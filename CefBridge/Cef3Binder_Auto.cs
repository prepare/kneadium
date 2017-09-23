//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{

    public enum CefBwCallMsg
    {
        //custom msg
        CefBw_MyCef_EnableKeyIntercept = 11,
        CefBw_SetSize = 25,
        CefBw_PostData = 27,
        CefBw_CloseBw = 28,
        CefBw_GetMainFrame = 29,

        CefBw_GetCefBrowser = 31,
    }

    static partial class Cef3Binder
    {

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(Cef3Binder.CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewInstance(int typeName, MyCefCallback callback, ref JsValue v1);

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport(Cef3Binder.CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMet_CallN(IntPtr me, int metName, out JsValue ret, ref JsValue v1,
            ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5, ref JsValue v6, ref JsValue v7);


        public static IntPtr NewInstance(int typeName, MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return NewInstance(typeName, callback, ref not_used);
        }



        public static void MyCefMet_Call0(IntPtr me, int metName, out JsValue ret)
        {

            JsValue v_notUsed = new JsValue();

            MyCefMet_CallN(
            me, metName, out ret
            , ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed
            );
        }

        public static void MyCefMet_Call1(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1
        )
        {
            JsValue v_notUsed = new JsValue();
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed
            );
        }
        public static void MyCefMet_Call2(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2
        )
        {
            JsValue v_notUsed = new JsValue();
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v2,
            ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed
            );
        }
        public static void MyCefMet_Call3(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3
        )
        {
            JsValue v_notUsed = new JsValue();
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v2, ref v3,
            ref v_notUsed, ref v_notUsed, ref v_notUsed, ref v_notUsed
            );
        }
        public static void MyCefMet_Call4(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4/*5117*/
        )
        {
            JsValue v_notUsed = new JsValue();
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4,
            ref v_notUsed, ref v_notUsed, ref v_notUsed
            );
        }

        public static void MyCefMet_Call5(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5
        )
        {

            JsValue v_notUsed = new JsValue();
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5,
            ref v_notUsed, ref v_notUsed
            );
        }
        public static void MyCefMet_Call6(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5, ref JsValue v6
        )
        {
            JsValue v_notUsed = new JsValue();
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6,
            ref v_notUsed
            );
        }
        public static void MyCefMet_Call7(IntPtr me, int metName, out JsValue ret
      , ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5, ref JsValue v6, ref JsValue v7
      )
        {
            MyCefMet_CallN(
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6, ref v7
            );
        }
    }


}