//MIT, 2015-2017, WinterDev 

using System;

namespace LayoutFarm.CefBridge
{
    static class Program
    {
        static void CheckNativeLibs()
        {
            //where are native lib/exe. 
            //set proper dir here
            //depend on what you want
            //1. nearest local dir
            //2. common dir  
            //string currrentExecPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //string commonAppDir = System.IO.Path.GetDirectoryName(Application.CommonAppDataPath);//skip version
            //------  
            ReferencePaths.LIB_PATH = @"D:\projects/cef_3_3071.1647/win64";
            ReferencePaths.SUB_PROCESS_PATH = ReferencePaths.LIB_PATH + "/CefBwSp.exe";
            //---------------
            ReferencePaths.OUTPUT_DIR = @"../../../_output";//dir
            ReferencePaths.LOG_PATH = ReferencePaths.OUTPUT_DIR + "/cef_console.log"; //file
            ReferencePaths.CACHE_PATH = ReferencePaths.OUTPUT_DIR + "/cef_cache"; //dir
            ReferencePaths.SAVE_IMAGE_PATH = ReferencePaths.OUTPUT_DIR + "/snap02"; //dir
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            CheckNativeLibs();
            //---------------------
            //this is designed for cef subprocess(eg gpu process, render process)
            //so we not include System.Drawing and System.Windows.Form
            //---------------------
            ReferencePaths.SUB_PROCESS_PATH = null; //use this same process..

            //1. load cef before OLE init (eg init winform) ***
            //see more detail ...  MyCef3InitEssential
            if (!MyCef3InitEssential.LoadAndInitCef3(args))
            {
                return;
            }
            //------------------------------------------
            //1. if this is main UI process
            //the code go here, and we just start
            //winform app as usual
            //2. if this is other process
            //mean this process is finish and will terminate soon.
            //so we do noting, just exit!
            //(***please note that 
            //*** we call ShutDownCef3 only in main thread ***)

            if (!MyCef3InitEssential.IsInMainProcess)
            {
                MyCef3InitEssential.ClearRemainingCefMsg();
                return;
            }
            /////////////////////////////////////////////
            MyCef3InitEssential.ClearRemainingCefMsg();
            MyCef3InitEssential.ShutDownCef3();
            //(***please note that 
            //*** we call ShutDownCef3 only in main thread ***)
        }
    }
}
