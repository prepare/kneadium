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
            var v = Cef3Binder.MyCefCbArgs_GetArg(argPtr, index);
            return Marshal.PtrToStringUni(v.Ptr);
        }

        public void SetOutput(int index, string str)
        {
            //interchange with utf16
            byte[] buffer = Encoding.Unicode.GetBytes(str.ToCharArray());
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
    }
}