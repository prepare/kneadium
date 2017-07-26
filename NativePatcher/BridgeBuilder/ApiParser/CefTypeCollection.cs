//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
namespace BridgeBuilder
{
    class CefTypeCollection
    {
        internal Dictionary<string, CodeTypeDeclaration> typeDics = new Dictionary<string, CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> cefBaseTypes = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> cefImplTypes = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> otherTypes = new List<CodeTypeDeclaration>();

        //semantic
        internal Dictionary<string, TypeSymbol> typeSymbols = new Dictionary<string, TypeSymbol>();
        internal Dictionary<string, TypeSymbol> baseCToCppTypeSymbols = new Dictionary<string, TypeSymbol>();
        internal Dictionary<string, TypeSymbol> unknownTypes = new Dictionary<string, TypeSymbol>();
        //-----------



        //------------
        //classification
        internal List<CodeTypeDeclaration> callBackClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> handlerClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> cToCppClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> cppToCClasses = new List<CodeTypeDeclaration>();
        internal List<CodeTypeDeclaration> otherClasses = new List<CodeTypeDeclaration>();
        //------------

        internal List<CodeCompilationUnit> compilationUnits;
        internal Dictionary<TypeSymbol, TypeHierarchyNode> hierarchy;

        void Reset()
        {
            typeDics.Clear();
            cefBaseTypes.Clear();
            cefImplTypes.Clear();
            otherTypes.Clear();
            typeSymbols.Clear();

            //--------------------------
            callBackClasses.Clear();
            handlerClasses.Clear();
            cToCppClasses.Clear();
            cppToCClasses.Clear();
            otherClasses.Clear();

            //--------------------------
            hierarchy = new Dictionary<TypeSymbol, TypeHierarchyNode>();

            //prebuild types & manual added types
            TypeSymbol[] prebuiltTypes = new TypeSymbol[]{


                new SimpleType("void"),
                new SimpleType("bool"),
                new SimpleType("char"),
                new SimpleType("int"),
                new SimpleType("int32"),new SimpleType("uint32"),
                new SimpleType("int64"),new SimpleType("uint64"),
                new SimpleType("double"),
                new SimpleType("size_t"),

                new SimpleType("string"),
                new SimpleType("CefString"),
                new SimpleType("CefBase"),
                //TODO: review
                //temp add here, to be review again
                new SimpleType("CefProcessId"), //typedef cef_process_id_t CefProcessId;
                new SimpleType("CefThreadId"), //typedef cef_thread_id_t CefThreadId;
                new SimpleType("CefBrowserSettings"),// typedef CefStructBase<CefBrowserSettingsTraits> CefBrowserSettings;
                new SimpleType("Handler")

            };

            foreach (SimpleType typeSymbol in prebuiltTypes)
            {
                typeSymbols.Add(typeSymbol.Name, typeSymbol);
            }
            //--------------------------
        }
        public void CollectAllTypeDefinitions(List<CodeCompilationUnit> compilationUnits)
        {

            Reset();
            //-----------------------
            this.compilationUnits = compilationUnits;
            //1. collect
            foreach (CodeCompilationUnit cu in compilationUnits)
            {
                foreach (CodeTypeDeclaration typeDecl in cu.Members)
                {
                    if (!typeDecl.IsForwardDecl && typeDecl.Name != null)
                    {
                        if (typeDics.ContainsKey(typeDecl.Name))
                        {
                            throw new Exception("duplicated key " + typeDecl.Name);
                        }
                        typeDics.Add(typeDecl.Name, typeDecl);
                        //-----------------------
                        SimpleType typeSymbol = new SimpleType(typeDecl.Name);
                        typeSymbol.CreatedByTypeDeclaration = typeDecl;
                        typeDecl.ResolvedType = typeSymbol;
                        typeSymbols.Add(typeSymbol.Name, typeSymbol);
                        //-----------------------
                    }
                }
            }
            ResolveBaseTypes();
             
            ResolveBaseTypeMembers();

            //-----------------------
            //do class classification 
            foreach (CodeTypeDeclaration t in typeDics.Values)
            {
                string name = t.Name;
                if (name.EndsWith("Callback"))
                {
                    callBackClasses.Add(t);
                }
                else if (name.EndsWith("Handler"))
                {
                    handlerClasses.Add(t);
                }
                else if (name.EndsWith("CToCpp"))
                {
                    cToCppClasses.Add(t);
                }
                else if (name.EndsWith("CppToC"))
                {
                    cppToCClasses.Add(t);
                }
                else
                {
                    otherClasses.Add(t);
                }
            }
            //-----------------------
            //for analysis

            foreach (CodeTypeDeclaration t in typeDics.Values)
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


        void ResolveBaseTypes()
        {
            //-----------------------
            //2. resolve allbase type
            foreach (CodeTypeDeclaration typedecl in typeDics.Values)
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
                        baseType.ResolvedType = ResolveType(baseType);
                    }
                }
            }
            //----------------------- 
        } 
        void ResolveBaseTypeMembers()
        {
            foreach (CodeTypeDeclaration typedecl in typeDics.Values)
            {
                foreach (CodeMemberDeclaration mbDecl in typedecl.Members)
                {
                    switch (mbDecl.MemberKind)
                    {
                        case CodeMemberKind.Method:
                            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)mbDecl;
                            if (metDecl.MethodKind == MethodKind.Normal)
                            {
                                //resolve return type and type parameter
                                metDecl.ReturnType.ResolvedType = ResolveType(metDecl.ReturnType);
                                foreach (var p in metDecl.Parameters)
                                {
                                    p.ParameterType.ResolvedType = ResolveType(p.ParameterType);
                                }
                            }
                            else
                            {
                                //this version, we skip 
                            }
                            break;
                        case CodeMemberKind.Type:
                            //sub type
                            break;
                        case CodeMemberKind.TypeDef:
                            break;
                        case CodeMemberKind.Field:
                            //skip ?
                            break;
                        default:
                            throw new NotSupportedException();
                    }
                }
            }
        }
        TypeSymbol RegisterBaseCToCppTypeSymbol(CodeTypeReference cToCppTypeReference)
        {

            TypeSymbol found;
            if (!baseCToCppTypeSymbols.TryGetValue(cToCppTypeReference.Name, out found))
            {
                //if not found then create the new simple type
                found = new SimpleType(cToCppTypeReference.Name);
                baseCToCppTypeSymbols.Add(cToCppTypeReference.Name, found);
            }
            return cToCppTypeReference.ResolvedType = found;
        }
        TypeSymbol ResolveType(CodeTypeReference typeRef)
        {
            //recursive
            switch (typeRef.Kind)
            {
                case CodeTypeReferenceKind.Simple:
                    {
                        var simpleBase = (CodeSimpleTypeReference)typeRef;
                        return ResolveType(simpleBase.Name);
                    }
                case CodeTypeReferenceKind.QualifiedName:
                    {
                        var qnameType = (CodeQualifiedNameType)typeRef;
                        switch (qnameType.Name)
                        {
                            //resolve wellknown type template   
                            case "base": return ResolveType(qnameType.RightPart);
                            case "std": return ResolveType(qnameType.RightPart);

                            //eg. nest or ns type

                            case "CefXmlReader":
                            case "ProviderEntryList": return ResolveType(qnameType.RightPart);
                            default:
                                throw new NotSupportedException();
                        }
                    }
                case CodeTypeReferenceKind.TypeTemplate:
                    {
                        //resolve wellknown type template   
                        var typeTemplate = (CodeTypeTemplateTypeReference)typeRef;
                        string templateName = typeTemplate.Name;
                        switch (typeTemplate.Name)
                        {
                            default:
                                throw new NotSupportedException();
                            case "CefCppToCScoped":
                            case "CefCppToCRefCounted":
                                {
                                    //cpp to c
                                    if (typeTemplate.Items.Count == 3)
                                    {
                                        //auto add native c/c++ type

                                        //
                                        TemplateType3 t3 = new TemplateType3(typeTemplate.Name);
                                        t3.Item1 = ResolveType(typeTemplate.Items[1]);
                                        t3.Item2 = RegisterBaseCToCppTypeSymbol(typeTemplate.Items[2]);
                                        return t3;
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
                                        TemplateType3 t3 = new TemplateType3(typeTemplate.Name);
                                        t3.Item1 = ResolveType(typeTemplate.Items[1]);
                                        t3.Item2 = RegisterBaseCToCppTypeSymbol(typeTemplate.Items[2]);
                                        return t3;

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
                                            return ResolveType(typeTemplate.Items[0]);
                                        case 2:
                                            // from cef c api , 
                                            //template <class T, typename Traits = DefaultRefCountedThreadSafeTraits<T> >
                                            return ResolveType(typeTemplate.Items[0]);

                                        default:
                                            throw new NotSupportedException();
                                    }
                                }
                            case "CefRefPtr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return new ReferenceOrPointerTypeSymbol(ResolveType(typeTemplate.Items[0]), ContainerTypeKind.CefRefPtr);
                                    }
                                    throw new NotSupportedException();
                                }
                            case "CefRawPtr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return new ReferenceOrPointerTypeSymbol(ResolveType(typeTemplate.Items[0]), ContainerTypeKind.CefRefPtr);
                                    }
                                    throw new NotSupportedException();
                                }
                            case "scoped_ptr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return new ReferenceOrPointerTypeSymbol(ResolveType(typeTemplate.Items[0]), ContainerTypeKind.ScopePtr);
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
                                        return new VecTypeSymbol(ResolveType(typeTemplate.Items[0]));
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
                        return new ReferenceOrPointerTypeSymbol(elementType, ContainerTypeKind.Pointer);
                    }
                case CodeTypeReferenceKind.ByRef:
                    {
                        var byRefType = (CodeByRefTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(byRefType.ElementType);
                        return new ReferenceOrPointerTypeSymbol(elementType, ContainerTypeKind.ByRef);
                    }
                default:
                    {
                        throw new NotSupportedException();
                    }
            }
        }
        TypeSymbol ResolveType(string typename)
        {
            CodeTypeDeclaration baseTypeFound;
            if (typeDics.TryGetValue(typename, out baseTypeFound))
            {
                return baseTypeFound.ResolvedType;
            }
            else
            {
                TypeSymbol foundSymbol;
                if (typeSymbols.TryGetValue(typename, out foundSymbol))
                {
                    return foundSymbol;
                }
                if (baseCToCppTypeSymbols.TryGetValue(typename, out foundSymbol))
                {
                    return foundSymbol;
                }

                //this is convention 
                if (typename.StartsWith("cef_") && IsAllLowerLetter(typename))
                {
                    //assume this is base c/cpp type
                    foundSymbol = new SimpleType(typename);
                    baseCToCppTypeSymbols.Add(
                        typename,
                        foundSymbol);
                    return foundSymbol;
                }

                if (!unknownTypes.TryGetValue(typename, out foundSymbol))
                {
                    foundSymbol = new SimpleType(typename);
                    unknownTypes.Add(typename, foundSymbol);
                    return foundSymbol;
                }
                return foundSymbol;
            }

        }
        public bool TryGetTypeDeclaration(string typeName, out CodeTypeDeclaration found)
        {
            return typeDics.TryGetValue(typeName, out found);
        }
        static bool IsAllLowerLetter(string name)
        {

            for (int i = name.Length - 1; i >= 0; --i)
            {
                char c = name[i];
                if (!((c >= 'a' && c <= 'z') || c == '_'))
                {
                    return false;
                }
            }
            return true;
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