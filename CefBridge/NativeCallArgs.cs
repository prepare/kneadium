//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{

    [StructLayout(LayoutKind.Sequential)]
    public class QueryRequestArgs
    {
        //see class  QueryRequestArgs in mycef.h

        IntPtr _browser_ptr;
        IntPtr _frame_ptr;
        IntPtr _requestCefStringHolder; //native ptr to CefString

        long _query_id;
        bool _presistent;

        private QueryRequestArgs()
        {
        }

        public static QueryRequestArgs CreateRequest(IntPtr nativeIntPtr)
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
        public long GetQueryId()
        {
            return _query_id;
        }
        public string GetRequest()
        {
            //get request from native string

            int acutalLen = 0;
            unsafe
            {
                int BUFF_LEN = 256;
                char* buffHead = stackalloc char[BUFF_LEN];
                Cef3Binder.MyCefStringHolder_Read(_requestCefStringHolder, buffHead, BUFF_LEN, ref acutalLen);
                if (acutalLen > BUFF_LEN)
                {
                    //read more
                }
                return new string(buffHead, 0, acutalLen);
            }
        }
    }


    public struct NativeCallArgs
    {
        IntPtr _argPtr;

        public NativeCallArgs(IntPtr argPtr)
        {
            _argPtr = argPtr;
        }

        const int BUFF_LEN = 512;
        public string GetArgAsString(int index)
        {
            JsValue v = Cef3Binder.MyCefNativeMetGetArgs(_argPtr, index);
            if ((int)v.Type == 30)
            {
                //native cef

                var charBuff = new char[BUFF_LEN];
                int acutalLen = 0;
                unsafe
                {
                    fixed (char* buffHead = &charBuff[0])
                    {

                        Cef3Binder.MyCefString_Read(v.Ptr, buffHead, BUFF_LEN, ref acutalLen);
                        if (acutalLen > BUFF_LEN)
                        {
                            //read more
                        }
                        return new string(buffHead, 0, acutalLen);
                    }
                }
            }
            else
            {
                return Marshal.PtrToStringUni(v.Ptr);
            }
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            JsValue v = Cef3Binder.MyCefNativeMetGetArgs(_argPtr, index);
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
    public struct NativeCallArgs2
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

}