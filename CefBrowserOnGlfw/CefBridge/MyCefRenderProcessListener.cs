//2016, MIT, WinterDev

using System;
using System.Text;
 
 
namespace LayoutFarm.CefBridge
{
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