//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    //CsCallToNativeCodeGen::GenerateCsCode , 756
    /// <summary>
    /// Callback interface used for asynchronous continuation of authentication
    /// requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefAuthCallback : IDisposable
    {
        const int _typeNAME = 80;
        const int CefAuthCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefAuthCallback_Continue_1 = (_typeNAME << 16) | 1;
        const int CefAuthCallback_Cancel_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefAuthCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefAuthCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 757

        // gen! void Continue(const CefString& username,const CefString& password)
        /// <summary>
        /// CefAuthCallback methods.
        /// </summary>

        public void Continue(string username,
        string password)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(username);
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(password);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefAuthCallback_Continue_1, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 758

        // gen! void Cancel()

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefAuthCallback_Cancel_2, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 759
    /// <summary>
    /// Callback interface for CefBrowserHost::RunFileDialog. The methods of this
    /// class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefRunFileDialogCallback : IDisposable
    {
        const int _typeNAME = 81;
        const int CefRunFileDialogCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefRunFileDialogCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRunFileDialogCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 760
    /// <summary>
    /// Callback interface for CefBrowserHost::PrintToPDF. The methods of this class
    /// will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefPdfPrintCallback : IDisposable
    {
        const int _typeNAME = 82;
        const int CefPdfPrintCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefPdfPrintCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPdfPrintCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 761
    /// <summary>
    /// Callback interface for CefBrowserHost::DownloadImage. The methods of this
    /// class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefDownloadImageCallback : IDisposable
    {
        const int _typeNAME = 83;
        const int CefDownloadImageCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefDownloadImageCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadImageCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 762
    /// <summary>
    /// Generic callback interface used for asynchronous continuation.
    /// /*(source=library)*/
    /// </summary>
    public struct CefCallback : IDisposable
    {
        const int _typeNAME = 84;
        const int CefCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefCallback_Continue_1 = (_typeNAME << 16) | 1;
        const int CefCallback_Cancel_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 763

        // gen! void Continue()
        /// <summary>
        /// CefCallback methods.
        /// </summary>

        public void Continue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCallback_Continue_1, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 764

        // gen! void Cancel()

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCallback_Cancel_2, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 765
    /// <summary>
    /// Generic callback interface used for asynchronous completion.
    /// /*(source=client)*/
    /// </summary>
    public struct CefCompletionCallback : IDisposable
    {
        const int _typeNAME = 85;
        const int CefCompletionCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefCompletionCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCompletionCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 766
    /// <summary>
    /// Callback interface used for continuation of custom context menu display.
    /// /*(source=library)*/
    /// </summary>
    public struct CefRunContextMenuCallback : IDisposable
    {
        const int _typeNAME = 86;
        const int CefRunContextMenuCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefRunContextMenuCallback_Continue_1 = (_typeNAME << 16) | 1;
        const int CefRunContextMenuCallback_Cancel_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefRunContextMenuCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRunContextMenuCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 767

        // gen! void Continue(int command_id,EventFlags event_flags)
        /// <summary>
        /// CefRunContextMenuCallback methods.
        /// </summary>

        public void Continue(int command_id,
        cef_event_flags_t event_flags)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)event_flags;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRunContextMenuCallback_Continue_1, out ret, ref v1, ref v2);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 768

        // gen! void Cancel()

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRunContextMenuCallback_Cancel_2, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 769
    /// <summary>
    /// Interface to implement to be notified of asynchronous completion via
    /// CefCookieManager::SetCookie().
    /// /*(source=client)*/
    /// </summary>
    public struct CefSetCookieCallback : IDisposable
    {
        const int _typeNAME = 87;
        const int CefSetCookieCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefSetCookieCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSetCookieCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 770
    /// <summary>
    /// Interface to implement to be notified of asynchronous completion via
    /// CefCookieManager::DeleteCookies().
    /// /*(source=client)*/
    /// </summary>
    public struct CefDeleteCookiesCallback : IDisposable
    {
        const int _typeNAME = 88;
        const int CefDeleteCookiesCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefDeleteCookiesCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDeleteCookiesCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 771
    /// <summary>
    /// Callback interface for asynchronous continuation of file dialog requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefFileDialogCallback : IDisposable
    {
        const int _typeNAME = 89;
        const int CefFileDialogCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefFileDialogCallback_Continue_1 = (_typeNAME << 16) | 1;
        const int CefFileDialogCallback_Cancel_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefFileDialogCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFileDialogCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 772

        // gen! void Continue(int selected_accept_filter,const std::vector<CefString>& file_paths)
        /// <summary>
        /// CefFileDialogCallback methods.
        /// </summary>

        public void Continue(int selected_accept_filter,
        List<string> file_paths)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)selected_accept_filter;
            v2.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefFileDialogCallback_Continue_1, out ret, ref v1, ref v2);
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v2.Ptr, file_paths);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 773

        // gen! void Cancel()

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFileDialogCallback_Cancel_2, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 774
    /// <summary>
    /// Callback interface used to asynchronously continue a download.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBeforeDownloadCallback : IDisposable
    {
        const int _typeNAME = 90;
        const int CefBeforeDownloadCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefBeforeDownloadCallback_Continue_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefBeforeDownloadCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBeforeDownloadCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 775

        // gen! void Continue(const CefString& download_path,bool show_dialog)
        /// <summary>
        /// CefBeforeDownloadCallback methods.
        /// </summary>

        public void Continue(string download_path,
        bool show_dialog)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateStringHolder(download_path);
            v2.I32 = show_dialog ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBeforeDownloadCallback_Continue_1, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 776
    /// <summary>
    /// Callback interface used to asynchronously cancel a download.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDownloadItemCallback : IDisposable
    {
        const int _typeNAME = 91;
        const int CefDownloadItemCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefDownloadItemCallback_Cancel_1 = (_typeNAME << 16) | 1;
        const int CefDownloadItemCallback_Pause_2 = (_typeNAME << 16) | 2;
        const int CefDownloadItemCallback_Resume_3 = (_typeNAME << 16) | 3;
        internal IntPtr nativePtr;
        internal CefDownloadItemCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItemCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 777

        // gen! void Cancel()
        /// <summary>
        /// CefDownloadItemCallback methods.
        /// </summary>

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItemCallback_Cancel_1, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 778

        // gen! void Pause()

        public void Pause()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItemCallback_Pause_2, out ret);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 779

        // gen! void Resume()

        public void Resume()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItemCallback_Resume_3, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 780
    /// <summary>
    /// Implement this interface to receive geolocation updates. The methods of this
    /// class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefGetGeolocationCallback : IDisposable
    {
        const int _typeNAME = 92;
        const int CefGetGeolocationCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefGetGeolocationCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefGetGeolocationCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 781
    /// <summary>
    /// Callback interface used for asynchronous continuation of geolocation
    /// permission requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefGeolocationCallback : IDisposable
    {
        const int _typeNAME = 93;
        const int CefGeolocationCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefGeolocationCallback_Continue_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefGeolocationCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefGeolocationCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 782

        // gen! void Continue(bool allow)
        /// <summary>
        /// CefGeolocationCallback methods.
        /// </summary>

        public void Continue(bool allow)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = allow ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefGeolocationCallback_Continue_1, out ret, ref v1);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 783
    /// <summary>
    /// Callback interface used for asynchronous continuation of JavaScript dialog
    /// requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefJSDialogCallback : IDisposable
    {
        const int _typeNAME = 94;
        const int CefJSDialogCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefJSDialogCallback_Continue_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefJSDialogCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefJSDialogCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 784

        // gen! void Continue(bool success,const CefString& user_input)
        /// <summary>
        /// CefJSDialogCallback methods.
        /// </summary>

        public void Continue(bool success,
        string user_input)
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateStringHolder(user_input);
            v1.I32 = success ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefJSDialogCallback_Continue_1, out ret, ref v1, ref v2);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 785
    /// <summary>
    /// Callback interface for asynchronous continuation of print dialog requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefPrintDialogCallback : IDisposable
    {
        const int _typeNAME = 95;
        const int CefPrintDialogCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefPrintDialogCallback_Continue_1 = (_typeNAME << 16) | 1;
        const int CefPrintDialogCallback_Cancel_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefPrintDialogCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintDialogCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 786

        // gen! void Continue(CefRefPtr<CefPrintSettings> settings)
        /// <summary>
        /// CefPrintDialogCallback methods.
        /// </summary>

        public void Continue(CefPrintSettings settings)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = settings.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintDialogCallback_Continue_1, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 787

        // gen! void Cancel()

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintDialogCallback_Cancel_2, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 788
    /// <summary>
    /// Callback interface for asynchronous continuation of print job requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefPrintJobCallback : IDisposable
    {
        const int _typeNAME = 96;
        const int CefPrintJobCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefPrintJobCallback_Continue_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefPrintJobCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintJobCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 789

        // gen! void Continue()
        /// <summary>
        /// CefPrintJobCallback methods.
        /// </summary>

        public void Continue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintJobCallback_Continue_1, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 790
    /// <summary>
    /// Callback interface for CefRequestContext::ResolveHost.
    /// /*(source=client)*/
    /// </summary>
    public struct CefResolveCallback : IDisposable
    {
        const int _typeNAME = 97;
        const int CefResolveCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefResolveCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResolveCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 791
    /// <summary>
    /// Callback interface used for asynchronous continuation of url requests.
    /// /*(source=library)*/
    /// </summary>
    public struct CefRequestCallback : IDisposable
    {
        const int _typeNAME = 98;
        const int CefRequestCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefRequestCallback_Continue_1 = (_typeNAME << 16) | 1;
        const int CefRequestCallback_Cancel_2 = (_typeNAME << 16) | 2;
        internal IntPtr nativePtr;
        internal CefRequestCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 792

        // gen! void Continue(bool allow)
        /// <summary>
        /// CefRequestCallback methods.
        /// </summary>

        public void Continue(bool allow)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = allow ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestCallback_Continue_1, out ret, ref v1);

        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 793

        // gen! void Cancel()

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestCallback_Cancel_2, out ret);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 794
    /// <summary>
    /// Callback interface used to select a client certificate for authentication.
    /// /*(source=library)*/
    /// </summary>
    public struct CefSelectClientCertificateCallback : IDisposable
    {
        const int _typeNAME = 99;
        const int CefSelectClientCertificateCallback_Release_0 = (_typeNAME << 16) | 0;
        const int CefSelectClientCertificateCallback_Select_1 = (_typeNAME << 16) | 1;
        internal IntPtr nativePtr;
        internal CefSelectClientCertificateCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSelectClientCertificateCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
        //CsCallToNativeCodeGen::GenerateCsMethod , 795

        // gen! void Select(CefRefPtr<CefX509Certificate> cert)
        /// <summary>
        /// CefSelectClientCertificateCallback methods.
        /// </summary>

        public void Select(CefX509Certificate cert)
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = cert.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefSelectClientCertificateCallback_Select_1, out ret, ref v1);

        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 796
    /// <summary>
    /// Implement this interface to receive notification when tracing has completed.
    /// The methods of this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefEndTracingCallback : IDisposable
    {
        const int _typeNAME = 100;
        const int CefEndTracingCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefEndTracingCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefEndTracingCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 797
    /// <summary>
    /// Interface to implement for receiving unstable plugin information. The methods
    /// of this class will be called on the browser process IO thread.
    /// /*cef(source=client)*/
    /// </summary>
    public struct CefWebPluginUnstableCallback : IDisposable
    {
        const int _typeNAME = 101;
        const int CefWebPluginUnstableCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefWebPluginUnstableCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginUnstableCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
    //CsCallToNativeCodeGen::GenerateCsCode , 798
    /// <summary>
    /// Implement this interface to receive notification when CDM registration is
    /// complete. The methods of this class will be called on the browser process
    /// UI thread.
    /// /*cef(source=client)*/
    /// </summary>
    public struct CefRegisterCdmCallback : IDisposable
    {
        const int _typeNAME = 102;
        const int CefRegisterCdmCallback_Release_0 = (_typeNAME << 16) | 0;
        internal IntPtr nativePtr;
        internal CefRegisterCdmCallback(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Dispose()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRegisterCdmCallback_Release_0, out ret);
            this.nativePtr = IntPtr.Zero;
        }
    }
}