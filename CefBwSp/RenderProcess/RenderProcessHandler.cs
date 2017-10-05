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

        void Test002(int id, IntPtr argsPtr)
        {
#if DEBUG
            //if (Cef3Binder.s_dbugIsRendererProcess)
            //{
            //    System.Diagnostics.Debugger.Break();
            //}
#endif
            Auto.CefV8Handler.ExecuteArgs ex = new CefV8Handler.ExecuteArgs(argsPtr);
          ex.retval((Auto.CefV8Value.CreateString("hello from managed side " + DateTime.Now)).nativePtr);

        }

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



}