//2016, MIT, WinterDev

using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
//
using LayoutFarm.CefBridge;
namespace LayoutFarm.CefBridge
{
    class MyCefUIProcessListener : CefUIProcessListener
    {
        public override void OnFilterUrl(NativeCallArgs args)
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
        public override void OnAddResourceMx(NativeResourceMx nativeResourceMx)
        {
            var resProvider = new ResourceProvider();
            nativeResourceMx.AddResourceProvider(resProvider);
        }
        public override void OnRequestForBinaryResource(NativeCallArgs args)
        {
            string url = args.GetArgAsString(0);
            if (url == "http://localhost/hello_img" && File.Exists("prepare.jpg"))
            {
                //load sample image and the send to client
                byte[] img = File.ReadAllBytes("prepare.jpg");
                int imgLen = img.Length;
                //TODO: review here, who will destroy this mem
                IntPtr unmanagedPtr = Marshal.AllocHGlobal(imgLen);
                Marshal.Copy(img, 0, unmanagedPtr, imgLen);
                args.SetOutput(0, 1);
                args.UnsafeSetOutput(1, unmanagedPtr, imgLen);
                args.SetOutputAsAsciiString(2, "image/jpeg");
            }
            else
            {
                //intercept any request
                //args.SetOutput(0, 1);
                //args.SetOutputAsAsciiString(1, "OKOK!!!!");
                //args.SetOutputAsAsciiString(2, "text/plain");
            }
        }
        public override void OnCefQuery(NativeCallArgs args, QueryRequestArgs reqArgs)
        {
            string frameUrl = reqArgs.GetFrameUrl();
            string getRequest = reqArgs.GetRequest();
            string result = "hello!";
            byte[] resultBuffer = Encoding.UTF8.GetBytes(result);
            args.SetOutput(0, resultBuffer);
        }
        public override void OnConsoleLog(NativeCallArgs args)
        {
            string msg = args.GetArgAsString(0);
            string src = args.GetArgAsString(1);
            string location = args.GetArgAsString(2);
            Console.WriteLine(msg);
        }
        public override void OnDownloadCompleted(NativeCallArgs args)
        {
            string downloadFullPath = args.GetArgAsString(2);
            Console.WriteLine("download complete :" + downloadFullPath);
        }
    }
}