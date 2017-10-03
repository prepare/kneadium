//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
namespace BridgeBuilder
{

    enum ImplWrapDirection
    {
        None,
        CppToC,
        CToCpp,
    }

    /// <summary>
    /// cef type transformer
    /// </summary>
    abstract class CefTypeTx
    {
        CodeTypeDeclaration _implDecl;
#if DEBUG
        protected int _dbug_cpp_count = 0;
#endif
        public CefTypeTx(CodeTypeDeclaration originalDecl)
        {
            this.OriginalDecl = originalDecl;
        }
        public SimpleTypeSymbol UnderlyingCType { get; set; }
        public CodeTypeDeclaration OriginalDecl { get; private set; }
        public CodeTypeDeclaration ImplTypeDecl
        {
            get { return _implDecl; }
            set
            {
                _implDecl = value;

            }
        }
        public override string ToString()
        {
            if (_implDecl != null)
            {
                return OriginalDecl.ToString() + " impl_by " + _implDecl.ToString();
            }
            else
            {
                return OriginalDecl.ToString();
            }
        }

        internal int MaxMethodParCount { get; set; }
        public int CsInterOpTypeNameId { get; set; }

        public abstract void GenerateCode(CefCodeGenOutput output);

        public string CppImplClassName { get; set; }
        public int CppImplClassNameId { get; set; }

        internal static string GetRawPtrMet(ImplWrapDirection wrapDirection)
        {

            //c-to-cpp
            //            template <class ClassName, class BaseName, class StructName>
            //CefRefPtr<BaseName> CefCToCppRefCounted<ClassName, BaseName, StructName>::Wrap(
            //    StructName* s)
            //        {
            //            if (!s)
            //                return NULL;


            //            template <class ClassName, class BaseName, class StructName>
            //StructName* CefCToCppRefCounted<ClassName, BaseName, StructName>::Unwrap(
            //    CefRefPtr<BaseName> c)
            //        {
            //            if (!c.get())
            //                return NULL;

            //------------------------------------
            //cpp-to-c
            //            // Wrap a C++ class with a C structure.  This is used when the class
            //            // implementation exists on this side of the DLL boundary but will have methods
            //            // called from the other side of the DLL boundary.
            //            template <class ClassName, class BaseName, class StructName>
            //class CefCppToCRefCounted : public CefBaseRefCounted {
            // public:
            //  // Create a new wrapper instance and associated structure reference for
            //  // passing an object instance the other side.
            //  static StructName* Wrap(CefRefPtr<BaseName> c)
            //        {
            //            if (!c.get())
            //                return NULL;

            //            // Wrap our object with the CefCppToCRefCounted class.
            //            ClassName* wrapper = new ClassName();
            //            wrapper->wrapper_struct_.object_ = c.get();
            //            // Add a reference to our wrapper object that will be released once our
            //            // structure arrives on the other side.
            //            wrapper->AddRef();
            //            // Return the structure pointer that can now be passed to the other side.
            //            return wrapper->GetStruct();
            //        }

            //        // Retrieve the underlying object instance for a structure reference passed
            //        // back from the other side.
            //        static CefRefPtr<BaseName> Unwrap(StructName* s)
            //        {
            //            if (!s)
            //                return NULL;

            //            // Cast our structure to the wrapper structure type.
            //            WrapperStruct* wrapperStruct = GetWrapperStruct(s);

            //            // If the type does not match this object then we need to unwrap as the
            //            // derived type.
            //            if (wrapperStruct->type_ != kWrapperType)
            //                return UnwrapDerived(wrapperStruct->type_, s);

            //            // Add the underlying object instance to a smart pointer.
            //            CefRefPtr<BaseName> objectPtr(wrapperStruct->object_);
            //            // Release the reference to our wrapper object that was added before the
            //            // structure was passed back to us.
            //            wrapperStruct->wrapper_->Release();
            //            // Return the underlying object instance.
            //            return objectPtr;
            //        }


            switch (wrapDirection)
            {
                default:
                    throw new NotSupportedException();
                case ImplWrapDirection.CppToC:
                    return "Wrap";
                case ImplWrapDirection.CToCpp:
                    return "Unwrap";
            }
        }
        internal static string GetSmartPointerMet(ImplWrapDirection wrapDirection)
        {
            switch (wrapDirection)
            {
                default:
                    throw new NotSupportedException();
                case ImplWrapDirection.CppToC:
                    return "Unwrap";
                case ImplWrapDirection.CToCpp:
                    return "Wrap";
            }

        }

