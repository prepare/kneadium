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

            //eg  "<html><head><script>function docload(){ console.log(test001()); console.log(test_myobj.myprop);console.log(test_myobj[12345]);}</script><body onload=\"docload()\"><h1>hello!</h1></body></html>"

            dbugRenderProcessLog.WriteLine("context_created");
            CefV8Context context = args.context();
            Auto.CefV8Value cefV8Global = context.GetGlobal();

            Auto.CefV8Handler funcHandler = new Auto.CefV8Handler(Cef3Binder.MyCefJs_New_V8Handler2(Test002));
            var func = Auto.CefV8Value.CreateFunction("test001", funcHandler);
            cefV8Global.SetValue("test001", func, cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_READONLY);

            CefV8Accessor accessor = CefV8Accessor.New((id, argPtr) =>
            {
                //--------------------------
                //this shows the unsafe and low-level interface to native.
                //you can use a 'higher' level wrapper.
                //--------------------------

                //from https://github.com/v8/v8/wiki/Embedder%27s-Guide
                //accessor callbacks are invoked when a specific object property is accessed by a script
                //Accessors
                //An accessor is a C++callback that calculates and returns a value when an object property is accessed by a JavaScript script.
                //Accessors are configured through an object template, using the SetAccessor method.
                //This method takes the name of the property with which it is associated and two callbacks to run when a script attempts to read or write the property.

                CefV8Accessor.GetArgs arg = new CefV8Accessor.GetArgs(argPtr);
                arg.retval(CefV8Value.CreateString("hello! from accessor").nativePtr);
                arg.myext_setRetValue(true);//finish the accessor!
            });

            CefV8Interceptor intercepter = CefV8Interceptor.New((id, argPtr) =>
            {
                //from https://github.com/v8/v8/wiki/Embedder%27s-Guide
                //interceptor callbacks are invoked when any object property is accessed by a script Accessors and interceptors are discussed later in this document. 
                //
                //                 
                //Interceptors    
                //  You can also specify a callback for whenever a script accesses any object property. These are called interceptors. For efficiency, there are two types of interceptors:
                //  named property interceptors - called when accessing properties with string names. An example of this, in a browser environment, is document.theFormName.elementName.
                //  indexed property interceptors - called when accessing indexed properties. An example of this, in a browser environment, is document.forms.elements[0].

                //--------------------------
                //this shows the unsafe and low-level interface to native.
                //you can use a 'higher' level wrapper.
                //--------------------------


                if ((id >> 16) != 41) return;
                //--------------------------
                int met_id = id & 0xffff;
                switch (met_id)
                {
                    case 1:
                        {
                            //by name
                            CefV8Interceptor.get_bynameArgs arg = new CefV8Interceptor.get_bynameArgs(argPtr);
                            arg.retval(CefV8Value.CreateString("hello! from intercepter" + arg.name()).nativePtr);
                        }
                        break;
                    case 2:
                        {
                            //by indexed property
                        }
                        break;
                }

            });

            //--------
            //The difference between accessors and interceptors is that interceptors handle all properties,
            //while accessors are associated with one specific property.
            //--------
            //
            CefV8Accessor empty = new CefV8Accessor();
            CefV8Interceptor empty_interceptor = new CefV8Interceptor();
            CefV8Value cef_object = CefV8Value.CreateObject(accessor, empty_interceptor);
            //if you want to use accessor, your must set it with SetValue() like this
            cef_object.SetValue("myprop", cef_v8_accesscontrol_t.V8_ACCESS_CONTROL_DEFAULT, cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_NONE);

            //
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