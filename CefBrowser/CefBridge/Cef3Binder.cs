//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{

    //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MyCefCallback(int id, IntPtr args);

  
    [StructLayout(LayoutKind.Explicit)]
    struct JsValue
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
    enum JsValueType
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


    static class Cef3Binder
    {

        internal static bool s_IsRendererProcess;
        //-------------------------------------------------
        static bool isLoad;
        static IntPtr hModule;
        //------------------------------------------------- 
#if DEBUG
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
            clientApp.CefReady();
        }

        //static int dbugTotalId = 0;
        //static object lock1 = new object();

        public static bool LoadCef3(string[] startArgs)
        {
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

            if (startArgs.Length > 0)
            {


                CefStartArgs cefStartArg = CefStartArgs.Parse(startArgs);
#if DEBUG

                if (cefStartArg.IsValidCefArgs && cefStartArg.ProcessType == "renderer")
                {
                    StringBuilder stbuilder = new StringBuilder();
                    foreach (var str in startArgs)
                    {
                        stbuilder.Append(str + " ");
                    }
                    s_IsRendererProcess = true;
                    //System.Windows.Forms.MessageBox.Show(stbuilder.ToString(), DateTime.Now.ToString());
                    //set break point after alert if we want to stop debugger                            
                }

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
            clientApp = new CefClientApp(System.Diagnostics.Process.GetCurrentProcess().Handle);

            //set some scheme here   
            //-----------------------------------------------------------
            //test***
            //register custom scheme 


            //-----------------------------------------------------------

            // if (!MyCefUseMultiMessageLoop())
            //{

            System.Windows.Forms.Application.Idle += (sender, e) =>
            {

                MyCefDoMessageLoopWork();

            };

            // }

            Console.WriteLine(regResult);
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
        internal static extern IntPtr MyCefCreateClientApp(IntPtr processHandle);

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
        //--------------------------------------------------- 



        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void DomGetTextWalk(IntPtr g_ClientHandler, MyCefCallback strCallBack);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void DomGetSourceWalk(IntPtr g_ClientHandler, MyCefCallback strCallBack);




        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static unsafe extern void MyCefMetArgs_SetResultAsString(
            IntPtr callArgsPtr,
            int resultIndex,
            string str, int strlen);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void MyCefCbArgs_SetResultAsBuffer(
            IntPtr callArgsPtr,
            int resultIndex,
            byte* resultBuffer, int strlen);

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
    }


    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetFocus();

        //-----------------------------------------------
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

    [Flags]
    internal enum SetWindowPosFlags : uint
    {
        /// <summary>
        /// If the calling thread and the thread that owns the window are attached to different input queues, 
        /// the system posts the request to the thread that owns the window. This prevents the calling thread from 
        /// blocking its execution while other threads process the request.
        /// </summary>
        /// <remarks>SWP_ASYNCWINDOWPOS</remarks>
        AsyncWindowPosition = 0x4000,

        /// <summary>
        /// Prevents generation of the WM_SYNCPAINT message.
        /// </summary>
        /// <remarks>SWP_DEFERERASE</remarks>
        DeferErase = 0x2000,

        /// <summary>
        /// Draws a frame (defined in the window's class description) around the window.
        /// </summary>
        /// <remarks>SWP_DRAWFRAME</remarks>
        DrawFrame = 0x0020,

        /// <summary>
        /// Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to 
        /// the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE 
        /// is sent only when the window's size is being changed.
        /// </summary>
        /// <remarks>SWP_FRAMECHANGED</remarks>
        FrameChanged = 0x0020,

        /// <summary>
        /// Hides the window.
        /// </summary>
        /// <remarks>SWP_HIDEWINDOW</remarks>
        HideWindow = 0x0080,

        /// <summary>
        /// Does not activate the window. If this flag is not set, the window is activated and moved to the 
        /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).
        /// </summary>
        /// <remarks>SWP_NOACTIVATE</remarks>
        NoActivate = 0x0010,

        /// <summary>
        /// Discards the entire contents of the client area. If this flag is not specified, the valid contents 
        /// of the client area are saved and copied back into the client area after the window is sized or repositioned.
        /// </summary>
        /// <remarks>SWP_NOCOPYBITS</remarks>
        NoCopyBits = 0x0100,

        /// <summary>
        /// Retains the current position (ignores X and Y parameters).
        /// </summary>
        /// <remarks>SWP_NOMOVE</remarks>
        NoMove = 0x0002,

        /// <summary>
        /// Does not change the owner window's position in the Z order.
        /// </summary>
        /// <remarks>SWP_NOOWNERZORDER</remarks>
        NoOwnerZOrder = 0x0200,

        /// <summary>
        /// Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to 
        /// the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent 
        /// window uncovered as a result of the window being moved. When this flag is set, the application must 
        /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
        /// </summary>
        /// <remarks>SWP_NOREDRAW</remarks>
        NoRedraw = 0x0008,

        /// <summary>
        /// Same as the SWP_NOOWNERZORDER flag.
        /// </summary>
        /// <remarks>SWP_NOREPOSITION</remarks>
        NoReposition = 0x0200,

        /// <summary>
        /// Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
        /// </summary>
        /// <remarks>SWP_NOSENDCHANGING</remarks>
        NoSendChanging = 0x0400,

        /// <summary>
        /// Retains the current size (ignores the cx and cy parameters).
        /// </summary>
        /// <remarks>SWP_NOSIZE</remarks>
        NoSize = 0x0001,

        /// <summary>
        /// Retains the current Z order (ignores the hWndInsertAfter parameter).
        /// </summary>
        /// <remarks>SWP_NOZORDER</remarks>
        NoZOrder = 0x0004,

        /// <summary>
        /// Displays the window.
        /// </summary>
        /// <remarks>SWP_SHOWWINDOW</remarks>
        ShowWindow = 0x0040,
    }




}
