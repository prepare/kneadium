//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LayoutFarm.CefBridge;

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


            //load cef before OLE init (eg init winform)
            var initEssential = new MyCef3InitEssential(args);

            if (!LayoutFarm.CefBridge.Cef3Binder.LoadCef3(initEssential))
            {
                return;
            }

            System.Windows.Forms.Application.Idle += (sender, e) =>
            {
                LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
            };

            //----------------------------------
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //----------------------------------
            LayoutFarm.CefBridge.Cef3Binder.CefReady();
            Form1 f1 = new Form1();
            ApplicationContext appContext = new ApplicationContext(f1);
            Application.Run(appContext);
            //  Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            //----------------------------------
            LayoutFarm.CefBridge.Cef3Binder.MyCefShutDown();

            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            //---------------------------------- 
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {

        }

        class MyCef3InitEssential : LayoutFarm.CefBridge.Cef3InitEssential
        {
            static Form tinyForm;
            public MyCef3InitEssential(string[] startArgs)
                : base(startArgs)
            {

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
            public override IWindowForm CreateNewBrowserWindow(int width, int height, string initURL)
            {
                Form1 form1 = new Form1();
                form1.Width = width;
                form1.Height = height;
                form1.InitUrl = initURL;
                return new MyWindowForm(form1);
            }
            public override void AfterProcessLoad(CefStartArgs cefStartArg)
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
                CefClientAppX clientApp = new CefClientAppX(System.Diagnostics.Process.GetCurrentProcess().Handle);
                return clientApp;
            }
            public override IntPtr CefReady()
            {
                if (tinyForm == null)
                {
                    tinyForm = new System.Windows.Forms.Form();
                    tinyForm.Size = new System.Drawing.Size(10, 10);
                    tinyForm.Visible = false;
                }
                return tinyForm.Handle;//force it create handle****
            }
        }


    }


}
