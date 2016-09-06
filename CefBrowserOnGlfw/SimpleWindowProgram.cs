using System;
using System.Windows.Forms;
using Pencil.Gaming;
using LayoutFarm.CefBridge;

namespace TestGlfw
{
    class SimpleWindowProgram
    {

        public static void Start(string[] args)
        {
            if (!Glfw.Init())
            {
                Console.WriteLine("can't init glfw");
                return;
            }

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

            GlfwMonitorPtr monitor = new GlfwMonitorPtr();
            GlfwWindowPtr glWindow = Glfw.CreateWindow(
                800,
                600,
                "Native CefBrowser, Press any key to start browse the web",
                monitor,
                GlfwWindowPtr.Null);

            ////--------------- 
            Form f1 = Form.CreateFromNativeWindowHwnd(Glfw.GetNativePlatformWinHwnd(glWindow));
            f1.Width = 800;
            f1.Height = 600;
            Glfw.SetWindowSizeCallback(glWindow, (GlfwWindowPtr wnd, int width, int height) =>
            {
                //change window size here
            });
            AddWbControlToMainWindow(f1);
            while (!Glfw.WindowShouldClose(glWindow))
            {
                MyCef3InitEssential.CefDoMessageLoopWork();
                Glfw.PollEvents();
                //Glfw.WaitEvents();
            }

            Glfw.DestroyWindow(glWindow);
            /////////////////////////////////////////////
            MyCef3InitEssential.ClearRemainingCefMsg();
            MyCef3InitEssential.ShutDownCef3();
            /////////////////////////////////////////////
            Glfw.Terminate();
        }
        static void AddWbControlToMainWindow(Form formMain)
        {
            //this test:    we create 2 web browsers

            cefBrowser = new MyCefBrowser(
                MyWindowControl.TryGetWindowControlOrRegisterIfNotExists(formMain),
                  0, 0, formMain.Width / 2, formMain.Height, "about:blank");
            cefBrowser2 = new MyCefBrowser(
                MyWindowControl.TryGetWindowControlOrRegisterIfNotExists(formMain),
                  formMain.Width / 2, 0, formMain.Width / 2, formMain.Height, "about:blank");
        }
        static MyCefBrowser cefBrowser;
        static MyCefBrowser cefBrowser2;
    }
}