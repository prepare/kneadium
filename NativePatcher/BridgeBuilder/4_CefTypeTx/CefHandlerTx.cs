//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
namespace BridgeBuilder
{
    /// <summary>
    /// tx for handler class
    /// </summary>
    class CefHandlerTx : CefTypeTx
    {
        TypePlan _typeTxInfo;
        public CefHandlerTx(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        void GenerateCppImplMethodForNs(MethodPlan met, CodeStringBuilder stbuilder, bool useJsSlot)
        {
            CodeMethodDeclaration metDecl = met.metDecl;
            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            //temp
            if (metDecl.ReturnType.ToString() == "FilterStatus")
            {
                stbuilder.Append(metDecl.ReturnType.ResolvedType + " " + metDecl.Name + "(");
            }
            else
            {
                stbuilder.Append(metDecl.ReturnType + " " + metDecl.Name + "(");
            }


            List<CodeMethodParameter> pars = metDecl.Parameters;

            //first par is managed callback
            stbuilder.Append("managed_callback mcallback");
            int j = pars.Count;
            for (int i = 0; i < j; ++i)
            {

                stbuilder.Append(",");
                CodeMethodParameter par = pars[i];

                if (par.IsConstPar)
                {
                    stbuilder.Append("const ");
                }
                //parameter type

                stbuilder.Append(par.ParameterType.ResolvedType.FullName + " ");
                stbuilder.Append(par.ParameterName);
            }
            stbuilder.AppendLine("){");
            //----------- 

            for (int i = 0; i < j; ++i)
            {
                MethodParameter parTx = met.pars[i];
                parTx.ClearExtractCode();
                PrepareDataFromNativeToCs(parTx, "&vargs[" + (i + 1) + "]", parTx.Name, true);
            }
            //method body
            if (!useJsSlot)
            {
                stbuilder.AppendLine("if(mcallback){");
                string metArgsClassName = metDecl.Name + "Args";
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
                stbuilder.AppendLine("mcallback( (_typeName << 16) | " + met.CppMethodSwitchCaseName + ",&args1.arg);");
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
                PrepareCppMetArg(met.ReturnPlan, "vargs[0]");
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
                stbuilder.AppendLine("mcallback( (_typeName << 16) | " + met.CppMethodSwitchCaseName + ",&args);");

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
            }

            //-------------------
            //default return if no managed callback
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

        void GenerateCppImplMethodDeclarationForNs(MethodPlan met, CodeStringBuilder stbuilder)
        {
            CodeMethodDeclaration metDecl = met.metDecl;
            stbuilder.AppendLine();
            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            //temp
            if (metDecl.ReturnType.ToString() == "FilterStatus")
            {
                stbuilder.Append(metDecl.ReturnType.ResolvedType + " " + metDecl.Name + "(");
            }
            else
            {
                stbuilder.Append(metDecl.ReturnType + " " + metDecl.Name + "(");
            }
            List<CodeMethodParameter> pars = metDecl.Parameters;
            //first par is managed callback
            stbuilder.Append("managed_callback mcallback");
            int j = pars.Count;
            for (int i = 0; i < j; ++i)
            {

                stbuilder.Append(",");
                CodeMethodParameter par = pars[i];

                if (par.IsConstPar)
                {
                    stbuilder.Append("const ");
                }
                //parameter type

                stbuilder.Append(par.ParameterType.ResolvedType.FullName + " ");
                stbuilder.Append(par.ParameterName);
            }
            stbuilder.AppendLine(");");
        }

        void GenerateCppImplNamespace(CodeTypeDeclaration orgDecl,
            List<MethodPlan> callToDotNetMets,
            CodeStringBuilder stbuilder)
        {

            string namespaceName = orgDecl.Name + "Ext"; //namespace
            this.CppImplClassNameId = _typeTxInfo.CsInterOpTypeNameId;
            this.CppImplClassName = namespaceName;
            //----------------------------------------------
            //create a cpp namespace      
            stbuilder.Append("namespace " + namespaceName);
            stbuilder.AppendLine("{");


            int nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodPlan met = callToDotNetMets[mm];
                met.CppMethodSwitchCaseName = namespaceName + "_" + met.Name + "_" + (mm + 1);
            }
            nn = callToDotNetMets.Count;
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodPlan met = callToDotNetMets[mm];
                //prepare data and call the callback
                GenerateCppImplMethodForNs(met, stbuilder, false);
            }
            stbuilder.AppendLine("}");
            //----------------------------------------------

            //----------------------------------------------
            //InternalHeaderForExportFunc.h
            _cppHeaderInternalForExportFuncAuto.AppendLine("namespace " + namespaceName);
            _cppHeaderInternalForExportFuncAuto.AppendLine("{");
            _cppHeaderInternalForExportFuncAuto.AppendLine("const int _typeName=" + "CefTypeName_" + orgDecl.Name + ";");
            for (int mm = 0; mm < nn; ++mm)
            {
                MethodPlan met = callToDotNetMets[mm];
                _cppHeaderInternalForExportFuncAuto.AppendLine("const int " + met.CppMethodSwitchCaseName + "=" + (mm + 1) + ";");
            }
            _cppHeaderInternalForExportFuncAuto.AppendLine("}");
            //----------------------------------------------
            //ExportFuncAuto.h
            _cppHeaderExportFuncAuto.AppendLine("namespace " + namespaceName);
            _cppHeaderExportFuncAuto.AppendLine("{");
            for (int mm = 0; mm < nn; ++mm)
            {
                //implement on event notificationi
                MethodPlan met = callToDotNetMets[mm];
                //prepare data and call the callback                 
                GenerateCppImplMethodDeclarationForNs(met, _cppHeaderExportFuncAuto);
            }
            _cppHeaderExportFuncAuto.AppendLine("}");

        }

