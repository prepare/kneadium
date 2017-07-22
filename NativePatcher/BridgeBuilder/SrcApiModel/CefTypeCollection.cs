//2016, MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace BridgeBuilder
{
    class CefTypeCollection
    {
        Dictionary<string, CodeTypeDeclaration> typeDics = new Dictionary<string, CodeTypeDeclaration>();
        List<CodeTypeDeclaration> cefBaseTypes = new List<CodeTypeDeclaration>();
        List<CodeTypeDeclaration> cefImplTypes = new List<CodeTypeDeclaration>();
        List<CodeTypeDeclaration> otherTypes = new List<CodeTypeDeclaration>();

        //semantic
        Dictionary<string, TypeSymbol> typeSymbols = new Dictionary<string, TypeSymbol>();
        Dictionary<string, TypeSymbol> baseCCppTypeSymbols = new Dictionary<string, TypeSymbol>();
        Dictionary<string, TypeSymbol> unknownTypes = new Dictionary<string, TypeSymbol>();

        void Reset()
        {
            typeDics.Clear();
            cefBaseTypes.Clear();
            cefImplTypes.Clear();
            otherTypes.Clear();
            typeSymbols.Clear();

            //--------------------------
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
            List<CodeTypeDeclaration> callBackClasses = new List<CodeTypeDeclaration>();
            List<CodeTypeDeclaration> handlerClasses = new List<CodeTypeDeclaration>();
            List<CodeTypeDeclaration> cppImplClasses = new List<CodeTypeDeclaration>();
            List<CodeTypeDeclaration> otherClasses = new List<CodeTypeDeclaration>();

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
                    cppImplClasses.Add(t);
                }
                else
                {
                    otherClasses.Add(t);
                }
            }
            //-----------------------
            //for analysis
            Dictionary<TypeSymbol, TypeHeirarchyNode> hierarchy = new Dictionary<TypeSymbol, TypeHeirarchyNode>();
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
                    TypeHeirarchyNode found;
                    if (!hierarchy.TryGetValue(baseType, out found))
                    {
                        found = new TypeHeirarchyNode(baseType);
                        hierarchy.Add(baseType, found);
                    }

                    if (found.Type != resolvedType)
                    {
                        found.AddTypeSymbol(resolvedType);
                    }
                }
            }

        }

        class TypeHeirarchyNode
        {

            List<TypeSymbol> children = new List<TypeSymbol>();
            public TypeHeirarchyNode(TypeSymbol type)
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
        void RegisterBaseCCppTypeSymbol(CodeTypeReference baseCCppTypeSymbol)
        {
            //replace if exists
            if (!baseCCppTypeSymbols.ContainsKey(baseCCppTypeSymbol.Name))
            {
                baseCCppTypeSymbols.Add(baseCCppTypeSymbol.Name, new SimpleType(baseCCppTypeSymbol.Name));
            }


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
                    } break;
                case CodeTypeReferenceKind.TypeTemplate:
                    {
                        //resolve wellknown type template   
                        var typeTemplate = (CodeTypeTemplateTypeReference)typeRef;
                        string templateName = typeTemplate.Name;
                        switch (typeTemplate.Name)
                        {

                            case "CefCToCpp":
                                {
                                    if (typeTemplate.Items.Count == 3)
                                    {
                                        //auto add native c/c++ type
                                        RegisterBaseCCppTypeSymbol(typeTemplate.Items[2]);
                                        return ResolveType(typeTemplate.Items[1]);
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
                            default:
                                throw new NotSupportedException();
                        }

                    } break;
                case CodeTypeReferenceKind.Pointer:
                    {
                        var pointerType = (CodePointerTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(pointerType.ElementType);
                        return new ReferenceOrPointerTypeSymbol(elementType, ContainerTypeKind.Pointer);
                    } break;
                case CodeTypeReferenceKind.ByRef:
                    {
                        var byRefType = (CodeByRefTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(byRefType.ElementType);
                        return new ReferenceOrPointerTypeSymbol(elementType, ContainerTypeKind.ByRef);

                    } break;
                default:
                    {
                        throw new NotSupportedException();
                    } break;
            }
            return null;
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
                if (baseCCppTypeSymbols.TryGetValue(typename, out foundSymbol))
                {
                    return foundSymbol;
                }

                //this is convention 
                if (typename.StartsWith("cef_") && IsAllLowerLetter(typename))
                {
                    //assume this is base c/cpp type
                    foundSymbol = new SimpleType(typename);
                    baseCCppTypeSymbols.Add(
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

}