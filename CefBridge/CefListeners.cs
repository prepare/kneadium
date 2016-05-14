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
    public abstract class CefUIProcessListener
    {
        public virtual void OnFilterUrl(NativeCallArgs args)
        {

            //string reqUrl = args.GetArgAsString(0);
            //if (reqUrl.StartsWith("http://localhost/index2"))
            //{
            //    //eg. how to fix request url

            //    args.SetOutput(0, 1);
            //    //return url-in ascii form 
            //    var utf8Buffer = Encoding.ASCII.GetBytes("http://localhost/index2.html");
            //    args.SetOutput(1, utf8Buffer);
            //}
        }
        public virtual void OnAddResourceMx(NativeResourceMx nativeResourceMx)
        {
            //var resProvider = new ResourceProvider();
            //nativeResourceMx.AddResourceProvider(resProvider);
        }
        public virtual void OnRequestForBinaryResource(NativeCallArgs args)
        {

            //string url = args.GetArgAsString(0);
            //if (url == "http://localhost/hello_img" && File.Exists("prepare.jpg"))
            //{
            //    //load sample image and the send to client
            //    byte[] img = File.ReadAllBytes("prepare.jpg");
            //    int imgLen = img.Length;
            //    IntPtr unmanagedPtr = Marshal.AllocHGlobal(imgLen);
            //    Marshal.Copy(img, 0, unmanagedPtr, imgLen);

            //    args.SetOutput(0, 1);
            //    args.UnsafeSetOutput(1, unmanagedPtr, imgLen);
            //    args.SetOutputAsAsciiString(2, "image/jpeg");
            //}

        }
        public virtual void OnCefQuery(NativeCallArgs args, QueryRequestArgs reqArgs)
        {
            //string frameUrl = reqArgs.GetFrameUrl();
            //string getRequest = reqArgs.GetRequest();
            //string result = "hello!";

            //byte[] resultBuffer = Encoding.UTF8.GetBytes(result);
            //args.SetOutput(0, resultBuffer);

        }
        public virtual void OnConsoleLog(NativeCallArgs args)
        {
            //string msg = args.GetArgAsString(0);
            //string src = args.GetArgAsString(1);
            //string location = args.GetArgAsString(2);
            //Console.WriteLine(msg);
        }

    }

    /// <summary>
    /// listener for render process
    /// </summary>
    public abstract class CefRenderProcessListener
    {
        public virtual void OnWebKitInitialized(NativeCallArgs nativeCallArgs)
        {
        }
        public virtual void OnContextCreated(MyCefContextArgs args)
        {
        }
        public virtual void OnContextReleased(MyCefContextArgs args)
        {
        }
        public virtual void OnConsoleLog(NativeCallArgs args)
        {
            ////console msg in render process
            //string msg = args.GetArgAsString(0);
            //string src = args.GetArgAsString(1);
            //string location = args.GetArgAsString(2);
            //Console.WriteLine(msg);
        }


    }

    public class MyCefContextArgs
    {
        public readonly NativeRendererApp clientRenderApp;
        public readonly NativeBrowser browser;
        public readonly NativeFrame nativeFrame;
        public readonly NativeJsContext context;

        public MyCefContextArgs(NativeCallArgs args)
        {

            clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(0));
            browser = new NativeBrowser(args.GetArgAsNativePtr(1));
            nativeFrame = new NativeFrame(args.GetArgAsNativePtr(2));
            context = new NativeJsContext(args.GetArgAsNativePtr(3));
        }
    }


}