//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{


    class CsCallToNativeCodeGen : CsCodeGen
    {
        CodeTypeDeclaration _currentCodeTypeDecl;
        TypeTxInfo _typeTxInfo;
        CodeTypeDeclaration _orgDecl;
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
                                                string met = CefTypeTxPlan.GetSmartPointerMet(implWrapDirection);
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
                                                            par.ArgPreExtractCode = argName + ".Ptr=" + " Cef3Binder.MyCefCreateStringHolder(" + par.Name + ");\r\n";
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

        public void GenerateCsCode(
            CefTypeTxPlan txplan,
            CodeTypeDeclaration orgDecl,
            CodeTypeDeclaration implTypeDecl,
            bool withNewMethod,
            CodeStringBuilder stbuilder)
        {

            //-----------------------------------------------------------------------
            _orgDecl = orgDecl;
            _typeTxInfo = implTypeDecl.TypeTxInfo;
            _currentCodeTypeDecl = implTypeDecl;

            int j = _typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder csStruct = new CodeStringBuilder();
            int maxPar = 0;
            CodeGenUtils.AddComment(orgDecl.LineComments, csStruct);
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

                MethodTxInfo metTx = _typeTxInfo.methods[i];
                GenerateCsMethod(metTx, met_stbuilder);
                csStruct.Append(met_stbuilder.ToString());
            }
            //-----------------------------------------------------------------------
            if (withNewMethod && txplan.CppImplClassName != null)
            {
                csStruct.AppendLine("public static " + orgDecl.Name + " New(MyCefCallback callback){");
                csStruct.AppendLine("JsValue not_used= new JsValue();");
                csStruct.AppendLine("return new " + orgDecl.Name + "(Cef3Binder.NewInstance(_typeNAME,callback,ref not_used));");
                csStruct.AppendLine("}");
            }
            //-----------------------------------------------------------------------
            csStruct.AppendLine("}");  //close struct 
            //add to stbuilder
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
            CodeGenUtils.AddComment(met.metDecl.LineComments, stbuilder);

            for (int i = 0; i < parCount; ++i)
            {
                //prepare some method args
                //get pars from parameter .                 
                PrepareCsMetArg(pars[i], "v" + (i + 1));
            }

            ret.ArgExtractCode = CefTypeTxPlan.PrepareDataFromNativeToCs(ret.TypeSymbol, "ret", "ret_result");
            stbuilder.AppendLine();
            //------------------
            stbuilder.Append("public ");
            stbuilder.Append(CefTypeTxPlan.GetCsRetName(ret.TypeSymbol));
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
                stbuilder.Append(CefTypeTxPlan.GetCsRetName(parTx.TypeSymbol));
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
            string orgDeclName = _orgDecl.Name;
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
        //void GenerateCsMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        //{

        //    if (met.CsLeftMethodBodyBlank) return;  //temp here 
        //    //---------------------------------------
        //    //extract managed args and then call native c++ method 
        //    MethodParameterTxInfo ret = met.ReturnPlan;
        //    List<MethodParameterTxInfo> pars = met.pars;
        //    int parCount = pars.Count;
        //    if (parCount > 15)
        //    {
        //        throw new NotSupportedException();
        //    }
        //    //--------------------------- 
        //    //generate method sig 
        //    //--------------------------- 

        //    stbuilder.Append(
        //        "\r\n" +
        //        "// gen! " + met.ToString() + "\r\n"
        //        );
        //    //---------------------------
        //    AddComment(met.metDecl.LineComments, stbuilder);

        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        //prepare some method args
        //        //get pars from parameter .                 
        //        PrepareCsMetArg(pars[i], "v" + (i + 1));
        //    }

        //    ret.ArgExtractCode = PrepareDataFromNativeToCs(ret.TypeSymbol, "ret", "ret_result");
        //    stbuilder.AppendLine();
        //    //------------------
        //    stbuilder.Append("public ");
        //    stbuilder.Append(GetCsRetName(ret.TypeSymbol));
        //    stbuilder.Append(" ");

        //    //some method name should be renamed
        //    if (met.Name == "GetType")
        //    {
        //        stbuilder.Append("_" + met.Name);
        //    }
        //    else
        //    {
        //        stbuilder.Append(met.Name);
        //    }
        //    stbuilder.Append("(");
        //    //---------------------------

        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        if (i > 0)
        //        {
        //            stbuilder.AppendLine(",");
        //        }
        //        MethodParameterTxInfo parTx = pars[i];
        //        stbuilder.Append(GetCsRetName(parTx.TypeSymbol));
        //        stbuilder.Append(" ");
        //        stbuilder.Append(parTx.Name);
        //    }
        //    stbuilder.Append(")");
        //    stbuilder.AppendLine("{");


        //    StringBuilder argList = new StringBuilder();
        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        argList.AppendLine("JsValue " + "v" + (i + 1) + "=new JsValue();");
        //    }
        //    argList.AppendLine("JsValue ret;");
        //    stbuilder.Append(argList.ToString());

        //    //---------------------------
        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        MethodParameterTxInfo parTx = pars[i];
        //        if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
        //        {
        //            stbuilder.Append(parTx.ArgPreExtractCode);
        //        }
        //    }
        //    //---------------------------
        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        MethodParameterTxInfo parTx = pars[i];
        //        if (!string.IsNullOrEmpty(parTx.ArgExtractCode))
        //        {
        //            stbuilder.Append(parTx.ArgExtractCode);
        //            stbuilder.AppendLine(";");
        //        }
        //    }
        //    string orgDeclName = this.OriginalDecl.Name;
        //    stbuilder.AppendLine();//marker

        //    stbuilder.Append("Cef3Binder.MyCefMet_Call" + parCount + "(");
        //    stbuilder.Append("this.nativePtr," + met.CppMethodSwitchCaseName + ",out ret");
        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        stbuilder.Append(",ref " + "v" + (i + 1));
        //    }
        //    stbuilder.Append(");\r\n");


        //    //clean up input arg
        //    //--------------------
        //    for (int i = 0; i < parCount; ++i)
        //    {
        //        MethodParameterTxInfo parTx = pars[i];
        //        if (parTx.ArgPostExtractCode != null)
        //        {
        //            stbuilder.AppendLine(parTx.ArgPostExtractCode);
        //        }
        //    }
        //    //--------------------

        //    stbuilder.AppendLine(ret.ArgExtractCode);
        //    //if (!met.ReturnPlan.IsVoid)
        //    //{
        //    //    stbuilder.AppendLine("return ret_result;");
        //    //}

        //    stbuilder.AppendLine("}");
        //}

    }
}