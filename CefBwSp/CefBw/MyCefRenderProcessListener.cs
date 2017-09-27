//MIT, 2016-2017, WinterDev

using System;

namespace LayoutFarm.CefBridge
{
    class SubProcessClientApp : CefClientApp
    {
        CefRenderProcessListener renderProcessListener;
        public SubProcessClientApp(IntPtr processHandle,
            CefRenderProcessListener renderProcessListener)
            : base(processHandle)
        {
            this.renderProcessListener = renderProcessListener;

        }
        protected override MyCefCallback GetManagedCallbackImpl()
        {
            return HandleNativeReq;
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
                case MyCefMsg.CEF_MSG_ClientHandler_ShowDevTools:
                    {

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


    }

    class MyCefRendererProcessListener : CefRenderProcessListener
    {
        public override void OnWebKitInitialized(NativeCallArgs nativeCallArgs)
        {
            //sample!!!
            string extensionCode =
                      "var test;" +
                       "if (!test)" +
                       "  test = {};" +
                       "(function() {" +
                       "  test.myfunc = function() {" +
                          "return 2;" +
                       //"    native function myfunc();" +
                       //"    return myfunc();" +
                       "  };" +
                       "})();";
            //test regsiter extension
            CefBinder2.RegisterCefExtension("v8/test", extensionCode);
        }
        public override void OnContextCreated(MyCefContextArgs args)
        {
            //sample !!!
            //call window.test001() from js 
            CefV8Value cefV8Global = args.context.GetGlobal();
            Cef3FuncHandler funcHandler = Cef3FuncHandler.CreateFuncHandler(Test001);
            Cef3Func func = Cef3Func.CreateFunc("test001", funcHandler);
            cefV8Global.Set("test001", func);
        }

        void Test001(int id, IntPtr argsPtr)
        {
#if DEBUG
            //if (Cef3Binder.s_dbugIsRendererProcess)
            //{
            //    System.Diagnostics.Debugger.Break();
            //}
#endif
            var nativeCallArgs = new NativeCallArgs(argsPtr);
            nativeCallArgs.SetOutput(0, "hello from managed side !");
        }
    }
}