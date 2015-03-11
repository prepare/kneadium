using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CefBridgeTest
{
    public partial class Form1 : Form
    {

        Timer tt = new Timer();
        public Form1()
        {
            InitializeComponent();
            tt.Tick += new EventHandler(tt_Tick);

            //=======================
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            tt.Enabled = false;


            this.cefWebBrowser1.PrepareNativeClose();
            base.OnClosing(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            //tt.Enabled = true;
            base.OnLoad(e);
        }
        public class MyConsole
        {
            string myname;
            public MyConsole(string myname)
            {
                this.myname = myname;
            }
            public string MyName
            {
                get
                {
                    return this.myname;
                }
                set
                {
                    this.myname = value;
                }
            }
            /// <summary>
            /// expose to javascript
            /// </summary>
            /// <param name="str"></param>
            public void Log(string str)
            {
                Console.WriteLine(str);
            }
        }
        void TestMe001()
        {

        }


        void tt_Tick(object sender, EventArgs e)
        {
            LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
            LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.cefWebBrowser1.NavigateTo("http://localhost/html5/mycanvas.html");

        }

    }

}
