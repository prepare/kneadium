//MIT, 2015-2017, WinterDev


namespace LayoutFarm.CefBridge
{

    /// <summary>
    /// client app for UI process
    /// </summary>
    public class ClientAppBrowser : CefClientApp
    {

        public ClientAppBrowser(
          System.IntPtr processHandle)
            : base(processHandle)
        {

        }
        protected override MyCefCallback GetManagedCallbackImpl()
        {
            return new MyCefCallback(HandleNativeReq);
        }

        void InitCefSettings(CefSettings cefSettings)
        {
            if (ReferencePaths.SUB_PROCESS_PATH != null)
            {
                cefSettings.SetSubProcessPath(ReferencePaths.SUB_PROCESS_PATH);
            }
            cefSettings.SetCachePath(ReferencePaths.CACHE_PATH);
            cefSettings.IgnoreCertErrror(true);
        }
        /// <summary>
        /// handle native reqiest , this is called by native side.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="argsPtr"></param>
        void HandleNativeReq(int id, System.IntPtr argsPtr)
        {
            switch ((MyCefMsg)id)
            {
                default:
                    break;
                case MyCefMsg.CEF_AppExt_OnBeforeCommandLineProcessing:
                    {
                        //temp
                        //set/change proxy here
                        //if not set, chrome will use default setting on the machine...
                        //set more setting options at http://www.chromium.org/developers/design-documents/network-settings#TOC-Preference-service-for-network-settings
                        //var args = new Auto.CefApp.OnBeforeCommandLineProcessingArgs(argsPtr);
                        ////args.command_line().AppendSwitch("no-proxy-server");
                        //args.command_line().AppendSwitchWithValue("proxy-server", "169.254.14.165:8080");
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
            }
        }

    }
}