//MIT, 2015-2017, WinterDev

using System;
using System.Collections.Generic;
namespace LayoutFarm.CefBridge
{
    public class MyCefBrowser
    {
        public event EventHandler BrowserDisposed;
        IntPtr myCefBrowser;
        MyCefCallback managedCallback;
        string currentUrl = "about:blank";
        IWindowControl parentControl;
        IWindowForm topForm;
        IWindowForm devForm;
        MyCefDevWindow cefDevWindow;
        CefUIProcessListener browserProcessListener;
        CefOsrListener cefOsrListener;
        List<MyCefCallback> keepAliveCallBack = new List<MyCefCallback>();
        //----

        public MyCefBrowser(IWindowControl parentControl,
            int x, int y, int w, int h, string initUrl, bool isOsr)
        {
            this.currentUrl = initUrl;
            //create cef browser view handler  
            this.parentControl = parentControl;
            this.topForm = parentControl.GetTopLevelControl() as IWindowForm;
            //ui process ***
            this.managedCallback = new MyCefCallback(this.MxCallBack);
            //for specific browser
            if (this.IsOsr = isOsr)
            {
                this.myCefBrowser = Cef3Binder.MyCefCreateMyWebBrowserOSR(managedCallback);
                Cef3Binder.MyCefSetupBrowserHwndOSR(myCefBrowser, parentControl.GetHandle(), x, y, w, h, initUrl, IntPtr.Zero);
            }
            else
            {
                this.myCefBrowser = Cef3Binder.MyCefCreateMyWebBrowser(managedCallback);
                Cef3Binder.MyCefSetupBrowserHwnd(myCefBrowser, parentControl.GetHandle(), x, y, w, h, initUrl, IntPtr.Zero);
            }

            Cef3Binder.MyCefEnableKeyIntercept(myCefBrowser, 1);
            //register mycef browser
            RegisterCefWbControl(this);
        }
        public bool IsOsr
        {
            get;
            private set;
        }
        public CefOsrListener OsrListener
        {
            get { return cefOsrListener; }
            set { cefOsrListener = value; }
        }
        public CefUIProcessListener Listener
        {
            get { return browserProcessListener; }
            set { browserProcessListener = value; }
        }

        public IWindowControl ParentControl { get { return this.parentControl; } }
        public IWindowForm ParentForm { get { return this.topForm; } }

        public bool IsBrowserCreated
        {
            get;
            private set;
        }

