//MIT, 2016-2017, WinterDev

using System;
using System.Collections.Generic;

namespace LayoutFarm.CefBridge
{
    /// <summary>
    /// Cef3 init essential for WindowForm
    /// </summary>
    public class MyCef3InitEssential : Cef3InitEssential
    {

        static MyCef3InitEssential initEssential;
        static string libPath;
        static bool s_skipPreRun = false;

        private MyCef3InitEssential(string[] startArgs)
            : base(startArgs)
        {
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
        List<string> logMessages = new List<string>();
        public override void AddLogMessage(string msg)
        {
            logMessages.Add(msg);
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
            //if (Cef3InitEssential.IsInRenderProcess)
            //{
            //    System.Diagnostics.Debugger.Launch();
            //}

#if DEBUG
            //if(Cef3InitEssential.IsInRenderProcess)
            //{
            //    Console.WriteLine("this is renderer process");
            //    System.Diagnostics.Debugger.Launch();
            //}
            //if (cefStartArg.IsValidCefArgs)
            //{
            //    if (cefStartArg.ProcessType == "renderer")
            //    {
            //        //StringBuilder stbuilder = new StringBuilder();
            //        //stbuilder.Append("rrrr");
            //        //foreach (var str in startArgs)
            //        //{
            //        //    stbuilder.Append(str + " ");
            //        //}
            //        //s_dbugIsRendererProcess = true;
            //        //System.Windows.Forms.MessageBox.Show(stbuilder.ToString(), DateTime.Now.ToString());
            //        //request debugger in render process
            //        Console.WriteLine("this is renderer process");
            //        System.Diagnostics.Debugger.Launch();

            //    }
            //    //set break point after alert if we want to stop debugger                            
            //}
#endif
        }
        public override CefClientApp CreateClientApp()
        {

            var clientApp = new ClientAppBrowser(
                System.Diagnostics.Process.GetCurrentProcess().Handle
                 );
            return clientApp;
        }

        public override void SetupPreRun()
        {

            if (!s_skipPreRun)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
#if !NO_WINFORMS
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
#endif
            }

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
        internal static void SkipPreRun(bool value)
        {
            s_skipPreRun = value;
        }
    }



}