        /// <summary>
        /// bring data from srcExpression and store to the destExpression
        /// </summary>
        /// <param name="par"></param>
        /// <param name="destExpression"></param>
        /// <param name="srcExpression"></param>
        internal static void PrepareDataFromNativeToCs(MethodParameter par, string destExpression, string srcExpression, bool stackBased)
        {

            TypeSymbol ret = par.TypeSymbol;
            //check if we need some clean up code after return to client  
            switch (ret.TypeSymbolKind)
            {
                default:
                    break;
                case TypeSymbolKind.TypeDef:
                    {
                        CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)ret;
                        par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                        return;
                    }
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        ReferenceOrPointerTypeSymbol refOrPtr = (ReferenceOrPointerTypeSymbol)ret;
                        switch (refOrPtr.Kind)
                        {
                            default:
                                {

                                }
                                break;
                            case ContainerTypeKind.CefRawPtr:
                                {
                                    //raw pointer 
                                    par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + srcExpression + ");";
                                    return;
                                }
                            case ContainerTypeKind.ByRef:
                                {
                                    TypeSymbol elemType = refOrPtr.ElementType;
                                    //what type that implement this elem
                                    if (elemType.TypeSymbolKind == TypeSymbolKind.Simple)
                                    {
                                        SimpleTypeSymbol simpleElem = (SimpleTypeSymbol)elemType;
                                        switch (simpleElem.PrimitiveTypeKind)
                                        {
                                            case PrimitiveTypeKind.CefString:
                                                if (stackBased)
                                                {
                                                    par.ArgExtractCode = "SetCefStringToJsValue2(" + destExpression + "," + srcExpression + ");";
                                                }
                                                else
                                                {
                                                    par.ArgExtractCode = "SetCefStringToJsValue(" + destExpression + "," + srcExpression + ");";
                                                    //need StringHolder cleanup
                                                    par.ArgPostExtractCode = "DeleteCefStringHolderFromJsValue(" + destExpression + ");";
                                                }

                                                return;
                                            case PrimitiveTypeKind.NaitveInt:
                                                par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.size_t:
                                                par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.Int64:
                                                par.ArgExtractCode = "MyCefSetInt64(" + destExpression + "," + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.UInt64:
                                                par.ArgExtractCode = "MyCefSetUInt64(" + destExpression + "," + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.Double:
                                                par.ArgExtractCode = "MyCefSetDouble(" + destExpression + "," + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.Float:
                                                par.ArgExtractCode = "MyCefSetFloat(" + destExpression + "," + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.Bool:
                                                //reference to bool
                                                //par.ArgExtractCode = "MyCefSetBool(" + destExpression + "," + srcExpression + ");";
                                                par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + ",&" + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.UInt32:
                                                par.ArgExtractCode = "MyCefSetUInt32(" + destExpression + "," + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.Int32:
                                                par.ArgExtractCode = "MyCefSetInt32(" + destExpression + "," + srcExpression + ");";
                                                return;
                                            case PrimitiveTypeKind.NotPrimitiveType:
                                                {
                                                    CefTypeTx txPlan = simpleElem.CefTxPlan;
                                                    if (txPlan == null)
                                                    {
                                                        if (par.IsConst)
                                                        {
                                                            par.ArgExtractCode = "MyCefSetVoidPtr2(" + destExpression + ",&" + srcExpression + ");";
                                                        }
                                                        else
                                                        {
                                                            par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + srcExpression + ");";
                                                        }
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        //find what type that implement wrap/unwrap
                                                        CodeTypeDeclaration implBy = txPlan.ImplTypeDecl;

                                                        //c-to-cpp => from 'raw' pointer to 'smart' pointer
                                                        //cpp-to-c => from 'smart' pointer to 'raw' pointer

                                                        if (stackBased)
                                                        {

                                                            if (implBy.Name.Contains("CToCpp"))
                                                            {
                                                                //so if you want to send this to client lib
                                                                //you need to GET raw pointer , so =>


                                                                string auto_p = "p_" + par.Name;
                                                                par.ArgPreExtractCode = "auto " + auto_p + "=" + implBy.Name + "::Unwrap" + "(" + srcExpression + ");";
                                                                par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + auto_p + "); ";//unwrap 
                                                                par.ArgPostExtractCode = implBy.Name + "::Wrap" + "(" + auto_p + ");";//wrap

                                                                return;

                                                            }
                                                            else if (implBy.Name.Contains("CppToC"))
                                                            {
                                                                string auto_p = "p_" + par.Name;
                                                                par.ArgPreExtractCode = "auto " + auto_p + "=" + implBy.Name + "::Wrap" + "(" + srcExpression + ")";//wrap
                                                                par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + auto_p + ");";
                                                                par.ArgPostExtractCode = implBy.Name + "::Unwrap" + "(" + auto_p + ");";//unwrap
                                                                return;
                                                            }
                                                            else
                                                            {
                                                                throw new NotSupportedException();
                                                            }
                                                        }
                                                        else
                                                        {

                                                            if (implBy.Name.Contains("CToCpp"))
                                                            {
                                                                //so if you want to send this to client lib
                                                                //you need to GET raw pointer , so =>

                                                                par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," +
                                                                      implBy.Name + "::Unwrap" + "(" + srcExpression + "));";
                                                                return;

                                                            }
                                                            else if (implBy.Name.Contains("CppToC"))
                                                            {
                                                                par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," +
                                                                    implBy.Name + "::Wrap" + "(" + srcExpression + "));";
                                                                return;
                                                            }
                                                            else
                                                            {
                                                                throw new NotSupportedException();
                                                            }
                                                        }

                                                    }
                                                }
                                        }

                                    }
                                    else if (elemType.TypeSymbolKind == TypeSymbolKind.Vec)
                                    {
                                        par.ArgExtractCode = "MyCefSetVoidPtr2(" + destExpression + ",&" + srcExpression + ");";
                                        return;
                                    }
                                    else
                                    {
                                        if (par.IsConst)
                                        {
                                            par.ArgExtractCode = "MyCefSetVoidPtr2(" + destExpression + ",&" + srcExpression + ");";
                                        }
                                        else
                                        {
                                            par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + srcExpression + ");";
                                        }
                                        return;
                                    }
                                }
                                break;
                            case ContainerTypeKind.CefRefPtr:
                                //return CefRefPtr => this need unwrap method for raw pointer before send this to client
                                {
                                    TypeSymbol elemType = refOrPtr.ElementType;
                                    //what type that implement this elem
                                    if (elemType.TypeSymbolKind == TypeSymbolKind.Simple)
                                    {
                                        SimpleTypeSymbol simpleElem = (SimpleTypeSymbol)elemType;
                                        if (simpleElem.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                        {
                                            CefTypeTx txPlan = simpleElem.CefTxPlan;
                                            if (txPlan == null)
                                            {

                                                if (simpleElem.ToString() == "CefBaseRefCounted")
                                                {
                                                    par.ArgExtractCode = "!";
                                                    return;
                                                }
                                                throw new NotSupportedException();

                                            }
                                            else
                                            {
                                                //find what type that implement wrap/unwrap
                                                CodeTypeDeclaration implBy = txPlan.ImplTypeDecl;

                                                //c-to-cpp => from 'raw' pointer to 'smart' pointer
                                                //cpp-to-c => from 'smart' pointer to 'raw' pointer

                                                if (stackBased)
                                                {
                                                    if (implBy.Name.Contains("CToCpp"))
                                                    {
                                                        //so if you want to send this to client lib
                                                        //you need to GET raw pointer , so => 
                                                        //find result after extract 
                                                        string unwrapType = txPlan.UnderlyingCType.ToString();
                                                        //since this is CefRefPtr 
                                                        //so after ElementType we should get pointer of the underlying element 
                                                        string auto_p = "p_" + par.Name;
                                                        par.CppUnwrapType = unwrapType + "*";
                                                        par.CppUnwrapMethod = implBy.Name + "::Unwrap";
                                                        par.CppWrapMethod = implBy.Name + "::Wrap";
                                                        //
                                                        par.ArgPreExtractCode = "auto " + auto_p + "=" + par.CppUnwrapMethod + "(" + srcExpression + ");"; //unwrap
                                                        par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + auto_p + ");";
                                                        par.ArgPostExtractCode = implBy.Name + "::Wrap" + "(" + auto_p + ");"; //wrap                                                        

                                                    }
                                                    else if (implBy.Name.Contains("CppToC"))
                                                    {
                                                        string auto_p = "p_" + par.Name;
                                                        par.ArgPreExtractCode = "auto " + auto_p + "=" + implBy.Name + "::Wrap" + "(" + srcExpression + ");"; //wrap
                                                        par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + auto_p + ");";
                                                        par.ArgPostExtractCode = implBy.Name + "::Unwrap" + "(" + auto_p + ");";//unwrap
                                                    }
                                                    else
                                                    {
                                                        throw new NotSupportedException();
                                                    }
                                                }
                                                else
                                                {
                                                    if (implBy.Name.Contains("CToCpp"))
                                                    {
                                                        //so if you want to send this to client lib
                                                        //you need to GET raw pointer , so =>
                                                        string unwrapType = txPlan.UnderlyingCType.ToString();
                                                        //since this is CefRefPtr 
                                                        //so after ElementType we should get pointer of the underlying element 
                                                        string auto_p = "p_" + par.Name;
                                                        par.CppUnwrapType = unwrapType + "*";
                                                        par.CppUnwrapMethod = implBy.Name + "::Unwrap";
                                                        par.CppWrapMethod = implBy.Name + "::Wrap";

                                                        par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," +
                                                              implBy.Name + "::Unwrap" + "(" + srcExpression + "));";

                                                    }
                                                    else if (implBy.Name.Contains("CppToC"))
                                                    {
                                                        par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," +
                                                            implBy.Name + "::Wrap" + "(" + srcExpression + "));";
                                                    }
                                                    else
                                                    {
                                                        throw new NotSupportedException();
                                                    }
                                                }
                                                return;
                                            }
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {
                                        par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + srcExpression + ");";
                                        return;
                                    }
                                }
                                break;
                            case ContainerTypeKind.Pointer:
                                {

                                    TypeSymbol elemType = refOrPtr.ElementType;
                                    if (elemType.TypeSymbolKind == TypeSymbolKind.Simple)
                                    {
                                        SimpleTypeSymbol simpleElem = (SimpleTypeSymbol)elemType;
                                        switch (simpleElem.PrimitiveTypeKind)
                                        {
                                            default:
                                                break;
                                            case PrimitiveTypeKind.NotPrimitiveType:
                                                {
                                                    CodeTypeDeclaration createdBy = simpleElem.CreatedByTypeDeclaration;
                                                    if (createdBy.Kind == TypeKind.Enum)
                                                    {
                                                        if (!par.IsConst)
                                                        {
                                                            par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                                                            //TODO: set post 
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {

                                                    }
                                                }
                                                break;
                                            case PrimitiveTypeKind.Bool:
                                                {
                                                    //bool*
                                                    if (par.IsConst)
                                                    {

                                                    }
                                                    else
                                                    {
                                                        par.ArgExtractCode = "MyCefSetBool(" + destExpression + ",*" + srcExpression + ");";
                                                        return;
                                                    }
                                                }
                                                break;
                                            case PrimitiveTypeKind.Void:
                                                {
                                                    //void*
                                                    if (par.IsConst)
                                                    {
                                                        par.ArgExtractCode = "MyCefSetVoidPtr2(" + destExpression + "," + srcExpression + ");";
                                                        return;
                                                    }
                                                    else
                                                    {
                                                        par.ArgExtractCode = "MyCefSetVoidPtr(" + destExpression + "," + srcExpression + ");";
                                                        return;
                                                    }
                                                }
                                        }
                                    }
                                    else if (elemType.TypeSymbolKind == TypeSymbolKind.TypeDef)
                                    {


                                    }
                                    else
                                    {

                                    }
                                }
                                break;
                            case ContainerTypeKind.scoped_ptr:
                                break;
                        }
                    }
                    break;
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol simpleType = (SimpleTypeSymbol)ret;
                        switch (simpleType.PrimitiveTypeKind)
                        {
                            default:
                                break;
                            case PrimitiveTypeKind.Void:
                                par.ArgExtractCode = null;
                                return;
                            case PrimitiveTypeKind.NotPrimitiveType:
                                {
                                    SimpleTypeSymbol ss = (SimpleTypeSymbol)simpleType;
                                    if (ss.IsEnum)
                                    {
                                        //enum class 
                                        par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                                        return;
                                    }
                                    else
                                    {
                                        switch (ss.Name)
                                        {
                                            default:
                                                {

                                                }
                                                break;
                                            case "CefTime":
                                            case "CefRect":
                                            case "CefPoint":
                                                {
                                                    //original code return the "value" type
                                                    //we have 2 choices
                                                    //1. copy-by-value
                                                    //2. copy-by-reference

                                                    //---test with copy by reference
                                                    //

                                                    par.ArgExtractCode = ss.Name + "* tmp_d1= new " + ss.Name + "(" + srcExpression + ");\r\n" +
                                                        "MyCefSetVoidPtr(" + destExpression + ",tmp_d1);\r\n";
                                                    return;
                                                }
                                        }
                                    }
                                }
                                break;
                            case PrimitiveTypeKind.CefString:
                                if (stackBased)
                                {
                                    par.ArgExtractCode = "SetCefStringToJsValue(" + destExpression + "," + srcExpression + ");";
                                }
                                else
                                {
                                    par.ArgExtractCode = "SetCefStringToJsValue(" + destExpression + "," + srcExpression + ");";
                                }
                                return;
                            case PrimitiveTypeKind.NaitveInt:
                                par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.size_t:
                                par.ArgExtractCode = "MyCefSetInt32(" + destExpression + ",(int32_t)" + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.Int64:
                                par.ArgExtractCode = "MyCefSetInt64(" + destExpression + "," + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.UInt64:
                                par.ArgExtractCode = "MyCefSetUInt64(" + destExpression + "," + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.Double:
                                par.ArgExtractCode = "MyCefSetDouble(" + destExpression + "," + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.Float:
                                par.ArgExtractCode = "MyCefSetFloat(" + destExpression + "," + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.Bool:
                                par.ArgExtractCode = "MyCefSetBool(" + destExpression + "," + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.UInt32:
                                par.ArgExtractCode = "MyCefSetUInt32(" + destExpression + "," + srcExpression + ");";
                                return;
                            case PrimitiveTypeKind.Int32:
                                par.ArgExtractCode = "MyCefSetInt32(" + destExpression + "," + srcExpression + ");";
                                return;
                        }
                    }
                    break;
            }
            throw new NotSupportedException();

        }

        internal static void PrepareCppMetArg(MethodParameter par, string argName)
        {
            par.ClearExtractCode();
            TypeSymbol typeSymbol = par.TypeSymbol;
            TypeBridgeInfo bridge = typeSymbol.BridgeInfo;
            switch (typeSymbol.TypeSymbolKind)
            {
                default:

                    break;
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol simpleType = (SimpleTypeSymbol)typeSymbol;
                        if (simpleType.IsEnum)
                        {
                            //.net send enum as int32 
                            par.ArgExtractCode = "(" + simpleType.ToString() + ")" + argName + "->i32";//review here
                        }
                        else
                        {
                            switch (simpleType.PrimitiveTypeKind)
                            {
                                default:
                                    break;
                                case PrimitiveTypeKind.size_t: //uint32                                     
                                    par.ArgExtractCode = argName + "->" + bridge.CefCppSlotName;//review here
                                    break;
                                case PrimitiveTypeKind.Bool:
                                    par.ArgExtractCode = argName + "->" + bridge.CefCppSlotName + " !=0 ";//review here
                                    break;
                                case PrimitiveTypeKind.NotPrimitiveType:
                                    par.ArgExtractCode = "(" + simpleType.ToString() + "*)" + argName + "->" + bridge.CefCppSlotName;
                                    break;
                                case PrimitiveTypeKind.NaitveInt:
                                case PrimitiveTypeKind.Int32:
                                case PrimitiveTypeKind.Int64:
                                case PrimitiveTypeKind.UInt32:
                                case PrimitiveTypeKind.Float:
                                case PrimitiveTypeKind.Double:
                                    par.ArgExtractCode = argName + "->" + bridge.CefCppSlotName;
                                    break;
                            }
                        }
                    }
                    break;
                case TypeSymbolKind.TypeDef:
                    {
                        //eg. FileDialogMode
                        //check refer to 
                        //eg CefProcessId
                        CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)typeSymbol;
                        TypeSymbol referTo = ctypedef.ReferToTypeSymbol;
                        if (referTo.TypeSymbolKind == TypeSymbolKind.Simple)
                        {
                            SimpleTypeSymbol ss = (SimpleTypeSymbol)referTo;
                            if (ss.IsEnum)
                            {
                                if (ctypedef.ParentType != null && !ctypedef.ParentType.IsGlobalCompilationUnitTypeDefinition)
                                {
                                    par.ArgExtractCode = "(" + ctypedef.ParentType + "::" + ctypedef.ToString() + ")" + argName + "->i32";
                                }
                                else
                                {
                                    par.ArgExtractCode = "(" + ctypedef.ToString() + ")" + argName + "->i32";
                                }

                            }
                            else if (ss.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                            {


                            }
                            else if (ss.PrimitiveTypeKind == PrimitiveTypeKind.UInt32)
                            {
                                //cef_color_t
                                par.ArgExtractCode = "(" + ctypedef.ToString() + ")" + argName + "->i32";//review here
                            }
                            else
                            {
                                par.ArgExtractCode = argName + "->" + bridge.CefCppSlotName;//review here
                            }
                        }
                        else
                        {

                        }

                    }
                    break;
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        ReferenceOrPointerTypeSymbol refOrPtr = (ReferenceOrPointerTypeSymbol)typeSymbol;
                        switch (refOrPtr.Kind)
                        {
                            default:
                                break;
                            case ContainerTypeKind.CefRawPtr:
                            case ContainerTypeKind.Pointer:
                                {
                                    TypeBridgeInfo bridgeInfo = refOrPtr.BridgeInfo;
                                    TypeSymbol elemtType = refOrPtr.ElementType;
                                    if (elemtType is SimpleTypeSymbol)
                                    {
                                        SimpleTypeSymbol ss = (SimpleTypeSymbol)elemtType;
                                        string elem_typename = ss.ToString();
                                        switch (elem_typename)
                                        {
                                            default:
                                                {

                                                }
                                                break;
                                            case "CefSchemeRegistrar":
                                                {
                                                    string slotName = bridge.CefCppSlotName.ToString();
                                                    par.ArgExtractCode = "(CefSchemeRegistrar*)" + argName + "->" + slotName;//direct cast
                                                }
                                                break;
                                            case "void":
                                                {
                                                    //void*
                                                    string slotName = bridge.CefCppSlotName.ToString();
                                                    par.ArgExtractCode = "(void*)" + argName + "->" + slotName;//direct cast
                                                }
                                                break;
                                            case "char":
                                                {
                                                    //char*
                                                    string slotName = bridge.CefCppSlotName.ToString();
                                                    par.ArgExtractCode = argName + "->" + slotName;
                                                }
                                                break;
                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                                break;
                            case ContainerTypeKind.CefRefPtr:
                                {
                                    //from cef 'smart' pointer

                                    TypeBridgeInfo bridgeInfo = refOrPtr.BridgeInfo;
                                    TypeSymbol elemtType = refOrPtr.ElementType;
                                    if (elemtType is SimpleTypeSymbol)
                                    {
                                        CefTypeTx txplan = ((SimpleTypeSymbol)elemtType).CefTxPlan;
                                        if (txplan == null)
                                        {
                                            if (elemtType.ToString() == "CefBaseRefCounted")
                                            {
                                                //bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
                                                //only 1 
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = argName + "->" + slotName;
                                            }
                                            else
                                            {
                                                throw new NotSupportedException();
                                            }
                                        }
                                        else
                                        {
                                            CodeTypeDeclaration implTypeDecl = txplan.ImplTypeDecl;
                                            ImplWrapDirection implWrapDirection = ImplWrapDirection.None;
                                            CodeTypeDeclaration implBy = txplan.ImplTypeDecl;
                                            if (implTypeDecl.Name.Contains("CToCpp"))
                                            {
                                                //so if you want to send this to client lib
                                                //you need to GET raw pointer , so =>
                                                string unwrapType = txplan.UnderlyingCType.ToString();
                                                //since this is CefRefPtr 
                                                //so after ElementType we should get pointer of the underlying element 
                                                string auto_p = "p_" + par.Name;
                                                par.CppUnwrapType = unwrapType + "*";
                                                par.CppUnwrapMethod = implBy.Name + "::Unwrap";
                                                par.CppWrapMethod = implBy.Name + "::Wrap";

                                                implWrapDirection = ImplWrapDirection.CToCpp;
                                                string met = GetSmartPointerMet(implWrapDirection);
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = implTypeDecl.Name + "::" + met + "(" + "(" + txplan.UnderlyingCType + "*)" + (argName + "->" + slotName) + ")";

                                            }
                                            else if (implTypeDecl.Name.Contains("CppToC"))
                                            {
                                                implWrapDirection = ImplWrapDirection.CppToC;
                                                string met = GetSmartPointerMet(implWrapDirection);
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = implTypeDecl.Name + "::" + met + "(" + "(" + txplan.UnderlyingCType + "*)" + (argName + "->" + slotName) + ")";
                                            }
                                            else
                                            {
                                                implWrapDirection = ImplWrapDirection.None;
                                                string met = GetSmartPointerMet(implWrapDirection);
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = implTypeDecl.Name + "::" + met + "(" + (argName + "->" + slotName) + ")";

                                            }
                                        }
                                    }
                                    else
                                    {
                                        //should not visit here
                                        throw new NotSupportedException();
                                    }
                                }
                                break;
                            case ContainerTypeKind.ByRef:
                                {
                                    TypeSymbol elemType = refOrPtr.ElementType;
                                    switch (elemType.TypeSymbolKind)
                                    {
                                        default:
                                            break;
                                        case TypeSymbolKind.Simple:
                                            {

                                                string elem_typename = refOrPtr.ElementType.ToString();
                                                switch (elem_typename)
                                                {
                                                    default:
                                                        throw new NotSupportedException();
                                                    case "CefTime":
                                                        {
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((CefTime*)" + argName + "->" + slotName + ")";

                                                        }
                                                        break;
                                                    case "bool"://bool&
                                                        {
                                                            //eg. bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((bool*)" + argName + "->" + slotName + ")";

                                                            //par.ArgExtractCode = "&tmp_" + argName;
                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + " tmp_" + argName + "=" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                        }
                                                        break;
                                                    case "size_t":
                                                        {
                                                            //size_t&
                                                            //bool GetDataResource(int resource_id, void*&data,size_t & data_size)
                                                            //bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)

                                                            //string slotName = bridge.CefCppSlotName.ToString();

                                                            //par.ArgExtractCode = "&tmp_" + argName;
                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + " tmp_" + argName + "=" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((size_t*)" + argName + "->" + slotName + ")";

                                                        }
                                                        break;
                                                    case "float": //float&
                                                        {
                                                            //eg. bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)

                                                            //string slotName = bridge.CefCppSlotName.ToString();

                                                            //par.ArgExtractCode = "&tmp_" + argName;
                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + " tmp_" + argName + "=" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((float*)" + argName + "->" + slotName + ")";

                                                        }
                                                        break;
                                                    case "int":
                                                        {
                                                            //eg .bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)

                                                            //string slotName = bridge.CefCppSlotName.ToString();

                                                            //par.ArgExtractCode = "&tmp_" + argName;
                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + " tmp_" + argName + "=" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((int*)" + argName + "->" + slotName + ")";
                                                        }
                                                        break;
                                                    case "CefWindowInfo":
                                                    case "CefPoint":
                                                    case "CefSize":
                                                    case "CefRect":
                                                    case "CefRange":
                                                        {
                                                            //eg. void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
                                                            //eg. void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)

                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "&tmp_" + argName;

                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + "* tmp_" + argName + "=" + "(*" + elem_typename + ")" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";
                                                        }
                                                        break;
                                                    case "CefString":
                                                        {
                                                            //CefString&
                                                            //known type names  
                                                            par.ArgExtractCode = "GetStringHolder(" + argName + ")->value"; //CefString          
                                                            //if (!par.IsConst)
                                                            //{

                                                            //}
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case TypeSymbolKind.ReferenceOrPointer:
                                            {
                                                string elem_typename = refOrPtr.ElementType.ToString();
                                                switch (elem_typename)
                                                {
                                                    default:

                                                        break;
                                                    case "void*":
                                                        {
                                                            //eg. bool GetDataResource(int resource_id,void*& data,size_t& data_size)
                                                            //string slotName = bridge.CefCppSlotName.ToString();

                                                            //par.ArgExtractCode = "&tmp_" + argName;
                                                            //if (par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + " tmp_" + argName + "=" + "(*" + elem_typename + ")" + argName + "->" + slotName;
                                                            //}
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";
                                                        }
                                                        break;
                                                    case "CefRefPtr<CefV8Value>":
                                                        {
                                                            //eg. bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
                                                            if (par.IsConst)
                                                            {

                                                            }
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";
                                                        }
                                                        break;
                                                    case "CefRefPtr<CefV8Exception>":
                                                        {
                                                            //eg. bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
                                                            if (par.IsConst)
                                                            {

                                                            }
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case TypeSymbolKind.Vec:
                                            {
                                                string elem_typename = refOrPtr.ElementType.ToString();
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";

                                                //switch (elem_typename)
                                                //{
                                                //    default:
                                                //        break;
                                                //    case "vec<CefString>":
                                                //        {
                                                //            //eg. void GetArgv(std::vector<CefString>& argv)
                                                //            //eg. bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
                                                //            //eg. void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)   
                                                //        }
                                                //        break;
                                                //    case "vec<int64>":
                                                //        {
                                                //            //eg. void GetFrameIdentifiers(std::vector<int64>& identifiers)
                                                //        }
                                                //        break;
                                                //    case "vec<CefCompositionUnderline>":
                                                //        {

                                                //        }
                                                //        break;
                                                //}
                                            }
                                            break;
                                        case TypeSymbolKind.Template:
                                            break;
                                        case TypeSymbolKind.TypeDef:
                                            {
                                                //eg. void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
                                                CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)elemType;

                                                if (ctypedef.ParentType != null && !ctypedef.ParentType.IsGlobalCompilationUnitTypeDefinition)
                                                {
                                                    string elem_typename = refOrPtr.ElementType.ToString();
                                                    string slotName = bridge.CefCppSlotName.ToString();
                                                    par.ArgExtractCode = "*((" + ctypedef.ParentType + "::" + elem_typename + "*)" + argName + "->" + slotName + ")";

                                                }
                                                else
                                                {
                                                    string elem_typename = refOrPtr.ElementType.ToString();
                                                    string slotName = bridge.CefCppSlotName.ToString();
                                                    par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";
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

        }

        internal static string GetCsRetName(TypeSymbol retType)
        {
            //return type from cs
            switch (retType.TypeSymbolKind)
            {
                default:
                    break;
                case TypeSymbolKind.TypeDef:
                    {
                        CTypeDefTypeSymbol typedef = (CTypeDefTypeSymbol)retType;
                        TypeSymbol referToType = typedef.ReferToTypeSymbol;
                        if (referToType.TypeSymbolKind == TypeSymbolKind.Simple)
                        {
                            SimpleTypeSymbol ss = (SimpleTypeSymbol)referToType;
                            if (ss.CreatedByTypeDeclaration != null)
                            {
                                if (ss.CreatedByTypeDeclaration.Kind == TypeKind.Enum)
                                {
                                    return ss.CreatedByTypeDeclaration.Name;
                                }
                            }
                            else
                            {
                                return "IntPtr";
                            }
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    break;
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol ss = (SimpleTypeSymbol)retType;
                        switch (ss.PrimitiveTypeKind)
                        {
                            default:
                                throw new NotSupportedException();
                            case PrimitiveTypeKind.Bool:
                                return "bool";
                            case PrimitiveTypeKind.CefString:
                                return "string";
                            case PrimitiveTypeKind.Double:
                                return "double";
                            case PrimitiveTypeKind.Float:
                                return "float";
                            case PrimitiveTypeKind.NaitveInt:
                                return "int";
                            case PrimitiveTypeKind.Int32:
                                return "int";
                            case PrimitiveTypeKind.Int64:
                                return "long";
                            case PrimitiveTypeKind.NotPrimitiveType:
                                {
                                    if (ss.IsEnum)
                                    {
                                        return ss.Name;
                                    }
                                    else
                                    {
                                        return ss.Name;
                                    }
                                }
                                break;
                            case PrimitiveTypeKind.size_t:
                                return "uint";
                            case PrimitiveTypeKind.UInt32:
                                return "uint";
                            case PrimitiveTypeKind.UInt64:
                                return "ulong";
                            case PrimitiveTypeKind.Void:
                                return "void";
                        }
                    }
                    break;
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        ReferenceOrPointerTypeSymbol refOrPtr = (ReferenceOrPointerTypeSymbol)retType;
                        TypeSymbol elemType = refOrPtr.ElementType;
                        switch (elemType.TypeSymbolKind)
                        {
                            default:
                                throw new NotSupportedException();
                            case TypeSymbolKind.ReferenceOrPointer:
                                {
                                    //eg. bool GetDataResource(int resource_id,void*& data,size_t& data_size)                                    
                                    switch (elemType.ToString())
                                    {
                                        default:
                                            break;
                                        case "CefRefPtr<CefClient>":
                                            return "IntPtr";
                                        case "CefRefPtr<CefV8Exception>":
                                        case "CefRefPtr<CefV8Value>":
                                            return "ref IntPtr";
                                        case "void*":
                                            return "IntPtr";
                                    }
                                }
                                break;
                            case TypeSymbolKind.TypeDef:
                                {
                                    CTypeDefTypeSymbol typedef = (CTypeDefTypeSymbol)elemType;

                                    switch (typedef.Name)
                                    {
                                        default:
                                            throw new NotSupportedException();
                                        case "CefCursorInfo":
                                        case "CefPopupFeatures":
                                        case "cef_color_t":
                                        case "CefKeyEvent":
                                        case "CefMouseEvent":
                                        case "CefBrowserSettings":
                                        case "CefPdfPrintSettings":
                                        case "SwitchMap":
                                        case "ArgumentList":
                                        case "AttributeMap":
                                        case "CefCookie":
                                        case "PageRangeList":
                                        case "HeaderMap":
                                        case "ElementVector":
                                        case "CefV8ValueList":
                                        case "KeyList":
                                        case "IssuerChainBinaryList":
                                        case "CefRequestContextSettings":
                                            return typedef.Name;
                                    }


                                }
                                break;
                            case TypeSymbolKind.Vec:
                                {
                                    VecTypeSymbol vec = (VecTypeSymbol)elemType;
                                    TypeSymbol elem = vec.ElementType;
                                    switch (elem.TypeSymbolKind)
                                    {
                                        default:
                                            throw new NotSupportedException();
                                        case TypeSymbolKind.ReferenceOrPointer:
                                            {
                                                string name = elem.ToString();
                                                switch (name)
                                                {
                                                    case "CefRefPtr<CefX509Certificate>":
                                                        return "CefX509CertificateList";
                                                }

                                                //list of a smart pointer object
                                            }
                                            break;
                                        case TypeSymbolKind.TypeDef:
                                            {
                                                CTypeDefTypeSymbol typedef = (CTypeDefTypeSymbol)elem;
                                                switch (typedef.Name)
                                                {
                                                    default:
                                                        throw new NotSupportedException();
                                                    case "CefCompositionUnderline":
                                                        return "List<CefCompositionUnderline>";
                                                }
                                            }
                                            break;
                                        case TypeSymbolKind.Simple:
                                            {
                                                SimpleTypeSymbol ss = (SimpleTypeSymbol)elem;
                                                switch (ss.PrimitiveTypeKind)
                                                {
                                                    default:
                                                        throw new NotSupportedException();
                                                    case PrimitiveTypeKind.NotPrimitiveType:
                                                        switch(ss.ToString())
                                                        {
                                                            case "CefDraggableRegion":
                                                                return "CefDraggableRegionList";
                                                            case "CefRect":
                                                                return "CefRectList";
                                                            default:
                                                                return "List<object>";
                                                        }
                                                         
                                                    case PrimitiveTypeKind.Int64:
                                                        //list of unit
                                                        return "List<long>";
                                                    case PrimitiveTypeKind.String:
                                                        return "List<string>";
                                                    case PrimitiveTypeKind.CefString:
                                                        return "List<string>";

                                                }
                                            }
                                    }
                                }
                                break;
                            case TypeSymbolKind.Simple:
                                {
                                    SimpleTypeSymbol ss = (SimpleTypeSymbol)elemType;

                                    switch (ss.PrimitiveTypeKind)
                                    {
                                        default:
                                            throw new NotSupportedException();
                                        case PrimitiveTypeKind.Char:
                                            //pointer or reference of char
                                            return "ref IntPtr";
                                        case PrimitiveTypeKind.Bool:
                                            return "ref bool";
                                        case PrimitiveTypeKind.CefString:
                                            return "ref string";
                                        case PrimitiveTypeKind.Double:
                                            return "ref  double";
                                        case PrimitiveTypeKind.Float:
                                            return "ref float";
                                        case PrimitiveTypeKind.NaitveInt:
                                        case PrimitiveTypeKind.Int32:
                                            return "ref int";
                                        case PrimitiveTypeKind.Int64:
                                            return "ref long";
                                        case PrimitiveTypeKind.NotPrimitiveType:
                                            //ref of this simple type
                                            return ss.Name;
                                        case PrimitiveTypeKind.size_t:
                                            return "ref uint";
                                        case PrimitiveTypeKind.UInt32:
                                            return "ref uint";
                                        case PrimitiveTypeKind.UInt64:
                                            return "ref ulong";
                                        case PrimitiveTypeKind.Void:
                                            //request void* 
                                            //change this to IntPtr
                                            return "ref IntPtr";
                                    }

                                }
                                break;
                        }
                    }
                    break;

            }

            throw new NotSupportedException();
        }

        internal static string PrepareDataFromNativeToCs(TypeSymbol ret, string retName, string autoRetResultName)
        {

            //check if we need some clean up code after return to client  
            switch (ret.TypeSymbolKind)
            {
                default:
                    break;
                case TypeSymbolKind.TypeDef:
                    {
                        CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)ret;
                        //from native type def  
                        TypeSymbol referToType = ctypedef.ReferToTypeSymbol;
                        if (referToType.TypeSymbolKind == TypeSymbolKind.Simple)
                        {
                            SimpleTypeSymbol ss = (SimpleTypeSymbol)referToType;
                            if (ss.IsEnum)
                            {
                                //return "var " + autoRetResultName + "= (" + referToType.ToString() + ")ret.I32;\r\n";
                                return " return (" + referToType.ToString() + ")" + retName + ".I32;\r\n";
                            }
                        }
                        return "return " + retName + ".Ptr;";
                        //return "IntPtr " + autoRetResultName + "= ret.Ptr;";

                    }
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        ReferenceOrPointerTypeSymbol refOrPtr = (ReferenceOrPointerTypeSymbol)ret;
                        switch (refOrPtr.Kind)
                        {
                            default:
                            case ContainerTypeKind.ByRef:
                                throw new NotSupportedException();
                            case ContainerTypeKind.CefRefPtr:
                                {
                                    //the result is inner pointer from cef 'smart' pointer
                                    TypeSymbol elemType = refOrPtr.ElementType;
                                    //return "var " + autoRetResultName + "= new " + elemType + "(ret.Ptr);";
                                    return "return new " + elemType + "(" + retName + ".Ptr);";
                                }
                        }
                    }
                case TypeSymbolKind.Simple:
                    {
                        SimpleTypeSymbol simpleType = (SimpleTypeSymbol)ret;
                        switch (simpleType.PrimitiveTypeKind)
                        {
                            default:
                                break;
                            case PrimitiveTypeKind.Void:
                                return null;
                            case PrimitiveTypeKind.NotPrimitiveType:
                                {
                                    SimpleTypeSymbol ss = (SimpleTypeSymbol)simpleType;
                                    if (ss.IsEnum)
                                    {
                                        //enum ,
                                        //cast from i32 to specific enum type
                                        //return "var " + autoRetResultName + "=(" + simpleType.Name + ")" + retName + ".I32;\r\n";
                                        return "return (" + simpleType.Name + ")" + retName + ".I32;\r\n";
                                    }
                                    else
                                    {
                                        switch (ss.Name)
                                        {
                                            default:
                                                {

                                                }
                                                break;
                                            case "CefTime":
                                            case "CefRect":
                                            case "CefPoint":
                                                {
                                                    //original code return the "value" type
                                                    //we have 2 choices
                                                    //1. copy-by-value
                                                    //2. copy-by-reference

                                                    //---test with copy by reference
                                                    //
                                                    // return "var " + autoRetResultName + "= new " + ss.Name + "(" + retName + ".Ptr);\r\n";
                                                    return "return new " + ss.Name + "(" + retName + ".Ptr);\r\n";
                                                }
                                        }
                                    }
                                }
                                break;
                            case PrimitiveTypeKind.CefString:
                                //get string from native side
                                //and we not need this CefString anymore,=> delete it too
                                //
                                //NativeMyCefStringHolder ret_str = new NativeMyCefStringHolder(ret.Ptr);
                                //string url = ret_str.ReadString(ret.I32);
                                //ret_str.Dispose();
                                //return "var " + autoRetResultName + "= " + "Cef3Binder.CopyStringAndDestroyNativeSide(ref " + retName + ");";
                                return "return Cef3Binder.CopyStringAndDestroyNativeSide(ref " + retName + ");";
                            case PrimitiveTypeKind.NaitveInt:
                                //return "var " + autoRetResultName + "= " + retName + ".I32;";
                                return "return " + retName + ".I32;";
                            case PrimitiveTypeKind.Int64:
                                //return "var " + autoRetResultName + "= " + retName + ".I64;";
                                return "return " + retName + ".I64;";
                            case PrimitiveTypeKind.UInt64:
                                //return "var " + autoRetResultName + "=  (ulong)" + retName + ".I64;";
                                return "return (ulong)" + retName + ".I64;";
                            case PrimitiveTypeKind.Double:
                                //return "var " + autoRetResultName + "=  " + retName + ".Num;";
                                return "return " + retName + ".Num;";
                            case PrimitiveTypeKind.Float:
                                //return "var " + autoRetResultName + "= (float)" + retName + ".Num;";
                                return "return (float)" + retName + ".Num;";
                            case PrimitiveTypeKind.Bool:
                                //return "var " + autoRetResultName + "=" + retName + ".I32 !=0;";
                                return "return " + retName + ".I32 !=0;";
                            case PrimitiveTypeKind.size_t:
                            case PrimitiveTypeKind.UInt32:
                                //return "var " + autoRetResultName + "= (uint)" + retName + ".I32;";
                                return "return (uint)" + retName + ".I32;";
                            case PrimitiveTypeKind.Int32:
                                //return "var " + autoRetResultName + "= " + retName + ".I32;";
                                return "return " + retName + ".I32;";
                        }
                    }
                    break;
            }
            throw new NotSupportedException();

        }


        protected static void AddComment(Token[] lineTokens, CodeStringBuilder builder)
        {
            CodeGenUtils.AddComment(lineTokens, builder);
        }
    }




}