//2015-2016 MIT, WinterDev
using System;
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
        internal IntPtr Ptr
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
            return new Cef3FuncHandler(Cef3Binder.MyCefJs_New_V8Handler(cefCallback));
        }

    }

    public class Cef3Func : Cef3RefCountingValue
    {

        private Cef3Func(IntPtr ptr) : base(ptr)
        {

        }
        public static Cef3Func CreateFunc(string name, Cef3FuncHandler funcHandler)
        {
            IntPtr func = Cef3Binder.MyCefJs_CreateFunction(name, funcHandler.Ptr);
            return new Cef3Func(func);
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
    }

    public class CefV8Value : Cef3RefCountingValue
    {

        public CefV8Value(IntPtr ptr) : base(ptr)
        {

        }
        public void Set(string key, Cef3Func cef3Func)
        {
            Cef3Binder.MyCefJs_CefV8Value_SetValue_ByString(this.Ptr, key, cef3Func.Ptr, (int)CefV8PropertyAttribute.V8_PROPERTY_ATTRIBUTE_READONLY);
        }

    }

    [StructLayout(LayoutKind.Explicit)]
    public struct JsValue
    {
        [FieldOffset(0)]
        public int I32;
        [FieldOffset(0)]
        public long I64;
        [FieldOffset(0)]
        public double Num;
        /// <summary>
        /// ptr from native side
        /// </summary>
        [FieldOffset(0)]
        public IntPtr Ptr;

        /// <summary>
        /// offset(8)See JsValueType, marshaled as integer. 
        /// </summary>
        [FieldOffset(8)]
        public JsValueType Type;

        /// <summary>
        /// offset(12) Length of array or string 
        /// </summary>
        [FieldOffset(12)]
        public int Length;
        /// <summary>
        /// offset(12) managed object keepalive index. 
        /// </summary>
        [FieldOffset(12)]
        public int Index;
        public static JsValue Null
        {
            get { return new JsValue() { Type = JsValueType.Null }; }
        }

        public static JsValue Empty
        {
            get { return new JsValue() { Type = JsValueType.Empty }; }
        }

        public static JsValue Error(int slot)
        {
            return new JsValue { Type = JsValueType.ManagedError, Index = slot };
        }

        public override string ToString()
        {
            return string.Format("[JsValue({0})]", Type);
        }
    }
    public enum JsValueType
    {
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
        JsTypeWrap = 18
    }
    public class NativeBrowser : Cef3RefCountingValue
    {
        public NativeBrowser(IntPtr ptr) : base(ptr)
        {

        }


    }
    public class NativeFrame : Cef3RefCountingValue
    {
        public NativeFrame(IntPtr ptr) : base(ptr)
        {

        }
        public string GetUrl()
        {

            unsafe
            {
                char[] buffer = new char[255];
                int actualLength = 0;
                fixed (char* buffer_head = &buffer[0])
                {
                    Cef3Binder.MyCefFrame_GetUrl(Ptr, buffer_head, 255, ref actualLength);
                    return new string(buffer_head);
                }
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