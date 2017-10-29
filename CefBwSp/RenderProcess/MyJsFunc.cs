//MIT, 2016-2017, WinterDev

using System;
using System.IO;
using LayoutFarm.CefBridge.Auto;
namespace LayoutFarm.CefBridge
{
    //all funcs here are designed to exec on renderer side 


    public abstract class MyJsFuncBase : IDisposable
    {
#if DEBUG
        protected string _dbugUserJsCode;
#endif
        protected CefV8Value _cefV8Func;
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="userJsCode"></param>
        /// <returns></returns>
        protected static bool CreateFromJsCode(CefV8Context ownerContext,
            string userJsCode,
            out IntPtr nativeFunc)
        {
            IntPtr ret = IntPtr.Zero;
            IntPtr exception = IntPtr.Zero;
            //eval in js side  

            if (ownerContext.Eval(userJsCode, "", 1, ref ret, ref exception))
            {
                nativeFunc = ret;
                return true;
            }
            else
            {
                //dispose 
                nativeFunc = IntPtr.Zero;
                CefV8Exception v8Exception = new CefV8Exception(exception);
                v8Exception.Dispose();
                return false;
            }
        }

        public void Dispose()
        {
            //TODO: review here
            _cefV8Func.Dispose();
        }
    }

    /// <summary>
    /// js func, no args
    /// </summary>
    public class MyJsFunc : MyJsFuncBase
    {
        private MyJsFunc() { }
        /// <summary>
        /// invoke as instance func 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public CefV8Value Invoke(CefV8Value obj)
        {
            CefV8ValueList argList = CefV8ValueList.NewList();
            CefV8Value innerFuncResult = _cefV8Func.ExecuteFunction(obj, argList);
            Cef3Binder.MyCefDeletePtr(argList.nativePtr);
            return innerFuncResult;
        }
        /// <summary>
        /// invoke as static func
        /// </summary>
        /// <returns></returns>
        public CefV8Value Invoke()
        {
            return Invoke(new CefV8Value());
        }

        /// <summary>
        /// create js func from userJsCode, userJsCode will be wraped with anonymous func before it is send to js
        /// </summary>
        /// <param name="ownerContext"></param>
        /// <param name="userJsCode"></param>
        /// <returns></returns>
        public static MyJsFunc Create(CefV8Context ownerContext, string userJsCode)
        {
            IntPtr v8JsFuncPtr;
            if (CreateFromJsCode(ownerContext,
                "(function(){ return " + userJsCode + "})()",
                out v8JsFuncPtr))
            {
                MyJsFunc func = new MyJsFunc();
                func._cefV8Func = new CefV8Value(v8JsFuncPtr);
                return func;
            }
            else
            {
                //not success
                return null;
            }
        }
    }



    enum ClrToV8ConversionKind
    {
        Unknown,
        FromString,
        FromDouble,
        FromInt32,
        FromUInt32,
        FromBool,
        FromArray,
        FromObject,
        //
        FromOpaqueObject,
    }
    static class JsValueArgTypeEvaluator<T>
    {

        static ClrToV8ConversionKind conversionKind;
        static JsValueArgTypeEvaluator()
        {
            conversionKind = GetConvKind(typeof(T));
        }
        static ClrToV8ConversionKind GetConvKind(Type t)
        {
            ClrToV8ConversionKind convKind = ClrToV8ConversionKind.Unknown;
            if (t == typeof(string))
            {
                convKind = ClrToV8ConversionKind.FromString;
            }
            else if (t == typeof(double))
            {
                //convert to number
                convKind = ClrToV8ConversionKind.FromDouble;
            }
            else if (t == typeof(int))
            {
                convKind = ClrToV8ConversionKind.FromInt32;

            }
            else if (t == typeof(uint))
            {
                convKind = ClrToV8ConversionKind.FromUInt32;
            }
            else if (t == typeof(bool))
            {
                convKind = ClrToV8ConversionKind.FromBool;
            }
            else if (t == typeof(object))
            {
                convKind = ClrToV8ConversionKind.FromObject;
            }
            else
            {
                //other type
                convKind = ClrToV8ConversionKind.Unknown;
            }
            return convKind;
        }
        public static CefV8Value ToV8Value(T value)
        {
            return InternalToV8Value(conversionKind, value);
        }
        static CefV8Value InternalToV8Value(ClrToV8ConversionKind convKind, object value)
        {
            switch (convKind)
            {
                case ClrToV8ConversionKind.FromOpaqueObject:

                    break;
                case ClrToV8ConversionKind.FromObject:
                    if (value == null)
                    {
                        return CefV8Value.CreateNull();
                    }
                    else
                    {
                        //get actual type of the value
                        ClrToV8ConversionKind actualConv;
                        return ((actualConv = GetConvKind(value.GetType())) == ClrToV8ConversionKind.FromObject) ?
                                InternalToV8Value(ClrToV8ConversionKind.FromOpaqueObject, value) :
                                InternalToV8Value(actualConv, value);
                    }
                case ClrToV8ConversionKind.FromString:
                    return CefV8Value.CreateString((string)value);
                case ClrToV8ConversionKind.FromDouble:
                    return CefV8Value.CreateDouble((double)value);
                case ClrToV8ConversionKind.FromInt32:
                    return CefV8Value.CreateInt((int)value);
                case ClrToV8ConversionKind.FromUInt32:
                    return CefV8Value.CreateUInt((uint)value);
                case ClrToV8ConversionKind.FromBool:
                    return CefV8Value.CreateBool((bool)value);
            }
            return new CefV8Value();
        }
    }

