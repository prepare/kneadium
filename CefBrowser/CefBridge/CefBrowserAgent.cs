//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{
    public class CefBrowserAgent
    {
        IntPtr cefBrowerAgent;
        IntPtr parentWindowHandler;


        internal CefBrowserAgent(IntPtr parentWindowHandler,
            int x, int y, int w, int h)
        {
            this.parentWindowHandler = parentWindowHandler;
            //create cef browser view handler  
            this.cefBrowerAgent = Cef3Binder.MyCefCreateClientHandler();
            Cef3Binder.SetupCefWindow(cefBrowerAgent, parentWindowHandler, x, y, w, h);
        }

        internal IntPtr Handle
        {
            get { return this.cefBrowerAgent; }
        }
        internal void CloseView()
        {
            Cef3Binder.MyCefCloseHandler(this.cefBrowerAgent);
        }

        public void NavigateTo(string url)
        {
            Cef3Binder.NavigateTo(this.cefBrowerAgent, url);
        }
        public void ExecJavascript(string src, string scriptUrl)
        {
            Cef3Binder.ExecJavascript(this.cefBrowerAgent, src, scriptUrl);
        }
        public void PostData(string url, byte[] data, int len)
        {
            unsafe
            {
                fixed (byte* h = &data[0])
                {
                    Cef3Binder.PostData(this.cefBrowerAgent, url, h, len);
                }
            }

        }

    }


}