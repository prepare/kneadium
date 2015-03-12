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

            managedCallback = new AgentManagedCallback(this.OnNativePartCallBack);
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


        void OnNativePartCallBack(int id, IntPtr callBackArgs)
        {
            NativeArgs nativeArgs = new NativeArgs(callBackArgs);
            string requestURL = nativeArgs.GetInputString();
            nativeArgs.SetOutputString(@"<http><body>Hello!</body></http>");

        }
    }
    public struct NativeArgs
    {
        IntPtr argPtr;
        public NativeArgs(IntPtr argPtr)
        {
            this.argPtr = argPtr;
        }
        public string GetInputString()
        {
            char[] resultBuffer = new char[1024];
            int resultLen;
            unsafe
            {
                fixed (char* h = &resultBuffer[0])
                {
                    Cef3Binder.CefCallbackArgsGetInputString(this.argPtr, h, out resultLen);
                }
            }
            return new string(resultBuffer, 0, resultLen);
        }
        public void SetOutputString(string str)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(str.ToCharArray());
            unsafe
            {
                fixed (byte* b = &buffer[0])
                {
                    Cef3Binder.CefCallbackArgsSetOutputString(this.argPtr, b, buffer.Length);
                }
            }
        }
    }
}