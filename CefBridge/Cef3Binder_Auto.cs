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
        //
        CefBw_GetFrameIdentifiers = 10,
        CefBw_MyCef_EnableKeyIntercept = 11,
        //
        CefBw_GetMainFrame_GetURL = 21,
        CefBw_StopLoad = 22,
        CefBw_GoForward = 23,
        CefBw_GetMainFrame_LoadURL = 24,
        CefBw_SetSize = 25,
        CefBw_ExecJs = 26,
        CefBw_PostData = 27,
        CefBw_CloseBw = 28,
    }
    public enum CefFrameCallMsg
    {
        CefFrame_GetSource = 1,
        CefFrame_GetUrl = 2,
    }
    static partial class Cef3Binder
    {
        public static void MyCefBwCall(IntPtr myCefBw, CefBwCallMsg methodName, int value)
        {
            JsValue ret;
            //
            JsValue arg1 = new JsValue();
            arg1.Type = JsValueType.Integer;
            arg1.I32 = value;
            //
            JsValue arg2 = new JsValue();

            MyCefBwCall2(myCefBw, (int)methodName, out ret, ref arg1, ref arg2);
        }

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern MyCefCallback MyCefJsValueGetManagedCallback(ref JsValue v);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefJsValueSetManagedCallback(ref JsValue v, MyCefCallback cb);
     


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwCall2(IntPtr myCefBw, int methodName, out JsValue ret, ref JsValue arg1, ref JsValue arg2);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefFrameCall2(IntPtr myCefBw, int methodName, out JsValue ret, ref JsValue arg1, ref JsValue arg2);
    

    }
}