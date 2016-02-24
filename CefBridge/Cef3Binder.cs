//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{
    public delegate void SimpleDel();

    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MyCefCallback(int id, IntPtr args);


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
    //typedef void (*managed_callback)(int id,
    //const wchar_t* methodName,
    //const wchar_t* inputDataString,
    //void* outputDataBuffer,size_t outputLen);


    public abstract class Cef3InitEssential
    {

        public readonly string[] startArgs;
        public Cef3InitEssential(string[] startArgs)
        {
            this.startArgs = startArgs;
        }
        public abstract void AfterProcessLoad(CefStartArgs args);
        public abstract CefClientApp CreateClientApp();
        public abstract IWindowForm CreateNewWindow(int width, int height);
        public abstract IWindowForm CreateNewBrowserWindow(int width, int height, string initURL);
        public abstract void SaveUIInvoke(SimpleDel simpleDel);
        public abstract IntPtr CefReady();

    }


    public static class Cef3Binder
    {

        static Cef3InitEssential cefInitEssential;
        //-------------------------------------------------
         
        static IntPtr hModule;
        //------------------------------------------------- 
#if DEBUG
        public static bool s_dbugIsRendererProcess;
        //static string libPath = @"..\\..\\..\\cef3\\cefclient\Debug\";
        //static string libPath = @"..\\..\\..\\cef3\\cefsimple\Debug\";
        //static string libPath = @"..\\..\\..\\cef3\\cefclient\Debug\";
        //static string libPath = @"..\\..\\..\\cef3\\cefsimple\Release\"; 
        static string libPath = @"D:\projects\CefBridge\cef3_output\cefclient\Debug\";
        const string CEF_CLIENT_DLL = "cefclient.dll";
        //const string CEF_CLIENT_DLL = "cefsimple.dll";
#else

        static string libPath = @"D:\projects\CefBridge\cef3_output\cefclient\Release\";
        const string CEF_CLIENT_DLL = "cefclient.dll";
#endif

        static MyCefCallback managedListener0;
        static MyCefCallback managedListener1;

        static bool _loadCef3Success = false;
        static CefClientApp clientApp;
        static CustomSchemeAgent customScheme;

        //-------------------------------------------------
        public static bool IsLoadCef3Success()
        {
            return _loadCef3Success;
        }
        public static void CefReady()
        {
            cefInitEssential.CefReady();
        }
        public static IWindowForm CreateBlankForm(int width, int height)
        {
            return cefInitEssential.CreateNewWindow(width, height);
        }
        public static IWindowForm CreateNewBrowserWindow(int width, int height, string initURL)
        {
            return cefInitEssential.CreateNewBrowserWindow(width, height, initURL);
        }
        public static void SafeUIInvoke(SimpleDel del)
        {
            cefInitEssential.SaveUIInvoke(del);
        }
        //static int dbugTotalId = 0;
        //static object lock1 = new object();

        public static bool LoadCef3(Cef3InitEssential cefInitEssential)
        {
            Cef3Binder.cefInitEssential = cefInitEssential;

            //follow these steps
            // 1. libcef
            if (!LoadLibCef())
            {
                return false;
            }
            //2. cef client
            string lib = libPath + CEF_CLIENT_DLL;  //; "cefclient.dll";
            IntPtr nativeModule = NativeMethods.LoadLibrary(lib);
            uint lastErr = NativeMethods.GetLastError();
            //------------------------------------------------
            hModule = nativeModule;
            if (nativeModule == IntPtr.Zero)
            {
                return false;
            }
            _loadCef3Success = true;

            //-----------------------------------------------------------
            //check start up process to see if what is this process
            //browser process
            //render process

            string[] startArgs = cefInitEssential.startArgs;
            if (startArgs.Length > 0)
            {

                CefStartArgs cefStartArg = CefStartArgs.Parse(startArgs);
#if DEBUG   
                cefInitEssential.AfterProcessLoad(cefStartArg);
#endif

            }

            //-----------------------------------------------------------

            //check version
            //1.
            int myCefVersion = MyCefGetVersion();
            //-----------------------------------------------------------
            //2. 
            managedListener0 = new MyCefCallback(Cef3callBack_ForMangedCallBack02);
            //3. unmanaged side can call back to this managed part

            int regResult = RegisterManagedCallBack(managedListener0, 0);
            //-----------------------------------------------------------
            //again ... another managed 
            //int i = 0;
            //lock (lock1)
            //{
            //    i = dbugTotalId++;
            //}


            managedListener1 = new MyCefCallback(Cef3callBack_ForMangedCallBack03);
            regResult = RegisterManagedCallBack(managedListener1, 1);
            //-----------------------------------------------------------
            //init cef            
            clientApp = cefInitEssential.CreateClientApp(); // System.Diagnostics.Process.GetCurrentProcess().Handle);

            //set some scheme here   
            //-----------------------------------------------------------
            //test***
            //register custom scheme 
            //-----------------------------------------------------------

            // if (!MyCefUseMultiMessageLoop())
            //{
            //cefInitEssential.SetCefMessageBump((s, e) =>
            //{
            //    MyCefDoMessageLoopWork();
            //});
            //System.Windows.Forms.Application.Idle += (sender, e) =>
            //{ 
            //    MyCefDoMessageLoopWork(); 
            //};

            // }
#if DEBUG
            Console.WriteLine(regResult);
#endif
            return true;
        }
        static bool LoadLibCef()
        {
            uint lastErr = 0;

            //if (!File.Exists(libPath + "icudt.dll"))
            //{
            //    return false;
            //}
            if (!File.Exists(libPath + "libcef.dll"))
            {

                return false;
            }

            IntPtr libCefModuleHandler;
            {
                //string lib = libPath + "icudt.dll";
                //libCefModuleHandler = NativeMethods.LoadLibrary(lib);
                //lastErr = NativeMethods.GetLastError();
            }
            {
                string lib = libPath + "libcef.dll";
                //Console.WriteLine(lib);
                libCefModuleHandler = NativeMethods.LoadLibrary(lib);

                //Console.WriteLine(libCefModuleHandler);
                lastErr = NativeMethods.GetLastError();

                //Console.WriteLine(lastErr);
            }

            return lastErr == 0;
        }
        static void Cef3callBack_ForMangedCallBack02(int oindex, IntPtr args)
        {

        }
        static void Cef3callBack_ForMangedCallBack03(int oindex, IntPtr args)
        {


        }
        //---------------------------------------------------
        //Cef
        //---------------------------------------------------
        //part 1: 

        //1.
        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefGetVersion();
        //2.
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int RegisterManagedCallBack(MyCefCallback funcPtr, int callbackKind);
        //3.
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateClientApp(IntPtr processHandle);

        //4. 
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateMyWebBrowser(MyCefCallback mxcallback);

        //5.
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetupBrowserHwnd(IntPtr myCefBrowser, IntPtr hWndParent, int x, int y, int width, int height, string initUrl);
        //6.
        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefDoMessageLoopWork();
        //7.
        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefShutDown();

        //--------------------------------------------------- 

        //part 2:
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMetArgs_SetResultAsJsValue(IntPtr nativeMetPtr, int retIndex, IntPtr ptr);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern JsValue MyCefNativeMetGetArgs(IntPtr cbArgPtr, int index);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefDisposePtr(IntPtr ptr);

        //part3:
        //--------------------------------------------------- 
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern unsafe void MyCefBwNavigateTo(IntPtr myCefBw, string urlAddress);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefBwExecJavascript(IntPtr myCefBw, string jssource, string scripturl);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefBwPostData(IntPtr myCefBw, string url, byte[] data, int len);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefShowDevTools(IntPtr myCefBw, IntPtr myCefDevTool, IntPtr parentWindow);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwGoBack(IntPtr myCefBw);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwGoForward(IntPtr myCefBw);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwStop(IntPtr myCefBw);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwReload(IntPtr myCefBw);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefBwReloadIgnoreCache(IntPtr myCefBw);
        //--------------------------------------------------- 



        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefDomGetTextWalk(IntPtr g_ClientHandler, MyCefCallback strCallBack);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefDomGetSourceWalk(IntPtr g_ClientHandler, MyCefCallback strCallBack);




        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static unsafe extern void MyCefMetArgs_SetResultAsString(
            IntPtr callArgsPtr,
            int resultIndex,
            string str, int strlen);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void MyCefMetArgs_SetResultAsByteBuffer(
            IntPtr callArgsPtr,
            int resultIndex,
            IntPtr str, int len);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMetArgs_SetResultAsInt32(
           IntPtr callArgsPtr,
           int resultIndex,
           int value);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern void MyCef_CefRegisterSchemeHandlerFactory(
           string schemeName,
           string startURL,
           IntPtr clientSchemeHandlerFactoryObject);



        //part 4
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJsGetGlobal(IntPtr jsContext);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJs_New_V8Handler(MyCefCallback managedCallback);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern void MyCefJs_CefV8Value_SetValue_ByString(IntPtr target, string key, IntPtr value, int setAttr);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefJs_CefV8Value_SetValue_ByIndex(IntPtr target, int index, IntPtr value);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern IntPtr MyCefJs_CreateFunction(string name, IntPtr handler);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefFrame_GetUrl(IntPtr myCefFrame, char* outputBuffer, int outputBufferLen, ref int actualLength);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefString_Read(IntPtr cefStr, char* outputBuffer, int outputBufferLen, ref int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefStringHolder_Read(IntPtr mycefStrHolder, char* outputBuffer, int outputBufferLen, ref int actualLength);

    }


    internal static class NativeMethods
    {

        //-----------------------------------------------
        //this is Windows Specific class ***
        [DllImport("Kernel32.dll")]
        public static extern IntPtr LoadLibrary(string libraryName);
        [DllImport("Kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
        [DllImport("Kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("Kernel32.dll")]
        public static extern uint SetErrorMode(int uMode);
        [DllImport("Kernel32.dll")]
        public static extern uint GetLastError();
        //-----------------------------------------------

    }




}
