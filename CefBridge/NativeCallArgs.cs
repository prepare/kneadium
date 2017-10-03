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
            this._argPtr = GetNativeObjPtr(argPtr, out argCount);
        }
        public string GetArgAsString(int index)
        {
            return GetAsString(_argPtr, index);
        }
        public int GetArgAsInt32(int index)
        {
            return GetAsInt32(_argPtr, index);
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            return GetAsIntPtr(_argPtr, index);
        }
        public void SetOutput(int index, string str)
        {
            //string need to copy to native side 
            SetAsIntPtr(_argPtr, index, Cef3Binder.MyCefCreateStringHolder(str));
        }
        public void SetOutput(int index, int value)
        {
            SetAsInt32(this._argPtr, index, value);
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
                SetAsIntPtr(this._argPtr, index, bufferHolderPtr);
            }
        }



        static IntPtr GetNativeObjPtr(IntPtr nativePtr, out int argCountAndFlags)
        {
            unsafe
            {
                //return address of vargs
                argCountAndFlags = *((int*)nativePtr);
                //check flags

                if (((argCountAndFlags >> 18) & 1) == 1)
                {
                    //this native
                    return nativePtr;
                }
                else
                {
                    IntPtr h1 = (IntPtr)(((byte*)nativePtr) + sizeof(int));
                    return (IntPtr)(*((JsValue**)h1));
                }

            }
        }
        static string GetAsString(IntPtr varr, int index)
        {
            unsafe
            {
                return MyCefJsReadString((JsValue*)varr + index);
            }
        }
        internal static string GetAsString(IntPtr cefStringPtr)
        {
            unsafe
            {
                char* rawCefString_char16_t;
                int actualLen;
                Cef3Binder.MyCefStringGetRawPtr(cefStringPtr, out rawCefString_char16_t, out actualLen);
                return new string(rawCefString_char16_t, 0, actualLen);
            }
        }
        static int GetAsInt32(IntPtr varr, int index)
        {
            unsafe
            {
                return ((JsValue*)varr + index)->I32;
            }
        }
        static void SetAsInt32(IntPtr varr, int index, int value)
        {
            unsafe
            {
                ((JsValue*)varr + index)->I32 = value;
            }
        }
        static uint GetAsUInt32(IntPtr varr, int index)
        {
            unsafe
            {

                return (uint)((JsValue*)varr + index)->I32;
            }
        }
        static long GetAsInt64(IntPtr varr, int index)
        {
            unsafe
            {
                return ((JsValue*)varr + index)->I64;
            }
        }
        static ulong GetAsUInt64(IntPtr varr, int index)
        {
            unsafe
            {
                return (ulong)((JsValue*)varr + index)->I64;
            }
        }
        static bool GetAsBool(IntPtr varr, int index)
        {
            unsafe
            {
                return ((JsValue*)varr + index)->I32 != 0;
            }
        }
        static double GetAsDouble(IntPtr varr, int index)
        {
            unsafe
            {
                return ((JsValue*)varr + index)->Num;
            }
        }
        static float GetAsFloat(IntPtr varr, int index)
        {
            unsafe
            {
                return (float)((JsValue*)varr + index)->Num;
            }
        }
        static IntPtr GetAsIntPtr(IntPtr varr, int index)
        {
            unsafe
            {
                return ((JsValue*)varr + index)->Ptr;
            }
        }
        static void SetAsIntPtr(IntPtr varr, int index, IntPtr value)
        {
            unsafe
            {
                ((JsValue*)varr + index)->Ptr = value;
            }
        }
        static void SetBoolToAddress(IntPtr varr, int index, bool value)
        {
            unsafe
            {
                JsValue* jsvalue = ((JsValue*)varr + index);
                *((bool*)jsvalue->Ptr) = value;
            }
        }
        static void SetUInt32ToAddress(IntPtr varr, int index, uint value)
        {
            unsafe
            {

                JsValue* jsvalue = ((JsValue*)varr + index);
                *((uint*)jsvalue->Ptr) = value;
            }
        }

        unsafe static string MyCefJsReadString(JsValue* jsval)
        {
            int actualLen;
            int buffLen = jsval->I32 + 1; //string len
            //check if string is on method-call's frame stack or heap
            if (jsval->Type == JsValueType.NativeCefString)
            {
                char* rawCefString_char16_t;
                Cef3Binder.MyCefStringGetRawPtr(jsval->Ptr, out rawCefString_char16_t, out actualLen);
                return new string(rawCefString_char16_t, 0, actualLen);
            }
            if (buffLen < 1024)
            {
                char* buffHead = stackalloc char[buffLen];
                Cef3Binder.MyCefStringHolder_Read(jsval->Ptr, buffHead, buffLen, out actualLen);
                if (actualLen > buffLen)
                {
                    //read more
                }
                return new string(buffHead, 0, actualLen);
            }
            else
            {
                char[] buffHead = new char[buffLen];
                fixed (char* h = &buffHead[0])
                {
                    Cef3Binder.MyCefStringHolder_Read(jsval->Ptr, h, buffLen, out actualLen);
                    if (actualLen > buffLen)
                    {
                        //read more
                    }
                }
                return new string(buffHead, 0, actualLen);
            }

        }
    }
}