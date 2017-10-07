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

            CefV8Handler.ExecuteArgs args = new CefV8Handler.ExecuteArgs(argsPtr);
            args.retval((Auto.CefV8Value.CreateString("hello from managed side " + DateTime.Now)).nativePtr);

        }

        public void OnContextCreated(CefRenderProcessHandler.OnContextCreatedArgs args)
        {

            //eg  "<html><head><script>function docload(){ console.log(test001());console.log(test_myobj[\"12345\"]); console.log(test_myobj.myprop);}</script><body onload=\"docload()\"><h1>hello!</h1></body></html>"

            dbugRenderProcessLog.WriteLine("context_created");
            CefV8Context context = args.context();
            Auto.CefV8Value cefV8Global = context.GetGlobal();

            Auto.CefV8Handler funcHandler = new Auto.CefV8Handler(Cef3Binder.MyCefJs_New_V8Handler2(Test002));
            var func = Auto.CefV8Value.CreateFunction("test001", funcHandler);
            cefV8Global.SetValue("test001", func, cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_READONLY);

            //create object

            CefV8Accessor accessor = CefV8Accessor.New((id, argPtr) =>
            {
                //similar to C# property
                CefV8Accessor.GetArgs arg = new CefV8Accessor.GetArgs(argPtr);
                arg.retval(CefV8Value.CreateString("hello! from accessor").nativePtr);
            });
            CefV8Interceptor intercepter = CefV8Interceptor.New((id, argPtr) =>
            {
                //similar to C# indexer 
                // 
                CefV8Interceptor.get_bynameArgs arg = new CefV8Interceptor.get_bynameArgs(argPtr);
                arg.retval(CefV8Value.CreateString("hello! from intercepter").nativePtr);
            });

            CefV8Value cef_object = CefV8Value.CreateObject(accessor, intercepter);
            //set to global object
            cefV8Global.SetValue("test_myobj", cef_object, cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_READONLY);
            

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