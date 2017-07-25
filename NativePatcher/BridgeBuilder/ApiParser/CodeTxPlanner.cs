//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
 
using System.Text;

namespace BridgeBuilder
{
    //about: code transformation 
    abstract class DotNetResolvedTypeBase
    {

        public bool IsPrimitiveType { get; set; }
    }
    class DotNetResolvedSimpleType : DotNetResolvedTypeBase
    {
        public DotNetResolvedSimpleType(SimpleType simpleType)
        {
            this.SimpleType = simpleType;
            this.Name = simpleType.Name;
        }
        public string Name { get; set; }
        public SimpleType SimpleType { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
    class DotNetResolvedArrayType : DotNetResolvedTypeBase
    {
        public DotNetResolvedArrayType(DotNetResolvedTypeBase elementType)
        {
            ElementType = elementType;
        }
        public DotNetResolvedTypeBase ElementType { get; set; }
        public override string ToString()
        {
            return ElementType + "[]";
        }
    }
    class DotNetList : DotNetResolvedTypeBase
    {
        public DotNetList(DotNetResolvedTypeBase elementType)
        {
            ElementType = elementType;
        }
        public DotNetResolvedTypeBase ElementType { get; set; }
        public override string ToString()
        {
            return "list<" + ElementType + ">";
        }

    }

    class TypeTxInfo
    {

        public List<MethodTxInfo> methods = new List<MethodTxInfo>();
        public TypeTxInfo(CodeTypeDeclaration typedecl)
        {
            this.TypeDecl = typedecl;
        }
        public CodeTypeDeclaration TypeDecl
        {
            get;
            set;
        }
        public void AddMethod(MethodTxInfo met)
        {
            methods.Add(met);
        }
#if DEBUG
        public override string ToString()
        {
            return TypeDecl.ToString();
        }
#endif
    }

    class MethodTxInfo
    {
        CodeMethodDeclaration metDecl;
        public List<MethodParameterTxInfo> pars = new List<MethodParameterTxInfo>();
        public MethodTxInfo(CodeMethodDeclaration metDecl)
        {
            this.metDecl = metDecl;
            this.Name = metDecl.Name;
        }
        public string Name { get; set; }
        public void AddMethodParameterTx(MethodParameterTxInfo par)
        {
            pars.Add(par);
        }
        public MethodParameterTxInfo ReturnPlan
        {
            get;
            set;
        }


#if DEBUG
        public override string ToString()
        {
            return metDecl.ToString();
        }
#endif
    }

    class MethodParameterTxInfo
    {
        public MethodParameterTxInfo(string name)
        {
            this.Name = name;
        }
        public bool IsMethodReturnParameter { get; set; }
        public string Name { get; set; }
        public bool IsVoid { get; set; }
        public DotNetResolvedTypeBase DotnetResolvedType { get; set; }
        public int MarkAsReferenceCount { get; set; }
        public override string ToString()
        {
            return DotnetResolvedType.ToString();
        }
    }

    class TypeTranformPlanner
    {
        public TypeTranformPlanner()
        {
        }
        public CefTypeCollection CefTypeCollection { get; set; }
        public TypeTxInfo MakeTransformPlan(CodeTypeDeclaration typedecl)
        {
            TypeTxInfo typeTxInfo = new TypeTxInfo(typedecl);
            foreach (CodeMemberDeclaration mb in typedecl.Members)
            {
                if (mb.MemberKind == CodeMemberKind.Method)
                {
                    CodeMethodDeclaration metDecl = (CodeMethodDeclaration)mb;
                    if (metDecl.MethodKind == MethodKind.Normal)
                    {
                        MethodTxInfo metTx = MakeMethodPlan(metDecl);
                        if (metTx == null)
                        {
                            throw new NotSupportedException();
                        }
                        typeTxInfo.AddMethod(metTx);
                    }
                }
            }
            return typeTxInfo;
        }

        MethodTxInfo MakeMethodPlan(CodeMethodDeclaration metDecl)
        {
            MethodTxInfo metTx = new MethodTxInfo(metDecl);
            //make return type plan

            //1. return
            MethodParameterTxInfo retTxInfo = new MethodParameterTxInfo(null) { IsMethodReturnParameter = true };
            AddMethodParameterTypeTxInfo(retTxInfo, metDecl.ReturnType.ResolvedType);
            metTx.ReturnPlan = retTxInfo;

            //2. parameters
            int j = metDecl.Parameters.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMethodParameter metPar = metDecl.Parameters[i];
                MethodParameterTxInfo parTxInfo = new MethodParameterTxInfo(metPar.ParameterName);

                AddMethodParameterTypeTxInfo(parTxInfo, metPar.ParameterType.ResolvedType);
                metTx.AddMethodParameterTx(parTxInfo);
                if (!metPar.IsConstPar)
                {
                    //TODO: review this
                    //if not, this should gen out or ref parameter
                }
            }

            return metTx;
        }

        void AddMethodParameterTypeTxInfo(MethodParameterTxInfo parPlan, TypeSymbol resolvedParType)
        {
            switch (resolvedParType.TypeSymbolKind)
            {
                case TypeSymbolKind.Simple:
                    {
                        SimpleType simpleType = (SimpleType)resolvedParType;
                        if (IsPrimitiveType(simpleType))
                        {
                            if (simpleType.Name == "void")
                            {
                                parPlan.IsVoid = true;
                            }
                            else
                            {
                                //
                            }
                            parPlan.DotnetResolvedType = new DotNetResolvedSimpleType(simpleType) { IsPrimitiveType = true };
                        }
                        else
                        {
                            //eg ret by reference 
                            //create wrapper for this type
                            parPlan.DotnetResolvedType = new DotNetResolvedSimpleType(simpleType);
                        }
                    }
                    break;
                case TypeSymbolKind.Vec:
                    {
                        var vec = (VecTypeSymbol)resolvedParType;
                        AddMethodParameterTypeTxInfo(parPlan, vec.ElementType);
                        //make it array
                        parPlan.DotnetResolvedType = new DotNetList(
                            parPlan.DotnetResolvedType);

                    }
                    break;
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        var refOrPointer = (ReferenceOrPointerTypeSymbol)resolvedParType;
                        //check element inside
                        switch (refOrPointer.Kind)
                        {
                            case ContainerTypeKind.ByRef:
                                {
                                    AddMethodParameterTypeTxInfo(parPlan, refOrPointer.ElementType);
                                    if (IsPrimitiveType(parPlan.DotnetResolvedType))
                                    {
                                        parPlan.MarkAsReferenceCount++;
                                    }
                                    else
                                    {
                                        //return reference of unmanaged heap object                                        
                                        //then just pass 
                                        if (parPlan.MarkAsReferenceCount == 0)
                                        {
                                            parPlan.MarkAsReferenceCount++;
                                        }
                                        else
                                        {
                                            throw new NotSupportedException();
                                        }
                                    }

                                }
                                break;
                            case ContainerTypeKind.CefRefPtr:
                                {
                                    AddMethodParameterTypeTxInfo(parPlan, refOrPointer.ElementType);

                                    if (IsPrimitiveType(parPlan.DotnetResolvedType))
                                    {
                                        throw new NotSupportedException();
                                    }
                                    else
                                    {
                                        //return reference of unmanaged heap object                                        
                                        //then just pass 
                                        if (parPlan.MarkAsReferenceCount == 0)
                                        {
                                            parPlan.MarkAsReferenceCount++;
                                        }
                                        else
                                        {
                                            throw new NotSupportedException();
                                        }
                                    }

                                }
                                break;
                            case ContainerTypeKind.Pointer:
                                throw new NotSupportedException();
                                break;
                            case ContainerTypeKind.ScopePtr:
                                throw new NotSupportedException();
                                break;
                            default:
                                throw new NotSupportedException();
                                break;
                        }
                    }
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        static bool IsPrimitiveType(string typename)
        {
            switch (typename)
            {
                case "void":
                case "bool":
                case "char":
                case "int":
                case "int32":
                case "uint32":
                case "int64":
                case "uint64":
                    return true;

            }
            return false;
        }

        static bool IsPrimitiveType(SimpleType ss)
        {
            return IsPrimitiveType(ss.Name);
        }
        static bool IsPrimitiveType(DotNetResolvedTypeBase dnResolvedType)
        {
            var asSimpleType = dnResolvedType as DotNetResolvedSimpleType;
            if (asSimpleType != null)
            {
                return IsPrimitiveType(asSimpleType.SimpleType);
            }
            return false;
        }
    }
}