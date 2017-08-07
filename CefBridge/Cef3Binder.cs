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

    public enum LogServerity
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
        //
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
        //
        CEF_MSG_MyCefDomGetTextWalk_Visit = 302,
        CEF_MSG_MyV8ManagedHandler_Execute = 301,
        CEF_MSG_HereOnRenderer = 303,

        CEF_MSG_ClientHandler_OnPreKeyEvent = 501,
        CEF_MSG_ClientHandler_NotifyTitle = 502,
        CEF_MSG_ClientHandler_NotifyAddress = 503,
    }

    public enum CefSettingsKey
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

    public struct MyCefStringVisitor
    {
        internal IntPtr nativePtr;
        internal MyCefStringVisitor(IntPtr ptr)
        {
            this.nativePtr = ptr;
        }
        public void Release()
        {
            Cef3Binder.MyCefRelease(this.nativePtr, 1); //string visitor
        }
    }
    public struct CefStringVisitor
    {
        internal IntPtr nativePtr;
        internal CefStringVisitor(IntPtr ptr)
        {
            this.nativePtr = ptr;
        }
        public void Release()
        {
            Cef3Binder.MyCefRelease(this.nativePtr, 1); //string visitor
        }
    }
    public struct MyCefFrame
    {
        internal IntPtr nativePtr;
        internal MyCefFrame(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }

        public bool IsValid()
        {

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_IsValid, out ret, ref a1, ref a2);
            return ret.I32 != 0;
        }
        public void Undo()
        {
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Undo, out ret, ref a1, ref a2);
        }
        public void Cut()
        {

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_Cut, out ret, ref a1, ref a2);
        }
        public void GetSource(CefStringVisitor visitor)
        {

            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            a1.Type = JsValueType.Wrapped;
            a1.Ptr = visitor.nativePtr;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetSource, out ret, ref a1, ref a2);
        }
        public string GetUrl()
        {
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_GetURL, out ret, ref a1, ref a2);
            //

            unsafe
            {
                int actualLen;
                int buffLen = ret.I32; //string len
                char* buffHead = stackalloc char[buffLen];

                Cef3Binder.MyCefStringHolder_Read(ret.Ptr, buffHead, buffLen, out actualLen);
                if (actualLen > buffLen)
                {
                    //read more
                }
                return new string(buffHead, 0, actualLen);
            }
        }

        public void GetSource(MyCefStringVisitor stringVisitor)
        {
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;

            a1.Ptr = stringVisitor.nativePtr;
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
                (int)CefFrameCallMsg.CefFrame_GetSource, out ret, ref a1, ref a2);
        }
        public void GetText(MyCefStringVisitor stringVisitor)
        {
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue a3 = new JsValue();
            JsValue a4 = new JsValue();
            JsValue a5 = new JsValue();
            JsValue a6 = new JsValue();
            JsValue ret;

            a1.Ptr = stringVisitor.nativePtr;
            //Cef3Binder.MyCefFrameCall2(this.nativePtr,
            //    (int)CefFrameCallMsg.CefFrame_GetText, out ret, ref a1, ref a2);
            const int CefFrame_GetText_11 = 11;
            Cef3Binder.MyCefMet_CefFrame(this.nativePtr,
               CefFrame_GetText_11, out ret, ref a1, ref a2, ref a3, ref a4, ref a5, ref a6);
        }
        public void GetSource(MyCefCallback cb2)
        {
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefJsValueSetManagedCallback(ref a1, cb2);
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
                (int)CefFrameCallMsg.CefFrame_GetSource_Ext, out ret, ref a1, ref a2);
        }
        
        public void LoadString(string string_val, string url)
        {  
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            Cef3Binder.MyCefCreateNativeStringHolder(ref a1, string_val);
            Cef3Binder.MyCefCreateNativeStringHolder(ref a2, url);
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
            (int)CefFrameCallMsg.CefFrame_LoadString, out ret, ref a1, ref a2);
        }
        public void Release()
        {
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;
            
            Cef3Binder.MyCefFrameCall2(this.nativePtr,
                (int)CefFrameCallMsg.CefFrame_Release, out ret, ref a1, ref a2);
        }

    }

    public struct MyCefBw
    {
        internal IntPtr ptr;
        internal MyCefBw(IntPtr ptr)
        {
            this.ptr = ptr;
        }
        public MyCefFrame GetMainFrame()
        {
            JsValue ret;
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();

            Cef3Binder.MyCefBwCall2(ptr,
                (int)CefBwCallMsg.CefBw_GetMainFrame,
                out ret, ref a1, ref a2);
            return new MyCefFrame(ret.Ptr);

        }
        public MyCefStringVisitor NewStringVisitor(MyCefCallback cb)
        {
            JsValue ret;
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            Cef3Binder.MyCefJsValueSetManagedCallback(ref a1, cb);
            Cef3Binder.MyCefBwCall2(ptr,
               (int)CefBwCallMsg.CefBw_NewStringVisitor,
               out ret, ref a1, ref a2);
            return new MyCefStringVisitor(ret.Ptr);
        }

    }







    public struct NativeMyCefStringHolder
    {
        internal IntPtr nativePtr;
        internal NativeMyCefStringHolder(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            Cef3Binder.MyCefDeletePtr(this.nativePtr);
            nativePtr = IntPtr.Zero;
        }

        public static NativeMyCefStringHolder CreateHolder(string str)
        {
            return new NativeMyCefStringHolder(Cef3Binder.MyCefCreateCefString(str));
        }
        public string ReadString(int len)
        {
            int buff_len = len + 1;

            char[] buffer = new char[buff_len];
            unsafe
            {
                fixed (char* h = &buffer[0])
                {
                    int actualLen = 0;
                    Cef3Binder.MyCefStringHolder_Read(this.nativePtr, h, buff_len, out actualLen);
                }
            }
            return new string(buffer);
        }
    }
    static partial class Cef3Binder
    {
        static Cef3InitEssential cefInitEssential;

        const string CEF_CLIENT_DLL = "cefclient.dll";
#if DEBUG
        public static bool s_dbugIsRendererProcess;
#endif

        static CefClientApp clientApp;


        public static IWindowForm CreateBlankForm(int width, int height)
        {
            return Cef3WinForms.s_currentImpl.CreateNewWindow(width, height);
        }
        public static IWindowForm CreateNewBrowserWindow(int width, int height)
        {
            return Cef3WinForms.s_currentImpl.CreateNewBrowserWindow(width, height);
        }
        public static void SafeUIInvoke(SimpleDel del)
        {
            Cef3WinForms.s_currentImpl.SaveUIInvoke(del);
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

            clientApp = cefInitEssential.CreateClientApp();
            return true;
        }

        static bool LoadNativeLibs(Cef3InitEssential initEssential)
        {

            //in version 3.2885.1548 (chrome 55+)
            PlatformNeutralMethods.LoadLibrary(cefInitEssential.GetLibChromeElfFileName());
            //1. lib cef
            string lib = initEssential.GetLibCefFileName();

            int tryLoadCount = 0;
            TRY_AGAIN:
            string lastErr = null;
            IntPtr libCefModuleHandler = PlatformNeutralMethods.LoadLibrary(lib);
            //Console.WriteLine(libCefModuleHandler);
            if (libCefModuleHandler == IntPtr.Zero)
            {
                lastErr = PlatformNeutralMethods.GetError();
                if (lastErr != null)
                {
                    if (lastErr == "2" & tryLoadCount < 3)
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

            IntPtr nativeModule = PlatformNeutralMethods.LoadLibrary(lib);
            lastErr = PlatformNeutralMethods.GetError();
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


        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefGetVersion();

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int RegisterManagedCallBack(MyCefCallback funcPtr, int callbackKind);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateClientApp(IntPtr processHandle);



        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateMyWebBrowser(MyCefCallback mxcallback);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MyCefCreateMyWebBrowserOSR(MyCefCallback mxcallback);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetupBrowserHwnd(IntPtr myCefBrowser, IntPtr hWndParent, int x, int y, int width, int height, string initUrl, IntPtr requestContext);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetupBrowserHwndOSR(IntPtr myCefBrowser, IntPtr hWndParent, int x, int y, int width, int height, string initUrl, IntPtr requestContext);




        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefDoMessageLoopWork();
        [DllImport(CEF_CLIENT_DLL)]
        public static extern void MyCefQuitMessageLoop();
        [DllImport(CEF_CLIENT_DLL)]
        public static extern int MyCefShutDown();



        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefSetInitSettings(IntPtr cefSetting, CefSettingsKey keyName, string value);
        //--------------------------------------------------- 


        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefMetArgs_SetResultAsJsValue(IntPtr nativeMetPtr, int retIndex, IntPtr ptr);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefMetArgs_GetArgs(IntPtr metArgPtr, int index, out JsValue outputValue);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefMetArgs_GetResult(IntPtr metArgPtr, int index, out JsValue outputValue);



        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefShowDevTools(IntPtr myCefBw, IntPtr myCefDevTool, IntPtr parentWindow);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefDeletePtr(IntPtr nativePtr);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefDeletePtrArray(JsValue* nativePtr);


        //

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern IntPtr MyCefCreatePdfPrintSetting(string pdfJsonConfig);
        //--------------------------------------------------- 
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void MyCefPrintToPdf(IntPtr myCefBw, IntPtr setting, string filename, MyCefCallback callback);




        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefDomGetTextWalk(IntPtr myCefBw, MyCefCallback strCallBack);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyCefDomGetSourceWalk(IntPtr myCefBw, MyCefCallback strCallBack);
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
        internal static extern IntPtr MyCefFrame_GetContext(IntPtr nativeFrame);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJsGetGlobal(IntPtr jsContext);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJs_EnterContext(IntPtr cefV8Context);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefJs_ExitContext(IntPtr cefV8Context);
        //
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr MyCefJs_New_V8Handler(MyCefCallback managedCallback);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern void MyCefJs_CefV8Value_SetValue_ByString(IntPtr target, string key, IntPtr value, int setAttr);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern bool MyCefJs_CefV8Value_IsFunc(IntPtr target);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void MyCefJs_CefV8Value_SetValue_ByIndex(IntPtr target, int index, IntPtr value);
        /// <summary>
        /// create cef string holder
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern IntPtr MyCefCreateCefString(string str);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern IntPtr MyCefJs_CreateFunction(string name, IntPtr handler);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static unsafe extern IntPtr MyCefJs_ExecJsFunctionWithContext(IntPtr cefJsFunc, IntPtr context, char* argAsJsonString);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        internal static extern bool MyCefJs_CefRegisterExtension(string extensionName, string extensionCode);

        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefString_Read(IntPtr cefStr, char* outputBuffer, int outputBufferLen, out int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefStringHolder_Read(IntPtr mycefStrHolder, char* outputBuffer, int outputBufferLen, out int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern unsafe void MyCefJs_CefV8Value_ReadAsString(IntPtr cefV8Value, char* outputBuffer, int outputBufferLen, out int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MyCefJs_MetReadArgAsInt32(IntPtr jsArgs, int index);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe void MyCefJs_MetReadArgAsString(IntPtr jsArgs, int index, char* outputBuffer, int outputBufferLen, out int actualLength);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe IntPtr MyCefJs_MetReadArgAsCefV8Value(IntPtr jsArgs, int index);
        [DllImport(CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe IntPtr MyCefJs_MetReadArgAsV8FuncHandle(IntPtr jsArgs, int index);



        public static string MyCefJsReadString(ref JsValue ret)
        {
            unsafe
            {
                int actualLen;
                int buffLen = ret.I32; //string len
                char* buffHead = stackalloc char[buffLen];

                Cef3Binder.MyCefStringHolder_Read(ret.Ptr, buffHead, buffLen, out actualLen);
                if (actualLen > buffLen)
                {
                    //read more
                }

                return new string(buffHead, 0, actualLen);
            }
        }
        public static void MyCefCreateNativeStringHolder(ref JsValue ret, string value)
        {
            unsafe
            {
                ret.Type = JsValueType.NativeCefString;
                ret.Ptr = Cef3Binder.MyCefCreateCefString(value);
                ret.I32 = value.Length;
            }
        }
    }


    public static class CefBinder2
    {
        public static bool RegisterCefExtension(string extensionName, string extensionCode)
        {
            return Cef3Binder.MyCefJs_CefRegisterExtension(extensionName, extensionCode);
        }



        public static void NotifyRendererAsync(MyCefCallback callback)
        {
            Cef3Binder.MyCefJsNotifyRenderer(callback, IntPtr.Zero);
        }
    }




    enum OsPlatform
    {
        Unknown,
        Windows,
        Mac,
        Linux
    }
    static class PlatformNeutralMethods
    {
        static NativeModuleLoader nativeModuleLoader;
        static PlatformNeutralMethods()
        {
            //evaluate current platform
            switch (GetOsName())
            {
                //TODO: review here for linux
                default:
                    throw new NotSupportedException();
                case OsPlatform.Windows:
                    nativeModuleLoader = new Win32NativeModuleLoader();
                    break;
                case OsPlatform.Mac:
                    nativeModuleLoader = new MacOsNativeModuleLoader();
                    break;
            }
        }
        public static OsPlatform GetOsName()
        {
            //check platform
#if NETCORE
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.OSX))
            {
                return OsPlatform.Mac;
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.Linux)
                )
            {
                return OsPlatform.Linux;
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
              System.Runtime.InteropServices.OSPlatform.Windows))
            {
                return OsPlatform.Windows;
            }
            else
            {
                return OsPlatform.Unknown;
            }
        }
#else
            OperatingSystem os = Environment.OSVersion;
            switch (os.Platform)
            {
                default:
                    throw new NotSupportedException();
                case PlatformID.MacOSX:
                    return OsPlatform.Mac;
                case PlatformID.Win32NT:
                    return OsPlatform.Windows;
            }
#endif
        }


        public static IntPtr LoadLibrary(string libname)
        {
            return nativeModuleLoader.LoadLib(libname);
        }
        public static string GetError()
        {
            return nativeModuleLoader.GetError();
        }
    }


    abstract class NativeModuleLoader
    {

        public abstract IntPtr LoadLib(string libname);
        public abstract bool FreeLib(IntPtr hModule);
        public abstract IntPtr GetFunc(IntPtr hModule, string funcName);
        public abstract string GetError();

    }
    class Win32NativeModuleLoader : NativeModuleLoader
    {
        //TODO: review here, check for other platforms
        //-----------------------------------------------
        //this is Windows Specific class ***
        [DllImport("Kernel32.dll")]
        static extern IntPtr LoadLibrary(string libraryName);
        [DllImport("Kernel32.dll")]
        static extern bool FreeLibrary(IntPtr hModule);
        [DllImport("Kernel32.dll")]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("Kernel32.dll")]
        static extern uint SetErrorMode(int uMode);
        [DllImport("Kernel32.dll")]
        static extern uint GetLastError();

        public override IntPtr LoadLib(string libname)
        {
            return LoadLibrary(libname);
        }

        public override bool FreeLib(IntPtr hModule)
        {
            return FreeLibrary(hModule);
        }

        public override IntPtr GetFunc(IntPtr hModule, string funcName)
        {
            return GetProcAddress(hModule, funcName);
        }
        public override string GetError()
        {
            uint lastError = GetLastError();
            if (lastError == 0)
            {
                return null;
            }
            else
            {
                return lastError.ToString();
            }
        }
        //---------------------- 

    }
    class MacOsNativeModuleLoader : NativeModuleLoader
    {
        /*
#define RTLD_LAZY   1
#define RTLD_NOW    2
#define RTLD_GLOBAL 4
*/
        [DllImport("libdl.so")]
        static extern IntPtr dlopen(string filename, int flags);
        [DllImport("libdl.so")]
        static extern int dlclose(IntPtr handle);
        [DllImport("libdl.so")]
        static extern IntPtr dlsym(IntPtr handle, string symbol);
        [DllImport("libdl.so")]
        static extern string dlerror();

        public override bool FreeLib(IntPtr hModule)
        {
            return dlclose(hModule) != 0;
        }
        public override IntPtr GetFunc(IntPtr hModule, string funcName)
        {
            return dlsym(hModule, funcName);
        }
        public override IntPtr LoadLib(string libname)
        {
            return dlopen(libname, 2);
        }
        public override string GetError()
        {
            return dlerror();
        }
    }

}
