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
        public DotNetResolvedSimpleType(SimpleTypeSymbol simpleType)
        {
            this.SimpleType = simpleType;
            this.Name = simpleType.Name;
            this.IsPrimitiveType = simpleType.PrimitiveTypeKind != PrimitiveTypeKind.NotPrimitiveType;
        }
        public string Name { get; set; }
        public SimpleTypeSymbol SimpleType { get; set; }
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
        DotNetResolvedTypeBase dnResolvedType;
        public MethodParameterTxInfo(string name)
        {
            this.Name = name;
        }
        public bool IsMethodReturnParameter { get; set; }
        public string Name { get; set; }
        public bool IsVoid
        {
            get;
            private set;
        }
        public DotNetResolvedTypeBase DotnetResolvedType
        {
            get { return dnResolvedType; }
            set
            {
                dnResolvedType = value;
                DotNetResolvedSimpleType asSimpleType = value as DotNetResolvedSimpleType;
                if (asSimpleType != null)
                {
                    IsVoid = asSimpleType.SimpleType.PrimitiveTypeKind == PrimitiveTypeKind.Void;
                }
                else
                {
                    IsVoid = false;
                }
            }

        }

        public override string ToString()
        {
            return DotnetResolvedType.ToString();
        }
        public TxParameterDirection Direction { get; set; }
    }

    enum TxParameterDirection
    {
        Return,
        In,
        Out,
        InOut
    }

    class TypeTranformPlanner
    {
        CodeTypeDeclaration typedecl; //current type decl
        TypeTxInfo typeTxInfo; //current type tx         
        TypeSymbol otherSearchScopeTypeSymbol;

        public TypeTranformPlanner()
        {
        }
        public CefTypeCollection CefTypeCollection { get; set; }

        public TypeTxInfo MakeTransformPlan(CodeTypeDeclaration typedecl)
        {
            this.typedecl = typedecl;
            this.typeTxInfo = new TypeTxInfo(typedecl);
            this.otherSearchScopeTypeSymbol = null;//reset 
            List<CodeTypeReference> baseTypes = typedecl.BaseTypes;
            //set up baseType
            if (baseTypes != null)
            {
                if (baseTypes.Count > 1)
                {
                    throw new NotSupportedException();
                }
                else if (baseTypes.Count == 1)
                {
                    CodeTypeReference baseTypeOfThisType = baseTypes[0];
                    TypeSymbol baseTypeSymbol = baseTypeOfThisType.ResolvedType;
                    switch (baseTypeSymbol.TypeSymbolKind)
                    {
                        case TypeSymbolKind.Template:
                            {
                                //we focus on this type
                                TemplateTypeSymbol3 t3 = (TemplateTypeSymbol3)baseTypeSymbol;
                                //in this version we have only TemplateType3
                                switch (t3.Name)
                                {
                                    default: throw new NotSupportedException();

                                    //c-to-cpp
                                    case "CefCToCppScoped":
                                    case "CefCToCppRefCounted":
                                        otherSearchScopeTypeSymbol = t3.Item1;
                                        break;
                                    //----------------------------
                                    //cpp-to-c
                                    case "CefCppToCScoped":
                                        otherSearchScopeTypeSymbol = t3.Item1;
                                        break;
                                    case "CefCppToCRefCounted":
                                        otherSearchScopeTypeSymbol = t3.Item1;
                                        break;
                                }
                            }
                            break;
                    }
                }
            }

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
                    else
                    {

                    }
                }
            }
            return typeTxInfo;
        }
        void AddParameterWrappingInfo(MethodParameterTxInfo parTxInfo, TypeSymbol parTypeSymbol)
        {

            switch (parTypeSymbol.TypeSymbolKind)
            {
                case TypeSymbolKind.TypeDef:
                    //check back to its original typedef                    
                    break;
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol simpleType = (SimpleTypeSymbol)parTypeSymbol;
                        if (simpleType.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                        {
                            TypeSymbol c_type;

                            if (!CefTypeCollection.baseCToCppTypeSymbols.TryGetValue(simpleType.Name, out c_type))
                            {
                                if (!CefTypeCollection.typeSymbols.ContainsKey(simpleType.Name))
                                {
                                    //this may be nested type
                                    if (this.otherSearchScopeTypeSymbol != null)
                                    {
                                        string searchName = otherSearchScopeTypeSymbol.ToString() + "." + simpleType.Name;
                                        if (!CefTypeCollection.typeSymbols.ContainsKey(searchName))
                                        {

                                        }
                                    }
                                    else
                                    {
                                        //where to find more?
                                    }

                                }
                            }
                            else
                            {

                            }
                        }
                    }



                    break;
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        ReferenceOrPointerTypeSymbol refOfPointer = (ReferenceOrPointerTypeSymbol)parTypeSymbol;
                        switch (refOfPointer.Kind)
                        {
                            default: throw new NotSupportedException();//should not visit here
                            case ContainerTypeKind.ByRef:
                                {
                                    //eg. CefPoint& 
                                    //check element type
                                    TypeSymbol elemType = refOfPointer.ElementType;
                                    switch (elemType.TypeSymbolKind)
                                    {
                                        default:
                                            //should not visit here
                                            throw new NotSupportedException();
                                        case TypeSymbolKind.Simple:
                                            //reference to simple type

                                            break;
                                        case TypeSymbolKind.Vec:
                                            //ref to vec
                                            break;
                                        case TypeSymbolKind.ReferenceOrPointer:
                                            ReferenceOrPointerTypeSymbol refOfPointerElem = (ReferenceOrPointerTypeSymbol)elemType;
                                            if (refOfPointerElem.Kind == ContainerTypeKind.Pointer)
                                            {

                                            }
                                            else if (refOfPointerElem.Kind == ContainerTypeKind.CefRefPtr)
                                            {

                                            }
                                            else
                                            {
                                                throw new NotSupportedException();
                                            }
                                            break;
                                    }
                                }
                                break;
                            case ContainerTypeKind.CefRefPtr:
                                {
                                    string ss = refOfPointer.ElementType.ToString();
                                    if (ss == "CefString")
                                    {
                                    }
                                    else if (ss == "vec<CefString>")
                                    {

                                    }
                                    else if (!ss.StartsWith("Cef"))
                                    {

                                    }
                                }
                                break;
                            case ContainerTypeKind.Pointer:
                                {
                                    string ss = parTypeSymbol.ToString();
                                    if (ss == "void*" || ss == "char*")
                                    {

                                    }
                                    else
                                    {

                                    }

                                }
                                break;
                        }
                    }
                    break;
                default:
                    throw new NotSupportedException();

            }

        }
        MethodTxInfo MakeMethodPlan(CodeMethodDeclaration metDecl)
        {
            MethodTxInfo metTx = new MethodTxInfo(metDecl);
            //make return type plan

            //1. return
            MethodParameterTxInfo retTxInfo = new MethodParameterTxInfo(null) { IsMethodReturnParameter = true };
            retTxInfo.Direction = TxParameterDirection.Return;

            AddMethodParameterTypeTxInfo(retTxInfo, metDecl.ReturnType.ResolvedType);
            AddParameterWrappingInfo(retTxInfo, metDecl.ReturnType.ResolvedType);

            metTx.ReturnPlan = retTxInfo;

            //2. parameters
            int j = metDecl.Parameters.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMethodParameter metPar = metDecl.Parameters[i];
                MethodParameterTxInfo parTxInfo = new MethodParameterTxInfo(metPar.ParameterName);
                parTxInfo.Direction = TxParameterDirection.In;
                //TODO: review Out,InOut direction 

                TypeSymbol parTypeSymbol = metPar.ParameterType.ResolvedType;
                AddMethodParameterTypeTxInfo(parTxInfo, parTypeSymbol);
                //check wrapping c-to-cpp / cpp-to-c
                AddParameterWrappingInfo(parTxInfo, parTypeSymbol);

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
                default:
                    throw new NotSupportedException();
                case TypeSymbolKind.TypeDef:
                    {
                        CTypeDefTypeSymbol typedefTypeSymbol = (CTypeDefTypeSymbol)resolvedParType;

                    }
                    break;
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol simpleType = (SimpleTypeSymbol)resolvedParType;
                        parPlan.DotnetResolvedType = new DotNetResolvedSimpleType(simpleType);
                        switch (parPlan.Direction)
                        {
                            default: throw new NotSupportedException();
                            case TxParameterDirection.In:
                                {
                                    //input parameter
                                    switch (simpleType.PrimitiveTypeKind)
                                    {
                                        case PrimitiveTypeKind.CefString:
                                            break;
                                        case PrimitiveTypeKind.Void:
                                            break;
                                        case PrimitiveTypeKind.NotPrimitiveType:
                                            {
                                                CodeTypeDeclaration decl = simpleType.CreatedByTypeDeclaration;
                                                if (decl != null)
                                                {

                                                }

                                            }
                                            break;
                                        default:
                                            {
                                                //other primitive type
                                            }
                                            break;
                                    }
                                }
                                break;
                            case TxParameterDirection.Return:
                                {
                                    //check if we return 
                                    //some 
                                    if (simpleType.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                    {
                                        //not primitive

                                    }
                                    else
                                    {

                                    }
                                }
                                break;
                        }

                    }
                    break;
                case TypeSymbolKind.Vec:
                    {
                        var vec = (VecTypeSymbol)resolvedParType;
                        //vector of ...
                        switch (parPlan.Direction)
                        {
                            default: throw new NotSupportedException();
                            case TxParameterDirection.Return:
                                {

                                }
                                break;
                            case TxParameterDirection.In:
                                {

                                }
                                break;
                            case TxParameterDirection.Out:
                                {

                                }
                                break;
                        }
                        //make it array
                        parPlan.DotnetResolvedType = new DotNetList(parPlan.DotnetResolvedType);
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

                                    if (refOrPointer.ElementType is SimpleTypeSymbol)
                                    {
                                        SimpleTypeSymbol elem = (SimpleTypeSymbol)refOrPointer.ElementType;
                                        if (elem.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                        {

                                        }
                                        else
                                        {

                                        }

                                    }
                                    else if (refOrPointer.ElementType is VecTypeSymbol)
                                    {

                                    }
                                    else
                                    {

                                    }

                                }
                                break;
                            case ContainerTypeKind.CefRefPtr:
                                {
                                    if (refOrPointer.ElementType is SimpleTypeSymbol)
                                    {
                                        SimpleTypeSymbol elem = (SimpleTypeSymbol)refOrPointer.ElementType;
                                        if (elem.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                        {
                                            //check how to send this through the bridge
                                            //by check its base type
                                            CodeTypeDeclaration createdTypeDecl = elem.CreatedByTypeDeclaration;
                                            if (createdTypeDecl.BaseTypes == null)
                                            {

                                            }
                                            else
                                            {
                                                CodeTypeReference baseTypeRef = createdTypeDecl.BaseTypes[0];
                                                switch (baseTypeRef.Name)
                                                {
                                                    case "CefBaseRefCounted":
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            }

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
                            case ContainerTypeKind.Pointer:
                                {

                                    string elemType = refOrPointer.ElementType.ToString();
                                    switch (elemType)
                                    {
                                        default:
                                            throw new NotSupportedException();
                                        case "char": //char*
                                            {

                                            }
                                            break;
                                        case "void": //void*
                                            {

                                            }
                                            break;
                                    }
                                }
                                break;
                            case ContainerTypeKind.ScopePtr:
                                throw new NotSupportedException();
                            default:
                                throw new NotSupportedException();
                        }
                    }
                    break;

            }
        }
    }
}