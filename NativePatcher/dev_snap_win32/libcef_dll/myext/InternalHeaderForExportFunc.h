//MIT, 2017, WinterDev
//AUTOGEN
const int CefTypeName_CefApp = 1;
const int CefTypeName_CefBrowser = 2;
const int CefTypeName_CefNavigationEntryVisitor = 3;
const int CefTypeName_CefBrowserHost = 4;
const int CefTypeName_CefClient = 5;
const int CefTypeName_CefCommandLine = 6;
const int CefTypeName_CefContextMenuParams = 7;
const int CefTypeName_CefCookieManager = 8;
const int CefTypeName_CefCookieVisitor = 9;
const int CefTypeName_CefDOMVisitor = 10;
const int CefTypeName_CefDOMDocument = 11;
const int CefTypeName_CefDOMNode = 12;
const int CefTypeName_CefDownloadItem = 13;
const int CefTypeName_CefDragData = 14;
const int CefTypeName_CefFrame = 15;
const int CefTypeName_CefImage = 16;
const int CefTypeName_CefMenuModel = 17;
const int CefTypeName_CefMenuModelDelegate = 18;
const int CefTypeName_CefNavigationEntry = 19;
const int CefTypeName_CefPrintSettings = 20;
const int CefTypeName_CefProcessMessage = 21;
const int CefTypeName_CefRequest = 22;
const int CefTypeName_CefPostData = 23;
const int CefTypeName_CefPostDataElement = 24;
const int CefTypeName_CefRequestContext = 25;
const int CefTypeName_CefResourceBundle = 26;
const int CefTypeName_CefResponse = 27;
const int CefTypeName_CefResponseFilter = 28;
const int CefTypeName_CefSchemeHandlerFactory = 29;
const int CefTypeName_CefSSLInfo = 30;
const int CefTypeName_CefSSLStatus = 31;
const int CefTypeName_CefStreamReader = 32;
const int CefTypeName_CefStreamWriter = 33;
const int CefTypeName_CefStringVisitor = 34;
const int CefTypeName_CefTask = 35;
const int CefTypeName_CefTaskRunner = 36;
const int CefTypeName_CefURLRequest = 37;
const int CefTypeName_CefURLRequestClient = 38;
const int CefTypeName_CefV8Context = 39;
const int CefTypeName_CefV8Accessor = 40;
const int CefTypeName_CefV8Interceptor = 41;
const int CefTypeName_CefV8Exception = 42;
const int CefTypeName_CefV8Value = 43;
const int CefTypeName_CefV8StackTrace = 44;
const int CefTypeName_CefV8StackFrame = 45;
const int CefTypeName_CefValue = 46;
const int CefTypeName_CefBinaryValue = 47;
const int CefTypeName_CefDictionaryValue = 48;
const int CefTypeName_CefListValue = 49;
const int CefTypeName_CefWebPluginInfo = 50;
const int CefTypeName_CefWebPluginInfoVisitor = 51;
const int CefTypeName_CefX509CertPrincipal = 52;
const int CefTypeName_CefX509Certificate = 53;
const int CefTypeName_CefXmlReader = 54;
const int CefTypeName_CefZipReader = 55;
const int CefTypeName_CefAccessibilityHandler = 56;
const int CefTypeName_CefBrowserProcessHandler = 57;
const int CefTypeName_CefContextMenuHandler = 58;
const int CefTypeName_CefDialogHandler = 59;
const int CefTypeName_CefDisplayHandler = 60;
const int CefTypeName_CefDownloadHandler = 61;
const int CefTypeName_CefDragHandler = 62;
const int CefTypeName_CefFindHandler = 63;
const int CefTypeName_CefFocusHandler = 64;
const int CefTypeName_CefGeolocationHandler = 65;
const int CefTypeName_CefJSDialogHandler = 66;
const int CefTypeName_CefKeyboardHandler = 67;
const int CefTypeName_CefLifeSpanHandler = 68;
const int CefTypeName_CefLoadHandler = 69;
const int CefTypeName_CefPrintHandler = 70;
const int CefTypeName_CefRenderHandler = 71;
const int CefTypeName_CefRenderProcessHandler = 72;
const int CefTypeName_CefRequestContextHandler = 73;
const int CefTypeName_CefRequestHandler = 74;
const int CefTypeName_CefResourceBundleHandler = 75;
const int CefTypeName_CefResourceHandler = 76;
const int CefTypeName_CefReadHandler = 77;
const int CefTypeName_CefWriteHandler = 78;
const int CefTypeName_CefV8Handler = 79;
const int CefTypeName_CefAuthCallback = 80;
const int CefTypeName_CefRunFileDialogCallback = 81;
const int CefTypeName_CefPdfPrintCallback = 82;
const int CefTypeName_CefDownloadImageCallback = 83;
const int CefTypeName_CefCallback = 84;
const int CefTypeName_CefCompletionCallback = 85;
const int CefTypeName_CefRunContextMenuCallback = 86;
const int CefTypeName_CefSetCookieCallback = 87;
const int CefTypeName_CefDeleteCookiesCallback = 88;
const int CefTypeName_CefFileDialogCallback = 89;
const int CefTypeName_CefBeforeDownloadCallback = 90;
const int CefTypeName_CefDownloadItemCallback = 91;
const int CefTypeName_CefGetGeolocationCallback = 92;
const int CefTypeName_CefGeolocationCallback = 93;
const int CefTypeName_CefJSDialogCallback = 94;
const int CefTypeName_CefPrintDialogCallback = 95;
const int CefTypeName_CefPrintJobCallback = 96;
const int CefTypeName_CefResolveCallback = 97;
const int CefTypeName_CefRequestCallback = 98;
const int CefTypeName_CefSelectClientCertificateCallback = 99;
const int CefTypeName_CefEndTracingCallback = 100;
const int CefTypeName_CefWebPluginUnstableCallback = 101;
const int CefTypeName_CefRegisterCdmCallback = 102;
namespace CefAppExt
{
	const int _typeName = CefTypeName_CefApp;
	const int CefAppExt_OnBeforeCommandLineProcessing_1 = 1;
	const int CefAppExt_OnRegisterCustomSchemes_2 = 2;
	const int CefAppExt_GetResourceBundleHandler_3 = 3;
	const int CefAppExt_GetBrowserProcessHandler_4 = 4;
	const int CefAppExt_GetRenderProcessHandler_5 = 5;

}
namespace CefNavigationEntryVisitorExt
{
	const int _typeName = CefTypeName_CefNavigationEntryVisitor;
	const int CefNavigationEntryVisitorExt_Visit_1 = 1;

}
namespace CefClientExt
{
	const int _typeName = CefTypeName_CefClient;
	const int CefClientExt_GetContextMenuHandler_1 = 1;
	const int CefClientExt_GetDialogHandler_2 = 2;
	const int CefClientExt_GetDisplayHandler_3 = 3;
	const int CefClientExt_GetDownloadHandler_4 = 4;
	const int CefClientExt_GetDragHandler_5 = 5;
	const int CefClientExt_GetFindHandler_6 = 6;
	const int CefClientExt_GetFocusHandler_7 = 7;
	const int CefClientExt_GetGeolocationHandler_8 = 8;
	const int CefClientExt_GetJSDialogHandler_9 = 9;
	const int CefClientExt_GetKeyboardHandler_10 = 10;
	const int CefClientExt_GetLifeSpanHandler_11 = 11;
	const int CefClientExt_GetLoadHandler_12 = 12;
	const int CefClientExt_GetRenderHandler_13 = 13;
	const int CefClientExt_GetRequestHandler_14 = 14;
	const int CefClientExt_OnProcessMessageReceived_15 = 15;

}
namespace CefCookieVisitorExt
{
	const int _typeName = CefTypeName_CefCookieVisitor;
	const int CefCookieVisitorExt_Visit_1 = 1;

}
namespace CefDOMVisitorExt
{
	const int _typeName = CefTypeName_CefDOMVisitor;
	const int CefDOMVisitorExt_Visit_1 = 1;

}
namespace CefMenuModelDelegateExt
{
	const int _typeName = CefTypeName_CefMenuModelDelegate;
	const int CefMenuModelDelegateExt_ExecuteCommand_1 = 1;
	const int CefMenuModelDelegateExt_MouseOutsideMenu_2 = 2;
	const int CefMenuModelDelegateExt_UnhandledOpenSubmenu_3 = 3;
	const int CefMenuModelDelegateExt_UnhandledCloseSubmenu_4 = 4;
	const int CefMenuModelDelegateExt_MenuWillShow_5 = 5;
	const int CefMenuModelDelegateExt_MenuClosed_6 = 6;
	const int CefMenuModelDelegateExt_FormatLabel_7 = 7;

}
namespace CefResponseFilterExt
{
	const int _typeName = CefTypeName_CefResponseFilter;
	const int CefResponseFilterExt_InitFilter_1 = 1;
	const int CefResponseFilterExt_Filter_2 = 2;

}
namespace CefSchemeHandlerFactoryExt
{
	const int _typeName = CefTypeName_CefSchemeHandlerFactory;
	const int CefSchemeHandlerFactoryExt_Create_1 = 1;

}
namespace CefStringVisitorExt
{
	const int _typeName = CefTypeName_CefStringVisitor;
	const int CefStringVisitorExt_Visit_1 = 1;

}
namespace CefTaskExt
{
	const int _typeName = CefTypeName_CefTask;
	const int CefTaskExt_Execute_1 = 1;

}
namespace CefURLRequestClientExt
{
	const int _typeName = CefTypeName_CefURLRequestClient;
	const int CefURLRequestClientExt_OnRequestComplete_1 = 1;
	const int CefURLRequestClientExt_OnUploadProgress_2 = 2;
	const int CefURLRequestClientExt_OnDownloadProgress_3 = 3;
	const int CefURLRequestClientExt_OnDownloadData_4 = 4;
	const int CefURLRequestClientExt_GetAuthCredentials_5 = 5;

}
namespace CefV8AccessorExt
{
	const int _typeName = CefTypeName_CefV8Accessor;
	const int CefV8AccessorExt_Get_1 = 1;
	const int CefV8AccessorExt_Set_2 = 2;

}
namespace CefV8InterceptorExt
{
	const int _typeName = CefTypeName_CefV8Interceptor;
	const int CefV8InterceptorExt_Get_1 = 1;
	const int CefV8InterceptorExt_Get1_2 = 2;
	const int CefV8InterceptorExt_Set_3 = 3;
	const int CefV8InterceptorExt_Set3_4 = 4;

}
namespace CefWebPluginInfoVisitorExt
{
	const int _typeName = CefTypeName_CefWebPluginInfoVisitor;
	const int CefWebPluginInfoVisitorExt_Visit_1 = 1;

}
namespace CefAuthCallbackExt
{
	const int _typeName = CefTypeName_CefAuthCallback;
	const int CefAuthCallbackExt_Continue_1 = 1;
	const int CefAuthCallbackExt_Cancel_2 = 2;

}
namespace CefRunFileDialogCallbackExt
{
	const int _typeName = CefTypeName_CefRunFileDialogCallback;
	const int CefRunFileDialogCallbackExt_OnFileDialogDismissed_1 = 1;

}
namespace CefPdfPrintCallbackExt
{
	const int _typeName = CefTypeName_CefPdfPrintCallback;
	const int CefPdfPrintCallbackExt_OnPdfPrintFinished_1 = 1;

}
namespace CefDownloadImageCallbackExt
{
	const int _typeName = CefTypeName_CefDownloadImageCallback;
	const int CefDownloadImageCallbackExt_OnDownloadImageFinished_1 = 1;

}
namespace CefCallbackExt
{
	const int _typeName = CefTypeName_CefCallback;
	const int CefCallbackExt_Continue_1 = 1;
	const int CefCallbackExt_Cancel_2 = 2;

}
namespace CefCompletionCallbackExt
{
	const int _typeName = CefTypeName_CefCompletionCallback;
	const int CefCompletionCallbackExt_OnComplete_1 = 1;

}
namespace CefRunContextMenuCallbackExt
{
	const int _typeName = CefTypeName_CefRunContextMenuCallback;
	const int CefRunContextMenuCallbackExt_Continue_1 = 1;
	const int CefRunContextMenuCallbackExt_Cancel_2 = 2;

}
namespace CefSetCookieCallbackExt
{
	const int _typeName = CefTypeName_CefSetCookieCallback;
	const int CefSetCookieCallbackExt_OnComplete_1 = 1;

}
namespace CefDeleteCookiesCallbackExt
{
	const int _typeName = CefTypeName_CefDeleteCookiesCallback;
	const int CefDeleteCookiesCallbackExt_OnComplete_1 = 1;

}
namespace CefFileDialogCallbackExt
{
	const int _typeName = CefTypeName_CefFileDialogCallback;
	const int CefFileDialogCallbackExt_Continue_1 = 1;
	const int CefFileDialogCallbackExt_Cancel_2 = 2;

}
namespace CefBeforeDownloadCallbackExt
{
	const int _typeName = CefTypeName_CefBeforeDownloadCallback;
	const int CefBeforeDownloadCallbackExt_Continue_1 = 1;

}
namespace CefDownloadItemCallbackExt
{
	const int _typeName = CefTypeName_CefDownloadItemCallback;
	const int CefDownloadItemCallbackExt_Cancel_1 = 1;
	const int CefDownloadItemCallbackExt_Pause_2 = 2;
	const int CefDownloadItemCallbackExt_Resume_3 = 3;

}
namespace CefGetGeolocationCallbackExt
{
	const int _typeName = CefTypeName_CefGetGeolocationCallback;
	const int CefGetGeolocationCallbackExt_OnLocationUpdate_1 = 1;

}
namespace CefGeolocationCallbackExt
{
	const int _typeName = CefTypeName_CefGeolocationCallback;
	const int CefGeolocationCallbackExt_Continue_1 = 1;

}
namespace CefJSDialogCallbackExt
{
	const int _typeName = CefTypeName_CefJSDialogCallback;
	const int CefJSDialogCallbackExt_Continue_1 = 1;

}
namespace CefPrintDialogCallbackExt
{
	const int _typeName = CefTypeName_CefPrintDialogCallback;
	const int CefPrintDialogCallbackExt_Continue_1 = 1;
	const int CefPrintDialogCallbackExt_Cancel_2 = 2;

}
namespace CefPrintJobCallbackExt
{
	const int _typeName = CefTypeName_CefPrintJobCallback;
	const int CefPrintJobCallbackExt_Continue_1 = 1;

}
namespace CefResolveCallbackExt
{
	const int _typeName = CefTypeName_CefResolveCallback;
	const int CefResolveCallbackExt_OnResolveCompleted_1 = 1;

}
namespace CefRequestCallbackExt
{
	const int _typeName = CefTypeName_CefRequestCallback;
	const int CefRequestCallbackExt_Continue_1 = 1;
	const int CefRequestCallbackExt_Cancel_2 = 2;

}
namespace CefSelectClientCertificateCallbackExt
{
	const int _typeName = CefTypeName_CefSelectClientCertificateCallback;
	const int CefSelectClientCertificateCallbackExt_Select_1 = 1;

}
namespace CefEndTracingCallbackExt
{
	const int _typeName = CefTypeName_CefEndTracingCallback;
	const int CefEndTracingCallbackExt_OnEndTracingComplete_1 = 1;

}
namespace CefWebPluginUnstableCallbackExt
{
	const int _typeName = CefTypeName_CefWebPluginUnstableCallback;
	const int CefWebPluginUnstableCallbackExt_IsUnstable_1 = 1;

}
namespace CefRegisterCdmCallbackExt
{
	const int _typeName = CefTypeName_CefRegisterCdmCallback;
	const int CefRegisterCdmCallbackExt_OnCdmRegistrationComplete_1 = 1;

}
namespace CefAccessibilityHandlerExt
{
	const int _typeName = CefTypeName_CefAccessibilityHandler;
	const int CefAccessibilityHandlerExt_OnAccessibilityTreeChange_1 = 1;
	const int CefAccessibilityHandlerExt_OnAccessibilityLocationChange_2 = 2;
}
namespace CefBrowserProcessHandlerExt
{
	const int _typeName = CefTypeName_CefBrowserProcessHandler;
	const int CefBrowserProcessHandlerExt_OnContextInitialized_1 = 1;
	const int CefBrowserProcessHandlerExt_OnBeforeChildProcessLaunch_2 = 2;
	const int CefBrowserProcessHandlerExt_OnRenderProcessThreadCreated_3 = 3;
	const int CefBrowserProcessHandlerExt_GetPrintHandler_4 = 4;
	const int CefBrowserProcessHandlerExt_OnScheduleMessagePumpWork_5 = 5;
}
namespace CefContextMenuHandlerExt
{
	const int _typeName = CefTypeName_CefContextMenuHandler;
	const int CefContextMenuHandlerExt_OnBeforeContextMenu_1 = 1;
	const int CefContextMenuHandlerExt_RunContextMenu_2 = 2;
	const int CefContextMenuHandlerExt_OnContextMenuCommand_3 = 3;
	const int CefContextMenuHandlerExt_OnContextMenuDismissed_4 = 4;
}
namespace CefDialogHandlerExt
{
	const int _typeName = CefTypeName_CefDialogHandler;
	const int CefDialogHandlerExt_OnFileDialog_1 = 1;
}
namespace CefDisplayHandlerExt
{
	const int _typeName = CefTypeName_CefDisplayHandler;
	const int CefDisplayHandlerExt_OnAddressChange_1 = 1;
	const int CefDisplayHandlerExt_OnTitleChange_2 = 2;
	const int CefDisplayHandlerExt_OnFaviconURLChange_3 = 3;
	const int CefDisplayHandlerExt_OnFullscreenModeChange_4 = 4;
	const int CefDisplayHandlerExt_OnTooltip_5 = 5;
	const int CefDisplayHandlerExt_OnStatusMessage_6 = 6;
	const int CefDisplayHandlerExt_OnConsoleMessage_7 = 7;
}
namespace CefDownloadHandlerExt
{
	const int _typeName = CefTypeName_CefDownloadHandler;
	const int CefDownloadHandlerExt_OnBeforeDownload_1 = 1;
	const int CefDownloadHandlerExt_OnDownloadUpdated_2 = 2;
}
namespace CefDragHandlerExt
{
	const int _typeName = CefTypeName_CefDragHandler;
	const int CefDragHandlerExt_OnDragEnter_1 = 1;
	const int CefDragHandlerExt_OnDraggableRegionsChanged_2 = 2;
}
namespace CefFindHandlerExt
{
	const int _typeName = CefTypeName_CefFindHandler;
	const int CefFindHandlerExt_OnFindResult_1 = 1;
}
namespace CefFocusHandlerExt
{
	const int _typeName = CefTypeName_CefFocusHandler;
	const int CefFocusHandlerExt_OnTakeFocus_1 = 1;
	const int CefFocusHandlerExt_OnSetFocus_2 = 2;
	const int CefFocusHandlerExt_OnGotFocus_3 = 3;
}
namespace CefGeolocationHandlerExt
{
	const int _typeName = CefTypeName_CefGeolocationHandler;
	const int CefGeolocationHandlerExt_OnRequestGeolocationPermission_1 = 1;
	const int CefGeolocationHandlerExt_OnCancelGeolocationPermission_2 = 2;
}
namespace CefJSDialogHandlerExt
{
	const int _typeName = CefTypeName_CefJSDialogHandler;
	const int CefJSDialogHandlerExt_OnJSDialog_1 = 1;
	const int CefJSDialogHandlerExt_OnBeforeUnloadDialog_2 = 2;
	const int CefJSDialogHandlerExt_OnResetDialogState_3 = 3;
	const int CefJSDialogHandlerExt_OnDialogClosed_4 = 4;
}
namespace CefKeyboardHandlerExt
{
	const int _typeName = CefTypeName_CefKeyboardHandler;
	const int CefKeyboardHandlerExt_OnPreKeyEvent_1 = 1;
	const int CefKeyboardHandlerExt_OnKeyEvent_2 = 2;
}
namespace CefLifeSpanHandlerExt
{
	const int _typeName = CefTypeName_CefLifeSpanHandler;
	const int CefLifeSpanHandlerExt_OnBeforePopup_1 = 1;
	const int CefLifeSpanHandlerExt_OnAfterCreated_2 = 2;
	const int CefLifeSpanHandlerExt_DoClose_3 = 3;
	const int CefLifeSpanHandlerExt_OnBeforeClose_4 = 4;
}
namespace CefLoadHandlerExt
{
	const int _typeName = CefTypeName_CefLoadHandler;
	const int CefLoadHandlerExt_OnLoadingStateChange_1 = 1;
	const int CefLoadHandlerExt_OnLoadStart_2 = 2;
	const int CefLoadHandlerExt_OnLoadEnd_3 = 3;
	const int CefLoadHandlerExt_OnLoadError_4 = 4;
}
namespace CefPrintHandlerExt
{
	const int _typeName = CefTypeName_CefPrintHandler;
	const int CefPrintHandlerExt_OnPrintStart_1 = 1;
	const int CefPrintHandlerExt_OnPrintSettings_2 = 2;
	const int CefPrintHandlerExt_OnPrintDialog_3 = 3;
	const int CefPrintHandlerExt_OnPrintJob_4 = 4;
	const int CefPrintHandlerExt_OnPrintReset_5 = 5;
	const int CefPrintHandlerExt_GetPdfPaperSize_6 = 6;
}
namespace CefRenderHandlerExt
{
	const int _typeName = CefTypeName_CefRenderHandler;
	const int CefRenderHandlerExt_GetAccessibilityHandler_1 = 1;
	const int CefRenderHandlerExt_GetRootScreenRect_2 = 2;
	const int CefRenderHandlerExt_GetViewRect_3 = 3;
	const int CefRenderHandlerExt_GetScreenPoint_4 = 4;
	const int CefRenderHandlerExt_GetScreenInfo_5 = 5;
	const int CefRenderHandlerExt_OnPopupShow_6 = 6;
	const int CefRenderHandlerExt_OnPopupSize_7 = 7;
	const int CefRenderHandlerExt_OnPaint_8 = 8;
	const int CefRenderHandlerExt_OnCursorChange_9 = 9;
	const int CefRenderHandlerExt_StartDragging_10 = 10;
	const int CefRenderHandlerExt_UpdateDragCursor_11 = 11;
	const int CefRenderHandlerExt_OnScrollOffsetChanged_12 = 12;
	const int CefRenderHandlerExt_OnImeCompositionRangeChanged_13 = 13;
}
namespace CefRenderProcessHandlerExt
{
	const int _typeName = CefTypeName_CefRenderProcessHandler;
	const int CefRenderProcessHandlerExt_OnRenderThreadCreated_1 = 1;
	const int CefRenderProcessHandlerExt_OnWebKitInitialized_2 = 2;
	const int CefRenderProcessHandlerExt_OnBrowserCreated_3 = 3;
	const int CefRenderProcessHandlerExt_OnBrowserDestroyed_4 = 4;
	const int CefRenderProcessHandlerExt_GetLoadHandler_5 = 5;
	const int CefRenderProcessHandlerExt_OnBeforeNavigation_6 = 6;
	const int CefRenderProcessHandlerExt_OnContextCreated_7 = 7;
	const int CefRenderProcessHandlerExt_OnContextReleased_8 = 8;
	const int CefRenderProcessHandlerExt_OnUncaughtException_9 = 9;
	const int CefRenderProcessHandlerExt_OnFocusedNodeChanged_10 = 10;
	const int CefRenderProcessHandlerExt_OnProcessMessageReceived_11 = 11;
}
namespace CefRequestContextHandlerExt
{
	const int _typeName = CefTypeName_CefRequestContextHandler;
	const int CefRequestContextHandlerExt_GetCookieManager_1 = 1;
	const int CefRequestContextHandlerExt_OnBeforePluginLoad_2 = 2;
}
namespace CefRequestHandlerExt
{
	const int _typeName = CefTypeName_CefRequestHandler;
	const int CefRequestHandlerExt_OnBeforeBrowse_1 = 1;
	const int CefRequestHandlerExt_OnOpenURLFromTab_2 = 2;
	const int CefRequestHandlerExt_OnBeforeResourceLoad_3 = 3;
	const int CefRequestHandlerExt_GetResourceHandler_4 = 4;
	const int CefRequestHandlerExt_OnResourceRedirect_5 = 5;
	const int CefRequestHandlerExt_OnResourceResponse_6 = 6;
	const int CefRequestHandlerExt_GetResourceResponseFilter_7 = 7;
	const int CefRequestHandlerExt_OnResourceLoadComplete_8 = 8;
	const int CefRequestHandlerExt_GetAuthCredentials_9 = 9;
	const int CefRequestHandlerExt_OnQuotaRequest_10 = 10;
	const int CefRequestHandlerExt_OnProtocolExecution_11 = 11;
	const int CefRequestHandlerExt_OnCertificateError_12 = 12;
	const int CefRequestHandlerExt_OnSelectClientCertificate_13 = 13;
	const int CefRequestHandlerExt_OnPluginCrashed_14 = 14;
	const int CefRequestHandlerExt_OnRenderViewReady_15 = 15;
	const int CefRequestHandlerExt_OnRenderProcessTerminated_16 = 16;
}
namespace CefResourceBundleHandlerExt
{
	const int _typeName = CefTypeName_CefResourceBundleHandler;
	const int CefResourceBundleHandlerExt_GetLocalizedString_1 = 1;
	const int CefResourceBundleHandlerExt_GetDataResource_2 = 2;
	const int CefResourceBundleHandlerExt_GetDataResourceForScale_3 = 3;
}
namespace CefResourceHandlerExt
{
	const int _typeName = CefTypeName_CefResourceHandler;
	const int CefResourceHandlerExt_ProcessRequest_1 = 1;
	const int CefResourceHandlerExt_GetResponseHeaders_2 = 2;
	const int CefResourceHandlerExt_ReadResponse_3 = 3;
	const int CefResourceHandlerExt_CanGetCookie_4 = 4;
	const int CefResourceHandlerExt_CanSetCookie_5 = 5;
	const int CefResourceHandlerExt_Cancel_6 = 6;
}
namespace CefReadHandlerExt
{
	const int _typeName = CefTypeName_CefReadHandler;
	const int CefReadHandlerExt_Read_1 = 1;
	const int CefReadHandlerExt_Seek_2 = 2;
	const int CefReadHandlerExt_Tell_3 = 3;
	const int CefReadHandlerExt_Eof_4 = 4;
	const int CefReadHandlerExt_MayBlock_5 = 5;
}
namespace CefWriteHandlerExt
{
	const int _typeName = CefTypeName_CefWriteHandler;
	const int CefWriteHandlerExt_Write_1 = 1;
	const int CefWriteHandlerExt_Seek_2 = 2;
	const int CefWriteHandlerExt_Tell_3 = 3;
	const int CefWriteHandlerExt_Flush_4 = 4;
	const int CefWriteHandlerExt_MayBlock_5 = 5;
}
namespace CefV8HandlerExt
{
	const int _typeName = CefTypeName_CefV8Handler;
	const int CefV8HandlerExt_Execute_1 = 1;
}
