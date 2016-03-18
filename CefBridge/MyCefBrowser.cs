//2015-2016 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;


namespace LayoutFarm.CefBridge
{


    public class MyCefBrowser
    {

        public event EventHandler BrowserDisposed;
        IntPtr myCefBrowser;
        MyCefCallback managedCallback;

        string currentUrl;
        IWindowControl parentControl;
        IWindowForm topForm;
        IWindowForm devForm;
        MyCefDevWindow cefDevWindow;
        MyCefUIProcessListener browserProcessListener;

        static Dictionary<IntPtr, List<MyCefBrowser>> registeredWbControls =
                    new Dictionary<IntPtr, List<MyCefBrowser>>();


        public MyCefBrowser(IWindowControl parentControl,
            int x, int y, int w, int h, string initUrl)
        {
            this.currentUrl = initUrl;
            //create cef browser view handler  
            this.parentControl = parentControl;


            this.topForm = (IWindowForm)parentControl.GetTopLevelControl();

            //ui process ***
            this.managedCallback = new MyCefCallback(this.MxCallBack);
            this.myCefBrowser = Cef3Binder.MyCefCreateMyWebBrowser(managedCallback);

            Cef3Binder.MyCefSetupBrowserHwnd(myCefBrowser, parentControl.GetHandle(), x, y, w, h, initUrl);
            Cef3Binder.MyCefEnableKeyIntercept(myCefBrowser, 1);

            //register mycef browser
            RegisterCefWbControl(this);
        }
        public MyCefUIProcessListener Listener
        {
            get { return browserProcessListener; }
            set { browserProcessListener = value; }
        }

        public IWindowControl ParentControl { get { return this.parentControl; } }
        public IWindowForm ParentForm { get { return this.topForm; } }

