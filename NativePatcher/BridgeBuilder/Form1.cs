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

        private void cmdBuild1_Click(object sender, EventArgs e)
        {

            //string srcRootDir = @"D:\projects\cef_binary_3.2526.1366" + "\\cefclient"; //2526.1366
            //ManualPatcher manualPatcher = new ManualPatcher(srcRootDir);
            //manualPatcher.DoChanged();
            //manualPatcher.CopyExtensionSources();
        }

        private void cmdMakePatchFiles_Click(object sender, EventArgs e)
        {
            //string srcRootDir = @"D:\projects\cef_binary_3.2526.1366" + "\\cefclient"; //2526.1366
            //string srcRootDir = "d:\\projects\\CefBridge\\cef3\\cefclient";
            string srcRootDir = "d:\\projects\\CefBridge\\cef3\\cefclient";
            PatchBuilder builder = new PatchBuilder(srcRootDir);
            builder.MakePatch();


            string saveFolder = "d:\\WImageTest\\cefbridge_patches";
            builder.Save(saveFolder);

            //assign root foler
            PatchBuilder builder2 = new PatchBuilder(srcRootDir);
            builder2.LoadPatchesFromFolder(saveFolder);


        }

        private void cmdLoadPatchAndDoPatch_Click(object sender, EventArgs e)
        {
            //string srcRootDir = @"D:\projects\cef_binary_3.2526.1366" + "\\cefclient"; //2526.1366
            //string srcRootDir = @"D:\projects\cef_binary_3.2623.1395" + "\\cefclient"; //2526.1366
            string srcRootDir = @"D:\projects\cef_binary_3.2623.1399" + "\\cefclient"; //2526.1366
            string saveFolder = "d:\\WImageTest\\cefbridge_patches";

            PatchBuilder builder2 = new PatchBuilder(srcRootDir);
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
                string replaceName = onlyPath.Replace("d:\\projects\\CefBridge\\cef3\\cefclient", newPathName);


                pfile.OriginalFileName = replaceName + "//" + onlyFileName;

                pfile.PatchContent();
            }


            ManualPatcher manualPatcher = new ManualPatcher(newPathName);
            manualPatcher.CopyExtensionSources();
            manualPatcher.Do_CMake_txt();

        }
    }
}
