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

            //load cef before OLE init (eg init winform) ***
            var initEssential = new MyCef3InitEssential(args);
            if (!initEssential.Init())
            {
                return;
            }
            //----------------------------------
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //----------------------------------
            
            initEssential.SetupPreRun(); 
            //----------------------------------
            Form1 f1 = new Form1();
            ApplicationContext appContext = new ApplicationContext(f1);
            Application.Run(appContext);
            //----------------------------------
            initEssential.Shutdown();          
            //---------------------------------- 
        }
    
      

    }


 


}
