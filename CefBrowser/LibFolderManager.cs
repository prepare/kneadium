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

             
            ReferencePaths.LIB_PATH = is64BitsApp ?
                @"D:\projects\cef_binary_3.3071.1647.win64build\tests\cefclient\Debug":
                @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Debug";
#else
            ReferencePaths.LIB_PATH = @"D:\projects\cef_binary_3.3071.1647.win64build\tests\cefclient\Release";
                 ReferencePaths.LIB_PATH = is64BitsApp ?
                @"D:\projects\cef_binary_3.3071.1647.win64build\tests\cefclient\Release":
                @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Release";
#endif
            //ReferencePaths.LIB_PATH = @"D:\projects\kneadium\bin\Release"; //test
            ReferencePaths.SUB_PROCESS_PATH = "CefBwSp.exe";
            //ReferencePaths.SUB_PROCESS_PATH = @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Release\CefBwSp.exe";
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