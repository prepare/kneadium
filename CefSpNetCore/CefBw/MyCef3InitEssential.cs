﻿//MIT, 2016-2017, WinterDev

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
        private MyCef3InitEssential(string[] startArgs)
            : base(startArgs)
        {
        }
        public static void SetLibPath(string libPath)
        {
            MyCef3InitEssential.libPath = libPath;
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

        }
        public override CefClientApp CreateClientApp()
        {
            var renderProcListener = new MyCefRendererProcessListener();
            var clientApp = new CefClientApp(
                System.Diagnostics.Process.GetCurrentProcess().SafeHandle.DangerousGetHandle(),
                renderProcListener);
            return clientApp;
        }

        public override void SetupPreRun()
        {
            //----------------------------------
            //2. as usual in WindowForm
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
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
    }



}