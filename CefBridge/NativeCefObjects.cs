//MIT, 2015-2017, WinterDev

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{
    public enum CefV8PropertyAttribute
    {
        //from cef_types.h
        //cef_v8_propertyattribute_t
        V8_PROPERTY_ATTRIBUTE_NONE = 0, // Writeable, Enumerable,Configurable
        V8_PROPERTY_ATTRIBUTE_READONLY = 1 << 0, // Not writeable
        V8_PROPERTY_ATTRIBUTE_DONTENUM = 1 << 1,  // Not enumerable
        V8_PROPERTY_ATTRIBUTE_DONTDELETE = 1 << 2   // Not configurable
    }

    public abstract class Cef3RefCountingValue : IDisposable
    {
        readonly IntPtr _ptr;
        public Cef3RefCountingValue(IntPtr ptr)
        {
            _ptr = ptr;
        }
        public void Dispose()
        {
            //TODO: release pointer back
        }
        public IntPtr Ptr
        {
            get { return _ptr; }
        }
    }

    public class Cef3FuncHandler : Cef3RefCountingValue
    {
        private Cef3FuncHandler(IntPtr ptr) : base(ptr)
        {
        }

        public static Cef3FuncHandler CreateFuncHandler(MyCefCallback cefCallback)
        {
            //store in cbs, prevent collected by GC
            cbs.Add(cefCallback);
            return new Cef3FuncHandler(Cef3Binder.MyCefJs_New_V8Handler(cefCallback));
        }
        static List<MyCefCallback> cbs = new List<MyCefCallback>();
    }

    public class Cef3Func : Cef3RefCountingValue
    {
        public Cef3Func(IntPtr ptr) : base(ptr)
        {
        }
        public static Cef3Func CreateFunc(string name, Cef3FuncHandler funcHandler)
        {
            IntPtr func = Cef3Binder.MyCefJs_CreateFunction(name, funcHandler.Ptr);
            return new Cef3Func(func);
        }
        public CefV8Value ExecFunction(NativeJsContext context, string argAsJsonString)
        {
            unsafe
            {
                char[] chars = argAsJsonString.ToCharArray();
                fixed (char* first = &chars[0])
                {
                    CefV8Value value = new CefV8Value(Cef3Binder.MyCefJs_ExecJsFunctionWithContext(this.Ptr, context.Ptr, first));
                    return value;
                }
            }
        }
        public CefV8Value ExecFunction(NativeJsContext context, char[] argAsJsonChars)
        {
            unsafe
            {
                fixed (char* first = &argAsJsonChars[0])
                {
                    CefV8Value value = new CefV8Value(Cef3Binder.MyCefJs_ExecJsFunctionWithContext(this.Ptr, context.Ptr, first));
                    return value;
                }
            }
        }
    }

    public class NativeJsContext : Cef3RefCountingValue
    {
        public NativeJsContext(IntPtr ptr)
            : base(ptr)
        {
        }
        /// <summary>
        /// get global object
        /// </summary>
        /// <returns></returns>
        public CefV8Value GetGlobal()
        {
            return new CefV8Value(Cef3Binder.MyCefJsGetGlobal(this.Ptr));
        }
        public static NativeJsContext GetCurrentContext()
        {
            return new NativeJsContext(Cef3Binder.MyCefJsGetCurrentContext());
        }
        public static NativeJsContext GetEnteredContext()
        {
            return new NativeJsContext(Cef3Binder.MyCefJs_GetEnteredContext());
        }

        public void EnterContext()
        {
            Cef3Binder.MyCefJs_EnterContext(this.Ptr);
        }
        public void ExitContext()
        {
            Cef3Binder.MyCefJs_ExitContext(this.Ptr);
        }
    }

    public class CefV8Value : Cef3RefCountingValue
    {
        public CefV8Value(IntPtr ptr) : base(ptr)
        {
            if (ptr == IntPtr.Zero)
            {
            }
        }
        public void Set(string key, Cef3Func cef3Func)
        {
            Cef3Binder.MyCefJs_CefV8Value_SetValue_ByString(
                this.Ptr,
                key,
                cef3Func.Ptr,
                (int)CefV8PropertyAttribute.V8_PROPERTY_ATTRIBUTE_READONLY);
        }
        public bool IsFunc()
        {
            return Cef3Binder.MyCefJs_CefV8Value_IsFunc(this.Ptr);
        }
       
    }


    //struct jsvalue
    //{
    //    int32_t type; //type and flags
    //                  //this for 32 bits values, also be used as string len, array len  and index to managed slot index
    //    int32_t i32;
    //    // native ptr (may point to native object, native array, native string)
    //    void* ptr; //uint16_t* or jsvalue**   arr or 
    //               //store float or double
    //    double num;
    //    //store 64 bits value
    //    int64_t i64;
    //};

    //---------------------------------------
    //2017-06-04
    //1. for internal inter-op only -> always be private
    //for inter-op with native lib, .net core on macOS x64 dose not support explicit layout
    //so we need sequential layout
    //2. this is a quite large object, and is designed to be used on stack,
    //pass by reference to native side
    //---------------------------------------
    /// <summary>
    /// for internal inter-op only -> always be private,used on stack,pass by reference
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    struct JsValue
    {
        /// <summary>
        /// type and flags
        /// </summary>
        public JsValueType Type;
        /// <summary>
        /// this for 32 bits values, also be used as string len, array len  and index to managed slot index
        /// </summary>
        public int I32;//
        /// <summary>
        /// native ptr (may point to native object, native array, native string)
        /// </summary>
        public IntPtr Ptr;
        /// <summary>
        /// store float or double
        /// </summary>
        public double Num;// 
        /// <summary>
        /// store 64 bits value
        /// </summary>
        public long I64;// 

        //--------------------------------


      
    }



    public enum JsValueType
    {

        //#define JSVALUE_TYPE_UNKNOWN_ERROR  -1
        //#define JSVALUE_TYPE_EMPTY			 0
        //#define JSVALUE_TYPE_NULL            1
        //#define JSVALUE_TYPE_BOOLEAN         2
        //#define JSVALUE_TYPE_INTEGER         3
        //#define JSVALUE_TYPE_NUMBER          4
        //#define JSVALUE_TYPE_STRING          5 //unicode string
        //#define JSVALUE_TYPE_DATE            6
        //#define JSVALUE_TYPE_INDEX           7
        //#define JSVALUE_TYPE_ARRAY          10
        //#define JSVALUE_TYPE_STRING_ERROR   11
        //#define JSVALUE_TYPE_MANAGED        12
        //#define JSVALUE_TYPE_MANAGED_ERROR  13
        //#define JSVALUE_TYPE_WRAPPED        14
        //#define JSVALUE_TYPE_DICT           15
        //#define JSVALUE_TYPE_ERROR          16
        //#define JSVALUE_TYPE_FUNCTION       17

        //#define JSVALUE_TYPE_JSTYPEDEF      18 //my extension
        //#define JSVALUE_TYPE_INTEGER64      19 //my extension
        //#define JSVALUE_TYPE_BUFFER         20 //my extension

        //#define JSVALUE_TYPE_NATIVE_CEFSTRING 30  //my extension
        //#define JSVALUE_TYPE_MEM_ERROR      50 //my extension

        UnknownError = -1,
        Empty = 0,
        Null = 1,
        Boolean = 2,
        Integer = 3,
        Number = 4,
        String = 5,
        Date = 6,
        Index = 7,
        Array = 10,
        StringError = 11,
        Managed = 12,
        ManagedError = 13,
        Wrapped = 14,
        Dictionary = 15,
        Error = 16,
        Function = 17,
        //---------------
        //my extension
        JsTypeWrap = 18,
        Int64 = 19,
        Buffer = 20,
        NativeCefString = 30,
        JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING = 31,
        JSVALUE_TYPE_MANAGED_CB = 32,
        MemError = 50,

    }
    public class NativeBrowser : Cef3RefCountingValue
    {
        public NativeBrowser(IntPtr ptr) : base(ptr)
        {
        }
        public void ExecJavascript(string src, string url)
        {
            throw new NotSupportedException();
        }
    }
    public class NativeFrame : Cef3RefCountingValue
    {
        public NativeFrame(IntPtr ptr) : base(ptr)
        {
        }
        public NativeJsContext GetFrameContext()
        {
            return new NativeJsContext(Cef3Binder.MyCefFrame_GetContext(this.Ptr));
        }
        public string GetUrl()
        {
            unsafe
            {
                JsValue ret;
                JsValue arg1 = new JsValue();
                JsValue arg2 = new JsValue();
                Cef3Binder.MyCefFrameCall2(this.Ptr, (int)CefFrameCallMsg.CefFrame_GetURL, out ret, ref arg1, ref arg2);
                NativeMyCefStringHolder ret_str = new NativeMyCefStringHolder(ret.Ptr);
                string url = ret_str.ReadString(ret.I32);
                ret_str.Dispose();
                return url;
                //get url, in this version max size =255?
                //char[] buffer = new char[255];
                //int actualLength = 0;
                //fixed (char* buffer_head = &buffer[0])
                //{
                //    Cef3Binder.MyCefFrame_GetUrl(Ptr, buffer_head, 255, ref actualLength);
                //    return new string(buffer_head);
                //}
            }
        }
    }
    public class NativeRendererApp : Cef3RefCountingValue
    {
        public NativeRendererApp(IntPtr ptr) : base(ptr)
        {
        }
    }
    public class NativeResourceMx : Cef3RefCountingValue
    {
        public NativeResourceMx(IntPtr ptr) : base(ptr)
        {
        }
        public void AddResourceProvider(ResourceProvider resProvider)
        {
        }
    }
    public class ResourceProvider
    {
    }
}