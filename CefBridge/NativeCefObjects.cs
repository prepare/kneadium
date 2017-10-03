//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{


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

    [StructLayout(LayoutKind.Sequential)]
    public struct JsValue
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
        JsTypeWrap = 18,
        Int64 = 19,
        Buffer = 20,
        NativeCefString = 30,
        JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING = 31,
        JSVALUE_TYPE_MANAGED_CB = 32,
        MemError = 50,
    }

}