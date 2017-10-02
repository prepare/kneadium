//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{


    // [virtual] class CefResponseFilter
    //CsCallToNativeCodeGen::GenerateCsCode , 449
    /// <summary>
    /// Implement this interface to filter resource response content. The methods of
    /// this class will be called on the browser process IO thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefResponseFilter : IDisposable
    {
        const int _typeNAME = 28;
        const int CefResponseFilter_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefResponseFilter(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponseFilter_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefResponseFilter New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefResponseFilter(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,229
        const int MyCefResponseFilter_InitFilter_1 = 1;
        const int MyCefResponseFilter_Filter_2 = 2;
        //gen! bool InitFilter()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,230
        /// <summary>
        /// Initialize the response filter. Will only be called a single time. The
        /// filter will not be installed if this method returns false.
        /// /*cef()*/
        /// </summary>
        public struct InitFilterArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal InitFilterArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((InitFilterNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((InitFilterNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((InitFilterNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,231
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct InitFilterNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
        }
        //gen! FilterStatus Filter(void* data_in,size_t data_in_size,size_t& data_in_read,void* data_out,size_t data_out_size,size_t& data_out_written)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,232
        /// <summary>
        /// Called to filter a chunk of data. Expected usage is as follows:
        ///
        ///  A. Read input data from |data_in| and set |data_in_read| to the number of
        ///     bytes that were read up to a maximum of |data_in_size|. |data_in| will
        ///     be NULL if |data_in_size| is zero.
        ///  B. Write filtered output data to |data_out| and set |data_out_written| to
        ///     the number of bytes that were written up to a maximum of
        ///     |data_out_size|. If no output data was written then all data must be
        ///     read from |data_in| (user must set |data_in_read| = |data_in_size|).
        ///  C. Return RESPONSE_FILTER_DONE if all output data was written or
        ///     RESPONSE_FILTER_NEED_MORE_DATA if output data is still pending.
        ///
        /// This method will be called repeatedly until the input buffer has been
        /// fully read (user sets |data_in_read| = |data_in_size|) and there is no
        /// more input data to filter (the resource response is complete). This method
        /// may then be called an additional time with an empty input buffer if the
        /// user filled the output buffer (set |data_out_written| = |data_out_size|)
        /// and returned RESPONSE_FILTER_NEED_MORE_DATA to indicate that output data is
        /// still pending.
        ///
        /// Calls to this method will stop when one of the following conditions is met:
        ///
        ///  A. There is no more input data to filter (the resource response is
        ///     complete) and the user sets |data_out_written| = 0 or returns
        ///     RESPONSE_FILTER_DONE to indicate that all data has been written, or;
        ///  B. The user returns RESPONSE_FILTER_ERROR to indicate an error.
        ///
        /// Do not keep a reference to the buffers passed to this method.
        /// /*cef(optional_param=data_in,default_retval=RESPONSE_FILTER_ERROR)*/
        /// </summary>
        public struct FilterArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal FilterArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((FilterNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((FilterNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(int value)
            {
                unsafe
                {
                    ((FilterNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public IntPtr data_in()
            {
                throw new CefNotImplementedException();
            }
            public uint data_in_size()
            {
                unsafe
                {
                    return ((FilterNativeArgs*)this.nativePtr)->data_in_size;
                }
            }
            public uint data_in_read()
            {
                unsafe
                {
                    return *(((FilterNativeArgs*)this.nativePtr)->data_in_read);
                }
            }
            public void data_in_read(uint value)
            {
                unsafe
                {
                    *(((FilterNativeArgs*)this.nativePtr)->data_in_read) = value;
                }
            }
            public IntPtr data_out()
            {
                throw new CefNotImplementedException();
            }
            public uint data_out_size()
            {
                unsafe
                {
                    return ((FilterNativeArgs*)this.nativePtr)->data_out_size;
                }
            }
            public uint data_out_written()
            {
                unsafe
                {
                    return *(((FilterNativeArgs*)this.nativePtr)->data_out_written);
                }
            }
            public void data_out_written(uint value)
            {
                unsafe
                {
                    *(((FilterNativeArgs*)this.nativePtr)->data_out_written) = value;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,233
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct FilterNativeArgs
        {
            public int argFlags;
            public int myext_ret_value;
            public IntPtr data_in;
            public uint data_in_size;
            public uint* data_in_read;
            public IntPtr data_out;
            public uint data_out_size;
            public uint* data_out_written;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,234
            /// <summary>
            /// Initialize the response filter. Will only be called a single time. The
            /// filter will not be installed if this method returns false.
            /// /*cef()*/
            /// </summary>
            void InitFilter(InitFilterArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,235
            /// <summary>
            /// Called to filter a chunk of data. Expected usage is as follows:
            ///
            ///  A. Read input data from |data_in| and set |data_in_read| to the number of
            ///     bytes that were read up to a maximum of |data_in_size|. |data_in| will
            ///     be NULL if |data_in_size| is zero.
            ///  B. Write filtered output data to |data_out| and set |data_out_written| to
            ///     the number of bytes that were written up to a maximum of
            ///     |data_out_size|. If no output data was written then all data must be
            ///     read from |data_in| (user must set |data_in_read| = |data_in_size|).
            ///  C. Return RESPONSE_FILTER_DONE if all output data was written or
            ///     RESPONSE_FILTER_NEED_MORE_DATA if output data is still pending.
            ///
            /// This method will be called repeatedly until the input buffer has been
            /// fully read (user sets |data_in_read| = |data_in_size|) and there is no
            /// more input data to filter (the resource response is complete). This method
            /// may then be called an additional time with an empty input buffer if the
            /// user filled the output buffer (set |data_out_written| = |data_out_size|)
            /// and returned RESPONSE_FILTER_NEED_MORE_DATA to indicate that output data is
            /// still pending.
            ///
            /// Calls to this method will stop when one of the following conditions is met:
            ///
            ///  A. There is no more input data to filter (the resource response is
            ///     complete) and the user sets |data_out_written| = 0 or returns
            ///     RESPONSE_FILTER_DONE to indicate that all data has been written, or;
            ///  B. The user returns RESPONSE_FILTER_ERROR to indicate an error.
            ///
            /// Do not keep a reference to the buffers passed to this method.
            /// /*cef(optional_param=data_in,default_retval=RESPONSE_FILTER_ERROR)*/
            /// </summary>
            void Filter(FilterArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,236
            /// <summary>
            /// Initialize the response filter. Will only be called a single time. The
            /// filter will not be installed if this method returns false.
            /// /*cef()*/
            /// </summary>
            bool InitFilter();
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,237
            /// <summary>
            /// Called to filter a chunk of data. Expected usage is as follows:
            ///
            ///  A. Read input data from |data_in| and set |data_in_read| to the number of
            ///     bytes that were read up to a maximum of |data_in_size|. |data_in| will
            ///     be NULL if |data_in_size| is zero.
            ///  B. Write filtered output data to |data_out| and set |data_out_written| to
            ///     the number of bytes that were written up to a maximum of
            ///     |data_out_size|. If no output data was written then all data must be
            ///     read from |data_in| (user must set |data_in_read| = |data_in_size|).
            ///  C. Return RESPONSE_FILTER_DONE if all output data was written or
            ///     RESPONSE_FILTER_NEED_MORE_DATA if output data is still pending.
            ///
            /// This method will be called repeatedly until the input buffer has been
            /// fully read (user sets |data_in_read| = |data_in_size|) and there is no
            /// more input data to filter (the resource response is complete). This method
            /// may then be called an additional time with an empty input buffer if the
            /// user filled the output buffer (set |data_out_written| = |data_out_size|)
            /// and returned RESPONSE_FILTER_NEED_MORE_DATA to indicate that output data is
            /// still pending.
            ///
            /// Calls to this method will stop when one of the following conditions is met:
            ///
            ///  A. There is no more input data to filter (the resource response is
            ///     complete) and the user sets |data_out_written| = 0 or returns
            ///     RESPONSE_FILTER_DONE to indicate that all data has been written, or;
            ///  B. The user returns RESPONSE_FILTER_ERROR to indicate an error.
            ///
            /// Do not keep a reference to the buffers passed to this method.
            /// /*cef(optional_param=data_in,default_retval=RESPONSE_FILTER_ERROR)*/
            /// </summary>
            cef_response_filter_status_t Filter(IntPtr data_in, uint data_in_size, ref uint data_in_read, IntPtr data_out, uint data_out_size, ref uint data_out_written);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,238
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,239
                case MyCefResponseFilter_InitFilter_1:
                    {
                        var args = new InitFilterArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.InitFilter(args);
                        }
                        if (i1 != null)
                        {
                            InitFilter(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,240
                case MyCefResponseFilter_Filter_2:
                    {
                        var args = new FilterArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Filter(args);
                        }
                        if (i1 != null)
                        {
                            Filter(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,241
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefResponseFilter_InitFilter_1:
                    i0.InitFilter(new InitFilterArgs(nativeArgPtr));
                    break;
                case MyCefResponseFilter_Filter_2:
                    i0.Filter(new FilterArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,242
        public static void InitFilter(I1 i1, InitFilterArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,243
            args.myext_setRetValue(i1.InitFilter());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,244
        public static void Filter(I1 i1, FilterArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,245
            uint data_in_read = 0;
            uint data_out_written = 0;
            i1.Filter(args.data_in(),
            args.data_in_size(),
            ref data_in_read,
            args.data_out(),
            args.data_out_size(),
            ref data_out_written);
            args.data_in_read(data_in_read);
            args.data_out_written(data_out_written);
        }
    }


    // [virtual] class CefSchemeHandlerFactory
    //CsCallToNativeCodeGen::GenerateCsCode , 450
    /// <summary>
    /// Class that creates CefResourceHandler instances for handling scheme requests.
    /// The methods of this class will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefSchemeHandlerFactory : IDisposable
    {
        const int _typeNAME = 29;
        const int CefSchemeHandlerFactory_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefSchemeHandlerFactory(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSchemeHandlerFactory_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefSchemeHandlerFactory New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefSchemeHandlerFactory(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,246
        const int MyCefSchemeHandlerFactory_Create_1 = 1;
        //gen! CefRefPtr<CefResourceHandler> Create(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& scheme_name,CefRefPtr<CefRequest> request)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,247
        /// <summary>
        /// Return a new resource handler instance to handle the request or an empty
        /// reference to allow default handling of the request. |browser| and |frame|
        /// will be the browser window and frame respectively that originated the
        /// request or NULL if the request did not originate from a browser window
        /// (for example, if the request came from CefURLRequest). The |request| object
        /// passed to this method will not contain cookie data.
        /// /*cef(optional_param=browser,optional_param=frame)*/
        /// </summary>
        public struct CreateArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal CreateArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((CreateNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((CreateNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(IntPtr value)
            {
                unsafe
                {
                    ((CreateNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public CefBrowser browser()
            {
                unsafe
                {
                    return new CefBrowser(((CreateNativeArgs*)this.nativePtr)->browser);
                }
            }
            public CefFrame frame()
            {
                unsafe
                {
                    return new CefFrame(((CreateNativeArgs*)this.nativePtr)->frame);
                }
            }
            public string scheme_name()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((CreateNativeArgs*)this.nativePtr)->scheme_name);
                }
            }
            public CefRequest request()
            {
                unsafe
                {
                    return new CefRequest(((CreateNativeArgs*)this.nativePtr)->request);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,248
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct CreateNativeArgs
        {
            public int argFlags;
            public IntPtr myext_ret_value;
            public IntPtr browser;
            public IntPtr frame;
            public IntPtr scheme_name;
            public IntPtr request;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,249
            /// <summary>
            /// Return a new resource handler instance to handle the request or an empty
            /// reference to allow default handling of the request. |browser| and |frame|
            /// will be the browser window and frame respectively that originated the
            /// request or NULL if the request did not originate from a browser window
            /// (for example, if the request came from CefURLRequest). The |request| object
            /// passed to this method will not contain cookie data.
            /// /*cef(optional_param=browser,optional_param=frame)*/
            /// </summary>
            void Create(CreateArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,250
            /// <summary>
            /// Return a new resource handler instance to handle the request or an empty
            /// reference to allow default handling of the request. |browser| and |frame|
            /// will be the browser window and frame respectively that originated the
            /// request or NULL if the request did not originate from a browser window
            /// (for example, if the request came from CefURLRequest). The |request| object
            /// passed to this method will not contain cookie data.
            /// /*cef(optional_param=browser,optional_param=frame)*/
            /// </summary>
            CefResourceHandler Create(CefBrowser browser, CefFrame frame, string scheme_name, CefRequest request);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,251
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,252
                case MyCefSchemeHandlerFactory_Create_1:
                    {
                        var args = new CreateArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Create(args);
                        }
                        if (i1 != null)
                        {
                            Create(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,253
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefSchemeHandlerFactory_Create_1:
                    i0.Create(new CreateArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,254
        public static void Create(I1 i1, CreateArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,255
            i1.Create(args.browser(),
            args.frame(),
            args.scheme_name(),
            args.request());
        }
    }


    // [virtual] class CefSSLInfo
    //CsCallToNativeCodeGen::GenerateCsCode , 451
    /// <summary>
    /// Class representing SSL information.
    /// /*(source=library)*/
    /// </summary>
    public struct CefSSLInfo : IDisposable
    {
        const int _typeNAME = 30;
        const int CefSSLInfo_Release_0 = (_typeNAME << 16) | 0;
        const int CefSSLInfo_GetCertStatus_1 = (_typeNAME << 16) | 1;
        const int CefSSLInfo_GetX509Certificate_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefSSLInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 452

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// CefSSLInfo methods.
        /// </summary>

        public cef_cert_status_t GetCertStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetCertStatus_1, out ret);
            return (cef_cert_status_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 453

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefX509Certificate GetX509Certificate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetX509Certificate_2, out ret);
            return new CefX509Certificate(ret.Ptr);
        }
    }


    // [virtual] class CefSSLStatus
    //CsCallToNativeCodeGen::GenerateCsCode , 454
    /// <summary>
    /// Class representing the SSL information for a navigation entry.
    /// /*(source=library)*/
    /// </summary>
    public struct CefSSLStatus : IDisposable
    {
        const int _typeNAME = 31;
        const int CefSSLStatus_Release_0 = (_typeNAME << 16) | 0;
        const int CefSSLStatus_IsSecureConnection_1 = (_typeNAME << 16) | 1;
        const int CefSSLStatus_GetCertStatus_2 = (_typeNAME << 16) | 2;
        const int CefSSLStatus_GetSSLVersion_3 = (_typeNAME << 16) | 3;
        const int CefSSLStatus_GetContentStatus_4 = (_typeNAME << 16) | 4;
        const int CefSSLStatus_GetX509Certificate_5 = (_typeNAME << 16) | 5;
        internal IntPtr nativePtr;
        internal CefSSLStatus(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 455

        // gen! bool IsSecureConnection()
        /// <summary>
        /// CefSSLStatus methods.
        /// </summary>

        public bool IsSecureConnection()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_IsSecureConnection_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 456

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// Returns a bitmask containing any and all problems verifying the server
        /// certificate.
        /// /*cef(default_retval=CERT_STATUS_NONE)*/
        /// </summary>

        public cef_cert_status_t GetCertStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetCertStatus_2, out ret);
            return (cef_cert_status_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 457

        // gen! cef_ssl_version_t GetSSLVersion()
        /// <summary>
        /// Returns the SSL version used for the SSL connection.
        /// /*cef(default_retval=SSL_CONNECTION_VERSION_UNKNOWN)*/
        /// </summary>

        public cef_ssl_version_t GetSSLVersion()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetSSLVersion_3, out ret);
            return (cef_ssl_version_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 458

        // gen! cef_ssl_content_status_t GetContentStatus()
        /// <summary>
        /// Returns a bitmask containing the page security content status.
        /// /*cef(default_retval=SSL_CONTENT_NORMAL_CONTENT)*/
        /// </summary>

        public cef_ssl_content_status_t GetContentStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetContentStatus_4, out ret);
            return (cef_ssl_content_status_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 459

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefX509Certificate GetX509Certificate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetX509Certificate_5, out ret);
            return new CefX509Certificate(ret.Ptr);
        }
    }


    // [virtual] class CefStreamReader
    //CsCallToNativeCodeGen::GenerateCsCode , 460
    /// <summary>
    /// Class used to read data from a stream. The methods of this class may be
    /// called on any thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefStreamReader : IDisposable
    {
        const int _typeNAME = 32;
        const int CefStreamReader_Release_0 = (_typeNAME << 16) | 0;
        const int CefStreamReader_Read_1 = (_typeNAME << 16) | 1;
        const int CefStreamReader_Seek_2 = (_typeNAME << 16) | 2;
        const int CefStreamReader_Tell_3 = (_typeNAME << 16) | 3;
        const int CefStreamReader_Eof_4 = (_typeNAME << 16) | 4;
        const int CefStreamReader_MayBlock_5 = (_typeNAME << 16) | 5;
        //
        const int CefStreamReader_S_CreateForFile_1 = (_typeNAME << 16) | 1;
        const int CefStreamReader_S_CreateForData_2 = (_typeNAME << 16) | 2;
        const int CefStreamReader_S_CreateForHandler_3 = (_typeNAME << 16) | 3;
        internal IntPtr nativePtr;
        internal CefStreamReader(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 461

        // gen! size_t Read(void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamReader methods.
        /// </summary>

        public uint Read(IntPtr ptr,
        uint size,
        uint n)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = ptr;
            v2.I32 = (int)size;
            v3.I32 = (int)n;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamReader_Read_1, out ret, ref v1, ref v2, ref v3);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 462

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public int Seek(long offset,
        int whence)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I64 = offset;
            v2.I32 = (int)whence;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamReader_Seek_2, out ret, ref v1, ref v2);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 463

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>

        public long Tell()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Tell_3, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 464

        // gen! int Eof()
        /// <summary>
        /// Return non-zero if at end of file.
        /// /*cef()*/
        /// </summary>

        public int Eof()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Eof_4, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 465

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this reader performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// reader from.
        /// /*cef()*/
        /// </summary>

        public bool MayBlock()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_MayBlock_5, out ret);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 466

        // gen! CefRefPtr<CefStreamReader> CreateForFile(const CefString& fileName)
        /// <summary>
        /// Create a new CefStreamReader object from a file.
        /// /*cef()*/
        /// </summary>

        public static CefStreamReader CreateForFile(string fileName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(fileName);

            Cef3Binder.MyCefMet_S_Call1(CefStreamReader_S_CreateForFile_1, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefStreamReader(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 467

        // gen! CefRefPtr<CefStreamReader> CreateForData(void* data,size_t size)
        /// <summary>
        /// Create a new CefStreamReader object from data.
        /// /*cef()*/
        /// </summary>

        public static CefStreamReader CreateForData(IntPtr data,
        uint size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = data;
            v2.I32 = (int)size;

            Cef3Binder.MyCefMet_S_Call2(CefStreamReader_S_CreateForData_2, out ret, ref v1, ref v2);
            return new CefStreamReader(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 468

        // gen! CefRefPtr<CefStreamReader> CreateForHandler(CefRefPtr<CefReadHandler> handler)
        /// <summary>
        /// Create a new CefStreamReader object from a custom handler.
        /// /*cef()*/
        /// </summary>

        public static CefStreamReader CreateForHandler(CefReadHandler handler)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = handler.nativePtr;

            Cef3Binder.MyCefMet_S_Call1(CefStreamReader_S_CreateForHandler_3, out ret, ref v1);
            return new CefStreamReader(ret.Ptr);
        }
    }


    // [virtual] class CefStreamWriter
    //CsCallToNativeCodeGen::GenerateCsCode , 469
    /// <summary>
    /// Class used to write data to a stream. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefStreamWriter : IDisposable
    {
        const int _typeNAME = 33;
        const int CefStreamWriter_Release_0 = (_typeNAME << 16) | 0;
        const int CefStreamWriter_Write_1 = (_typeNAME << 16) | 1;
        const int CefStreamWriter_Seek_2 = (_typeNAME << 16) | 2;
        const int CefStreamWriter_Tell_3 = (_typeNAME << 16) | 3;
        const int CefStreamWriter_Flush_4 = (_typeNAME << 16) | 4;
        const int CefStreamWriter_MayBlock_5 = (_typeNAME << 16) | 5;
        //
        const int CefStreamWriter_S_CreateForFile_1 = (_typeNAME << 16) | 1;
        const int CefStreamWriter_S_CreateForHandler_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefStreamWriter(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 470

        // gen! size_t Write(const void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamWriter methods.
        /// </summary>

        public uint Write(IntPtr ptr,
        uint size,
        uint n)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = ptr;
            v2.I32 = (int)size;
            v3.I32 = (int)n;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamWriter_Write_1, out ret, ref v1, ref v2, ref v3);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 471

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public int Seek(long offset,
        int whence)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I64 = offset;
            v2.I32 = (int)whence;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamWriter_Seek_2, out ret, ref v1, ref v2);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 472

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>

        public long Tell()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Tell_3, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 473

        // gen! int Flush()
        /// <summary>
        /// Flush the stream.
        /// /*cef()*/
        /// </summary>

        public int Flush()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Flush_4, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 474

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this writer performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// writer from.
        /// /*cef()*/
        /// </summary>

        public bool MayBlock()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_MayBlock_5, out ret);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 475

        // gen! CefRefPtr<CefStreamWriter> CreateForFile(const CefString& fileName)
        /// <summary>
        /// Create a new CefStreamWriter object for a file.
        /// /*cef()*/
        /// </summary>

        public static CefStreamWriter CreateForFile(string fileName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(fileName);

            Cef3Binder.MyCefMet_S_Call1(CefStreamWriter_S_CreateForFile_1, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefStreamWriter(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 476

        // gen! CefRefPtr<CefStreamWriter> CreateForHandler(CefRefPtr<CefWriteHandler> handler)
        /// <summary>
        /// Create a new CefStreamWriter object for a custom handler.
        /// /*cef()*/
        /// </summary>

        public static CefStreamWriter CreateForHandler(CefWriteHandler handler)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = handler.nativePtr;

            Cef3Binder.MyCefMet_S_Call1(CefStreamWriter_S_CreateForHandler_2, out ret, ref v1);
            return new CefStreamWriter(ret.Ptr);
        }
    }


    // [virtual] class CefStringVisitor
    //CsCallToNativeCodeGen::GenerateCsCode , 477
    /// <summary>
    /// Implement this interface to receive string values asynchronously.
    /// /*(source=client)*/
    /// </summary>
    public struct CefStringVisitor : IDisposable
    {
        const int _typeNAME = 34;
        const int CefStringVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefStringVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStringVisitor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefStringVisitor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefStringVisitor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,256
        const int MyCefStringVisitor_Visit_1 = 1;
        //gen! void Visit(const CefString& string)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,257
        /// <summary>
        /// Method that will be executed.
        /// /*cef(optional_param=string)*/
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
            public string _string()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((VisitNativeArgs*)this.nativePtr)->_string);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,258
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct VisitNativeArgs
        {
            public int argFlags;
            public IntPtr _string;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,259
            /// <summary>
            /// Method that will be executed.
            /// /*cef(optional_param=string)*/
            /// </summary>
            void Visit(VisitArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,260
            /// <summary>
            /// Method that will be executed.
            /// /*cef(optional_param=string)*/
            /// </summary>
            void Visit(string _string);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,261
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,262
                case MyCefStringVisitor_Visit_1:
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
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,263
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefStringVisitor_Visit_1:
                    i0.Visit(new VisitArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,264
        public static void Visit(I1 i1, VisitArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,265
            i1.Visit(args._string());
        }
    }


    // [virtual] class CefTask
    //CsCallToNativeCodeGen::GenerateCsCode , 478
    /// <summary>
    /// Implement this interface for asynchronous task execution. If the task is
    /// posted successfully and if the associated message loop is still running then
    /// the Execute() method will be called on the target thread. If the task fails
    /// to post then the task object may be destroyed on the source thread instead of
    /// the target thread. For this reason be cautious when performing work in the
    /// task object destructor.
    /// /*cef(source=client)*/
    /// </summary>
    public struct CefTask : IDisposable
    {
        const int _typeNAME = 35;
        const int CefTask_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefTask(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTask_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefTask New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefTask(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,266
        const int MyCefTask_Execute_1 = 1;
        //gen! void Execute()
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,267
        /// <summary>
        /// Method that will be executed on the target thread.
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
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,268
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct ExecuteNativeArgs
        {
            public int argFlags;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,269
            /// <summary>
            /// Method that will be executed on the target thread.
            /// /*cef()*/
            /// </summary>
            void Execute(ExecuteArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,270
            /// <summary>
            /// Method that will be executed on the target thread.
            /// /*cef()*/
            /// </summary>
            void Execute();
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,271
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,272
                case MyCefTask_Execute_1:
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
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,273
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefTask_Execute_1:
                    i0.Execute(new ExecuteArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,274
        public static void Execute(I1 i1, ExecuteArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,275
            i1.Execute();
        }
    }


    // [virtual] class CefTaskRunner
    //CsCallToNativeCodeGen::GenerateCsCode , 479
    /// <summary>
    /// Class that asynchronously executes tasks on the associated thread. It is safe
    /// to call the methods of this class on any thread.
    ///
    /// CEF maintains multiple internal threads that are used for handling different
    /// types of tasks in different processes. The cef_thread_id_t definitions in
    /// cef_types.h list the common CEF threads. Task runners are also available for
    /// other CEF threads as appropriate (for example, V8 WebWorker threads).
    /// /*(source=library)*/
    /// </summary>
    public struct CefTaskRunner : IDisposable
    {
        const int _typeNAME = 36;
        const int CefTaskRunner_Release_0 = (_typeNAME << 16) | 0;
        const int CefTaskRunner_IsSame_1 = (_typeNAME << 16) | 1;
        const int CefTaskRunner_BelongsToCurrentThread_2 = (_typeNAME << 16) | 2;
        const int CefTaskRunner_BelongsToThread_3 = (_typeNAME << 16) | 3;
        const int CefTaskRunner_PostTask_4 = (_typeNAME << 16) | 4;
        const int CefTaskRunner_PostDelayedTask_5 = (_typeNAME << 16) | 5;
        //
        const int CefTaskRunner_S_GetForCurrentThread_1 = (_typeNAME << 16) | 1;
        const int CefTaskRunner_S_GetForThread_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefTaskRunner(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 480

        // gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
        /// <summary>
        /// CefTaskRunner methods.
        /// </summary>

        public bool IsSame(CefTaskRunner that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_IsSame_1, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 481

        // gen! bool BelongsToCurrentThread()
        /// <summary>
        /// Returns true if this task runner belongs to the current thread.
        /// /*cef()*/
        /// </summary>

        public bool BelongsToCurrentThread()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_BelongsToCurrentThread_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 482

        // gen! bool BelongsToThread(CefThreadId threadId)
        /// <summary>
        /// Returns true if this task runner is for the specified CEF thread.
        /// /*cef()*/
        /// </summary>

        public bool BelongsToThread(cef_thread_id_t threadId)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)threadId;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_BelongsToThread_3, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 483

        // gen! bool PostTask(CefRefPtr<CefTask> task)
        /// <summary>
        /// Post a task for execution on the thread associated with this task runner.
        /// Execution will occur asynchronously.
        /// /*cef()*/
        /// </summary>

        public bool PostTask(CefTask task)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = task.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_PostTask_4, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 484

        // gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
        /// <summary>
        /// Post a task for delayed execution on the thread associated with this task
        /// runner. Execution will occur asynchronously. Delayed tasks are not
        /// supported on V8 WebWorker threads and will be executed without the
        /// specified delay.
        /// /*cef()*/
        /// </summary>

        public bool PostDelayedTask(CefTask task,
        long delay_ms)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = task.nativePtr;
            v2.I64 = delay_ms;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefTaskRunner_PostDelayedTask_5, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 485

        // gen! CefRefPtr<CefTaskRunner> GetForCurrentThread()
        /// <summary>
        /// Returns the task runner for the current thread. Only CEF threads will have
        /// task runners. An empty reference will be returned if this method is called
        /// on an invalid thread.
        /// /*cef()*/
        /// </summary>

        public static CefTaskRunner GetForCurrentThread()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefTaskRunner_S_GetForCurrentThread_1, out ret);
            return new CefTaskRunner(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 486

        // gen! CefRefPtr<CefTaskRunner> GetForThread(CefThreadId threadId)
        /// <summary>
        /// Returns the task runner for the specified CEF thread.
        /// /*cef()*/
        /// </summary>

        public static CefTaskRunner GetForThread(cef_thread_id_t threadId)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)threadId;

            Cef3Binder.MyCefMet_S_Call1(CefTaskRunner_S_GetForThread_2, out ret, ref v1);
            return new CefTaskRunner(ret.Ptr);
        }
    }


    // [virtual] class CefURLRequest
    //CsCallToNativeCodeGen::GenerateCsCode , 487
    /// <summary>
    /// Class used to make a URL request. URL requests are not associated with a
    /// browser instance so no CefClient callbacks will be executed. URL requests
    /// can be created on any valid CEF thread in either the browser or render
    /// process. Once created the methods of the URL request object must be accessed
    /// on the same thread that created it.
    /// /*(source=library)*/
    /// </summary>
    public struct CefURLRequest : IDisposable
    {
        const int _typeNAME = 37;
        const int CefURLRequest_Release_0 = (_typeNAME << 16) | 0;
        const int CefURLRequest_GetRequest_1 = (_typeNAME << 16) | 1;
        const int CefURLRequest_GetClient_2 = (_typeNAME << 16) | 2;
        const int CefURLRequest_GetRequestStatus_3 = (_typeNAME << 16) | 3;
        const int CefURLRequest_GetRequestError_4 = (_typeNAME << 16) | 4;
        const int CefURLRequest_GetResponse_5 = (_typeNAME << 16) | 5;
        const int CefURLRequest_Cancel_6 = (_typeNAME << 16) | 6;
        //
        const int CefURLRequest_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefURLRequest(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 488

        // gen! CefRefPtr<CefRequest> GetRequest()
        /// <summary>
        /// CefURLRequest methods.
        /// </summary>

        public CefRequest GetRequest()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequest_1, out ret);
            return new CefRequest(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 489

        // gen! CefRefPtr<CefURLRequestClient> GetClient()
        /// <summary>
        /// Returns the client.
        /// /*cef()*/
        /// </summary>

        public CefURLRequestClient GetClient()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetClient_2, out ret);
            return new CefURLRequestClient(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 490

        // gen! Status GetRequestStatus()
        /// <summary>
        /// Returns the request status.
        /// /*cef(default_retval=UR_UNKNOWN)*/
        /// </summary>

        public cef_urlrequest_status_t GetRequestStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestStatus_3, out ret);
            return (cef_urlrequest_status_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 491

        // gen! ErrorCode GetRequestError()
        /// <summary>
        /// Returns the request error if status is UR_CANCELED or UR_FAILED, or 0
        /// otherwise.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>

        public cef_errorcode_t GetRequestError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestError_4, out ret);
            return (cef_errorcode_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 492

        // gen! CefRefPtr<CefResponse> GetResponse()
        /// <summary>
        /// Returns the response, or NULL if no response information is available.
        /// Response information will only be available after the upload has completed.
        /// The returned object is read-only and should not be modified.
        /// /*cef()*/
        /// </summary>

        public CefResponse GetResponse()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetResponse_5, out ret);
            return new CefResponse(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 493

        // gen! void Cancel()
        /// <summary>
        /// Cancel the request.
        /// /*cef()*/
        /// </summary>

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Cancel_6, out ret);

        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 494

        // gen! CefRefPtr<CefURLRequest> Create(CefRefPtr<CefRequest> request,CefRefPtr<CefURLRequestClient> client,CefRefPtr<CefRequestContext> request_context)
        /// <summary>
        /// Create a new URL request. Only GET, POST, HEAD, DELETE and PUT request
        /// methods are supported. Multiple post data elements are not supported and
        /// elements of type PDE_TYPE_FILE are only supported for requests originating
        /// from the browser process. Requests originating from the render process will
        /// receive the same handling as requests originating from Web content -- if
        /// the response contains Content-Disposition or Mime-Type header values that
        /// would not normally be rendered then the response may receive special
        /// handling inside the browser (for example, via the file download code path
        /// instead of the URL request code path). The |request| object will be marked
        /// as read-only after calling this method. In the browser process if
        /// |request_context| is empty the global request context will be used. In the
        /// render process |request_context| must be empty and the context associated
        /// with the current renderer process' browser will be used.
        /// /*cef(optional_param=request_context)*/
        /// </summary>

        public static CefURLRequest Create(CefRequest request,
        CefURLRequestClient client,
        CefRequestContext request_context)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = request.nativePtr;
            v2.Ptr = client.nativePtr;
            v3.Ptr = request_context.nativePtr;

            Cef3Binder.MyCefMet_S_Call3(CefURLRequest_S_Create_1, out ret, ref v1, ref v2, ref v3);
            return new CefURLRequest(ret.Ptr);
        }
    }


    // [virtual] class CefURLRequestClient
    //CsCallToNativeCodeGen::GenerateCsCode , 495
    /// <summary>
    /// Interface that should be implemented by the CefURLRequest client. The
    /// methods of this class will be called on the same thread that created the
    /// request unless otherwise documented.
    /// /*(source=client)*/
    /// </summary>
    public struct CefURLRequestClient : IDisposable
    {
        const int _typeNAME = 38;
        const int CefURLRequestClient_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefURLRequestClient(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequestClient_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefURLRequestClient New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefURLRequestClient(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,276
        const int MyCefURLRequestClient_OnRequestComplete_1 = 1;
        const int MyCefURLRequestClient_OnUploadProgress_2 = 2;
        const int MyCefURLRequestClient_OnDownloadProgress_3 = 3;
        const int MyCefURLRequestClient_OnDownloadData_4 = 4;
        const int MyCefURLRequestClient_GetAuthCredentials_5 = 5;
        //gen! void OnRequestComplete(CefRefPtr<CefURLRequest> request)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,277
        /// <summary>
        /// Notifies the client that the request has completed. Use the
        /// CefURLRequest::GetRequestStatus method to determine if the request was
        /// successful or not.
        /// /*cef()*/
        /// </summary>
        public struct OnRequestCompleteArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnRequestCompleteArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnRequestCompleteNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnRequestCompleteNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefURLRequest request()
            {
                unsafe
                {
                    return new CefURLRequest(((OnRequestCompleteNativeArgs*)this.nativePtr)->request);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,278
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnRequestCompleteNativeArgs
        {
            public int argFlags;
            public IntPtr request;
        }
        //gen! void OnUploadProgress(CefRefPtr<CefURLRequest> request,int64 current,int64 total)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,279
        /// <summary>
        /// Notifies the client of upload progress. |current| denotes the number of
        /// bytes sent so far and |total| is the total size of uploading data (or -1 if
        /// chunked upload is enabled). This method will only be called if the
        /// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
        /// /*cef()*/
        /// </summary>
        public struct OnUploadProgressArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnUploadProgressArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnUploadProgressNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnUploadProgressNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefURLRequest request()
            {
                unsafe
                {
                    return new CefURLRequest(((OnUploadProgressNativeArgs*)this.nativePtr)->request);
                }
            }
            public long current()
            {
                unsafe
                {
                    return ((OnUploadProgressNativeArgs*)this.nativePtr)->current;
                }
            }
            public long total()
            {
                unsafe
                {
                    return ((OnUploadProgressNativeArgs*)this.nativePtr)->total;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,280
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnUploadProgressNativeArgs
        {
            public int argFlags;
            public IntPtr request;
            public long current;
            public long total;
        }
        //gen! void OnDownloadProgress(CefRefPtr<CefURLRequest> request,int64 current,int64 total)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,281
        /// <summary>
        /// Notifies the client of download progress. |current| denotes the number of
        /// bytes received up to the call and |total| is the expected total size of the
        /// response (or -1 if not determined).
        /// /*cef()*/
        /// </summary>
        public struct OnDownloadProgressArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnDownloadProgressArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnDownloadProgressNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnDownloadProgressNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefURLRequest request()
            {
                unsafe
                {
                    return new CefURLRequest(((OnDownloadProgressNativeArgs*)this.nativePtr)->request);
                }
            }
            public long current()
            {
                unsafe
                {
                    return ((OnDownloadProgressNativeArgs*)this.nativePtr)->current;
                }
            }
            public long total()
            {
                unsafe
                {
                    return ((OnDownloadProgressNativeArgs*)this.nativePtr)->total;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,282
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnDownloadProgressNativeArgs
        {
            public int argFlags;
            public IntPtr request;
            public long current;
            public long total;
        }
        //gen! void OnDownloadData(CefRefPtr<CefURLRequest> request,const void* data,size_t data_length)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,283
        /// <summary>
        /// Called when some part of the response is read. |data| contains the current
        /// bytes received since the last call. This method will not be called if the
        /// UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
        /// /*cef()*/
        /// </summary>
        public struct OnDownloadDataArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal OnDownloadDataArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((OnDownloadDataNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((OnDownloadDataNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public CefURLRequest request()
            {
                unsafe
                {
                    return new CefURLRequest(((OnDownloadDataNativeArgs*)this.nativePtr)->request);
                }
            }
            public IntPtr data()
            {
                throw new CefNotImplementedException();
            }
            public uint data_length()
            {
                unsafe
                {
                    return ((OnDownloadDataNativeArgs*)this.nativePtr)->data_length;
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,284
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct OnDownloadDataNativeArgs
        {
            public int argFlags;
            public IntPtr request;
            public IntPtr data;
            public uint data_length;
        }
        //gen! bool GetAuthCredentials(bool isProxy,const CefString& host,int port,const CefString& realm,const CefString& scheme,CefRefPtr<CefAuthCallback> callback)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,285
        /// <summary>
        /// Called on the IO thread when the browser needs credentials from the user.
        /// |isProxy| indicates whether the host is a proxy server. |host| contains the
        /// hostname and |port| contains the port number. Return true to continue the
        /// request and call CefAuthCallback::Continue() when the authentication
        /// information is available. Return false to cancel the request. This method
        /// will only be called for requests initiated from the browser process.
        /// /*cef(optional_param=realm)*/
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
                    return MyMetArgs.GetAsString(((GetAuthCredentialsNativeArgs*)this.nativePtr)->host);
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
                    return MyMetArgs.GetAsString(((GetAuthCredentialsNativeArgs*)this.nativePtr)->realm);
                }
            }
            public string scheme()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((GetAuthCredentialsNativeArgs*)this.nativePtr)->scheme);
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
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,286
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetAuthCredentialsNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public bool isProxy;
            public IntPtr host;
            public int port;
            public IntPtr realm;
            public IntPtr scheme;
            public IntPtr callback;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,287
            /// <summary>
            /// Notifies the client that the request has completed. Use the
            /// CefURLRequest::GetRequestStatus method to determine if the request was
            /// successful or not.
            /// /*cef()*/
            /// </summary>
            void OnRequestComplete(OnRequestCompleteArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,288
            /// <summary>
            /// Notifies the client of upload progress. |current| denotes the number of
            /// bytes sent so far and |total| is the total size of uploading data (or -1 if
            /// chunked upload is enabled). This method will only be called if the
            /// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
            /// /*cef()*/
            /// </summary>
            void OnUploadProgress(OnUploadProgressArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,289
            /// <summary>
            /// Notifies the client of download progress. |current| denotes the number of
            /// bytes received up to the call and |total| is the expected total size of the
            /// response (or -1 if not determined).
            /// /*cef()*/
            /// </summary>
            void OnDownloadProgress(OnDownloadProgressArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,290
            /// <summary>
            /// Called when some part of the response is read. |data| contains the current
            /// bytes received since the last call. This method will not be called if the
            /// UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
            /// /*cef()*/
            /// </summary>
            void OnDownloadData(OnDownloadDataArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,291
            /// <summary>
            /// Called on the IO thread when the browser needs credentials from the user.
            /// |isProxy| indicates whether the host is a proxy server. |host| contains the
            /// hostname and |port| contains the port number. Return true to continue the
            /// request and call CefAuthCallback::Continue() when the authentication
            /// information is available. Return false to cancel the request. This method
            /// will only be called for requests initiated from the browser process.
            /// /*cef(optional_param=realm)*/
            /// </summary>
            void GetAuthCredentials(GetAuthCredentialsArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,292
            /// <summary>
            /// Notifies the client that the request has completed. Use the
            /// CefURLRequest::GetRequestStatus method to determine if the request was
            /// successful or not.
            /// /*cef()*/
            /// </summary>
            void OnRequestComplete(CefURLRequest request);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,293
            /// <summary>
            /// Notifies the client of upload progress. |current| denotes the number of
            /// bytes sent so far and |total| is the total size of uploading data (or -1 if
            /// chunked upload is enabled). This method will only be called if the
            /// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
            /// /*cef()*/
            /// </summary>
            void OnUploadProgress(CefURLRequest request, long current, long total);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,294
            /// <summary>
            /// Notifies the client of download progress. |current| denotes the number of
            /// bytes received up to the call and |total| is the expected total size of the
            /// response (or -1 if not determined).
            /// /*cef()*/
            /// </summary>
            void OnDownloadProgress(CefURLRequest request, long current, long total);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,295
            /// <summary>
            /// Called when some part of the response is read. |data| contains the current
            /// bytes received since the last call. This method will not be called if the
            /// UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
            /// /*cef()*/
            /// </summary>
            void OnDownloadData(CefURLRequest request, IntPtr data, uint data_length);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,296
            /// <summary>
            /// Called on the IO thread when the browser needs credentials from the user.
            /// |isProxy| indicates whether the host is a proxy server. |host| contains the
            /// hostname and |port| contains the port number. Return true to continue the
            /// request and call CefAuthCallback::Continue() when the authentication
            /// information is available. Return false to cancel the request. This method
            /// will only be called for requests initiated from the browser process.
            /// /*cef(optional_param=realm)*/
            /// </summary>
            bool GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, CefAuthCallback callback);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,297
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,298
                case MyCefURLRequestClient_OnRequestComplete_1:
                    {
                        var args = new OnRequestCompleteArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnRequestComplete(args);
                        }
                        if (i1 != null)
                        {
                            OnRequestComplete(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,299
                case MyCefURLRequestClient_OnUploadProgress_2:
                    {
                        var args = new OnUploadProgressArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnUploadProgress(args);
                        }
                        if (i1 != null)
                        {
                            OnUploadProgress(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,300
                case MyCefURLRequestClient_OnDownloadProgress_3:
                    {
                        var args = new OnDownloadProgressArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnDownloadProgress(args);
                        }
                        if (i1 != null)
                        {
                            OnDownloadProgress(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,301
                case MyCefURLRequestClient_OnDownloadData_4:
                    {
                        var args = new OnDownloadDataArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.OnDownloadData(args);
                        }
                        if (i1 != null)
                        {
                            OnDownloadData(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,302
                case MyCefURLRequestClient_GetAuthCredentials_5:
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
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,303
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefURLRequestClient_OnRequestComplete_1:
                    i0.OnRequestComplete(new OnRequestCompleteArgs(nativeArgPtr));
                    break;
                case MyCefURLRequestClient_OnUploadProgress_2:
                    i0.OnUploadProgress(new OnUploadProgressArgs(nativeArgPtr));
                    break;
                case MyCefURLRequestClient_OnDownloadProgress_3:
                    i0.OnDownloadProgress(new OnDownloadProgressArgs(nativeArgPtr));
                    break;
                case MyCefURLRequestClient_OnDownloadData_4:
                    i0.OnDownloadData(new OnDownloadDataArgs(nativeArgPtr));
                    break;
                case MyCefURLRequestClient_GetAuthCredentials_5:
                    i0.GetAuthCredentials(new GetAuthCredentialsArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,304
        public static void OnRequestComplete(I1 i1, OnRequestCompleteArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,305
            i1.OnRequestComplete(args.request());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,306
        public static void OnUploadProgress(I1 i1, OnUploadProgressArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,307
            i1.OnUploadProgress(args.request(),
            args.current(),
            args.total());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,308
        public static void OnDownloadProgress(I1 i1, OnDownloadProgressArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,309
            i1.OnDownloadProgress(args.request(),
            args.current(),
            args.total());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,310
        public static void OnDownloadData(I1 i1, OnDownloadDataArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,311
            i1.OnDownloadData(args.request(),
            args.data(),
            args.data_length());
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,312
        public static void GetAuthCredentials(I1 i1, GetAuthCredentialsArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,313
            args.myext_setRetValue(i1.GetAuthCredentials(args.isProxy(),
            args.host(),
            args.port(),
            args.realm(),
            args.scheme(),
            args.callback()));
        }
    }


    // [virtual] class CefV8Context
    //CsCallToNativeCodeGen::GenerateCsCode , 496
    /// <summary>
    /// Class representing a V8 context handle. V8 handles can only be accessed from
    /// the thread on which they are created. Valid threads for creating a V8 handle
    /// include the render process main thread (TID_RENDERER) and WebWorker threads.
    /// A task runner for posting tasks on the associated thread can be retrieved via
    /// the CefV8Context::GetTaskRunner() method.
    /// /*cef(source=library)*/
    /// </summary>
    public struct CefV8Context : IDisposable
    {
        const int _typeNAME = 39;
        const int CefV8Context_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8Context_GetTaskRunner_1 = (_typeNAME << 16) | 1;
        const int CefV8Context_IsValid_2 = (_typeNAME << 16) | 2;
        const int CefV8Context_GetBrowser_3 = (_typeNAME << 16) | 3;
        const int CefV8Context_GetFrame_4 = (_typeNAME << 16) | 4;
        const int CefV8Context_GetGlobal_5 = (_typeNAME << 16) | 5;
        const int CefV8Context_Enter_6 = (_typeNAME << 16) | 6;
        const int CefV8Context_Exit_7 = (_typeNAME << 16) | 7;
        const int CefV8Context_IsSame_8 = (_typeNAME << 16) | 8;
        const int CefV8Context_Eval_9 = (_typeNAME << 16) | 9;
        //
        const int CefV8Context_S_GetCurrentContext_1 = (_typeNAME << 16) | 1;
        const int CefV8Context_S_GetEnteredContext_2 = (_typeNAME << 16) | 2;
        const int CefV8Context_S_InContext_3 = (_typeNAME << 16) | 3;
        internal IntPtr nativePtr;
        internal CefV8Context(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 497

        // gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
        /// <summary>
        /// CefV8Context methods.
        /// </summary>

        public CefTaskRunner GetTaskRunner()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetTaskRunner_1, out ret);
            return new CefTaskRunner(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 498

        // gen! bool IsValid()
        /// <summary>
        /// Returns true if the underlying handle is valid and it can be accessed on
        /// the current thread. Do not call any other methods if this method returns
        /// false.
        /// /*cef()*/
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_IsValid_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 499

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>

        public CefBrowser GetBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetBrowser_3, out ret);
            return new CefBrowser(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 500

        // gen! CefRefPtr<CefFrame> GetFrame()
        /// <summary>
        /// Returns the frame for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetFrame()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetFrame_4, out ret);
            return new CefFrame(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 501

        // gen! CefRefPtr<CefV8Value> GetGlobal()
        /// <summary>
        /// Returns the global object for this context. The context must be entered
        /// before calling this method.
        /// /*cef()*/
        /// </summary>

        public CefV8Value GetGlobal()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetGlobal_5, out ret);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 502

        // gen! bool Enter()
        /// <summary>
        /// Enter this context. A context must be explicitly entered before creating a
        /// V8 Object, Array, Function or Date asynchronously. Exit() must be called
        /// the same number of times as Enter() before releasing this context. V8
        /// objects belong to the context in which they are created. Returns true if
        /// the scope was entered successfully.
        /// /*cef()*/
        /// </summary>

        public bool Enter()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Enter_6, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 503

        // gen! bool Exit()
        /// <summary>
        /// Exit this context. Call this method only after calling Enter(). Returns
        /// true if the scope was exited successfully.
        /// /*cef()*/
        /// </summary>

        public bool Exit()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Exit_7, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 504

        // gen! bool IsSame(CefRefPtr<CefV8Context> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefV8Context that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Context_IsSame_8, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 505

        // gen! bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
        /// <summary>
        /// Execute a string of JavaScript code in this V8 context. The |script_url|
        /// parameter is the URL where the script in question can be found, if any.
        /// The |start_line| parameter is the base line number to use for error
        /// reporting. On success |retval| will be set to the return value, if any, and
        /// the function will return true. On failure |exception| will be set to the
        /// exception, if any, and the function will return false.
        /// /*cef(optional_param=script_url)*/
        /// </summary>

        public bool Eval(string code,
        string script_url,
        int start_line,
        ref IntPtr retval,
        IntPtr exception)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(code);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(script_url);
            v3.I32 = (int)start_line;
            v4.Ptr = retval;
            v5.Ptr = exception;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefV8Context_Eval_9, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            retval = v4.Ptr;
            exception = v5.Ptr;
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 506

        // gen! CefRefPtr<CefV8Context> GetCurrentContext()
        /// <summary>
        /// Returns the current (top) context object in the V8 context stack.
        /// /*cef()*/
        /// </summary>

        public static CefV8Context GetCurrentContext()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefV8Context_S_GetCurrentContext_1, out ret);
            return new CefV8Context(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 507

        // gen! CefRefPtr<CefV8Context> GetEnteredContext()
        /// <summary>
        /// Returns the entered (bottom) context object in the V8 context stack.
        /// /*cef()*/
        /// </summary>

        public static CefV8Context GetEnteredContext()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefV8Context_S_GetEnteredContext_2, out ret);
            return new CefV8Context(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 508

        // gen! bool InContext()
        /// <summary>
        /// Returns true if V8 is currently inside a context.
        /// /*cef()*/
        /// </summary>

        public static bool InContext()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefV8Context_S_InContext_3, out ret);
            return ret.I32 != 0;
        }
    }


    // [virtual] class CefV8Accessor
    //CsCallToNativeCodeGen::GenerateCsCode , 509
    /// <summary>
    /// Interface that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CefV8Value::SetValue(). The methods
    /// of this class will be called on the thread associated with the V8 accessor.
    /// /*(source=client)*/
    /// </summary>
    public struct CefV8Accessor : IDisposable
    {
        const int _typeNAME = 40;
        const int CefV8Accessor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefV8Accessor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Accessor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefV8Accessor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefV8Accessor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,314
        const int MyCefV8Accessor_Get_1 = 1;
        const int MyCefV8Accessor_Set_2 = 2;
        //gen! bool Get(const CefString& name,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,315
        /// <summary>
        /// Handle retrieval the accessor value identified by |name|. |object| is the
        /// receiver ('this' object) of the accessor. If retrieval succeeds set
        /// |retval| to the return value. If retrieval fails set |exception| to the
        /// exception that will be thrown. Return true if accessor retrieval was
        /// handled.
        /// /*cef()*/
        /// </summary>
        public struct GetArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal GetArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((GetNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((GetNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((GetNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public string name()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((GetNativeArgs*)this.nativePtr)->name);
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((GetNativeArgs*)this.nativePtr)->_object);
                }
            }
            public bool retval()
            {
                throw new CefNotImplementedException();
            }
            public void retval(IntPtr value)
            {
                unsafe
                {
                    *(((GetNativeArgs*)this.nativePtr)->retval) = value;
                }
            }
            public string exception()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((GetNativeArgs*)this.nativePtr)->exception);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,316
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct GetNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr name;
            public IntPtr _object;
            public IntPtr* retval;
            public IntPtr exception;
        }
        //gen! bool Set(const CefString& name,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,317
        /// <summary>
        /// Handle assignment of the accessor value identified by |name|. |object| is
        /// the receiver ('this' object) of the accessor. |value| is the new value
        /// being assigned to the accessor. If assignment fails set |exception| to the
        /// exception that will be thrown. Return true if accessor assignment was
        /// handled.
        /// /*cef()*/
        /// </summary>
        public struct SetArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal SetArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((SetNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((SetNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((SetNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public string name()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((SetNativeArgs*)this.nativePtr)->name);
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((SetNativeArgs*)this.nativePtr)->_object);
                }
            }
            public CefV8Value value()
            {
                unsafe
                {
                    return new CefV8Value(((SetNativeArgs*)this.nativePtr)->value);
                }
            }
            public string exception()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((SetNativeArgs*)this.nativePtr)->exception);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,318
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct SetNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr name;
            public IntPtr _object;
            public IntPtr value;
            public IntPtr exception;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,319
            /// <summary>
            /// Handle retrieval the accessor value identified by |name|. |object| is the
            /// receiver ('this' object) of the accessor. If retrieval succeeds set
            /// |retval| to the return value. If retrieval fails set |exception| to the
            /// exception that will be thrown. Return true if accessor retrieval was
            /// handled.
            /// /*cef()*/
            /// </summary>
            void Get(GetArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,320
            /// <summary>
            /// Handle assignment of the accessor value identified by |name|. |object| is
            /// the receiver ('this' object) of the accessor. |value| is the new value
            /// being assigned to the accessor. If assignment fails set |exception| to the
            /// exception that will be thrown. Return true if accessor assignment was
            /// handled.
            /// /*cef()*/
            /// </summary>
            void Set(SetArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,321
            /// <summary>
            /// Handle retrieval the accessor value identified by |name|. |object| is the
            /// receiver ('this' object) of the accessor. If retrieval succeeds set
            /// |retval| to the return value. If retrieval fails set |exception| to the
            /// exception that will be thrown. Return true if accessor retrieval was
            /// handled.
            /// /*cef()*/
            /// </summary>
            bool Get(string name, CefV8Value _object, ref IntPtr retval, string exception);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,322
            /// <summary>
            /// Handle assignment of the accessor value identified by |name|. |object| is
            /// the receiver ('this' object) of the accessor. |value| is the new value
            /// being assigned to the accessor. If assignment fails set |exception| to the
            /// exception that will be thrown. Return true if accessor assignment was
            /// handled.
            /// /*cef()*/
            /// </summary>
            bool Set(string name, CefV8Value _object, CefV8Value value, string exception);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,323
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,324
                case MyCefV8Accessor_Get_1:
                    {
                        var args = new GetArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Get(args);
                        }
                        if (i1 != null)
                        {
                            Get(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,325
                case MyCefV8Accessor_Set_2:
                    {
                        var args = new SetArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Set(args);
                        }
                        if (i1 != null)
                        {
                            Set(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,326
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefV8Accessor_Get_1:
                    i0.Get(new GetArgs(nativeArgPtr));
                    break;
                case MyCefV8Accessor_Set_2:
                    i0.Set(new SetArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,327
        public static void Get(I1 i1, GetArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,328
            IntPtr retval = IntPtr.Zero;
            args.myext_setRetValue(i1.Get(args.name(),
            args._object(),
            ref retval,
            args.exception()));
            args.retval(retval);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,329
        public static void Set(I1 i1, SetArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,330
            args.myext_setRetValue(i1.Set(args.name(),
            args._object(),
            args.value(),
            args.exception()));
        }
    }


    // [virtual] class CefV8Interceptor
    //CsCallToNativeCodeGen::GenerateCsCode , 510
    /// <summary>
    /// Interface that should be implemented to handle V8 interceptor calls. The
    /// methods of this class will be called on the thread associated with the V8
    /// interceptor. Interceptor's named property handlers (with first argument of
    /// type CefString) are called when object is indexed by string. Indexed property
    /// handlers (with first argument of type int) are called when object is indexed
    /// by integer.
    /// /*(source=client)*/
    /// </summary>
    public struct CefV8Interceptor : IDisposable
    {
        const int _typeNAME = 41;
        const int CefV8Interceptor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefV8Interceptor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Interceptor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefV8Interceptor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefV8Interceptor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,331
        const int MyCefV8Interceptor_Get_1 = 1;
        const int MyCefV8Interceptor_Get_2 = 2;
        const int MyCefV8Interceptor_Set_3 = 3;
        const int MyCefV8Interceptor_Set_4 = 4;
        //gen! bool Get(const CefString& name,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,332
        /// <summary>
        /// Handle retrieval of the interceptor value identified by |name|. |object| is
        /// the receiver ('this' object) of the interceptor. If retrieval succeeds, set
        /// |retval| to the return value. If the requested value does not exist, don't
        /// set either |retval| or |exception|. If retrieval fails, set |exception| to
        /// the exception that will be thrown. If the property has an associated
        /// accessor, it will be called only if you don't set |retval|.
        /// Return true if interceptor retrieval was handled, false otherwise.
        /// /*cef(capi_name=get_byname)*/
        /// </summary>
        public struct get_bynameArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal get_bynameArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((get_bynameNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((get_bynameNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((get_bynameNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public string name()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((get_bynameNativeArgs*)this.nativePtr)->name);
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((get_bynameNativeArgs*)this.nativePtr)->_object);
                }
            }
            public bool retval()
            {
                throw new CefNotImplementedException();
            }
            public void retval(IntPtr value)
            {
                unsafe
                {
                    *(((get_bynameNativeArgs*)this.nativePtr)->retval) = value;
                }
            }
            public string exception()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((get_bynameNativeArgs*)this.nativePtr)->exception);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,333
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct get_bynameNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr name;
            public IntPtr _object;
            public IntPtr* retval;
            public IntPtr exception;
        }
        //gen! bool Get(int index,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,334
        /// <summary>
        /// Handle retrieval of the interceptor value identified by |index|. |object|
        /// is the receiver ('this' object) of the interceptor. If retrieval succeeds,
        /// set |retval| to the return value. If the requested value does not exist,
        /// don't set either |retval| or |exception|. If retrieval fails, set
        /// |exception| to the exception that will be thrown.
        /// Return true if interceptor retrieval was handled, false otherwise.
        /// /*cef(capi_name=get_byindex,index_param=index)*/
        /// </summary>
        public struct get_byindexArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal get_byindexArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((get_byindexNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((get_byindexNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((get_byindexNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public int index()
            {
                unsafe
                {
                    return ((get_byindexNativeArgs*)this.nativePtr)->index;
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((get_byindexNativeArgs*)this.nativePtr)->_object);
                }
            }
            public bool retval()
            {
                throw new CefNotImplementedException();
            }
            public void retval(IntPtr value)
            {
                unsafe
                {
                    *(((get_byindexNativeArgs*)this.nativePtr)->retval) = value;
                }
            }
            public string exception()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((get_byindexNativeArgs*)this.nativePtr)->exception);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,335
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct get_byindexNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public int index;
            public IntPtr _object;
            public IntPtr* retval;
            public IntPtr exception;
        }
        //gen! bool Set(const CefString& name,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,336
        /// <summary>
        /// Handle assignment of the interceptor value identified by |name|. |object|
        /// is the receiver ('this' object) of the interceptor. |value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |exception| to the exception that will be thrown. This setter will always
        /// be called, even when the property has an associated accessor.
        /// Return true if interceptor assignment was handled, false otherwise.
        /// /*cef(capi_name=set_byname)*/
        /// </summary>
        public struct set_bynameArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal set_bynameArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((set_bynameNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((set_bynameNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((set_bynameNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public string name()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((set_bynameNativeArgs*)this.nativePtr)->name);
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((set_bynameNativeArgs*)this.nativePtr)->_object);
                }
            }
            public CefV8Value value()
            {
                unsafe
                {
                    return new CefV8Value(((set_bynameNativeArgs*)this.nativePtr)->value);
                }
            }
            public string exception()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((set_bynameNativeArgs*)this.nativePtr)->exception);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,337
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct set_bynameNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr name;
            public IntPtr _object;
            public IntPtr value;
            public IntPtr exception;
        }
        //gen! bool Set(int index,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,338
        /// <summary>
        /// Handle assignment of the interceptor value identified by |index|. |object|
        /// is the receiver ('this' object) of the interceptor. |value| is the new
        /// value being assigned to the interceptor. If assignment fails, set
        /// |exception| to the exception that will be thrown.
        /// Return true if interceptor assignment was handled, false otherwise.
        /// /*cef(capi_name=set_byindex,index_param=index)*/
        /// </summary>
        public struct set_byindexArgs
        {
            IntPtr nativePtr; //met arg native ptr
            internal set_byindexArgs(IntPtr nativePtr)
            {
                this.nativePtr = nativePtr;
            }
            public void myext_finish()
            {
                unsafe
                {
                    ((set_byindexNativeArgs*)this.nativePtr)->argFlags |= MyCefArgsHelper.FINISH_FLAGS;
                }
            }
            public bool myext_isDone()
            {
                unsafe
                {
                    return MyCefArgsHelper.IsDone(((set_byindexNativeArgs*)this.nativePtr)->argFlags);
                }
            }
            public void myext_setRetValue(bool value)
            {
                unsafe
                {
                    ((set_byindexNativeArgs*)this.nativePtr)->myext_ret_value = value;
                }
            }
            public int index()
            {
                unsafe
                {
                    return ((set_byindexNativeArgs*)this.nativePtr)->index;
                }
            }
            public CefV8Value _object()
            {
                unsafe
                {
                    return new CefV8Value(((set_byindexNativeArgs*)this.nativePtr)->_object);
                }
            }
            public CefV8Value value()
            {
                unsafe
                {
                    return new CefV8Value(((set_byindexNativeArgs*)this.nativePtr)->value);
                }
            }
            public string exception()
            {
                unsafe
                {
                    return MyMetArgs.GetAsString(((set_byindexNativeArgs*)this.nativePtr)->exception);
                }
            }
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,339
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct set_byindexNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public int index;
            public IntPtr _object;
            public IntPtr value;
            public IntPtr exception;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,340
            /// <summary>
            /// Handle retrieval of the interceptor value identified by |name|. |object| is
            /// the receiver ('this' object) of the interceptor. If retrieval succeeds, set
            /// |retval| to the return value. If the requested value does not exist, don't
            /// set either |retval| or |exception|. If retrieval fails, set |exception| to
            /// the exception that will be thrown. If the property has an associated
            /// accessor, it will be called only if you don't set |retval|.
            /// Return true if interceptor retrieval was handled, false otherwise.
            /// /*cef(capi_name=get_byname)*/
            /// </summary>
            void Get(get_bynameArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,341
            /// <summary>
            /// Handle retrieval of the interceptor value identified by |index|. |object|
            /// is the receiver ('this' object) of the interceptor. If retrieval succeeds,
            /// set |retval| to the return value. If the requested value does not exist,
            /// don't set either |retval| or |exception|. If retrieval fails, set
            /// |exception| to the exception that will be thrown.
            /// Return true if interceptor retrieval was handled, false otherwise.
            /// /*cef(capi_name=get_byindex,index_param=index)*/
            /// </summary>
            void Get(get_byindexArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,342
            /// <summary>
            /// Handle assignment of the interceptor value identified by |name|. |object|
            /// is the receiver ('this' object) of the interceptor. |value| is the new
            /// value being assigned to the interceptor. If assignment fails, set
            /// |exception| to the exception that will be thrown. This setter will always
            /// be called, even when the property has an associated accessor.
            /// Return true if interceptor assignment was handled, false otherwise.
            /// /*cef(capi_name=set_byname)*/
            /// </summary>
            void Set(set_bynameArgs args);
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,343
            /// <summary>
            /// Handle assignment of the interceptor value identified by |index|. |object|
            /// is the receiver ('this' object) of the interceptor. |value| is the new
            /// value being assigned to the interceptor. If assignment fails, set
            /// |exception| to the exception that will be thrown.
            /// Return true if interceptor assignment was handled, false otherwise.
            /// /*cef(capi_name=set_byindex,index_param=index)*/
            /// </summary>
            void Set(set_byindexArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,344
            /// <summary>
            /// Handle retrieval of the interceptor value identified by |name|. |object| is
            /// the receiver ('this' object) of the interceptor. If retrieval succeeds, set
            /// |retval| to the return value. If the requested value does not exist, don't
            /// set either |retval| or |exception|. If retrieval fails, set |exception| to
            /// the exception that will be thrown. If the property has an associated
            /// accessor, it will be called only if you don't set |retval|.
            /// Return true if interceptor retrieval was handled, false otherwise.
            /// /*cef(capi_name=get_byname)*/
            /// </summary>
            bool Get(string name, CefV8Value _object, ref IntPtr retval, string exception);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,345
            /// <summary>
            /// Handle retrieval of the interceptor value identified by |index|. |object|
            /// is the receiver ('this' object) of the interceptor. If retrieval succeeds,
            /// set |retval| to the return value. If the requested value does not exist,
            /// don't set either |retval| or |exception|. If retrieval fails, set
            /// |exception| to the exception that will be thrown.
            /// Return true if interceptor retrieval was handled, false otherwise.
            /// /*cef(capi_name=get_byindex,index_param=index)*/
            /// </summary>
            bool Get(int index, CefV8Value _object, ref IntPtr retval, string exception);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,346
            /// <summary>
            /// Handle assignment of the interceptor value identified by |name|. |object|
            /// is the receiver ('this' object) of the interceptor. |value| is the new
            /// value being assigned to the interceptor. If assignment fails, set
            /// |exception| to the exception that will be thrown. This setter will always
            /// be called, even when the property has an associated accessor.
            /// Return true if interceptor assignment was handled, false otherwise.
            /// /*cef(capi_name=set_byname)*/
            /// </summary>
            bool Set(string name, CefV8Value _object, CefV8Value value, string exception);
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,347
            /// <summary>
            /// Handle assignment of the interceptor value identified by |index|. |object|
            /// is the receiver ('this' object) of the interceptor. |value| is the new
            /// value being assigned to the interceptor. If assignment fails, set
            /// |exception| to the exception that will be thrown.
            /// Return true if interceptor assignment was handled, false otherwise.
            /// /*cef(capi_name=set_byindex,index_param=index)*/
            /// </summary>
            bool Set(int index, CefV8Value _object, CefV8Value value, string exception);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,348
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,349
                case MyCefV8Interceptor_Get_1:
                    {
                        var args = new get_bynameArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Get(args);
                        }
                        if (i1 != null)
                        {
                            Get(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,350
                case MyCefV8Interceptor_Get_2:
                    {
                        var args = new get_byindexArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Get(args);
                        }
                        if (i1 != null)
                        {
                            Get(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,351
                case MyCefV8Interceptor_Set_3:
                    {
                        var args = new set_bynameArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Set(args);
                        }
                        if (i1 != null)
                        {
                            Set(i1, args);
                        }
                    }
                    break;
                //CsStructModuleCodeGen:: HandleNativeReq ,352
                case MyCefV8Interceptor_Set_4:
                    {
                        var args = new set_byindexArgs(nativeArgPtr);
                        if (i0 != null)
                        {
                            i0.Set(args);
                        }
                        if (i1 != null)
                        {
                            Set(i1, args);
                        }
                    }
                    break;
            }
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,353
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefV8Interceptor_Get_1:
                    i0.Get(new get_bynameArgs(nativeArgPtr));
                    break;
                case MyCefV8Interceptor_Get_2:
                    i0.Get(new get_byindexArgs(nativeArgPtr));
                    break;
                case MyCefV8Interceptor_Set_3:
                    i0.Set(new set_bynameArgs(nativeArgPtr));
                    break;
                case MyCefV8Interceptor_Set_4:
                    i0.Set(new set_byindexArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,354
        public static void Get(I1 i1, get_bynameArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,355
            IntPtr retval = IntPtr.Zero;
            args.myext_setRetValue(i1.Get(args.name(),
            args._object(),
            ref retval,
            args.exception()));
            args.retval(retval);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,356
        public static void Get(I1 i1, get_byindexArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,357
            IntPtr retval = IntPtr.Zero;
            args.myext_setRetValue(i1.Get(args.index(),
            args._object(),
            ref retval,
            args.exception()));
            args.retval(retval);
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,358
        public static void Set(I1 i1, set_bynameArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,359
            args.myext_setRetValue(i1.Set(args.name(),
            args._object(),
            args.value(),
            args.exception()));
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,360
        public static void Set(I1 i1, set_byindexArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,361
            args.myext_setRetValue(i1.Set(args.index(),
            args._object(),
            args.value(),
            args.exception()));
        }
    }


    // [virtual] class CefV8Exception
    //CsCallToNativeCodeGen::GenerateCsCode , 511
    /// <summary>
    /// Class representing a V8 exception. The methods of this class may be called on
    /// any render process thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8Exception : IDisposable
    {
        const int _typeNAME = 42;
        const int CefV8Exception_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8Exception_GetMessage_1 = (_typeNAME << 16) | 1;
        const int CefV8Exception_GetSourceLine_2 = (_typeNAME << 16) | 2;
        const int CefV8Exception_GetScriptResourceName_3 = (_typeNAME << 16) | 3;
        const int CefV8Exception_GetLineNumber_4 = (_typeNAME << 16) | 4;
        const int CefV8Exception_GetStartPosition_5 = (_typeNAME << 16) | 5;
        const int CefV8Exception_GetEndPosition_6 = (_typeNAME << 16) | 6;
        const int CefV8Exception_GetStartColumn_7 = (_typeNAME << 16) | 7;
        const int CefV8Exception_GetEndColumn_8 = (_typeNAME << 16) | 8;
        internal IntPtr nativePtr;
        internal CefV8Exception(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 512

        // gen! CefString GetMessage()
        /// <summary>
        /// CefV8Exception methods.
        /// </summary>

        public string GetMessage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetMessage_1, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 513

        // gen! CefString GetSourceLine()
        /// <summary>
        /// Returns the line of source code that the exception occurred within.
        /// /*cef()*/
        /// </summary>

        public string GetSourceLine()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetSourceLine_2, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 514

        // gen! CefString GetScriptResourceName()
        /// <summary>
        /// Returns the resource name for the script from where the function causing
        /// the error originates.
        /// /*cef()*/
        /// </summary>

        public string GetScriptResourceName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetScriptResourceName_3, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 515

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based number of the line where the error occurred or 0 if the
        /// line number is unknown.
        /// /*cef()*/
        /// </summary>

        public int GetLineNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetLineNumber_4, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 516

        // gen! int GetStartPosition()
        /// <summary>
        /// Returns the index within the script of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetStartPosition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartPosition_5, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 517

        // gen! int GetEndPosition()
        /// <summary>
        /// Returns the index within the script of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetEndPosition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndPosition_6, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 518

        // gen! int GetStartColumn()
        /// <summary>
        /// Returns the index within the line of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetStartColumn()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartColumn_7, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 519

        // gen! int GetEndColumn()
        /// <summary>
        /// Returns the index within the line of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetEndColumn()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndColumn_8, out ret);
            return ret.I32;
        }
    }


    // [virtual] class CefV8Value
    //CsCallToNativeCodeGen::GenerateCsCode , 520
    /// <summary>
    /// Class representing a V8 value handle. V8 handles can only be accessed from
    /// the thread on which they are created. Valid threads for creating a V8 handle
    /// include the render process main thread (TID_RENDERER) and WebWorker threads.
    /// A task runner for posting tasks on the associated thread can be retrieved via
    /// the CefV8Context::GetTaskRunner() method.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8Value : IDisposable
    {
        const int _typeNAME = 43;
        const int CefV8Value_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8Value_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefV8Value_IsUndefined_2 = (_typeNAME << 16) | 2;
        const int CefV8Value_IsNull_3 = (_typeNAME << 16) | 3;
        const int CefV8Value_IsBool_4 = (_typeNAME << 16) | 4;
        const int CefV8Value_IsInt_5 = (_typeNAME << 16) | 5;
        const int CefV8Value_IsUInt_6 = (_typeNAME << 16) | 6;
        const int CefV8Value_IsDouble_7 = (_typeNAME << 16) | 7;
        const int CefV8Value_IsDate_8 = (_typeNAME << 16) | 8;
        const int CefV8Value_IsString_9 = (_typeNAME << 16) | 9;
        const int CefV8Value_IsObject_10 = (_typeNAME << 16) | 10;
        const int CefV8Value_IsArray_11 = (_typeNAME << 16) | 11;
        const int CefV8Value_IsFunction_12 = (_typeNAME << 16) | 12;
        const int CefV8Value_IsSame_13 = (_typeNAME << 16) | 13;
        const int CefV8Value_GetBoolValue_14 = (_typeNAME << 16) | 14;
        const int CefV8Value_GetIntValue_15 = (_typeNAME << 16) | 15;
        const int CefV8Value_GetUIntValue_16 = (_typeNAME << 16) | 16;
        const int CefV8Value_GetDoubleValue_17 = (_typeNAME << 16) | 17;
        const int CefV8Value_GetDateValue_18 = (_typeNAME << 16) | 18;
        const int CefV8Value_GetStringValue_19 = (_typeNAME << 16) | 19;
        const int CefV8Value_IsUserCreated_20 = (_typeNAME << 16) | 20;
        const int CefV8Value_HasException_21 = (_typeNAME << 16) | 21;
        const int CefV8Value_GetException_22 = (_typeNAME << 16) | 22;
        const int CefV8Value_ClearException_23 = (_typeNAME << 16) | 23;
        const int CefV8Value_WillRethrowExceptions_24 = (_typeNAME << 16) | 24;
        const int CefV8Value_SetRethrowExceptions_25 = (_typeNAME << 16) | 25;
        const int CefV8Value_HasValue_26 = (_typeNAME << 16) | 26;
        const int CefV8Value_HasValue_27 = (_typeNAME << 16) | 27;
        const int CefV8Value_DeleteValue_28 = (_typeNAME << 16) | 28;
        const int CefV8Value_DeleteValue_29 = (_typeNAME << 16) | 29;
        const int CefV8Value_GetValue_30 = (_typeNAME << 16) | 30;
        const int CefV8Value_GetValue_31 = (_typeNAME << 16) | 31;
        const int CefV8Value_SetValue_32 = (_typeNAME << 16) | 32;
        const int CefV8Value_SetValue_33 = (_typeNAME << 16) | 33;
        const int CefV8Value_SetValue_34 = (_typeNAME << 16) | 34;
        const int CefV8Value_GetKeys_35 = (_typeNAME << 16) | 35;
        const int CefV8Value_SetUserData_36 = (_typeNAME << 16) | 36;
        const int CefV8Value_GetUserData_37 = (_typeNAME << 16) | 37;
        const int CefV8Value_GetExternallyAllocatedMemory_38 = (_typeNAME << 16) | 38;
        const int CefV8Value_AdjustExternallyAllocatedMemory_39 = (_typeNAME << 16) | 39;
        const int CefV8Value_GetArrayLength_40 = (_typeNAME << 16) | 40;
        const int CefV8Value_GetFunctionName_41 = (_typeNAME << 16) | 41;
        const int CefV8Value_GetFunctionHandler_42 = (_typeNAME << 16) | 42;
        const int CefV8Value_ExecuteFunction_43 = (_typeNAME << 16) | 43;
        const int CefV8Value_ExecuteFunctionWithContext_44 = (_typeNAME << 16) | 44;
        //
        const int CefV8Value_S_CreateUndefined_1 = (_typeNAME << 16) | 1;
        const int CefV8Value_S_CreateNull_2 = (_typeNAME << 16) | 2;
        const int CefV8Value_S_CreateBool_3 = (_typeNAME << 16) | 3;
        const int CefV8Value_S_CreateInt_4 = (_typeNAME << 16) | 4;
        const int CefV8Value_S_CreateUInt_5 = (_typeNAME << 16) | 5;
        const int CefV8Value_S_CreateDouble_6 = (_typeNAME << 16) | 6;
        const int CefV8Value_S_CreateDate_7 = (_typeNAME << 16) | 7;
        const int CefV8Value_S_CreateString_8 = (_typeNAME << 16) | 8;
        const int CefV8Value_S_CreateObject_9 = (_typeNAME << 16) | 9;
        const int CefV8Value_S_CreateArray_10 = (_typeNAME << 16) | 10;
        const int CefV8Value_S_CreateFunction_11 = (_typeNAME << 16) | 11;
        internal IntPtr nativePtr;
        internal CefV8Value(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 521

        // gen! bool IsValid()
        /// <summary>
        /// CefV8Value methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 522

        // gen! bool IsUndefined()
        /// <summary>
        /// True if the value type is undefined.
        /// /*cef()*/
        /// </summary>

        public bool IsUndefined()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUndefined_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 523

        // gen! bool IsNull()
        /// <summary>
        /// True if the value type is null.
        /// /*cef()*/
        /// </summary>

        public bool IsNull()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsNull_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 524

        // gen! bool IsBool()
        /// <summary>
        /// True if the value type is bool.
        /// /*cef()*/
        /// </summary>

        public bool IsBool()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsBool_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 525

        // gen! bool IsInt()
        /// <summary>
        /// True if the value type is int.
        /// /*cef()*/
        /// </summary>

        public bool IsInt()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsInt_5, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 526

        // gen! bool IsUInt()
        /// <summary>
        /// True if the value type is unsigned int.
        /// /*cef()*/
        /// </summary>

        public bool IsUInt()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUInt_6, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 527

        // gen! bool IsDouble()
        /// <summary>
        /// True if the value type is double.
        /// /*cef()*/
        /// </summary>

        public bool IsDouble()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDouble_7, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 528

        // gen! bool IsDate()
        /// <summary>
        /// True if the value type is Date.
        /// /*cef()*/
        /// </summary>

        public bool IsDate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDate_8, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 529

        // gen! bool IsString()
        /// <summary>
        /// True if the value type is string.
        /// /*cef()*/
        /// </summary>

        public bool IsString()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsString_9, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 530

        // gen! bool IsObject()
        /// <summary>
        /// True if the value type is object.
        /// /*cef()*/
        /// </summary>

        public bool IsObject()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsObject_10, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 531

        // gen! bool IsArray()
        /// <summary>
        /// True if the value type is array.
        /// /*cef()*/
        /// </summary>

        public bool IsArray()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsArray_11, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 532

        // gen! bool IsFunction()
        /// <summary>
        /// True if the value type is function.
        /// /*cef()*/
        /// </summary>

        public bool IsFunction()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsFunction_12, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 533

        // gen! bool IsSame(CefRefPtr<CefV8Value> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefV8Value that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_IsSame_13, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 534

        // gen! bool GetBoolValue()
        /// <summary>
        /// Return a bool value.
        /// /*cef()*/
        /// </summary>

        public bool GetBoolValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetBoolValue_14, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 535

        // gen! int32 GetIntValue()
        /// <summary>
        /// Return an int value.
        /// /*cef()*/
        /// </summary>

        public int GetIntValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetIntValue_15, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 536

        // gen! uint32 GetUIntValue()
        /// <summary>
        /// Return an unsigned int value.
        /// /*cef()*/
        /// </summary>

        public uint GetUIntValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUIntValue_16, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 537

        // gen! double GetDoubleValue()
        /// <summary>
        /// Return a double value.
        /// /*cef()*/
        /// </summary>

        public double GetDoubleValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDoubleValue_17, out ret);
            return ret.Num;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 538

        // gen! CefTime GetDateValue()
        /// <summary>
        /// Return a Date value.
        /// /*cef()*/
        /// </summary>

        public CefTime GetDateValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDateValue_18, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 539

        // gen! CefString GetStringValue()
        /// <summary>
        /// Return a string value.
        /// /*cef()*/
        /// </summary>

        public string GetStringValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetStringValue_19, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 540

        // gen! bool IsUserCreated()
        /// <summary>
        /// OBJECT METHODS - These methods are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true if this is a user created object.
        /// /*cef()*/
        /// </summary>

        public bool IsUserCreated()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUserCreated_20, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 541

        // gen! bool HasException()
        /// <summary>
        /// Returns true if the last method call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public bool HasException()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_HasException_21, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 542

        // gen! CefRefPtr<CefV8Exception> GetException()
        /// <summary>
        /// Returns the exception resulting from the last method call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public CefV8Exception GetException()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetException_22, out ret);
            return new CefV8Exception(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 543

        // gen! bool ClearException()
        /// <summary>
        /// Clears the last exception and returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool ClearException()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_ClearException_23, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 544

        // gen! bool WillRethrowExceptions()
        /// <summary>
        /// Returns true if this object will re-throw future exceptions. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public bool WillRethrowExceptions()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_WillRethrowExceptions_24, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 545

        // gen! bool SetRethrowExceptions(bool rethrow)
        /// <summary>
        /// Set whether this object will re-throw future exceptions. By default
        /// exceptions are not re-thrown. If a exception is re-thrown the current
        /// context should not be accessed again until after the exception has been
        /// caught and not re-thrown. Returns true on success. This attribute exists
        /// only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public bool SetRethrowExceptions(bool rethrow)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = rethrow ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetRethrowExceptions_25, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 546

        // gen! bool HasValue(const CefString& key)

        public bool HasValue(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_26, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 547

        // gen! bool HasValue(int index)

        public bool HasValue(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_27, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 548

        // gen! bool DeleteValue(const CefString& key)

        public bool DeleteValue(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_28, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 549

        // gen! bool DeleteValue(int index)

        public bool DeleteValue(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_29, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 550

        // gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)

        public CefV8Value GetValue(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_30, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 551

        // gen! CefRefPtr<CefV8Value> GetValue(int index)

        public CefV8Value GetValue(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_31, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 552

        // gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)

        public bool SetValue(string key,
        CefV8Value value,
        cef_v8_propertyattribute_t attribute)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Ptr = value.nativePtr;
            v3.I32 = (int)attribute;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_32, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 553

        // gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)

        public bool SetValue(int index,
        CefV8Value value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_SetValue_33, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 554

        // gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)

        public bool SetValue(string key,
        cef_v8_accesscontrol_t settings,
        cef_v8_propertyattribute_t attribute)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.I32 = (int)settings;
            v3.I32 = (int)attribute;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_34, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 555

        // gen! bool GetKeys(std::vector<CefString>& keys)
        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// /*cef()*/
        /// </summary>

        public bool GetKeys(List<string> keys)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetKeys_35, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, keys);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 556

        // gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
        /// <summary>
        /// Sets the user data for this object and returns true on success. Returns
        /// false if this method is called incorrectly. This method can only be called
        /// on user created objects.
        /// /*cef(optional_param=user_data)*/
        /// </summary>

        public bool SetUserData(CefBaseRefCounted user_data)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = user_data.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetUserData_36, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 557

        // gen! CefRefPtr<CefBaseRefCounted> GetUserData()
        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// /*cef()*/
        /// </summary>

        public CefBaseRefCounted GetUserData()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUserData_37, out ret);
            return new CefBaseRefCounted(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 558

        // gen! int GetExternallyAllocatedMemory()
        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// /*cef()*/
        /// </summary>

        public int GetExternallyAllocatedMemory()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetExternallyAllocatedMemory_38, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 559

        // gen! int AdjustExternallyAllocatedMemory(int change_in_bytes)
        /// <summary>
        /// Adjusts the amount of registered external memory for the object. Used to
        /// give V8 an indication of the amount of externally allocated memory that is
        /// kept alive by JavaScript objects. V8 uses this information to decide when
        /// to perform global garbage collection. Each CefV8Value tracks the amount of
        /// external memory associated with it and automatically decreases the global
        /// total by the appropriate amount on its destruction. |change_in_bytes|
        /// specifies the number of bytes to adjust by. This method returns the number
        /// of bytes associated with the object after the adjustment. This method can
        /// only be called on user created objects.
        /// /*cef()*/
        /// </summary>

        public int AdjustExternallyAllocatedMemory(int change_in_bytes)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)change_in_bytes;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_AdjustExternallyAllocatedMemory_39, out ret, ref v1);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 560

        // gen! int GetArrayLength()
        /// <summary>
        /// ARRAY METHODS - These methods are only available on arrays.
        /// Returns the number of elements in the array.
        /// /*cef()*/
        /// </summary>

        public int GetArrayLength()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetArrayLength_40, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 561

        // gen! CefString GetFunctionName()
        /// <summary>
        /// FUNCTION METHODS - These methods are only available on functions.
        /// Returns the function name.
        /// /*cef()*/
        /// </summary>

        public string GetFunctionName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionName_41, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 562

        // gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// /*cef()*/
        /// </summary>

        public CefV8Handler GetFunctionHandler()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionHandler_42, out ret);
            return new CefV8Handler(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 563

        // gen! CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
        /// <summary>
        /// Execute the function using the current V8 context. This method should only
        /// be called from within the scope of a CefV8Handler or CefV8Accessor
        /// callback, or in combination with calling Enter() and Exit() on a stored
        /// CefV8Context reference. |object| is the receiver ('this' object) of the
        /// function. If |object| is empty the current context's global object will be
        /// used. |arguments| is the list of arguments that will be passed to the
        /// function. Returns the function return value on success. Returns NULL if
        /// this method is called incorrectly or an exception is thrown.
        /// /*cef(optional_param=object)*/
        /// </summary>

        public CefV8Value ExecuteFunction(CefV8Value _object,
        CefV8ValueList arguments)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _object.nativePtr;
            v2.Ptr = arguments.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_ExecuteFunction_43, out ret, ref v1, ref v2);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 564

        // gen! CefRefPtr<CefV8Value> ExecuteFunctionWithContext(CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
        /// <summary>
        /// Execute the function using the specified V8 context. |object| is the
        /// receiver ('this' object) of the function. If |object| is empty the
        /// specified context's global object will be used. |arguments| is the list of
        /// arguments that will be passed to the function. Returns the function return
        /// value on success. Returns NULL if this method is called incorrectly or an
        /// exception is thrown.
        /// /*cef(optional_param=object)*/
        /// </summary>

        public CefV8Value ExecuteFunctionWithContext(CefV8Context context,
        CefV8Value _object,
        CefV8ValueList arguments)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = context.nativePtr;
            v2.Ptr = _object.nativePtr;
            v3.Ptr = arguments.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_ExecuteFunctionWithContext_44, out ret, ref v1, ref v2, ref v3);
            return new CefV8Value(ret.Ptr);
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 565

        // gen! CefRefPtr<CefV8Value> CreateUndefined()
        /// <summary>
        /// Create a new CefV8Value object of type undefined.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateUndefined()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefV8Value_S_CreateUndefined_1, out ret);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 566

        // gen! CefRefPtr<CefV8Value> CreateNull()
        /// <summary>
        /// Create a new CefV8Value object of type null.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateNull()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefV8Value_S_CreateNull_2, out ret);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 567

        // gen! CefRefPtr<CefV8Value> CreateBool(bool value)
        /// <summary>
        /// Create a new CefV8Value object of type bool.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateBool(bool value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateBool_3, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 568

        // gen! CefRefPtr<CefV8Value> CreateInt(int32 value)
        /// <summary>
        /// Create a new CefV8Value object of type int.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateInt(int value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = value;

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateInt_4, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 569

        // gen! CefRefPtr<CefV8Value> CreateUInt(uint32 value)
        /// <summary>
        /// Create a new CefV8Value object of type unsigned int.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateUInt(uint value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)value;

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateUInt_5, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 570

        // gen! CefRefPtr<CefV8Value> CreateDouble(double value)
        /// <summary>
        /// Create a new CefV8Value object of type double.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateDouble(double value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = value;

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateDouble_6, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 571

        // gen! CefRefPtr<CefV8Value> CreateDate(const CefTime& date)
        /// <summary>
        /// Create a new CefV8Value object of type Date. This method should only be
        /// called from within the scope of a CefRenderProcessHandler, CefV8Handler or
        /// CefV8Accessor callback, or in combination with calling Enter() and Exit()
        /// on a stored CefV8Context reference.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateDate(CefTime date)
        {
            JsValue v1 = new JsValue();
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateDate_7, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 572

        // gen! CefRefPtr<CefV8Value> CreateString(const CefString& value)
        /// <summary>
        /// Create a new CefV8Value object of type string.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public static CefV8Value CreateString(string value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(value);

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateString_8, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 573

        // gen! CefRefPtr<CefV8Value> CreateObject(CefRefPtr<CefV8Accessor> accessor,CefRefPtr<CefV8Interceptor> interceptor)
        /// <summary>
        /// Create a new CefV8Value object of type object with optional accessor and/or
        /// interceptor. This method should only be called from within the scope of a
        /// CefRenderProcessHandler, CefV8Handler or CefV8Accessor callback, or in
        /// combination with calling Enter() and Exit() on a stored CefV8Context
        /// reference.
        /// /*cef(optional_param=accessor,optional_param=interceptor)*/
        /// </summary>

        public static CefV8Value CreateObject(CefV8Accessor accessor,
        CefV8Interceptor interceptor)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = accessor.nativePtr;
            v2.Ptr = interceptor.nativePtr;

            Cef3Binder.MyCefMet_S_Call2(CefV8Value_S_CreateObject_9, out ret, ref v1, ref v2);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 574

        // gen! CefRefPtr<CefV8Value> CreateArray(int length)
        /// <summary>
        /// Create a new CefV8Value object of type array with the specified |length|.
        /// If |length| is negative the returned array will have length 0. This method
        /// should only be called from within the scope of a CefRenderProcessHandler,
        /// CefV8Handler or CefV8Accessor callback, or in combination with calling
        /// Enter() and Exit() on a stored CefV8Context reference.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateArray(int length)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)length;

            Cef3Binder.MyCefMet_S_Call1(CefV8Value_S_CreateArray_10, out ret, ref v1);
            return new CefV8Value(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 575

        // gen! CefRefPtr<CefV8Value> CreateFunction(const CefString& name,CefRefPtr<CefV8Handler> handler)
        /// <summary>
        /// Create a new CefV8Value object of type function. This method should only be
        /// called from within the scope of a CefRenderProcessHandler, CefV8Handler or
        /// CefV8Accessor callback, or in combination with calling Enter() and Exit()
        /// on a stored CefV8Context reference.
        /// /*cef()*/
        /// </summary>

        public static CefV8Value CreateFunction(string name,
        CefV8Handler handler)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(name);
            v2.Ptr = handler.nativePtr;

            Cef3Binder.MyCefMet_S_Call2(CefV8Value_S_CreateFunction_11, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefV8Value(ret.Ptr);
        }
    }


    // [virtual] class CefV8StackTrace
    //CsCallToNativeCodeGen::GenerateCsCode , 576
    /// <summary>
    /// Class representing a V8 stack trace handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CefV8Context::GetTaskRunner() method.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8StackTrace : IDisposable
    {
        const int _typeNAME = 44;
        const int CefV8StackTrace_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8StackTrace_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefV8StackTrace_GetFrameCount_2 = (_typeNAME << 16) | 2;
        const int CefV8StackTrace_GetFrame_3 = (_typeNAME << 16) | 3;
        //
        const int CefV8StackTrace_S_GetCurrent_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefV8StackTrace(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 577

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackTrace methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 578

        // gen! int GetFrameCount()
        /// <summary>
        /// Returns the number of stack frames.
        /// /*cef()*/
        /// </summary>

        public int GetFrameCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_GetFrameCount_2, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 579

        // gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
        /// <summary>
        /// Returns the stack frame at the specified 0-based index.
        /// /*cef()*/
        /// </summary>

        public CefV8StackFrame GetFrame(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8StackTrace_GetFrame_3, out ret, ref v1);
            return new CefV8StackFrame(ret.Ptr);
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 580

        // gen! CefRefPtr<CefV8StackTrace> GetCurrent(int frame_limit)
        /// <summary>
        /// Returns the stack trace for the currently active context. |frame_limit| is
        /// the maximum number of frames that will be captured.
        /// /*cef()*/
        /// </summary>

        public static CefV8StackTrace GetCurrent(int frame_limit)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)frame_limit;

            Cef3Binder.MyCefMet_S_Call1(CefV8StackTrace_S_GetCurrent_1, out ret, ref v1);
            return new CefV8StackTrace(ret.Ptr);
        }
    }


    // [virtual] class CefV8StackFrame
    //CsCallToNativeCodeGen::GenerateCsCode , 581
    /// <summary>
    /// Class representing a V8 stack frame handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CefV8Context::GetTaskRunner() method.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8StackFrame : IDisposable
    {
        const int _typeNAME = 45;
        const int CefV8StackFrame_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8StackFrame_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefV8StackFrame_GetScriptName_2 = (_typeNAME << 16) | 2;
        const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = (_typeNAME << 16) | 3;
        const int CefV8StackFrame_GetFunctionName_4 = (_typeNAME << 16) | 4;
        const int CefV8StackFrame_GetLineNumber_5 = (_typeNAME << 16) | 5;
        const int CefV8StackFrame_GetColumn_6 = (_typeNAME << 16) | 6;
        const int CefV8StackFrame_IsEval_7 = (_typeNAME << 16) | 7;
        const int CefV8StackFrame_IsConstructor_8 = (_typeNAME << 16) | 8;
        internal IntPtr nativePtr;
        internal CefV8StackFrame(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 582

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackFrame methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 583

        // gen! CefString GetScriptName()
        /// <summary>
        /// Returns the name of the resource script that contains the function.
        /// /*cef()*/
        /// </summary>

        public string GetScriptName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptName_2, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 584

        // gen! CefString GetScriptNameOrSourceURL()
        /// <summary>
        /// Returns the name of the resource script that contains the function or the
        /// sourceURL value if the script name is undefined and its source ends with
        /// a "//@ sourceURL=..." string.
        /// /*cef()*/
        /// </summary>

        public string GetScriptNameOrSourceURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptNameOrSourceURL_3, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 585

        // gen! CefString GetFunctionName()
        /// <summary>
        /// Returns the name of the function.
        /// /*cef()*/
        /// </summary>

        public string GetFunctionName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetFunctionName_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 586

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based line number for the function call or 0 if unknown.
        /// /*cef()*/
        /// </summary>

        public int GetLineNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetLineNumber_5, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 587

        // gen! int GetColumn()
        /// <summary>
        /// Returns the 1-based column offset on the line for the function call or 0 if
        /// unknown.
        /// /*cef()*/
        /// </summary>

        public int GetColumn()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetColumn_6, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 588

        // gen! bool IsEval()
        /// <summary>
        /// Returns true if the function was compiled using eval().
        /// /*cef()*/
        /// </summary>

        public bool IsEval()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsEval_7, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 589

        // gen! bool IsConstructor()
        /// <summary>
        /// Returns true if the function was called as a constructor via "new".
        /// /*cef()*/
        /// </summary>

        public bool IsConstructor()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsConstructor_8, out ret);
            return ret.I32 != 0;
        }
    }


    // [virtual] class CefValue
    //CsCallToNativeCodeGen::GenerateCsCode , 590
    /// <summary>
    /// Class that wraps other data value types. Complex types (binary, dictionary
    /// and list) will be referenced but not owned by this object. Can be used on any
    /// process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    public struct CefValue : IDisposable
    {
        const int _typeNAME = 46;
        const int CefValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        const int CefValue_IsSame_4 = (_typeNAME << 16) | 4;
        const int CefValue_IsEqual_5 = (_typeNAME << 16) | 5;
        const int CefValue_Copy_6 = (_typeNAME << 16) | 6;
        const int CefValue_GetType_7 = (_typeNAME << 16) | 7;
        const int CefValue_GetBool_8 = (_typeNAME << 16) | 8;
        const int CefValue_GetInt_9 = (_typeNAME << 16) | 9;
        const int CefValue_GetDouble_10 = (_typeNAME << 16) | 10;
        const int CefValue_GetString_11 = (_typeNAME << 16) | 11;
        const int CefValue_GetBinary_12 = (_typeNAME << 16) | 12;
        const int CefValue_GetDictionary_13 = (_typeNAME << 16) | 13;
        const int CefValue_GetList_14 = (_typeNAME << 16) | 14;
        const int CefValue_SetNull_15 = (_typeNAME << 16) | 15;
        const int CefValue_SetBool_16 = (_typeNAME << 16) | 16;
        const int CefValue_SetInt_17 = (_typeNAME << 16) | 17;
        const int CefValue_SetDouble_18 = (_typeNAME << 16) | 18;
        const int CefValue_SetString_19 = (_typeNAME << 16) | 19;
        const int CefValue_SetBinary_20 = (_typeNAME << 16) | 20;
        const int CefValue_SetDictionary_21 = (_typeNAME << 16) | 21;
        const int CefValue_SetList_22 = (_typeNAME << 16) | 22;
        //
        const int CefValue_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 591

        // gen! bool IsValid()
        /// <summary>
        /// CefValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 592

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if the underlying data is owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsOwned_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 593

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the underlying data is read-only. Some APIs may expose
        /// read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsReadOnly_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 594

        // gen! bool IsSame(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsSame_4, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 595

        // gen! bool IsEqual(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsEqual_5, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 596

        // gen! CefRefPtr<CefValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The underlying data will also be copied.
        /// /*cef()*/
        /// </summary>

        public CefValue Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Copy_6, out ret);
            return new CefValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 597

        // gen! CefValueType GetType()
        /// <summary>
        /// Returns the underlying value type.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>

        public cef_value_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetType_7, out ret);
            return (cef_value_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 598

        // gen! bool GetBool()
        /// <summary>
        /// Returns the underlying value as type bool.
        /// /*cef()*/
        /// </summary>

        public bool GetBool()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBool_8, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 599

        // gen! int GetInt()
        /// <summary>
        /// Returns the underlying value as type int.
        /// /*cef()*/
        /// </summary>

        public int GetInt()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetInt_9, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 600

        // gen! double GetDouble()
        /// <summary>
        /// Returns the underlying value as type double.
        /// /*cef()*/
        /// </summary>

        public double GetDouble()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDouble_10, out ret);
            return ret.Num;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 601

        // gen! CefString GetString()
        /// <summary>
        /// Returns the underlying value as type string.
        /// /*cef()*/
        /// </summary>

        public string GetString()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetString_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 602

        // gen! CefRefPtr<CefBinaryValue> GetBinary()
        /// <summary>
        /// Returns the underlying value as type binary. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetBinary().
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetBinary()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBinary_12, out ret);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 603

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary()
        /// <summary>
        /// Returns the underlying value as type dictionary. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetDictionary().
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetDictionary()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDictionary_13, out ret);
            return new CefDictionaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 604

        // gen! CefRefPtr<CefListValue> GetList()
        /// <summary>
        /// Returns the underlying value as type list. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetList().
        /// /*cef()*/
        /// </summary>

        public CefListValue GetList()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetList_14, out ret);
            return new CefListValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 605

        // gen! bool SetNull()
        /// <summary>
        /// Sets the underlying value as type null. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetNull()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_SetNull_15, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 606

        // gen! bool SetBool(bool value)
        /// <summary>
        /// Sets the underlying value as type bool. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetBool(bool value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBool_16, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 607

        // gen! bool SetInt(int value)
        /// <summary>
        /// Sets the underlying value as type int. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetInt(int value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)value;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetInt_17, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 608

        // gen! bool SetDouble(double value)
        /// <summary>
        /// Sets the underlying value as type double. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetDouble(double value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = value;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDouble_18, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 609

        // gen! bool SetString(const CefString& value)
        /// <summary>
        /// Sets the underlying value as type string. Returns true if the value was set
        /// successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetString(string value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(value);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetString_19, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 610

        // gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the underlying value as type binary. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>

        public bool SetBinary(CefBinaryValue value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBinary_20, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 611

        // gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the underlying value as type dict. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>

        public bool SetDictionary(CefDictionaryValue value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDictionary_21, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 612

        // gen! bool SetList(CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the underlying value as type list. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>

        public bool SetList(CefListValue value)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetList_22, out ret, ref v1);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 613

        // gen! CefRefPtr<CefValue> Create()
        /// <summary>
        /// Creates a new object.
        /// /*cef()*/
        /// </summary>

        public static CefValue Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefValue_S_Create_1, out ret);
            return new CefValue(ret.Ptr);
        }
    }


    // [virtual] class CefBinaryValue
    //CsCallToNativeCodeGen::GenerateCsCode , 614
    /// <summary>
    /// Class representing a binary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBinaryValue : IDisposable
    {
        const int _typeNAME = 47;
        const int CefBinaryValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefBinaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefBinaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefBinaryValue_IsSame_3 = (_typeNAME << 16) | 3;
        const int CefBinaryValue_IsEqual_4 = (_typeNAME << 16) | 4;
        const int CefBinaryValue_Copy_5 = (_typeNAME << 16) | 5;
        const int CefBinaryValue_GetSize_6 = (_typeNAME << 16) | 6;
        const int CefBinaryValue_GetData_7 = (_typeNAME << 16) | 7;
        //
        const int CefBinaryValue_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefBinaryValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 615

        // gen! bool IsValid()
        /// <summary>
        /// CefBinaryValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 616

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsOwned_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 617

        // gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefBinaryValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsSame_3, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 618

        // gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefBinaryValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsEqual_4, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 619

        // gen! CefRefPtr<CefBinaryValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The data in this object will also be copied.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Copy_5, out ret);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 620

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the data size.
        /// /*cef()*/
        /// </summary>

        public uint GetSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_GetSize_6, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 621

        // gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
        /// <summary>
        /// Read up to |buffer_size| number of bytes into |buffer|. Reading begins at
        /// the specified byte |data_offset|. Returns the number of bytes read.
        /// /*cef()*/
        /// </summary>

        public uint GetData(IntPtr buffer,
        uint buffer_size,
        uint data_offset)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = buffer;
            v2.I32 = (int)buffer_size;
            v3.I32 = (int)data_offset;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBinaryValue_GetData_7, out ret, ref v1, ref v2, ref v3);
            return (uint)ret.I32;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 622

        // gen! CefRefPtr<CefBinaryValue> Create(const void* data,size_t data_size)
        /// <summary>
        /// Creates a new object that is not owned by any other object. The specified
        /// |data| will be copied.
        /// /*cef()*/
        /// </summary>

        public static CefBinaryValue Create(IntPtr data,
        uint data_size)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = data;
            v2.I32 = (int)data_size;

            Cef3Binder.MyCefMet_S_Call2(CefBinaryValue_S_Create_1, out ret, ref v1, ref v2);
            return new CefBinaryValue(ret.Ptr);
        }
    }


    // [virtual] class CefDictionaryValue
    //CsCallToNativeCodeGen::GenerateCsCode , 623
    /// <summary>
    /// Class representing a dictionary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDictionaryValue : IDisposable
    {
        const int _typeNAME = 48;
        const int CefDictionaryValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefDictionaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefDictionaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefDictionaryValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        const int CefDictionaryValue_IsSame_4 = (_typeNAME << 16) | 4;
        const int CefDictionaryValue_IsEqual_5 = (_typeNAME << 16) | 5;
        const int CefDictionaryValue_Copy_6 = (_typeNAME << 16) | 6;
        const int CefDictionaryValue_GetSize_7 = (_typeNAME << 16) | 7;
        const int CefDictionaryValue_Clear_8 = (_typeNAME << 16) | 8;
        const int CefDictionaryValue_HasKey_9 = (_typeNAME << 16) | 9;
        const int CefDictionaryValue_GetKeys_10 = (_typeNAME << 16) | 10;
        const int CefDictionaryValue_Remove_11 = (_typeNAME << 16) | 11;
        const int CefDictionaryValue_GetType_12 = (_typeNAME << 16) | 12;
        const int CefDictionaryValue_GetValue_13 = (_typeNAME << 16) | 13;
        const int CefDictionaryValue_GetBool_14 = (_typeNAME << 16) | 14;
        const int CefDictionaryValue_GetInt_15 = (_typeNAME << 16) | 15;
        const int CefDictionaryValue_GetDouble_16 = (_typeNAME << 16) | 16;
        const int CefDictionaryValue_GetString_17 = (_typeNAME << 16) | 17;
        const int CefDictionaryValue_GetBinary_18 = (_typeNAME << 16) | 18;
        const int CefDictionaryValue_GetDictionary_19 = (_typeNAME << 16) | 19;
        const int CefDictionaryValue_GetList_20 = (_typeNAME << 16) | 20;
        const int CefDictionaryValue_SetValue_21 = (_typeNAME << 16) | 21;
        const int CefDictionaryValue_SetNull_22 = (_typeNAME << 16) | 22;
        const int CefDictionaryValue_SetBool_23 = (_typeNAME << 16) | 23;
        const int CefDictionaryValue_SetInt_24 = (_typeNAME << 16) | 24;
        const int CefDictionaryValue_SetDouble_25 = (_typeNAME << 16) | 25;
        const int CefDictionaryValue_SetString_26 = (_typeNAME << 16) | 26;
        const int CefDictionaryValue_SetBinary_27 = (_typeNAME << 16) | 27;
        const int CefDictionaryValue_SetDictionary_28 = (_typeNAME << 16) | 28;
        const int CefDictionaryValue_SetList_29 = (_typeNAME << 16) | 29;
        //
        const int CefDictionaryValue_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefDictionaryValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 624

        // gen! bool IsValid()
        /// <summary>
        /// CefDictionaryValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 625

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsOwned_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 626

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsReadOnly_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 627

        // gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefDictionaryValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsSame_4, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 628

        // gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefDictionaryValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsEqual_5, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 629

        // gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
        /// <summary>
        /// Returns a writable copy of this object. If |exclude_empty_children| is true
        /// any empty dictionaries or lists will be excluded from the copy.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue Copy(bool exclude_empty_children)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = exclude_empty_children ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Copy_6, out ret, ref v1);
            return new CefDictionaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 630

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>

        public uint GetSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_GetSize_7, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 631

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Clear()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Clear_8, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 632

        // gen! bool HasKey(const CefString& key)
        /// <summary>
        /// Returns true if the current dictionary has a value for the given key.
        /// /*cef()*/
        /// </summary>

        public bool HasKey(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_HasKey_9, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 633

        // gen! bool GetKeys(KeyList& keys)
        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// /*cef()*/
        /// </summary>

        public bool GetKeys(KeyList keys)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = keys.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetKeys_10, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 634

        // gen! bool Remove(const CefString& key)
        /// <summary>
        /// Removes the value at the specified key. Returns true is the value was
        /// removed successfully.
        /// /*cef()*/
        /// </summary>

        public bool Remove(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Remove_11, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 635

        // gen! CefValueType GetType(const CefString& key)
        /// <summary>
        /// Returns the value type for the specified key.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>

        public cef_value_type_t _GetType(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetType_12, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return (cef_value_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 636

        // gen! CefRefPtr<CefValue> GetValue(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// /*cef()*/
        /// </summary>

        public CefValue GetValue(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetValue_13, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 637

        // gen! bool GetBool(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// /*cef()*/
        /// </summary>

        public bool GetBool(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBool_14, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 638

        // gen! int GetInt(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type int.
        /// /*cef()*/
        /// </summary>

        public int GetInt(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetInt_15, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 639

        // gen! double GetDouble(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type double.
        /// /*cef()*/
        /// </summary>

        public double GetDouble(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDouble_16, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.Num;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 640

        // gen! CefString GetString(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type string.
        /// /*cef()*/
        /// </summary>

        public string GetString(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetString_17, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 641

        // gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetBinary(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBinary_18, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 642

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetDictionary(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDictionary_19, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefDictionaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 643

        // gen! CefRefPtr<CefListValue> GetList(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type list. The returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// /*cef()*/
        /// </summary>

        public CefListValue GetList(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetList_20, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return new CefListValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 644

        // gen! bool SetValue(const CefString& key,CefRefPtr<CefValue> value)
        /// <summary>
        /// Sets the value at the specified key. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// /*cef()*/
        /// </summary>

        public bool SetValue(string key,
        CefValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetValue_21, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 645

        // gen! bool SetNull(const CefString& key)
        /// <summary>
        /// Sets the value at the specified key as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetNull(string key)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_SetNull_22, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 646

        // gen! bool SetBool(const CefString& key,bool value)
        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetBool(string key,
        bool value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBool_23, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 647

        // gen! bool SetInt(const CefString& key,int value)
        /// <summary>
        /// Sets the value at the specified key as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetInt(string key,
        int value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.I32 = (int)value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetInt_24, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 648

        // gen! bool SetDouble(const CefString& key,double value)
        /// <summary>
        /// Sets the value at the specified key as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetDouble(string key,
        double value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Num = value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDouble_25, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 649

        // gen! bool SetString(const CefString& key,const CefString& value)
        /// <summary>
        /// Sets the value at the specified key as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetString(string key,
        string value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(value);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetString_26, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 650

        // gen! bool SetBinary(const CefString& key,CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the value at the specified key as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetBinary(string key,
        CefBinaryValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBinary_27, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 651

        // gen! bool SetDictionary(const CefString& key,CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the value at the specified key as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetDictionary(string key,
        CefDictionaryValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDictionary_28, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 652

        // gen! bool SetList(const CefString& key,CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the value at the specified key as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetList(string key,
        CefListValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(key);
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetList_29, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 653

        // gen! CefRefPtr<CefDictionaryValue> Create()
        /// <summary>
        /// Creates a new object that is not owned by any other object.
        /// /*cef()*/
        /// </summary>

        public static CefDictionaryValue Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefDictionaryValue_S_Create_1, out ret);
            return new CefDictionaryValue(ret.Ptr);
        }
    }


    // [virtual] class CefListValue
    //CsCallToNativeCodeGen::GenerateCsCode , 654
    /// <summary>
    /// Class representing a list value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefListValue : IDisposable
    {
        const int _typeNAME = 49;
        const int CefListValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefListValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefListValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefListValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        const int CefListValue_IsSame_4 = (_typeNAME << 16) | 4;
        const int CefListValue_IsEqual_5 = (_typeNAME << 16) | 5;
        const int CefListValue_Copy_6 = (_typeNAME << 16) | 6;
        const int CefListValue_SetSize_7 = (_typeNAME << 16) | 7;
        const int CefListValue_GetSize_8 = (_typeNAME << 16) | 8;
        const int CefListValue_Clear_9 = (_typeNAME << 16) | 9;
        const int CefListValue_Remove_10 = (_typeNAME << 16) | 10;
        const int CefListValue_GetType_11 = (_typeNAME << 16) | 11;
        const int CefListValue_GetValue_12 = (_typeNAME << 16) | 12;
        const int CefListValue_GetBool_13 = (_typeNAME << 16) | 13;
        const int CefListValue_GetInt_14 = (_typeNAME << 16) | 14;
        const int CefListValue_GetDouble_15 = (_typeNAME << 16) | 15;
        const int CefListValue_GetString_16 = (_typeNAME << 16) | 16;
        const int CefListValue_GetBinary_17 = (_typeNAME << 16) | 17;
        const int CefListValue_GetDictionary_18 = (_typeNAME << 16) | 18;
        const int CefListValue_GetList_19 = (_typeNAME << 16) | 19;
        const int CefListValue_SetValue_20 = (_typeNAME << 16) | 20;
        const int CefListValue_SetNull_21 = (_typeNAME << 16) | 21;
        const int CefListValue_SetBool_22 = (_typeNAME << 16) | 22;
        const int CefListValue_SetInt_23 = (_typeNAME << 16) | 23;
        const int CefListValue_SetDouble_24 = (_typeNAME << 16) | 24;
        const int CefListValue_SetString_25 = (_typeNAME << 16) | 25;
        const int CefListValue_SetBinary_26 = (_typeNAME << 16) | 26;
        const int CefListValue_SetDictionary_27 = (_typeNAME << 16) | 27;
        const int CefListValue_SetList_28 = (_typeNAME << 16) | 28;
        //
        const int CefListValue_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefListValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 655

        // gen! bool IsValid()
        /// <summary>
        /// CefListValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsValid_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 656

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsOwned_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 657

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsReadOnly_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 658

        // gen! bool IsSame(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefListValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsSame_4, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 659

        // gen! bool IsEqual(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefListValue that)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsEqual_5, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 660

        // gen! CefRefPtr<CefListValue> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefListValue Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Copy_6, out ret);
            return new CefListValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 661

        // gen! bool SetSize(size_t size)
        /// <summary>
        /// Sets the number of values. If the number of values is expanded all
        /// new value slots will default to type null. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetSize(uint size)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetSize_7, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 662

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>

        public uint GetSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_GetSize_8, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 663

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Clear()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Clear_9, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 664

        // gen! bool Remove(size_t index)
        /// <summary>
        /// Removes the value at the specified index.
        /// /*cef()*/
        /// </summary>

        public bool Remove(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_Remove_10, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 665

        // gen! CefValueType GetType(size_t index)
        /// <summary>
        /// Returns the value type at the specified index.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>

        public cef_value_type_t _GetType(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetType_11, out ret, ref v1);
            return (cef_value_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 666

        // gen! CefRefPtr<CefValue> GetValue(size_t index)
        /// <summary>
        /// Returns the value at the specified index. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// /*cef()*/
        /// </summary>

        public CefValue GetValue(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetValue_12, out ret, ref v1);
            return new CefValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 667

        // gen! bool GetBool(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// /*cef()*/
        /// </summary>

        public bool GetBool(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBool_13, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 668

        // gen! int GetInt(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type int.
        /// /*cef()*/
        /// </summary>

        public int GetInt(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetInt_14, out ret, ref v1);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 669

        // gen! double GetDouble(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type double.
        /// /*cef()*/
        /// </summary>

        public double GetDouble(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDouble_15, out ret, ref v1);
            return ret.Num;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 670

        // gen! CefString GetString(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type string.
        /// /*cef()*/
        /// </summary>

        public string GetString(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetString_16, out ret, ref v1);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 671

        // gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetBinary(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBinary_17, out ret, ref v1);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 672

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetDictionary(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDictionary_18, out ret, ref v1);
            return new CefDictionaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 673

        // gen! CefRefPtr<CefListValue> GetList(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type list. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>

        public CefListValue GetList(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetList_19, out ret, ref v1);
            return new CefListValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 674

        // gen! bool SetValue(size_t index,CefRefPtr<CefValue> value)
        /// <summary>
        /// Sets the value at the specified index. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// /*cef()*/
        /// </summary>

        public bool SetValue(uint index,
        CefValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetValue_20, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 675

        // gen! bool SetNull(size_t index)
        /// <summary>
        /// Sets the value at the specified index as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetNull(uint index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetNull_21, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 676

        // gen! bool SetBool(size_t index,bool value)
        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetBool(uint index,
        bool value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBool_22, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 677

        // gen! bool SetInt(size_t index,int value)
        /// <summary>
        /// Sets the value at the specified index as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetInt(uint index,
        int value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetInt_23, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 678

        // gen! bool SetDouble(size_t index,double value)
        /// <summary>
        /// Sets the value at the specified index as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetDouble(uint index,
        double value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Num = value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDouble_24, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 679

        // gen! bool SetString(size_t index,const CefString& value)
        /// <summary>
        /// Sets the value at the specified index as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetString(uint index,
        string value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(value);
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetString_25, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 680

        // gen! bool SetBinary(size_t index,CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the value at the specified index as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetBinary(uint index,
        CefBinaryValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBinary_26, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 681

        // gen! bool SetDictionary(size_t index,CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the value at the specified index as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetDictionary(uint index,
        CefDictionaryValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDictionary_27, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 682

        // gen! bool SetList(size_t index,CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the value at the specified index as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetList(uint index,
        CefListValue value)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetList_28, out ret, ref v1, ref v2);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 683

        // gen! CefRefPtr<CefListValue> Create()
        /// <summary>
        /// Creates a new object that is not owned by any other object.
        /// /*cef()*/
        /// </summary>

        public static CefListValue Create()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_S_Call0(CefListValue_S_Create_1, out ret);
            return new CefListValue(ret.Ptr);
        }
    }


    // [virtual] class CefWebPluginInfo
    //CsCallToNativeCodeGen::GenerateCsCode , 684
    /// <summary>
    /// Information about a specific web plugin.
    /// /*(source=library)*/
    /// </summary>
    public struct CefWebPluginInfo : IDisposable
    {
        const int _typeNAME = 50;
        const int CefWebPluginInfo_Release_0 = (_typeNAME << 16) | 0;
        const int CefWebPluginInfo_GetName_1 = (_typeNAME << 16) | 1;
        const int CefWebPluginInfo_GetPath_2 = (_typeNAME << 16) | 2;
        const int CefWebPluginInfo_GetVersion_3 = (_typeNAME << 16) | 3;
        const int CefWebPluginInfo_GetDescription_4 = (_typeNAME << 16) | 4;
        internal IntPtr nativePtr;
        internal CefWebPluginInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 685

        // gen! CefString GetName()
        /// <summary>
        /// CefWebPluginInfo methods.
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetName_1, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 686

        // gen! CefString GetPath()
        /// <summary>
        /// Returns the plugin file path (DLL/bundle/library).
        /// /*cef()*/
        /// </summary>

        public string GetPath()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetPath_2, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 687

        // gen! CefString GetVersion()
        /// <summary>
        /// Returns the version of the plugin (may be OS-specific).
        /// /*cef()*/
        /// </summary>

        public string GetVersion()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetVersion_3, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 688

        // gen! CefString GetDescription()
        /// <summary>
        /// Returns a description of the plugin from the version information.
        /// /*cef()*/
        /// </summary>

        public string GetDescription()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetDescription_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
    }


    // [virtual] class CefWebPluginInfoVisitor
    //CsCallToNativeCodeGen::GenerateCsCode , 689
    /// <summary>
    /// Interface to implement for visiting web plugin information. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefWebPluginInfoVisitor : IDisposable
    {
        const int _typeNAME = 51;
        const int CefWebPluginInfoVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefWebPluginInfoVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfoVisitor_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        public static CefWebPluginInfoVisitor New(MyCefCallback callback)
        {
            JsValue not_used = new JsValue();
            return new CefWebPluginInfoVisitor(Cef3Binder.NewInstance(_typeNAME, callback, ref not_used));
        }
        //CsStructModuleCodeGen:: GenerateCsStructClass ,362
        const int MyCefWebPluginInfoVisitor_Visit_1 = 1;
        //gen! bool Visit(CefRefPtr<CefWebPluginInfo> info,int count,int total)
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass ,363
        /// <summary>
        /// Method that will be called once for each plugin. |count| is the 0-based
        /// index for the current plugin. |total| is the total number of plugins.
        /// Return false to stop visiting plugins. This method may never be called if
        /// no plugins are found.
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
            public CefWebPluginInfo info()
            {
                unsafe
                {
                    return new CefWebPluginInfo(((VisitNativeArgs*)this.nativePtr)->info);
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
        }
        //CsStructModuleCodeGen:: GenerateCsMethodArgsClass_Native ,364
        [StructLayout(LayoutKind.Sequential)]
        unsafe struct VisitNativeArgs
        {
            public int argFlags;
            public bool myext_ret_value;
            public IntPtr info;
            public int count;
            public int total;
        }
        public interface I0
        {
            //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForInterface ,365
            /// <summary>
            /// Method that will be called once for each plugin. |count| is the 0-based
            /// index for the current plugin. |total| is the total number of plugins.
            /// Return false to stop visiting plugins. This method may never be called if
            /// no plugins are found.
            /// /*cef()*/
            /// </summary>
            void Visit(VisitArgs args);
        }
        public interface I1
        {
            //CsStructModuleCodeGen:: GenerateCsExpandedArgsMethodForInterface ,366
            /// <summary>
            /// Method that will be called once for each plugin. |count| is the 0-based
            /// index for the current plugin. |total| is the total number of plugins.
            /// Return false to stop visiting plugins. This method may never be called if
            /// no plugins are found.
            /// /*cef()*/
            /// </summary>
            bool Visit(CefWebPluginInfo info, int count, int total);
        }
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable ,367
        public static void HandleNativeReq(I0 i0, I1 i1, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            switch (met_name)
            {
                //CsStructModuleCodeGen:: HandleNativeReq ,368
                case MyCefWebPluginInfoVisitor_Visit_1:
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
        //CsStructModuleCodeGen::GenerateHandleNativeReqTable_I0 ,369
        public static void HandleNativeReq_I0(I0 i0, int met_id, IntPtr nativeArgPtr)
        {
            int met_name = met_id & 0xffff;
            if (i0 == null) return;
            switch (met_name)
            {
                case MyCefWebPluginInfoVisitor_Visit_1:
                    i0.Visit(new VisitArgs(nativeArgPtr));
                    break;
            }
        }
        //CsStructModuleCodeGen:: GenerateCsSingleArgMethodImplForI1 ,370
        public static void Visit(I1 i1, VisitArgs args)
        {
            //CsStructModuleCodeGen:: GenerateCsExpandMethodContent ,371
            args.myext_setRetValue(i1.Visit(args.info(),
            args.count(),
            args.total()));
        }
    }


    // [virtual] class CefX509CertPrincipal
    //CsCallToNativeCodeGen::GenerateCsCode , 690
    /// <summary>
    /// Class representing the issuer or subject field of an X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    public struct CefX509CertPrincipal : IDisposable
    {
        const int _typeNAME = 52;
        const int CefX509CertPrincipal_Release_0 = (_typeNAME << 16) | 0;
        const int CefX509CertPrincipal_GetDisplayName_1 = (_typeNAME << 16) | 1;
        const int CefX509CertPrincipal_GetCommonName_2 = (_typeNAME << 16) | 2;
        const int CefX509CertPrincipal_GetLocalityName_3 = (_typeNAME << 16) | 3;
        const int CefX509CertPrincipal_GetStateOrProvinceName_4 = (_typeNAME << 16) | 4;
        const int CefX509CertPrincipal_GetCountryName_5 = (_typeNAME << 16) | 5;
        const int CefX509CertPrincipal_GetStreetAddresses_6 = (_typeNAME << 16) | 6;
        const int CefX509CertPrincipal_GetOrganizationNames_7 = (_typeNAME << 16) | 7;
        const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = (_typeNAME << 16) | 8;
        const int CefX509CertPrincipal_GetDomainComponents_9 = (_typeNAME << 16) | 9;
        internal IntPtr nativePtr;
        internal CefX509CertPrincipal(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 691

        // gen! CefString GetDisplayName()
        /// <summary>
        /// CefX509CertPrincipal methods.
        /// </summary>

        public string GetDisplayName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetDisplayName_1, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 692

        // gen! CefString GetCommonName()
        /// <summary>
        /// Returns the common name.
        /// /*cef()*/
        /// </summary>

        public string GetCommonName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCommonName_2, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 693

        // gen! CefString GetLocalityName()
        /// <summary>
        /// Returns the locality name.
        /// /*cef()*/
        /// </summary>

        public string GetLocalityName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetLocalityName_3, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 694

        // gen! CefString GetStateOrProvinceName()
        /// <summary>
        /// Returns the state or province name.
        /// /*cef()*/
        /// </summary>

        public string GetStateOrProvinceName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetStateOrProvinceName_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 695

        // gen! CefString GetCountryName()
        /// <summary>
        /// Returns the country name.
        /// /*cef()*/
        /// </summary>

        public string GetCountryName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCountryName_5, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 696

        // gen! void GetStreetAddresses(std::vector<CefString>& addresses)
        /// <summary>
        /// Retrieve the list of street addresses.
        /// /*cef()*/
        /// </summary>

        public void GetStreetAddresses(List<string> addresses)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetStreetAddresses_6, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, addresses);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 697

        // gen! void GetOrganizationNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization names.
        /// /*cef()*/
        /// </summary>

        public void GetOrganizationNames(List<string> names)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationNames_7, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 698

        // gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization unit names.
        /// /*cef()*/
        /// </summary>

        public void GetOrganizationUnitNames(List<string> names)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationUnitNames_8, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 699

        // gen! void GetDomainComponents(std::vector<CefString>& components)
        /// <summary>
        /// Retrieve the list of domain components.
        /// /*cef()*/
        /// </summary>

        public void GetDomainComponents(List<string> components)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetDomainComponents_9, out ret, ref v1);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, components);

        }
    }


    // [virtual] class CefX509Certificate
    //CsCallToNativeCodeGen::GenerateCsCode , 700
    /// <summary>
    /// Class representing a X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    public struct CefX509Certificate : IDisposable
    {
        const int _typeNAME = 53;
        const int CefX509Certificate_Release_0 = (_typeNAME << 16) | 0;
        const int CefX509Certificate_GetSubject_1 = (_typeNAME << 16) | 1;
        const int CefX509Certificate_GetIssuer_2 = (_typeNAME << 16) | 2;
        const int CefX509Certificate_GetSerialNumber_3 = (_typeNAME << 16) | 3;
        const int CefX509Certificate_GetValidStart_4 = (_typeNAME << 16) | 4;
        const int CefX509Certificate_GetValidExpiry_5 = (_typeNAME << 16) | 5;
        const int CefX509Certificate_GetDEREncoded_6 = (_typeNAME << 16) | 6;
        const int CefX509Certificate_GetPEMEncoded_7 = (_typeNAME << 16) | 7;
        const int CefX509Certificate_GetIssuerChainSize_8 = (_typeNAME << 16) | 8;
        const int CefX509Certificate_GetDEREncodedIssuerChain_9 = (_typeNAME << 16) | 9;
        const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = (_typeNAME << 16) | 10;
        internal IntPtr nativePtr;
        internal CefX509Certificate(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 701

        // gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
        /// <summary>
        /// CefX509Certificate methods.
        /// </summary>

        public CefX509CertPrincipal GetSubject()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSubject_1, out ret);
            return new CefX509CertPrincipal(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 702

        // gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
        /// <summary>
        /// Returns the issuer of the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefX509CertPrincipal GetIssuer()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuer_2, out ret);
            return new CefX509CertPrincipal(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 703

        // gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
        /// <summary>
        /// Returns the DER encoded serial number for the X.509 certificate. The value
        /// possibly includes a leading 00 byte.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetSerialNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSerialNumber_3, out ret);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 704

        // gen! CefTime GetValidStart()
        /// <summary>
        /// Returns the date before which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>

        public CefTime GetValidStart()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidStart_4, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 705

        // gen! CefTime GetValidExpiry()
        /// <summary>
        /// Returns the date after which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>

        public CefTime GetValidExpiry()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidExpiry_5, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 706

        // gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
        /// <summary>
        /// Returns the DER encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetDEREncoded()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetDEREncoded_6, out ret);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 707

        // gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
        /// <summary>
        /// Returns the PEM encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetPEMEncoded()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetPEMEncoded_7, out ret);
            return new CefBinaryValue(ret.Ptr);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 708

        // gen! size_t GetIssuerChainSize()
        /// <summary>
        /// Returns the number of certificates in the issuer chain.
        /// If 0, the certificate is self-signed.
        /// /*cef()*/
        /// </summary>

        public uint GetIssuerChainSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuerChainSize_8, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 709

        // gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the DER encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>

        public void GetDEREncodedIssuerChain(IssuerChainBinaryList chain)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = chain.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetDEREncodedIssuerChain_9, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 710

        // gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the PEM encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>

        public void GetPEMEncodedIssuerChain(IssuerChainBinaryList chain)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = chain.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetPEMEncodedIssuerChain_10, out ret, ref v1);

        }
    }


    // [virtual] class CefXmlReader
    //CsCallToNativeCodeGen::GenerateCsCode , 711
    /// <summary>
    /// Class that supports the reading of XML data via the libxml streaming API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    public struct CefXmlReader : IDisposable
    {
        const int _typeNAME = 54;
        const int CefXmlReader_Release_0 = (_typeNAME << 16) | 0;
        const int CefXmlReader_MoveToNextNode_1 = (_typeNAME << 16) | 1;
        const int CefXmlReader_Close_2 = (_typeNAME << 16) | 2;
        const int CefXmlReader_HasError_3 = (_typeNAME << 16) | 3;
        const int CefXmlReader_GetError_4 = (_typeNAME << 16) | 4;
        const int CefXmlReader_GetType_5 = (_typeNAME << 16) | 5;
        const int CefXmlReader_GetDepth_6 = (_typeNAME << 16) | 6;
        const int CefXmlReader_GetLocalName_7 = (_typeNAME << 16) | 7;
        const int CefXmlReader_GetPrefix_8 = (_typeNAME << 16) | 8;
        const int CefXmlReader_GetQualifiedName_9 = (_typeNAME << 16) | 9;
        const int CefXmlReader_GetNamespaceURI_10 = (_typeNAME << 16) | 10;
        const int CefXmlReader_GetBaseURI_11 = (_typeNAME << 16) | 11;
        const int CefXmlReader_GetXmlLang_12 = (_typeNAME << 16) | 12;
        const int CefXmlReader_IsEmptyElement_13 = (_typeNAME << 16) | 13;
        const int CefXmlReader_HasValue_14 = (_typeNAME << 16) | 14;
        const int CefXmlReader_GetValue_15 = (_typeNAME << 16) | 15;
        const int CefXmlReader_HasAttributes_16 = (_typeNAME << 16) | 16;
        const int CefXmlReader_GetAttributeCount_17 = (_typeNAME << 16) | 17;
        const int CefXmlReader_GetAttribute_18 = (_typeNAME << 16) | 18;
        const int CefXmlReader_GetAttribute_19 = (_typeNAME << 16) | 19;
        const int CefXmlReader_GetAttribute_20 = (_typeNAME << 16) | 20;
        const int CefXmlReader_GetInnerXml_21 = (_typeNAME << 16) | 21;
        const int CefXmlReader_GetOuterXml_22 = (_typeNAME << 16) | 22;
        const int CefXmlReader_GetLineNumber_23 = (_typeNAME << 16) | 23;
        const int CefXmlReader_MoveToAttribute_24 = (_typeNAME << 16) | 24;
        const int CefXmlReader_MoveToAttribute_25 = (_typeNAME << 16) | 25;
        const int CefXmlReader_MoveToAttribute_26 = (_typeNAME << 16) | 26;
        const int CefXmlReader_MoveToFirstAttribute_27 = (_typeNAME << 16) | 27;
        const int CefXmlReader_MoveToNextAttribute_28 = (_typeNAME << 16) | 28;
        const int CefXmlReader_MoveToCarryingElement_29 = (_typeNAME << 16) | 29;
        //
        const int CefXmlReader_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefXmlReader(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 712

        // gen! bool MoveToNextNode()
        /// <summary>
        /// CefXmlReader methods.
        /// </summary>

        public bool MoveToNextNode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextNode_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 713

        // gen! bool Close()
        /// <summary>
        /// Close the document. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>

        public bool Close()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Close_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 714

        // gen! bool HasError()
        /// <summary>
        /// Returns true if an error has been reported by the XML parser.
        /// /*cef()*/
        /// </summary>

        public bool HasError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasError_3, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 715

        // gen! CefString GetError()
        /// <summary>
        /// Returns the error string.
        /// /*cef()*/
        /// </summary>

        public string GetError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetError_4, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 716

        // gen! NodeType GetType()
        /// <summary>
        /// The below methods retrieve data for the node at the current cursor
        /// position.
        /// Returns the node type.
        /// /*cef(default_retval=XML_NODE_UNSUPPORTED)*/
        /// </summary>

        public cef_xml_node_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetType_5, out ret);
            return (cef_xml_node_type_t)ret.I32;

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 717

        // gen! int GetDepth()
        /// <summary>
        /// Returns the node depth. Depth starts at 0 for the root node.
        /// /*cef()*/
        /// </summary>

        public int GetDepth()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetDepth_6, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 718

        // gen! CefString GetLocalName()
        /// <summary>
        /// Returns the local name. See
        /// http://www.w3.org/TR/REC-xml-names/#NT-LocalPart for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetLocalName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLocalName_7, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 719

        // gen! CefString GetPrefix()
        /// <summary>
        /// Returns the namespace prefix. See http://www.w3.org/TR/REC-xml-names/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>

        public string GetPrefix()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetPrefix_8, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 720

        // gen! CefString GetQualifiedName()
        /// <summary>
        /// Returns the qualified name, equal to (Prefix:)LocalName. See
        /// http://www.w3.org/TR/REC-xml-names/#ns-qualnames for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetQualifiedName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetQualifiedName_9, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 721

        // gen! CefString GetNamespaceURI()
        /// <summary>
        /// Returns the URI defining the namespace associated with the node. See
        /// http://www.w3.org/TR/REC-xml-names/ for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetNamespaceURI()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetNamespaceURI_10, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 722

        // gen! CefString GetBaseURI()
        /// <summary>
        /// Returns the base URI of the node. See http://www.w3.org/TR/xmlbase/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>

        public string GetBaseURI()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetBaseURI_11, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 723

        // gen! CefString GetXmlLang()
        /// <summary>
        /// Returns the xml:lang scope within which the node resides. See
        /// http://www.w3.org/TR/REC-xml/#sec-lang-tag for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetXmlLang()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetXmlLang_12, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 724

        // gen! bool IsEmptyElement()
        /// <summary>
        /// Returns true if the node represents an empty element. <a/> is considered
        /// empty but <a></a> is not.
        /// /*cef()*/
        /// </summary>

        public bool IsEmptyElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_IsEmptyElement_13, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 725

        // gen! bool HasValue()
        /// <summary>
        /// Returns true if the node has a text value.
        /// /*cef()*/
        /// </summary>

        public bool HasValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasValue_14, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 726

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the text value.
        /// /*cef()*/
        /// </summary>

        public string GetValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetValue_15, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 727

        // gen! bool HasAttributes()
        /// <summary>
        /// Returns true if the node has attributes.
        /// /*cef()*/
        /// </summary>

        public bool HasAttributes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasAttributes_16, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 728

        // gen! size_t GetAttributeCount()
        /// <summary>
        /// Returns the number of attributes.
        /// /*cef()*/
        /// </summary>

        public uint GetAttributeCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetAttributeCount_17, out ret);
            return (uint)ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 729

        // gen! CefString GetAttribute(int index)

        public string GetAttribute(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_18, out ret, ref v1);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 730

        // gen! CefString GetAttribute(const CefString& qualifiedName)

        public string GetAttribute(string qualifiedName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(qualifiedName);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_19, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 731

        // gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)

        public string GetAttribute(string localName,
        string namespaceURI)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(localName);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(namespaceURI);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_GetAttribute_20, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 732

        // gen! CefString GetInnerXml()
        /// <summary>
        /// Returns an XML representation of the current node's children.
        /// /*cef()*/
        /// </summary>

        public string GetInnerXml()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetInnerXml_21, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 733

        // gen! CefString GetOuterXml()
        /// <summary>
        /// Returns an XML representation of the current node including its children.
        /// /*cef()*/
        /// </summary>

        public string GetOuterXml()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetOuterXml_22, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 734

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the line number for the current node.
        /// /*cef()*/
        /// </summary>

        public int GetLineNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLineNumber_23, out ret);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 735

        // gen! bool MoveToAttribute(int index)

        public bool MoveToAttribute(int index)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_24, out ret, ref v1);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 736

        // gen! bool MoveToAttribute(const CefString& qualifiedName)

        public bool MoveToAttribute(string qualifiedName)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(qualifiedName);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_25, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 737

        // gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)

        public bool MoveToAttribute(string localName,
        string namespaceURI)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(localName);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(namespaceURI);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_MoveToAttribute_26, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 738

        // gen! bool MoveToFirstAttribute()
        /// <summary>
        /// Moves the cursor to the first attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToFirstAttribute()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToFirstAttribute_27, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 739

        // gen! bool MoveToNextAttribute()
        /// <summary>
        /// Moves the cursor to the next attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToNextAttribute()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextAttribute_28, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 740

        // gen! bool MoveToCarryingElement()
        /// <summary>
        /// Moves the cursor back to the carrying element. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToCarryingElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToCarryingElement_29, out ret);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 741

        // gen! CefRefPtr<CefXmlReader> Create(CefRefPtr<CefStreamReader> stream,EncodingType encodingType,const CefString& URI)
        /// <summary>
        /// Create a new CefXmlReader object. The returned object's methods can only
        /// be called from the thread that created the object.
        /// /*cef()*/
        /// </summary>

        public static CefXmlReader Create(CefStreamReader stream,
        cef_xml_encoding_type_t encodingType,
        string URI)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateStringHolder(URI);
            v1.Ptr = stream.nativePtr;
            v2.I32 = (int)encodingType;

            Cef3Binder.MyCefMet_S_Call3(CefXmlReader_S_Create_1, out ret, ref v1, ref v2, ref v3);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);
            return new CefXmlReader(ret.Ptr);
        }
    }


    // [virtual] class CefZipReader
    //CsCallToNativeCodeGen::GenerateCsCode , 742
    /// <summary>
    /// Class that supports the reading of zip archives via the zlib unzip API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    public struct CefZipReader : IDisposable
    {
        const int _typeNAME = 55;
        const int CefZipReader_Release_0 = (_typeNAME << 16) | 0;
        const int CefZipReader_MoveToFirstFile_1 = (_typeNAME << 16) | 1;
        const int CefZipReader_MoveToNextFile_2 = (_typeNAME << 16) | 2;
        const int CefZipReader_MoveToFile_3 = (_typeNAME << 16) | 3;
        const int CefZipReader_Close_4 = (_typeNAME << 16) | 4;
        const int CefZipReader_GetFileName_5 = (_typeNAME << 16) | 5;
        const int CefZipReader_GetFileSize_6 = (_typeNAME << 16) | 6;
        const int CefZipReader_GetFileLastModified_7 = (_typeNAME << 16) | 7;
        const int CefZipReader_OpenFile_8 = (_typeNAME << 16) | 8;
        const int CefZipReader_CloseFile_9 = (_typeNAME << 16) | 9;
        const int CefZipReader_ReadFile_10 = (_typeNAME << 16) | 10;
        const int CefZipReader_Tell_11 = (_typeNAME << 16) | 11;
        const int CefZipReader_Eof_12 = (_typeNAME << 16) | 12;
        //
        const int CefZipReader_S_Create_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefZipReader(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 743

        // gen! bool MoveToFirstFile()
        /// <summary>
        /// CefZipReader methods.
        /// </summary>

        public bool MoveToFirstFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToFirstFile_1, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 744

        // gen! bool MoveToNextFile()
        /// <summary>
        /// Moves the cursor to the next file in the archive. Returns true if the
        /// cursor position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToNextFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToNextFile_2, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 745

        // gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
        /// <summary>
        /// Moves the cursor to the specified file in the archive. If |caseSensitive|
        /// is true then the search will be case sensitive. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToFile(string fileName,
        bool caseSensitive)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(fileName);
            v2.I32 = caseSensitive ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_MoveToFile_3, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 746

        // gen! bool Close()
        /// <summary>
        /// Closes the archive. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>

        public bool Close()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Close_4, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 747

        // gen! CefString GetFileName()
        /// <summary>
        /// The below methods act on the file at the current cursor position.
        /// Returns the name of the file.
        /// /*cef()*/
        /// </summary>

        public string GetFileName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileName_5, out ret);
            return Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 748

        // gen! int64 GetFileSize()
        /// <summary>
        /// Returns the uncompressed size of the file.
        /// /*cef()*/
        /// </summary>

        public long GetFileSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileSize_6, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 749

        // gen! CefTime GetFileLastModified()
        /// <summary>
        /// Returns the last modified timestamp for the file.
        /// /*cef()*/
        /// </summary>

        public CefTime GetFileLastModified()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileLastModified_7, out ret);
            return new CefTime(ret.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 750

        // gen! bool OpenFile(const CefString& password)
        /// <summary>
        /// Opens the file for reading of uncompressed data. A read password may
        /// optionally be specified.
        /// /*cef(optional_param=password)*/
        /// </summary>

        public bool OpenFile(string password)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(password);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefZipReader_OpenFile_8, out ret, ref v1);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 751

        // gen! bool CloseFile()
        /// <summary>
        /// Closes the file.
        /// /*cef()*/
        /// </summary>

        public bool CloseFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_CloseFile_9, out ret);
            return ret.I32 != 0;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 752

        // gen! int ReadFile(void* buffer,size_t bufferSize)
        /// <summary>
        /// Read uncompressed file contents into the specified buffer. Returns < 0 if
        /// an error occurred, 0 if at the end of file, or the number of bytes read.
        /// /*cef()*/
        /// </summary>

        public int ReadFile(IntPtr buffer,
        uint bufferSize)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = buffer;
            v2.I32 = (int)bufferSize;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_ReadFile_10, out ret, ref v1, ref v2);
            return ret.I32;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 753

        // gen! int64 Tell()
        /// <summary>
        /// Returns the current offset in the uncompressed file contents.
        /// /*cef()*/
        /// </summary>

        public long Tell()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Tell_11, out ret);
            return ret.I64;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 754

        // gen! bool Eof()
        /// <summary>
        /// Returns true if at end of the file contents.
        /// /*cef()*/
        /// </summary>

        public bool Eof()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Eof_12, out ret);
            return ret.I32 != 0;
        }
        //
        //CsCallToNativeCodeGen::GenerateCs_S_Method , 755

        // gen! CefRefPtr<CefZipReader> Create(CefRefPtr<CefStreamReader> stream)
        /// <summary>
        /// Create a new CefZipReader object. The returned object's methods can only
        /// be called from the thread that created the object.
        /// /*cef()*/
        /// </summary>

        public static CefZipReader Create(CefStreamReader stream)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = stream.nativePtr;

            Cef3Binder.MyCefMet_S_Call1(CefZipReader_S_Create_1, out ret, ref v1);
            return new CefZipReader(ret.Ptr);
        }
    }

}