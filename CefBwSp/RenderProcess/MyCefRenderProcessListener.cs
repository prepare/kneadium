//MIT, 2016-2017, WinterDev

using System;
using System.IO;
using LayoutFarm.CefBridge.Auto;
namespace LayoutFarm.CefBridge
{
    class RenderProcessHandler : CefRenderProcessHandler.I0
    {

        public void GetLoadHandler(CefRenderProcessHandler.GetLoadHandlerArgs args)
        {

        }
        public void OnBeforeNavigation(CefRenderProcessHandler.OnBeforeNavigationArgs args)
        {

        }

        public void OnBrowserCreated(CefRenderProcessHandler.OnBrowserCreatedArgs args)
        {

        }

        public void OnBrowserDestroyed(CefRenderProcessHandler.OnBrowserDestroyedArgs args)
        {

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
            nativeCallArgs.SetOutput(0, "hello from managed side3 !");
        }
        void Test002(int id, IntPtr argsPtr)
        {
#if DEBUG
            //if (Cef3Binder.s_dbugIsRendererProcess)
            //{
            //    System.Diagnostics.Debugger.Break();
            //}
#endif
            Auto.CefV8Handler.ExecuteArgs ex = new CefV8Handler.ExecuteArgs(argsPtr);
            ex.retval((Auto.CefV8Value.CreateString("hello from managed side NEW3")).nativePtr);

        }
        //public void OnContextCreated2(MyCefContextArgs args)
        //{
        //    CefV8Value cefV8Global = args.context.GetGlobal();
        //    Cef3FuncHandler funcHandler = Cef3FuncHandler.CreateFuncHandler(Test001);
        //    Cef3Func func = Cef3Func.CreateFunc("test001", funcHandler);
        //    cefV8Global.Set("test001", func);
        //    dbugRenderProcessLog.WriteLine("register test001!");
        //}
        public void OnContextCreated(CefRenderProcessHandler.OnContextCreatedArgs args)
        {

            dbugRenderProcessLog.WriteLine("context_created");
            CefV8Context context = args.context();
            Auto.CefV8Value cefV8Global = context.GetGlobal();

            Auto.CefV8Handler funcHandler = new Auto.CefV8Handler(Cef3Binder.MyCefJs_New_V8Handler2(Test002));
            var func = Auto.CefV8Value.CreateFunction("test001", funcHandler);
            cefV8Global.SetValue("test001", func, cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_READONLY); 

            dbugRenderProcessLog.WriteLine("context_created-pass");
        }
        public void OnContextReleased(CefRenderProcessHandler.OnContextReleasedArgs args)
        {
        }

        public void OnFocusedNodeChanged(CefRenderProcessHandler.OnFocusedNodeChangedArgs args)
        {

        }

        public void OnProcessMessageReceived(CefRenderProcessHandler.OnProcessMessageReceivedArgs args)
        {

        }

        public void OnRenderThreadCreated(CefRenderProcessHandler.OnRenderThreadCreatedArgs args)
        {
        }
        public void OnUncaughtException(CefRenderProcessHandler.OnUncaughtExceptionArgs args)
        {

        }
        public void OnWebKitInitialized(CefRenderProcessHandler.OnWebKitInitializedArgs args)
        {

            dbugRenderProcessLog.WriteLine("webkit_init");
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
            dbugRenderProcessLog.WriteLine("register pass!");
        }
    }

    //tmp for debug only
    static class dbugRenderProcessLog
    {
        public static void WriteLine(string log)
        {
            // File.AppendAllText("d:\\WImageTest\\render_process_msg.txt", log + "\r\n");
        }
    }


    class SubProcessClientApp : CefClientApp
    {
        RenderProcessHandler renderProcessHandler;
        //CefRenderProcessListener renderProcessListener;

        public SubProcessClientApp(IntPtr processHandle,
            CefRenderProcessListener renderProcessListener)
            : base(processHandle)
        {
            //this.renderProcessListener = renderProcessListener;

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

        void HandleNativeReq(int met_id, IntPtr argsPtr)
        {
            if (renderProcessHandler == null)
            {
                //check if the render process handler is create or not
                //this method is called from native side
                //must check here!
                renderProcessHandler = new RenderProcessHandler();
            }

            //main raw msg switch table              
            if ((met_id >> 16) > 0)
            {
                //built in object 
                CefNativeRequestHandlers.HandleNativeReq_I0(renderProcessHandler, met_id, argsPtr);
                return;
            }

            //this is custom msg 
            dbugRenderProcessLog.WriteLine("custom_msg");
            switch ((MyCefMsg)met_id)
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

                        //if (renderProcessHandler != null)
                        //{
                        //    renderProcessHandler.OnContextCreated2(
                        //        new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                        //}
                        //if (renderProcessListener != null)
                        //{
                        //    renderProcessListener.OnContextCreated(
                        //        new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                        //}
                    }
                    break;
                case MyCefMsg.CEF_MSG_RenderDelegate_OnContextReleased:
                    {
                        //if (renderProcessListener != null)
                        //{
                        //    renderProcessListener.OnContextReleased(
                        //        new MyCefContextArgs(new NativeCallArgs(argsPtr)));
                        //}
                    }
                    break;
                case MyCefMsg.CEF_MSG_RenderDelegate_OnWebKitInitialized:
                    {
                        //if (renderProcessListener != null)
                        //{
                        //    NativeCallArgs args = new NativeCallArgs(argsPtr);
                        //    renderProcessListener.OnWebKitInitialized(args);
                        //}
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