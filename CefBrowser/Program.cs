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
        static void Main()
        {

            //load cef before OLE init (eg init winform)
            LayoutFarm.CefBridge.Cef3Binder.LoadCef3();
            //----------------------------------
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             
            Form1 form1 = new Form1();
            Application.Run(form1);
            //----------------------------------

            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            LayoutFarm.CefBridge.Cef3Binder.MyCefShutDown();
            //----------------------------------
        }
    }
     

}
