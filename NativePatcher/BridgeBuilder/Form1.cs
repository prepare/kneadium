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
        string _cefSrcRootDir = null;


        PatcherPreset _selectedPreSet = null;
        List<PatcherPreset> _patcherPresets = new List<PatcherPreset>();

        public Form1()
        {
            InitializeComponent();

            //absolute path to this bridge builder app(eg.d:\\projects\\kneadium)
            string bridgeBuilderRootFolder = @"d:\projects\kneadium";
            string bridgeBuilderFolder = bridgeBuilderRootFolder + @"\NativePacther\BridgeBuilder";

            _patcherPresets.AddRange(
                new PatcherPreset[]
                {
                    new PatcherPreset(){
                        EnvName = EnvName.Win32,
                        CefSrcFolder = @"D:\projects\cef_binary_3.3071.1647.win32",
                        NewlyCreatedPatchSaveToFolder = "d:\\WImageTest\\cefbridge_patches",
                        PatchFolder = "d:\\WImageTest\\cefbridge_patches",
                        Backup_NativePatcherFolder= bridgeBuilderRootFolder + @"\NativePatcher",
                        ProjectNativePatcher_BridgeFolder = bridgeBuilderFolder,
                    },
                    new PatcherPreset(){
                        EnvName = EnvName.Win64,
                        CefSrcFolder = @"D:\projects\cef_binary_3.3071.1647.win64",
                        NewlyCreatedPatchSaveToFolder = "d:\\WImageTest\\cefbridge_patches",
                        PatchFolder = "d:\\WImageTest\\cefbridge_patches",
                        Backup_NativePatcherFolder= bridgeBuilderRootFolder + @"\NativePatcher",
                        ProjectNativePatcher_BridgeFolder = bridgeBuilderFolder,
                    },
                });
            //
            SetCurrentPreset(_patcherPresets[0]);//default             
        }
        void SetCurrentPreset(PatcherPreset preset)
        {
            _selectedPreSet = preset;
            _cefSrcRootDir = preset.CefSrcFolder;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCefSrcFolder.Items.AddRange(_patcherPresets.ToArray());
            cmbCefSrcFolder.SelectedIndex = 0; //set default

            //
            cmbCefSrcFolder.SelectedIndexChanged += (s1, e1) =>
            {
                SetCurrentPreset((PatcherPreset)cmbCefSrcFolder.SelectedItem);

            };
        }
        private void cmdShowCefSourceFolder_Click(object sender, EventArgs e)
        {
            //open cefSrcRootDir in Windows Explorer
            System.Threading.ThreadPool.QueueUserWorkItem(s =>
            {
                System.Diagnostics.Process.Start("explorer.exe", _cefSrcRootDir);
            });
        }
        private void cmdCefBridgeCodeGen_Click(object sender, EventArgs e)
        {
            //cpp-to-c wrapper and c-to-cpp wrapper
            //read original cef src, apply pacth and generate cpp/cs bridge code 
            CefBridgeCodeGen cefBrideCodeGen = new CefBridgeCodeGen();
            cefBrideCodeGen.GenerateBridge(_cefSrcRootDir);
        }

        private void cmdCreatePatchFiles_Click(object sender, EventArgs e)
        {

            //1. analyze modified source files, in source folder  
            PatchBuilder builder = new PatchBuilder(new string[]{
                _cefSrcRootDir + @"\tests\cefclient",
                _cefSrcRootDir + @"\tests\shared"
            });
            builder.MakePatch();

            //2. save patch to...
            string newPatchFolder = _selectedPreSet.NewlyCreatedPatchSaveToFolder;
            builder.Save(newPatchFolder);

            ////----------------------------------
            //3.1 copy newly generate patch to backup folder 
            //this code will push to github ***
            //----------------------------------
            string backup_nativePatcher = _selectedPreSet.Backup_NativePatcherFolder;
            string backup_NativePatcher_BridgeBuilder_folder = _selectedPreSet.ProjectNativePatcher_BridgeFolder;

            FolderUtils.CopyFileInFolder(newPatchFolder, backup_nativePatcher);

            //3.2 copy newly generate patch to backup folder 
            //this code will push to github (same) 
            FolderUtils.CopyFileInFolder(
                _cefSrcRootDir + @"\tests\cefclient\myext",
                 backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode\myext");
            //3.3 copy newly generate patch to backup folder 
            //this code will push to github  (same) 
            FolderUtils.CopyFileInFolder(
                _cefSrcRootDir + @"\libcef_dll\myext",
                backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_libcef_dll\myext");
            //---------- 
            //3.4 copy file by file
            //this code will push to github  (same) 
            FolderUtils.CopyFile(_cefSrcRootDir + "\\include\\cef_base.h",
               backup_NativePatcher_BridgeBuilder_folder + @"\BridgeBuilder\Patcher_ExtCode_Others");
            //3.5 //this code will push to github  (same) 
            FolderUtils.CopyFile(_cefSrcRootDir + "\\libcef_dll\\ctocpp\\ctocpp_ref_counted.h",
               backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_Others");
            //3.6 //this code will push to github  (same) 
            FolderUtils.CopyFile(_cefSrcRootDir + "\\libcef_dll\\cpptoc\\cpptoc_ref_counted.h",
               backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_Others");
            //
        }
        private void cmdCopyDevSnap_Click(object sender, EventArgs e)
        {
            string backup_nativePatcher = _selectedPreSet.Backup_NativePatcherFolder;

            string snapBackupFolder = backup_nativePatcher + @"\dev_snap_win32";

            //check if we have snap folder,
            //if not => create it
            FolderUtils.CopyFolder(_cefSrcRootDir + "\\libcef_dll", snapBackupFolder);
            FolderUtils.CopyFolder(_cefSrcRootDir + "\\tests", snapBackupFolder);
            FolderUtils.CopyFolder(_cefSrcRootDir + "\\include", snapBackupFolder);
            //----------  
        }


        private void cmdLoadPatchAndApplyPatch_Click(object sender, EventArgs e)
        {
            string backup_nativePatcher = _selectedPreSet.Backup_NativePatcherFolder;
            string backup_NativePatcher_BridgeBuilder_folder = _selectedPreSet.ProjectNativePatcher_BridgeFolder;
            string srcRootDir0 = _cefSrcRootDir;

            //where is patch folder
            string cefBridge_PatchFolder = _selectedPreSet.PatchFolder;
            string org_cefclient_test_folder = srcRootDir0 + "\\tests";

            //copy my extension file relative folder to this project
            FolderUtils.CopyFolder(backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode\myext", org_cefclient_test_folder + "\\cefclient");
            //copy my extension file
            FolderUtils.CopyFolder(backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_libcef_dll\myext", srcRootDir0 + "\\libcef_dll");
            //-----------
            ManualPatcher manualPatcher = new ManualPatcher(org_cefclient_test_folder);

            //1.
            System.IO.File.Copy(backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_Others\cef_base.h",
                 srcRootDir0 + "\\include\\cef_base.h", true);
            //2.
            System.IO.File.Copy(backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_Others\cpptoc_ref_counted.h",
                srcRootDir0 + "\\libcef_dll\\cpptoc\\cpptoc_ref_counted.h", true);
            //3.
            System.IO.File.Copy(backup_NativePatcher_BridgeBuilder_folder + @"\Patcher_ExtCode_Others\ctocpp_ref_counted.h",
                srcRootDir0 + "\\libcef_dll\\ctocpp\\ctocpp_ref_counted.h", true);
            //-----------

            manualPatcher.Do_LibCefDll_CMake_txt(srcRootDir0 + "\\libcef_dll\\CMakeLists.txt");
            manualPatcher.Do_CefClient_CMake_txt();
            //-----------
            PatchBuilder builder2 = new PatchBuilder(new string[]{
                org_cefclient_test_folder,
            });
            builder2.LoadPatchesFromFolder(cefBridge_PatchFolder);

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
                string replaceName = org_cefclient_test_folder + rightSide;
                pfile.OriginalFileName = replaceName + "//" + onlyFileName;
                pfile.PatchContent();
            }
        }









        //------------------------------------------------------------------------------------------------------
        //EXPERIMENT!
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
            FolderUtils.CopyFileInFolder(saveFolder,
                @"D:\projects\Kneadium\NativePatcher\cefbridge_patches_mac"
               );
            //copy ext from actual src 
            FolderUtils.CopyFileInFolder(srcRootDir + "\\myext",
                 @"D:\projects\Kneadium\NativePatcher\BridgeBuilder\Patcher_ExtCode_mac\myext");
        }
        //EXPERIMENT!
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
