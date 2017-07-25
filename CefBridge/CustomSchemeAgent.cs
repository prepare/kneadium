//MIT, 2015-2017, WinterDev

using System;
namespace LayoutFarm.CefBridge
{
    public struct CefSchemeRegistrar
    {
        IntPtr nativePtr;
        internal CefSchemeRegistrar(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void AddCustomScheme(
            string scheme_name,
            bool is_standard,
            bool is_local,
            bool is_display_isolated)
        {
            //call to native 

        }
    }

    public class CustomSchemeAgent
    {
        string schemeName;
        public CustomSchemeAgent(string schemeName)
        {
            this.schemeName = schemeName;
        }
        public string SchemeName
        {
            get { return this.schemeName; }
        }
    }



    public class CefSchemeHandler
    {
        internal IntPtr nativePtr;
        internal CefSchemeHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public class CefSchemeFactory
    {
        internal IntPtr nativePtr;
        internal CefSchemeFactory(IntPtr cefReqPtr)
        {
            this.nativePtr = cefReqPtr;
        }
    }

    public struct CefRequest
    {
        internal  IntPtr nativePtr;
        internal CefRequest(IntPtr cefReqPtr)
        {
            this.nativePtr = cefReqPtr;
        }
        public string Url
        {
            get
            {
                //get url from specific 

                return "";
            }
        }
    }
}