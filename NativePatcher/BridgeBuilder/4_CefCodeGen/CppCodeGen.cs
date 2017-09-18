//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{
    class CppInstanceImplCodeGen : CppCodeGen
    {
        //this create a impl in cpp side

        public void GenerateCppImplClass(
            CefTypeTx cefTypeTxPlan,
            TypePlan typeTxInfo,
            List<MethodPlan> callToDotNetMets,
            CodeTypeDeclaration orgDecl,
            CodeStringBuilder stbuilder)
        {
            stbuilder.AppendLine("//!codegen: GenerateCppImplClass \r\n");
            string className = "My" + orgDecl.Name;
            int nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodPlan met = callToDotNetMets[mm];
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
            cefTypeTxPlan.CppImplClassNameId = cefTypeTxPlan.CsInterOpTypeNameId;
            cefTypeTxPlan.CppImplClassName = className;

            nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodPlan met = callToDotNetMets[mm];
                //prepare data and call the callback
                GenerateCppImplMethod(met, stbuilder);
            }
            //private member
            stbuilder.AppendLine("private:");
            stbuilder.AppendLine("IMPLEMENT_REFCOUNTING(" + className + ");");
            stbuilder.AppendLine("};");
        }
        void GenerateCppImplMethod(MethodPlan met, CodeStringBuilder stbuilder)
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
            int arrLen = j + 1;
            stbuilder.AppendLine("jsvalue vargs[" + arrLen + "];");
            stbuilder.AppendLine("memset(&vargs, 0, sizeof(jsvalue) * " + arrLen + ");");
            stbuilder.AppendLine("args.vargs=vargs;");

            for (int i = 0; i < j; ++i)
            {
                MethodParameter parTx = met.pars[i];
                parTx.ClearExtractCode();
                CefTypeTx.PrepareDataFromNativeToCs(parTx, "&vargs[" + (i + 1) + "]", parTx.Name, true);
            }

            CefTypeTx.PrepareCppMetArg(met.ReturnPlan, "vargs[0]");
            //
            for (int i = 0; i < j; ++i)
            {
                MethodParameter parTx = met.pars[i];
                if (parTx.ArgPreExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPreExtractCode);
                }
            }
            for (int i = 0; i < j; ++i)
            {
                MethodParameter parTx = met.pars[i];
                stbuilder.AppendLine(parTx.ArgExtractCode);
            }
            //
            //call a method and get some result back 
            //
            stbuilder.AppendLine("mcallback(" + met.CppMethodSwitchCaseName + ",&args);");

            //post call
            for (int i = 0; i < j; ++i)
            {
                MethodParameter parTx = met.pars[i];
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
    }

    class CppEventListenerInstanceImplCodeGen : CppCodeGen
    {
        void GenerateCppImplMethod(
            CodeTypeDeclaration orgDecl,
            MethodPlan met, CodeStringBuilder stbuilder, bool useJsSlot)
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

            if (!useJsSlot)
            {
                stbuilder.AppendLine("if(mcallback){");
                string metArgsClassName = orgDecl.Name + "Ext::" + metDecl.Name + "Args";
                stbuilder.Append(metArgsClassName + " args1");
                //with ctors
                if (j == 0)
                {
                    stbuilder.AppendLine(";");
                }
                else
                {
                    stbuilder.Append("(");
                    for (int i = 0; i < j; ++i)
                    {
                        MethodParameter par = met.pars[i];
                        if (i > 0) { stbuilder.Append(","); }
                        //temp
                        string parType = par.TypeSymbol.ToString();
                        if (parType.EndsWith("&"))
                        {
                            stbuilder.Append("&");
                        }
                        stbuilder.Append(par.Name);
                    }
                    stbuilder.AppendLine(");");
                }
                stbuilder.AppendLine("mcallback( (" + orgDecl.Name + "Ext::" + "_typeName << 16) | " + met.CppMethodSwitchCaseName + ",&args1.arg);");
                stbuilder.AppendLine("}"); //if(this->mcallback){ 
            }
            else
            {
                stbuilder.AppendLine("if(mcallback){");
                //call to managed 
                stbuilder.AppendLine("MyMetArgsN args;");
                stbuilder.AppendLine("memset(&args, 0, sizeof(MyMetArgsN));");
                stbuilder.AppendLine("args.argCount=" + j + ";");
                int arrLen = j + 1;
                stbuilder.AppendLine("jsvalue vargs[" + arrLen + "];");
                stbuilder.AppendLine("memset(&vargs, 0, sizeof(jsvalue) * " + arrLen + ");");
                stbuilder.AppendLine("args.vargs=vargs;");

                for (int i = 0; i < j; ++i)
                {
                    MethodParameter parTx = met.pars[i];
                    parTx.ClearExtractCode();
                    CefTypeTx.PrepareDataFromNativeToCs(parTx, "&vargs[" + (i + 1) + "]", parTx.Name, true);
                }

                CefTypeTx.PrepareCppMetArg(met.ReturnPlan, "vargs[0]");
                //
                for (int i = 0; i < j; ++i)
                {
                    MethodParameter parTx = met.pars[i];
                    if (parTx.ArgPreExtractCode != null)
                    {
                        stbuilder.AppendLine(parTx.ArgPreExtractCode);
                    }
                }
                for (int i = 0; i < j; ++i)
                {
                    MethodParameter parTx = met.pars[i];
                    stbuilder.AppendLine(parTx.ArgExtractCode);
                }
                //
                //call a method and get some result back 
                //
                stbuilder.AppendLine("mcallback(" + met.CppMethodSwitchCaseName + ",&args);");
                //post call
                for (int i = 0; i < j; ++i)
                {
                    MethodParameter parTx = met.pars[i];
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
            }



            //-----------
            stbuilder.AppendLine("}"); //method
        }
        public void GenerateCppImplClass(
            CefTypeTx cefTypeTxPlan,
            TypePlan typeTxInfo,
            CodeTypeDeclaration orgDecl,
            List<MethodPlan> onEventMethods,
            CodeStringBuilder stbuilder)
        {
            stbuilder.AppendLine("//!codegen: CppEventListenerInstanceImplCodeGen \r\n");
            string className = "My" + orgDecl.Name;
            int nn = onEventMethods.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodPlan met = onEventMethods[mm];
                met.CppMethodSwitchCaseName = className + "_" + met.Name + "_" + (mm + 1);
                stbuilder.AppendLine("const int " + met.CppMethodSwitchCaseName + "=" + (mm + 1) + ";");
            }

            cefTypeTxPlan.CppImplClassNameId = typeTxInfo.CsInterOpTypeNameId;
            cefTypeTxPlan.CppImplClassName = className;

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

            // 
            nn = onEventMethods.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                GenerateCppImplMethod(orgDecl, onEventMethods[mm], stbuilder, false);
            }

            stbuilder.AppendLine("private:");
            stbuilder.AppendLine("IMPLEMENT_REFCOUNTING(" + className + ");");

            stbuilder.AppendLine("};");
        }

    }


    class CppHandleCsMethodRequestCodeGen : CppCodeGen
    {

        //when C# call to Cef native side
        //these code will handle those CS request
        //
        //we use cpp's switch table to handle this


        internal List<MethodPlan> callToDotNetMets;
        public void GenerateCppCode(
            CefTypeTx cefTx,
            CodeTypeDeclaration codeTypeDecl,
            CodeTypeDeclaration impl,
            SimpleTypeSymbol underlyingType,
            CodeStringBuilder stbuilder)
        {

            stbuilder.AppendLine("//!codegen: CppHandleCsMethodRequestCodeGen \r\n");
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = codeTypeDecl;
            CodeTypeDeclaration implTypeDecl = impl;
            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();

            TypePlan typeTxInfo;
            if (implTypeDecl.Name.Contains("CppToC"))
            {
                typeTxInfo = orgDecl.TypePlan;
            }
            else
            {
                typeTxInfo = implTypeDecl.TypePlan;
            }
            int j = typeTxInfo.methods.Count;
            //-----------------------------------------------------------------------
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            callToDotNetMets = new List<MethodPlan>();
            int maxPar = 0;
            for (int i = 0; i < j; ++i)
            {
                MethodPlan metTx = typeTxInfo.methods[i];

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
            cefTx.MaxMethodParCount = maxPar;
            totalTypeMethod.AppendLine(const_methodNames.ToString());
            //-----------------------------------------------------------------------
            {
                StringBuilder met_sig = new StringBuilder();
                met_sig.Append("void MyCefMet_" + orgDecl.Name + "(" +
                    underlyingType.Name + "* me1,int metName,jsvalue* ret");
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

            totalTypeMethod.AppendLine("auto me=" + implTypeDecl.Name + "::" + CefTypeTx.GetSmartPointerMet(implWrapDirection) + "(me1);");
            //swicth table is a way that this instance'smethod is called
            //through the bridge 


            totalTypeMethod.AppendLine("switch(metName){");
            totalTypeMethod.AppendLine("case MET_Release:return; //yes, just return");


            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodPlan metTx = typeTxInfo.methods[i];
                met_stbuilder.AppendLine("case " + metTx.CppMethodSwitchCaseName + ":{");

                GenerateCppMethod(typeTxInfo.methods[i], met_stbuilder);

                met_stbuilder.AppendLine("} break;");

                totalTypeMethod.Append(met_stbuilder.ToString());
            }

            totalTypeMethod.AppendLine("}"); //end switch table
                                             //

            totalTypeMethod.AppendLine(implTypeDecl.Name + "::" + CefTypeTx.GetRawPtrMet(implWrapDirection) + "(me);");

            totalTypeMethod.AppendLine("}");
            stbuilder.Append(totalTypeMethod.ToString());
        }
        void GenerateCppMethod(MethodPlan met, CodeStringBuilder stbuilder)
        {
            if (met.CsLeftMethodBodyBlank) return;  //temp here
                                                    //---------------------------------------

            //extract managed args and then call native c++ method
            //----
            MethodParameter ret = met.ReturnPlan;
            //----
            List<MethodParameter> pars = met.pars;
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
                CefTypeTx.PrepareCppMetArg(pars[i], "v" + (i + 1));
            }
            CefTypeTx.PrepareDataFromNativeToCs(ret, "ret", "ret_result", false);


            //---------------------------
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameter parTx = pars[i];
                if (!string.IsNullOrEmpty(parTx.ArgPreExtractCode))
                {
                    stbuilder.Append(parTx.ArgPreExtractCode);
                }
            }
            //---------------------------
            StringBuilder arglistBuilder = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                MethodParameter parTx = pars[i];
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
                MethodParameter parTx = pars[i];
                if (parTx.ArgPostExtractCode != null)
                {
                    stbuilder.AppendLine(parTx.ArgPostExtractCode);
                }
            }
            stbuilder.AppendLine(ret.ArgExtractCode);
            //clean up 
        }

    }





    class CppToCsMethodArgsClassGen : CppCodeGen
    {
        /// <summary>
        /// generate native method args class
        /// </summary>
        /// <param name="met"></param>
        /// <param name="stbuilder"></param>
        /// <returns></returns>
        public string GenerateCppMethodArgsClass(MethodPlan met, CodeStringBuilder stbuilder)
        {
            stbuilder.AppendLine("//!codegen: CppToCsMethodArgsClassGen \r\n");

            //generate cs method pars
            CodeMethodDeclaration metDecl = met.metDecl;
            List<CodeMethodParameter> pars = metDecl.Parameters;
            int j = pars.Count;

            //temp 
            string className = met.Name + "Args";
            stbuilder.AppendLine("class " + className + "{ ");
            stbuilder.AppendLine("public:");
            //
            //inner c POD struct
            //see https://stackoverflow.com/questions/26939609/how-is-the-memory-layout-of-a-class-vs-a-struct
            stbuilder.AppendLine("struct argData{");
            //fields
            stbuilder.AppendLine("int32_t myext_flags;");
            if (!met.ReturnPlan.IsVoid)
            {
                //return fields              
                stbuilder.Append(met.ReturnPlan.TypeSymbol.ToString());
                stbuilder.Append(" ");
                stbuilder.AppendLine("myext_ret_value; //0");
            }
            //met args  => fields
            List<string> field_types = new List<string>();

            for (int i = 0; i < j; ++i)
            {
                //move this to method
                CodeMethodParameter par = pars[i];
                MethodParameter parTx = met.pars[i];

                string fieldType = null;
                if (parTx.CppUnwrapType != null)
                {
                    fieldType = parTx.CppUnwrapType;
                }
                else
                {
                    fieldType = parTx.TypeSymbol.ToString();
                }

                if (fieldType.EndsWith("&"))
                {
                    //temp here
                    fieldType = fieldType.Substring(0, fieldType.Length - 1) + "*";
                }

                field_types.Add(fieldType);

                if (parTx.IsConst)
                {
                    stbuilder.Append("const ");
                }
                stbuilder.Append(fieldType);


                stbuilder.Append(" ");
                stbuilder.Append(parTx.Name);
                stbuilder.AppendLine(";//" + (i + 1));
            }
            stbuilder.AppendLine("};"); //close struct
            //args field,
            stbuilder.Append("argData arg;");
            //private class's flags
            stbuilder.AppendLine("//");

            //arg's common flags
            string flags = "(1<<18)";//this is special args
            if (!met.ReturnPlan.IsVoid)
            {
                //not void
                flags += "|(1<< 19)";
            }

            //-----------------------------
            //ctor style 1 not wrap (1<<20) = 0
            //or wrap (1<<20) =1
            //-----------------------------
            stbuilder.Append(className);
            stbuilder.Append("(");
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(",");
                }
                //move this to method
                CodeMethodParameter par = pars[i];
                MethodParameter parTx = met.pars[i];
                if (parTx.IsConst)
                {
                    stbuilder.Append("const ");
                }
                stbuilder.Append(field_types[i]);
                stbuilder.Append(" ");
                stbuilder.Append(parTx.Name);
            }
            stbuilder.AppendLine(")");
            stbuilder.AppendLine("{");
            stbuilder.AppendLine("arg.myext_flags = (" + flags + " | " + j + ");"); //not wrap/unwrap
            if (!met.ReturnPlan.IsVoid)
            {
                //set init return value
                //with default value 
                stbuilder.AppendLine("arg.myext_ret_value=0;");
            }

            bool need_unwrapMethodAndCtor = false;
            for (int i = 0; i < j; ++i)
            {
                CodeMethodParameter par = pars[i];
                MethodParameter parTx = met.pars[i];
                stbuilder.Append("arg." + parTx.Name + "=");
                stbuilder.AppendLine(parTx.Name + ";");

                if (parTx.CppUnwrapType != null)
                {
                    need_unwrapMethodAndCtor = true;
                }
            }
            stbuilder.AppendLine("}");//ctor's body --> empty
            //-----------------------------
            //ctor style 2
            if (!need_unwrapMethodAndCtor)
            {

            }
            else
            {
                stbuilder.Append(className);
                stbuilder.Append("(");
                for (int i = 0; i < j; ++i)
                {
                    if (i > 0)
                    {
                        stbuilder.Append(",");
                    }
                    //move this to method
                    CodeMethodParameter par = pars[i];
                    MethodParameter parTx = met.pars[i];
                    if (parTx.IsConst)
                    {
                        stbuilder.Append("const ");
                    }

                    string fieldType = parTx.TypeSymbol.ToString();
                    if (fieldType.EndsWith("&"))
                    {
                        //temp 
                        fieldType = fieldType.Substring(0, fieldType.Length - 1) + "*";
                    }
                    stbuilder.Append(fieldType);
                    stbuilder.Append(" ");
                    stbuilder.Append(parTx.Name);
                }
                stbuilder.AppendLine(")");
                //ctor's initialization
                stbuilder.Append("{");
                stbuilder.AppendLine("arg.myext_flags = (" + flags + " | (1<<20) | " + j + ");");//wrap
                if (!met.ReturnPlan.IsVoid)
                {
                    //set init return value
                    //with default value 
                    stbuilder.AppendLine("arg.myext_ret_value=0;");
                }
                for (int i = 0; i < j; ++i)
                {
                    //
                    CodeMethodParameter par = pars[i];
                    MethodParameter parTx = met.pars[i];
                    stbuilder.Append("arg.");
                    stbuilder.Append(parTx.Name); //same name as field name
                    stbuilder.Append("=");

                    if (parTx.CppUnwrapType != null)
                    {
                        stbuilder.Append(parTx.CppUnwrapMethod + "(" + parTx.Name + ")");
                    }
                    else
                    {
                        stbuilder.Append(parTx.Name);
                    }
                    stbuilder.AppendLine(";");
                }
                stbuilder.AppendLine("}");//ctor's body --> empty 
                //-----------------------------
                //dtor 
                stbuilder.Append("~");
                stbuilder.Append(className);
                stbuilder.Append("()");
                stbuilder.AppendLine("{");
                stbuilder.AppendLine("if( ((arg.myext_flags >> 20) &1)  ==1){");
                for (int i = 0; i < j; ++i)
                {
                    CodeMethodParameter par = pars[i];
                    MethodParameter parTx = met.pars[i];
                    if (parTx.CppUnwrapType != null)
                    {
                        stbuilder.AppendLine(parTx.CppWrapMethod + "(arg." + parTx.Name + ");");
                    }
                }
                stbuilder.AppendLine("}"); //end if(myext_created_from_Unwrap){
                stbuilder.AppendLine("}");//end class
            }
            //-----------------------------
            //private disallow copy
            stbuilder.AppendLine("private:");
            stbuilder.AppendLine("DISALLOW_COPY_AND_ASSIGN(" + className + ");");

            //-----------------------------
            stbuilder.AppendLine("};"); //close cpp's class
            return className;
        }

    }


    class CppInstanceMethodCodeGen : CppCodeGen
    {
        public void CreateCppNewInstanceMethod(StringBuilder outputStBuilder, List<CefTypeTx> customImplClasses)
        {
            CodeStringBuilder stbuilder = new CodeStringBuilder();
            stbuilder.AppendLine("void* NewInstance(int typeName, managed_callback mcallback, jsvalue* jsvalue){");
            stbuilder.AppendLine("switch(typeName){");
            int j = customImplClasses.Count;
            for (int i = 0; i < j; ++i)
            {
                CefTypeTx tx = customImplClasses[i];
                CodeTypeDeclaration typedecl = tx.OriginalDecl;
                stbuilder.AppendLine("case  CefTypeName_" + typedecl.Name + ":{");
                CodeTypeDeclaration implTypeDecl = tx.ImplTypeDecl;
                stbuilder.AppendLine("auto inst =new " + tx.CppImplClassName + "();");
                stbuilder.AppendLine("inst->mcallback = mcallback;");
                stbuilder.AppendLine("return " + tx.ImplTypeDecl.Name + "::Wrap(inst);");
                stbuilder.AppendLine("}");
            }
            stbuilder.AppendLine("}");//end switch
            stbuilder.AppendLine("return nullptr;");
            stbuilder.AppendLine("}");
            //
            outputStBuilder.Append(stbuilder.ToString());

        }
    }

    class CppSwicthTableCodeGen : CppCodeGen
    {
        public void CreateCppSwitchTable(StringBuilder stbuilder, List<CefInstanceElementTx> instanceClassPlans)
        {
            CodeStringBuilder cppStBuilder = new CodeStringBuilder();
            //------
            cppStBuilder.AppendLine("void MyCefMet_CallN(void* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7){");
            cppStBuilder.AppendLine(" int cefTypeName = (metName >> 16);");
            cppStBuilder.AppendLine(" switch (cefTypeName)");
            cppStBuilder.AppendLine(" {");
            cppStBuilder.AppendLine(" default: break;");

            int j = instanceClassPlans.Count;
            for (int i = 0; i < j; ++i)
            {
                CefInstanceElementTx instanceClassPlan = instanceClassPlans[i];
                cppStBuilder.AppendLine("case " + "CefTypeName_" + instanceClassPlan.OriginalDecl.Name + ":");
                cppStBuilder.AppendLine("{");
                cppStBuilder.AppendLine("MyCefMet_" + instanceClassPlan.OriginalDecl.Name + "((" + instanceClassPlan.UnderlyingCType + "*)me1,metName & 0xffff,ret");
                int nn = instanceClassPlan.MaxMethodParCount;
                for (int m = 0; m < nn; ++m)
                {
                    cppStBuilder.Append(",v" + (m + 1));
                }

                cppStBuilder.AppendLine(");");
                cppStBuilder.AppendLine("break;");
                cppStBuilder.AppendLine("}");
            }
            cppStBuilder.AppendLine("}");
            cppStBuilder.AppendLine("}");

            stbuilder.Append(cppStBuilder.ToString());
        }
    }
}