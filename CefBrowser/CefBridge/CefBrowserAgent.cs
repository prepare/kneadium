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
        AgentManagedCallback managedCallback;

        internal CefBrowserAgent(IntPtr parentWindowHandler,
            int x, int y, int w, int h)
        {
            this.parentWindowHandler = parentWindowHandler;
            //create cef browser view handler  
            this.cefBrowerAgent = Cef3Binder.MyCefCreateClientHandler();
            Cef3Binder.SetupCefWindow(cefBrowerAgent, parentWindowHandler, x, y, w, h);

            managedCallback = new AgentManagedCallback(this.OnUnmanagedPartCallBack);
            Cef3Binder.AgentRegisterManagedCallback(this.cefBrowerAgent, managedCallback);

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
            Cef3Binder.PostData(this.cefBrowerAgent, url, data, len);
        }

        public void GetText(CefStringCallback strCallback)
        {
            //keep alive callback
            keepAliveCallBack.Add(strCallback);
            Cef3Binder.DomGetTextWalk(this.cefBrowerAgent, strCallback);
        }

        public void GetSource(CefStringCallback strCallback)
        {
            //keep alive callback
            keepAliveCallBack.Add(strCallback);
            Cef3Binder.DomGetSourceWalk(this.cefBrowerAgent, strCallback);

        }

        List<CefStringCallback> keepAliveCallBack = new List<CefStringCallback>();

        void OnUnmanagedPartCallBack(int id, IntPtr callBackArgs)
        {

            switch ((MethodName)id)
            {
                case MethodName.MET_GetResourceHandler:
                    {
                        GetResourceHandler(new ResourceRequestArg(
                            new NativeCallArgs(callBackArgs)));

                    } break;
            }
        }
        protected virtual void GetResourceHandler(ResourceRequestArg req)
        {
            //sample here
            string requestURL = req.RequestUrl;
            //test change content here 
            if (requestURL.StartsWith("http://www.google.com"))
            {
                req.SetResponseData("text/html", @"<http><body>Hello!</body></http>");
            }
        } 

        public class ResourceRequestArg
        {
            NativeCallArgs nativeArgs;
            internal ResourceRequestArg(NativeCallArgs nativeArgs)
            {
                this.nativeArgs = nativeArgs;
            }
            public string RequestUrl
            {
                get
                {
                    return this.nativeArgs.GetArgAsString(0);
                }
            }
            public void SetResponseData(string mime, string str)
            {
                nativeArgs.SetOutput(0, mime);
                var utf8Buffer = Encoding.UTF8.GetBytes(str.ToCharArray());
                nativeArgs.SetOutput(1, utf8Buffer);
            }
            public void SetResponseData(string mime, byte[] dataBuffer)
            {
                nativeArgs.SetOutput(0, mime);
                nativeArgs.SetOutput(1, dataBuffer);
            }
        }



        //---------
        //map with unmanaged part
        enum MethodName
        {
            MET_GetResourceHandler = 2
        }
    }





}