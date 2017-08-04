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
        bool _dbugEnableLineNote = false;
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
                stbuilder.Append("/*" + _dbugLineCount + "*/");
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


        public virtual void GenerateCppCode(CodeStringBuilder stbuilder)
        {

        }
        public virtual void GenerateCsCode(CodeStringBuilder stbuilder)
        {

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
        public CefHandlerTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        public override void GenerateCppCode(CodeStringBuilder stbuilder)
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

        static string GetRawPtrMet(ImplWrapDirection wrapDirection)
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
                    break;
            }
        }
        static string GetSmartPointerMet(ImplWrapDirection wrapDirection)
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

        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            _typeTxInfo = implTypeDecl.TypeTxInfo;
            _currentCodeTypeDecl = implTypeDecl;

            int j = _typeTxInfo.methods.Count;
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            for (int i = 0; i < j; ++i)
            {
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                const_methodNames.AppendLine("const int " + orgDecl.Name + "_" + metTx.Name + "=" + (i + 1) + ";");
            }

            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();
            //1. generate method decl
            totalTypeMethod.AppendLine(const_methodNames.ToString());
            totalTypeMethod.AppendLine("void MyCefMet_" + orgDecl.Name + "(" +
                this.UnderlyingCType.Name + "* me1,int metName,jsvalue* ret,jsvalue* v1,jsvalue* v2,jsvalue* v3){");
            //2. generate method header
            //3. generate switch table


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
                met_stbuilder.AppendLine("case " + orgDecl.Name + "_" + metTx.Name + ":{");

                GenerateCppMethod(_typeTxInfo.methods[i], met_stbuilder);

                met_stbuilder.AppendLine("} break;");

                totalTypeMethod.Append(met_stbuilder.ToString());
            }

            totalTypeMethod.AppendLine("}"); //end switch table
                                             //

            totalTypeMethod.AppendLine(implTypeDecl.Name + "::" + GetRawPtrMet(implWrapDirection) + "(me1);");

            totalTypeMethod.AppendLine("}");
        }

        static string PrepareCppReturnToCs(TypeSymbol ret, string retName, string autoRetResultName)
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
                                                return "SetCefStringToJsValue(" + retName + ",(int32_t)" + autoRetResultName + ");";

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
                                                return "MyCefSetUint32(" + retName + "," + autoRetResultName + ");";

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
                                        return "MyCefSetVoidPtr(" + retName + ",(int32_t)" + autoRetResultName + ");";
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

                                                    return ss.Name + "* tmp_d1= new " + ss.Name + "();\r\n" +
                                                        "tmp_d1 = ret_result;\r\n" +
                                                        "MyCefSetVoidPtr(" + retName + ",temp_d1);\r\n";
                                                }
                                        }
                                    }
                                }
                                break;
                            case PrimitiveTypeKind.CefString:
                                return "SetCefStringToJsValue(" + retName + ",(int32_t)" + autoRetResultName + ");";

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
                                return "MyCefSetUint32(" + retName + "," + autoRetResultName + ");";

                            case PrimitiveTypeKind.Int32:
                                return "MyCefSetInt32(" + retName + "," + autoRetResultName + ");";
                        }
                    }
                    break;
            }
            throw new NotSupportedException();

        }
        void PrepareCppMetArg(MethodParameterTxInfo par, string argName)
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
                            par.ArgExtractCode = "(" + simpleType.ToString() + ")" + argName + "->" + bridge.CefCppSlotName;//review here
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
                                par.ArgExtractCode = "(" + ctypedef.ToString() + ")" + argName + "->" + bridge.CefCppSlotName;//review here
                            }
                            else if (ss.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                            {


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
                                                    par.ArgExtractCode = argName + "->" + slotName;
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
                                                par.ArgExtractCode = implTypeDecl.Name + "::" + met + "(" + argName + ")";
                                            }
                                            else
                                            {
                                                implWrapDirection = ImplWrapDirection.None;
                                                string met = GetSmartPointerMet(implWrapDirection);
                                                par.ArgExtractCode = implTypeDecl.Name + "::" + met + "(" + argName + ")";

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
                                                            par.ArgExtractCode = "*((bool*)" + argName + "->" + slotName + "))";

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
                                                            par.ArgExtractCode = "*((size_t*)" + argName + "->" + slotName + "))";

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
                                                            par.ArgExtractCode = "*((float*)" + argName + "->" + slotName + "))";

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
                                                            par.ArgExtractCode = "*((int*)" + argName + "->" + slotName + "))";
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
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + "))";
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
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + "))";
                                                        }
                                                        break;
                                                    case "CefRefPtr<CefV8Value>":
                                                        {
                                                            //eg. bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
                                                            if (par.IsConst)
                                                            {

                                                            }
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + "))";
                                                        }
                                                        break;
                                                    case "CefRefPtr<CefV8Exception>":
                                                        {
                                                            //eg. bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
                                                            if (par.IsConst)
                                                            {

                                                            }
                                                            string slotName = bridge.CefCppSlotName.ToString();
                                                            par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + "))";
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case TypeSymbolKind.Vec:
                                            {
                                                string elem_typename = refOrPtr.ElementType.ToString();
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + "))";

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

                                                string elem_typename = refOrPtr.ElementType.ToString();
                                                string slotName = bridge.CefCppSlotName.ToString();
                                                par.ArgExtractCode = "*((" + elem_typename + "*)" + argName + "->" + slotName + "))";



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
            //----
            stbuilder.AppendLine();
            stbuilder.AppendLine("// gen! " + met.ToString());
            stbuilder.AppendLine();

            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                //prepare some method args
                //get pars from parameter .
                PrepareCppMetArg(pars[i], "v" + (i + 1));
            }
            ret.ArgExtractCode = PrepareCppReturnToCs(ret.TypeSymbol, "ret", "ret_result");


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
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            //create C# code that call the cefbridge interop method
            base.GenerateCsCode(stbuilder);
        }
    }


}