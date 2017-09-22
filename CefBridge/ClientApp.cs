//MIT, 2015-2017, WinterDev

using System;
namespace LayoutFarm.CefBridge
{
    public class CefClientApp
    {
        IntPtr clientAppPtr;
        static bool isInitWithProcessHandle;
        static readonly object sync_ = new object();
        MyCefCallback mxCallback;
        CefRenderProcessListener renderProcessListener;

        public CefClientApp(
            IntPtr processHandle,
            CefRenderProcessListener renderProcessListener)
        {
            this.renderProcessListener = renderProcessListener;
#if DEBUG
            //dev note: multiprocess debuging: renderer process debugger 
            //if you want to break in the renderer process
            //1. set break point after, MessageBox.Show();
            //2. call pop up message box
            //3. then, use Visual studio to find what process that own the pop up
            // ( Debug-> Attach To Process -> select process the own the pop up
            //4. select process id that is renderer process
            //5. push ok button on the pop msgbox , then debugger will break on the 
            //  break point after popup
            //if (Cef3Binder.s_dbugIsRendererProcess)
            //{
            //    System.Windows.Forms.MessageBox.Show("Renderer", "Renderer"); 
            //}
#endif

            lock (sync_)
            {
                //init once
                if (!isInitWithProcessHandle)
                {
                    isInitWithProcessHandle = true;
                    //1) register mx callback,
                    //call-back must be created first (before client app).
                    //
                    Cef3Binder.RegisterManagedCallBack(this.mxCallback = new MyCefCallback(HandleNativeReq), 3);
                    //2) create client app
                    //1 process have 1 client app instance.                                        
                    this.clientAppPtr = Cef3Binder.MyCefCreateClientApp(processHandle);
                    //the registered callback from previous step(1) was attached to the new client app.
                }
            }
        }
        /// <summary>
        /// handle native reqiest , this is called by native side.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="argsPtr"></param>
        void HandleNativeReq(int id, IntPtr argsPtr)
        {
            switch ((MyCefMsg)id)
            {
                default:

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
                case MyCefMsg.CEF_MSG_CefSettings_Init:
                    {
                        InitCefSettings(new CefSettings(argsPtr));
                    }
                    break;
                case MyCefMsg.CEF_MSG_MainContext_GetConsoleLogPath:
                    {

                        NativeCallArgs nat1 = new NativeCallArgs(argsPtr);
                        nat1.SetOutputAsAsciiString(0, ReferencePaths.LOG_PATH);
                    }
                    break;
                case MyCefMsg.CEF_MSG_OSR_Render:
                    {
                        //not visit here?

                    }
                    break;
                case MyCefMsg.CEF_MSG_RenderDelegate_OnContextCreated:
                    {
                        //client app callback
                        //eg. from RenderClientApp
                        //in render process ***
                        //we can register external methods  for window object here.
                        //NativeMethods.MessageBox(IntPtr.Zero, id.ToString(), "NN2", 0);

                        if (renderProcessListener != null)
                        {
                            renderProcessListener.OnContextCreated(
                                new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                        }
                    }
                    break;
                case MyCefMsg.CEF_MSG_RenderDelegate_OnContextReleased:
                    {
                        if (renderProcessListener != null)
                        {
                            renderProcessListener.OnContextReleased(
                                new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                        }
                    }
                    break;
                case MyCefMsg.CEF_MSG_RenderDelegate_OnWebKitInitialized:
                    {
                        if (renderProcessListener != null)
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            renderProcessListener.OnWebKitInitialized(args);
                        }
                    }
                    break;
            }
        }

        void InitCefSettings(CefSettings cefSettings)
        {
            if (ReferencePaths.SUB_PROCESS_PATH != null)
            {
                cefSettings.SetSubProcessPath(ReferencePaths.SUB_PROCESS_PATH);
            }
            cefSettings.SetCachePath(ReferencePaths.CACHE_PATH);
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