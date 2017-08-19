//MIT, 2015-2017, WinterDev

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
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

            int actualLen = 0;
            unsafe
            {
                int BUFF_LEN = 256;
                char* buffHead = stackalloc char[BUFF_LEN];
                Cef3Binder.MyCefStringHolder_Read(_requestCefStringHolder, buffHead, BUFF_LEN, out actualLen);
                if (actualLen > BUFF_LEN)
                {
                    //read more
                }
                return new string(buffHead, 0, actualLen);
            }
        }
    }


    public struct NativeCallArgs
    {
        internal readonly IntPtr _argPtr;
        public NativeCallArgs(IntPtr argPtr)
        {
            int argCount;
            this._argPtr = MyMetArgs.GetArrHead(argPtr, out argCount);
        }
        public string GetArgAsString(int index)
        {
            return MyMetArgs.GetAsString(_argPtr, index);
        }
        public int GetArgAsInt32(int index)
        {
            return MyMetArgs.GetAsInt32(_argPtr, index);
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            return MyMetArgs.GetAsIntPtr(_argPtr, index);
        }
        public void SetOutput(int index, string str)
        {
            //string need to copy to native side 
            MyMetArgs.SetAsIntPtr(_argPtr, index, Cef3Binder.MyCefCreateStringHolder(str));
        }
        public void SetOutput(int index, int value)
        {
            MyMetArgs.SetAsInt32(this._argPtr, index, value);
        }

        public void SetOutput(int index, byte[] buffer)
        {
            //output
            CopyBufferToBufferHolder(index, buffer);
        }

        static Encoding asciiEncoding = null;
        public void SetOutputAsAsciiString(int index, string str)
        {
            if (asciiEncoding == null)
            {
                asciiEncoding = Encoding.GetEncoding("ASCII");
            }
            CopyBufferToBufferHolder(index, asciiEncoding.GetBytes(str.ToCharArray()));
        }
        public void CopyBufferToBufferHolder(int index, byte[] data)
        {
            int len = data.Length;
            unsafe
            {
                IntPtr bufferHolderPtr;
                fixed (byte* head = &data[0])
                {
                    //native side copy the managed data and store at the native side
                    bufferHolderPtr = Cef3Binder.MyCefCreateBufferHolderWithInitData(len, head);
                }
                MyMetArgs.SetAsIntPtr(this._argPtr, index, bufferHolderPtr);
            }
        }
    }
}