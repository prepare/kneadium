//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{
    public struct CefPoint
    {
        IntPtr nativePtr;
        public CefPoint(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefRect { }
    public struct CefPdfPrintSettings { }
    public struct CefPdfPrintCallback { }
    public struct CefWindowInfo { }
    public struct CefBrowserSettings { }
    public struct CefKeyEvent { }
    public struct CefMouseEvent { }
    public struct CefCompositionUnderline { }
    public struct CefRange { }
    public struct SwitchMap { }
    public struct ArgumentList { }
    public struct CefCompletionCallback { }
    public struct CefCookie { }
    public struct CefSetCookieCallback { }
    public struct CefDeleteCookiesCallback { }
    public struct AttributeMap { }
    public struct CefTime { }
}