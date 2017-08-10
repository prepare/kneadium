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

      

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMet_CefBrowser(IntPtr /*cef_browser_t* */ me1, int metName, out JsValue ret, ref JsValue arg1, ref JsValue arg2, ref JsValue arg3, ref JsValue arg4, ref JsValue arg5, ref JsValue arg6);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMet_CefFrame(IntPtr /*cef_frame_t**/ me1, int metName, out JsValue ret, ref JsValue arg1, ref JsValue arg2, ref JsValue arg3, ref JsValue arg4, ref JsValue arg5, ref JsValue arg6);


        [DllImport(Cef3Binder.CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMet_CallN(IntPtr me, int metName, out JsValue ret, ref JsValue v1,
            ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5, ref JsValue v6, ref JsValue v7);

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

    public partial class CefFrame
    {
        IntPtr nativePtr;
        internal CefFrame(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public bool IsValid()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_IsValid, out ret, ref a1, ref a2);
            return ret.I32 != 0;
        }

        public void Undo()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Undo, out ret, ref a1, ref a2);
        }

        public void Redo()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Redo, out ret, ref a1, ref a2);
        }

        public void Cut()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Cut, out ret, ref a1, ref a2);
        }

        public void Copy()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Copy, out ret, ref a1, ref a2);
        }

        public void Paste()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Paste, out ret, ref a1, ref a2);
        }

        public void Delete()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Delete, out ret, ref a1, ref a2);
        }

        public void SelectAll()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_SelectAll, out ret, ref a1, ref a2);
        }

        public void ViewSource()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_ViewSource, out ret, ref a1, ref a2);
        }

        public void GetSource(CefStringVisitor visitor)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            a1.Type = JsValueType.Wrapped;
            a1.Ptr = visitor.nativePtr;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetSource, out ret, ref a1, ref a2);
        }

        public void GetText(CefStringVisitor visitor)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            a1.Type = JsValueType.Wrapped;
            a1.Ptr = visitor.nativePtr;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetText, out ret, ref a1, ref a2);
        }

        public void LoadRequest(CefRequest request)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            a1.Type = JsValueType.Wrapped;
            a1.Ptr = request.nativePtr;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_LoadRequest, out ret, ref a1, ref a2);
        }

        public void LoadURL(string url)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefCreateNativeStringHolder(ref a1, url);
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_LoadURL, out ret, ref a1, ref a2);
        }

        public void LoadString(string string_val, string url)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefCreateNativeStringHolder(ref a1, string_val);
            Cef3Binder.MyCefCreateNativeStringHolder(ref a2, url);
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_LoadString, out ret, ref a1, ref a2);
        }

        public void ExecuteJavaScript(string code, string script_url, int start_line)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefCreateNativeStringHolder(ref a1, code);
            Cef3Binder.MyCefCreateNativeStringHolder(ref a2, script_url);
            //a3.Type = JsValueType.Integer;
            //a3.I32 = start_line;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_ExecuteJavaScript, out ret, ref a1, ref a2);
        }

        public bool IsMain()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_IsMain, out ret, ref a1, ref a2);
            return ret.I32 != 0;
        }

        public bool IsFocused()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_IsFocused, out ret, ref a1, ref a2);
            return ret.I32 != 0;
        }

        public string GetName()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetName, out ret, ref a1, ref a2);
            return Cef3Binder.MyCefJsReadString(ref ret);
        }

        public long GetIdentifier()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetIdentifier, out ret, ref a1, ref a2);
            return ret.I64;
        }

        public CefFrame GetParent()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetParent, out ret, ref a1, ref a2);
            return new CefFrame(ret.Ptr);
        }

        public string GetURL()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetURL, out ret, ref a1, ref a2);
            return Cef3Binder.MyCefJsReadString(ref ret);
        }

        public CefBrowser GetBrowser()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetBrowser, out ret, ref a1, ref a2);
            return new CefBrowser(ret.Ptr);
        }

        public CefV8Context GetV8Context()
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetV8Context, out ret, ref a1, ref a2);
            return new CefV8Context(ret.Ptr);
        }

        public void VisitDOM(CefDOMVisitor visitor)
        {

            //autogen!

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            a1.Type = JsValueType.Wrapped;
            a1.Ptr = visitor.nativePtr;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_VisitDOM, out ret, ref a1, ref a2);
        }

    }





}