    public class MyJsFunc<T> : MyJsFuncBase
    {

        private MyJsFunc()
        {

        }
        /// <summary>
        /// create js func from userJsCode, userJsCode will be wraped with anonymous func before it is send to js
        /// </summary>
        /// <param name="ownerContext"></param>
        /// <param name="userJsCode"></param>
        /// <returns></returns>
        public static MyJsFunc<T> Create(CefV8Context ownerContext, string userJsCode)
        {
            IntPtr v8JsFuncPtr;
            if (CreateFromJsCode(ownerContext,
                "(function(){ return " + userJsCode + "})()",
                out v8JsFuncPtr))
            {
                MyJsFunc<T> func = new MyJsFunc<T>();
                func._cefV8Func = new CefV8Value(v8JsFuncPtr);
                return func;
            }
            else
            {
                //not success
                return null;
            }
        }
        /// <summary>
        /// invoke as static func, 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public CefV8Value Invoke(T a)
        {
            return Invoke(new CefV8Value(), a);
        }
        /// <summary>
        /// invoke as instance func
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public CefV8Value Invoke(CefV8Value obj, T a)
        {
            CefV8ValueList argList = CefV8ValueList.NewList();
            //append arg
            argList.AddElement(JsValueArgTypeEvaluator<T>.ToV8Value(a));

            CefV8Value innerFuncResult = _cefV8Func.ExecuteFunction(obj, argList);

            Cef3Binder.MyCefDeletePtr(argList.nativePtr);

            return innerFuncResult;
        }
    }

    public class MyJsFunc<T1, T2> : MyJsFuncBase
    {

        private MyJsFunc()
        {

        }
        /// <summary>
        /// create js func from userJsCode, userJsCode will be wraped with anonymous func before it is send to js
        /// </summary>
        /// <param name="ownerContext"></param>
        /// <param name="userJsCode"></param>
        /// <returns></returns>
        public static MyJsFunc<T1, T2> Create(CefV8Context ownerContext, string userJsCode)
        {
            IntPtr v8JsFuncPtr;
            if (CreateFromJsCode(ownerContext,
                "(function(){ return " + userJsCode + "})()",
                out v8JsFuncPtr))
            {
                MyJsFunc<T1, T2> func = new MyJsFunc<T1, T2>();
                func._cefV8Func = new CefV8Value(v8JsFuncPtr);
                return func;
            }
            else
            {
                //not success
                return null;
            }
        }
        /// <summary>
        /// invoke as static func, 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public CefV8Value Invoke(T1 a1, T2 a2)
        {
            return Invoke(new CefV8Value(), a1, a2);
        }
        /// <summary>
        /// invoke as instance func
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public CefV8Value Invoke(CefV8Value obj, T1 a1, T2 a2)
        {
            CefV8ValueList argList = CefV8ValueList.NewList();
            //append arg
            argList.AddElement(JsValueArgTypeEvaluator<T1>.ToV8Value(a1));
            argList.AddElement(JsValueArgTypeEvaluator<T2>.ToV8Value(a2));

            CefV8Value innerFuncResult = _cefV8Func.ExecuteFunction(obj, argList);

            Cef3Binder.MyCefDeletePtr(argList.nativePtr);

            return innerFuncResult;
        }
    }
}