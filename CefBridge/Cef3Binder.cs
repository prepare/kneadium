//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{
    public delegate void SimpleDel();

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void MyCefCallback(int id, IntPtr args);
    //----------------------------------------------------------------------
    //cef msg constant
    //----------------------------------------------------------------------

    public enum LogServerify
    {
        ///
        // Default logging (currently INFO logging).
        ///
        LOGSEVERITY_DEFAULT,

        ///
        // Verbose logging.
        ///
        LOGSEVERITY_VERBOSE,

        ///
        // INFO logging.
        ///
        LOGSEVERITY_INFO,

        ///
        // WARNING logging.
        ///
        LOGSEVERITY_WARNING,

        ///
        // ERROR logging.
        ///
        LOGSEVERITY_ERROR,

        ///
        // Completely disable logging.
        ///
        LOGSEVERITY_DISABLE = 99
    }


    public enum MyCefMsg
    {
        MYCEF_MSG_UNKNOWN = 0,

        CEF_MSG_ClientHandler_NotifyBrowserClosing = 100,
        CEF_MSG_ClientHandler_NotifyBrowserClosed = 101,
        CEF_MSG_ClientHandler_NotifyBrowserCreated = 102,


        CEF_MSG_ClientHandler_OnBeforePopup = 104,
        CEF_MSG_ClientHandler_OnConsoleMessage = 106,
        CEF_MSG_ClientHandler_ShowDevTools = 107,
        CEF_MSG_ClientHandler_CloseDevTools = 108,
        CEF_MSG_ClientHandler_OnBeforeContextMenu = 109,
        CEF_MSG_ClientHandler_BeforeDownload = 110,
        CEF_MSG_ClientHandler_DownloadUpdated = 111,
        CEF_MSG_ClientHandler_OnLoadError = 119,
        CEF_MSG_ClientHandler_OnCertError = 120,
        CEF_MSG_ClientHandler_ExecCustomProtocol = 121,

        CEF_MSG_ClientHandler_SetResourceManager = 140,
        CEF_MSG_RequestUrlFilter2 = 142,
        CEF_MSG_BinaryResouceProvider_OnRequest = 145,

        //
        CEF_MSG_CefSettings_Init = 150,
        CEF_MSG_MainContext_GetConsoleLogPath = 151,
        CEF_MSG_OSR_Render = 155,
        //
        CEF_MSG_RenderDelegate_OnWebKitInitialized = 201,
        CEF_MSG_RenderDelegate_OnContextCreated = 202,
        CEF_MSG_RenderDelegate_OnContextReleased = 203,
        CEF_MSG_OnQuery = 205,
        CEF_MSG_ClientHandler_OnPreKeyEvent = 501,
        CEF_MSG_ClientHandler_NotifyTitle = 502,
        CEF_MSG_ClientHandler_NotifyAddress = 503,
    }

    enum CefSettingsKey
    {
        CEF_SETTINGS_BrowserSubProcessPath = 9,
        CEF_SETTINGS_CachePath = 10,
        CEF_SETTINGS_ResourcesDirPath = 11,
        CEF_SETTINGS_UserDirPath = 12,
        CEF_SETTINGS_LocalDirPath = 14,
        CEF_SETTINGS_IgnoreCertError = 15,
        CEF_SETTINGS_RemoteDebuggingPort = 17,

        CEF_SETTINGS_LogFile = 18,
        CEF_SETTINGS_LogSeverity = 19,
    }

    static class Cef3Binder
    {
        static Cef3InitEssential cefInitEssential;
        const string CEF_CLIENT_DLL = "cefclient.dll";
#if DEBUG
        public static bool s_dbugIsRendererProcess;
#endif 
      
        static CefClientApp clientApp;
        static CustomSchemeAgent customScheme;
        public static IWindowForm CreateBlankForm(int width, int height)
        {
            return cefInitEssential.CreateNewWindow(width, height);
        }
        public static IWindowForm CreateNewBrowserWindow(int width, int height)
        {
            return cefInitEssential.CreateNewBrowserWindow(width, height);
        }
        public static void SafeUIInvoke(SimpleDel del)
        {
            cefInitEssential.SaveUIInvoke(del);
        }

        public static bool LoadCef3(Cef3InitEssential cefInitEssential)
        {
            Cef3Binder.cefInitEssential = cefInitEssential;
            //follow these steps
            // 1. libcef
            if (!LoadNativeLibs(cefInitEssential))
            {
                return false;
            }

            //-----------------------------------------------------------
            //check start up process to see if what is this process
            //browser process
            //render process

            string[] startArgs = cefInitEssential.startArgs;
            if (startArgs.Length > 0)
            {
                CefStartArgs cefStartArg = CefStartArgs.Parse(startArgs);
                Cef3InitEssential.IsInRenderProcess = (cefStartArg.IsValidCefArgs && cefStartArg.ProcessType == "renderer");
                Cef3InitEssential.IsInMainProcess = (cefStartArg.IsValidCefArgs && cefStartArg.ProcessType == "");
                cefInitEssential.AfterProcessLoaded(cefStartArg);
            }
            else
            {
                Cef3InitEssential.IsInMainProcess = true;
            }
            //----------------------------------------------------------- 
            //check version
            //1.
            int myCefVersion = MyCefGetVersion();
            //-----------------------------------------------------------
            //2. 
            //managedListener0 = new MyCefCallback(Cef3callBack_ForMangedCallBack0);
            //3. unmanaged side can call back to this managed part 
            //int regResult = RegisterManagedCallBack(managedListener0, 0);
            //-----------------------------------------------------------
            //again ... another managed 


            //managedListener1 = new MyCefCallback(Cef3callBack_ForMangedCallBack2);
            //regResult = RegisterManagedCallBack(managedListener1, 1);
            //-----------------------------------------------------------
            //init cef  

            clientApp = cefInitEssential.CreateClientApp(); // System.Diagnostics.Process.GetCurrentProcess().Handle);
            return true;
        }

        static bool LoadNativeLibs(Cef3InitEssential initEssential)
        {

            //in version 3.2885.1548 (chrome 55+)
            NativeMethods.LoadLibrary(cefInitEssential.GetLibChromeElfFileName());

            //1. lib cef
            string lib = initEssential.GetLibCefFileName();
            //if (!File.Exists(lib))
            //{
            //    initEssential.AddLogMessage("not found " + lib);
            //    return false;
            //}

            //IntPtr libCefModuleHandler;
            //{
            //    //string lib = libPath + "icudt.dll";
            //    //libCefModuleHandler = NativeMethods.LoadLibrary(lib);
            //    //lastErr = NativeMethods.GetLastError();
            //}
            //Console.WriteLine(lib);
            int tryLoadCount = 0;
        TRY_AGAIN:
            uint lastErr = 0;
            IntPtr libCefModuleHandler = NativeMethods.LoadLibrary(lib);
            //Console.WriteLine(libCefModuleHandler);
            if (libCefModuleHandler == IntPtr.Zero)
            {
                lastErr = NativeMethods.GetLastError();
                if (lastErr != 0)
                {
                    if (lastErr == 2 & tryLoadCount < 3)
                    {
                        //if not finish
                        //System.Threading.Thread.Sleep(100);
                        tryLoadCount++;
                        goto TRY_AGAIN;
                    }
                    initEssential.AddLogMessage("load err code" + lastErr);
                    return false;
                }
            }

            //------------------------------------------------------------------
            //2. cef client
            lib = cefInitEssential.GetCefClientFileName();
            //if (!File.Exists(lib))
            //{
            //    initEssential.AddLogMessage("not found " + lib);
            //    return false;
            //}
            IntPtr nativeModule = NativeMethods.LoadLibrary(lib);
            lastErr = NativeMethods.GetLastError();
            //------------------------------------------------
            if (nativeModule == IntPtr.Zero)
            {
                return false;
            }
            return true;
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
        //3.1
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefEnableKeyIntercept(IntPtr myCefBrowser, int enable);
        //4. 
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateMyWebBrowser(MyCefCallback mxcallback);
        //4. OSR
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateMyWebBrowserOSR(MyCefCallback mxcallback);
        //5.
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetupBrowserHwnd(IntPtr myCefBrowser, IntPtr hWndParent, int x, int y, int width, int height, string initUrl, IntPtr requestContext);
        //5. OSR
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetupBrowserHwndOSR(IntPtr myCefBrowser, IntPtr hWndParent, int x, int y, int width, int height, string initUrl, IntPtr requestContext);

        //6.
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefCloseMyWebBrowser(IntPtr myCefBrowser);

        //7.
        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefDoMessageLoopWork();
        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefQuitMessageLoop();
        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefShutDown();



        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetInitSettings(IntPtr cefSetting, int keyName, string value);
        //--------------------------------------------------- 

        //part 2:
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMetArgs_SetResultAsJsValue(IntPtr nativeMetPtr, int retIndex, IntPtr ptr);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern JsValue MyCefNativeMetGetArgs(IntPtr cbArgPtr, int index);
        //part3:
        //--------------------------------------------------- 
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern unsafe void MyCefBwNavigateTo(IntPtr myCefBw, string urlAddress);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefBwExecJavascript(IntPtr myCefBw, string jssource, string scripturl);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefBwExecJavascript2(IntPtr nativeWb, string jssource, string scripturl);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetBrowserSize(IntPtr myCefBw, int w, int h);
        //--------------------------------------------------- 



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
        public static unsafe extern void MyCefMetArgs_SetInputAsString(
           IntPtr callArgsPtr,
           int resultIndex,
           string str, int strlen);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static unsafe extern void MyCefMetArgs_SetInputAsInt32(
            IntPtr callArgsPtr,
            int resultIndex,
            int value);
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
        //part 4 js binding
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJsGetCurrentContext();
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefJsNotifyRenderer(MyCefCallback handler, IntPtr pars);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJs_GetEnteredContext();
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJsFrameContext(IntPtr nativeFrame);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJsGetGlobal(IntPtr jsContext);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJs_EnterContext(IntPtr cefV8Context);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefJs_ExitContext(IntPtr cefV8Context);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJs_New_V8Handler(MyCefCallback managedCallback);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern void MyCefJs_CefV8Value_SetValue_ByString(IntPtr target, string key, IntPtr value, int setAttr);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern bool MyCefJs_CefV8Value_IsFunc(IntPtr target);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefJs_CefV8Value_SetValue_ByIndex(IntPtr target, int index, IntPtr value);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern IntPtr MyCefCreateCefString(string str);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern IntPtr MyCefJs_CreateFunction(string name, IntPtr handler);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static unsafe extern IntPtr MyCefJs_ExecJsFunctionWithContext(IntPtr cefJsFunc, IntPtr context, char* argAsJsonString);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern bool MyCefJs_CefRegisterExtension(string extensionName, string extensionCode);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefFrame_GetUrl(IntPtr myCefFrame, char* outputBuffer, int outputBufferLen, ref int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefString_Read(IntPtr cefStr, char* outputBuffer, int outputBufferLen, ref int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefStringHolder_Read(IntPtr mycefStrHolder, char* outputBuffer, int outputBufferLen, ref int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern unsafe void MyCefJs_CefV8Value_ReadAsString(IntPtr cefV8Value, char* outputBuffer, int outputBufferLen, ref int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MyCefJs_MetReadArgAsInt32(IntPtr jsArgs, int index);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefJs_MetReadArgAsString(IntPtr jsArgs, int index, char* outputBuffer, int outputBufferLen, ref int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe IntPtr MyCefJs_MetReadArgAsCefV8Value(IntPtr jsArgs, int index);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe IntPtr MyCefJs_MetReadArgAsV8FuncHandle(IntPtr jsArgs, int index);
        //[DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        //public static extern IntPtr CreateMethodArgs();
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeMethodArgs(IntPtr methodArgs);
    }

    public static class CefBinder2
    {
        public static bool RegisterCefExtension(string extensionName, string extensionCode)
        {
            return Cef3Binder.MyCefJs_CefRegisterExtension(extensionName, extensionCode);
        }
        public static void DisposeNativeCallArgs(NativeCallArgs nativeCallArgs)
        {
            Cef3Binder.DisposeMethodArgs(nativeCallArgs._argPtr);
        }
        public static IntPtr CefCreateString(string a)
        {
            return Cef3Binder.MyCefCreateCefString(a);
        }

        public static void NotifyRendererAsync(MyCefCallback callback)
        {
            Cef3Binder.MyCefJsNotifyRenderer(callback, IntPtr.Zero);
        }
    }

    static class NativeMethods
    {
        //TODO: review here, check for other platforms
        //-----------------------------------------------
        //this is Windows Specific class ***
        [DllImport("Kernel32.dll")]
        public static extern IntPtr LoadLibrary(string libraryName);
        [DllImport("Kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
        //[DllImport("Kernel32.dll")]
        //public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("Kernel32.dll")]
        public static extern uint SetErrorMode(int uMode);
        [DllImport("Kernel32.dll")]
        public static extern uint GetLastError();
        //-----------------------------------------------

    }
}
