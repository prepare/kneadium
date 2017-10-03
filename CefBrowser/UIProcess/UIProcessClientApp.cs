//MIT, 2015-2017, WinterDev


namespace LayoutFarm.CefBridge
{

    public class UIProcessCefClientApp : CefClientApp
    {

        public UIProcessCefClientApp(
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
                //case MyCefMsg.CEF_MSG_ClientHandler_ShowDevTools:
                //    {
                //        //show dev tools
                //        //Cef3Binder.SafeUIInvoke(() =>
                //        //{
                //        //    //IWindowForm newPopupForm = Cef3Binder.CreateNewBrowserWindow(800, 600);
                //        //    //newPopupForm.Show();
                //        //});
                //    }
                //    break;
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
                    //case MyCefMsg.CEF_MSG_RenderDelegate_OnContextCreated:
                    //    {
                    //        //client app callback
                    //        //eg. from RenderClientApp
                    //        //in render process ***
                    //        //we can register external methods  for window object here.
                    //        //NativeMethods.MessageBox(IntPtr.Zero, id.ToString(), "NN2", 0);

                    //        //if (renderProcessListener != null)
                    //        //{
                    //        //    renderProcessListener.OnContextCreated(
                    //        //        new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                    //        //}
                    //    }
                    //    break;
                    //case MyCefMsg.CEF_MSG_RenderDelegate_OnContextReleased:
                    //    {
                    //        //if (renderProcessListener != null)
                    //        //{
                    //        //    renderProcessListener.OnContextReleased(
                    //        //        new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                    //        //}
                    //    }
                    //    break;
                    //case MyCefMsg.CEF_MSG_RenderDelegate_OnWebKitInitialized:
                    //    {
                    //        //    if (renderProcessListener != null)
                    //        //    {
                    //        //        NativeCallArgs args = new NativeCallArgs(argsPtr);
                    //        //        renderProcessListener.OnWebKitInitialized(args);
                    //        //    }
                    //    }
                    //    break;
            }
        }

    }
}