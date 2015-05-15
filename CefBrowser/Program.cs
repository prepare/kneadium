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

<<<<<<< HEAD
            Form1 f1 = new Form1();
            ApplicationContext appContext = new ApplicationContext(f1);
            Application.Run(appContext);
            //  Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            //----------------------------------
            LayoutFarm.CefBridge.Cef3Binder.MyCefShutDown();
=======
            Form1 form1 = new Form1();
            Application.Run(form1);
            //----------------------------------
>>>>>>> origin/mod1

            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

<<<<<<< HEAD

            //---------------------------------- 
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {

        }
    }

=======
            LayoutFarm.CefBridge.Cef3Binder.MyCefShutDown();
            //----------------------------------

 
        }
    }
     
>>>>>>> origin/mod1

}
