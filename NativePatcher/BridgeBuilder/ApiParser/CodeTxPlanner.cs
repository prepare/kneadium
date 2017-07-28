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
                                TemplateTypeSymbol t_base = (TemplateTypeSymbol)baseTypeSymbol;
                                switch (t_base.ItemCount)
                                {
                                    default:
                                        throw new NotSupportedException();
                                    case 3:
                                        {
                                            TemplateTypeSymbol3 t3 = (TemplateTypeSymbol3)baseTypeSymbol;
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
                            break;
                    }
                }
            }

            foreach (CodeMethodDeclaration metDecl in typedecl.GetMethodIter())
            {
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
                            //if (!CefTypeCollection.typeSymbols.ContainsKey(simpleType.Name))
                            //{
                            //    //this may be nested type
                            //    if (this.otherSearchScopeTypeSymbol != null)
                            //    {
                            //        string searchName = otherSearchScopeTypeSymbol.ToString() + "." + simpleType.Name;
                            //        if (!CefTypeCollection.typeSymbols.ContainsKey(searchName))
                            //        {
                            //            if (!CefTypeCollection.typeDics.ContainsKey(simpleType.Name))
                            //            {

                            //            }

                            //        }
                            //    }
                            //    else
                            //    {
                            //        //where to find more?
                            //    }

                            //}

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
                                        case TypeSymbolKind.TypeDef:
                                            {

                                            }

                                            break;
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
                                        if (simpleType.CreatedByTypeDeclaration != null)
                                        {

                                        }
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
                                    switch (refOrPointer.ElementType.TypeSymbolKind)
                                    {
                                        default:
                                            break;
                                        case TypeSymbolKind.Simple:
                                            {
                                                SimpleTypeSymbol elem = (SimpleTypeSymbol)refOrPointer.ElementType;
                                                if (elem.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                                {

                                                }
                                                else
                                                {

                                                }
                                            }
                                            break;
                                        case TypeSymbolKind.Vec:
                                            break;
                                        case TypeSymbolKind.ReferenceOrPointer:
                                            break;
                                        case TypeSymbolKind.TypeDef:
                                            {
                                                CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)refOrPointer.ElementType;
                                                TypeSymbol referToType = ctypedef.ReferToTypeSymbol;
                                                switch (referToType.TypeSymbolKind)
                                                {
                                                    default:
                                                        throw new NotSupportedException();
                                                    case TypeSymbolKind.Template:
                                                        {
                                                            TemplateTypeSymbol tt = (TemplateTypeSymbol)referToType;
                                                            switch (tt.Name)
                                                            {
                                                                default:
                                                                    break;
                                                                case "CefStructBase":
                                                                    //act as struct
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
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
                                            if (createdTypeDecl != null && createdTypeDecl.BaseTypes != null)
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
                                            else
                                            {

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

    enum CefTypeKind
    {

        //#define JSVALUE_TYPE_UNKNOWN_ERROR  -1
        //#define JSVALUE_TYPE_EMPTY			 0
        //#define JSVALUE_TYPE_NULL            1
        //#define JSVALUE_TYPE_BOOLEAN         2
        //#define JSVALUE_TYPE_INTEGER         3
        //#define JSVALUE_TYPE_NUMBER          4
        //#define JSVALUE_TYPE_STRING          5 //unicode string
        //#define JSVALUE_TYPE_DATE            6
        //#define JSVALUE_TYPE_INDEX           7
        //#define JSVALUE_TYPE_ARRAY          10
        //#define JSVALUE_TYPE_STRING_ERROR   11
        //#define JSVALUE_TYPE_MANAGED        12
        //#define JSVALUE_TYPE_MANAGED_ERROR  13
        //#define JSVALUE_TYPE_WRAPPED        14
        //#define JSVALUE_TYPE_DICT           15
        //#define JSVALUE_TYPE_ERROR          16
        //#define JSVALUE_TYPE_FUNCTION       17

        //#define JSVALUE_TYPE_JSTYPEDEF      18 //my extension
        //#define JSVALUE_TYPE_INTEGER64      19 //my extension
        //#define JSVALUE_TYPE_BUFFER         20 //my extension

        //#define JSVALUE_TYPE_NATIVE_CEFSTRING 30  //my extension
        //#define JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING 31//my extension
        //#define JSVALUE_TYPE_MANAGED_CB 32
        //#define JSVALUE_TYPE_MEM_ERROR      50 //my extension


        JSVALUE_TYPE_UNKNOWN_ERROR = -1,
        JSVALUE_TYPE_EMPTY = 0,
        JSVALUE_TYPE_NULL = 1,
        JSVALUE_TYPE_BOOLEAN = 2,
        JSVALUE_TYPE_INTEGER = 3,
        JSVALUE_TYPE_NUMBER = 4,
        JSVALUE_TYPE_STRING = 5, //unicode string
        JSVALUE_TYPE_DATE = 6,
        JSVALUE_TYPE_INDEX = 7,
        JSVALUE_TYPE_ARRAY = 10,
        JSVALUE_TYPE_STRING_ERROR = 11,
        JSVALUE_TYPE_MANAGED = 12,
        JSVALUE_TYPE_MANAGED_ERROR = 13,
        JSVALUE_TYPE_WRAPPED = 14,
        JSVALUE_TYPE_DICT = 15,
        JSVALUE_TYPE_ERROR = 16,
        JSVALUE_TYPE_FUNCTION = 17,
        JSVALUE_TYPE_JSTYPEDEF = 18,//my extension
        JSVALUE_TYPE_INTEGER64 = 19, //my extension
        JSVALUE_TYPE_BUFFER = 20,//my extension 
        JSVALUE_TYPE_NATIVE_CEFSTRING = 30, //my extension
        JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING = 31,//my extension
        JSVALUE_TYPE_MANAGED_CB = 32,
        JSVALUE_TYPE_MEM_ERROR = 50, //my extension
    }


    class TypeBridgeInfo
    {
        readonly TypeSymbol owner;
        public readonly CefSlotName slotName;
        public readonly CefTypeKind cefTypeKind;

        //
        public readonly BridgeForInArg InArg;
        public readonly BridgeForOutArg OutArg;
        public readonly BridgeForReturn Return;


        public TypeBridgeInfo(TypeSymbol owner, CefTypeKind cefTypeKind)
        {
            this.owner = owner;
            this.cefTypeKind = cefTypeKind;
            switch (cefTypeKind)
            {
                default: throw new NotSupportedException();
                case CefTypeKind.JSVALUE_TYPE_ERROR:
                    slotName = CefSlotName.UNKNOWN;
                    break;
                case CefTypeKind.JSVALUE_TYPE_WRAPPED:
                    slotName = CefSlotName.ptr;
                    break;
                case CefTypeKind.JSVALUE_TYPE_INTEGER64:
                    slotName = CefSlotName.i64;
                    break;
                case CefTypeKind.JSVALUE_TYPE_EMPTY:
                    slotName = CefSlotName.UNKNOWN;
                    break;
                case CefTypeKind.JSVALUE_TYPE_BOOLEAN:
                case CefTypeKind.JSVALUE_TYPE_INTEGER: //TODO: review int32
                    slotName = CefSlotName.i32; //sign 32 bits
                    break;
                case CefTypeKind.JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING:
                case CefTypeKind.JSVALUE_TYPE_NATIVE_CEFSTRING:
                    slotName = CefSlotName.ptr;
                    break;
                case CefTypeKind.JSVALUE_TYPE_NUMBER:
                    slotName = CefSlotName.num;
                    break;
            }
            this.InArg = new BridgeForInArg();
            this.OutArg = new BridgeForOutArg();
            this.Return = new BridgeForReturn();
        }
        public override string ToString()
        {
            return "bridge:" + owner.ToString();
        }

    }
    class BridgeForInArg
    {
        public CefTypeKind TxKind;

    }
    class BridgeForOutArg
    {
        public CefTypeKind TxKind;
    }
    class BridgeForReturn
    {
        public CefTypeKind TxKind;
    }

    enum CefSlotName
    {
        UNKNOWN,
        //
        type,
        i32,
        ptr,
        num,
        i64
    }

    class CefTypeBridgeTransformPlanner
    {

        //extern "C" { 
        //	struct jsvalue
        //        {
        //            int32_t type; //type and flags
        //                          //this for 32 bits values, also be used as string len, array len  and index to managed slot index
        //            int32_t i32;
        //            // native ptr (may point to native object, native array, native string)
        //            const void* ptr; //uint16_t* or jsvalue**   arr or 
        //                             //store float or double
        //            double num;
        //            //store 64 bits value
        //            int64_t i64;
        //        };
        //    }

        Dictionary<string, TypeSymbol> typeSymbols;
        TypeBridgeInfo SelectTypeBridgeForNonPrimitiveSimpleType(SimpleTypeSymbol simpleType)
        {
            //app-specific
            switch (simpleType.Name)
            {
                default:
                    {
                        if (simpleType.Name.StartsWith("cef_") && CefResolvingContext.IsAllLowerLetter(simpleType.Name))
                        {
                            //this is native cef?
                            var typeBridge = new TypeBridgeInfo(simpleType, CefTypeKind.JSVALUE_TYPE_WRAPPED);
                            return typeBridge;
                        }
                        else
                        {

                        }

                    }
                    return null;
                case "RECT":
                    {
                        var typeBridge = new TypeBridgeInfo(simpleType, CefTypeKind.JSVALUE_TYPE_WRAPPED);
                        return typeBridge;
                    }
                case "Handler":
                case "CefBase":
                case "CefBaseRefCounted":
                case "CefBaseScoped":
                    {
                        var typeBridge = new TypeBridgeInfo(simpleType, CefTypeKind.JSVALUE_TYPE_ERROR);
                        return typeBridge;
                    }
                case "HINSTANCE":
                case "time_t":
                    {
                        var typeBridge = new TypeBridgeInfo(simpleType, CefTypeKind.JSVALUE_TYPE_INTEGER64);
                        return typeBridge;
                    }

            }
        }


        TypeBridgeInfo SelectProperTypeBridge(TypeSymbol t)
        {
            //assign bridge info
            //for return, in and out
            switch (t.TypeSymbolKind)
            {
                default:
                    throw new NotSupportedException();
                case TypeSymbolKind.Template:
                    {
                        TemplateTypeSymbol templateType = (TemplateTypeSymbol)t;
                        switch (templateType.ItemCount)
                        {
                            default: throw new NotSupportedException();
                            case 1:
                                return SelectProperTypeBridge((TemplateTypeSymbol1)templateType);
                            case 2:
                                return SelectProperTypeBridge((TemplateTypeSymbol2)templateType);
                            case 3:
                                return SelectProperTypeBridge((TemplateTypeSymbol3)templateType);
                        } 
                    }
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol simpleType = (SimpleTypeSymbol)t;
                        switch (simpleType.PrimitiveTypeKind)
                        {
                            default:
                                throw new NotSupportedException();
                            case PrimitiveTypeKind.NotPrimitiveType:
                                return SelectTypeBridgeForNonPrimitiveSimpleType(simpleType);

                            case PrimitiveTypeKind.Float:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_NUMBER);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.Double:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_NUMBER);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.Bool:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_BOOLEAN);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.Char:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.Int32:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.Int64:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER64);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.UInt32:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.Void:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_EMPTY);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.IntPtr:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER64);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.UInt64:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER64);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.size_t:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_INTEGER64);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.String:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING);
                                    return typeBridge;
                                }
                            case PrimitiveTypeKind.CefString:
                                {
                                    var typeBridge = new TypeBridgeInfo(t, CefTypeKind.JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING);
                                    return typeBridge;
                                }
                        }
                    }
                case TypeSymbolKind.TypeDef:
                    {
                        CTypeDefTypeSymbol typedefSymbol = (CTypeDefTypeSymbol)t;
                        TypeBridgeInfo typeBridge = SelectProperTypeBridge(typedefSymbol.ReferToTypeSymbol);
                        return typeBridge;
                    }
            }


        }

        TypeBridgeInfo SelectProperTypeBridge(TemplateTypeSymbol3 t3)
        {
            return null;
        }
        TypeBridgeInfo SelectProperTypeBridge(TemplateTypeSymbol2 t2)
        {
            return null;
        }
        TypeBridgeInfo SelectProperTypeBridge(TemplateTypeSymbol1 t1)
        {
            return null;
        }

        public void AssignTypeBrigeInfo(Dictionary<string, TypeSymbol> typeSymbols)
        {
            this.typeSymbols = typeSymbols;
            foreach (TypeSymbol t in typeSymbols.Values)
            {
                if ((t is SimpleTypeSymbol) &&
                    ((SimpleTypeSymbol)t).IsGlobalCompilationUnitTypeDefinition)
                {
                    continue;
                }
                //
                TypeBridgeInfo bridgeInfo = SelectProperTypeBridge(t);
                if (bridgeInfo == null)
                {

                }
                t.BridgeInfo = bridgeInfo;
            }
        }


    }
}