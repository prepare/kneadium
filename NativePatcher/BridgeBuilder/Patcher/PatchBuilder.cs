//2016, MIT, WinterDev

using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace BridgeBuilder
{

    class PatchBuilder
    {

        List<string> filenames = new List<string>();
        List<PatchFile> pfiles = new List<PatchFile>();
        //extension to be patch
        string[] fileExts = new string[] { ".cpp", ".h", ".cc",".mm" };
        string[] srcFolders;
        public PatchBuilder(string[] srcFolders)
        {
            this.srcFolders = srcFolders;
        }
      
        public void MakePatch()
        {
            //from root dir
            //just find line with specific values
            pfiles.Clear();
            filenames.Clear();
            foreach (string srcFolder in this.srcFolders)
            {
                CollectFilesRecursive(srcFolder);
            }            
            //--------------------------------------
            for (int i = filenames.Count - 1; i >= 0; --i)
            {
                PatchFile pfile = PatchFile.BuildPatchFile(filenames[i]);
                if (pfile != null)
                {
                    pfiles.Add(pfile);
                }
            }

        }
        /// <summary>
        /// save all patches into a specific folder
        /// </summary>
        /// <param name="folder"></param>
        public void Save(string folder)
        {
            for (int i = pfiles.Count - 1; i >= 0; --i)
            {
                PatchFile pfile = pfiles[i];
                //save patch file into a folder
                string filename = folder + "\\" + Path.GetFileName(pfile.OriginalFileName) + ".patch";
                pfile.SavePatchFile(filename);
            }
        }
        public void LoadPatchesFromFolder(string folder)
        {
            pfiles.Clear();
            this.filenames.Clear();
            string[] filenames = Directory.GetFiles(folder);
            for (int i = filenames.Length - 1; i >= 0; --i)
            {
                PatchFile pfile = PatchFile.BuildPatchFile(filenames[i]);
                if (pfile != null)
                {
                    pfiles.Add(pfile);
                }
            }

        }
        void CollectFilesRecursive(string dir)
        {
            //recursive
            string[] allfiles = Directory.GetFiles(dir);
            for (int i = allfiles.Length - 1; i >= 0; --i)
            {
                if (IsPatchableFile(allfiles[i]))
                {
                    filenames.Add(allfiles[i]);
                }
            }

            string[] allSubDirs = Directory.GetDirectories(dir);
            for (int i = allSubDirs.Length - 1; i >= 0; --i)
            {
                CollectFilesRecursive(allSubDirs[i]);
            }

        }
        bool IsPatchableFile(string filename)
        {
            string ext = Path.GetExtension(filename).ToLower();
            for (int i = fileExts.Length - 1; i >= 0; --i)
            {
                if (ext == fileExts[i])
                {
                    return true;
                }
            }
            return false;
        }


        public List<PatchFile> GetAllPatchFiles()
        {
            return pfiles;
        }
    }
}