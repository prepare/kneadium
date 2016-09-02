//2015-2016 MIT, WinterDev

using System;
using System.Windows.Forms;
namespace CefBridgeTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
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
                for (int i = 10; i >= 0; --i)
                {
                    MyCef3InitEssential.CefDoMessageLoopWork();
                    System.Threading.Thread.Sleep(50);
                }
                return;
            }

            //------------------------------------------
            /////////////////////////////////////////////
            //this code is run only in main process
            //------------------------------------------
            Form1 f1 = new Form1();
            ApplicationContext appContext = new ApplicationContext(f1);
            Application.Run(appContext);

            for (int i = 10; i >= 0; --i)
            {
                MyCef3InitEssential.CefDoMessageLoopWork();
                System.Threading.Thread.Sleep(50);
            }

            MyCef3InitEssential.ShutDownCef3();
            //(***please note that 
            //*** we call ShutDownCef3 only in main thread ***)
        }
    }
}
