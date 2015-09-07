//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            if (!LayoutFarm.CefBridge.Cef3Binder.LoadCef3(args))
            {
                return;
            }
        
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
    }


}
