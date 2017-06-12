//MIT, 2017, brezza92, EngineKit

namespace LayoutFarm.CefBridge
{
    public static class ReferencePaths
    {
        //public static string LIB_PATH = @"D:\projects\cef_binary_3.3071.1634output\tests\cefclient\Release";
        //public static string LIB_PATH = @"../../../../cef_3_3701/Release";
        public static string LIB_PATH = @"D:\projects/cef_3_3701/Release";
        //*** use / for escape sub-process char
        //public static string SUB_PROCESS_PATH = @"D:\projects/CefBridge/CefBrowser/bin/Release/CefBrowserX.exe";
        //public static string SUB_PROCESS_PATH = @"../../../../cef_3_3701/Release/CefBrowserX.exe";
        public static string SUB_PROCESS_PATH = @"D:\projects/cef_3_3701/Release/CefBrowserX.exe";

        public static string OUTPUT_DIR = @"../../../_output";//dir
        public static string LOG_PATH = OUTPUT_DIR + "/cef_console.log"; //file
        public static string CACHE_PATH = OUTPUT_DIR + "/cef_cache"; //dir
        public static string SAVE_IMAGE_PATH = OUTPUT_DIR + "/snap02"; //dir
    }
}