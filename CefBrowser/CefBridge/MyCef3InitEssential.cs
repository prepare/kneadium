//2016, MIT, WinterDev
using System;
using System.Windows.Forms;
using LayoutFarm.CefBridge;


namespace CefBridgeTest
{
    /// <summary>
    /// Cef3 init essential for WindowForm
    /// </summary>
    class MyCef3InitEssential : LayoutFarm.CefBridge.Cef3InitEssential
    {
        static Form tinyForm;

        static string libPath = @"D:\projects\CefBridge\cef3_output\cefclient\Debug";


        static MyCef3InitEssential initEssential;

        private MyCef3InitEssential(string[] startArgs)
            : base(startArgs)
        {

        }
        public override string GetLibCefFileName()
        {
            return libPath + "\\libcef.dll";
        }
        public override string GetCefClientFileName()
        {
            return libPath + "\\cefclient.dll";
        }

        public override IWindowForm CreateNewWindow(int width, int height)
        {
            Form form1 = new Form();
            form1.Width = width;
            form1.Height = height;
            return new MyWindowForm(form1);
        }
        public override void SaveUIInvoke(SimpleDel simpleDel)
        {
            tinyForm.Invoke(simpleDel);
        }
        public override IWindowForm CreateNewBrowserWindow(int width, int height)
        {
            Form1 form1 = new Form1();
            form1.Width = width;
            form1.Height = height;
            return new MyWindowForm(form1);
        }
        public override void AfterProcessLoaded(CefStartArgs cefStartArg)
        {
#if DEBUG
            //if (cefStartArg.IsValidCefArgs)
            //{
            //    if (cefStartArg.ProcessType == "renderer")
            //    {
            //        StringBuilder stbuilder = new StringBuilder();
            //        foreach (var str in startArgs)
            //        {
            //            stbuilder.Append(str + " ");
            //        }
            //        s_dbugIsRendererProcess = true;
            //        System.Windows.Forms.MessageBox.Show(stbuilder.ToString(), DateTime.Now.ToString());
            //        //request debugger in render process
            //        System.Diagnostics.Debugger.Break();

            //    }
            //    //set break point after alert if we want to stop debugger                            
            //}
#endif
        }
        public override CefClientApp CreateClientApp()
        {

            CefClientApp clientApp = new CefClientApp(System.Diagnostics.Process.GetCurrentProcess().Handle);



            return clientApp;
        }

        public override IntPtr SetupPreRun()
        {

            //----------------------------------
            //2. as usual in WindowForm
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //-------------------------------------------------
            if (tinyForm == null)
            {
                tinyForm = new System.Windows.Forms.Form();
                tinyForm.Size = new System.Drawing.Size(10, 10);
                tinyForm.Visible = false;
            }
            IntPtr handle = tinyForm.Handle;//force it create handle**** 

            //Cef3's message pump
            System.Windows.Forms.Application.Idle += (sender, e) =>
            {
                DoMessageLoopWork();
            };

            return handle;
        }
        protected override void OnAfterShutdown()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }


        public static bool LoadAndInitCef3(string[] args)
        {
            initEssential = new MyCef3InitEssential(args);
            if (!initEssential.Init())
            {
                return false;
            }
          
            initEssential.SetupPreRun(); 

            return true;
        }
        public static void ShutDownCef3()
        {
            //----------------------------------
            //4. 
            initEssential.Shutdown();
            //---------------------------------- 
        }
    }
}