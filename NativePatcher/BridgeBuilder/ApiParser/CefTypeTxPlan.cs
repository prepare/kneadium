//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{
    //cef -specfic 
    class CodeStringBuilder
    {
        StringBuilder stbuilder = new StringBuilder();
#if DEBUG
        static int _dbugLineCount;
        bool _dbugEnableLineNote = true;
#endif
        public void EnterIndentLevel()
        {

        }
        public void ExitIndentLevel()
        {

        }
        public void AppendLine(string text)
        {
#if DEBUG
            dbugIncLineCount();
#endif
            stbuilder.AppendLine(text);
        }
        public void AppendLine()
        {
#if DEBUG
            dbugIncLineCount();
#endif
            stbuilder.AppendLine();
        }
#if DEBUG
        void dbugIncLineCount()
        {

            _dbugLineCount++;
            if (_dbugEnableLineNote)
            {
                // stbuilder.AppendLine("/*" + _dbugLineCount + "*/");
                //if (_dbugLineCount >= 14863)
                //{

                //}
            }

        }
#endif

        public void Append(string text)
        {
            stbuilder.Append(text);
        }
        public override string ToString()
        {
            return stbuilder.ToString();
        }
    }


    abstract class CefTypeTxPlan : TypeTxPlan
    {
        CodeTypeDeclaration _implDecl;

#if DEBUG
        protected int _dbug_cpp_count = 0;
#endif
        public CefTypeTxPlan(CodeTypeDeclaration originalDecl)
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

        public virtual void GenerateCppCode(CodeStringBuilder stbuilder)
        {

        }
        public virtual void GenerateCsCode(CodeStringBuilder stbuilder)
        {

        }

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
        internal static void PrepareDataFromNativeToCs(MethodParameterTxInfo par, string destExpression, string srcExpression)
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
                                                par.ArgExtractCode = "SetCefStringToJsValue(" + destExpression + "," + srcExpression + ");";
                                                //need StringHolder cleanup
                                                par.ArgPostExtractCode = "DeleteCefStringHolderFromJsValue(" + destExpression + ");";

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
                                                    CefTypeTxPlan txPlan = simpleElem.CefTxPlan;
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
                                            CefTypeTxPlan txPlan = simpleElem.CefTxPlan;
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

                                                if (implBy.Name.Contains("CToCpp"))
                                                {
                                                    //so if you want to send this to client lib
                                                    //you need to GET raw pointer , so =>

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
                                par.ArgExtractCode = "SetCefStringToJsValue(" + destExpression + "," + srcExpression + ");";
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

        internal static void PrepareCppMetArg(MethodParameterTxInfo par, string argName)
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
                                        CefTypeTxPlan txplan = ((SimpleTypeSymbol)elemtType).CefTxPlan;
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
                                            if (implTypeDecl.Name.Contains("CToCpp"))
                                            {
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




                                                ////typedef 
                                                //string elem_typename = refOrPtr.ElementType.ToString();
                                                //switch (elem_typename)
                                                //{
                                                //    default:
                                                //        break;
                                                //    case "CefBrowserSettings":
                                                //    case "CefPdfPrintSettings":
                                                //    //eg. void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
                                                //    case "CefKeyEvent":
                                                //    case "CefMouseEvent":
                                                //    //eg. void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
                                                //    case "CefCookie":
                                                //    //eg. bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
                                                //    //

                                                //    case "AttributeMap":
                                                //    case "ElementVector":
                                                //    //eg. {bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)}
                                                //    case "HeaderMap":
                                                //    case "SwitchMap":
                                                //    //eg. void GetSwitches(SwitchMap& switches)
                                                //    case "cef_color_t":
                                                //    //eg. bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
                                                //    case "ArgumentList":
                                                //    //eg. void GetArguments(ArgumentList& arguments)
                                                //    case "CefV8ValueList":
                                                //    //eg. CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
                                                //    case "IssuerChainBinaryList":
                                                //    //eg {void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)}
                                                //    case "PageRangeList":
                                                //    case "KeyList":     //eg. {bool GetKeys(KeyList& keys)}                                                
                                                //        {

                                                //        }
                                                //        break;
                                                //}
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
                                        case "CefRefPtr<CefV8Value>":
                                            return "IntPtr";
                                        case "void*":
                                            return "IntPtr";
                                        case "CefRefPtr<CefV8Exception>":
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
                                                        return "List<CefCompositionUnderline>";
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
                                                        return "List<object>";
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
                                            return "IntPtr";
                                        case PrimitiveTypeKind.Bool:
                                            return "ref bool";
                                        case PrimitiveTypeKind.CefString:
                                            return "string";
                                        case PrimitiveTypeKind.Double:
                                            return "ref  double";
                                        case PrimitiveTypeKind.Float:
                                            return "ref float";
                                        case PrimitiveTypeKind.NaitveInt:
                                        case PrimitiveTypeKind.Int32:
                                            return "ref int";
                                        case PrimitiveTypeKind.Int64:
                                            return "long";
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
                                            return "IntPtr";
                                    }

                                }
                                break;
                        }
                    }
                    break;

            }

            throw new NotSupportedException();
        }

        internal static void PrepareCsMetArg(MethodParameterTxInfo par, string argName)
        {
            par.ClearExtractCode();
            TypeSymbol typeSymbol = par.TypeSymbol;
            TypeBridgeInfo bridge = typeSymbol.BridgeInfo;

            //check if parTx.Name is keyword?
            switch (par.Name)
            {
                case "event":
                    par.Name = "_event";
                    break;
                case "checked":
                    par.Name = "_checked";
                    break;
                case "object":
                    par.Name = "_object";
                    break;

            }
            //-----------------

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
                            par.ArgExtractCode = argName + ".I32=(int)" + par.Name;
                        }
                        else
                        {
                            switch (simpleType.PrimitiveTypeKind)
                            {
                                default:
                                    break;
                                case PrimitiveTypeKind.size_t: //uint32                                     
                                    par.ArgExtractCode = argName + ".I32 = (int)" + par.Name;
                                    break;
                                case PrimitiveTypeKind.Bool:
                                    par.ArgExtractCode = argName + ".I32= " + par.Name + "?1:0";//review here
                                    break;
                                case PrimitiveTypeKind.NotPrimitiveType:
                                    par.ArgExtractCode = "(" + simpleType.ToString() + "*)" + argName + "->" + bridge.CefCppSlotName;
                                    break;
                                case PrimitiveTypeKind.NaitveInt:
                                    par.ArgExtractCode = argName + ".I32= (int)" + par.Name;//review here
                                    break;
                                case PrimitiveTypeKind.Int32:
                                    par.ArgExtractCode = argName + ".I32= " + par.Name;//review here 
                                    break;
                                case PrimitiveTypeKind.UInt32:
                                    {
                                        par.ArgExtractCode = argName + ".I32= (int)" + par.Name;//review here
                                    }
                                    break;
                                case PrimitiveTypeKind.Int64:
                                    {
                                        par.ArgExtractCode = argName + ".I64= " + par.Name;//review here
                                    }
                                    break;
                                case PrimitiveTypeKind.Float:
                                case PrimitiveTypeKind.Double:
                                    par.ArgExtractCode = argName + ".Num = " + par.Name;
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
                                    par.ArgExtractCode = argName + ".I32 = (int)" + par.Name;
                                }
                                else
                                {
                                    par.ArgExtractCode = argName + ".I32 = (int)" + par.Name;
                                }

                            }
                            else if (ss.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                            {


                            }
                            else if (ss.PrimitiveTypeKind == PrimitiveTypeKind.UInt32)
                            {
                                //cef_color_t
                                par.ArgExtractCode = argName + ".I32 = (int)" + par.Name;
                            }
                            else
                            {
                                par.ArgExtractCode = argName + ".I32 = (int)" + par.Name;
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
                                            case "void":
                                                {
                                                    //void* 
                                                    par.ArgExtractCode = argName + ".Ptr=" + par.Name;
                                                }
                                                break;
                                            case "char":
                                                {
                                                    //char* 
                                                    par.ArgExtractCode = argName + ".Ptr=" + par.Name;
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
                                        CefTypeTxPlan txplan = ((SimpleTypeSymbol)elemtType).CefTxPlan;
                                        if (txplan == null)
                                        {
                                            if (elemtType.ToString() == "CefBaseRefCounted")
                                            {
                                                //bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
                                                //only 1 
                                                par.ArgExtractCode = argName + ".Ptr=" + par.Name + ".nativePtr";
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
                                            if (implTypeDecl.Name.Contains("CToCpp"))
                                            {
                                                par.ArgExtractCode = argName + ".Ptr=" + par.Name + ".nativePtr";
                                            }
                                            else if (implTypeDecl.Name.Contains("CppToC"))
                                            {
                                                par.ArgExtractCode = argName + ".Ptr=" + par.Name + ".nativePtr";
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
                                                        break;
                                                    case "bool"://bool&
                                                        {
                                                            //eg. bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)


                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "*((bool*)" + argName + "->" + slotName + ")";

                                                            //par.ArgExtractCode = "&tmp_" + argName;
                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + " tmp_" + argName + "=" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                            par.ArgExtractCode = argName + ".I32=" + "(" + par.Name + "?1:0)";
                                                            par.ArgPostExtractCode = par.Name + "= " + argName + ".I32 != 0;"; //restore result back
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
                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "*((size_t*)" + argName + "->" + slotName + ")";

                                                            par.ArgExtractCode = argName + ".I32= (int)" + par.Name;
                                                            par.ArgPostExtractCode = par.Name + "= (uint)" + argName + ".I32;"; //restore result back
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
                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "*((float*)" + argName + "->" + slotName + ")";

                                                            par.ArgExtractCode = argName + ".Num=" + par.Name;
                                                            par.ArgPostExtractCode = par.Name + "= (float)" + argName + ".Num;"; //restore result back

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
                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "*((int*)" + argName + "->" + slotName + ")";

                                                            //--------------------------------------------------------------------------
                                                            //bring data

                                                            par.ArgExtractCode = argName + ".I32=" + par.Name;
                                                            par.ArgPostExtractCode = par.Name + "= (int)" + argName + ".I32;"; //restore result back
                                                        }
                                                        break;
                                                    case "CefWindowInfo":
                                                    case "CefPoint":
                                                    case "CefSize":
                                                    case "CefRect":
                                                    case "CefRange":
                                                        {

                                                            //create struct at native part?
                                                            //****


                                                            //eg. void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
                                                            //eg. void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)

                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "&tmp_" + argName;

                                                            //if (!par.IsConst)
                                                            //{
                                                            //    par.ArgPreExtractCode = elem_typename + "* tmp_" + argName + "=" + "(*" + elem_typename + ")" + argName + "->" + slotName;
                                                            //    par.ArgPostExtractCode = PrepareCppReturnToCs(par.TypeSymbol, argName, " tmp_" + argName);
                                                            //}
                                                            //string slotName = bridge.CefCppSlotName.ToString();
                                                            //par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + ")";
                                                            par.ArgExtractCode = argName + ".Ptr=" + par.Name + ".nativePtr";
                                                        }
                                                        break;
                                                    case "CefString":
                                                        {
                                                            //native need cefstring
                                                            //so we create a cef string handle holder
                                                            par.ArgPreExtractCode = argName + ".Ptr=" + " Cef3Binder.MyCefCreateCefString(" + par.Name + ");\r\n";
                                                            par.ArgPostExtractCode = "Cef3Binder.MyCefDeletePtr(" + argName + ".Ptr);";
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
                                                            par.ArgExtractCode = argName + ".Ptr=" + par.Name;
                                                            par.ArgPostExtractCode = par.Name + "= " + argName + ".Ptr;"; //restore result back
                                                        }
                                                        break;
                                                    case "CefRefPtr<CefV8Value>":
                                                        {
                                                            //eg. bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
                                                            //if (par.IsConst)
                                                            //{

                                                            //}
                                                            par.ArgExtractCode = argName + ".Ptr=" + par.Name;
                                                            par.ArgPostExtractCode = par.Name + "= " + argName + ".Ptr;"; //restore result back
                                                        }
                                                        break;
                                                    case "CefRefPtr<CefV8Exception>":
                                                        {
                                                            //eg. bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
                                                            //if (par.IsConst)
                                                            //{

                                                            //}
                                                            par.ArgExtractCode = argName + ".Ptr=" + par.Name;
                                                            par.ArgPostExtractCode = par.Name + "= " + argName + ".Ptr;"; //restore result back
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case TypeSymbolKind.Vec:
                                            {
                                                //for cef,...
                                                //list of what

                                                string elem_typename = refOrPtr.ElementType.ToString();
                                                switch (elem_typename)
                                                {
                                                    default:
                                                        throw new NotFiniteNumberException();
                                                    case "std::vector<int64>":
                                                        par.ArgExtractCode = argName + ".Ptr=Cef3Binder.CreateStdList(1)";
                                                        par.ArgPostExtractCode = "Cef3Binder.CopyStdInt64ListAndDestroyNativeSide(" + argName + ".Ptr," + par.Name + ");";

                                                        break;
                                                    case "std::vector<CefString>":
                                                        par.ArgExtractCode = argName + ".Ptr=Cef3Binder.CreateStdList(2)";
                                                        par.ArgPostExtractCode = "Cef3Binder.CopyStdStringListAndDestroyNativeSide(" + argName + ".Ptr," + par.Name + ");";
                                                        break;
                                                    case "std::vector<CefCompositionUnderline>":
                                                        par.ArgExtractCode = argName + ".Ptr=Cef3Binder.CreateStdList(3);";
                                                        break;
                                                }

                                            }
                                            break;
                                        case TypeSymbolKind.Template:
                                            break;
                                        case TypeSymbolKind.TypeDef:
                                            {
                                                //eg. void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
                                                CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)elemType;
                                                par.ArgExtractCode = argName + ".Ptr= " + par.Name + ".nativePtr";

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
            if (lineTokens == null)
            {
                return;
            }
            //
            StringBuilder stbuilder = new StringBuilder();
            int j = lineTokens.Length;
            int lastLine = j - 1;

            stbuilder.Append("/// <summary>\r\n");
            for (int i = 0; i < j; ++i)
            {
                //for cef, special care for first and last line 
                string lineContent = lineTokens[i].Content;
                if (i == 0 || i == lastLine)
                {
                    if (lineContent.StartsWith("///"))
                    {
                        if (lineContent.Substring(3).Trim() == "")
                        {
                            continue; //skip this first and last line comment
                        }
                        else
                        {
                            stbuilder.AppendLine(lineContent);
                        }
                    }
                    else
                    {
                        stbuilder.AppendLine("/" + lineContent);
                    }
                }
                else
                {

                    if (!lineContent.StartsWith("///"))
                    {
                        if (lineContent.StartsWith("//"))
                        {
                            //append one /
                            stbuilder.AppendLine("/" + lineTokens[i].Content);
                            continue;
                        }
                    }
                }
            }
            stbuilder.Append("/// </summary>\r\n");

            builder.Append(stbuilder.ToString());
        }
    }





    /// <summary>
    /// tx plan for callback class
    /// </summary>
    class CefCallbackTxPlan : CefTypeTxPlan
    {
        TypeTxInfo _typeTxInfo;
        CodeTypeDeclaration _currentCodeTypeDecl;


        public CefCallbackTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {
            //this is call back

        }

        void GenerateCppImplMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {


            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)met.metDecl;
            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            stbuilder.Append("virtual " + metDecl.ReturnType + " " + metDecl.Name + "(");
            List<CodeMethodParameter> pars = metDecl.Parameters;
            int j = pars.Count;
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(",");
                }
                CodeMethodParameter par = pars[i];

                if (par.IsConstPar)
                {
                    stbuilder.Append("const ");
                }
                stbuilder.Append(par.ParameterType.ToString() + " ");
                stbuilder.Append(par.ParameterName);
            }
            stbuilder.AppendLine("){");
            //-----------
            stbuilder.AppendLine("if(mcallback){");
            //call to managed 
            stbuilder.AppendLine("MyMetArgsN args;");
            stbuilder.AppendLine("memset(&args, 0, sizeof(MyMetArgsN));");
            stbuilder.AppendLine("args.argCount=" + j + ";");
            if (j > 0)
            {
                stbuilder.AppendLine("jsvalue vargs[" + j + "];");
                stbuilder.AppendLine("args.vargs=vargs;");
                for (int i = 0; i < j; ++i)
                {
                    MethodParameterTxInfo parTx = met.pars[i];
                    parTx.ClearExtractCode();
                    CefTypeTxPlan.PrepareDataFromNativeToCs(parTx, "&vargs[" + i + "]", parTx.Name);
                }
            }
            CefTypeTxPlan.PrepareCppMetArg(met.ReturnPlan, "args.ret");
            //
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                if (parTx.ArgPreExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPreExtractCode);
                }
            }
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                stbuilder.AppendLine(parTx.ArgExtractCode);
            }
            //
            //call a method and get some result back 
            //
            stbuilder.AppendLine("mcallback(" + met.CppMethodSwitchCaseName + ",&args);");
            //post call
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }
            if (!met.ReturnPlan.IsVoid)
            {

            }

            //and return value
            stbuilder.AppendLine("}"); //if(this->mcallback){
            //-----------
            stbuilder.AppendLine("}"); //method
        }
        void GenerateImplClass(
          CodeTypeDeclaration orgDecl,
          List<MethodTxInfo> onEventMethods,
          CodeStringBuilder stbuilder)
        {

            string className = "My" + orgDecl.Name;
            int nn = onEventMethods.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = onEventMethods[mm];
                met.CppMethodSwitchCaseName = className + "_" + met.Name + "_" + (mm + 1);
                stbuilder.AppendLine("const int " + met.CppMethodSwitchCaseName + "=" + (mm + 1) + ";");
            }

            this.CppImplClassNameId = _typeTxInfo.CsInterOpTypeNameId;
            this.CppImplClassName = className;

            //create a cpp class              
            stbuilder.Append("class " + className);
            stbuilder.Append(":public " + orgDecl.Name);
            stbuilder.AppendLine("{");
            //members
            stbuilder.AppendLine("public:");
            stbuilder.AppendLine("managed_callback mcallback;");
            stbuilder.AppendLine("explicit " + className + "(){");
            stbuilder.AppendLine("mcallback= NULL;");
            stbuilder.AppendLine("}");
            //stbuilder.AppendLine("managed_callback GetManagedCallBack() const OVERRIDE { return mcallback; }");

            // 
            nn = onEventMethods.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = onEventMethods[mm];
                //prepare data and call the callback
                GenerateCppImplMethod(met, stbuilder);
            }

            stbuilder.AppendLine("private:");
            stbuilder.AppendLine("IMPLEMENT_REFCOUNTING(" + className + ");");

            stbuilder.AppendLine("};");
        }



        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {

#if DEBUG
            _dbug_cpp_count++;
#endif
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();

            _typeTxInfo = orgDecl.TypeTxInfo;
            _currentCodeTypeDecl = orgDecl;

            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            int maxPar = 0;

            List<MethodTxInfo> onEventMethods = new List<MethodTxInfo>();
            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                if (metTx.metDecl.IsVirtual)
                {
                    //this method need a callback to .net side (.net-side event listener)
                    if (metTx.metDecl.Name.StartsWith("On"))
                    {
                        onEventMethods.Add(metTx);
                    }
                }

                metTx.CppMethodSwitchCaseName = orgDecl.Name + "_" + metTx.Name + "_" + (i + 1);
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                const_methodNames.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "=" + (i + 1) + ";");
            }

            if (onEventMethods.Count > 0)
            {
                GenerateImplClass(
                    orgDecl,
                    onEventMethods,
                    stbuilder);
            }

            MaxMethodParCount = maxPar;
            totalTypeMethod.AppendLine(const_methodNames.ToString());
            //-----------------------------------------------------------------------
            {
                StringBuilder met_sig = new StringBuilder();
                met_sig.Append("void MyCefMet_" + orgDecl.Name + "(" +
                    this.UnderlyingCType.Name + "* me1,int metName,jsvalue* ret");
                for (int i = 0; i < maxPar; ++i)
                {
                    met_sig.Append(",jsvalue* v" + (i + 1));
                }
                met_sig.AppendLine("){");
                totalTypeMethod.Append(met_sig.ToString());
            }

            if (implTypeDecl == null)
            {
                throw new NotSupportedException();
            }
            totalTypeMethod.AppendLine("ret->type = JSVALUE_TYPE_EMPTY;");
            ImplWrapDirection implWrapDirection = ImplWrapDirection.None;
            if (implTypeDecl.Name.Contains("CToCpp"))
            {
                implWrapDirection = ImplWrapDirection.CToCpp;
            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {
                implWrapDirection = ImplWrapDirection.CppToC;
            }
            else
            {
                implWrapDirection = ImplWrapDirection.None;
            }

            totalTypeMethod.AppendLine("auto me=" + implTypeDecl.Name + "::" + GetSmartPointerMet(implWrapDirection) + "(me1);");
            //swicth table is a way that this instance'smethod is called
            //through the bridge  

            totalTypeMethod.AppendLine("switch(metName){");
            totalTypeMethod.AppendLine("case MET_Release:return; //yes, just return");


            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                if (metTx.Name.StartsWith("On"))
                {
                    //cef convention
                    continue;
                }
                met_stbuilder.AppendLine("case " + metTx.CppMethodSwitchCaseName + ":{");

                GenerateCppMethod(_typeTxInfo.methods[i], met_stbuilder);

                met_stbuilder.AppendLine("} break;");

                totalTypeMethod.Append(met_stbuilder.ToString());
            }

            totalTypeMethod.AppendLine("}"); //end switch table
                                             //

            totalTypeMethod.AppendLine(implTypeDecl.Name + "::" + GetRawPtrMet(implWrapDirection) + "(me);");

            totalTypeMethod.AppendLine("}");

            //
            stbuilder.Append(totalTypeMethod.ToString());

        }
        void GenerateCppMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            if (met.CsLeftMethodBodyBlank) return;  //temp here
                                                    //---------------------------------------

            //extract managed args and then call native c++ method
            //----
            MethodParameterTxInfo ret = met.ReturnPlan;
            //----
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 15)
            {
                throw new NotSupportedException();
            }

            //--------------------------- 
            stbuilder.AppendLine();
            stbuilder.Append(
                "\r\n" +
                "// gen! " + met.ToString() + "\r\n"
                );
            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                //prepare some method args
                //get pars from parameter .
                PrepareCppMetArg(pars[i], "v" + (i + 1));
            }
            PrepareDataFromNativeToCs(met.ReturnPlan, "ret", "ret_result");


            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
                {
                    stbuilder.Append(parTx.ArgPreExtractCode);
                }
            }
            //---------------------------
            StringBuilder arglistBuilder = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (i > 0)
                {
                    arglistBuilder.AppendLine(",");
                }
                arglistBuilder.Append(parTx.ArgExtractCode);
            }

            string instThis = "me";
            if (ret.IsVoid)
            {
                //call, no return result
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");

            }
            else
            {
                stbuilder.Append("auto ret_result=");
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");
            }


            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }
            stbuilder.AppendLine(ret.ArgExtractCode);
            //clean up 
        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {

            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;


            //-----------------------------------------------------------------------
            _typeTxInfo = implTypeDecl.TypeTxInfo;
            _currentCodeTypeDecl = implTypeDecl;

            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder csStruct = new CodeStringBuilder();
            int maxPar = 0;

            AddComment(orgDecl.LineComments, csStruct);
            //
            csStruct.AppendLine("public struct " + orgDecl.Name + "{");
            csStruct.AppendLine("const int _typeNAME=" + orgDecl.TypeTxInfo.CsInterOpTypeNameId + ";");

            string releaseMetName = orgDecl.Name + "_Release_0";

            csStruct.AppendLine("const int " + releaseMetName + "= (_typeNAME <<16) | 0;");

            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                if (metTx.CppMethodSwitchCaseName == null)
                {
                    metTx.CppMethodSwitchCaseName = _currentCodeTypeDecl.Name + "_" + metTx.Name;
                    //throw new NotSupportedException();
                }
                csStruct.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "= (_typeNAME <<16) |" + (i + 1) + ";");
            }
            //-----------------------------------------------------------------------
            //create ctor
            csStruct.AppendLine("internal IntPtr nativePtr;");
            csStruct.AppendLine("internal " + orgDecl.Name + "(IntPtr nativePtr){");
            csStruct.AppendLine("this.nativePtr= nativePtr;");
            csStruct.AppendLine("}");
            //-----------------------------------------------------------------------
            //release method for cef instance object
            csStruct.AppendLine("public void Release(){");
            csStruct.AppendLine("JsValue ret;");
            csStruct.AppendLine("Cef3Binder.MyCefMet_Call0(this.nativePtr, " + releaseMetName + ", out ret);");
            csStruct.AppendLine("this.nativePtr= IntPtr.Zero;");
            csStruct.AppendLine("}");

            //-----------------------------------------------------------------------
            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                GenerateCsMethod(metTx, met_stbuilder);
                csStruct.Append(met_stbuilder.ToString());
            }

            csStruct.AppendLine("}");  //close struct

            //
            stbuilder.Append(csStruct.ToString());
        }
        void GenerateCsMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {

            if (met.CsLeftMethodBodyBlank) return;  //temp here 
            //---------------------------------------
            //extract managed args and then call native c++ method 
            MethodParameterTxInfo ret = met.ReturnPlan;
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 15)
            {
                throw new NotSupportedException();
            }
            //--------------------------- 
            //generate method sig 
            //--------------------------- 

            stbuilder.Append(
                "\r\n" +
                "// gen! " + met.ToString() + "\r\n"
                );
            //---------------------------
            AddComment(met.metDecl.LineComments, stbuilder);

            for (int i = 0; i < parCount; ++i)
            {
                //prepare some method args
                //get pars from parameter .                 
                PrepareCsMetArg(pars[i], "v" + (i + 1));
            }

            ret.ArgExtractCode = PrepareDataFromNativeToCs(ret.TypeSymbol, "ret", "ret_result");
            stbuilder.AppendLine();
            //------------------
            stbuilder.Append("public ");
            stbuilder.Append(GetCsRetName(ret.TypeSymbol));
            stbuilder.Append(" ");

            //some method name should be renamed
            if (met.Name == "GetType")
            {
                stbuilder.Append("_" + met.Name);
            }
            else
            {
                stbuilder.Append(met.Name);
            }
            stbuilder.Append("(");
            //---------------------------

            for (int i = 0; i < parCount; ++i)
            {
                if (i > 0)
                {
                    stbuilder.AppendLine(",");
                }
                MethodParameterTxInfo parTx = pars[i];
                stbuilder.Append(GetCsRetName(parTx.TypeSymbol));
                stbuilder.Append(" ");
                stbuilder.Append(parTx.Name);
            }
            stbuilder.Append(")");
            stbuilder.AppendLine("{");


            StringBuilder argList = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                argList.AppendLine("JsValue " + "v" + (i + 1) + "=new JsValue();");
            }
            argList.AppendLine("JsValue ret;");
            stbuilder.Append(argList.ToString());

            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
                {
                    stbuilder.Append(parTx.ArgPreExtractCode);
                }
            }
            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgExtractCode))
                {
                    stbuilder.Append(parTx.ArgExtractCode);
                    stbuilder.AppendLine(";");
                }
            }
            string orgDeclName = this.OriginalDecl.Name;
            stbuilder.AppendLine();//marker

            stbuilder.Append("Cef3Binder.MyCefMet_Call" + parCount + "(");
            stbuilder.Append("this.nativePtr," + met.CppMethodSwitchCaseName + ",out ret");
            for (int i = 0; i < parCount; ++i)
            {
                stbuilder.Append(",ref " + "v" + (i + 1));
            }
            stbuilder.Append(");\r\n");


            //clean up input arg
            //--------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }
            //--------------------

            stbuilder.AppendLine(ret.ArgExtractCode);
            //if (!met.ReturnPlan.IsVoid)
            //{
            //    stbuilder.AppendLine("return ret_result;");
            //}

            stbuilder.AppendLine("}");
        }

    }

    /// <summary>
    /// tx plan for handler class
    /// </summary>
    class CefHandlerTxPlan : CefTypeTxPlan
    {
        TypeTxInfo _typeTxInfo;

        public CefHandlerTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        void GenerateCppImplMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            CodeMethodDeclaration metDecl = met.metDecl;
            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            //temp
            if (metDecl.ReturnType.ToString() == "FilterStatus")
            {
                stbuilder.Append("virtual " + metDecl.ReturnType.ResolvedType + " " + metDecl.Name + "(");
            }
            else
            {
                stbuilder.Append("virtual " + metDecl.ReturnType + " " + metDecl.Name + "(");
            }


            List<CodeMethodParameter> pars = metDecl.Parameters;
            int j = pars.Count;
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(",");
                }
                CodeMethodParameter par = pars[i];

                if (par.IsConstPar)
                {
                    stbuilder.Append("const ");
                }
                stbuilder.Append(par.ParameterType.ToString() + " ");
                stbuilder.Append(par.ParameterName);
            }
            stbuilder.AppendLine("){");
            //-----------
            stbuilder.AppendLine("if(mcallback){");
            //call to managed 
            stbuilder.AppendLine("MyMetArgsN args;");
            stbuilder.AppendLine("memset(&args, 0, sizeof(MyMetArgsN));");
            stbuilder.AppendLine("args.argCount=" + j + ";");
            if (j > 0)
            {
                stbuilder.AppendLine("jsvalue vargs[" + j + "];");
                stbuilder.AppendLine("args.vargs=vargs;");

                for (int i = 0; i < j; ++i)
                {
                    MethodParameterTxInfo parTx = met.pars[i];
                    parTx.ClearExtractCode();
                    PrepareDataFromNativeToCs(parTx, "&vargs[" + i + "]", parTx.Name);
                }
            }
            PrepareCppMetArg(met.ReturnPlan, "args.ret");
            //
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                if (parTx.ArgPreExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPreExtractCode);
                }
            }
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                stbuilder.AppendLine(parTx.ArgExtractCode);
            }
            //
            //call a method and get some result back 
            //
            stbuilder.AppendLine("mcallback(" + met.CppMethodSwitchCaseName + ",&args);");

            //post call
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }

            //temp fix, arg extract code 
            if (!met.ReturnPlan.IsVoid)
            {
                stbuilder.AppendLine("return " + met.ReturnPlan.ArgExtractCode.Replace("->", ".") + ";");
            }
            //and return value
            stbuilder.AppendLine("}"); //if(this->mcallback){

            //-----------

            if (!met.ReturnPlan.IsVoid)
            {
                string retTypeName = metDecl.ReturnType.ToString();
                if (retTypeName.StartsWith("CefRefPtr<"))
                {
                    stbuilder.Append("return nullptr;");
                }
                else
                {
                    switch (metDecl.ReturnType.ToString())
                    {
                        case "bool":
                            stbuilder.Append("return false;");
                            break;
                        case "FilterStatus": //TODO: revisit here
                            stbuilder.Append("return (FilterStatus)0;");
                            break;
                        case "ReturnValue":
                            stbuilder.Append("return (ReturnValue)0;");
                            break;
                        case "CefSize":
                            stbuilder.Append("throw new CefNotImplementException();");
                            break;
                        case "size_t":
                            stbuilder.Append("return 0;");
                            break;
                        case "int":
                            stbuilder.Append("return 0;");
                            break;
                        case "int64":
                            stbuilder.Append("return 0;");
                            break;
                        default:
                            throw new NotSupportedException();

                    }
                }
            }

            stbuilder.AppendLine("}"); //method
        }

        void GenerateCppImplClass(CodeTypeDeclaration orgDecl, List<MethodTxInfo> callToDotNetMets, CodeStringBuilder stbuilder)
        {

            string className = "My" + orgDecl.Name;
            int nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];
                met.CppMethodSwitchCaseName = className + "_" + met.Name + "_" + (mm + 1);
                stbuilder.AppendLine("const int " + met.CppMethodSwitchCaseName + "=" + (mm + 1) + ";");
            }

            //create a cpp class              
            stbuilder.Append("class " + className);
            stbuilder.Append(":public " + orgDecl.Name);
            stbuilder.AppendLine("{");
            //members
            stbuilder.AppendLine("public:");
            stbuilder.AppendLine("managed_callback mcallback;");
            stbuilder.AppendLine("explicit " + className + "(){");
            stbuilder.AppendLine("mcallback= NULL;");
            stbuilder.AppendLine("}");
            //stbuilder.AppendLine("managed_callback GetManagedCallBack() const OVERRIDE { return mcallback; }");

            //
            this.CppImplClassNameId = _typeTxInfo.CsInterOpTypeNameId;
            this.CppImplClassName = className;

            nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];
                //prepare data and call the callback
                GenerateCppImplMethod(met, stbuilder);
            }
            //private member
            stbuilder.AppendLine("private:");
            stbuilder.AppendLine("IMPLEMENT_REFCOUNTING(" + className + ");");
            stbuilder.AppendLine("};");
        }


        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();


            if (implTypeDecl.Name.Contains("CppToC"))
            {
                _typeTxInfo = orgDecl.TypeTxInfo;
            }
            else
            {
                _typeTxInfo = implTypeDecl.TypeTxInfo;
            }

            //-----------------------------------------------------------------------
            List<MethodTxInfo> callToDotNetMets = new List<MethodTxInfo>();
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            int maxPar = 0;
            int j = _typeTxInfo.methods.Count;

            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                metTx.CppMethodSwitchCaseName = orgDecl.Name + "_" + metTx.Name + "_" + (i + 1);
                //-----------------
                CodeMethodDeclaration codeMethodDecl = metTx.metDecl;
                if (codeMethodDecl.IsAbstract || codeMethodDecl.IsVirtual)
                {
                    callToDotNetMets.Add(metTx);
                }
                //-----------------

                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                const_methodNames.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "=" + (i + 1) + ";");
            }
            totalTypeMethod.AppendLine(const_methodNames.ToString());
            //-----------------------------------------------------------------------



            if (callToDotNetMets.Count > 0)
            {
                GenerateCppImplClass(orgDecl, callToDotNetMets, stbuilder);
            }

        }
        void GenerateCppMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            //
            //generate calling code( to .net side)
            //--------------------------- 
            stbuilder.AppendLine();
            stbuilder.Append(
                "\r\n" +
                "// gen! " + met.ToString() + "\r\n"
                );
            //---------------------------


            stbuilder.AppendLine("MetArgs args;");
            stbuilder.AppendLine("memset(&args, 0, sizeof(MetArgs));");
            //
            //each arg, set data from cpp's managed arg to .net 
            int j = met.pars.Count;
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                PrepareDataFromNativeToCs(parTx, "&args.v" + (i + 1), parTx.Name);
            }
            PrepareCppMetArg(met.ReturnPlan, "args.ret");

            //
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                stbuilder.AppendLine(parTx.ArgExtractCode);
            }

            //
            stbuilder.AppendLine("mcallback_(" + met.CppMethodSwitchCaseName + ", &args)");
            if (!met.ReturnPlan.IsVoid)
            {
                stbuilder.AppendLine("return " + met.ReturnPlan.ArgExtractCode);
            }

        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;


            if (implTypeDecl.Name.Contains("CppToC"))
            {
                _typeTxInfo = orgDecl.TypeTxInfo;
            }
            else
            {
                _typeTxInfo = implTypeDecl.TypeTxInfo;
            }

            //-----------------------------------------------------------------------
            List<MethodTxInfo> callToDotNetMets = new List<MethodTxInfo>();

            int maxPar = 0;
            int j = _typeTxInfo.methods.Count;

            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                //-----------------
                CodeMethodDeclaration codeMethodDecl = metTx.metDecl;
                if (codeMethodDecl.IsAbstract || codeMethodDecl.IsVirtual)
                {
                    callToDotNetMets.Add(metTx);
                }
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
            }



            if (callToDotNetMets.Count > 0)
            {
                GenerateCsImplClass(orgDecl, callToDotNetMets, stbuilder);
            }

        }

        string GenerateCsMethodArgsClass(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            //generate cs method pars
            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)met.metDecl;
            List<CodeMethodParameter> pars = metDecl.Parameters;
            int j = pars.Count;


            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            //temp 
            string className = met.Name + "Args";

            stbuilder.AppendLine("public struct " + className + "{ ");
            stbuilder.AppendLine("internal IntPtr nativePtr; //met arg native ptr");

            stbuilder.AppendLine("internal " + className + "(IntPtr nativePtr){");
            stbuilder.AppendLine("this.nativePtr = nativePtr;");
            stbuilder.AppendLine("}");

            for (int i = 0; i < j; ++i)
            {
                //move this to method

                CodeMethodParameter par = pars[i];
                MethodParameterTxInfo parTx = met.pars[i];
                switch (parTx.Name)
                {
                    case "params":
                        parTx.Name = "_params";
                        break;
                    case "string":
                        parTx.Name = "_string";
                        break;
                    case "object":
                        parTx.Name = "_object";
                        break;
                    case "event":
                        parTx.Name = "_event";
                        break;
                }
                //
                stbuilder.Append("public ");

                string csParTypeName = GetCsRetName(parTx.TypeSymbol);
                string csSetterParTypeName = null;
                switch (csParTypeName)
                {
                    case "ref bool":
                        //provide both getter and setter method
                        stbuilder.Append("bool");
                        parTx.ArgByRef = true;//temp
                        parTx.InnerTypeName = csSetterParTypeName = "bool";
                        break;
                    case "ref int":
                        stbuilder.Append("int");
                        parTx.ArgByRef = true;//temp
                        parTx.InnerTypeName = csSetterParTypeName = "int";
                        break;
                    case "ref uint":
                        stbuilder.Append("uint");
                        parTx.ArgByRef = true;//temp
                        parTx.InnerTypeName = csSetterParTypeName = "uint";
                        break;
                    default:
                        stbuilder.Append(csParTypeName);
                        csSetterParTypeName = csParTypeName;
                        break;
                }

                //some cpp name can't be use in C#                 
                stbuilder.Append(" ");
                stbuilder.Append(parTx.Name);
                stbuilder.Append("()");
                stbuilder.AppendLine("{");


                switch (csParTypeName)
                {
                    default:
                        {

                            if (csParTypeName.StartsWith("Cef"))
                            {
                                stbuilder.Append("return new " + csParTypeName + "(Cef3Binder.MyMetArgGetAsIntPtr(nativePtr," + (i + 1).ToString() + "));");
                            }
                            else if (csParTypeName.StartsWith("cef"))
                            {
                                stbuilder.Append("return " + "(" + csParTypeName + ")" + "Cef3Binder.MyMetArgGetAsInt32(nativePtr," + (i + 1).ToString() + ");");
                            }
                            else
                            {
                                stbuilder.Append("throw new CefNotImplementedException();");
                            }
                        }

                        break;
                    case "IntPtr":
                        stbuilder.Append("throw new CefNotImplementedException();");
                        break;
                    case "List<object>":
                    case "List<string>":
                    case "List<CefCompositionUnderline>":
                        stbuilder.Append("throw new CefNotImplementedException();");
                        break;
                    case "CefValue":

                        stbuilder.Append("throw new CefNotImplementedException();");
                        break;
                    case "uint":
                        stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsUInt32(nativePtr," + (i + 1).ToString() + ");");
                        break;
                    case "int":
                        stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsInt32(nativePtr," + (i + 1).ToString() + ");");
                        break;
                    case "long":
                        stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsInt64(nativePtr," + (i + 1).ToString() + ");");
                        break;
                    case "string":
                        stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsString(nativePtr," + (i + 1).ToString() + ");");
                        break;
                    case "bool":
                        stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsBool(nativePtr," + (i + 1).ToString() + ");");
                        break;
                    case "double":
                        stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsDouble(nativePtr," + (i + 1).ToString() + ");");
                        break;
                    case "ref bool":
                        //provide both getter and setter method
                        {
                            stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsBool(nativePtr," + (i + 1).ToString() + ");");
                            stbuilder.AppendLine("}");

                            //method
                            //generate setter part

                            stbuilder.AppendLine("public void " + parTx.Name + "(" + csSetterParTypeName + " value){");
                            stbuilder.AppendLine("Cef3Binder.MyMetArgSetBoolToAddress(nativePtr," + (i + 1).ToString() + ",value);");
                            stbuilder.AppendLine("}");
                            continue;
                        }

                    case "ref int":
                        {
                            stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsInt32(nativePtr," + (i + 1).ToString() + ");");
                            stbuilder.AppendLine("}");

                            //method
                            //generate setter part
                            stbuilder.AppendLine("public void " + parTx.Name + "(" + csSetterParTypeName + " value){");
                            stbuilder.AppendLine("Cef3Binder.MyMetArgSetInt32ToAddress(nativePtr," + (i + 1).ToString() + ",value);");
                            stbuilder.AppendLine("}");
                            continue;
                        }

                    case "ref uint":
                        {
                            stbuilder.Append("return " + "Cef3Binder.MyMetArgGetAsUInt32(nativePtr," + (i + 1).ToString() + ");");
                            stbuilder.AppendLine("}");

                            //method
                            //generate setter part
                            stbuilder.AppendLine("public void " + parTx.Name + "(" + csSetterParTypeName + " value){");
                            stbuilder.AppendLine("Cef3Binder.MyMetArgSetUInt32ToAddress(nativePtr," + (i + 1).ToString() + ",value);");
                            stbuilder.AppendLine("}");
                            continue;
                        }

                }


                stbuilder.AppendLine("}"); //method
            }
            stbuilder.AppendLine("}"); //struct

            return className;
        }

        void PrepareCsMetPars(MethodTxInfo met)
        {
            int j = met.pars.Count;
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                switch (parTx.Name)
                {
                    case "params":
                        {
                            parTx.Name = "_params";
                        }
                        break;
                    case "string":
                        {
                            parTx.Name = "_string";
                        }
                        break;
                    case "object":
                        {
                            parTx.Name = "_object";
                        }
                        break;
                    case "event":
                        {
                            parTx.Name = "_event";
                        }
                        break;
                }
            }

        }

        void GenerateCsExpandedArgsMethodImpl(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)met.metDecl;

            //temp 
            stbuilder.Append("public virtual ");
            stbuilder.Append(GetCsRetName(met.ReturnPlan.TypeSymbol));
            stbuilder.Append(" ");
            stbuilder.Append(met.Name);
            stbuilder.Append("(");

            List<CodeMethodParameter> pars = metDecl.Parameters;
            int j = pars.Count;
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(",");
                }

                MethodParameterTxInfo parTx = met.pars[i];
                string parTypeName = GetCsRetName(parTx.TypeSymbol);
                stbuilder.Append(parTypeName);



                //some cpp name can't be use in C#
                stbuilder.Append(" ");
                stbuilder.Append(parTx.Name);
            }
            stbuilder.AppendLine("){");



            if (!met.ReturnPlan.IsVoid)
            {
                string retTypeName = metDecl.ReturnType.ToString();
                if (retTypeName.StartsWith("CefRefPtr<"))
                {
                    stbuilder.Append("throw new CefNotImplementedException();");
                }
                else
                {
                    switch (metDecl.ReturnType.ToString())
                    {
                        case "bool":
                            stbuilder.Append("return false;");
                            break;
                        case "FilterStatus": //TODO: revisit here
                            stbuilder.Append("return (FilterStatus)0;");
                            break;
                        case "ReturnValue":
                            stbuilder.Append("return (ReturnValue)0;");
                            break;
                        case "CefSize":
                            stbuilder.Append("throw new CefNotImplementedException();");
                            break;
                        case "size_t":
                            stbuilder.Append("return 0;");
                            break;
                        case "int":
                            stbuilder.Append("return 0;");
                            break;
                        case "int64":
                            stbuilder.Append("return 0;");
                            break;
                        default:
                            throw new NotSupportedException();

                    }
                }
            }

            stbuilder.AppendLine("}"); //method
        }



        void GenerateCsSingleArgMethodImpl(string argClassName, MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)met.metDecl;
            //temp 
            List<MethodParameterTxInfo> pars = met.pars;

            stbuilder.Append("public virtual void");
            stbuilder.Append(" ");

            stbuilder.Append(met.Name);
            stbuilder.Append("(");
            stbuilder.Append(argClassName + " args");
            stbuilder.AppendLine("){");
            //call 
            stbuilder.AppendLine("//expand args");
            int j = pars.Count;
            if (j > 0)
            {
                //arg expansion 
                //bool allow_os_execution = false;
                //OnProtocolExecution(args.browser(), args.url(), ref allow_os_execution);
                //args.allow_os_execution(allow_os_execution); 
                for (int i = 0; i < j; ++i)
                {
                    MethodParameterTxInfo par = pars[i];
                    if (par.ArgByRef)
                    {
                        stbuilder.Append(par.InnerTypeName + " " + par.Name);
                        //with default value
                        if (par.InnerTypeName == "bool")
                        {
                            stbuilder.AppendLine("=false;");
                        }
                        else
                        {
                            stbuilder.AppendLine("=0;");
                        }
                    }
                }
            }
            //-------
            stbuilder.Append(met.Name);
            stbuilder.Append("(");
            if (j > 0)
            {

                for (int i = 0; i < j; ++i)
                {
                    if (i > 0)
                    {
                        stbuilder.Append(",\r\n");
                    }
                    MethodParameterTxInfo par = pars[i];
                    if (par.ArgByRef)
                    {
                        stbuilder.Append("ref " + par.Name);
                    }
                    else
                    {
                        stbuilder.Append("args." + par.Name + "()");
                    }
                }
            }
            stbuilder.AppendLine(");");
            if (j > 0)
            {
                for (int i = 0; i < j; ++i)
                {
                    MethodParameterTxInfo par = pars[i];
                    if (par.ArgByRef)
                    {
                        stbuilder.AppendLine("args." + par.Name + "(" + par.Name + ");");
                    }
                }
            }


            stbuilder.AppendLine("}"); //method
        }
        void GenerateCsSingleArgMethodImplForInterface(string argClassName, MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)met.metDecl;
            //temp 
            List<MethodParameterTxInfo> pars = met.pars;

            stbuilder.Append("void");
            stbuilder.Append(" ");

            stbuilder.Append(met.Name);
            stbuilder.Append("(");
            stbuilder.Append(argClassName + " args");
            stbuilder.AppendLine(");");
        }
        void GenerateCsImplClass(CodeTypeDeclaration orgDecl, List<MethodTxInfo> callToDotNetMets, CodeStringBuilder stbuilder)
        {
            int nn = callToDotNetMets.Count;
            //create interface for this handler
            //we provide 2 interfaces
            //1. singles arg interface
            //2. expanded args interface

            string className = orgDecl.Name;


            //create a cpp class              
            stbuilder.Append("public class " + className);
            stbuilder.AppendLine("{");
            stbuilder.AppendLine("const int _typeNAME=" + orgDecl.TypeTxInfo.CsInterOpTypeNameId + ";");


            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];

                PrepareCsMetPars(met);
                stbuilder.AppendLine("const int " + met.CppMethodSwitchCaseName + "= (_typeNAME <<16) | " + (mm + 1) + ";");
            }
            //------ 
            stbuilder.AppendLine("internal IntPtr nativePtr;");
            stbuilder.AppendLine("public " + className + "(IntPtr nativePtr){");
            stbuilder.AppendLine("this.nativePtr= nativePtr;");
            stbuilder.AppendLine("}");
            //
            stbuilder.AppendLine("public " + className + "(){}");
            //------

            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];
                //prepare data and call the callback                

                GenerateCsExpandedArgsMethodImpl(met, stbuilder);
                string argClassName = GenerateCsMethodArgsClass(met, stbuilder);
                met.CsArgClassName = argClassName;
                GenerateCsSingleArgMethodImpl(argClassName, met, stbuilder);


            }

            //-----------------------------------------------------------------------
            if (this.CppImplClassName != null)
            {
                //new with callback
                stbuilder.AppendLine("public static " + className + " New(MyCefCallback callback){");
                stbuilder.AppendLine("return new " + className + "(Cef3Binder.NewInstance(_typeNAME,callback));");
                stbuilder.AppendLine("}");
                //with built in method table

                stbuilder.AppendLine("public static " + className + " New(){");
                stbuilder.AppendLine(className + " newInst= new " + className + "();");
                stbuilder.AppendLine("newInst.nativePtr = Cef3Binder.NewInstance(_typeNAME,(met_id, nativeMetArgs) =>");
                stbuilder.AppendLine("{");
                stbuilder.AppendLine("switch(met_id){");

                for (int mm = 0; mm < nn; ++mm)
                {
                    //implement on event notificationi
                    MethodTxInfo met = callToDotNetMets[mm];
                    stbuilder.AppendLine("case " + met.CppMethodSwitchCaseName + ":{");
                    stbuilder.AppendLine("newInst." + met.Name + "(new " + met.Name + "Args(nativeMetArgs));");
                    stbuilder.AppendLine("}break;");//case 
                }
                stbuilder.AppendLine("}");//switch 
                stbuilder.AppendLine("});");
                stbuilder.AppendLine("return newInst;");
                stbuilder.AppendLine("}");
            }



            //------------------------------            
            stbuilder.Append("public interface I");
            stbuilder.AppendLine("{");
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];
                GenerateCsSingleArgMethodImplForInterface(met.CsArgClassName, met, stbuilder);

            }
            stbuilder.AppendLine("}");
            //-----------------


            stbuilder.AppendLine("}");
        }
    }


    enum ImplWrapDirection
    {
        None,
        CppToC,
        CToCpp,
    }

    class CefEnumTxPlan : CefTypeTxPlan
    {
        TypeTxInfo _typeTxInfo;
        CodeTypeDeclaration _currentCodeTypeDecl;

        string enum_base = "";
        public CefEnumTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {
            //check each field for proper enum base type

            foreach (CodeFieldDeclaration field in this.OriginalDecl.GetFieldIter())
            {
                if (field.InitExpression != null)
                {
                    //cef specific
                    //some init expression need special treatment
                    string initExprString = field.InitExpression.ToString();

                    if (initExprString == "UINT_MAX")
                    {
                        enum_base = ":uint";
                        break;
                    }
                    else
                    {
                        initExprString = initExprString.ToLower();
                        if (initExprString.StartsWith("0x"))
                        {
                            uint uint1 = Convert.ToUInt32(initExprString.Substring(2), 16);
                            if (uint1 >= int.MaxValue)
                            {
                                enum_base = ":uint";
                                break;
                            }
                        }

                    }

                }
            }
        }

        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            CodeStringBuilder codeBuilder = new CodeStringBuilder();
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            _typeTxInfo = orgDecl.TypeTxInfo;
            _currentCodeTypeDecl = orgDecl;
            //
            AddComment(orgDecl.LineComments, codeBuilder);

            //for cef, if enum class end with flags_t 
            //we add FlagsAttribute to this enum type

            if (orgDecl.Name.EndsWith("flags_t"))
            {
                codeBuilder.AppendLine("[Flags]");
            }

            codeBuilder.AppendLine("public enum " + orgDecl.Name + enum_base + "{");
            //transform enum
            int i = 0;
            foreach (FieldTxInfo fieldTx in _typeTxInfo.fields)
            {

                if (i > 0)
                {
                    codeBuilder.AppendLine(",");
                }
                i++;
                CodeFieldDeclaration codeFieldDecl = fieldTx.fieldDecl;
                //
                AddComment(codeFieldDecl.LineComments, codeBuilder);
                //
                if (codeFieldDecl.InitExpression != null)
                {
                    string initExpr = codeFieldDecl.InitExpression.ToString();
                    //cef specific
                    if (initExpr == "UINT_MAX")
                    {
                        codeBuilder.Append(codeFieldDecl.Name + "=uint.MaxValue");
                    }
                    else
                    {
                        codeBuilder.Append(codeFieldDecl.Name + "=" + codeFieldDecl.InitExpression.ToString());
                    }
                }
                else
                {
                    codeBuilder.Append(codeFieldDecl.Name);
                }
            }
            codeBuilder.AppendLine("}");
            //
            stbuilder.Append(codeBuilder.ToString());
        }
    }





    /// <summary>
    /// tx plan for instance element
    /// </summary>
    class CefInstanceElementTxPlan : CefTypeTxPlan
    {
        TypeTxInfo _typeTxInfo;


        public CefInstanceElementTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }

        void GenerateCppImplMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {


            CodeMethodDeclaration metDecl = (CodeMethodDeclaration)met.metDecl;
            stbuilder.AppendLine("//gen! " + metDecl.ToString());

            //temp
            if (metDecl.ReturnType.ToString() == "FilterStatus")
            {
                stbuilder.Append("virtual " + metDecl.ReturnType.ResolvedType + " " + metDecl.Name + "(");
            }
            else
            {
                stbuilder.Append("virtual " + metDecl.ReturnType + " " + metDecl.Name + "(");
            }


            List<CodeMethodParameter> pars = metDecl.Parameters;
            int j = pars.Count;
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(",");
                }
                CodeMethodParameter par = pars[i];

                if (par.IsConstPar)
                {
                    stbuilder.Append("const ");
                }
                stbuilder.Append(par.ParameterType.ToString() + " ");
                stbuilder.Append(par.ParameterName);
            }
            stbuilder.AppendLine("){");
            //-----------
            stbuilder.AppendLine("if(mcallback){");
            //call to managed 
            stbuilder.AppendLine("MyMetArgsN args;");
            stbuilder.AppendLine("memset(&args, 0, sizeof(MyMetArgsN));");
            stbuilder.AppendLine("args.argCount=" + j + ";");
            if (j > 0)
            {
                stbuilder.AppendLine("jsvalue vargs[" + j + "];");
                stbuilder.AppendLine("args.vargs=vargs;");

                for (int i = 0; i < j; ++i)
                {
                    MethodParameterTxInfo parTx = met.pars[i];
                    parTx.ClearExtractCode();
                    PrepareDataFromNativeToCs(parTx, "&vargs[" + i + "]", parTx.Name);
                }
            }

            PrepareCppMetArg(met.ReturnPlan, "args.ret");
            //
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                if (parTx.ArgPreExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPreExtractCode);
                }
            }
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                stbuilder.AppendLine(parTx.ArgExtractCode);
            }
            //
            //call a method and get some result back 
            //
            stbuilder.AppendLine("mcallback(" + met.CppMethodSwitchCaseName + ",&args);");

            //post call
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }

            //temp fix, arg extract code 
            if (!met.ReturnPlan.IsVoid)
            {
                stbuilder.AppendLine("return " + met.ReturnPlan.ArgExtractCode.Replace("->", ".") + ";");
            }
            //and return value
            stbuilder.AppendLine("}"); //if(this->mcallback){

            //-----------

            if (!met.ReturnPlan.IsVoid)
            {
                string retTypeName = metDecl.ReturnType.ToString();
                if (retTypeName.StartsWith("CefRefPtr<"))
                {
                    stbuilder.Append("return nullptr;");
                }
                else
                {
                    switch (metDecl.ReturnType.ToString())
                    {
                        case "bool":
                            stbuilder.Append("return false;");
                            break;
                        case "FilterStatus":
                            stbuilder.Append("return (FilterStatus)0;");
                            break;
                        default:
                            throw new NotSupportedException();

                    }
                }
            }

            stbuilder.AppendLine("}"); //method
        }

        void GenerateCppImplClass(CodeTypeDeclaration orgDecl, List<MethodTxInfo> callToDotNetMets, CodeStringBuilder stbuilder)
        {

            string className = "My" + orgDecl.Name;
            int nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];
                met.CppMethodSwitchCaseName = className + "_" + met.Name + "_" + (mm + 1);
                stbuilder.AppendLine("const int " + met.CppMethodSwitchCaseName + "=" + (mm + 1) + ";");
            }

            //create a cpp class              
            stbuilder.Append("class " + className);
            stbuilder.Append(":public " + orgDecl.Name);
            stbuilder.AppendLine("{");
            //members
            stbuilder.AppendLine("public:");
            stbuilder.AppendLine("managed_callback mcallback;");
            stbuilder.AppendLine("explicit " + className + "(){");
            stbuilder.AppendLine("mcallback= NULL;");
            stbuilder.AppendLine("}");
            //stbuilder.AppendLine("managed_callback GetManagedCallBack() const OVERRIDE { return mcallback; }");

            //
            this.CppImplClassNameId = _typeTxInfo.CsInterOpTypeNameId;
            this.CppImplClassName = className;

            nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodTxInfo met = callToDotNetMets[mm];
                //prepare data and call the callback
                GenerateCppImplMethod(met, stbuilder);
            }
            //private member
            stbuilder.AppendLine("private:");
            stbuilder.AppendLine("IMPLEMENT_REFCOUNTING(" + className + ");");
            stbuilder.AppendLine("};");
        }

        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {

#if DEBUG
            _dbug_cpp_count++;
#endif
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();


            if (implTypeDecl.Name.Contains("CppToC"))
            {
                _typeTxInfo = orgDecl.TypeTxInfo;
            }
            else
            {
                _typeTxInfo = implTypeDecl.TypeTxInfo;
            }
            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            List<MethodTxInfo> callToDotNetMets = new List<MethodTxInfo>();
            int maxPar = 0;
            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];

                metTx.CppMethodSwitchCaseName = orgDecl.Name + "_" + metTx.Name + "_" + (i + 1);
                //-----------------
                CodeMethodDeclaration codeMethodDecl = metTx.metDecl;
                if (codeMethodDecl.IsAbstract || codeMethodDecl.IsVirtual)
                {
                    callToDotNetMets.Add(metTx);
                }
                //-----------------
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                const_methodNames.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "=" + (i + 1) + ";");
            }
            MaxMethodParCount = maxPar;
            totalTypeMethod.AppendLine(const_methodNames.ToString());
            //-----------------------------------------------------------------------
            {
                StringBuilder met_sig = new StringBuilder();
                met_sig.Append("void MyCefMet_" + orgDecl.Name + "(" +
                    this.UnderlyingCType.Name + "* me1,int metName,jsvalue* ret");
                for (int i = 0; i < maxPar; ++i)
                {
                    met_sig.Append(",jsvalue* v" + (i + 1));
                }
                met_sig.AppendLine("){");
                totalTypeMethod.Append(met_sig.ToString());
            }

            if (implTypeDecl == null)
            {
                throw new NotSupportedException();
            }
            totalTypeMethod.AppendLine("ret->type = JSVALUE_TYPE_EMPTY;");
            ImplWrapDirection implWrapDirection = ImplWrapDirection.None;
            if (implTypeDecl.Name.Contains("CToCpp"))
            {
                implWrapDirection = ImplWrapDirection.CToCpp;
            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {
                implWrapDirection = ImplWrapDirection.CppToC;
            }
            else
            {
                implWrapDirection = ImplWrapDirection.None;
            }

            totalTypeMethod.AppendLine("auto me=" + implTypeDecl.Name + "::" + GetSmartPointerMet(implWrapDirection) + "(me1);");
            //swicth table is a way that this instance'smethod is called
            //through the bridge 


            totalTypeMethod.AppendLine("switch(metName){");
            totalTypeMethod.AppendLine("case MET_Release:return; //yes, just return");


            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                met_stbuilder.AppendLine("case " + metTx.CppMethodSwitchCaseName + ":{");

                GenerateCppMethod(_typeTxInfo.methods[i], met_stbuilder);

                met_stbuilder.AppendLine("} break;");

                totalTypeMethod.Append(met_stbuilder.ToString());
            }

            totalTypeMethod.AppendLine("}"); //end switch table
                                             //

            totalTypeMethod.AppendLine(implTypeDecl.Name + "::" + GetRawPtrMet(implWrapDirection) + "(me);");

            totalTypeMethod.AppendLine("}");
            stbuilder.Append(totalTypeMethod.ToString());

            //-------------------------------------------
            if (callToDotNetMets.Count > 0)
            {
                GenerateCppImplClass(orgDecl, callToDotNetMets, stbuilder);
            }
        }

        void GenerateCppMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            if (met.CsLeftMethodBodyBlank) return;  //temp here
                                                    //---------------------------------------

            //extract managed args and then call native c++ method
            //----
            MethodParameterTxInfo ret = met.ReturnPlan;
            //----
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 15)
            {
                throw new NotSupportedException();
            }

            //--------------------------- 
            stbuilder.AppendLine();
            stbuilder.Append(
                "\r\n" +
                "// gen! " + met.ToString() + "\r\n"
                );
            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                //prepare some method args
                //get pars from parameter .
                PrepareCppMetArg(pars[i], "v" + (i + 1));
            }
            PrepareDataFromNativeToCs(ret, "ret", "ret_result");


            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
                {
                    stbuilder.Append(parTx.ArgPreExtractCode);
                }
            }
            //---------------------------
            StringBuilder arglistBuilder = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (i > 0)
                {
                    arglistBuilder.AppendLine(",");
                }
                arglistBuilder.Append(parTx.ArgExtractCode);
            }

            string instThis = "me";
            if (ret.IsVoid)
            {
                //call, no return result
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");

            }
            else
            {
                stbuilder.Append("auto ret_result=");
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");
            }


            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }
            stbuilder.AppendLine(ret.ArgExtractCode);
            //clean up 
        }

        //---------------------------------------------------
        void AddComments(CodeTypeDeclaration orgDecl, CodeTypeDeclaration implTypeDecl)
        {

            //copy comment from orgDecl to implTypeDecl 
            List<CodeMethodDeclaration> results = new List<CodeMethodDeclaration>();
            foreach (CodeMethodDeclaration orgMet in orgDecl.GetMethodIter())
            {
                Token[] lineComments = orgMet.LineComments;

                if (lineComments != null)
                {
                    results.Clear();
                    implTypeDecl.FindMethod(orgMet.Name, results);
                    switch (results.Count)
                    {
                        case 0://not found
                            break;
                        case 1:
                            //found 1
                            {
                                CodeMethodDeclaration implMethodDecl = results[0];
                                if (implMethodDecl.LineComments == null)
                                {
                                    implMethodDecl.LineComments = lineComments;
                                }
                                else
                                {
                                }

                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            AddComments(orgDecl, implTypeDecl);
            //-----------------------------------------------------------------------
            _typeTxInfo = implTypeDecl.TypeTxInfo;



            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder csStruct = new CodeStringBuilder();
            int maxPar = 0;

            AddComment(orgDecl.LineComments, csStruct);
            //
            csStruct.AppendLine("public struct " + orgDecl.Name + "{");
            csStruct.AppendLine("const int _typeNAME=" + orgDecl.TypeTxInfo.CsInterOpTypeNameId + ";");

            string releaseMetName = orgDecl.Name + "_Release_0";

            csStruct.AppendLine("const int " + releaseMetName + "= (_typeNAME <<16) | 0;");

            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                if (metTx.CppMethodSwitchCaseName == null)
                {
                    throw new NotSupportedException();
                }
                csStruct.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "= (_typeNAME <<16) |" + (i + 1) + ";");
            }
            //-----------------------------------------------------------------------
            //create ctor
            csStruct.AppendLine("internal IntPtr nativePtr;");
            csStruct.AppendLine("internal " + orgDecl.Name + "(IntPtr nativePtr){");
            csStruct.AppendLine("this.nativePtr= nativePtr;");
            csStruct.AppendLine("}");
            //-----------------------------------------------------------------------
            //release method for cef instance object
            csStruct.AppendLine("public void Release(){");
            csStruct.AppendLine("JsValue ret;");
            csStruct.AppendLine("Cef3Binder.MyCefMet_Call0(this.nativePtr, " + releaseMetName + ", out ret);");
            csStruct.AppendLine("this.nativePtr= IntPtr.Zero;");
            csStruct.AppendLine("}");

            //-----------------------------------------------------------------------
            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                GenerateCsMethod(metTx, met_stbuilder);
                csStruct.Append(met_stbuilder.ToString());
            }

            //-----------------------------------------------------------------------
            if (this.CppImplClassName != null)
            {
                csStruct.AppendLine("public static " + orgDecl.Name + " New(MyCefCallback callback){");
                csStruct.AppendLine("JsValue not_used= new JsValue();");
                csStruct.AppendLine("return new " + orgDecl.Name + "(Cef3Binder.NewInstance(_typeNAME,callback,ref not_used));");
                csStruct.AppendLine("}");
            }
            //-----------------------------------------------------------------------
            csStruct.AppendLine("}");  //close struct

            //
            stbuilder.Append(csStruct.ToString());
        }


        void GenerateCsMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {

            if (met.CsLeftMethodBodyBlank) return;  //temp here 
            //---------------------------------------
            //extract managed args and then call native c++ method 
            MethodParameterTxInfo ret = met.ReturnPlan;
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 15)
            {
                throw new NotSupportedException();
            }
            //--------------------------- 
            //generate method sig 
            //--------------------------- 

            stbuilder.Append(
                "\r\n" +
                "// gen! " + met.ToString() + "\r\n"
                );
            //---------------------------
            AddComment(met.metDecl.LineComments, stbuilder);

            for (int i = 0; i < parCount; ++i)
            {
                //prepare some method args
                //get pars from parameter .                 
                PrepareCsMetArg(pars[i], "v" + (i + 1));
            }

            ret.ArgExtractCode = PrepareDataFromNativeToCs(ret.TypeSymbol, "ret", "ret_result");
            stbuilder.AppendLine();
            //------------------
            stbuilder.Append("public ");
            stbuilder.Append(GetCsRetName(ret.TypeSymbol));
            stbuilder.Append(" ");

            //some method name should be renamed
            if (met.Name == "GetType")
            {
                stbuilder.Append("_" + met.Name);
            }
            else
            {
                stbuilder.Append(met.Name);
            }
            stbuilder.Append("(");
            //---------------------------

            for (int i = 0; i < parCount; ++i)
            {
                if (i > 0)
                {
                    stbuilder.AppendLine(",");
                }
                MethodParameterTxInfo parTx = pars[i];
                stbuilder.Append(GetCsRetName(parTx.TypeSymbol));
                stbuilder.Append(" ");
                stbuilder.Append(parTx.Name);
            }
            stbuilder.Append(")");
            stbuilder.AppendLine("{");


            StringBuilder argList = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                argList.AppendLine("JsValue " + "v" + (i + 1) + "=new JsValue();");
            }
            argList.AppendLine("JsValue ret;");
            stbuilder.Append(argList.ToString());

            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
                {
                    stbuilder.Append(parTx.ArgPreExtractCode);
                }
            }
            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgExtractCode))
                {
                    stbuilder.Append(parTx.ArgExtractCode);
                    stbuilder.AppendLine(";");
                }
            }
            string orgDeclName = this.OriginalDecl.Name;
            stbuilder.AppendLine();//marker

            stbuilder.Append("Cef3Binder.MyCefMet_Call" + parCount + "(");
            stbuilder.Append("this.nativePtr," + met.CppMethodSwitchCaseName + ",out ret");
            for (int i = 0; i < parCount; ++i)
            {
                stbuilder.Append(",ref " + "v" + (i + 1));
            }
            stbuilder.Append(");\r\n");


            //clean up input arg
            //--------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }
            //--------------------

            stbuilder.AppendLine(ret.ArgExtractCode);
            //if (!met.ReturnPlan.IsVoid)
            //{
            //    stbuilder.AppendLine("return ret_result;");
            //}

            stbuilder.AppendLine("}");
        }

    }


}