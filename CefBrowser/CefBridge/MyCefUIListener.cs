//MIT, 2016-2017, WinterDev

using System;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{
    class MyCefUIProcessListener : CefUIProcessListener
    {
        public override void OnFilterUrl(NativeCallArgs args)
        {
            string reqUrl = args.GetArgAsString(1);
            if (reqUrl.StartsWith("http://localhost/index2"))
            {
                //eg. how to fix request url

                args.SetOutput(0, 1);
                //return url-in ascii form 
                var utf8Buffer = Encoding.ASCII.GetBytes("http://localhost/index2.html");
                args.SetOutput(2, utf8Buffer);
            }
        }
        public override void OnAddResourceMx(NativeResourceMx nativeResourceMx)
        {
            var resProvider = new ResourceProvider();
            nativeResourceMx.AddResourceProvider(resProvider);
        }
        public override void OnRequestForBinaryResource(NativeCallArgs args)
        {
            //0: bool , return value
            //1: [in] url
            //2: [in] request
            //3: [out] buffer stream
            //4: [out] stream kind
            string url = args.GetArgAsString(1);
            if (url == "http://localhost/hello_img" && File.Exists("prepare.jpg"))
            {
                //load sample image and the send to client
                byte[] img = File.ReadAllBytes("prepare.jpg");
                int imgLen = img.Length;
                //img data will be used on native side
                //so lets create a space on native side
                //and let it destroy on native side

                //or we can let native side to load the file
                //  
                args.SetOutput(0, 1);// return true to notify that this is handled
                args.CopyBufferToBufferHolder(3, img);
                args.SetOutputAsAsciiString(4, "image/jpeg");
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
            //string frameUrl = reqArgs.GetFrameUrl();
            //string getRequest = reqArgs.GetRequest();
            //string result = "hello!";
            //byte[] resultBuffer = Encoding.UTF8.GetBytes(result);
            //args.SetOutput(0, resultBuffer);
        }
        public override void OnConsoleLog(NativeCallArgs args)
        {
            string msg = args.GetArgAsString(1);
            string src = args.GetArgAsString(2);
            string location = args.GetArgAsString(3);
            Console.WriteLine(msg);
        }
        public override void OnDownloadCompleted(NativeCallArgs args)
        {
            string downloadFullPath = args.GetArgAsString(3);
            Console.WriteLine("download complete :" + downloadFullPath);
        }
    }
}