        void MxCallBack(int id, IntPtr argsPtr)
        {
            switch ((MyCefMsg)id)
            {
                case MyCefMsg.CEF_MSG_ClientHandler_NotifyBrowserCreated:
                    {
                        IsBrowserCreated = true;

                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_NotifyBrowserClosing:
                    {

                    }
                    break;

                case MyCefMsg.CEF_MSG_ClientHandler_NotifyBrowserClosed:
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
                case MyCefMsg.CEF_MSG_ClientHandler_OnBeforeContextMenu:
                    {
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_BeforeDownload:
                    {
                        //handle download path here
                        NativeCallArgs metArgs = new NativeCallArgs(argsPtr);
                        string pathName = metArgs.GetArgAsString(2);

                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_DownloadUpdated:
                    {
                        //this version we notify back 
                        //when 
                        NativeCallArgs metArgs = new NativeCallArgs(argsPtr);
                        if (browserProcessListener != null)
                        {
                            browserProcessListener.OnDownloadCompleted(metArgs);
                        }
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_OnBeforePopup:
                    {
                        NativeCallArgs args = new NativeCallArgs(argsPtr);
                        //open new form with specific url
                        string url = args.GetArgAsString(0);
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            IWindowForm form = Cef3Binder.CreateNewBrowserWindow(800, 600);
                            form.Show();
                            //and navigate to a specific url 
                        });
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_OnConsoleMessage:
                    {
                        //console.log ...

                        if (browserProcessListener != null)
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            browserProcessListener.OnConsoleLog(args);
                        }
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_ShowDevTools:
                    {
                        //show dev tools
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            IWindowForm newPopupForm = Cef3Binder.CreateNewBrowserWindow(800, 600);
                            newPopupForm.Show();
                        });
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_OnLoadError:
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
                case MyCefMsg.CEF_MSG_ClientHandler_OnCertError:
                    {
                        var args = new NativeCallArgs(argsPtr);
                        string certErrMsg = args.GetArgAsString(0);
                        args.SetOutput(0, 1);//true
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_ExecCustomProtocol:
                    {
                        //disable all protocol
                        var args = new NativeCallArgs(argsPtr);
                        if (browserProcessListener != null)
                        {
                            browserProcessListener.OnExecProtocol(args);
                        }
                        else
                        {
                            args.SetOutput(0, 0);//disable all protocol
                        }
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_SetResourceManager:
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
                case MyCefMsg.CEF_MSG_RequestUrlFilter2:
                    {
                        //filter url name
                        if (browserProcessListener != null)
                        {
                            var args = new NativeCallArgs(argsPtr);
                            browserProcessListener.OnFilterUrl(args);
                        }
                    }
                    break;
                case MyCefMsg.CEF_MSG_BinaryResouceProvider_OnRequest:
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
                case MyCefMsg.CEF_MSG_OnQuery:
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
                case MyCefMsg.CEF_MSG_ClientHandler_OnPreKeyEvent: //on PreKey
                    {
                        //Console.WriteLine("on pre key");
                        //NavigateTo("https://html5test.com");
                    }
                    break;
                //------------------------------
                case MyCefMsg.CEF_MSG_ClientHandler_NotifyTitle:
                    {
                        //title changed
                        var args = new NativeCallArgs(argsPtr);
                        string newtitle = args.GetArgAsString(0);
                        // Console.WriteLine("title changed:" + newtitle);
                    }
                    break;
                case MyCefMsg.CEF_MSG_ClientHandler_NotifyAddress:
                    {
                        //address changed
                        var args = new NativeCallArgs(argsPtr);
                        string newtitle = args.GetArgAsString(0);
                        // Console.WriteLine("address changed:" + newtitle);
                    }
                    break;
                //------------------------------
                case MyCefMsg.CEF_MSG_OSR_Render:
                    {
                        //receive rendere msg
                        var args = new NativeCallArgs(argsPtr);
                        //copy bits buffer and store to files  
                        if (cefOsrListener != null)
                        {
                            cefOsrListener.OnRender(args);
                        }

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
            if (IsBrowserCreated)
            {
                Cef3Binder.MyCefBwNavigateTo(this.myCefBrowser, url);
            }
        }
        public void ExecJavascript(string src, string scriptUrl)
        {
            Cef3Binder.MyCefBwExecJavascript(this.myCefBrowser, src, scriptUrl);
        }
        public void PostData(string url, byte[] data, int len)
        {
            Cef3Binder.MyCefBwPostData(this.myCefBrowser, url, data, len);
        }
        public void SetSize(int w, int h)
        {
            Cef3Binder.MyCefSetBrowserSize(this.myCefBrowser, w, h);
        }

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
        public void PrintToPdf(string filename)
        {
            Cef3Binder.MyCefPrintToPdf(this.myCefBrowser, filename);
        }
        internal void NotifyCloseBw()
        {
            this.Stop();
            Cef3Binder.MyCefCloseMyWebBrowser(myCefBrowser);
        }

        static Dictionary<IWindowForm, List<MyCefBrowser>> registerTopWindowForms =
                   new Dictionary<IWindowForm, List<MyCefBrowser>>();
        static readonly object sync_remove = new object();
        static void RegisterCefWbControl(MyCefBrowser cefWb)
        {
            // get top level of this cef browser control

            var ownerForm = (IWindowForm)cefWb.ParentControl.GetTopLevelControl();
            List<MyCefBrowser> foundList;
            if (!registerTopWindowForms.TryGetValue(ownerForm, out foundList))
            {
                foundList = new List<MyCefBrowser>();
                registerTopWindowForms.Add(ownerForm, foundList);
            }
            if (!foundList.Contains(cefWb))
            {
                foundList.Add(cefWb);
                cefWb.BrowserDisposed += new EventHandler(cefBrowserControl_Disposed);
            }
        }

        public static void DisposeAllChildWebBrowserControls(IWindowForm ownerForm)
        {

            //dispose all web browser (child) windows inside this window form             
            List<MyCefBrowser> foundList;
            if (registerTopWindowForms.TryGetValue(ownerForm, out foundList))
            {
                //remove webbrowser controls             
                for (int i = foundList.Count - 1; i >= 0; --i)
                {
                    MyCefBrowser mycefBw = foundList[i];
                    IWindowControl wb = mycefBw.ParentControl;
                    mycefBw.NotifyCloseBw();
                    //---------------------------------------
                    var parent = wb.GetParent();
                    parent.RemoveChild(wb);

                    //this Dispose() will terminate cef_life_time_handle *** 
                    //after native side dispose the wb control
                    //it will raise event BrowserDisposed
                    wb.Dispose();

                    //---------------------------------------
                }
                registerTopWindowForms.Remove(ownerForm);
            }
        }
        static void cefBrowserControl_Disposed(object sender, EventArgs e)
        {
            //web browser control is disposed 
            //TODO: review here 
            MyCefBrowser wb = sender as MyCefBrowser;
            if (wb != null)
            {
                IWindowForm winHandle = wb.ParentForm;
                List<MyCefBrowser> wblist;
                if (registerTopWindowForms.TryGetValue(winHandle, out wblist))
                {
                    lock (sync_remove)
                    {
                        wblist.Remove(wb);
                    }
                }
            }
            else
            {
                throw new NotSupportedException();
            }

        }
        public static bool IsReadyToClose(IWindowForm winForm)
        {
            //ready-to-close winform 
            lock (sync_remove)
            {
                List<MyCefBrowser> cefBrowserList;
                if (registerTopWindowForms.TryGetValue(winForm, out cefBrowserList))
                {
                    return cefBrowserList.Count == 0;
                }
                return true;
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