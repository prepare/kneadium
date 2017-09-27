//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{


    // [virtual] class CefApp
    //CsCallToNativeCodeGen::GenerateCsCode , 1
    /// <summary>
    /// Implement this interface to provide handler implementations. Methods will be
    /// called by the process and/or thread indicated.
    /// /*cef(source=client,no_debugct_check)*/
    /// </summary>
    public struct CefApp : IDisposable
    {
        const int _typeNAME = 1;
        const int CefApp_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefApp(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefApp_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefApp New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefApp(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,1
        const int MyCefApp_OnBeforeCommandLineProcessing_1 = 1;
        const int MyCefApp_OnRegisterCustomSchemes_2 = 2;
        const int MyCefApp_GetResourceBundleHandler_3 = 3;
        const int MyCefApp_GetBrowserProcessHandler_4 = 4;
        const int MyCefApp_GetRenderProcessHandler_5 = 5;
        //gen! void OnBeforeCommandLineProcessing(const CefString& process_type,CefRefPtr<CefCommandLine> command_line)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,2
        /// <summary>
        /// Provides an opportunity to view and/or modify command-line arguments before
        /// processing by CEF and Chromium. The |process_type| value will be empty for
        /// the browser process. Do not keep a reference to the CefCommandLine object
        /// passed to this method. The CefSettings.command_line_args_disabled value
        /// can be used to start with an empty command-line object. Any values
        /// specified in CefSettings that equate to command-line arguments will be set
        /// before this method is called. Be cautious when using this method to modify
        /// command-line arguments for non-browser processes as this may result in
        /// undefined behavior including crashes.
        /// /*cef(optional_param=process_type)*/
        /// </summary>
        public struct OnBeforeCommandLineProcessingArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeCommandLineProcessingArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeCommandLineProcessingNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeCommandLineProcessingNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public string process_type()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((OnBeforeCommandLineProcessingNativeArgs*)this.nativePtr)->process_type);
                }
            }
            public CefCommandLine command_line()
            {
                unsafe
                {
                    return new CefCommandLine(((OnBeforeCommandLineProcessingNativeArgs*)this.nativePtr)->command_line);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,3
        [StructLayout(LayoutKind.Sequential)]
        struct OnBeforeCommandLineProcessingNativeArgs
        {
            public int argFlags;
            public IntPtr process_type;
            public IntPtr command_line;
        }
        //gen! void OnRegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,4
        /// <summary>
        /// Provides an opportunity to register custom schemes. Do not keep a reference
        /// to the |registrar| object. This method is called on the main thread for
        /// each process and the registered schemes should be the same across all
        /// processes.
        /// /*cef()*/
        /// </summary>
        public struct OnRegisterCustomSchemesArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRegisterCustomSchemesArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRegisterCustomSchemesNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRegisterCustomSchemesNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefSchemeRegistrar registrar()
            {
                unsafe
                {
                    return new CefSchemeRegistrar(((OnRegisterCustomSchemesNativeArgs*)this.nativePtr)->registrar);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,5
        [StructLayout(LayoutKind.Sequential)]
        struct OnRegisterCustomSchemesNativeArgs
        {
            public int argFlags;
            public IntPtr registrar;
        }
        //gen! CefRefPtr<CefResourceBundleHandler> GetResourceBundleHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,6
        /// <summary>
        /// Return the handler for resource bundle events. If
        /// CefSettings.pack_loading_disabled is true a handler must be returned. If no
        /// handler is returned resources will be loaded from pack files. This method
        /// is called by the browser and render processes on multiple threads.
        /// /*cef()*/
        /// </summary>
        public struct GetResourceBundleHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetResourceBundleHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetResourceBundleHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetResourceBundleHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetResourceBundleHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,7
        [StructLayout(LayoutKind.Sequential)]
        struct GetResourceBundleHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefBrowserProcessHandler> GetBrowserProcessHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,8
        /// <summary>
        /// Return the handler for functionality specific to the browser process. This
        /// method is called on multiple threads in the browser process.
        /// /*cef()*/
        /// </summary>
        public struct GetBrowserProcessHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetBrowserProcessHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetBrowserProcessHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetBrowserProcessHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetBrowserProcessHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,9
        [StructLayout(LayoutKind.Sequential)]
        struct GetBrowserProcessHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefRenderProcessHandler> GetRenderProcessHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,10
        /// <summary>
        /// Return the handler for functionality specific to the render process. This
        /// method is called on the render process main thread.
        /// /*cef()*/
        /// </summary>
        public struct GetRenderProcessHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetRenderProcessHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetRenderProcessHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetRenderProcessHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetRenderProcessHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,11
        [StructLayout(LayoutKind.Sequential)]
        struct GetRenderProcessHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,12
            /// <summary>
            /// Provides an opportunity to view and/or modify command-line arguments before
            /// processing by CEF and Chromium. The |process_type| value will be empty for
            /// the browser process. Do not keep a reference to the CefCommandLine object
            /// passed to this method. The CefSettings.command_line_args_disabled value
            /// can be used to start with an empty command-line object. Any values
            /// specified in CefSettings that equate to command-line arguments will be set
            /// before this method is called. Be cautious when using this method to modify
            /// command-line arguments for non-browser processes as this may result in
            /// undefined behavior including crashes.
            /// /*cef(optional_param=process_type)*/
            /// </summary>
            void OnBeforeCommandLineProcessing(OnBeforeCommandLineProcessingArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,13
            /// <summary>
            /// Provides an opportunity to register custom schemes. Do not keep a reference
            /// to the |registrar| object. This method is called on the main thread for
            /// each process and the registered schemes should be the same across all
            /// processes.
            /// /*cef()*/
            /// </summary>
            void OnRegisterCustomSchemes(OnRegisterCustomSchemesArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,14
            /// <summary>
            /// Return the handler for resource bundle events. If
            /// CefSettings.pack_loading_disabled is true a handler must be returned. If no
            /// handler is returned resources will be loaded from pack files. This method
            /// is called by the browser and render processes on multiple threads.
            /// /*cef()*/
            /// </summary>
            void GetResourceBundleHandler(GetResourceBundleHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,15
            /// <summary>
            /// Return the handler for functionality specific to the browser process. This
            /// method is called on multiple threads in the browser process.
            /// /*cef()*/
            /// </summary>
            void GetBrowserProcessHandler(GetBrowserProcessHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,16
            /// <summary>
            /// Return the handler for functionality specific to the render process. This
            /// method is called on the render process main thread.
            /// /*cef()*/
            /// </summary>
            void GetRenderProcessHandler(GetRenderProcessHandlerArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,17
            /// <summary>
            /// Provides an opportunity to view and/or modify command-line arguments before
            /// processing by CEF and Chromium. The |process_type| value will be empty for
            /// the browser process. Do not keep a reference to the CefCommandLine object
            /// passed to this method. The CefSettings.command_line_args_disabled value
            /// can be used to start with an empty command-line object. Any values
            /// specified in CefSettings that equate to command-line arguments will be set
            /// before this method is called. Be cautious when using this method to modify
            /// command-line arguments for non-browser processes as this may result in
            /// undefined behavior including crashes.
            /// /*cef(optional_param=process_type)*/
            /// </summary>
            void OnBeforeCommandLineProcessing(string process_type, CefCommandLine command_line);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,18
            /// <summary>
            /// Provides an opportunity to register custom schemes. Do not keep a reference
            /// to the |registrar| object. This method is called on the main thread for
            /// each process and the registered schemes should be the same across all
            /// processes.
            /// /*cef()*/
            /// </summary>
            void OnRegisterCustomSchemes(CefSchemeRegistrar registrar);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,19
            /// <summary>
            /// Return the handler for resource bundle events. If
            /// CefSettings.pack_loading_disabled is true a handler must be returned. If no
            /// handler is returned resources will be loaded from pack files. This method
            /// is called by the browser and render processes on multiple threads.
            /// /*cef()*/
            /// </summary>
            CefResourceBundleHandler GetResourceBundleHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,20
            /// <summary>
            /// Return the handler for functionality specific to the browser process. This
            /// method is called on multiple threads in the browser process.
            /// /*cef()*/
            /// </summary>
            CefBrowserProcessHandler GetBrowserProcessHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,21
            /// <summary>
            /// Return the handler for functionality specific to the render process. This
            /// method is called on the render process main thread.
            /// /*cef()*/
            /// </summary>
            CefRenderProcessHandler GetRenderProcessHandler();
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,22
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,23
                case MyCefApp_OnBeforeCommandLineProcessing_1:
                    {
                        var args = new OnBeforeCommandLineProcessingArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeCommandLineProcessing(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeCommandLineProcessing(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,24
                case MyCefApp_OnRegisterCustomSchemes_2:
                    {
                        var args = new OnRegisterCustomSchemesArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRegisterCustomSchemes(args);
                        }
                        if (i1 != null)
                        {
                            OnRegisterCustomSchemes(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,25
                case MyCefApp_GetResourceBundleHandler_3:
                    {
                        var args = new GetResourceBundleHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetResourceBundleHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetResourceBundleHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,26
                case MyCefApp_GetBrowserProcessHandler_4:
                    {
                        var args = new GetBrowserProcessHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetBrowserProcessHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetBrowserProcessHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,27
                case MyCefApp_GetRenderProcessHandler_5:
                    {
                        var args = new GetRenderProcessHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetRenderProcessHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetRenderProcessHandler(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,28
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefApp_OnBeforeCommandLineProcessing_1:
                    i0.OnBeforeCommandLineProcessing(new OnBeforeCommandLineProcessingArgs(nativeArgPtr));
                    break;
                case MyCefApp_OnRegisterCustomSchemes_2:
                    i0.OnRegisterCustomSchemes(new OnRegisterCustomSchemesArgs(nativeArgPtr));
                    break;
                case MyCefApp_GetResourceBundleHandler_3:
                    i0.GetResourceBundleHandler(new GetResourceBundleHandlerArgs(nativeArgPtr));
                    break;
                case MyCefApp_GetBrowserProcessHandler_4:
                    i0.GetBrowserProcessHandler(new GetBrowserProcessHandlerArgs(nativeArgPtr));
                    break;
                case MyCefApp_GetRenderProcessHandler_5:
                    i0.GetRenderProcessHandler(new GetRenderProcessHandlerArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,29
        public static void OnBeforeCommandLineProcessing(I1 i1, OnBeforeCommandLineProcessingArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,30
            i1.OnBeforeCommandLineProcessing(args.process_type(),
            args.command_line());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,31
        public static void OnRegisterCustomSchemes(I1 i1, OnRegisterCustomSchemesArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,32
            i1.OnRegisterCustomSchemes(args.registrar());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,33
        public static void GetResourceBundleHandler(I1 i1, GetResourceBundleHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,34
            i1.GetResourceBundleHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,35
        public static void GetBrowserProcessHandler(I1 i1, GetBrowserProcessHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,36
            i1.GetBrowserProcessHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,37
        public static void GetRenderProcessHandler(I1 i1, GetRenderProcessHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,38
            i1.GetRenderProcessHandler();
        }
    }


    // [virtual] class CefBrowser
    //CsCallToNativeCodeGen::GenerateCsCode , 2
    /// <summary>
    /// Class used to represent a browser window. When used in the browser process
    /// the methods of this class may be called on any thread unless otherwise
    /// indicated in the comments. When used in the render process the methods of
    /// this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBrowser : IDisposable
    {
        const int _typeNAME = 2;
        const int CefBrowser_Release_0 = (_typeNAME << 16) | 0;
        const int CefBrowser_GetHost_1 = (_typeNAME << 16) | 1;
        const int CefBrowser_CanGoBack_2 = (_typeNAME << 16) | 2;
        const int CefBrowser_GoBack_3 = (_typeNAME << 16) | 3;
        const int CefBrowser_CanGoForward_4 = (_typeNAME << 16) | 4;
        const int CefBrowser_GoForward_5 = (_typeNAME << 16) | 5;
        const int CefBrowser_IsLoading_6 = (_typeNAME << 16) | 6;
        const int CefBrowser_Reload_7 = (_typeNAME << 16) | 7;
        const int CefBrowser_ReloadIgnoreCache_8 = (_typeNAME << 16) | 8;
        const int CefBrowser_StopLoad_9 = (_typeNAME << 16) | 9;
        const int CefBrowser_GetIdentifier_10 = (_typeNAME << 16) | 10;
        const int CefBrowser_IsSame_11 = (_typeNAME << 16) | 11;
        const int CefBrowser_IsPopup_12 = (_typeNAME << 16) | 12;
        const int CefBrowser_HasDocument_13 = (_typeNAME << 16) | 13;
        const int CefBrowser_GetMainFrame_14 = (_typeNAME << 16) | 14;
        const int CefBrowser_GetFocusedFrame_15 = (_typeNAME << 16) | 15;
        const int CefBrowser_GetFrame_16 = (_typeNAME << 16) | 16;
        const int CefBrowser_GetFrame_17 = (_typeNAME << 16) | 17;
        const int CefBrowser_GetFrameCount_18 = (_typeNAME << 16) | 18;
        const int CefBrowser_GetFrameIdentifiers_19 = (_typeNAME << 16) | 19;
        const int CefBrowser_GetFrameNames_20 = (_typeNAME << 16) | 20;
        const int CefBrowser_SendProcessMessage_21 = (_typeNAME << 16) | 21;
        internal IntPtr nativePtr;
        internal CefBrowser(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 3

        // gen! CefRefPtr<CefBrowserHost> GetHost()
        /// <summary>
        /// CefBrowser methods.
        /// </summary>

        public CefBrowserHost GetHost()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetHost_1, out ret);
            return new CefBrowserHost(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 4

        // gen! bool CanGoBack()
        /// <summary>
        /// Returns true if the browser can navigate backwards.
        /// /*cef()*/
        /// </summary>

        public bool CanGoBack()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoBack_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 5

        // gen! void GoBack()
        /// <summary>
        /// Navigate backwards.
        /// /*cef()*/
        /// </summary>

        public void GoBack()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoBack_3, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 6

        // gen! bool CanGoForward()
        /// <summary>
        /// Returns true if the browser can navigate forwards.
        /// /*cef()*/
        /// </summary>

        public bool CanGoForward()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoForward_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 7

        // gen! void GoForward()
        /// <summary>
        /// Navigate forwards.
        /// /*cef()*/
        /// </summary>

        public void GoForward()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoForward_5, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 8

        // gen! bool IsLoading()
        /// <summary>
        /// Returns true if the browser is currently loading.
        /// /*cef()*/
        /// </summary>

        public bool IsLoading()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsLoading_6, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 9

        // gen! void Reload()
        /// <summary>
        /// Reload the current page.
        /// /*cef()*/
        /// </summary>

        public void Reload()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Reload_7, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 10

        // gen! void ReloadIgnoreCache()
        /// <summary>
        /// Reload the current page ignoring any cached data.
        /// /*cef()*/
        /// </summary>

        public void ReloadIgnoreCache()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_ReloadIgnoreCache_8, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 11

        // gen! void StopLoad()
        /// <summary>
        /// Stop loading the page.
        /// /*cef()*/
        /// </summary>

        public void StopLoad()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_StopLoad_9, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 12

        // gen! int GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this browser.
        /// /*cef()*/
        /// </summary>

        public int GetIdentifier()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetIdentifier_10, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 13

        // gen! bool IsSame(CefRefPtr<CefBrowser> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefBrowser that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_IsSame_11, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 14

        // gen! bool IsPopup()
        /// <summary>
        /// Returns true if the window is a popup window.
        /// /*cef()*/
        /// </summary>

        public bool IsPopup()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsPopup_12, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 15

        // gen! bool HasDocument()
        /// <summary>
        /// Returns true if a document has been loaded in the browser.
        /// /*cef()*/
        /// </summary>

        public bool HasDocument()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_HasDocument_13, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 16

        // gen! CefRefPtr<CefFrame> GetMainFrame()
        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetMainFrame()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetMainFrame_14, out ret);
            return new CefFrame(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 17

        // gen! CefRefPtr<CefFrame> GetFocusedFrame()
        /// <summary>
        /// Returns the focused frame for the browser window.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetFocusedFrame()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFocusedFrame_15, out ret);
            return new CefFrame(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 18

        // gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)

        public CefFrame GetFrame(long identifier)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I64 = identifier;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_16, out ret, ref v1);
            return new CefFrame(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 19

        // gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)

        public CefFrame GetFrame(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_17, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefFrame(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 20

        // gen! size_t GetFrameCount()
        /// <summary>
        /// Returns the number of frames that currently exist.
        /// /*cef()*/
        /// </summary>

        public uint GetFrameCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFrameCount_18, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 21

        // gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// /*cef(count_func=identifiers:GetFrameCount)*/
        /// </summary>

        public void GetFrameIdentifiers(List<long> identifiers)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(1);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameIdentifiers_19, out ret, ref v1);
            Cef3Binder.CopyStdInt64ListAndDestroyNativeSide(v1.Ptr, identifiers);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 22

        // gen! void GetFrameNames(std::vector<CefString>& names)
        /// <summary>
        /// Returns the names of all existing frames.
        /// /*cef()*/
        /// </summary>

        public void GetFrameNames(List<string> names)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameNames_20, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 23

        // gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
        /// <summary>
        /// Send a message to the specified |target_process|. Returns true if the
        /// message was sent successfully.
        /// /*cef()*/
        /// </summary>

        public bool SendProcessMessage(cef_process_id_t target_process,
        CefProcessMessage message)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)target_process;
            v2.Ptr = message.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowser_SendProcessMessage_21, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
    }


    // [virtual] class CefNavigationEntryVisitor
    //CsCallToNativeCodeGen::GenerateCsCode , 24
    /// <summary>
    /// Callback interface for CefBrowserHost::GetNavigationEntries. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefNavigationEntryVisitor : IDisposable
    {
        const int _typeNAME = 3;
        const int CefNavigationEntryVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefNavigationEntryVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntryVisitor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefNavigationEntryVisitor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefNavigationEntryVisitor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,39
        const int MyCefNavigationEntryVisitor_Visit_1 = 1;
        //gen! bool Visit(CefRefPtr<CefNavigationEntry> entry,bool current,int index,int total)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,40
        /// <summary>
        /// Method that will be executed. Do not keep a reference to |entry| outside of
        /// this callback. Return true to continue visiting entries or false to stop.
        /// |current| is true if this entry is the currently loaded navigation entry.
        /// |index| is the 0-based index of this entry and |total| is the total number
        /// of entries.
        /// /*cef()*/
        /// </summary>
        public struct VisitArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal VisitArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((VisitNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((VisitNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((VisitNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefNavigationEntry entry()
            {
                unsafe
                {
                    return new CefNavigationEntry(((VisitNativeArgs*)this.nativePtr)->entry);
                }
            }
            public bool current()
            {
                unsafe
                {
                    return ((VisitNativeArgs*)this.nativePtr)->current;
                }
            }
            public int index()
            {
                unsafe
                {
                    return ((VisitNativeArgs*)this.nativePtr)->index;
                }
            }
            public int total()
            {
                unsafe
                {
                    return ((VisitNativeArgs*)this.nativePtr)->total;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,41
        [StructLayout(LayoutKind.Sequential)]
        struct VisitNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr entry;
            public bool current;
            public int index;
            public int total;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,42
            /// <summary>
            /// Method that will be executed. Do not keep a reference to |entry| outside of
            /// this callback. Return true to continue visiting entries or false to stop.
            /// |current| is true if this entry is the currently loaded navigation entry.
            /// |index| is the 0-based index of this entry and |total| is the total number
            /// of entries.
            /// /*cef()*/
            /// </summary>
            void Visit(VisitArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,43
            /// <summary>
            /// Method that will be executed. Do not keep a reference to |entry| outside of
            /// this callback. Return true to continue visiting entries or false to stop.
            /// |current| is true if this entry is the currently loaded navigation entry.
            /// |index| is the 0-based index of this entry and |total| is the total number
            /// of entries.
            /// /*cef()*/
            /// </summary>
            bool Visit(CefNavigationEntry entry, bool current, int index, int total);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,44
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,45
                case MyCefNavigationEntryVisitor_Visit_1:
                    {
                        var args = new VisitArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Visit(args);
                        }
                        if (i1 != null)
                        {
                            Visit(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,46
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefNavigationEntryVisitor_Visit_1:
                    i0.Visit(new VisitArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,47
        public static void Visit(I1 i1, VisitArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,48
            args.myext_setRetValue(i1.Visit(args.entry(),
            args.current(),
            args.index(),
            args.total()));
        }
    }


    // [virtual] class CefBrowserHost
    //CsCallToNativeCodeGen::GenerateCsCode , 25
    /// <summary>
    /// Class used to represent the browser process aspects of a browser window. The
    /// methods of this class can only be called in the browser process. They may be
    /// called on any thread in that process unless otherwise indicated in the
    /// comments.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBrowserHost : IDisposable
    {
        const int _typeNAME = 4;
        const int CefBrowserHost_Release_0 = (_typeNAME << 16) | 0;
        const int CefBrowserHost_GetBrowser_1 = (_typeNAME << 16) | 1;
        const int CefBrowserHost_CloseBrowser_2 = (_typeNAME << 16) | 2;
        const int CefBrowserHost_TryCloseBrowser_3 = (_typeNAME << 16) | 3;
        const int CefBrowserHost_SetFocus_4 = (_typeNAME << 16) | 4;
        const int CefBrowserHost_GetWindowHandle_5 = (_typeNAME << 16) | 5;
        const int CefBrowserHost_GetOpenerWindowHandle_6 = (_typeNAME << 16) | 6;
        const int CefBrowserHost_HasView_7 = (_typeNAME << 16) | 7;
        const int CefBrowserHost_GetClient_8 = (_typeNAME << 16) | 8;
        const int CefBrowserHost_GetRequestContext_9 = (_typeNAME << 16) | 9;
        const int CefBrowserHost_GetZoomLevel_10 = (_typeNAME << 16) | 10;
        const int CefBrowserHost_SetZoomLevel_11 = (_typeNAME << 16) | 11;
        const int CefBrowserHost_RunFileDialog_12 = (_typeNAME << 16) | 12;
        const int CefBrowserHost_StartDownload_13 = (_typeNAME << 16) | 13;
        const int CefBrowserHost_DownloadImage_14 = (_typeNAME << 16) | 14;
        const int CefBrowserHost_Print_15 = (_typeNAME << 16) | 15;
        const int CefBrowserHost_PrintToPDF_16 = (_typeNAME << 16) | 16;
        const int CefBrowserHost_Find_17 = (_typeNAME << 16) | 17;
        const int CefBrowserHost_StopFinding_18 = (_typeNAME << 16) | 18;
        const int CefBrowserHost_ShowDevTools_19 = (_typeNAME << 16) | 19;
        const int CefBrowserHost_CloseDevTools_20 = (_typeNAME << 16) | 20;
        const int CefBrowserHost_HasDevTools_21 = (_typeNAME << 16) | 21;
        const int CefBrowserHost_GetNavigationEntries_22 = (_typeNAME << 16) | 22;
        const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = (_typeNAME << 16) | 23;
        const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = (_typeNAME << 16) | 24;
        const int CefBrowserHost_ReplaceMisspelling_25 = (_typeNAME << 16) | 25;
        const int CefBrowserHost_AddWordToDictionary_26 = (_typeNAME << 16) | 26;
        const int CefBrowserHost_IsWindowRenderingDisabled_27 = (_typeNAME << 16) | 27;
        const int CefBrowserHost_WasResized_28 = (_typeNAME << 16) | 28;
        const int CefBrowserHost_WasHidden_29 = (_typeNAME << 16) | 29;
        const int CefBrowserHost_NotifyScreenInfoChanged_30 = (_typeNAME << 16) | 30;
        const int CefBrowserHost_Invalidate_31 = (_typeNAME << 16) | 31;
        const int CefBrowserHost_SendKeyEvent_32 = (_typeNAME << 16) | 32;
        const int CefBrowserHost_SendMouseClickEvent_33 = (_typeNAME << 16) | 33;
        const int CefBrowserHost_SendMouseMoveEvent_34 = (_typeNAME << 16) | 34;
        const int CefBrowserHost_SendMouseWheelEvent_35 = (_typeNAME << 16) | 35;
        const int CefBrowserHost_SendFocusEvent_36 = (_typeNAME << 16) | 36;
        const int CefBrowserHost_SendCaptureLostEvent_37 = (_typeNAME << 16) | 37;
        const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = (_typeNAME << 16) | 38;
        const int CefBrowserHost_GetWindowlessFrameRate_39 = (_typeNAME << 16) | 39;
        const int CefBrowserHost_SetWindowlessFrameRate_40 = (_typeNAME << 16) | 40;
        const int CefBrowserHost_ImeSetComposition_41 = (_typeNAME << 16) | 41;
        const int CefBrowserHost_ImeCommitText_42 = (_typeNAME << 16) | 42;
        const int CefBrowserHost_ImeFinishComposingText_43 = (_typeNAME << 16) | 43;
        const int CefBrowserHost_ImeCancelComposition_44 = (_typeNAME << 16) | 44;
        const int CefBrowserHost_DragTargetDragEnter_45 = (_typeNAME << 16) | 45;
        const int CefBrowserHost_DragTargetDragOver_46 = (_typeNAME << 16) | 46;
        const int CefBrowserHost_DragTargetDragLeave_47 = (_typeNAME << 16) | 47;
        const int CefBrowserHost_DragTargetDrop_48 = (_typeNAME << 16) | 48;
        const int CefBrowserHost_DragSourceEndedAt_49 = (_typeNAME << 16) | 49;
        const int CefBrowserHost_DragSourceSystemDragEnded_50 = (_typeNAME << 16) | 50;
        const int CefBrowserHost_GetVisibleNavigationEntry_51 = (_typeNAME << 16) | 51;
        const int CefBrowserHost_SetAccessibilityState_52 = (_typeNAME << 16) | 52;
        //
        const int CefBrowserHost_S_CreateBrowser_1 = (_typeNAME << 16) | 1;
        const int CefBrowserHost_S_CreateBrowserSync_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefBrowserHost(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 26

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// CefBrowserHost methods.
        /// </summary>

        public CefBrowser GetBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetBrowser_1, out ret);
            return new CefBrowser(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 27

        // gen! void CloseBrowser(bool force_close)
        /// <summary>
        /// Request that the browser close. The JavaScript 'onbeforeunload' event will
        /// be fired. If |force_close| is false the event handler, if any, will be
        /// allowed to prompt the user and the user can optionally cancel the close.
        /// If |force_close| is true the prompt will not be displayed and the close
        /// will proceed. Results in a call to CefLifeSpanHandler::DoClose() if the
        /// event handler allows the close or if |force_close| is true. See
        /// CefLifeSpanHandler::DoClose() documentation for additional usage
        /// information.
        /// /*cef()*/
        /// </summary>

        public void CloseBrowser(bool force_close)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = force_close ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_CloseBrowser_2, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 28

        // gen! bool TryCloseBrowser()
        /// <summary>
        /// Helper for closing a browser. Call this method from the top-level window
        /// close handler. Internally this calls CloseBrowser(false) if the close has
        /// not yet been initiated. This method returns false while the close is
        /// pending and true after the close has completed. See CloseBrowser() and
        /// CefLifeSpanHandler::DoClose() documentation for additional usage
        /// information. This method must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool TryCloseBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_TryCloseBrowser_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 29

        // gen! void SetFocus(bool focus)
        /// <summary>
        /// Set whether the browser is focused.
        /// /*cef()*/
        /// </summary>

        public void SetFocus(bool focus)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = focus ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetFocus_4, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 30

        // gen! CefWindowHandle GetWindowHandle()
        /// <summary>
        /// Retrieve the window handle for this browser. If this browser is wrapped in
        /// a CefBrowserView this method should be called on the browser process UI
        /// thread and it will return the handle for the top-level native window.
        /// /*cef()*/
        /// </summary>

        public IntPtr GetWindowHandle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowHandle_5, out ret);
            return ret.Ptr;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 31

        // gen! CefWindowHandle GetOpenerWindowHandle()
        /// <summary>
        /// Retrieve the window handle of the browser that opened this browser. Will
        /// return NULL for non-popup windows or if this browser is wrapped in a
        /// CefBrowserView. This method can be used in combination with custom handling
        /// of modal windows.
        /// /*cef()*/
        /// </summary>

        public IntPtr GetOpenerWindowHandle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetOpenerWindowHandle_6, out ret);
            return ret.Ptr;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 32

        // gen! bool HasView()
        /// <summary>
        /// Returns true if this browser is wrapped in a CefBrowserView.
        /// /*cef()*/
        /// </summary>

        public bool HasView()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasView_7, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 33

        // gen! CefRefPtr<CefClient> GetClient()
        /// <summary>
        /// Returns the client for this browser.
        /// /*cef()*/
        /// </summary>

        public CefClient GetClient()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetClient_8, out ret);
            return new CefClient(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 34

        // gen! CefRefPtr<CefRequestContext> GetRequestContext()
        /// <summary>
        /// Returns the request context for this browser.
        /// /*cef()*/
        /// </summary>

        public CefRequestContext GetRequestContext()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetRequestContext_9, out ret);
            return new CefRequestContext(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 35

        // gen! double GetZoomLevel()
        /// <summary>
        /// Get the current zoom level. The default zoom level is 0.0. This method can
        /// only be called on the UI thread.
        /// /*cef()*/
        /// </summary>

        public double GetZoomLevel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetZoomLevel_10, out ret);
            return ret.Num;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 36

        // gen! void SetZoomLevel(double zoomLevel)
        /// <summary>
        /// Change the zoom level to the specified value. Specify 0.0 to reset the
        /// zoom level. If called on the UI thread the change will be applied
        /// immediately. Otherwise, the change will be applied asynchronously on the
        /// UI thread.
        /// /*cef()*/
        /// </summary>

        public void SetZoomLevel(double zoomLevel)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = zoomLevel;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetZoomLevel_11, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 37

        // gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
        /// <summary>
        /// Call to run a file chooser dialog. Only a single file chooser dialog may be
        /// pending at any given time. |mode| represents the type of dialog to display.
        /// |title| to the title to be used for the dialog and may be empty to show the
        /// default title ("Open" or "Save" depending on the mode). |default_file_path|
        /// is the path with optional directory and/or file name component that will be
        /// initially selected in the dialog. |accept_filters| are used to restrict the
        /// selectable file types and may any combination of (a) valid lower-cased MIME
        /// types (e.g. "text/*" or "image/*"), (b) individual file extensions (e.g.
        /// ".txt" or ".png"), or (c) combined description and file extension delimited
        /// using "|" and ";" (e.g. "Image Types|.png;.gif;.jpg").
        /// |selected_accept_filter| is the 0-based index of the filter that will be
        /// selected by default. |callback| will be executed after the dialog is
        /// dismissed or immediately if another dialog is already pending. The dialog
        /// will be initiated asynchronously on the UI thread.
        /// /*cef(optional_param=title,optional_param=default_file_path,optional_param=accept_filters,index_param=selected_accept_filter)*/
        /// </summary>

        public void RunFileDialog(cef_file_dialog_mode_t mode,
        string title,
        string default_file_path,
        List<string> accept_filters,
        int selected_accept_filter,
        CefRunFileDialogCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(title);
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(default_file_path);
            v1.I32 = (int)mode;
            v4.Ptr = Cef3Binder.CreateStdList(2);
            v5.I32 = (int)selected_accept_filter;
            v6.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call6(this.nativePtr, CefBrowserHost_RunFileDialog_12, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v4.Ptr, accept_filters);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 38

        // gen! void StartDownload(const CefString& url)
        /// <summary>
        /// Download the file at |url| using CefDownloadHandler.
        /// /*cef()*/
        /// </summary>

        public void StartDownload(string url)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StartDownload_13, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 39

        // gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
        /// <summary>
        /// Download |image_url| and execute |callback| on completion with the images
        /// received from the renderer. If |is_favicon| is true then cookies are not
        /// sent and not accepted during download. Images with density independent
        /// pixel (DIP) sizes larger than |max_image_size| are filtered out from the
        /// image results. Versions of the image at different scale factors may be
        /// downloaded up to the maximum scale factor supported by the system. If there
        /// are no image results <= |max_image_size| then the smallest image is resized
        /// to |max_image_size| and is the only result. A |max_image_size| of 0 means
        /// unlimited. If |bypass_cache| is true then |image_url| is requested from the
        /// server even if it is present in the browser cache.
        /// /*cef()*/
        /// </summary>

        public void DownloadImage(string image_url,
        bool is_favicon,
        uint max_image_size,
        bool bypass_cache,
        CefDownloadImageCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(image_url);
            v2.I32 = is_favicon ? 1 : 0;
            v3.I32 = (int)max_image_size;
            v4.I32 = bypass_cache ? 1 : 0;
            v5.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_DownloadImage_14, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 40

        // gen! void Print()
        /// <summary>
        /// Print the current browser contents.
        /// /*cef()*/
        /// </summary>

        public void Print()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Print_15, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 41

        // gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
        /// <summary>
        /// Print the current browser contents to the PDF file specified by |path| and
        /// execute |callback| on completion. The caller is responsible for deleting
        /// |path| when done. For PDF printing to work on Linux you must implement the
        /// CefPrintHandler::GetPdfPaperSize method.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public void PrintToPDF(string path,
        CefPdfPrintSettings settings,
        CefPdfPrintCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(path);
            v2.Ptr = settings.nativePtr;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_PrintToPDF_16, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 42

        // gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
        /// <summary>
        /// Search for |searchText|. |identifier| must be a unique ID and these IDs
        /// must strictly increase so that newer requests always have greater IDs than
        /// older requests. If |identifier| is zero or less than the previous ID value
        /// then it will be automatically assigned a new valid ID. |forward| indicates
        /// whether to search forward or backward within the page. |matchCase|
        /// indicates whether the search should be case-sensitive. |findNext| indicates
        /// whether this is the first request or a follow-up. The CefFindHandler
        /// instance, if any, returned via CefClient::GetFindHandler will be called to
        /// report find results.
        /// /*cef()*/
        /// </summary>

        public void Find(int identifier,
        string searchText,
        bool forward,
        bool matchCase,
        bool findNext)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(searchText);
            v1.I32 = (int)identifier;
            v3.I32 = forward ? 1 : 0;
            v4.I32 = matchCase ? 1 : 0;
            v5.I32 = findNext ? 1 : 0;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_Find_17, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 43

        // gen! void StopFinding(bool clearSelection)
        /// <summary>
        /// Cancel all searches that are currently going on.
        /// /*cef()*/
        /// </summary>

        public void StopFinding(bool clearSelection)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = clearSelection ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StopFinding_18, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 44

        // gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
        /// <summary>
        /// Open developer tools (DevTools) in its own browser. The DevTools browser
        /// will remain associated with this browser. If the DevTools browser is
        /// already open then it will be focused, in which case the |windowInfo|,
        /// |client| and |settings| parameters will be ignored. If |inspect_element_at|
        /// is non-empty then the element at the specified (x,y) location will be
        /// inspected. The |windowInfo| parameter will be ignored if this browser is
        /// wrapped in a CefBrowserView.
        /// /*cef(optional_param=windowInfo,optional_param=client,optional_param=settings,optional_param=inspect_element_at)*/
        /// </summary>

        public void ShowDevTools(CefWindowInfo windowInfo,
        CefClient client,
        CefBrowserSettings settings,
        CefPoint inspect_element_at)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = windowInfo.nativePtr;
            v2.Ptr = client.nativePtr;
            v3.Ptr = settings.nativePtr;
            v4.Ptr = inspect_element_at.nativePtr;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ShowDevTools_19, out ret, ref v1, ref v2, ref v3, ref v4);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 45

        // gen! void CloseDevTools()
        /// <summary>
        /// Explicitly close the associated DevTools browser, if any.
        /// /*cef()*/
        /// </summary>

        public void CloseDevTools()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_CloseDevTools_20, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 46

        // gen! bool HasDevTools()
        /// <summary>
        /// Returns true if this browser currently has an associated DevTools browser.
        /// Must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool HasDevTools()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasDevTools_21, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 47

        // gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
        /// <summary>
        /// Retrieve a snapshot of current navigation entries as values sent to the
        /// specified visitor. If |current_only| is true only the current navigation
        /// entry will be sent, otherwise all navigation entries will be sent.
        /// /*cef()*/
        /// </summary>

        public void GetNavigationEntries(CefNavigationEntryVisitor visitor,
        bool current_only)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;
            v2.I32 = current_only ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_GetNavigationEntries_22, out ret, ref v1, ref v2);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 48

        // gen! void SetMouseCursorChangeDisabled(bool disabled)
        /// <summary>
        /// Set whether mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>

        public void SetMouseCursorChangeDisabled(bool disabled)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = disabled ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetMouseCursorChangeDisabled_23, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 49

        // gen! bool IsMouseCursorChangeDisabled()
        /// <summary>
        /// Returns true if mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>

        public bool IsMouseCursorChangeDisabled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsMouseCursorChangeDisabled_24, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 50

        // gen! void ReplaceMisspelling(const CefString& word)
        /// <summary>
        /// If a misspelled word is currently selected in an editable node calling
        /// this method will replace it with the specified |word|.
        /// /*cef()*/
        /// </summary>

        public void ReplaceMisspelling(string word)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(word);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ReplaceMisspelling_25, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 51

        // gen! void AddWordToDictionary(const CefString& word)
        /// <summary>
        /// Add the specified |word| to the spelling dictionary.
        /// /*cef()*/
        /// </summary>

        public void AddWordToDictionary(string word)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(word);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_AddWordToDictionary_26, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 52

        // gen! bool IsWindowRenderingDisabled()
        /// <summary>
        /// Returns true if window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public bool IsWindowRenderingDisabled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsWindowRenderingDisabled_27, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 53

        // gen! void WasResized()
        /// <summary>
        /// Notify the browser that the widget has been resized. The browser will first
        /// call CefRenderHandler::GetViewRect to get the new size and then call
        /// CefRenderHandler::OnPaint asynchronously with the updated regions. This
        /// method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void WasResized()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_WasResized_28, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 54

        // gen! void WasHidden(bool hidden)
        /// <summary>
        /// Notify the browser that it has been hidden or shown. Layouting and
        /// CefRenderHandler::OnPaint notification will stop when the browser is
        /// hidden. This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void WasHidden(bool hidden)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = hidden ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_WasHidden_29, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 55

        // gen! void NotifyScreenInfoChanged()
        /// <summary>
        /// Send a notification to the browser that the screen info has changed. The
        /// browser will then call CefRenderHandler::GetScreenInfo to update the
        /// screen information with the new values. This simulates moving the webview
        /// window from one display to another, or changing the properties of the
        /// current display. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>

        public void NotifyScreenInfoChanged()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyScreenInfoChanged_30, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 56

        // gen! void Invalidate(PaintElementType type)
        /// <summary>
        /// Invalidate the view. The browser will call CefRenderHandler::OnPaint
        /// asynchronously. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>

        public void Invalidate(cef_paint_element_type_t type)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)type;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_Invalidate_31, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 57

        // gen! void SendKeyEvent(const CefKeyEvent& event)
        /// <summary>
        /// Send a key event to the browser.
        /// /*cef()*/
        /// </summary>

        public void SendKeyEvent(CefKeyEvent _event)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendKeyEvent_32, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 58

        // gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
        /// <summary>
        /// Send a mouse click event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>

        public void SendMouseClickEvent(CefMouseEvent _event,
        cef_mouse_button_type_t type,
        bool mouseUp,
        int clickCount)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = (int)type;
            v3.I32 = mouseUp ? 1 : 0;
            v4.I32 = (int)clickCount;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_SendMouseClickEvent_33, out ret, ref v1, ref v2, ref v3, ref v4);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 59

        // gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
        /// <summary>
        /// Send a mouse move event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>

        public void SendMouseMoveEvent(CefMouseEvent _event,
        bool mouseLeave)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = mouseLeave ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_SendMouseMoveEvent_34, out ret, ref v1, ref v2);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 60

        // gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
        /// <summary>
        /// Send a mouse wheel event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view. The |deltaX| and |deltaY|
        /// values represent the movement delta in the X and Y directions respectively.
        /// In order to scroll inside select popups with window rendering disabled
        /// CefRenderHandler::GetScreenPoint should be implemented properly.
        /// /*cef()*/
        /// </summary>

        public void SendMouseWheelEvent(CefMouseEvent _event,
        int deltaX,
        int deltaY)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = (int)deltaX;
            v3.I32 = (int)deltaY;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_SendMouseWheelEvent_35, out ret, ref v1, ref v2, ref v3);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 61

        // gen! void SendFocusEvent(bool setFocus)
        /// <summary>
        /// Send a focus event to the browser.
        /// /*cef()*/
        /// </summary>

        public void SendFocusEvent(bool setFocus)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = setFocus ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendFocusEvent_36, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 62

        // gen! void SendCaptureLostEvent()
        /// <summary>
        /// Send a capture lost event to the browser.
        /// /*cef()*/
        /// </summary>

        public void SendCaptureLostEvent()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_SendCaptureLostEvent_37, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 63

        // gen! void NotifyMoveOrResizeStarted()
        /// <summary>
        /// Notify the browser that the window hosting it is about to be moved or
        /// resized. This method is only used on Windows and Linux.
        /// /*cef()*/
        /// </summary>

        public void NotifyMoveOrResizeStarted()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyMoveOrResizeStarted_38, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 64

        // gen! int GetWindowlessFrameRate()
        /// <summary>
        /// Returns the maximum rate in frames per second (fps) that CefRenderHandler::
        /// OnPaint will be called for a windowless browser. The actual fps may be
        /// lower if the browser cannot generate frames at the requested rate. The
        /// minimum value is 1 and the maximum value is 60 (default 30). This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>

        public int GetWindowlessFrameRate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowlessFrameRate_39, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 65

        // gen! void SetWindowlessFrameRate(int frame_rate)
        /// <summary>
        /// Set the maximum rate in frames per second (fps) that CefRenderHandler::
        /// OnPaint will be called for a windowless browser. The actual fps may be
        /// lower if the browser cannot generate frames at the requested rate. The
        /// minimum value is 1 and the maximum value is 60 (default 30). Can also be
        /// set at browser creation via CefBrowserSettings.windowless_frame_rate.
        /// /*cef()*/
        /// </summary>

        public void SetWindowlessFrameRate(int frame_rate)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)frame_rate;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetWindowlessFrameRate_40, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 66

        // gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
        /// <summary>
        /// Begins a new composition or updates the existing composition. Blink has a
        /// special node (a composition node) that allows the input method to change
        /// text without affecting other DOM nodes. |text| is the optional text that
        /// will be inserted into the composition node. |underlines| is an optional set
        /// of ranges that will be underlined in the resulting text.
        /// |replacement_range| is an optional range of the existing text that will be
        /// replaced. |selection_range| is an optional range of the resulting text that
        /// will be selected after insertion or replacement. The |replacement_range|
        /// value is only used on OS X.
        ///
        /// This method may be called multiple times as the composition changes. When
        /// the client is done making changes the composition should either be canceled
        /// or completed. To cancel the composition call ImeCancelComposition. To
        /// complete the composition call either ImeCommitText or
        /// ImeFinishComposingText. Completion is usually signaled when:
        ///   A. The client receives a WM_IME_COMPOSITION message with a GCS_RESULTSTR
        ///      flag (on Windows), or;
        ///   B. The client receives a "commit" signal of GtkIMContext (on Linux), or;
        ///   C. insertText of NSTextInput is called (on Mac).
        ///
        /// This method is only used when window rendering is disabled.
        /// /*cef(optional_param=text,optional_param=underlines)*/
        /// </summary>

        public void ImeSetComposition(string text,
        List<CefCompositionUnderline> underlines,
        CefRange replacement_range,
        CefRange selection_range)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(text);
            v2.Ptr = Cef3Binder.CreateStdList(3); ;
            v3.Ptr = replacement_range.nativePtr;
            v4.Ptr = selection_range.nativePtr;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ImeSetComposition_41, out ret, ref v1, ref v2, ref v3, ref v4);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 67

        // gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
        /// <summary>
        /// Completes the existing composition by optionally inserting the specified
        /// |text| into the composition node. |replacement_range| is an optional range
        /// of the existing text that will be replaced. |relative_cursor_pos| is where
        /// the cursor will be positioned relative to the current cursor position. See
        /// comments on ImeSetComposition for usage. The |replacement_range| and
        /// |relative_cursor_pos| values are only used on OS X.
        /// This method is only used when window rendering is disabled.
        /// /*cef(optional_param=text)*/
        /// </summary>

        public void ImeCommitText(string text,
        CefRange replacement_range,
        int relative_cursor_pos)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(text);
            v2.Ptr = replacement_range.nativePtr;
            v3.I32 = (int)relative_cursor_pos;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_ImeCommitText_42, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 68

        // gen! void ImeFinishComposingText(bool keep_selection)
        /// <summary>
        /// Completes the existing composition by applying the current composition node
        /// contents. If |keep_selection| is false the current selection, if any, will
        /// be discarded. See comments on ImeSetComposition for usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void ImeFinishComposingText(bool keep_selection)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = keep_selection ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ImeFinishComposingText_43, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 69

        // gen! void ImeCancelComposition()
        /// <summary>
        /// Cancels the existing composition and discards the composition node
        /// contents without applying them. See comments on ImeSetComposition for
        /// usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void ImeCancelComposition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_ImeCancelComposition_44, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 70

        // gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /// <summary>
        /// Call this method when the user drags the mouse into the web view (before
        /// calling DragTargetDragOver/DragTargetLeave/DragTargetDrop).
        /// |drag_data| should not contain file contents as this type of data is not
        /// allowed to be dragged into the web view. File contents can be removed using
        /// CefDragData::ResetFileContents (for example, if |drag_data| comes from
        /// CefRenderHandler::StartDragging).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDragEnter(CefDragData drag_data,
        CefMouseEvent _event,
        cef_drag_operations_mask_t allowed_ops)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = drag_data.nativePtr;
            v2.Ptr = _event.nativePtr;
            v3.I32 = (int)allowed_ops;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragTargetDragEnter_45, out ret, ref v1, ref v2, ref v3);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 71

        // gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /// <summary>
        /// Call this method each time the mouse is moved across the web view during
        /// a drag operation (after calling DragTargetDragEnter and before calling
        /// DragTargetDragLeave/DragTargetDrop).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDragOver(CefMouseEvent _event,
        cef_drag_operations_mask_t allowed_ops)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = (int)allowed_ops;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_DragTargetDragOver_46, out ret, ref v1, ref v2);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 72

        // gen! void DragTargetDragLeave()
        /// <summary>
        /// Call this method when the user drags the mouse out of the web view (after
        /// calling DragTargetDragEnter).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDragLeave()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragTargetDragLeave_47, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 73

        // gen! void DragTargetDrop(const CefMouseEvent& event)
        /// <summary>
        /// Call this method when the user completes the drag operation by dropping
        /// the object onto the web view (after calling DragTargetDragEnter).
        /// The object being dropped is |drag_data|, given as an argument to
        /// the previous DragTargetDragEnter call.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDrop(CefMouseEvent _event)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_DragTargetDrop_48, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 74

        // gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
        /// <summary>
        /// Call this method when the drag operation started by a
        /// CefRenderHandler::StartDragging call has ended either in a drop or
        /// by being cancelled. |x| and |y| are mouse coordinates relative to the
        /// upper-left corner of the view. If the web view is both the drag source
        /// and the drag target then all DragTarget* methods should be called before
        /// DragSource* mthods.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragSourceEndedAt(int x,
        int y,
        cef_drag_operations_mask_t op)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)x;
            v2.I32 = (int)y;
            v3.I32 = (int)op;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragSourceEndedAt_49, out ret, ref v1, ref v2, ref v3);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 75

        // gen! void DragSourceSystemDragEnded()
        /// <summary>
        /// Call this method when the drag operation started by a
        /// CefRenderHandler::StartDragging call has completed. This method may be
        /// called immediately without first calling DragSourceEndedAt to cancel a
        /// drag operation. If the web view is both the drag source and the drag
        /// target then all DragTarget* methods should be called before DragSource*
        /// mthods.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragSourceSystemDragEnded()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragSourceSystemDragEnded_50, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 76

        // gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
        /// <summary>
        /// Returns the current visible navigation entry for this browser. This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>

        public CefNavigationEntry GetVisibleNavigationEntry()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetVisibleNavigationEntry_51, out ret);
            return new CefNavigationEntry(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 77

        // gen! void SetAccessibilityState(cef_state_t accessibility_state)
        /// <summary>
        /// Set accessibility state for all frames. |accessibility_state| may be
        /// default, enabled or disabled. If |accessibility_state| is STATE_DEFAULT
        /// then accessibility will be disabled by default and the state may be further
        /// controlled with the "force-renderer-accessibility" and
        /// "disable-renderer-accessibility" command-line switches. If
        /// |accessibility_state| is STATE_ENABLED then accessibility will be enabled.
        /// If |accessibility_state| is STATE_DISABLED then accessibility will be
        /// completely disabled.
        ///
        /// For windowed browsers accessibility will be enabled in Complete mode (which
        /// corresponds to kAccessibilityModeComplete in Chromium). In this mode all
        /// platform accessibility objects will be created and managed by Chromium's
        /// internal implementation. The client needs only to detect the screen reader
        /// and call this method appropriately. For example, on macOS the client can
        /// handle the @"AXEnhancedUserInterface" accessibility attribute to detect
        /// VoiceOver state changes and on Windows the client can handle WM_GETOBJECT
        /// with OBJID_CLIENT to detect accessibility readers.
        ///
        /// For windowless browsers accessibility will be enabled in TreeOnly mode
        /// (which corresponds to kAccessibilityModeWebContentsOnly in Chromium). In
        /// this mode renderer accessibility is enabled, the full tree is computed, and
        /// events are passed to CefAccessibiltyHandler, but platform accessibility
        /// objects are not created. The client may implement platform accessibility
        /// objects using CefAccessibiltyHandler callbacks if desired.
        /// /*cef()*/
        /// </summary>

        public void SetAccessibilityState(cef_state_t accessibility_state)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)accessibility_state;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetAccessibilityState_52, out ret, ref v1);

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 78

        // gen! bool CreateBrowser(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefString& url,const CefBrowserSettings& settings,CefRefPtr<CefRequestContext> request_context)
        /// <summary>
        /// Create a new browser window using the window parameters specified by
        /// |windowInfo|. All values will be copied internally and the actual window
        /// will be created on the UI thread. If |request_context| is empty the
        /// global request context will be used. This method can be called on any
        /// browser process thread and will not block.
        /// /*cef(optional_param=client,optional_param=url,optional_param=request_context)*/
        /// </summary>

        public static bool CreateBrowser(CefWindowInfo windowInfo,
        CefClient client,
        string url,
        CefBrowserSettings settings,
        CefRequestContext request_context)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(url);
            v1.Ptr = windowInfo.nativePtr;
            v2.Ptr = client.nativePtr;
            v4.Ptr = settings.nativePtr;
            v5.Ptr = request_context.nativePtr;

            Cef3Binder.MyCefMet_S_Call5(CefBrowserHost_S_CreateBrowser_1, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 79

        // gen! CefRefPtr<CefBrowser> CreateBrowserSync(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefString& url,const CefBrowserSettings& settings,CefRefPtr<CefRequestContext> request_context)
        /// <summary>
        /// Create a new browser window using the window parameters specified by
        /// |windowInfo|. If |request_context| is empty the global request context
        /// will be used. This method can only be called on the browser process UI
        /// thread.
        /// /*cef(optional_param=client,optional_param=url,optional_param=request_context)*/
        /// </summary>

        public static CefBrowser CreateBrowserSync(CefWindowInfo windowInfo,
        CefClient client,
        string url,
        CefBrowserSettings settings,
        CefRequestContext request_context)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(url);
            v1.Ptr = windowInfo.nativePtr;
            v2.Ptr = client.nativePtr;
            v4.Ptr = settings.nativePtr;
            v5.Ptr = request_context.nativePtr;

            Cef3Binder.MyCefMet_S_Call5(CefBrowserHost_S_CreateBrowserSync_2, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return new CefBrowser(ret.Ptr);
        }
    }


    // [virtual] class CefClient
    //CsCallToNativeCodeGen::GenerateCsCode , 80
    /// <summary>
    /// Implement this interface to provide handler implementations.
    /// /*(source=client,no_debugct_check)*/
    /// </summary>
    public struct CefClient : IDisposable
    {
        const int _typeNAME = 5;
        const int CefClient_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefClient(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefClient_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefClient New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefClient(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,49
        const int MyCefClient_GetContextMenuHandler_1 = 1;
        const int MyCefClient_GetDialogHandler_2 = 2;
        const int MyCefClient_GetDisplayHandler_3 = 3;
        const int MyCefClient_GetDownloadHandler_4 = 4;
        const int MyCefClient_GetDragHandler_5 = 5;
        const int MyCefClient_GetFindHandler_6 = 6;
        const int MyCefClient_GetFocusHandler_7 = 7;
        const int MyCefClient_GetGeolocationHandler_8 = 8;
        const int MyCefClient_GetJSDialogHandler_9 = 9;
        const int MyCefClient_GetKeyboardHandler_10 = 10;
        const int MyCefClient_GetLifeSpanHandler_11 = 11;
        const int MyCefClient_GetLoadHandler_12 = 12;
        const int MyCefClient_GetRenderHandler_13 = 13;
        const int MyCefClient_GetRequestHandler_14 = 14;
        const int MyCefClient_OnProcessMessageReceived_15 = 15;
        //gen! CefRefPtr<CefContextMenuHandler> GetContextMenuHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,50
        /// <summary>
        /// Return the handler for context menus. If no handler is provided the default
        /// implementation will be used.
        /// /*cef()*/
        /// </summary>
        public struct GetContextMenuHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetContextMenuHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetContextMenuHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetContextMenuHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetContextMenuHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,51
        [StructLayout(LayoutKind.Sequential)]
        struct GetContextMenuHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefDialogHandler> GetDialogHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,52
        /// <summary>
        /// Return the handler for dialogs. If no handler is provided the default
        /// implementation will be used.
        /// /*cef()*/
        /// </summary>
        public struct GetDialogHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetDialogHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetDialogHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetDialogHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetDialogHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,53
        [StructLayout(LayoutKind.Sequential)]
        struct GetDialogHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefDisplayHandler> GetDisplayHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,54
        /// <summary>
        /// Return the handler for browser display state events.
        /// /*cef()*/
        /// </summary>
        public struct GetDisplayHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetDisplayHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetDisplayHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetDisplayHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetDisplayHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,55
        [StructLayout(LayoutKind.Sequential)]
        struct GetDisplayHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefDownloadHandler> GetDownloadHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,56
        /// <summary>
        /// Return the handler for download events. If no handler is returned downloads
        /// will not be allowed.
        /// /*cef()*/
        /// </summary>
        public struct GetDownloadHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetDownloadHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetDownloadHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetDownloadHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetDownloadHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,57
        [StructLayout(LayoutKind.Sequential)]
        struct GetDownloadHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefDragHandler> GetDragHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,58
        /// <summary>
        /// Return the handler for drag events.
        /// /*cef()*/
        /// </summary>
        public struct GetDragHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetDragHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetDragHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetDragHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetDragHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,59
        [StructLayout(LayoutKind.Sequential)]
        struct GetDragHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefFindHandler> GetFindHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,60
        /// <summary>
        /// Return the handler for find result events.
        /// /*cef()*/
        /// </summary>
        public struct GetFindHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetFindHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetFindHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetFindHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetFindHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,61
        [StructLayout(LayoutKind.Sequential)]
        struct GetFindHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefFocusHandler> GetFocusHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,62
        /// <summary>
        /// Return the handler for focus events.
        /// /*cef()*/
        /// </summary>
        public struct GetFocusHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetFocusHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetFocusHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetFocusHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetFocusHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,63
        [StructLayout(LayoutKind.Sequential)]
        struct GetFocusHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefGeolocationHandler> GetGeolocationHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,64
        /// <summary>
        /// Return the handler for geolocation permissions requests. If no handler is
        /// provided geolocation access will be denied by default.
        /// /*cef()*/
        /// </summary>
        public struct GetGeolocationHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetGeolocationHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetGeolocationHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetGeolocationHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetGeolocationHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,65
        [StructLayout(LayoutKind.Sequential)]
        struct GetGeolocationHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefJSDialogHandler> GetJSDialogHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,66
        /// <summary>
        /// Return the handler for JavaScript dialogs. If no handler is provided the
        /// default implementation will be used.
        /// /*cef()*/
        /// </summary>
        public struct GetJSDialogHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetJSDialogHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetJSDialogHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetJSDialogHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetJSDialogHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,67
        [StructLayout(LayoutKind.Sequential)]
        struct GetJSDialogHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefKeyboardHandler> GetKeyboardHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,68
        /// <summary>
        /// Return the handler for keyboard events.
        /// /*cef()*/
        /// </summary>
        public struct GetKeyboardHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetKeyboardHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetKeyboardHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetKeyboardHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetKeyboardHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,69
        [StructLayout(LayoutKind.Sequential)]
        struct GetKeyboardHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefLifeSpanHandler> GetLifeSpanHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,70
        /// <summary>
        /// Return the handler for browser life span events.
        /// /*cef()*/
        /// </summary>
        public struct GetLifeSpanHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetLifeSpanHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetLifeSpanHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetLifeSpanHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetLifeSpanHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,71
        [StructLayout(LayoutKind.Sequential)]
        struct GetLifeSpanHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefLoadHandler> GetLoadHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,72
        /// <summary>
        /// Return the handler for browser load status events.
        /// /*cef()*/
        /// </summary>
        public struct GetLoadHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetLoadHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetLoadHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetLoadHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetLoadHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,73
        [StructLayout(LayoutKind.Sequential)]
        struct GetLoadHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefRenderHandler> GetRenderHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,74
        /// <summary>
        /// Return the handler for off-screen rendering events.
        /// /*cef()*/
        /// </summary>
        public struct GetRenderHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetRenderHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetRenderHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetRenderHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetRenderHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,75
        [StructLayout(LayoutKind.Sequential)]
        struct GetRenderHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! CefRefPtr<CefRequestHandler> GetRequestHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,76
        /// <summary>
        /// Return the handler for browser request events.
        /// /*cef()*/
        /// </summary>
        public struct GetRequestHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetRequestHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetRequestHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetRequestHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetRequestHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,77
        [StructLayout(LayoutKind.Sequential)]
        struct GetRequestHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! bool OnProcessMessageReceived(CefRefPtr<CefBrowser> browser,CefProcessId source_process,CefRefPtr<CefProcessMessage> message)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,78
        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// if the message was handled or false otherwise. Do not keep a reference to
        /// or attempt to access the message outside of this callback.
        /// /*cef()*/
        /// </summary>
        public struct OnProcessMessageReceivedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnProcessMessageReceivedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnProcessMessageReceivedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnProcessMessageReceivedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnProcessMessageReceivedNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnProcessMessageReceivedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_process_id_t source_process()
            {
                unsafe
                {
                    return (cef_process_id_t)(((OnProcessMessageReceivedNativeArgs*)this.nativePtr)->source_process);
                }
            }
            public CefProcessMessage message()
            {
                unsafe
                {
                    return new CefProcessMessage(((OnProcessMessageReceivedNativeArgs*)this.nativePtr)->message);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,79
        [StructLayout(LayoutKind.Sequential)]
        struct OnProcessMessageReceivedNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public cef_process_id_t source_process;
            public IntPtr message;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,80
            /// <summary>
            /// Return the handler for context menus. If no handler is provided the default
            /// implementation will be used.
            /// /*cef()*/
            /// </summary>
            void GetContextMenuHandler(GetContextMenuHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,81
            /// <summary>
            /// Return the handler for dialogs. If no handler is provided the default
            /// implementation will be used.
            /// /*cef()*/
            /// </summary>
            void GetDialogHandler(GetDialogHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,82
            /// <summary>
            /// Return the handler for browser display state events.
            /// /*cef()*/
            /// </summary>
            void GetDisplayHandler(GetDisplayHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,83
            /// <summary>
            /// Return the handler for download events. If no handler is returned downloads
            /// will not be allowed.
            /// /*cef()*/
            /// </summary>
            void GetDownloadHandler(GetDownloadHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,84
            /// <summary>
            /// Return the handler for drag events.
            /// /*cef()*/
            /// </summary>
            void GetDragHandler(GetDragHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,85
            /// <summary>
            /// Return the handler for find result events.
            /// /*cef()*/
            /// </summary>
            void GetFindHandler(GetFindHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,86
            /// <summary>
            /// Return the handler for focus events.
            /// /*cef()*/
            /// </summary>
            void GetFocusHandler(GetFocusHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,87
            /// <summary>
            /// Return the handler for geolocation permissions requests. If no handler is
            /// provided geolocation access will be denied by default.
            /// /*cef()*/
            /// </summary>
            void GetGeolocationHandler(GetGeolocationHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,88
            /// <summary>
            /// Return the handler for JavaScript dialogs. If no handler is provided the
            /// default implementation will be used.
            /// /*cef()*/
            /// </summary>
            void GetJSDialogHandler(GetJSDialogHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,89
            /// <summary>
            /// Return the handler for keyboard events.
            /// /*cef()*/
            /// </summary>
            void GetKeyboardHandler(GetKeyboardHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,90
            /// <summary>
            /// Return the handler for browser life span events.
            /// /*cef()*/
            /// </summary>
            void GetLifeSpanHandler(GetLifeSpanHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,91
            /// <summary>
            /// Return the handler for browser load status events.
            /// /*cef()*/
            /// </summary>
            void GetLoadHandler(GetLoadHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,92
            /// <summary>
            /// Return the handler for off-screen rendering events.
            /// /*cef()*/
            /// </summary>
            void GetRenderHandler(GetRenderHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,93
            /// <summary>
            /// Return the handler for browser request events.
            /// /*cef()*/
            /// </summary>
            void GetRequestHandler(GetRequestHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,94
            /// <summary>
            /// Called when a new message is received from a different process. Return true
            /// if the message was handled or false otherwise. Do not keep a reference to
            /// or attempt to access the message outside of this callback.
            /// /*cef()*/
            /// </summary>
            void OnProcessMessageReceived(OnProcessMessageReceivedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,95
            /// <summary>
            /// Return the handler for context menus. If no handler is provided the default
            /// implementation will be used.
            /// /*cef()*/
            /// </summary>
            CefContextMenuHandler GetContextMenuHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,96
            /// <summary>
            /// Return the handler for dialogs. If no handler is provided the default
            /// implementation will be used.
            /// /*cef()*/
            /// </summary>
            CefDialogHandler GetDialogHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,97
            /// <summary>
            /// Return the handler for browser display state events.
            /// /*cef()*/
            /// </summary>
            CefDisplayHandler GetDisplayHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,98
            /// <summary>
            /// Return the handler for download events. If no handler is returned downloads
            /// will not be allowed.
            /// /*cef()*/
            /// </summary>
            CefDownloadHandler GetDownloadHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,99
            /// <summary>
            /// Return the handler for drag events.
            /// /*cef()*/
            /// </summary>
            CefDragHandler GetDragHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,100
            /// <summary>
            /// Return the handler for find result events.
            /// /*cef()*/
            /// </summary>
            CefFindHandler GetFindHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,101
            /// <summary>
            /// Return the handler for focus events.
            /// /*cef()*/
            /// </summary>
            CefFocusHandler GetFocusHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,102
            /// <summary>
            /// Return the handler for geolocation permissions requests. If no handler is
            /// provided geolocation access will be denied by default.
            /// /*cef()*/
            /// </summary>
            CefGeolocationHandler GetGeolocationHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,103
            /// <summary>
            /// Return the handler for JavaScript dialogs. If no handler is provided the
            /// default implementation will be used.
            /// /*cef()*/
            /// </summary>
            CefJSDialogHandler GetJSDialogHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,104
            /// <summary>
            /// Return the handler for keyboard events.
            /// /*cef()*/
            /// </summary>
            CefKeyboardHandler GetKeyboardHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,105
            /// <summary>
            /// Return the handler for browser life span events.
            /// /*cef()*/
            /// </summary>
            CefLifeSpanHandler GetLifeSpanHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,106
            /// <summary>
            /// Return the handler for browser load status events.
            /// /*cef()*/
            /// </summary>
            CefLoadHandler GetLoadHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,107
            /// <summary>
            /// Return the handler for off-screen rendering events.
            /// /*cef()*/
            /// </summary>
            CefRenderHandler GetRenderHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,108
            /// <summary>
            /// Return the handler for browser request events.
            /// /*cef()*/
            /// </summary>
            CefRequestHandler GetRequestHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,109
            /// <summary>
            /// Called when a new message is received from a different process. Return true
            /// if the message was handled or false otherwise. Do not keep a reference to
            /// or attempt to access the message outside of this callback.
            /// /*cef()*/
            /// </summary>
            bool OnProcessMessageReceived(CefBrowser browser, cef_process_id_t source_process, CefProcessMessage message);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,110
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,111
                case MyCefClient_GetContextMenuHandler_1:
                    {
                        var args = new GetContextMenuHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetContextMenuHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetContextMenuHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,112
                case MyCefClient_GetDialogHandler_2:
                    {
                        var args = new GetDialogHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetDialogHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetDialogHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,113
                case MyCefClient_GetDisplayHandler_3:
                    {
                        var args = new GetDisplayHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetDisplayHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetDisplayHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,114
                case MyCefClient_GetDownloadHandler_4:
                    {
                        var args = new GetDownloadHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetDownloadHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetDownloadHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,115
                case MyCefClient_GetDragHandler_5:
                    {
                        var args = new GetDragHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetDragHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetDragHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,116
                case MyCefClient_GetFindHandler_6:
                    {
                        var args = new GetFindHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetFindHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetFindHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,117
                case MyCefClient_GetFocusHandler_7:
                    {
                        var args = new GetFocusHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetFocusHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetFocusHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,118
                case MyCefClient_GetGeolocationHandler_8:
                    {
                        var args = new GetGeolocationHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetGeolocationHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetGeolocationHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,119
                case MyCefClient_GetJSDialogHandler_9:
                    {
                        var args = new GetJSDialogHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetJSDialogHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetJSDialogHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,120
                case MyCefClient_GetKeyboardHandler_10:
                    {
                        var args = new GetKeyboardHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetKeyboardHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetKeyboardHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,121
                case MyCefClient_GetLifeSpanHandler_11:
                    {
                        var args = new GetLifeSpanHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetLifeSpanHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetLifeSpanHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,122
                case MyCefClient_GetLoadHandler_12:
                    {
                        var args = new GetLoadHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetLoadHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetLoadHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,123
                case MyCefClient_GetRenderHandler_13:
                    {
                        var args = new GetRenderHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetRenderHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetRenderHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,124
                case MyCefClient_GetRequestHandler_14:
                    {
                        var args = new GetRequestHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetRequestHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetRequestHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,125
                case MyCefClient_OnProcessMessageReceived_15:
                    {
                        var args = new OnProcessMessageReceivedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnProcessMessageReceived(args);
                        }
                        if (i1 != null)
                        {
                            OnProcessMessageReceived(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,126
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefClient_GetContextMenuHandler_1:
                    i0.GetContextMenuHandler(new GetContextMenuHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetDialogHandler_2:
                    i0.GetDialogHandler(new GetDialogHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetDisplayHandler_3:
                    i0.GetDisplayHandler(new GetDisplayHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetDownloadHandler_4:
                    i0.GetDownloadHandler(new GetDownloadHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetDragHandler_5:
                    i0.GetDragHandler(new GetDragHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetFindHandler_6:
                    i0.GetFindHandler(new GetFindHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetFocusHandler_7:
                    i0.GetFocusHandler(new GetFocusHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetGeolocationHandler_8:
                    i0.GetGeolocationHandler(new GetGeolocationHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetJSDialogHandler_9:
                    i0.GetJSDialogHandler(new GetJSDialogHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetKeyboardHandler_10:
                    i0.GetKeyboardHandler(new GetKeyboardHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetLifeSpanHandler_11:
                    i0.GetLifeSpanHandler(new GetLifeSpanHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetLoadHandler_12:
                    i0.GetLoadHandler(new GetLoadHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetRenderHandler_13:
                    i0.GetRenderHandler(new GetRenderHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_GetRequestHandler_14:
                    i0.GetRequestHandler(new GetRequestHandlerArgs(nativeArgPtr));
                    break;
                case MyCefClient_OnProcessMessageReceived_15:
                    i0.OnProcessMessageReceived(new OnProcessMessageReceivedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,127
        public static void GetContextMenuHandler(I1 i1, GetContextMenuHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,128
            i1.GetContextMenuHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,129
        public static void GetDialogHandler(I1 i1, GetDialogHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,130
            i1.GetDialogHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,131
        public static void GetDisplayHandler(I1 i1, GetDisplayHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,132
            i1.GetDisplayHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,133
        public static void GetDownloadHandler(I1 i1, GetDownloadHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,134
            i1.GetDownloadHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,135
        public static void GetDragHandler(I1 i1, GetDragHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,136
            i1.GetDragHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,137
        public static void GetFindHandler(I1 i1, GetFindHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,138
            i1.GetFindHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,139
        public static void GetFocusHandler(I1 i1, GetFocusHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,140
            i1.GetFocusHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,141
        public static void GetGeolocationHandler(I1 i1, GetGeolocationHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,142
            i1.GetGeolocationHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,143
        public static void GetJSDialogHandler(I1 i1, GetJSDialogHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,144
            i1.GetJSDialogHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,145
        public static void GetKeyboardHandler(I1 i1, GetKeyboardHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,146
            i1.GetKeyboardHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,147
        public static void GetLifeSpanHandler(I1 i1, GetLifeSpanHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,148
            i1.GetLifeSpanHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,149
        public static void GetLoadHandler(I1 i1, GetLoadHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,150
            i1.GetLoadHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,151
        public static void GetRenderHandler(I1 i1, GetRenderHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,152
            i1.GetRenderHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,153
        public static void GetRequestHandler(I1 i1, GetRequestHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,154
            i1.GetRequestHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,155
        public static void OnProcessMessageReceived(I1 i1, OnProcessMessageReceivedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,156
            args.myext_setRetValue(i1.OnProcessMessageReceived(args.browser(),
            args.source_process(),
            args.message()));
        }
    }


    // [virtual] class CefCommandLine
    //CsCallToNativeCodeGen::GenerateCsCode , 81
    /// <summary>
    /// Class used to create and/or parse command line arguments. Arguments with
    /// '--', '-' and, on Windows, '/' prefixes are considered switches. Switches
    /// will always precede any arguments without switch prefixes. Switches can
    /// optionally have a value specified using the '=' delimiter (e.g.
    /// "-switch=value"). An argument of "--" will terminate switch parsing with all
    /// subsequent tokens, regardless of prefix, being interpreted as non-switch
    /// arguments. Switch names are considered case-insensitive. This class can be
    /// used before CefInitialize() is called.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefCommandLine : IDisposable
    {
        const int _typeNAME = 6;
        const int CefCommandLine_Release_0 = (_typeNAME << 16) | 0;
        const int CefCommandLine_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefCommandLine_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefCommandLine_Copy_3 = (_typeNAME << 16) | 3;
        const int CefCommandLine_InitFromArgv_4 = (_typeNAME << 16) | 4;
        const int CefCommandLine_InitFromString_5 = (_typeNAME << 16) | 5;
        const int CefCommandLine_Reset_6 = (_typeNAME << 16) | 6;
        const int CefCommandLine_GetArgv_7 = (_typeNAME << 16) | 7;
        const int CefCommandLine_GetCommandLineString_8 = (_typeNAME << 16) | 8;
        const int CefCommandLine_GetProgram_9 = (_typeNAME << 16) | 9;
        const int CefCommandLine_SetProgram_10 = (_typeNAME << 16) | 10;
        const int CefCommandLine_HasSwitches_11 = (_typeNAME << 16) | 11;
        const int CefCommandLine_HasSwitch_12 = (_typeNAME << 16) | 12;
        const int CefCommandLine_GetSwitchValue_13 = (_typeNAME << 16) | 13;
        const int CefCommandLine_GetSwitches_14 = (_typeNAME << 16) | 14;
        const int CefCommandLine_AppendSwitch_15 = (_typeNAME << 16) | 15;
        const int CefCommandLine_AppendSwitchWithValue_16 = (_typeNAME << 16) | 16;
        const int CefCommandLine_HasArguments_17 = (_typeNAME << 16) | 17;
        const int CefCommandLine_GetArguments_18 = (_typeNAME << 16) | 18;
        const int CefCommandLine_AppendArgument_19 = (_typeNAME << 16) | 19;
        const int CefCommandLine_PrependWrapper_20 = (_typeNAME << 16) | 20;
        //
        const int CefCommandLine_S_CreateCommandLine_1 = (_typeNAME << 16) | 1;
        const int CefCommandLine_S_GetGlobalCommandLine_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefCommandLine(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 82

        // gen! bool IsValid()
        /// <summary>
        /// CefCommandLine methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 83

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsReadOnly_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 84

        // gen! CefRefPtr<CefCommandLine> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefCommandLine Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Copy_3, out ret);
            return new CefCommandLine(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 85

        // gen! void InitFromArgv(int argc,const char* const* argv)
        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This method is only
        /// supported on non-Windows platforms.
        /// /*cef()*/
        /// </summary>

        public void InitFromArgv(int argc,
        IntPtr argv)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)argc;
            v2.Ptr = argv;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_InitFromArgv_4, out ret, ref v1, ref v2);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 86

        // gen! void InitFromString(const CefString& command_line)
        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This method is only supported on Windows.
        /// /*cef()*/
        /// </summary>

        public void InitFromString(string command_line)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(command_line);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_InitFromString_5, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 87

        // gen! void Reset()
        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// /*cef()*/
        /// </summary>

        public void Reset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Reset_6, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 88

        // gen! void GetArgv(std::vector<CefString>& argv)
        /// <summary>
        /// Retrieve the original command line string as a vector of strings.
        /// The argv array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// /*cef()*/
        /// </summary>

        public void GetArgv(List<string> argv)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArgv_7, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, argv);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 89

        // gen! CefString GetCommandLineString()
        /// <summary>
        /// Constructs and returns the represented command line string. Use this method
        /// cautiously because quoting behavior is unclear.
        /// /*cef()*/
        /// </summary>

        public string GetCommandLineString()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetCommandLineString_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 90

        // gen! CefString GetProgram()
        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>

        public string GetProgram()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetProgram_9, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 91

        // gen! void SetProgram(const CefString& program)
        /// <summary>
        /// Set the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>

        public void SetProgram(string program)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(program);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_SetProgram_10, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 92

        // gen! bool HasSwitches()
        /// <summary>
        /// Returns true if the command line has switches.
        /// /*cef()*/
        /// </summary>

        public bool HasSwitches()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasSwitches_11, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 93

        // gen! bool HasSwitch(const CefString& name)
        /// <summary>
        /// Returns true if the command line contains the given switch.
        /// /*cef()*/
        /// </summary>

        public bool HasSwitch(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_HasSwitch_12, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 94

        // gen! CefString GetSwitchValue(const CefString& name)
        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this method returns the empty string.
        /// /*cef()*/
        /// </summary>

        public string GetSwitchValue(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitchValue_13, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 95

        // gen! void GetSwitches(SwitchMap& switches)
        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// empty string is returned.
        /// /*cef()*/
        /// </summary>

        public void GetSwitches(SwitchMap switches)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = switches.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitches_14, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 96

        // gen! void AppendSwitch(const CefString& name)
        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an empty value string.
        /// /*cef()*/
        /// </summary>

        public void AppendSwitch(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendSwitch_15, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 97

        // gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// /*cef()*/
        /// </summary>

        public void AppendSwitchWithValue(string name,
        string value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(value);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_AppendSwitchWithValue_16, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 98

        // gen! bool HasArguments()
        /// <summary>
        /// True if there are remaining command line arguments.
        /// /*cef()*/
        /// </summary>

        public bool HasArguments()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasArguments_17, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 99

        // gen! void GetArguments(ArgumentList& arguments)
        /// <summary>
        /// Get the remaining command line arguments.
        /// /*cef()*/
        /// </summary>

        public void GetArguments(ArgumentList arguments)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = arguments.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArguments_18, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 100

        // gen! void AppendArgument(const CefString& argument)
        /// <summary>
        /// Add an argument to the end of the command line.
        /// /*cef()*/
        /// </summary>

        public void AppendArgument(string argument)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(argument);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendArgument_19, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 101

        // gen! void PrependWrapper(const CefString& wrapper)
        /// <summary>
        /// Insert a command before the current command.
        /// Common for debuggers, like "valgrind" or "gdb --args".
        /// /*cef()*/
        /// </summary>

        public void PrependWrapper(string wrapper)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(wrapper);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_PrependWrapper_20, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 102

        // gen! CefRefPtr<CefCommandLine> CreateCommandLine()
        /// <summary>
        /// Create a new CefCommandLine instance.
        /// /*cef(api_hash_check)*/
        /// </summary>

        public static CefCommandLine CreateCommandLine()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefCommandLine_S_CreateCommandLine_1, out ret);
            return new CefCommandLine(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 103

        // gen! CefRefPtr<CefCommandLine> GetGlobalCommandLine()
        /// <summary>
        /// Returns the singleton global CefCommandLine object. The returned object
        /// will be read-only.
        /// /*cef(api_hash_check)*/
        /// </summary>

        public static CefCommandLine GetGlobalCommandLine()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefCommandLine_S_GetGlobalCommandLine_2, out ret);
            return new CefCommandLine(ret.Ptr);
        }
    }


    // [virtual] class CefContextMenuParams
    //CsCallToNativeCodeGen::GenerateCsCode , 104
    /// <summary>
    /// Provides information about the context menu state. The ethods of this class
    /// can only be accessed on browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefContextMenuParams : IDisposable
    {
        const int _typeNAME = 7;
        const int CefContextMenuParams_Release_0 = (_typeNAME << 16) | 0;
        const int CefContextMenuParams_GetXCoord_1 = (_typeNAME << 16) | 1;
        const int CefContextMenuParams_GetYCoord_2 = (_typeNAME << 16) | 2;
        const int CefContextMenuParams_GetTypeFlags_3 = (_typeNAME << 16) | 3;
        const int CefContextMenuParams_GetLinkUrl_4 = (_typeNAME << 16) | 4;
        const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = (_typeNAME << 16) | 5;
        const int CefContextMenuParams_GetSourceUrl_6 = (_typeNAME << 16) | 6;
        const int CefContextMenuParams_HasImageContents_7 = (_typeNAME << 16) | 7;
        const int CefContextMenuParams_GetTitleText_8 = (_typeNAME << 16) | 8;
        const int CefContextMenuParams_GetPageUrl_9 = (_typeNAME << 16) | 9;
        const int CefContextMenuParams_GetFrameUrl_10 = (_typeNAME << 16) | 10;
        const int CefContextMenuParams_GetFrameCharset_11 = (_typeNAME << 16) | 11;
        const int CefContextMenuParams_GetMediaType_12 = (_typeNAME << 16) | 12;
        const int CefContextMenuParams_GetMediaStateFlags_13 = (_typeNAME << 16) | 13;
        const int CefContextMenuParams_GetSelectionText_14 = (_typeNAME << 16) | 14;
        const int CefContextMenuParams_GetMisspelledWord_15 = (_typeNAME << 16) | 15;
        const int CefContextMenuParams_GetDictionarySuggestions_16 = (_typeNAME << 16) | 16;
        const int CefContextMenuParams_IsEditable_17 = (_typeNAME << 16) | 17;
        const int CefContextMenuParams_IsSpellCheckEnabled_18 = (_typeNAME << 16) | 18;
        const int CefContextMenuParams_GetEditStateFlags_19 = (_typeNAME << 16) | 19;
        const int CefContextMenuParams_IsCustomMenu_20 = (_typeNAME << 16) | 20;
        const int CefContextMenuParams_IsPepperMenu_21 = (_typeNAME << 16) | 21;
        internal IntPtr nativePtr;
        internal CefContextMenuParams(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 105

        // gen! int GetXCoord()
        /// <summary>
        /// CefContextMenuParams methods.
        /// </summary>

        public int GetXCoord()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetXCoord_1, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 106

        // gen! int GetYCoord()
        /// <summary>
        /// Returns the Y coordinate of the mouse where the context menu was invoked.
        /// Coords are relative to the associated RenderView's origin.
        /// /*cef()*/
        /// </summary>

        public int GetYCoord()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetYCoord_2, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 107

        // gen! TypeFlags GetTypeFlags()
        /// <summary>
        /// Returns flags representing the type of node that the context menu was
        /// invoked on.
        /// /*cef(default_retval=CM_TYPEFLAG_NONE)*/
        /// </summary>

        public cef_context_menu_type_flags_t GetTypeFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTypeFlags_3, out ret);
            return (cef_context_menu_type_flags_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 108

        // gen! CefString GetLinkUrl()
        /// <summary>
        /// Returns the URL of the link, if any, that encloses the node that the
        /// context menu was invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetLinkUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetLinkUrl_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 109

        // gen! CefString GetUnfilteredLinkUrl()
        /// <summary>
        /// Returns the link URL, if any, to be used ONLY for "copy link address". We
        /// don't validate this field in the frontend process.
        /// /*cef()*/
        /// </summary>

        public string GetUnfilteredLinkUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetUnfilteredLinkUrl_5, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 110

        // gen! CefString GetSourceUrl()
        /// <summary>
        /// Returns the source URL, if any, for the element that the context menu was
        /// invoked on. Example of elements with source URLs are img, audio, and video.
        /// /*cef()*/
        /// </summary>

        public string GetSourceUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSourceUrl_6, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 111

        // gen! bool HasImageContents()
        /// <summary>
        /// Returns true if the context menu was invoked on an image which has
        /// non-empty contents.
        /// /*cef()*/
        /// </summary>

        public bool HasImageContents()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_HasImageContents_7, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 112

        // gen! CefString GetTitleText()
        /// <summary>
        /// Returns the title text or the alt text if the context menu was invoked on
        /// an image.
        /// /*cef()*/
        /// </summary>

        public string GetTitleText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTitleText_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 113

        // gen! CefString GetPageUrl()
        /// <summary>
        /// Returns the URL of the top level page that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetPageUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetPageUrl_9, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 114

        // gen! CefString GetFrameUrl()
        /// <summary>
        /// Returns the URL of the subframe that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetFrameUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameUrl_10, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 115

        // gen! CefString GetFrameCharset()
        /// <summary>
        /// Returns the character encoding of the subframe that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetFrameCharset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameCharset_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 116

        // gen! MediaType GetMediaType()
        /// <summary>
        /// Returns the type of context node that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIATYPE_NONE)*/
        /// </summary>

        public cef_context_menu_media_type_t GetMediaType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaType_12, out ret);
            return (cef_context_menu_media_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 117

        // gen! MediaStateFlags GetMediaStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the media element, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIAFLAG_NONE)*/
        /// </summary>

        public cef_context_menu_media_state_flags_t GetMediaStateFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaStateFlags_13, out ret);
            return (cef_context_menu_media_state_flags_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 118

        // gen! CefString GetSelectionText()
        /// <summary>
        /// Returns the text of the selection, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetSelectionText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSelectionText_14, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 119

        // gen! CefString GetMisspelledWord()
        /// <summary>
        /// Returns the text of the misspelled word, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetMisspelledWord()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMisspelledWord_15, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 120

        // gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
        /// <summary>
        /// Returns true if suggestions exist, false otherwise. Fills in |suggestions|
        /// from the spell check service for the misspelled word if there is one.
        /// /*cef()*/
        /// </summary>

        public bool GetDictionarySuggestions(List<string> suggestions)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefContextMenuParams_GetDictionarySuggestions_16, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, suggestions);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 121

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node.
        /// /*cef()*/
        /// </summary>

        public bool IsEditable()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsEditable_17, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 122

        // gen! bool IsSpellCheckEnabled()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node where
        /// spell-check is enabled.
        /// /*cef()*/
        /// </summary>

        public bool IsSpellCheckEnabled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsSpellCheckEnabled_18, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 123

        // gen! EditStateFlags GetEditStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the editable node, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_EDITFLAG_NONE)*/
        /// </summary>

        public cef_context_menu_edit_state_flags_t GetEditStateFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetEditStateFlags_19, out ret);
            return (cef_context_menu_edit_state_flags_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 124

        // gen! bool IsCustomMenu()
        /// <summary>
        /// Returns true if the context menu contains items specified by the renderer
        /// process (for example, plugin placeholder or pepper plugin menu items).
        /// /*cef()*/
        /// </summary>

        public bool IsCustomMenu()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsCustomMenu_20, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 125

        // gen! bool IsPepperMenu()
        /// <summary>
        /// Returns true if the context menu was invoked from a pepper plugin.
        /// /*cef()*/
        /// </summary>

        public bool IsPepperMenu()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsPepperMenu_21, out ret);
            return ret.I32 != 0;
        }
    }


    // [virtual] class CefCookieManager
    //CsCallToNativeCodeGen::GenerateCsCode , 126
    /// <summary>
    /// Class used for managing cookies. The methods of this class may be called on
    /// any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefCookieManager : IDisposable
    {
        const int _typeNAME = 8;
        const int CefCookieManager_Release_0 = (_typeNAME << 16) | 0;
        const int CefCookieManager_SetSupportedSchemes_1 = (_typeNAME << 16) | 1;
        const int CefCookieManager_VisitAllCookies_2 = (_typeNAME << 16) | 2;
        const int CefCookieManager_VisitUrlCookies_3 = (_typeNAME << 16) | 3;
        const int CefCookieManager_SetCookie_4 = (_typeNAME << 16) | 4;
        const int CefCookieManager_DeleteCookies_5 = (_typeNAME << 16) | 5;
        const int CefCookieManager_SetStoragePath_6 = (_typeNAME << 16) | 6;
        const int CefCookieManager_FlushStore_7 = (_typeNAME << 16) | 7;
        //
        const int CefCookieManager_S_GetGlobalManager_1 = (_typeNAME << 16) | 1;
        const int CefCookieManager_S_CreateManager_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefCookieManager(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieManager_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 127

        // gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// CefCookieManager methods.
        /// </summary>

        public void SetSupportedSchemes(List<string> schemes,
        CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);
            v2.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCookieManager_SetSupportedSchemes_1, out ret, ref v1, ref v2);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, schemes);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 128

        // gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
        /// <summary>
        /// Visit all cookies on the IO thread. The returned cookies are ordered by
        /// longest path, then by earliest creation date. Returns false if cookies
        /// cannot be accessed.
        /// /*cef()*/
        /// </summary>

        public bool VisitAllCookies(CefCookieVisitor visitor)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_VisitAllCookies_2, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 129

        // gen! bool VisitUrlCookies(const CefString& url,bool includeHttpOnly,CefRefPtr<CefCookieVisitor> visitor)
        /// <summary>
        /// Visit a subset of cookies on the IO thread. The results are filtered by the
        /// given url scheme, host, domain and path. If |includeHttpOnly| is true
        /// HTTP-only cookies will also be included in the results. The returned
        /// cookies are ordered by longest path, then by earliest creation date.
        /// Returns false if cookies cannot be accessed.
        /// /*cef()*/
        /// </summary>

        public bool VisitUrlCookies(string url,
        bool includeHttpOnly,
        CefCookieVisitor visitor)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);
            v2.I32 = includeHttpOnly ? 1 : 0;
            v3.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_VisitUrlCookies_3, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 130

        // gen! bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
        /// <summary>
        /// Sets a cookie given a valid URL and explicit user-provided cookie
        /// attributes. This function expects each attribute to be well-formed. It will
        /// check for disallowed characters (e.g. the ';' character is disallowed
        /// within the cookie value attribute) and fail without setting the cookie if
        /// such characters are found. If |callback| is non-NULL it will be executed
        /// asnychronously on the IO thread after the cookie has been set. Returns
        /// false if an invalid URL is specified or if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public bool SetCookie(string url,
        CefCookie cookie,
        CefSetCookieCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);
            v2.Ptr = cookie.nativePtr;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetCookie_4, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 131

        // gen! bool DeleteCookies(const CefString& url,const CefString& cookie_name,CefRefPtr<CefDeleteCookiesCallback> callback)
        /// <summary>
        /// Delete all cookies that match the specified parameters. If both |url| and
        /// |cookie_name| values are specified all host and domain cookies matching
        /// both will be deleted. If only |url| is specified all host cookies (but not
        /// domain cookies) irrespective of path will be deleted. If |url| is empty all
        /// cookies for all hosts and domains will be deleted. If |callback| is
        /// non-NULL it will be executed asnychronously on the IO thread after the
        /// cookies have been deleted. Returns false if a non-empty invalid URL is
        /// specified or if cookies cannot be accessed. Cookies can alternately be
        /// deleted using the Visit*Cookies() methods.
        /// /*cef(optional_param=url,optional_param=cookie_name,optional_param=callback)*/
        /// </summary>

        public bool DeleteCookies(string url,
        string cookie_name,
        CefDeleteCookiesCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(cookie_name);
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_DeleteCookies_5, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 132

        // gen! bool SetStoragePath(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Sets the directory path that will be used for storing cookie data. If
        /// |path| is empty data will be stored in memory only. Otherwise, data will be
        /// stored at the specified |path|. To persist session cookies (cookies without
        /// an expiry date or validity interval) set |persist_session_cookies| to true.
        /// Session cookies are generally intended to be transient and most Web
        /// browsers do not persist them. If |callback| is non-NULL it will be executed
        /// asnychronously on the IO thread after the manager's storage has been
        /// initialized. Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=path,optional_param=callback)*/
        /// </summary>

        public bool SetStoragePath(string path,
        bool persist_session_cookies,
        CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(path);
            v2.I32 = persist_session_cookies ? 1 : 0;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetStoragePath_6, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 133

        // gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Flush the backing store (if any) to disk. If |callback| is non-NULL it will
        /// be executed asnychronously on the IO thread after the flush is complete.
        /// Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public bool FlushStore(CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_FlushStore_7, out ret, ref v1);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 134

        // gen! CefRefPtr<CefCookieManager> GetGlobalManager(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Returns the global cookie manager. By default data will be stored at
        /// CefSettings.cache_path if specified or in memory otherwise. If |callback|
        /// is non-NULL it will be executed asnychronously on the IO thread after the
        /// manager's storage has been initialized. Using this method is equivalent to
        /// calling CefRequestContext::GetGlobalContext()->GetDefaultCookieManager().
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public static CefCookieManager GetGlobalManager(CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_S_Call1(CefCookieManager_S_GetGlobalManager_1, out ret, ref v1);
            return new CefCookieManager(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 135

        // gen! CefRefPtr<CefCookieManager> CreateManager(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Creates a new cookie manager. If |path| is empty data will be stored in
        /// memory only. Otherwise, data will be stored at the specified |path|. To
        /// persist session cookies (cookies without an expiry date or validity
        /// interval) set |persist_session_cookies| to true. Session cookies are
        /// generally intended to be transient and most Web browsers do not persist
        /// them. If |callback| is non-NULL it will be executed asnychronously on the
        /// IO thread after the manager's storage has been initialized.
        /// /*cef(optional_param=path,optional_param=callback)*/
        /// </summary>

        public static CefCookieManager CreateManager(string path,
        bool persist_session_cookies,
        CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(path);
            v2.I32 = persist_session_cookies ? 1 : 0;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_S_Call3(CefCookieManager_S_CreateManager_2, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefCookieManager(ret.Ptr);
        }
    }


    // [virtual] class CefCookieVisitor
    //CsCallToNativeCodeGen::GenerateCsCode , 136
    /// <summary>
    /// Interface to implement for visiting cookie values. The methods of this class
    /// will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefCookieVisitor : IDisposable
    {
        const int _typeNAME = 9;
        const int CefCookieVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefCookieVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieVisitor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefCookieVisitor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefCookieVisitor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,157
        const int MyCefCookieVisitor_Visit_1 = 1;
        //gen! bool Visit(const CefCookie& cookie,int count,int total,bool& deleteCookie)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,158
        /// <summary>
        /// Method that will be called once for each cookie. |count| is the 0-based
        /// index for the current cookie. |total| is the total number of cookies.
        /// Set |deleteCookie| to true to delete the cookie currently being visited.
        /// Return false to stop visiting cookies. This method may never be called if
        /// no cookies are found.
        /// /*cef()*/
        /// </summary>
        public struct VisitArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal VisitArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((VisitNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((VisitNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((VisitNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefCookie cookie()
            {
                unsafe
                {
                    return new CefCookie(((VisitNativeArgs*)this.nativePtr)->cookie);
                }
            }
            public int count()
            {
                unsafe
                {
                    return ((VisitNativeArgs*)this.nativePtr)->count;
                }
            }
            public int total()
            {
                unsafe
                {
                    return ((VisitNativeArgs*)this.nativePtr)->total;
                }
            }
            public bool deleteCookie()
            {
                unsafe
                {
                    return MyMetArgs.GetAsBool(nativePtr, 4);
                }
            }
            public void deleteCookie(bool value)
            {
                MyMetArgs.SetBoolToAddress(nativePtr, 4, value);
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,159
        [StructLayout(LayoutKind.Sequential)]
        struct VisitNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr cookie;
            public int count;
            public int total;
            public double deleteCookie;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,160
            /// <summary>
            /// Method that will be called once for each cookie. |count| is the 0-based
            /// index for the current cookie. |total| is the total number of cookies.
            /// Set |deleteCookie| to true to delete the cookie currently being visited.
            /// Return false to stop visiting cookies. This method may never be called if
            /// no cookies are found.
            /// /*cef()*/
            /// </summary>
            void Visit(VisitArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,161
            /// <summary>
            /// Method that will be called once for each cookie. |count| is the 0-based
            /// index for the current cookie. |total| is the total number of cookies.
            /// Set |deleteCookie| to true to delete the cookie currently being visited.
            /// Return false to stop visiting cookies. This method may never be called if
            /// no cookies are found.
            /// /*cef()*/
            /// </summary>
            bool Visit(CefCookie cookie, int count, int total, ref bool deleteCookie);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,162
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,163
                case MyCefCookieVisitor_Visit_1:
                    {
                        var args = new VisitArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Visit(args);
                        }
                        if (i1 != null)
                        {
                            Visit(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,164
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefCookieVisitor_Visit_1:
                    i0.Visit(new VisitArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,165
        public static void Visit(I1 i1, VisitArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,166
            bool deleteCookie = false;
            args.myext_setRetValue(i1.Visit(args.cookie(),
            args.count(),
            args.total(),
            ref deleteCookie));
            args.deleteCookie(deleteCookie);
        }
    }


    // [virtual] class CefDOMVisitor
    //CsCallToNativeCodeGen::GenerateCsCode , 137
    /// <summary>
    /// Interface to implement for visiting the DOM. The methods of this class will
    /// be called on the render process main thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefDOMVisitor : IDisposable
    {
        const int _typeNAME = 10;
        const int CefDOMVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefDOMVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMVisitor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefDOMVisitor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefDOMVisitor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,167
        const int MyCefDOMVisitor_Visit_1 = 1;
        //gen! void Visit(CefRefPtr<CefDOMDocument> document)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,168
        /// <summary>
        /// Method executed for visiting the DOM. The document object passed to this
        /// method represents a snapshot of the DOM at the time this method is
        /// executed. DOM objects are only valid for the scope of this method. Do not
        /// keep references to or attempt to access any DOM objects outside the scope
        /// of this method.
        /// /*cef()*/
        /// </summary>
        public struct VisitArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal VisitArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((VisitNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((VisitNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefDOMDocument document()
            {
                unsafe
                {
                    return new CefDOMDocument(((VisitNativeArgs*)this.nativePtr)->document);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,169
        [StructLayout(LayoutKind.Sequential)]
        struct VisitNativeArgs
        {
            public int argFlags;
            public IntPtr document;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,170
            /// <summary>
            /// Method executed for visiting the DOM. The document object passed to this
            /// method represents a snapshot of the DOM at the time this method is
            /// executed. DOM objects are only valid for the scope of this method. Do not
            /// keep references to or attempt to access any DOM objects outside the scope
            /// of this method.
            /// /*cef()*/
            /// </summary>
            void Visit(VisitArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,171
            /// <summary>
            /// Method executed for visiting the DOM. The document object passed to this
            /// method represents a snapshot of the DOM at the time this method is
            /// executed. DOM objects are only valid for the scope of this method. Do not
            /// keep references to or attempt to access any DOM objects outside the scope
            /// of this method.
            /// /*cef()*/
            /// </summary>
            void Visit(CefDOMDocument document);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,172
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,173
                case MyCefDOMVisitor_Visit_1:
                    {
                        var args = new VisitArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Visit(args);
                        }
                        if (i1 != null)
                        {
                            Visit(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,174
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefDOMVisitor_Visit_1:
                    i0.Visit(new VisitArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,175
        public static void Visit(I1 i1, VisitArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,176
            i1.Visit(args.document());
        }
    }


    // [virtual] class CefDOMDocument
    //CsCallToNativeCodeGen::GenerateCsCode , 138
    /// <summary>
    /// Class used to represent a DOM document. The methods of this class should only
    /// be called on the render process main thread thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDOMDocument : IDisposable
    {
        const int _typeNAME = 11;
        const int CefDOMDocument_Release_0 = (_typeNAME << 16) | 0;
        const int CefDOMDocument_GetType_1 = (_typeNAME << 16) | 1;
        const int CefDOMDocument_GetDocument_2 = (_typeNAME << 16) | 2;
        const int CefDOMDocument_GetBody_3 = (_typeNAME << 16) | 3;
        const int CefDOMDocument_GetHead_4 = (_typeNAME << 16) | 4;
        const int CefDOMDocument_GetTitle_5 = (_typeNAME << 16) | 5;
        const int CefDOMDocument_GetElementById_6 = (_typeNAME << 16) | 6;
        const int CefDOMDocument_GetFocusedNode_7 = (_typeNAME << 16) | 7;
        const int CefDOMDocument_HasSelection_8 = (_typeNAME << 16) | 8;
        const int CefDOMDocument_GetSelectionStartOffset_9 = (_typeNAME << 16) | 9;
        const int CefDOMDocument_GetSelectionEndOffset_10 = (_typeNAME << 16) | 10;
        const int CefDOMDocument_GetSelectionAsMarkup_11 = (_typeNAME << 16) | 11;
        const int CefDOMDocument_GetSelectionAsText_12 = (_typeNAME << 16) | 12;
        const int CefDOMDocument_GetBaseURL_13 = (_typeNAME << 16) | 13;
        const int CefDOMDocument_GetCompleteURL_14 = (_typeNAME << 16) | 14;
        internal IntPtr nativePtr;
        internal CefDOMDocument(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 139

        // gen! Type GetType()
        /// <summary>
        /// CefDOMDocument methods.
        /// </summary>

        public cef_dom_document_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetType_1, out ret);
            return (cef_dom_document_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 140

        // gen! CefRefPtr<CefDOMNode> GetDocument()
        /// <summary>
        /// Returns the root document node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetDocument()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetDocument_2, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 141

        // gen! CefRefPtr<CefDOMNode> GetBody()
        /// <summary>
        /// Returns the BODY node of an HTML document.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetBody()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBody_3, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 142

        // gen! CefRefPtr<CefDOMNode> GetHead()
        /// <summary>
        /// Returns the HEAD node of an HTML document.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetHead()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetHead_4, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 143

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title of an HTML document.
        /// /*cef()*/
        /// </summary>

        public string GetTitle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetTitle_5, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 144

        // gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
        /// <summary>
        /// Returns the document element with the specified ID value.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetElementById(string id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(id);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetElementById_6, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 145

        // gen! CefRefPtr<CefDOMNode> GetFocusedNode()
        /// <summary>
        /// Returns the node that currently has keyboard focus.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetFocusedNode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetFocusedNode_7, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 146

        // gen! bool HasSelection()
        /// <summary>
        /// Returns true if a portion of the document is selected.
        /// /*cef()*/
        /// </summary>

        public bool HasSelection()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_HasSelection_8, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 147

        // gen! int GetSelectionStartOffset()
        /// <summary>
        /// Returns the selection offset within the start node.
        /// /*cef()*/
        /// </summary>

        public int GetSelectionStartOffset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionStartOffset_9, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 148

        // gen! int GetSelectionEndOffset()
        /// <summary>
        /// Returns the selection offset within the end node.
        /// /*cef()*/
        /// </summary>

        public int GetSelectionEndOffset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionEndOffset_10, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 149

        // gen! CefString GetSelectionAsMarkup()
        /// <summary>
        /// Returns the contents of this selection as markup.
        /// /*cef()*/
        /// </summary>

        public string GetSelectionAsMarkup()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsMarkup_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 150

        // gen! CefString GetSelectionAsText()
        /// <summary>
        /// Returns the contents of this selection as text.
        /// /*cef()*/
        /// </summary>

        public string GetSelectionAsText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsText_12, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 151

        // gen! CefString GetBaseURL()
        /// <summary>
        /// Returns the base URL for the document.
        /// /*cef()*/
        /// </summary>

        public string GetBaseURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBaseURL_13, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 152

        // gen! CefString GetCompleteURL(const CefString& partialURL)
        /// <summary>
        /// Returns a complete URL based on the document base URL and the specified
        /// partial URL.
        /// /*cef()*/
        /// </summary>

        public string GetCompleteURL(string partialURL)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(partialURL);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetCompleteURL_14, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
    }


    // [virtual] class CefDOMNode
    //CsCallToNativeCodeGen::GenerateCsCode , 153
    /// <summary>
    /// Class used to represent a DOM node. The methods of this class should only be
    /// called on the render process main thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDOMNode : IDisposable
    {
        const int _typeNAME = 12;
        const int CefDOMNode_Release_0 = (_typeNAME << 16) | 0;
        const int CefDOMNode_GetType_1 = (_typeNAME << 16) | 1;
        const int CefDOMNode_IsText_2 = (_typeNAME << 16) | 2;
        const int CefDOMNode_IsElement_3 = (_typeNAME << 16) | 3;
        const int CefDOMNode_IsEditable_4 = (_typeNAME << 16) | 4;
        const int CefDOMNode_IsFormControlElement_5 = (_typeNAME << 16) | 5;
        const int CefDOMNode_GetFormControlElementType_6 = (_typeNAME << 16) | 6;
        const int CefDOMNode_IsSame_7 = (_typeNAME << 16) | 7;
        const int CefDOMNode_GetName_8 = (_typeNAME << 16) | 8;
        const int CefDOMNode_GetValue_9 = (_typeNAME << 16) | 9;
        const int CefDOMNode_SetValue_10 = (_typeNAME << 16) | 10;
        const int CefDOMNode_GetAsMarkup_11 = (_typeNAME << 16) | 11;
        const int CefDOMNode_GetDocument_12 = (_typeNAME << 16) | 12;
        const int CefDOMNode_GetParent_13 = (_typeNAME << 16) | 13;
        const int CefDOMNode_GetPreviousSibling_14 = (_typeNAME << 16) | 14;
        const int CefDOMNode_GetNextSibling_15 = (_typeNAME << 16) | 15;
        const int CefDOMNode_HasChildren_16 = (_typeNAME << 16) | 16;
        const int CefDOMNode_GetFirstChild_17 = (_typeNAME << 16) | 17;
        const int CefDOMNode_GetLastChild_18 = (_typeNAME << 16) | 18;
        const int CefDOMNode_GetElementTagName_19 = (_typeNAME << 16) | 19;
        const int CefDOMNode_HasElementAttributes_20 = (_typeNAME << 16) | 20;
        const int CefDOMNode_HasElementAttribute_21 = (_typeNAME << 16) | 21;
        const int CefDOMNode_GetElementAttribute_22 = (_typeNAME << 16) | 22;
        const int CefDOMNode_GetElementAttributes_23 = (_typeNAME << 16) | 23;
        const int CefDOMNode_SetElementAttribute_24 = (_typeNAME << 16) | 24;
        const int CefDOMNode_GetElementInnerText_25 = (_typeNAME << 16) | 25;
        const int CefDOMNode_GetElementBounds_26 = (_typeNAME << 16) | 26;
        internal IntPtr nativePtr;
        internal CefDOMNode(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 154

        // gen! Type GetType()
        /// <summary>
        /// CefDOMNode methods.
        /// </summary>

        public cef_dom_node_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetType_1, out ret);
            return (cef_dom_node_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 155

        // gen! bool IsText()
        /// <summary>
        /// Returns true if this is a text node.
        /// /*cef()*/
        /// </summary>

        public bool IsText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsText_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 156

        // gen! bool IsElement()
        /// <summary>
        /// Returns true if this is an element node.
        /// /*cef()*/
        /// </summary>

        public bool IsElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsElement_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 157

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if this is an editable node.
        /// /*cef()*/
        /// </summary>

        public bool IsEditable()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsEditable_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 158

        // gen! bool IsFormControlElement()
        /// <summary>
        /// Returns true if this is a form control element node.
        /// /*cef()*/
        /// </summary>

        public bool IsFormControlElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsFormControlElement_5, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 159

        // gen! CefString GetFormControlElementType()
        /// <summary>
        /// Returns the type of this form control element node.
        /// /*cef()*/
        /// </summary>

        public string GetFormControlElementType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFormControlElementType_6, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 160

        // gen! bool IsSame(CefRefPtr<CefDOMNode> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefDOMNode that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_IsSame_7, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 161

        // gen! CefString GetName()
        /// <summary>
        /// Returns the name of this node.
        /// /*cef()*/
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetName_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 162

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the value of this node.
        /// /*cef()*/
        /// </summary>

        public string GetValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetValue_9, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 163

        // gen! bool SetValue(const CefString& value)
        /// <summary>
        /// Set the value of this node. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetValue(string value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(value);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_SetValue_10, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 164

        // gen! CefString GetAsMarkup()
        /// <summary>
        /// Returns the contents of this node as markup.
        /// /*cef()*/
        /// </summary>

        public string GetAsMarkup()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetAsMarkup_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 165

        // gen! CefRefPtr<CefDOMDocument> GetDocument()
        /// <summary>
        /// Returns the document associated with this node.
        /// /*cef()*/
        /// </summary>

        public CefDOMDocument GetDocument()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetDocument_12, out ret);
            return new CefDOMDocument(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 166

        // gen! CefRefPtr<CefDOMNode> GetParent()
        /// <summary>
        /// Returns the parent node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetParent()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetParent_13, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 167

        // gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
        /// <summary>
        /// Returns the previous sibling node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetPreviousSibling()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetPreviousSibling_14, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 168

        // gen! CefRefPtr<CefDOMNode> GetNextSibling()
        /// <summary>
        /// Returns the next sibling node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetNextSibling()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetNextSibling_15, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 169

        // gen! bool HasChildren()
        /// <summary>
        /// Returns true if this node has child nodes.
        /// /*cef()*/
        /// </summary>

        public bool HasChildren()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasChildren_16, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 170

        // gen! CefRefPtr<CefDOMNode> GetFirstChild()
        /// <summary>
        /// Return the first child node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetFirstChild()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFirstChild_17, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 171

        // gen! CefRefPtr<CefDOMNode> GetLastChild()
        /// <summary>
        /// Returns the last child node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetLastChild()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetLastChild_18, out ret);
            return new CefDOMNode(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 172

        // gen! CefString GetElementTagName()
        /// <summary>
        /// The following methods are valid only for element nodes.
        /// Returns the tag name of this element.
        /// /*cef()*/
        /// </summary>

        public string GetElementTagName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementTagName_19, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 173

        // gen! bool HasElementAttributes()
        /// <summary>
        /// Returns true if this element has attributes.
        /// /*cef()*/
        /// </summary>

        public bool HasElementAttributes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasElementAttributes_20, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 174

        // gen! bool HasElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns true if this element has an attribute named |attrName|.
        /// /*cef()*/
        /// </summary>

        public bool HasElementAttribute(string attrName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(attrName);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_HasElementAttribute_21, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 175

        // gen! CefString GetElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// /*cef()*/
        /// </summary>

        public string GetElementAttribute(string attrName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(attrName);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttribute_22, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 176

        // gen! void GetElementAttributes(AttributeMap& attrMap)
        /// <summary>
        /// Returns a map of all element attributes.
        /// /*cef()*/
        /// </summary>

        public void GetElementAttributes(AttributeMap attrMap)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = attrMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttributes_23, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 177

        // gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetElementAttribute(string attrName,
        string value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(attrName);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(value);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDOMNode_SetElementAttribute_24, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 178

        // gen! CefString GetElementInnerText()
        /// <summary>
        /// Returns the inner text of the element.
        /// /*cef()*/
        /// </summary>

        public string GetElementInnerText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementInnerText_25, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 179

        // gen! CefRect GetElementBounds()
        /// <summary>
        /// Returns the bounds of the element.
        /// /*cef()*/
        /// </summary>

        public CefRect GetElementBounds()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementBounds_26, out ret);
            return new CefRect(ret.Ptr);

        }
    }


    // [virtual] class CefDownloadItem
    //CsCallToNativeCodeGen::GenerateCsCode , 180
    /// <summary>
    /// Class used to represent a download item.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDownloadItem : IDisposable
    {
        const int _typeNAME = 13;
        const int CefDownloadItem_Release_0 = (_typeNAME << 16) | 0;
        const int CefDownloadItem_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefDownloadItem_IsInProgress_2 = (_typeNAME << 16) | 2;
        const int CefDownloadItem_IsComplete_3 = (_typeNAME << 16) | 3;
        const int CefDownloadItem_IsCanceled_4 = (_typeNAME << 16) | 4;
        const int CefDownloadItem_GetCurrentSpeed_5 = (_typeNAME << 16) | 5;
        const int CefDownloadItem_GetPercentComplete_6 = (_typeNAME << 16) | 6;
        const int CefDownloadItem_GetTotalBytes_7 = (_typeNAME << 16) | 7;
        const int CefDownloadItem_GetReceivedBytes_8 = (_typeNAME << 16) | 8;
        const int CefDownloadItem_GetStartTime_9 = (_typeNAME << 16) | 9;
        const int CefDownloadItem_GetEndTime_10 = (_typeNAME << 16) | 10;
        const int CefDownloadItem_GetFullPath_11 = (_typeNAME << 16) | 11;
        const int CefDownloadItem_GetId_12 = (_typeNAME << 16) | 12;
        const int CefDownloadItem_GetURL_13 = (_typeNAME << 16) | 13;
        const int CefDownloadItem_GetOriginalUrl_14 = (_typeNAME << 16) | 14;
        const int CefDownloadItem_GetSuggestedFileName_15 = (_typeNAME << 16) | 15;
        const int CefDownloadItem_GetContentDisposition_16 = (_typeNAME << 16) | 16;
        const int CefDownloadItem_GetMimeType_17 = (_typeNAME << 16) | 17;
        internal IntPtr nativePtr;
        internal CefDownloadItem(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 181

        // gen! bool IsValid()
        /// <summary>
        /// CefDownloadItem methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 182

        // gen! bool IsInProgress()
        /// <summary>
        /// Returns true if the download is in progress.
        /// /*cef()*/
        /// </summary>

        public bool IsInProgress()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsInProgress_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 183

        // gen! bool IsComplete()
        /// <summary>
        /// Returns true if the download is complete.
        /// /*cef()*/
        /// </summary>

        public bool IsComplete()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsComplete_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 184

        // gen! bool IsCanceled()
        /// <summary>
        /// Returns true if the download has been canceled or interrupted.
        /// /*cef()*/
        /// </summary>

        public bool IsCanceled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsCanceled_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 185

        // gen! int64 GetCurrentSpeed()
        /// <summary>
        /// Returns a simple speed estimate in bytes/s.
        /// /*cef()*/
        /// </summary>

        public long GetCurrentSpeed()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetCurrentSpeed_5, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 186

        // gen! int GetPercentComplete()
        /// <summary>
        /// Returns the rough percent complete or -1 if the receive total size is
        /// unknown.
        /// /*cef()*/
        /// </summary>

        public int GetPercentComplete()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetPercentComplete_6, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 187

        // gen! int64 GetTotalBytes()
        /// <summary>
        /// Returns the total number of bytes.
        /// /*cef()*/
        /// </summary>

        public long GetTotalBytes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetTotalBytes_7, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 188

        // gen! int64 GetReceivedBytes()
        /// <summary>
        /// Returns the number of received bytes.
        /// /*cef()*/
        /// </summary>

        public long GetReceivedBytes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetReceivedBytes_8, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 189

        // gen! CefTime GetStartTime()
        /// <summary>
        /// Returns the time that the download started.
        /// /*cef()*/
        /// </summary>

        public CefTime GetStartTime()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetStartTime_9, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 190

        // gen! CefTime GetEndTime()
        /// <summary>
        /// Returns the time that the download ended.
        /// /*cef()*/
        /// </summary>

        public CefTime GetEndTime()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetEndTime_10, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 191

        // gen! CefString GetFullPath()
        /// <summary>
        /// Returns the full path to the downloaded or downloading file.
        /// /*cef()*/
        /// </summary>

        public string GetFullPath()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetFullPath_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 192

        // gen! uint32 GetId()
        /// <summary>
        /// Returns the unique identifier for this download.
        /// /*cef()*/
        /// </summary>

        public uint GetId()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetId_12, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 193

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetURL_13, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 194

        // gen! CefString GetOriginalUrl()
        /// <summary>
        /// Returns the original URL before any redirections.
        /// /*cef()*/
        /// </summary>

        public string GetOriginalUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetOriginalUrl_14, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 195

        // gen! CefString GetSuggestedFileName()
        /// <summary>
        /// Returns the suggested file name.
        /// /*cef()*/
        /// </summary>

        public string GetSuggestedFileName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetSuggestedFileName_15, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 196

        // gen! CefString GetContentDisposition()
        /// <summary>
        /// Returns the content disposition.
        /// /*cef()*/
        /// </summary>

        public string GetContentDisposition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetContentDisposition_16, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 197

        // gen! CefString GetMimeType()
        /// <summary>
        /// Returns the mime type.
        /// /*cef()*/
        /// </summary>

        public string GetMimeType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetMimeType_17, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
    }


    // [virtual] class CefDragData
    //CsCallToNativeCodeGen::GenerateCsCode , 198
    /// <summary>
    /// Class used to represent drag data. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDragData : IDisposable
    {
        const int _typeNAME = 14;
        const int CefDragData_Release_0 = (_typeNAME << 16) | 0;
        const int CefDragData_Clone_1 = (_typeNAME << 16) | 1;
        const int CefDragData_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefDragData_IsLink_3 = (_typeNAME << 16) | 3;
        const int CefDragData_IsFragment_4 = (_typeNAME << 16) | 4;
        const int CefDragData_IsFile_5 = (_typeNAME << 16) | 5;
        const int CefDragData_GetLinkURL_6 = (_typeNAME << 16) | 6;
        const int CefDragData_GetLinkTitle_7 = (_typeNAME << 16) | 7;
        const int CefDragData_GetLinkMetadata_8 = (_typeNAME << 16) | 8;
        const int CefDragData_GetFragmentText_9 = (_typeNAME << 16) | 9;
        const int CefDragData_GetFragmentHtml_10 = (_typeNAME << 16) | 10;
        const int CefDragData_GetFragmentBaseURL_11 = (_typeNAME << 16) | 11;
        const int CefDragData_GetFileName_12 = (_typeNAME << 16) | 12;
        const int CefDragData_GetFileContents_13 = (_typeNAME << 16) | 13;
        const int CefDragData_GetFileNames_14 = (_typeNAME << 16) | 14;
        const int CefDragData_SetLinkURL_15 = (_typeNAME << 16) | 15;
        const int CefDragData_SetLinkTitle_16 = (_typeNAME << 16) | 16;
        const int CefDragData_SetLinkMetadata_17 = (_typeNAME << 16) | 17;
        const int CefDragData_SetFragmentText_18 = (_typeNAME << 16) | 18;
        const int CefDragData_SetFragmentHtml_19 = (_typeNAME << 16) | 19;
        const int CefDragData_SetFragmentBaseURL_20 = (_typeNAME << 16) | 20;
        const int CefDragData_ResetFileContents_21 = (_typeNAME << 16) | 21;
        const int CefDragData_AddFile_22 = (_typeNAME << 16) | 22;
        const int CefDragData_GetImage_23 = (_typeNAME << 16) | 23;
        const int CefDragData_GetImageHotspot_24 = (_typeNAME << 16) | 24;
        const int CefDragData_HasImage_25 = (_typeNAME << 16) | 25;
        //
        const int CefDragData_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefDragData(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 199

        // gen! CefRefPtr<CefDragData> Clone()
        /// <summary>
        /// CefDragData methods.
        /// </summary>

        public CefDragData Clone()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Clone_1, out ret);
            return new CefDragData(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 200

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if this object is read-only.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsReadOnly_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 201

        // gen! bool IsLink()
        /// <summary>
        /// Returns true if the drag data is a link.
        /// /*cef()*/
        /// </summary>

        public bool IsLink()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsLink_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 202

        // gen! bool IsFragment()
        /// <summary>
        /// Returns true if the drag data is a text or html fragment.
        /// /*cef()*/
        /// </summary>

        public bool IsFragment()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFragment_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 203

        // gen! bool IsFile()
        /// <summary>
        /// Returns true if the drag data is a file.
        /// /*cef()*/
        /// </summary>

        public bool IsFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFile_5, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 204

        // gen! CefString GetLinkURL()
        /// <summary>
        /// Return the link URL that is being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetLinkURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkURL_6, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 205

        // gen! CefString GetLinkTitle()
        /// <summary>
        /// Return the title associated with the link being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetLinkTitle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkTitle_7, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 206

        // gen! CefString GetLinkMetadata()
        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetLinkMetadata()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkMetadata_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 207

        // gen! CefString GetFragmentText()
        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetFragmentText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentText_9, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 208

        // gen! CefString GetFragmentHtml()
        /// <summary>
        /// Return the text/html fragment that is being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetFragmentHtml()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentHtml_10, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 209

        // gen! CefString GetFragmentBaseURL()
        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for
        /// resolving relative URLs and may be empty.
        /// /*cef()*/
        /// </summary>

        public string GetFragmentBaseURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentBaseURL_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 210

        // gen! CefString GetFileName()
        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// /*cef()*/
        /// </summary>

        public string GetFileName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFileName_12, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 211

        // gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
        /// <summary>
        /// Write the contents of the file being dragged out of the web view into
        /// |writer|. Returns the number of bytes sent to |writer|. If |writer| is
        /// NULL this method will return the size of the file contents in bytes.
        /// Call GetFileName() to get a suggested name for the file.
        /// /*cef(optional_param=writer)*/
        /// </summary>

        public uint GetFileContents(CefStreamWriter writer)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = writer.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileContents_13, out ret, ref v1);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 212

        // gen! bool GetFileNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser
        /// window.
        /// /*cef()*/
        /// </summary>

        public bool GetFileNames(List<string> names)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileNames_14, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 213

        // gen! void SetLinkURL(const CefString& url)
        /// <summary>
        /// Set the link URL that is being dragged.
        /// /*cef(optional_param=url)*/
        /// </summary>

        public void SetLinkURL(string url)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkURL_15, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 214

        // gen! void SetLinkTitle(const CefString& title)
        /// <summary>
        /// Set the title associated with the link being dragged.
        /// /*cef(optional_param=title)*/
        /// </summary>

        public void SetLinkTitle(string title)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(title);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkTitle_16, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 215

        // gen! void SetLinkMetadata(const CefString& data)
        /// <summary>
        /// Set the metadata associated with the link being dragged.
        /// /*cef(optional_param=data)*/
        /// </summary>

        public void SetLinkMetadata(string data)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(data);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkMetadata_17, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 216

        // gen! void SetFragmentText(const CefString& text)
        /// <summary>
        /// Set the plain text fragment that is being dragged.
        /// /*cef(optional_param=text)*/
        /// </summary>

        public void SetFragmentText(string text)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(text);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentText_18, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 217

        // gen! void SetFragmentHtml(const CefString& html)
        /// <summary>
        /// Set the text/html fragment that is being dragged.
        /// /*cef(optional_param=html)*/
        /// </summary>

        public void SetFragmentHtml(string html)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(html);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentHtml_19, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 218

        // gen! void SetFragmentBaseURL(const CefString& base_url)
        /// <summary>
        /// Set the base URL that the fragment came from.
        /// /*cef(optional_param=base_url)*/
        /// </summary>

        public void SetFragmentBaseURL(string base_url)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(base_url);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentBaseURL_20, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 219

        // gen! void ResetFileContents()
        /// <summary>
        /// Reset the file contents. You should do this before calling
        /// CefBrowserHost::DragTargetDragEnter as the web view does not allow us to
        /// drag in this kind of data.
        /// /*cef()*/
        /// </summary>

        public void ResetFileContents()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_ResetFileContents_21, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 220

        // gen! void AddFile(const CefString& path,const CefString& display_name)
        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// /*cef(optional_param=display_name)*/
        /// </summary>

        public void AddFile(string path,
        string display_name)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(path);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(display_name);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDragData_AddFile_22, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 221

        // gen! CefRefPtr<CefImage> GetImage()
        /// <summary>
        /// Get the image representation of drag data. May return NULL if no image
        /// representation is available.
        /// /*cef()*/
        /// </summary>

        public CefImage GetImage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImage_23, out ret);
            return new CefImage(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 222

        // gen! CefPoint GetImageHotspot()
        /// <summary>
        /// Get the image hotspot (drag start location relative to image dimensions).
        /// /*cef()*/
        /// </summary>

        public CefPoint GetImageHotspot()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImageHotspot_24, out ret);
            return new CefPoint(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 223

        // gen! bool HasImage()
        /// <summary>
        /// Returns true if an image representation of drag data is available.
        /// /*cef()*/
        /// </summary>

        public bool HasImage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_HasImage_25, out ret);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 224

        // gen! CefRefPtr<CefDragData> Create()
        /// <summary>
        /// Create a new CefDragData object.
        /// /*cef()*/
        /// </summary>

        public static CefDragData Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefDragData_S_Create_1, out ret);
            return new CefDragData(ret.Ptr);
        }
    }


    // [virtual] class CefFrame
    //CsCallToNativeCodeGen::GenerateCsCode , 225
    /// <summary>
    /// Class used to represent a frame in the browser window. When used in the
    /// browser process the methods of this class may be called on any thread unless
    /// otherwise indicated in the comments. When used in the render process the
    /// methods of this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefFrame : IDisposable
    {
        const int _typeNAME = 15;
        const int CefFrame_Release_0 = (_typeNAME << 16) | 0;
        const int CefFrame_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefFrame_Undo_2 = (_typeNAME << 16) | 2;
        const int CefFrame_Redo_3 = (_typeNAME << 16) | 3;
        const int CefFrame_Cut_4 = (_typeNAME << 16) | 4;
        const int CefFrame_Copy_5 = (_typeNAME << 16) | 5;
        const int CefFrame_Paste_6 = (_typeNAME << 16) | 6;
        const int CefFrame_Delete_7 = (_typeNAME << 16) | 7;
        const int CefFrame_SelectAll_8 = (_typeNAME << 16) | 8;
        const int CefFrame_ViewSource_9 = (_typeNAME << 16) | 9;
        const int CefFrame_GetSource_10 = (_typeNAME << 16) | 10;
        const int CefFrame_GetText_11 = (_typeNAME << 16) | 11;
        const int CefFrame_LoadRequest_12 = (_typeNAME << 16) | 12;
        const int CefFrame_LoadURL_13 = (_typeNAME << 16) | 13;
        const int CefFrame_LoadString_14 = (_typeNAME << 16) | 14;
        const int CefFrame_ExecuteJavaScript_15 = (_typeNAME << 16) | 15;
        const int CefFrame_IsMain_16 = (_typeNAME << 16) | 16;
        const int CefFrame_IsFocused_17 = (_typeNAME << 16) | 17;
        const int CefFrame_GetName_18 = (_typeNAME << 16) | 18;
        const int CefFrame_GetIdentifier_19 = (_typeNAME << 16) | 19;
        const int CefFrame_GetParent_20 = (_typeNAME << 16) | 20;
        const int CefFrame_GetURL_21 = (_typeNAME << 16) | 21;
        const int CefFrame_GetBrowser_22 = (_typeNAME << 16) | 22;
        const int CefFrame_GetV8Context_23 = (_typeNAME << 16) | 23;
        const int CefFrame_VisitDOM_24 = (_typeNAME << 16) | 24;
        internal IntPtr nativePtr;
        internal CefFrame(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 226

        // gen! bool IsValid()
        /// <summary>
        /// CefFrame methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 227

        // gen! void Undo()
        /// <summary>
        /// Execute undo in this frame.
        /// /*cef()*/
        /// </summary>

        public void Undo()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Undo_2, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 228

        // gen! void Redo()
        /// <summary>
        /// Execute redo in this frame.
        /// /*cef()*/
        /// </summary>

        public void Redo()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Redo_3, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 229

        // gen! void Cut()
        /// <summary>
        /// Execute cut in this frame.
        /// /*cef()*/
        /// </summary>

        public void Cut()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Cut_4, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 230

        // gen! void Copy()
        /// <summary>
        /// Execute copy in this frame.
        /// /*cef()*/
        /// </summary>

        public void Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Copy_5, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 231

        // gen! void Paste()
        /// <summary>
        /// Execute paste in this frame.
        /// /*cef()*/
        /// </summary>

        public void Paste()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Paste_6, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 232

        // gen! void Delete()
        /// <summary>
        /// Execute delete in this frame.
        /// /*cef(capi_name=del)*/
        /// </summary>

        public void Delete()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Delete_7, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 233

        // gen! void SelectAll()
        /// <summary>
        /// Execute select all in this frame.
        /// /*cef()*/
        /// </summary>

        public void SelectAll()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_SelectAll_8, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 234

        // gen! void ViewSource()
        /// <summary>
        /// Save this frame's HTML source to a temporary file and open it in the
        /// default text viewing application. This method can only be called from the
        /// browser process.
        /// /*cef()*/
        /// </summary>

        public void ViewSource()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_ViewSource_9, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 235

        // gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's HTML source as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>

        public void GetSource(CefStringVisitor visitor)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetSource_10, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 236

        // gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's display text as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>

        public void GetText(CefStringVisitor visitor)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetText_11, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 237

        // gen! void LoadRequest(CefRefPtr<CefRequest> request)
        /// <summary>
        /// Load the request represented by the |request| object.
        /// /*cef()*/
        /// </summary>

        public void LoadRequest(CefRequest request)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = request.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadRequest_12, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 238

        // gen! void LoadURL(const CefString& url)
        /// <summary>
        /// Load the specified |url|.
        /// /*cef()*/
        /// </summary>

        public void LoadURL(string url)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadURL_13, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 239

        // gen! void LoadString(const CefString& string_val,const CefString& url)
        /// <summary>
        /// Load the contents of |string_val| with the specified dummy |url|. |url|
        /// should have a standard scheme (for example, http scheme) or behaviors like
        /// link clicks and web security restrictions may not behave as expected.
        /// /*cef()*/
        /// </summary>

        public void LoadString(string string_val,
        string url)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(string_val);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(url);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefFrame_LoadString_14, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 240

        // gen! void ExecuteJavaScript(const CefString& code,const CefString& script_url,int start_line)
        /// <summary>
        /// Execute a string of JavaScript code in this frame. The |script_url|
        /// parameter is the URL where the script in question can be found, if any.
        /// The renderer may request this URL to show the developer the source of the
        /// error.  The |start_line| parameter is the base line number to use for error
        /// reporting.
        /// /*cef(optional_param=script_url)*/
        /// </summary>

        public void ExecuteJavaScript(string code,
        string script_url,
        int start_line)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(code);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(script_url);
            v3.I32 = (int)start_line;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefFrame_ExecuteJavaScript_15, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 241

        // gen! bool IsMain()
        /// <summary>
        /// Returns true if this is the main (top-level) frame.
        /// /*cef()*/
        /// </summary>

        public bool IsMain()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsMain_16, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 242

        // gen! bool IsFocused()
        /// <summary>
        /// Returns true if this is the focused frame.
        /// /*cef()*/
        /// </summary>

        public bool IsFocused()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsFocused_17, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 243

        // gen! CefString GetName()
        /// <summary>
        /// Returns the name for this frame. If the frame has an assigned name (for
        /// example, set via the iframe "name" attribute) then that value will be
        /// returned. Otherwise a unique name will be constructed based on the frame
        /// parent hierarchy. The main (top-level) frame will always have an empty name
        /// value.
        /// /*cef()*/
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetName_18, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 244

        // gen! int64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this frame or < 0 if the
        /// underlying frame does not yet exist.
        /// /*cef()*/
        /// </summary>

        public long GetIdentifier()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetIdentifier_19, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 245

        // gen! CefRefPtr<CefFrame> GetParent()
        /// <summary>
        /// Returns the parent of this frame or NULL if this is the main (top-level)
        /// frame.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetParent()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetParent_20, out ret);
            return new CefFrame(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 246

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL currently loaded in this frame.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetURL_21, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 247

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser that this frame belongs to.
        /// /*cef()*/
        /// </summary>

        public CefBrowser GetBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetBrowser_22, out ret);
            return new CefBrowser(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 248

        // gen! CefRefPtr<CefV8Context> GetV8Context()
        /// <summary>
        /// Get the V8 context associated with the frame. This method can only be
        /// called from the render process.
        /// /*cef()*/
        /// </summary>

        public CefV8Context GetV8Context()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetV8Context_23, out ret);
            return new CefV8Context(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 249

        // gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
        /// <summary>
        /// Visit the DOM document. This method can only be called from the render
        /// process.
        /// /*cef()*/
        /// </summary>

        public void VisitDOM(CefDOMVisitor visitor)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_VisitDOM_24, out ret, ref v1);

        }
    }


    // [virtual] class CefImage
    //CsCallToNativeCodeGen::GenerateCsCode , 250
    /// <summary>
    /// Container for a single image represented at different scale factors. All
    /// image representations should be the same size in density independent pixel
    /// (DIP) units. For example, if the image at scale factor 1.0 is 100x100 pixels
    /// then the image at scale factor 2.0 should be 200x200 pixels -- both images
    /// will display with a DIP size of 100x100 units. The methods of this class must
    /// be called on the browser process UI thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefImage : IDisposable
    {
        const int _typeNAME = 16;
        const int CefImage_Release_0 = (_typeNAME << 16) | 0;
        const int CefImage_IsEmpty_1 = (_typeNAME << 16) | 1;
        const int CefImage_IsSame_2 = (_typeNAME << 16) | 2;
        const int CefImage_AddBitmap_3 = (_typeNAME << 16) | 3;
        const int CefImage_AddPNG_4 = (_typeNAME << 16) | 4;
        const int CefImage_AddJPEG_5 = (_typeNAME << 16) | 5;
        const int CefImage_GetWidth_6 = (_typeNAME << 16) | 6;
        const int CefImage_GetHeight_7 = (_typeNAME << 16) | 7;
        const int CefImage_HasRepresentation_8 = (_typeNAME << 16) | 8;
        const int CefImage_RemoveRepresentation_9 = (_typeNAME << 16) | 9;
        const int CefImage_GetRepresentationInfo_10 = (_typeNAME << 16) | 10;
        const int CefImage_GetAsBitmap_11 = (_typeNAME << 16) | 11;
        const int CefImage_GetAsPNG_12 = (_typeNAME << 16) | 12;
        const int CefImage_GetAsJPEG_13 = (_typeNAME << 16) | 13;
        //
        const int CefImage_S_CreateImage_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefImage(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 251

        // gen! bool IsEmpty()
        /// <summary>
        /// CefImage methods.
        /// </summary>

        public bool IsEmpty()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_IsEmpty_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 252

        // gen! bool IsSame(CefRefPtr<CefImage> that)
        /// <summary>
        /// Returns true if this Image and |that| Image share the same underlying
        /// storage. Will also return true if both images are empty.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefImage that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_IsSame_2, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 253

        // gen! bool AddBitmap(float scale_factor,int pixel_width,int pixel_height,cef_color_type_t color_type,cef_alpha_type_t alpha_type,const void* pixel_data,size_t pixel_data_size)
        /// <summary>
        /// Add a bitmap image representation for |scale_factor|. Only 32-bit RGBA/BGRA
        /// formats are supported. |pixel_width| and |pixel_height| are the bitmap
        /// representation size in pixel coordinates. |pixel_data| is the array of
        /// pixel data and should be |pixel_width| x |pixel_height| x 4 bytes in size.
        /// |color_type| and |alpha_type| values specify the pixel format.
        /// /*cef()*/
        /// </summary>

        public bool AddBitmap(float scale_factor,
        int pixel_width,
        int pixel_height,
        cef_color_type_t color_type,
        cef_alpha_type_t alpha_type,
        IntPtr pixel_data,
        uint pixel_data_size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue v7 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = (int)pixel_width;
            v3.I32 = (int)pixel_height;
            v4.I32 = (int)color_type;
            v5.I32 = (int)alpha_type;
            v6.Ptr = pixel_data;
            v7.I32 = (int)pixel_data_size;

            Cef3Binder.MyCefMet_Call7(this.nativePtr, CefImage_AddBitmap_3, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6, ref v7);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 254

        // gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
        /// <summary>
        /// Add a PNG image representation for |scale_factor|. |png_data| is the image
        /// data of size |png_data_size|. Any alpha transparency in the PNG data will
        /// be maintained.
        /// /*cef()*/
        /// </summary>

        public bool AddPNG(float scale_factor,
        IntPtr png_data,
        uint png_data_size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.Ptr = png_data;
            v3.I32 = (int)png_data_size;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddPNG_4, out ret, ref v1, ref v2, ref v3);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 255

        // gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
        /// <summary>
        /// Create a JPEG image representation for |scale_factor|. |jpeg_data| is the
        /// image data of size |jpeg_data_size|. The JPEG format does not support
        /// transparency so the alpha byte will be set to 0xFF for all pixels.
        /// /*cef()*/
        /// </summary>

        public bool AddJPEG(float scale_factor,
        IntPtr jpeg_data,
        uint jpeg_data_size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.Ptr = jpeg_data;
            v3.I32 = (int)jpeg_data_size;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddJPEG_5, out ret, ref v1, ref v2, ref v3);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 256

        // gen! size_t GetWidth()
        /// <summary>
        /// Returns the image width in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>

        public uint GetWidth()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetWidth_6, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 257

        // gen! size_t GetHeight()
        /// <summary>
        /// Returns the image height in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>

        public uint GetHeight()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetHeight_7, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 258

        // gen! bool HasRepresentation(float scale_factor)
        /// <summary>
        /// Returns true if this image contains a representation for |scale_factor|.
        /// /*cef()*/
        /// </summary>

        public bool HasRepresentation(float scale_factor)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_HasRepresentation_8, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 259

        // gen! bool RemoveRepresentation(float scale_factor)
        /// <summary>
        /// Removes the representation for |scale_factor|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveRepresentation(float scale_factor)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_RemoveRepresentation_9, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 260

        // gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns information for the representation that most closely matches
        /// |scale_factor|. |actual_scale_factor| is the actual scale factor for the
        /// representation. |pixel_width| and |pixel_height| are the representation
        /// size in pixel coordinates. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetRepresentationInfo(float scale_factor,
        ref float actual_scale_factor,
        ref int pixel_width,
        ref int pixel_height)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.Num = actual_scale_factor;
            v3.I32 = pixel_width;
            v4.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetRepresentationInfo_10, out ret, ref v1, ref v2, ref v3, ref v4);
            actual_scale_factor = (float)v2.Num;
            pixel_width = (int)v3.I32;
            pixel_height = (int)v4.I32;
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 261

        // gen! CefRefPtr<CefBinaryValue> GetAsBitmap(float scale_factor,cef_color_type_t color_type,cef_alpha_type_t alpha_type,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns the bitmap representation that most closely matches |scale_factor|.
        /// Only 32-bit RGBA/BGRA formats are supported. |color_type| and |alpha_type|
        /// values specify the desired output pixel format. |pixel_width| and
        /// |pixel_height| are the output representation size in pixel coordinates.
        /// Returns a CefBinaryValue containing the pixel data on success or NULL on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetAsBitmap(float scale_factor,
        cef_color_type_t color_type,
        cef_alpha_type_t alpha_type,
        ref int pixel_width,
        ref int pixel_height)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = (int)color_type;
            v3.I32 = (int)alpha_type;
            v4.I32 = pixel_width;
            v5.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefImage_GetAsBitmap_11, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            pixel_width = (int)v4.I32;
            pixel_height = (int)v5.I32;
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 262

        // gen! CefRefPtr<CefBinaryValue> GetAsPNG(float scale_factor,bool with_transparency,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns the PNG representation that most closely matches |scale_factor|. If
        /// |with_transparency| is true any alpha transparency in the image will be
        /// represented in the resulting PNG data. |pixel_width| and |pixel_height| are
        /// the output representation size in pixel coordinates. Returns a
        /// CefBinaryValue containing the PNG image data on success or NULL on failure.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetAsPNG(float scale_factor,
        bool with_transparency,
        ref int pixel_width,
        ref int pixel_height)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = with_transparency ? 1 : 0;
            v3.I32 = pixel_width;
            v4.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsPNG_12, out ret, ref v1, ref v2, ref v3, ref v4);
            pixel_width = (int)v3.I32;
            pixel_height = (int)v4.I32;
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 263

        // gen! CefRefPtr<CefBinaryValue> GetAsJPEG(float scale_factor,int quality,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns the JPEG representation that most closely matches |scale_factor|.
        /// |quality| determines the compression level with 0 == lowest and 100 ==
        /// highest. The JPEG format does not support alpha transparency and the alpha
        /// channel, if any, will be discarded. |pixel_width| and |pixel_height| are
        /// the output representation size in pixel coordinates. Returns a
        /// CefBinaryValue containing the JPEG image data on success or NULL on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetAsJPEG(float scale_factor,
        int quality,
        ref int pixel_width,
        ref int pixel_height)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = (int)quality;
            v3.I32 = pixel_width;
            v4.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsJPEG_13, out ret, ref v1, ref v2, ref v3, ref v4);
            pixel_width = (int)v3.I32;
            pixel_height = (int)v4.I32;
            return new CefBinaryValue(ret.Ptr);
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 264

        // gen! CefRefPtr<CefImage> CreateImage()
        /// <summary>
        /// Create a new CefImage. It will initially be empty. Use the Add*() methods
        /// to add representations at different scale factors.
        /// /*cef()*/
        /// </summary>

        public static CefImage CreateImage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefImage_S_CreateImage_1, out ret);
            return new CefImage(ret.Ptr);
        }
    }


    // [virtual] class CefMenuModel
    //CsCallToNativeCodeGen::GenerateCsCode , 265
    /// <summary>
    /// Supports creation and modification of menus. See cef_menu_id_t for the
    /// command ids that have default implementations. All user-defined command ids
    /// should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST. The methods of
    /// this class can only be accessed on the browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefMenuModel : IDisposable
    {
        const int _typeNAME = 17;
        const int CefMenuModel_Release_0 = (_typeNAME << 16) | 0;
        const int CefMenuModel_IsSubMenu_1 = (_typeNAME << 16) | 1;
        const int CefMenuModel_Clear_2 = (_typeNAME << 16) | 2;
        const int CefMenuModel_GetCount_3 = (_typeNAME << 16) | 3;
        const int CefMenuModel_AddSeparator_4 = (_typeNAME << 16) | 4;
        const int CefMenuModel_AddItem_5 = (_typeNAME << 16) | 5;
        const int CefMenuModel_AddCheckItem_6 = (_typeNAME << 16) | 6;
        const int CefMenuModel_AddRadioItem_7 = (_typeNAME << 16) | 7;
        const int CefMenuModel_AddSubMenu_8 = (_typeNAME << 16) | 8;
        const int CefMenuModel_InsertSeparatorAt_9 = (_typeNAME << 16) | 9;
        const int CefMenuModel_InsertItemAt_10 = (_typeNAME << 16) | 10;
        const int CefMenuModel_InsertCheckItemAt_11 = (_typeNAME << 16) | 11;
        const int CefMenuModel_InsertRadioItemAt_12 = (_typeNAME << 16) | 12;
        const int CefMenuModel_InsertSubMenuAt_13 = (_typeNAME << 16) | 13;
        const int CefMenuModel_Remove_14 = (_typeNAME << 16) | 14;
        const int CefMenuModel_RemoveAt_15 = (_typeNAME << 16) | 15;
        const int CefMenuModel_GetIndexOf_16 = (_typeNAME << 16) | 16;
        const int CefMenuModel_GetCommandIdAt_17 = (_typeNAME << 16) | 17;
        const int CefMenuModel_SetCommandIdAt_18 = (_typeNAME << 16) | 18;
        const int CefMenuModel_GetLabel_19 = (_typeNAME << 16) | 19;
        const int CefMenuModel_GetLabelAt_20 = (_typeNAME << 16) | 20;
        const int CefMenuModel_SetLabel_21 = (_typeNAME << 16) | 21;
        const int CefMenuModel_SetLabelAt_22 = (_typeNAME << 16) | 22;
        const int CefMenuModel_GetType_23 = (_typeNAME << 16) | 23;
        const int CefMenuModel_GetTypeAt_24 = (_typeNAME << 16) | 24;
        const int CefMenuModel_GetGroupId_25 = (_typeNAME << 16) | 25;
        const int CefMenuModel_GetGroupIdAt_26 = (_typeNAME << 16) | 26;
        const int CefMenuModel_SetGroupId_27 = (_typeNAME << 16) | 27;
        const int CefMenuModel_SetGroupIdAt_28 = (_typeNAME << 16) | 28;
        const int CefMenuModel_GetSubMenu_29 = (_typeNAME << 16) | 29;
        const int CefMenuModel_GetSubMenuAt_30 = (_typeNAME << 16) | 30;
        const int CefMenuModel_IsVisible_31 = (_typeNAME << 16) | 31;
        const int CefMenuModel_IsVisibleAt_32 = (_typeNAME << 16) | 32;
        const int CefMenuModel_SetVisible_33 = (_typeNAME << 16) | 33;
        const int CefMenuModel_SetVisibleAt_34 = (_typeNAME << 16) | 34;
        const int CefMenuModel_IsEnabled_35 = (_typeNAME << 16) | 35;
        const int CefMenuModel_IsEnabledAt_36 = (_typeNAME << 16) | 36;
        const int CefMenuModel_SetEnabled_37 = (_typeNAME << 16) | 37;
        const int CefMenuModel_SetEnabledAt_38 = (_typeNAME << 16) | 38;
        const int CefMenuModel_IsChecked_39 = (_typeNAME << 16) | 39;
        const int CefMenuModel_IsCheckedAt_40 = (_typeNAME << 16) | 40;
        const int CefMenuModel_SetChecked_41 = (_typeNAME << 16) | 41;
        const int CefMenuModel_SetCheckedAt_42 = (_typeNAME << 16) | 42;
        const int CefMenuModel_HasAccelerator_43 = (_typeNAME << 16) | 43;
        const int CefMenuModel_HasAcceleratorAt_44 = (_typeNAME << 16) | 44;
        const int CefMenuModel_SetAccelerator_45 = (_typeNAME << 16) | 45;
        const int CefMenuModel_SetAcceleratorAt_46 = (_typeNAME << 16) | 46;
        const int CefMenuModel_RemoveAccelerator_47 = (_typeNAME << 16) | 47;
        const int CefMenuModel_RemoveAcceleratorAt_48 = (_typeNAME << 16) | 48;
        const int CefMenuModel_GetAccelerator_49 = (_typeNAME << 16) | 49;
        const int CefMenuModel_GetAcceleratorAt_50 = (_typeNAME << 16) | 50;
        const int CefMenuModel_SetColor_51 = (_typeNAME << 16) | 51;
        const int CefMenuModel_SetColorAt_52 = (_typeNAME << 16) | 52;
        const int CefMenuModel_GetColor_53 = (_typeNAME << 16) | 53;
        const int CefMenuModel_GetColorAt_54 = (_typeNAME << 16) | 54;
        const int CefMenuModel_SetFontList_55 = (_typeNAME << 16) | 55;
        const int CefMenuModel_SetFontListAt_56 = (_typeNAME << 16) | 56;
        //
        const int CefMenuModel_S_CreateMenuModel_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefMenuModel(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 266

        // gen! bool IsSubMenu()
        /// <summary>
        /// CefMenuModel methods.
        /// </summary>

        public bool IsSubMenu()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_IsSubMenu_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 267

        // gen! bool Clear()
        /// <summary>
        /// Clears the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Clear()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Clear_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 268

        // gen! int GetCount()
        /// <summary>
        /// Returns the number of items in this menu.
        /// /*cef()*/
        /// </summary>

        public int GetCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_GetCount_3, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 269

        // gen! bool AddSeparator()
        /// <summary>
        /// Add a separator to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddSeparator()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_AddSeparator_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 270

        // gen! bool AddItem(int command_id,const CefString& label)
        /// <summary>
        /// Add an item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddItem(int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddItem_5, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 271

        // gen! bool AddCheckItem(int command_id,const CefString& label)
        /// <summary>
        /// Add a check item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddCheckItem(int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddCheckItem_6, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 272

        // gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Add a radio item to the menu. Only a single item with the specified
        /// |group_id| can be checked at a time. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddRadioItem(int command_id,
        string label,
        int group_id)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)command_id;
            v3.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_AddRadioItem_7, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 273

        // gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
        /// <summary>
        /// Add a sub-menu to the menu. The new sub-menu is returned.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel AddSubMenu(int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddSubMenu_8, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return new CefMenuModel(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 274

        // gen! bool InsertSeparatorAt(int index)
        /// <summary>
        /// Insert a separator in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool InsertSeparatorAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_InsertSeparatorAt_9, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 275

        // gen! bool InsertItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert an item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool InsertItemAt(int index,
        int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertItemAt_10, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 276

        // gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a check item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool InsertCheckItemAt(int index,
        int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertCheckItemAt_11, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 277

        // gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Insert a radio item in the menu at the specified |index|. Only a single
        /// item with the specified |group_id| can be checked at a time. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>

        public bool InsertRadioItemAt(int index,
        int command_id,
        string label,
        int group_id)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;
            v4.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefMenuModel_InsertRadioItemAt_12, out ret, ref v1, ref v2, ref v3, ref v4);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 278

        // gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a sub-menu in the menu at the specified |index|. The new sub-menu
        /// is returned.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel InsertSubMenuAt(int index,
        int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertSubMenuAt_13, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return new CefMenuModel(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 279

        // gen! bool Remove(int command_id)
        /// <summary>
        /// Removes the item with the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Remove(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_Remove_14, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 280

        // gen! bool RemoveAt(int index)
        /// <summary>
        /// Removes the item at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAt_15, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 281

        // gen! int GetIndexOf(int command_id)
        /// <summary>
        /// Returns the index associated with the specified |command_id| or -1 if not
        /// found due to the command id not existing in the menu.
        /// /*cef()*/
        /// </summary>

        public int GetIndexOf(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetIndexOf_16, out ret, ref v1);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 282

        // gen! int GetCommandIdAt(int index)
        /// <summary>
        /// Returns the command id at the specified |index| or -1 if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>

        public int GetCommandIdAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetCommandIdAt_17, out ret, ref v1);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 283

        // gen! bool SetCommandIdAt(int index,int command_id)
        /// <summary>
        /// Sets the command id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetCommandIdAt(int index,
        int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCommandIdAt_18, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 284

        // gen! CefString GetLabel(int command_id)
        /// <summary>
        /// Returns the label for the specified |command_id| or empty if not found.
        /// /*cef()*/
        /// </summary>

        public string GetLabel(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabel_19, out ret, ref v1);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 285

        // gen! CefString GetLabelAt(int index)
        /// <summary>
        /// Returns the label at the specified |index| or empty if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>

        public string GetLabelAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabelAt_20, out ret, ref v1);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 286

        // gen! bool SetLabel(int command_id,const CefString& label)
        /// <summary>
        /// Sets the label for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetLabel(int command_id,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabel_21, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 287

        // gen! bool SetLabelAt(int index,const CefString& label)
        /// <summary>
        /// Set the label at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetLabelAt(int index,
        string label)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(label);
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabelAt_22, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 288

        // gen! MenuItemType GetType(int command_id)
        /// <summary>
        /// Returns the item type for the specified |command_id|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>

        public cef_menu_item_type_t _GetType(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetType_23, out ret, ref v1);
            return (cef_menu_item_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 289

        // gen! MenuItemType GetTypeAt(int index)
        /// <summary>
        /// Returns the item type at the specified |index|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>

        public cef_menu_item_type_t GetTypeAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetTypeAt_24, out ret, ref v1);
            return (cef_menu_item_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 290

        // gen! int GetGroupId(int command_id)
        /// <summary>
        /// Returns the group id for the specified |command_id| or -1 if invalid.
        /// /*cef()*/
        /// </summary>

        public int GetGroupId(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupId_25, out ret, ref v1);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 291

        // gen! int GetGroupIdAt(int index)
        /// <summary>
        /// Returns the group id at the specified |index| or -1 if invalid.
        /// /*cef()*/
        /// </summary>

        public int GetGroupIdAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupIdAt_26, out ret, ref v1);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 292

        // gen! bool SetGroupId(int command_id,int group_id)
        /// <summary>
        /// Sets the group id for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetGroupId(int command_id,
        int group_id)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupId_27, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 293

        // gen! bool SetGroupIdAt(int index,int group_id)
        /// <summary>
        /// Sets the group id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetGroupIdAt(int index,
        int group_id)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupIdAt_28, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 294

        // gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
        /// <summary>
        /// Returns the submenu for the specified |command_id| or empty if invalid.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel GetSubMenu(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenu_29, out ret, ref v1);
            return new CefMenuModel(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 295

        // gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
        /// <summary>
        /// Returns the submenu at the specified |index| or empty if invalid.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel GetSubMenuAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenuAt_30, out ret, ref v1);
            return new CefMenuModel(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 296

        // gen! bool IsVisible(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is visible.
        /// /*cef()*/
        /// </summary>

        public bool IsVisible(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisible_31, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 297

        // gen! bool IsVisibleAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is visible.
        /// /*cef()*/
        /// </summary>

        public bool IsVisibleAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisibleAt_32, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 298

        // gen! bool SetVisible(int command_id,bool visible)
        /// <summary>
        /// Change the visibility of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetVisible(int command_id,
        bool visible)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = visible ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisible_33, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 299

        // gen! bool SetVisibleAt(int index,bool visible)
        /// <summary>
        /// Change the visibility at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetVisibleAt(int index,
        bool visible)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = visible ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisibleAt_34, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 300

        // gen! bool IsEnabled(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is enabled.
        /// /*cef()*/
        /// </summary>

        public bool IsEnabled(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabled_35, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 301

        // gen! bool IsEnabledAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is enabled.
        /// /*cef()*/
        /// </summary>

        public bool IsEnabledAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabledAt_36, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 302

        // gen! bool SetEnabled(int command_id,bool enabled)
        /// <summary>
        /// Change the enabled status of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetEnabled(int command_id,
        bool enabled)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = enabled ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabled_37, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 303

        // gen! bool SetEnabledAt(int index,bool enabled)
        /// <summary>
        /// Change the enabled status at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetEnabledAt(int index,
        bool enabled)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = enabled ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabledAt_38, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 304

        // gen! bool IsChecked(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is checked. Only applies to
        /// check and radio items.
        /// /*cef()*/
        /// </summary>

        public bool IsChecked(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsChecked_39, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 305

        // gen! bool IsCheckedAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is checked. Only applies to check
        /// and radio items.
        /// /*cef()*/
        /// </summary>

        public bool IsCheckedAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsCheckedAt_40, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 306

        // gen! bool SetChecked(int command_id,bool checked)
        /// <summary>
        /// Check the specified |command_id|. Only applies to check and radio items.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetChecked(int command_id,
        bool _checked)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = _checked ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetChecked_41, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 307

        // gen! bool SetCheckedAt(int index,bool checked)
        /// <summary>
        /// Check the specified |index|. Only applies to check and radio items. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetCheckedAt(int index,
        bool _checked)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = _checked ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCheckedAt_42, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 308

        // gen! bool HasAccelerator(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| has a keyboard accelerator
        /// assigned.
        /// /*cef()*/
        /// </summary>

        public bool HasAccelerator(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAccelerator_43, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 309

        // gen! bool HasAcceleratorAt(int index)
        /// <summary>
        /// Returns true if the specified |index| has a keyboard accelerator assigned.
        /// /*cef()*/
        /// </summary>

        public bool HasAcceleratorAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAcceleratorAt_44, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 310

        // gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator for the specified |command_id|. |key_code| can
        /// be any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetAccelerator(int command_id,
        int key_code,
        bool shift_pressed,
        bool ctrl_pressed,
        bool alt_pressed)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)key_code;
            v3.I32 = shift_pressed ? 1 : 0;
            v4.I32 = ctrl_pressed ? 1 : 0;
            v5.I32 = alt_pressed ? 1 : 0;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAccelerator_45, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 311

        // gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator at the specified |index|. |key_code| can be
        /// any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetAcceleratorAt(int index,
        int key_code,
        bool shift_pressed,
        bool ctrl_pressed,
        bool alt_pressed)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)key_code;
            v3.I32 = shift_pressed ? 1 : 0;
            v4.I32 = ctrl_pressed ? 1 : 0;
            v5.I32 = alt_pressed ? 1 : 0;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAcceleratorAt_46, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 312

        // gen! bool RemoveAccelerator(int command_id)
        /// <summary>
        /// Remove the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveAccelerator(int command_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAccelerator_47, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 313

        // gen! bool RemoveAcceleratorAt(int index)
        /// <summary>
        /// Remove the keyboard accelerator at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveAcceleratorAt(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAcceleratorAt_48, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 314

        // gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetAccelerator(int command_id,
        ref int key_code,
        ref bool shift_pressed,
        ref bool ctrl_pressed,
        ref bool alt_pressed)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = key_code;
            v3.I32 = (shift_pressed ? 1 : 0);
            v4.I32 = (ctrl_pressed ? 1 : 0);
            v5.I32 = (alt_pressed ? 1 : 0);

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAccelerator_49, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            key_code = (int)v2.I32;
            shift_pressed = v3.I32 != 0;
            ctrl_pressed = v4.I32 != 0;
            alt_pressed = v5.I32 != 0;
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 315

        // gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |index|. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>

        public bool GetAcceleratorAt(int index,
        ref int key_code,
        ref bool shift_pressed,
        ref bool ctrl_pressed,
        ref bool alt_pressed)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = key_code;
            v3.I32 = (shift_pressed ? 1 : 0);
            v4.I32 = (ctrl_pressed ? 1 : 0);
            v5.I32 = (alt_pressed ? 1 : 0);

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAcceleratorAt_50, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            key_code = (int)v2.I32;
            shift_pressed = v3.I32 != 0;
            ctrl_pressed = v4.I32 != 0;
            alt_pressed = v5.I32 != 0;
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 316

        // gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
        /// <summary>
        /// Set the explicit color for |command_id| and |color_type| to |color|.
        /// Specify a |color| value of 0 to remove the explicit color. If no explicit
        /// color or default color is set for |color_type| then the system color will
        /// be used. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetColor(int command_id,
        cef_menu_color_type_t color_type,
        IntPtr color)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)color_type;
            v3.I32 = (int)color;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColor_51, out ret, ref v1, ref v2, ref v3);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 317

        // gen! bool SetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t color)
        /// <summary>
        /// Set the explicit color for |command_id| and |index| to |color|. Specify a
        /// |color| value of 0 to remove the explicit color. Specify an |index| value
        /// of -1 to set the default color for items that do not have an explicit
        /// color set. If no explicit color or default color is set for |color_type|
        /// then the system color will be used. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetColorAt(int index,
        cef_menu_color_type_t color_type,
        IntPtr color)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)color_type;
            v3.I32 = (int)color;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColorAt_52, out ret, ref v1, ref v2, ref v3);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 318

        // gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetColor(int command_id,
        cef_menu_color_type_t color_type,
        cef_color_t color)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)color_type;
            v3.Ptr = color.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColor_53, out ret, ref v1, ref v2, ref v3);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 319

        // gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. Specify an |index| value of -1 to return the default color
        /// in |color|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetColorAt(int index,
        cef_menu_color_type_t color_type,
        cef_color_t color)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)color_type;
            v3.Ptr = color.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColorAt_54, out ret, ref v1, ref v2, ref v3);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 320

        // gen! bool SetFontList(int command_id,const CefString& font_list)
        /// <summary>
        /// Sets the font list for the specified |command_id|. If |font_list| is empty
        /// the system font will be used. Returns true on success. The format is
        /// "<FONT_FAMILY_LIST>,[STYLES] <SIZE>", where:
        /// - FONT_FAMILY_LIST is a comma-separated list of font family names,
        /// - STYLES is an optional space-separated list of style names (case-sensitive
        ///   "Bold" and "Italic" are supported), and
        /// - SIZE is an integer font size in pixels with the suffix "px".
        ///
        /// Here are examples of valid font description strings:
        /// - "Arial, Helvetica, Bold Italic 14px"
        /// - "Arial, 14px"
        /// /*cef(optional_param=font_list)*/
        /// </summary>

        public bool SetFontList(int command_id,
        string font_list)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(font_list);
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontList_55, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 321

        // gen! bool SetFontListAt(int index,const CefString& font_list)
        /// <summary>
        /// Sets the font list for the specified |index|. Specify an |index| value of
        /// -1 to set the default font. If |font_list| is empty the system font will
        /// be used. Returns true on success. The format is
        /// "<FONT_FAMILY_LIST>,[STYLES] <SIZE>", where:
        /// - FONT_FAMILY_LIST is a comma-separated list of font family names,
        /// - STYLES is an optional space-separated list of style names (case-sensitive
        ///   "Bold" and "Italic" are supported), and
        /// - SIZE is an integer font size in pixels with the suffix "px".
        ///
        /// Here are examples of valid font description strings:
        /// - "Arial, Helvetica, Bold Italic 14px"
        /// - "Arial, 14px"
        /// /*cef(optional_param=font_list)*/
        /// </summary>

        public bool SetFontListAt(int index,
        string font_list)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(font_list);
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontListAt_56, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 322

        // gen! CefRefPtr<CefMenuModel> CreateMenuModel(CefRefPtr<CefMenuModelDelegate> delegate)
        /// <summary>
        /// Create a new MenuModel with the specified |delegate|.
        /// /*cef()*/
        /// </summary>

        public static CefMenuModel CreateMenuModel(CefMenuModelDelegate _delegate)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _delegate.nativePtr;

            Cef3Binder.MyCefMet_S_Call1(CefMenuModel_S_CreateMenuModel_1, out ret, ref v1);
            return new CefMenuModel(ret.Ptr);
        }
    }


    // [virtual] class CefMenuModelDelegate
    //CsCallToNativeCodeGen::GenerateCsCode , 323
    /// <summary>
    /// Implement this interface to handle menu model events. The methods of this
    /// class will be called on the browser process UI thread unless otherwise
    /// indicated.
    /// /*(source=client)*/
    /// </summary>
    public struct CefMenuModelDelegate : IDisposable
    {
        const int _typeNAME = 18;
        const int CefMenuModelDelegate_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefMenuModelDelegate(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModelDelegate_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefMenuModelDelegate New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefMenuModelDelegate(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,177
        const int MyCefMenuModelDelegate_ExecuteCommand_1 = 1;
        const int MyCefMenuModelDelegate_MouseOutsideMenu_2 = 2;
        const int MyCefMenuModelDelegate_UnhandledOpenSubmenu_3 = 3;
        const int MyCefMenuModelDelegate_UnhandledCloseSubmenu_4 = 4;
        const int MyCefMenuModelDelegate_MenuWillShow_5 = 5;
        const int MyCefMenuModelDelegate_MenuClosed_6 = 6;
        const int MyCefMenuModelDelegate_FormatLabel_7 = 7;
        //gen! void ExecuteCommand(CefRefPtr<CefMenuModel> menu_model,int command_id,cef_event_flags_t event_flags)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,178
        /// <summary>
        /// Perform the action associated with the specified |command_id| and
        /// optional |event_flags|.
        /// /*cef()*/
        /// </summary>
        public struct ExecuteCommandArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal ExecuteCommandArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((ExecuteCommandNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((ExecuteCommandNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((ExecuteCommandNativeArgs*)this.nativePtr)->menu_model);
                }
            }
            public int command_id()
            {
                unsafe
                {
                    return ((ExecuteCommandNativeArgs*)this.nativePtr)->command_id;
                }
            }
            public cef_event_flags_t event_flags()
            {
                unsafe
                {
                    return (cef_event_flags_t)(((ExecuteCommandNativeArgs*)this.nativePtr)->event_flags);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,179
        [StructLayout(LayoutKind.Sequential)]
        struct ExecuteCommandNativeArgs
        {
            public int argFlags;
            public IntPtr menu_model;
            public int command_id;
            public cef_event_flags_t event_flags;
        }
        //gen! void MouseOutsideMenu(CefRefPtr<CefMenuModel> menu_model,const CefPoint& screen_point)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,180
        /// <summary>
        /// Called when the user moves the mouse outside the menu and over the owning
        /// window.
        /// /*cef()*/
        /// </summary>
        public struct MouseOutsideMenuArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal MouseOutsideMenuArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((MouseOutsideMenuNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((MouseOutsideMenuNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((MouseOutsideMenuNativeArgs*)this.nativePtr)->menu_model);
                }
            }
            public CefPoint screen_point()
            {
                unsafe
                {
                    return new CefPoint(((MouseOutsideMenuNativeArgs*)this.nativePtr)->screen_point);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,181
        [StructLayout(LayoutKind.Sequential)]
        struct MouseOutsideMenuNativeArgs
        {
            public int argFlags;
            public IntPtr menu_model;
            public IntPtr screen_point;
        }
        //gen! void UnhandledOpenSubmenu(CefRefPtr<CefMenuModel> menu_model,bool is_rtl)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,182
        /// <summary>
        /// Called on unhandled open submenu keyboard commands. |is_rtl| will be true
        /// if the menu is displaying a right-to-left language.
        /// /*cef()*/
        /// </summary>
        public struct UnhandledOpenSubmenuArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal UnhandledOpenSubmenuArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((UnhandledOpenSubmenuNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((UnhandledOpenSubmenuNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((UnhandledOpenSubmenuNativeArgs*)this.nativePtr)->menu_model);
                }
            }
            public bool is_rtl()
            {
                unsafe
                {
                    return ((UnhandledOpenSubmenuNativeArgs*)this.nativePtr)->is_rtl;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,183
        [StructLayout(LayoutKind.Sequential)]
        struct UnhandledOpenSubmenuNativeArgs
        {
            public int argFlags;
            public IntPtr menu_model;
            public bool is_rtl;
        }
        //gen! void UnhandledCloseSubmenu(CefRefPtr<CefMenuModel> menu_model,bool is_rtl)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,184
        /// <summary>
        /// Called on unhandled close submenu keyboard commands. |is_rtl| will be true
        /// if the menu is displaying a right-to-left language.
        /// /*cef()*/
        /// </summary>
        public struct UnhandledCloseSubmenuArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal UnhandledCloseSubmenuArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((UnhandledCloseSubmenuNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((UnhandledCloseSubmenuNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((UnhandledCloseSubmenuNativeArgs*)this.nativePtr)->menu_model);
                }
            }
            public bool is_rtl()
            {
                unsafe
                {
                    return ((UnhandledCloseSubmenuNativeArgs*)this.nativePtr)->is_rtl;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,185
        [StructLayout(LayoutKind.Sequential)]
        struct UnhandledCloseSubmenuNativeArgs
        {
            public int argFlags;
            public IntPtr menu_model;
            public bool is_rtl;
        }
        //gen! void MenuWillShow(CefRefPtr<CefMenuModel> menu_model)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,186
        /// <summary>
        /// The menu is about to show.
        /// /*cef()*/
        /// </summary>
        public struct MenuWillShowArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal MenuWillShowArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((MenuWillShowNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((MenuWillShowNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((MenuWillShowNativeArgs*)this.nativePtr)->menu_model);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,187
        [StructLayout(LayoutKind.Sequential)]
        struct MenuWillShowNativeArgs
        {
            public int argFlags;
            public IntPtr menu_model;
        }
        //gen! void MenuClosed(CefRefPtr<CefMenuModel> menu_model)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,188
        /// <summary>
        /// The menu has closed.
        /// /*cef()*/
        /// </summary>
        public struct MenuClosedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal MenuClosedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((MenuClosedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((MenuClosedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((MenuClosedNativeArgs*)this.nativePtr)->menu_model);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,189
        [StructLayout(LayoutKind.Sequential)]
        struct MenuClosedNativeArgs
        {
            public int argFlags;
            public IntPtr menu_model;
        }
        //gen! bool FormatLabel(CefRefPtr<CefMenuModel> menu_model,CefString& label)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,190
        /// <summary>
        /// Optionally modify a menu item label. Return true if |label| was modified.
        /// /*cef()*/
        /// </summary>
        public struct FormatLabelArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal FormatLabelArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((FormatLabelNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((FormatLabelNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((FormatLabelNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefMenuModel menu_model()
            {
                unsafe
                {
                    return new CefMenuModel(((FormatLabelNativeArgs*)this.nativePtr)->menu_model);
                }
            }
            public string label()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((FormatLabelNativeArgs*)this.nativePtr)->label);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,191
        [StructLayout(LayoutKind.Sequential)]
        struct FormatLabelNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr menu_model;
            public IntPtr label;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,192
            /// <summary>
            /// Perform the action associated with the specified |command_id| and
            /// optional |event_flags|.
            /// /*cef()*/
            /// </summary>
            void ExecuteCommand(ExecuteCommandArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,193
            /// <summary>
            /// Called when the user moves the mouse outside the menu and over the owning
            /// window.
            /// /*cef()*/
            /// </summary>
            void MouseOutsideMenu(MouseOutsideMenuArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,194
            /// <summary>
            /// Called on unhandled open submenu keyboard commands. |is_rtl| will be true
            /// if the menu is displaying a right-to-left language.
            /// /*cef()*/
            /// </summary>
            void UnhandledOpenSubmenu(UnhandledOpenSubmenuArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,195
            /// <summary>
            /// Called on unhandled close submenu keyboard commands. |is_rtl| will be true
            /// if the menu is displaying a right-to-left language.
            /// /*cef()*/
            /// </summary>
            void UnhandledCloseSubmenu(UnhandledCloseSubmenuArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,196
            /// <summary>
            /// The menu is about to show.
            /// /*cef()*/
            /// </summary>
            void MenuWillShow(MenuWillShowArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,197
            /// <summary>
            /// The menu has closed.
            /// /*cef()*/
            /// </summary>
            void MenuClosed(MenuClosedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,198
            /// <summary>
            /// Optionally modify a menu item label. Return true if |label| was modified.
            /// /*cef()*/
            /// </summary>
            void FormatLabel(FormatLabelArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,199
            /// <summary>
            /// Perform the action associated with the specified |command_id| and
            /// optional |event_flags|.
            /// /*cef()*/
            /// </summary>
            void ExecuteCommand(CefMenuModel menu_model, int command_id, cef_event_flags_t event_flags);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,200
            /// <summary>
            /// Called when the user moves the mouse outside the menu and over the owning
            /// window.
            /// /*cef()*/
            /// </summary>
            void MouseOutsideMenu(CefMenuModel menu_model, CefPoint screen_point);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,201
            /// <summary>
            /// Called on unhandled open submenu keyboard commands. |is_rtl| will be true
            /// if the menu is displaying a right-to-left language.
            /// /*cef()*/
            /// </summary>
            void UnhandledOpenSubmenu(CefMenuModel menu_model, bool is_rtl);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,202
            /// <summary>
            /// Called on unhandled close submenu keyboard commands. |is_rtl| will be true
            /// if the menu is displaying a right-to-left language.
            /// /*cef()*/
            /// </summary>
            void UnhandledCloseSubmenu(CefMenuModel menu_model, bool is_rtl);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,203
            /// <summary>
            /// The menu is about to show.
            /// /*cef()*/
            /// </summary>
            void MenuWillShow(CefMenuModel menu_model);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,204
            /// <summary>
            /// The menu has closed.
            /// /*cef()*/
            /// </summary>
            void MenuClosed(CefMenuModel menu_model);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,205
            /// <summary>
            /// Optionally modify a menu item label. Return true if |label| was modified.
            /// /*cef()*/
            /// </summary>
            bool FormatLabel(CefMenuModel menu_model, string label);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,206
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,207
                case MyCefMenuModelDelegate_ExecuteCommand_1:
                    {
                        var args = new ExecuteCommandArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.ExecuteCommand(args);
                        }
                        if (i1 != null)
                        {
                            ExecuteCommand(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,208
                case MyCefMenuModelDelegate_MouseOutsideMenu_2:
                    {
                        var args = new MouseOutsideMenuArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.MouseOutsideMenu(args);
                        }
                        if (i1 != null)
                        {
                            MouseOutsideMenu(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,209
                case MyCefMenuModelDelegate_UnhandledOpenSubmenu_3:
                    {
                        var args = new UnhandledOpenSubmenuArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.UnhandledOpenSubmenu(args);
                        }
                        if (i1 != null)
                        {
                            UnhandledOpenSubmenu(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,210
                case MyCefMenuModelDelegate_UnhandledCloseSubmenu_4:
                    {
                        var args = new UnhandledCloseSubmenuArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.UnhandledCloseSubmenu(args);
                        }
                        if (i1 != null)
                        {
                            UnhandledCloseSubmenu(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,211
                case MyCefMenuModelDelegate_MenuWillShow_5:
                    {
                        var args = new MenuWillShowArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.MenuWillShow(args);
                        }
                        if (i1 != null)
                        {
                            MenuWillShow(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,212
                case MyCefMenuModelDelegate_MenuClosed_6:
                    {
                        var args = new MenuClosedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.MenuClosed(args);
                        }
                        if (i1 != null)
                        {
                            MenuClosed(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,213
                case MyCefMenuModelDelegate_FormatLabel_7:
                    {
                        var args = new FormatLabelArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.FormatLabel(args);
                        }
                        if (i1 != null)
                        {
                            FormatLabel(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,214
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefMenuModelDelegate_ExecuteCommand_1:
                    i0.ExecuteCommand(new ExecuteCommandArgs(nativeArgPtr));
                    break;
                case MyCefMenuModelDelegate_MouseOutsideMenu_2:
                    i0.MouseOutsideMenu(new MouseOutsideMenuArgs(nativeArgPtr));
                    break;
                case MyCefMenuModelDelegate_UnhandledOpenSubmenu_3:
                    i0.UnhandledOpenSubmenu(new UnhandledOpenSubmenuArgs(nativeArgPtr));
                    break;
                case MyCefMenuModelDelegate_UnhandledCloseSubmenu_4:
                    i0.UnhandledCloseSubmenu(new UnhandledCloseSubmenuArgs(nativeArgPtr));
                    break;
                case MyCefMenuModelDelegate_MenuWillShow_5:
                    i0.MenuWillShow(new MenuWillShowArgs(nativeArgPtr));
                    break;
                case MyCefMenuModelDelegate_MenuClosed_6:
                    i0.MenuClosed(new MenuClosedArgs(nativeArgPtr));
                    break;
                case MyCefMenuModelDelegate_FormatLabel_7:
                    i0.FormatLabel(new FormatLabelArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,215
        public static void ExecuteCommand(I1 i1, ExecuteCommandArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,216
            i1.ExecuteCommand(args.menu_model(),
            args.command_id(),
            args.event_flags());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,217
        public static void MouseOutsideMenu(I1 i1, MouseOutsideMenuArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,218
            i1.MouseOutsideMenu(args.menu_model(),
            args.screen_point());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,219
        public static void UnhandledOpenSubmenu(I1 i1, UnhandledOpenSubmenuArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,220
            i1.UnhandledOpenSubmenu(args.menu_model(),
            args.is_rtl());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,221
        public static void UnhandledCloseSubmenu(I1 i1, UnhandledCloseSubmenuArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,222
            i1.UnhandledCloseSubmenu(args.menu_model(),
            args.is_rtl());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,223
        public static void MenuWillShow(I1 i1, MenuWillShowArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,224
            i1.MenuWillShow(args.menu_model());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,225
        public static void MenuClosed(I1 i1, MenuClosedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,226
            i1.MenuClosed(args.menu_model());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,227
        public static void FormatLabel(I1 i1, FormatLabelArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,228
            args.myext_setRetValue(i1.FormatLabel(args.menu_model(),
            args.label()));
        }
    }


    // [virtual] class CefNavigationEntry
    //CsCallToNativeCodeGen::GenerateCsCode , 324
    /// <summary>
    /// Class used to represent an entry in navigation history.
    /// /*(source=library)*/
    /// </summary>
    public struct CefNavigationEntry : IDisposable
    {
        const int _typeNAME = 19;
        const int CefNavigationEntry_Release_0 = (_typeNAME << 16) | 0;
        const int CefNavigationEntry_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefNavigationEntry_GetURL_2 = (_typeNAME << 16) | 2;
        const int CefNavigationEntry_GetDisplayURL_3 = (_typeNAME << 16) | 3;
        const int CefNavigationEntry_GetOriginalURL_4 = (_typeNAME << 16) | 4;
        const int CefNavigationEntry_GetTitle_5 = (_typeNAME << 16) | 5;
        const int CefNavigationEntry_GetTransitionType_6 = (_typeNAME << 16) | 6;
        const int CefNavigationEntry_HasPostData_7 = (_typeNAME << 16) | 7;
        const int CefNavigationEntry_GetCompletionTime_8 = (_typeNAME << 16) | 8;
        const int CefNavigationEntry_GetHttpStatusCode_9 = (_typeNAME << 16) | 9;
        const int CefNavigationEntry_GetSSLStatus_10 = (_typeNAME << 16) | 10;
        internal IntPtr nativePtr;
        internal CefNavigationEntry(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 325

        // gen! bool IsValid()
        /// <summary>
        /// CefNavigationEntry methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 326

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the actual URL of the page. For some pages this may be data: URL or
        /// similar. Use GetDisplayURL() to return a display-friendly version.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetURL_2, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 327

        // gen! CefString GetDisplayURL()
        /// <summary>
        /// Returns a display-friendly version of the URL.
        /// /*cef()*/
        /// </summary>

        public string GetDisplayURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetDisplayURL_3, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 328

        // gen! CefString GetOriginalURL()
        /// <summary>
        /// Returns the original URL that was entered by the user before any redirects.
        /// /*cef()*/
        /// </summary>

        public string GetOriginalURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetOriginalURL_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 329

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title set by the page. This value may be empty.
        /// /*cef()*/
        /// </summary>

        public string GetTitle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTitle_5, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 330

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Returns the transition type which indicates what the user did to move to
        /// this page from the previous page.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>

        public cef_transition_type_t GetTransitionType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTransitionType_6, out ret);
            return (cef_transition_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 331

        // gen! bool HasPostData()
        /// <summary>
        /// Returns true if this navigation includes post data.
        /// /*cef()*/
        /// </summary>

        public bool HasPostData()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_HasPostData_7, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 332

        // gen! CefTime GetCompletionTime()
        /// <summary>
        /// Returns the time for the last known successful navigation completion. A
        /// navigation may be completed more than once if the page is reloaded. May be
        /// 0 if the navigation has not yet completed.
        /// /*cef()*/
        /// </summary>

        public CefTime GetCompletionTime()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetCompletionTime_8, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 333

        // gen! int GetHttpStatusCode()
        /// <summary>
        /// Returns the HTTP status code for the last known successful navigation
        /// response. May be 0 if the response has not yet been received or if the
        /// navigation has not yet completed.
        /// /*cef()*/
        /// </summary>

        public int GetHttpStatusCode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetHttpStatusCode_9, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 334

        // gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
        /// <summary>
        /// Returns the SSL information for this navigation entry.
        /// /*cef()*/
        /// </summary>

        public CefSSLStatus GetSSLStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetSSLStatus_10, out ret);
            return new CefSSLStatus(ret.Ptr);
        }
    }


    // [virtual] class CefPrintSettings
    //CsCallToNativeCodeGen::GenerateCsCode , 335
    /// <summary>
    /// Class representing print settings.
    /// /*(source=library)*/
    /// </summary>
    public struct CefPrintSettings : IDisposable
    {
        const int _typeNAME = 20;
        const int CefPrintSettings_Release_0 = (_typeNAME << 16) | 0;
        const int CefPrintSettings_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefPrintSettings_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefPrintSettings_Copy_3 = (_typeNAME << 16) | 3;
        const int CefPrintSettings_SetOrientation_4 = (_typeNAME << 16) | 4;
        const int CefPrintSettings_IsLandscape_5 = (_typeNAME << 16) | 5;
        const int CefPrintSettings_SetPrinterPrintableArea_6 = (_typeNAME << 16) | 6;
        const int CefPrintSettings_SetDeviceName_7 = (_typeNAME << 16) | 7;
        const int CefPrintSettings_GetDeviceName_8 = (_typeNAME << 16) | 8;
        const int CefPrintSettings_SetDPI_9 = (_typeNAME << 16) | 9;
        const int CefPrintSettings_GetDPI_10 = (_typeNAME << 16) | 10;
        const int CefPrintSettings_SetPageRanges_11 = (_typeNAME << 16) | 11;
        const int CefPrintSettings_GetPageRangesCount_12 = (_typeNAME << 16) | 12;
        const int CefPrintSettings_GetPageRanges_13 = (_typeNAME << 16) | 13;
        const int CefPrintSettings_SetSelectionOnly_14 = (_typeNAME << 16) | 14;
        const int CefPrintSettings_IsSelectionOnly_15 = (_typeNAME << 16) | 15;
        const int CefPrintSettings_SetCollate_16 = (_typeNAME << 16) | 16;
        const int CefPrintSettings_WillCollate_17 = (_typeNAME << 16) | 17;
        const int CefPrintSettings_SetColorModel_18 = (_typeNAME << 16) | 18;
        const int CefPrintSettings_GetColorModel_19 = (_typeNAME << 16) | 19;
        const int CefPrintSettings_SetCopies_20 = (_typeNAME << 16) | 20;
        const int CefPrintSettings_GetCopies_21 = (_typeNAME << 16) | 21;
        const int CefPrintSettings_SetDuplexMode_22 = (_typeNAME << 16) | 22;
        const int CefPrintSettings_GetDuplexMode_23 = (_typeNAME << 16) | 23;
        //
        const int CefPrintSettings_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefPrintSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 336

        // gen! bool IsValid()
        /// <summary>
        /// CefPrintSettings methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 337

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsReadOnly_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 338

        // gen! CefRefPtr<CefPrintSettings> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefPrintSettings Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Copy_3, out ret);
            return new CefPrintSettings(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 339

        // gen! void SetOrientation(bool landscape)
        /// <summary>
        /// Set the page orientation.
        /// /*cef()*/
        /// </summary>

        public void SetOrientation(bool landscape)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = landscape ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetOrientation_4, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 340

        // gen! bool IsLandscape()
        /// <summary>
        /// Returns true if the orientation is landscape.
        /// /*cef()*/
        /// </summary>

        public bool IsLandscape()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsLandscape_5, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 341

        // gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
        /// <summary>
        /// Set the printer printable area in device units.
        /// Some platforms already provide flipped area. Set |landscape_needs_flip|
        /// to false on those platforms to avoid double flipping.
        /// /*cef()*/
        /// </summary>

        public void SetPrinterPrintableArea(CefSize physical_size_device_units,
        CefRect printable_area_device_units,
        bool landscape_needs_flip)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = physical_size_device_units.nativePtr;
            v2.Ptr = printable_area_device_units.nativePtr;
            v3.I32 = landscape_needs_flip ? 1 : 0;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefPrintSettings_SetPrinterPrintableArea_6, out ret, ref v1, ref v2, ref v3);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 342

        // gen! void SetDeviceName(const CefString& name)
        /// <summary>
        /// Set the device name.
        /// /*cef(optional_param=name)*/
        /// </summary>

        public void SetDeviceName(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDeviceName_7, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 343

        // gen! CefString GetDeviceName()
        /// <summary>
        /// Get the device name.
        /// /*cef()*/
        /// </summary>

        public string GetDeviceName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDeviceName_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 344

        // gen! void SetDPI(int dpi)
        /// <summary>
        /// Set the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>

        public void SetDPI(int dpi)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)dpi;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDPI_9, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 345

        // gen! int GetDPI()
        /// <summary>
        /// Get the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>

        public int GetDPI()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDPI_10, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 346

        // gen! void SetPageRanges(const PageRangeList& ranges)
        /// <summary>
        /// Set the page ranges.
        /// /*cef()*/
        /// </summary>

        public void SetPageRanges(PageRangeList ranges)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = ranges.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetPageRanges_11, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 347

        // gen! size_t GetPageRangesCount()
        /// <summary>
        /// Returns the number of page ranges that currently exist.
        /// /*cef()*/
        /// </summary>

        public uint GetPageRangesCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetPageRangesCount_12, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 348

        // gen! void GetPageRanges(PageRangeList& ranges)
        /// <summary>
        /// Retrieve the page ranges.
        /// /*cef(count_func=ranges:GetPageRangesCount)*/
        /// </summary>

        public void GetPageRanges(PageRangeList ranges)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = ranges.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_GetPageRanges_13, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 349

        // gen! void SetSelectionOnly(bool selection_only)
        /// <summary>
        /// Set whether only the selection will be printed.
        /// /*cef()*/
        /// </summary>

        public void SetSelectionOnly(bool selection_only)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = selection_only ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetSelectionOnly_14, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 350

        // gen! bool IsSelectionOnly()
        /// <summary>
        /// Returns true if only the selection will be printed.
        /// /*cef()*/
        /// </summary>

        public bool IsSelectionOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsSelectionOnly_15, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 351

        // gen! void SetCollate(bool collate)
        /// <summary>
        /// Set whether pages will be collated.
        /// /*cef()*/
        /// </summary>

        public void SetCollate(bool collate)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = collate ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCollate_16, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 352

        // gen! bool WillCollate()
        /// <summary>
        /// Returns true if pages will be collated.
        /// /*cef()*/
        /// </summary>

        public bool WillCollate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_WillCollate_17, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 353

        // gen! void SetColorModel(ColorModel model)
        /// <summary>
        /// Set the color model.
        /// /*cef()*/
        /// </summary>

        public void SetColorModel(cef_color_model_t model)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)model;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetColorModel_18, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 354

        // gen! ColorModel GetColorModel()
        /// <summary>
        /// Get the color model.
        /// /*cef(default_retval=COLOR_MODEL_UNKNOWN)*/
        /// </summary>

        public cef_color_model_t GetColorModel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetColorModel_19, out ret);
            return (cef_color_model_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 355

        // gen! void SetCopies(int copies)
        /// <summary>
        /// Set the number of copies.
        /// /*cef()*/
        /// </summary>

        public void SetCopies(int copies)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)copies;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCopies_20, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 356

        // gen! int GetCopies()
        /// <summary>
        /// Get the number of copies.
        /// /*cef()*/
        /// </summary>

        public int GetCopies()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetCopies_21, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 357

        // gen! void SetDuplexMode(DuplexMode mode)
        /// <summary>
        /// Set the duplex mode.
        /// /*cef()*/
        /// </summary>

        public void SetDuplexMode(cef_duplex_mode_t mode)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)mode;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDuplexMode_22, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 358

        // gen! DuplexMode GetDuplexMode()
        /// <summary>
        /// Get the duplex mode.
        /// /*cef(default_retval=DUPLEX_MODE_UNKNOWN)*/
        /// </summary>

        public cef_duplex_mode_t GetDuplexMode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDuplexMode_23, out ret);
            return (cef_duplex_mode_t)ret.I32;

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 359

        // gen! CefRefPtr<CefPrintSettings> Create()
        /// <summary>
        /// Create a new CefPrintSettings object.
        /// /*cef()*/
        /// </summary>

        public static CefPrintSettings Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefPrintSettings_S_Create_1, out ret);
            return new CefPrintSettings(ret.Ptr);
        }
    }


    // [virtual] class CefProcessMessage
    //CsCallToNativeCodeGen::GenerateCsCode , 360
    /// <summary>
    /// Class representing a message. Can be used on any process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    public struct CefProcessMessage : IDisposable
    {
        const int _typeNAME = 21;
        const int CefProcessMessage_Release_0 = (_typeNAME << 16) | 0;
        const int CefProcessMessage_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefProcessMessage_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefProcessMessage_Copy_3 = (_typeNAME << 16) | 3;
        const int CefProcessMessage_GetName_4 = (_typeNAME << 16) | 4;
        const int CefProcessMessage_GetArgumentList_5 = (_typeNAME << 16) | 5;
        //
        const int CefProcessMessage_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefProcessMessage(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 361

        // gen! bool IsValid()
        /// <summary>
        /// CefProcessMessage methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 362

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsReadOnly_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 363

        // gen! CefRefPtr<CefProcessMessage> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefProcessMessage Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Copy_3, out ret);
            return new CefProcessMessage(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 364

        // gen! CefString GetName()
        /// <summary>
        /// Returns the message name.
        /// /*cef()*/
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetName_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 365

        // gen! CefRefPtr<CefListValue> GetArgumentList()
        /// <summary>
        /// Returns the list of arguments.
        /// /*cef()*/
        /// </summary>

        public CefListValue GetArgumentList()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetArgumentList_5, out ret);
            return new CefListValue(ret.Ptr);
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 366

        // gen! CefRefPtr<CefProcessMessage> Create(const CefString& name)
        /// <summary>
        /// Create a new CefProcessMessage object with the specified name.
        /// /*cef()*/
        /// </summary>

        public static CefProcessMessage Create(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_S_Call1(CefProcessMessage_S_Create_1, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefProcessMessage(ret.Ptr);
        }
    }


    // [virtual] class CefRequest
    //CsCallToNativeCodeGen::GenerateCsCode , 367
    /// <summary>
    /// Class used to represent a web request. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefRequest : IDisposable
    {
        const int _typeNAME = 22;
        const int CefRequest_Release_0 = (_typeNAME << 16) | 0;
        const int CefRequest_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefRequest_GetURL_2 = (_typeNAME << 16) | 2;
        const int CefRequest_SetURL_3 = (_typeNAME << 16) | 3;
        const int CefRequest_GetMethod_4 = (_typeNAME << 16) | 4;
        const int CefRequest_SetMethod_5 = (_typeNAME << 16) | 5;
        const int CefRequest_SetReferrer_6 = (_typeNAME << 16) | 6;
        const int CefRequest_GetReferrerURL_7 = (_typeNAME << 16) | 7;
        const int CefRequest_GetReferrerPolicy_8 = (_typeNAME << 16) | 8;
        const int CefRequest_GetPostData_9 = (_typeNAME << 16) | 9;
        const int CefRequest_SetPostData_10 = (_typeNAME << 16) | 10;
        const int CefRequest_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        const int CefRequest_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        const int CefRequest_Set_13 = (_typeNAME << 16) | 13;
        const int CefRequest_GetFlags_14 = (_typeNAME << 16) | 14;
        const int CefRequest_SetFlags_15 = (_typeNAME << 16) | 15;
        const int CefRequest_GetFirstPartyForCookies_16 = (_typeNAME << 16) | 16;
        const int CefRequest_SetFirstPartyForCookies_17 = (_typeNAME << 16) | 17;
        const int CefRequest_GetResourceType_18 = (_typeNAME << 16) | 18;
        const int CefRequest_GetTransitionType_19 = (_typeNAME << 16) | 19;
        const int CefRequest_GetIdentifier_20 = (_typeNAME << 16) | 20;
        //
        const int CefRequest_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefRequest(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 368

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefRequest methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_IsReadOnly_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 369

        // gen! CefString GetURL()
        /// <summary>
        /// Get the fully qualified URL.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetURL_2, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 370

        // gen! void SetURL(const CefString& url)
        /// <summary>
        /// Set the fully qualified URL.
        /// /*cef()*/
        /// </summary>

        public void SetURL(string url)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetURL_3, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 371

        // gen! CefString GetMethod()
        /// <summary>
        /// Get the request method type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// /*cef()*/
        /// </summary>

        public string GetMethod()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetMethod_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 372

        // gen! void SetMethod(const CefString& method)
        /// <summary>
        /// Set the request method type.
        /// /*cef()*/
        /// </summary>

        public void SetMethod(string method)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(method);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetMethod_5, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 373

        // gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
        /// <summary>
        /// Set the referrer URL and policy. If non-empty the referrer URL must be
        /// fully qualified with an HTTP or HTTPS scheme component. Any username,
        /// password or ref component will be removed.
        /// /*cef()*/
        /// </summary>

        public void SetReferrer(string referrer_url,
        cef_referrer_policy_t policy)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(referrer_url);
            v2.I32 = (int)policy;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequest_SetReferrer_6, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 374

        // gen! CefString GetReferrerURL()
        /// <summary>
        /// Get the referrer URL.
        /// /*cef()*/
        /// </summary>

        public string GetReferrerURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerURL_7, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 375

        // gen! ReferrerPolicy GetReferrerPolicy()
        /// <summary>
        /// Get the referrer policy.
        /// /*cef(default_retval=REFERRER_POLICY_DEFAULT)*/
        /// </summary>

        public cef_referrer_policy_t GetReferrerPolicy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerPolicy_8, out ret);
            return (cef_referrer_policy_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 376

        // gen! CefRefPtr<CefPostData> GetPostData()
        /// <summary>
        /// Get the post data.
        /// /*cef()*/
        /// </summary>

        public CefPostData GetPostData()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetPostData_9, out ret);
            return new CefPostData(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 377

        // gen! void SetPostData(CefRefPtr<CefPostData> postData)
        /// <summary>
        /// Set the post data.
        /// /*cef()*/
        /// </summary>

        public void SetPostData(CefPostData postData)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = postData.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetPostData_10, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 378

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get the header values. Will not include the Referer value if any.
        /// /*cef()*/
        /// </summary>

        public void GetHeaderMap(HeaderMap headerMap)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_GetHeaderMap_11, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 379

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set the header values. If a Referer value exists in the header map it will
        /// be removed and ignored.
        /// /*cef()*/
        /// </summary>

        public void SetHeaderMap(HeaderMap headerMap)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetHeaderMap_12, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 380

        // gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
        /// <summary>
        /// Set all values at one time.
        /// /*cef(optional_param=postData)*/
        /// </summary>

        public void Set(string url,
        string method,
        CefPostData postData,
        HeaderMap headerMap)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(method);
            v3.Ptr = postData.nativePtr;
            v4.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefRequest_Set_13, out ret, ref v1, ref v2, ref v3, ref v4);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 381

        // gen! int GetFlags()
        /// <summary>
        /// Get the flags used in combination with CefURLRequest. See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef(default_retval=UR_FLAG_NONE)*/
        /// </summary>

        public int GetFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFlags_14, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 382

        // gen! void SetFlags(int flags)
        /// <summary>
        /// Set the flags used in combination with CefURLRequest.  See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef()*/
        /// </summary>

        public void SetFlags(int flags)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)flags;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFlags_15, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 383

        // gen! CefString GetFirstPartyForCookies()
        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>

        public string GetFirstPartyForCookies()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFirstPartyForCookies_16, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 384

        // gen! void SetFirstPartyForCookies(const CefString& url)
        /// <summary>
        /// Get the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>

        public void SetFirstPartyForCookies(string url)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(url);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFirstPartyForCookies_17, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 385

        // gen! ResourceType GetResourceType()
        /// <summary>
        /// Get the resource type for this request. Only available in the browser
        /// process.
        /// /*cef(default_retval=RT_SUB_RESOURCE)*/
        /// </summary>

        public cef_resource_type_t GetResourceType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetResourceType_18, out ret);
            return (cef_resource_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 386

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or
        /// sub-frame navigation.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>

        public cef_transition_type_t GetTransitionType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetTransitionType_19, out ret);
            return (cef_transition_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 387

        // gen! uint64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this request or 0 if not
        /// specified. Can be used by CefRequestHandler implementations in the browser
        /// process to track a single request across multiple callbacks.
        /// /*cef()*/
        /// </summary>

        public ulong GetIdentifier()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetIdentifier_20, out ret);
            return (ulong)ret.I64;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 388

        // gen! CefRefPtr<CefRequest> Create()
        /// <summary>
        /// Create a new CefRequest object.
        /// /*cef()*/
        /// </summary>

        public static CefRequest Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefRequest_S_Create_1, out ret);
            return new CefRequest(ret.Ptr);
        }
    }


    // [virtual] class CefPostData
    //CsCallToNativeCodeGen::GenerateCsCode , 389
    /// <summary>
    /// Class used to represent post data for a web request. The methods of this
    /// class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefPostData : IDisposable
    {
        const int _typeNAME = 23;
        const int CefPostData_Release_0 = (_typeNAME << 16) | 0;
        const int CefPostData_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefPostData_HasExcludedElements_2 = (_typeNAME << 16) | 2;
        const int CefPostData_GetElementCount_3 = (_typeNAME << 16) | 3;
        const int CefPostData_GetElements_4 = (_typeNAME << 16) | 4;
        const int CefPostData_RemoveElement_5 = (_typeNAME << 16) | 5;
        const int CefPostData_AddElement_6 = (_typeNAME << 16) | 6;
        const int CefPostData_RemoveElements_7 = (_typeNAME << 16) | 7;
        //
        const int CefPostData_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefPostData(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 390

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostData methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_IsReadOnly_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 391

        // gen! bool HasExcludedElements()
        /// <summary>
        /// Returns true if the underlying POST data includes elements that are not
        /// represented by this CefPostData object (for example, multi-part file upload
        /// data). Modifying CefPostData objects with excluded elements may result in
        /// the request failing.
        /// /*cef()*/
        /// </summary>

        public bool HasExcludedElements()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_HasExcludedElements_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 392

        // gen! size_t GetElementCount()
        /// <summary>
        /// Returns the number of existing post data elements.
        /// /*cef()*/
        /// </summary>

        public uint GetElementCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_GetElementCount_3, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 393

        // gen! void GetElements(ElementVector& elements)
        /// <summary>
        /// Retrieve the post data elements.
        /// /*cef(count_func=elements:GetElementCount)*/
        /// </summary>

        public void GetElements(ElementVector elements)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = elements.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_GetElements_4, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 394

        // gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Remove the specified post data element.  Returns true if the removal
        /// succeeds.
        /// /*cef()*/
        /// </summary>

        public bool RemoveElement(CefPostDataElement element)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = element.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_RemoveElement_5, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 395

        // gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Add the specified post data element.  Returns true if the add succeeds.
        /// /*cef()*/
        /// </summary>

        public bool AddElement(CefPostDataElement element)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = element.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_AddElement_6, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 396

        // gen! void RemoveElements()
        /// <summary>
        /// Remove all existing post data elements.
        /// /*cef()*/
        /// </summary>

        public void RemoveElements()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_RemoveElements_7, out ret);

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 397

        // gen! CefRefPtr<CefPostData> Create()
        /// <summary>
        /// Create a new CefPostData object.
        /// /*cef()*/
        /// </summary>

        public static CefPostData Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefPostData_S_Create_1, out ret);
            return new CefPostData(ret.Ptr);
        }
    }


    // [virtual] class CefPostDataElement
    //CsCallToNativeCodeGen::GenerateCsCode , 398
    /// <summary>
    /// Class used to represent a single element in the request post data. The
    /// methods of this class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefPostDataElement : IDisposable
    {
        const int _typeNAME = 24;
        const int CefPostDataElement_Release_0 = (_typeNAME << 16) | 0;
        const int CefPostDataElement_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefPostDataElement_SetToEmpty_2 = (_typeNAME << 16) | 2;
        const int CefPostDataElement_SetToFile_3 = (_typeNAME << 16) | 3;
        const int CefPostDataElement_SetToBytes_4 = (_typeNAME << 16) | 4;
        const int CefPostDataElement_GetType_5 = (_typeNAME << 16) | 5;
        const int CefPostDataElement_GetFile_6 = (_typeNAME << 16) | 6;
        const int CefPostDataElement_GetBytesCount_7 = (_typeNAME << 16) | 7;
        const int CefPostDataElement_GetBytes_8 = (_typeNAME << 16) | 8;
        //
        const int CefPostDataElement_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefPostDataElement(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 399

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostDataElement methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_IsReadOnly_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 400

        // gen! void SetToEmpty()
        /// <summary>
        /// Remove all contents from the post data element.
        /// /*cef()*/
        /// </summary>

        public void SetToEmpty()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_SetToEmpty_2, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 401

        // gen! void SetToFile(const CefString& fileName)
        /// <summary>
        /// The post data element will represent a file.
        /// /*cef()*/
        /// </summary>

        public void SetToFile(string fileName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(fileName);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostDataElement_SetToFile_3, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 402

        // gen! void SetToBytes(size_t size,const void* bytes)
        /// <summary>
        /// The post data element will represent bytes.  The bytes passed
        /// in will be copied.
        /// /*cef()*/
        /// </summary>

        public void SetToBytes(uint size,
        IntPtr bytes)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size;
            v2.Ptr = bytes;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_SetToBytes_4, out ret, ref v1, ref v2);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 403

        // gen! Type GetType()
        /// <summary>
        /// Return the type of this post data element.
        /// /*cef(default_retval=PDE_TYPE_EMPTY)*/
        /// </summary>

        public cef_postdataelement_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetType_5, out ret);
            return (cef_postdataelement_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 404

        // gen! CefString GetFile()
        /// <summary>
        /// Return the file name.
        /// /*cef()*/
        /// </summary>

        public string GetFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetFile_6, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 405

        // gen! size_t GetBytesCount()
        /// <summary>
        /// Return the number of bytes.
        /// /*cef()*/
        /// </summary>

        public uint GetBytesCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetBytesCount_7, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 406

        // gen! size_t GetBytes(size_t size,void* bytes)
        /// <summary>
        /// Read up to |size| bytes into |bytes| and return the number of bytes
        /// actually read.
        /// /*cef()*/
        /// </summary>

        public uint GetBytes(uint size,
        IntPtr bytes)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size;
            v2.Ptr = bytes;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_GetBytes_8, out ret, ref v1, ref v2);
            return (uint)ret.I32;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 407

        // gen! CefRefPtr<CefPostDataElement> Create()
        /// <summary>
        /// Create a new CefPostDataElement object.
        /// /*cef()*/
        /// </summary>

        public static CefPostDataElement Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefPostDataElement_S_Create_1, out ret);
            return new CefPostDataElement(ret.Ptr);
        }
    }


    // [virtual] class CefRequestContext
    //CsCallToNativeCodeGen::GenerateCsCode , 408
    /// <summary>
    /// A request context provides request handling for a set of related browser
    /// or URL request objects. A request context can be specified when creating a
    /// new browser via the CefBrowserHost static factory methods or when creating a
    /// new URL request via the CefURLRequest static factory methods. Browser objects
    /// with different request contexts will never be hosted in the same render
    /// process. Browser objects with the same request context may or may not be
    /// hosted in the same render process depending on the process model. Browser
    /// objects created indirectly via the JavaScript window.open function or
    /// targeted links will share the same render process and the same request
    /// context as the source browser. When running in single-process mode there is
    /// only a single render process (the main process) and so all browsers created
    /// in single-process mode will share the same request context. This will be the
    /// first request context passed into a CefBrowserHost static factory method and
    /// all other request context objects will be ignored.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefRequestContext : IDisposable
    {
        const int _typeNAME = 25;
        const int CefRequestContext_Release_0 = (_typeNAME << 16) | 0;
        const int CefRequestContext_IsSame_1 = (_typeNAME << 16) | 1;
        const int CefRequestContext_IsSharingWith_2 = (_typeNAME << 16) | 2;
        const int CefRequestContext_IsGlobal_3 = (_typeNAME << 16) | 3;
        const int CefRequestContext_GetHandler_4 = (_typeNAME << 16) | 4;
        const int CefRequestContext_GetCachePath_5 = (_typeNAME << 16) | 5;
        const int CefRequestContext_GetDefaultCookieManager_6 = (_typeNAME << 16) | 6;
        const int CefRequestContext_RegisterSchemeHandlerFactory_7 = (_typeNAME << 16) | 7;
        const int CefRequestContext_ClearSchemeHandlerFactories_8 = (_typeNAME << 16) | 8;
        const int CefRequestContext_PurgePluginListCache_9 = (_typeNAME << 16) | 9;
        const int CefRequestContext_HasPreference_10 = (_typeNAME << 16) | 10;
        const int CefRequestContext_GetPreference_11 = (_typeNAME << 16) | 11;
        const int CefRequestContext_GetAllPreferences_12 = (_typeNAME << 16) | 12;
        const int CefRequestContext_CanSetPreference_13 = (_typeNAME << 16) | 13;
        const int CefRequestContext_SetPreference_14 = (_typeNAME << 16) | 14;
        const int CefRequestContext_ClearCertificateExceptions_15 = (_typeNAME << 16) | 15;
        const int CefRequestContext_CloseAllConnections_16 = (_typeNAME << 16) | 16;
        const int CefRequestContext_ResolveHost_17 = (_typeNAME << 16) | 17;
        const int CefRequestContext_ResolveHostCached_18 = (_typeNAME << 16) | 18;
        //
        const int CefRequestContext_S_GetGlobalContext_1 = (_typeNAME << 16) | 1;
        const int CefRequestContext_S_CreateContext_2 = (_typeNAME << 16) | 2;
        const int CefRequestContext_S_CreateContext_3 = (_typeNAME << 16) | 3;
        internal IntPtr nativePtr;
        internal CefRequestContext(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 409

        // gen! bool IsSame(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// CefRequestContext methods.
        /// </summary>

        public bool IsSame(CefRequestContext other)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSame_1, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 410

        // gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// Returns true if this object is sharing the same storage as |that| object.
        /// /*cef()*/
        /// </summary>

        public bool IsSharingWith(CefRequestContext other)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSharingWith_2, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 411

        // gen! bool IsGlobal()
        /// <summary>
        /// Returns true if this object is the global context. The global context is
        /// used by default when creating a browser or URL request with a NULL context
        /// argument.
        /// /*cef()*/
        /// </summary>

        public bool IsGlobal()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_IsGlobal_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 412

        // gen! CefRefPtr<CefRequestContextHandler> GetHandler()
        /// <summary>
        /// Returns the handler for this context if any.
        /// /*cef()*/
        /// </summary>

        public CefRequestContextHandler GetHandler()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetHandler_4, out ret);
            return new CefRequestContextHandler(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 413

        // gen! CefString GetCachePath()
        /// <summary>
        /// Returns the cache path for this object. If empty an "incognito mode"
        /// in-memory cache is being used.
        /// /*cef()*/
        /// </summary>

        public string GetCachePath()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetCachePath_5, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 414

        // gen! CefRefPtr<CefCookieManager> GetDefaultCookieManager(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Returns the default cookie manager for this object. This will be the global
        /// cookie manager if this object is the global request context. Otherwise,
        /// this will be the default cookie manager used when this request context does
        /// not receive a value via CefRequestContextHandler::GetCookieManager(). If
        /// |callback| is non-NULL it will be executed asnychronously on the IO thread
        /// after the manager's storage has been initialized.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public CefCookieManager GetDefaultCookieManager(CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetDefaultCookieManager_6, out ret, ref v1);
            return new CefCookieManager(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 415

        // gen! bool RegisterSchemeHandlerFactory(const CefString& scheme_name,const CefString& domain_name,CefRefPtr<CefSchemeHandlerFactory> factory)
        /// <summary>
        /// Register a scheme handler factory for the specified |scheme_name| and
        /// optional |domain_name|. An empty |domain_name| value for a standard scheme
        /// will cause the factory to match all domain names. The |domain_name| value
        /// will be ignored for non-standard schemes. If |scheme_name| is a built-in
        /// scheme and no handler is returned by |factory| then the built-in scheme
        /// handler factory will be called. If |scheme_name| is a custom scheme then
        /// you must also implement the CefApp::OnRegisterCustomSchemes() method in all
        /// processes. This function may be called multiple times to change or remove
        /// the factory that matches the specified |scheme_name| and optional
        /// |domain_name|. Returns false if an error occurs. This function may be
        /// called on any thread in the browser process.
        /// /*cef(optional_param=domain_name,optional_param=factory)*/
        /// </summary>

        public bool RegisterSchemeHandlerFactory(string scheme_name,
        string domain_name,
        CefSchemeHandlerFactory factory)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(scheme_name);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(domain_name);
            v3.Ptr = factory.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_RegisterSchemeHandlerFactory_7, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 416

        // gen! bool ClearSchemeHandlerFactories()
        /// <summary>
        /// Clear all registered scheme handler factories. Returns false on error. This
        /// function may be called on any thread in the browser process.
        /// /*cef()*/
        /// </summary>

        public bool ClearSchemeHandlerFactories()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_ClearSchemeHandlerFactories_8, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 417

        // gen! void PurgePluginListCache(bool reload_pages)
        /// <summary>
        /// Tells all renderer processes associated with this context to throw away
        /// their plugin list cache. If |reload_pages| is true they will also reload
        /// all pages with plugins. CefRequestContextHandler::OnBeforePluginLoad may
        /// be called to rebuild the plugin list cache.
        /// /*cef()*/
        /// </summary>

        public void PurgePluginListCache(bool reload_pages)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = reload_pages ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_PurgePluginListCache_9, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 418

        // gen! bool HasPreference(const CefString& name)
        /// <summary>
        /// Returns true if a preference with the specified |name| exists. This method
        /// must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool HasPreference(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_HasPreference_10, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 419

        // gen! CefRefPtr<CefValue> GetPreference(const CefString& name)
        /// <summary>
        /// Returns the value for the preference with the specified |name|. Returns
        /// NULL if the preference does not exist. The returned object contains a copy
        /// of the underlying preference value and modifications to the returned object
        /// will not modify the underlying preference value. This method must be called
        /// on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public CefValue GetPreference(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetPreference_11, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 420

        // gen! CefRefPtr<CefDictionaryValue> GetAllPreferences(bool include_defaults)
        /// <summary>
        /// Returns all preferences as a dictionary. If |include_defaults| is true then
        /// preferences currently at their default value will be included. The returned
        /// object contains a copy of the underlying preference values and
        /// modifications to the returned object will not modify the underlying
        /// preference values. This method must be called on the browser process UI
        /// thread.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetAllPreferences(bool include_defaults)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = include_defaults ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetAllPreferences_12, out ret, ref v1);
            return new CefDictionaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 421

        // gen! bool CanSetPreference(const CefString& name)
        /// <summary>
        /// Returns true if the preference with the specified |name| can be modified
        /// using SetPreference. As one example preferences set via the command-line
        /// usually cannot be modified. This method must be called on the browser
        /// process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool CanSetPreference(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CanSetPreference_13, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 422

        // gen! bool SetPreference(const CefString& name,CefRefPtr<CefValue> value,CefString& error)
        /// <summary>
        /// Set the |value| associated with preference |name|. Returns true if the
        /// value is set successfully and false otherwise. If |value| is NULL the
        /// preference will be restored to its default value. If setting the preference
        /// fails then |error| will be populated with a detailed description of the
        /// problem. This method must be called on the browser process UI thread.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetPreference(string name,
        CefValue value,
        string error)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(error);
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_SetPreference_14, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 423

        // gen! void ClearCertificateExceptions(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Clears all certificate exceptions that were added as part of handling
        /// CefRequestHandler::OnCertificateError(). If you call this it is
        /// recommended that you also call CloseAllConnections() or you risk not
        /// being prompted again for server certificates if you reconnect quickly.
        /// If |callback| is non-NULL it will be executed on the UI thread after
        /// completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public void ClearCertificateExceptions(CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_ClearCertificateExceptions_15, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 424

        // gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Clears all active and idle connections that Chromium currently has.
        /// This is only recommended if you have released all other CEF objects but
        /// don't yet want to call CefShutdown(). If |callback| is non-NULL it will be
        /// executed on the UI thread after completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public void CloseAllConnections(CefCompletionCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CloseAllConnections_16, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 425

        // gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses.
        /// |callback| will be executed on the UI thread after completion.
        /// /*cef()*/
        /// </summary>

        public void ResolveHost(string origin,
        CefResolveCallback callback)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(origin);
            v2.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHost_17, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 426

        // gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses using
        /// cached data. |resolved_ips| will be populated with the list of resolved IP
        /// addresses or empty if no cached data is available. Returns ERR_NONE on
        /// success. This method must be called on the browser process IO thread.
        /// /*cef(default_retval=ERR_FAILED)*/
        /// </summary>

        public cef_errorcode_t ResolveHostCached(string origin,
        List<string> resolved_ips)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(origin);
            v2.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHostCached_18, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v2.Ptr, resolved_ips);
            return (cef_errorcode_t)ret.I32;

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 427

        // gen! CefRefPtr<CefRequestContext> GetGlobalContext()
        /// <summary>
        /// Returns the global context object.
        /// /*cef()*/
        /// </summary>

        public static CefRequestContext GetGlobalContext()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefRequestContext_S_GetGlobalContext_1, out ret);
            return new CefRequestContext(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 428

        // gen! CefRefPtr<CefRequestContext> CreateContext(const CefRequestContextSettings& settings,CefRefPtr<CefRequestContextHandler> handler)
        /// <summary>
        /// Creates a new context object with the specified |settings| and optional
        /// |handler|.
        /// /*cef(optional_param=handler)*/
        /// </summary>

        public static CefRequestContext CreateContext(CefRequestContextSettings settings,
        CefRequestContextHandler handler)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = settings.nativePtr;
            v2.Ptr = handler.nativePtr;

            Cef3Binder.MyCefMet_S_Call2(CefRequestContext_S_CreateContext_2, out ret, ref v1, ref v2);
            return new CefRequestContext(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 429

        // gen! CefRefPtr<CefRequestContext> CreateContext(CefRefPtr<CefRequestContext> other,CefRefPtr<CefRequestContextHandler> handler)
        /// <summary>
        /// Creates a new context object that shares storage with |other| and uses an
        /// optional |handler|.
        /// /*cef(capi_name=cef_create_context_shared,optional_param=handler)*/
        /// </summary>

        public static CefRequestContext CreateContext(CefRequestContext other,
        CefRequestContextHandler handler)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr;
            v2.Ptr = handler.nativePtr;

            Cef3Binder.MyCefMet_S_Call2(CefRequestContext_S_CreateContext_3, out ret, ref v1, ref v2);
            return new CefRequestContext(ret.Ptr);
        }
    }


    // [virtual] class CefResourceBundle
    //CsCallToNativeCodeGen::GenerateCsCode , 430
    /// <summary>
    /// Class used for retrieving resources from the resource bundle (*.pak) files
    /// loaded by CEF during startup or via the CefResourceBundleHandler returned
    /// from CefApp::GetResourceBundleHandler. See CefSettings for additional options
    /// related to resource bundle loading. The methods of this class may be called
    /// on any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefResourceBundle : IDisposable
    {
        const int _typeNAME = 26;
        const int CefResourceBundle_Release_0 = (_typeNAME << 16) | 0;
        const int CefResourceBundle_GetLocalizedString_1 = (_typeNAME << 16) | 1;
        const int CefResourceBundle_GetDataResource_2 = (_typeNAME << 16) | 2;
        const int CefResourceBundle_GetDataResourceForScale_3 = (_typeNAME << 16) | 3;
        //
        const int CefResourceBundle_S_GetGlobal_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefResourceBundle(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResourceBundle_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 431

        // gen! CefString GetLocalizedString(int string_id)
        /// <summary>
        /// CefResourceBundle methods.
        /// </summary>

        public string GetLocalizedString(int string_id)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)string_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResourceBundle_GetLocalizedString_1, out ret, ref v1);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 432

        // gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
        /// <summary>
        /// Retrieves the contents of the specified scale independent |resource_id|.
        /// If the value is found then |data| and |data_size| will be populated and
        /// this method will return true. If the value is not found then this method
        /// will return false. The returned |data| pointer will remain resident in
        /// memory and should not be freed. Include cef_pack_resources.h for a listing
        /// of valid resource ID values.
        /// /*cef()*/
        /// </summary>

        public bool GetDataResource(int resource_id,
        IntPtr data,
        ref uint data_size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)resource_id;
            v2.Ptr = data;
            v3.I32 = (int)data_size;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefResourceBundle_GetDataResource_2, out ret, ref v1, ref v2, ref v3);
            data = v2.Ptr;
            data_size = (uint)v3.I32;
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 433

        // gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
        /// <summary>
        /// Retrieves the contents of the specified |resource_id| nearest the scale
        /// factor |scale_factor|. Use a |scale_factor| value of SCALE_FACTOR_NONE for
        /// scale independent resources or call GetDataResource instead. If the value
        /// is found then |data| and |data_size| will be populated and this method will
        /// return true. If the value is not found then this method will return false.
        /// The returned |data| pointer will remain resident in memory and should not
        /// be freed. Include cef_pack_resources.h for a listing of valid resource ID
        /// values.
        /// /*cef()*/
        /// </summary>

        public bool GetDataResourceForScale(int resource_id,
        cef_scale_factor_t scale_factor,
        IntPtr data,
        ref uint data_size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.I32 = (int)resource_id;
            v2.I32 = (int)scale_factor;
            v3.Ptr = data;
            v4.I32 = (int)data_size;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefResourceBundle_GetDataResourceForScale_3, out ret, ref v1, ref v2, ref v3, ref v4);
            data = v3.Ptr;
            data_size = (uint)v4.I32;
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 434

        // gen! CefRefPtr<CefResourceBundle> GetGlobal()
        /// <summary>
        /// Returns the global resource bundle instance.
        /// /*cef()*/
        /// </summary>

        public static CefResourceBundle GetGlobal()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefResourceBundle_S_GetGlobal_1, out ret);
            return new CefResourceBundle(ret.Ptr);
        }
    }


    // [virtual] class CefResponse
    //CsCallToNativeCodeGen::GenerateCsCode , 435
    /// <summary>
    /// Class used to represent a web response. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefResponse : IDisposable
    {
        const int _typeNAME = 27;
        const int CefResponse_Release_0 = (_typeNAME << 16) | 0;
        const int CefResponse_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefResponse_GetError_2 = (_typeNAME << 16) | 2;
        const int CefResponse_SetError_3 = (_typeNAME << 16) | 3;
        const int CefResponse_GetStatus_4 = (_typeNAME << 16) | 4;
        const int CefResponse_SetStatus_5 = (_typeNAME << 16) | 5;
        const int CefResponse_GetStatusText_6 = (_typeNAME << 16) | 6;
        const int CefResponse_SetStatusText_7 = (_typeNAME << 16) | 7;
        const int CefResponse_GetMimeType_8 = (_typeNAME << 16) | 8;
        const int CefResponse_SetMimeType_9 = (_typeNAME << 16) | 9;
        const int CefResponse_GetHeader_10 = (_typeNAME << 16) | 10;
        const int CefResponse_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        const int CefResponse_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        //
        const int CefResponse_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefResponse(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 436

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefResponse methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_IsReadOnly_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 437

        // gen! cef_errorcode_t GetError()
        /// <summary>
        /// Get the response error code. Returns ERR_NONE if there was no error.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>

        public cef_errorcode_t GetError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetError_2, out ret);
            return (cef_errorcode_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 438

        // gen! void SetError(cef_errorcode_t error)
        /// <summary>
        /// Set the response error code. This can be used by custom scheme handlers
        /// to return errors during initial request processing.
        /// /*cef()*/
        /// </summary>

        public void SetError(cef_errorcode_t error)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)error;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetError_3, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 439

        // gen! int GetStatus()
        /// <summary>
        /// Get the response status code.
        /// /*cef()*/
        /// </summary>

        public int GetStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatus_4, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 440

        // gen! void SetStatus(int status)
        /// <summary>
        /// Set the response status code.
        /// /*cef()*/
        /// </summary>

        public void SetStatus(int status)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)status;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatus_5, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 441

        // gen! CefString GetStatusText()
        /// <summary>
        /// Get the response status text.
        /// /*cef()*/
        /// </summary>

        public string GetStatusText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatusText_6, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 442

        // gen! void SetStatusText(const CefString& statusText)
        /// <summary>
        /// Set the response status text.
        /// /*cef()*/
        /// </summary>

        public void SetStatusText(string statusText)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(statusText);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatusText_7, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 443

        // gen! CefString GetMimeType()
        /// <summary>
        /// Get the response mime type.
        /// /*cef()*/
        /// </summary>

        public string GetMimeType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetMimeType_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 444

        // gen! void SetMimeType(const CefString& mimeType)
        /// <summary>
        /// Set the response mime type.
        /// /*cef()*/
        /// </summary>

        public void SetMimeType(string mimeType)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(mimeType);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetMimeType_9, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 445

        // gen! CefString GetHeader(const CefString& name)
        /// <summary>
        /// Get the value for the specified response header field.
        /// /*cef()*/
        /// </summary>

        public string GetHeader(string name)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeader_10, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 446

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get all response header fields.
        /// /*cef()*/
        /// </summary>

        public void GetHeaderMap(HeaderMap headerMap)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeaderMap_11, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 447

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set all response header fields.
        /// /*cef()*/
        /// </summary>

        public void SetHeaderMap(HeaderMap headerMap)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetHeaderMap_12, out ret, ref v1);

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 448

        // gen! CefRefPtr<CefResponse> Create()
        /// <summary>
        /// Create a new CefResponse object.
        /// /*cef()*/
        /// </summary>

        public static CefResponse Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefResponse_S_Create_1, out ret);
            return new CefResponse(ret.Ptr);
        }
    }

}