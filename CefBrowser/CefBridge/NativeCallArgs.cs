//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{

    [StructLayout(LayoutKind.Sequential)]
    class QueryRequestArgs
    {
        //see class  QueryRequestArgs in mycef.h

        IntPtr _browser_ptr;
        IntPtr _frame_ptr;
        long _query_id;
        IntPtr _request;
        bool _presistent;

        internal static QueryRequestArgs CreateRequest(IntPtr nativeIntPtr)
        {
            var req = new QueryRequestArgs();
            Marshal.PtrToStructure(nativeIntPtr, req);
            return req;
        }

        public string GetFrameUrl()
        {
            var fr = new NativeFrame(_frame_ptr);
            return fr.GetUrl();
        }


    }


    struct NativeCallArgs
    {
        IntPtr _argPtr;

        public NativeCallArgs(IntPtr argPtr)
        {
            this._argPtr = argPtr;
        }
        public string GetArgAsString(int index)
        {
            var v = Cef3Binder.MyCefNativeMetGetArgs(_argPtr, index);
            return Marshal.PtrToStringUni(v.Ptr);
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            var v = Cef3Binder.MyCefNativeMetGetArgs(_argPtr, index);
            return v.Ptr;
        }
        public void SetOutput(int index, string str)
        {
            Cef3Binder.MyCefMetArgs_SetResultAsString(this._argPtr, index, str, str.Length);
        }
        public void SetOutput(int index, int value)
        {
            Cef3Binder.MyCefMetArgs_SetResultAsInt32(this._argPtr, index, value);
        }
        public void SetOutput(int index, byte[] buffer)
        {

            unsafe
            {
                fixed (byte* b = &buffer[0])
                {
                    Cef3Binder.MyCefMetArgs_SetResultAsByteBuffer(this._argPtr,
                        index,
                        new IntPtr(b),
                        buffer.Length);
                }
            }
        }
        public void SetOutputAsAsciiString(int index, string str)
        {
            SetOutput(index, Encoding.ASCII.GetBytes(str.ToCharArray()));
        }
        public unsafe void UnsafeSetOutput(int index, IntPtr unmangedMemPtr, int len)
        {

            Cef3Binder.MyCefMetArgs_SetResultAsByteBuffer(this._argPtr,
                index,
                unmangedMemPtr,
                len);
        }
       
        public void Dispose()
        {
            Cef3Binder.MyCefDisposePtr(this._argPtr);
        }
    }
    struct NativeCallArgs2
    {
        IntPtr argPtr;
        public NativeCallArgs2(IntPtr argPtr)
        {
            this.argPtr = argPtr;
        }
        public void SetResult(IntPtr nativePtr)
        {
            //set data to unmanaged side
            unsafe
            {
                JsValue jsvalue = new JsValue();
                jsvalue.Ptr = nativePtr;
                Cef3Binder.MyCefMetArgs_SetResultAsJsValue(this.argPtr, 0, (IntPtr)(&jsvalue));

            }
        }
    }


    //[StructLayout(LayoutKind.Sequential)]
    //struct NativeMethodCallArgs
    //{

    //    public int method_id;
    //    public JsValue arg1;
    //    public JsValue arg2;
    //    public JsValue arg3;
    //    public JsValue arg4;

    //    public JsValue result0;
    //    public JsValue result1;
    //    public JsValue result2;
    //    public JsValue result3;
    //    public JsValue result4;
    //    public int resultKind;
    //    public int argCount;
    //    public int resultCount;
    //}
}