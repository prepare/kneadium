//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{
    struct NativeCallArgs
    {
        IntPtr argPtr;

        public NativeCallArgs(IntPtr argPtr)
        {
            this.argPtr = argPtr;
        }
        public string GetArgAsString(int index)
        {
            var v = Cef3Binder.MyCefNativeMetGetArgs(argPtr, index);
            return Marshal.PtrToStringUni(v.Ptr);
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            var v = Cef3Binder.MyCefNativeMetGetArgs(argPtr, index);
            return v.Ptr;
        }
        public void SetOutput(int index, string str)
        {
            //interchange with utf16
            //byte[] buffer = Encoding.Unicode.GetBytes(str.ToCharArray());
            //unsafe
            //{
            //    fixed (byte* b = &buffer[0])
            //    {
            //        Cef3Binder.MyCefCbArgs_SetResultAsBuffer(this.argPtr,
            //            index,
            //            b,
            //            buffer.Length);
            //    }
            //}
            Cef3Binder.MyCefMetArgs_SetResultAsString(this.argPtr, index, str, str.Length);

        }
        public void SetOutput(int index, byte[] buffer)
        {

            unsafe
            {
                fixed (byte* b = &buffer[0])
                {
                    Cef3Binder.MyCefCbArgs_SetResultAsBuffer(this.argPtr,
                        index,
                        b,
                        buffer.Length);
                }
            }
        }


        public void Dispose()
        {
            Cef3Binder.MyCefDisposePtr(this.argPtr);
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