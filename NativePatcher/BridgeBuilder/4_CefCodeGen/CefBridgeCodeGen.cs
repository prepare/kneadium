//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{
    public class CefBridgeCodeGen
    {
        public void GenerateBridge(string cefSrcFolder)
        {

            string cefDir = cefSrcFolder;
            List<CodeCompilationUnit> totalCuList_capi = new List<CodeCompilationUnit>();
            List<CodeCompilationUnit> totalCuList = new List<CodeCompilationUnit>();
            List<CodeCompilationUnit> test_cpptoc_List = new List<CodeCompilationUnit>();
            //-----------------------------
            {
                //cpptoc folder
                string[] onlyCppFiles = System.IO.Directory.GetFiles(cefDir + @"\cpptoc", "*.cc");
                //we skip some files
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new string[] {
                    "base_ref_counted_cpptoc.cc" ,
                    "base_scoped_cpptoc.cc" });
                int j = onlyCppFiles.Length;

                for (int i = 0; i < j; ++i)
                {
                    if (skipFiles.ContainsKey(System.IO.Path.GetFileName(onlyCppFiles[i])))
                    {
                        continue;
                    }
                    CodeCompilationUnit cu = ParseCppFile(onlyCppFiles[i]);
                    test_cpptoc_List.Add(cu);

                    //
                    CppToCsImplCodeGen cppToCsImplCodeGen = new CppToCsImplCodeGen();
                    string onlyFileName = System.IO.Path.GetFileName(cu.Filename);
                    if (onlyFileName == "v8interceptor_cpptoc.cc")
                    {
                        continue;
                    }


                    //cppToCsImplCodeGen.PatchCppMethod(cu, cefDir + @"\libcef_dll\cpptoc\" + onlyFileName, cefDir + @"\cpptoc");
                    cppToCsImplCodeGen.PatchCppMethod(cu, null, cefDir + @"\cpptoc");
                }

            }
            //-----------------------------

            //-----------------------------
            {
                //cef capi
                string[] onlyHeaderFiles = System.IO.Directory.GetFiles(cefDir + @"\include\capi", "*.h");
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new string[0]);
                int j = onlyHeaderFiles.Length;
                for (int i = 0; i < j; ++i)
                {
                    if (skipFiles.ContainsKey(System.IO.Path.GetFileName(onlyHeaderFiles[i])))
                    {
                        continue;
                    }
                    CodeCompilationUnit cu = Parse(onlyHeaderFiles[i]);
                    totalCuList_capi.Add(cu);
                }
            }
            {
                //cef capi/views
                string[] onlyHeaderFiles = System.IO.Directory.GetFiles(cefDir + @"\include\capi\views", "*.h");
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new string[0]);
                int j = onlyHeaderFiles.Length;
                for (int i = 0; i < j; ++i)
                {
                    if (skipFiles.ContainsKey(System.IO.Path.GetFileName(onlyHeaderFiles[i])))
                    {
                        continue;
                    }
                    CodeCompilationUnit cu = Parse(onlyHeaderFiles[i]);
                    totalCuList_capi.Add(cu);
                }
            }


            {

                //include/internal
                totalCuList.Add(Parse(cefDir + @"\include\internal\cef_types.h"));
                totalCuList.Add(Parse(cefDir + @"\include\internal\cef_types_wrappers.h"));
                totalCuList.Add(Parse(cefDir + @"\include\internal\cef_win.h")); //for windows

            }


            {
                //include folder
                string[] onlyHeaderFiles = System.IO.Directory.GetFiles(cefDir + @"\include\", "*.h");
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new string[0]);

                int j = onlyHeaderFiles.Length;
                for (int i = 0; i < j; ++i)
                {
                    if (skipFiles.ContainsKey(System.IO.Path.GetFileName(onlyHeaderFiles[i])))
                    {
                        continue;
                    }

                    CodeCompilationUnit cu = Parse(onlyHeaderFiles[i]);
                    totalCuList.Add(cu);
                }
            }

            //c to cpp 
            {
                string[] onlyHeaderFiles = System.IO.Directory.GetFiles(cefDir + @"\libcef_dll\ctocpp", "*.h");
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new string[0]);

                int j = onlyHeaderFiles.Length;
                for (int i = 0; i < j; ++i)
                {
                    if (skipFiles.ContainsKey(System.IO.Path.GetFileName(onlyHeaderFiles[i])))
                    {
                        continue;
                    }
                    CodeCompilationUnit cu = Parse(onlyHeaderFiles[i]);
                    totalCuList.Add(cu);
                }
            }

            //cpp to c
            {
                string[] onlyHeaderFiles = System.IO.Directory.GetFiles(cefDir + @"\libcef_dll\cpptoc", "*.h");
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new string[0]);

                int j = onlyHeaderFiles.Length;
                for (int i = 0; i < j; ++i)
                {
                    if (skipFiles.ContainsKey(System.IO.Path.GetFileName(onlyHeaderFiles[i])))
                    {
                        continue;
                    }
                    CodeCompilationUnit cu = Parse(onlyHeaderFiles[i]);
                    totalCuList.Add(cu);
                }
            }

            //
            CefTypeCollection cefTypeCollection = new CefTypeCollection();
            cefTypeCollection.RootFolder = cefDir;
            cefTypeCollection.SetTypeSystem(totalCuList);




            //
            TypeTranformPlanner txPlanner = new TypeTranformPlanner();
            txPlanner.CefTypeCollection = cefTypeCollection;


            Dictionary<string, CefTypeTx> allTxPlans = new Dictionary<string, CefTypeTx>();
            List<CefHandlerTx> handlerPlans = new List<CefHandlerTx>();
            List<CefCallbackTx> callbackPlans = new List<CefCallbackTx>();
            List<CefInstanceElementTx> instanceClassPlans = new List<CefInstanceElementTx>();
            List<CefEnumTx> enumTxPlans = new List<CefEnumTx>();
            List<CefCStructTx> cstructPlans = new List<CefCStructTx>();
            //--

            //--
            int typeName = 1;
            List<TypePlan> typeTxInfoList = new List<TypePlan>();


            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._v_instanceClasses)
            {
                //eg. CefApp, CefBrowser, CefCommandLine, CefFrame
                CefInstanceElementTx instanceClassPlan = new CefInstanceElementTx(typedecl);
                instanceClassPlans.Add(instanceClassPlan);
                allTxPlans.Add(typedecl.Name, instanceClassPlan);
                TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                instanceClassPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypePlan = typeTxPlan;
                typeTxInfoList.Add(typeTxPlan);
            }


            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._v_handlerClasses)
            {
                //eg. CefDisplayHandler, CefDownloadHandler
                CefHandlerTx handlerPlan = new CefHandlerTx(typedecl);
                handlerPlans.Add(handlerPlan);
                allTxPlans.Add(typedecl.Name, handlerPlan);
                TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                handlerPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypePlan = typeTxPlan;
                typeTxInfoList.Add(typeTxPlan);
            }
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._v_callBackClasses)
            {
                //eg. CefAuthenCallback, CefPdfCallback
                CefCallbackTx callbackPlan = new CefCallbackTx(typedecl);
                callbackPlans.Add(callbackPlan);
                allTxPlans.Add(typedecl.Name, callbackPlan);
                ////
                TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                callbackPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypePlan = typeTxPlan;
                typeTxInfoList.Add(typeTxPlan);
            }
            //
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._enumClasses)
            {
                CefEnumTx enumTxPlan = new CefEnumTx(typedecl);
                enumTxPlans.Add(enumTxPlan);
                allTxPlans.Add(typedecl.Name, enumTxPlan);
                TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                enumTxPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypePlan = typeTxPlan;

            }

            List<CodeTypeDeclaration> notFoundAbstractClasses = new List<CodeTypeDeclaration>();

            foreach (CodeTypeDeclaration typedecl in cefTypeCollection.cToCppClasses)
            {
                TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypePlan = typeTxPlan;

                //cef -specific
                TemplateTypeSymbol3 baseType0 = (TemplateTypeSymbol3)typedecl.BaseTypes[0].ResolvedType;
                //add information to our model
                SimpleTypeSymbol abstractType = (SimpleTypeSymbol)baseType0.Item1;
                SimpleTypeSymbol underlying_c_type = (SimpleTypeSymbol)baseType0.Item2;

                CefTypeTx found;
                if (!allTxPlans.TryGetValue(abstractType.Name, out found))
                {
                    notFoundAbstractClasses.Add(typedecl);
                    continue;
                }
                found.UnderlyingCType = underlying_c_type;
                found.ImplTypeDecl = typedecl;

                abstractType.CefTxPlan = found;
                ////[chrome] cpp<-to<-c  <--- ::::: <--- c-interface-to[external - user - lib] ....

            }
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection.cppToCClasses)
            {
                //callback, handle, visitor etc
                TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypePlan = typeTxPlan;
                //cef -specific
                TemplateTypeSymbol3 baseType0 = (TemplateTypeSymbol3)typedecl.BaseTypes[0].ResolvedType;
                SimpleTypeSymbol abstractType = (SimpleTypeSymbol)baseType0.Item1;
                SimpleTypeSymbol underlying_c_type = (SimpleTypeSymbol)baseType0.Item2;
                CefTypeTx found;
                if (!allTxPlans.TryGetValue(abstractType.Name, out found))
                {
                    notFoundAbstractClasses.Add(typedecl);
                    continue;
                }

                found.UnderlyingCType = underlying_c_type;
                found.ImplTypeDecl = typedecl;
                abstractType.CefTxPlan = found;

                ////[chrome]  cpp->to->c  ---> ::::: ---> c-interface-to [external-user-lib] ....
                ////eg. handlers and callbacks 

            }
            //-------- 
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._plainCStructs)
            {
                //create raw type
                if (!typedecl.Name.EndsWith("Traits") &&
                   typedecl.Name.StartsWith("_"))
                {
                    //
                    CefCStructTx cstructTx = new CefCStructTx(typedecl);
                    cstructPlans.Add(cstructTx);
                    TypePlan typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                    cstructTx.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                    typedecl.TypePlan = typeTxPlan;
                    //
                    typeTxInfoList.Add(typeTxPlan);
                }
                else
                {
                }
            }

            //--------
            //code gen 

            List<CefTypeTx> customImplClasses = new List<CefTypeTx>();
            StringBuilder cppCodeStBuilder = new StringBuilder();
            AddCppBuiltInBeginCode(cppCodeStBuilder);

            CodeStringBuilder cppHeaderInternalForExportFunc = new CodeStringBuilder();
            cppHeaderInternalForExportFunc.AppendLine(
                "//MIT, 2017, WinterDev\r\n" +
                "//AUTOGEN");


            foreach (TypePlan txinfo in typeTxInfoList)
            {
                cppHeaderInternalForExportFunc.AppendLine("const int CefTypeName_" + txinfo.TypeDecl.Name + " = " + txinfo.CsInterOpTypeNameId.ToString() + ";");
            }


            StringBuilder csCodeStBuilder = new StringBuilder();
            AddCsCodeHeader(csCodeStBuilder);
            CefCodeGenOutput codeGenOutput = null;
            foreach (CefTypeTx tx in enumTxPlans)
            {
                codeGenOutput = new CefCodeGenOutput();
                tx.GenerateCode(codeGenOutput);
                //get cs output
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
            }
            csCodeStBuilder.Append("}"); //close namespace
            //save to file
            System.IO.File.WriteAllText("CefEnums.cs", csCodeStBuilder.ToString());

            //-------------------------
            CodeStringBuilder cppHeaderExportFuncAuto = new CodeStringBuilder();
            cppHeaderExportFuncAuto.AppendLine("//AUTOGEN");
            //-------------------------

            //cef instance is quite large             
            //so we spit the code gen into 2 sections
            int instance_count = instanceClassPlans.Count;
            int mid = instance_count / 2;
            {
                //1st part
                csCodeStBuilder = new StringBuilder();
                AddCsCodeHeader(csCodeStBuilder);
                //-------------------------         
                for (int cc = 0; cc < mid; ++cc)
                {
                    CefInstanceElementTx tx = instanceClassPlans[cc];
                    codeGenOutput = new CefCodeGenOutput();
                    tx.GenerateCode(codeGenOutput);
                    //---------------------------------------------------- 
                    cppCodeStBuilder.AppendLine();
                    cppCodeStBuilder.AppendLine("// " + tx.OriginalDecl.ToString());
                    cppCodeStBuilder.Append(codeGenOutput._cppCode.ToString());
                    cppCodeStBuilder.AppendLine();
                    //---------------------------------------------------- 
                    csCodeStBuilder.AppendLine();
                    csCodeStBuilder.AppendLine("// " + tx.OriginalDecl.ToString());
                    csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
                    csCodeStBuilder.AppendLine();
                    //--------------------------------------------

                    cppHeaderExportFuncAuto.Append(codeGenOutput._cppHeaderExportFuncAuto.ToString());
                    cppHeaderInternalForExportFunc.Append(codeGenOutput._cppHeaderInternalForExportFuncAuto.ToString());
                    //----------
                    if (tx.CppImplClassNameId > 0)
                    {
                        customImplClasses.Add(tx);
                    }
                }
                csCodeStBuilder.Append("}");
                //save to file
                System.IO.File.WriteAllText("CefInstances_P1.cs", csCodeStBuilder.ToString());
                //------------------------- 
            }
            {
                //2nd part
                //1st part
                csCodeStBuilder = new StringBuilder();
                AddCsCodeHeader(csCodeStBuilder);

                for (int cc = mid; cc < instance_count; ++cc)
                {
                    CefInstanceElementTx tx = instanceClassPlans[cc];
                    codeGenOutput = new CefCodeGenOutput();
                    tx.GenerateCode(codeGenOutput);
                    //---------------------------------------------------- 
                    cppCodeStBuilder.AppendLine();
                    cppCodeStBuilder.AppendLine("// " + tx.OriginalDecl.ToString());
                    cppCodeStBuilder.Append(codeGenOutput._cppCode.ToString());
                    cppCodeStBuilder.AppendLine();
                    //---------------------------------------------------- 
                    csCodeStBuilder.AppendLine();
                    csCodeStBuilder.AppendLine("// " + tx.OriginalDecl.ToString());
                    csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
                    csCodeStBuilder.AppendLine();
                    //--------------------------------------------

                    cppHeaderExportFuncAuto.Append(codeGenOutput._cppHeaderExportFuncAuto.ToString());
                    cppHeaderInternalForExportFunc.Append(codeGenOutput._cppHeaderInternalForExportFuncAuto.ToString());
                    //----------
                    if (tx.CppImplClassNameId > 0)
                    {
                        customImplClasses.Add(tx);
                    }
                }
                csCodeStBuilder.Append("}");
                //save to file
                System.IO.File.WriteAllText("CefInstances_P2.cs", csCodeStBuilder.ToString());
                //-------------------------  
            }



            csCodeStBuilder = new StringBuilder();
            AddCsCodeHeader(csCodeStBuilder);
            foreach (CefCallbackTx tx in callbackPlans)
            {

                codeGenOutput = new CefCodeGenOutput();
                tx.GenerateCode(codeGenOutput);

                cppCodeStBuilder.Append(codeGenOutput._cppCode.ToString());
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
                //----------
                cppHeaderExportFuncAuto.Append(codeGenOutput._cppHeaderExportFuncAuto.ToString());
                cppHeaderInternalForExportFunc.Append(codeGenOutput._cppHeaderInternalForExportFuncAuto.ToString());
                //----------
                if (tx.CppImplClassNameId > 0)
                {
                    customImplClasses.Add(tx);
                }
            }
            csCodeStBuilder.Append("}");
            //save to file
            System.IO.File.WriteAllText("CefCallbacks.cs", csCodeStBuilder.ToString());
            //------------------------- 
            csCodeStBuilder = new StringBuilder();
            AddCsCodeHeader(csCodeStBuilder);
            foreach (CefHandlerTx tx in handlerPlans)
            {
                codeGenOutput = new CefCodeGenOutput();
                tx.GenerateCode(codeGenOutput);

                cppCodeStBuilder.Append(codeGenOutput._cppCode.ToString());
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
                //----------
                cppHeaderExportFuncAuto.Append(codeGenOutput._cppHeaderExportFuncAuto.ToString());
                cppHeaderInternalForExportFunc.Append(codeGenOutput._cppHeaderInternalForExportFuncAuto.ToString());
                //---------- 
            }
            csCodeStBuilder.Append("}");
            //save to file
            System.IO.File.WriteAllText("CefHandlers.cs", csCodeStBuilder.ToString());
            //------------------------- 
            csCodeStBuilder = new StringBuilder();
            AddCsCodeHeader(csCodeStBuilder);
            foreach (CefCStructTx tx in cstructPlans)
            {
                codeGenOutput = new CefCodeGenOutput();
                tx.GenerateCode(codeGenOutput);
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
            }
            csCodeStBuilder.Append("}");
            //save to file
            System.IO.File.WriteAllText("CefPlainCStructs.cs", csCodeStBuilder.ToString());
            //------------------------- 
            csCodeStBuilder = new StringBuilder();
            AddCsCodeHeader(csCodeStBuilder);
            CsNativeHandlerSwitchTableCodeGen csNativeHandlerSwitchTableCodeGen = new CsNativeHandlerSwitchTableCodeGen();
            csNativeHandlerSwitchTableCodeGen.GenerateCefNativeRequestHandlers(handlerPlans, csCodeStBuilder);
            //cs...
            csCodeStBuilder.AppendLine("}");
            System.IO.File.WriteAllText("CefApiSwitchTables.cs", csCodeStBuilder.ToString());
            //--------
            //cpp
            CppSwicthTableCodeGen cppSwitchTableCodeGen = new CppSwicthTableCodeGen();
            cppSwitchTableCodeGen.CreateCppSwitchTableForInstanceMethods(cppCodeStBuilder, instanceClassPlans);
            cppSwitchTableCodeGen.CreateCppSwitchTableForStaticMethods(cppCodeStBuilder, instanceClassPlans);
            //
            CppInstanceMethodCodeGen instanceMetCodeGen = new CppInstanceMethodCodeGen();
            instanceMetCodeGen.CreateCppNewInstanceMethod(cppCodeStBuilder, customImplClasses);
            //--------
            cppCodeStBuilder.AppendLine("/////////////////////////////////////////////////");
            // 
        }


        void AddCsCodeHeader(StringBuilder stbuilder)
        {
            stbuilder.AppendLine(
                "//MIT, 2017, WinterDev\r\n" +
                "//AUTOGEN CONTENT\r\n" +
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Runtime.InteropServices;\r\n" +
                "namespace LayoutFarm.CefBridge.Auto{\r\n");
        }
        void AddCppBuiltInBeginCode(StringBuilder cppStBuilder)
        {

            string prebuilt1 =
            @"
            //MIT, 2017, WinterDev
            //AUTOGEN
        
            #pragma once
            #include ""ExportFuncAuto.h""
            #include ""InternalHeaderForExportFunc.h""
            //----------------
            const int MET_Release = 0;
            //----------------  
            //
#include ""libcef_dll/cpptoc/drag_handler_cpptoc.h"" 
#include ""libcef_dll/cpptoc/navigation_entry_visitor_cpptoc.h""
#include ""libcef_dll/cpptoc/pdf_print_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/client_cpptoc.h""
#include ""libcef_dll/cpptoc/download_image_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/run_file_dialog_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/domvisitor_cpptoc.h""
#include ""libcef_dll/cpptoc/completion_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/cookie_visitor_cpptoc.h""
#include ""libcef_dll/cpptoc/delete_cookies_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/menu_model_delegate_cpptoc.h""
#include ""libcef_dll/cpptoc/request_context_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/resolve_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/response_filter_cpptoc.h""
#include ""libcef_dll/cpptoc/scheme_handler_factory_cpptoc.h""
#include ""libcef_dll/cpptoc/task_cpptoc.h""
#include ""libcef_dll/cpptoc/set_cookie_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/v8accessor_cpptoc.h""
#include ""libcef_dll/cpptoc/v8handler_cpptoc.h""
#include ""libcef_dll/cpptoc/v8interceptor_cpptoc.h""
#include ""libcef_dll/cpptoc/web_plugin_info_visitor_cpptoc.h""
#include ""libcef_dll/cpptoc/web_plugin_unstable_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/write_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/app_cpptoc.h""
#include ""libcef_dll/cpptoc/urlrequest_client_cpptoc.h""
#include ""libcef_dll/cpptoc/string_visitor_cpptoc.h""
#include ""libcef_dll/cpptoc/get_geolocation_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/end_tracing_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/register_cdm_callback_cpptoc.h""
#include ""libcef_dll/cpptoc/accessibility_handler_cpptoc.h""

//handlers
#include ""libcef_dll/cpptoc/resource_bundle_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/browser_process_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/dialog_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/render_process_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/context_menu_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/display_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/download_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/find_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/focus_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/geolocation_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/jsdialog_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/keyboard_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/life_span_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/load_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/render_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/request_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/resource_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/print_handler_cpptoc.h""
#include ""libcef_dll/cpptoc/read_handler_cpptoc.h""

            
            //////////////////////////////////////////////////////////////////";

            using (System.IO.StringReader strReader = new System.IO.StringReader(prebuilt1))
            {
                string line = strReader.ReadLine();
                while (line != null)
                {

                    line = line.TrimStart();
                    cppStBuilder.AppendLine(line);
                    //
                    line = strReader.ReadLine();
                }
            }
        }



        static Dictionary<string, bool> CreateSkipFiles(string[] filenames)
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            foreach (string s in filenames)
            {
                dic.Add(s, true);
            }
            return dic;
        }

        CodeCompilationUnit ParseCppFile(string filename)
        {
            //-----
            //this is for Cef3 cpp-to-c .cc file only!!!
            //test_cpptoc_List -> this version we need some pre-precessing step
            //-----

            List<string> lines = new List<string>(System.IO.File.ReadAllLines(filename));
            List<string> selectedLines = new List<string>();
            int j = lines.Count;

            for (int i = 0; i < j; ++i)
            {
                string line = lines[i].Trim();
                if (line.StartsWith("//"))
                {
                    //this is comment
                    //read the comment
                    if (line.Contains("CONSTRUCTOR"))
                    {
                        //stop here
                        break;
                    }
                }
                selectedLines.Add(line);
            }

            CodeCompilationUnit cu = Parse(filename, selectedLines);

            return cu;
        }
        CodeCompilationUnit Parse(string srcFile)
        {

            Cef3FileParser headerParser = new Cef3FileParser();
            headerParser.Parse(srcFile);
            return headerParser.Result;
        }
        CodeCompilationUnit Parse(string srcFile, IEnumerable<string> lines)
        {

            Cef3FileParser headerParser = new Cef3FileParser();
            headerParser.Parse(srcFile, lines);
            return headerParser.Result;
        }


    }
}