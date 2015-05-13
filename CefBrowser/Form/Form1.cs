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
        delegate void SimpleDel();
        bool isCloseFirst = false;
        protected override void OnClosing(CancelEventArgs e)
        {
            tt.Enabled = false;
            if (!isCloseFirst)
            {
                this.cefWebBrowser1.PrepareNativeClose();
                
                e.Cancel = true;
                isCloseFirst = true;
            }
            else
            {
                base.OnClosing(e);
            } 
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



        void tt_Tick(object sender, EventArgs e)
        {
            LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
            LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            this.cefWebBrowser1.Focus();
            //this.cefWebBrowser1.NavigateTo("http://10.0.2.71");
            this.cefWebBrowser1.NavigateTo("http://localhost");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cefWebBrowser1.Agent.ExecJavascript(
                "window.open('http://localhost/html5/mycanvas.html');", "about:blank");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = "arg1=val1&arg2=val2";
            byte[] dataBuffer = Encoding.UTF8.GetBytes(data);

            cefWebBrowser1.Agent.PostData(
                "http://tests/request",
                dataBuffer,
                dataBuffer.Length);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            cefWebBrowser1.Agent.GetText(
                (id, str) =>
                {
                    Console.WriteLine(str);
                });

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cefWebBrowser1.Agent.GetSource(
                (id, str) =>
                {
                    Console.WriteLine(str);
                });
        }

        private void button5_Click(object sender, EventArgs e)
        {






        }

    }

}
