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
                stbuilder.AppendLine("/*" + _dbugLineCount + "*/");
                if (_dbugLineCount >= 1815)
                {

                }
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


        public int CsInterOpTypeNameId { get; set; }

        public virtual void GenerateCppCode(CodeStringBuilder stbuilder)
        {

        }
        public virtual void GenerateCsCode(CodeStringBuilder stbuilder)
        {

        }

        protected static string GetRawPtrMet(ImplWrapDirection wrapDirection)
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
        protected static string GetSmartPointerMet(ImplWrapDirection wrapDirection)
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
        protected static string PrepareDataFromCppToCs(TypeSymbol ret, string retName, string autoRetResultName)
        {

            //check if we need some clean up code after return to client  
            switch (ret.TypeSymbolKind)
            {
                default:
                    break;
                case TypeSymbolKind.TypeDef:
                    {
                        CTypeDefTypeSymbol ctypedef = (CTypeDefTypeSymbol)ret;
                        return "MyCefSetInt32(" + retName + ",(int32_t)" + autoRetResultName + ");";
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
                                                return "SetCefStringToJsValue(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.NaitveInt:
                                                return "MyCefSetInt64(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.size_t:
                                                return "MyCefSetInt32(" + retName + ",(int32_t)" + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Int64:
                                                return "MyCefSetInt64(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.UInt64:
                                                return "MyCefSetUInt64(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Double:
                                                return "MyCefSetDouble(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Float:
                                                return "MyCefSetFloat(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Bool:
                                                return "MyCefSetBool(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.UInt32:
                                                return "MyCefSetUInt32(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Int32:
                                                return "MyCefSetInt32(" + retName + "," + autoRetResultName + ");";
                                            case PrimitiveTypeKind.NotPrimitiveType:
                                                {
                                                    CefTypeTxPlan txPlan = simpleElem.CefTxPlan;
                                                    if (txPlan == null)
                                                    {

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

                                                            return "MyCefSetVoidPtr(" + retName + "," +
                                                                  implBy.Name + "::Unwrap" + "(" + autoRetResultName + "));";

                                                        }
                                                        else if (implBy.Name.Contains("CppToC"))
                                                        {
                                                            return "MyCefSetVoidPtr(" + retName + "," +
                                                                implBy.Name + "::Wrap" + "(" + autoRetResultName + "));";
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                }
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        return "MyCefSetVoidPtr(" + retName + "," + autoRetResultName + ");";
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
                                                return "";
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

                                                    return "MyCefSetVoidPtr(" + retName + "," +
                                                          implBy.Name + "::Unwrap" + "(" + autoRetResultName + "));";

                                                }
                                                else if (implBy.Name.Contains("CppToC"))
                                                {
                                                    return "MyCefSetVoidPtr(" + retName + "," +
                                                        implBy.Name + "::Wrap" + "(" + autoRetResultName + "));";
                                                }
                                                else
                                                {

                                                }
                                            }
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {
                                        return "MyCefSetVoidPtr(" + retName + "," + autoRetResultName + ");";
                                    }
                                }
                                break;
                            case ContainerTypeKind.Pointer:
                                {
                                    if (refOrPtr.ElementType.BridgeInfo.WellKnownTypeName == WellKnownTypeName.Void)
                                    {
                                        //void*
                                        return "MyCefSetVoidPtr(" + retName + "," + autoRetResultName + ");";

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
                                return null;
                            case PrimitiveTypeKind.NotPrimitiveType:
                                {
                                    SimpleTypeSymbol ss = (SimpleTypeSymbol)simpleType;
                                    if (ss.IsEnum)
                                    {
                                        //enum class 
                                        return "MyCefSetInt32(" + retName + ",(int32_t)" + autoRetResultName + ");";
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

                                                    return ss.Name + "* tmp_d1= new " + ss.Name + "(" + autoRetResultName + ");\r\n" +
                                                        "MyCefSetVoidPtr(" + retName + ",tmp_d1);\r\n";
                                                }
                                        }
                                    }
                                }
                                break;
                            case PrimitiveTypeKind.CefString:
                                return "SetCefStringToJsValue(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.NaitveInt:
                                return "MyCefSetInt64(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.size_t:
                                return "MyCefSetInt32(" + retName + ",(int32_t)" + autoRetResultName + ");";

                            case PrimitiveTypeKind.Int64:
                                return "MyCefSetInt64(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.UInt64:
                                return "MyCefSetUInt64(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.Double:
                                return "MyCefSetDouble(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.Float:
                                return "MyCefSetFloat(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.Bool:
                                return "MyCefSetBool(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.UInt32:
                                return "MyCefSetUInt32(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.Int32:
                                return "MyCefSetInt32(" + retName + "," + autoRetResultName + ");";
                        }
                    }
                    break;
            }
            throw new NotSupportedException();

        }

        protected static void PrepareCppMetArg(MethodParameterTxInfo par, string argName)
        {

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



        protected static void PrepareCsMetArg(MethodParameterTxInfo par, string argName)
        {

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
                                case PrimitiveTypeKind.Int32:
                                    {
                                        par.ArgExtractCode = argName + ".I32= " + par.Name + "?1:0";//review here
                                    }
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

                                                            par.ArgExtractCode = argName + ".I32=" + par.Name;
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
                                                            par.ArgExtractCode = argName + ".Ptr";
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

        protected static string PrepareDataFromNativeToCs(TypeSymbol ret, string retName, string autoRetResultName)
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
                                return "var " + autoRetResultName + "= (" + referToType.ToString() + ")ret.I32;\r\n";
                            }
                        }
                        return "IntPtr " + autoRetResultName + "= ret.Ptr;";

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
                                                return "SetCefStringToJsValue(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.NaitveInt:
                                                return "MyCefSetInt64(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.size_t:
                                                return "MyCefSetInt32(" + retName + ",(int32_t)" + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Int64:
                                                return "MyCefSetInt64(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.UInt64:
                                                return "MyCefSetUInt64(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Double:
                                                return "MyCefSetDouble(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Float:
                                                return "MyCefSetFloat(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Bool:
                                                return "MyCefSetBool(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.UInt32:
                                                return "MyCefSetUInt32(" + retName + "," + autoRetResultName + ");";

                                            case PrimitiveTypeKind.Int32:
                                                return "MyCefSetInt32(" + retName + "," + autoRetResultName + ");";
                                            case PrimitiveTypeKind.NotPrimitiveType:
                                                {
                                                    CefTypeTxPlan txPlan = simpleElem.CefTxPlan;
                                                    if (txPlan == null)
                                                    {

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

                                                            return "MyCefSetVoidPtr(" + retName + "," +
                                                                  implBy.Name + "::Unwrap" + "(" + autoRetResultName + "));";

                                                        }
                                                        else if (implBy.Name.Contains("CppToC"))
                                                        {
                                                            return "MyCefSetVoidPtr(" + retName + "," +
                                                                implBy.Name + "::Wrap" + "(" + autoRetResultName + "));";
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                }
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        return "MyCefSetVoidPtr(" + retName + "," + autoRetResultName + ");";
                                    }
                                }
                                break;
                            case ContainerTypeKind.CefRefPtr:
                                {
                                    //the result is inner pointer from cef 'smart' pointer
                                    TypeSymbol elemType = refOrPtr.ElementType;
                                    return "var " + autoRetResultName + "= new " + elemType + "(ret.Ptr);";
                                }
                            case ContainerTypeKind.Pointer:
                                {
                                    if (refOrPtr.ElementType.BridgeInfo.WellKnownTypeName == WellKnownTypeName.Void)
                                    {
                                        //void*
                                        return "MyCefSetVoidPtr(" + retName + "," + autoRetResultName + ");";

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
                                return null;
                            case PrimitiveTypeKind.NotPrimitiveType:
                                {
                                    SimpleTypeSymbol ss = (SimpleTypeSymbol)simpleType;
                                    if (ss.IsEnum)
                                    {
                                        //enum ,
                                        //cast from i32 to specific enum type
                                        return "var " + autoRetResultName + "=(" + simpleType.Name + ")" + retName + ".I32;\r\n";
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
                                                    return "var " + autoRetResultName + "= new " + ss.Name + "(" + retName + ".Ptr);\r\n";

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
                                return "var " + autoRetResultName + "= " + "Cef3Binder.CopyStringAndDestroyNativeSide(ref " + retName + ");";
                            case PrimitiveTypeKind.NaitveInt:
                                return "var " + autoRetResultName + "= " + retName + ".I32;";
                            case PrimitiveTypeKind.Int64:
                                return "var " + autoRetResultName + "= " + retName + ".I64;";
                            case PrimitiveTypeKind.UInt64:
                                return "var " + autoRetResultName + "=  (ulong)" + retName + ".I64;";
                            case PrimitiveTypeKind.Double:
                                return "var " + autoRetResultName + "=  " + retName + ".Num;";
                            case PrimitiveTypeKind.Float:
                                return "var " + autoRetResultName + "= (float)" + retName + ".Num;";
                            case PrimitiveTypeKind.Bool:
                                return "var " + autoRetResultName + "=" + retName + ".I32 !=0;";
                            case PrimitiveTypeKind.size_t:
                            case PrimitiveTypeKind.UInt32:
                                return "var " + autoRetResultName + "= (uint)" + retName + ".I32;";
                            case PrimitiveTypeKind.Int32:
                                return "var " + autoRetResultName + "= " + retName + ".I32;";
                        }
                    }
                    break;
            }
            throw new NotSupportedException();

        }

    }

    /// <summary>
    /// tx plan for callback class
    /// </summary>
    class CefCallbackTxPlan : CefTypeTxPlan
    {
        public CefCallbackTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {
            //this is call back
        }
        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            base.GenerateCppCode(stbuilder);
        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {

            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            if (implTypeDecl == null)
            {
                throw new NotSupportedException();
            }

            if (implTypeDecl.Name.Contains("CToCPP"))
            {

            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {

            }
            else
            {

            }
        }

    }

    /// <summary>
    /// tx plan for handler class
    /// </summary>
    class CefHandlerTxPlan : CefTypeTxPlan
    {
        TypeTxInfo _typeTxInfo;
        CodeTypeDeclaration _currentCodeTypeDecl;
        public CefHandlerTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();

            _typeTxInfo = orgDecl.TypeTxInfo;
            _currentCodeTypeDecl = orgDecl;


            //-----------------------------------------------------------------------
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            int maxPar = 0;
            int j = _typeTxInfo.methods.Count;

            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                metTx.CppMethodSwitchCaseName = orgDecl.Name + "_" + metTx.Name + "_" + (i + 1);
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                const_methodNames.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "=" + (i + 1) + ";");
            }
            totalTypeMethod.AppendLine(const_methodNames.ToString());
            //-----------------------------------------------------------------------


            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                GenerateCppMethod(_typeTxInfo.methods[i], met_stbuilder);
                totalTypeMethod.Append(met_stbuilder.ToString());
            }
            stbuilder.Append(totalTypeMethod.ToString());

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


            //MethodArgs args;
            //memset(&args, 0, sizeof(MethodArgs));
            //CefString cefStr1 = url;
            //args.SetArgAsString(0, cefStr1.c_str());
            //this->mcallback_(CEF_MSG_ClientHandler_ExecCustomProtocol, &args);
            ////then what to do next


            stbuilder.AppendLine("MetArgs args;");
            stbuilder.AppendLine("memset(&args, 0, sizeof(MetArgs));");
            //
            //each arg, set data from cpp's managed arg to .net 
            int j = met.pars.Count;
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                parTx.ArgExtractCode = PrepareDataFromCppToCs(parTx.TypeSymbol, "&args.v" + (i + 1), parTx.Name);
            }
            PrepareCppMetArg(met.ReturnPlan, "args.ret");

            //
            for (int i = 0; i < j; ++i)
            {
                MethodParameterTxInfo parTx = met.pars[i];
                stbuilder.AppendLine(parTx.ArgExtractCode);
            }

            //
            stbuilder.AppendLine("this->mcallback_(" + met.CppMethodSwitchCaseName + ", &args)");
            if (!met.ReturnPlan.IsVoid)
            {
                stbuilder.AppendLine("return " + met.ReturnPlan.ArgExtractCode);
            }

        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            base.GenerateCsCode(stbuilder);
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
                    if (field.InitExpression.ToString() == "UINT_MAX")
                    {
                        enum_base = ":uint";
                        break;
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

            //uint.MaxValue

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
        CodeTypeDeclaration _currentCodeTypeDecl;

        public CefInstanceElementTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }

