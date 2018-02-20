//MIT, 2015-2017, WinterDev

using System;
using System.Windows.Forms;

namespace LayoutFarm.CefBridge
{
    static class Program
    {


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
            LibFolderManager.CheckNativeLibs();
            //move current dir to subfolder ***


            string currentExecPath = System.Windows.Forms.Application.ExecutablePath;
            string onlyDirName = System.IO.Path.GetDirectoryName(currentExecPath);
            string onlyExeName = System.IO.Path.GetFileName(currentExecPath);

            //move our current dir to Application dir
            //before we load native dll
            System.IO.Directory.SetCurrentDirectory(onlyDirName + "//sub");

            ////------------------------------------------
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