        CodeStringBuilder _cppHeaderExportFuncAuto;
        CodeStringBuilder _cppHeaderInternalForExportFuncAuto;

        public override void GenerateCode(CefCodeGenOutput output)
        {
            _cppHeaderExportFuncAuto = output._cppHeaderExportFuncAuto;
            _cppHeaderInternalForExportFuncAuto = output._cppHeaderInternalForExportFuncAuto;


            //cpp
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
            List<MethodPlan> callToDotNetMets = new List<MethodPlan>();
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            int maxPar = 0;
            int j = _typeTxInfo.methods.Count;

            for (int i = 0; i < j; ++i)
            {
                MethodPlan metTx = _typeTxInfo.methods[i];
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
                GenerateCppImplNamespace(orgDecl, callToDotNetMets, output._cppCode);
            }
            //----------------------------------------------------------------------- 

            //C# part
            CsStructModuleCodeGen structModuleCodeGen = new CsStructModuleCodeGen();
            if (callToDotNetMets.Count > 0)
            {
                structModuleCodeGen.GenerateCsStructClass(orgDecl, callToDotNetMets, output._csCode);
            }

            //back to cpp again...
            CppToCsMethodArgsClassGen cppMetArgClassGen = new CppToCsMethodArgsClassGen();
            //------------------------------------------------------------------
            CodeStringBuilder cppArgClassStBuilder = new CodeStringBuilder();
            cppArgClassStBuilder.AppendLine("namespace " + orgDecl.Name + "Ext{");
            for (int i = 0; i < j; ++i)
            {
                MethodPlan met = _typeTxInfo.methods[i];
                cppMetArgClassGen.GenerateCppMethodArgsClass(met, cppArgClassStBuilder);
            }
            cppArgClassStBuilder.AppendLine("}");
            _cppHeaderExportFuncAuto.Append(cppArgClassStBuilder.ToString());
            //------------------------------------------------------------------
        }
    }

}