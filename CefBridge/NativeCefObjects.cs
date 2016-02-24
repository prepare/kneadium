//2015-2016 MIT, WinterDev
using System;
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