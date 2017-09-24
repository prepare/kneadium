//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic; 
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
        CodeCompilationUnit Parse(string srcFile)
        {
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h";
            //
            Cef3FileParser headerParser = new Cef3FileParser();
            headerParser.Parse(srcFile);
            return headerParser.Result;
        }
        CodeCompilationUnit Parse(string srcFile, IEnumerable<string> lines)
        {
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h";
            //
            Cef3FileParser headerParser = new Cef3FileParser();
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

            CodeCompilationUnit cu = Parse(filename, selectedLines);

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
                    cppToCsImplCodeGen.PatchCppMethod(cu, cefDir + @"\libcef_dll\cpptoc\" + onlyFileName, cefDir + @"\cpptoc");
                    //cppToCsImplCodeGen.PatchCppMethod(cu, null, cefDir + @"\cpptoc");
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

            int tt_count = 0;
            StringBuilder cppCodeStBuilder = new StringBuilder();
            StringBuilder csCodeStBuilder = new StringBuilder();
            AddCppBuiltInBeginCode(cppCodeStBuilder);



            CodeStringBuilder cppHeaderInternalForExportFunc = new CodeStringBuilder();
            cppHeaderInternalForExportFunc.AppendLine(
                "//MIT, 2017, WinterDev\r\n" +
                "//AUTOGEN");


            foreach (TypePlan txinfo in typeTxInfoList)
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


            CefCodeGenOutput codeGenOutput = null;
            foreach (CefTypeTx tx in enumTxPlans)
            {
                codeGenOutput = new CefCodeGenOutput();
                tx.GenerateCode(codeGenOutput);
                //get cs output
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
            }
            //-------------------------
            CodeStringBuilder cppHeaderExportFuncAuto = new CodeStringBuilder();
            cppHeaderExportFuncAuto.AppendLine("//AUTOGEN");

            tt_count = 0;
            foreach (CefInstanceElementTx tx in instanceClassPlans)
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
                //--------------------------------------------

                cppHeaderExportFuncAuto.Append(codeGenOutput._cppHeaderExportFuncAuto.ToString());
                cppHeaderInternalForExportFunc.Append(codeGenOutput._cppHeaderInternalForExportFuncAuto.ToString());
                //----------
                if (tx.CppImplClassNameId > 0)
                {
                    customImplClasses.Add(tx);
                }
                tt_count++;
            }

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


            foreach (CefCStructTx tx in cstructPlans)
            {
                codeGenOutput = new CefCodeGenOutput();
                tx.GenerateCode(codeGenOutput);
                csCodeStBuilder.Append(codeGenOutput._csCode.ToString());
            }


            CsNativeHandlerSwitchTableCodeGen csNativeHandlerSwitchTableCodeGen = new CsNativeHandlerSwitchTableCodeGen();
            csNativeHandlerSwitchTableCodeGen.GenerateCefNativeRequestHandlers(handlerPlans, csCodeStBuilder);

            //cs...
            csCodeStBuilder.AppendLine("}"); //end cs
            //--------
            //cpp
            CppSwicthTableCodeGen cppSwitchTableCodeGen = new CppSwicthTableCodeGen();
            cppSwitchTableCodeGen.CreateCppSwitchTableForInstanceMethod(cppCodeStBuilder, instanceClassPlans);
            cppSwitchTableCodeGen.CreateCppSwitchTableForStaticMethod(cppCodeStBuilder, instanceClassPlans);
            //
            CppInstanceMethodCodeGen instanceMetCodeGen = new CppInstanceMethodCodeGen();
            instanceMetCodeGen.CreateCppNewInstanceMethod(cppCodeStBuilder, customImplClasses);
            //--------
            cppCodeStBuilder.AppendLine("/////////////////////////////////////////////////");
            // 
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



    
    }
}
