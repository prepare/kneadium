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
        TypePlan _typePlan;

        static int codeGenNum;

        public CefHandlerTx(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        void GenerateCppImplMethodForNs(MethodPlan met, CodeStringBuilder stbuilder )
        {

            CodeMethodDeclaration metDecl = met.metDecl;

            stbuilder.AppendLine("//CefHandlerTx::GenerateCppImplMethodForNs ," + (++codeGenNum));
            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            //--------------------------- 

            //temp
            if (metDecl.ReturnType.ToString() == "FilterStatus")
            {
                stbuilder.Append(metDecl.ReturnType.ResolvedType + " " + metDecl.Name + "(");
            }
            else if (metDecl.ReturnType.ToString() == "ReturnValue")
            {
                string ownerName = metDecl.OwnerTypeDecl.Name;
                stbuilder.Append(ownerName + "::" + metDecl.ReturnType + " " + metDecl.Name + "(");
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

            //-----------------------------
            //use native C data slot 
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
            //temp fix, arg extract code 
            if (!met.ReturnPlan.IsVoid)
            {
                stbuilder.AppendLine("return args1.arg.myext_ret_value;");
            } 
            stbuilder.AppendLine("}");


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
                            {
                                string ownerName = metDecl.OwnerTypeDecl.Name;
                                stbuilder.Append("return (" + ownerName + "::ReturnValue)0;");
                            }
                            break;
                        case "CefSize":
                            stbuilder.Append("return CefSize();");
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
            stbuilder.AppendLine("//CefHandlerTx::GenerateCppImplMethodDeclarationForNs ," + (++codeGenNum));
            stbuilder.AppendLine("//gen! " + metDecl.ToString());
            //--------------------------- 

            //temp
            switch (metDecl.ReturnType.ToString())
            {
                case "FilterStatus":
                    stbuilder.Append(metDecl.ReturnType.ResolvedType + " " + metDecl.Name + "(");
                    break;
                case "ReturnValue":
                    string ownerType = met.metDecl.OwnerTypeDecl.Name;
                    stbuilder.Append(ownerType + "::" + metDecl.ReturnType + " " + metDecl.Name + "(");
                    break;
                default:
                    stbuilder.Append(metDecl.ReturnType + " " + metDecl.Name + "(");
                    break;
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
            this.CppImplClassNameId = _typePlan.CsInterOpTypeNameId;
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
                GenerateCppImplMethodForNs(met, stbuilder);
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
                _typePlan = orgDecl.TypePlan;
            }
            else
            {
                _typePlan = implTypeDecl.TypePlan;
            }

            //-----------------------------------------------------------------------
            List<MethodPlan> callToDotNetMets = new List<MethodPlan>();
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            int maxPar = 0;
            int j = _typePlan.methods.Count;

            for (int i = 0; i < j; ++i)
            {
                MethodPlan metTx = _typePlan.methods[i];
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
                MethodPlan met = _typePlan.methods[i];
                cppMetArgClassGen.GenerateCppMethodArgsClass(met, cppArgClassStBuilder);
            }
            cppArgClassStBuilder.AppendLine("}");
            _cppHeaderExportFuncAuto.Append(cppArgClassStBuilder.ToString());
            //------------------------------------------------------------------
        }
    }

}