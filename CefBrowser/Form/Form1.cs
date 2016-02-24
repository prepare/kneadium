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

        Timer tt2 = new Timer();

        bool startClosing;
        bool readyToClose;
        object sync_ = new object();
        object sync_2 = new object();
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            this.tt2.Interval = 200;
            this.tt2.Tick += new EventHandler(tt2_Tick);


        }
        public string InitUrl
        {
            get { return this.cefWebBrowser1.InitUrl; }
            set { this.cefWebBrowser1.InitUrl = value; }
        }
        void tt2_Tick(object sender, EventArgs e)
        {
            //check if we should closing?    
            CheckClosing();
        }
        void CheckClosing()
        {
            if (LayoutFarm.CefBridge.CefClientApp.IsReadyToClose(this))
            {
                tt2.Enabled = false;
                this.Close();
            }
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!startClosing)
            {
                LayoutFarm.CefBridge.CefClientApp.DisposeCefWbControl(this);
                tt2.Enabled = true;
                startClosing = true;
                e.Cancel = true;
            }
            else
            {
                if (!LayoutFarm.CefBridge.CefClientApp.IsReadyToClose(this))
                {
                    e.Cancel = true;
                }
            }
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

        protected override void OnLoad(EventArgs e)
        {
            //            tt.Enabled = true;
            base.OnLoad(e);

        }


        //void tt_Tick(object sender, EventArgs e)
        //{
        //    LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
        //    LayoutFarm.CefBridge.Cef3Binder.MyCefDoMessageLoopWork();
        //}

        private void button7_Click(object sender, EventArgs e)
        {

            this.cefWebBrowser1.Focus();
            this.cefWebBrowser1.NavigateTo("http://localhost:8080");
            //this.cefWebBrowser1.NavigateTo("https://html5test.com");
            //this.cefWebBrowser1.NavigateTo("https://www.youtube.com");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cefWebBrowser1.Agent.ExecJavascript(
                 "window.open('https://html5test.com');", "about:blank");
            //cefWebBrowser1.Agent.ExecJavascript(
            //    "alert('test!');", "about:blank");
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
                str =>
                {
                    Console.WriteLine(str);
                });

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cefWebBrowser1.Agent.GetSource(
                str =>
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
            //remove and destroy browser window
            //var wb = this.cefWebBrowser1;
            //if (wb != null)
            //{
            //    this.Controls.Remove(wb);
            //    wb.Dispose();
            //    this.cefWebBrowser1 = wb = null;
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.cefWebBrowser1.Agent.ShowDevTools();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 anotherForm1 = new Form1();
            anotherForm1.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //back
            this.cefWebBrowser1.Agent.GoBack();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //foward
            this.cefWebBrowser1.Agent.GoForward();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //reload
            this.cefWebBrowser1.Agent.Reload();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            //stop
            this.cefWebBrowser1.Agent.Stop();
        }

        private void cmdReloadIgnoreCache_Click(object sender, EventArgs e)
        {
            this.cefWebBrowser1.Agent.ReloadIgnoreCache();
        }
    }

}
