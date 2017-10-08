//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    //CsStructModuleCodeGen:: GenerateCsStructClass ,372
    public struct CefAccessibilityHandler
    {
        public const int _typeNAME = 56;
        internal IntPtr nativePtr;
        public CefAccessibilityHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefAccessibilityHandlerExt_OnAccessibilityTreeChange_1 = 1;
        public const int CefAccessibilityHandlerExt_OnAccessibilityLocationChange_2 = 2;
        //gen! void OnAccessibilityTreeChange(CefRefPtr<CefValue> value)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,373
        /// <summary>
        /// Called after renderer process sends accessibility tree changes to the
        /// browser process.
        /// /*cef()*/
        /// </summary>
        public struct OnAccessibilityTreeChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnAccessibilityTreeChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnAccessibilityTreeChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnAccessibilityTreeChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefValue value()
            {
                unsafe
                {
                    return new CefValue(((OnAccessibilityTreeChangeNativeArgs*)this.nativePtr)->value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,374
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnAccessibilityTreeChangeNativeArgs
        {
            public int argFlags;
            public IntPtr value;
        }
        //gen! void OnAccessibilityLocationChange(CefRefPtr<CefValue> value)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,375
        /// <summary>
        /// Called after renderer process sends accessibility location changes to the
        /// browser process.
        /// /*cef()*/
        /// </summary>
        public struct OnAccessibilityLocationChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnAccessibilityLocationChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnAccessibilityLocationChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnAccessibilityLocationChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefValue value()
            {
                unsafe
                {
                    return new CefValue(((OnAccessibilityLocationChangeNativeArgs*)this.nativePtr)->value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,376
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnAccessibilityLocationChangeNativeArgs
        {
            public int argFlags;
            public IntPtr value;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,377
            /// <summary>
            /// Called after renderer process sends accessibility tree changes to the
            /// browser process.
            /// /*cef()*/
            /// </summary>
            void OnAccessibilityTreeChange(OnAccessibilityTreeChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,378
            /// <summary>
            /// Called after renderer process sends accessibility location changes to the
            /// browser process.
            /// /*cef()*/
            /// </summary>
            void OnAccessibilityLocationChange(OnAccessibilityLocationChangeArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,379
            /// <summary>
            /// Called after renderer process sends accessibility tree changes to the
            /// browser process.
            /// /*cef()*/
            /// </summary>
            void OnAccessibilityTreeChange(CefValue value);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,380
            /// <summary>
            /// Called after renderer process sends accessibility location changes to the
            /// browser process.
            /// /*cef()*/
            /// </summary>
            void OnAccessibilityLocationChange(CefValue value);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,381
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,382
                case CefAccessibilityHandlerExt_OnAccessibilityTreeChange_1:
                    {
                        var args = new OnAccessibilityTreeChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnAccessibilityTreeChange(args);
                        }
                        if (i1 != null)
                        {
                            OnAccessibilityTreeChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,383
                case CefAccessibilityHandlerExt_OnAccessibilityLocationChange_2:
                    {
                        var args = new OnAccessibilityLocationChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnAccessibilityLocationChange(args);
                        }
                        if (i1 != null)
                        {
                            OnAccessibilityLocationChange(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,384
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefAccessibilityHandlerExt_OnAccessibilityTreeChange_1:
                    i0.OnAccessibilityTreeChange(new OnAccessibilityTreeChangeArgs(nativeArgPtr));
                    break;
                case CefAccessibilityHandlerExt_OnAccessibilityLocationChange_2:
                    i0.OnAccessibilityLocationChange(new OnAccessibilityLocationChangeArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,385
        public static void OnAccessibilityTreeChange(I1 i1, OnAccessibilityTreeChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,386
            i1.OnAccessibilityTreeChange(args.value());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,387
        public static void OnAccessibilityLocationChange(I1 i1, OnAccessibilityLocationChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,388
            i1.OnAccessibilityLocationChange(args.value());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,389
    public struct CefBrowserProcessHandler
    {
        public const int _typeNAME = 57;
        internal IntPtr nativePtr;
        public CefBrowserProcessHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefBrowserProcessHandlerExt_OnContextInitialized_1 = 1;
        public const int CefBrowserProcessHandlerExt_OnBeforeChildProcessLaunch_2 = 2;
        public const int CefBrowserProcessHandlerExt_OnRenderProcessThreadCreated_3 = 3;
        public const int CefBrowserProcessHandlerExt_GetPrintHandler_4 = 4;
        public const int CefBrowserProcessHandlerExt_OnScheduleMessagePumpWork_5 = 5;
        //gen! void OnContextInitialized()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,390
        /// <summary>
        /// Called on the browser process UI thread immediately after the CEF context
        /// has been initialized.
        /// /*cef()*/
        /// </summary>
        public struct OnContextInitializedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnContextInitializedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnContextInitializedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnContextInitializedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,391
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnContextInitializedNativeArgs
        {
            public int argFlags;
        }
        //gen! void OnBeforeChildProcessLaunch(CefRefPtr<CefCommandLine> command_line)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,392
        /// <summary>
        /// Called before a child process is launched. Will be called on the browser
        /// process UI thread when launching a render process and on the browser
        /// process IO thread when launching a GPU or plugin process. Provides an
        /// opportunity to modify the child process command line. Do not keep a
        /// reference to |command_line| outside of this method.
        /// /*cef()*/
        /// </summary>
        public struct OnBeforeChildProcessLaunchArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeChildProcessLaunchArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeChildProcessLaunchNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeChildProcessLaunchNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefCommandLine command_line()
            {
                unsafe
                {
                    return new CefCommandLine(((OnBeforeChildProcessLaunchNativeArgs*)this.nativePtr)->command_line);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,393
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeChildProcessLaunchNativeArgs
        {
            public int argFlags;
            public IntPtr command_line;
        }
        //gen! void OnRenderProcessThreadCreated(CefRefPtr<CefListValue> extra_info)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,394
        /// <summary>
        /// Called on the browser process IO thread after the main thread has been
        /// created for a new render process. Provides an opportunity to specify extra
        /// information that will be passed to
        /// CefRenderProcessHandler::OnRenderThreadCreated() in the render process. Do
        /// not keep a reference to |extra_info| outside of this method.
        /// /*cef()*/
        /// </summary>
        public struct OnRenderProcessThreadCreatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRenderProcessThreadCreatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRenderProcessThreadCreatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRenderProcessThreadCreatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefListValue extra_info()
            {
                unsafe
                {
                    return new CefListValue(((OnRenderProcessThreadCreatedNativeArgs*)this.nativePtr)->extra_info);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,395
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnRenderProcessThreadCreatedNativeArgs
        {
            public int argFlags;
            public IntPtr extra_info;
        }
        //gen! CefRefPtr<CefPrintHandler> GetPrintHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,396
        /// <summary>
        /// Return the handler for printing on Linux. If a print handler is not
        /// provided then printing will not be supported on the Linux platform.
        /// /*cef()*/
        /// </summary>
        public struct GetPrintHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetPrintHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetPrintHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetPrintHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetPrintHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,397
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetPrintHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! void OnScheduleMessagePumpWork(int64 delay_ms)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,398
        /// <summary>
        /// Called from any thread when work has been scheduled for the browser process
        /// main (UI) thread. This callback is used in combination with CefSettings.
        /// external_message_pump and CefDoMessageLoopWork() in cases where the CEF
        /// message loop must be integrated into an existing application message loop
        /// (see additional comments and warnings on CefDoMessageLoopWork). This
        /// callback should schedule a CefDoMessageLoopWork() call to happen on the
        /// main (UI) thread. |delay_ms| is the requested delay in milliseconds. If
        /// |delay_ms| is <= 0 then the call should happen reasonably soon. If
        /// |delay_ms| is > 0 then the call should be scheduled to happen after the
        /// specified delay and any currently pending scheduled call should be
        /// cancelled.
        /// /*cef()*/
        /// </summary>
        public struct OnScheduleMessagePumpWorkArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnScheduleMessagePumpWorkArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnScheduleMessagePumpWorkNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnScheduleMessagePumpWorkNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public long delay_ms()
            {
                unsafe
                {
                    return ((OnScheduleMessagePumpWorkNativeArgs*)this.nativePtr)->delay_ms;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,399
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnScheduleMessagePumpWorkNativeArgs
        {
            public int argFlags;
            public long delay_ms;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,400
            /// <summary>
            /// Called on the browser process UI thread immediately after the CEF context
            /// has been initialized.
            /// /*cef()*/
            /// </summary>
            void OnContextInitialized(OnContextInitializedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,401
            /// <summary>
            /// Called before a child process is launched. Will be called on the browser
            /// process UI thread when launching a render process and on the browser
            /// process IO thread when launching a GPU or plugin process. Provides an
            /// opportunity to modify the child process command line. Do not keep a
            /// reference to |command_line| outside of this method.
            /// /*cef()*/
            /// </summary>
            void OnBeforeChildProcessLaunch(OnBeforeChildProcessLaunchArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,402
            /// <summary>
            /// Called on the browser process IO thread after the main thread has been
            /// created for a new render process. Provides an opportunity to specify extra
            /// information that will be passed to
            /// CefRenderProcessHandler::OnRenderThreadCreated() in the render process. Do
            /// not keep a reference to |extra_info| outside of this method.
            /// /*cef()*/
            /// </summary>
            void OnRenderProcessThreadCreated(OnRenderProcessThreadCreatedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,403
            /// <summary>
            /// Return the handler for printing on Linux. If a print handler is not
            /// provided then printing will not be supported on the Linux platform.
            /// /*cef()*/
            /// </summary>
            void GetPrintHandler(GetPrintHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,404
            /// <summary>
            /// Called from any thread when work has been scheduled for the browser process
            /// main (UI) thread. This callback is used in combination with CefSettings.
            /// external_message_pump and CefDoMessageLoopWork() in cases where the CEF
            /// message loop must be integrated into an existing application message loop
            /// (see additional comments and warnings on CefDoMessageLoopWork). This
            /// callback should schedule a CefDoMessageLoopWork() call to happen on the
            /// main (UI) thread. |delay_ms| is the requested delay in milliseconds. If
            /// |delay_ms| is <= 0 then the call should happen reasonably soon. If
            /// |delay_ms| is > 0 then the call should be scheduled to happen after the
            /// specified delay and any currently pending scheduled call should be
            /// cancelled.
            /// /*cef()*/
            /// </summary>
            void OnScheduleMessagePumpWork(OnScheduleMessagePumpWorkArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,405
            /// <summary>
            /// Called on the browser process UI thread immediately after the CEF context
            /// has been initialized.
            /// /*cef()*/
            /// </summary>
            void OnContextInitialized();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,406
            /// <summary>
            /// Called before a child process is launched. Will be called on the browser
            /// process UI thread when launching a render process and on the browser
            /// process IO thread when launching a GPU or plugin process. Provides an
            /// opportunity to modify the child process command line. Do not keep a
            /// reference to |command_line| outside of this method.
            /// /*cef()*/
            /// </summary>
            void OnBeforeChildProcessLaunch(CefCommandLine command_line);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,407
            /// <summary>
            /// Called on the browser process IO thread after the main thread has been
            /// created for a new render process. Provides an opportunity to specify extra
            /// information that will be passed to
            /// CefRenderProcessHandler::OnRenderThreadCreated() in the render process. Do
            /// not keep a reference to |extra_info| outside of this method.
            /// /*cef()*/
            /// </summary>
            void OnRenderProcessThreadCreated(CefListValue extra_info);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,408
            /// <summary>
            /// Return the handler for printing on Linux. If a print handler is not
            /// provided then printing will not be supported on the Linux platform.
            /// /*cef()*/
            /// </summary>
            CefPrintHandler GetPrintHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,409
            /// <summary>
            /// Called from any thread when work has been scheduled for the browser process
            /// main (UI) thread. This callback is used in combination with CefSettings.
            /// external_message_pump and CefDoMessageLoopWork() in cases where the CEF
            /// message loop must be integrated into an existing application message loop
            /// (see additional comments and warnings on CefDoMessageLoopWork). This
            /// callback should schedule a CefDoMessageLoopWork() call to happen on the
            /// main (UI) thread. |delay_ms| is the requested delay in milliseconds. If
            /// |delay_ms| is <= 0 then the call should happen reasonably soon. If
            /// |delay_ms| is > 0 then the call should be scheduled to happen after the
            /// specified delay and any currently pending scheduled call should be
            /// cancelled.
            /// /*cef()*/
            /// </summary>
            void OnScheduleMessagePumpWork(long delay_ms);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,410
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,411
                case CefBrowserProcessHandlerExt_OnContextInitialized_1:
                    {
                        var args = new OnContextInitializedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnContextInitialized(args);
                        }
                        if (i1 != null)
                        {
                            OnContextInitialized(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,412
                case CefBrowserProcessHandlerExt_OnBeforeChildProcessLaunch_2:
                    {
                        var args = new OnBeforeChildProcessLaunchArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeChildProcessLaunch(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeChildProcessLaunch(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,413
                case CefBrowserProcessHandlerExt_OnRenderProcessThreadCreated_3:
                    {
                        var args = new OnRenderProcessThreadCreatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRenderProcessThreadCreated(args);
                        }
                        if (i1 != null)
                        {
                            OnRenderProcessThreadCreated(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,414
                case CefBrowserProcessHandlerExt_GetPrintHandler_4:
                    {
                        var args = new GetPrintHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetPrintHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetPrintHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,415
                case CefBrowserProcessHandlerExt_OnScheduleMessagePumpWork_5:
                    {
                        var args = new OnScheduleMessagePumpWorkArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnScheduleMessagePumpWork(args);
                        }
                        if (i1 != null)
                        {
                            OnScheduleMessagePumpWork(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,416
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefBrowserProcessHandlerExt_OnContextInitialized_1:
                    i0.OnContextInitialized(new OnContextInitializedArgs(nativeArgPtr));
                    break;
                case CefBrowserProcessHandlerExt_OnBeforeChildProcessLaunch_2:
                    i0.OnBeforeChildProcessLaunch(new OnBeforeChildProcessLaunchArgs(nativeArgPtr));
                    break;
                case CefBrowserProcessHandlerExt_OnRenderProcessThreadCreated_3:
                    i0.OnRenderProcessThreadCreated(new OnRenderProcessThreadCreatedArgs(nativeArgPtr));
                    break;
                case CefBrowserProcessHandlerExt_GetPrintHandler_4:
                    i0.GetPrintHandler(new GetPrintHandlerArgs(nativeArgPtr));
                    break;
                case CefBrowserProcessHandlerExt_OnScheduleMessagePumpWork_5:
                    i0.OnScheduleMessagePumpWork(new OnScheduleMessagePumpWorkArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,417
        public static void OnContextInitialized(I1 i1, OnContextInitializedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,418
            i1.OnContextInitialized();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,419
        public static void OnBeforeChildProcessLaunch(I1 i1, OnBeforeChildProcessLaunchArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,420
            i1.OnBeforeChildProcessLaunch(args.command_line());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,421
        public static void OnRenderProcessThreadCreated(I1 i1, OnRenderProcessThreadCreatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,422
            i1.OnRenderProcessThreadCreated(args.extra_info());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,423
        public static void GetPrintHandler(I1 i1, GetPrintHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,424
            i1.GetPrintHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,425
        public static void OnScheduleMessagePumpWork(I1 i1, OnScheduleMessagePumpWorkArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,426
            i1.OnScheduleMessagePumpWork(args.delay_ms());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,427
    public struct CefContextMenuHandler
    {
        public const int _typeNAME = 58;
        internal IntPtr nativePtr;
        public CefContextMenuHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefContextMenuHandlerExt_OnBeforeContextMenu_1 = 1;
        public const int CefContextMenuHandlerExt_RunContextMenu_2 = 2;
        public const int CefContextMenuHandlerExt_OnContextMenuCommand_3 = 3;
        public const int CefContextMenuHandlerExt_OnContextMenuDismissed_4 = 4;
        //gen! void OnBeforeContextMenu(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,CefRefPtr<CefMenuModel> model)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,428
        /// <summary>
        /// Called before a context menu is displayed. |params| provides information
        /// about the context menu state. |model| initially contains the default
        /// context menu. The |model| can be cleared to show no context menu or
        /// modified to show a custom menu. Do not keep references to |params| or
        /// |model| outside of this callback.
        /// /*cef()*/
        /// </summary>
        public struct OnBeforeContextMenuArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeContextMenuArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeContextMenuNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeContextMenuNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeContextMenuNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnBeforeContextMenuNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefContextMenuParams _params()
            {
                unsafe
                {
                    return new CefContextMenuParams(((OnBeforeContextMenuNativeArgs*)this.nativePtr)->_params);
                }
            }
            public CefMenuModel model()
            {
                unsafe
                {
                    return new CefMenuModel(((OnBeforeContextMenuNativeArgs*)this.nativePtr)->model);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,429
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeContextMenuNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr _params;
            public IntPtr model;
        }
        //gen! bool RunContextMenu(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,CefRefPtr<CefMenuModel> model,CefRefPtr<CefRunContextMenuCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,430
        /// <summary>
        /// Called to allow custom display of the context menu. |params| provides
        /// information about the context menu state. |model| contains the context menu
        /// model resulting from OnBeforeContextMenu. For custom display return true
        /// and execute |callback| either synchronously or asynchronously with the
        /// selected command ID. For default display return false. Do not keep
        /// references to |params| or |model| outside of this callback.
        /// /*cef()*/
        /// </summary>
        public struct RunContextMenuArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal RunContextMenuArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((RunContextMenuNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((RunContextMenuNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((RunContextMenuNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((RunContextMenuNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((RunContextMenuNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefContextMenuParams _params()
            {
                unsafe
                {
                    return new CefContextMenuParams(((RunContextMenuNativeArgs*)this.nativePtr)->_params);
                }
            }
            public CefMenuModel model()
            {
                unsafe
                {
                    return new CefMenuModel(((RunContextMenuNativeArgs*)this.nativePtr)->model);
                }
            }
            public CefRunContextMenuCallback callback()
            {
                unsafe
                {
                    return new CefRunContextMenuCallback(((RunContextMenuNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,431
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct RunContextMenuNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr _params;
            public IntPtr model;
            public IntPtr callback;
        }
        //gen! bool OnContextMenuCommand(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,int command_id,EventFlags event_flags)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,432
        /// <summary>
        /// Called to execute a command selected from the context menu. Return true if
        /// the command was handled or false for the default implementation. See
        /// cef_menu_id_t for the command ids that have default implementations. All
        /// user-defined command ids should be between MENU_ID_USER_FIRST and
        /// MENU_ID_USER_LAST. |params| will have the same values as what was passed to
        /// OnBeforeContextMenu(). Do not keep a reference to |params| outside of this
        /// callback.
        /// /*cef()*/
        /// </summary>
        public struct OnContextMenuCommandArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnContextMenuCommandArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnContextMenuCommandNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnContextMenuCommandNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnContextMenuCommandNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnContextMenuCommandNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnContextMenuCommandNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefContextMenuParams _params()
            {
                unsafe
                {
                    return new CefContextMenuParams(((OnContextMenuCommandNativeArgs*)this.nativePtr)->_params);
                }
            }
            public int command_id()
            {
                unsafe
                {
                    return ((OnContextMenuCommandNativeArgs*)this.nativePtr)->command_id;
                }
            }
            public cef_event_flags_t event_flags()
            {
                unsafe
                {
                    return (cef_event_flags_t)(((OnContextMenuCommandNativeArgs*)this.nativePtr)->event_flags);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,433
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnContextMenuCommandNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr _params;
            public int command_id;
            public cef_event_flags_t event_flags;
        }
        //gen! void OnContextMenuDismissed(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,434
        /// <summary>
        /// Called when the context menu is dismissed irregardless of whether the menu
        /// was empty or a command was selected.
        /// /*cef()*/
        /// </summary>
        public struct OnContextMenuDismissedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnContextMenuDismissedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnContextMenuDismissedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnContextMenuDismissedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnContextMenuDismissedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnContextMenuDismissedNativeArgs*)this.nativePtr)->frame);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,435
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnContextMenuDismissedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,436
            /// <summary>
            /// Called before a context menu is displayed. |params| provides information
            /// about the context menu state. |model| initially contains the default
            /// context menu. The |model| can be cleared to show no context menu or
            /// modified to show a custom menu. Do not keep references to |params| or
            /// |model| outside of this callback.
            /// /*cef()*/
            /// </summary>
            void OnBeforeContextMenu(OnBeforeContextMenuArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,437
            /// <summary>
            /// Called to allow custom display of the context menu. |params| provides
            /// information about the context menu state. |model| contains the context menu
            /// model resulting from OnBeforeContextMenu. For custom display return true
            /// and execute |callback| either synchronously or asynchronously with the
            /// selected command ID. For default display return false. Do not keep
            /// references to |params| or |model| outside of this callback.
            /// /*cef()*/
            /// </summary>
            void RunContextMenu(RunContextMenuArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,438
            /// <summary>
            /// Called to execute a command selected from the context menu. Return true if
            /// the command was handled or false for the default implementation. See
            /// cef_menu_id_t for the command ids that have default implementations. All
            /// user-defined command ids should be between MENU_ID_USER_FIRST and
            /// MENU_ID_USER_LAST. |params| will have the same values as what was passed to
            /// OnBeforeContextMenu(). Do not keep a reference to |params| outside of this
            /// callback.
            /// /*cef()*/
            /// </summary>
            void OnContextMenuCommand(OnContextMenuCommandArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,439
            /// <summary>
            /// Called when the context menu is dismissed irregardless of whether the menu
            /// was empty or a command was selected.
            /// /*cef()*/
            /// </summary>
            void OnContextMenuDismissed(OnContextMenuDismissedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,440
            /// <summary>
            /// Called before a context menu is displayed. |params| provides information
            /// about the context menu state. |model| initially contains the default
            /// context menu. The |model| can be cleared to show no context menu or
            /// modified to show a custom menu. Do not keep references to |params| or
            /// |model| outside of this callback.
            /// /*cef()*/
            /// </summary>
            void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams _params, CefMenuModel model);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,441
            /// <summary>
            /// Called to allow custom display of the context menu. |params| provides
            /// information about the context menu state. |model| contains the context menu
            /// model resulting from OnBeforeContextMenu. For custom display return true
            /// and execute |callback| either synchronously or asynchronously with the
            /// selected command ID. For default display return false. Do not keep
            /// references to |params| or |model| outside of this callback.
            /// /*cef()*/
            /// </summary>
            bool RunContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams _params, CefMenuModel model, CefRunContextMenuCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,442
            /// <summary>
            /// Called to execute a command selected from the context menu. Return true if
            /// the command was handled or false for the default implementation. See
            /// cef_menu_id_t for the command ids that have default implementations. All
            /// user-defined command ids should be between MENU_ID_USER_FIRST and
            /// MENU_ID_USER_LAST. |params| will have the same values as what was passed to
            /// OnBeforeContextMenu(). Do not keep a reference to |params| outside of this
            /// callback.
            /// /*cef()*/
            /// </summary>
            bool OnContextMenuCommand(CefBrowser browser, CefFrame frame, CefContextMenuParams _params, int command_id, cef_event_flags_t event_flags);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,443
            /// <summary>
            /// Called when the context menu is dismissed irregardless of whether the menu
            /// was empty or a command was selected.
            /// /*cef()*/
            /// </summary>
            void OnContextMenuDismissed(CefBrowser browser, CefFrame frame);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,444
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,445
                case CefContextMenuHandlerExt_OnBeforeContextMenu_1:
                    {
                        var args = new OnBeforeContextMenuArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeContextMenu(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeContextMenu(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,446
                case CefContextMenuHandlerExt_RunContextMenu_2:
                    {
                        var args = new RunContextMenuArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.RunContextMenu(args);
                        }
                        if (i1 != null)
                        {
                            RunContextMenu(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,447
                case CefContextMenuHandlerExt_OnContextMenuCommand_3:
                    {
                        var args = new OnContextMenuCommandArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnContextMenuCommand(args);
                        }
                        if (i1 != null)
                        {
                            OnContextMenuCommand(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,448
                case CefContextMenuHandlerExt_OnContextMenuDismissed_4:
                    {
                        var args = new OnContextMenuDismissedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnContextMenuDismissed(args);
                        }
                        if (i1 != null)
                        {
                            OnContextMenuDismissed(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,449
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefContextMenuHandlerExt_OnBeforeContextMenu_1:
                    i0.OnBeforeContextMenu(new OnBeforeContextMenuArgs(nativeArgPtr));
                    break;
                case CefContextMenuHandlerExt_RunContextMenu_2:
                    i0.RunContextMenu(new RunContextMenuArgs(nativeArgPtr));
                    break;
                case CefContextMenuHandlerExt_OnContextMenuCommand_3:
                    i0.OnContextMenuCommand(new OnContextMenuCommandArgs(nativeArgPtr));
                    break;
                case CefContextMenuHandlerExt_OnContextMenuDismissed_4:
                    i0.OnContextMenuDismissed(new OnContextMenuDismissedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,450
        public static void OnBeforeContextMenu(I1 i1, OnBeforeContextMenuArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,451
            i1.OnBeforeContextMenu(args.browser(),
            args.frame(),
            args._params(),
            args.model());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,452
        public static void RunContextMenu(I1 i1, RunContextMenuArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,453
            args.myext_setRetValue(i1.RunContextMenu(args.browser(),
            args.frame(),
            args._params(),
            args.model(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,454
        public static void OnContextMenuCommand(I1 i1, OnContextMenuCommandArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,455
            args.myext_setRetValue(i1.OnContextMenuCommand(args.browser(),
            args.frame(),
            args._params(),
            args.command_id(),
            args.event_flags()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,456
        public static void OnContextMenuDismissed(I1 i1, OnContextMenuDismissedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,457
            i1.OnContextMenuDismissed(args.browser(),
            args.frame());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,458
    public struct CefDialogHandler
    {
        public const int _typeNAME = 59;
        internal IntPtr nativePtr;
        public CefDialogHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefDialogHandlerExt_OnFileDialog_1 = 1;
        //gen! bool OnFileDialog(CefRefPtr<CefBrowser> browser,FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefFileDialogCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,459
        /// <summary>
        /// Called to run a file chooser dialog. |mode| represents the type of dialog
        /// to display. |title| to the title to be used for the dialog and may be empty
        /// to show the default title ("Open" or "Save" depending on the mode).
        /// |default_file_path| is the path with optional directory and/or file name
        /// component that should be initially selected in the dialog. |accept_filters|
        /// are used to restrict the selectable file types and may any combination of
        /// (a) valid lower-cased MIME types (e.g. "text/*" or "image/*"),
        /// (b) individual file extensions (e.g. ".txt" or ".png"), or (c) combined
        /// description and file extension delimited using "|" and ";" (e.g.
        /// "Image Types|.png;.gif;.jpg"). |selected_accept_filter| is the 0-based
        /// index of the filter that should be selected by default. To display a custom
        /// dialog return true and execute |callback| either inline or at a later time.
        /// To display the default dialog return false.
        /// /*cef(optional_param=title,optional_param=default_file_path,optional_param=accept_filters,index_param=selected_accept_filter)*/
        /// </summary>
        public struct OnFileDialogArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnFileDialogArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnFileDialogNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnFileDialogNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnFileDialogNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnFileDialogNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_file_dialog_mode_t mode()
            {
                unsafe
                {
                    return (cef_file_dialog_mode_t)(((OnFileDialogNativeArgs*)this.nativePtr)->mode);
                }
            }
            public string title()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnFileDialogNativeArgs*)this.nativePtr)->title);
                }
            }
            public string default_file_path()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnFileDialogNativeArgs*)this.nativePtr)->default_file_path);
                }
            }
            public List<string> accept_filters()
            {
                unsafe
                {
                    List<string> outputlist = new List<string>();
                    Cef3Binder.CopyStdStringList(((OnFileDialogNativeArgs*)this.nativePtr)->accept_filters, outputlist);
                    return outputlist;
                }
            }
            public int selected_accept_filter()
            {
                unsafe
                {
                    return ((OnFileDialogNativeArgs*)this.nativePtr)->selected_accept_filter;
                }
            }
            public CefFileDialogCallback callback()
            {
                unsafe
                {
                    return new CefFileDialogCallback(((OnFileDialogNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,460
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnFileDialogNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public cef_file_dialog_mode_t mode;
            public IntPtr title;
            public IntPtr default_file_path;
            public IntPtr accept_filters;
            public int selected_accept_filter;
            public IntPtr callback;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,461
            /// <summary>
            /// Called to run a file chooser dialog. |mode| represents the type of dialog
            /// to display. |title| to the title to be used for the dialog and may be empty
            /// to show the default title ("Open" or "Save" depending on the mode).
            /// |default_file_path| is the path with optional directory and/or file name
            /// component that should be initially selected in the dialog. |accept_filters|
            /// are used to restrict the selectable file types and may any combination of
            /// (a) valid lower-cased MIME types (e.g. "text/*" or "image/*"),
            /// (b) individual file extensions (e.g. ".txt" or ".png"), or (c) combined
            /// description and file extension delimited using "|" and ";" (e.g.
            /// "Image Types|.png;.gif;.jpg"). |selected_accept_filter| is the 0-based
            /// index of the filter that should be selected by default. To display a custom
            /// dialog return true and execute |callback| either inline or at a later time.
            /// To display the default dialog return false.
            /// /*cef(optional_param=title,optional_param=default_file_path,optional_param=accept_filters,index_param=selected_accept_filter)*/
            /// </summary>
            void OnFileDialog(OnFileDialogArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,462
            /// <summary>
            /// Called to run a file chooser dialog. |mode| represents the type of dialog
            /// to display. |title| to the title to be used for the dialog and may be empty
            /// to show the default title ("Open" or "Save" depending on the mode).
            /// |default_file_path| is the path with optional directory and/or file name
            /// component that should be initially selected in the dialog. |accept_filters|
            /// are used to restrict the selectable file types and may any combination of
            /// (a) valid lower-cased MIME types (e.g. "text/*" or "image/*"),
            /// (b) individual file extensions (e.g. ".txt" or ".png"), or (c) combined
            /// description and file extension delimited using "|" and ";" (e.g.
            /// "Image Types|.png;.gif;.jpg"). |selected_accept_filter| is the 0-based
            /// index of the filter that should be selected by default. To display a custom
            /// dialog return true and execute |callback| either inline or at a later time.
            /// To display the default dialog return false.
            /// /*cef(optional_param=title,optional_param=default_file_path,optional_param=accept_filters,index_param=selected_accept_filter)*/
            /// </summary>
            bool OnFileDialog(CefBrowser browser, cef_file_dialog_mode_t mode, string title, string default_file_path, List<string> accept_filters, int selected_accept_filter, CefFileDialogCallback callback);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,463
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,464
                case CefDialogHandlerExt_OnFileDialog_1:
                    {
                        var args = new OnFileDialogArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnFileDialog(args);
                        }
                        if (i1 != null)
                        {
                            OnFileDialog(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,465
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefDialogHandlerExt_OnFileDialog_1:
                    i0.OnFileDialog(new OnFileDialogArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,466
        public static void OnFileDialog(I1 i1, OnFileDialogArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,467
            args.myext_setRetValue(i1.OnFileDialog(args.browser(),
            args.mode(),
            args.title(),
            args.default_file_path(),
            args.accept_filters(),
            args.selected_accept_filter(),
            args.callback()));
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,468
    public struct CefDisplayHandler
    {
        public const int _typeNAME = 60;
        internal IntPtr nativePtr;
        public CefDisplayHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefDisplayHandlerExt_OnAddressChange_1 = 1;
        public const int CefDisplayHandlerExt_OnTitleChange_2 = 2;
        public const int CefDisplayHandlerExt_OnFaviconURLChange_3 = 3;
        public const int CefDisplayHandlerExt_OnFullscreenModeChange_4 = 4;
        public const int CefDisplayHandlerExt_OnTooltip_5 = 5;
        public const int CefDisplayHandlerExt_OnStatusMessage_6 = 6;
        public const int CefDisplayHandlerExt_OnConsoleMessage_7 = 7;
        //gen! void OnAddressChange(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& url)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,469
        /// <summary>
        /// Called when a frame's address has changed.
        /// /*cef()*/
        /// </summary>
        public struct OnAddressChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnAddressChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnAddressChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnAddressChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnAddressChangeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnAddressChangeNativeArgs*)this.nativePtr)->frame);
                }
            }
            public string url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnAddressChangeNativeArgs*)this.nativePtr)->url);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,470
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnAddressChangeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr url;
        }
        //gen! void OnTitleChange(CefRefPtr<CefBrowser> browser,const CefString& title)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,471
        /// <summary>
        /// Called when the page title changes.
        /// /*cef(optional_param=title)*/
        /// </summary>
        public struct OnTitleChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnTitleChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnTitleChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnTitleChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnTitleChangeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string title()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnTitleChangeNativeArgs*)this.nativePtr)->title);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,472
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnTitleChangeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr title;
        }
        //gen! void OnFaviconURLChange(CefRefPtr<CefBrowser> browser,const std::vector<CefString>& icon_urls)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,473
        /// <summary>
        /// Called when the page icon changes.
        /// /*cef(optional_param=icon_urls)*/
        /// </summary>
        public struct OnFaviconURLChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnFaviconURLChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnFaviconURLChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnFaviconURLChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnFaviconURLChangeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public List<string> icon_urls()
            {
                unsafe
                {
                    List<string> outputlist = new List<string>();
                    Cef3Binder.CopyStdStringList(((OnFaviconURLChangeNativeArgs*)this.nativePtr)->icon_urls, outputlist);
                    return outputlist;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,474
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnFaviconURLChangeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr icon_urls;
        }
        //gen! void OnFullscreenModeChange(CefRefPtr<CefBrowser> browser,bool fullscreen)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,475
        /// <summary>
        /// Called when web content in the page has toggled fullscreen mode. If
        /// |fullscreen| is true the content will automatically be sized to fill the
        /// browser content area. If |fullscreen| is false the content will
        /// automatically return to its original size and position. The client is
        /// responsible for resizing the browser if desired.
        /// /*cef()*/
        /// </summary>
        public struct OnFullscreenModeChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnFullscreenModeChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnFullscreenModeChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnFullscreenModeChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnFullscreenModeChangeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public bool fullscreen()
            {
                unsafe
                {
                    return ((OnFullscreenModeChangeNativeArgs*)this.nativePtr)->fullscreen;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,476
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnFullscreenModeChangeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public bool fullscreen;
        }
        //gen! bool OnTooltip(CefRefPtr<CefBrowser> browser,CefString& text)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,477
        /// <summary>
        /// Called when the browser is about to display a tooltip. |text| contains the
        /// text that will be displayed in the tooltip. To handle the display of the
        /// tooltip yourself return true. Otherwise, you can optionally modify |text|
        /// and then return false to allow the browser to display the tooltip.
        /// When window rendering is disabled the application is responsible for
        /// drawing tooltips and the return value is ignored.
        /// /*cef(optional_param=text)*/
        /// </summary>
        public struct OnTooltipArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnTooltipArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnTooltipNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnTooltipNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnTooltipNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnTooltipNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string text()
            {
                unsafe
                {
                    IntPtr str_address = *(((OnTooltipNativeArgs*)this.nativePtr)->text);
                    return Cef3Binder.GetAsString(str_address);
                }
            }
            public void text(string value)
            {
                unsafe
                {
                    *(((OnTooltipNativeArgs*)this.nativePtr)->text) = Cef3Binder.MyCefCreateStringHolder(value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,478
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnTooltipNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr* text;
        }
        //gen! void OnStatusMessage(CefRefPtr<CefBrowser> browser,const CefString& value)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,479
        /// <summary>
        /// Called when the browser receives a status message. |value| contains the
        /// text that will be displayed in the status message.
        /// /*cef(optional_param=value)*/
        /// </summary>
        public struct OnStatusMessageArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnStatusMessageArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnStatusMessageNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnStatusMessageNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnStatusMessageNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string value()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnStatusMessageNativeArgs*)this.nativePtr)->value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,480
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnStatusMessageNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr value;
        }
        //gen! bool OnConsoleMessage(CefRefPtr<CefBrowser> browser,const CefString& message,const CefString& source,int line)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,481
        /// <summary>
        /// Called to display a console message. Return true to stop the message from
        /// being output to the console.
        /// /*cef(optional_param=message,optional_param=source)*/
        /// </summary>
        public struct OnConsoleMessageArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnConsoleMessageArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnConsoleMessageNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnConsoleMessageNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnConsoleMessageNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnConsoleMessageNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string message()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnConsoleMessageNativeArgs*)this.nativePtr)->message);
                }
            }
            public string source()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnConsoleMessageNativeArgs*)this.nativePtr)->source);
                }
            }
            public int line()
            {
                unsafe
                {
                    return ((OnConsoleMessageNativeArgs*)this.nativePtr)->line;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,482
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnConsoleMessageNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr message;
            public IntPtr source;
            public int line;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,483
            /// <summary>
            /// Called when a frame's address has changed.
            /// /*cef()*/
            /// </summary>
            void OnAddressChange(OnAddressChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,484
            /// <summary>
            /// Called when the page title changes.
            /// /*cef(optional_param=title)*/
            /// </summary>
            void OnTitleChange(OnTitleChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,485
            /// <summary>
            /// Called when the page icon changes.
            /// /*cef(optional_param=icon_urls)*/
            /// </summary>
            void OnFaviconURLChange(OnFaviconURLChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,486
            /// <summary>
            /// Called when web content in the page has toggled fullscreen mode. If
            /// |fullscreen| is true the content will automatically be sized to fill the
            /// browser content area. If |fullscreen| is false the content will
            /// automatically return to its original size and position. The client is
            /// responsible for resizing the browser if desired.
            /// /*cef()*/
            /// </summary>
            void OnFullscreenModeChange(OnFullscreenModeChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,487
            /// <summary>
            /// Called when the browser is about to display a tooltip. |text| contains the
            /// text that will be displayed in the tooltip. To handle the display of the
            /// tooltip yourself return true. Otherwise, you can optionally modify |text|
            /// and then return false to allow the browser to display the tooltip.
            /// When window rendering is disabled the application is responsible for
            /// drawing tooltips and the return value is ignored.
            /// /*cef(optional_param=text)*/
            /// </summary>
            void OnTooltip(OnTooltipArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,488
            /// <summary>
            /// Called when the browser receives a status message. |value| contains the
            /// text that will be displayed in the status message.
            /// /*cef(optional_param=value)*/
            /// </summary>
            void OnStatusMessage(OnStatusMessageArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,489
            /// <summary>
            /// Called to display a console message. Return true to stop the message from
            /// being output to the console.
            /// /*cef(optional_param=message,optional_param=source)*/
            /// </summary>
            void OnConsoleMessage(OnConsoleMessageArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,490
            /// <summary>
            /// Called when a frame's address has changed.
            /// /*cef()*/
            /// </summary>
            void OnAddressChange(CefBrowser browser, CefFrame frame, string url);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,491
            /// <summary>
            /// Called when the page title changes.
            /// /*cef(optional_param=title)*/
            /// </summary>
            void OnTitleChange(CefBrowser browser, string title);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,492
            /// <summary>
            /// Called when the page icon changes.
            /// /*cef(optional_param=icon_urls)*/
            /// </summary>
            void OnFaviconURLChange(CefBrowser browser, List<string> icon_urls);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,493
            /// <summary>
            /// Called when web content in the page has toggled fullscreen mode. If
            /// |fullscreen| is true the content will automatically be sized to fill the
            /// browser content area. If |fullscreen| is false the content will
            /// automatically return to its original size and position. The client is
            /// responsible for resizing the browser if desired.
            /// /*cef()*/
            /// </summary>
            void OnFullscreenModeChange(CefBrowser browser, bool fullscreen);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,494
            /// <summary>
            /// Called when the browser is about to display a tooltip. |text| contains the
            /// text that will be displayed in the tooltip. To handle the display of the
            /// tooltip yourself return true. Otherwise, you can optionally modify |text|
            /// and then return false to allow the browser to display the tooltip.
            /// When window rendering is disabled the application is responsible for
            /// drawing tooltips and the return value is ignored.
            /// /*cef(optional_param=text)*/
            /// </summary>
            bool OnTooltip(CefBrowser browser, ref string text);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,495
            /// <summary>
            /// Called when the browser receives a status message. |value| contains the
            /// text that will be displayed in the status message.
            /// /*cef(optional_param=value)*/
            /// </summary>
            void OnStatusMessage(CefBrowser browser, string value);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,496
            /// <summary>
            /// Called to display a console message. Return true to stop the message from
            /// being output to the console.
            /// /*cef(optional_param=message,optional_param=source)*/
            /// </summary>
            bool OnConsoleMessage(CefBrowser browser, string message, string source, int line);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,497
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,498
                case CefDisplayHandlerExt_OnAddressChange_1:
                    {
                        var args = new OnAddressChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnAddressChange(args);
                        }
                        if (i1 != null)
                        {
                            OnAddressChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,499
                case CefDisplayHandlerExt_OnTitleChange_2:
                    {
                        var args = new OnTitleChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnTitleChange(args);
                        }
                        if (i1 != null)
                        {
                            OnTitleChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,500
                case CefDisplayHandlerExt_OnFaviconURLChange_3:
                    {
                        var args = new OnFaviconURLChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnFaviconURLChange(args);
                        }
                        if (i1 != null)
                        {
                            OnFaviconURLChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,501
                case CefDisplayHandlerExt_OnFullscreenModeChange_4:
                    {
                        var args = new OnFullscreenModeChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnFullscreenModeChange(args);
                        }
                        if (i1 != null)
                        {
                            OnFullscreenModeChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,502
                case CefDisplayHandlerExt_OnTooltip_5:
                    {
                        var args = new OnTooltipArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnTooltip(args);
                        }
                        if (i1 != null)
                        {
                            OnTooltip(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,503
                case CefDisplayHandlerExt_OnStatusMessage_6:
                    {
                        var args = new OnStatusMessageArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnStatusMessage(args);
                        }
                        if (i1 != null)
                        {
                            OnStatusMessage(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,504
                case CefDisplayHandlerExt_OnConsoleMessage_7:
                    {
                        var args = new OnConsoleMessageArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnConsoleMessage(args);
                        }
                        if (i1 != null)
                        {
                            OnConsoleMessage(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,505
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefDisplayHandlerExt_OnAddressChange_1:
                    i0.OnAddressChange(new OnAddressChangeArgs(nativeArgPtr));
                    break;
                case CefDisplayHandlerExt_OnTitleChange_2:
                    i0.OnTitleChange(new OnTitleChangeArgs(nativeArgPtr));
                    break;
                case CefDisplayHandlerExt_OnFaviconURLChange_3:
                    i0.OnFaviconURLChange(new OnFaviconURLChangeArgs(nativeArgPtr));
                    break;
                case CefDisplayHandlerExt_OnFullscreenModeChange_4:
                    i0.OnFullscreenModeChange(new OnFullscreenModeChangeArgs(nativeArgPtr));
                    break;
                case CefDisplayHandlerExt_OnTooltip_5:
                    i0.OnTooltip(new OnTooltipArgs(nativeArgPtr));
                    break;
                case CefDisplayHandlerExt_OnStatusMessage_6:
                    i0.OnStatusMessage(new OnStatusMessageArgs(nativeArgPtr));
                    break;
                case CefDisplayHandlerExt_OnConsoleMessage_7:
                    i0.OnConsoleMessage(new OnConsoleMessageArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,506
        public static void OnAddressChange(I1 i1, OnAddressChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,507
            i1.OnAddressChange(args.browser(),
            args.frame(),
            args.url());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,508
        public static void OnTitleChange(I1 i1, OnTitleChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,509
            i1.OnTitleChange(args.browser(),
            args.title());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,510
        public static void OnFaviconURLChange(I1 i1, OnFaviconURLChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,511
            i1.OnFaviconURLChange(args.browser(),
            args.icon_urls());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,512
        public static void OnFullscreenModeChange(I1 i1, OnFullscreenModeChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,513
            i1.OnFullscreenModeChange(args.browser(),
            args.fullscreen());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,514
        public static void OnTooltip(I1 i1, OnTooltipArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,515
            string text = args.text();
            args.myext_setRetValue(i1.OnTooltip(args.browser(),
            ref text));
            args.text(text);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,516
        public static void OnStatusMessage(I1 i1, OnStatusMessageArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,517
            i1.OnStatusMessage(args.browser(),
            args.value());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,518
        public static void OnConsoleMessage(I1 i1, OnConsoleMessageArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,519
            args.myext_setRetValue(i1.OnConsoleMessage(args.browser(),
            args.message(),
            args.source(),
            args.line()));
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,520
    public struct CefDownloadHandler
    {
        public const int _typeNAME = 61;
        internal IntPtr nativePtr;
        public CefDownloadHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefDownloadHandlerExt_OnBeforeDownload_1 = 1;
        public const int CefDownloadHandlerExt_OnDownloadUpdated_2 = 2;
        //gen! void OnBeforeDownload(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDownloadItem> download_item,const CefString& suggested_name,CefRefPtr<CefBeforeDownloadCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,521
        /// <summary>
        /// Called before a download begins. |suggested_name| is the suggested name for
        /// the download file. By default the download will be canceled. Execute
        /// |callback| either asynchronously or in this method to continue the download
        /// if desired. Do not keep a reference to |download_item| outside of this
        /// method.
        /// /*cef()*/
        /// </summary>
        public struct OnBeforeDownloadArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeDownloadArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeDownloadNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeDownloadNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeDownloadNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefDownloadItem download_item()
            {
                unsafe
                {
                    return new CefDownloadItem(((OnBeforeDownloadNativeArgs*)this.nativePtr)->download_item);
                }
            }
            public string suggested_name()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforeDownloadNativeArgs*)this.nativePtr)->suggested_name);
                }
            }
            public CefBeforeDownloadCallback callback()
            {
                unsafe
                {
                    return new CefBeforeDownloadCallback(((OnBeforeDownloadNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,522
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeDownloadNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr download_item;
            public IntPtr suggested_name;
            public IntPtr callback;
        }
        //gen! void OnDownloadUpdated(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDownloadItem> download_item,CefRefPtr<CefDownloadItemCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,523
        /// <summary>
        /// Called when a download's status or progress information has been updated.
        /// This may be called multiple times before and after OnBeforeDownload().
        /// Execute |callback| either asynchronously or in this method to cancel the
        /// download if desired. Do not keep a reference to |download_item| outside of
        /// this method.
        /// /*cef()*/
        /// </summary>
        public struct OnDownloadUpdatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnDownloadUpdatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnDownloadUpdatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnDownloadUpdatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnDownloadUpdatedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefDownloadItem download_item()
            {
                unsafe
                {
                    return new CefDownloadItem(((OnDownloadUpdatedNativeArgs*)this.nativePtr)->download_item);
                }
            }
            public CefDownloadItemCallback callback()
            {
                unsafe
                {
                    return new CefDownloadItemCallback(((OnDownloadUpdatedNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,524
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnDownloadUpdatedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr download_item;
            public IntPtr callback;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,525
            /// <summary>
            /// Called before a download begins. |suggested_name| is the suggested name for
            /// the download file. By default the download will be canceled. Execute
            /// |callback| either asynchronously or in this method to continue the download
            /// if desired. Do not keep a reference to |download_item| outside of this
            /// method.
            /// /*cef()*/
            /// </summary>
            void OnBeforeDownload(OnBeforeDownloadArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,526
            /// <summary>
            /// Called when a download's status or progress information has been updated.
            /// This may be called multiple times before and after OnBeforeDownload().
            /// Execute |callback| either asynchronously or in this method to cancel the
            /// download if desired. Do not keep a reference to |download_item| outside of
            /// this method.
            /// /*cef()*/
            /// </summary>
            void OnDownloadUpdated(OnDownloadUpdatedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,527
            /// <summary>
            /// Called before a download begins. |suggested_name| is the suggested name for
            /// the download file. By default the download will be canceled. Execute
            /// |callback| either asynchronously or in this method to continue the download
            /// if desired. Do not keep a reference to |download_item| outside of this
            /// method.
            /// /*cef()*/
            /// </summary>
            void OnBeforeDownload(CefBrowser browser, CefDownloadItem download_item, string suggested_name, CefBeforeDownloadCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,528
            /// <summary>
            /// Called when a download's status or progress information has been updated.
            /// This may be called multiple times before and after OnBeforeDownload().
            /// Execute |callback| either asynchronously or in this method to cancel the
            /// download if desired. Do not keep a reference to |download_item| outside of
            /// this method.
            /// /*cef()*/
            /// </summary>
            void OnDownloadUpdated(CefBrowser browser, CefDownloadItem download_item, CefDownloadItemCallback callback);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,529
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,530
                case CefDownloadHandlerExt_OnBeforeDownload_1:
                    {
                        var args = new OnBeforeDownloadArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeDownload(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeDownload(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,531
                case CefDownloadHandlerExt_OnDownloadUpdated_2:
                    {
                        var args = new OnDownloadUpdatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnDownloadUpdated(args);
                        }
                        if (i1 != null)
                        {
                            OnDownloadUpdated(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,532
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefDownloadHandlerExt_OnBeforeDownload_1:
                    i0.OnBeforeDownload(new OnBeforeDownloadArgs(nativeArgPtr));
                    break;
                case CefDownloadHandlerExt_OnDownloadUpdated_2:
                    i0.OnDownloadUpdated(new OnDownloadUpdatedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,533
        public static void OnBeforeDownload(I1 i1, OnBeforeDownloadArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,534
            i1.OnBeforeDownload(args.browser(),
            args.download_item(),
            args.suggested_name(),
            args.callback());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,535
        public static void OnDownloadUpdated(I1 i1, OnDownloadUpdatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,536
            i1.OnDownloadUpdated(args.browser(),
            args.download_item(),
            args.callback());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,537
    public struct CefDragHandler
    {
        public const int _typeNAME = 62;
        internal IntPtr nativePtr;
        public CefDragHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefDragHandlerExt_OnDragEnter_1 = 1;
        public const int CefDragHandlerExt_OnDraggableRegionsChanged_2 = 2;
        //gen! bool OnDragEnter(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDragData> dragData,DragOperationsMask mask)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,538
        /// <summary>
        /// Called when an external drag event enters the browser window. |dragData|
        /// contains the drag event data and |mask| represents the type of drag
        /// operation. Return false for default drag handling behavior or true to
        /// cancel the drag event.
        /// /*cef()*/
        /// </summary>
        public struct OnDragEnterArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnDragEnterArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnDragEnterNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnDragEnterNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnDragEnterNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnDragEnterNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefDragData dragData()
            {
                unsafe
                {
                    return new CefDragData(((OnDragEnterNativeArgs*)this.nativePtr)->dragData);
                }
            }
            public cef_drag_operations_mask_t mask()
            {
                unsafe
                {
                    return (cef_drag_operations_mask_t)(((OnDragEnterNativeArgs*)this.nativePtr)->mask);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,539
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnDragEnterNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr dragData;
            public cef_drag_operations_mask_t mask;
        }
        //gen! void OnDraggableRegionsChanged(CefRefPtr<CefBrowser> browser,const std::vector<CefDraggableRegion>& regions)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,540
        /// <summary>
        /// Called whenever draggable regions for the browser window change. These can
        /// be specified using the '-webkit-app-region: drag/no-drag' CSS-property. If
        /// draggable regions are never defined in a document this method will also
        /// never be called. If the last draggable region is removed from a document
        /// this method will be called with an empty vector.
        /// /*cef()*/
        /// </summary>
        public struct OnDraggableRegionsChangedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnDraggableRegionsChangedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnDraggableRegionsChangedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnDraggableRegionsChangedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnDraggableRegionsChangedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefDraggableRegionList regions()
            {
                unsafe
                {
                    return new CefDraggableRegionList(((OnDraggableRegionsChangedNativeArgs*)this.nativePtr)->regions);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,541
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnDraggableRegionsChangedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr regions;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,542
            /// <summary>
            /// Called when an external drag event enters the browser window. |dragData|
            /// contains the drag event data and |mask| represents the type of drag
            /// operation. Return false for default drag handling behavior or true to
            /// cancel the drag event.
            /// /*cef()*/
            /// </summary>
            void OnDragEnter(OnDragEnterArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,543
            /// <summary>
            /// Called whenever draggable regions for the browser window change. These can
            /// be specified using the '-webkit-app-region: drag/no-drag' CSS-property. If
            /// draggable regions are never defined in a document this method will also
            /// never be called. If the last draggable region is removed from a document
            /// this method will be called with an empty vector.
            /// /*cef()*/
            /// </summary>
            void OnDraggableRegionsChanged(OnDraggableRegionsChangedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,544
            /// <summary>
            /// Called when an external drag event enters the browser window. |dragData|
            /// contains the drag event data and |mask| represents the type of drag
            /// operation. Return false for default drag handling behavior or true to
            /// cancel the drag event.
            /// /*cef()*/
            /// </summary>
            bool OnDragEnter(CefBrowser browser, CefDragData dragData, cef_drag_operations_mask_t mask);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,545
            /// <summary>
            /// Called whenever draggable regions for the browser window change. These can
            /// be specified using the '-webkit-app-region: drag/no-drag' CSS-property. If
            /// draggable regions are never defined in a document this method will also
            /// never be called. If the last draggable region is removed from a document
            /// this method will be called with an empty vector.
            /// /*cef()*/
            /// </summary>
            void OnDraggableRegionsChanged(CefBrowser browser, CefDraggableRegionList regions);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,546
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,547
                case CefDragHandlerExt_OnDragEnter_1:
                    {
                        var args = new OnDragEnterArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnDragEnter(args);
                        }
                        if (i1 != null)
                        {
                            OnDragEnter(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,548
                case CefDragHandlerExt_OnDraggableRegionsChanged_2:
                    {
                        var args = new OnDraggableRegionsChangedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnDraggableRegionsChanged(args);
                        }
                        if (i1 != null)
                        {
                            OnDraggableRegionsChanged(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,549
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefDragHandlerExt_OnDragEnter_1:
                    i0.OnDragEnter(new OnDragEnterArgs(nativeArgPtr));
                    break;
                case CefDragHandlerExt_OnDraggableRegionsChanged_2:
                    i0.OnDraggableRegionsChanged(new OnDraggableRegionsChangedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,550
        public static void OnDragEnter(I1 i1, OnDragEnterArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,551
            args.myext_setRetValue(i1.OnDragEnter(args.browser(),
            args.dragData(),
            args.mask()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,552
        public static void OnDraggableRegionsChanged(I1 i1, OnDraggableRegionsChangedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,553
            i1.OnDraggableRegionsChanged(args.browser(),
            args.regions());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,554
    public struct CefFindHandler
    {
        public const int _typeNAME = 63;
        internal IntPtr nativePtr;
        public CefFindHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefFindHandlerExt_OnFindResult_1 = 1;
        //gen! void OnFindResult(CefRefPtr<CefBrowser> browser,int identifier,int count,const CefRect& selectionRect,int activeMatchOrdinal,bool finalUpdate)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,555
        /// <summary>
        /// Called to report find results returned by CefBrowserHost::Find().
        /// |identifer| is the identifier passed to Find(), |count| is the number of
        /// matches currently identified, |selectionRect| is the location of where the
        /// match was found (in window coordinates), |activeMatchOrdinal| is the
        /// current position in the search results, and |finalUpdate| is true if this
        /// is the last find notification.
        /// /*cef()*/
        /// </summary>
        public struct OnFindResultArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnFindResultArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnFindResultNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnFindResultNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnFindResultNativeArgs*)this.nativePtr)->browser);
                }
            }
            public int identifier()
            {
                unsafe
                {
                    return ((OnFindResultNativeArgs*)this.nativePtr)->identifier;
                }
            }
            public int count()
            {
                unsafe
                {
                    return ((OnFindResultNativeArgs*)this.nativePtr)->count;
                }
            }
            public CefRect selectionRect()
            {
                unsafe
                {
                    return new CefRect(((OnFindResultNativeArgs*)this.nativePtr)->selectionRect);
                }
            }
            public int activeMatchOrdinal()
            {
                unsafe
                {
                    return ((OnFindResultNativeArgs*)this.nativePtr)->activeMatchOrdinal;
                }
            }
            public bool finalUpdate()
            {
                unsafe
                {
                    return ((OnFindResultNativeArgs*)this.nativePtr)->finalUpdate;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,556
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnFindResultNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public int identifier;
            public int count;
            public IntPtr selectionRect;
            public int activeMatchOrdinal;
            public bool finalUpdate;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,557
            /// <summary>
            /// Called to report find results returned by CefBrowserHost::Find().
            /// |identifer| is the identifier passed to Find(), |count| is the number of
            /// matches currently identified, |selectionRect| is the location of where the
            /// match was found (in window coordinates), |activeMatchOrdinal| is the
            /// current position in the search results, and |finalUpdate| is true if this
            /// is the last find notification.
            /// /*cef()*/
            /// </summary>
            void OnFindResult(OnFindResultArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,558
            /// <summary>
            /// Called to report find results returned by CefBrowserHost::Find().
            /// |identifer| is the identifier passed to Find(), |count| is the number of
            /// matches currently identified, |selectionRect| is the location of where the
            /// match was found (in window coordinates), |activeMatchOrdinal| is the
            /// current position in the search results, and |finalUpdate| is true if this
            /// is the last find notification.
            /// /*cef()*/
            /// </summary>
            void OnFindResult(CefBrowser browser, int identifier, int count, CefRect selectionRect, int activeMatchOrdinal, bool finalUpdate);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,559
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,560
                case CefFindHandlerExt_OnFindResult_1:
                    {
                        var args = new OnFindResultArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnFindResult(args);
                        }
                        if (i1 != null)
                        {
                            OnFindResult(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,561
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefFindHandlerExt_OnFindResult_1:
                    i0.OnFindResult(new OnFindResultArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,562
        public static void OnFindResult(I1 i1, OnFindResultArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,563
            i1.OnFindResult(args.browser(),
            args.identifier(),
            args.count(),
            args.selectionRect(),
            args.activeMatchOrdinal(),
            args.finalUpdate());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,564
    public struct CefFocusHandler
    {
        public const int _typeNAME = 64;
        internal IntPtr nativePtr;
        public CefFocusHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefFocusHandlerExt_OnTakeFocus_1 = 1;
        public const int CefFocusHandlerExt_OnSetFocus_2 = 2;
        public const int CefFocusHandlerExt_OnGotFocus_3 = 3;
        //gen! void OnTakeFocus(CefRefPtr<CefBrowser> browser,bool next)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,565
        /// <summary>
        /// Called when the browser component is about to loose focus. For instance, if
        /// focus was on the last HTML element and the user pressed the TAB key. |next|
        /// will be true if the browser is giving focus to the next component and false
        /// if the browser is giving focus to the previous component.
        /// /*cef()*/
        /// </summary>
        public struct OnTakeFocusArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnTakeFocusArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnTakeFocusNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnTakeFocusNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnTakeFocusNativeArgs*)this.nativePtr)->browser);
                }
            }
            public bool next()
            {
                unsafe
                {
                    return ((OnTakeFocusNativeArgs*)this.nativePtr)->next;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,566
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnTakeFocusNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public bool next;
        }
        //gen! bool OnSetFocus(CefRefPtr<CefBrowser> browser,FocusSource source)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,567
        /// <summary>
        /// Called when the browser component is requesting focus. |source| indicates
        /// where the focus request is originating from. Return false to allow the
        /// focus to be set or true to cancel setting the focus.
        /// /*cef()*/
        /// </summary>
        public struct OnSetFocusArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnSetFocusArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnSetFocusNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnSetFocusNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnSetFocusNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnSetFocusNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_focus_source_t source()
            {
                unsafe
                {
                    return (cef_focus_source_t)(((OnSetFocusNativeArgs*)this.nativePtr)->source);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,568
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnSetFocusNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public cef_focus_source_t source;
        }
        //gen! void OnGotFocus(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,569
        /// <summary>
        /// Called when the browser component has received focus.
        /// /*cef()*/
        /// </summary>
        public struct OnGotFocusArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnGotFocusArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnGotFocusNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnGotFocusNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnGotFocusNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,570
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnGotFocusNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,571
            /// <summary>
            /// Called when the browser component is about to loose focus. For instance, if
            /// focus was on the last HTML element and the user pressed the TAB key. |next|
            /// will be true if the browser is giving focus to the next component and false
            /// if the browser is giving focus to the previous component.
            /// /*cef()*/
            /// </summary>
            void OnTakeFocus(OnTakeFocusArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,572
            /// <summary>
            /// Called when the browser component is requesting focus. |source| indicates
            /// where the focus request is originating from. Return false to allow the
            /// focus to be set or true to cancel setting the focus.
            /// /*cef()*/
            /// </summary>
            void OnSetFocus(OnSetFocusArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,573
            /// <summary>
            /// Called when the browser component has received focus.
            /// /*cef()*/
            /// </summary>
            void OnGotFocus(OnGotFocusArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,574
            /// <summary>
            /// Called when the browser component is about to loose focus. For instance, if
            /// focus was on the last HTML element and the user pressed the TAB key. |next|
            /// will be true if the browser is giving focus to the next component and false
            /// if the browser is giving focus to the previous component.
            /// /*cef()*/
            /// </summary>
            void OnTakeFocus(CefBrowser browser, bool next);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,575
            /// <summary>
            /// Called when the browser component is requesting focus. |source| indicates
            /// where the focus request is originating from. Return false to allow the
            /// focus to be set or true to cancel setting the focus.
            /// /*cef()*/
            /// </summary>
            bool OnSetFocus(CefBrowser browser, cef_focus_source_t source);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,576
            /// <summary>
            /// Called when the browser component has received focus.
            /// /*cef()*/
            /// </summary>
            void OnGotFocus(CefBrowser browser);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,577
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,578
                case CefFocusHandlerExt_OnTakeFocus_1:
                    {
                        var args = new OnTakeFocusArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnTakeFocus(args);
                        }
                        if (i1 != null)
                        {
                            OnTakeFocus(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,579
                case CefFocusHandlerExt_OnSetFocus_2:
                    {
                        var args = new OnSetFocusArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnSetFocus(args);
                        }
                        if (i1 != null)
                        {
                            OnSetFocus(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,580
                case CefFocusHandlerExt_OnGotFocus_3:
                    {
                        var args = new OnGotFocusArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnGotFocus(args);
                        }
                        if (i1 != null)
                        {
                            OnGotFocus(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,581
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefFocusHandlerExt_OnTakeFocus_1:
                    i0.OnTakeFocus(new OnTakeFocusArgs(nativeArgPtr));
                    break;
                case CefFocusHandlerExt_OnSetFocus_2:
                    i0.OnSetFocus(new OnSetFocusArgs(nativeArgPtr));
                    break;
                case CefFocusHandlerExt_OnGotFocus_3:
                    i0.OnGotFocus(new OnGotFocusArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,582
        public static void OnTakeFocus(I1 i1, OnTakeFocusArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,583
            i1.OnTakeFocus(args.browser(),
            args.next());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,584
        public static void OnSetFocus(I1 i1, OnSetFocusArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,585
            args.myext_setRetValue(i1.OnSetFocus(args.browser(),
            args.source()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,586
        public static void OnGotFocus(I1 i1, OnGotFocusArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,587
            i1.OnGotFocus(args.browser());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,588
    public struct CefGeolocationHandler
    {
        public const int _typeNAME = 65;
        internal IntPtr nativePtr;
        public CefGeolocationHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefGeolocationHandlerExt_OnRequestGeolocationPermission_1 = 1;
        public const int CefGeolocationHandlerExt_OnCancelGeolocationPermission_2 = 2;
        //gen! bool OnRequestGeolocationPermission(CefRefPtr<CefBrowser> browser,const CefString& requesting_url,int request_id,CefRefPtr<CefGeolocationCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,589
        /// <summary>
        /// Called when a page requests permission to access geolocation information.
        /// |requesting_url| is the URL requesting permission and |request_id| is the
        /// unique ID for the permission request. Return true and call
        /// CefGeolocationCallback::Continue() either in this method or at a later
        /// time to continue or cancel the request. Return false to cancel the request
        /// immediately.
        /// /*cef()*/
        /// </summary>
        public struct OnRequestGeolocationPermissionArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRequestGeolocationPermissionArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string requesting_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->requesting_url);
                }
            }
            public int request_id()
            {
                unsafe
                {
                    return ((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->request_id;
                }
            }
            public CefGeolocationCallback callback()
            {
                unsafe
                {
                    return new CefGeolocationCallback(((OnRequestGeolocationPermissionNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,590
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnRequestGeolocationPermissionNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr requesting_url;
            public int request_id;
            public IntPtr callback;
        }
        //gen! void OnCancelGeolocationPermission(CefRefPtr<CefBrowser> browser,int request_id)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,591
        /// <summary>
        /// Called when a geolocation access request is canceled. |request_id| is the
        /// unique ID for the permission request.
        /// /*cef()*/
        /// </summary>
        public struct OnCancelGeolocationPermissionArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnCancelGeolocationPermissionArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnCancelGeolocationPermissionNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnCancelGeolocationPermissionNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnCancelGeolocationPermissionNativeArgs*)this.nativePtr)->browser);
                }
            }
            public int request_id()
            {
                unsafe
                {
                    return ((OnCancelGeolocationPermissionNativeArgs*)this.nativePtr)->request_id;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,592
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnCancelGeolocationPermissionNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public int request_id;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,593
            /// <summary>
            /// Called when a page requests permission to access geolocation information.
            /// |requesting_url| is the URL requesting permission and |request_id| is the
            /// unique ID for the permission request. Return true and call
            /// CefGeolocationCallback::Continue() either in this method or at a later
            /// time to continue or cancel the request. Return false to cancel the request
            /// immediately.
            /// /*cef()*/
            /// </summary>
            void OnRequestGeolocationPermission(OnRequestGeolocationPermissionArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,594
            /// <summary>
            /// Called when a geolocation access request is canceled. |request_id| is the
            /// unique ID for the permission request.
            /// /*cef()*/
            /// </summary>
            void OnCancelGeolocationPermission(OnCancelGeolocationPermissionArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,595
            /// <summary>
            /// Called when a page requests permission to access geolocation information.
            /// |requesting_url| is the URL requesting permission and |request_id| is the
            /// unique ID for the permission request. Return true and call
            /// CefGeolocationCallback::Continue() either in this method or at a later
            /// time to continue or cancel the request. Return false to cancel the request
            /// immediately.
            /// /*cef()*/
            /// </summary>
            bool OnRequestGeolocationPermission(CefBrowser browser, string requesting_url, int request_id, CefGeolocationCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,596
            /// <summary>
            /// Called when a geolocation access request is canceled. |request_id| is the
            /// unique ID for the permission request.
            /// /*cef()*/
            /// </summary>
            void OnCancelGeolocationPermission(CefBrowser browser, int request_id);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,597
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,598
                case CefGeolocationHandlerExt_OnRequestGeolocationPermission_1:
                    {
                        var args = new OnRequestGeolocationPermissionArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRequestGeolocationPermission(args);
                        }
                        if (i1 != null)
                        {
                            OnRequestGeolocationPermission(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,599
                case CefGeolocationHandlerExt_OnCancelGeolocationPermission_2:
                    {
                        var args = new OnCancelGeolocationPermissionArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnCancelGeolocationPermission(args);
                        }
                        if (i1 != null)
                        {
                            OnCancelGeolocationPermission(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,600
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefGeolocationHandlerExt_OnRequestGeolocationPermission_1:
                    i0.OnRequestGeolocationPermission(new OnRequestGeolocationPermissionArgs(nativeArgPtr));
                    break;
                case CefGeolocationHandlerExt_OnCancelGeolocationPermission_2:
                    i0.OnCancelGeolocationPermission(new OnCancelGeolocationPermissionArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,601
        public static void OnRequestGeolocationPermission(I1 i1, OnRequestGeolocationPermissionArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,602
            args.myext_setRetValue(i1.OnRequestGeolocationPermission(args.browser(),
            args.requesting_url(),
            args.request_id(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,603
        public static void OnCancelGeolocationPermission(I1 i1, OnCancelGeolocationPermissionArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,604
            i1.OnCancelGeolocationPermission(args.browser(),
            args.request_id());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,605
    public struct CefJSDialogHandler
    {
        public const int _typeNAME = 66;
        internal IntPtr nativePtr;
        public CefJSDialogHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefJSDialogHandlerExt_OnJSDialog_1 = 1;
        public const int CefJSDialogHandlerExt_OnBeforeUnloadDialog_2 = 2;
        public const int CefJSDialogHandlerExt_OnResetDialogState_3 = 3;
        public const int CefJSDialogHandlerExt_OnDialogClosed_4 = 4;
        //gen! bool OnJSDialog(CefRefPtr<CefBrowser> browser,const CefString& origin_url,JSDialogType dialog_type,const CefString& message_text,const CefString& default_prompt_text,CefRefPtr<CefJSDialogCallback> callback,bool& suppress_message)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,606
        /// <summary>
        /// Called to run a JavaScript dialog. If |origin_url| is non-empty it can be
        /// passed to the CefFormatUrlForSecurityDisplay function to retrieve a secure
        /// and user-friendly display string. The |default_prompt_text| value will be
        /// specified for prompt dialogs only. Set |suppress_message| to true and
        /// return false to suppress the message (suppressing messages is preferable to
        /// immediately executing the callback as this is used to detect presumably
        /// malicious behavior like spamming alert messages in onbeforeunload). Set
        /// |suppress_message| to false and return false to use the default
        /// implementation (the default implementation will show one modal dialog at a
        /// time and suppress any additional dialog requests until the displayed dialog
        /// is dismissed). Return true if the application will use a custom dialog or
        /// if the callback has been executed immediately. Custom dialogs may be either
        /// modal or modeless. If a custom dialog is used the application must execute
        /// |callback| once the custom dialog is dismissed.
        /// /*cef(optional_param=origin_url,optional_param=accept_lang,optional_param=message_text,optional_param=default_prompt_text)*/
        /// </summary>
        public struct OnJSDialogArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnJSDialogArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnJSDialogNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnJSDialogNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnJSDialogNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnJSDialogNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string origin_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnJSDialogNativeArgs*)this.nativePtr)->origin_url);
                }
            }
            public cef_jsdialog_type_t dialog_type()
            {
                unsafe
                {
                    return (cef_jsdialog_type_t)(((OnJSDialogNativeArgs*)this.nativePtr)->dialog_type);
                }
            }
            public string message_text()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnJSDialogNativeArgs*)this.nativePtr)->message_text);
                }
            }
            public string default_prompt_text()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnJSDialogNativeArgs*)this.nativePtr)->default_prompt_text);
                }
            }
            public CefJSDialogCallback callback()
            {
                unsafe
                {
                    return new CefJSDialogCallback(((OnJSDialogNativeArgs*)this.nativePtr)->callback);
                }
            }
            public bool suppress_message()
            {
                unsafe
                {
                    return *(((OnJSDialogNativeArgs*)this.nativePtr)->suppress_message);
                }
            }
            public void suppress_message(bool value)
            {
                unsafe
                {
                    *(((OnJSDialogNativeArgs*)this.nativePtr)->suppress_message) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,607
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnJSDialogNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr origin_url;
            public cef_jsdialog_type_t dialog_type;
            public IntPtr message_text;
            public IntPtr default_prompt_text;
            public IntPtr callback;
            public bool* suppress_message;
        }
        //gen! bool OnBeforeUnloadDialog(CefRefPtr<CefBrowser> browser,const CefString& message_text,bool is_reload,CefRefPtr<CefJSDialogCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,608
        /// <summary>
        /// Called to run a dialog asking the user if they want to leave a page. Return
        /// false to use the default dialog implementation. Return true if the
        /// application will use a custom dialog or if the callback has been executed
        /// immediately. Custom dialogs may be either modal or modeless. If a custom
        /// dialog is used the application must execute |callback| once the custom
        /// dialog is dismissed.
        /// /*cef(optional_param=message_text)*/
        /// </summary>
        public struct OnBeforeUnloadDialogArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeUnloadDialogArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string message_text()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->message_text);
                }
            }
            public bool is_reload()
            {
                unsafe
                {
                    return ((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->is_reload;
                }
            }
            public CefJSDialogCallback callback()
            {
                unsafe
                {
                    return new CefJSDialogCallback(((OnBeforeUnloadDialogNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,609
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeUnloadDialogNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr message_text;
            public bool is_reload;
            public IntPtr callback;
        }
        //gen! void OnResetDialogState(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,610
        /// <summary>
        /// Called to cancel any pending dialogs and reset any saved dialog state. Will
        /// be called due to events like page navigation irregardless of whether any
        /// dialogs are currently pending.
        /// /*cef()*/
        /// </summary>
        public struct OnResetDialogStateArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnResetDialogStateArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnResetDialogStateNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnResetDialogStateNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnResetDialogStateNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,611
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnResetDialogStateNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! void OnDialogClosed(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,612
        /// <summary>
        /// Called when the default implementation dialog is closed.
        /// /*cef()*/
        /// </summary>
        public struct OnDialogClosedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnDialogClosedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnDialogClosedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnDialogClosedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnDialogClosedNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,613
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnDialogClosedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,614
            /// <summary>
            /// Called to run a JavaScript dialog. If |origin_url| is non-empty it can be
            /// passed to the CefFormatUrlForSecurityDisplay function to retrieve a secure
            /// and user-friendly display string. The |default_prompt_text| value will be
            /// specified for prompt dialogs only. Set |suppress_message| to true and
            /// return false to suppress the message (suppressing messages is preferable to
            /// immediately executing the callback as this is used to detect presumably
            /// malicious behavior like spamming alert messages in onbeforeunload). Set
            /// |suppress_message| to false and return false to use the default
            /// implementation (the default implementation will show one modal dialog at a
            /// time and suppress any additional dialog requests until the displayed dialog
            /// is dismissed). Return true if the application will use a custom dialog or
            /// if the callback has been executed immediately. Custom dialogs may be either
            /// modal or modeless. If a custom dialog is used the application must execute
            /// |callback| once the custom dialog is dismissed.
            /// /*cef(optional_param=origin_url,optional_param=accept_lang,optional_param=message_text,optional_param=default_prompt_text)*/
            /// </summary>
            void OnJSDialog(OnJSDialogArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,615
            /// <summary>
            /// Called to run a dialog asking the user if they want to leave a page. Return
            /// false to use the default dialog implementation. Return true if the
            /// application will use a custom dialog or if the callback has been executed
            /// immediately. Custom dialogs may be either modal or modeless. If a custom
            /// dialog is used the application must execute |callback| once the custom
            /// dialog is dismissed.
            /// /*cef(optional_param=message_text)*/
            /// </summary>
            void OnBeforeUnloadDialog(OnBeforeUnloadDialogArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,616
            /// <summary>
            /// Called to cancel any pending dialogs and reset any saved dialog state. Will
            /// be called due to events like page navigation irregardless of whether any
            /// dialogs are currently pending.
            /// /*cef()*/
            /// </summary>
            void OnResetDialogState(OnResetDialogStateArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,617
            /// <summary>
            /// Called when the default implementation dialog is closed.
            /// /*cef()*/
            /// </summary>
            void OnDialogClosed(OnDialogClosedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,618
            /// <summary>
            /// Called to run a JavaScript dialog. If |origin_url| is non-empty it can be
            /// passed to the CefFormatUrlForSecurityDisplay function to retrieve a secure
            /// and user-friendly display string. The |default_prompt_text| value will be
            /// specified for prompt dialogs only. Set |suppress_message| to true and
            /// return false to suppress the message (suppressing messages is preferable to
            /// immediately executing the callback as this is used to detect presumably
            /// malicious behavior like spamming alert messages in onbeforeunload). Set
            /// |suppress_message| to false and return false to use the default
            /// implementation (the default implementation will show one modal dialog at a
            /// time and suppress any additional dialog requests until the displayed dialog
            /// is dismissed). Return true if the application will use a custom dialog or
            /// if the callback has been executed immediately. Custom dialogs may be either
            /// modal or modeless. If a custom dialog is used the application must execute
            /// |callback| once the custom dialog is dismissed.
            /// /*cef(optional_param=origin_url,optional_param=accept_lang,optional_param=message_text,optional_param=default_prompt_text)*/
            /// </summary>
            bool OnJSDialog(CefBrowser browser, string origin_url, cef_jsdialog_type_t dialog_type, string message_text, string default_prompt_text, CefJSDialogCallback callback, ref bool suppress_message);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,619
            /// <summary>
            /// Called to run a dialog asking the user if they want to leave a page. Return
            /// false to use the default dialog implementation. Return true if the
            /// application will use a custom dialog or if the callback has been executed
            /// immediately. Custom dialogs may be either modal or modeless. If a custom
            /// dialog is used the application must execute |callback| once the custom
            /// dialog is dismissed.
            /// /*cef(optional_param=message_text)*/
            /// </summary>
            bool OnBeforeUnloadDialog(CefBrowser browser, string message_text, bool is_reload, CefJSDialogCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,620
            /// <summary>
            /// Called to cancel any pending dialogs and reset any saved dialog state. Will
            /// be called due to events like page navigation irregardless of whether any
            /// dialogs are currently pending.
            /// /*cef()*/
            /// </summary>
            void OnResetDialogState(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,621
            /// <summary>
            /// Called when the default implementation dialog is closed.
            /// /*cef()*/
            /// </summary>
            void OnDialogClosed(CefBrowser browser);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,622
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,623
                case CefJSDialogHandlerExt_OnJSDialog_1:
                    {
                        var args = new OnJSDialogArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnJSDialog(args);
                        }
                        if (i1 != null)
                        {
                            OnJSDialog(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,624
                case CefJSDialogHandlerExt_OnBeforeUnloadDialog_2:
                    {
                        var args = new OnBeforeUnloadDialogArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeUnloadDialog(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeUnloadDialog(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,625
                case CefJSDialogHandlerExt_OnResetDialogState_3:
                    {
                        var args = new OnResetDialogStateArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnResetDialogState(args);
                        }
                        if (i1 != null)
                        {
                            OnResetDialogState(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,626
                case CefJSDialogHandlerExt_OnDialogClosed_4:
                    {
                        var args = new OnDialogClosedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnDialogClosed(args);
                        }
                        if (i1 != null)
                        {
                            OnDialogClosed(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,627
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefJSDialogHandlerExt_OnJSDialog_1:
                    i0.OnJSDialog(new OnJSDialogArgs(nativeArgPtr));
                    break;
                case CefJSDialogHandlerExt_OnBeforeUnloadDialog_2:
                    i0.OnBeforeUnloadDialog(new OnBeforeUnloadDialogArgs(nativeArgPtr));
                    break;
                case CefJSDialogHandlerExt_OnResetDialogState_3:
                    i0.OnResetDialogState(new OnResetDialogStateArgs(nativeArgPtr));
                    break;
                case CefJSDialogHandlerExt_OnDialogClosed_4:
                    i0.OnDialogClosed(new OnDialogClosedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,628
        public static void OnJSDialog(I1 i1, OnJSDialogArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,629
            bool suppress_message = false;
            args.myext_setRetValue(i1.OnJSDialog(args.browser(),
            args.origin_url(),
            args.dialog_type(),
            args.message_text(),
            args.default_prompt_text(),
            args.callback(),
            ref suppress_message));
            args.suppress_message(suppress_message);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,630
        public static void OnBeforeUnloadDialog(I1 i1, OnBeforeUnloadDialogArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,631
            args.myext_setRetValue(i1.OnBeforeUnloadDialog(args.browser(),
            args.message_text(),
            args.is_reload(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,632
        public static void OnResetDialogState(I1 i1, OnResetDialogStateArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,633
            i1.OnResetDialogState(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,634
        public static void OnDialogClosed(I1 i1, OnDialogClosedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,635
            i1.OnDialogClosed(args.browser());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,636
    public struct CefKeyboardHandler
    {
        public const int _typeNAME = 67;
        internal IntPtr nativePtr;
        public CefKeyboardHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefKeyboardHandlerExt_OnPreKeyEvent_1 = 1;
        public const int CefKeyboardHandlerExt_OnKeyEvent_2 = 2;
        //gen! bool OnPreKeyEvent(CefRefPtr<CefBrowser> browser,const CefKeyEvent& event,CefEventHandle os_event,bool* is_keyboard_shortcut)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,637
        /// <summary>
        /// Called before a keyboard event is sent to the renderer. |event| contains
        /// information about the keyboard event. |os_event| is the operating system
        /// event message, if any. Return true if the event was handled or false
        /// otherwise. If the event will be handled in OnKeyEvent() as a keyboard
        /// shortcut set |is_keyboard_shortcut| to true and return false.
        /// /*cef()*/
        /// </summary>
        public struct OnPreKeyEventArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPreKeyEventArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPreKeyEventNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPreKeyEventNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnPreKeyEventNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPreKeyEventNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefKeyEvent _event()
            {
                unsafe
                {
                    return new CefKeyEvent(((OnPreKeyEventNativeArgs*)this.nativePtr)->_event);
                }
            }
            public IntPtr os_event()
            {
                unsafe
                {
                    return ((OnPreKeyEventNativeArgs*)this.nativePtr)->os_event;
                }
            }
            public bool is_keyboard_shortcut()
            {
                unsafe
                {
                    return *(((OnPreKeyEventNativeArgs*)this.nativePtr)->is_keyboard_shortcut);
                }
            }
            public void is_keyboard_shortcut(bool value)
            {
                unsafe
                {
                    *(((OnPreKeyEventNativeArgs*)this.nativePtr)->is_keyboard_shortcut) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,638
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPreKeyEventNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr _event;
            public IntPtr os_event;
            public bool* is_keyboard_shortcut;
        }
        //gen! bool OnKeyEvent(CefRefPtr<CefBrowser> browser,const CefKeyEvent& event,CefEventHandle os_event)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,639
        /// <summary>
        /// Called after the renderer and JavaScript in the page has had a chance to
        /// handle the event. |event| contains information about the keyboard event.
        /// |os_event| is the operating system event message, if any. Return true if
        /// the keyboard event was handled or false otherwise.
        /// /*cef()*/
        /// </summary>
        public struct OnKeyEventArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnKeyEventArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnKeyEventNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnKeyEventNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnKeyEventNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnKeyEventNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefKeyEvent _event()
            {
                unsafe
                {
                    return new CefKeyEvent(((OnKeyEventNativeArgs*)this.nativePtr)->_event);
                }
            }
            public IntPtr os_event()
            {
                unsafe
                {
                    return ((OnKeyEventNativeArgs*)this.nativePtr)->os_event;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,640
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnKeyEventNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr _event;
            public IntPtr os_event;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,641
            /// <summary>
            /// Called before a keyboard event is sent to the renderer. |event| contains
            /// information about the keyboard event. |os_event| is the operating system
            /// event message, if any. Return true if the event was handled or false
            /// otherwise. If the event will be handled in OnKeyEvent() as a keyboard
            /// shortcut set |is_keyboard_shortcut| to true and return false.
            /// /*cef()*/
            /// </summary>
            void OnPreKeyEvent(OnPreKeyEventArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,642
            /// <summary>
            /// Called after the renderer and JavaScript in the page has had a chance to
            /// handle the event. |event| contains information about the keyboard event.
            /// |os_event| is the operating system event message, if any. Return true if
            /// the keyboard event was handled or false otherwise.
            /// /*cef()*/
            /// </summary>
            void OnKeyEvent(OnKeyEventArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,643
            /// <summary>
            /// Called before a keyboard event is sent to the renderer. |event| contains
            /// information about the keyboard event. |os_event| is the operating system
            /// event message, if any. Return true if the event was handled or false
            /// otherwise. If the event will be handled in OnKeyEvent() as a keyboard
            /// shortcut set |is_keyboard_shortcut| to true and return false.
            /// /*cef()*/
            /// </summary>
            bool OnPreKeyEvent(CefBrowser browser, CefKeyEvent _event, IntPtr os_event, ref bool is_keyboard_shortcut);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,644
            /// <summary>
            /// Called after the renderer and JavaScript in the page has had a chance to
            /// handle the event. |event| contains information about the keyboard event.
            /// |os_event| is the operating system event message, if any. Return true if
            /// the keyboard event was handled or false otherwise.
            /// /*cef()*/
            /// </summary>
            bool OnKeyEvent(CefBrowser browser, CefKeyEvent _event, IntPtr os_event);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,645
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,646
                case CefKeyboardHandlerExt_OnPreKeyEvent_1:
                    {
                        var args = new OnPreKeyEventArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPreKeyEvent(args);
                        }
                        if (i1 != null)
                        {
                            OnPreKeyEvent(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,647
                case CefKeyboardHandlerExt_OnKeyEvent_2:
                    {
                        var args = new OnKeyEventArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnKeyEvent(args);
                        }
                        if (i1 != null)
                        {
                            OnKeyEvent(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,648
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefKeyboardHandlerExt_OnPreKeyEvent_1:
                    i0.OnPreKeyEvent(new OnPreKeyEventArgs(nativeArgPtr));
                    break;
                case CefKeyboardHandlerExt_OnKeyEvent_2:
                    i0.OnKeyEvent(new OnKeyEventArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,649
        public static void OnPreKeyEvent(I1 i1, OnPreKeyEventArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,650
            bool is_keyboard_shortcut = false;
            args.myext_setRetValue(i1.OnPreKeyEvent(args.browser(),
            args._event(),
            args.os_event(),
            ref is_keyboard_shortcut));
            args.is_keyboard_shortcut(is_keyboard_shortcut);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,651
        public static void OnKeyEvent(I1 i1, OnKeyEventArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,652
            args.myext_setRetValue(i1.OnKeyEvent(args.browser(),
            args._event(),
            args.os_event()));
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,653
    public struct CefLifeSpanHandler
    {
        public const int _typeNAME = 68;
        internal IntPtr nativePtr;
        public CefLifeSpanHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefLifeSpanHandlerExt_OnBeforePopup_1 = 1;
        public const int CefLifeSpanHandlerExt_OnAfterCreated_2 = 2;
        public const int CefLifeSpanHandlerExt_DoClose_3 = 3;
        public const int CefLifeSpanHandlerExt_OnBeforeClose_4 = 4;
        //gen! bool OnBeforePopup(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& target_url,const CefString& target_frame_name,WindowOpenDisposition target_disposition,bool user_gesture,const CefPopupFeatures& popupFeatures,CefWindowInfo& windowInfo,CefRefPtr<CefClient>& client,CefBrowserSettings& settings,bool* no_javascript_access)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,654
        /// <summary>
        /// Called on the IO thread before a new popup browser is created. The
        /// |browser| and |frame| values represent the source of the popup request. The
        /// |target_url| and |target_frame_name| values indicate where the popup
        /// browser should navigate and may be empty if not specified with the request.
        /// The |target_disposition| value indicates where the user intended to open
        /// the popup (e.g. current tab, new tab, etc). The |user_gesture| value will
        /// be true if the popup was opened via explicit user gesture (e.g. clicking a
        /// link) or false if the popup opened automatically (e.g. via the
        /// DomContentLoaded event). The |popupFeatures| structure contains additional
        /// information about the requested popup window. To allow creation of the
        /// popup browser optionally modify |windowInfo|, |client|, |settings| and
        /// |no_javascript_access| and return false. To cancel creation of the popup
        /// browser return true. The |client| and |settings| values will default to the
        /// source browser's values. If the |no_javascript_access| value is set to
        /// false the new browser will not be scriptable and may not be hosted in the
        /// same renderer process as the source browser. Any modifications to
        /// |windowInfo| will be ignored if the parent browser is wrapped in a
        /// CefBrowserView. Popup browser creation will be canceled if the parent
        /// browser is destroyed before the popup browser creation completes (indicated
        /// by a call to OnAfterCreated for the popup browser).
        /// /*cef(optional_param=target_url,optional_param=target_frame_name)*/
        /// </summary>
        public struct OnBeforePopupArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforePopupArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforePopupNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforePopupNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnBeforePopupNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforePopupNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnBeforePopupNativeArgs*)this.nativePtr)->frame);
                }
            }
            public string target_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforePopupNativeArgs*)this.nativePtr)->target_url);
                }
            }
            public string target_frame_name()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforePopupNativeArgs*)this.nativePtr)->target_frame_name);
                }
            }
            public cef_window_open_disposition_t target_disposition()
            {
                unsafe
                {
                    return (cef_window_open_disposition_t)(((OnBeforePopupNativeArgs*)this.nativePtr)->target_disposition);
                }
            }
            public bool user_gesture()
            {
                unsafe
                {
                    return ((OnBeforePopupNativeArgs*)this.nativePtr)->user_gesture;
                }
            }
            public CefPopupFeatures popupFeatures()
            {
                unsafe
                {
                    return new CefPopupFeatures(((OnBeforePopupNativeArgs*)this.nativePtr)->popupFeatures);
                }
            }
            public CefWindowInfo windowInfo()
            {
                unsafe
                {
                    return new CefWindowInfo(((OnBeforePopupNativeArgs*)this.nativePtr)->windowInfo);
                }
            }
            public IntPtr client()
            {
                unsafe
                {
                    return ((OnBeforePopupNativeArgs*)this.nativePtr)->client;
                }
            }
            public CefBrowserSettings settings()
            {
                unsafe
                {
                    return new CefBrowserSettings(((OnBeforePopupNativeArgs*)this.nativePtr)->settings);
                }
            }
            public bool no_javascript_access()
            {
                unsafe
                {
                    return *(((OnBeforePopupNativeArgs*)this.nativePtr)->no_javascript_access);
                }
            }
            public void no_javascript_access(bool value)
            {
                unsafe
                {
                    *(((OnBeforePopupNativeArgs*)this.nativePtr)->no_javascript_access) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,655
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforePopupNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr target_url;
            public IntPtr target_frame_name;
            public cef_window_open_disposition_t target_disposition;
            public bool user_gesture;
            public IntPtr popupFeatures;
            public IntPtr windowInfo;
            public IntPtr client;
            public IntPtr settings;
            public bool* no_javascript_access;
        }
        //gen! void OnAfterCreated(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,656
        /// <summary>
        /// Called after a new browser is created. This callback will be the first
        /// notification that references |browser|.
        /// /*cef()*/
        /// </summary>
        public struct OnAfterCreatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnAfterCreatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnAfterCreatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnAfterCreatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnAfterCreatedNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,657
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnAfterCreatedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! bool DoClose(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,658
        /// <summary>
        /// Called when a browser has recieved a request to close. This may result
        /// directly from a call to CefBrowserHost::*CloseBrowser() or indirectly if
        /// the browser is parented to a top-level window created by CEF and the user
        /// attempts to close that window (by clicking the 'X', for example). The
        /// DoClose() method will be called after the JavaScript 'onunload' event has
        /// been fired.
        ///
        /// An application should handle top-level owner window close notifications by
        /// calling CefBrowserHost::TryCloseBrowser() or
        /// CefBrowserHost::CloseBrowser(false) instead of allowing the window to close
        /// immediately (see the examples below). This gives CEF an opportunity to
        /// process the 'onbeforeunload' event and optionally cancel the close before
        /// DoClose() is called.
        ///
        /// When windowed rendering is enabled CEF will internally create a window or
        /// view to host the browser. In that case returning false from DoClose() will
        /// send the standard close notification to the browser's top-level owner
        /// window (e.g. WM_CLOSE on Windows, performClose: on OS X, "delete_event" on
        /// Linux or CefWindowDelegate::CanClose() callback from Views). If the
        /// browser's host window/view has already been destroyed (via view hierarchy
        /// tear-down, for example) then DoClose() will not be called for that browser
        /// since is no longer possible to cancel the close.
        ///
        /// When windowed rendering is disabled returning false from DoClose() will
        /// cause the browser object to be destroyed immediately.
        ///
        /// If the browser's top-level owner window requires a non-standard close
        /// notification then send that notification from DoClose() and return true.
        ///
        /// The CefLifeSpanHandler::OnBeforeClose() method will be called after
        /// DoClose() (if DoClose() is called) and immediately before the browser
        /// object is destroyed. The application should only exit after OnBeforeClose()
        /// has been called for all existing browsers.
        ///
        /// The below examples describe what should happen during window close when the
        /// browser is parented to an application-provided top-level window.
        ///
        /// Example 1: Using CefBrowserHost::TryCloseBrowser(). This is recommended for
        /// clients using standard close handling and windows created on the browser
        /// process UI thread.
        /// 1.  User clicks the window close button which sends a close notification to
        ///     the application's top-level window.
        /// 2.  Application's top-level window receives the close notification and
        ///     calls TryCloseBrowser() (which internally calls CloseBrowser(false)).
        ///     TryCloseBrowser() returns false so the client cancels the window close.
        /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
        ///     confirmation dialog (which can be overridden via
        ///     CefJSDialogHandler::OnBeforeUnloadDialog()).
        /// 4.  User approves the close.
        /// 5.  JavaScript 'onunload' handler executes.
        /// 6.  CEF sends a close notification to the application's top-level window
        ///     (because DoClose() returned false by default).
        /// 7.  Application's top-level window receives the close notification and
        ///     calls TryCloseBrowser(). TryCloseBrowser() returns true so the client
        ///     allows the window close.
        /// 8.  Application's top-level window is destroyed.
        /// 9.  Application's OnBeforeClose() handler is called and the browser object
        ///     is destroyed.
        /// 10. Application exits by calling CefQuitMessageLoop() if no other browsers
        ///     exist.
        ///
        /// Example 2: Using CefBrowserHost::CloseBrowser(false) and implementing the
        /// DoClose() callback. This is recommended for clients using non-standard
        /// close handling or windows that were not created on the browser process UI
        /// thread.
        /// 1.  User clicks the window close button which sends a close notification to
        ///     the application's top-level window.
        /// 2.  Application's top-level window receives the close notification and:
        ///     A. Calls CefBrowserHost::CloseBrowser(false).
        ///     B. Cancels the window close.
        /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
        ///     confirmation dialog (which can be overridden via
        ///     CefJSDialogHandler::OnBeforeUnloadDialog()).
        /// 4.  User approves the close.
        /// 5.  JavaScript 'onunload' handler executes.
        /// 6.  Application's DoClose() handler is called. Application will:
        ///     A. Set a flag to indicate that the next close attempt will be allowed.
        ///     B. Return false.
        /// 7.  CEF sends an close notification to the application's top-level window.
        /// 8.  Application's top-level window receives the close notification and
        ///     allows the window to close based on the flag from #6B.
        /// 9.  Application's top-level window is destroyed.
        /// 10. Application's OnBeforeClose() handler is called and the browser object
        ///     is destroyed.
        /// 11. Application exits by calling CefQuitMessageLoop() if no other browsers
        ///     exist.
        /// /*cef()*/
        /// </summary>
        public struct DoCloseArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal DoCloseArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((DoCloseNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((DoCloseNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((DoCloseNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((DoCloseNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,659
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct DoCloseNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
        }
        //gen! void OnBeforeClose(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,660
        /// <summary>
        /// Called just before a browser is destroyed. Release all references to the
        /// browser object and do not attempt to execute any methods on the browser
        /// object after this callback returns. This callback will be the last
        /// notification that references |browser|. See DoClose() documentation for
        /// additional usage information.
        /// /*cef()*/
        /// </summary>
        public struct OnBeforeCloseArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeCloseArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeCloseNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeCloseNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeCloseNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,661
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeCloseNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,662
            /// <summary>
            /// Called on the IO thread before a new popup browser is created. The
            /// |browser| and |frame| values represent the source of the popup request. The
            /// |target_url| and |target_frame_name| values indicate where the popup
            /// browser should navigate and may be empty if not specified with the request.
            /// The |target_disposition| value indicates where the user intended to open
            /// the popup (e.g. current tab, new tab, etc). The |user_gesture| value will
            /// be true if the popup was opened via explicit user gesture (e.g. clicking a
            /// link) or false if the popup opened automatically (e.g. via the
            /// DomContentLoaded event). The |popupFeatures| structure contains additional
            /// information about the requested popup window. To allow creation of the
            /// popup browser optionally modify |windowInfo|, |client|, |settings| and
            /// |no_javascript_access| and return false. To cancel creation of the popup
            /// browser return true. The |client| and |settings| values will default to the
            /// source browser's values. If the |no_javascript_access| value is set to
            /// false the new browser will not be scriptable and may not be hosted in the
            /// same renderer process as the source browser. Any modifications to
            /// |windowInfo| will be ignored if the parent browser is wrapped in a
            /// CefBrowserView. Popup browser creation will be canceled if the parent
            /// browser is destroyed before the popup browser creation completes (indicated
            /// by a call to OnAfterCreated for the popup browser).
            /// /*cef(optional_param=target_url,optional_param=target_frame_name)*/
            /// </summary>
            void OnBeforePopup(OnBeforePopupArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,663
            /// <summary>
            /// Called after a new browser is created. This callback will be the first
            /// notification that references |browser|.
            /// /*cef()*/
            /// </summary>
            void OnAfterCreated(OnAfterCreatedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,664
            /// <summary>
            /// Called when a browser has recieved a request to close. This may result
            /// directly from a call to CefBrowserHost::*CloseBrowser() or indirectly if
            /// the browser is parented to a top-level window created by CEF and the user
            /// attempts to close that window (by clicking the 'X', for example). The
            /// DoClose() method will be called after the JavaScript 'onunload' event has
            /// been fired.
            ///
            /// An application should handle top-level owner window close notifications by
            /// calling CefBrowserHost::TryCloseBrowser() or
            /// CefBrowserHost::CloseBrowser(false) instead of allowing the window to close
            /// immediately (see the examples below). This gives CEF an opportunity to
            /// process the 'onbeforeunload' event and optionally cancel the close before
            /// DoClose() is called.
            ///
            /// When windowed rendering is enabled CEF will internally create a window or
            /// view to host the browser. In that case returning false from DoClose() will
            /// send the standard close notification to the browser's top-level owner
            /// window (e.g. WM_CLOSE on Windows, performClose: on OS X, "delete_event" on
            /// Linux or CefWindowDelegate::CanClose() callback from Views). If the
            /// browser's host window/view has already been destroyed (via view hierarchy
            /// tear-down, for example) then DoClose() will not be called for that browser
            /// since is no longer possible to cancel the close.
            ///
            /// When windowed rendering is disabled returning false from DoClose() will
            /// cause the browser object to be destroyed immediately.
            ///
            /// If the browser's top-level owner window requires a non-standard close
            /// notification then send that notification from DoClose() and return true.
            ///
            /// The CefLifeSpanHandler::OnBeforeClose() method will be called after
            /// DoClose() (if DoClose() is called) and immediately before the browser
            /// object is destroyed. The application should only exit after OnBeforeClose()
            /// has been called for all existing browsers.
            ///
            /// The below examples describe what should happen during window close when the
            /// browser is parented to an application-provided top-level window.
            ///
            /// Example 1: Using CefBrowserHost::TryCloseBrowser(). This is recommended for
            /// clients using standard close handling and windows created on the browser
            /// process UI thread.
            /// 1.  User clicks the window close button which sends a close notification to
            ///     the application's top-level window.
            /// 2.  Application's top-level window receives the close notification and
            ///     calls TryCloseBrowser() (which internally calls CloseBrowser(false)).
            ///     TryCloseBrowser() returns false so the client cancels the window close.
            /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
            ///     confirmation dialog (which can be overridden via
            ///     CefJSDialogHandler::OnBeforeUnloadDialog()).
            /// 4.  User approves the close.
            /// 5.  JavaScript 'onunload' handler executes.
            /// 6.  CEF sends a close notification to the application's top-level window
            ///     (because DoClose() returned false by default).
            /// 7.  Application's top-level window receives the close notification and
            ///     calls TryCloseBrowser(). TryCloseBrowser() returns true so the client
            ///     allows the window close.
            /// 8.  Application's top-level window is destroyed.
            /// 9.  Application's OnBeforeClose() handler is called and the browser object
            ///     is destroyed.
            /// 10. Application exits by calling CefQuitMessageLoop() if no other browsers
            ///     exist.
            ///
            /// Example 2: Using CefBrowserHost::CloseBrowser(false) and implementing the
            /// DoClose() callback. This is recommended for clients using non-standard
            /// close handling or windows that were not created on the browser process UI
            /// thread.
            /// 1.  User clicks the window close button which sends a close notification to
            ///     the application's top-level window.
            /// 2.  Application's top-level window receives the close notification and:
            ///     A. Calls CefBrowserHost::CloseBrowser(false).
            ///     B. Cancels the window close.
            /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
            ///     confirmation dialog (which can be overridden via
            ///     CefJSDialogHandler::OnBeforeUnloadDialog()).
            /// 4.  User approves the close.
            /// 5.  JavaScript 'onunload' handler executes.
            /// 6.  Application's DoClose() handler is called. Application will:
            ///     A. Set a flag to indicate that the next close attempt will be allowed.
            ///     B. Return false.
            /// 7.  CEF sends an close notification to the application's top-level window.
            /// 8.  Application's top-level window receives the close notification and
            ///     allows the window to close based on the flag from #6B.
            /// 9.  Application's top-level window is destroyed.
            /// 10. Application's OnBeforeClose() handler is called and the browser object
            ///     is destroyed.
            /// 11. Application exits by calling CefQuitMessageLoop() if no other browsers
            ///     exist.
            /// /*cef()*/
            /// </summary>
            void DoClose(DoCloseArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,665
            /// <summary>
            /// Called just before a browser is destroyed. Release all references to the
            /// browser object and do not attempt to execute any methods on the browser
            /// object after this callback returns. This callback will be the last
            /// notification that references |browser|. See DoClose() documentation for
            /// additional usage information.
            /// /*cef()*/
            /// </summary>
            void OnBeforeClose(OnBeforeCloseArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,666
            /// <summary>
            /// Called on the IO thread before a new popup browser is created. The
            /// |browser| and |frame| values represent the source of the popup request. The
            /// |target_url| and |target_frame_name| values indicate where the popup
            /// browser should navigate and may be empty if not specified with the request.
            /// The |target_disposition| value indicates where the user intended to open
            /// the popup (e.g. current tab, new tab, etc). The |user_gesture| value will
            /// be true if the popup was opened via explicit user gesture (e.g. clicking a
            /// link) or false if the popup opened automatically (e.g. via the
            /// DomContentLoaded event). The |popupFeatures| structure contains additional
            /// information about the requested popup window. To allow creation of the
            /// popup browser optionally modify |windowInfo|, |client|, |settings| and
            /// |no_javascript_access| and return false. To cancel creation of the popup
            /// browser return true. The |client| and |settings| values will default to the
            /// source browser's values. If the |no_javascript_access| value is set to
            /// false the new browser will not be scriptable and may not be hosted in the
            /// same renderer process as the source browser. Any modifications to
            /// |windowInfo| will be ignored if the parent browser is wrapped in a
            /// CefBrowserView. Popup browser creation will be canceled if the parent
            /// browser is destroyed before the popup browser creation completes (indicated
            /// by a call to OnAfterCreated for the popup browser).
            /// /*cef(optional_param=target_url,optional_param=target_frame_name)*/
            /// </summary>
            bool OnBeforePopup(CefBrowser browser, CefFrame frame, string target_url, string target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, IntPtr client, CefBrowserSettings settings, ref bool no_javascript_access);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,667
            /// <summary>
            /// Called after a new browser is created. This callback will be the first
            /// notification that references |browser|.
            /// /*cef()*/
            /// </summary>
            void OnAfterCreated(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,668
            /// <summary>
            /// Called when a browser has recieved a request to close. This may result
            /// directly from a call to CefBrowserHost::*CloseBrowser() or indirectly if
            /// the browser is parented to a top-level window created by CEF and the user
            /// attempts to close that window (by clicking the 'X', for example). The
            /// DoClose() method will be called after the JavaScript 'onunload' event has
            /// been fired.
            ///
            /// An application should handle top-level owner window close notifications by
            /// calling CefBrowserHost::TryCloseBrowser() or
            /// CefBrowserHost::CloseBrowser(false) instead of allowing the window to close
            /// immediately (see the examples below). This gives CEF an opportunity to
            /// process the 'onbeforeunload' event and optionally cancel the close before
            /// DoClose() is called.
            ///
            /// When windowed rendering is enabled CEF will internally create a window or
            /// view to host the browser. In that case returning false from DoClose() will
            /// send the standard close notification to the browser's top-level owner
            /// window (e.g. WM_CLOSE on Windows, performClose: on OS X, "delete_event" on
            /// Linux or CefWindowDelegate::CanClose() callback from Views). If the
            /// browser's host window/view has already been destroyed (via view hierarchy
            /// tear-down, for example) then DoClose() will not be called for that browser
            /// since is no longer possible to cancel the close.
            ///
            /// When windowed rendering is disabled returning false from DoClose() will
            /// cause the browser object to be destroyed immediately.
            ///
            /// If the browser's top-level owner window requires a non-standard close
            /// notification then send that notification from DoClose() and return true.
            ///
            /// The CefLifeSpanHandler::OnBeforeClose() method will be called after
            /// DoClose() (if DoClose() is called) and immediately before the browser
            /// object is destroyed. The application should only exit after OnBeforeClose()
            /// has been called for all existing browsers.
            ///
            /// The below examples describe what should happen during window close when the
            /// browser is parented to an application-provided top-level window.
            ///
            /// Example 1: Using CefBrowserHost::TryCloseBrowser(). This is recommended for
            /// clients using standard close handling and windows created on the browser
            /// process UI thread.
            /// 1.  User clicks the window close button which sends a close notification to
            ///     the application's top-level window.
            /// 2.  Application's top-level window receives the close notification and
            ///     calls TryCloseBrowser() (which internally calls CloseBrowser(false)).
            ///     TryCloseBrowser() returns false so the client cancels the window close.
            /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
            ///     confirmation dialog (which can be overridden via
            ///     CefJSDialogHandler::OnBeforeUnloadDialog()).
            /// 4.  User approves the close.
            /// 5.  JavaScript 'onunload' handler executes.
            /// 6.  CEF sends a close notification to the application's top-level window
            ///     (because DoClose() returned false by default).
            /// 7.  Application's top-level window receives the close notification and
            ///     calls TryCloseBrowser(). TryCloseBrowser() returns true so the client
            ///     allows the window close.
            /// 8.  Application's top-level window is destroyed.
            /// 9.  Application's OnBeforeClose() handler is called and the browser object
            ///     is destroyed.
            /// 10. Application exits by calling CefQuitMessageLoop() if no other browsers
            ///     exist.
            ///
            /// Example 2: Using CefBrowserHost::CloseBrowser(false) and implementing the
            /// DoClose() callback. This is recommended for clients using non-standard
            /// close handling or windows that were not created on the browser process UI
            /// thread.
            /// 1.  User clicks the window close button which sends a close notification to
            ///     the application's top-level window.
            /// 2.  Application's top-level window receives the close notification and:
            ///     A. Calls CefBrowserHost::CloseBrowser(false).
            ///     B. Cancels the window close.
            /// 3.  JavaScript 'onbeforeunload' handler executes and shows the close
            ///     confirmation dialog (which can be overridden via
            ///     CefJSDialogHandler::OnBeforeUnloadDialog()).
            /// 4.  User approves the close.
            /// 5.  JavaScript 'onunload' handler executes.
            /// 6.  Application's DoClose() handler is called. Application will:
            ///     A. Set a flag to indicate that the next close attempt will be allowed.
            ///     B. Return false.
            /// 7.  CEF sends an close notification to the application's top-level window.
            /// 8.  Application's top-level window receives the close notification and
            ///     allows the window to close based on the flag from #6B.
            /// 9.  Application's top-level window is destroyed.
            /// 10. Application's OnBeforeClose() handler is called and the browser object
            ///     is destroyed.
            /// 11. Application exits by calling CefQuitMessageLoop() if no other browsers
            ///     exist.
            /// /*cef()*/
            /// </summary>
            bool DoClose(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,669
            /// <summary>
            /// Called just before a browser is destroyed. Release all references to the
            /// browser object and do not attempt to execute any methods on the browser
            /// object after this callback returns. This callback will be the last
            /// notification that references |browser|. See DoClose() documentation for
            /// additional usage information.
            /// /*cef()*/
            /// </summary>
            void OnBeforeClose(CefBrowser browser);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,670
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,671
                case CefLifeSpanHandlerExt_OnBeforePopup_1:
                    {
                        var args = new OnBeforePopupArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforePopup(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforePopup(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,672
                case CefLifeSpanHandlerExt_OnAfterCreated_2:
                    {
                        var args = new OnAfterCreatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnAfterCreated(args);
                        }
                        if (i1 != null)
                        {
                            OnAfterCreated(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,673
                case CefLifeSpanHandlerExt_DoClose_3:
                    {
                        var args = new DoCloseArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.DoClose(args);
                        }
                        if (i1 != null)
                        {
                            DoClose(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,674
                case CefLifeSpanHandlerExt_OnBeforeClose_4:
                    {
                        var args = new OnBeforeCloseArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeClose(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeClose(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,675
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefLifeSpanHandlerExt_OnBeforePopup_1:
                    i0.OnBeforePopup(new OnBeforePopupArgs(nativeArgPtr));
                    break;
                case CefLifeSpanHandlerExt_OnAfterCreated_2:
                    i0.OnAfterCreated(new OnAfterCreatedArgs(nativeArgPtr));
                    break;
                case CefLifeSpanHandlerExt_DoClose_3:
                    i0.DoClose(new DoCloseArgs(nativeArgPtr));
                    break;
                case CefLifeSpanHandlerExt_OnBeforeClose_4:
                    i0.OnBeforeClose(new OnBeforeCloseArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,676
        public static void OnBeforePopup(I1 i1, OnBeforePopupArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,677
            bool no_javascript_access = false;
            args.myext_setRetValue(i1.OnBeforePopup(args.browser(),
            args.frame(),
            args.target_url(),
            args.target_frame_name(),
            args.target_disposition(),
            args.user_gesture(),
            args.popupFeatures(),
            args.windowInfo(),
            args.client(),
            args.settings(),
            ref no_javascript_access));
            args.no_javascript_access(no_javascript_access);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,678
        public static void OnAfterCreated(I1 i1, OnAfterCreatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,679
            i1.OnAfterCreated(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,680
        public static void DoClose(I1 i1, DoCloseArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,681
            args.myext_setRetValue(i1.DoClose(args.browser()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,682
        public static void OnBeforeClose(I1 i1, OnBeforeCloseArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,683
            i1.OnBeforeClose(args.browser());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,684
    public struct CefLoadHandler
    {
        public const int _typeNAME = 69;
        internal IntPtr nativePtr;
        public CefLoadHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefLoadHandlerExt_OnLoadingStateChange_1 = 1;
        public const int CefLoadHandlerExt_OnLoadStart_2 = 2;
        public const int CefLoadHandlerExt_OnLoadEnd_3 = 3;
        public const int CefLoadHandlerExt_OnLoadError_4 = 4;
        //gen! void OnLoadingStateChange(CefRefPtr<CefBrowser> browser,bool isLoading,bool canGoBack,bool canGoForward)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,685
        /// <summary>
        /// Called when the loading state has changed. This callback will be executed
        /// twice -- once when loading is initiated either programmatically or by user
        /// action, and once when loading is terminated due to completion, cancellation
        /// of failure. It will be called before any calls to OnLoadStart and after all
        /// calls to OnLoadError and/or OnLoadEnd.
        /// /*cef()*/
        /// </summary>
        public struct OnLoadingStateChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnLoadingStateChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnLoadingStateChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnLoadingStateChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnLoadingStateChangeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public bool isLoading()
            {
                unsafe
                {
                    return ((OnLoadingStateChangeNativeArgs*)this.nativePtr)->isLoading;
                }
            }
            public bool canGoBack()
            {
                unsafe
                {
                    return ((OnLoadingStateChangeNativeArgs*)this.nativePtr)->canGoBack;
                }
            }
            public bool canGoForward()
            {
                unsafe
                {
                    return ((OnLoadingStateChangeNativeArgs*)this.nativePtr)->canGoForward;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,686
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnLoadingStateChangeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public bool isLoading;
            public bool canGoBack;
            public bool canGoForward;
        }
        //gen! void OnLoadStart(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,TransitionType transition_type)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,687
        /// <summary>
        /// Called after a navigation has been committed and before the browser begins
        /// loading contents in the frame. The |frame| value will never be empty --
        /// call the IsMain() method to check if this frame is the main frame.
        /// |transition_type| provides information about the source of the navigation
        /// and an accurate value is only available in the browser process. Multiple
        /// frames may be loading at the same time. Sub-frames may start or continue
        /// loading after the main frame load has ended. This method will not be called
        /// for same page navigations (fragments, history state, etc.) or for
        /// navigations that fail or are canceled before commit. For notification of
        /// overall browser load status use OnLoadingStateChange instead.
        /// /*cef()*/
        /// </summary>
        public struct OnLoadStartArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnLoadStartArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnLoadStartNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnLoadStartNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnLoadStartNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnLoadStartNativeArgs*)this.nativePtr)->frame);
                }
            }
            public cef_transition_type_t transition_type()
            {
                unsafe
                {
                    return (cef_transition_type_t)(((OnLoadStartNativeArgs*)this.nativePtr)->transition_type);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,688
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnLoadStartNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public cef_transition_type_t transition_type;
        }
        //gen! void OnLoadEnd(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,int httpStatusCode)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,689
        /// <summary>
        /// Called when the browser is done loading a frame. The |frame| value will
        /// never be empty -- call the IsMain() method to check if this frame is the
        /// main frame. Multiple frames may be loading at the same time. Sub-frames may
        /// start or continue loading after the main frame load has ended. This method
        /// will not be called for same page navigations (fragments, history state,
        /// etc.) or for navigations that fail or are canceled before commit. For
        /// notification of overall browser load status use OnLoadingStateChange
        /// instead.
        /// /*cef()*/
        /// </summary>
        public struct OnLoadEndArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnLoadEndArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnLoadEndNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnLoadEndNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnLoadEndNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnLoadEndNativeArgs*)this.nativePtr)->frame);
                }
            }
            public int httpStatusCode()
            {
                unsafe
                {
                    return ((OnLoadEndNativeArgs*)this.nativePtr)->httpStatusCode;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,690
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnLoadEndNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public int httpStatusCode;
        }
        //gen! void OnLoadError(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,ErrorCode errorCode,const CefString& errorText,const CefString& failedUrl)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,691
        /// <summary>
        /// Called when a navigation fails or is canceled. This method may be called
        /// by itself if before commit or in combination with OnLoadStart/OnLoadEnd if
        /// after commit. |errorCode| is the error code number, |errorText| is the
        /// error text and |failedUrl| is the URL that failed to load.
        /// See net\base\net_error_list.h for complete descriptions of the error codes.
        /// /*cef(optional_param=errorText)*/
        /// </summary>
        public struct OnLoadErrorArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnLoadErrorArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnLoadErrorNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnLoadErrorNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnLoadErrorNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnLoadErrorNativeArgs*)this.nativePtr)->frame);
                }
            }
            public cef_errorcode_t errorCode()
            {
                unsafe
                {
                    return (cef_errorcode_t)(((OnLoadErrorNativeArgs*)this.nativePtr)->errorCode);
                }
            }
            public string errorText()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnLoadErrorNativeArgs*)this.nativePtr)->errorText);
                }
            }
            public string failedUrl()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnLoadErrorNativeArgs*)this.nativePtr)->failedUrl);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,692
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnLoadErrorNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public cef_errorcode_t errorCode;
            public IntPtr errorText;
            public IntPtr failedUrl;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,693
            /// <summary>
            /// Called when the loading state has changed. This callback will be executed
            /// twice -- once when loading is initiated either programmatically or by user
            /// action, and once when loading is terminated due to completion, cancellation
            /// of failure. It will be called before any calls to OnLoadStart and after all
            /// calls to OnLoadError and/or OnLoadEnd.
            /// /*cef()*/
            /// </summary>
            void OnLoadingStateChange(OnLoadingStateChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,694
            /// <summary>
            /// Called after a navigation has been committed and before the browser begins
            /// loading contents in the frame. The |frame| value will never be empty --
            /// call the IsMain() method to check if this frame is the main frame.
            /// |transition_type| provides information about the source of the navigation
            /// and an accurate value is only available in the browser process. Multiple
            /// frames may be loading at the same time. Sub-frames may start or continue
            /// loading after the main frame load has ended. This method will not be called
            /// for same page navigations (fragments, history state, etc.) or for
            /// navigations that fail or are canceled before commit. For notification of
            /// overall browser load status use OnLoadingStateChange instead.
            /// /*cef()*/
            /// </summary>
            void OnLoadStart(OnLoadStartArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,695
            /// <summary>
            /// Called when the browser is done loading a frame. The |frame| value will
            /// never be empty -- call the IsMain() method to check if this frame is the
            /// main frame. Multiple frames may be loading at the same time. Sub-frames may
            /// start or continue loading after the main frame load has ended. This method
            /// will not be called for same page navigations (fragments, history state,
            /// etc.) or for navigations that fail or are canceled before commit. For
            /// notification of overall browser load status use OnLoadingStateChange
            /// instead.
            /// /*cef()*/
            /// </summary>
            void OnLoadEnd(OnLoadEndArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,696
            /// <summary>
            /// Called when a navigation fails or is canceled. This method may be called
            /// by itself if before commit or in combination with OnLoadStart/OnLoadEnd if
            /// after commit. |errorCode| is the error code number, |errorText| is the
            /// error text and |failedUrl| is the URL that failed to load.
            /// See net\base\net_error_list.h for complete descriptions of the error codes.
            /// /*cef(optional_param=errorText)*/
            /// </summary>
            void OnLoadError(OnLoadErrorArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,697
            /// <summary>
            /// Called when the loading state has changed. This callback will be executed
            /// twice -- once when loading is initiated either programmatically or by user
            /// action, and once when loading is terminated due to completion, cancellation
            /// of failure. It will be called before any calls to OnLoadStart and after all
            /// calls to OnLoadError and/or OnLoadEnd.
            /// /*cef()*/
            /// </summary>
            void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,698
            /// <summary>
            /// Called after a navigation has been committed and before the browser begins
            /// loading contents in the frame. The |frame| value will never be empty --
            /// call the IsMain() method to check if this frame is the main frame.
            /// |transition_type| provides information about the source of the navigation
            /// and an accurate value is only available in the browser process. Multiple
            /// frames may be loading at the same time. Sub-frames may start or continue
            /// loading after the main frame load has ended. This method will not be called
            /// for same page navigations (fragments, history state, etc.) or for
            /// navigations that fail or are canceled before commit. For notification of
            /// overall browser load status use OnLoadingStateChange instead.
            /// /*cef()*/
            /// </summary>
            void OnLoadStart(CefBrowser browser, CefFrame frame, cef_transition_type_t transition_type);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,699
            /// <summary>
            /// Called when the browser is done loading a frame. The |frame| value will
            /// never be empty -- call the IsMain() method to check if this frame is the
            /// main frame. Multiple frames may be loading at the same time. Sub-frames may
            /// start or continue loading after the main frame load has ended. This method
            /// will not be called for same page navigations (fragments, history state,
            /// etc.) or for navigations that fail or are canceled before commit. For
            /// notification of overall browser load status use OnLoadingStateChange
            /// instead.
            /// /*cef()*/
            /// </summary>
            void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,700
            /// <summary>
            /// Called when a navigation fails or is canceled. This method may be called
            /// by itself if before commit or in combination with OnLoadStart/OnLoadEnd if
            /// after commit. |errorCode| is the error code number, |errorText| is the
            /// error text and |failedUrl| is the URL that failed to load.
            /// See net\base\net_error_list.h for complete descriptions of the error codes.
            /// /*cef(optional_param=errorText)*/
            /// </summary>
            void OnLoadError(CefBrowser browser, CefFrame frame, cef_errorcode_t errorCode, string errorText, string failedUrl);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,701
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,702
                case CefLoadHandlerExt_OnLoadingStateChange_1:
                    {
                        var args = new OnLoadingStateChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnLoadingStateChange(args);
                        }
                        if (i1 != null)
                        {
                            OnLoadingStateChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,703
                case CefLoadHandlerExt_OnLoadStart_2:
                    {
                        var args = new OnLoadStartArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnLoadStart(args);
                        }
                        if (i1 != null)
                        {
                            OnLoadStart(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,704
                case CefLoadHandlerExt_OnLoadEnd_3:
                    {
                        var args = new OnLoadEndArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnLoadEnd(args);
                        }
                        if (i1 != null)
                        {
                            OnLoadEnd(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,705
                case CefLoadHandlerExt_OnLoadError_4:
                    {
                        var args = new OnLoadErrorArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnLoadError(args);
                        }
                        if (i1 != null)
                        {
                            OnLoadError(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,706
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefLoadHandlerExt_OnLoadingStateChange_1:
                    i0.OnLoadingStateChange(new OnLoadingStateChangeArgs(nativeArgPtr));
                    break;
                case CefLoadHandlerExt_OnLoadStart_2:
                    i0.OnLoadStart(new OnLoadStartArgs(nativeArgPtr));
                    break;
                case CefLoadHandlerExt_OnLoadEnd_3:
                    i0.OnLoadEnd(new OnLoadEndArgs(nativeArgPtr));
                    break;
                case CefLoadHandlerExt_OnLoadError_4:
                    i0.OnLoadError(new OnLoadErrorArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,707
        public static void OnLoadingStateChange(I1 i1, OnLoadingStateChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,708
            i1.OnLoadingStateChange(args.browser(),
            args.isLoading(),
            args.canGoBack(),
            args.canGoForward());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,709
        public static void OnLoadStart(I1 i1, OnLoadStartArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,710
            i1.OnLoadStart(args.browser(),
            args.frame(),
            args.transition_type());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,711
        public static void OnLoadEnd(I1 i1, OnLoadEndArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,712
            i1.OnLoadEnd(args.browser(),
            args.frame(),
            args.httpStatusCode());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,713
        public static void OnLoadError(I1 i1, OnLoadErrorArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,714
            i1.OnLoadError(args.browser(),
            args.frame(),
            args.errorCode(),
            args.errorText(),
            args.failedUrl());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,715
    public struct CefPrintHandler
    {
        public const int _typeNAME = 70;
        internal IntPtr nativePtr;
        public CefPrintHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefPrintHandlerExt_OnPrintStart_1 = 1;
        public const int CefPrintHandlerExt_OnPrintSettings_2 = 2;
        public const int CefPrintHandlerExt_OnPrintDialog_3 = 3;
        public const int CefPrintHandlerExt_OnPrintJob_4 = 4;
        public const int CefPrintHandlerExt_OnPrintReset_5 = 5;
        public const int CefPrintHandlerExt_GetPdfPaperSize_6 = 6;
        //gen! void OnPrintStart(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,716
        /// <summary>
        /// Called when printing has started for the specified |browser|. This method
        /// will be called before the other OnPrint*() methods and irrespective of how
        /// printing was initiated (e.g. CefBrowserHost::Print(), JavaScript
        /// window.print() or PDF extension print button).
        /// /*cef()*/
        /// </summary>
        public struct OnPrintStartArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPrintStartArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPrintStartNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPrintStartNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPrintStartNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,717
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPrintStartNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! void OnPrintSettings(CefRefPtr<CefBrowser> browser,CefRefPtr<CefPrintSettings> settings,bool get_defaults)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,718
        /// <summary>
        /// Synchronize |settings| with client state. If |get_defaults| is true then
        /// populate |settings| with the default print settings. Do not keep a
        /// reference to |settings| outside of this callback.
        /// /*cef()*/
        /// </summary>
        public struct OnPrintSettingsArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPrintSettingsArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPrintSettingsNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPrintSettingsNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPrintSettingsNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefPrintSettings settings()
            {
                unsafe
                {
                    return new CefPrintSettings(((OnPrintSettingsNativeArgs*)this.nativePtr)->settings);
                }
            }
            public bool get_defaults()
            {
                unsafe
                {
                    return ((OnPrintSettingsNativeArgs*)this.nativePtr)->get_defaults;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,719
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPrintSettingsNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr settings;
            public bool get_defaults;
        }
        //gen! bool OnPrintDialog(CefRefPtr<CefBrowser> browser,bool has_selection,CefRefPtr<CefPrintDialogCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,720
        /// <summary>
        /// Show the print dialog. Execute |callback| once the dialog is dismissed.
        /// Return true if the dialog will be displayed or false to cancel the
        /// printing immediately.
        /// /*cef()*/
        /// </summary>
        public struct OnPrintDialogArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPrintDialogArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPrintDialogNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPrintDialogNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnPrintDialogNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPrintDialogNativeArgs*)this.nativePtr)->browser);
                }
            }
            public bool has_selection()
            {
                unsafe
                {
                    return ((OnPrintDialogNativeArgs*)this.nativePtr)->has_selection;
                }
            }
            public CefPrintDialogCallback callback()
            {
                unsafe
                {
                    return new CefPrintDialogCallback(((OnPrintDialogNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,721
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPrintDialogNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public bool has_selection;
            public IntPtr callback;
        }
        //gen! bool OnPrintJob(CefRefPtr<CefBrowser> browser,const CefString& document_name,const CefString& pdf_file_path,CefRefPtr<CefPrintJobCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,722
        /// <summary>
        /// Send the print job to the printer. Execute |callback| once the job is
        /// completed. Return true if the job will proceed or false to cancel the job
        /// immediately.
        /// /*cef()*/
        /// </summary>
        public struct OnPrintJobArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPrintJobArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPrintJobNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPrintJobNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnPrintJobNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPrintJobNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string document_name()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnPrintJobNativeArgs*)this.nativePtr)->document_name);
                }
            }
            public string pdf_file_path()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnPrintJobNativeArgs*)this.nativePtr)->pdf_file_path);
                }
            }
            public CefPrintJobCallback callback()
            {
                unsafe
                {
                    return new CefPrintJobCallback(((OnPrintJobNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,723
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPrintJobNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr document_name;
            public IntPtr pdf_file_path;
            public IntPtr callback;
        }
        //gen! void OnPrintReset(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,724
        /// <summary>
        /// Reset client state related to printing.
        /// /*cef()*/
        /// </summary>
        public struct OnPrintResetArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPrintResetArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPrintResetNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPrintResetNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPrintResetNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,725
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPrintResetNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! CefSize GetPdfPaperSize(int device_units_per_inch)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,726
        /// <summary>
        /// Return the PDF paper size in device units. Used in combination with
        /// CefBrowserHost::PrintToPDF().
        /// /*cef()*/
        /// </summary>
        public struct GetPdfPaperSizeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetPdfPaperSizeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetPdfPaperSizeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetPdfPaperSizeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value_w,
            int value_h)
            {
                unsafe
                {
                    ((GetPdfPaperSizeNativeArgs*)this.nativePtr)->myext_ret_value_w = value_w;
                    ((GetPdfPaperSizeNativeArgs*)this.nativePtr)->myext_ret_value_h = value_h;
                }
            }
            public int device_units_per_inch()
            {
                unsafe
                {
                    return ((GetPdfPaperSizeNativeArgs*)this.nativePtr)->device_units_per_inch;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,727
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetPdfPaperSizeNativeArgs
        {
            public int argFlags;
            public int myext_ret_value_w;
            public int myext_ret_value_h;
            public int device_units_per_inch;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,728
            /// <summary>
            /// Called when printing has started for the specified |browser|. This method
            /// will be called before the other OnPrint*() methods and irrespective of how
            /// printing was initiated (e.g. CefBrowserHost::Print(), JavaScript
            /// window.print() or PDF extension print button).
            /// /*cef()*/
            /// </summary>
            void OnPrintStart(OnPrintStartArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,729
            /// <summary>
            /// Synchronize |settings| with client state. If |get_defaults| is true then
            /// populate |settings| with the default print settings. Do not keep a
            /// reference to |settings| outside of this callback.
            /// /*cef()*/
            /// </summary>
            void OnPrintSettings(OnPrintSettingsArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,730
            /// <summary>
            /// Show the print dialog. Execute |callback| once the dialog is dismissed.
            /// Return true if the dialog will be displayed or false to cancel the
            /// printing immediately.
            /// /*cef()*/
            /// </summary>
            void OnPrintDialog(OnPrintDialogArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,731
            /// <summary>
            /// Send the print job to the printer. Execute |callback| once the job is
            /// completed. Return true if the job will proceed or false to cancel the job
            /// immediately.
            /// /*cef()*/
            /// </summary>
            void OnPrintJob(OnPrintJobArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,732
            /// <summary>
            /// Reset client state related to printing.
            /// /*cef()*/
            /// </summary>
            void OnPrintReset(OnPrintResetArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,733
            /// <summary>
            /// Return the PDF paper size in device units. Used in combination with
            /// CefBrowserHost::PrintToPDF().
            /// /*cef()*/
            /// </summary>
            void GetPdfPaperSize(GetPdfPaperSizeArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,734
            /// <summary>
            /// Called when printing has started for the specified |browser|. This method
            /// will be called before the other OnPrint*() methods and irrespective of how
            /// printing was initiated (e.g. CefBrowserHost::Print(), JavaScript
            /// window.print() or PDF extension print button).
            /// /*cef()*/
            /// </summary>
            void OnPrintStart(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,735
            /// <summary>
            /// Synchronize |settings| with client state. If |get_defaults| is true then
            /// populate |settings| with the default print settings. Do not keep a
            /// reference to |settings| outside of this callback.
            /// /*cef()*/
            /// </summary>
            void OnPrintSettings(CefBrowser browser, CefPrintSettings settings, bool get_defaults);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,736
            /// <summary>
            /// Show the print dialog. Execute |callback| once the dialog is dismissed.
            /// Return true if the dialog will be displayed or false to cancel the
            /// printing immediately.
            /// /*cef()*/
            /// </summary>
            bool OnPrintDialog(CefBrowser browser, bool has_selection, CefPrintDialogCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,737
            /// <summary>
            /// Send the print job to the printer. Execute |callback| once the job is
            /// completed. Return true if the job will proceed or false to cancel the job
            /// immediately.
            /// /*cef()*/
            /// </summary>
            bool OnPrintJob(CefBrowser browser, string document_name, string pdf_file_path, CefPrintJobCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,738
            /// <summary>
            /// Reset client state related to printing.
            /// /*cef()*/
            /// </summary>
            void OnPrintReset(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,739
            /// <summary>
            /// Return the PDF paper size in device units. Used in combination with
            /// CefBrowserHost::PrintToPDF().
            /// /*cef()*/
            /// </summary>
            CefSize GetPdfPaperSize(int device_units_per_inch);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,740
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,741
                case CefPrintHandlerExt_OnPrintStart_1:
                    {
                        var args = new OnPrintStartArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPrintStart(args);
                        }
                        if (i1 != null)
                        {
                            OnPrintStart(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,742
                case CefPrintHandlerExt_OnPrintSettings_2:
                    {
                        var args = new OnPrintSettingsArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPrintSettings(args);
                        }
                        if (i1 != null)
                        {
                            OnPrintSettings(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,743
                case CefPrintHandlerExt_OnPrintDialog_3:
                    {
                        var args = new OnPrintDialogArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPrintDialog(args);
                        }
                        if (i1 != null)
                        {
                            OnPrintDialog(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,744
                case CefPrintHandlerExt_OnPrintJob_4:
                    {
                        var args = new OnPrintJobArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPrintJob(args);
                        }
                        if (i1 != null)
                        {
                            OnPrintJob(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,745
                case CefPrintHandlerExt_OnPrintReset_5:
                    {
                        var args = new OnPrintResetArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPrintReset(args);
                        }
                        if (i1 != null)
                        {
                            OnPrintReset(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,746
                case CefPrintHandlerExt_GetPdfPaperSize_6:
                    {
                        var args = new GetPdfPaperSizeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetPdfPaperSize(args);
                        }
                        if (i1 != null)
                        {
                            GetPdfPaperSize(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,747
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefPrintHandlerExt_OnPrintStart_1:
                    i0.OnPrintStart(new OnPrintStartArgs(nativeArgPtr));
                    break;
                case CefPrintHandlerExt_OnPrintSettings_2:
                    i0.OnPrintSettings(new OnPrintSettingsArgs(nativeArgPtr));
                    break;
                case CefPrintHandlerExt_OnPrintDialog_3:
                    i0.OnPrintDialog(new OnPrintDialogArgs(nativeArgPtr));
                    break;
                case CefPrintHandlerExt_OnPrintJob_4:
                    i0.OnPrintJob(new OnPrintJobArgs(nativeArgPtr));
                    break;
                case CefPrintHandlerExt_OnPrintReset_5:
                    i0.OnPrintReset(new OnPrintResetArgs(nativeArgPtr));
                    break;
                case CefPrintHandlerExt_GetPdfPaperSize_6:
                    i0.GetPdfPaperSize(new GetPdfPaperSizeArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,748
        public static void OnPrintStart(I1 i1, OnPrintStartArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,749
            i1.OnPrintStart(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,750
        public static void OnPrintSettings(I1 i1, OnPrintSettingsArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,751
            i1.OnPrintSettings(args.browser(),
            args.settings(),
            args.get_defaults());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,752
        public static void OnPrintDialog(I1 i1, OnPrintDialogArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,753
            args.myext_setRetValue(i1.OnPrintDialog(args.browser(),
            args.has_selection(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,754
        public static void OnPrintJob(I1 i1, OnPrintJobArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,755
            args.myext_setRetValue(i1.OnPrintJob(args.browser(),
            args.document_name(),
            args.pdf_file_path(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,756
        public static void OnPrintReset(I1 i1, OnPrintResetArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,757
            i1.OnPrintReset(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,758
        public static void GetPdfPaperSize(I1 i1, GetPdfPaperSizeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,759
            i1.GetPdfPaperSize(args.device_units_per_inch());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,760
    public struct CefRenderHandler
    {
        public const int _typeNAME = 71;
        internal IntPtr nativePtr;
        public CefRenderHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefRenderHandlerExt_GetAccessibilityHandler_1 = 1;
        public const int CefRenderHandlerExt_GetRootScreenRect_2 = 2;
        public const int CefRenderHandlerExt_GetViewRect_3 = 3;
        public const int CefRenderHandlerExt_GetScreenPoint_4 = 4;
        public const int CefRenderHandlerExt_GetScreenInfo_5 = 5;
        public const int CefRenderHandlerExt_OnPopupShow_6 = 6;
        public const int CefRenderHandlerExt_OnPopupSize_7 = 7;
        public const int CefRenderHandlerExt_OnPaint_8 = 8;
        public const int CefRenderHandlerExt_OnCursorChange_9 = 9;
        public const int CefRenderHandlerExt_StartDragging_10 = 10;
        public const int CefRenderHandlerExt_UpdateDragCursor_11 = 11;
        public const int CefRenderHandlerExt_OnScrollOffsetChanged_12 = 12;
        public const int CefRenderHandlerExt_OnImeCompositionRangeChanged_13 = 13;
        //gen! CefRefPtr<CefAccessibilityHandler> GetAccessibilityHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,761
        /// <summary>
        /// Return the handler for accessibility notifications. If no handler is
        /// provided the default implementation will be used.
        /// /*cef()*/
        /// </summary>
        public struct GetAccessibilityHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetAccessibilityHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetAccessibilityHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetAccessibilityHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetAccessibilityHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,762
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetAccessibilityHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! bool GetRootScreenRect(CefRefPtr<CefBrowser> browser,CefRect& rect)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,763
        /// <summary>
        /// Called to retrieve the root window rectangle in screen coordinates. Return
        /// true if the rectangle was provided.
        /// /*cef()*/
        /// </summary>
        public struct GetRootScreenRectArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetRootScreenRectArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetRootScreenRectNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetRootScreenRectNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetRootScreenRectNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetRootScreenRectNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefRect rect()
            {
                unsafe
                {
                    return new CefRect(((GetRootScreenRectNativeArgs*)this.nativePtr)->rect);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,764
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetRootScreenRectNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr rect;
        }
        //gen! bool GetViewRect(CefRefPtr<CefBrowser> browser,CefRect& rect)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,765
        /// <summary>
        /// Called to retrieve the view rectangle which is relative to screen
        /// coordinates. Return true if the rectangle was provided.
        /// /*cef()*/
        /// </summary>
        public struct GetViewRectArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetViewRectArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetViewRectNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetViewRectNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetViewRectNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetViewRectNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefRect rect()
            {
                unsafe
                {
                    return new CefRect(((GetViewRectNativeArgs*)this.nativePtr)->rect);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,766
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetViewRectNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr rect;
        }
        //gen! bool GetScreenPoint(CefRefPtr<CefBrowser> browser,int viewX,int viewY,int& screenX,int& screenY)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,767
        /// <summary>
        /// Called to retrieve the translation from view coordinates to actual screen
        /// coordinates. Return true if the screen coordinates were provided.
        /// /*cef()*/
        /// </summary>
        public struct GetScreenPointArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetScreenPointArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetScreenPointNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetScreenPointNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetScreenPointNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetScreenPointNativeArgs*)this.nativePtr)->browser);
                }
            }
            public int viewX()
            {
                unsafe
                {
                    return ((GetScreenPointNativeArgs*)this.nativePtr)->viewX;
                }
            }
            public int viewY()
            {
                unsafe
                {
                    return ((GetScreenPointNativeArgs*)this.nativePtr)->viewY;
                }
            }
            public int screenX()
            {
                unsafe
                {
                    return *(((GetScreenPointNativeArgs*)this.nativePtr)->screenX);
                }
            }
            public void screenX(int value)
            {
                unsafe
                {
                    *(((GetScreenPointNativeArgs*)this.nativePtr)->screenX) = value;
                }
            }
            public int screenY()
            {
                unsafe
                {
                    return *(((GetScreenPointNativeArgs*)this.nativePtr)->screenY);
                }
            }
            public void screenY(int value)
            {
                unsafe
                {
                    *(((GetScreenPointNativeArgs*)this.nativePtr)->screenY) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,768
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetScreenPointNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public int viewX;
            public int viewY;
            public int* screenX;
            public int* screenY;
        }
        //gen! bool GetScreenInfo(CefRefPtr<CefBrowser> browser,CefScreenInfo& screen_info)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,769
        /// <summary>
        /// Called to allow the client to fill in the CefScreenInfo object with
        /// appropriate values. Return true if the |screen_info| structure has been
        /// modified.
        ///
        /// If the screen info rectangle is left empty the rectangle from GetViewRect
        /// will be used. If the rectangle is still empty or invalid popups may not be
        /// drawn correctly.
        /// /*cef()*/
        /// </summary>
        public struct GetScreenInfoArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetScreenInfoArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetScreenInfoNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetScreenInfoNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetScreenInfoNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetScreenInfoNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefScreenInfo screen_info()
            {
                unsafe
                {
                    return new CefScreenInfo(((GetScreenInfoNativeArgs*)this.nativePtr)->screen_info);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,770
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetScreenInfoNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr screen_info;
        }
        //gen! void OnPopupShow(CefRefPtr<CefBrowser> browser,bool show)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,771
        /// <summary>
        /// Called when the browser wants to show or hide the popup widget. The popup
        /// should be shown if |show| is true and hidden if |show| is false.
        /// /*cef()*/
        /// </summary>
        public struct OnPopupShowArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPopupShowArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPopupShowNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPopupShowNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPopupShowNativeArgs*)this.nativePtr)->browser);
                }
            }
            public bool show()
            {
                unsafe
                {
                    return ((OnPopupShowNativeArgs*)this.nativePtr)->show;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,772
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPopupShowNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public bool show;
        }
        //gen! void OnPopupSize(CefRefPtr<CefBrowser> browser,const CefRect& rect)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,773
        /// <summary>
        /// Called when the browser wants to move or resize the popup widget. |rect|
        /// contains the new location and size in view coordinates.
        /// /*cef()*/
        /// </summary>
        public struct OnPopupSizeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPopupSizeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPopupSizeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPopupSizeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPopupSizeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefRect rect()
            {
                unsafe
                {
                    return new CefRect(((OnPopupSizeNativeArgs*)this.nativePtr)->rect);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,774
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPopupSizeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr rect;
        }
        //gen! void OnPaint(CefRefPtr<CefBrowser> browser,PaintElementType type,const RectList& dirtyRects,const void* buffer,int width,int height)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,775
        /// <summary>
        /// Called when an element should be painted. Pixel values passed to this
        /// method are scaled relative to view coordinates based on the value of
        /// CefScreenInfo.device_scale_factor returned from GetScreenInfo. |type|
        /// indicates whether the element is the view or the popup widget. |buffer|
        /// contains the pixel data for the whole image. |dirtyRects| contains the set
        /// of rectangles in pixel coordinates that need to be repainted. |buffer| will
        /// be |width|*|height|*4 bytes in size and represents a BGRA image with an
        /// upper-left origin.
        /// /*cef()*/
        /// </summary>
        public struct OnPaintArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPaintArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPaintNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPaintNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPaintNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_paint_element_type_t type()
            {
                unsafe
                {
                    return (cef_paint_element_type_t)(((OnPaintNativeArgs*)this.nativePtr)->type);
                }
            }
            public CefRectList dirtyRects()
            {
                unsafe
                {
                    return new CefRectList(((OnPaintNativeArgs*)this.nativePtr)->dirtyRects);
                }
            }
            public IntPtr buffer()
            {
                unsafe
                {
                    return ((OnPaintNativeArgs*)this.nativePtr)->buffer;
                }
            }
            public int width()
            {
                unsafe
                {
                    return ((OnPaintNativeArgs*)this.nativePtr)->width;
                }
            }
            public int height()
            {
                unsafe
                {
                    return ((OnPaintNativeArgs*)this.nativePtr)->height;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,776
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPaintNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public cef_paint_element_type_t type;
            public IntPtr dirtyRects;
            public IntPtr buffer;
            public int width;
            public int height;
        }
        //gen! void OnCursorChange(CefRefPtr<CefBrowser> browser,CefCursorHandle cursor,CursorType type,const CefCursorInfo& custom_cursor_info)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,777
        /// <summary>
        /// Called when the browser's cursor has changed. If |type| is CT_CUSTOM then
        /// |custom_cursor_info| will be populated with the custom cursor information.
        /// /*cef()*/
        /// </summary>
        public struct OnCursorChangeArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnCursorChangeArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnCursorChangeNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnCursorChangeNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnCursorChangeNativeArgs*)this.nativePtr)->browser);
                }
            }
            public IntPtr cursor()
            {
                unsafe
                {
                    return ((OnCursorChangeNativeArgs*)this.nativePtr)->cursor;
                }
            }
            public cef_cursor_type_t type()
            {
                unsafe
                {
                    return (cef_cursor_type_t)(((OnCursorChangeNativeArgs*)this.nativePtr)->type);
                }
            }
            public CefCursorInfo custom_cursor_info()
            {
                unsafe
                {
                    return new CefCursorInfo(((OnCursorChangeNativeArgs*)this.nativePtr)->custom_cursor_info);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,778
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnCursorChangeNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr cursor;
            public cef_cursor_type_t type;
            public IntPtr custom_cursor_info;
        }
        //gen! bool StartDragging(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDragData> drag_data,DragOperationsMask allowed_ops,int x,int y)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,779
        /// <summary>
        /// Called when the user starts dragging content in the web view. Contextual
        /// information about the dragged content is supplied by |drag_data|.
        /// (|x|, |y|) is the drag start location in screen coordinates.
        /// OS APIs that run a system message loop may be used within the
        /// StartDragging call.
        ///
        /// Return false to abort the drag operation. Don't call any of
        /// CefBrowserHost::DragSource*Ended* methods after returning false.
        ///
        /// Return true to handle the drag operation. Call
        /// CefBrowserHost::DragSourceEndedAt and DragSourceSystemDragEnded either
        /// synchronously or asynchronously to inform the web view that the drag
        /// operation has ended.
        /// /*cef()*/
        /// </summary>
        public struct StartDraggingArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal StartDraggingArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((StartDraggingNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((StartDraggingNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((StartDraggingNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((StartDraggingNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefDragData drag_data()
            {
                unsafe
                {
                    return new CefDragData(((StartDraggingNativeArgs*)this.nativePtr)->drag_data);
                }
            }
            public cef_drag_operations_mask_t allowed_ops()
            {
                unsafe
                {
                    return (cef_drag_operations_mask_t)(((StartDraggingNativeArgs*)this.nativePtr)->allowed_ops);
                }
            }
            public int x()
            {
                unsafe
                {
                    return ((StartDraggingNativeArgs*)this.nativePtr)->x;
                }
            }
            public int y()
            {
                unsafe
                {
                    return ((StartDraggingNativeArgs*)this.nativePtr)->y;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,780
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct StartDraggingNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr drag_data;
            public cef_drag_operations_mask_t allowed_ops;
            public int x;
            public int y;
        }
        //gen! void UpdateDragCursor(CefRefPtr<CefBrowser> browser,DragOperation operation)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,781
        /// <summary>
        /// Called when the web view wants to update the mouse cursor during a
        /// drag & drop operation. |operation| describes the allowed operation
        /// (none, move, copy, link).
        /// /*cef()*/
        /// </summary>
        public struct UpdateDragCursorArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal UpdateDragCursorArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((UpdateDragCursorNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((UpdateDragCursorNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((UpdateDragCursorNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_drag_operations_mask_t operation()
            {
                unsafe
                {
                    return (cef_drag_operations_mask_t)(((UpdateDragCursorNativeArgs*)this.nativePtr)->operation);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,782
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct UpdateDragCursorNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public cef_drag_operations_mask_t operation;
        }
        //gen! void OnScrollOffsetChanged(CefRefPtr<CefBrowser> browser,double x,double y)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,783
        /// <summary>
        /// Called when the scroll offset has changed.
        /// /*cef()*/
        /// </summary>
        public struct OnScrollOffsetChangedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnScrollOffsetChangedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnScrollOffsetChangedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnScrollOffsetChangedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnScrollOffsetChangedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public double x()
            {
                unsafe
                {
                    return ((OnScrollOffsetChangedNativeArgs*)this.nativePtr)->x;
                }
            }
            public double y()
            {
                unsafe
                {
                    return ((OnScrollOffsetChangedNativeArgs*)this.nativePtr)->y;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,784
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnScrollOffsetChangedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public double x;
            public double y;
        }
        //gen! void OnImeCompositionRangeChanged(CefRefPtr<CefBrowser> browser,const CefRange& selected_range,const RectList& character_bounds)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,785
        /// <summary>
        /// Called when the IME composition range has changed. |selected_range| is the
        /// range of characters that have been selected. |character_bounds| is the
        /// bounds of each character in view coordinates.
        /// /*cef()*/
        /// </summary>
        public struct OnImeCompositionRangeChangedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnImeCompositionRangeChangedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnImeCompositionRangeChangedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnImeCompositionRangeChangedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnImeCompositionRangeChangedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefRange selected_range()
            {
                unsafe
                {
                    return new CefRange(((OnImeCompositionRangeChangedNativeArgs*)this.nativePtr)->selected_range);
                }
            }
            public CefRectList character_bounds()
            {
                unsafe
                {
                    return new CefRectList(((OnImeCompositionRangeChangedNativeArgs*)this.nativePtr)->character_bounds);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,786
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnImeCompositionRangeChangedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr selected_range;
            public IntPtr character_bounds;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,787
            /// <summary>
            /// Return the handler for accessibility notifications. If no handler is
            /// provided the default implementation will be used.
            /// /*cef()*/
            /// </summary>
            void GetAccessibilityHandler(GetAccessibilityHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,788
            /// <summary>
            /// Called to retrieve the root window rectangle in screen coordinates. Return
            /// true if the rectangle was provided.
            /// /*cef()*/
            /// </summary>
            void GetRootScreenRect(GetRootScreenRectArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,789
            /// <summary>
            /// Called to retrieve the view rectangle which is relative to screen
            /// coordinates. Return true if the rectangle was provided.
            /// /*cef()*/
            /// </summary>
            void GetViewRect(GetViewRectArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,790
            /// <summary>
            /// Called to retrieve the translation from view coordinates to actual screen
            /// coordinates. Return true if the screen coordinates were provided.
            /// /*cef()*/
            /// </summary>
            void GetScreenPoint(GetScreenPointArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,791
            /// <summary>
            /// Called to allow the client to fill in the CefScreenInfo object with
            /// appropriate values. Return true if the |screen_info| structure has been
            /// modified.
            ///
            /// If the screen info rectangle is left empty the rectangle from GetViewRect
            /// will be used. If the rectangle is still empty or invalid popups may not be
            /// drawn correctly.
            /// /*cef()*/
            /// </summary>
            void GetScreenInfo(GetScreenInfoArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,792
            /// <summary>
            /// Called when the browser wants to show or hide the popup widget. The popup
            /// should be shown if |show| is true and hidden if |show| is false.
            /// /*cef()*/
            /// </summary>
            void OnPopupShow(OnPopupShowArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,793
            /// <summary>
            /// Called when the browser wants to move or resize the popup widget. |rect|
            /// contains the new location and size in view coordinates.
            /// /*cef()*/
            /// </summary>
            void OnPopupSize(OnPopupSizeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,794
            /// <summary>
            /// Called when an element should be painted. Pixel values passed to this
            /// method are scaled relative to view coordinates based on the value of
            /// CefScreenInfo.device_scale_factor returned from GetScreenInfo. |type|
            /// indicates whether the element is the view or the popup widget. |buffer|
            /// contains the pixel data for the whole image. |dirtyRects| contains the set
            /// of rectangles in pixel coordinates that need to be repainted. |buffer| will
            /// be |width|*|height|*4 bytes in size and represents a BGRA image with an
            /// upper-left origin.
            /// /*cef()*/
            /// </summary>
            void OnPaint(OnPaintArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,795
            /// <summary>
            /// Called when the browser's cursor has changed. If |type| is CT_CUSTOM then
            /// |custom_cursor_info| will be populated with the custom cursor information.
            /// /*cef()*/
            /// </summary>
            void OnCursorChange(OnCursorChangeArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,796
            /// <summary>
            /// Called when the user starts dragging content in the web view. Contextual
            /// information about the dragged content is supplied by |drag_data|.
            /// (|x|, |y|) is the drag start location in screen coordinates.
            /// OS APIs that run a system message loop may be used within the
            /// StartDragging call.
            ///
            /// Return false to abort the drag operation. Don't call any of
            /// CefBrowserHost::DragSource*Ended* methods after returning false.
            ///
            /// Return true to handle the drag operation. Call
            /// CefBrowserHost::DragSourceEndedAt and DragSourceSystemDragEnded either
            /// synchronously or asynchronously to inform the web view that the drag
            /// operation has ended.
            /// /*cef()*/
            /// </summary>
            void StartDragging(StartDraggingArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,797
            /// <summary>
            /// Called when the web view wants to update the mouse cursor during a
            /// drag & drop operation. |operation| describes the allowed operation
            /// (none, move, copy, link).
            /// /*cef()*/
            /// </summary>
            void UpdateDragCursor(UpdateDragCursorArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,798
            /// <summary>
            /// Called when the scroll offset has changed.
            /// /*cef()*/
            /// </summary>
            void OnScrollOffsetChanged(OnScrollOffsetChangedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,799
            /// <summary>
            /// Called when the IME composition range has changed. |selected_range| is the
            /// range of characters that have been selected. |character_bounds| is the
            /// bounds of each character in view coordinates.
            /// /*cef()*/
            /// </summary>
            void OnImeCompositionRangeChanged(OnImeCompositionRangeChangedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,800
            /// <summary>
            /// Return the handler for accessibility notifications. If no handler is
            /// provided the default implementation will be used.
            /// /*cef()*/
            /// </summary>
            CefAccessibilityHandler GetAccessibilityHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,801
            /// <summary>
            /// Called to retrieve the root window rectangle in screen coordinates. Return
            /// true if the rectangle was provided.
            /// /*cef()*/
            /// </summary>
            bool GetRootScreenRect(CefBrowser browser, CefRect rect);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,802
            /// <summary>
            /// Called to retrieve the view rectangle which is relative to screen
            /// coordinates. Return true if the rectangle was provided.
            /// /*cef()*/
            /// </summary>
            bool GetViewRect(CefBrowser browser, CefRect rect);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,803
            /// <summary>
            /// Called to retrieve the translation from view coordinates to actual screen
            /// coordinates. Return true if the screen coordinates were provided.
            /// /*cef()*/
            /// </summary>
            bool GetScreenPoint(CefBrowser browser, int viewX, int viewY, ref int screenX, ref int screenY);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,804
            /// <summary>
            /// Called to allow the client to fill in the CefScreenInfo object with
            /// appropriate values. Return true if the |screen_info| structure has been
            /// modified.
            ///
            /// If the screen info rectangle is left empty the rectangle from GetViewRect
            /// will be used. If the rectangle is still empty or invalid popups may not be
            /// drawn correctly.
            /// /*cef()*/
            /// </summary>
            bool GetScreenInfo(CefBrowser browser, CefScreenInfo screen_info);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,805
            /// <summary>
            /// Called when the browser wants to show or hide the popup widget. The popup
            /// should be shown if |show| is true and hidden if |show| is false.
            /// /*cef()*/
            /// </summary>
            void OnPopupShow(CefBrowser browser, bool show);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,806
            /// <summary>
            /// Called when the browser wants to move or resize the popup widget. |rect|
            /// contains the new location and size in view coordinates.
            /// /*cef()*/
            /// </summary>
            void OnPopupSize(CefBrowser browser, CefRect rect);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,807
            /// <summary>
            /// Called when an element should be painted. Pixel values passed to this
            /// method are scaled relative to view coordinates based on the value of
            /// CefScreenInfo.device_scale_factor returned from GetScreenInfo. |type|
            /// indicates whether the element is the view or the popup widget. |buffer|
            /// contains the pixel data for the whole image. |dirtyRects| contains the set
            /// of rectangles in pixel coordinates that need to be repainted. |buffer| will
            /// be |width|*|height|*4 bytes in size and represents a BGRA image with an
            /// upper-left origin.
            /// /*cef()*/
            /// </summary>
            void OnPaint(CefBrowser browser, cef_paint_element_type_t type, CefRectList dirtyRects, IntPtr buffer, int width, int height);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,808
            /// <summary>
            /// Called when the browser's cursor has changed. If |type| is CT_CUSTOM then
            /// |custom_cursor_info| will be populated with the custom cursor information.
            /// /*cef()*/
            /// </summary>
            void OnCursorChange(CefBrowser browser, IntPtr cursor, cef_cursor_type_t type, CefCursorInfo custom_cursor_info);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,809
            /// <summary>
            /// Called when the user starts dragging content in the web view. Contextual
            /// information about the dragged content is supplied by |drag_data|.
            /// (|x|, |y|) is the drag start location in screen coordinates.
            /// OS APIs that run a system message loop may be used within the
            /// StartDragging call.
            ///
            /// Return false to abort the drag operation. Don't call any of
            /// CefBrowserHost::DragSource*Ended* methods after returning false.
            ///
            /// Return true to handle the drag operation. Call
            /// CefBrowserHost::DragSourceEndedAt and DragSourceSystemDragEnded either
            /// synchronously or asynchronously to inform the web view that the drag
            /// operation has ended.
            /// /*cef()*/
            /// </summary>
            bool StartDragging(CefBrowser browser, CefDragData drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,810
            /// <summary>
            /// Called when the web view wants to update the mouse cursor during a
            /// drag & drop operation. |operation| describes the allowed operation
            /// (none, move, copy, link).
            /// /*cef()*/
            /// </summary>
            void UpdateDragCursor(CefBrowser browser, cef_drag_operations_mask_t operation);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,811
            /// <summary>
            /// Called when the scroll offset has changed.
            /// /*cef()*/
            /// </summary>
            void OnScrollOffsetChanged(CefBrowser browser, double x, double y);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,812
            /// <summary>
            /// Called when the IME composition range has changed. |selected_range| is the
            /// range of characters that have been selected. |character_bounds| is the
            /// bounds of each character in view coordinates.
            /// /*cef()*/
            /// </summary>
            void OnImeCompositionRangeChanged(CefBrowser browser, CefRange selected_range, CefRectList character_bounds);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,813
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,814
                case CefRenderHandlerExt_GetAccessibilityHandler_1:
                    {
                        var args = new GetAccessibilityHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetAccessibilityHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetAccessibilityHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,815
                case CefRenderHandlerExt_GetRootScreenRect_2:
                    {
                        var args = new GetRootScreenRectArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetRootScreenRect(args);
                        }
                        if (i1 != null)
                        {
                            GetRootScreenRect(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,816
                case CefRenderHandlerExt_GetViewRect_3:
                    {
                        var args = new GetViewRectArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetViewRect(args);
                        }
                        if (i1 != null)
                        {
                            GetViewRect(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,817
                case CefRenderHandlerExt_GetScreenPoint_4:
                    {
                        var args = new GetScreenPointArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetScreenPoint(args);
                        }
                        if (i1 != null)
                        {
                            GetScreenPoint(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,818
                case CefRenderHandlerExt_GetScreenInfo_5:
                    {
                        var args = new GetScreenInfoArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetScreenInfo(args);
                        }
                        if (i1 != null)
                        {
                            GetScreenInfo(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,819
                case CefRenderHandlerExt_OnPopupShow_6:
                    {
                        var args = new OnPopupShowArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPopupShow(args);
                        }
                        if (i1 != null)
                        {
                            OnPopupShow(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,820
                case CefRenderHandlerExt_OnPopupSize_7:
                    {
                        var args = new OnPopupSizeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPopupSize(args);
                        }
                        if (i1 != null)
                        {
                            OnPopupSize(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,821
                case CefRenderHandlerExt_OnPaint_8:
                    {
                        var args = new OnPaintArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPaint(args);
                        }
                        if (i1 != null)
                        {
                            OnPaint(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,822
                case CefRenderHandlerExt_OnCursorChange_9:
                    {
                        var args = new OnCursorChangeArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnCursorChange(args);
                        }
                        if (i1 != null)
                        {
                            OnCursorChange(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,823
                case CefRenderHandlerExt_StartDragging_10:
                    {
                        var args = new StartDraggingArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.StartDragging(args);
                        }
                        if (i1 != null)
                        {
                            StartDragging(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,824
                case CefRenderHandlerExt_UpdateDragCursor_11:
                    {
                        var args = new UpdateDragCursorArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.UpdateDragCursor(args);
                        }
                        if (i1 != null)
                        {
                            UpdateDragCursor(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,825
                case CefRenderHandlerExt_OnScrollOffsetChanged_12:
                    {
                        var args = new OnScrollOffsetChangedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnScrollOffsetChanged(args);
                        }
                        if (i1 != null)
                        {
                            OnScrollOffsetChanged(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,826
                case CefRenderHandlerExt_OnImeCompositionRangeChanged_13:
                    {
                        var args = new OnImeCompositionRangeChangedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnImeCompositionRangeChanged(args);
                        }
                        if (i1 != null)
                        {
                            OnImeCompositionRangeChanged(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,827
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefRenderHandlerExt_GetAccessibilityHandler_1:
                    i0.GetAccessibilityHandler(new GetAccessibilityHandlerArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_GetRootScreenRect_2:
                    i0.GetRootScreenRect(new GetRootScreenRectArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_GetViewRect_3:
                    i0.GetViewRect(new GetViewRectArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_GetScreenPoint_4:
                    i0.GetScreenPoint(new GetScreenPointArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_GetScreenInfo_5:
                    i0.GetScreenInfo(new GetScreenInfoArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_OnPopupShow_6:
                    i0.OnPopupShow(new OnPopupShowArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_OnPopupSize_7:
                    i0.OnPopupSize(new OnPopupSizeArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_OnPaint_8:
                    i0.OnPaint(new OnPaintArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_OnCursorChange_9:
                    i0.OnCursorChange(new OnCursorChangeArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_StartDragging_10:
                    i0.StartDragging(new StartDraggingArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_UpdateDragCursor_11:
                    i0.UpdateDragCursor(new UpdateDragCursorArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_OnScrollOffsetChanged_12:
                    i0.OnScrollOffsetChanged(new OnScrollOffsetChangedArgs(nativeArgPtr));
                    break;
                case CefRenderHandlerExt_OnImeCompositionRangeChanged_13:
                    i0.OnImeCompositionRangeChanged(new OnImeCompositionRangeChangedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,828
        public static void GetAccessibilityHandler(I1 i1, GetAccessibilityHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,829
            i1.GetAccessibilityHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,830
        public static void GetRootScreenRect(I1 i1, GetRootScreenRectArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,831
            args.myext_setRetValue(i1.GetRootScreenRect(args.browser(),
            args.rect()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,832
        public static void GetViewRect(I1 i1, GetViewRectArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,833
            args.myext_setRetValue(i1.GetViewRect(args.browser(),
            args.rect()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,834
        public static void GetScreenPoint(I1 i1, GetScreenPointArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,835
            int screenX = 0;
            int screenY = 0;
            args.myext_setRetValue(i1.GetScreenPoint(args.browser(),
            args.viewX(),
            args.viewY(),
            ref screenX,
            ref screenY));
            args.screenX(screenX);
            args.screenY(screenY);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,836
        public static void GetScreenInfo(I1 i1, GetScreenInfoArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,837
            args.myext_setRetValue(i1.GetScreenInfo(args.browser(),
            args.screen_info()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,838
        public static void OnPopupShow(I1 i1, OnPopupShowArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,839
            i1.OnPopupShow(args.browser(),
            args.show());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,840
        public static void OnPopupSize(I1 i1, OnPopupSizeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,841
            i1.OnPopupSize(args.browser(),
            args.rect());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,842
        public static void OnPaint(I1 i1, OnPaintArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,843
            i1.OnPaint(args.browser(),
            args.type(),
            args.dirtyRects(),
            args.buffer(),
            args.width(),
            args.height());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,844
        public static void OnCursorChange(I1 i1, OnCursorChangeArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,845
            i1.OnCursorChange(args.browser(),
            args.cursor(),
            args.type(),
            args.custom_cursor_info());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,846
        public static void StartDragging(I1 i1, StartDraggingArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,847
            args.myext_setRetValue(i1.StartDragging(args.browser(),
            args.drag_data(),
            args.allowed_ops(),
            args.x(),
            args.y()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,848
        public static void UpdateDragCursor(I1 i1, UpdateDragCursorArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,849
            i1.UpdateDragCursor(args.browser(),
            args.operation());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,850
        public static void OnScrollOffsetChanged(I1 i1, OnScrollOffsetChangedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,851
            i1.OnScrollOffsetChanged(args.browser(),
            args.x(),
            args.y());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,852
        public static void OnImeCompositionRangeChanged(I1 i1, OnImeCompositionRangeChangedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,853
            i1.OnImeCompositionRangeChanged(args.browser(),
            args.selected_range(),
            args.character_bounds());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,854
    public struct CefRenderProcessHandler
    {
        public const int _typeNAME = 72;
        internal IntPtr nativePtr;
        public CefRenderProcessHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefRenderProcessHandlerExt_OnRenderThreadCreated_1 = 1;
        public const int CefRenderProcessHandlerExt_OnWebKitInitialized_2 = 2;
        public const int CefRenderProcessHandlerExt_OnBrowserCreated_3 = 3;
        public const int CefRenderProcessHandlerExt_OnBrowserDestroyed_4 = 4;
        public const int CefRenderProcessHandlerExt_GetLoadHandler_5 = 5;
        public const int CefRenderProcessHandlerExt_OnBeforeNavigation_6 = 6;
        public const int CefRenderProcessHandlerExt_OnContextCreated_7 = 7;
        public const int CefRenderProcessHandlerExt_OnContextReleased_8 = 8;
        public const int CefRenderProcessHandlerExt_OnUncaughtException_9 = 9;
        public const int CefRenderProcessHandlerExt_OnFocusedNodeChanged_10 = 10;
        public const int CefRenderProcessHandlerExt_OnProcessMessageReceived_11 = 11;
        //gen! void OnRenderThreadCreated(CefRefPtr<CefListValue> extra_info)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,855
        /// <summary>
        /// Called after the render process main thread has been created. |extra_info|
        /// is a read-only value originating from
        /// CefBrowserProcessHandler::OnRenderProcessThreadCreated(). Do not keep a
        /// reference to |extra_info| outside of this method.
        /// /*cef()*/
        /// </summary>
        public struct OnRenderThreadCreatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRenderThreadCreatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRenderThreadCreatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRenderThreadCreatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefListValue extra_info()
            {
                unsafe
                {
                    return new CefListValue(((OnRenderThreadCreatedNativeArgs*)this.nativePtr)->extra_info);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,856
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnRenderThreadCreatedNativeArgs
        {
            public int argFlags;
            public IntPtr extra_info;
        }
        //gen! void OnWebKitInitialized()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,857
        /// <summary>
        /// Called after WebKit has been initialized.
        /// /*cef()*/
        /// </summary>
        public struct OnWebKitInitializedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnWebKitInitializedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnWebKitInitializedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnWebKitInitializedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,858
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnWebKitInitializedNativeArgs
        {
            public int argFlags;
        }
        //gen! void OnBrowserCreated(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,859
        /// <summary>
        /// Called after a browser has been created. When browsing cross-origin a new
        /// browser will be created before the old browser with the same identifier is
        /// destroyed.
        /// /*cef()*/
        /// </summary>
        public struct OnBrowserCreatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBrowserCreatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBrowserCreatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBrowserCreatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBrowserCreatedNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,860
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBrowserCreatedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! void OnBrowserDestroyed(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,861
        /// <summary>
        /// Called before a browser is destroyed.
        /// /*cef()*/
        /// </summary>
        public struct OnBrowserDestroyedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBrowserDestroyedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBrowserDestroyedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBrowserDestroyedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBrowserDestroyedNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,862
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBrowserDestroyedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! CefRefPtr<CefLoadHandler> GetLoadHandler()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,863
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
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,864
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetLoadHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! bool OnBeforeNavigation(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,NavigationType navigation_type,bool is_redirect)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,865
        /// <summary>
        /// Called before browser navigation. Return true to cancel the navigation or
        /// false to allow the navigation to proceed. The |request| object cannot be
        /// modified in this callback.
        /// /*cef()*/
        /// </summary>
        public struct OnBeforeNavigationArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeNavigationArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeNavigationNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeNavigationNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnBeforeNavigationNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeNavigationNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnBeforeNavigationNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((OnBeforeNavigationNativeArgs*)this.nativePtr)->request);
                }
            }
            public cef_navigation_type_t navigation_type()
            {
                unsafe
                {
                    return (cef_navigation_type_t)(((OnBeforeNavigationNativeArgs*)this.nativePtr)->navigation_type);
                }
            }
            public bool is_redirect()
            {
                unsafe
                {
                    return ((OnBeforeNavigationNativeArgs*)this.nativePtr)->is_redirect;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,866
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeNavigationNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public cef_navigation_type_t navigation_type;
            public bool is_redirect;
        }
        //gen! void OnContextCreated(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefV8Context> context)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,867
        /// <summary>
        /// Called immediately after the V8 context for a frame has been created. To
        /// retrieve the JavaScript 'window' object use the CefV8Context::GetGlobal()
        /// method. V8 handles can only be accessed from the thread on which they are
        /// created. A task runner for posting tasks on the associated thread can be
        /// retrieved via the CefV8Context::GetTaskRunner() method.
        /// /*cef()*/
        /// </summary>
        public struct OnContextCreatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnContextCreatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnContextCreatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnContextCreatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnContextCreatedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnContextCreatedNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefV8Context context()
            {
                unsafe
                {
                    return new CefV8Context(((OnContextCreatedNativeArgs*)this.nativePtr)->context);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,868
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnContextCreatedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr context;
        }
        //gen! void OnContextReleased(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefV8Context> context)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,869
        /// <summary>
        /// Called immediately before the V8 context for a frame is released. No
        /// references to the context should be kept after this method is called.
        /// /*cef()*/
        /// </summary>
        public struct OnContextReleasedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnContextReleasedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnContextReleasedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnContextReleasedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnContextReleasedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnContextReleasedNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefV8Context context()
            {
                unsafe
                {
                    return new CefV8Context(((OnContextReleasedNativeArgs*)this.nativePtr)->context);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,870
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnContextReleasedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr context;
        }
        //gen! void OnUncaughtException(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Exception> exception,CefRefPtr<CefV8StackTrace> stackTrace)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,871
        /// <summary>
        /// Called for global uncaught exceptions in a frame. Execution of this
        /// callback is disabled by default. To enable set
        /// CefSettings.uncaught_exception_stack_size > 0.
        /// /*cef()*/
        /// </summary>
        public struct OnUncaughtExceptionArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnUncaughtExceptionArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnUncaughtExceptionNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnUncaughtExceptionNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnUncaughtExceptionNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnUncaughtExceptionNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefV8Context context()
            {
                unsafe
                {
                    return new CefV8Context(((OnUncaughtExceptionNativeArgs*)this.nativePtr)->context);
                }
            }
            public CefV8Exception exception()
            {
                unsafe
                {
                    return new CefV8Exception(((OnUncaughtExceptionNativeArgs*)this.nativePtr)->exception);
                }
            }
            public CefV8StackTrace stackTrace()
            {
                unsafe
                {
                    return new CefV8StackTrace(((OnUncaughtExceptionNativeArgs*)this.nativePtr)->stackTrace);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,872
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnUncaughtExceptionNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr context;
            public IntPtr exception;
            public IntPtr stackTrace;
        }
        //gen! void OnFocusedNodeChanged(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefDOMNode> node)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,873
        /// <summary>
        /// Called when a new node in the the browser gets focus. The |node| value may
        /// be empty if no specific node has gained focus. The node object passed to
        /// this method represents a snapshot of the DOM at the time this method is
        /// executed. DOM objects are only valid for the scope of this method. Do not
        /// keep references to or attempt to access any DOM objects outside the scope
        /// of this method.
        /// /*cef(optional_param=frame,optional_param=node)*/
        /// </summary>
        public struct OnFocusedNodeChangedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnFocusedNodeChangedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnFocusedNodeChangedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnFocusedNodeChangedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnFocusedNodeChangedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnFocusedNodeChangedNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefDOMNode node()
            {
                unsafe
                {
                    return new CefDOMNode(((OnFocusedNodeChangedNativeArgs*)this.nativePtr)->node);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,874
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnFocusedNodeChangedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr node;
        }
        //gen! bool OnProcessMessageReceived(CefRefPtr<CefBrowser> browser,CefProcessId source_process,CefRefPtr<CefProcessMessage> message)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,875
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
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,876
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnProcessMessageReceivedNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public cef_process_id_t source_process;
            public IntPtr message;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,877
            /// <summary>
            /// Called after the render process main thread has been created. |extra_info|
            /// is a read-only value originating from
            /// CefBrowserProcessHandler::OnRenderProcessThreadCreated(). Do not keep a
            /// reference to |extra_info| outside of this method.
            /// /*cef()*/
            /// </summary>
            void OnRenderThreadCreated(OnRenderThreadCreatedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,878
            /// <summary>
            /// Called after WebKit has been initialized.
            /// /*cef()*/
            /// </summary>
            void OnWebKitInitialized(OnWebKitInitializedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,879
            /// <summary>
            /// Called after a browser has been created. When browsing cross-origin a new
            /// browser will be created before the old browser with the same identifier is
            /// destroyed.
            /// /*cef()*/
            /// </summary>
            void OnBrowserCreated(OnBrowserCreatedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,880
            /// <summary>
            /// Called before a browser is destroyed.
            /// /*cef()*/
            /// </summary>
            void OnBrowserDestroyed(OnBrowserDestroyedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,881
            /// <summary>
            /// Return the handler for browser load status events.
            /// /*cef()*/
            /// </summary>
            void GetLoadHandler(GetLoadHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,882
            /// <summary>
            /// Called before browser navigation. Return true to cancel the navigation or
            /// false to allow the navigation to proceed. The |request| object cannot be
            /// modified in this callback.
            /// /*cef()*/
            /// </summary>
            void OnBeforeNavigation(OnBeforeNavigationArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,883
            /// <summary>
            /// Called immediately after the V8 context for a frame has been created. To
            /// retrieve the JavaScript 'window' object use the CefV8Context::GetGlobal()
            /// method. V8 handles can only be accessed from the thread on which they are
            /// created. A task runner for posting tasks on the associated thread can be
            /// retrieved via the CefV8Context::GetTaskRunner() method.
            /// /*cef()*/
            /// </summary>
            void OnContextCreated(OnContextCreatedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,884
            /// <summary>
            /// Called immediately before the V8 context for a frame is released. No
            /// references to the context should be kept after this method is called.
            /// /*cef()*/
            /// </summary>
            void OnContextReleased(OnContextReleasedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,885
            /// <summary>
            /// Called for global uncaught exceptions in a frame. Execution of this
            /// callback is disabled by default. To enable set
            /// CefSettings.uncaught_exception_stack_size > 0.
            /// /*cef()*/
            /// </summary>
            void OnUncaughtException(OnUncaughtExceptionArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,886
            /// <summary>
            /// Called when a new node in the the browser gets focus. The |node| value may
            /// be empty if no specific node has gained focus. The node object passed to
            /// this method represents a snapshot of the DOM at the time this method is
            /// executed. DOM objects are only valid for the scope of this method. Do not
            /// keep references to or attempt to access any DOM objects outside the scope
            /// of this method.
            /// /*cef(optional_param=frame,optional_param=node)*/
            /// </summary>
            void OnFocusedNodeChanged(OnFocusedNodeChangedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,887
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
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,888
            /// <summary>
            /// Called after the render process main thread has been created. |extra_info|
            /// is a read-only value originating from
            /// CefBrowserProcessHandler::OnRenderProcessThreadCreated(). Do not keep a
            /// reference to |extra_info| outside of this method.
            /// /*cef()*/
            /// </summary>
            void OnRenderThreadCreated(CefListValue extra_info);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,889
            /// <summary>
            /// Called after WebKit has been initialized.
            /// /*cef()*/
            /// </summary>
            void OnWebKitInitialized();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,890
            /// <summary>
            /// Called after a browser has been created. When browsing cross-origin a new
            /// browser will be created before the old browser with the same identifier is
            /// destroyed.
            /// /*cef()*/
            /// </summary>
            void OnBrowserCreated(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,891
            /// <summary>
            /// Called before a browser is destroyed.
            /// /*cef()*/
            /// </summary>
            void OnBrowserDestroyed(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,892
            /// <summary>
            /// Return the handler for browser load status events.
            /// /*cef()*/
            /// </summary>
            CefLoadHandler GetLoadHandler();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,893
            /// <summary>
            /// Called before browser navigation. Return true to cancel the navigation or
            /// false to allow the navigation to proceed. The |request| object cannot be
            /// modified in this callback.
            /// /*cef()*/
            /// </summary>
            bool OnBeforeNavigation(CefBrowser browser, CefFrame frame, CefRequest request, cef_navigation_type_t navigation_type, bool is_redirect);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,894
            /// <summary>
            /// Called immediately after the V8 context for a frame has been created. To
            /// retrieve the JavaScript 'window' object use the CefV8Context::GetGlobal()
            /// method. V8 handles can only be accessed from the thread on which they are
            /// created. A task runner for posting tasks on the associated thread can be
            /// retrieved via the CefV8Context::GetTaskRunner() method.
            /// /*cef()*/
            /// </summary>
            void OnContextCreated(CefBrowser browser, CefFrame frame, CefV8Context context);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,895
            /// <summary>
            /// Called immediately before the V8 context for a frame is released. No
            /// references to the context should be kept after this method is called.
            /// /*cef()*/
            /// </summary>
            void OnContextReleased(CefBrowser browser, CefFrame frame, CefV8Context context);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,896
            /// <summary>
            /// Called for global uncaught exceptions in a frame. Execution of this
            /// callback is disabled by default. To enable set
            /// CefSettings.uncaught_exception_stack_size > 0.
            /// /*cef()*/
            /// </summary>
            void OnUncaughtException(CefBrowser browser, CefFrame frame, CefV8Context context, CefV8Exception exception, CefV8StackTrace stackTrace);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,897
            /// <summary>
            /// Called when a new node in the the browser gets focus. The |node| value may
            /// be empty if no specific node has gained focus. The node object passed to
            /// this method represents a snapshot of the DOM at the time this method is
            /// executed. DOM objects are only valid for the scope of this method. Do not
            /// keep references to or attempt to access any DOM objects outside the scope
            /// of this method.
            /// /*cef(optional_param=frame,optional_param=node)*/
            /// </summary>
            void OnFocusedNodeChanged(CefBrowser browser, CefFrame frame, CefDOMNode node);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,898
            /// <summary>
            /// Called when a new message is received from a different process. Return true
            /// if the message was handled or false otherwise. Do not keep a reference to
            /// or attempt to access the message outside of this callback.
            /// /*cef()*/
            /// </summary>
            bool OnProcessMessageReceived(CefBrowser browser, cef_process_id_t source_process, CefProcessMessage message);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,899
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,900
                case CefRenderProcessHandlerExt_OnRenderThreadCreated_1:
                    {
                        var args = new OnRenderThreadCreatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRenderThreadCreated(args);
                        }
                        if (i1 != null)
                        {
                            OnRenderThreadCreated(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,901
                case CefRenderProcessHandlerExt_OnWebKitInitialized_2:
                    {
                        var args = new OnWebKitInitializedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnWebKitInitialized(args);
                        }
                        if (i1 != null)
                        {
                            OnWebKitInitialized(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,902
                case CefRenderProcessHandlerExt_OnBrowserCreated_3:
                    {
                        var args = new OnBrowserCreatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBrowserCreated(args);
                        }
                        if (i1 != null)
                        {
                            OnBrowserCreated(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,903
                case CefRenderProcessHandlerExt_OnBrowserDestroyed_4:
                    {
                        var args = new OnBrowserDestroyedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBrowserDestroyed(args);
                        }
                        if (i1 != null)
                        {
                            OnBrowserDestroyed(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,904
                case CefRenderProcessHandlerExt_GetLoadHandler_5:
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
                //CsStructModuleCodeGen:: HandleNativeReq ,905
                case CefRenderProcessHandlerExt_OnBeforeNavigation_6:
                    {
                        var args = new OnBeforeNavigationArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeNavigation(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeNavigation(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,906
                case CefRenderProcessHandlerExt_OnContextCreated_7:
                    {
                        var args = new OnContextCreatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnContextCreated(args);
                        }
                        if (i1 != null)
                        {
                            OnContextCreated(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,907
                case CefRenderProcessHandlerExt_OnContextReleased_8:
                    {
                        var args = new OnContextReleasedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnContextReleased(args);
                        }
                        if (i1 != null)
                        {
                            OnContextReleased(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,908
                case CefRenderProcessHandlerExt_OnUncaughtException_9:
                    {
                        var args = new OnUncaughtExceptionArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnUncaughtException(args);
                        }
                        if (i1 != null)
                        {
                            OnUncaughtException(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,909
                case CefRenderProcessHandlerExt_OnFocusedNodeChanged_10:
                    {
                        var args = new OnFocusedNodeChangedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnFocusedNodeChanged(args);
                        }
                        if (i1 != null)
                        {
                            OnFocusedNodeChanged(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,910
                case CefRenderProcessHandlerExt_OnProcessMessageReceived_11:
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
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,911
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefRenderProcessHandlerExt_OnRenderThreadCreated_1:
                    i0.OnRenderThreadCreated(new OnRenderThreadCreatedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnWebKitInitialized_2:
                    i0.OnWebKitInitialized(new OnWebKitInitializedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnBrowserCreated_3:
                    i0.OnBrowserCreated(new OnBrowserCreatedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnBrowserDestroyed_4:
                    i0.OnBrowserDestroyed(new OnBrowserDestroyedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_GetLoadHandler_5:
                    i0.GetLoadHandler(new GetLoadHandlerArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnBeforeNavigation_6:
                    i0.OnBeforeNavigation(new OnBeforeNavigationArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnContextCreated_7:
                    i0.OnContextCreated(new OnContextCreatedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnContextReleased_8:
                    i0.OnContextReleased(new OnContextReleasedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnUncaughtException_9:
                    i0.OnUncaughtException(new OnUncaughtExceptionArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnFocusedNodeChanged_10:
                    i0.OnFocusedNodeChanged(new OnFocusedNodeChangedArgs(nativeArgPtr));
                    break;
                case CefRenderProcessHandlerExt_OnProcessMessageReceived_11:
                    i0.OnProcessMessageReceived(new OnProcessMessageReceivedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,912
        public static void OnRenderThreadCreated(I1 i1, OnRenderThreadCreatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,913
            i1.OnRenderThreadCreated(args.extra_info());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,914
        public static void OnWebKitInitialized(I1 i1, OnWebKitInitializedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,915
            i1.OnWebKitInitialized();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,916
        public static void OnBrowserCreated(I1 i1, OnBrowserCreatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,917
            i1.OnBrowserCreated(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,918
        public static void OnBrowserDestroyed(I1 i1, OnBrowserDestroyedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,919
            i1.OnBrowserDestroyed(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,920
        public static void GetLoadHandler(I1 i1, GetLoadHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,921
            i1.GetLoadHandler();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,922
        public static void OnBeforeNavigation(I1 i1, OnBeforeNavigationArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,923
            args.myext_setRetValue(i1.OnBeforeNavigation(args.browser(),
            args.frame(),
            args.request(),
            args.navigation_type(),
            args.is_redirect()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,924
        public static void OnContextCreated(I1 i1, OnContextCreatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,925
            i1.OnContextCreated(args.browser(),
            args.frame(),
            args.context());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,926
        public static void OnContextReleased(I1 i1, OnContextReleasedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,927
            i1.OnContextReleased(args.browser(),
            args.frame(),
            args.context());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,928
        public static void OnUncaughtException(I1 i1, OnUncaughtExceptionArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,929
            i1.OnUncaughtException(args.browser(),
            args.frame(),
            args.context(),
            args.exception(),
            args.stackTrace());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,930
        public static void OnFocusedNodeChanged(I1 i1, OnFocusedNodeChangedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,931
            i1.OnFocusedNodeChanged(args.browser(),
            args.frame(),
            args.node());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,932
        public static void OnProcessMessageReceived(I1 i1, OnProcessMessageReceivedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,933
            args.myext_setRetValue(i1.OnProcessMessageReceived(args.browser(),
            args.source_process(),
            args.message()));
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,934
    public struct CefRequestContextHandler
    {
        public const int _typeNAME = 73;
        internal IntPtr nativePtr;
        public CefRequestContextHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefRequestContextHandlerExt_GetCookieManager_1 = 1;
        public const int CefRequestContextHandlerExt_OnBeforePluginLoad_2 = 2;
        //gen! CefRefPtr<CefCookieManager> GetCookieManager()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,935
        /// <summary>
        /// Called on the browser process IO thread to retrieve the cookie manager. If
        /// this method returns NULL the default cookie manager retrievable via
        /// CefRequestContext::GetDefaultCookieManager() will be used.
        /// /*cef()*/
        /// </summary>
        public struct GetCookieManagerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetCookieManagerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetCookieManagerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetCookieManagerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetCookieManagerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,936
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetCookieManagerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
        }
        //gen! bool OnBeforePluginLoad(const CefString& mime_type,const CefString& plugin_url,bool is_main_frame,const CefString& top_origin_url,CefRefPtr<CefWebPluginInfo> plugin_info,PluginPolicy* plugin_policy)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,937
        /// <summary>
        /// Called on multiple browser process threads before a plugin instance is
        /// loaded. |mime_type| is the mime type of the plugin that will be loaded.
        /// |plugin_url| is the content URL that the plugin will load and may be empty.
        /// |is_main_frame| will be true if the plugin is being loaded in the main
        /// (top-level) frame, |top_origin_url| is the URL for the top-level frame that
        /// contains the plugin when loading a specific plugin instance or empty when
        /// building the initial list of enabled plugins for 'navigator.plugins'
        /// JavaScript state. |plugin_info| includes additional information about the
        /// plugin that will be loaded. |plugin_policy| is the recommended policy.
        /// Modify |plugin_policy| and return true to change the policy. Return false
        /// to use the recommended policy. The default plugin policy can be set at
        /// runtime using the `--plugin-policy=[allow|detect|block]` command-line flag.
        /// Decisions to mark a plugin as disabled by setting |plugin_policy| to
        /// PLUGIN_POLICY_DISABLED may be cached when |top_origin_url| is empty. To
        /// purge the plugin list cache and potentially trigger new calls to this
        /// method call CefRequestContext::PurgePluginListCache.
        /// /*cef(optional_param=plugin_url,optional_param=top_origin_url)*/
        /// </summary>
        public struct OnBeforePluginLoadArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforePluginLoadArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforePluginLoadNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforePluginLoadNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnBeforePluginLoadNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public string mime_type()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforePluginLoadNativeArgs*)this.nativePtr)->mime_type);
                }
            }
            public string plugin_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforePluginLoadNativeArgs*)this.nativePtr)->plugin_url);
                }
            }
            public bool is_main_frame()
            {
                unsafe
                {
                    return ((OnBeforePluginLoadNativeArgs*)this.nativePtr)->is_main_frame;
                }
            }
            public string top_origin_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnBeforePluginLoadNativeArgs*)this.nativePtr)->top_origin_url);
                }
            }
            public CefWebPluginInfo plugin_info()
            {
                unsafe
                {
                    return new CefWebPluginInfo(((OnBeforePluginLoadNativeArgs*)this.nativePtr)->plugin_info);
                }
            }
            public cef_plugin_policy_t plugin_policy()
            {
                unsafe
                {
                    return (cef_plugin_policy_t)(((OnBeforePluginLoadNativeArgs*)this.nativePtr)->plugin_policy);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,938
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforePluginLoadNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr mime_type;
            public IntPtr plugin_url;
            public bool is_main_frame;
            public IntPtr top_origin_url;
            public IntPtr plugin_info;
            public cef_plugin_policy_t plugin_policy;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,939
            /// <summary>
            /// Called on the browser process IO thread to retrieve the cookie manager. If
            /// this method returns NULL the default cookie manager retrievable via
            /// CefRequestContext::GetDefaultCookieManager() will be used.
            /// /*cef()*/
            /// </summary>
            void GetCookieManager(GetCookieManagerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,940
            /// <summary>
            /// Called on multiple browser process threads before a plugin instance is
            /// loaded. |mime_type| is the mime type of the plugin that will be loaded.
            /// |plugin_url| is the content URL that the plugin will load and may be empty.
            /// |is_main_frame| will be true if the plugin is being loaded in the main
            /// (top-level) frame, |top_origin_url| is the URL for the top-level frame that
            /// contains the plugin when loading a specific plugin instance or empty when
            /// building the initial list of enabled plugins for 'navigator.plugins'
            /// JavaScript state. |plugin_info| includes additional information about the
            /// plugin that will be loaded. |plugin_policy| is the recommended policy.
            /// Modify |plugin_policy| and return true to change the policy. Return false
            /// to use the recommended policy. The default plugin policy can be set at
            /// runtime using the `--plugin-policy=[allow|detect|block]` command-line flag.
            /// Decisions to mark a plugin as disabled by setting |plugin_policy| to
            /// PLUGIN_POLICY_DISABLED may be cached when |top_origin_url| is empty. To
            /// purge the plugin list cache and potentially trigger new calls to this
            /// method call CefRequestContext::PurgePluginListCache.
            /// /*cef(optional_param=plugin_url,optional_param=top_origin_url)*/
            /// </summary>
            void OnBeforePluginLoad(OnBeforePluginLoadArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,941
            /// <summary>
            /// Called on the browser process IO thread to retrieve the cookie manager. If
            /// this method returns NULL the default cookie manager retrievable via
            /// CefRequestContext::GetDefaultCookieManager() will be used.
            /// /*cef()*/
            /// </summary>
            CefCookieManager GetCookieManager();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,942
            /// <summary>
            /// Called on multiple browser process threads before a plugin instance is
            /// loaded. |mime_type| is the mime type of the plugin that will be loaded.
            /// |plugin_url| is the content URL that the plugin will load and may be empty.
            /// |is_main_frame| will be true if the plugin is being loaded in the main
            /// (top-level) frame, |top_origin_url| is the URL for the top-level frame that
            /// contains the plugin when loading a specific plugin instance or empty when
            /// building the initial list of enabled plugins for 'navigator.plugins'
            /// JavaScript state. |plugin_info| includes additional information about the
            /// plugin that will be loaded. |plugin_policy| is the recommended policy.
            /// Modify |plugin_policy| and return true to change the policy. Return false
            /// to use the recommended policy. The default plugin policy can be set at
            /// runtime using the `--plugin-policy=[allow|detect|block]` command-line flag.
            /// Decisions to mark a plugin as disabled by setting |plugin_policy| to
            /// PLUGIN_POLICY_DISABLED may be cached when |top_origin_url| is empty. To
            /// purge the plugin list cache and potentially trigger new calls to this
            /// method call CefRequestContext::PurgePluginListCache.
            /// /*cef(optional_param=plugin_url,optional_param=top_origin_url)*/
            /// </summary>
            bool OnBeforePluginLoad(string mime_type, string plugin_url, bool is_main_frame, string top_origin_url, CefWebPluginInfo plugin_info, cef_plugin_policy_t plugin_policy);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,943
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,944
                case CefRequestContextHandlerExt_GetCookieManager_1:
                    {
                        var args = new GetCookieManagerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetCookieManager(args);
                        }
                        if (i1 != null)
                        {
                            GetCookieManager(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,945
                case CefRequestContextHandlerExt_OnBeforePluginLoad_2:
                    {
                        var args = new OnBeforePluginLoadArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforePluginLoad(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforePluginLoad(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,946
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefRequestContextHandlerExt_GetCookieManager_1:
                    i0.GetCookieManager(new GetCookieManagerArgs(nativeArgPtr));
                    break;
                case CefRequestContextHandlerExt_OnBeforePluginLoad_2:
                    i0.OnBeforePluginLoad(new OnBeforePluginLoadArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,947
        public static void GetCookieManager(I1 i1, GetCookieManagerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,948
            i1.GetCookieManager();
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,949
        public static void OnBeforePluginLoad(I1 i1, OnBeforePluginLoadArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,950
            args.myext_setRetValue(i1.OnBeforePluginLoad(args.mime_type(),
            args.plugin_url(),
            args.is_main_frame(),
            args.top_origin_url(),
            args.plugin_info(),
            args.plugin_policy()));
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,951
    public struct CefRequestHandler
    {
        public const int _typeNAME = 74;
        internal IntPtr nativePtr;
        public CefRequestHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefRequestHandlerExt_OnBeforeBrowse_1 = 1;
        public const int CefRequestHandlerExt_OnOpenURLFromTab_2 = 2;
        public const int CefRequestHandlerExt_OnBeforeResourceLoad_3 = 3;
        public const int CefRequestHandlerExt_GetResourceHandler_4 = 4;
        public const int CefRequestHandlerExt_OnResourceRedirect_5 = 5;
        public const int CefRequestHandlerExt_OnResourceResponse_6 = 6;
        public const int CefRequestHandlerExt_GetResourceResponseFilter_7 = 7;
        public const int CefRequestHandlerExt_OnResourceLoadComplete_8 = 8;
        public const int CefRequestHandlerExt_GetAuthCredentials_9 = 9;
        public const int CefRequestHandlerExt_OnQuotaRequest_10 = 10;
        public const int CefRequestHandlerExt_OnProtocolExecution_11 = 11;
        public const int CefRequestHandlerExt_OnCertificateError_12 = 12;
        public const int CefRequestHandlerExt_OnSelectClientCertificate_13 = 13;
        public const int CefRequestHandlerExt_OnPluginCrashed_14 = 14;
        public const int CefRequestHandlerExt_OnRenderViewReady_15 = 15;
        public const int CefRequestHandlerExt_OnRenderProcessTerminated_16 = 16;
        //gen! bool OnBeforeBrowse(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,bool is_redirect)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,952
        /// <summary>
        /// Called on the UI thread before browser navigation. Return true to cancel
        /// the navigation or false to allow the navigation to proceed. The |request|
        /// object cannot be modified in this callback.
        /// CefLoadHandler::OnLoadingStateChange will be called twice in all cases.
        /// If the navigation is allowed CefLoadHandler::OnLoadStart and
        /// CefLoadHandler::OnLoadEnd will be called. If the navigation is canceled
        /// CefLoadHandler::OnLoadError will be called with an |errorCode| value of
        /// ERR_ABORTED.
        /// /*cef()*/
        /// </summary>
        public struct OnBeforeBrowseArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeBrowseArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeBrowseNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeBrowseNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnBeforeBrowseNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeBrowseNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnBeforeBrowseNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((OnBeforeBrowseNativeArgs*)this.nativePtr)->request);
                }
            }
            public bool is_redirect()
            {
                unsafe
                {
                    return ((OnBeforeBrowseNativeArgs*)this.nativePtr)->is_redirect;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,953
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeBrowseNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public bool is_redirect;
        }
        //gen! bool OnOpenURLFromTab(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& target_url,WindowOpenDisposition target_disposition,bool user_gesture)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,954
        /// <summary>
        /// Called on the UI thread before OnBeforeBrowse in certain limited cases
        /// where navigating a new or different browser might be desirable. This
        /// includes user-initiated navigation that might open in a special way (e.g.
        /// links clicked via middle-click or ctrl + left-click) and certain types of
        /// cross-origin navigation initiated from the renderer process (e.g.
        /// navigating the top-level frame to/from a file URL). The |browser| and
        /// |frame| values represent the source of the navigation. The
        /// |target_disposition| value indicates where the user intended to navigate
        /// the browser based on standard Chromium behaviors (e.g. current tab,
        /// new tab, etc). The |user_gesture| value will be true if the browser
        /// navigated via explicit user gesture (e.g. clicking a link) or false if it
        /// navigated automatically (e.g. via the DomContentLoaded event). Return true
        /// to cancel the navigation or false to allow the navigation to proceed in the
        /// source browser's top-level frame.
        /// /*cef()*/
        /// </summary>
        public struct OnOpenURLFromTabArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnOpenURLFromTabArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnOpenURLFromTabNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnOpenURLFromTabNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnOpenURLFromTabNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnOpenURLFromTabNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnOpenURLFromTabNativeArgs*)this.nativePtr)->frame);
                }
            }
            public string target_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnOpenURLFromTabNativeArgs*)this.nativePtr)->target_url);
                }
            }
            public cef_window_open_disposition_t target_disposition()
            {
                unsafe
                {
                    return (cef_window_open_disposition_t)(((OnOpenURLFromTabNativeArgs*)this.nativePtr)->target_disposition);
                }
            }
            public bool user_gesture()
            {
                unsafe
                {
                    return ((OnOpenURLFromTabNativeArgs*)this.nativePtr)->user_gesture;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,955
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnOpenURLFromTabNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr target_url;
            public cef_window_open_disposition_t target_disposition;
            public bool user_gesture;
        }
        //gen! ReturnValue OnBeforeResourceLoad(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefRequestCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,956
        /// <summary>
        /// Called on the IO thread before a resource request is loaded. The |request|
        /// object may be modified. Return RV_CONTINUE to continue the request
        /// immediately. Return RV_CONTINUE_ASYNC and call CefRequestCallback::
        /// Continue() at a later time to continue or cancel the request
        /// asynchronously. Return RV_CANCEL to cancel the request immediately.
        ///
        /// /*cef(default_retval=RV_CONTINUE)*/
        /// </summary>
        public struct OnBeforeResourceLoadArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnBeforeResourceLoadArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->request);
                }
            }
            public CefRequestCallback callback()
            {
                unsafe
                {
                    return new CefRequestCallback(((OnBeforeResourceLoadNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,957
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnBeforeResourceLoadNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public IntPtr callback;
        }
        //gen! CefRefPtr<CefResourceHandler> GetResourceHandler(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,958
        /// <summary>
        /// Called on the IO thread before a resource is loaded. To allow the resource
        /// to load normally return NULL. To specify a handler for the resource return
        /// a CefResourceHandler object. The |request| object should not be modified in
        /// this callback.
        /// /*cef()*/
        /// </summary>
        public struct GetResourceHandlerArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetResourceHandlerArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetResourceHandlerNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetResourceHandlerNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetResourceHandlerNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetResourceHandlerNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((GetResourceHandlerNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((GetResourceHandlerNativeArgs*)this.nativePtr)->request);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,959
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetResourceHandlerNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
        }
        //gen! void OnResourceRedirect(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response,CefString& new_url)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,960
        /// <summary>
        /// Called on the IO thread when a resource load is redirected. The |request|
        /// parameter will contain the old URL and other request-related information.
        /// The |response| parameter will contain the response that resulted in the
        /// redirect. The |new_url| parameter will contain the new URL and can be
        /// changed if desired. The |request| object cannot be modified in this
        /// callback.
        /// /*cef()*/
        /// </summary>
        public struct OnResourceRedirectArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnResourceRedirectArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnResourceRedirectNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnResourceRedirectNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnResourceRedirectNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnResourceRedirectNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((OnResourceRedirectNativeArgs*)this.nativePtr)->request);
                }
            }
            public CefResponse response()
            {
                unsafe
                {
                    return new CefResponse(((OnResourceRedirectNativeArgs*)this.nativePtr)->response);
                }
            }
            public string new_url()
            {
                unsafe
                {
                    IntPtr str_address = *(((OnResourceRedirectNativeArgs*)this.nativePtr)->new_url);
                    return Cef3Binder.GetAsString(str_address);
                }
            }
            public void new_url(string value)
            {
                unsafe
                {
                    *(((OnResourceRedirectNativeArgs*)this.nativePtr)->new_url) = Cef3Binder.MyCefCreateStringHolder(value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,961
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnResourceRedirectNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public IntPtr response;
            public IntPtr* new_url;
        }
        //gen! bool OnResourceResponse(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,962
        /// <summary>
        /// Called on the IO thread when a resource response is received. To allow the
        /// resource to load normally return false. To redirect or retry the resource
        /// modify |request| (url, headers or post body) and return true. The
        /// |response| object cannot be modified in this callback.
        /// /*cef()*/
        /// </summary>
        public struct OnResourceResponseArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnResourceResponseArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnResourceResponseNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnResourceResponseNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnResourceResponseNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnResourceResponseNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnResourceResponseNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((OnResourceResponseNativeArgs*)this.nativePtr)->request);
                }
            }
            public CefResponse response()
            {
                unsafe
                {
                    return new CefResponse(((OnResourceResponseNativeArgs*)this.nativePtr)->response);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,963
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnResourceResponseNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public IntPtr response;
        }
        //gen! CefRefPtr<CefResponseFilter> GetResourceResponseFilter(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,964
        /// <summary>
        /// Called on the IO thread to optionally filter resource response content.
        /// |request| and |response| represent the request and response respectively
        /// and cannot be modified in this callback.
        /// /*cef()*/
        /// </summary>
        public struct GetResourceResponseFilterArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetResourceResponseFilterArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetResourceResponseFilterNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetResourceResponseFilterNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((GetResourceResponseFilterNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetResourceResponseFilterNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((GetResourceResponseFilterNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((GetResourceResponseFilterNativeArgs*)this.nativePtr)->request);
                }
            }
            public CefResponse response()
            {
                unsafe
                {
                    return new CefResponse(((GetResourceResponseFilterNativeArgs*)this.nativePtr)->response);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,965
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetResourceResponseFilterNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public IntPtr response;
        }
        //gen! void OnResourceLoadComplete(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response,URLRequestStatus status,int64 received_content_length)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,966
        /// <summary>
        /// Called on the IO thread when a resource load has completed. |request| and
        /// |response| represent the request and response respectively and cannot be
        /// modified in this callback. |status| indicates the load completion status.
        /// |received_content_length| is the number of response bytes actually read.
        /// /*cef()*/
        /// </summary>
        public struct OnResourceLoadCompleteArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnResourceLoadCompleteArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->frame);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->request);
                }
            }
            public CefResponse response()
            {
                unsafe
                {
                    return new CefResponse(((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->response);
                }
            }
            public cef_urlrequest_status_t status()
            {
                unsafe
                {
                    return (cef_urlrequest_status_t)(((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->status);
                }
            }
            public long received_content_length()
            {
                unsafe
                {
                    return ((OnResourceLoadCompleteNativeArgs*)this.nativePtr)->received_content_length;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,967
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnResourceLoadCompleteNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr request;
            public IntPtr response;
            public cef_urlrequest_status_t status;
            public long received_content_length;
        }
        //gen! bool GetAuthCredentials(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,bool isProxy,const CefString& host,int port,const CefString& realm,const CefString& scheme,CefRefPtr<CefAuthCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,968
        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |isProxy| indicates whether the host is a proxy server. |host| contains the
        /// hostname and |port| contains the port number. |realm| is the realm of the
        /// challenge and may be empty. |scheme| is the authentication scheme used,
        /// such as "basic" or "digest", and will be empty if the source of the request
        /// is an FTP server. Return true to continue the request and call
        /// CefAuthCallback::Continue() either in this method or at a later time when
        /// the authentication information is available. Return false to cancel the
        /// request immediately.
        /// /*cef(optional_param=realm,optional_param=scheme)*/
        /// </summary>
        public struct GetAuthCredentialsArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetAuthCredentialsArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetAuthCredentialsNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetAuthCredentialsNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetAuthCredentialsNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((GetAuthCredentialsNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((GetAuthCredentialsNativeArgs*)this.nativePtr)->frame);
                }
            }
            public bool isProxy()
            {
                unsafe
                {
                    return ((GetAuthCredentialsNativeArgs*)this.nativePtr)->isProxy;
                }
            }
            public string host()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((GetAuthCredentialsNativeArgs*)this.nativePtr)->host);
                }
            }
            public int port()
            {
                unsafe
                {
                    return ((GetAuthCredentialsNativeArgs*)this.nativePtr)->port;
                }
            }
            public string realm()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((GetAuthCredentialsNativeArgs*)this.nativePtr)->realm);
                }
            }
            public string scheme()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((GetAuthCredentialsNativeArgs*)this.nativePtr)->scheme);
                }
            }
            public CefAuthCallback callback()
            {
                unsafe
                {
                    return new CefAuthCallback(((GetAuthCredentialsNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,969
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetAuthCredentialsNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public bool isProxy;
            public IntPtr host;
            public int port;
            public IntPtr realm;
            public IntPtr scheme;
            public IntPtr callback;
        }
        //gen! bool OnQuotaRequest(CefRefPtr<CefBrowser> browser,const CefString& origin_url,int64 new_size,CefRefPtr<CefRequestCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,970
        /// <summary>
        /// Called on the IO thread when JavaScript requests a specific storage quota
        /// size via the webkitStorageInfo.requestQuota function. |origin_url| is the
        /// origin of the page making the request. |new_size| is the requested quota
        /// size in bytes. Return true to continue the request and call
        /// CefRequestCallback::Continue() either in this method or at a later time to
        /// grant or deny the request. Return false to cancel the request immediately.
        /// /*cef()*/
        /// </summary>
        public struct OnQuotaRequestArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnQuotaRequestArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnQuotaRequestNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnQuotaRequestNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnQuotaRequestNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnQuotaRequestNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string origin_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnQuotaRequestNativeArgs*)this.nativePtr)->origin_url);
                }
            }
            public long new_size()
            {
                unsafe
                {
                    return ((OnQuotaRequestNativeArgs*)this.nativePtr)->new_size;
                }
            }
            public CefRequestCallback callback()
            {
                unsafe
                {
                    return new CefRequestCallback(((OnQuotaRequestNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,971
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnQuotaRequestNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public IntPtr origin_url;
            public long new_size;
            public IntPtr callback;
        }
        //gen! void OnProtocolExecution(CefRefPtr<CefBrowser> browser,const CefString& url,bool& allow_os_execution)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,972
        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an unknown
        /// protocol component. Set |allow_os_execution| to true to attempt execution
        /// via the registered OS protocol handler, if any.
        /// SECURITY WARNING: YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED
        /// ON SCHEME, HOST OR OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
        /// /*cef()*/
        /// </summary>
        public struct OnProtocolExecutionArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnProtocolExecutionArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnProtocolExecutionNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnProtocolExecutionNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnProtocolExecutionNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnProtocolExecutionNativeArgs*)this.nativePtr)->url);
                }
            }
            public bool allow_os_execution()
            {
                unsafe
                {
                    return *(((OnProtocolExecutionNativeArgs*)this.nativePtr)->allow_os_execution);
                }
            }
            public void allow_os_execution(bool value)
            {
                unsafe
                {
                    *(((OnProtocolExecutionNativeArgs*)this.nativePtr)->allow_os_execution) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,973
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnProtocolExecutionNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr url;
            public bool* allow_os_execution;
        }
        //gen! bool OnCertificateError(CefRefPtr<CefBrowser> browser,cef_errorcode_t cert_error,const CefString& request_url,CefRefPtr<CefSSLInfo> ssl_info,CefRefPtr<CefRequestCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,974
        /// <summary>
        /// Called on the UI thread to handle requests for URLs with an invalid
        /// SSL certificate. Return true and call CefRequestCallback::Continue() either
        /// in this method or at a later time to continue or cancel the request. Return
        /// false to cancel the request immediately. If
        /// CefSettings.ignore_certificate_errors is set all invalid certificates will
        /// be accepted without calling this method.
        /// /*cef()*/
        /// </summary>
        public struct OnCertificateErrorArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnCertificateErrorArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnCertificateErrorNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnCertificateErrorNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnCertificateErrorNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnCertificateErrorNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_errorcode_t cert_error()
            {
                unsafe
                {
                    return (cef_errorcode_t)(((OnCertificateErrorNativeArgs*)this.nativePtr)->cert_error);
                }
            }
            public string request_url()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnCertificateErrorNativeArgs*)this.nativePtr)->request_url);
                }
            }
            public CefSSLInfo ssl_info()
            {
                unsafe
                {
                    return new CefSSLInfo(((OnCertificateErrorNativeArgs*)this.nativePtr)->ssl_info);
                }
            }
            public CefRequestCallback callback()
            {
                unsafe
                {
                    return new CefRequestCallback(((OnCertificateErrorNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,975
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnCertificateErrorNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public cef_errorcode_t cert_error;
            public IntPtr request_url;
            public IntPtr ssl_info;
            public IntPtr callback;
        }
        //gen! bool OnSelectClientCertificate(CefRefPtr<CefBrowser> browser,bool isProxy,const CefString& host,int port,const X509CertificateList& certificates,CefRefPtr<CefSelectClientCertificateCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,976
        /// <summary>
        /// Called on the UI thread when a client certificate is being requested for
        /// authentication. Return false to use the default behavior and automatically
        /// select the first certificate available. Return true and call
        /// CefSelectClientCertificateCallback::Select either in this method or at a
        /// later time to select a certificate. Do not call Select or call it with NULL
        /// to continue without using any certificate. |isProxy| indicates whether the
        /// host is an HTTPS proxy or the origin server. |host| and |port| contains the
        /// hostname and port of the SSL server. |certificates| is the list of
        /// certificates to choose from; this list has already been pruned by Chromium
        /// so that it only contains certificates from issuers that the server trusts.
        /// /*cef()*/
        /// </summary>
        public struct OnSelectClientCertificateArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnSelectClientCertificateArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnSelectClientCertificateNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnSelectClientCertificateNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((OnSelectClientCertificateNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnSelectClientCertificateNativeArgs*)this.nativePtr)->browser);
                }
            }
            public bool isProxy()
            {
                unsafe
                {
                    return ((OnSelectClientCertificateNativeArgs*)this.nativePtr)->isProxy;
                }
            }
            public string host()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnSelectClientCertificateNativeArgs*)this.nativePtr)->host);
                }
            }
            public int port()
            {
                unsafe
                {
                    return ((OnSelectClientCertificateNativeArgs*)this.nativePtr)->port;
                }
            }
            public CefX509CertificateList certificates()
            {
                unsafe
                {
                    return new CefX509CertificateList(((OnSelectClientCertificateNativeArgs*)this.nativePtr)->certificates);
                }
            }
            public CefSelectClientCertificateCallback callback()
            {
                unsafe
                {
                    return new CefSelectClientCertificateCallback(((OnSelectClientCertificateNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,977
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnSelectClientCertificateNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr browser;
            public bool isProxy;
            public IntPtr host;
            public int port;
            public IntPtr certificates;
            public IntPtr callback;
        }
        //gen! void OnPluginCrashed(CefRefPtr<CefBrowser> browser,const CefString& plugin_path)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,978
        /// <summary>
        /// Called on the browser process UI thread when a plugin has crashed.
        /// |plugin_path| is the path of the plugin that crashed.
        /// /*cef()*/
        /// </summary>
        public struct OnPluginCrashedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnPluginCrashedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnPluginCrashedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnPluginCrashedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnPluginCrashedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public string plugin_path()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((OnPluginCrashedNativeArgs*)this.nativePtr)->plugin_path);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,979
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnPluginCrashedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public IntPtr plugin_path;
        }
        //gen! void OnRenderViewReady(CefRefPtr<CefBrowser> browser)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,980
        /// <summary>
        /// Called on the browser process UI thread when the render view associated
        /// with |browser| is ready to receive/handle IPC messages in the render
        /// process.
        /// /*cef()*/
        /// </summary>
        public struct OnRenderViewReadyArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRenderViewReadyArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRenderViewReadyNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRenderViewReadyNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnRenderViewReadyNativeArgs*)this.nativePtr)->browser);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,981
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnRenderViewReadyNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
        }
        //gen! void OnRenderProcessTerminated(CefRefPtr<CefBrowser> browser,TerminationStatus status)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,982
        /// <summary>
        /// Called on the browser process UI thread when the render process
        /// terminates unexpectedly. |status| indicates how the process
        /// terminated.
        /// /*cef()*/
        /// </summary>
        public struct OnRenderProcessTerminatedArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRenderProcessTerminatedArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRenderProcessTerminatedNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRenderProcessTerminatedNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((OnRenderProcessTerminatedNativeArgs*)this.nativePtr)->browser);
                }
            }
            public cef_termination_status_t status()
            {
                unsafe
                {
                    return (cef_termination_status_t)(((OnRenderProcessTerminatedNativeArgs*)this.nativePtr)->status);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,983
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnRenderProcessTerminatedNativeArgs
        {
            public int argFlags;
            public IntPtr browser;
            public cef_termination_status_t status;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,984
            /// <summary>
            /// Called on the UI thread before browser navigation. Return true to cancel
            /// the navigation or false to allow the navigation to proceed. The |request|
            /// object cannot be modified in this callback.
            /// CefLoadHandler::OnLoadingStateChange will be called twice in all cases.
            /// If the navigation is allowed CefLoadHandler::OnLoadStart and
            /// CefLoadHandler::OnLoadEnd will be called. If the navigation is canceled
            /// CefLoadHandler::OnLoadError will be called with an |errorCode| value of
            /// ERR_ABORTED.
            /// /*cef()*/
            /// </summary>
            void OnBeforeBrowse(OnBeforeBrowseArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,985
            /// <summary>
            /// Called on the UI thread before OnBeforeBrowse in certain limited cases
            /// where navigating a new or different browser might be desirable. This
            /// includes user-initiated navigation that might open in a special way (e.g.
            /// links clicked via middle-click or ctrl + left-click) and certain types of
            /// cross-origin navigation initiated from the renderer process (e.g.
            /// navigating the top-level frame to/from a file URL). The |browser| and
            /// |frame| values represent the source of the navigation. The
            /// |target_disposition| value indicates where the user intended to navigate
            /// the browser based on standard Chromium behaviors (e.g. current tab,
            /// new tab, etc). The |user_gesture| value will be true if the browser
            /// navigated via explicit user gesture (e.g. clicking a link) or false if it
            /// navigated automatically (e.g. via the DomContentLoaded event). Return true
            /// to cancel the navigation or false to allow the navigation to proceed in the
            /// source browser's top-level frame.
            /// /*cef()*/
            /// </summary>
            void OnOpenURLFromTab(OnOpenURLFromTabArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,986
            /// <summary>
            /// Called on the IO thread before a resource request is loaded. The |request|
            /// object may be modified. Return RV_CONTINUE to continue the request
            /// immediately. Return RV_CONTINUE_ASYNC and call CefRequestCallback::
            /// Continue() at a later time to continue or cancel the request
            /// asynchronously. Return RV_CANCEL to cancel the request immediately.
            ///
            /// /*cef(default_retval=RV_CONTINUE)*/
            /// </summary>
            void OnBeforeResourceLoad(OnBeforeResourceLoadArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,987
            /// <summary>
            /// Called on the IO thread before a resource is loaded. To allow the resource
            /// to load normally return NULL. To specify a handler for the resource return
            /// a CefResourceHandler object. The |request| object should not be modified in
            /// this callback.
            /// /*cef()*/
            /// </summary>
            void GetResourceHandler(GetResourceHandlerArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,988
            /// <summary>
            /// Called on the IO thread when a resource load is redirected. The |request|
            /// parameter will contain the old URL and other request-related information.
            /// The |response| parameter will contain the response that resulted in the
            /// redirect. The |new_url| parameter will contain the new URL and can be
            /// changed if desired. The |request| object cannot be modified in this
            /// callback.
            /// /*cef()*/
            /// </summary>
            void OnResourceRedirect(OnResourceRedirectArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,989
            /// <summary>
            /// Called on the IO thread when a resource response is received. To allow the
            /// resource to load normally return false. To redirect or retry the resource
            /// modify |request| (url, headers or post body) and return true. The
            /// |response| object cannot be modified in this callback.
            /// /*cef()*/
            /// </summary>
            void OnResourceResponse(OnResourceResponseArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,990
            /// <summary>
            /// Called on the IO thread to optionally filter resource response content.
            /// |request| and |response| represent the request and response respectively
            /// and cannot be modified in this callback.
            /// /*cef()*/
            /// </summary>
            void GetResourceResponseFilter(GetResourceResponseFilterArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,991
            /// <summary>
            /// Called on the IO thread when a resource load has completed. |request| and
            /// |response| represent the request and response respectively and cannot be
            /// modified in this callback. |status| indicates the load completion status.
            /// |received_content_length| is the number of response bytes actually read.
            /// /*cef()*/
            /// </summary>
            void OnResourceLoadComplete(OnResourceLoadCompleteArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,992
            /// <summary>
            /// Called on the IO thread when the browser needs credentials from the user.
            /// |isProxy| indicates whether the host is a proxy server. |host| contains the
            /// hostname and |port| contains the port number. |realm| is the realm of the
            /// challenge and may be empty. |scheme| is the authentication scheme used,
            /// such as "basic" or "digest", and will be empty if the source of the request
            /// is an FTP server. Return true to continue the request and call
            /// CefAuthCallback::Continue() either in this method or at a later time when
            /// the authentication information is available. Return false to cancel the
            /// request immediately.
            /// /*cef(optional_param=realm,optional_param=scheme)*/
            /// </summary>
            void GetAuthCredentials(GetAuthCredentialsArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,993
            /// <summary>
            /// Called on the IO thread when JavaScript requests a specific storage quota
            /// size via the webkitStorageInfo.requestQuota function. |origin_url| is the
            /// origin of the page making the request. |new_size| is the requested quota
            /// size in bytes. Return true to continue the request and call
            /// CefRequestCallback::Continue() either in this method or at a later time to
            /// grant or deny the request. Return false to cancel the request immediately.
            /// /*cef()*/
            /// </summary>
            void OnQuotaRequest(OnQuotaRequestArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,994
            /// <summary>
            /// Called on the UI thread to handle requests for URLs with an unknown
            /// protocol component. Set |allow_os_execution| to true to attempt execution
            /// via the registered OS protocol handler, if any.
            /// SECURITY WARNING: YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED
            /// ON SCHEME, HOST OR OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
            /// /*cef()*/
            /// </summary>
            void OnProtocolExecution(OnProtocolExecutionArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,995
            /// <summary>
            /// Called on the UI thread to handle requests for URLs with an invalid
            /// SSL certificate. Return true and call CefRequestCallback::Continue() either
            /// in this method or at a later time to continue or cancel the request. Return
            /// false to cancel the request immediately. If
            /// CefSettings.ignore_certificate_errors is set all invalid certificates will
            /// be accepted without calling this method.
            /// /*cef()*/
            /// </summary>
            void OnCertificateError(OnCertificateErrorArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,996
            /// <summary>
            /// Called on the UI thread when a client certificate is being requested for
            /// authentication. Return false to use the default behavior and automatically
            /// select the first certificate available. Return true and call
            /// CefSelectClientCertificateCallback::Select either in this method or at a
            /// later time to select a certificate. Do not call Select or call it with NULL
            /// to continue without using any certificate. |isProxy| indicates whether the
            /// host is an HTTPS proxy or the origin server. |host| and |port| contains the
            /// hostname and port of the SSL server. |certificates| is the list of
            /// certificates to choose from; this list has already been pruned by Chromium
            /// so that it only contains certificates from issuers that the server trusts.
            /// /*cef()*/
            /// </summary>
            void OnSelectClientCertificate(OnSelectClientCertificateArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,997
            /// <summary>
            /// Called on the browser process UI thread when a plugin has crashed.
            /// |plugin_path| is the path of the plugin that crashed.
            /// /*cef()*/
            /// </summary>
            void OnPluginCrashed(OnPluginCrashedArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,998
            /// <summary>
            /// Called on the browser process UI thread when the render view associated
            /// with |browser| is ready to receive/handle IPC messages in the render
            /// process.
            /// /*cef()*/
            /// </summary>
            void OnRenderViewReady(OnRenderViewReadyArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,999
            /// <summary>
            /// Called on the browser process UI thread when the render process
            /// terminates unexpectedly. |status| indicates how the process
            /// terminated.
            /// /*cef()*/
            /// </summary>
            void OnRenderProcessTerminated(OnRenderProcessTerminatedArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1000
            /// <summary>
            /// Called on the UI thread before browser navigation. Return true to cancel
            /// the navigation or false to allow the navigation to proceed. The |request|
            /// object cannot be modified in this callback.
            /// CefLoadHandler::OnLoadingStateChange will be called twice in all cases.
            /// If the navigation is allowed CefLoadHandler::OnLoadStart and
            /// CefLoadHandler::OnLoadEnd will be called. If the navigation is canceled
            /// CefLoadHandler::OnLoadError will be called with an |errorCode| value of
            /// ERR_ABORTED.
            /// /*cef()*/
            /// </summary>
            bool OnBeforeBrowse(CefBrowser browser, CefFrame frame, CefRequest request, bool is_redirect);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1001
            /// <summary>
            /// Called on the UI thread before OnBeforeBrowse in certain limited cases
            /// where navigating a new or different browser might be desirable. This
            /// includes user-initiated navigation that might open in a special way (e.g.
            /// links clicked via middle-click or ctrl + left-click) and certain types of
            /// cross-origin navigation initiated from the renderer process (e.g.
            /// navigating the top-level frame to/from a file URL). The |browser| and
            /// |frame| values represent the source of the navigation. The
            /// |target_disposition| value indicates where the user intended to navigate
            /// the browser based on standard Chromium behaviors (e.g. current tab,
            /// new tab, etc). The |user_gesture| value will be true if the browser
            /// navigated via explicit user gesture (e.g. clicking a link) or false if it
            /// navigated automatically (e.g. via the DomContentLoaded event). Return true
            /// to cancel the navigation or false to allow the navigation to proceed in the
            /// source browser's top-level frame.
            /// /*cef()*/
            /// </summary>
            bool OnOpenURLFromTab(CefBrowser browser, CefFrame frame, string target_url, cef_window_open_disposition_t target_disposition, bool user_gesture);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1002
            /// <summary>
            /// Called on the IO thread before a resource request is loaded. The |request|
            /// object may be modified. Return RV_CONTINUE to continue the request
            /// immediately. Return RV_CONTINUE_ASYNC and call CefRequestCallback::
            /// Continue() at a later time to continue or cancel the request
            /// asynchronously. Return RV_CANCEL to cancel the request immediately.
            ///
            /// /*cef(default_retval=RV_CONTINUE)*/
            /// </summary>
            cef_return_value_t OnBeforeResourceLoad(CefBrowser browser, CefFrame frame, CefRequest request, CefRequestCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1003
            /// <summary>
            /// Called on the IO thread before a resource is loaded. To allow the resource
            /// to load normally return NULL. To specify a handler for the resource return
            /// a CefResourceHandler object. The |request| object should not be modified in
            /// this callback.
            /// /*cef()*/
            /// </summary>
            CefResourceHandler GetResourceHandler(CefBrowser browser, CefFrame frame, CefRequest request);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1004
            /// <summary>
            /// Called on the IO thread when a resource load is redirected. The |request|
            /// parameter will contain the old URL and other request-related information.
            /// The |response| parameter will contain the response that resulted in the
            /// redirect. The |new_url| parameter will contain the new URL and can be
            /// changed if desired. The |request| object cannot be modified in this
            /// callback.
            /// /*cef()*/
            /// </summary>
            void OnResourceRedirect(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, ref string new_url);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1005
            /// <summary>
            /// Called on the IO thread when a resource response is received. To allow the
            /// resource to load normally return false. To redirect or retry the resource
            /// modify |request| (url, headers or post body) and return true. The
            /// |response| object cannot be modified in this callback.
            /// /*cef()*/
            /// </summary>
            bool OnResourceResponse(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1006
            /// <summary>
            /// Called on the IO thread to optionally filter resource response content.
            /// |request| and |response| represent the request and response respectively
            /// and cannot be modified in this callback.
            /// /*cef()*/
            /// </summary>
            CefResponseFilter GetResourceResponseFilter(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1007
            /// <summary>
            /// Called on the IO thread when a resource load has completed. |request| and
            /// |response| represent the request and response respectively and cannot be
            /// modified in this callback. |status| indicates the load completion status.
            /// |received_content_length| is the number of response bytes actually read.
            /// /*cef()*/
            /// </summary>
            void OnResourceLoadComplete(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, cef_urlrequest_status_t status, long received_content_length);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1008
            /// <summary>
            /// Called on the IO thread when the browser needs credentials from the user.
            /// |isProxy| indicates whether the host is a proxy server. |host| contains the
            /// hostname and |port| contains the port number. |realm| is the realm of the
            /// challenge and may be empty. |scheme| is the authentication scheme used,
            /// such as "basic" or "digest", and will be empty if the source of the request
            /// is an FTP server. Return true to continue the request and call
            /// CefAuthCallback::Continue() either in this method or at a later time when
            /// the authentication information is available. Return false to cancel the
            /// request immediately.
            /// /*cef(optional_param=realm,optional_param=scheme)*/
            /// </summary>
            bool GetAuthCredentials(CefBrowser browser, CefFrame frame, bool isProxy, string host, int port, string realm, string scheme, CefAuthCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1009
            /// <summary>
            /// Called on the IO thread when JavaScript requests a specific storage quota
            /// size via the webkitStorageInfo.requestQuota function. |origin_url| is the
            /// origin of the page making the request. |new_size| is the requested quota
            /// size in bytes. Return true to continue the request and call
            /// CefRequestCallback::Continue() either in this method or at a later time to
            /// grant or deny the request. Return false to cancel the request immediately.
            /// /*cef()*/
            /// </summary>
            bool OnQuotaRequest(CefBrowser browser, string origin_url, long new_size, CefRequestCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1010
            /// <summary>
            /// Called on the UI thread to handle requests for URLs with an unknown
            /// protocol component. Set |allow_os_execution| to true to attempt execution
            /// via the registered OS protocol handler, if any.
            /// SECURITY WARNING: YOU SHOULD USE THIS METHOD TO ENFORCE RESTRICTIONS BASED
            /// ON SCHEME, HOST OR OTHER URL ANALYSIS BEFORE ALLOWING OS EXECUTION.
            /// /*cef()*/
            /// </summary>
            void OnProtocolExecution(CefBrowser browser, string url, ref bool allow_os_execution);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1011
            /// <summary>
            /// Called on the UI thread to handle requests for URLs with an invalid
            /// SSL certificate. Return true and call CefRequestCallback::Continue() either
            /// in this method or at a later time to continue or cancel the request. Return
            /// false to cancel the request immediately. If
            /// CefSettings.ignore_certificate_errors is set all invalid certificates will
            /// be accepted without calling this method.
            /// /*cef()*/
            /// </summary>
            bool OnCertificateError(CefBrowser browser, cef_errorcode_t cert_error, string request_url, CefSSLInfo ssl_info, CefRequestCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1012
            /// <summary>
            /// Called on the UI thread when a client certificate is being requested for
            /// authentication. Return false to use the default behavior and automatically
            /// select the first certificate available. Return true and call
            /// CefSelectClientCertificateCallback::Select either in this method or at a
            /// later time to select a certificate. Do not call Select or call it with NULL
            /// to continue without using any certificate. |isProxy| indicates whether the
            /// host is an HTTPS proxy or the origin server. |host| and |port| contains the
            /// hostname and port of the SSL server. |certificates| is the list of
            /// certificates to choose from; this list has already been pruned by Chromium
            /// so that it only contains certificates from issuers that the server trusts.
            /// /*cef()*/
            /// </summary>
            bool OnSelectClientCertificate(CefBrowser browser, bool isProxy, string host, int port, CefX509CertificateList certificates, CefSelectClientCertificateCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1013
            /// <summary>
            /// Called on the browser process UI thread when a plugin has crashed.
            /// |plugin_path| is the path of the plugin that crashed.
            /// /*cef()*/
            /// </summary>
            void OnPluginCrashed(CefBrowser browser, string plugin_path);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1014
            /// <summary>
            /// Called on the browser process UI thread when the render view associated
            /// with |browser| is ready to receive/handle IPC messages in the render
            /// process.
            /// /*cef()*/
            /// </summary>
            void OnRenderViewReady(CefBrowser browser);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1015
            /// <summary>
            /// Called on the browser process UI thread when the render process
            /// terminates unexpectedly. |status| indicates how the process
            /// terminated.
            /// /*cef()*/
            /// </summary>
            void OnRenderProcessTerminated(CefBrowser browser, cef_termination_status_t status);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,1016
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,1017
                case CefRequestHandlerExt_OnBeforeBrowse_1:
                    {
                        var args = new OnBeforeBrowseArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeBrowse(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeBrowse(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1018
                case CefRequestHandlerExt_OnOpenURLFromTab_2:
                    {
                        var args = new OnOpenURLFromTabArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnOpenURLFromTab(args);
                        }
                        if (i1 != null)
                        {
                            OnOpenURLFromTab(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1019
                case CefRequestHandlerExt_OnBeforeResourceLoad_3:
                    {
                        var args = new OnBeforeResourceLoadArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnBeforeResourceLoad(args);
                        }
                        if (i1 != null)
                        {
                            OnBeforeResourceLoad(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1020
                case CefRequestHandlerExt_GetResourceHandler_4:
                    {
                        var args = new GetResourceHandlerArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetResourceHandler(args);
                        }
                        if (i1 != null)
                        {
                            GetResourceHandler(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1021
                case CefRequestHandlerExt_OnResourceRedirect_5:
                    {
                        var args = new OnResourceRedirectArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnResourceRedirect(args);
                        }
                        if (i1 != null)
                        {
                            OnResourceRedirect(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1022
                case CefRequestHandlerExt_OnResourceResponse_6:
                    {
                        var args = new OnResourceResponseArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnResourceResponse(args);
                        }
                        if (i1 != null)
                        {
                            OnResourceResponse(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1023
                case CefRequestHandlerExt_GetResourceResponseFilter_7:
                    {
                        var args = new GetResourceResponseFilterArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetResourceResponseFilter(args);
                        }
                        if (i1 != null)
                        {
                            GetResourceResponseFilter(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1024
                case CefRequestHandlerExt_OnResourceLoadComplete_8:
                    {
                        var args = new OnResourceLoadCompleteArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnResourceLoadComplete(args);
                        }
                        if (i1 != null)
                        {
                            OnResourceLoadComplete(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1025
                case CefRequestHandlerExt_GetAuthCredentials_9:
                    {
                        var args = new GetAuthCredentialsArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetAuthCredentials(args);
                        }
                        if (i1 != null)
                        {
                            GetAuthCredentials(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1026
                case CefRequestHandlerExt_OnQuotaRequest_10:
                    {
                        var args = new OnQuotaRequestArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnQuotaRequest(args);
                        }
                        if (i1 != null)
                        {
                            OnQuotaRequest(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1027
                case CefRequestHandlerExt_OnProtocolExecution_11:
                    {
                        var args = new OnProtocolExecutionArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnProtocolExecution(args);
                        }
                        if (i1 != null)
                        {
                            OnProtocolExecution(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1028
                case CefRequestHandlerExt_OnCertificateError_12:
                    {
                        var args = new OnCertificateErrorArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnCertificateError(args);
                        }
                        if (i1 != null)
                        {
                            OnCertificateError(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1029
                case CefRequestHandlerExt_OnSelectClientCertificate_13:
                    {
                        var args = new OnSelectClientCertificateArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnSelectClientCertificate(args);
                        }
                        if (i1 != null)
                        {
                            OnSelectClientCertificate(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1030
                case CefRequestHandlerExt_OnPluginCrashed_14:
                    {
                        var args = new OnPluginCrashedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnPluginCrashed(args);
                        }
                        if (i1 != null)
                        {
                            OnPluginCrashed(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1031
                case CefRequestHandlerExt_OnRenderViewReady_15:
                    {
                        var args = new OnRenderViewReadyArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRenderViewReady(args);
                        }
                        if (i1 != null)
                        {
                            OnRenderViewReady(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1032
                case CefRequestHandlerExt_OnRenderProcessTerminated_16:
                    {
                        var args = new OnRenderProcessTerminatedArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRenderProcessTerminated(args);
                        }
                        if (i1 != null)
                        {
                            OnRenderProcessTerminated(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,1033
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefRequestHandlerExt_OnBeforeBrowse_1:
                    i0.OnBeforeBrowse(new OnBeforeBrowseArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnOpenURLFromTab_2:
                    i0.OnOpenURLFromTab(new OnOpenURLFromTabArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnBeforeResourceLoad_3:
                    i0.OnBeforeResourceLoad(new OnBeforeResourceLoadArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_GetResourceHandler_4:
                    i0.GetResourceHandler(new GetResourceHandlerArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnResourceRedirect_5:
                    i0.OnResourceRedirect(new OnResourceRedirectArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnResourceResponse_6:
                    i0.OnResourceResponse(new OnResourceResponseArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_GetResourceResponseFilter_7:
                    i0.GetResourceResponseFilter(new GetResourceResponseFilterArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnResourceLoadComplete_8:
                    i0.OnResourceLoadComplete(new OnResourceLoadCompleteArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_GetAuthCredentials_9:
                    i0.GetAuthCredentials(new GetAuthCredentialsArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnQuotaRequest_10:
                    i0.OnQuotaRequest(new OnQuotaRequestArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnProtocolExecution_11:
                    i0.OnProtocolExecution(new OnProtocolExecutionArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnCertificateError_12:
                    i0.OnCertificateError(new OnCertificateErrorArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnSelectClientCertificate_13:
                    i0.OnSelectClientCertificate(new OnSelectClientCertificateArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnPluginCrashed_14:
                    i0.OnPluginCrashed(new OnPluginCrashedArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnRenderViewReady_15:
                    i0.OnRenderViewReady(new OnRenderViewReadyArgs(nativeArgPtr));
                    break;
                case CefRequestHandlerExt_OnRenderProcessTerminated_16:
                    i0.OnRenderProcessTerminated(new OnRenderProcessTerminatedArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1034
        public static void OnBeforeBrowse(I1 i1, OnBeforeBrowseArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1035
            args.myext_setRetValue(i1.OnBeforeBrowse(args.browser(),
            args.frame(),
            args.request(),
            args.is_redirect()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1036
        public static void OnOpenURLFromTab(I1 i1, OnOpenURLFromTabArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1037
            args.myext_setRetValue(i1.OnOpenURLFromTab(args.browser(),
            args.frame(),
            args.target_url(),
            args.target_disposition(),
            args.user_gesture()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1038
        public static void OnBeforeResourceLoad(I1 i1, OnBeforeResourceLoadArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1039
            i1.OnBeforeResourceLoad(args.browser(),
            args.frame(),
            args.request(),
            args.callback());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1040
        public static void GetResourceHandler(I1 i1, GetResourceHandlerArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1041
            i1.GetResourceHandler(args.browser(),
            args.frame(),
            args.request());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1042
        public static void OnResourceRedirect(I1 i1, OnResourceRedirectArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1043
            string new_url = args.new_url();
            i1.OnResourceRedirect(args.browser(),
            args.frame(),
            args.request(),
            args.response(),
            ref new_url);
            args.new_url(new_url);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1044
        public static void OnResourceResponse(I1 i1, OnResourceResponseArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1045
            args.myext_setRetValue(i1.OnResourceResponse(args.browser(),
            args.frame(),
            args.request(),
            args.response()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1046
        public static void GetResourceResponseFilter(I1 i1, GetResourceResponseFilterArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1047
            i1.GetResourceResponseFilter(args.browser(),
            args.frame(),
            args.request(),
            args.response());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1048
        public static void OnResourceLoadComplete(I1 i1, OnResourceLoadCompleteArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1049
            i1.OnResourceLoadComplete(args.browser(),
            args.frame(),
            args.request(),
            args.response(),
            args.status(),
            args.received_content_length());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1050
        public static void GetAuthCredentials(I1 i1, GetAuthCredentialsArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1051
            args.myext_setRetValue(i1.GetAuthCredentials(args.browser(),
            args.frame(),
            args.isProxy(),
            args.host(),
            args.port(),
            args.realm(),
            args.scheme(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1052
        public static void OnQuotaRequest(I1 i1, OnQuotaRequestArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1053
            args.myext_setRetValue(i1.OnQuotaRequest(args.browser(),
            args.origin_url(),
            args.new_size(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1054
        public static void OnProtocolExecution(I1 i1, OnProtocolExecutionArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1055
            bool allow_os_execution = false;
            i1.OnProtocolExecution(args.browser(),
            args.url(),
            ref allow_os_execution);
            args.allow_os_execution(allow_os_execution);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1056
        public static void OnCertificateError(I1 i1, OnCertificateErrorArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1057
            args.myext_setRetValue(i1.OnCertificateError(args.browser(),
            args.cert_error(),
            args.request_url(),
            args.ssl_info(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1058
        public static void OnSelectClientCertificate(I1 i1, OnSelectClientCertificateArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1059
            args.myext_setRetValue(i1.OnSelectClientCertificate(args.browser(),
            args.isProxy(),
            args.host(),
            args.port(),
            args.certificates(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1060
        public static void OnPluginCrashed(I1 i1, OnPluginCrashedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1061
            i1.OnPluginCrashed(args.browser(),
            args.plugin_path());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1062
        public static void OnRenderViewReady(I1 i1, OnRenderViewReadyArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1063
            i1.OnRenderViewReady(args.browser());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1064
        public static void OnRenderProcessTerminated(I1 i1, OnRenderProcessTerminatedArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1065
            i1.OnRenderProcessTerminated(args.browser(),
            args.status());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,1066
    public struct CefResourceBundleHandler
    {
        public const int _typeNAME = 75;
        internal IntPtr nativePtr;
        public CefResourceBundleHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefResourceBundleHandlerExt_GetLocalizedString_1 = 1;
        public const int CefResourceBundleHandlerExt_GetDataResource_2 = 2;
        public const int CefResourceBundleHandlerExt_GetDataResourceForScale_3 = 3;
        //gen! bool GetLocalizedString(int string_id,CefString& string)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1067
        /// <summary>
        /// Called to retrieve a localized translation for the specified |string_id|.
        /// To provide the translation set |string| to the translation string and
        /// return true. To use the default translation return false. Include
        /// cef_pack_strings.h for a listing of valid string ID values.
        /// /*cef()*/
        /// </summary>
        public struct GetLocalizedStringArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetLocalizedStringArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetLocalizedStringNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetLocalizedStringNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetLocalizedStringNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public int string_id()
            {
                unsafe
                {
                    return ((GetLocalizedStringNativeArgs*)this.nativePtr)->string_id;
                }
            }
            public string _string()
            {
                unsafe
                {
                    IntPtr str_address = *(((GetLocalizedStringNativeArgs*)this.nativePtr)->_string);
                    return Cef3Binder.GetAsString(str_address);
                }
            }
            public void _string(string value)
            {
                unsafe
                {
                    *(((GetLocalizedStringNativeArgs*)this.nativePtr)->_string) = Cef3Binder.MyCefCreateStringHolder(value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1068
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetLocalizedStringNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public int string_id;
            public IntPtr* _string;
        }
        //gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1069
        /// <summary>
        /// Called to retrieve data for the specified scale independent |resource_id|.
        /// To provide the resource data set |data| and |data_size| to the data pointer
        /// and size respectively and return true. To use the default resource data
        /// return false. The resource data will not be copied and must remain resident
        /// in memory. Include cef_pack_resources.h for a listing of valid resource ID
        /// values.
        /// /*cef()*/
        /// </summary>
        public struct GetDataResourceArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetDataResourceArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetDataResourceNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetDataResourceNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetDataResourceNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public int resource_id()
            {
                unsafe
                {
                    return ((GetDataResourceNativeArgs*)this.nativePtr)->resource_id;
                }
            }
            public IntPtr data()
            {
                unsafe
                {
                    return ((GetDataResourceNativeArgs*)this.nativePtr)->data;
                }
            }
            public uint data_size()
            {
                unsafe
                {
                    return *(((GetDataResourceNativeArgs*)this.nativePtr)->data_size);
                }
            }
            public void data_size(uint value)
            {
                unsafe
                {
                    *(((GetDataResourceNativeArgs*)this.nativePtr)->data_size) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1070
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetDataResourceNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public int resource_id;
            public IntPtr data;
            public uint* data_size;
        }
        //gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1071
        /// <summary>
        /// Called to retrieve data for the specified |resource_id| nearest the scale
        /// factor |scale_factor|. To provide the resource data set |data| and
        /// |data_size| to the data pointer and size respectively and return true. To
        /// use the default resource data return false. The resource data will not be
        /// copied and must remain resident in memory. Include cef_pack_resources.h for
        /// a listing of valid resource ID values.
        /// /*cef()*/
        /// </summary>
        public struct GetDataResourceForScaleArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetDataResourceForScaleArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetDataResourceForScaleNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetDataResourceForScaleNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetDataResourceForScaleNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public int resource_id()
            {
                unsafe
                {
                    return ((GetDataResourceForScaleNativeArgs*)this.nativePtr)->resource_id;
                }
            }
            public cef_scale_factor_t scale_factor()
            {
                unsafe
                {
                    return (cef_scale_factor_t)(((GetDataResourceForScaleNativeArgs*)this.nativePtr)->scale_factor);
                }
            }
            public IntPtr data()
            {
                unsafe
                {
                    return ((GetDataResourceForScaleNativeArgs*)this.nativePtr)->data;
                }
            }
            public uint data_size()
            {
                unsafe
                {
                    return *(((GetDataResourceForScaleNativeArgs*)this.nativePtr)->data_size);
                }
            }
            public void data_size(uint value)
            {
                unsafe
                {
                    *(((GetDataResourceForScaleNativeArgs*)this.nativePtr)->data_size) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1072
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetDataResourceForScaleNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public int resource_id;
            public cef_scale_factor_t scale_factor;
            public IntPtr data;
            public uint* data_size;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1073
            /// <summary>
            /// Called to retrieve a localized translation for the specified |string_id|.
            /// To provide the translation set |string| to the translation string and
            /// return true. To use the default translation return false. Include
            /// cef_pack_strings.h for a listing of valid string ID values.
            /// /*cef()*/
            /// </summary>
            void GetLocalizedString(GetLocalizedStringArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1074
            /// <summary>
            /// Called to retrieve data for the specified scale independent |resource_id|.
            /// To provide the resource data set |data| and |data_size| to the data pointer
            /// and size respectively and return true. To use the default resource data
            /// return false. The resource data will not be copied and must remain resident
            /// in memory. Include cef_pack_resources.h for a listing of valid resource ID
            /// values.
            /// /*cef()*/
            /// </summary>
            void GetDataResource(GetDataResourceArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1075
            /// <summary>
            /// Called to retrieve data for the specified |resource_id| nearest the scale
            /// factor |scale_factor|. To provide the resource data set |data| and
            /// |data_size| to the data pointer and size respectively and return true. To
            /// use the default resource data return false. The resource data will not be
            /// copied and must remain resident in memory. Include cef_pack_resources.h for
            /// a listing of valid resource ID values.
            /// /*cef()*/
            /// </summary>
            void GetDataResourceForScale(GetDataResourceForScaleArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1076
            /// <summary>
            /// Called to retrieve a localized translation for the specified |string_id|.
            /// To provide the translation set |string| to the translation string and
            /// return true. To use the default translation return false. Include
            /// cef_pack_strings.h for a listing of valid string ID values.
            /// /*cef()*/
            /// </summary>
            bool GetLocalizedString(int string_id, ref string _string);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1077
            /// <summary>
            /// Called to retrieve data for the specified scale independent |resource_id|.
            /// To provide the resource data set |data| and |data_size| to the data pointer
            /// and size respectively and return true. To use the default resource data
            /// return false. The resource data will not be copied and must remain resident
            /// in memory. Include cef_pack_resources.h for a listing of valid resource ID
            /// values.
            /// /*cef()*/
            /// </summary>
            bool GetDataResource(int resource_id, IntPtr data, ref uint data_size);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1078
            /// <summary>
            /// Called to retrieve data for the specified |resource_id| nearest the scale
            /// factor |scale_factor|. To provide the resource data set |data| and
            /// |data_size| to the data pointer and size respectively and return true. To
            /// use the default resource data return false. The resource data will not be
            /// copied and must remain resident in memory. Include cef_pack_resources.h for
            /// a listing of valid resource ID values.
            /// /*cef()*/
            /// </summary>
            bool GetDataResourceForScale(int resource_id, cef_scale_factor_t scale_factor, IntPtr data, ref uint data_size);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,1079
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,1080
                case CefResourceBundleHandlerExt_GetLocalizedString_1:
                    {
                        var args = new GetLocalizedStringArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetLocalizedString(args);
                        }
                        if (i1 != null)
                        {
                            GetLocalizedString(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1081
                case CefResourceBundleHandlerExt_GetDataResource_2:
                    {
                        var args = new GetDataResourceArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetDataResource(args);
                        }
                        if (i1 != null)
                        {
                            GetDataResource(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1082
                case CefResourceBundleHandlerExt_GetDataResourceForScale_3:
                    {
                        var args = new GetDataResourceForScaleArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetDataResourceForScale(args);
                        }
                        if (i1 != null)
                        {
                            GetDataResourceForScale(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,1083
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefResourceBundleHandlerExt_GetLocalizedString_1:
                    i0.GetLocalizedString(new GetLocalizedStringArgs(nativeArgPtr));
                    break;
                case CefResourceBundleHandlerExt_GetDataResource_2:
                    i0.GetDataResource(new GetDataResourceArgs(nativeArgPtr));
                    break;
                case CefResourceBundleHandlerExt_GetDataResourceForScale_3:
                    i0.GetDataResourceForScale(new GetDataResourceForScaleArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1084
        public static void GetLocalizedString(I1 i1, GetLocalizedStringArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1085
            string _string = args._string();
            args.myext_setRetValue(i1.GetLocalizedString(args.string_id(),
            ref _string));
            args._string(_string);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1086
        public static void GetDataResource(I1 i1, GetDataResourceArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1087
            uint data_size = 0;
            args.myext_setRetValue(i1.GetDataResource(args.resource_id(),
            args.data(),
            ref data_size));
            args.data_size(data_size);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1088
        public static void GetDataResourceForScale(I1 i1, GetDataResourceForScaleArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1089
            uint data_size = 0;
            args.myext_setRetValue(i1.GetDataResourceForScale(args.resource_id(),
            args.scale_factor(),
            args.data(),
            ref data_size));
            args.data_size(data_size);
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,1090
    public struct CefResourceHandler
    {
        public const int _typeNAME = 76;
        internal IntPtr nativePtr;
        public CefResourceHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefResourceHandlerExt_ProcessRequest_1 = 1;
        public const int CefResourceHandlerExt_GetResponseHeaders_2 = 2;
        public const int CefResourceHandlerExt_ReadResponse_3 = 3;
        public const int CefResourceHandlerExt_CanGetCookie_4 = 4;
        public const int CefResourceHandlerExt_CanSetCookie_5 = 5;
        public const int CefResourceHandlerExt_Cancel_6 = 6;
        //gen! bool ProcessRequest(CefRefPtr<CefRequest> request,CefRefPtr<CefCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1091
        /// <summary>
        /// Begin processing the request. To handle the request return true and call
        /// CefCallback::Continue() once the response header information is available
        /// (CefCallback::Continue() can also be called from inside this method if
        /// header information is available immediately). To cancel the request return
        /// false.
        /// /*cef()*/
        /// </summary>
        public struct ProcessRequestArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal ProcessRequestArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((ProcessRequestNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((ProcessRequestNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((ProcessRequestNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((ProcessRequestNativeArgs*)this.nativePtr)->request);
                }
            }
            public CefCallback callback()
            {
                unsafe
                {
                    return new CefCallback(((ProcessRequestNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1092
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct ProcessRequestNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr request;
            public IntPtr callback;
        }
        //gen! void GetResponseHeaders(CefRefPtr<CefResponse> response,int64& response_length,CefString& redirectUrl)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1093
        /// <summary>
        /// Retrieve response header information. If the response length is not known
        /// set |response_length| to -1 and ReadResponse() will be called until it
        /// returns false. If the response length is known set |response_length|
        /// to a positive value and ReadResponse() will be called until it returns
        /// false or the specified number of bytes have been read. Use the |response|
        /// object to set the mime type, http status code and other optional header
        /// values. To redirect the request to a new URL set |redirectUrl| to the new
        /// URL. If an error occured while setting up the request you can call
        /// SetError() on |response| to indicate the error condition.
        /// /*cef()*/
        /// </summary>
        public struct GetResponseHeadersArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetResponseHeadersArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetResponseHeadersNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetResponseHeadersNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefResponse response()
            {
                unsafe
                {
                    return new CefResponse(((GetResponseHeadersNativeArgs*)this.nativePtr)->response);
                }
            }
            public long response_length()
            {
                unsafe
                {
                    return *(((GetResponseHeadersNativeArgs*)this.nativePtr)->response_length);
                }
            }
            public void response_length(long value)
            {
                unsafe
                {
                    *(((GetResponseHeadersNativeArgs*)this.nativePtr)->response_length) = value;
                }
            }
            public string redirectUrl()
            {
                unsafe
                {
                    IntPtr str_address = *(((GetResponseHeadersNativeArgs*)this.nativePtr)->redirectUrl);
                    return Cef3Binder.GetAsString(str_address);
                }
            }
            public void redirectUrl(string value)
            {
                unsafe
                {
                    *(((GetResponseHeadersNativeArgs*)this.nativePtr)->redirectUrl) = Cef3Binder.MyCefCreateStringHolder(value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1094
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetResponseHeadersNativeArgs
        {
            public int argFlags;
            public IntPtr response;
            public long* response_length;
            public IntPtr* redirectUrl;
        }
        //gen! bool ReadResponse(void* data_out,int bytes_to_read,int& bytes_read,CefRefPtr<CefCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1095
        /// <summary>
        /// Read response data. If data is available immediately copy up to
        /// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
        /// bytes copied, and return true. To read the data at a later time set
        /// |bytes_read| to 0, return true and call CefCallback::Continue() when the
        /// data is available. To indicate response completion return false.
        /// /*cef()*/
        /// </summary>
        public struct ReadResponseArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal ReadResponseArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((ReadResponseNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((ReadResponseNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((ReadResponseNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public IntPtr data_out()
            {
                unsafe
                {
                    return *(((ReadResponseNativeArgs*)this.nativePtr)->data_out);
                }
            }
            public void data_out(IntPtr value)
            {
                unsafe
                {
                    *(((ReadResponseNativeArgs*)this.nativePtr)->data_out) = value;
                }
            }
            public int bytes_to_read()
            {
                unsafe
                {
                    return ((ReadResponseNativeArgs*)this.nativePtr)->bytes_to_read;
                }
            }
            public int bytes_read()
            {
                unsafe
                {
                    return *(((ReadResponseNativeArgs*)this.nativePtr)->bytes_read);
                }
            }
            public void bytes_read(int value)
            {
                unsafe
                {
                    *(((ReadResponseNativeArgs*)this.nativePtr)->bytes_read) = value;
                }
            }
            public CefCallback callback()
            {
                unsafe
                {
                    return new CefCallback(((ReadResponseNativeArgs*)this.nativePtr)->callback);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1096
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct ReadResponseNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr* data_out;
            public int bytes_to_read;
            public int* bytes_read;
            public IntPtr callback;
        }
        //gen! bool CanGetCookie(const CefCookie& cookie)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1097
        /// <summary>
        /// Return true if the specified cookie can be sent with the request or false
        /// otherwise. If false is returned for any cookie then no cookies will be sent
        /// with the request.
        /// /*cef()*/
        /// </summary>
        public struct CanGetCookieArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal CanGetCookieArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((CanGetCookieNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((CanGetCookieNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((CanGetCookieNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefCookie cookie()
            {
                unsafe
                {
                    return new CefCookie(((CanGetCookieNativeArgs*)this.nativePtr)->cookie);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1098
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct CanGetCookieNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr cookie;
        }
        //gen! bool CanSetCookie(const CefCookie& cookie)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1099
        /// <summary>
        /// Return true if the specified cookie returned with the response can be set
        /// or false otherwise.
        /// /*cef()*/
        /// </summary>
        public struct CanSetCookieArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal CanSetCookieArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((CanSetCookieNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((CanSetCookieNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((CanSetCookieNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefCookie cookie()
            {
                unsafe
                {
                    return new CefCookie(((CanSetCookieNativeArgs*)this.nativePtr)->cookie);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1100
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct CanSetCookieNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr cookie;
        }
        //gen! void Cancel()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1101
        /// <summary>
        /// Request processing has been canceled.
        /// /*cef()*/
        /// </summary>
        public struct CancelArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal CancelArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((CancelNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((CancelNativeArgs*)this.nativePtr)->argFlags);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1102
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct CancelNativeArgs
        {
            public int argFlags;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1103
            /// <summary>
            /// Begin processing the request. To handle the request return true and call
            /// CefCallback::Continue() once the response header information is available
            /// (CefCallback::Continue() can also be called from inside this method if
            /// header information is available immediately). To cancel the request return
            /// false.
            /// /*cef()*/
            /// </summary>
            void ProcessRequest(ProcessRequestArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1104
            /// <summary>
            /// Retrieve response header information. If the response length is not known
            /// set |response_length| to -1 and ReadResponse() will be called until it
            /// returns false. If the response length is known set |response_length|
            /// to a positive value and ReadResponse() will be called until it returns
            /// false or the specified number of bytes have been read. Use the |response|
            /// object to set the mime type, http status code and other optional header
            /// values. To redirect the request to a new URL set |redirectUrl| to the new
            /// URL. If an error occured while setting up the request you can call
            /// SetError() on |response| to indicate the error condition.
            /// /*cef()*/
            /// </summary>
            void GetResponseHeaders(GetResponseHeadersArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1105
            /// <summary>
            /// Read response data. If data is available immediately copy up to
            /// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
            /// bytes copied, and return true. To read the data at a later time set
            /// |bytes_read| to 0, return true and call CefCallback::Continue() when the
            /// data is available. To indicate response completion return false.
            /// /*cef()*/
            /// </summary>
            void ReadResponse(ReadResponseArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1106
            /// <summary>
            /// Return true if the specified cookie can be sent with the request or false
            /// otherwise. If false is returned for any cookie then no cookies will be sent
            /// with the request.
            /// /*cef()*/
            /// </summary>
            void CanGetCookie(CanGetCookieArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1107
            /// <summary>
            /// Return true if the specified cookie returned with the response can be set
            /// or false otherwise.
            /// /*cef()*/
            /// </summary>
            void CanSetCookie(CanSetCookieArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1108
            /// <summary>
            /// Request processing has been canceled.
            /// /*cef()*/
            /// </summary>
            void Cancel(CancelArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1109
            /// <summary>
            /// Begin processing the request. To handle the request return true and call
            /// CefCallback::Continue() once the response header information is available
            /// (CefCallback::Continue() can also be called from inside this method if
            /// header information is available immediately). To cancel the request return
            /// false.
            /// /*cef()*/
            /// </summary>
            bool ProcessRequest(CefRequest request, CefCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1110
            /// <summary>
            /// Retrieve response header information. If the response length is not known
            /// set |response_length| to -1 and ReadResponse() will be called until it
            /// returns false. If the response length is known set |response_length|
            /// to a positive value and ReadResponse() will be called until it returns
            /// false or the specified number of bytes have been read. Use the |response|
            /// object to set the mime type, http status code and other optional header
            /// values. To redirect the request to a new URL set |redirectUrl| to the new
            /// URL. If an error occured while setting up the request you can call
            /// SetError() on |response| to indicate the error condition.
            /// /*cef()*/
            /// </summary>
            void GetResponseHeaders(CefResponse response, ref long response_length, ref string redirectUrl);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1111
            /// <summary>
            /// Read response data. If data is available immediately copy up to
            /// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
            /// bytes copied, and return true. To read the data at a later time set
            /// |bytes_read| to 0, return true and call CefCallback::Continue() when the
            /// data is available. To indicate response completion return false.
            /// /*cef()*/
            /// </summary>
            bool ReadResponse(ref IntPtr data_out, int bytes_to_read, ref int bytes_read, CefCallback callback);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1112
            /// <summary>
            /// Return true if the specified cookie can be sent with the request or false
            /// otherwise. If false is returned for any cookie then no cookies will be sent
            /// with the request.
            /// /*cef()*/
            /// </summary>
            bool CanGetCookie(CefCookie cookie);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1113
            /// <summary>
            /// Return true if the specified cookie returned with the response can be set
            /// or false otherwise.
            /// /*cef()*/
            /// </summary>
            bool CanSetCookie(CefCookie cookie);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1114
            /// <summary>
            /// Request processing has been canceled.
            /// /*cef()*/
            /// </summary>
            void Cancel();
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,1115
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,1116
                case CefResourceHandlerExt_ProcessRequest_1:
                    {
                        var args = new ProcessRequestArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.ProcessRequest(args);
                        }
                        if (i1 != null)
                        {
                            ProcessRequest(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1117
                case CefResourceHandlerExt_GetResponseHeaders_2:
                    {
                        var args = new GetResponseHeadersArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.GetResponseHeaders(args);
                        }
                        if (i1 != null)
                        {
                            GetResponseHeaders(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1118
                case CefResourceHandlerExt_ReadResponse_3:
                    {
                        var args = new ReadResponseArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.ReadResponse(args);
                        }
                        if (i1 != null)
                        {
                            ReadResponse(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1119
                case CefResourceHandlerExt_CanGetCookie_4:
                    {
                        var args = new CanGetCookieArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.CanGetCookie(args);
                        }
                        if (i1 != null)
                        {
                            CanGetCookie(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1120
                case CefResourceHandlerExt_CanSetCookie_5:
                    {
                        var args = new CanSetCookieArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.CanSetCookie(args);
                        }
                        if (i1 != null)
                        {
                            CanSetCookie(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1121
                case CefResourceHandlerExt_Cancel_6:
                    {
                        var args = new CancelArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Cancel(args);
                        }
                        if (i1 != null)
                        {
                            Cancel(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,1122
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefResourceHandlerExt_ProcessRequest_1:
                    i0.ProcessRequest(new ProcessRequestArgs(nativeArgPtr));
                    break;
                case CefResourceHandlerExt_GetResponseHeaders_2:
                    i0.GetResponseHeaders(new GetResponseHeadersArgs(nativeArgPtr));
                    break;
                case CefResourceHandlerExt_ReadResponse_3:
                    i0.ReadResponse(new ReadResponseArgs(nativeArgPtr));
                    break;
                case CefResourceHandlerExt_CanGetCookie_4:
                    i0.CanGetCookie(new CanGetCookieArgs(nativeArgPtr));
                    break;
                case CefResourceHandlerExt_CanSetCookie_5:
                    i0.CanSetCookie(new CanSetCookieArgs(nativeArgPtr));
                    break;
                case CefResourceHandlerExt_Cancel_6:
                    i0.Cancel(new CancelArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1123
        public static void ProcessRequest(I1 i1, ProcessRequestArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1124
            args.myext_setRetValue(i1.ProcessRequest(args.request(),
            args.callback()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1125
        public static void GetResponseHeaders(I1 i1, GetResponseHeadersArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1126
            long response_length = 0;
            string redirectUrl = args.redirectUrl();
            i1.GetResponseHeaders(args.response(),
            ref response_length,
            ref redirectUrl);
            args.response_length(response_length);
            args.redirectUrl(redirectUrl);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1127
        public static void ReadResponse(I1 i1, ReadResponseArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1128
            IntPtr data_out = IntPtr.Zero;
            int bytes_read = 0;
            args.myext_setRetValue(i1.ReadResponse(ref data_out,
            args.bytes_to_read(),
            ref bytes_read,
            args.callback()));
            args.data_out(data_out);
            args.bytes_read(bytes_read);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1129
        public static void CanGetCookie(I1 i1, CanGetCookieArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1130
            args.myext_setRetValue(i1.CanGetCookie(args.cookie()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1131
        public static void CanSetCookie(I1 i1, CanSetCookieArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1132
            args.myext_setRetValue(i1.CanSetCookie(args.cookie()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1133
        public static void Cancel(I1 i1, CancelArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1134
            i1.Cancel();
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,1135
    public struct CefReadHandler
    {
        public const int _typeNAME = 77;
        internal IntPtr nativePtr;
        public CefReadHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefReadHandlerExt_Read_1 = 1;
        public const int CefReadHandlerExt_Seek_2 = 2;
        public const int CefReadHandlerExt_Tell_3 = 3;
        public const int CefReadHandlerExt_Eof_4 = 4;
        public const int CefReadHandlerExt_MayBlock_5 = 5;
        //gen! size_t Read(void* ptr,size_t size,size_t n)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1136
        /// <summary>
        /// Read raw binary data.
        /// /*cef()*/
        /// </summary>
        public struct ReadArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal ReadArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((ReadNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((ReadNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((ReadNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public IntPtr ptr()
            {
                unsafe
                {
                    return *(((ReadNativeArgs*)this.nativePtr)->ptr);
                }
            }
            public void ptr(IntPtr value)
            {
                unsafe
                {
                    *(((ReadNativeArgs*)this.nativePtr)->ptr) = value;
                }
            }
            public uint size()
            {
                unsafe
                {
                    return ((ReadNativeArgs*)this.nativePtr)->size;
                }
            }
            public uint n()
            {
                unsafe
                {
                    return ((ReadNativeArgs*)this.nativePtr)->n;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1137
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct ReadNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
            public IntPtr* ptr;
            public uint size;
            public uint n;
        }
        //gen! int Seek(int64 offset,int whence)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1138
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Return zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        public struct SeekArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal SeekArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((SeekNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((SeekNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((SeekNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public long offset()
            {
                unsafe
                {
                    return ((SeekNativeArgs*)this.nativePtr)->offset;
                }
            }
            public int whence()
            {
                unsafe
                {
                    return ((SeekNativeArgs*)this.nativePtr)->whence;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1139
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct SeekNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
            public long offset;
            public int whence;
        }
        //gen! int64 Tell()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1140
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        public struct TellArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal TellArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((TellNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((TellNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(long value)
            {
                unsafe
                {
                    ((TellNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1141
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct TellNativeArgs
        {
            public int argFlags;
            public long myext_ret_value;
        }
        //gen! int Eof()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1142
        /// <summary>
        /// Return non-zero if at end of file.
        /// /*cef()*/
        /// </summary>
        public struct EofArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal EofArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((EofNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((EofNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((EofNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1143
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct EofNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
        }
        //gen! bool MayBlock()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1144
        /// <summary>
        /// Return true if this handler performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// handler from.
        /// /*cef()*/
        /// </summary>
        public struct MayBlockArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal MayBlockArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((MayBlockNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((MayBlockNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((MayBlockNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1145
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct MayBlockNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1146
            /// <summary>
            /// Read raw binary data.
            /// /*cef()*/
            /// </summary>
            void Read(ReadArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1147
            /// <summary>
            /// Seek to the specified offset position. |whence| may be any one of
            /// SEEK_CUR, SEEK_END or SEEK_SET. Return zero on success and non-zero on
            /// failure.
            /// /*cef()*/
            /// </summary>
            void Seek(SeekArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1148
            /// <summary>
            /// Return the current offset position.
            /// /*cef()*/
            /// </summary>
            void Tell(TellArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1149
            /// <summary>
            /// Return non-zero if at end of file.
            /// /*cef()*/
            /// </summary>
            void Eof(EofArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1150
            /// <summary>
            /// Return true if this handler performs work like accessing the file system
            /// which may block. Used as a hint for determining the thread to access the
            /// handler from.
            /// /*cef()*/
            /// </summary>
            void MayBlock(MayBlockArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1151
            /// <summary>
            /// Read raw binary data.
            /// /*cef()*/
            /// </summary>
            uint Read(ref IntPtr ptr, uint size, uint n);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1152
            /// <summary>
            /// Seek to the specified offset position. |whence| may be any one of
            /// SEEK_CUR, SEEK_END or SEEK_SET. Return zero on success and non-zero on
            /// failure.
            /// /*cef()*/
            /// </summary>
            int Seek(long offset, int whence);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1153
            /// <summary>
            /// Return the current offset position.
            /// /*cef()*/
            /// </summary>
            long Tell();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1154
            /// <summary>
            /// Return non-zero if at end of file.
            /// /*cef()*/
            /// </summary>
            int Eof();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1155
            /// <summary>
            /// Return true if this handler performs work like accessing the file system
            /// which may block. Used as a hint for determining the thread to access the
            /// handler from.
            /// /*cef()*/
            /// </summary>
            bool MayBlock();
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,1156
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,1157
                case CefReadHandlerExt_Read_1:
                    {
                        var args = new ReadArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Read(args);
                        }
                        if (i1 != null)
                        {
                            Read(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1158
                case CefReadHandlerExt_Seek_2:
                    {
                        var args = new SeekArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Seek(args);
                        }
                        if (i1 != null)
                        {
                            Seek(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1159
                case CefReadHandlerExt_Tell_3:
                    {
                        var args = new TellArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Tell(args);
                        }
                        if (i1 != null)
                        {
                            Tell(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1160
                case CefReadHandlerExt_Eof_4:
                    {
                        var args = new EofArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Eof(args);
                        }
                        if (i1 != null)
                        {
                            Eof(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1161
                case CefReadHandlerExt_MayBlock_5:
                    {
                        var args = new MayBlockArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.MayBlock(args);
                        }
                        if (i1 != null)
                        {
                            MayBlock(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,1162
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefReadHandlerExt_Read_1:
                    i0.Read(new ReadArgs(nativeArgPtr));
                    break;
                case CefReadHandlerExt_Seek_2:
                    i0.Seek(new SeekArgs(nativeArgPtr));
                    break;
                case CefReadHandlerExt_Tell_3:
                    i0.Tell(new TellArgs(nativeArgPtr));
                    break;
                case CefReadHandlerExt_Eof_4:
                    i0.Eof(new EofArgs(nativeArgPtr));
                    break;
                case CefReadHandlerExt_MayBlock_5:
                    i0.MayBlock(new MayBlockArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1163
        public static void Read(I1 i1, ReadArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1164
            IntPtr ptr = IntPtr.Zero;
            i1.Read(ref ptr,
            args.size(),
            args.n());
            args.ptr(ptr);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1165
        public static void Seek(I1 i1, SeekArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1166
            args.myext_setRetValue(i1.Seek(args.offset(),
            args.whence()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1167
        public static void Tell(I1 i1, TellArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1168
            args.myext_setRetValue(i1.Tell());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1169
        public static void Eof(I1 i1, EofArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1170
            args.myext_setRetValue(i1.Eof());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1171
        public static void MayBlock(I1 i1, MayBlockArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1172
            args.myext_setRetValue(i1.MayBlock());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,1173
    public struct CefWriteHandler
    {
        public const int _typeNAME = 78;
        internal IntPtr nativePtr;
        public CefWriteHandler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefWriteHandlerExt_Write_1 = 1;
        public const int CefWriteHandlerExt_Seek_2 = 2;
        public const int CefWriteHandlerExt_Tell_3 = 3;
        public const int CefWriteHandlerExt_Flush_4 = 4;
        public const int CefWriteHandlerExt_MayBlock_5 = 5;
        //gen! size_t Write(const void* ptr,size_t size,size_t n)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1174
        /// <summary>
        /// Write raw binary data.
        /// /*cef()*/
        /// </summary>
        public struct WriteArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal WriteArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((WriteNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((WriteNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((WriteNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public IntPtr ptr()
            {
                unsafe
                {
                    return ((WriteNativeArgs*)this.nativePtr)->ptr;
                }
            }
            public uint size()
            {
                unsafe
                {
                    return ((WriteNativeArgs*)this.nativePtr)->size;
                }
            }
            public uint n()
            {
                unsafe
                {
                    return ((WriteNativeArgs*)this.nativePtr)->n;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1175
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct WriteNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
            public IntPtr ptr;
            public uint size;
            public uint n;
        }
        //gen! int Seek(int64 offset,int whence)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1176
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Return zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        public struct SeekArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal SeekArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((SeekNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((SeekNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((SeekNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public long offset()
            {
                unsafe
                {
                    return ((SeekNativeArgs*)this.nativePtr)->offset;
                }
            }
            public int whence()
            {
                unsafe
                {
                    return ((SeekNativeArgs*)this.nativePtr)->whence;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1177
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct SeekNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
            public long offset;
            public int whence;
        }
        //gen! int64 Tell()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1178
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        public struct TellArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal TellArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((TellNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((TellNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(long value)
            {
                unsafe
                {
                    ((TellNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1179
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct TellNativeArgs
        {
            public int argFlags;
            public long myext_ret_value;
        }
        //gen! int Flush()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1180
        /// <summary>
        /// Flush the stream.
        /// /*cef()*/
        /// </summary>
        public struct FlushArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal FlushArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((FlushNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((FlushNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((FlushNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1181
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct FlushNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
        }
        //gen! bool MayBlock()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1182
        /// <summary>
        /// Return true if this handler performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// handler from.
        /// /*cef()*/
        /// </summary>
        public struct MayBlockArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal MayBlockArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((MayBlockNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((MayBlockNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((MayBlockNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1183
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct MayBlockNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1184
            /// <summary>
            /// Write raw binary data.
            /// /*cef()*/
            /// </summary>
            void Write(WriteArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1185
            /// <summary>
            /// Seek to the specified offset position. |whence| may be any one of
            /// SEEK_CUR, SEEK_END or SEEK_SET. Return zero on success and non-zero on
            /// failure.
            /// /*cef()*/
            /// </summary>
            void Seek(SeekArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1186
            /// <summary>
            /// Return the current offset position.
            /// /*cef()*/
            /// </summary>
            void Tell(TellArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1187
            /// <summary>
            /// Flush the stream.
            /// /*cef()*/
            /// </summary>
            void Flush(FlushArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1188
            /// <summary>
            /// Return true if this handler performs work like accessing the file system
            /// which may block. Used as a hint for determining the thread to access the
            /// handler from.
            /// /*cef()*/
            /// </summary>
            void MayBlock(MayBlockArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1189
            /// <summary>
            /// Write raw binary data.
            /// /*cef()*/
            /// </summary>
            uint Write(IntPtr ptr, uint size, uint n);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1190
            /// <summary>
            /// Seek to the specified offset position. |whence| may be any one of
            /// SEEK_CUR, SEEK_END or SEEK_SET. Return zero on success and non-zero on
            /// failure.
            /// /*cef()*/
            /// </summary>
            int Seek(long offset, int whence);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1191
            /// <summary>
            /// Return the current offset position.
            /// /*cef()*/
            /// </summary>
            long Tell();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1192
            /// <summary>
            /// Flush the stream.
            /// /*cef()*/
            /// </summary>
            int Flush();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1193
            /// <summary>
            /// Return true if this handler performs work like accessing the file system
            /// which may block. Used as a hint for determining the thread to access the
            /// handler from.
            /// /*cef()*/
            /// </summary>
            bool MayBlock();
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,1194
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,1195
                case CefWriteHandlerExt_Write_1:
                    {
                        var args = new WriteArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Write(args);
                        }
                        if (i1 != null)
                        {
                            Write(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1196
                case CefWriteHandlerExt_Seek_2:
                    {
                        var args = new SeekArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Seek(args);
                        }
                        if (i1 != null)
                        {
                            Seek(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1197
                case CefWriteHandlerExt_Tell_3:
                    {
                        var args = new TellArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Tell(args);
                        }
                        if (i1 != null)
                        {
                            Tell(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1198
                case CefWriteHandlerExt_Flush_4:
                    {
                        var args = new FlushArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Flush(args);
                        }
                        if (i1 != null)
                        {
                            Flush(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,1199
                case CefWriteHandlerExt_MayBlock_5:
                    {
                        var args = new MayBlockArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.MayBlock(args);
                        }
                        if (i1 != null)
                        {
                            MayBlock(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,1200
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefWriteHandlerExt_Write_1:
                    i0.Write(new WriteArgs(nativeArgPtr));
                    break;
                case CefWriteHandlerExt_Seek_2:
                    i0.Seek(new SeekArgs(nativeArgPtr));
                    break;
                case CefWriteHandlerExt_Tell_3:
                    i0.Tell(new TellArgs(nativeArgPtr));
                    break;
                case CefWriteHandlerExt_Flush_4:
                    i0.Flush(new FlushArgs(nativeArgPtr));
                    break;
                case CefWriteHandlerExt_MayBlock_5:
                    i0.MayBlock(new MayBlockArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1201
        public static void Write(I1 i1, WriteArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1202
            i1.Write(args.ptr(),
            args.size(),
            args.n());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1203
        public static void Seek(I1 i1, SeekArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1204
            args.myext_setRetValue(i1.Seek(args.offset(),
            args.whence()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1205
        public static void Tell(I1 i1, TellArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1206
            args.myext_setRetValue(i1.Tell());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1207
        public static void Flush(I1 i1, FlushArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1208
            args.myext_setRetValue(i1.Flush());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1209
        public static void MayBlock(I1 i1, MayBlockArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1210
            args.myext_setRetValue(i1.MayBlock());
        }
    }
    //CsStructModuleCodeGen:: GenerateCsStructClass ,1211
    public struct CefV8Handler
    {
        public const int _typeNAME = 79;
        internal IntPtr nativePtr;
        public CefV8Handler(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public const int CefV8HandlerExt_Execute_1 = 1;
        //gen! bool Execute(const CefString& name,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments,CefRefPtr<CefV8Value>& retval,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,1212
        /// <summary>
        /// Handle execution of the function identified by |name|. |object| is the
        /// receiver ('this' object) of the function. |arguments| is the list of
        /// arguments passed to the function. If execution succeeds set |retval| to the
        /// function return value. If execution fails set |exception| to the exception
        /// that will be thrown. Return true if execution was handled.
        /// /*cef()*/
        /// </summary>
        public struct ExecuteArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal ExecuteArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((ExecuteNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((ExecuteNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((ExecuteNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public string name()
            {
                unsafe
                {
                    return Cef3Binder.GetAsString(((ExecuteNativeArgs*)this.nativePtr)->name);
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((ExecuteNativeArgs*)this.nativePtr)->_object);
                }
            }
            public CefV8ValueList arguments()
            {
                unsafe
                {
                    return new CefV8ValueList(((ExecuteNativeArgs*)this.nativePtr)->arguments);
                }
            }
            public IntPtr retval()
            {
                unsafe
                {
                    return *(((ExecuteNativeArgs*)this.nativePtr)->retval);
                }
            }
            public void retval(IntPtr value)
            {
                unsafe
                {
                    *(((ExecuteNativeArgs*)this.nativePtr)->retval) = value;
                }
            }
            public string exception()
            {
                unsafe
                {
                    IntPtr str_address = *(((ExecuteNativeArgs*)this.nativePtr)->exception);
                    return Cef3Binder.GetAsString(str_address);
                }
            }
            public void exception(string value)
            {
                unsafe
                {
                    *(((ExecuteNativeArgs*)this.nativePtr)->exception) = Cef3Binder.MyCefCreateStringHolder(value);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,1213
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct ExecuteNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr name;
            public IntPtr _object;
            public IntPtr arguments;
            public IntPtr* retval;
            public IntPtr* exception;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,1214
            /// <summary>
            /// Handle execution of the function identified by |name|. |object| is the
            /// receiver ('this' object) of the function. |arguments| is the list of
            /// arguments passed to the function. If execution succeeds set |retval| to the
            /// function return value. If execution fails set |exception| to the exception
            /// that will be thrown. Return true if execution was handled.
            /// /*cef()*/
            /// </summary>
            void Execute(ExecuteArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,1215
            /// <summary>
            /// Handle execution of the function identified by |name|. |object| is the
            /// receiver ('this' object) of the function. |arguments| is the list of
            /// arguments passed to the function. If execution succeeds set |retval| to the
            /// function return value. If execution fails set |exception| to the exception
            /// that will be thrown. Return true if execution was handled.
            /// /*cef()*/
            /// </summary>
            bool Execute(string name, CefV8Value _object, CefV8ValueList arguments, ref IntPtr retval, ref string exception);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,1216
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,1217
                case CefV8HandlerExt_Execute_1:
                    {
                        var args = new ExecuteArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Execute(args);
                        }
                        if (i1 != null)
                        {
                            Execute(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,1218
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case CefV8HandlerExt_Execute_1:
                    i0.Execute(new ExecuteArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,1219
        public static void Execute(I1 i1, ExecuteArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,1220
            IntPtr retval = IntPtr.Zero;
            string exception = args.exception();
            args.myext_setRetValue(i1.Execute(args.name(),
            args._object(),
            args.arguments(),
            ref retval,
            ref exception));
            args.retval(retval);
            args.exception(exception);
        }
    }
}