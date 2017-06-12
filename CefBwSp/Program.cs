//MIT, 2015-2017, WinterDev 

using System;

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
