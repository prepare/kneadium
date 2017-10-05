//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BridgeBuilder
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// original cef src folder
        /// </summary>
        string cefSrcRootDir = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCefSrcFolder.Items.AddRange(
                new string[]
                {
                    @"D:\projects\cef_binary_3.3071.1647.win32",
                    @"D:\projects\cef_binary_3.3071.1647.win64"
                });

            cmbCefSrcFolder.SelectedIndex = 0; //set default
            cefSrcRootDir = cmbCefSrcFolder.SelectedItem as string;//default
            //
            cmbCefSrcFolder.SelectedIndexChanged += (s1, e1) =>
            {
                cefSrcRootDir = cmbCefSrcFolder.SelectedItem as string;
            };
        } 

        private void cmdCefBridgeCodeGen_Click(object sender, EventArgs e)
        {   
            //cpp-to-c wrapper and c-to-cpp wrapper
            //read original cef src, apply pacth and generate cpp/cs bridge code 
            CefBridgeCodeGen cefBrideCodeGen = new CefBridgeCodeGen();
            cefBrideCodeGen.GenerateBridge(cefSrcRootDir);
        }

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

            string srcRootDir0 = cefSrcRootDir;
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

            //EXPERIMENT!
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

            //EXPERIMENT!
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




    }
}
