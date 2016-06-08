using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
            //1. load cef before OLE init (eg init winform) ***
            //see more detail ...  MyCef3InitEssential
            if (!MyCef3InitEssential.LoadAndInitCef3(args))
            {
                return;
            }

            ////---------------------------------
            ////2. as usual in WindowForm
            //Form1 f1 = new Form1();
            //ApplicationContext appContext = new ApplicationContext(f1);
            //Application.Run(appContext);
            //---------------------------------

            Form f1 = new Form();
            Application.Run(f1);
            //3. shutdown cef3
            MyCef3InitEssential.ShutDownCef3();
        }
    }

}