#if DEBUG
        int _dbug_cpp_count = 0;
#endif
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

            _typeTxInfo = implTypeDecl.TypeTxInfo;
            _currentCodeTypeDecl = implTypeDecl;

            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            int maxPar = 0;
            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                metTx.CppMethodSwitchCaseName = orgDecl.Name + "_" + metTx.Name + "_" + (i + 1);
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
                const_methodNames.AppendLine("const int " + metTx.CppMethodSwitchCaseName + "=" + (i + 1) + ";");
            }
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
            ret.ArgExtractCode = PrepareDataFromCppToCs(ret.TypeSymbol, "ret", "ret_result");


            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
                {
                    stbuilder.Append(parTx.ArgPreExtractCode);
                    stbuilder.AppendLine(";");
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
                    stbuilder.Append(parTx.ArgPostExtractCode);
                    stbuilder.AppendLine(";");
                }
            }
            stbuilder.AppendLine(ret.ArgExtractCode);
            //clean up 
        }

        //---------------------------------------------------

        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;


            _typeTxInfo = implTypeDecl.TypeTxInfo;
            _currentCodeTypeDecl = implTypeDecl;

            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder csStruct = new CodeStringBuilder();
            int maxPar = 0;
            csStruct.AppendLine("public struct " + orgDecl.Name + "{");
            csStruct.AppendLine("const int _typeNAME=" + orgDecl.TypeTxInfo.CsInterOpTypeNameId + ";");
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
            csStruct.AppendLine("IntPtr nativePtr;");
            csStruct.AppendLine("internal " + orgDecl.Name + "(IntPtr nativePtr){");
            csStruct.AppendLine("this.nativePtr= nativePtr;");
            csStruct.AppendLine("}");
            //-----------------------------------------------------------------------
            //create native method binder
            //CsCreateNativeMethodBinder(csStruct, orgDecl.Name);
            //for (int i = 0; i < 6; ++i)
            //{
            //    CsCreateAccessoryNativeMethodBinder(csStruct, orgDecl.Name, i);
            //}
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
        //void CsCreateNativeMethodBinder(CodeStringBuilder stbuilder, string orgTypeName)
        //{
        //    stbuilder.AppendLine("[DllImport(Cef3Binder.CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]");
        //    stbuilder.AppendLine("static extern void MyCefMet_" + orgTypeName + "(IntPtr me,int metName,out JsValue ret, ref JsValue v1,ref JsValue v2, ref JsValue v3,ref JsValue v4, ref JsValue v5,ref JsValue v6);\r\n");
        //}
        //void CsCreateAccessoryNativeMethodBinder(CodeStringBuilder stbuilder, string orgTypeName, int npars)
        //{

        //    stbuilder.AppendLine("static void MyCefMet_" + orgTypeName + "(IntPtr me,int metName,out JsValue ret");
        //    for (int i = 0; i < npars; ++i)
        //    {
        //        stbuilder.Append(",");
        //        stbuilder.Append("ref JsValue v" + (i + 1));
        //    }
        //    stbuilder.AppendLine("){");

        //    int remaining = 5 - npars; //v1 -v6 
        //    for (int i = npars; i < 6; ++i)
        //    {
        //        stbuilder.AppendLine("JsValue v" + (i + 1) + "=new JsValue();");
        //    }


        //    stbuilder.AppendLine("MyCefMet_" + orgTypeName + "(");
        //    stbuilder.AppendLine("me, metName,out ret");
        //    for (int i = 0; i < 6; ++i)
        //    {
        //        stbuilder.Append(",");
        //        stbuilder.Append("ref v" + (i + 1));
        //    }
        //    stbuilder.AppendLine(");");
        //    stbuilder.AppendLine("}");
        //}


        string GetCsRetName(TypeSymbol retType)
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
                                            return "byte*";
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

            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(",");
                }
                MethodParameterTxInfo parTx = pars[i];
                stbuilder.Append(GetCsRetName(parTx.TypeSymbol));
                stbuilder.Append(" ");

                //check if parTx.Name is keyword?
                switch (parTx.Name)
                {
                    case "event":
                        parTx.Name = "_event";
                        break;
                    case "checked":
                        parTx.Name = "_checked";
                        break;
                    case "object":
                        parTx.Name = "_object";
                        break;

                }

                stbuilder.AppendLine(parTx.Name);
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
                    stbuilder.AppendLine(";");
                }
            }
            //---------------------------

            string orgDeclName = this.OriginalDecl.Name;
            stbuilder.AppendLine();//marker

            stbuilder.Append("Cef3Binder.MyCefMet_Call" + parCount + "(");
            stbuilder.Append("this.nativePtr," + met.CppMethodSwitchCaseName + ",out ret");
            for (int i = 0; i < parCount; ++i)
            {
                stbuilder.Append(",ref " + "v" + (i + 1));
            }
            stbuilder.Append(");\r\n");

            stbuilder.AppendLine(ret.ArgExtractCode);
            //clean up 
            //--------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameterTxInfo parTx = pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.Append(parTx.ArgPostExtractCode);
                    stbuilder.AppendLine(";");
                }
            }
            //--------------------

            if (!met.ReturnPlan.IsVoid)
            {
                stbuilder.AppendLine("return ret_result;");
            }

            stbuilder.AppendLine("}");
        }

    }


}