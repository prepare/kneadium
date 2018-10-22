//MIT, 2015-2017, WinterDev
using System;
namespace LayoutFarm.CefBridge
{
    static class LibFolderManager
    {
        public static void CheckNativeLibs()
        {
            //where are native lib/exe. 
            //set proper dir here
            //depend on what you want

            //------   
            bool is64BitsApp = System.Runtime.InteropServices.Marshal.SizeOf(typeof(IntPtr)) == 8; //this check if app is 32 or 64 bits
#if DEBUG
            //chromium 59
            //ReferencePaths.LIB_PATH = is64BitsApp ?
            //    @"D:\projects\cef_binary_3.3071.1647.win64build\tests\cefclient\Debug" :
            //    @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Debug";

            ////chromium 61
            //ReferencePaths.LIB_PATH = is64BitsApp ?
            //    @"D:\projects\cef_binary_3.3163.1671.win64build\tests\cefclient\Debug" :
            //    @"D:\projects\cef_binary_3.3163.1671.win32build\tests\cefclient\Debug";

            //chromium 63

            ReferencePaths.LIB_PATH = "./";//relative path, from current folder

#else
            //chromium 59
            //ReferencePaths.LIB_PATH = "./";//relative path, from current folder
            //ReferencePaths.LIB_PATH = is64BitsApp ?
            // @"D:\projects\cef_binary_3.3071.1647.win64build\tests\cefclient\Release":
            // @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Release";

            //chromium 61
            //ReferencePaths.LIB_PATH = "./";
            //chromium 63
            ReferencePaths.LIB_PATH = "./";
            //ReferencePaths.LIB_PATH = is64BitsApp ?
            //    @"D:\projects\cef_binary_3.3163.1671.win64build\tests\cefclient\Release" :
            //    @"D:\projects\cef_binary_3.3163.1671.win32build\tests\cefclient\Release";
#endif


            //ReferencePaths.LIB_PATH = "./";
            //-----
            //test using another exe with the same name
            //in sub-folder

            string currentExecPath = System.Windows.Forms.Application.ExecutablePath;
            string onlyDirName = System.IO.Path.GetDirectoryName(currentExecPath);
            string onlyExeName = System.IO.Path.GetFileName(currentExecPath);

            //-----
            string subProcFolder = onlyDirName + "//sub";
            if (!System.IO.Directory.Exists(subProcFolder))
            {
                System.IO.Directory.CreateDirectory(subProcFolder);
            }
            ReferencePaths.SUB_PROCESS_PATH = subProcFolder + "//" + onlyExeName;
            // 
            //ReferencePaths.SUB_PROCESS_PATH = onlyExeName;

            ReferencePaths.OUTPUT_DIR = subProcFolder + "//_output";//dir
            ReferencePaths.LOG_PATH = ReferencePaths.OUTPUT_DIR + "/cef_console.log"; //file
            ReferencePaths.CACHE_PATH = ReferencePaths.OUTPUT_DIR + "/cef_cache"; //dir
            ReferencePaths.SAVE_IMAGE_PATH = ReferencePaths.OUTPUT_DIR + "/snap02"; //dir

            if (!System.IO.Directory.Exists(ReferencePaths.OUTPUT_DIR))
            {
                System.IO.Directory.CreateDirectory(ReferencePaths.OUTPUT_DIR);
            }
        }
        
    }

}