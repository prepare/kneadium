//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

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
        IntPtr ptr;
        internal CefSchemeHandler()
        {

        }

    }

    public class CefSchemeFactory
    {
        IntPtr nativeSchemeFactory;
        internal CefSchemeFactory()
        {

        }

    }

    public struct CefRequest
    {
        IntPtr cefReqPtr;
        internal CefRequest(IntPtr cefReqPtr)
        {
            this.cefReqPtr = cefReqPtr;

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