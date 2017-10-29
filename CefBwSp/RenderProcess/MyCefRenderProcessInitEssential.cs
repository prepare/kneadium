//MIT, 2016-2017, WinterDev

using System;
using System.Collections.Generic;

namespace LayoutFarm.CefBridge
{

    /// <summary>
    /// Cef3 Init essential for Render process
    /// </summary>
    class MyCef3RenderProcessInitEssential : Cef3InitEssential
    {

        static MyCef3RenderProcessInitEssential initEssential;
        static string libPath;
        private MyCef3RenderProcessInitEssential(string[] startArgs)
            : base(startArgs)
        {
        }
        public override CefClientApp CreateClientApp()
        {
            //if (Cef3InitEssential.IsInRenderProcess)
            //{
            //    //you can choose debugger.break , or msgbox
            //    //to break on renderer process
            //    //System.Diagnostics.Debugger.Break();
            //    System.Windows.Forms.MessageBox.Show("RenderProcess", "RenderProcess");
            //}

            var clientApp = new ClientAppRenderer(
                System.Diagnostics.Process.GetCurrentProcess().Handle);
            return clientApp;
        }
        public static void SetLibPath(string libPath)
        {
            MyCef3RenderProcessInitEssential.libPath = libPath;
        }
        public static string GetLibPath()
        {
            return libPath;
        }
        public override bool Init()
        {
            //must check proper location of libcef, cefclient dir 

            libPath = ReferencePaths.LIB_PATH;
            return base.Init();
        }

#if DEBUG
        List<string> logMessages = new List<string>();
#endif
        public override void AddLogMessage(string msg)
        {
#if DEBUG
            logMessages.Add(msg);
#endif
        }


        public override string GetLibCefFileName()
        {
            return libPath + "\\libcef.dll";
        }
        public override string GetCefClientFileName()
        {
            return libPath + "\\cefclient.dll";
        }
        public override string GetLibChromeElfFileName()
        {
            return libPath + "\\chrome_elf.dll";
        }

        public override void AfterProcessLoaded(CefStartArgs cefStartArg)
        {

        }


        public override void SetupPreRun()
        {
            //----------------------------------
            //2. as usual in WindowForm
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //------------------------------------------------- 

        }
        protected override void OnAfterShutdown()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }

        public static bool LoadAndInitCef3(string[] args)
        {
            initEssential = new MyCef3RenderProcessInitEssential(args);
            if (!initEssential.Init())
            {
                return false;
            }
            initEssential.SetupPreRun();
            return true;
        }

        public static void ClearRemainingCefMsg()
        {
            for (int i = 100; i >= 0; --i)
            {
                CefDoMessageLoopWork();
                System.Threading.Thread.Sleep(10);
            }
        }
        public static void ShutDownCef3()
        {
            //----------------------------------
            //4. 
            initEssential.Shutdown();
            //---------------------------------- 

        }
        internal static void CefDoMessageLoopWork()
        {
            DoMessageLoopWork();
        }
    }



}