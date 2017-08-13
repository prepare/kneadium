//MIT, 2015-2017, WinterDev

using System;
namespace LayoutFarm.CefBridge
{
    public struct CefPrintHandler
    {
        internal IntPtr nativePtr;
        public CefPrintHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefAccessibilityHandler
    {

    }
    public struct CefLoadHandler
    {

    }
    public struct CefCursorInfo
    {
        internal IntPtr nativePtr;
        public CefCursorInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public struct CefPopupFeatures
    {
        internal IntPtr nativePtr;
        public CefPopupFeatures(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefResourceHandler
    {
        internal IntPtr nativePtr;
        public CefResourceHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct ReturnValue
    {
        internal IntPtr nativePtr;
        public ReturnValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefScreenInfo
    {
        internal IntPtr nativePtr;
        public CefScreenInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefPoint
    {
        internal IntPtr nativePtr;
        public CefPoint(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefRect
    {
        internal IntPtr nativePtr;
        public CefRect(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefSize
    {
        internal IntPtr nativePtr;
        public CefSize(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefPdfPrintSettings
    {
        internal IntPtr nativePtr;
        public CefPdfPrintSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public struct CefWindowInfo
    {
        internal IntPtr nativePtr;
        public CefWindowInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefBrowserSettings
    {
        internal IntPtr nativePtr;
        public CefBrowserSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefKeyEvent
    {
        internal IntPtr nativePtr;
        public CefKeyEvent(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefMouseEvent
    {
        internal IntPtr nativePtr;
        public CefMouseEvent(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefCompositionUnderline
    {
        internal IntPtr nativePtr;
        public CefCompositionUnderline(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefRange
    {
        internal IntPtr nativePtr;
        public CefRange(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct SwitchMap
    {
        internal IntPtr nativePtr;
        public SwitchMap(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct ArgumentList
    {
        internal IntPtr nativePtr;
    }
    public struct AttributeMap
    {
        internal IntPtr nativePtr;
    }
    public struct CefTime
    {
        IntPtr nativePtr;
        public CefTime(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefCookie
    {
        internal IntPtr nativePtr;
        public CefCookie(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct HeaderMap
    {
        internal IntPtr nativePtr;
    }
    //--------------
    public struct CefCompletionCallback
    {
        internal IntPtr nativePtr;
    }
    public struct CefSetCookieCallback
    {
        internal IntPtr nativePtr;
    }
    public struct CefDeleteCookiesCallback
    {
        internal IntPtr nativePtr;
    }
    public struct CefRunFileDialogCallback
    {
        internal IntPtr nativePtr;
    }
    public struct CefResolveCallback
    {
        internal IntPtr nativePtr;
    }
    public struct CefBaseRefCounted
    {
        internal IntPtr nativePtr;
        public CefBaseRefCounted(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefPdfPrintCallback
    {
        internal IntPtr nativePtr;
    }
    public struct CefDownloadImageCallback
    {
        internal IntPtr nativePtr;
    }
    public struct KeyList
    {
        internal IntPtr nativePtr;
    }
    public struct CefRequestContextHandler
    {
        internal IntPtr nativePtr;
        public CefRequestContextHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct IssuerChainBinaryList
    {
        internal IntPtr nativePtr;
    }
    public struct ElementVector
    {
        internal IntPtr nativePtr;
    }
    public struct PageRangeList
    {
        internal IntPtr nativePtr;
    }
    public struct cef_color_t
    {
        internal IntPtr nativePtr;
    }
    public struct CefV8Handler
    {
        internal IntPtr nativePtr;
        public CefV8Handler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefV8ValueList
    {
        internal IntPtr nativePtr;
        public CefV8ValueList(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public struct MyCefNativeMetArgs
    {
        internal IntPtr nativePtr;
        internal MyCefNativeMetArgs(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public int GetArgCount()
        {
            return Cef3Binder.MyMetArgGetCount(nativePtr);
        }
        public void GetArg(int index, out JsValue value)
        {
            unsafe
            {
                JsValue* jsvalue = (JsValue*)Cef3Binder.MyMetArgGetArgAddress(nativePtr, index);
                value = *jsvalue;
            }
        }
    }

    class CefNotImplementedException : NotImplementedException
    {

    }

}