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
        internal readonly IntPtr _argPtr;
        public NativeCallArgs(IntPtr argPtr)
        {
            _argPtr = argPtr;
        }

        const int BUFF_LEN = 512;
        public string GetArgAsString(int index)
        {
            JsValue v = new JsValue();
            Cef3Binder.MyCefMetArgs_GetArgs(_argPtr, index, out v);
            if ((int)v.Type == 30)
            {
                //native cef 
                unsafe
                {
                    char* charBuff = stackalloc char[BUFF_LEN];
                    int actualLen;
                    Cef3Binder.MyCefString_Read(v.Ptr, charBuff, BUFF_LEN, out actualLen);
                    if (actualLen > BUFF_LEN)
                    {
                        //read more
                    }
                    return new string(charBuff, 0, actualLen);
                }
            }
            else
            {
                return Marshal.PtrToStringUni(v.Ptr);
            }
        }
        public int GetArgAsInt32(int index)
        {
            JsValue v = new JsValue();
            Cef3Binder.MyCefMetArgs_GetArgs(_argPtr, index, out v);
            return v.I32;
        }
        public IntPtr GetArgAsNativePtr(int index)
        {
            JsValue v = new JsValue();
            Cef3Binder.MyCefMetArgs_GetArgs(_argPtr, index, out v);
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
        public void SetInput(int index, string str)
        {
            //input args
            Cef3Binder.MyCefMetArgs_SetInputAsString(this._argPtr,
                       index,
                       str,
                       str.Length);
        }
        public void SetInput(int index, int value)
        {
            //input args
            Cef3Binder.MyCefMetArgs_SetInputAsInt32(this._argPtr,
                       index, value);
        }
        public void SetOutput(int index, byte[] buffer)
        {
            //output

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

        static Encoding asciiEncoding = null;
        public void SetOutputAsAsciiString(int index, string str)
        {
            if (asciiEncoding == null)
            {
                asciiEncoding = Encoding.GetEncoding("ASCII");
            }

            SetOutput(index, asciiEncoding.GetBytes(str.ToCharArray()));
        }
        public unsafe void UnsafeSetOutput(int index, IntPtr unmangedMemPtr, int len)
        {
            Cef3Binder.MyCefMetArgs_SetResultAsByteBuffer(this._argPtr,
                index,
                unmangedMemPtr,
                len);
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
    public struct JsMetArgs
    {
        IntPtr argPtr;
        public JsMetArgs(IntPtr argPtr)
        {
            this.argPtr = argPtr;
        }
        public string ReadArgAsString(int index)
        {
            //Cef3Binder.MyCefJs_MetReadArgAsString(this.argPtr,index,)
            int acutalLen = 0;
            unsafe
            {
                int BUFF_LEN = 256;
                char* buffHead = stackalloc char[BUFF_LEN];
                Cef3Binder.MyCefJs_MetReadArgAsString(argPtr, index, buffHead, BUFF_LEN, ref acutalLen);
                if (acutalLen > BUFF_LEN)
                {
                    //read more
                }
                return new string(buffHead, 0, acutalLen);
            }
        }
        public Cef3Func ReadArgsFuncHandler(int index)
        {
            CefV8Value func = new CefV8Value(Cef3Binder.MyCefJs_MetReadArgAsCefV8Value(argPtr, index));
            return new Cef3Func(func.Ptr);
        }
    }

    public struct CefSettings
    {
        IntPtr nativePtr;
        internal CefSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void SetSubProcessPath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_BrowserSubProcessPath, value);
        }
        public void SetCachePath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_CachePath, value);
        }
        public void SetUserDirPath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_UserDirPath, value);
        }
        public void SetLocalDirPath(string value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_LocalDirPath, value);
        }
        public void IgnoreCertErrror(bool value)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_IgnoreCertError, value ? "1" : "0");
        }
        public void SetRemoteDebuggingPort(int portNo)
        {
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
                CefSettingsKey.CEF_SETTINGS_RemoteDebuggingPort, portNo.ToString());
        }
        public void SetLogSeverity(LogServerity logSeverity)
        {
            int severity = (int)logSeverity;
            Cef3Binder.MyCefSetInitSettings(this.nativePtr,
               CefSettingsKey.CEF_SETTINGS_RemoteDebuggingPort, severity.ToString());
        }
    }
}