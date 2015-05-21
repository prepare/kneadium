//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{

    public class CefBrowserAgent2
    {
        internal static bool WindowIsCreated;
        IntPtr myCefBrowser;
        IntPtr parentWindowHandler;
        MyCefCallback managedCallback;
        string initUrl;
        internal CefBrowserAgent2()
        {
            //create cef browser view handler  
            this.myCefBrowser = Cef3Binder.MyCefCreateMyWebBrowser();
        }
        public IntPtr GetMyCefBrowser()
        {
            return this.myCefBrowser;
        }

    }


    public class CefBrowserAgent
    {

        internal static bool WindowIsCreated;
        IntPtr myCefBrowser;
        IntPtr parentWindowHandler;
        MyCefCallback managedCallback;
        string initUrl;
        internal CefBrowserAgent(IntPtr parentWindowHandler,
            int x, int y, int w, int h, string initUrl)
        {
            this.initUrl = initUrl;
            this.parentWindowHandler = parentWindowHandler;
            //create cef browser view handler  
            this.myCefBrowser = Cef3Binder.MyCefCreateMyWebBrowser();
            Cef3Binder.MyCefSetupBrowserHwnd(myCefBrowser, parentWindowHandler, x, y, w, h, initUrl);
        }
        internal IntPtr NativeMyCefBrowserHandle
        {
            get { return this.myCefBrowser; }
        }
        public void NavigateTo(string url)
        {
            Cef3Binder.MyCefBwNavigateTo(this.myCefBrowser, url);
        }
        public void ExecJavascript(string src, string scriptUrl)
        {
            Cef3Binder.MyCefBwExecJavascript(this.myCefBrowser, src, scriptUrl);
        }
        public void PostData(string url, byte[] data, int len)
        {
            Cef3Binder.MyCefBwPostData(this.myCefBrowser, url, data, len);
        }

        public void GetText(MyCefCallback strCallback)
        {
            ////keep alive callback
            //keepAliveCallBack.Add(strCallback);
            //Cef3Binder.DomGetTextWalk(this.myCefBrowser, strCallback);
        }

        public void GetSource(MyCefCallback strCallback)
        {
            ////keep alive callback
            //keepAliveCallBack.Add(strCallback);
            //Cef3Binder.DomGetSourceWalk(this.myCefBrowser, strCallback);

        }

        List<MyCefCallback> keepAliveCallBack = new List<MyCefCallback>();

        void OnUnmanagedPartCallBack(int id, IntPtr callBackArgs)
        {

            switch ((MethodName)id)
            {
                case MethodName.MET_GetResourceHandler:
                    {
                        GetResourceHandler(new ResourceRequestArg(
                            new NativeCallArgs(callBackArgs)));
                    } break;
                case MethodName.MET_TCALLBACK:
                    {
                        //Console.WriteLine("TCALLBACK");
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

        public void Stop()
        {
            Cef3Binder.MyCefBwStop(myCefBrowser);
        }
        public void GoBack()
        {
            Cef3Binder.MyCefBwGoBack(myCefBrowser);
        }
        public void GoForward()
        {
            Cef3Binder.MyCefBwGoForward(myCefBrowser);
        }
        public void Reload()
        {
            Cef3Binder.MyCefBwReload(myCefBrowser);
        }


        //---------
        //map with unmanaged part
        enum MethodName
        {
            MET_GetResourceHandler = 2,
            MET_TCALLBACK = 3
        }
    }





}