        void MxCallBack(int id, IntPtr argsPtr)
        {
            switch (id)
            {
                case 100:
                    {
                        if (this.devForm != null)
                        {
                            this.devForm.Close();
                            ((IDisposable)this.devForm).Dispose();
                            this.devForm = null;
                        }
                        if (this.BrowserDisposed != null)
                        {
                            this.BrowserDisposed(this, EventArgs.Empty);
                        }
                    }
                    break;
                case 101:
                    {
                    }
                    break;
                case 103:
                    {
                        //create pop up window and send window handle to cef 
                        //create new window form

                        IWindowForm popupWin = Cef3Binder.CreateBlankForm(600, 450);
                        popupWin.Show();
                        IntPtr handle = popupWin.GetHandle();
                        if (argsPtr != IntPtr.Zero)
                        {
                            NativeCallArgs2 args = new NativeCallArgs2(argsPtr);
                            args.SetResult(handle);
                        }
                    }
                    break;
                case 104:
                    {
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            string url = args.GetArgAsString(0);
                            IWindowForm form = Cef3Binder.CreateNewBrowserWindow(800, 600);
                            form.Show();
                            //and navigate to a specific url
                            //TODO: review here

                            args.Dispose();
                        });

                    }
                    break;
                case 106:
                    {
                        //console.log ...

                        if (browserProcessListener != null)
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            browserProcessListener.OnConsoleLog(args);
                        }

                    }
                    break;
                case 107:
                    {
                        //show dev tools
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            IWindowForm newPopupForm = Cef3Binder.CreateNewBrowserWindow(800, 600);
                            newPopupForm.Show();
                        });

                    }
                    break;
                case 108:
                    {
                        //load page error
                        //ui process
                        var args = new NativeCallArgs(argsPtr);
                        IntPtr cefBrowser = args.GetArgAsNativePtr(0);
                        IntPtr cefFrame = args.GetArgAsNativePtr(1);
                        int errorCode = args.GetArgAsInt32(2);//error code
                        string errorText = args.GetArgAsString(3);//errorText
                        string failedUrl = args.GetArgAsString(4); //failedUrl
                        //---------------------------                        
                        //load error page
                        LoadErrorPage(cefBrowser, cefFrame, errorCode, errorText, failedUrl);
                    }
                    break;
                case 140:
                    {
                        //setup resource mx
                        if (browserProcessListener != null)
                        {

                            var args = new NativeCallArgs(argsPtr);
                            var resourceMx = new NativeResourceMx(args.GetArgAsNativePtr(0));
                            browserProcessListener.OnAddResourceMx(resourceMx);
                        }
                    }
                    break;

                case 142:
                    {

                        //filter url name
                        if (browserProcessListener != null)
                        {
                            var args = new NativeCallArgs(argsPtr);
                            browserProcessListener.OnFilterUrl(args);
                        }

                    }
                    break;
                case 145:
                    {
                        //request for binary resource
                        if (browserProcessListener != null)
                        {
                            var args = new NativeCallArgs(argsPtr);
                            browserProcessListener.OnRequestForBinaryResource(args);
                        }
                    }
                    break;
                //------------------------------
                //eg. from cefQuery --> 
                case 205:
                    {
                        if (browserProcessListener != null)
                        {
                            var args = new NativeCallArgs(argsPtr);
                            QueryRequestArgs reqArgs = QueryRequestArgs.CreateRequest(args.GetArgAsNativePtr(0));
                            browserProcessListener.OnCefQuery(args, reqArgs);
                        }

                    }
                    break;
                //------------------------------
                case 501: //on PreKey
                    {
                        // Console.WriteLine("on pre key");
                    }
                    break;
                //------------------------------
                case 502:
                    {
                        //title changed
                        var args = new NativeCallArgs(argsPtr);
                        string newtitle = args.GetArgAsString(0);
                        // Console.WriteLine("title changed:" + newtitle);
                    }
                    break;
                case 503:
                    {
                        //address changed
                        var args = new NativeCallArgs(argsPtr);
                        string newtitle = args.GetArgAsString(0);
                        // Console.WriteLine("address changed:" + newtitle);
                    }
                    break;
            }

        }

        void LoadErrorPage(IntPtr cefBw, IntPtr cefFrame, int errorCode, string errorText, string failedUrl)
        {


            //ss << "<html><head><title>Page failed to load</title></head>" 
            //    "<body bgcolor=\"white\">" 
            //    "<h3>Page failed to load.</h3>" 
            //    "URL: <a href=\"" << failed_url << "\">" << failed_url << "</a>" 
            //    "<br/>Error: " << test_runner::GetErrorString(error_code) <<
            //    " (" << error_code << ")"; 
            //if (!other_info.empty())
            //    ss << "<br/>" << other_info;
            //ss << "</body></html>";
            //frame->LoadURL(test_runner::GetDataURI(ss.str(), "text/html"));
        }

        public string CurrentUrl
        {
            get { return this.currentUrl; }
        }

        public void NavigateTo(string url)
        {
            currentUrl = url;
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
        List<MyCefCallback> keepAliveCallBack = new List<MyCefCallback>();
        public void GetText(Action<string> strCallback)
        {
            //keep alive callback
            InternalGetText((id, nativePtr) =>
            {
                var args = new NativeCallArgs(nativePtr);
                strCallback(args.GetArgAsString(0));

            });
            //Cef3Binder.MyCefDomGetTextWalk(this.myCefBrowser, strCallback);
        }
        public void GetSource(Action<string> strCallback)
        {
            //keep alive callback
            InternalGetSource((id, nativePtr) =>
            {
                var args = new NativeCallArgs(nativePtr);
                strCallback(args.GetArgAsString(0));
            });

        }
        void InternalGetSource(MyCefCallback strCallback)
        {
            //keep alive callback
            keepAliveCallBack.Add(strCallback);
            Cef3Binder.MyCefDomGetSourceWalk(this.myCefBrowser, strCallback);
        }
        void InternalGetText(MyCefCallback strCallback)
        {
            //keep alive callback
            keepAliveCallBack.Add(strCallback);
            Cef3Binder.MyCefDomGetTextWalk(this.myCefBrowser, strCallback);
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
        public void ReloadIgnoreCache()
        {
            Cef3Binder.MyCefBwReloadIgnoreCache(myCefBrowser);
        }
        public void ShowDevTools()
        {
            if (cefDevWindow == null)
            {
                cefDevWindow = new MyCefDevWindow();
                IWindowForm devForm = Cef3Binder.CreateBlankForm(800, 600);
                devForm.Text = "Developer Tool";
                devForm.Show();

                Cef3Binder.MyCefShowDevTools(this.myCefBrowser,
                    cefDevWindow.GetMyCefBrowser(),
                    devForm.GetHandle());
            }
        }

        static readonly object sync_remove = new object();
        static void RegisterCefWbControl(MyCefBrowser cefWb)
        {
            //register this control with parent form
            var ownerForm = (IWindowForm)cefWb.ParentControl.GetTopLevelControl();
            List<MyCefBrowser> foundList;
            IntPtr winHandle = ownerForm.GetHandle();
            if (!registeredWbControls.TryGetValue(winHandle, out foundList))
            {
                foundList = new List<MyCefBrowser>();
                registeredWbControls.Add(winHandle, foundList);
            }
            if (!foundList.Contains(cefWb))
            {
                foundList.Add(cefWb);
                cefWb.BrowserDisposed += new EventHandler(cefWb_BrowserDisposed);
            }
        }
        static void cefWb_BrowserDisposed(object sender, EventArgs e)
        {
            //when browser is disposed..
            MyCefBrowser wb = (MyCefBrowser)sender;
            //remove wb from registerd list
            List<MyCefBrowser> wblist;
            IntPtr winHandle = wb.ParentForm.GetHandle();
            if (registeredWbControls.TryGetValue(winHandle, out wblist))
            {
                lock (sync_remove)
                {
                    wblist.Remove(wb);
                    if (wblist.Count == 0)
                    {
                        registeredWbControls.Remove(winHandle);
                    }
                }
            }
        }
        public static void DisposeCefWbControl(IWindowForm ownerForm)
        {
            //register this control with parent form 
            List<MyCefBrowser> foundList;
            IntPtr winHandle = ownerForm.GetHandle();
            if (registeredWbControls.TryGetValue(winHandle, out foundList))
            {
                //remove wb controls             
                for (int i = foundList.Count - 1; i >= 0; --i)
                {
                    var wb = foundList[i].ParentControl;
                    var parent = wb.GetParent();
                    parent.RemoveChild(wb);
                    wb.Dispose();
                }

                registeredWbControls.Remove(winHandle);

            }

        }
        public static bool IsReadyToClose(IntPtr nativeHandle)
        {
            //register this control with parent form  
            lock (sync_remove)
            {
                return !registeredWbControls.ContainsKey(nativeHandle);
            }
        }


        //void OnUnmanagedPartCallBack(int id, IntPtr callBackArgs)
        //{

        //    switch ((MethodName)id)
        //    {
        //        case MethodName.MET_GetResourceHandler:
        //            {
        //                GetResourceHandler(new ResourceRequestArg(
        //                    new NativeCallArgs(callBackArgs)));
        //            }
        //            break;
        //        case MethodName.MET_TCALLBACK:
        //            {
        //                //Console.WriteLine("TCALLBACK");
        //            }
        //            break;
        //    }
        //}
        //protected virtual void GetResourceHandler(ResourceRequestArg req)
        //{
        //    //sample here
        //    string requestURL = req.RequestUrl;
        //    //test change content here 
        //    if (requestURL.StartsWith("http://www.google.com"))
        //    {
        //        req.SetResponseData("text/html", @"<http><body>Hello!</body></http>");
        //    }
        //}

        //public class ResourceRequestArg
        //{
        //    NativeCallArgs nativeArgs;
        //    internal ResourceRequestArg(NativeCallArgs nativeArgs)
        //    {
        //        this.nativeArgs = nativeArgs;
        //    }
        //    public string RequestUrl
        //    {
        //        get
        //        {
        //            return this.nativeArgs.GetArgAsString(0);
        //        }
        //    }
        //    public void SetResponseData(string mime, string str)
        //    {
        //        nativeArgs.SetOutput(0, mime);
        //        var utf8Buffer = Encoding.UTF8.GetBytes(str.ToCharArray());
        //        nativeArgs.SetOutput(1, utf8Buffer);
        //    }
        //    public void SetResponseData(string mime, byte[] dataBuffer)
        //    {
        //        nativeArgs.SetOutput(0, mime);
        //        nativeArgs.SetOutput(1, dataBuffer);
        //    }
        //}

    }





}