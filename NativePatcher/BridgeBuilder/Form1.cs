//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BridgeBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cefSrcRootDir = @"D:\projects\cef_binary_3.3071.1647.win32";

        private void cmdCreatePatchFiles_Click(object sender, EventArgs e)
        {

            //1. analyze modified source files, in source folder  
            PatchBuilder builder = new PatchBuilder(new string[]{
                cefSrcRootDir + @"\tests\cefclient",
                cefSrcRootDir + @"\tests\shared"
            });
            builder.MakePatch();

            //2. save patch to...
            string saveFolder = "d:\\WImageTest\\cefbridge_patches";
            builder.Save(saveFolder);

            //----------
            //copy extension code          
            CopyFileInFolder(saveFolder,
                @"D:\projects\Kneadium\NativePatcher\cefbridge_patches"
               );
            //copy ext from actual src 
            CopyFileInFolder(
                cefSrcRootDir + @"\tests\cefclient\myext",
                 @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode\myext");
            //----------
            //copy ext from actual src 
            CopyFileInFolder(
                cefSrcRootDir + @"\libcef_dll\myext",
                 @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode_libcef_dll\myext");
            //---------- 
            //copy file by file
            CopyFile(cefSrcRootDir + "\\include\\cef_base.h",
                    @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode_Others");
            CopyFile(cefSrcRootDir + "\\libcef_dll\\ctocpp\\ctocpp_ref_counted.h",
                @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode_Others");
            CopyFile(cefSrcRootDir + "\\libcef_dll\\cpptoc\\cpptoc_ref_counted.h",
                @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode_Others");

        }
        /// <summary>
        /// copy a single file and place (overwrite) into destination target folder
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="destTargetFolder"></param>
        static void CopyFile(string filename, string destTargetFolder)
        {
            string onlyFileName = System.IO.Path.GetFileName(filename);
            System.IO.File.Copy(filename, destTargetFolder + "//" + onlyFileName, true);
        }
        static void CopyFolder(string srcFolder, string intoTargetFolder)
        {
            //force update
            //copy files
            string folderName = System.IO.Path.GetFileName(srcFolder);
            string targetFolder = intoTargetFolder + "\\" + folderName;
            if (System.IO.Directory.Exists(targetFolder))
            {
                //delete
                System.IO.Directory.Delete(targetFolder, true);
            }
            System.IO.Directory.CreateDirectory(targetFolder);
            //
            //copy file
            CopyFileInFolder(srcFolder, targetFolder);
            //
            string[] subDirs = System.IO.Directory.GetDirectories(srcFolder);

            int j = subDirs.Length;
            for (int i = 0; i < j; ++i)
            {
                CopyFolder(subDirs[i], targetFolder);
            }
        }

        static void CopyFileInFolder(string srcFolder, string targetFolder)
        {
            //not recursive
            if (srcFolder == targetFolder)
            {
                throw new NotSupportedException();
            }
            string[] srcFiles = System.IO.Directory.GetFiles(srcFolder);
            foreach (var f in srcFiles)
            {
                System.IO.File.Copy(f,
                    targetFolder + "\\" + System.IO.Path.GetFileName(f), true);
            }
        }

        private void cmdLoadPatchAndApplyPatch_Click(object sender, EventArgs e)
        {
            //cef_binary_3.3071.1647 
            string srcRootDir0 = @"D:\projects\cef_binary_3.3071.1647.win32";
            string saveFolder = "d:\\WImageTest\\cefbridge_patches";
            string newPathName = srcRootDir0 + "\\tests";

            //copy my extension file
            CopyFolder(@"..\..\Patcher_ExtCode\myext", newPathName + "\\cefclient");
            //copy my extension file
            CopyFolder(@"..\..\Patcher_ExtCode_libcef_dll\myext", srcRootDir0 + "\\libcef_dll");
            //-----------
            ManualPatcher manualPatcher = new ManualPatcher(newPathName);

            //1.
            System.IO.File.Copy(@"..\..\Patcher_ExtCode_Others\cef_base.h",
                 srcRootDir0 + "\\include\\cef_base.h", true);
            //2.
            System.IO.File.Copy(@"..\..\Patcher_ExtCode_Others\cpptoc_ref_counted.h",
                srcRootDir0 + "\\libcef_dll\\cpptoc\\cpptoc_ref_counted.h", true);
            //3.
            System.IO.File.Copy(@"..\..\Patcher_ExtCode_Others\ctocpp_ref_counted.h",
                srcRootDir0 + "\\libcef_dll\\ctocpp\\ctocpp_ref_counted.h", true);
            //-----------

            manualPatcher.Do_LibCefDll_CMake_txt(srcRootDir0 + "\\libcef_dll\\CMakeLists.txt");
            manualPatcher.Do_CefClient_CMake_txt();
            //-----------
            PatchBuilder builder2 = new PatchBuilder(new string[]{
                newPathName,
            });
            builder2.LoadPatchesFromFolder(saveFolder);

            List<PatchFile> pfiles = builder2.GetAllPatchFiles();
            //string oldPathName = srcRootDir; 


            for (int i = pfiles.Count - 1; i >= 0; --i)
            {
                //can change original filename before patch

                PatchFile pfile = pfiles[i];

                string onlyFileName = System.IO.Path.GetFileName(pfile.OriginalFileName);
                string onlyPath = System.IO.Path.GetDirectoryName(pfile.OriginalFileName);

                int indexOfCefClient = onlyPath.IndexOf("\\cefclient\\");
                if (indexOfCefClient < 0)
                {
                    indexOfCefClient = onlyPath.IndexOf("\\shared\\");
                    if (indexOfCefClient < 0)
                    {
                        indexOfCefClient = onlyPath.IndexOf("\\cefclient");
                        if (indexOfCefClient < 0)
                        {
                            throw new NotSupportedException();
                        }
                    }
                }
                string rightSide = onlyPath.Substring(indexOfCefClient);
                //string replaceName = onlyPath.Replace("D:\\projects\\cef_binary_3.2623.1399\\cefclient", newPathName);
                string replaceName = newPathName + rightSide;
                pfile.OriginalFileName = replaceName + "//" + onlyFileName;
                pfile.PatchContent();
            }
        }

        private void cmdMacBuildPatchesFromSrc_Click(object sender, EventArgs e)
        {

            string srcRootDir = @"D:\projects\cef_binary_3.3071.1647.macos\tests\cefclient";

            PatchBuilder builder = new PatchBuilder(new string[]{
                srcRootDir,
                @"D:\projects\cef_binary_3.3071.1647.macos\tests\shared"
            });
            builder.MakePatch();

            //2. save patch to...
            string saveFolder = "d:\\WImageTest\\cefbridge_patches_mac";
            builder.Save(saveFolder);

            ////3. test load those patches
            //PatchBuilder builder2 = new PatchBuilder(srcRootDir);
            //builder2.LoadPatchesFromFolder(saveFolder);

            //----------
            //copy extension code          
            CopyFileInFolder(saveFolder,
                @"D:\projects\Kneadium\NativePatcher\cefbridge_patches_mac"
               );
            //copy ext from actual src 
            CopyFileInFolder(srcRootDir + "\\myext",
                 @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode_mac\myext");
        }

        private void cmdMacApplyPatches_Click(object sender, EventArgs e)
        {


            //cef_binary_3.3071.1647
            //string srcRootDir = @"D:\projects\cef_binary_3.3071.1647.win32\tests";
            string srcRootDir = @"D:\projects\cef_binary_3.3071.1647.macos\tests";
            string patchSrcFolder = "d:\\WImageTest\\cefbridge_patches_mac";

            PatchBuilder builder2 = new PatchBuilder(new string[]{
                srcRootDir,
            });
            builder2.LoadPatchesFromFolder(patchSrcFolder);

            List<PatchFile> pfiles = builder2.GetAllPatchFiles();
            string newPathName = srcRootDir;

            for (int i = pfiles.Count - 1; i >= 0; --i)
            {
                //can change original filename before patch

                PatchFile pfile = pfiles[i];

                string onlyFileName = System.IO.Path.GetFileName(pfile.OriginalFileName);
                string onlyPath = System.IO.Path.GetDirectoryName(pfile.OriginalFileName);

                int indexOfCefClient = onlyPath.IndexOf("\\cefclient\\");
                if (indexOfCefClient < 0)
                {
                    indexOfCefClient = onlyPath.IndexOf("\\shared\\");
                    if (indexOfCefClient < 0)
                    {
                        throw new NotSupportedException();
                    }
                }
                string rightSide = onlyPath.Substring(indexOfCefClient);
                //string replaceName = onlyPath.Replace("D:\\projects\\cef_binary_3.2623.1399\\cefclient", newPathName);
                string replaceName = newPathName + rightSide;
                pfile.OriginalFileName = replaceName + "//" + onlyFileName;
                pfile.PatchContent();
            }


            throw new NotSupportedException();
            ManualPatcher manualPatcher = new ManualPatcher(newPathName);
            string extTargetDir = newPathName + "\\cefclient\\myext";
            //manualPatcher.CopyExtensionSources(extTargetDir);
            manualPatcher.Do_CefClient_CMake_txt();
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

            CodeCompilationUnit cu = ParseWrapper(filename, selectedLines);

            return cu;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //cpp-to-c wrapper and c-to-cpp wrapper
            //ParseWrapper(@"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h");

            string cefDir = @"D:\projects\cef_binary_3.3071.1647.win32";

            List<CodeCompilationUnit> totalCuList_capi = new List<CodeCompilationUnit>();
            List<CodeCompilationUnit> totalCuList = new List<CodeCompilationUnit>();
            List<CodeCompilationUnit> test_cpptoc_List = new List<CodeCompilationUnit>();

            {

                string[] onlyCppFiles = System.IO.Directory.GetFiles(cefDir + @"\libcef_dll\cpptoc", "*.cc");
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
                }
            }

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
                    CodeCompilationUnit cu = ParseWrapper(onlyHeaderFiles[i]);
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
                    CodeCompilationUnit cu = ParseWrapper(onlyHeaderFiles[i]);
                    totalCuList_capi.Add(cu);
                }
            }


            {

                //include/internal
                totalCuList.Add(ParseWrapper(cefDir + @"\include\internal\cef_types.h"));
                totalCuList.Add(ParseWrapper(cefDir + @"\include\internal\cef_types_wrappers.h"));
                totalCuList.Add(ParseWrapper(cefDir + @"\include\internal\cef_win.h")); //for windows

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

                    CodeCompilationUnit cu = ParseWrapper(onlyHeaderFiles[i]);
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
                    CodeCompilationUnit cu = ParseWrapper(onlyHeaderFiles[i]);
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
                    CodeCompilationUnit cu = ParseWrapper(onlyHeaderFiles[i]);
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


            Dictionary<string, CefTypeTxPlan> allTxPlans = new Dictionary<string, CefTypeTxPlan>();
            List<CefHandlerTxPlan> handlerPlans = new List<CefHandlerTxPlan>();
            List<CefCallbackTxPlan> callbackPlans = new List<CefCallbackTxPlan>();
            List<CefInstanceElementTxPlan> instanceClassPlans = new List<CefInstanceElementTxPlan>();
            List<CefEnumTxPlan> enumTxPlans = new List<CefEnumTxPlan>();


            int typeName = 1;

            List<TypeTxInfo> typeTxInfoList = new List<TypeTxInfo>();

            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._v_instanceClasses)
            {
                //eg. CefApp, CefBrowser, CefCommandLine, CefFrame
                CefInstanceElementTxPlan instanceClassPlan = new CefInstanceElementTxPlan(typedecl);
                instanceClassPlans.Add(instanceClassPlan);
                allTxPlans.Add(typedecl.Name, instanceClassPlan);
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                instanceClassPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypeTxInfo = typeTxPlan;
                typeTxInfoList.Add(typeTxPlan);

            }


            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._v_handlerClasses)
            {
                //eg. CefDisplayHandler, CefDownloadHandler
                CefHandlerTxPlan handlerPlan = new CefHandlerTxPlan(typedecl);
                handlerPlans.Add(handlerPlan);
                allTxPlans.Add(typedecl.Name, handlerPlan);
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                handlerPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypeTxInfo = typeTxPlan;
                typeTxInfoList.Add(typeTxPlan);
            }
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._v_callBackClasses)
            {
                //eg. CefAuthenCallback, CefPdfCallback
                CefCallbackTxPlan callbackPlan = new CefCallbackTxPlan(typedecl);
                callbackPlans.Add(callbackPlan);
                allTxPlans.Add(typedecl.Name, callbackPlan);
                ////
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                callbackPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypeTxInfo = typeTxPlan;
                typeTxInfoList.Add(typeTxPlan);
            }
            //
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection._enumClasses)
            {
                CefEnumTxPlan enumTxPlan = new CefEnumTxPlan(typedecl);
                enumTxPlans.Add(enumTxPlan);
                allTxPlans.Add(typedecl.Name, enumTxPlan);
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                enumTxPlan.CsInterOpTypeNameId = typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypeTxInfo = typeTxPlan;

            }

            List<CodeTypeDeclaration> notFoundAbstractClasses = new List<CodeTypeDeclaration>();

            foreach (CodeTypeDeclaration typedecl in cefTypeCollection.cToCppClasses)
            {
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypeTxInfo = typeTxPlan;

                //cef -specific
                TemplateTypeSymbol3 baseType0 = (TemplateTypeSymbol3)typedecl.BaseTypes[0].ResolvedType;
                //add information to our model
                SimpleTypeSymbol abstractType = (SimpleTypeSymbol)baseType0.Item1;
                SimpleTypeSymbol underlying_c_type = (SimpleTypeSymbol)baseType0.Item2;

                CefTypeTxPlan found;
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
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                typeTxPlan.CsInterOpTypeNameId = typeName++;
                typedecl.TypeTxInfo = typeTxPlan;
                //cef -specific
                TemplateTypeSymbol3 baseType0 = (TemplateTypeSymbol3)typedecl.BaseTypes[0].ResolvedType;
                SimpleTypeSymbol abstractType = (SimpleTypeSymbol)baseType0.Item1;
                SimpleTypeSymbol underlying_c_type = (SimpleTypeSymbol)baseType0.Item2;
                CefTypeTxPlan found;
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
            //code gen

            List<CefTypeTxPlan> customImplClasses = new List<CefTypeTxPlan>();

            int tt_count = 0;
            StringBuilder cppCodeStBuilder = new StringBuilder();
            StringBuilder csCodeStBuilder = new StringBuilder();
            AddCppBuiltInBeginCode(cppCodeStBuilder);

            CodeStringBuilder cppHeaderExportFuncAuto = new CodeStringBuilder();
            CodeStringBuilder cppHeaderInternalForExportFunc = new CodeStringBuilder();

            cppHeaderExportFuncAuto.AppendLine("//AUTOGEN");
            cppHeaderInternalForExportFunc.AppendLine("//AUTOGEN");


            foreach (TypeTxInfo txinfo in typeTxInfoList)
            {
                cppHeaderInternalForExportFunc.AppendLine("const int CefTypeName_" + txinfo.TypeDecl.Name + " = " + txinfo.CsInterOpTypeNameId.ToString() + ";");
            }


            csCodeStBuilder.AppendLine(
                "//MIT, 2017, WinterDev\r\n" +
                "//AUTOGEN CONTENT\r\n" +
                "using System;\r\n" +
                "using System.Collections.Generic;\r\n" +
                "using System.Runtime.InteropServices;\r\n" +
                "namespace LayoutFarm.CefBridge.Auto{\r\n");


            CefCodeGenOutput codeGenOutput = new CefCodeGenOutput();
            foreach (CefTypeTxPlan tx in enumTxPlans)
            {
                tx.GenerateCode(codeGenOutput);
                //get cs output
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
            }
            //-------------------------

            foreach (CefInstanceElementTxPlan tx in instanceClassPlans)
            {
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

                if (tx.CppImplClassNameId > 0)
                {
                    customImplClasses.Add(tx);
                }
                tt_count++;
            }


            foreach (CefCallbackTxPlan tx in callbackPlans)
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


            foreach (CefHandlerTxPlan tx in handlerPlans)
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


            //---------
            CodeStringBuilder cef_NativeReqHandlers_Class = new CodeStringBuilder();
            cef_NativeReqHandlers_Class.AppendLine("//------ common cef handler swicth table---------");
            cef_NativeReqHandlers_Class.AppendLine("public static class CefNativeRequestHandlers{");
            cef_NativeReqHandlers_Class.AppendLine("public static void HandleNativeReq(object inst, int met_id,IntPtr args){");
            cef_NativeReqHandlers_Class.AppendLine("switch((met_id>>16)){");
            foreach (CefHandlerTxPlan tx in handlerPlans)
            {
                cef_NativeReqHandlers_Class.AppendLine("case " + tx.OriginalDecl.Name + "._typeNAME:{");
                cef_NativeReqHandlers_Class.AppendLine(tx.OriginalDecl.Name + ".HandleNativeReq(inst as " + tx.OriginalDecl.Name + ".I0," +
                        " inst as " + tx.OriginalDecl.Name + ".I1,met_id,args);");
                cef_NativeReqHandlers_Class.AppendLine("}break;");
            }
            //--------
            //create handle common switch table
            cef_NativeReqHandlers_Class.AppendLine("}");//switch
            cef_NativeReqHandlers_Class.AppendLine("}");//HandleNativeReq()
            cef_NativeReqHandlers_Class.AppendLine("}");

            //add to cs code
            csCodeStBuilder.Append(cef_NativeReqHandlers_Class.ToString());
            //cs...
            csCodeStBuilder.AppendLine("}"); //end cs
            //--------
            //cpp
            CreateCppSwitchTable(cppCodeStBuilder, instanceClassPlans);
            CreateNewInstanceMethod(cppCodeStBuilder, customImplClasses);
            AddCppBuiltInEndCode(cppCodeStBuilder);
            // 
        }
        void CreateNewInstanceMethod(StringBuilder outputStBuilder, List<CefTypeTxPlan> customImplClasses)
        {
            CodeStringBuilder stbuilder = new CodeStringBuilder();
            //void* NewInstance(int typeName, managed_callback mcallback, jsvalue* jsvalue);
            stbuilder.AppendLine("void* NewInstance(int typeName, managed_callback mcallback, jsvalue* jsvalue){");
            stbuilder.AppendLine("switch(typeName){");
            int j = customImplClasses.Count;
            for (int i = 0; i < j; ++i)
            {
                CefTypeTxPlan tx = customImplClasses[i];
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
        void AddCppBuiltInEndCode(StringBuilder cppStBuilder)
        {
            cppStBuilder.AppendLine("/////////////////////////////////////////////////");
        }
        void CreateCppSwitchTable(StringBuilder stbuilder, List<CefInstanceElementTxPlan> instanceClassPlans)
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
                CefInstanceElementTxPlan instanceClassPlan = instanceClassPlans[i];
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

        CodeCompilationUnit ParseWrapper(string srcFile)
        {
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h";
            //
            Cef3HeaderFileParser headerParser = new Cef3HeaderFileParser();
            headerParser.Parse(srcFile);
            return headerParser.Result;
        }
        CodeCompilationUnit ParseWrapper(string srcFile, IEnumerable<string> lines)
        {
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h";
            //
            Cef3HeaderFileParser headerParser = new Cef3HeaderFileParser();
            headerParser.Parse(srcFile, lines);
            return headerParser.Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string snapFolder = @"D:\projects\Kneadium\NativePatcher\dev_snap_win32";
            CopyFolder(cefSrcRootDir + "\\libcef_dll", snapFolder);
            CopyFolder(cefSrcRootDir + "\\tests", snapFolder);
            CopyFolder(cefSrcRootDir + "\\include", snapFolder);
            //----------  
        }
    }
}
