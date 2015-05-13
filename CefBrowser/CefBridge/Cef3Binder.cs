//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{




    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate void ManagedListenerDel(int mIndex, [MarshalAs(UnmanagedType.LPWStr)]string methodName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    delegate string ManagedListenerDel3(int mIndex, [MarshalAs(UnmanagedType.LPWStr)]string methodName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CefStringCallback(int id, [MarshalAs(UnmanagedType.LPWStr)]string content);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    unsafe delegate void AgentManagedCallback(int id, IntPtr args);

    struct MyTxString
    {
        public int Len;
        public IntPtr data;
        public string GetString()
        {
            unsafe
            {
                return new string((char*)data, 0, Len);
            }
        }
        public void Dispose()
        {
            Cef3Binder.DisposeTxString(this);
            //clear unmanaged memory
            this.data = IntPtr.Zero;
            this.Len = 0;
        }
    }
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
        //-------------------------------------------------
        static bool isLoad;
        static IntPtr hModule;
        //------------------------------------------------- 
#if DEBUG
        static string libPath = @"..\\..\\..\\cef3\\cefclient\Debug\";
        //static string libPath = @"..\\..\\..\\cef3\\cefclient\Release\"; 
        const string CEF_CLIENT_DLL = "cefclient.dll";
#else
        
        static string libPath = @"..\\..\\..\\cef3\out\Release\";
#endif

        static ManagedListenerDel managedListener;
        static ManagedListenerDel3 managedListener3;
        static IntPtr cef3CallbackPtr;
        static IntPtr cef3CallbackPtr_3;
        static bool _loadCef3Success = false;
        static CefClientApp clientApp;
        static CustomSchemeAgent customScheme;

        //-------------------------------------------------
        public static bool IsLoadCef3Success()
        {
            return _loadCef3Success;
        }
        public static void LoadCef3()
        {
            //follow these steps
            // 1. libcef
            if (!LoadLibCef())
            {
                return;
            }
            //2. cef client
            string lib = libPath + CEF_CLIENT_DLL;  //; "cefclient.dll";
            IntPtr nativeModule = NativeMethods.LoadLibrary(lib);
            uint lastErr = NativeMethods.GetLastError();
            //------------------------------------------------
            hModule = nativeModule;
            if (nativeModule == IntPtr.Zero)
            {
                return;
            }
            _loadCef3Success = true;
            //check version

            int myCefVersion = MyCefGetVersion();
            //-----------------------------------------------------------
            //1. 
            managedListener = new ManagedListenerDel(Cef3callBack_ForMangedCallBack02);
            //2. 
            cef3CallbackPtr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(managedListener);
            //3. unmanaged side can call back to this managed part
            int regResult = RegisterManagedCallBack(cef3CallbackPtr, 0);
            //-----------------------------------------------------------
            //again ... another managed
            managedListener3 = new ManagedListenerDel3(Cef3callBack_ForMangedCallBack03);
            cef3CallbackPtr_3 = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(managedListener3);
            regResult = RegisterManagedCallBack(cef3CallbackPtr_3, 3);
            //-----------------------------------------------------------
            //init cef 

            clientApp = new CefClientApp();
            //set some scheme here


            clientApp.InitWithProcessHandle(System.Diagnostics.Process.GetCurrentProcess().Handle);

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
                libCefModuleHandler = NativeMethods.LoadLibrary(lib);
                lastErr = NativeMethods.GetLastError();
            }

            return lastErr == 0;
        }
        static void Cef3callBack_ForMangedCallBack02(int oindex, string name)
        {
            Console.WriteLine(oindex.ToString() + " " + name);
        }
        static string Cef3callBack_ForMangedCallBack03(int oindex, string name)
        {
            return null;
        }


        //---------------------------------------------------
        [DllImport(CEF_CLIENT_DLL)]
        public static extern int RegisterManagedCallBack(IntPtr funcPtr, int callbackKind);

        //---------------------------------------------------
        //Cef
        //---------------------------------------------------

        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefGetVersion();

        [DllImport(CEF_CLIENT_DLL)]
        internal static extern IntPtr MyCefCreateClientApp(IntPtr mainContext);

        [DllImport(CEF_CLIENT_DLL)]
        internal static extern void MyCefClientAppSetManagedCallback(IntPtr clientApp, AgentManagedCallback callback);


        [DllImport(CEF_CLIENT_DLL)]
        public static extern IntPtr MyCefInit(IntPtr processHandle, IntPtr clientAppHandle);

        [DllImport(CEF_CLIENT_DLL)]
        public static extern bool MyCefUseMultiMessageLoop();
        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefShutDown();

        //---------------------------------------------------
        [DllImport(CEF_CLIENT_DLL)]
        public static extern IntPtr MyCefCreateClientHandler(IntPtr mainContext, IntPtr hWndParent, int x, int y, int width, int height);
        //[DllImport(CEF_CLIENT_DLL)]
        //static extern int MyCefSetupWindowsBegin(IntPtr clientHandler, IntPtr parentWindow);
        //[DllImport(CEF_CLIENT_DLL)]
        //static extern void MyCefSetupWindowsEnd(IntPtr clientHandler, IntPtr hWndParent, int x, int y, int width, int height);
        ////---------------------------------------------------
        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefRunMessageLoop();
        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefDoMessageLoopWork();

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefCloseHandler(IntPtr handle);

        [DllImport(CEF_CLIENT_DLL, CharSet = CharSet.Unicode)]
        public static extern unsafe void NavigateTo(IntPtr clientHandler, string urlAddress);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void ExecJavascript(IntPtr clientHandler, string jssource, string scripturl);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void PostData(IntPtr clientHandler, string url, byte[] data, int len);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void DomGetTextWalk(IntPtr g_ClientHandler, CefStringCallback strCallBack);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void DomGetSourceWalk(IntPtr g_ClientHandler, CefStringCallback strCallBack);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void AgentRegisterManagedCallback(IntPtr g_ClientHandler, AgentManagedCallback agentManagedCallback);


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern JsValue MyCefCbArgs_GetArg(IntPtr cbArgPtr, int index);


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


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void DisposeTxString(MyTxString myTxString);


        //public static void SetupCefWindow(IntPtr clientHandler, IntPtr parentWindow,
        //    int x, int y, int width, int height)
        //{
        //    Cef3Binder.MyCefSetupWindowsBegin(clientHandler, parentWindow);
        //    Cef3Binder.MyCefSetupWindowsEnd(clientHandler, parentWindow, x, y, width, height);
        //    //Cef3Binder.MyCefDoMessageLoopWork();
        //}
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
