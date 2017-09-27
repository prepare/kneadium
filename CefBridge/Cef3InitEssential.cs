//MIT, 2015-2017, WinterDev

using System;
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
        public abstract void SetupPreRun();
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
        public abstract string GetLibChromeElfFileName();

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
        public static bool IsInMainProcess
        {
            get;
            internal set;
        }
    }

    public struct CefSettings
    {
        IntPtr nativePtr;
        internal CefSettings(IntPtr nativePtr)
        {

            this.nativePtr = nativePtr;
        }
        public void SetSubProcessPath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_BrowserSubProcessPath, value);
        }
        public void SetCachePath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_CachePath, value);
        }
        public void SetUserDirPath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_UserDirPath, value);
        }
        public void SetLocalDirPath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_LocalDirPath, value);
        }
        public void IgnoreCertErrror(bool value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_IgnoreCertError, value ? "1" : "0");
        }
        public void SetRemoteDebuggingPort(int portNo)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_RemoteDebuggingPort, portNo.ToString());
        }
        public void SetLogSeverity(LayoutFarm.CefBridge.Auto.cef_log_severity_t logSeverity)
        {
            int severity = (int)logSeverity;
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
               CefSettingsKey.CEF_SETTINGS_LogSeverity, ((int)severity).ToString());
        }
    }
}