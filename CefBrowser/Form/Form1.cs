//2016, MIT , WinterDev
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

//2015-2016 MIT, WinterDev

using System.Text;
using System.Windows.Forms;

namespace CefBridgeTest
{
    public partial class Form1 : Form
    {


        LayoutFarm.CefBridge.MyWindowForm nativeWindow;
        public Form1()
        {
            InitializeComponent();
            nativeWindow = new LayoutFarm.CefBridge.MyWindowForm(this); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cefWebBrowser1.Agent.Listener = new LayoutFarm.CefBridge.MyCefUIProcessListener();

        }
         

        private void button7_Click(object sender, EventArgs e)
        {

            this.cefWebBrowser1.Focus();
            //this.cefWebBrowser1.NavigateTo("http://localhost:8080");
            this.cefWebBrowser1.NavigateTo("http://localhost");


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
