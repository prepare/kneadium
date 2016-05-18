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
                new TypeSymbol("CefBase"),
                new TypeSymbol("size_t"),
                new TypeSymbol("void"),
                new TypeSymbol("int"),
                new TypeSymbol("int64"),
                new TypeSymbol("int32"),
                new TypeSymbol("bool"),
                new TypeSymbol("string"),
                //TODO: review
                //temp add here, to be review again
                new TypeSymbol("CefProcessId"), //typedef cef_process_id_t CefProcessId;
                new TypeSymbol("Handler")
            };

            foreach (TypeSymbol typeSymbol in prebuiltTypes)
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
                        TypeSymbol typeSymbol = new TypeSymbol(typeDecl.Name);
                        typeSymbol.CreatedByTypeDeclaration = typeDecl;
                        typeDecl.ResolvedType = typeSymbol;
                        typeSymbols.Add(typeSymbol.Name, typeSymbol);
                        //-----------------------
                    }
                }
            }
            ResolveBaseTypes();
            ResolveBaseTypeMembers();
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
                            case "base":
                                {
                                    TypeSymbol t = ResolveType(qnameType.RightPart);
                                    return t;
                                }
                            case "std":
                                {

                                    TypeSymbol t = ResolveType(qnameType.RightPart);
                                    return t;
                                }
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
                            case "CefRefPtr":
                                {
                                    if (typeTemplate.Items.Count == 1)
                                    {
                                        return ResolveType(typeTemplate.Items[0]);
                                    }
                                    throw new NotSupportedException();
                                }
                            case "CefCToCpp":
                                {
                                    if (typeTemplate.Items.Count == 3)
                                    {
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
                            default:
                                throw new NotSupportedException();
                        }

                    } break;
                case CodeTypeReferenceKind.Pointer:
                    {
                        var pointerType = (CodePointerTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(pointerType.ElementType);
                        return new PointerTypeSymbol(elementType);
                    } break;
                case CodeTypeReferenceKind.ByRef:
                    {
                        var byRefType = (CodeByRefTypeReference)typeRef;
                        TypeSymbol elementType = ResolveType(byRefType.ElementType);
                        return new PointerTypeSymbol(elementType);

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
                //try get type from pre-built type symbol

                //handle not found type
                throw new NotSupportedException();
            }

        }
        public bool TryGetTypeDeclaration(string typeName, out CodeTypeDeclaration found)
        {
            return typeDics.TryGetValue(typeName, out found);
        }
    }

}