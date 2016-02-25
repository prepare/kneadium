//2015-2016 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;


namespace LayoutFarm.CefBridge
{

    /// <summary>
    /// listener for browser process
    /// </summary>
    public class MyCefBrowserListener
    {
        public virtual void OnFilterUrl(NativeCallArgs args)
        {

            string reqUrl = args.GetArgAsString(0);
            if (reqUrl.StartsWith("http://localhost/index2"))
            {
                //eg. how to fix request url

                args.SetOutput(0, 1);
                //return url-in ascii form 
                var utf8Buffer = Encoding.ASCII.GetBytes("http://localhost/index2.html");
                args.SetOutput(1, utf8Buffer);
            }
        }
        public virtual void OnAddResourceMx(NativeResourceMx nativeResourceMx)
        {
            var resProvider = new ResourceProvider();
            nativeResourceMx.AddResourceProvider(resProvider);
        }
        public virtual void OnRequestForBinaryResource(NativeCallArgs args)
        {

            string url = args.GetArgAsString(0);
            if (url == "http://localhost/hello_img" && File.Exists("prepare.jpg"))
            {
                //load sample image and the send to client
                byte[] img = File.ReadAllBytes("prepare.jpg");
                int imgLen = img.Length;
                IntPtr unmanagedPtr = Marshal.AllocHGlobal(imgLen);
                Marshal.Copy(img, 0, unmanagedPtr, imgLen);

                args.SetOutput(0, 1);
                args.UnsafeSetOutput(1, unmanagedPtr, imgLen);
                args.SetOutputAsAsciiString(2, "image/jpeg");
            }

        }
        public virtual void OnCefQuery(NativeCallArgs args, QueryRequestArgs reqArgs)
        {
            string frameUrl = reqArgs.GetFrameUrl();
            string getRequest = reqArgs.GetRequest();
            string result = "hello!";

            byte[] resultBuffer = Encoding.UTF8.GetBytes(result);
            args.SetOutput(0, resultBuffer);


        }
        public virtual void OnConsoleLog(NativeCallArgs args)
        {
            string msg = args.GetArgAsString(0);
            string src = args.GetArgAsString(1);
            string location = args.GetArgAsString(2);
            Console.WriteLine(msg);
        }

    }

    /// <summary>
    /// listener for render process
    /// </summary>
    public class MyCefRenderListener
    {
        public virtual void OnCreateContext(NativeCallArgs args)
        {
#if DEBUG
            //if you want to stop on RenderProcess
            //if (Cef3Binder.s_dbugIsRendererProcess)
            //{
            //    System.Diagnostics.Debugger.Break();
            //}
#endif


            RenderProcessOnContextCreated(args);
        }
        public virtual void OnConsoleLog(NativeCallArgs args)
        {
            string msg = args.GetArgAsString(0);
            string src = args.GetArgAsString(1);
            string location = args.GetArgAsString(2);
            Console.WriteLine(msg);

        }
        void RenderProcessOnContextCreated(NativeCallArgs args)
        {
            //sample !!!
            //test function on render process

            var clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(0));
            var browser = new NativeBrowser(args.GetArgAsNativePtr(1));
            var context = new NativeJsContext(args.GetArgAsNativePtr(2));


            CefV8Value cefV8Global = context.GetGlobal();
            Cef3FuncHandler funcHandler = Cef3FuncHandler.CreateFuncHandler(Test001);
            Cef3Func func = Cef3Func.CreateFunc("test001", funcHandler);
            cefV8Global.Set("test001", func);
        }

        void Test001(int id, IntPtr argsPtr)
        {

#if DEBUG
            if (Cef3Binder.s_dbugIsRendererProcess)
            {
                System.Diagnostics.Debugger.Break();
            }
#endif
            var nativeCallArgs = new NativeCallArgs(argsPtr);
            nativeCallArgs.SetOutput(0, "hello from managed side !");

        }
    }



}