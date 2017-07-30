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


        private void cmdCreatePatchFiles_Click(object sender, EventArgs e)
        {
            //string srcRootDir = @"D:\projects\cef_binary_3.2526.1366" + "\\cefclient"; //2526.1366
            //string srcRootDir = "d:\\projects\\CefBridge\\cef3\\cefclient";
            //string srcRootDir = "d:\\projects\\CefBridge\\cef3\\cefclient";

            //1. analyze modified source files, in source folder
            //string srcRootDir = @"D:\projects\cef_binary_3.2883.1548\tests\cefclient";
            //string srcRootDir = @"D:\projects\cef_binary_3.2883.1553\tests\cefclient";
            //string srcRootDir = @"D:\projects\cef_binary_3.3071.1634\tests\cefclient";
            string srcRootDir = @"D:\projects\cef_binary_3.3071.1647.win32\tests\cefclient";

            PatchBuilder builder = new PatchBuilder(new string[]{
                srcRootDir,
                @"D:\projects\cef_binary_3.3071.1647.win32\tests\shared"
            });
            builder.MakePatch();

            //2. save patch to...
            string saveFolder = "d:\\WImageTest\\cefbridge_patches";
            builder.Save(saveFolder);

            ////3. test load those patches
            //PatchBuilder builder2 = new PatchBuilder(srcRootDir);
            //builder2.LoadPatchesFromFolder(saveFolder);

            //----------
            //copy extension code          
            CopyFileInFolder(saveFolder,
                @"D:\projects\CefBridge\NativePatcher\cefbridge_patches"
               );
            //copy ext from actual src 
            CopyFileInFolder(srcRootDir + "\\myext",
                 @"D:\projects\CefBridge\NativePatcher\BridgeBuilder\Patcher_ExtCode\myext");

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
            //string srcRootDir = @"D:\projects\cef_binary_3.2526.1366" + "\\cefclient"; //2526.1366
            //string srcRootDir = @"D:\projects\cef_binary_3.2623.1395" + "\\cefclient"; //2526.1366
            //string srcRootDir = @"D:\projects\cef_binary_3.2623.1399" + "\\cefclient"; //2526.1366
            //string srcRootDir = @"D:\projects\cef_binary_3.2704.1418"; 
            //string srcRootDir = @"D:\projects\cef_binary_3.2785.1466";  
            //string srcRootDir = @"D:\projects\cef_binary_3.2883.1548\\tests"; 
            //string srcRootDir = @"D:\projects\cef_binary_3.2883.1553\\tests";
            //string srcRootDir = @"D:\projects\cef_binary_3.3029.1619\tests";
            //string srcRootDir = @"D:\projects\cef_binary_3.3071.1634\tests";
            //
            //cef_binary_3.3071.1647
            //string srcRootDir = @"D:\projects\cef_binary_3.3071.1647.win32\tests";
            string srcRootDir = @"D:\projects\cef_binary_3.3071.1647.win32\tests";
            string saveFolder = "d:\\WImageTest\\cefbridge_patches";

            PatchBuilder builder2 = new PatchBuilder(new string[]{
                srcRootDir,
                //@"D:\projects\cef_binary_3.2883.1553\\shared"
                //@"D:\projects\cef_binary_3.3029.1619\shared"
                //@"D:\projects\cef_binary_3.3071.1647.win32\shared"
               // @"D:\projects\cef_binary_3.3071.1647.win64\tests\shared"
            });
            builder2.LoadPatchesFromFolder(saveFolder);

            List<PatchFile> pfiles = builder2.GetAllPatchFiles();
            //string oldPathName = srcRootDir;

            string newPathName = srcRootDir;// "d:\\projects\\CefBridge\\cef3\\cefclient";

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


            ManualPatcher manualPatcher = new ManualPatcher(newPathName);

            string extTargetDir = newPathName + "\\cefclient\\myext";
            manualPatcher.CopyExtensionSources(extTargetDir);
            manualPatcher.Do_CMake_txt();

            //bool is3_2704 = true;
            //if (is3_2704)
            //{
            //    string extTargetDir = newPathName + "\\cefclient\\myext";
            //    manualPatcher.CopyExtensionSources(extTargetDir);
            //    manualPatcher.Do_CMake_txt_New_3_2704_up();
            //}
            //else
            //{
            //    string extTargetDir = newPathName + "\\myext";
            //    manualPatcher.CopyExtensionSources(extTargetDir);
            //    manualPatcher.Do_CMake_txt_old(); ;
            //}

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
                @"D:\projects\CefBridge\NativePatcher\cefbridge_patches_mac"
               );
            //copy ext from actual src 
            CopyFileInFolder(srcRootDir + "\\myext",
                 @"D:\projects\CefBridge\NativePatcher\BridgeBuilder\Patcher_ExtCode_mac\myext");
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


            ManualPatcher manualPatcher = new ManualPatcher(newPathName);
            string extTargetDir = newPathName + "\\cefclient\\myext";
            manualPatcher.CopyExtensionSources(extTargetDir);
            manualPatcher.Do_CMake_txt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\include\cef_browser.h";
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\include\cef_request_handler.h";
            string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\include\internal\cef_time.h";
            //
            Cef3HeaderFileParser headerParser = new Cef3HeaderFileParser();
            headerParser.Parse(srcFile);
            CodeCompilationUnit cu = headerParser.Result;

            //
            List<CodeCompilationUnit> culist = new List<CodeCompilationUnit>();
            culist.Add(cu);
            CefTypeCollection cefTypeCollection = new CefTypeCollection();
            cefTypeCollection.RootFolder = @"D:\projects\cef_binary_3.3071.1647.win32";

            cefTypeCollection.SetTypeSystem(culist);
            //-----------

            TypeTranformPlanner txPlanner = new TypeTranformPlanner();
            txPlanner.CefTypeCollection = cefTypeCollection;

            ApiBuilderCsPart apiBuilderCs = new ApiBuilderCsPart();
            ApiBuilderCppPart apiBuilderCpp = new ApiBuilderCppPart();

            CodeTypeDeclaration globalType = cu.GlobalTypeDecl;
            if (globalType.MemberCount > 0)
            {
                //TODO: review global type
            }
            //
            int j = cu.TypeCount;
            for (int i = 0; i < j; ++i)
            {
                CodeTypeDeclaration typedecl = cu.GetTypeDeclaration(i);
                if (typedecl.Name == null)
                {
                    continue;
                }
                if (typedecl.Name.Contains("Callback"))
                {
                    continue;
                }

                StringBuilder stbuilder = new StringBuilder();
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                apiBuilderCs.GenerateCsType(typeTxPlan, stbuilder);
                //
                StringBuilder cppPart = new StringBuilder();
                apiBuilderCpp.GenerateCppPart(typeTxPlan, cppPart);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //cpp-to-c wrapper and c-to-cpp wrapper
            //ParseWrapper(@"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h");

            string cefDir = @"D:\projects\cef_binary_3.3071.1647.win32";
            List<CodeCompilationUnit> totalCuList = new List<CodeCompilationUnit>();
            {

                //include/internal
                totalCuList.Add(ParseWrapper(cefDir + @"\include\internal\cef_types.h"));
                totalCuList.Add(ParseWrapper(cefDir + @"\include\internal\cef_types_wrappers.h"));
                totalCuList.Add(ParseWrapper(cefDir + @"\include\internal\cef_win.h")); //for windows

            }
            {
                //include folder
                string[] onlyHeaderFiles = System.IO.Directory.GetFiles(cefDir + @"\include\", "*.h");
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new[] {
                "cef_base.h"});

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
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new[] {
                "ctocpp_ref_counted.h" ,"ctocpp_scoped.h"});

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
                Dictionary<string, bool> skipFiles = CreateSkipFiles(new[] {
                "cpptoc_ref_counted.h","cpptoc_scoped.h"});

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
            ApiBuilderCsPart apiBuilderCsPart = new ApiBuilderCsPart();
            ApiBuilderCppPart apiBuilderCppPart = new ApiBuilderCppPart();

            //
            CefTypeCollection cefTypeCollection = new CefTypeCollection();
            cefTypeCollection.RootFolder = cefDir;
            cefTypeCollection.SetTypeSystem(totalCuList);

            //
            TypeTranformPlanner txPlanner = new TypeTranformPlanner();
            txPlanner.CefTypeCollection = cefTypeCollection;


            foreach (CodeTypeDeclaration typedecl in cefTypeCollection.otherClasses)
            {
                if (typedecl.IsGlobalCompilationUnitType) { continue; }
                if (typedecl.BaseIsVirtual) { continue; }
                if (typedecl.IsTemplateTypeDefinition) { continue; }
                if (typedecl.Name.EndsWith("Traits")) { continue; }


                if (typedecl.Kind != TypeKind.Enum)
                {

                }
                
                //
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                //
                {
                    StringBuilder stbuilder = new StringBuilder();
                    apiBuilderCsPart.GenerateCsType(typeTxPlan, stbuilder);
                }
                //
                //
                {
                    StringBuilder stbuilder = new StringBuilder();
                    apiBuilderCppPart.GenerateCppPart(typeTxPlan, stbuilder);
                }
                //
            }
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection.cToCppClasses)
            {
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                //
                {
                    StringBuilder stbuilder = new StringBuilder();
                    apiBuilderCsPart.GenerateCsType(typeTxPlan, stbuilder);
                }
                //
                //
                {
                    StringBuilder stbuilder = new StringBuilder();
                    apiBuilderCppPart.GenerateCppPart(typeTxPlan, stbuilder);
                }
                //
            }
            foreach (CodeTypeDeclaration typedecl in cefTypeCollection.cppToCClasses)
            {
                //eg. handlers and callbacks 
                TypeTxInfo typeTxPlan = txPlanner.MakeTransformPlan(typedecl);
                //
                {
                    StringBuilder stbuilder = new StringBuilder();
                    apiBuilderCsPart.GenerateCsType(typeTxPlan, stbuilder);
                }
                //
                //
                {
                    StringBuilder stbuilder = new StringBuilder();
                    apiBuilderCppPart.GenerateCppPart(typeTxPlan, stbuilder);
                }
                //
            }
        }
        CodeCompilationUnit ParseWrapper(string srcFile)
        {
            //string srcFile = @"D:\projects\cef_binary_3.3071.1647.win32\libcef_dll\ctocpp\frame_ctocpp.h";
            //
            Cef3HeaderFileParser headerParser = new Cef3HeaderFileParser();
            headerParser.Parse(srcFile);
            return headerParser.Result;
        }
    }
}
