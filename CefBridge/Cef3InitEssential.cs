//2015-2016 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{
    public abstract class Cef3InitEssential
    {

        internal readonly string[] startArgs;
        public Cef3InitEssential(string[] startArgs)
        {
            this.startArgs = startArgs;
        }
        public abstract void AfterProcessLoaded(CefStartArgs args);
        public abstract CefClientApp CreateClientApp();
        public abstract IWindowForm CreateNewWindow(int width, int height);
        public abstract IWindowForm CreateNewBrowserWindow(int width, int height);
        public abstract void SaveUIInvoke(SimpleDel simpleDel);

        public void Shutdown()
        {
            OnBeforeShutdown();
            Cef3Binder.MyCefShutDown();
            OnAfterShutdown();
        }
        protected virtual void OnBeforeShutdown()
        {

        }
        protected virtual void OnAfterShutdown()
        {
        }
        public abstract IntPtr SetupPreRun();
        /// <summary>
        /// load and init cef library
        /// </summary>
        public virtual bool Init()
        {
            bool loadResult = Cef3Binder.LoadCef3(this);
            if (!loadResult)
            {
                return false;
            }

            return true;
        }

        protected static void DoMessageLoopWork()
        {
            Cef3Binder.MyCefDoMessageLoopWork();
        }

        public abstract void AddLogMessage(string msg);

       
        /// <summary>
        /// libcef.dll (original)
        /// </summary>
        /// <returns></returns>         
        public abstract string GetLibCefFileName();
        /// <summary>
        /// cefclient.dll (wrapper)
        /// </summary>
        /// <returns></returns>
        public abstract string GetCefClientFileName();

       

        public static bool IsInRenderProcess
        {
            get;
            internal set;
        }
        
    }


}