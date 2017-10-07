//MIT, 2015-2017, WinterDev

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace LayoutFarm.CefBridge
{
    public partial class Form1 : Form
    {
        LayoutFarm.CefBridge.IWindowForm nativeWindow;
        public Form1()
        {
            InitializeComponent();
            nativeWindow = LayoutFarm.CefBridge.MyWindowForm.TryGetWindowFormOrRegisterIfNotExists(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.splitContainer1.SplitterMoved += SplitContainer1_SplitterMoved;
            //load test url

            cmbAddressBar.Items.AddRange(new string[]
            {
                "https://html5test.com",
                "http://www.youtube.com",
                "https://www.google.com",
                "http://localhost",
                "http://localhost/LiborMasekThesis.pdf",
                "http://localhost/pdfjs/web/viewer.html",
                "http://localhost/pdfjs/web/compressed.tracemonkey-pldi-09.pdf",

            });
            this.cmbAddressBar.SelectedIndexChanged += cmbAddressBar_SelectedIndexChanged;
            this.cmbAddressBar.KeyDown += cmbAddressBar_KeyDown;
        }
        private void cmbAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selectedUrl = cmbAddressBar.Text;
                if (selectedUrl != null)
                {
                    this.cefWebBrowser1.Focus();
                    this.cefWebBrowser1.NavigateTo(selectedUrl);
                }
            }

        }

        private void cmbAddressBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUrl = this.cmbAddressBar.SelectedItem as string;
            if (selectedUrl != null)
            {
                this.cefWebBrowser1.Focus();
                this.cefWebBrowser1.NavigateTo(selectedUrl);
            }
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cefWebBrowser1.Agent.SetSize(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
        }
        public void Navigate(string url)
        {
            this.cefWebBrowser1.NavigateTo(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cefWebBrowser1.Agent.ExecJavascript(
            //     "window.open('https://html5test.com');", "about:blank");
            cefWebBrowser1.Agent.ExecJavascript(
              "alert('test!');", "about:blank");
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



        private void button8_Click(object sender, EventArgs e)
        {
            this.cefWebBrowser1.Agent.ShowDevTools();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 anotherForm1 = new Form1();
            anotherForm1.Show();
            anotherForm1.Navigate("http://localhost");
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
        private void button6_Click(object sender, EventArgs e)
        {
            {
                var p = cefWebBrowser1.Parent;
                p.Controls.Remove(cefWebBrowser1);
                cefWebBrowser1.Dispose();
            }
            //{
            //    var p = cefWebBrowserControl1.Parent;
            //    p.Controls.Remove(p);
            //    p.Dispose();
            //}
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //this.cefWebBrowser1.Agent.PrintToPdf("d:\\WImageTest\\testpdf.pdf");
            string pdfConfig = "{\"header_footer_enabled\":true,\"header_footer_url\":\"hello001\",\"landscape\":1}";
            this.cefWebBrowser1.Agent.PrintToPdf(pdfConfig, "d:\\WImageTest\\testpdf.pdf");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.cefWebBrowser1.Agent.GetSource2((str) =>
            {



            });
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //load text
            //this.cefWebBrowser1.Agent.LoadText("<html><head><body><h1>hello!</h1></body></html>", "http://localhost");
            this.cefWebBrowser1.Agent.LoadText("<html><head><script>function docload(){ console.log(test001());console.log(test_myobj[\"12345\"]); console.log(test_myobj.myprop);}</script><body onload=\"docload()\"><h1>hello!</h1></body></html>", "http://localhost");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string data = "arg1=val1&arg2=val2";
            byte[] dataBuffer = Encoding.UTF8.GetBytes(data);
            using (var nativeBw = cefWebBrowser1.Agent.GetNativeBw())
            using (var fr = nativeBw.GetMainFrame())
            {


                Auto.CefRequest req = Auto.CefRequest.Create();
                req.SetURL("http://localhost");
                fr.LoadRequest(req);
            }
            //

            //cefWebBrowser1.Agent.PostData(
            //    "http://tests/request",
            //    dataBuffer,
            //    dataBuffer.Length);
        }


    }
}
;