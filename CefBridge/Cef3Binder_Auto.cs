//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{

    public enum CefBwCallMsg
    {
        CefBw_GoBack = 1,
        CefBw_Reload = 2,
        CefBw_ReloadIgnoreCache = 3,
        CefBw_GetFrameCount = 4,
        CefBw_IsSame = 6,
        CefBw_GetFrameNames = 7,
        CefBw_GetFrameIdentifiers = 10,
        CefBw_GetMainFrame_GetURL = 21
    }
    static partial class Cef3Binder
    {

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwCall2(IntPtr myCefBw, int methodName, out JsValue ret, ref JsValue arg1, ref JsValue arg2);

    }
}