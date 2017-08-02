//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
namespace BridgeBuilder
{
    enum ResolvingContextKind
    {
        Base,
        MethodParReturnType,
        MethodPar
    }
    struct CefResolvingContext
    {
        public readonly CefTypeCollection _typeCollection;
        public readonly CodeTypeDeclaration _currentResolvingType;
        public readonly ResolvingContextKind contextKind;
        public CefResolvingContext(CefTypeCollection typeCollection, CodeTypeDeclaration currentResolvingType, ResolvingContextKind contextKind)
        {
            this._typeCollection = typeCollection;
            this.contextKind = contextKind;
            this._currentResolvingType = currentResolvingType;
        }
        public TypeSymbol ResolveType(CodeTypeReference typeRef)
        {
            if (typeRef.ResolvedType != null)
            {
                return typeRef.ResolvedType;
            }
            //recursive
            switch (typeRef.Kind)
            {
                case CodeTypeReferenceKind.Simple:
                    {
                        var simpleBase = (CodeSimpleTypeReference)typeRef;
                        return typeRef.ResolvedType = ResolveType(simpleBase.Name);
                    }
                case CodeTypeReferenceKind.QualifiedName:
                    {
                        var qnameType = (CodeQualifiedNameType)typeRef;
                        switch (qnameType.LeftPart.ToString())
                        {
                            //resolve wellknown type template    
                            case "std":
                                return ResolveType(qnameType.RightPart);
                            default:
                                {
                                    if (_currentResolvingType != null &&
                                        _currentResolvingType.TemplateNotation != null)
                                    {
                                        //search ns from template notation

                                        CodeTemplateParameter foundTemplatePar = null;
                                        if (_currentResolvingType.TemplateNotation.TryGetTemplateParByParameterName(qnameType.LeftPart.ToString(), out foundTemplatePar))
                                        {
                                            //TODO: resolve template type parameter
                                            return (typeRef.ResolvedType = new TemplateParameterTypeSymbol(foundTemplatePar));
                                        }
                                    }
                                    //--
                                    TypeSymbol found;
                                    if (_typeCollection.TryGetType(typeRef.ToString(), out found))
                                    {
                                        return found;
                                    }
                                    throw new NotSupportedException();
                                }

                        }
                    }
                case CodeTypeReferenceKind.TypeTemplate:
                    {
                        //resolve wellknown type template   
                        var typeTemplate = (CodeTypeTemplateTypeReference)typeRef;
                        string templateName = typeTemplate.Name;
                        //this version => just switch by name first
                        //TODO: switch by num of template item
                        switch (typeTemplate.Name)
                        {
                            default:
                                throw new NotSupportedException();
                            case "CefOwnPtr":
                            case "CefStructBase":
                                {

                                    TypeSymbol resolve1 = ResolveType(typeTemplate.Items[0]);
                                    TemplateTypeSymbol1 t1 = new TemplateTypeSymbol1(typeTemplate.Name);
                                    t1.Item0 = resolve1;
                                    return typeRef.ResolvedType = t1;
                                }
                            case "multimap":
                            case "map":
                                {
                                    TemplateTypeSymbol2 t2 = new TemplateTypeSymbol2(typeTemplate.Name);
                                    t2.Item0 = ResolveType(typeTemplate.Items[0]);
                                    t2.Item1 = ResolveType(typeTemplate.Items[1]);
                                    return typeRef.ResolvedType = t2;
                                }
                            case "CefCppToCScoped":
                            case "CefCppToCRefCounted":
                                {
                                    //cpp to c
                                    if (typeTemplate.Items.Count == 3)
                                    {
                                        //auto add native c/c++ type 
                                        TemplateTypeSymbol3 t3 = new TemplateTypeSymbol3(typeTemplate.Name);
                                        t3.Item1 = ResolveType(typeTemplate.Items[1]);
                                        t3.Item2 = this._typeCollection.RegisterBaseCToCppTypeSymbol(typeTemplate.Items[2]);
                                        return typeRef.ResolvedType = t3;
                                    }
                                    else
                                    {
                                        throw new NotSupportedException();
                                    }
                                }
                            case "CefCToCppScoped":
                            case "CefCToCppRefCounted":
                            case "CefCToCpp":
                                {
                                    //c to cpp
                                    if (typeTemplate.Items.Count == 3)
                                    {
                                        //auto add native c/c++ type
                                        TemplateTypeSymbol3 t3 = new TemplateTypeSymbol3(typeTemplate.Name);
                                        t3.Item1 = ResolveType(typeTemplate.Items[1]);
                                        t3.Item2 = this._typeCollection.RegisterBaseCToCppTypeSymbol(typeTemplate.Items[2]);
                                        return typeRef.ResolvedType = t3;

                                    }
                                    else
                                    {
                                        throw new NotSupportedException();
                                    }
                                }
                            case "RefCountedThreadSafe":
                                {
                                    switch (typeTemplate.Items.Count)
                                    {
                                        case 1:
                                            return typeRef.ResolvedType = ResolveType(typeTemplate.Items[0]);
                                        case 2:
                                            // from cef c api , 
                                            //template <class T, typename Traits = DefaultRefCountedThreadSafeTraits<T> >
                                            return typeRef.ResolvedType = ResolveType(typeTemplate.Items[0]);

                                        default:
                                            throw new NotSupportedException();
                                    }
                                }
                            case "CefRefPtr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return typeRef.ResolvedType = new ReferenceOrPointerTypeSymbol(ResolveType(typeTemplate.Items[0]), ContainerTypeKind.CefRefPtr);
                                    }
                                    throw new NotSupportedException();
                                }
                            case "CefRawPtr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return typeRef.ResolvedType = new ReferenceOrPointerTypeSymbol(ResolveType(typeTemplate.Items[0]), ContainerTypeKind.CefRefPtr);
                                    }
                                    throw new NotSupportedException();
                                }
                            case "scoped_ptr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return typeRef.ResolvedType = new ReferenceOrPointerTypeSymbol(ResolveType(typeTemplate.Items[0]), ContainerTypeKind.ScopePtr);
                                    }
                                    else
                                    {
                                        throw new NotSupportedException();
                                    }
                                }
                            case "vector":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return typeRef.ResolvedType = new VecTypeSymbol(ResolveType(typeTemplate.Items[0]));
                                    }
                                    else
                                    {
                                        throw new NotSupportedException();
                                    }
                                }

                        }

                    }
                case CodeTypeReferenceKind.Pointer:
                    {
                        var pointerType = (CodePointerTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(pointerType.ElementType);
                        return typeRef.ResolvedType = new ReferenceOrPointerTypeSymbol(elementType, ContainerTypeKind.Pointer);
                    }
                case CodeTypeReferenceKind.ByRef:
                    {
                        var byRefType = (CodeByRefTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(byRefType.ElementType);
                        return typeRef.ResolvedType = new ReferenceOrPointerTypeSymbol(elementType, ContainerTypeKind.ByRef);
                    }
                default:
                    {
                        throw new NotSupportedException();
                    }
            }
        }

        TypeSymbol ResolveType(string typename)
        {
            TypeSymbol foundSymbol = null;
            if (_currentResolvingType != null)
            {
                //1. 
                if (_currentResolvingType.IsTemplateTypeDefinition)
                {

                    //
                    //check if this is the template type parameter
                    //if (typename == _currentResolvingType.TemplateNotation.templatePar.ReAssignToTypeName)
                    //{   //found
                    //    return new TemplateParameterTypeSymbol(_currentResolvingType.TemplateNotation.templatePar);
                    //}
                    CodeTemplateParameter foundTemplatePar = null;
                    if (_currentResolvingType.TemplateNotation.TryGetTemplateParByReAssignToName(typename, out foundTemplatePar))
                    {
                        //TODO: resolve template type parameter
                        return new TemplateParameterTypeSymbol(foundTemplatePar);
                    }

                    if (_currentResolvingType.TemplateNotation.TryGetTemplateParByParameterName(typename, out foundTemplatePar))
                    {
                        //TODO: resolve template type parameter
                        return new TemplateParameterTypeSymbol(foundTemplatePar);
                    }
                }


                //2.
                //search nest type
                //TODO: review here -> use field                
                if (_currentResolvingType.HasSubType)
                {
                    List<CodeMemberDeclaration> tempResults = new List<CodeMemberDeclaration>();
                    int foundCount;
                    if ((foundCount = _currentResolvingType.FindSubType(typename, tempResults)) > 0)
                    {
                        for (int i = 0; i < foundCount; ++i)
                        {
                            CodeMemberDeclaration subtype = tempResults[i];
                            switch (subtype.MemberKind)
                            {
                                default: throw new NotSupportedException();
                                case CodeMemberKind.Type:
                                    break;
                                case CodeMemberKind.TypeDef:
                                    {
                                        CodeCTypeDef ctypedef = (CodeCTypeDef)subtype;
                                        TypeSymbol resolveFromType = ResolveType(ctypedef.From);
                                        if (resolveFromType != null)
                                        {
                                            //found
                                            return resolveFromType;
                                        }
                                    }
                                    break;
                            }

                        }
                    }
                }
                //3 
                if (_currentResolvingType.BaseTypes != null)
                {
                    //check if we need to search in other scopes
                    int baseCount = _currentResolvingType.BaseTypes.Count;
                    //we get only 1 base count
                    if (baseCount > 0)
                    {
                        if ((foundSymbol = SearchFromFirstBase(_currentResolvingType.BaseTypes[0] as CodeTypeTemplateTypeReference, typename)) != null)
                        {
                            return foundSymbol;
                        }
                    }
                }
            }



            //-------

            if (this._typeCollection.TryGetType(typename, out foundSymbol))
            {
                return foundSymbol;
            }

            //this is convention 
            if (typename.StartsWith("cef_") && IsAllLowerLetter(typename))
            {
                //assume this is base c/cpp type
                foundSymbol = new SimpleTypeSymbol(typename);
                this._typeCollection.RegisterType(
                    typename,
                    foundSymbol);
                return foundSymbol;
            }

            //not found
            return foundSymbol;
        }
        internal static bool IsAllLowerLetter(string name)
        {
            for (int i = name.Length - 1; i >= 0; --i)
            {
                char c = name[i];
                if (!((c >= 'a' && c <= 'z') || c == '_' || char.IsNumber(c)))
                {
                    return false;
                }
            }
            return true;
        }




        TypeSymbol SearchFromFirstBase(CodeTypeTemplateTypeReference firstBase, string typename)
        {
            if (firstBase == null)
            {
                return null;
            }

            CodeTypeTemplateTypeReference templateTypeRef = (CodeTypeTemplateTypeReference)firstBase;
            //-----------
            //first base is not resolve 
            switch (templateTypeRef.Items.Count)
            {
                case 3:
                    {
                        //we accept only known template name

                        switch (firstBase.Name)
                        {
                            default:


                                break;
                            case "CefCppToCScoped":
                            case "CefCppToCRefCounted":
                            //
                            case "CefCToCppRefCounted":
                            case "CefCToCppScoped":
                                {
                                    //c-to-cpp
                                    //search in another scope item2 
                                    CodeTypeReference typeRef1 = templateTypeRef.Items[1];
                                    if (typeRef1.Name == typename)
                                    {
                                        TypeSymbol foundSymbol1;
                                        if (this._typeCollection.TryGetType(typename, out foundSymbol1))
                                        {
                                            return foundSymbol1;
                                        }
                                    }
                                    else
                                    {

                                    }

                                    TemplateTypeSymbol3 t3 = (TemplateTypeSymbol3)templateTypeRef.ResolvedType;
                                    TypeSymbol t1 = t3.Item1;
                                    //
                                    switch (t1.TypeSymbolKind)
                                    {
                                        default:
                                            break;
                                        case TypeSymbolKind.Simple:
                                            {
                                                SimpleTypeSymbol s = (SimpleTypeSymbol)t1;
                                                //check nested type

                                                if (s.NestedTypeSymbols != null)
                                                {
                                                    int nestedTypeCount = s.NestedTypeSymbols.Count;
                                                    for (int n = 0; n < nestedTypeCount; ++n)
                                                    {
                                                        TypeSymbol nestedType = s.NestedTypeSymbols[n];
                                                        switch (nestedType.TypeSymbolKind)
                                                        {
                                                            case TypeSymbolKind.Simple:
                                                                {

                                                                }
                                                                break;
                                                            case TypeSymbolKind.TypeDef:
                                                                {
                                                                    CTypeDefTypeSymbol cTypeDef = (CTypeDefTypeSymbol)nestedType;
                                                                    if (cTypeDef.Name == typename)
                                                                    {
                                                                        //found
                                                                        return cTypeDef;
                                                                    }
                                                                }
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                    }
                                                }
                                            }
                                            break;

                                    }

                                }
                                break;
                        }
                    }
                    break;

            }
            return null;
        }
    }




    class CefTypeCollection
    {
        internal Dictionary<string, CodeTypeDeclaration> typedeclDic = new Dictionary<string, CodeTypeDeclaration>();



        //semantic
        Dictionary<string, TypeSymbol> typeSymbols = new Dictionary<string, TypeSymbol>();

        //------------
        //note from cef-3
        //@prepare,
        // inside the Chromium lib, it is C++ environment
        // so: ...
        //1. If you want to export some object to outside( user lib), then you need to wrap it with C structure and send it out
        //
        //  [chrome]  cpp->to->c  ---> ::::: ---> c-interface-to [external-user-lib] ....
        //
        //2. If yout receive some object from outside(user lib), it is sent as C  object, then you need to wrap it with C++ structure.                  
        //
        //  [chrome]  cpp<-to<-c  <--- ::::: <--- c-interface-to [external-user-lib] ....
        //
        //------------


        // cpp-to-c :Wrap a C++ class with a C structure. This is used when the class
        // implementation exists on this side of the DLL boundary but will have methods
        // called from the other side of the DLL boundary.
        // 

        // c-to-cpp: Wrap a C structure with a C++ class.  This is used when the implementation
        // exists on the other side of the DLL boundary but will have methods called on
        // this side of the DLL boundary  



        //classification (after all type symbols are created)        
        /// <summary>
        ///  [chrome]  cpp->to->c  ---> ::::: ---> c-interface-to [external-user-lib] ....
        /// </summary>
        internal List<CodeTypeDeclaration> cppToCClasses = new List<CodeTypeDeclaration>();
        /// <summary>
        /// [chrome]  cpp&lt;-to&lt;-c  &lt;--- ::::: &lt;--- c-interface-to [external-user-lib] ....
        /// </summary>
        internal List<CodeTypeDeclaration> cToCppClasses = new List<CodeTypeDeclaration>();

        //------------
        internal List<CodeTypeDeclaration> _v_instanceClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _v_callBackClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _v_handlerClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _enumClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _plainCStructs = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _fileModuleClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _templateClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> _cefBaseTypes = new List<CodeTypeDeclaration>();
        //------------

        List<CodeCompilationUnit> compilationUnits;
        Dictionary<string, CodeCompilationUnit> _compilationUnitDics = new Dictionary<string, CodeCompilationUnit>();

        internal Dictionary<TypeSymbol, TypeHierarchyNode> hierarchy;

        bool _freeze;
        internal void Freeze()
        {
            _freeze = true;
        }

        void Reset()
        {
            _freeze = false;
            typedeclDic.Clear();
            typeSymbols.Clear();

            //--------------------------
            _v_callBackClasses.Clear();
            _v_handlerClasses.Clear();
            _v_instanceClasses.Clear();
            _cefBaseTypes.Clear();
            _enumClasses.Clear();
            _plainCStructs.Clear();
            _fileModuleClasses.Clear();
            _templateClasses.Clear();

            cToCppClasses.Clear();
            cppToCClasses.Clear();
            //--------------------------
            _compilationUnitDics.Clear();
            //--------------------------
            hierarchy = new Dictionary<TypeSymbol, TypeHierarchyNode>();

            //prebuild types & manual added types
            TypeSymbol[] prebuiltTypes = new TypeSymbol[]{

                //-----------------------------------------

                new SimpleTypeSymbol("void"){PrimitiveTypeKind = PrimitiveTypeKind.Void },
                new SimpleTypeSymbol("bool"){PrimitiveTypeKind = PrimitiveTypeKind.Bool },
                new SimpleTypeSymbol("char"){PrimitiveTypeKind = PrimitiveTypeKind.Char },
                new SimpleTypeSymbol("int"){PrimitiveTypeKind = PrimitiveTypeKind.NaitveInt },//TODO: review here
                new SimpleTypeSymbol("int32"){PrimitiveTypeKind = PrimitiveTypeKind.Int32 },
                new SimpleTypeSymbol("uint32"){PrimitiveTypeKind = PrimitiveTypeKind.UInt32 },
                new SimpleTypeSymbol("int64"){PrimitiveTypeKind = PrimitiveTypeKind.Int64 },
                new SimpleTypeSymbol("uint64"){PrimitiveTypeKind = PrimitiveTypeKind.UInt64 },
                new SimpleTypeSymbol("double"){PrimitiveTypeKind = PrimitiveTypeKind.Double },
                new SimpleTypeSymbol("float"){PrimitiveTypeKind = PrimitiveTypeKind.Float },
                new SimpleTypeSymbol("size_t"){PrimitiveTypeKind = PrimitiveTypeKind.size_t },
                //
                new SimpleTypeSymbol("string"){PrimitiveTypeKind = PrimitiveTypeKind.String },
                new SimpleTypeSymbol("CefString"){PrimitiveTypeKind = PrimitiveTypeKind.CefString },
                //
                new SimpleTypeSymbol("time_t"),
                new SimpleTypeSymbol("HINSTANCE"),
                //TODO: review              
                new SimpleTypeSymbol("Handler"),
                new SimpleTypeSymbol("RECT"),
                new CTypeDefTypeSymbol("CefWindowHandle",new CodeSimpleTypeReference("cef_window_handle_t")),
                new CTypeDefTypeSymbol("CefCursorHandle",new CodeSimpleTypeReference("cef_cursor_handle_t")),
                new CTypeDefTypeSymbol("CefEventHandle",new CodeSimpleTypeReference("cef_event_handle_t")),
            };

            foreach (TypeSymbol typeSymbol in prebuiltTypes)
            {
                switch (typeSymbol.TypeSymbolKind)
                {
                    default: throw new NotSupportedException();
                    case TypeSymbolKind.Simple:
                        RegisterType(((SimpleTypeSymbol)typeSymbol).Name, typeSymbol);
                        break;
                    case TypeSymbolKind.TypeDef:
                        RegisterType(((CTypeDefTypeSymbol)typeSymbol).Name, typeSymbol);
                        break;
                }

            }
            //--------------------------
        }
        public void RegisterType(string typeName, TypeSymbol tt)
        {
            if (_freeze)
            {
                if (!(typeName.StartsWith("cef_") && CefResolvingContext.IsAllLowerLetter(typeName)))
                {
                    Console.WriteLine(typeName);
                }
                else
                {
                    //for cef only!

                }
            }
            typeSymbols.Add(typeName, tt);
        }
        public bool TryGetType(string typeName, out TypeSymbol tt)
        {
            return this.typeSymbols.TryGetValue(typeName, out tt);
        }
        public string RootFolder { get; set; }
        public CefTypeBridgeTransformPlanner Planner { get; set; }
        public void SetTypeSystem(List<CodeCompilationUnit> compilationUnits)
        {

            Reset();
            //-----------------------
            this.compilationUnits = compilationUnits;
            //-----------------------
            //resolve cu's file path

            foreach (CodeCompilationUnit cu in compilationUnits)
            {
                //check absolute path for include file                  
                foreach (IncludeFileDirective includeDirective in cu._includeFiles)
                {
                    //remove " from begin and end of the original IncludeFile 
                    if (includeDirective.SystemFolder)
                    {
                        continue;
                    }
                    // 
                    string include_file = includeDirective.IncludeFile.Substring(1, includeDirective.IncludeFile.Length - 2);
                    includeDirective.ResolvedAbsoluteFilePath = RootFolder + "\\" + include_file;
                    //check 
                    if (!System.IO.File.Exists(includeDirective.ResolvedAbsoluteFilePath))
                    {
                        //file not found
                        if (!(includeDirective.ResolvedAbsoluteFilePath.EndsWith("mac.h") ||
                            includeDirective.ResolvedAbsoluteFilePath.EndsWith("linux.h")))
                        {
                            throw new NotSupportedException();
                        }
                    }
                }
                //
                _compilationUnitDics.Add(cu.Filename, cu);
            }


            List<CodeMethodDeclaration> cppMethodList = new List<CodeMethodDeclaration>();

            //-----------------------
            //1. collect
            foreach (CodeCompilationUnit cu in compilationUnits)
            {
                //
                RegisterTypeDeclaration(cu.GlobalTypeDecl);
                //extract type from global typedecl
                foreach (CodeMemberDeclaration mb in cu.GlobalTypeDecl.GetMemberIter())
                {
                    switch (mb.MemberKind)
                    {
                        case CodeMemberKind.Method:
                            {
                                //check if this method has C++ explicit ower type
                                CodeMethodDeclaration metDecl = (CodeMethodDeclaration)mb;
                                if (metDecl.CppExplicitOwnerType != null)
                                {
                                    //add this to typedecl later
                                    cppMethodList.Add(metDecl);
                                }
                            }
                            break;
                        case CodeMemberKind.TypeDef:
                            {
                                CodeCTypeDef ctypeDef = (CodeCTypeDef)mb;
                                // 
                                CTypeDefTypeSymbol ctypedefTypeSymbol = new CTypeDefTypeSymbol(ctypeDef.Name, ctypeDef.From);
                                ctypedefTypeSymbol.CreatedTypeCTypeDef = ctypeDef;
                                //---

                                TypeSymbol existing;
                                if (TryGetType(ctypeDef.Name, out existing))
                                {
                                    throw new NotSupportedException();
                                }
                                RegisterType(ctypeDef.Name, ctypedefTypeSymbol);
                            }
                            break;
                        case CodeMemberKind.Type:
                            {
                                RegisterTypeDeclaration((CodeTypeDeclaration)mb);
                            }
                            break;
                    }
                }

                int typeCount = cu.TypeCount;
                for (int i = 0; i < typeCount; ++i)
                {
                    RegisterTypeDeclaration(cu.GetTypeDeclaration(i));
                }
            }
            //-----------------------
            if (cppMethodList.Count > 0)
            {
                //find owner and add the implementation

            }
            //-----------------------
            ResolveBaseTypes();
            ResolveTypeMembers();
            //-----------------------

            AddMoreTypeInfo();
            //
            var cefTypeBridgeTxPlanner = new CefTypeBridgeTransformPlanner();
            cefTypeBridgeTxPlanner.AssignTypeBridgeInfo(this.typeSymbols);
            //
            this.Planner = cefTypeBridgeTxPlanner;

            //-----------------------
            //do class classification 


            foreach (CodeTypeDeclaration t in typedeclDic.Values)
            {
                string name = t.Name;
                if (name.EndsWith("Callback"))
                {
                    _v_callBackClasses.Add(t);
                }
                else if (name.EndsWith("Handler"))
                {
                    _v_handlerClasses.Add(t);
                }
                else if (name.EndsWith("CToCpp"))
                {
                    //implementation
                    cToCppClasses.Add(t);
                }
                else if (name.EndsWith("CppToC"))
                {
                    //implementation
                    cppToCClasses.Add(t);
                }
                else
                {
                    switch (t.Kind)
                    {
                        default:
                            {
                                if (t.IsGlobalCompilationUnitType)
                                {
                                    _fileModuleClasses.Add(t);
                                }
                                else if (t.IsTemplateTypeDefinition)
                                {
                                    _templateClasses.Add(t);
                                }
                                else if (t.BaseIsVirtual)
                                {
                                    _v_instanceClasses.Add(t);
                                }
                                else
                                {
                                    if (t.BaseTypes != null && t.BaseTypes.Count > 0)
                                    {
                                        CodeTypeReference baseType = t.BaseTypes[0];
                                        if (baseType.ResolvedType != null)
                                        {
                                            switch (baseType.Name)
                                            {
                                                default:

                                                    break;
                                                case "CefStructBase":
                                                case "CefBaseScoped":
                                                case "CefBaseRefCounted":
                                                    _cefBaseTypes.Add(t);
                                                    break;
                                            }
                                        }
                                    }
                                    else if (t.Name == "CefScopedSandboxInfo")
                                    {
                                        //no base class
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            break;
                        case TypeKind.Enum:
                            if (!CefResolvingContext.IsAllLowerLetter(name))
                            {

                            }
                            _enumClasses.Add(t);
                            break;
                        case TypeKind.Struct:
                            if (!CefResolvingContext.IsAllLowerLetter(name))
                            {
                                if (name.EndsWith("Traits"))
                                {

                                }
                                else
                                {

                                }
                            }
                            _plainCStructs.Add(t);
                            break;

                    }

                }
            }
            //-----------------------
            //for analysis

            foreach (CodeTypeDeclaration t in typedeclDic.Values)
            {
                TypeSymbol resolvedType = t.ResolvedType;
                if (t.BaseTypes.Count == 0)
                {
                    //
                }
                else
                {
                    TypeSymbol baseType = t.BaseTypes[0].ResolvedType;
                    TypeHierarchyNode found;
                    if (!hierarchy.TryGetValue(baseType, out found))
                    {
                        found = new TypeHierarchyNode(baseType);
                        hierarchy.Add(baseType, found);
                    }

                    if (found.Type != resolvedType)
                    {
                        found.AddTypeSymbol(resolvedType);
                    }
                }
            }
            //----------------------- 
        }


        void RegisterTypeDeclaration(CodeTypeDeclaration typeDecl)
        {
            //1. collect

            if (typeDecl.IsGlobalCompilationUnitType)
            {
                //this is global type                        
                if (typeDecl.MemberCount == 0)
                {
                    //skip this global type
                    return;
                }
            }

            if (!typeDecl.IsForwardDecl && typeDecl.Name != null)
            {
                CodeTypeDeclaration existingDecl;
                if (typedeclDic.TryGetValue(typeDecl.FullName, out existingDecl))
                {
                    //found  
                    throw new Exception("duplicated key " + typeDecl.Name);
                }

                typedeclDic.Add(typeDecl.FullName, typeDecl);
                //-----------------------

                SimpleTypeSymbol typeSymbol = new SimpleTypeSymbol(typeDecl);
                typeDecl.ResolvedType = typeSymbol;
                //

                TypeSymbol existingTypeSymbol;
                if (TryGetType(typeSymbol.Name, out existingTypeSymbol))
                {
                    //have existing value
                    throw new NotSupportedException();
                }
                else
                {
                    RegisterType(typeSymbol.Name, typeSymbol);
                }
                //
                //and sub types
                if (!typeDecl.IsGlobalCompilationUnitType)
                {
                    foreach (CodeMemberDeclaration subType in typeDecl.GetSubTypeIter())
                    {
                        if (subType.MemberKind == CodeMemberKind.TypeDef)
                        {

                            CodeCTypeDef ctypeDef = (CodeCTypeDef)subType;
                            //

                            CTypeDefTypeSymbol ctypedefTypeSymbol = new CTypeDefTypeSymbol(ctypeDef.Name, ctypeDef.From);
                            ctypedefTypeSymbol.CreatedTypeCTypeDef = ctypeDef;
                            ctypedefTypeSymbol.ParentType = typeSymbol;

                            //---                             
                            RegisterType(typeSymbol.Name + "." + ctypeDef.Name, ctypedefTypeSymbol);
                            List<TypeSymbol> nestedTypes = typeSymbol.NestedTypeSymbols;
                            if (nestedTypes == null)
                            {
                                typeSymbol.NestedTypeSymbols = nestedTypes = new List<TypeSymbol>();
                            }
                            nestedTypes.Add(ctypedefTypeSymbol);
                        }
                    }

                }

            }

        }

        void ResolveBaseTypes()
        {
            //2. resolve allbase type
            foreach (CodeTypeDeclaration typedecl in typedeclDic.Values)
            {
                //resolve base type
                List<CodeTypeReference> baseTypes = typedecl.BaseTypes;
                if (baseTypes.Count == 0)
                {
                    //eg. struct 
                }
                else
                {
                    foreach (CodeTypeReference baseType in baseTypes)
                    {
                        CefResolvingContext resolvingContext = new CefResolvingContext(this, typedecl, ResolvingContextKind.Base);
                        baseType.ResolvedType = resolvingContext.ResolveType(baseType);
                        if (baseType.ResolvedType == null)
                        {
                            throw new NotSupportedException();
                        }
                    }
                }
            }
        }
        void AddMoreTypeInfo()
        {

            //--------
            //copy all
            Freeze();
            //
            Dictionary<string, TypeSymbol> tempSymbols = new Dictionary<string, TypeSymbol>();
            int typeCount = typeSymbols.Count;
            foreach (var kp in typeSymbols)
            {
                tempSymbols.Add(kp.Key, kp.Value);
            }

            //Cef- find tune detail of base type
            foreach (TypeSymbol t in tempSymbols.Values)
            {
                switch (t.TypeSymbolKind)
                {
                    default:
                        throw new NotSupportedException();
                    case TypeSymbolKind.Simple:
                        {
                            SimpleTypeSymbol simpleType = (SimpleTypeSymbol)t;
                            if (simpleType.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                            {
                                //resolve base type
                                CodeTypeDeclaration typedecl = simpleType.CreatedByTypeDeclaration;
                                if (typedecl != null && typedecl.BaseTypes != null && typedecl.BaseTypes.Count > 0)
                                {
                                    CefResolvingContext ctx = new CefResolvingContext(this, null, ResolvingContextKind.Base);
                                    simpleType.BaseType = ctx.ResolveType(typedecl.BaseTypes[0]);
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        break;
                    case TypeSymbolKind.TypeDef:
                        {
                            CTypeDefTypeSymbol typedefSymbol = (CTypeDefTypeSymbol)t;
                            CefResolvingContext ctx = new CefResolvingContext(this, null, ResolvingContextKind.Base);
                            typedefSymbol.ReferToTypeSymbol = ctx.ResolveType(typedefSymbol.OriginalTypeDecl);
                        }
                        break;

                }
            }
            //-------
            //assign bridge information 
            //-------
            //swap
            this.typeSymbols = tempSymbols;
        }

        void ResolveTypeMembers()
        {
            foreach (CodeTypeDeclaration typedecl in typedeclDic.Values)
            {
                foreach (CodeMethodDeclaration metDecl in typedecl.GetMethodIter())
                {
                    //this version we resolve only method ***


                    switch (metDecl.MethodKind)
                    {
                        default: throw new NotSupportedException();
                        case MethodKind.Ctor:
                        case MethodKind.Dtor:
                            {
                                foreach (CodeMethodParameter p in metDecl.Parameters)
                                {
                                    CefResolvingContext resolvingContext = new CefResolvingContext(this, typedecl, ResolvingContextKind.MethodParReturnType);
                                    //
                                    p.ParameterType.ResolvedType = resolvingContext.ResolveType(p.ParameterType);
                                }
                            }
                            break;
                        case MethodKind.Normal:
                            {
                                //resolve return type and type parameter 
                                {
                                    CefResolvingContext resolvingContext = new CefResolvingContext(this, typedecl, ResolvingContextKind.MethodParReturnType);
                                    //
                                    metDecl.ReturnType.ResolvedType = resolvingContext.ResolveType(metDecl.ReturnType);
                                }


                                foreach (CodeMethodParameter p in metDecl.Parameters)
                                {
                                    CefResolvingContext resolvingContext = new CefResolvingContext(this, typedecl, ResolvingContextKind.MethodPar);
                                    //
                                    p.ParameterType.ResolvedType = resolvingContext.ResolveType(p.ParameterType);
                                }
                            }
                            break;
                    }

                }
            }

        }
        internal TypeSymbol RegisterBaseCToCppTypeSymbol(CodeTypeReference cToCppTypeReference)
        {

#if DEBUG
            if (!CefResolvingContext.IsAllLowerLetter(cToCppTypeReference.Name))
            {
                //cef-name convention
                throw new NotSupportedException();
            }
#endif
            TypeSymbol found;
            if (!typeSymbols.TryGetValue(cToCppTypeReference.Name, out found))
            {
                //if not found then create the new simple type
                found = new SimpleTypeSymbol(cToCppTypeReference.Name);
                RegisterType(cToCppTypeReference.Name, found);
            }
            return cToCppTypeReference.ResolvedType = found;
        }


    }
    class TypeHierarchyNode
    {
        List<TypeSymbol> children = new List<TypeSymbol>();
        public TypeHierarchyNode(TypeSymbol type)
        {
            this.Type = type;
        }
        public TypeSymbol Type { get; private set; }
        public void AddTypeSymbol(TypeSymbol c)
        {
            if (c == Type)
            {
                throw new Exception("cyclic!");
            }
            children.Add(c);
        }
    }

}