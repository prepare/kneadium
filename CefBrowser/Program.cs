//MIT, 2015-2017, WinterDev

using System;
using System.Windows.Forms;

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
            //ReferencePaths.LIB_PATH = @"D:\projects/cef_3_3071.1647/win64";
            //ReferencePaths.LIB_PATH = @"D:\projects\cef_binary_3.3071.1647.win64build\tests\cefclient\Release";
#if DEBUG
            ReferencePaths.LIB_PATH = @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Debug";
#else
            ReferencePaths.LIB_PATH = @"D:\projects\cef_binary_3.3071.1647.win32build\tests\cefclient\Release";
#endif  
            //ReferencePaths.SUB_PROCESS_PATH = ReferencePaths.LIB_PATH + "/CefBwSp.exe";
            ReferencePaths.SUB_PROCESS_PATH = "CefBwSp.exe";
            //---------------
            ReferencePaths.OUTPUT_DIR = @"../../../_output";//dir
            ReferencePaths.LOG_PATH = ReferencePaths.OUTPUT_DIR + "/cef_console.log"; //file
            ReferencePaths.CACHE_PATH = ReferencePaths.OUTPUT_DIR + "/cef_cache"; //dir
            ReferencePaths.SAVE_IMAGE_PATH = ReferencePaths.OUTPUT_DIR + "/snap02"; //dir

            if (!System.IO.Directory.Exists(ReferencePaths.OUTPUT_DIR))
            {
                System.IO.Directory.CreateDirectory(ReferencePaths.OUTPUT_DIR);
            }


        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //this is designed for cef UI process.
            //this process starts before any subprocess.
            //so before load anything we should check  
            //  if essential libs are available
            //------------------------------------------
            CheckNativeLibs();
            //------------------------------------------
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


            //------------------------------------------
            /////////////////////////////////////////////
            //this code is run only in main process
            //------------------------------------------
            MyCef3WinForms myCef3WinForm = new MyCef3WinForms();
            myCef3WinForm.SetAsCurrentImpl();
            WinFormCefMsgLoopPump.Start();
            //------------------------------------------
            Form1 f1 = new Form1();
            ApplicationContext appContext = new ApplicationContext(f1);
            Application.Run(appContext);

            /////////////////////////////////////////////
            MyCef3InitEssential.ClearRemainingCefMsg();
            MyCef3InitEssential.ShutDownCef3();
            //(***please note that 
            //*** we call ShutDownCef3 only in main thread ***)
        }

    }
}
