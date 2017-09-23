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
        CefBw_GetMainFrame = 29,
        CefBw_NewStringVisitor = 30,
    }
    public enum CefFrameCallMsg
    {
        CefFrame_Release = 0,
        CefFrame_IsValid = 1,
        CefFrame_Undo = 2,
        CefFrame_Redo = 3,
        CefFrame_Cut = 4,
        CefFrame_Copy = 5,
        CefFrame_Paste = 6,
        CefFrame_Delete = 7,
        CefFrame_SelectAll = 8,
        CefFrame_ViewSource = 9,

        CefFrame_GetSource = 10,
        CefFrame_GetSource_Ext = 30,
        CefFrame_GetURL = 11,
        CefFrame_GetText = 12,
        CefFrame_LoadRequest = 13,
        CefFrame_LoadURL = 14,
        CefFrame_LoadString = 15,
        CefFrame_ExecuteJavaScript = 16,
        CefFrame_IsMain = 17,
        CefFrame_IsFocused = 18,
        CefFrame_GetName = 19,
        CefFrame_GetIdentifier = 20,
        CefFrame_GetParent = 21,
        CefFrame_GetBrowser = 22,
        CefFrame_GetV8Context = 23,
        CefFrame_VisitDOM = 24
    }
    static partial class Cef3Binder
    {
       

        [DllImport(Cef3Binder.CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr NewInstance(int typeName, MyCefCallback callback, ref JsValue v1);

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


    public partial class CefBrowser
    {
        public IntPtr nativePtr;
        internal CefBrowser(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public partial class CefV8Context
    {
        public IntPtr nativePtr;
        internal CefV8Context(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public partial class CefDOMVisitor
    {
        public IntPtr nativePtr;
        internal CefDOMVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    } 


}