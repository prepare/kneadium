using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CefBridgeTest
{
    public partial class Form1 : Form
    {

        Timer tt = new Timer();

        Timer tt2 = new Timer();

        bool startClosing;
        bool readyToClose;
        object sync_ = new object();
        object sync_2 = new object();
        public Form1()
        {
            InitializeComponent();
            tt.Tick += new EventHandler(tt_Tick);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            this.tt2.Interval = 200;
            this.tt2.Tick += new EventHandler(tt2_Tick);

        }
        void tt2_Tick(object sender, EventArgs e)
        {
            //check if we should closing?    
            CheckClosing(); 
        }
        void CheckClosing()
        {
            if (!readyToClose)
            {  
                lock (sync_2)
                {
                    var wb = this.cefWebBrowser1;
                    if (wb != null)
                    {
                        this.Controls.Remove(wb);
                        wb.Dispose();
                        this.cefWebBrowser1 = wb = null;
                        this.Update();                        
                    }
                    readyToClose = true;
                    //this.Text = "closing...";
                    //Application.DoEvents();
                    
                } 
            }
            else
            {
                tt2.Enabled = false;
                this.Close();
            }

        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 
            //stop and close all browser then close form
            //lock (sync_)
            //{
            //    if (!this.readyToClose)
            //    {
            //        if (!startClosing)
            //        {
            //            //start closing
            //            startClosing = true;
            //            tt2.Enabled = true;
            //        }
            //        e.Cancel = true;
            //    }
            //}

        }
        delegate void SimpleDel();
        int n = 0;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var wb = this.cefWebBrowser1;
            if (wb != null)
            {
                this.Controls.Remove(wb);
                wb.Dispose();
                this.cefWebBrowser1 = wb = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string content= wb.DownloadString("http://www.google.com");
        }

    }

}
