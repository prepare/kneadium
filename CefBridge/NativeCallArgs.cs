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
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct MyMetArgsN
        {
            public int argCount;
            public JsValue* jsArr;
        }

        readonly IntPtr rawNativeArgs;
        public NativeCallArgs(IntPtr argPtr)
        {
            rawNativeArgs = argPtr;
        }
        public string GetArgAsString(int index)
        {
            return GetAsString(rawNativeArgs, index);
        }
        public int GetArgAsInt32(int index)
        {
            return GetAsInt32(rawNativeArgs, index);
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            return GetAsIntPtr(rawNativeArgs, index);
        }
        public void SetOutput(int index, string str)
        {
            //string need to copy to native side 
            SetAsIntPtr(rawNativeArgs, index, Cef3Binder.MyCefCreateStringHolder(str));
        }
        public void SetOutput(int index, int value)
        {
            SetAsInt32(rawNativeArgs, index, value);
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
                SetAsIntPtr(this.rawNativeArgs, index, bufferHolderPtr);
            }
        }
        static bool IsCustomArray(IntPtr nativePtr)
        {
            unsafe
            {
                int argCountAndFlags = *((int*)nativePtr);
                return (((argCountAndFlags >> 18) & 1) != 1);
            }
        }
        static string GetAsString(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return MyCefJsReadString(arr + index);
                //return MyCefJsReadString(((MyMetArgsN*)varr)->jsArr[index]);
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
        static int GetAsInt32(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (arr + index)->I32;
                //return ((JsValue*)varr + index)->I32;
            }
        }
        static void SetAsInt32(IntPtr myMetArgN, int index, int value)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                (arr + index)->I32 = value;
                // ((JsValue*)varr + index)->I32 = value;
            }
        }
        static uint GetAsUInt32(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (uint)(arr + index)->I32;
            }
        }
        static long GetAsInt64(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (arr + index)->I64;
                //return ((JsValue*)varr + index)->I64;
            }
        }
        static ulong GetAsUInt64(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (ulong)(arr + index)->I64;
                //return (ulong)((JsValue*)varr + index)->I64;
            }
        }
        static bool GetAsBool(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (arr + index)->I32 != 0;
            }
        }
        static double GetAsDouble(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (arr + index)->Num;
                //return ((JsValue*)varr + index)->Num;
            }
        }
        static float GetAsFloat(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (float)(arr + index)->Num;
                //return (float)((JsValue*)varr + index)->Num;
            }
        }
        static IntPtr GetAsIntPtr(IntPtr myMetArgN, int index)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                return (arr + index)->Ptr;
                //return ((JsValue*)varr + index)->Ptr;
            }
        }

        static void SetAsIntPtr(IntPtr myMetArgN, int index, IntPtr value)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                (arr + index)->Ptr = value;
            }
        }
        static void SetBoolToAddress(IntPtr myMetArgN, int index, bool value)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                *((bool*)(arr + index)->Ptr) = value;

                //JsValue* jsvalue = ((JsValue*)myMetArgN + index);
                //*((bool*)jsvalue->Ptr) = value;
            }
        }
        static void SetUInt32ToAddress(IntPtr myMetArgN, int index, uint value)
        {
            unsafe
            {
                MyMetArgsN* metArg = (MyMetArgsN*)myMetArgN;
                JsValue* arr = metArg->jsArr;
                *((uint*)(arr + index)->Ptr) = value;


                //JsValue* jsvalue = ((JsValue*)myMetArgN + index);
                //*((uint*)jsvalue->Ptr) = value;
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