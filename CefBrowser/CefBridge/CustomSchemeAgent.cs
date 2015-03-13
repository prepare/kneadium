//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{

    public class CustomSchemeAgent
    {
        string schemeName;
        public CustomSchemeAgent(string schemeName)
        {
            this.schemeName = schemeName;
        }
    }
    public class CefSchemeHandler
    {

    }
    public class CefSchemeFactory
    {

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