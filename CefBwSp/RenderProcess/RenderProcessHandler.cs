//MIT, 2016-2017, WinterDev

using System;
using System.Collections.Generic;
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

        List<MyCefCallback> _cefCallbackKeeper = new List<MyCefCallback>();

        public void OnContextCreated(CefRenderProcessHandler.OnContextCreatedArgs args)
        {

            //-----------------------
            //this is TEST CODE
            //-----------------------


            //eg  "<html><head><script>function docload(){ console.log(test001()); console.log(test_myobj.myprop);console.log(test_myobj[12345]);}</script><body onload=\"docload()\"><h1>hello!</h1></body></html>"

            dbugRenderProcessLog.WriteLine("context_created1");
            CefV8Context context = args.context();

            dbugRenderProcessLog.WriteLine("context_cx1");
            //global => window object
            CefV8Value cefV8Global = context.GetGlobal();

            //
            Auto.CefV8Handler funcHandler = new Auto.CefV8Handler(Cef3Binder.MyCefJs_New_V8Handler(Test002));
            CefV8Value func = Auto.CefV8Value.CreateFunction("test001", funcHandler);
            cefV8Global.SetValue("test001", func, cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_READONLY);
            //------- 

            dbugRenderProcessLog.WriteLine("context_cx2");


            dbugRenderProcessLog.WriteLine("context_cx3");
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


                if ((id >> 16) != CefV8Interceptor._typeNAME) return;
                //--------------------------
                int met_id = id & 0xffff;
                switch (met_id)
                {
                    case CefV8Interceptor.MyCefV8Interceptor_Get_1:
                        {
                            //by name
                            CefV8Interceptor.get_bynameArgs arg = new CefV8Interceptor.get_bynameArgs(argPtr);
                            arg.retval(CefV8Value.CreateString("hello! from intercepter" + arg.name()).nativePtr);
                        }
                        break;
                    case CefV8Interceptor.MyCefV8Interceptor_Get_2:
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
            //------ 

            //--------------

            //-------
            //TEST 1: raw, low level interface
            //-------
            IntPtr ret = IntPtr.Zero;
            IntPtr exception = IntPtr.Zero;
            //string jscode = "(function(){ return function (){return 1.25;}})()";
            string jscode = "(function(){ return function (){ console.log('hello-eval1'); return 1.25;}})()";
            if (context.Eval(jscode, "", 1, ref ret, ref exception))
            {
                dbugRenderProcessLog.WriteLine("eval success");
            }
            else
            {
                dbugRenderProcessLog.WriteLine("eval fail");
            }
            //
            using (CefV8Value cefv8_ret = new CefV8Value(ret))
            using (CefV8Value cefv8_excep = new CefV8Value(exception))
            {
                if (cefv8_ret.IsFunction())
                {
                    CefV8Value obj1 = new CefV8Value(); //empty 
                    CefV8ValueList args1 = CefV8ValueList.NewList();
                    CefV8Value innerFuncResult = cefv8_ret.ExecuteFunction(obj1, args1);
                    Cef3Binder.MyCefDeletePtr(args1.nativePtr);


                    double innerDouble = innerFuncResult.GetDoubleValue();

                }
                else
                {
                    double v8ret_double = cefv8_ret.GetDoubleValue();
                }
            }


            //low-level example, TODO: make this to O-O style
            //------
            var myfunc2 = MyJsFunc<double>.Create(context,
                "function(a00){ console.log(a00);}");
            myfunc2.Invoke(101);
            //------
            var myfunc3 = MyJsFunc<string>.Create(context,
                "function(a00){ console.log(a00);}");

            myfunc3.Invoke("HELLOO!");
            //------
            //
            var myfunc4 = MyJsFunc<double, string>.Create(context,
               "function(a00,a02){ console.log(a00); console.log(a02);}");
            myfunc4.Invoke(101, "hello_myfunc4");
            //------
            var myfunc5 = MyJsFunc<string, string>.Create(context,
               "function(a00,a02){ console.log(a00); console.log(a02);}");
            myfunc5.Invoke("HELLOO!", "hello_myfunc5");
            //------
            var myfunc6 = MyJsFunc.Create(context,
               "function(){ document.title='hello1'; document.write('0'); return document; }");
            var doc = myfunc6.Invoke();
            CefV8Value docTitle = doc.GetValue("title");
            string docTitleAsString = docTitle.GetStringValue();
            CefV8Value docBody = doc.GetValue("body");
            if (!docBody.IsNull())
            {
                //get innerHTML property
                CefV8Value innerHtmlProp = docBody.GetValue("innerHTML");
                if (innerHtmlProp.IsString())
                {

                }
                //set innerHTML property
                docBody.SetValue("innerHTML", CefV8Value.CreateString("A_Z"), cef_v8_propertyattribute_t.V8_PROPERTY_ATTRIBUTE_NONE);
            }

            CefV8Value docWrite = doc.GetValue("write");
            if (docWrite.IsFunction()) //try getting 'write' method of the document object
            {
                CefV8ValueList writeArgs = CefV8ValueList.NewList();
                writeArgs.AddElement(CefV8Value.CreateString("Hello_FROM_WRITE"));
                docWrite.ExecuteFunction(doc, writeArgs);
                Cef3Binder.MyCefDeletePtr(writeArgs.nativePtr);
            }
            //------ 
            //if we write() all 
            //we need to get doc again
            doc = myfunc6.Invoke();
            cefV8Global = context.GetGlobal();

            //low-level example, TODO: make this to O-O style
            CefV8Value cefGlobal_addEventListener = cefV8Global.GetValue("addEventListener");
            if (cefGlobal_addEventListener.IsFunction())
            {
                MyCefCallback cefWindowOnLoad = (id, argsPtr) =>
                {
                    //arg as mouse event args
                    CefV8Handler.ExecuteArgs args2 = new CefV8Handler.ExecuteArgs(argsPtr);
                    CefV8ValueList argumentList = args2.arguments();
                    int argCount = argumentList.GetListCount();
                };
                _cefCallbackKeeper.Add(cefWindowOnLoad);
                var v8Handler = new CefV8Handler(Cef3Binder.MyCefJs_New_V8Handler(cefWindowOnLoad));
                CefV8ValueList handleArgs = CefV8ValueList.NewList();
                //"load"
                handleArgs.AddElement(CefV8Value.CreateString("load"));
                CefV8Value v8Loadhandler = CefV8Value.CreateFunction("mydocload", v8Handler);
                //"eventHandler"
                handleArgs.AddElement(v8Loadhandler);
                cefGlobal_addEventListener.ExecuteFunction(cefV8Global, handleArgs);
                Cef3Binder.MyCefDeletePtr(handleArgs.nativePtr);
            }
            //------ 
            //low-level example, TODO: make this to O-O style
            CefV8Value doc_addEventListener = doc.GetValue("addEventListener");
            if (doc_addEventListener.IsFunction())
            {
                MyCefCallback mouseDownCallback = (id, argsPtr) =>
                {
                    //arg as mouse event args
                    CefV8Handler.ExecuteArgs args2 = new CefV8Handler.ExecuteArgs(argsPtr);
                    CefV8ValueList argumentList = args2.arguments();
                    int argCount = argumentList.GetListCount();
                    CefV8Value v8arg = argumentList.GetElement(0);
                    //get button propery
                    CefV8Value v8button = v8arg.GetValue("button");
                    if (v8button.IsInt())
                    {
                        int button = v8button.GetIntValue();
                    }
                };
                _cefCallbackKeeper.Add(mouseDownCallback);
                var v8Handler = new CefV8Handler(Cef3Binder.MyCefJs_New_V8Handler(mouseDownCallback));
                CefV8ValueList handleArgs = CefV8ValueList.NewList();
                //"load"
                handleArgs.AddElement(CefV8Value.CreateString("mousedown"));
                CefV8Value v8Loadhandler = CefV8Value.CreateFunction("mycallback", v8Handler);
                //"eventHandler"
                handleArgs.AddElement(v8Loadhandler);
                cefGlobal_addEventListener.ExecuteFunction(doc, handleArgs);
                Cef3Binder.MyCefDeletePtr(handleArgs.nativePtr);
            }




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

            dbugRenderProcessLog.WriteLine("webkit_init" + DateTime.Now.ToString());
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
            CefBinder2.RegisterCefExtension("v8/test", extensionCode, IntPtr.Zero);
            dbugRenderProcessLog.WriteLine("register pass!");
        }
    }

    //tmp for debug only
    static class dbugRenderProcessLog
    {
        public static void WriteLine(string log)
        {
            File.AppendAllText("d:\\WImageTest\\render_process_msg.txt", log + "\r\n");
        }
    }



}