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
#if DEBUG
            ReferencePaths.LIB_PATH = @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Debug";
#else
            ReferencePaths.LIB_PATH = @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Release";
#endif
            //ReferencePaths.LIB_PATH = @"D:\projects\kneadium\bin\Release"; //test
            ReferencePaths.SUB_PROCESS_PATH = "CefBwSp.exe";
            ReferencePaths.OUTPUT_DIR = @"_output";//dir
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