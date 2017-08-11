
//MIT, 2017, WinterDev
//AUTOGEN

#pragma once
#include "ExportFuncAuto.h" 
//----------------
const int MET_Release = 0;
//---------------- 
//
inline void SetCefStringToJsValue(jsvalue* value, const CefString&cefstr) {

	MyCefStringHolder* str = new MyCefStringHolder();
	str->value = cefstr;
	//
	value->type = JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;
	value->ptr = str;
	value->i32 = str->value.length();
}
inline void MyCefSetVoidPtr(jsvalue* value, void* data)
{
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = data;
}
inline void MyCefSetVoidPtr2(jsvalue* value, const void* data) {
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = data;
}
inline void MyCefSetInt32(jsvalue* value, int32_t data)
{
	value->type = JSVALUE_TYPE_INTEGER;
	value->i32 = data;
}
inline void MyCefSetUInt32(jsvalue* value, uint32_t data)
{
	value->type = JSVALUE_TYPE_INTEGER;
	value->i32 = (int32_t)data;
}
inline void MyCefSetInt64(jsvalue* value, int64_t data)
{
	value->type = JSVALUE_TYPE_INTEGER64;
	value->i64 = data;
}
inline void MyCefSetUInt64(jsvalue* value, uint64_t data)
{
	value->type = JSVALUE_TYPE_INTEGER64;
	value->i64 = data;
}
inline void MyCefSetBool(jsvalue* value, bool data)
{
	value->type = JSVALUE_TYPE_BOOLEAN;
	value->i32 = data ? 1 : 0;
}
inline void MyCefSetDouble(jsvalue* value, double data)
{
	value->type = JSVALUE_TYPE_NUMBER;
	value->num = data;
}
inline void MyCefSetFloat(jsvalue* value, float data)
{
	value->type = JSVALUE_TYPE_NUMBER;
	value->num = data;
}
inline MyCefStringHolder*GetStringHolder(jsvalue * value) {
	return (MyCefStringHolder*)value->ptr;
}
inline void MyCefSetCefPoint(jsvalue* value, CefPoint&data) {

	CefPoint* cefPoint = new CefPoint();
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = cefPoint;
}
struct MyMetArgs2
{
	jsvalue ret;
	jsvalue v1;
	jsvalue v2;
	jsvalue v3;
	jsvalue v4;
	jsvalue v5;
	jsvalue v6;
	jsvalue v7;
};
//////////////////////////////////////////////////////////////////
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

// [virtual] class CefApp
const int CefApp_OnBeforeCommandLineProcessing_1 = 1;
const int CefApp_OnRegisterCustomSchemes_2 = 2;
const int CefApp_GetResourceBundleHandler_3 = 3;
const int CefApp_GetBrowserProcessHandler_4 = 4;
const int CefApp_GetRenderProcessHandler_5 = 5;

void MyCefMet_CefApp(cef_app_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefAppCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefApp_OnBeforeCommandLineProcessing_1: {


		// gen! void OnBeforeCommandLineProcessing(const CefString& process_type,CefRefPtr<CefCommandLine> command_line)
		me->OnBeforeCommandLineProcessing(GetStringHolder(v1)->value,
			CefCommandLineCToCpp::Wrap((cef_command_line_t*)v2->ptr));

	} break;
	case CefApp_OnRegisterCustomSchemes_2: {


		// gen! void OnRegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar)
		me->OnRegisterCustomSchemes((CefSchemeRegistrar*)v1->ptr);

	} break;
	case CefApp_GetResourceBundleHandler_3: {


		// gen! CefRefPtr<CefResourceBundleHandler> GetResourceBundleHandler()
		auto ret_result = me->GetResourceBundleHandler();
		MyCefSetVoidPtr(ret, CefResourceBundleHandlerCppToC::Wrap(ret_result));
	} break;
	case CefApp_GetBrowserProcessHandler_4: {


		// gen! CefRefPtr<CefBrowserProcessHandler> GetBrowserProcessHandler()
		auto ret_result = me->GetBrowserProcessHandler();
		MyCefSetVoidPtr(ret, CefBrowserProcessHandlerCppToC::Wrap(ret_result));
	} break;
	case CefApp_GetRenderProcessHandler_5: {


		// gen! CefRefPtr<CefRenderProcessHandler> GetRenderProcessHandler()
		auto ret_result = me->GetRenderProcessHandler();
		MyCefSetVoidPtr(ret, CefRenderProcessHandlerCppToC::Wrap(ret_result));
	} break;
	}
	CefAppCppToC::Wrap(me);
}
const int MyCefApp_OnBeforeCommandLineProcessing_1 = 1;
const int MyCefApp_OnRegisterCustomSchemes_2 = 2;
const int MyCefApp_GetResourceBundleHandler_3 = 3;
const int MyCefApp_GetBrowserProcessHandler_4 = 4;
const int MyCefApp_GetRenderProcessHandler_5 = 5;
class MyCefApp :public CefAppCppToC {
public:
	managed_callback mcallback;
	explicit MyCefApp() {
		mcallback = NULL;
	}
	//gen! void OnBeforeCommandLineProcessing(const CefString& process_type,CefRefPtr<CefCommandLine> command_line)
	virtual void OnBeforeCommandLineProcessing(const CefString& process_type, CefRefPtr<CefCommandLine> command_line) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, process_type);
			MyCefSetVoidPtr(&args.v2, CefCommandLineCToCpp::Unwrap(command_line));
			this->mcallback(MyCefApp_OnBeforeCommandLineProcessing_1, &args);
		}
	}
	//gen! void OnRegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar)
	virtual void OnRegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, registrar);
			this->mcallback(MyCefApp_OnRegisterCustomSchemes_2, &args);
		}
	}
	//gen! CefRefPtr<CefResourceBundleHandler> GetResourceBundleHandler()
	virtual CefRefPtr<CefResourceBundleHandler> GetResourceBundleHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefApp_GetResourceBundleHandler_3, &args);
			return CefResourceBundleHandlerCppToC::Unwrap((cef_resource_bundle_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefBrowserProcessHandler> GetBrowserProcessHandler()
	virtual CefRefPtr<CefBrowserProcessHandler> GetBrowserProcessHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefApp_GetBrowserProcessHandler_4, &args);
			return CefBrowserProcessHandlerCppToC::Unwrap((cef_browser_process_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefRenderProcessHandler> GetRenderProcessHandler()
	virtual CefRefPtr<CefRenderProcessHandler> GetRenderProcessHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefApp_GetRenderProcessHandler_5, &args);
			return CefRenderProcessHandlerCppToC::Unwrap((cef_render_process_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
};


// [virtual] class CefBrowser
const int CefBrowser_GetHost_1 = 1;
const int CefBrowser_CanGoBack_2 = 2;
const int CefBrowser_GoBack_3 = 3;
const int CefBrowser_CanGoForward_4 = 4;
const int CefBrowser_GoForward_5 = 5;
const int CefBrowser_IsLoading_6 = 6;
const int CefBrowser_Reload_7 = 7;
const int CefBrowser_ReloadIgnoreCache_8 = 8;
const int CefBrowser_StopLoad_9 = 9;
const int CefBrowser_GetIdentifier_10 = 10;
const int CefBrowser_IsSame_11 = 11;
const int CefBrowser_IsPopup_12 = 12;
const int CefBrowser_HasDocument_13 = 13;
const int CefBrowser_GetMainFrame_14 = 14;
const int CefBrowser_GetFocusedFrame_15 = 15;
const int CefBrowser_GetFrame_16 = 16;
const int CefBrowser_GetFrame_17 = 17;
const int CefBrowser_GetFrameCount_18 = 18;
const int CefBrowser_GetFrameIdentifiers_19 = 19;
const int CefBrowser_GetFrameNames_20 = 20;
const int CefBrowser_SendProcessMessage_21 = 21;

void MyCefMet_CefBrowser(cef_browser_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefBrowserCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefBrowser_GetHost_1: {


		// gen! CefRefPtr<CefBrowserHost> GetHost()
		auto ret_result = me->GetHost();
		MyCefSetVoidPtr(ret, CefBrowserHostCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowser_CanGoBack_2: {


		// gen! bool CanGoBack()
		auto ret_result = me->CanGoBack();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowser_GoBack_3: {


		// gen! void GoBack()
		me->GoBack();

	} break;
	case CefBrowser_CanGoForward_4: {


		// gen! bool CanGoForward()
		auto ret_result = me->CanGoForward();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowser_GoForward_5: {


		// gen! void GoForward()
		me->GoForward();

	} break;
	case CefBrowser_IsLoading_6: {


		// gen! bool IsLoading()
		auto ret_result = me->IsLoading();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowser_Reload_7: {


		// gen! void Reload()
		me->Reload();

	} break;
	case CefBrowser_ReloadIgnoreCache_8: {


		// gen! void ReloadIgnoreCache()
		me->ReloadIgnoreCache();

	} break;
	case CefBrowser_StopLoad_9: {


		// gen! void StopLoad()
		me->StopLoad();

	} break;
	case CefBrowser_GetIdentifier_10: {


		// gen! int GetIdentifier()
		auto ret_result = me->GetIdentifier();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefBrowser_IsSame_11: {


		// gen! bool IsSame(CefRefPtr<CefBrowser> that)
		auto ret_result = me->IsSame(CefBrowserCToCpp::Wrap((cef_browser_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowser_IsPopup_12: {


		// gen! bool IsPopup()
		auto ret_result = me->IsPopup();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowser_HasDocument_13: {


		// gen! bool HasDocument()
		auto ret_result = me->HasDocument();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowser_GetMainFrame_14: {


		// gen! CefRefPtr<CefFrame> GetMainFrame()
		auto ret_result = me->GetMainFrame();
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowser_GetFocusedFrame_15: {


		// gen! CefRefPtr<CefFrame> GetFocusedFrame()
		auto ret_result = me->GetFocusedFrame();
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowser_GetFrame_16: {


		// gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
		auto ret_result = me->GetFrame(v1->i64);
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowser_GetFrame_17: {


		// gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
		auto ret_result = me->GetFrame(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowser_GetFrameCount_18: {


		// gen! size_t GetFrameCount()
		auto ret_result = me->GetFrameCount();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefBrowser_GetFrameIdentifiers_19: {


		// gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
		me->GetFrameIdentifiers(*((std::vector<int64>*)v1->ptr));

	} break;
	case CefBrowser_GetFrameNames_20: {


		// gen! void GetFrameNames(std::vector<CefString>& names)
		me->GetFrameNames(*((std::vector<CefString>*)v1->ptr));

	} break;
	case CefBrowser_SendProcessMessage_21: {


		// gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
		auto ret_result = me->SendProcessMessage((CefProcessId)v1->i32,
			CefProcessMessageCToCpp::Wrap((cef_process_message_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefBrowserCToCpp::Unwrap(me);
}


// [virtual] class CefNavigationEntryVisitor
const int CefNavigationEntryVisitor_Visit_1 = 1;

void MyCefMet_CefNavigationEntryVisitor(cef_navigation_entry_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefNavigationEntryVisitorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefNavigationEntryVisitor_Visit_1: {


		// gen! bool Visit(CefRefPtr<CefNavigationEntry> entry,bool current,int index,int total)
		auto ret_result = me->Visit(CefNavigationEntryCToCpp::Wrap((cef_navigation_entry_t*)v1->ptr),
			v2->i32 != 0,
			v3->i32,
			v4->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefNavigationEntryVisitorCppToC::Wrap(me);
}
const int MyCefNavigationEntryVisitor_Visit_1 = 1;
class MyCefNavigationEntryVisitor :public CefNavigationEntryVisitorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefNavigationEntryVisitor() {
		mcallback = NULL;
	}
	//gen! bool Visit(CefRefPtr<CefNavigationEntry> entry,bool current,int index,int total)
	virtual bool Visit(CefRefPtr<CefNavigationEntry> entry, bool current, int index, int total) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefNavigationEntryCToCpp::Unwrap(entry));
			MyCefSetBool(&args.v2, current);
			MyCefSetInt64(&args.v3, index);
			MyCefSetInt64(&args.v4, total);
			this->mcallback(MyCefNavigationEntryVisitor_Visit_1, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefBrowserHost
const int CefBrowserHost_GetBrowser_1 = 1;
const int CefBrowserHost_CloseBrowser_2 = 2;
const int CefBrowserHost_TryCloseBrowser_3 = 3;
const int CefBrowserHost_SetFocus_4 = 4;
const int CefBrowserHost_GetWindowHandle_5 = 5;
const int CefBrowserHost_GetOpenerWindowHandle_6 = 6;
const int CefBrowserHost_HasView_7 = 7;
const int CefBrowserHost_GetClient_8 = 8;
const int CefBrowserHost_GetRequestContext_9 = 9;
const int CefBrowserHost_GetZoomLevel_10 = 10;
const int CefBrowserHost_SetZoomLevel_11 = 11;
const int CefBrowserHost_RunFileDialog_12 = 12;
const int CefBrowserHost_StartDownload_13 = 13;
const int CefBrowserHost_DownloadImage_14 = 14;
const int CefBrowserHost_Print_15 = 15;
const int CefBrowserHost_PrintToPDF_16 = 16;
const int CefBrowserHost_Find_17 = 17;
const int CefBrowserHost_StopFinding_18 = 18;
const int CefBrowserHost_ShowDevTools_19 = 19;
const int CefBrowserHost_CloseDevTools_20 = 20;
const int CefBrowserHost_HasDevTools_21 = 21;
const int CefBrowserHost_GetNavigationEntries_22 = 22;
const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = 23;
const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = 24;
const int CefBrowserHost_ReplaceMisspelling_25 = 25;
const int CefBrowserHost_AddWordToDictionary_26 = 26;
const int CefBrowserHost_IsWindowRenderingDisabled_27 = 27;
const int CefBrowserHost_WasResized_28 = 28;
const int CefBrowserHost_WasHidden_29 = 29;
const int CefBrowserHost_NotifyScreenInfoChanged_30 = 30;
const int CefBrowserHost_Invalidate_31 = 31;
const int CefBrowserHost_SendKeyEvent_32 = 32;
const int CefBrowserHost_SendMouseClickEvent_33 = 33;
const int CefBrowserHost_SendMouseMoveEvent_34 = 34;
const int CefBrowserHost_SendMouseWheelEvent_35 = 35;
const int CefBrowserHost_SendFocusEvent_36 = 36;
const int CefBrowserHost_SendCaptureLostEvent_37 = 37;
const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = 38;
const int CefBrowserHost_GetWindowlessFrameRate_39 = 39;
const int CefBrowserHost_SetWindowlessFrameRate_40 = 40;
const int CefBrowserHost_ImeSetComposition_41 = 41;
const int CefBrowserHost_ImeCommitText_42 = 42;
const int CefBrowserHost_ImeFinishComposingText_43 = 43;
const int CefBrowserHost_ImeCancelComposition_44 = 44;
const int CefBrowserHost_DragTargetDragEnter_45 = 45;
const int CefBrowserHost_DragTargetDragOver_46 = 46;
const int CefBrowserHost_DragTargetDragLeave_47 = 47;
const int CefBrowserHost_DragTargetDrop_48 = 48;
const int CefBrowserHost_DragSourceEndedAt_49 = 49;
const int CefBrowserHost_DragSourceSystemDragEnded_50 = 50;
const int CefBrowserHost_GetVisibleNavigationEntry_51 = 51;
const int CefBrowserHost_SetAccessibilityState_52 = 52;

void MyCefMet_CefBrowserHost(cef_browser_host_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefBrowserHostCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefBrowserHost_GetBrowser_1: {


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowserHost_CloseBrowser_2: {


		// gen! void CloseBrowser(bool force_close)
		me->CloseBrowser(v1->i32 != 0);

	} break;
	case CefBrowserHost_TryCloseBrowser_3: {


		// gen! bool TryCloseBrowser()
		auto ret_result = me->TryCloseBrowser();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowserHost_SetFocus_4: {


		// gen! void SetFocus(bool focus)
		me->SetFocus(v1->i32 != 0);

	} break;
	case CefBrowserHost_GetWindowHandle_5: {


		// gen! CefWindowHandle GetWindowHandle()
		auto ret_result = me->GetWindowHandle();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefBrowserHost_GetOpenerWindowHandle_6: {


		// gen! CefWindowHandle GetOpenerWindowHandle()
		auto ret_result = me->GetOpenerWindowHandle();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefBrowserHost_HasView_7: {


		// gen! bool HasView()
		auto ret_result = me->HasView();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowserHost_GetClient_8: {


		// gen! CefRefPtr<CefClient> GetClient()
		auto ret_result = me->GetClient();
		MyCefSetVoidPtr(ret, CefClientCppToC::Wrap(ret_result));
	} break;
	case CefBrowserHost_GetRequestContext_9: {


		// gen! CefRefPtr<CefRequestContext> GetRequestContext()
		auto ret_result = me->GetRequestContext();
		MyCefSetVoidPtr(ret, CefRequestContextCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowserHost_GetZoomLevel_10: {


		// gen! double GetZoomLevel()
		auto ret_result = me->GetZoomLevel();
		MyCefSetDouble(ret, ret_result);
	} break;
	case CefBrowserHost_SetZoomLevel_11: {


		// gen! void SetZoomLevel(double zoomLevel)
		me->SetZoomLevel(v1->num);

	} break;
	case CefBrowserHost_RunFileDialog_12: {


		// gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
		me->RunFileDialog((CefBrowserHost::FileDialogMode)v1->i32,
			GetStringHolder(v2)->value,
			GetStringHolder(v3)->value,
			*((std::vector<CefString>*)v4->ptr),
			v5->i32,
			CefRunFileDialogCallbackCppToC::Unwrap((cef_run_file_dialog_callback_t*)v6->ptr));

	} break;
	case CefBrowserHost_StartDownload_13: {


		// gen! void StartDownload(const CefString& url)
		me->StartDownload(GetStringHolder(v1)->value);

	} break;
	case CefBrowserHost_DownloadImage_14: {


		// gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
		me->DownloadImage(GetStringHolder(v1)->value,
			v2->i32 != 0,
			v3->i32,
			v4->i32 != 0,
			CefDownloadImageCallbackCppToC::Unwrap((cef_download_image_callback_t*)v5->ptr));

	} break;
	case CefBrowserHost_Print_15: {


		// gen! void Print()
		me->Print();

	} break;
	case CefBrowserHost_PrintToPDF_16: {


		// gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
		me->PrintToPDF(GetStringHolder(v1)->value,
			*((CefPdfPrintSettings*)v2->ptr),
			CefPdfPrintCallbackCppToC::Unwrap((cef_pdf_print_callback_t*)v3->ptr));

	} break;
	case CefBrowserHost_Find_17: {


		// gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
		me->Find(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);

	} break;
	case CefBrowserHost_StopFinding_18: {


		// gen! void StopFinding(bool clearSelection)
		me->StopFinding(v1->i32 != 0);

	} break;
	case CefBrowserHost_ShowDevTools_19: {


		// gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
		me->ShowDevTools(*((CefWindowInfo*)v1->ptr),
			CefClientCppToC::Unwrap((cef_client_t*)v2->ptr),
			*((CefBrowserSettings*)v3->ptr),
			*((CefPoint*)v4->ptr));

	} break;
	case CefBrowserHost_CloseDevTools_20: {


		// gen! void CloseDevTools()
		me->CloseDevTools();

	} break;
	case CefBrowserHost_HasDevTools_21: {


		// gen! bool HasDevTools()
		auto ret_result = me->HasDevTools();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowserHost_GetNavigationEntries_22: {


		// gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
		me->GetNavigationEntries(CefNavigationEntryVisitorCppToC::Unwrap((cef_navigation_entry_visitor_t*)v1->ptr),
			v2->i32 != 0);

	} break;
	case CefBrowserHost_SetMouseCursorChangeDisabled_23: {


		// gen! void SetMouseCursorChangeDisabled(bool disabled)
		me->SetMouseCursorChangeDisabled(v1->i32 != 0);

	} break;
	case CefBrowserHost_IsMouseCursorChangeDisabled_24: {


		// gen! bool IsMouseCursorChangeDisabled()
		auto ret_result = me->IsMouseCursorChangeDisabled();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowserHost_ReplaceMisspelling_25: {


		// gen! void ReplaceMisspelling(const CefString& word)
		me->ReplaceMisspelling(GetStringHolder(v1)->value);

	} break;
	case CefBrowserHost_AddWordToDictionary_26: {


		// gen! void AddWordToDictionary(const CefString& word)
		me->AddWordToDictionary(GetStringHolder(v1)->value);

	} break;
	case CefBrowserHost_IsWindowRenderingDisabled_27: {


		// gen! bool IsWindowRenderingDisabled()
		auto ret_result = me->IsWindowRenderingDisabled();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBrowserHost_WasResized_28: {


		// gen! void WasResized()
		me->WasResized();

	} break;
	case CefBrowserHost_WasHidden_29: {


		// gen! void WasHidden(bool hidden)
		me->WasHidden(v1->i32 != 0);

	} break;
	case CefBrowserHost_NotifyScreenInfoChanged_30: {


		// gen! void NotifyScreenInfoChanged()
		me->NotifyScreenInfoChanged();

	} break;
	case CefBrowserHost_Invalidate_31: {


		// gen! void Invalidate(PaintElementType type)
		me->Invalidate((CefBrowserHost::PaintElementType)v1->i32);

	} break;
	case CefBrowserHost_SendKeyEvent_32: {


		// gen! void SendKeyEvent(const CefKeyEvent& event)
		me->SendKeyEvent(*((CefKeyEvent*)v1->ptr));

	} break;
	case CefBrowserHost_SendMouseClickEvent_33: {


		// gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
		me->SendMouseClickEvent(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::MouseButtonType)v2->i32,
			v3->i32 != 0,
			v4->i32);

	} break;
	case CefBrowserHost_SendMouseMoveEvent_34: {


		// gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
		me->SendMouseMoveEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32 != 0);

	} break;
	case CefBrowserHost_SendMouseWheelEvent_35: {


		// gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
		me->SendMouseWheelEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32,
			v3->i32);

	} break;
	case CefBrowserHost_SendFocusEvent_36: {


		// gen! void SendFocusEvent(bool setFocus)
		me->SendFocusEvent(v1->i32 != 0);

	} break;
	case CefBrowserHost_SendCaptureLostEvent_37: {


		// gen! void SendCaptureLostEvent()
		me->SendCaptureLostEvent();

	} break;
	case CefBrowserHost_NotifyMoveOrResizeStarted_38: {


		// gen! void NotifyMoveOrResizeStarted()
		me->NotifyMoveOrResizeStarted();

	} break;
	case CefBrowserHost_GetWindowlessFrameRate_39: {


		// gen! int GetWindowlessFrameRate()
		auto ret_result = me->GetWindowlessFrameRate();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefBrowserHost_SetWindowlessFrameRate_40: {


		// gen! void SetWindowlessFrameRate(int frame_rate)
		me->SetWindowlessFrameRate(v1->i32);

	} break;
	case CefBrowserHost_ImeSetComposition_41: {


		// gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
		me->ImeSetComposition(GetStringHolder(v1)->value,
			*((std::vector<CefCompositionUnderline>*)v2->ptr),
			*((CefRange*)v3->ptr),
			*((CefRange*)v4->ptr));

	} break;
	case CefBrowserHost_ImeCommitText_42: {


		// gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
		me->ImeCommitText(GetStringHolder(v1)->value,
			*((CefRange*)v2->ptr),
			v3->i32);

	} break;
	case CefBrowserHost_ImeFinishComposingText_43: {


		// gen! void ImeFinishComposingText(bool keep_selection)
		me->ImeFinishComposingText(v1->i32 != 0);

	} break;
	case CefBrowserHost_ImeCancelComposition_44: {


		// gen! void ImeCancelComposition()
		me->ImeCancelComposition();

	} break;
	case CefBrowserHost_DragTargetDragEnter_45: {


		// gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
		me->DragTargetDragEnter(CefDragDataCToCpp::Wrap((cef_drag_data_t*)v1->ptr),
			*((CefMouseEvent*)v2->ptr),
			(CefBrowserHost::DragOperationsMask)v3->i32);

	} break;
	case CefBrowserHost_DragTargetDragOver_46: {


		// gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
		me->DragTargetDragOver(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::DragOperationsMask)v2->i32);

	} break;
	case CefBrowserHost_DragTargetDragLeave_47: {


		// gen! void DragTargetDragLeave()
		me->DragTargetDragLeave();

	} break;
	case CefBrowserHost_DragTargetDrop_48: {


		// gen! void DragTargetDrop(const CefMouseEvent& event)
		me->DragTargetDrop(*((CefMouseEvent*)v1->ptr));

	} break;
	case CefBrowserHost_DragSourceEndedAt_49: {


		// gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
		me->DragSourceEndedAt(v1->i32,
			v2->i32,
			(CefBrowserHost::DragOperationsMask)v3->i32);

	} break;
	case CefBrowserHost_DragSourceSystemDragEnded_50: {


		// gen! void DragSourceSystemDragEnded()
		me->DragSourceSystemDragEnded();

	} break;
	case CefBrowserHost_GetVisibleNavigationEntry_51: {


		// gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
		auto ret_result = me->GetVisibleNavigationEntry();
		MyCefSetVoidPtr(ret, CefNavigationEntryCToCpp::Unwrap(ret_result));
	} break;
	case CefBrowserHost_SetAccessibilityState_52: {


		// gen! void SetAccessibilityState(cef_state_t accessibility_state)
		me->SetAccessibilityState((cef_state_t)v1->i32);

	} break;
	}
	CefBrowserHostCToCpp::Unwrap(me);
}


// [virtual] class CefClient
const int CefClient_GetContextMenuHandler_1 = 1;
const int CefClient_GetDialogHandler_2 = 2;
const int CefClient_GetDisplayHandler_3 = 3;
const int CefClient_GetDownloadHandler_4 = 4;
const int CefClient_GetDragHandler_5 = 5;
const int CefClient_GetFindHandler_6 = 6;
const int CefClient_GetFocusHandler_7 = 7;
const int CefClient_GetGeolocationHandler_8 = 8;
const int CefClient_GetJSDialogHandler_9 = 9;
const int CefClient_GetKeyboardHandler_10 = 10;
const int CefClient_GetLifeSpanHandler_11 = 11;
const int CefClient_GetLoadHandler_12 = 12;
const int CefClient_GetRenderHandler_13 = 13;
const int CefClient_GetRequestHandler_14 = 14;
const int CefClient_OnProcessMessageReceived_15 = 15;

void MyCefMet_CefClient(cef_client_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefClientCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefClient_GetContextMenuHandler_1: {


		// gen! CefRefPtr<CefContextMenuHandler> GetContextMenuHandler()
		auto ret_result = me->GetContextMenuHandler();
		MyCefSetVoidPtr(ret, CefContextMenuHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetDialogHandler_2: {


		// gen! CefRefPtr<CefDialogHandler> GetDialogHandler()
		auto ret_result = me->GetDialogHandler();
		MyCefSetVoidPtr(ret, CefDialogHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetDisplayHandler_3: {


		// gen! CefRefPtr<CefDisplayHandler> GetDisplayHandler()
		auto ret_result = me->GetDisplayHandler();
		MyCefSetVoidPtr(ret, CefDisplayHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetDownloadHandler_4: {


		// gen! CefRefPtr<CefDownloadHandler> GetDownloadHandler()
		auto ret_result = me->GetDownloadHandler();
		MyCefSetVoidPtr(ret, CefDownloadHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetDragHandler_5: {


		// gen! CefRefPtr<CefDragHandler> GetDragHandler()
		auto ret_result = me->GetDragHandler();
		MyCefSetVoidPtr(ret, CefDragHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetFindHandler_6: {


		// gen! CefRefPtr<CefFindHandler> GetFindHandler()
		auto ret_result = me->GetFindHandler();
		MyCefSetVoidPtr(ret, CefFindHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetFocusHandler_7: {


		// gen! CefRefPtr<CefFocusHandler> GetFocusHandler()
		auto ret_result = me->GetFocusHandler();
		MyCefSetVoidPtr(ret, CefFocusHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetGeolocationHandler_8: {


		// gen! CefRefPtr<CefGeolocationHandler> GetGeolocationHandler()
		auto ret_result = me->GetGeolocationHandler();
		MyCefSetVoidPtr(ret, CefGeolocationHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetJSDialogHandler_9: {


		// gen! CefRefPtr<CefJSDialogHandler> GetJSDialogHandler()
		auto ret_result = me->GetJSDialogHandler();
		MyCefSetVoidPtr(ret, CefJSDialogHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetKeyboardHandler_10: {


		// gen! CefRefPtr<CefKeyboardHandler> GetKeyboardHandler()
		auto ret_result = me->GetKeyboardHandler();
		MyCefSetVoidPtr(ret, CefKeyboardHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetLifeSpanHandler_11: {


		// gen! CefRefPtr<CefLifeSpanHandler> GetLifeSpanHandler()
		auto ret_result = me->GetLifeSpanHandler();
		MyCefSetVoidPtr(ret, CefLifeSpanHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetLoadHandler_12: {


		// gen! CefRefPtr<CefLoadHandler> GetLoadHandler()
		auto ret_result = me->GetLoadHandler();
		MyCefSetVoidPtr(ret, CefLoadHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetRenderHandler_13: {


		// gen! CefRefPtr<CefRenderHandler> GetRenderHandler()
		auto ret_result = me->GetRenderHandler();
		MyCefSetVoidPtr(ret, CefRenderHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_GetRequestHandler_14: {


		// gen! CefRefPtr<CefRequestHandler> GetRequestHandler()
		auto ret_result = me->GetRequestHandler();
		MyCefSetVoidPtr(ret, CefRequestHandlerCppToC::Wrap(ret_result));
	} break;
	case CefClient_OnProcessMessageReceived_15: {


		// gen! bool OnProcessMessageReceived(CefRefPtr<CefBrowser> browser,CefProcessId source_process,CefRefPtr<CefProcessMessage> message)
		auto ret_result = me->OnProcessMessageReceived(CefBrowserCToCpp::Wrap((cef_browser_t*)v1->ptr),
			(CefProcessId)v2->i32,
			CefProcessMessageCToCpp::Wrap((cef_process_message_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefClientCppToC::Wrap(me);
}
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
class MyCefClient :public CefClientCppToC {
public:
	managed_callback mcallback;
	explicit MyCefClient() {
		mcallback = NULL;
	}
	//gen! CefRefPtr<CefContextMenuHandler> GetContextMenuHandler()
	virtual CefRefPtr<CefContextMenuHandler> GetContextMenuHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetContextMenuHandler_1, &args);
			return CefContextMenuHandlerCppToC::Unwrap((cef_context_menu_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefDialogHandler> GetDialogHandler()
	virtual CefRefPtr<CefDialogHandler> GetDialogHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetDialogHandler_2, &args);
			return CefDialogHandlerCppToC::Unwrap((cef_dialog_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefDisplayHandler> GetDisplayHandler()
	virtual CefRefPtr<CefDisplayHandler> GetDisplayHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetDisplayHandler_3, &args);
			return CefDisplayHandlerCppToC::Unwrap((cef_display_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefDownloadHandler> GetDownloadHandler()
	virtual CefRefPtr<CefDownloadHandler> GetDownloadHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetDownloadHandler_4, &args);
			return CefDownloadHandlerCppToC::Unwrap((cef_download_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefDragHandler> GetDragHandler()
	virtual CefRefPtr<CefDragHandler> GetDragHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetDragHandler_5, &args);
			return CefDragHandlerCppToC::Unwrap((cef_drag_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefFindHandler> GetFindHandler()
	virtual CefRefPtr<CefFindHandler> GetFindHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetFindHandler_6, &args);
			return CefFindHandlerCppToC::Unwrap((cef_find_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefFocusHandler> GetFocusHandler()
	virtual CefRefPtr<CefFocusHandler> GetFocusHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetFocusHandler_7, &args);
			return CefFocusHandlerCppToC::Unwrap((cef_focus_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefGeolocationHandler> GetGeolocationHandler()
	virtual CefRefPtr<CefGeolocationHandler> GetGeolocationHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetGeolocationHandler_8, &args);
			return CefGeolocationHandlerCppToC::Unwrap((cef_geolocation_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefJSDialogHandler> GetJSDialogHandler()
	virtual CefRefPtr<CefJSDialogHandler> GetJSDialogHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetJSDialogHandler_9, &args);
			return CefJSDialogHandlerCppToC::Unwrap((cef_jsdialog_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefKeyboardHandler> GetKeyboardHandler()
	virtual CefRefPtr<CefKeyboardHandler> GetKeyboardHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetKeyboardHandler_10, &args);
			return CefKeyboardHandlerCppToC::Unwrap((cef_keyboard_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefLifeSpanHandler> GetLifeSpanHandler()
	virtual CefRefPtr<CefLifeSpanHandler> GetLifeSpanHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetLifeSpanHandler_11, &args);
			return CefLifeSpanHandlerCppToC::Unwrap((cef_life_span_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefLoadHandler> GetLoadHandler()
	virtual CefRefPtr<CefLoadHandler> GetLoadHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetLoadHandler_12, &args);
			return CefLoadHandlerCppToC::Unwrap((cef_load_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefRenderHandler> GetRenderHandler()
	virtual CefRefPtr<CefRenderHandler> GetRenderHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetRenderHandler_13, &args);
			return CefRenderHandlerCppToC::Unwrap((cef_render_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! CefRefPtr<CefRequestHandler> GetRequestHandler()
	virtual CefRefPtr<CefRequestHandler> GetRequestHandler() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefClient_GetRequestHandler_14, &args);
			return CefRequestHandlerCppToC::Unwrap((cef_request_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
	//gen! bool OnProcessMessageReceived(CefRefPtr<CefBrowser> browser,CefProcessId source_process,CefRefPtr<CefProcessMessage> message)
	virtual bool OnProcessMessageReceived(CefRefPtr<CefBrowser> browser, CefProcessId source_process, CefRefPtr<CefProcessMessage> message) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefBrowserCToCpp::Unwrap(browser));
			MyCefSetInt32(&args.v2, (int32_t)source_process);
			MyCefSetVoidPtr(&args.v3, CefProcessMessageCToCpp::Unwrap(message));
			this->mcallback(MyCefClient_OnProcessMessageReceived_15, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefCommandLine
const int CefCommandLine_IsValid_1 = 1;
const int CefCommandLine_IsReadOnly_2 = 2;
const int CefCommandLine_Copy_3 = 3;
const int CefCommandLine_InitFromArgv_4 = 4;
const int CefCommandLine_InitFromString_5 = 5;
const int CefCommandLine_Reset_6 = 6;
const int CefCommandLine_GetArgv_7 = 7;
const int CefCommandLine_GetCommandLineString_8 = 8;
const int CefCommandLine_GetProgram_9 = 9;
const int CefCommandLine_SetProgram_10 = 10;
const int CefCommandLine_HasSwitches_11 = 11;
const int CefCommandLine_HasSwitch_12 = 12;
const int CefCommandLine_GetSwitchValue_13 = 13;
const int CefCommandLine_GetSwitches_14 = 14;
const int CefCommandLine_AppendSwitch_15 = 15;
const int CefCommandLine_AppendSwitchWithValue_16 = 16;
const int CefCommandLine_HasArguments_17 = 17;
const int CefCommandLine_GetArguments_18 = 18;
const int CefCommandLine_AppendArgument_19 = 19;
const int CefCommandLine_PrependWrapper_20 = 20;

void MyCefMet_CefCommandLine(cef_command_line_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefCommandLineCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefCommandLine_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCommandLine_IsReadOnly_2: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCommandLine_Copy_3: {


		// gen! CefRefPtr<CefCommandLine> Copy()
		auto ret_result = me->Copy();
		MyCefSetVoidPtr(ret, CefCommandLineCToCpp::Unwrap(ret_result));
	} break;
	case CefCommandLine_InitFromArgv_4: {


		//// gen! void InitFromArgv(int argc,const char* const* argv)
		//me->InitFromArgv(v1->i32,
		//	v2->ptr);

	} break;
	case CefCommandLine_InitFromString_5: {


		// gen! void InitFromString(const CefString& command_line)
		me->InitFromString(GetStringHolder(v1)->value);

	} break;
	case CefCommandLine_Reset_6: {


		// gen! void Reset()
		me->Reset();

	} break;
	case CefCommandLine_GetArgv_7: {


		// gen! void GetArgv(std::vector<CefString>& argv)
		me->GetArgv(*((std::vector<CefString>*)v1->ptr));

	} break;
	case CefCommandLine_GetCommandLineString_8: {


		// gen! CefString GetCommandLineString()
		auto ret_result = me->GetCommandLineString();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefCommandLine_GetProgram_9: {


		// gen! CefString GetProgram()
		auto ret_result = me->GetProgram();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefCommandLine_SetProgram_10: {


		// gen! void SetProgram(const CefString& program)
		me->SetProgram(GetStringHolder(v1)->value);

	} break;
	case CefCommandLine_HasSwitches_11: {


		// gen! bool HasSwitches()
		auto ret_result = me->HasSwitches();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCommandLine_HasSwitch_12: {


		// gen! bool HasSwitch(const CefString& name)
		auto ret_result = me->HasSwitch(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCommandLine_GetSwitchValue_13: {


		// gen! CefString GetSwitchValue(const CefString& name)
		auto ret_result = me->GetSwitchValue(GetStringHolder(v1)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefCommandLine_GetSwitches_14: {


		// gen! void GetSwitches(SwitchMap& switches)
		me->GetSwitches(*((CefCommandLine::SwitchMap*)v1->ptr));

	} break;
	case CefCommandLine_AppendSwitch_15: {


		// gen! void AppendSwitch(const CefString& name)
		me->AppendSwitch(GetStringHolder(v1)->value);

	} break;
	case CefCommandLine_AppendSwitchWithValue_16: {


		// gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
		me->AppendSwitchWithValue(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);

	} break;
	case CefCommandLine_HasArguments_17: {


		// gen! bool HasArguments()
		auto ret_result = me->HasArguments();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCommandLine_GetArguments_18: {


		// gen! void GetArguments(ArgumentList& arguments)
		me->GetArguments(*((CefCommandLine::ArgumentList*)v1->ptr));

	} break;
	case CefCommandLine_AppendArgument_19: {


		// gen! void AppendArgument(const CefString& argument)
		me->AppendArgument(GetStringHolder(v1)->value);

	} break;
	case CefCommandLine_PrependWrapper_20: {


		// gen! void PrependWrapper(const CefString& wrapper)
		me->PrependWrapper(GetStringHolder(v1)->value);

	} break;
	}
	CefCommandLineCToCpp::Unwrap(me);
}


// [virtual] class CefContextMenuParams
const int CefContextMenuParams_GetXCoord_1 = 1;
const int CefContextMenuParams_GetYCoord_2 = 2;
const int CefContextMenuParams_GetTypeFlags_3 = 3;
const int CefContextMenuParams_GetLinkUrl_4 = 4;
const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = 5;
const int CefContextMenuParams_GetSourceUrl_6 = 6;
const int CefContextMenuParams_HasImageContents_7 = 7;
const int CefContextMenuParams_GetTitleText_8 = 8;
const int CefContextMenuParams_GetPageUrl_9 = 9;
const int CefContextMenuParams_GetFrameUrl_10 = 10;
const int CefContextMenuParams_GetFrameCharset_11 = 11;
const int CefContextMenuParams_GetMediaType_12 = 12;
const int CefContextMenuParams_GetMediaStateFlags_13 = 13;
const int CefContextMenuParams_GetSelectionText_14 = 14;
const int CefContextMenuParams_GetMisspelledWord_15 = 15;
const int CefContextMenuParams_GetDictionarySuggestions_16 = 16;
const int CefContextMenuParams_IsEditable_17 = 17;
const int CefContextMenuParams_IsSpellCheckEnabled_18 = 18;
const int CefContextMenuParams_GetEditStateFlags_19 = 19;
const int CefContextMenuParams_IsCustomMenu_20 = 20;
const int CefContextMenuParams_IsPepperMenu_21 = 21;

void MyCefMet_CefContextMenuParams(cef_context_menu_params_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefContextMenuParamsCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefContextMenuParams_GetXCoord_1: {


		// gen! int GetXCoord()
		auto ret_result = me->GetXCoord();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefContextMenuParams_GetYCoord_2: {


		// gen! int GetYCoord()
		auto ret_result = me->GetYCoord();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefContextMenuParams_GetTypeFlags_3: {


		// gen! TypeFlags GetTypeFlags()
		auto ret_result = me->GetTypeFlags();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefContextMenuParams_GetLinkUrl_4: {


		// gen! CefString GetLinkUrl()
		auto ret_result = me->GetLinkUrl();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetUnfilteredLinkUrl_5: {


		// gen! CefString GetUnfilteredLinkUrl()
		auto ret_result = me->GetUnfilteredLinkUrl();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetSourceUrl_6: {


		// gen! CefString GetSourceUrl()
		auto ret_result = me->GetSourceUrl();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_HasImageContents_7: {


		// gen! bool HasImageContents()
		auto ret_result = me->HasImageContents();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefContextMenuParams_GetTitleText_8: {


		// gen! CefString GetTitleText()
		auto ret_result = me->GetTitleText();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetPageUrl_9: {


		// gen! CefString GetPageUrl()
		auto ret_result = me->GetPageUrl();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetFrameUrl_10: {


		// gen! CefString GetFrameUrl()
		auto ret_result = me->GetFrameUrl();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetFrameCharset_11: {


		// gen! CefString GetFrameCharset()
		auto ret_result = me->GetFrameCharset();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetMediaType_12: {


		// gen! MediaType GetMediaType()
		auto ret_result = me->GetMediaType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefContextMenuParams_GetMediaStateFlags_13: {


		// gen! MediaStateFlags GetMediaStateFlags()
		auto ret_result = me->GetMediaStateFlags();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefContextMenuParams_GetSelectionText_14: {


		// gen! CefString GetSelectionText()
		auto ret_result = me->GetSelectionText();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetMisspelledWord_15: {


		// gen! CefString GetMisspelledWord()
		auto ret_result = me->GetMisspelledWord();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefContextMenuParams_GetDictionarySuggestions_16: {


		// gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
		auto ret_result = me->GetDictionarySuggestions(*((std::vector<CefString>*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefContextMenuParams_IsEditable_17: {


		// gen! bool IsEditable()
		auto ret_result = me->IsEditable();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefContextMenuParams_IsSpellCheckEnabled_18: {


		// gen! bool IsSpellCheckEnabled()
		auto ret_result = me->IsSpellCheckEnabled();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefContextMenuParams_GetEditStateFlags_19: {


		// gen! EditStateFlags GetEditStateFlags()
		auto ret_result = me->GetEditStateFlags();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefContextMenuParams_IsCustomMenu_20: {


		// gen! bool IsCustomMenu()
		auto ret_result = me->IsCustomMenu();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefContextMenuParams_IsPepperMenu_21: {


		// gen! bool IsPepperMenu()
		auto ret_result = me->IsPepperMenu();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefContextMenuParamsCToCpp::Unwrap(me);
}


// [virtual] class CefCookieManager
const int CefCookieManager_SetSupportedSchemes_1 = 1;
const int CefCookieManager_VisitAllCookies_2 = 2;
const int CefCookieManager_VisitUrlCookies_3 = 3;
const int CefCookieManager_SetCookie_4 = 4;
const int CefCookieManager_DeleteCookies_5 = 5;
const int CefCookieManager_SetStoragePath_6 = 6;
const int CefCookieManager_FlushStore_7 = 7;

void MyCefMet_CefCookieManager(cef_cookie_manager_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefCookieManagerCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefCookieManager_SetSupportedSchemes_1: {


		// gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
		me->SetSupportedSchemes(*((std::vector<CefString>*)v1->ptr),
			CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v2->ptr));

	} break;
	case CefCookieManager_VisitAllCookies_2: {


		// gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
		auto ret_result = me->VisitAllCookies(CefCookieVisitorCppToC::Unwrap((cef_cookie_visitor_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCookieManager_VisitUrlCookies_3: {


		// gen! bool VisitUrlCookies(const CefString& url,bool includeHttpOnly,CefRefPtr<CefCookieVisitor> visitor)
		auto ret_result = me->VisitUrlCookies(GetStringHolder(v1)->value,
			v2->i32 != 0,
			CefCookieVisitorCppToC::Unwrap((cef_cookie_visitor_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCookieManager_SetCookie_4: {


		// gen! bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
		auto ret_result = me->SetCookie(GetStringHolder(v1)->value,
			*((CefCookie*)v2->ptr),
			CefSetCookieCallbackCppToC::Unwrap((cef_set_cookie_callback_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCookieManager_DeleteCookies_5: {


		// gen! bool DeleteCookies(const CefString& url,const CefString& cookie_name,CefRefPtr<CefDeleteCookiesCallback> callback)
		auto ret_result = me->DeleteCookies(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefDeleteCookiesCallbackCppToC::Unwrap((cef_delete_cookies_callback_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCookieManager_SetStoragePath_6: {


		// gen! bool SetStoragePath(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->SetStoragePath(GetStringHolder(v1)->value,
			v2->i32 != 0,
			CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefCookieManager_FlushStore_7: {


		// gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->FlushStore(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefCookieManagerCToCpp::Unwrap(me);
}


// [virtual] class CefCookieVisitor
const int CefCookieVisitor_Visit_1 = 1;

void MyCefMet_CefCookieVisitor(cef_cookie_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefCookieVisitorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefCookieVisitor_Visit_1: {


		// gen! bool Visit(const CefCookie& cookie,int count,int total,bool& deleteCookie)
		auto ret_result = me->Visit(*((CefCookie*)v1->ptr),
			v2->i32,
			v3->i32,
			*((bool*)v4->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefCookieVisitorCppToC::Wrap(me);
}
const int MyCefCookieVisitor_Visit_1 = 1;
class MyCefCookieVisitor :public CefCookieVisitorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefCookieVisitor() {
		mcallback = NULL;
	}
	//gen! bool Visit(const CefCookie& cookie,int count,int total,bool& deleteCookie)
	virtual bool Visit(const CefCookie& cookie, int count, int total, bool& deleteCookie) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr2(&args.v1, &cookie);
			MyCefSetInt64(&args.v2, count);
			MyCefSetInt64(&args.v3, total);
			MyCefSetBool(&args.v4, deleteCookie);
			this->mcallback(MyCefCookieVisitor_Visit_1, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefDOMVisitor
const int CefDOMVisitor_Visit_1 = 1;

void MyCefMet_CefDOMVisitor(cef_domvisitor_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDOMVisitorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDOMVisitor_Visit_1: {


		// gen! void Visit(CefRefPtr<CefDOMDocument> document)
		me->Visit(CefDOMDocumentCToCpp::Wrap((cef_domdocument_t*)v1->ptr));

	} break;
	}
	CefDOMVisitorCppToC::Wrap(me);
}
const int MyCefDOMVisitor_Visit_1 = 1;
class MyCefDOMVisitor :public CefDOMVisitorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefDOMVisitor() {
		mcallback = NULL;
	}
	//gen! void Visit(CefRefPtr<CefDOMDocument> document)
	virtual void Visit(CefRefPtr<CefDOMDocument> document) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefDOMDocumentCToCpp::Unwrap(document));
			this->mcallback(MyCefDOMVisitor_Visit_1, &args);
		}
	}
};


// [virtual] class CefDOMDocument
const int CefDOMDocument_GetType_1 = 1;
const int CefDOMDocument_GetDocument_2 = 2;
const int CefDOMDocument_GetBody_3 = 3;
const int CefDOMDocument_GetHead_4 = 4;
const int CefDOMDocument_GetTitle_5 = 5;
const int CefDOMDocument_GetElementById_6 = 6;
const int CefDOMDocument_GetFocusedNode_7 = 7;
const int CefDOMDocument_HasSelection_8 = 8;
const int CefDOMDocument_GetSelectionStartOffset_9 = 9;
const int CefDOMDocument_GetSelectionEndOffset_10 = 10;
const int CefDOMDocument_GetSelectionAsMarkup_11 = 11;
const int CefDOMDocument_GetSelectionAsText_12 = 12;
const int CefDOMDocument_GetBaseURL_13 = 13;
const int CefDOMDocument_GetCompleteURL_14 = 14;

void MyCefMet_CefDOMDocument(cef_domdocument_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDOMDocumentCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDOMDocument_GetType_1: {


		// gen! Type GetType()
		auto ret_result = me->GetType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefDOMDocument_GetDocument_2: {


		// gen! CefRefPtr<CefDOMNode> GetDocument()
		auto ret_result = me->GetDocument();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMDocument_GetBody_3: {


		// gen! CefRefPtr<CefDOMNode> GetBody()
		auto ret_result = me->GetBody();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMDocument_GetHead_4: {


		// gen! CefRefPtr<CefDOMNode> GetHead()
		auto ret_result = me->GetHead();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMDocument_GetTitle_5: {


		// gen! CefString GetTitle()
		auto ret_result = me->GetTitle();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMDocument_GetElementById_6: {


		// gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
		auto ret_result = me->GetElementById(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMDocument_GetFocusedNode_7: {


		// gen! CefRefPtr<CefDOMNode> GetFocusedNode()
		auto ret_result = me->GetFocusedNode();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMDocument_HasSelection_8: {


		// gen! bool HasSelection()
		auto ret_result = me->HasSelection();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMDocument_GetSelectionStartOffset_9: {


		// gen! int GetSelectionStartOffset()
		auto ret_result = me->GetSelectionStartOffset();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDOMDocument_GetSelectionEndOffset_10: {


		// gen! int GetSelectionEndOffset()
		auto ret_result = me->GetSelectionEndOffset();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDOMDocument_GetSelectionAsMarkup_11: {


		// gen! CefString GetSelectionAsMarkup()
		auto ret_result = me->GetSelectionAsMarkup();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMDocument_GetSelectionAsText_12: {


		// gen! CefString GetSelectionAsText()
		auto ret_result = me->GetSelectionAsText();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMDocument_GetBaseURL_13: {


		// gen! CefString GetBaseURL()
		auto ret_result = me->GetBaseURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMDocument_GetCompleteURL_14: {


		// gen! CefString GetCompleteURL(const CefString& partialURL)
		auto ret_result = me->GetCompleteURL(GetStringHolder(v1)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	}
	CefDOMDocumentCToCpp::Unwrap(me);
}


// [virtual] class CefDOMNode
const int CefDOMNode_GetType_1 = 1;
const int CefDOMNode_IsText_2 = 2;
const int CefDOMNode_IsElement_3 = 3;
const int CefDOMNode_IsEditable_4 = 4;
const int CefDOMNode_IsFormControlElement_5 = 5;
const int CefDOMNode_GetFormControlElementType_6 = 6;
const int CefDOMNode_IsSame_7 = 7;
const int CefDOMNode_GetName_8 = 8;
const int CefDOMNode_GetValue_9 = 9;
const int CefDOMNode_SetValue_10 = 10;
const int CefDOMNode_GetAsMarkup_11 = 11;
const int CefDOMNode_GetDocument_12 = 12;
const int CefDOMNode_GetParent_13 = 13;
const int CefDOMNode_GetPreviousSibling_14 = 14;
const int CefDOMNode_GetNextSibling_15 = 15;
const int CefDOMNode_HasChildren_16 = 16;
const int CefDOMNode_GetFirstChild_17 = 17;
const int CefDOMNode_GetLastChild_18 = 18;
const int CefDOMNode_GetElementTagName_19 = 19;
const int CefDOMNode_HasElementAttributes_20 = 20;
const int CefDOMNode_HasElementAttribute_21 = 21;
const int CefDOMNode_GetElementAttribute_22 = 22;
const int CefDOMNode_GetElementAttributes_23 = 23;
const int CefDOMNode_SetElementAttribute_24 = 24;
const int CefDOMNode_GetElementInnerText_25 = 25;
const int CefDOMNode_GetElementBounds_26 = 26;

void MyCefMet_CefDOMNode(cef_domnode_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDOMNodeCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDOMNode_GetType_1: {


		// gen! Type GetType()
		auto ret_result = me->GetType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefDOMNode_IsText_2: {


		// gen! bool IsText()
		auto ret_result = me->IsText();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_IsElement_3: {


		// gen! bool IsElement()
		auto ret_result = me->IsElement();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_IsEditable_4: {


		// gen! bool IsEditable()
		auto ret_result = me->IsEditable();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_IsFormControlElement_5: {


		// gen! bool IsFormControlElement()
		auto ret_result = me->IsFormControlElement();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_GetFormControlElementType_6: {


		// gen! CefString GetFormControlElementType()
		auto ret_result = me->GetFormControlElementType();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_IsSame_7: {


		// gen! bool IsSame(CefRefPtr<CefDOMNode> that)
		auto ret_result = me->IsSame(CefDOMNodeCToCpp::Wrap((cef_domnode_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_GetName_8: {


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_GetValue_9: {


		// gen! CefString GetValue()
		auto ret_result = me->GetValue();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_SetValue_10: {


		// gen! bool SetValue(const CefString& value)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_GetAsMarkup_11: {


		// gen! CefString GetAsMarkup()
		auto ret_result = me->GetAsMarkup();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_GetDocument_12: {


		// gen! CefRefPtr<CefDOMDocument> GetDocument()
		auto ret_result = me->GetDocument();
		MyCefSetVoidPtr(ret, CefDOMDocumentCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMNode_GetParent_13: {


		// gen! CefRefPtr<CefDOMNode> GetParent()
		auto ret_result = me->GetParent();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMNode_GetPreviousSibling_14: {


		// gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
		auto ret_result = me->GetPreviousSibling();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMNode_GetNextSibling_15: {


		// gen! CefRefPtr<CefDOMNode> GetNextSibling()
		auto ret_result = me->GetNextSibling();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMNode_HasChildren_16: {


		// gen! bool HasChildren()
		auto ret_result = me->HasChildren();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_GetFirstChild_17: {


		// gen! CefRefPtr<CefDOMNode> GetFirstChild()
		auto ret_result = me->GetFirstChild();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMNode_GetLastChild_18: {


		// gen! CefRefPtr<CefDOMNode> GetLastChild()
		auto ret_result = me->GetLastChild();
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
	} break;
	case CefDOMNode_GetElementTagName_19: {


		// gen! CefString GetElementTagName()
		auto ret_result = me->GetElementTagName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_HasElementAttributes_20: {


		// gen! bool HasElementAttributes()
		auto ret_result = me->HasElementAttributes();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_HasElementAttribute_21: {


		// gen! bool HasElementAttribute(const CefString& attrName)
		auto ret_result = me->HasElementAttribute(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_GetElementAttribute_22: {


		// gen! CefString GetElementAttribute(const CefString& attrName)
		auto ret_result = me->GetElementAttribute(GetStringHolder(v1)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_GetElementAttributes_23: {


		// gen! void GetElementAttributes(AttributeMap& attrMap)
		me->GetElementAttributes(*((CefDOMNode::AttributeMap*)v1->ptr));

	} break;
	case CefDOMNode_SetElementAttribute_24: {


		// gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
		auto ret_result = me->SetElementAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDOMNode_GetElementInnerText_25: {


		// gen! CefString GetElementInnerText()
		auto ret_result = me->GetElementInnerText();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDOMNode_GetElementBounds_26: {


		// gen! CefRect GetElementBounds()
		auto ret_result = me->GetElementBounds();
		CefRect* tmp_d1 = new CefRect(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	}
	CefDOMNodeCToCpp::Unwrap(me);
}


// [virtual] class CefDownloadItem
const int CefDownloadItem_IsValid_1 = 1;
const int CefDownloadItem_IsInProgress_2 = 2;
const int CefDownloadItem_IsComplete_3 = 3;
const int CefDownloadItem_IsCanceled_4 = 4;
const int CefDownloadItem_GetCurrentSpeed_5 = 5;
const int CefDownloadItem_GetPercentComplete_6 = 6;
const int CefDownloadItem_GetTotalBytes_7 = 7;
const int CefDownloadItem_GetReceivedBytes_8 = 8;
const int CefDownloadItem_GetStartTime_9 = 9;
const int CefDownloadItem_GetEndTime_10 = 10;
const int CefDownloadItem_GetFullPath_11 = 11;
const int CefDownloadItem_GetId_12 = 12;
const int CefDownloadItem_GetURL_13 = 13;
const int CefDownloadItem_GetOriginalUrl_14 = 14;
const int CefDownloadItem_GetSuggestedFileName_15 = 15;
const int CefDownloadItem_GetContentDisposition_16 = 16;
const int CefDownloadItem_GetMimeType_17 = 17;

void MyCefMet_CefDownloadItem(cef_download_item_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDownloadItemCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDownloadItem_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDownloadItem_IsInProgress_2: {


		// gen! bool IsInProgress()
		auto ret_result = me->IsInProgress();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDownloadItem_IsComplete_3: {


		// gen! bool IsComplete()
		auto ret_result = me->IsComplete();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDownloadItem_IsCanceled_4: {


		// gen! bool IsCanceled()
		auto ret_result = me->IsCanceled();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDownloadItem_GetCurrentSpeed_5: {


		// gen! int64 GetCurrentSpeed()
		auto ret_result = me->GetCurrentSpeed();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDownloadItem_GetPercentComplete_6: {


		// gen! int GetPercentComplete()
		auto ret_result = me->GetPercentComplete();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDownloadItem_GetTotalBytes_7: {


		// gen! int64 GetTotalBytes()
		auto ret_result = me->GetTotalBytes();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDownloadItem_GetReceivedBytes_8: {


		// gen! int64 GetReceivedBytes()
		auto ret_result = me->GetReceivedBytes();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDownloadItem_GetStartTime_9: {


		// gen! CefTime GetStartTime()
		auto ret_result = me->GetStartTime();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefDownloadItem_GetEndTime_10: {


		// gen! CefTime GetEndTime()
		auto ret_result = me->GetEndTime();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefDownloadItem_GetFullPath_11: {


		// gen! CefString GetFullPath()
		auto ret_result = me->GetFullPath();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDownloadItem_GetId_12: {


		// gen! uint32 GetId()
		auto ret_result = me->GetId();
		MyCefSetUInt32(ret, ret_result);
	} break;
	case CefDownloadItem_GetURL_13: {


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDownloadItem_GetOriginalUrl_14: {


		// gen! CefString GetOriginalUrl()
		auto ret_result = me->GetOriginalUrl();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDownloadItem_GetSuggestedFileName_15: {


		// gen! CefString GetSuggestedFileName()
		auto ret_result = me->GetSuggestedFileName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDownloadItem_GetContentDisposition_16: {


		// gen! CefString GetContentDisposition()
		auto ret_result = me->GetContentDisposition();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDownloadItem_GetMimeType_17: {


		// gen! CefString GetMimeType()
		auto ret_result = me->GetMimeType();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	}
	CefDownloadItemCToCpp::Unwrap(me);
}


// [virtual] class CefDragData
const int CefDragData_Clone_1 = 1;
const int CefDragData_IsReadOnly_2 = 2;
const int CefDragData_IsLink_3 = 3;
const int CefDragData_IsFragment_4 = 4;
const int CefDragData_IsFile_5 = 5;
const int CefDragData_GetLinkURL_6 = 6;
const int CefDragData_GetLinkTitle_7 = 7;
const int CefDragData_GetLinkMetadata_8 = 8;
const int CefDragData_GetFragmentText_9 = 9;
const int CefDragData_GetFragmentHtml_10 = 10;
const int CefDragData_GetFragmentBaseURL_11 = 11;
const int CefDragData_GetFileName_12 = 12;
const int CefDragData_GetFileContents_13 = 13;
const int CefDragData_GetFileNames_14 = 14;
const int CefDragData_SetLinkURL_15 = 15;
const int CefDragData_SetLinkTitle_16 = 16;
const int CefDragData_SetLinkMetadata_17 = 17;
const int CefDragData_SetFragmentText_18 = 18;
const int CefDragData_SetFragmentHtml_19 = 19;
const int CefDragData_SetFragmentBaseURL_20 = 20;
const int CefDragData_ResetFileContents_21 = 21;
const int CefDragData_AddFile_22 = 22;
const int CefDragData_GetImage_23 = 23;
const int CefDragData_GetImageHotspot_24 = 24;
const int CefDragData_HasImage_25 = 25;

void MyCefMet_CefDragData(cef_drag_data_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDragDataCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDragData_Clone_1: {


		// gen! CefRefPtr<CefDragData> Clone()
		auto ret_result = me->Clone();
		MyCefSetVoidPtr(ret, CefDragDataCToCpp::Unwrap(ret_result));
	} break;
	case CefDragData_IsReadOnly_2: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDragData_IsLink_3: {


		// gen! bool IsLink()
		auto ret_result = me->IsLink();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDragData_IsFragment_4: {


		// gen! bool IsFragment()
		auto ret_result = me->IsFragment();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDragData_IsFile_5: {


		// gen! bool IsFile()
		auto ret_result = me->IsFile();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDragData_GetLinkURL_6: {


		// gen! CefString GetLinkURL()
		auto ret_result = me->GetLinkURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetLinkTitle_7: {


		// gen! CefString GetLinkTitle()
		auto ret_result = me->GetLinkTitle();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetLinkMetadata_8: {


		// gen! CefString GetLinkMetadata()
		auto ret_result = me->GetLinkMetadata();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetFragmentText_9: {


		// gen! CefString GetFragmentText()
		auto ret_result = me->GetFragmentText();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetFragmentHtml_10: {


		// gen! CefString GetFragmentHtml()
		auto ret_result = me->GetFragmentHtml();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetFragmentBaseURL_11: {


		// gen! CefString GetFragmentBaseURL()
		auto ret_result = me->GetFragmentBaseURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetFileName_12: {


		// gen! CefString GetFileName()
		auto ret_result = me->GetFileName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDragData_GetFileContents_13: {


		// gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
		auto ret_result = me->GetFileContents(CefStreamWriterCToCpp::Wrap((cef_stream_writer_t*)v1->ptr));
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefDragData_GetFileNames_14: {


		// gen! bool GetFileNames(std::vector<CefString>& names)
		auto ret_result = me->GetFileNames(*((std::vector<CefString>*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDragData_SetLinkURL_15: {


		// gen! void SetLinkURL(const CefString& url)
		me->SetLinkURL(GetStringHolder(v1)->value);

	} break;
	case CefDragData_SetLinkTitle_16: {


		// gen! void SetLinkTitle(const CefString& title)
		me->SetLinkTitle(GetStringHolder(v1)->value);

	} break;
	case CefDragData_SetLinkMetadata_17: {


		// gen! void SetLinkMetadata(const CefString& data)
		me->SetLinkMetadata(GetStringHolder(v1)->value);

	} break;
	case CefDragData_SetFragmentText_18: {


		// gen! void SetFragmentText(const CefString& text)
		me->SetFragmentText(GetStringHolder(v1)->value);

	} break;
	case CefDragData_SetFragmentHtml_19: {


		// gen! void SetFragmentHtml(const CefString& html)
		me->SetFragmentHtml(GetStringHolder(v1)->value);

	} break;
	case CefDragData_SetFragmentBaseURL_20: {


		// gen! void SetFragmentBaseURL(const CefString& base_url)
		me->SetFragmentBaseURL(GetStringHolder(v1)->value);

	} break;
	case CefDragData_ResetFileContents_21: {


		// gen! void ResetFileContents()
		me->ResetFileContents();

	} break;
	case CefDragData_AddFile_22: {


		// gen! void AddFile(const CefString& path,const CefString& display_name)
		me->AddFile(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);

	} break;
	case CefDragData_GetImage_23: {


		// gen! CefRefPtr<CefImage> GetImage()
		auto ret_result = me->GetImage();
		MyCefSetVoidPtr(ret, CefImageCToCpp::Unwrap(ret_result));
	} break;
	case CefDragData_GetImageHotspot_24: {


		// gen! CefPoint GetImageHotspot()
		auto ret_result = me->GetImageHotspot();
		CefPoint* tmp_d1 = new CefPoint(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefDragData_HasImage_25: {


		// gen! bool HasImage()
		auto ret_result = me->HasImage();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefDragDataCToCpp::Unwrap(me);
}


// [virtual] class CefFrame
const int CefFrame_IsValid_1 = 1;
const int CefFrame_Undo_2 = 2;
const int CefFrame_Redo_3 = 3;
const int CefFrame_Cut_4 = 4;
const int CefFrame_Copy_5 = 5;
const int CefFrame_Paste_6 = 6;
const int CefFrame_Delete_7 = 7;
const int CefFrame_SelectAll_8 = 8;
const int CefFrame_ViewSource_9 = 9;
const int CefFrame_GetSource_10 = 10;
const int CefFrame_GetText_11 = 11;
const int CefFrame_LoadRequest_12 = 12;
const int CefFrame_LoadURL_13 = 13;
const int CefFrame_LoadString_14 = 14;
const int CefFrame_ExecuteJavaScript_15 = 15;
const int CefFrame_IsMain_16 = 16;
const int CefFrame_IsFocused_17 = 17;
const int CefFrame_GetName_18 = 18;
const int CefFrame_GetIdentifier_19 = 19;
const int CefFrame_GetParent_20 = 20;
const int CefFrame_GetURL_21 = 21;
const int CefFrame_GetBrowser_22 = 22;
const int CefFrame_GetV8Context_23 = 23;
const int CefFrame_VisitDOM_24 = 24;

void MyCefMet_CefFrame(cef_frame_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefFrameCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefFrame_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefFrame_Undo_2: {


		// gen! void Undo()
		me->Undo();

	} break;
	case CefFrame_Redo_3: {


		// gen! void Redo()
		me->Redo();

	} break;
	case CefFrame_Cut_4: {


		// gen! void Cut()
		me->Cut();

	} break;
	case CefFrame_Copy_5: {


		// gen! void Copy()
		me->Copy();

	} break;
	case CefFrame_Paste_6: {


		// gen! void Paste()
		me->Paste();

	} break;
	case CefFrame_Delete_7: {


		// gen! void Delete()
		me->Delete();

	} break;
	case CefFrame_SelectAll_8: {


		// gen! void SelectAll()
		me->SelectAll();

	} break;
	case CefFrame_ViewSource_9: {


		// gen! void ViewSource()
		me->ViewSource();

	} break;
	case CefFrame_GetSource_10: {


		// gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
		me->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));

	} break;
	case CefFrame_GetText_11: {


		// gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
		me->GetText(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));

	} break;
	case CefFrame_LoadRequest_12: {


		// gen! void LoadRequest(CefRefPtr<CefRequest> request)
		me->LoadRequest(CefRequestCToCpp::Wrap((cef_request_t*)v1->ptr));

	} break;
	case CefFrame_LoadURL_13: {


		// gen! void LoadURL(const CefString& url)
		me->LoadURL(GetStringHolder(v1)->value);

	} break;
	case CefFrame_LoadString_14: {


		// gen! void LoadString(const CefString& string_val,const CefString& url)
		me->LoadString(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);

	} break;
	case CefFrame_ExecuteJavaScript_15: {


		// gen! void ExecuteJavaScript(const CefString& code,const CefString& script_url,int start_line)
		me->ExecuteJavaScript(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			v3->i32);

	} break;
	case CefFrame_IsMain_16: {


		// gen! bool IsMain()
		auto ret_result = me->IsMain();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefFrame_IsFocused_17: {


		// gen! bool IsFocused()
		auto ret_result = me->IsFocused();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefFrame_GetName_18: {


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefFrame_GetIdentifier_19: {


		// gen! int64 GetIdentifier()
		auto ret_result = me->GetIdentifier();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefFrame_GetParent_20: {


		// gen! CefRefPtr<CefFrame> GetParent()
		auto ret_result = me->GetParent();
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
	} break;
	case CefFrame_GetURL_21: {


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefFrame_GetBrowser_22: {


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
	} break;
	case CefFrame_GetV8Context_23: {


		// gen! CefRefPtr<CefV8Context> GetV8Context()
		auto ret_result = me->GetV8Context();
		MyCefSetVoidPtr(ret, CefV8ContextCToCpp::Unwrap(ret_result));
	} break;
	case CefFrame_VisitDOM_24: {


		// gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
		me->VisitDOM(CefDOMVisitorCppToC::Unwrap((cef_domvisitor_t*)v1->ptr));

	} break;
	}
	CefFrameCToCpp::Unwrap(me);
}


// [virtual] class CefImage
const int CefImage_IsEmpty_1 = 1;
const int CefImage_IsSame_2 = 2;
const int CefImage_AddBitmap_3 = 3;
const int CefImage_AddPNG_4 = 4;
const int CefImage_AddJPEG_5 = 5;
const int CefImage_GetWidth_6 = 6;
const int CefImage_GetHeight_7 = 7;
const int CefImage_HasRepresentation_8 = 8;
const int CefImage_RemoveRepresentation_9 = 9;
const int CefImage_GetRepresentationInfo_10 = 10;
const int CefImage_GetAsBitmap_11 = 11;
const int CefImage_GetAsPNG_12 = 12;
const int CefImage_GetAsJPEG_13 = 13;

void MyCefMet_CefImage(cef_image_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefImageCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefImage_IsEmpty_1: {


		// gen! bool IsEmpty()
		auto ret_result = me->IsEmpty();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_IsSame_2: {


		// gen! bool IsSame(CefRefPtr<CefImage> that)
		auto ret_result = me->IsSame(CefImageCToCpp::Wrap((cef_image_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_AddBitmap_3: {


		// gen! bool AddBitmap(float scale_factor,int pixel_width,int pixel_height,cef_color_type_t color_type,cef_alpha_type_t alpha_type,const void* pixel_data,size_t pixel_data_size)
		auto ret_result = me->AddBitmap(v1->num,
			v2->i32,
			v3->i32,
			(cef_color_type_t)v4->i32,
			(cef_alpha_type_t)v5->i32,
			(void*)v6->ptr,
			v7->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_AddPNG_4: {


		// gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
		auto ret_result = me->AddPNG(v1->num,
			(void*)v2->ptr,
			v3->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_AddJPEG_5: {


		// gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
		auto ret_result = me->AddJPEG(v1->num,
			(void*)v2->ptr,
			v3->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_GetWidth_6: {


		// gen! size_t GetWidth()
		auto ret_result = me->GetWidth();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefImage_GetHeight_7: {


		// gen! size_t GetHeight()
		auto ret_result = me->GetHeight();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefImage_HasRepresentation_8: {


		// gen! bool HasRepresentation(float scale_factor)
		auto ret_result = me->HasRepresentation(v1->num);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_RemoveRepresentation_9: {


		// gen! bool RemoveRepresentation(float scale_factor)
		auto ret_result = me->RemoveRepresentation(v1->num);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_GetRepresentationInfo_10: {


		// gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetRepresentationInfo(v1->num,
			*((float*)v2->ptr),
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefImage_GetAsBitmap_11: {


		// gen! CefRefPtr<CefBinaryValue> GetAsBitmap(float scale_factor,cef_color_type_t color_type,cef_alpha_type_t alpha_type,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsBitmap(v1->num,
			(cef_color_type_t)v2->i32,
			(cef_alpha_type_t)v3->i32,
			*((int*)v4->ptr),
			*((int*)v5->ptr));
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefImage_GetAsPNG_12: {


		// gen! CefRefPtr<CefBinaryValue> GetAsPNG(float scale_factor,bool with_transparency,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsPNG(v1->num,
			v2->i32 != 0,
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefImage_GetAsJPEG_13: {


		// gen! CefRefPtr<CefBinaryValue> GetAsJPEG(float scale_factor,int quality,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsJPEG(v1->num,
			v2->i32,
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	}
	CefImageCToCpp::Unwrap(me);
}


// [virtual] class CefMenuModel
const int CefMenuModel_IsSubMenu_1 = 1;
const int CefMenuModel_Clear_2 = 2;
const int CefMenuModel_GetCount_3 = 3;
const int CefMenuModel_AddSeparator_4 = 4;
const int CefMenuModel_AddItem_5 = 5;
const int CefMenuModel_AddCheckItem_6 = 6;
const int CefMenuModel_AddRadioItem_7 = 7;
const int CefMenuModel_AddSubMenu_8 = 8;
const int CefMenuModel_InsertSeparatorAt_9 = 9;
const int CefMenuModel_InsertItemAt_10 = 10;
const int CefMenuModel_InsertCheckItemAt_11 = 11;
const int CefMenuModel_InsertRadioItemAt_12 = 12;
const int CefMenuModel_InsertSubMenuAt_13 = 13;
const int CefMenuModel_Remove_14 = 14;
const int CefMenuModel_RemoveAt_15 = 15;
const int CefMenuModel_GetIndexOf_16 = 16;
const int CefMenuModel_GetCommandIdAt_17 = 17;
const int CefMenuModel_SetCommandIdAt_18 = 18;
const int CefMenuModel_GetLabel_19 = 19;
const int CefMenuModel_GetLabelAt_20 = 20;
const int CefMenuModel_SetLabel_21 = 21;
const int CefMenuModel_SetLabelAt_22 = 22;
const int CefMenuModel_GetType_23 = 23;
const int CefMenuModel_GetTypeAt_24 = 24;
const int CefMenuModel_GetGroupId_25 = 25;
const int CefMenuModel_GetGroupIdAt_26 = 26;
const int CefMenuModel_SetGroupId_27 = 27;
const int CefMenuModel_SetGroupIdAt_28 = 28;
const int CefMenuModel_GetSubMenu_29 = 29;
const int CefMenuModel_GetSubMenuAt_30 = 30;
const int CefMenuModel_IsVisible_31 = 31;
const int CefMenuModel_IsVisibleAt_32 = 32;
const int CefMenuModel_SetVisible_33 = 33;
const int CefMenuModel_SetVisibleAt_34 = 34;
const int CefMenuModel_IsEnabled_35 = 35;
const int CefMenuModel_IsEnabledAt_36 = 36;
const int CefMenuModel_SetEnabled_37 = 37;
const int CefMenuModel_SetEnabledAt_38 = 38;
const int CefMenuModel_IsChecked_39 = 39;
const int CefMenuModel_IsCheckedAt_40 = 40;
const int CefMenuModel_SetChecked_41 = 41;
const int CefMenuModel_SetCheckedAt_42 = 42;
const int CefMenuModel_HasAccelerator_43 = 43;
const int CefMenuModel_HasAcceleratorAt_44 = 44;
const int CefMenuModel_SetAccelerator_45 = 45;
const int CefMenuModel_SetAcceleratorAt_46 = 46;
const int CefMenuModel_RemoveAccelerator_47 = 47;
const int CefMenuModel_RemoveAcceleratorAt_48 = 48;
const int CefMenuModel_GetAccelerator_49 = 49;
const int CefMenuModel_GetAcceleratorAt_50 = 50;
const int CefMenuModel_SetColor_51 = 51;
const int CefMenuModel_SetColorAt_52 = 52;
const int CefMenuModel_GetColor_53 = 53;
const int CefMenuModel_GetColorAt_54 = 54;
const int CefMenuModel_SetFontList_55 = 55;
const int CefMenuModel_SetFontListAt_56 = 56;

void MyCefMet_CefMenuModel(cef_menu_model_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefMenuModelCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefMenuModel_IsSubMenu_1: {


		// gen! bool IsSubMenu()
		auto ret_result = me->IsSubMenu();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_Clear_2: {


		// gen! bool Clear()
		auto ret_result = me->Clear();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetCount_3: {


		// gen! int GetCount()
		auto ret_result = me->GetCount();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefMenuModel_AddSeparator_4: {


		// gen! bool AddSeparator()
		auto ret_result = me->AddSeparator();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_AddItem_5: {


		// gen! bool AddItem(int command_id,const CefString& label)
		auto ret_result = me->AddItem(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_AddCheckItem_6: {


		// gen! bool AddCheckItem(int command_id,const CefString& label)
		auto ret_result = me->AddCheckItem(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_AddRadioItem_7: {


		// gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
		auto ret_result = me->AddRadioItem(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_AddSubMenu_8: {


		// gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
		auto ret_result = me->AddSubMenu(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
	} break;
	case CefMenuModel_InsertSeparatorAt_9: {


		// gen! bool InsertSeparatorAt(int index)
		auto ret_result = me->InsertSeparatorAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_InsertItemAt_10: {


		// gen! bool InsertItemAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_InsertCheckItemAt_11: {


		// gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertCheckItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_InsertRadioItemAt_12: {


		// gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
		auto ret_result = me->InsertRadioItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value,
			v4->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_InsertSubMenuAt_13: {


		// gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertSubMenuAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
	} break;
	case CefMenuModel_Remove_14: {


		// gen! bool Remove(int command_id)
		auto ret_result = me->Remove(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_RemoveAt_15: {


		// gen! bool RemoveAt(int index)
		auto ret_result = me->RemoveAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetIndexOf_16: {


		// gen! int GetIndexOf(int command_id)
		auto ret_result = me->GetIndexOf(v1->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefMenuModel_GetCommandIdAt_17: {


		// gen! int GetCommandIdAt(int index)
		auto ret_result = me->GetCommandIdAt(v1->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefMenuModel_SetCommandIdAt_18: {


		// gen! bool SetCommandIdAt(int index,int command_id)
		auto ret_result = me->SetCommandIdAt(v1->i32,
			v2->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetLabel_19: {


		// gen! CefString GetLabel(int command_id)
		auto ret_result = me->GetLabel(v1->i32);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefMenuModel_GetLabelAt_20: {


		// gen! CefString GetLabelAt(int index)
		auto ret_result = me->GetLabelAt(v1->i32);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefMenuModel_SetLabel_21: {


		// gen! bool SetLabel(int command_id,const CefString& label)
		auto ret_result = me->SetLabel(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetLabelAt_22: {


		// gen! bool SetLabelAt(int index,const CefString& label)
		auto ret_result = me->SetLabelAt(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetType_23: {


		// gen! MenuItemType GetType(int command_id)
		auto ret_result = me->GetType(v1->i32);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefMenuModel_GetTypeAt_24: {


		// gen! MenuItemType GetTypeAt(int index)
		auto ret_result = me->GetTypeAt(v1->i32);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefMenuModel_GetGroupId_25: {


		// gen! int GetGroupId(int command_id)
		auto ret_result = me->GetGroupId(v1->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefMenuModel_GetGroupIdAt_26: {


		// gen! int GetGroupIdAt(int index)
		auto ret_result = me->GetGroupIdAt(v1->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefMenuModel_SetGroupId_27: {


		// gen! bool SetGroupId(int command_id,int group_id)
		auto ret_result = me->SetGroupId(v1->i32,
			v2->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetGroupIdAt_28: {


		// gen! bool SetGroupIdAt(int index,int group_id)
		auto ret_result = me->SetGroupIdAt(v1->i32,
			v2->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetSubMenu_29: {


		// gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
		auto ret_result = me->GetSubMenu(v1->i32);
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
	} break;
	case CefMenuModel_GetSubMenuAt_30: {


		// gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
		auto ret_result = me->GetSubMenuAt(v1->i32);
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
	} break;
	case CefMenuModel_IsVisible_31: {


		// gen! bool IsVisible(int command_id)
		auto ret_result = me->IsVisible(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_IsVisibleAt_32: {


		// gen! bool IsVisibleAt(int index)
		auto ret_result = me->IsVisibleAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetVisible_33: {


		// gen! bool SetVisible(int command_id,bool visible)
		auto ret_result = me->SetVisible(v1->i32,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetVisibleAt_34: {


		// gen! bool SetVisibleAt(int index,bool visible)
		auto ret_result = me->SetVisibleAt(v1->i32,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_IsEnabled_35: {


		// gen! bool IsEnabled(int command_id)
		auto ret_result = me->IsEnabled(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_IsEnabledAt_36: {


		// gen! bool IsEnabledAt(int index)
		auto ret_result = me->IsEnabledAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetEnabled_37: {


		// gen! bool SetEnabled(int command_id,bool enabled)
		auto ret_result = me->SetEnabled(v1->i32,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetEnabledAt_38: {


		// gen! bool SetEnabledAt(int index,bool enabled)
		auto ret_result = me->SetEnabledAt(v1->i32,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_IsChecked_39: {


		// gen! bool IsChecked(int command_id)
		auto ret_result = me->IsChecked(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_IsCheckedAt_40: {


		// gen! bool IsCheckedAt(int index)
		auto ret_result = me->IsCheckedAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetChecked_41: {


		// gen! bool SetChecked(int command_id,bool checked)
		auto ret_result = me->SetChecked(v1->i32,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetCheckedAt_42: {


		// gen! bool SetCheckedAt(int index,bool checked)
		auto ret_result = me->SetCheckedAt(v1->i32,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_HasAccelerator_43: {


		// gen! bool HasAccelerator(int command_id)
		auto ret_result = me->HasAccelerator(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_HasAcceleratorAt_44: {


		// gen! bool HasAcceleratorAt(int index)
		auto ret_result = me->HasAcceleratorAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetAccelerator_45: {


		// gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
		auto ret_result = me->SetAccelerator(v1->i32,
			v2->i32,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetAcceleratorAt_46: {


		// gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
		auto ret_result = me->SetAcceleratorAt(v1->i32,
			v2->i32,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_RemoveAccelerator_47: {


		// gen! bool RemoveAccelerator(int command_id)
		auto ret_result = me->RemoveAccelerator(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_RemoveAcceleratorAt_48: {


		// gen! bool RemoveAcceleratorAt(int index)
		auto ret_result = me->RemoveAcceleratorAt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetAccelerator_49: {


		// gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
		auto ret_result = me->GetAccelerator(v1->i32,
			*((int*)v2->ptr),
			*((bool*)v3->ptr),
			*((bool*)v4->ptr),
			*((bool*)v5->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetAcceleratorAt_50: {


		// gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
		auto ret_result = me->GetAcceleratorAt(v1->i32,
			*((int*)v2->ptr),
			*((bool*)v3->ptr),
			*((bool*)v4->ptr),
			*((bool*)v5->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetColor_51: {


		// gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
		auto ret_result = me->SetColor(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			(cef_color_t)v3->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetColorAt_52: {


		// gen! bool SetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t color)
		auto ret_result = me->SetColorAt(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			(cef_color_t)v3->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetColor_53: {


		// gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
		auto ret_result = me->GetColor(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			*((cef_color_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_GetColorAt_54: {


		// gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
		auto ret_result = me->GetColorAt(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			*((cef_color_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetFontList_55: {


		// gen! bool SetFontList(int command_id,const CefString& font_list)
		auto ret_result = me->SetFontList(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefMenuModel_SetFontListAt_56: {


		// gen! bool SetFontListAt(int index,const CefString& font_list)
		auto ret_result = me->SetFontListAt(v1->i32,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefMenuModelCToCpp::Unwrap(me);
}


// [virtual] class CefMenuModelDelegate
const int CefMenuModelDelegate_ExecuteCommand_1 = 1;
const int CefMenuModelDelegate_MouseOutsideMenu_2 = 2;
const int CefMenuModelDelegate_UnhandledOpenSubmenu_3 = 3;
const int CefMenuModelDelegate_UnhandledCloseSubmenu_4 = 4;
const int CefMenuModelDelegate_MenuWillShow_5 = 5;
const int CefMenuModelDelegate_MenuClosed_6 = 6;
const int CefMenuModelDelegate_FormatLabel_7 = 7;

void MyCefMet_CefMenuModelDelegate(cef_menu_model_delegate_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefMenuModelDelegateCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefMenuModelDelegate_ExecuteCommand_1: {


		// gen! void ExecuteCommand(CefRefPtr<CefMenuModel> menu_model,int command_id,cef_event_flags_t event_flags)
		me->ExecuteCommand(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr),
			v2->i32,
			(cef_event_flags_t)v3->i32);

	} break;
	case CefMenuModelDelegate_MouseOutsideMenu_2: {


		// gen! void MouseOutsideMenu(CefRefPtr<CefMenuModel> menu_model,const CefPoint& screen_point)
		me->MouseOutsideMenu(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr),
			*((CefPoint*)v2->ptr));

	} break;
	case CefMenuModelDelegate_UnhandledOpenSubmenu_3: {


		// gen! void UnhandledOpenSubmenu(CefRefPtr<CefMenuModel> menu_model,bool is_rtl)
		me->UnhandledOpenSubmenu(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr),
			v2->i32 != 0);

	} break;
	case CefMenuModelDelegate_UnhandledCloseSubmenu_4: {


		// gen! void UnhandledCloseSubmenu(CefRefPtr<CefMenuModel> menu_model,bool is_rtl)
		me->UnhandledCloseSubmenu(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr),
			v2->i32 != 0);

	} break;
	case CefMenuModelDelegate_MenuWillShow_5: {


		// gen! void MenuWillShow(CefRefPtr<CefMenuModel> menu_model)
		me->MenuWillShow(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr));

	} break;
	case CefMenuModelDelegate_MenuClosed_6: {


		// gen! void MenuClosed(CefRefPtr<CefMenuModel> menu_model)
		me->MenuClosed(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr));

	} break;
	case CefMenuModelDelegate_FormatLabel_7: {


		// gen! bool FormatLabel(CefRefPtr<CefMenuModel> menu_model,CefString& label)
		auto ret_result = me->FormatLabel(CefMenuModelCToCpp::Wrap((cef_menu_model_t*)v1->ptr),
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefMenuModelDelegateCppToC::Wrap(me);
}
const int MyCefMenuModelDelegate_ExecuteCommand_1 = 1;
const int MyCefMenuModelDelegate_MouseOutsideMenu_2 = 2;
const int MyCefMenuModelDelegate_UnhandledOpenSubmenu_3 = 3;
const int MyCefMenuModelDelegate_UnhandledCloseSubmenu_4 = 4;
const int MyCefMenuModelDelegate_MenuWillShow_5 = 5;
const int MyCefMenuModelDelegate_MenuClosed_6 = 6;
const int MyCefMenuModelDelegate_FormatLabel_7 = 7;
class MyCefMenuModelDelegate :public CefMenuModelDelegateCppToC {
public:
	managed_callback mcallback;
	explicit MyCefMenuModelDelegate() {
		mcallback = NULL;
	}
	//gen! void ExecuteCommand(CefRefPtr<CefMenuModel> menu_model,int command_id,cef_event_flags_t event_flags)
	virtual void ExecuteCommand(CefRefPtr<CefMenuModel> menu_model, int command_id, cef_event_flags_t event_flags) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			MyCefSetInt64(&args.v2, command_id);
			MyCefSetInt32(&args.v3, (int32_t)event_flags);
			this->mcallback(MyCefMenuModelDelegate_ExecuteCommand_1, &args);
		}
	}
	//gen! void MouseOutsideMenu(CefRefPtr<CefMenuModel> menu_model,const CefPoint& screen_point)
	virtual void MouseOutsideMenu(CefRefPtr<CefMenuModel> menu_model, const CefPoint& screen_point) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			MyCefSetVoidPtr2(&args.v2, &screen_point);
			this->mcallback(MyCefMenuModelDelegate_MouseOutsideMenu_2, &args);
		}
	}
	//gen! void UnhandledOpenSubmenu(CefRefPtr<CefMenuModel> menu_model,bool is_rtl)
	virtual void UnhandledOpenSubmenu(CefRefPtr<CefMenuModel> menu_model, bool is_rtl) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			MyCefSetBool(&args.v2, is_rtl);
			this->mcallback(MyCefMenuModelDelegate_UnhandledOpenSubmenu_3, &args);
		}
	}
	//gen! void UnhandledCloseSubmenu(CefRefPtr<CefMenuModel> menu_model,bool is_rtl)
	virtual void UnhandledCloseSubmenu(CefRefPtr<CefMenuModel> menu_model, bool is_rtl) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			MyCefSetBool(&args.v2, is_rtl);
			this->mcallback(MyCefMenuModelDelegate_UnhandledCloseSubmenu_4, &args);
		}
	}
	//gen! void MenuWillShow(CefRefPtr<CefMenuModel> menu_model)
	virtual void MenuWillShow(CefRefPtr<CefMenuModel> menu_model) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			this->mcallback(MyCefMenuModelDelegate_MenuWillShow_5, &args);
		}
	}
	//gen! void MenuClosed(CefRefPtr<CefMenuModel> menu_model)
	virtual void MenuClosed(CefRefPtr<CefMenuModel> menu_model) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			this->mcallback(MyCefMenuModelDelegate_MenuClosed_6, &args);
		}
	}
	//gen! bool FormatLabel(CefRefPtr<CefMenuModel> menu_model,CefString& label)
	virtual bool FormatLabel(CefRefPtr<CefMenuModel> menu_model, CefString& label) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefMenuModelCToCpp::Unwrap(menu_model));
			SetCefStringToJsValue(&args.v2, label);
			this->mcallback(MyCefMenuModelDelegate_FormatLabel_7, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefNavigationEntry
const int CefNavigationEntry_IsValid_1 = 1;
const int CefNavigationEntry_GetURL_2 = 2;
const int CefNavigationEntry_GetDisplayURL_3 = 3;
const int CefNavigationEntry_GetOriginalURL_4 = 4;
const int CefNavigationEntry_GetTitle_5 = 5;
const int CefNavigationEntry_GetTransitionType_6 = 6;
const int CefNavigationEntry_HasPostData_7 = 7;
const int CefNavigationEntry_GetCompletionTime_8 = 8;
const int CefNavigationEntry_GetHttpStatusCode_9 = 9;
const int CefNavigationEntry_GetSSLStatus_10 = 10;

void MyCefMet_CefNavigationEntry(cef_navigation_entry_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefNavigationEntryCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefNavigationEntry_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefNavigationEntry_GetURL_2: {


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefNavigationEntry_GetDisplayURL_3: {


		// gen! CefString GetDisplayURL()
		auto ret_result = me->GetDisplayURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefNavigationEntry_GetOriginalURL_4: {


		// gen! CefString GetOriginalURL()
		auto ret_result = me->GetOriginalURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefNavigationEntry_GetTitle_5: {


		// gen! CefString GetTitle()
		auto ret_result = me->GetTitle();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefNavigationEntry_GetTransitionType_6: {


		// gen! TransitionType GetTransitionType()
		auto ret_result = me->GetTransitionType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefNavigationEntry_HasPostData_7: {


		// gen! bool HasPostData()
		auto ret_result = me->HasPostData();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefNavigationEntry_GetCompletionTime_8: {


		// gen! CefTime GetCompletionTime()
		auto ret_result = me->GetCompletionTime();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefNavigationEntry_GetHttpStatusCode_9: {


		// gen! int GetHttpStatusCode()
		auto ret_result = me->GetHttpStatusCode();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefNavigationEntry_GetSSLStatus_10: {


		// gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
		auto ret_result = me->GetSSLStatus();
		MyCefSetVoidPtr(ret, CefSSLStatusCToCpp::Unwrap(ret_result));
	} break;
	}
	CefNavigationEntryCToCpp::Unwrap(me);
}


// [virtual] class CefPrintSettings
const int CefPrintSettings_IsValid_1 = 1;
const int CefPrintSettings_IsReadOnly_2 = 2;
const int CefPrintSettings_Copy_3 = 3;
const int CefPrintSettings_SetOrientation_4 = 4;
const int CefPrintSettings_IsLandscape_5 = 5;
const int CefPrintSettings_SetPrinterPrintableArea_6 = 6;
const int CefPrintSettings_SetDeviceName_7 = 7;
const int CefPrintSettings_GetDeviceName_8 = 8;
const int CefPrintSettings_SetDPI_9 = 9;
const int CefPrintSettings_GetDPI_10 = 10;
const int CefPrintSettings_SetPageRanges_11 = 11;
const int CefPrintSettings_GetPageRangesCount_12 = 12;
const int CefPrintSettings_GetPageRanges_13 = 13;
const int CefPrintSettings_SetSelectionOnly_14 = 14;
const int CefPrintSettings_IsSelectionOnly_15 = 15;
const int CefPrintSettings_SetCollate_16 = 16;
const int CefPrintSettings_WillCollate_17 = 17;
const int CefPrintSettings_SetColorModel_18 = 18;
const int CefPrintSettings_GetColorModel_19 = 19;
const int CefPrintSettings_SetCopies_20 = 20;
const int CefPrintSettings_GetCopies_21 = 21;
const int CefPrintSettings_SetDuplexMode_22 = 22;
const int CefPrintSettings_GetDuplexMode_23 = 23;

void MyCefMet_CefPrintSettings(cef_print_settings_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefPrintSettingsCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefPrintSettings_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPrintSettings_IsReadOnly_2: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPrintSettings_Copy_3: {


		// gen! CefRefPtr<CefPrintSettings> Copy()
		auto ret_result = me->Copy();
		MyCefSetVoidPtr(ret, CefPrintSettingsCToCpp::Unwrap(ret_result));
	} break;
	case CefPrintSettings_SetOrientation_4: {


		// gen! void SetOrientation(bool landscape)
		me->SetOrientation(v1->i32 != 0);

	} break;
	case CefPrintSettings_IsLandscape_5: {


		// gen! bool IsLandscape()
		auto ret_result = me->IsLandscape();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPrintSettings_SetPrinterPrintableArea_6: {


		// gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
		me->SetPrinterPrintableArea(*((CefSize*)v1->ptr),
			*((CefRect*)v2->ptr),
			v3->i32 != 0);

	} break;
	case CefPrintSettings_SetDeviceName_7: {


		// gen! void SetDeviceName(const CefString& name)
		me->SetDeviceName(GetStringHolder(v1)->value);

	} break;
	case CefPrintSettings_GetDeviceName_8: {


		// gen! CefString GetDeviceName()
		auto ret_result = me->GetDeviceName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefPrintSettings_SetDPI_9: {


		// gen! void SetDPI(int dpi)
		me->SetDPI(v1->i32);

	} break;
	case CefPrintSettings_GetDPI_10: {


		// gen! int GetDPI()
		auto ret_result = me->GetDPI();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefPrintSettings_SetPageRanges_11: {


		// gen! void SetPageRanges(const PageRangeList& ranges)
		me->SetPageRanges(*((CefPrintSettings::PageRangeList*)v1->ptr));

	} break;
	case CefPrintSettings_GetPageRangesCount_12: {


		// gen! size_t GetPageRangesCount()
		auto ret_result = me->GetPageRangesCount();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefPrintSettings_GetPageRanges_13: {


		// gen! void GetPageRanges(PageRangeList& ranges)
		me->GetPageRanges(*((CefPrintSettings::PageRangeList*)v1->ptr));

	} break;
	case CefPrintSettings_SetSelectionOnly_14: {


		// gen! void SetSelectionOnly(bool selection_only)
		me->SetSelectionOnly(v1->i32 != 0);

	} break;
	case CefPrintSettings_IsSelectionOnly_15: {


		// gen! bool IsSelectionOnly()
		auto ret_result = me->IsSelectionOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPrintSettings_SetCollate_16: {


		// gen! void SetCollate(bool collate)
		me->SetCollate(v1->i32 != 0);

	} break;
	case CefPrintSettings_WillCollate_17: {


		// gen! bool WillCollate()
		auto ret_result = me->WillCollate();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPrintSettings_SetColorModel_18: {


		// gen! void SetColorModel(ColorModel model)
		me->SetColorModel((CefPrintSettings::ColorModel)v1->i32);

	} break;
	case CefPrintSettings_GetColorModel_19: {


		// gen! ColorModel GetColorModel()
		auto ret_result = me->GetColorModel();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefPrintSettings_SetCopies_20: {


		// gen! void SetCopies(int copies)
		me->SetCopies(v1->i32);

	} break;
	case CefPrintSettings_GetCopies_21: {


		// gen! int GetCopies()
		auto ret_result = me->GetCopies();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefPrintSettings_SetDuplexMode_22: {


		// gen! void SetDuplexMode(DuplexMode mode)
		me->SetDuplexMode((CefPrintSettings::DuplexMode)v1->i32);

	} break;
	case CefPrintSettings_GetDuplexMode_23: {


		// gen! DuplexMode GetDuplexMode()
		auto ret_result = me->GetDuplexMode();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	}
	CefPrintSettingsCToCpp::Unwrap(me);
}


// [virtual] class CefProcessMessage
const int CefProcessMessage_IsValid_1 = 1;
const int CefProcessMessage_IsReadOnly_2 = 2;
const int CefProcessMessage_Copy_3 = 3;
const int CefProcessMessage_GetName_4 = 4;
const int CefProcessMessage_GetArgumentList_5 = 5;

void MyCefMet_CefProcessMessage(cef_process_message_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefProcessMessageCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefProcessMessage_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefProcessMessage_IsReadOnly_2: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefProcessMessage_Copy_3: {


		// gen! CefRefPtr<CefProcessMessage> Copy()
		auto ret_result = me->Copy();
		MyCefSetVoidPtr(ret, CefProcessMessageCToCpp::Unwrap(ret_result));
	} break;
	case CefProcessMessage_GetName_4: {


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefProcessMessage_GetArgumentList_5: {


		// gen! CefRefPtr<CefListValue> GetArgumentList()
		auto ret_result = me->GetArgumentList();
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
	} break;
	}
	CefProcessMessageCToCpp::Unwrap(me);
}


// [virtual] class CefRequest
const int CefRequest_IsReadOnly_1 = 1;
const int CefRequest_GetURL_2 = 2;
const int CefRequest_SetURL_3 = 3;
const int CefRequest_GetMethod_4 = 4;
const int CefRequest_SetMethod_5 = 5;
const int CefRequest_SetReferrer_6 = 6;
const int CefRequest_GetReferrerURL_7 = 7;
const int CefRequest_GetReferrerPolicy_8 = 8;
const int CefRequest_GetPostData_9 = 9;
const int CefRequest_SetPostData_10 = 10;
const int CefRequest_GetHeaderMap_11 = 11;
const int CefRequest_SetHeaderMap_12 = 12;
const int CefRequest_Set_13 = 13;
const int CefRequest_GetFlags_14 = 14;
const int CefRequest_SetFlags_15 = 15;
const int CefRequest_GetFirstPartyForCookies_16 = 16;
const int CefRequest_SetFirstPartyForCookies_17 = 17;
const int CefRequest_GetResourceType_18 = 18;
const int CefRequest_GetTransitionType_19 = 19;
const int CefRequest_GetIdentifier_20 = 20;

void MyCefMet_CefRequest(cef_request_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefRequestCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefRequest_IsReadOnly_1: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequest_GetURL_2: {


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefRequest_SetURL_3: {


		// gen! void SetURL(const CefString& url)
		me->SetURL(GetStringHolder(v1)->value);

	} break;
	case CefRequest_GetMethod_4: {


		// gen! CefString GetMethod()
		auto ret_result = me->GetMethod();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefRequest_SetMethod_5: {


		// gen! void SetMethod(const CefString& method)
		me->SetMethod(GetStringHolder(v1)->value);

	} break;
	case CefRequest_SetReferrer_6: {


		// gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
		me->SetReferrer(GetStringHolder(v1)->value,
			(CefRequest::ReferrerPolicy)v2->i32);

	} break;
	case CefRequest_GetReferrerURL_7: {


		// gen! CefString GetReferrerURL()
		auto ret_result = me->GetReferrerURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefRequest_GetReferrerPolicy_8: {


		// gen! ReferrerPolicy GetReferrerPolicy()
		auto ret_result = me->GetReferrerPolicy();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefRequest_GetPostData_9: {


		// gen! CefRefPtr<CefPostData> GetPostData()
		auto ret_result = me->GetPostData();
		MyCefSetVoidPtr(ret, CefPostDataCToCpp::Unwrap(ret_result));
	} break;
	case CefRequest_SetPostData_10: {


		// gen! void SetPostData(CefRefPtr<CefPostData> postData)
		me->SetPostData(CefPostDataCToCpp::Wrap((cef_post_data_t*)v1->ptr));

	} break;
	case CefRequest_GetHeaderMap_11: {


		// gen! void GetHeaderMap(HeaderMap& headerMap)
		me->GetHeaderMap(*((CefRequest::HeaderMap*)v1->ptr));

	} break;
	case CefRequest_SetHeaderMap_12: {


		// gen! void SetHeaderMap(const HeaderMap& headerMap)
		me->SetHeaderMap(*((CefRequest::HeaderMap*)v1->ptr));

	} break;
	case CefRequest_Set_13: {


		// gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
		me->Set(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefPostDataCToCpp::Wrap((cef_post_data_t*)v3->ptr),
			*((CefRequest::HeaderMap*)v4->ptr));

	} break;
	case CefRequest_GetFlags_14: {


		// gen! int GetFlags()
		auto ret_result = me->GetFlags();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefRequest_SetFlags_15: {


		// gen! void SetFlags(int flags)
		me->SetFlags(v1->i32);

	} break;
	case CefRequest_GetFirstPartyForCookies_16: {


		// gen! CefString GetFirstPartyForCookies()
		auto ret_result = me->GetFirstPartyForCookies();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefRequest_SetFirstPartyForCookies_17: {


		// gen! void SetFirstPartyForCookies(const CefString& url)
		me->SetFirstPartyForCookies(GetStringHolder(v1)->value);

	} break;
	case CefRequest_GetResourceType_18: {


		// gen! ResourceType GetResourceType()
		auto ret_result = me->GetResourceType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefRequest_GetTransitionType_19: {


		// gen! TransitionType GetTransitionType()
		auto ret_result = me->GetTransitionType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefRequest_GetIdentifier_20: {


		// gen! uint64 GetIdentifier()
		auto ret_result = me->GetIdentifier();
		MyCefSetUInt64(ret, ret_result);
	} break;
	}
	CefRequestCToCpp::Unwrap(me);
}


// [virtual] class CefPostData
const int CefPostData_IsReadOnly_1 = 1;
const int CefPostData_HasExcludedElements_2 = 2;
const int CefPostData_GetElementCount_3 = 3;
const int CefPostData_GetElements_4 = 4;
const int CefPostData_RemoveElement_5 = 5;
const int CefPostData_AddElement_6 = 6;
const int CefPostData_RemoveElements_7 = 7;

void MyCefMet_CefPostData(cef_post_data_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefPostDataCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefPostData_IsReadOnly_1: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPostData_HasExcludedElements_2: {


		// gen! bool HasExcludedElements()
		auto ret_result = me->HasExcludedElements();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPostData_GetElementCount_3: {


		// gen! size_t GetElementCount()
		auto ret_result = me->GetElementCount();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefPostData_GetElements_4: {


		// gen! void GetElements(ElementVector& elements)
		me->GetElements(*((CefPostData::ElementVector*)v1->ptr));

	} break;
	case CefPostData_RemoveElement_5: {


		// gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
		auto ret_result = me->RemoveElement(CefPostDataElementCToCpp::Wrap((cef_post_data_element_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPostData_AddElement_6: {


		// gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
		auto ret_result = me->AddElement(CefPostDataElementCToCpp::Wrap((cef_post_data_element_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPostData_RemoveElements_7: {


		// gen! void RemoveElements()
		me->RemoveElements();

	} break;
	}
	CefPostDataCToCpp::Unwrap(me);
}


// [virtual] class CefPostDataElement
const int CefPostDataElement_IsReadOnly_1 = 1;
const int CefPostDataElement_SetToEmpty_2 = 2;
const int CefPostDataElement_SetToFile_3 = 3;
const int CefPostDataElement_SetToBytes_4 = 4;
const int CefPostDataElement_GetType_5 = 5;
const int CefPostDataElement_GetFile_6 = 6;
const int CefPostDataElement_GetBytesCount_7 = 7;
const int CefPostDataElement_GetBytes_8 = 8;

void MyCefMet_CefPostDataElement(cef_post_data_element_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefPostDataElementCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefPostDataElement_IsReadOnly_1: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefPostDataElement_SetToEmpty_2: {


		// gen! void SetToEmpty()
		me->SetToEmpty();

	} break;
	case CefPostDataElement_SetToFile_3: {


		// gen! void SetToFile(const CefString& fileName)
		me->SetToFile(GetStringHolder(v1)->value);

	} break;
	case CefPostDataElement_SetToBytes_4: {


		// gen! void SetToBytes(size_t size,const void* bytes)
		me->SetToBytes(v1->i64,
			(void*)v2->ptr);

	} break;
	case CefPostDataElement_GetType_5: {


		// gen! Type GetType()
		auto ret_result = me->GetType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefPostDataElement_GetFile_6: {


		// gen! CefString GetFile()
		auto ret_result = me->GetFile();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefPostDataElement_GetBytesCount_7: {


		// gen! size_t GetBytesCount()
		auto ret_result = me->GetBytesCount();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefPostDataElement_GetBytes_8: {


		// gen! size_t GetBytes(size_t size,void* bytes)
		auto ret_result = me->GetBytes(v1->i64,
			(void*)v2->ptr);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	}
	CefPostDataElementCToCpp::Unwrap(me);
}


// [virtual] class CefRequestContext
const int CefRequestContext_IsSame_1 = 1;
const int CefRequestContext_IsSharingWith_2 = 2;
const int CefRequestContext_IsGlobal_3 = 3;
const int CefRequestContext_GetHandler_4 = 4;
const int CefRequestContext_GetCachePath_5 = 5;
const int CefRequestContext_GetDefaultCookieManager_6 = 6;
const int CefRequestContext_RegisterSchemeHandlerFactory_7 = 7;
const int CefRequestContext_ClearSchemeHandlerFactories_8 = 8;
const int CefRequestContext_PurgePluginListCache_9 = 9;
const int CefRequestContext_HasPreference_10 = 10;
const int CefRequestContext_GetPreference_11 = 11;
const int CefRequestContext_GetAllPreferences_12 = 12;
const int CefRequestContext_CanSetPreference_13 = 13;
const int CefRequestContext_SetPreference_14 = 14;
const int CefRequestContext_ClearCertificateExceptions_15 = 15;
const int CefRequestContext_CloseAllConnections_16 = 16;
const int CefRequestContext_ResolveHost_17 = 17;
const int CefRequestContext_ResolveHostCached_18 = 18;

void MyCefMet_CefRequestContext(cef_request_context_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefRequestContextCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefRequestContext_IsSame_1: {


		// gen! bool IsSame(CefRefPtr<CefRequestContext> other)
		auto ret_result = me->IsSame(CefRequestContextCToCpp::Wrap((cef_request_context_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_IsSharingWith_2: {


		// gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
		auto ret_result = me->IsSharingWith(CefRequestContextCToCpp::Wrap((cef_request_context_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_IsGlobal_3: {


		// gen! bool IsGlobal()
		auto ret_result = me->IsGlobal();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_GetHandler_4: {


		// gen! CefRefPtr<CefRequestContextHandler> GetHandler()
		auto ret_result = me->GetHandler();
		MyCefSetVoidPtr(ret, CefRequestContextHandlerCppToC::Wrap(ret_result));
	} break;
	case CefRequestContext_GetCachePath_5: {


		// gen! CefString GetCachePath()
		auto ret_result = me->GetCachePath();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefRequestContext_GetDefaultCookieManager_6: {


		// gen! CefRefPtr<CefCookieManager> GetDefaultCookieManager(CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->GetDefaultCookieManager(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		MyCefSetVoidPtr(ret, CefCookieManagerCToCpp::Unwrap(ret_result));
	} break;
	case CefRequestContext_RegisterSchemeHandlerFactory_7: {


		// gen! bool RegisterSchemeHandlerFactory(const CefString& scheme_name,const CefString& domain_name,CefRefPtr<CefSchemeHandlerFactory> factory)
		auto ret_result = me->RegisterSchemeHandlerFactory(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefSchemeHandlerFactoryCppToC::Unwrap((cef_scheme_handler_factory_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_ClearSchemeHandlerFactories_8: {


		// gen! bool ClearSchemeHandlerFactories()
		auto ret_result = me->ClearSchemeHandlerFactories();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_PurgePluginListCache_9: {


		// gen! void PurgePluginListCache(bool reload_pages)
		me->PurgePluginListCache(v1->i32 != 0);

	} break;
	case CefRequestContext_HasPreference_10: {


		// gen! bool HasPreference(const CefString& name)
		auto ret_result = me->HasPreference(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_GetPreference_11: {


		// gen! CefRefPtr<CefValue> GetPreference(const CefString& name)
		auto ret_result = me->GetPreference(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
	} break;
	case CefRequestContext_GetAllPreferences_12: {


		// gen! CefRefPtr<CefDictionaryValue> GetAllPreferences(bool include_defaults)
		auto ret_result = me->GetAllPreferences(v1->i32 != 0);
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefRequestContext_CanSetPreference_13: {


		// gen! bool CanSetPreference(const CefString& name)
		auto ret_result = me->CanSetPreference(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_SetPreference_14: {


		// gen! bool SetPreference(const CefString& name,CefRefPtr<CefValue> value,CefString& error)
		auto ret_result = me->SetPreference(GetStringHolder(v1)->value,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr),
			GetStringHolder(v3)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefRequestContext_ClearCertificateExceptions_15: {


		// gen! void ClearCertificateExceptions(CefRefPtr<CefCompletionCallback> callback)
		me->ClearCertificateExceptions(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));

	} break;
	case CefRequestContext_CloseAllConnections_16: {


		// gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
		me->CloseAllConnections(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));

	} break;
	case CefRequestContext_ResolveHost_17: {


		// gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
		me->ResolveHost(GetStringHolder(v1)->value,
			CefResolveCallbackCppToC::Unwrap((cef_resolve_callback_t*)v2->ptr));

	} break;
	case CefRequestContext_ResolveHostCached_18: {


		// gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
		auto ret_result = me->ResolveHostCached(GetStringHolder(v1)->value,
			*((std::vector<CefString>*)v2->ptr));
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	}
	CefRequestContextCToCpp::Unwrap(me);
}


// [virtual] class CefResourceBundle
const int CefResourceBundle_GetLocalizedString_1 = 1;
const int CefResourceBundle_GetDataResource_2 = 2;
const int CefResourceBundle_GetDataResourceForScale_3 = 3;

void MyCefMet_CefResourceBundle(cef_resource_bundle_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefResourceBundleCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefResourceBundle_GetLocalizedString_1: {


		// gen! CefString GetLocalizedString(int string_id)
		auto ret_result = me->GetLocalizedString(v1->i32);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefResourceBundle_GetDataResource_2: {


		// gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
		auto ret_result = me->GetDataResource(v1->i32,
			*((void**)v2->ptr),
			*((size_t*)v3->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefResourceBundle_GetDataResourceForScale_3: {


		// gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
		auto ret_result = me->GetDataResourceForScale(v1->i32,
			(CefResourceBundle::ScaleFactor)v2->i32,
			*((void**)v3->ptr),
			*((size_t*)v4->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefResourceBundleCToCpp::Unwrap(me);
}


// [virtual] class CefResponse
const int CefResponse_IsReadOnly_1 = 1;
const int CefResponse_GetError_2 = 2;
const int CefResponse_SetError_3 = 3;
const int CefResponse_GetStatus_4 = 4;
const int CefResponse_SetStatus_5 = 5;
const int CefResponse_GetStatusText_6 = 6;
const int CefResponse_SetStatusText_7 = 7;
const int CefResponse_GetMimeType_8 = 8;
const int CefResponse_SetMimeType_9 = 9;
const int CefResponse_GetHeader_10 = 10;
const int CefResponse_GetHeaderMap_11 = 11;
const int CefResponse_SetHeaderMap_12 = 12;

void MyCefMet_CefResponse(cef_response_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefResponseCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefResponse_IsReadOnly_1: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefResponse_GetError_2: {


		// gen! cef_errorcode_t GetError()
		auto ret_result = me->GetError();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefResponse_SetError_3: {


		// gen! void SetError(cef_errorcode_t error)
		me->SetError((cef_errorcode_t)v1->i32);

	} break;
	case CefResponse_GetStatus_4: {


		// gen! int GetStatus()
		auto ret_result = me->GetStatus();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefResponse_SetStatus_5: {


		// gen! void SetStatus(int status)
		me->SetStatus(v1->i32);

	} break;
	case CefResponse_GetStatusText_6: {


		// gen! CefString GetStatusText()
		auto ret_result = me->GetStatusText();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefResponse_SetStatusText_7: {


		// gen! void SetStatusText(const CefString& statusText)
		me->SetStatusText(GetStringHolder(v1)->value);

	} break;
	case CefResponse_GetMimeType_8: {


		// gen! CefString GetMimeType()
		auto ret_result = me->GetMimeType();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefResponse_SetMimeType_9: {


		// gen! void SetMimeType(const CefString& mimeType)
		me->SetMimeType(GetStringHolder(v1)->value);

	} break;
	case CefResponse_GetHeader_10: {


		// gen! CefString GetHeader(const CefString& name)
		auto ret_result = me->GetHeader(GetStringHolder(v1)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefResponse_GetHeaderMap_11: {


		// gen! void GetHeaderMap(HeaderMap& headerMap)
		me->GetHeaderMap(*((CefResponse::HeaderMap*)v1->ptr));

	} break;
	case CefResponse_SetHeaderMap_12: {


		// gen! void SetHeaderMap(const HeaderMap& headerMap)
		me->SetHeaderMap(*((CefResponse::HeaderMap*)v1->ptr));

	} break;
	}
	CefResponseCToCpp::Unwrap(me);
}


// [virtual] class CefResponseFilter
const int CefResponseFilter_InitFilter_1 = 1;
const int CefResponseFilter_Filter_2 = 2;

void MyCefMet_CefResponseFilter(cef_response_filter_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefResponseFilterCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefResponseFilter_InitFilter_1: {


		// gen! bool InitFilter()
		auto ret_result = me->InitFilter();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefResponseFilter_Filter_2: {


		// gen! FilterStatus Filter(void* data_in,size_t data_in_size,size_t& data_in_read,void* data_out,size_t data_out_size,size_t& data_out_written)
		auto ret_result = me->Filter((void*)v1->ptr,
			v2->i64,
			*((size_t*)v3->ptr),
			(void*)v4->ptr,
			v5->i64,
			*((size_t*)v6->ptr));
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	}
	CefResponseFilterCppToC::Wrap(me);
}
const int MyCefResponseFilter_InitFilter_1 = 1;
const int MyCefResponseFilter_Filter_2 = 2;
class MyCefResponseFilter :public CefResponseFilterCppToC {
public:
	managed_callback mcallback;
	explicit MyCefResponseFilter() {
		mcallback = NULL;
	}
	//gen! bool InitFilter()
	virtual bool InitFilter() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefResponseFilter_InitFilter_1, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
	//gen! FilterStatus Filter(void* data_in,size_t data_in_size,size_t& data_in_read,void* data_out,size_t data_out_size,size_t& data_out_written)
	virtual cef_response_filter_status_t Filter(void* data_in, size_t data_in_size, size_t& data_in_read, void* data_out, size_t data_out_size, size_t& data_out_written) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, data_in);
			MyCefSetInt32(&args.v2, (int32_t)data_in_size);
			MyCefSetInt32(&args.v3, (int32_t)data_in_read);
			MyCefSetVoidPtr(&args.v4, data_out);
			MyCefSetInt32(&args.v5, (int32_t)data_out_size);
			MyCefSetInt32(&args.v6, (int32_t)data_out_written);
			this->mcallback(MyCefResponseFilter_Filter_2, &args);
			return (cef_response_filter_status_t)args.ret.i32;
		}
		return (cef_response_filter_status_t)0;
	}
};


// [virtual] class CefSchemeHandlerFactory
const int CefSchemeHandlerFactory_Create_1 = 1;

void MyCefMet_CefSchemeHandlerFactory(cef_scheme_handler_factory_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefSchemeHandlerFactoryCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefSchemeHandlerFactory_Create_1: {


		// gen! CefRefPtr<CefResourceHandler> Create(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& scheme_name,CefRefPtr<CefRequest> request)
		auto ret_result = me->Create(CefBrowserCToCpp::Wrap((cef_browser_t*)v1->ptr),
			CefFrameCToCpp::Wrap((cef_frame_t*)v2->ptr),
			GetStringHolder(v3)->value,
			CefRequestCToCpp::Wrap((cef_request_t*)v4->ptr));
		MyCefSetVoidPtr(ret, CefResourceHandlerCppToC::Wrap(ret_result));
	} break;
	}
	CefSchemeHandlerFactoryCppToC::Wrap(me);
}
const int MyCefSchemeHandlerFactory_Create_1 = 1;
class MyCefSchemeHandlerFactory :public CefSchemeHandlerFactoryCppToC {
public:
	managed_callback mcallback;
	explicit MyCefSchemeHandlerFactory() {
		mcallback = NULL;
	}
	//gen! CefRefPtr<CefResourceHandler> Create(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& scheme_name,CefRefPtr<CefRequest> request)
	virtual CefRefPtr<CefResourceHandler> Create(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& scheme_name, CefRefPtr<CefRequest> request) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefBrowserCToCpp::Unwrap(browser));
			MyCefSetVoidPtr(&args.v2, CefFrameCToCpp::Unwrap(frame));
			SetCefStringToJsValue(&args.v3, scheme_name);
			MyCefSetVoidPtr(&args.v4, CefRequestCToCpp::Unwrap(request));
			this->mcallback(MyCefSchemeHandlerFactory_Create_1, &args);
			return CefResourceHandlerCppToC::Unwrap((cef_resource_handler_t*)args.ret.ptr);
		}
		return nullptr;
	}
};


// [virtual] class CefSSLInfo
const int CefSSLInfo_GetCertStatus_1 = 1;
const int CefSSLInfo_GetX509Certificate_2 = 2;

void MyCefMet_CefSSLInfo(cef_sslinfo_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefSSLInfoCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefSSLInfo_GetCertStatus_1: {


		// gen! cef_cert_status_t GetCertStatus()
		auto ret_result = me->GetCertStatus();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefSSLInfo_GetX509Certificate_2: {


		// gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
		auto ret_result = me->GetX509Certificate();
		MyCefSetVoidPtr(ret, CefX509CertificateCToCpp::Unwrap(ret_result));
	} break;
	}
	CefSSLInfoCToCpp::Unwrap(me);
}


// [virtual] class CefSSLStatus
const int CefSSLStatus_IsSecureConnection_1 = 1;
const int CefSSLStatus_GetCertStatus_2 = 2;
const int CefSSLStatus_GetSSLVersion_3 = 3;
const int CefSSLStatus_GetContentStatus_4 = 4;
const int CefSSLStatus_GetX509Certificate_5 = 5;

void MyCefMet_CefSSLStatus(cef_sslstatus_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefSSLStatusCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefSSLStatus_IsSecureConnection_1: {


		// gen! bool IsSecureConnection()
		auto ret_result = me->IsSecureConnection();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefSSLStatus_GetCertStatus_2: {


		// gen! cef_cert_status_t GetCertStatus()
		auto ret_result = me->GetCertStatus();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefSSLStatus_GetSSLVersion_3: {


		// gen! cef_ssl_version_t GetSSLVersion()
		auto ret_result = me->GetSSLVersion();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefSSLStatus_GetContentStatus_4: {


		// gen! cef_ssl_content_status_t GetContentStatus()
		auto ret_result = me->GetContentStatus();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefSSLStatus_GetX509Certificate_5: {


		// gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
		auto ret_result = me->GetX509Certificate();
		MyCefSetVoidPtr(ret, CefX509CertificateCToCpp::Unwrap(ret_result));
	} break;
	}
	CefSSLStatusCToCpp::Unwrap(me);
}


// [virtual] class CefStreamReader
const int CefStreamReader_Read_1 = 1;
const int CefStreamReader_Seek_2 = 2;
const int CefStreamReader_Tell_3 = 3;
const int CefStreamReader_Eof_4 = 4;
const int CefStreamReader_MayBlock_5 = 5;

void MyCefMet_CefStreamReader(cef_stream_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefStreamReaderCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefStreamReader_Read_1: {


		// gen! size_t Read(void* ptr,size_t size,size_t n)
		auto ret_result = me->Read((void*)v1->ptr,
			v2->i64,
			v3->i64);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefStreamReader_Seek_2: {


		// gen! int Seek(int64 offset,int whence)
		auto ret_result = me->Seek(v1->i64,
			v2->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefStreamReader_Tell_3: {


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefStreamReader_Eof_4: {


		// gen! int Eof()
		auto ret_result = me->Eof();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefStreamReader_MayBlock_5: {


		// gen! bool MayBlock()
		auto ret_result = me->MayBlock();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefStreamReaderCToCpp::Unwrap(me);
}


// [virtual] class CefStreamWriter
const int CefStreamWriter_Write_1 = 1;
const int CefStreamWriter_Seek_2 = 2;
const int CefStreamWriter_Tell_3 = 3;
const int CefStreamWriter_Flush_4 = 4;
const int CefStreamWriter_MayBlock_5 = 5;

void MyCefMet_CefStreamWriter(cef_stream_writer_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefStreamWriterCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefStreamWriter_Write_1: {


		// gen! size_t Write(const void* ptr,size_t size,size_t n)
		auto ret_result = me->Write((void*)v1->ptr,
			v2->i64,
			v3->i64);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefStreamWriter_Seek_2: {


		// gen! int Seek(int64 offset,int whence)
		auto ret_result = me->Seek(v1->i64,
			v2->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefStreamWriter_Tell_3: {


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefStreamWriter_Flush_4: {


		// gen! int Flush()
		auto ret_result = me->Flush();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefStreamWriter_MayBlock_5: {


		// gen! bool MayBlock()
		auto ret_result = me->MayBlock();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefStreamWriterCToCpp::Unwrap(me);
}


// [virtual] class CefStringVisitor
const int CefStringVisitor_Visit_1 = 1;

void MyCefMet_CefStringVisitor(cef_string_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefStringVisitorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefStringVisitor_Visit_1: {


		// gen! void Visit(const CefString& string)
		me->Visit(GetStringHolder(v1)->value);

	} break;
	}
	CefStringVisitorCppToC::Wrap(me);
}
const int MyCefStringVisitor_Visit_1 = 1;
class MyCefStringVisitor :public CefStringVisitorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefStringVisitor() {
		mcallback = NULL;
	}
	//gen! void Visit(const CefString& string)
	virtual void Visit(const CefString& string) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, string);
			this->mcallback(MyCefStringVisitor_Visit_1, &args);
		}
	}
};


// [virtual] class CefTask
const int CefTask_Execute_1 = 1;

void MyCefMet_CefTask(cef_task_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefTaskCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefTask_Execute_1: {


		// gen! void Execute()
		me->Execute();

	} break;
	}
	CefTaskCppToC::Wrap(me);
}
const int MyCefTask_Execute_1 = 1;
class MyCefTask :public CefTaskCppToC {
public:
	managed_callback mcallback;
	explicit MyCefTask() {
		mcallback = NULL;
	}
	//gen! void Execute()
	virtual void Execute() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefTask_Execute_1, &args);
		}
	}
};


// [virtual] class CefTaskRunner
const int CefTaskRunner_IsSame_1 = 1;
const int CefTaskRunner_BelongsToCurrentThread_2 = 2;
const int CefTaskRunner_BelongsToThread_3 = 3;
const int CefTaskRunner_PostTask_4 = 4;
const int CefTaskRunner_PostDelayedTask_5 = 5;

void MyCefMet_CefTaskRunner(cef_task_runner_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefTaskRunnerCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefTaskRunner_IsSame_1: {


		// gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
		auto ret_result = me->IsSame(CefTaskRunnerCToCpp::Wrap((cef_task_runner_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefTaskRunner_BelongsToCurrentThread_2: {


		// gen! bool BelongsToCurrentThread()
		auto ret_result = me->BelongsToCurrentThread();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefTaskRunner_BelongsToThread_3: {


		// gen! bool BelongsToThread(CefThreadId threadId)
		auto ret_result = me->BelongsToThread((CefThreadId)v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefTaskRunner_PostTask_4: {


		// gen! bool PostTask(CefRefPtr<CefTask> task)
		auto ret_result = me->PostTask(CefTaskCppToC::Unwrap((cef_task_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefTaskRunner_PostDelayedTask_5: {


		// gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
		auto ret_result = me->PostDelayedTask(CefTaskCppToC::Unwrap((cef_task_t*)v1->ptr),
			v2->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefTaskRunnerCToCpp::Unwrap(me);
}


// [virtual] class CefURLRequest
const int CefURLRequest_GetRequest_1 = 1;
const int CefURLRequest_GetClient_2 = 2;
const int CefURLRequest_GetRequestStatus_3 = 3;
const int CefURLRequest_GetRequestError_4 = 4;
const int CefURLRequest_GetResponse_5 = 5;
const int CefURLRequest_Cancel_6 = 6;

void MyCefMet_CefURLRequest(cef_urlrequest_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefURLRequestCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefURLRequest_GetRequest_1: {


		// gen! CefRefPtr<CefRequest> GetRequest()
		auto ret_result = me->GetRequest();
		MyCefSetVoidPtr(ret, CefRequestCToCpp::Unwrap(ret_result));
	} break;
	case CefURLRequest_GetClient_2: {


		// gen! CefRefPtr<CefURLRequestClient> GetClient()
		auto ret_result = me->GetClient();
		MyCefSetVoidPtr(ret, CefURLRequestClientCppToC::Wrap(ret_result));
	} break;
	case CefURLRequest_GetRequestStatus_3: {


		// gen! Status GetRequestStatus()
		auto ret_result = me->GetRequestStatus();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefURLRequest_GetRequestError_4: {


		// gen! ErrorCode GetRequestError()
		auto ret_result = me->GetRequestError();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefURLRequest_GetResponse_5: {


		// gen! CefRefPtr<CefResponse> GetResponse()
		auto ret_result = me->GetResponse();
		MyCefSetVoidPtr(ret, CefResponseCToCpp::Unwrap(ret_result));
	} break;
	case CefURLRequest_Cancel_6: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefURLRequestCToCpp::Unwrap(me);
}


// [virtual] class CefURLRequestClient
const int CefURLRequestClient_OnRequestComplete_1 = 1;
const int CefURLRequestClient_OnUploadProgress_2 = 2;
const int CefURLRequestClient_OnDownloadProgress_3 = 3;
const int CefURLRequestClient_OnDownloadData_4 = 4;
const int CefURLRequestClient_GetAuthCredentials_5 = 5;

void MyCefMet_CefURLRequestClient(cef_urlrequest_client_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefURLRequestClientCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefURLRequestClient_OnRequestComplete_1: {


		// gen! void OnRequestComplete(CefRefPtr<CefURLRequest> request)
		me->OnRequestComplete(CefURLRequestCToCpp::Wrap((cef_urlrequest_t*)v1->ptr));

	} break;
	case CefURLRequestClient_OnUploadProgress_2: {


		// gen! void OnUploadProgress(CefRefPtr<CefURLRequest> request,int64 current,int64 total)
		me->OnUploadProgress(CefURLRequestCToCpp::Wrap((cef_urlrequest_t*)v1->ptr),
			v2->i64,
			v3->i64);

	} break;
	case CefURLRequestClient_OnDownloadProgress_3: {


		// gen! void OnDownloadProgress(CefRefPtr<CefURLRequest> request,int64 current,int64 total)
		me->OnDownloadProgress(CefURLRequestCToCpp::Wrap((cef_urlrequest_t*)v1->ptr),
			v2->i64,
			v3->i64);

	} break;
	case CefURLRequestClient_OnDownloadData_4: {


		// gen! void OnDownloadData(CefRefPtr<CefURLRequest> request,const void* data,size_t data_length)
		me->OnDownloadData(CefURLRequestCToCpp::Wrap((cef_urlrequest_t*)v1->ptr),
			(void*)v2->ptr,
			v3->i64);

	} break;
	case CefURLRequestClient_GetAuthCredentials_5: {


		// gen! bool GetAuthCredentials(bool isProxy,const CefString& host,int port,const CefString& realm,const CefString& scheme,CefRefPtr<CefAuthCallback> callback)
		auto ret_result = me->GetAuthCredentials(v1->i32 != 0,
			GetStringHolder(v2)->value,
			v3->i32,
			GetStringHolder(v4)->value,
			GetStringHolder(v5)->value,
			CefAuthCallbackCToCpp::Wrap((cef_auth_callback_t*)v6->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefURLRequestClientCppToC::Wrap(me);
}
const int MyCefURLRequestClient_OnRequestComplete_1 = 1;
const int MyCefURLRequestClient_OnUploadProgress_2 = 2;
const int MyCefURLRequestClient_OnDownloadProgress_3 = 3;
const int MyCefURLRequestClient_OnDownloadData_4 = 4;
const int MyCefURLRequestClient_GetAuthCredentials_5 = 5;
class MyCefURLRequestClient :public CefURLRequestClientCppToC {
public:
	managed_callback mcallback;
	explicit MyCefURLRequestClient() {
		mcallback = NULL;
	}
	//gen! void OnRequestComplete(CefRefPtr<CefURLRequest> request)
	virtual void OnRequestComplete(CefRefPtr<CefURLRequest> request) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefURLRequestCToCpp::Unwrap(request));
			this->mcallback(MyCefURLRequestClient_OnRequestComplete_1, &args);
		}
	}
	//gen! void OnUploadProgress(CefRefPtr<CefURLRequest> request,int64 current,int64 total)
	virtual void OnUploadProgress(CefRefPtr<CefURLRequest> request, int64 current, int64 total) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefURLRequestCToCpp::Unwrap(request));
			MyCefSetInt64(&args.v2, current);
			MyCefSetInt64(&args.v3, total);
			this->mcallback(MyCefURLRequestClient_OnUploadProgress_2, &args);
		}
	}
	//gen! void OnDownloadProgress(CefRefPtr<CefURLRequest> request,int64 current,int64 total)
	virtual void OnDownloadProgress(CefRefPtr<CefURLRequest> request, int64 current, int64 total) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefURLRequestCToCpp::Unwrap(request));
			MyCefSetInt64(&args.v2, current);
			MyCefSetInt64(&args.v3, total);
			this->mcallback(MyCefURLRequestClient_OnDownloadProgress_3, &args);
		}
	}
	//gen! void OnDownloadData(CefRefPtr<CefURLRequest> request,const void* data,size_t data_length)
	virtual void OnDownloadData(CefRefPtr<CefURLRequest> request, const void* data, size_t data_length) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefURLRequestCToCpp::Unwrap(request));
			MyCefSetVoidPtr2(&args.v2, data);
			MyCefSetInt32(&args.v3, (int32_t)data_length);
			this->mcallback(MyCefURLRequestClient_OnDownloadData_4, &args);
		}
	}
	//gen! bool GetAuthCredentials(bool isProxy,const CefString& host,int port,const CefString& realm,const CefString& scheme,CefRefPtr<CefAuthCallback> callback)
	virtual bool GetAuthCredentials(bool isProxy, const CefString& host, int port, const CefString& realm, const CefString& scheme, CefRefPtr<CefAuthCallback> callback) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetBool(&args.v1, isProxy);
			SetCefStringToJsValue(&args.v2, host);
			MyCefSetInt64(&args.v3, port);
			SetCefStringToJsValue(&args.v4, realm);
			SetCefStringToJsValue(&args.v5, scheme);
			MyCefSetVoidPtr(&args.v6, CefAuthCallbackCToCpp::Unwrap(callback));
			this->mcallback(MyCefURLRequestClient_GetAuthCredentials_5, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefV8Context
const int CefV8Context_GetTaskRunner_1 = 1;
const int CefV8Context_IsValid_2 = 2;
const int CefV8Context_GetBrowser_3 = 3;
const int CefV8Context_GetFrame_4 = 4;
const int CefV8Context_GetGlobal_5 = 5;
const int CefV8Context_Enter_6 = 6;
const int CefV8Context_Exit_7 = 7;
const int CefV8Context_IsSame_8 = 8;
const int CefV8Context_Eval_9 = 9;

void MyCefMet_CefV8Context(cef_v8context_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8ContextCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8Context_GetTaskRunner_1: {


		// gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
		auto ret_result = me->GetTaskRunner();
		MyCefSetVoidPtr(ret, CefTaskRunnerCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Context_IsValid_2: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Context_GetBrowser_3: {


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Context_GetFrame_4: {


		// gen! CefRefPtr<CefFrame> GetFrame()
		auto ret_result = me->GetFrame();
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Context_GetGlobal_5: {


		// gen! CefRefPtr<CefV8Value> GetGlobal()
		auto ret_result = me->GetGlobal();
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Context_Enter_6: {


		// gen! bool Enter()
		auto ret_result = me->Enter();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Context_Exit_7: {


		// gen! bool Exit()
		auto ret_result = me->Exit();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Context_IsSame_8: {


		// gen! bool IsSame(CefRefPtr<CefV8Context> that)
		auto ret_result = me->IsSame(CefV8ContextCToCpp::Wrap((cef_v8context_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Context_Eval_9: {


		// gen! bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
		auto ret_result = me->Eval(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			v3->i32,
			*((CefRefPtr<CefV8Value>*)v4->ptr),
			*((CefRefPtr<CefV8Exception>*)v5->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefV8ContextCToCpp::Unwrap(me);
}


// [virtual] class CefV8Accessor
const int CefV8Accessor_Get_1 = 1;
const int CefV8Accessor_Set_2 = 2;

void MyCefMet_CefV8Accessor(cef_v8accessor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8AccessorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8Accessor_Get_1: {


		// gen! bool Get(const CefString& name,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
		auto ret_result = me->Get(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			*((CefRefPtr<CefV8Value>*)v3->ptr),
			GetStringHolder(v4)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Accessor_Set_2: {


		// gen! bool Set(const CefString& name,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
		auto ret_result = me->Set(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v3->ptr),
			GetStringHolder(v4)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefV8AccessorCppToC::Wrap(me);
}
const int MyCefV8Accessor_Get_1 = 1;
const int MyCefV8Accessor_Set_2 = 2;
class MyCefV8Accessor :public CefV8AccessorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefV8Accessor() {
		mcallback = NULL;
	}
	//gen! bool Get(const CefString& name,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
	virtual bool Get(const CefString& name, const CefRefPtr<CefV8Value> object, CefRefPtr<CefV8Value>& retval, CefString& exception) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, name);
			MyCefSetVoidPtr(&args.v2, CefV8ValueCToCpp::Unwrap(object));
			MyCefSetVoidPtr(&args.v3, retval);
			SetCefStringToJsValue(&args.v4, exception);
			this->mcallback(MyCefV8Accessor_Get_1, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
	//gen! bool Set(const CefString& name,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
	virtual bool Set(const CefString& name, const CefRefPtr<CefV8Value> object, const CefRefPtr<CefV8Value> value, CefString& exception) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, name);
			MyCefSetVoidPtr(&args.v2, CefV8ValueCToCpp::Unwrap(object));
			MyCefSetVoidPtr(&args.v3, CefV8ValueCToCpp::Unwrap(value));
			SetCefStringToJsValue(&args.v4, exception);
			this->mcallback(MyCefV8Accessor_Set_2, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefV8Interceptor
const int CefV8Interceptor_Get_1 = 1;
const int CefV8Interceptor_Get_2 = 2;
const int CefV8Interceptor_Set_3 = 3;
const int CefV8Interceptor_Set_4 = 4;

void MyCefMet_CefV8Interceptor(cef_v8interceptor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8InterceptorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8Interceptor_Get_1: {


		// gen! bool Get(const CefString& name,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
		auto ret_result = me->Get(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			*((CefRefPtr<CefV8Value>*)v3->ptr),
			GetStringHolder(v4)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Interceptor_Get_2: {


		// gen! bool Get(int index,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
		auto ret_result = me->Get(v1->i32,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			*((CefRefPtr<CefV8Value>*)v3->ptr),
			GetStringHolder(v4)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Interceptor_Set_3: {


		// gen! bool Set(const CefString& name,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
		auto ret_result = me->Set(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v3->ptr),
			GetStringHolder(v4)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Interceptor_Set_4: {


		// gen! bool Set(int index,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
		auto ret_result = me->Set(v1->i32,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v3->ptr),
			GetStringHolder(v4)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefV8InterceptorCppToC::Wrap(me);
}
const int MyCefV8Interceptor_Get_1 = 1;
const int MyCefV8Interceptor_Get_2 = 2;
const int MyCefV8Interceptor_Set_3 = 3;
const int MyCefV8Interceptor_Set_4 = 4;
class MyCefV8Interceptor :public CefV8InterceptorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefV8Interceptor() {
		mcallback = NULL;
	}
	//gen! bool Get(const CefString& name,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
	virtual bool Get(const CefString& name, const CefRefPtr<CefV8Value> object, CefRefPtr<CefV8Value>& retval, CefString& exception) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, name);
			MyCefSetVoidPtr(&args.v2, CefV8ValueCToCpp::Unwrap(object));
			MyCefSetVoidPtr(&args.v3, retval);
			SetCefStringToJsValue(&args.v4, exception);
			this->mcallback(MyCefV8Interceptor_Get_1, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
	//gen! bool Get(int index,const CefRefPtr<CefV8Value> object,CefRefPtr<CefV8Value>& retval,CefString& exception)
	virtual bool Get(int index, const CefRefPtr<CefV8Value> object, CefRefPtr<CefV8Value>& retval, CefString& exception) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetInt64(&args.v1, index);
			MyCefSetVoidPtr(&args.v2, CefV8ValueCToCpp::Unwrap(object));
			MyCefSetVoidPtr(&args.v3, retval);
			SetCefStringToJsValue(&args.v4, exception);
			this->mcallback(MyCefV8Interceptor_Get_2, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
	//gen! bool Set(const CefString& name,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
	virtual bool Set(const CefString& name, const CefRefPtr<CefV8Value> object, const CefRefPtr<CefV8Value> value, CefString& exception) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, name);
			MyCefSetVoidPtr(&args.v2, CefV8ValueCToCpp::Unwrap(object));
			MyCefSetVoidPtr(&args.v3, CefV8ValueCToCpp::Unwrap(value));
			SetCefStringToJsValue(&args.v4, exception);
			this->mcallback(MyCefV8Interceptor_Set_3, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
	//gen! bool Set(int index,const CefRefPtr<CefV8Value> object,const CefRefPtr<CefV8Value> value,CefString& exception)
	virtual bool Set(int index, const CefRefPtr<CefV8Value> object, const CefRefPtr<CefV8Value> value, CefString& exception) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetInt64(&args.v1, index);
			MyCefSetVoidPtr(&args.v2, CefV8ValueCToCpp::Unwrap(object));
			MyCefSetVoidPtr(&args.v3, CefV8ValueCToCpp::Unwrap(value));
			SetCefStringToJsValue(&args.v4, exception);
			this->mcallback(MyCefV8Interceptor_Set_4, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefV8Exception
const int CefV8Exception_GetMessage_1 = 1;
const int CefV8Exception_GetSourceLine_2 = 2;
const int CefV8Exception_GetScriptResourceName_3 = 3;
const int CefV8Exception_GetLineNumber_4 = 4;
const int CefV8Exception_GetStartPosition_5 = 5;
const int CefV8Exception_GetEndPosition_6 = 6;
const int CefV8Exception_GetStartColumn_7 = 7;
const int CefV8Exception_GetEndColumn_8 = 8;

void MyCefMet_CefV8Exception(cef_v8exception_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8ExceptionCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8Exception_GetMessage_1: {


		// gen! CefString GetMessage()
		auto ret_result = me->GetMessage();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8Exception_GetSourceLine_2: {


		// gen! CefString GetSourceLine()
		auto ret_result = me->GetSourceLine();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8Exception_GetScriptResourceName_3: {


		// gen! CefString GetScriptResourceName()
		auto ret_result = me->GetScriptResourceName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8Exception_GetLineNumber_4: {


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Exception_GetStartPosition_5: {


		// gen! int GetStartPosition()
		auto ret_result = me->GetStartPosition();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Exception_GetEndPosition_6: {


		// gen! int GetEndPosition()
		auto ret_result = me->GetEndPosition();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Exception_GetStartColumn_7: {


		// gen! int GetStartColumn()
		auto ret_result = me->GetStartColumn();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Exception_GetEndColumn_8: {


		// gen! int GetEndColumn()
		auto ret_result = me->GetEndColumn();
		MyCefSetInt64(ret, ret_result);
	} break;
	}
	CefV8ExceptionCToCpp::Unwrap(me);
}


// [virtual] class CefV8Value
const int CefV8Value_IsValid_1 = 1;
const int CefV8Value_IsUndefined_2 = 2;
const int CefV8Value_IsNull_3 = 3;
const int CefV8Value_IsBool_4 = 4;
const int CefV8Value_IsInt_5 = 5;
const int CefV8Value_IsUInt_6 = 6;
const int CefV8Value_IsDouble_7 = 7;
const int CefV8Value_IsDate_8 = 8;
const int CefV8Value_IsString_9 = 9;
const int CefV8Value_IsObject_10 = 10;
const int CefV8Value_IsArray_11 = 11;
const int CefV8Value_IsFunction_12 = 12;
const int CefV8Value_IsSame_13 = 13;
const int CefV8Value_GetBoolValue_14 = 14;
const int CefV8Value_GetIntValue_15 = 15;
const int CefV8Value_GetUIntValue_16 = 16;
const int CefV8Value_GetDoubleValue_17 = 17;
const int CefV8Value_GetDateValue_18 = 18;
const int CefV8Value_GetStringValue_19 = 19;
const int CefV8Value_IsUserCreated_20 = 20;
const int CefV8Value_HasException_21 = 21;
const int CefV8Value_GetException_22 = 22;
const int CefV8Value_ClearException_23 = 23;
const int CefV8Value_WillRethrowExceptions_24 = 24;
const int CefV8Value_SetRethrowExceptions_25 = 25;
const int CefV8Value_HasValue_26 = 26;
const int CefV8Value_HasValue_27 = 27;
const int CefV8Value_DeleteValue_28 = 28;
const int CefV8Value_DeleteValue_29 = 29;
const int CefV8Value_GetValue_30 = 30;
const int CefV8Value_GetValue_31 = 31;
const int CefV8Value_SetValue_32 = 32;
const int CefV8Value_SetValue_33 = 33;
const int CefV8Value_SetValue_34 = 34;
const int CefV8Value_GetKeys_35 = 35;
const int CefV8Value_SetUserData_36 = 36;
const int CefV8Value_GetUserData_37 = 37;
const int CefV8Value_GetExternallyAllocatedMemory_38 = 38;
const int CefV8Value_AdjustExternallyAllocatedMemory_39 = 39;
const int CefV8Value_GetArrayLength_40 = 40;
const int CefV8Value_GetFunctionName_41 = 41;
const int CefV8Value_GetFunctionHandler_42 = 42;
const int CefV8Value_ExecuteFunction_43 = 43;
const int CefV8Value_ExecuteFunctionWithContext_44 = 44;

void MyCefMet_CefV8Value(cef_v8value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8ValueCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8Value_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsUndefined_2: {


		// gen! bool IsUndefined()
		auto ret_result = me->IsUndefined();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsNull_3: {


		// gen! bool IsNull()
		auto ret_result = me->IsNull();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsBool_4: {


		// gen! bool IsBool()
		auto ret_result = me->IsBool();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsInt_5: {


		// gen! bool IsInt()
		auto ret_result = me->IsInt();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsUInt_6: {


		// gen! bool IsUInt()
		auto ret_result = me->IsUInt();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsDouble_7: {


		// gen! bool IsDouble()
		auto ret_result = me->IsDouble();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsDate_8: {


		// gen! bool IsDate()
		auto ret_result = me->IsDate();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsString_9: {


		// gen! bool IsString()
		auto ret_result = me->IsString();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsObject_10: {


		// gen! bool IsObject()
		auto ret_result = me->IsObject();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsArray_11: {


		// gen! bool IsArray()
		auto ret_result = me->IsArray();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsFunction_12: {


		// gen! bool IsFunction()
		auto ret_result = me->IsFunction();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_IsSame_13: {


		// gen! bool IsSame(CefRefPtr<CefV8Value> that)
		auto ret_result = me->IsSame(CefV8ValueCToCpp::Wrap((cef_v8value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_GetBoolValue_14: {


		// gen! bool GetBoolValue()
		auto ret_result = me->GetBoolValue();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_GetIntValue_15: {


		// gen! int32 GetIntValue()
		auto ret_result = me->GetIntValue();
		MyCefSetInt32(ret, ret_result);
	} break;
	case CefV8Value_GetUIntValue_16: {


		// gen! uint32 GetUIntValue()
		auto ret_result = me->GetUIntValue();
		MyCefSetUInt32(ret, ret_result);
	} break;
	case CefV8Value_GetDoubleValue_17: {


		// gen! double GetDoubleValue()
		auto ret_result = me->GetDoubleValue();
		MyCefSetDouble(ret, ret_result);
	} break;
	case CefV8Value_GetDateValue_18: {


		// gen! CefTime GetDateValue()
		auto ret_result = me->GetDateValue();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefV8Value_GetStringValue_19: {


		// gen! CefString GetStringValue()
		auto ret_result = me->GetStringValue();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8Value_IsUserCreated_20: {


		// gen! bool IsUserCreated()
		auto ret_result = me->IsUserCreated();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_HasException_21: {


		// gen! bool HasException()
		auto ret_result = me->HasException();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_GetException_22: {


		// gen! CefRefPtr<CefV8Exception> GetException()
		auto ret_result = me->GetException();
		MyCefSetVoidPtr(ret, CefV8ExceptionCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Value_ClearException_23: {


		// gen! bool ClearException()
		auto ret_result = me->ClearException();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_WillRethrowExceptions_24: {


		// gen! bool WillRethrowExceptions()
		auto ret_result = me->WillRethrowExceptions();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_SetRethrowExceptions_25: {


		// gen! bool SetRethrowExceptions(bool rethrow)
		auto ret_result = me->SetRethrowExceptions(v1->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_HasValue_26: {


		// gen! bool HasValue(const CefString& key)
		auto ret_result = me->HasValue(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_HasValue_27: {


		// gen! bool HasValue(int index)
		auto ret_result = me->HasValue(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_DeleteValue_28: {


		// gen! bool DeleteValue(const CefString& key)
		auto ret_result = me->DeleteValue(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_DeleteValue_29: {


		// gen! bool DeleteValue(int index)
		auto ret_result = me->DeleteValue(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_GetValue_30: {


		// gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)
		auto ret_result = me->GetValue(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Value_GetValue_31: {


		// gen! CefRefPtr<CefV8Value> GetValue(int index)
		auto ret_result = me->GetValue(v1->i32);
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Value_SetValue_32: {


		// gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			(CefV8Value::PropertyAttribute)v3->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_SetValue_33: {


		// gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)
		auto ret_result = me->SetValue(v1->i32,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_SetValue_34: {


		// gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			(CefV8Value::AccessControl)v2->i32,
			(CefV8Value::PropertyAttribute)v3->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_GetKeys_35: {


		// gen! bool GetKeys(std::vector<CefString>& keys)
		auto ret_result = me->GetKeys(*((std::vector<CefString>*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_SetUserData_36: {


		//// gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
		//auto ret_result = me->SetUserData(v1->ptr);
		//MyCefSetBool(ret, ret_result);
	} break;
	case CefV8Value_GetUserData_37: {


		//// gen! CefRefPtr<CefBaseRefCounted> GetUserData()
		//auto ret_result = me->GetUserData();
		//!
	} break;
	case CefV8Value_GetExternallyAllocatedMemory_38: {


		// gen! int GetExternallyAllocatedMemory()
		auto ret_result = me->GetExternallyAllocatedMemory();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Value_AdjustExternallyAllocatedMemory_39: {


		// gen! int AdjustExternallyAllocatedMemory(int change_in_bytes)
		auto ret_result = me->AdjustExternallyAllocatedMemory(v1->i32);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Value_GetArrayLength_40: {


		// gen! int GetArrayLength()
		auto ret_result = me->GetArrayLength();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8Value_GetFunctionName_41: {


		// gen! CefString GetFunctionName()
		auto ret_result = me->GetFunctionName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8Value_GetFunctionHandler_42: {


		// gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
		auto ret_result = me->GetFunctionHandler();
		MyCefSetVoidPtr(ret, CefV8HandlerCppToC::Wrap(ret_result));
	} break;
	case CefV8Value_ExecuteFunction_43: {


		// gen! CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
		auto ret_result = me->ExecuteFunction(CefV8ValueCToCpp::Wrap((cef_v8value_t*)v1->ptr),
			*((CefV8ValueList*)v2->ptr));
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
	} break;
	case CefV8Value_ExecuteFunctionWithContext_44: {


		// gen! CefRefPtr<CefV8Value> ExecuteFunctionWithContext(CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
		auto ret_result = me->ExecuteFunctionWithContext(CefV8ContextCToCpp::Wrap((cef_v8context_t*)v1->ptr),
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			*((CefV8ValueList*)v3->ptr));
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
	} break;
	}
	CefV8ValueCToCpp::Unwrap(me);
}


// [virtual] class CefV8StackTrace
const int CefV8StackTrace_IsValid_1 = 1;
const int CefV8StackTrace_GetFrameCount_2 = 2;
const int CefV8StackTrace_GetFrame_3 = 3;

void MyCefMet_CefV8StackTrace(cef_v8stack_trace_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8StackTraceCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8StackTrace_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8StackTrace_GetFrameCount_2: {


		// gen! int GetFrameCount()
		auto ret_result = me->GetFrameCount();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8StackTrace_GetFrame_3: {


		// gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
		auto ret_result = me->GetFrame(v1->i32);
		MyCefSetVoidPtr(ret, CefV8StackFrameCToCpp::Unwrap(ret_result));
	} break;
	}
	CefV8StackTraceCToCpp::Unwrap(me);
}


// [virtual] class CefV8StackFrame
const int CefV8StackFrame_IsValid_1 = 1;
const int CefV8StackFrame_GetScriptName_2 = 2;
const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = 3;
const int CefV8StackFrame_GetFunctionName_4 = 4;
const int CefV8StackFrame_GetLineNumber_5 = 5;
const int CefV8StackFrame_GetColumn_6 = 6;
const int CefV8StackFrame_IsEval_7 = 7;
const int CefV8StackFrame_IsConstructor_8 = 8;

void MyCefMet_CefV8StackFrame(cef_v8stack_frame_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefV8StackFrameCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefV8StackFrame_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8StackFrame_GetScriptName_2: {


		// gen! CefString GetScriptName()
		auto ret_result = me->GetScriptName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8StackFrame_GetScriptNameOrSourceURL_3: {


		// gen! CefString GetScriptNameOrSourceURL()
		auto ret_result = me->GetScriptNameOrSourceURL();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8StackFrame_GetFunctionName_4: {


		// gen! CefString GetFunctionName()
		auto ret_result = me->GetFunctionName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefV8StackFrame_GetLineNumber_5: {


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8StackFrame_GetColumn_6: {


		// gen! int GetColumn()
		auto ret_result = me->GetColumn();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefV8StackFrame_IsEval_7: {


		// gen! bool IsEval()
		auto ret_result = me->IsEval();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefV8StackFrame_IsConstructor_8: {


		// gen! bool IsConstructor()
		auto ret_result = me->IsConstructor();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefV8StackFrameCToCpp::Unwrap(me);
}


// [virtual] class CefValue
const int CefValue_IsValid_1 = 1;
const int CefValue_IsOwned_2 = 2;
const int CefValue_IsReadOnly_3 = 3;
const int CefValue_IsSame_4 = 4;
const int CefValue_IsEqual_5 = 5;
const int CefValue_Copy_6 = 6;
const int CefValue_GetType_7 = 7;
const int CefValue_GetBool_8 = 8;
const int CefValue_GetInt_9 = 9;
const int CefValue_GetDouble_10 = 10;
const int CefValue_GetString_11 = 11;
const int CefValue_GetBinary_12 = 12;
const int CefValue_GetDictionary_13 = 13;
const int CefValue_GetList_14 = 14;
const int CefValue_SetNull_15 = 15;
const int CefValue_SetBool_16 = 16;
const int CefValue_SetInt_17 = 17;
const int CefValue_SetDouble_18 = 18;
const int CefValue_SetString_19 = 19;
const int CefValue_SetBinary_20 = 20;
const int CefValue_SetDictionary_21 = 21;
const int CefValue_SetList_22 = 22;

void MyCefMet_CefValue(cef_value_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefValueCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefValue_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_IsOwned_2: {


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_IsReadOnly_3: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_IsSame_4: {


		// gen! bool IsSame(CefRefPtr<CefValue> that)
		auto ret_result = me->IsSame(CefValueCToCpp::Wrap((cef_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_IsEqual_5: {


		// gen! bool IsEqual(CefRefPtr<CefValue> that)
		auto ret_result = me->IsEqual(CefValueCToCpp::Wrap((cef_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_Copy_6: {


		// gen! CefRefPtr<CefValue> Copy()
		auto ret_result = me->Copy();
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
	} break;
	case CefValue_GetType_7: {


		// gen! CefValueType GetType()
		auto ret_result = me->GetType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefValue_GetBool_8: {


		// gen! bool GetBool()
		auto ret_result = me->GetBool();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_GetInt_9: {


		// gen! int GetInt()
		auto ret_result = me->GetInt();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefValue_GetDouble_10: {


		// gen! double GetDouble()
		auto ret_result = me->GetDouble();
		MyCefSetDouble(ret, ret_result);
	} break;
	case CefValue_GetString_11: {


		// gen! CefString GetString()
		auto ret_result = me->GetString();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefValue_GetBinary_12: {


		// gen! CefRefPtr<CefBinaryValue> GetBinary()
		auto ret_result = me->GetBinary();
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefValue_GetDictionary_13: {


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary()
		auto ret_result = me->GetDictionary();
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefValue_GetList_14: {


		// gen! CefRefPtr<CefListValue> GetList()
		auto ret_result = me->GetList();
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
	} break;
	case CefValue_SetNull_15: {


		// gen! bool SetNull()
		auto ret_result = me->SetNull();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetBool_16: {


		// gen! bool SetBool(bool value)
		auto ret_result = me->SetBool(v1->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetInt_17: {


		// gen! bool SetInt(int value)
		auto ret_result = me->SetInt(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetDouble_18: {


		// gen! bool SetDouble(double value)
		auto ret_result = me->SetDouble(v1->num);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetString_19: {


		// gen! bool SetString(const CefString& value)
		auto ret_result = me->SetString(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetBinary_20: {


		// gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetDictionary_21: {


		// gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefValue_SetList_22: {


		// gen! bool SetList(CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefValueCToCpp::Unwrap(me);
}


// [virtual] class CefBinaryValue
const int CefBinaryValue_IsValid_1 = 1;
const int CefBinaryValue_IsOwned_2 = 2;
const int CefBinaryValue_IsSame_3 = 3;
const int CefBinaryValue_IsEqual_4 = 4;
const int CefBinaryValue_Copy_5 = 5;
const int CefBinaryValue_GetSize_6 = 6;
const int CefBinaryValue_GetData_7 = 7;

void MyCefMet_CefBinaryValue(cef_binary_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefBinaryValueCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefBinaryValue_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBinaryValue_IsOwned_2: {


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBinaryValue_IsSame_3: {


		// gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
		auto ret_result = me->IsSame(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBinaryValue_IsEqual_4: {


		// gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
		auto ret_result = me->IsEqual(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefBinaryValue_Copy_5: {


		// gen! CefRefPtr<CefBinaryValue> Copy()
		auto ret_result = me->Copy();
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefBinaryValue_GetSize_6: {


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefBinaryValue_GetData_7: {


		// gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
		auto ret_result = me->GetData((void*)v1->ptr,
			v2->i64,
			v3->i64);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	}
	CefBinaryValueCToCpp::Unwrap(me);
}


// [virtual] class CefDictionaryValue
const int CefDictionaryValue_IsValid_1 = 1;
const int CefDictionaryValue_IsOwned_2 = 2;
const int CefDictionaryValue_IsReadOnly_3 = 3;
const int CefDictionaryValue_IsSame_4 = 4;
const int CefDictionaryValue_IsEqual_5 = 5;
const int CefDictionaryValue_Copy_6 = 6;
const int CefDictionaryValue_GetSize_7 = 7;
const int CefDictionaryValue_Clear_8 = 8;
const int CefDictionaryValue_HasKey_9 = 9;
const int CefDictionaryValue_GetKeys_10 = 10;
const int CefDictionaryValue_Remove_11 = 11;
const int CefDictionaryValue_GetType_12 = 12;
const int CefDictionaryValue_GetValue_13 = 13;
const int CefDictionaryValue_GetBool_14 = 14;
const int CefDictionaryValue_GetInt_15 = 15;
const int CefDictionaryValue_GetDouble_16 = 16;
const int CefDictionaryValue_GetString_17 = 17;
const int CefDictionaryValue_GetBinary_18 = 18;
const int CefDictionaryValue_GetDictionary_19 = 19;
const int CefDictionaryValue_GetList_20 = 20;
const int CefDictionaryValue_SetValue_21 = 21;
const int CefDictionaryValue_SetNull_22 = 22;
const int CefDictionaryValue_SetBool_23 = 23;
const int CefDictionaryValue_SetInt_24 = 24;
const int CefDictionaryValue_SetDouble_25 = 25;
const int CefDictionaryValue_SetString_26 = 26;
const int CefDictionaryValue_SetBinary_27 = 27;
const int CefDictionaryValue_SetDictionary_28 = 28;
const int CefDictionaryValue_SetList_29 = 29;

void MyCefMet_CefDictionaryValue(cef_dictionary_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDictionaryValueCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDictionaryValue_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_IsOwned_2: {


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_IsReadOnly_3: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_IsSame_4: {


		// gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
		auto ret_result = me->IsSame(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_IsEqual_5: {


		// gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
		auto ret_result = me->IsEqual(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_Copy_6: {


		// gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
		auto ret_result = me->Copy(v1->i32 != 0);
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefDictionaryValue_GetSize_7: {


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefDictionaryValue_Clear_8: {


		// gen! bool Clear()
		auto ret_result = me->Clear();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_HasKey_9: {


		// gen! bool HasKey(const CefString& key)
		auto ret_result = me->HasKey(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_GetKeys_10: {


		// gen! bool GetKeys(KeyList& keys)
		auto ret_result = me->GetKeys(*((CefDictionaryValue::KeyList*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_Remove_11: {


		// gen! bool Remove(const CefString& key)
		auto ret_result = me->Remove(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_GetType_12: {


		// gen! CefValueType GetType(const CefString& key)
		auto ret_result = me->GetType(GetStringHolder(v1)->value);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefDictionaryValue_GetValue_13: {


		// gen! CefRefPtr<CefValue> GetValue(const CefString& key)
		auto ret_result = me->GetValue(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
	} break;
	case CefDictionaryValue_GetBool_14: {


		// gen! bool GetBool(const CefString& key)
		auto ret_result = me->GetBool(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_GetInt_15: {


		// gen! int GetInt(const CefString& key)
		auto ret_result = me->GetInt(GetStringHolder(v1)->value);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefDictionaryValue_GetDouble_16: {


		// gen! double GetDouble(const CefString& key)
		auto ret_result = me->GetDouble(GetStringHolder(v1)->value);
		MyCefSetDouble(ret, ret_result);
	} break;
	case CefDictionaryValue_GetString_17: {


		// gen! CefString GetString(const CefString& key)
		auto ret_result = me->GetString(GetStringHolder(v1)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefDictionaryValue_GetBinary_18: {


		// gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
		auto ret_result = me->GetBinary(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefDictionaryValue_GetDictionary_19: {


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
		auto ret_result = me->GetDictionary(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefDictionaryValue_GetList_20: {


		// gen! CefRefPtr<CefListValue> GetList(const CefString& key)
		auto ret_result = me->GetList(GetStringHolder(v1)->value);
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
	} break;
	case CefDictionaryValue_SetValue_21: {


		// gen! bool SetValue(const CefString& key,CefRefPtr<CefValue> value)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetNull_22: {


		// gen! bool SetNull(const CefString& key)
		auto ret_result = me->SetNull(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetBool_23: {


		// gen! bool SetBool(const CefString& key,bool value)
		auto ret_result = me->SetBool(GetStringHolder(v1)->value,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetInt_24: {


		// gen! bool SetInt(const CefString& key,int value)
		auto ret_result = me->SetInt(GetStringHolder(v1)->value,
			v2->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetDouble_25: {


		// gen! bool SetDouble(const CefString& key,double value)
		auto ret_result = me->SetDouble(GetStringHolder(v1)->value,
			v2->num);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetString_26: {


		// gen! bool SetString(const CefString& key,const CefString& value)
		auto ret_result = me->SetString(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetBinary_27: {


		// gen! bool SetBinary(const CefString& key,CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(GetStringHolder(v1)->value,
			CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetDictionary_28: {


		// gen! bool SetDictionary(const CefString& key,CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(GetStringHolder(v1)->value,
			CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefDictionaryValue_SetList_29: {


		// gen! bool SetList(const CefString& key,CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(GetStringHolder(v1)->value,
			CefListValueCToCpp::Wrap((cef_list_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefDictionaryValueCToCpp::Unwrap(me);
}


// [virtual] class CefListValue
const int CefListValue_IsValid_1 = 1;
const int CefListValue_IsOwned_2 = 2;
const int CefListValue_IsReadOnly_3 = 3;
const int CefListValue_IsSame_4 = 4;
const int CefListValue_IsEqual_5 = 5;
const int CefListValue_Copy_6 = 6;
const int CefListValue_SetSize_7 = 7;
const int CefListValue_GetSize_8 = 8;
const int CefListValue_Clear_9 = 9;
const int CefListValue_Remove_10 = 10;
const int CefListValue_GetType_11 = 11;
const int CefListValue_GetValue_12 = 12;
const int CefListValue_GetBool_13 = 13;
const int CefListValue_GetInt_14 = 14;
const int CefListValue_GetDouble_15 = 15;
const int CefListValue_GetString_16 = 16;
const int CefListValue_GetBinary_17 = 17;
const int CefListValue_GetDictionary_18 = 18;
const int CefListValue_GetList_19 = 19;
const int CefListValue_SetValue_20 = 20;
const int CefListValue_SetNull_21 = 21;
const int CefListValue_SetBool_22 = 22;
const int CefListValue_SetInt_23 = 23;
const int CefListValue_SetDouble_24 = 24;
const int CefListValue_SetString_25 = 25;
const int CefListValue_SetBinary_26 = 26;
const int CefListValue_SetDictionary_27 = 27;
const int CefListValue_SetList_28 = 28;

void MyCefMet_CefListValue(cef_list_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefListValueCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefListValue_IsValid_1: {


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_IsOwned_2: {


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_IsReadOnly_3: {


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_IsSame_4: {


		// gen! bool IsSame(CefRefPtr<CefListValue> that)
		auto ret_result = me->IsSame(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_IsEqual_5: {


		// gen! bool IsEqual(CefRefPtr<CefListValue> that)
		auto ret_result = me->IsEqual(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_Copy_6: {


		// gen! CefRefPtr<CefListValue> Copy()
		auto ret_result = me->Copy();
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
	} break;
	case CefListValue_SetSize_7: {


		// gen! bool SetSize(size_t size)
		auto ret_result = me->SetSize(v1->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_GetSize_8: {


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefListValue_Clear_9: {


		// gen! bool Clear()
		auto ret_result = me->Clear();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_Remove_10: {


		// gen! bool Remove(size_t index)
		auto ret_result = me->Remove(v1->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_GetType_11: {


		// gen! CefValueType GetType(size_t index)
		auto ret_result = me->GetType(v1->i64);
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefListValue_GetValue_12: {


		// gen! CefRefPtr<CefValue> GetValue(size_t index)
		auto ret_result = me->GetValue(v1->i64);
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
	} break;
	case CefListValue_GetBool_13: {


		// gen! bool GetBool(size_t index)
		auto ret_result = me->GetBool(v1->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_GetInt_14: {


		// gen! int GetInt(size_t index)
		auto ret_result = me->GetInt(v1->i64);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefListValue_GetDouble_15: {


		// gen! double GetDouble(size_t index)
		auto ret_result = me->GetDouble(v1->i64);
		MyCefSetDouble(ret, ret_result);
	} break;
	case CefListValue_GetString_16: {


		// gen! CefString GetString(size_t index)
		auto ret_result = me->GetString(v1->i64);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefListValue_GetBinary_17: {


		// gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
		auto ret_result = me->GetBinary(v1->i64);
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefListValue_GetDictionary_18: {


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
		auto ret_result = me->GetDictionary(v1->i64);
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefListValue_GetList_19: {


		// gen! CefRefPtr<CefListValue> GetList(size_t index)
		auto ret_result = me->GetList(v1->i64);
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
	} break;
	case CefListValue_SetValue_20: {


		// gen! bool SetValue(size_t index,CefRefPtr<CefValue> value)
		auto ret_result = me->SetValue(v1->i64,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetNull_21: {


		// gen! bool SetNull(size_t index)
		auto ret_result = me->SetNull(v1->i64);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetBool_22: {


		// gen! bool SetBool(size_t index,bool value)
		auto ret_result = me->SetBool(v1->i64,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetInt_23: {


		// gen! bool SetInt(size_t index,int value)
		auto ret_result = me->SetInt(v1->i64,
			v2->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetDouble_24: {


		// gen! bool SetDouble(size_t index,double value)
		auto ret_result = me->SetDouble(v1->i64,
			v2->num);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetString_25: {


		// gen! bool SetString(size_t index,const CefString& value)
		auto ret_result = me->SetString(v1->i64,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetBinary_26: {


		// gen! bool SetBinary(size_t index,CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(v1->i64,
			CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetDictionary_27: {


		// gen! bool SetDictionary(size_t index,CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(v1->i64,
			CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	case CefListValue_SetList_28: {


		// gen! bool SetList(size_t index,CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(v1->i64,
			CefListValueCToCpp::Wrap((cef_list_value_t*)v2->ptr));
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefListValueCToCpp::Unwrap(me);
}


// [virtual] class CefWebPluginInfo
const int CefWebPluginInfo_GetName_1 = 1;
const int CefWebPluginInfo_GetPath_2 = 2;
const int CefWebPluginInfo_GetVersion_3 = 3;
const int CefWebPluginInfo_GetDescription_4 = 4;

void MyCefMet_CefWebPluginInfo(cef_web_plugin_info_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefWebPluginInfoCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefWebPluginInfo_GetName_1: {


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefWebPluginInfo_GetPath_2: {


		// gen! CefString GetPath()
		auto ret_result = me->GetPath();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefWebPluginInfo_GetVersion_3: {


		// gen! CefString GetVersion()
		auto ret_result = me->GetVersion();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefWebPluginInfo_GetDescription_4: {


		// gen! CefString GetDescription()
		auto ret_result = me->GetDescription();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	}
	CefWebPluginInfoCToCpp::Unwrap(me);
}


// [virtual] class CefWebPluginInfoVisitor
const int CefWebPluginInfoVisitor_Visit_1 = 1;

void MyCefMet_CefWebPluginInfoVisitor(cef_web_plugin_info_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefWebPluginInfoVisitorCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefWebPluginInfoVisitor_Visit_1: {


		// gen! bool Visit(CefRefPtr<CefWebPluginInfo> info,int count,int total)
		auto ret_result = me->Visit(CefWebPluginInfoCToCpp::Wrap((cef_web_plugin_info_t*)v1->ptr),
			v2->i32,
			v3->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefWebPluginInfoVisitorCppToC::Wrap(me);
}
const int MyCefWebPluginInfoVisitor_Visit_1 = 1;
class MyCefWebPluginInfoVisitor :public CefWebPluginInfoVisitorCppToC {
public:
	managed_callback mcallback;
	explicit MyCefWebPluginInfoVisitor() {
		mcallback = NULL;
	}
	//gen! bool Visit(CefRefPtr<CefWebPluginInfo> info,int count,int total)
	virtual bool Visit(CefRefPtr<CefWebPluginInfo> info, int count, int total) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr(&args.v1, CefWebPluginInfoCToCpp::Unwrap(info));
			MyCefSetInt64(&args.v2, count);
			MyCefSetInt64(&args.v3, total);
			this->mcallback(MyCefWebPluginInfoVisitor_Visit_1, &args);
			return args.ret.i32 != 0;
		}
		return false;
	}
};


// [virtual] class CefX509CertPrincipal
const int CefX509CertPrincipal_GetDisplayName_1 = 1;
const int CefX509CertPrincipal_GetCommonName_2 = 2;
const int CefX509CertPrincipal_GetLocalityName_3 = 3;
const int CefX509CertPrincipal_GetStateOrProvinceName_4 = 4;
const int CefX509CertPrincipal_GetCountryName_5 = 5;
const int CefX509CertPrincipal_GetStreetAddresses_6 = 6;
const int CefX509CertPrincipal_GetOrganizationNames_7 = 7;
const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = 8;
const int CefX509CertPrincipal_GetDomainComponents_9 = 9;

void MyCefMet_CefX509CertPrincipal(cef_x509cert_principal_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefX509CertPrincipalCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefX509CertPrincipal_GetDisplayName_1: {


		// gen! CefString GetDisplayName()
		auto ret_result = me->GetDisplayName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefX509CertPrincipal_GetCommonName_2: {


		// gen! CefString GetCommonName()
		auto ret_result = me->GetCommonName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefX509CertPrincipal_GetLocalityName_3: {


		// gen! CefString GetLocalityName()
		auto ret_result = me->GetLocalityName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefX509CertPrincipal_GetStateOrProvinceName_4: {


		// gen! CefString GetStateOrProvinceName()
		auto ret_result = me->GetStateOrProvinceName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefX509CertPrincipal_GetCountryName_5: {


		// gen! CefString GetCountryName()
		auto ret_result = me->GetCountryName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefX509CertPrincipal_GetStreetAddresses_6: {


		// gen! void GetStreetAddresses(std::vector<CefString>& addresses)
		me->GetStreetAddresses(*((std::vector<CefString>*)v1->ptr));

	} break;
	case CefX509CertPrincipal_GetOrganizationNames_7: {


		// gen! void GetOrganizationNames(std::vector<CefString>& names)
		me->GetOrganizationNames(*((std::vector<CefString>*)v1->ptr));

	} break;
	case CefX509CertPrincipal_GetOrganizationUnitNames_8: {


		// gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
		me->GetOrganizationUnitNames(*((std::vector<CefString>*)v1->ptr));

	} break;
	case CefX509CertPrincipal_GetDomainComponents_9: {


		// gen! void GetDomainComponents(std::vector<CefString>& components)
		me->GetDomainComponents(*((std::vector<CefString>*)v1->ptr));

	} break;
	}
	CefX509CertPrincipalCToCpp::Unwrap(me);
}


// [virtual] class CefX509Certificate
const int CefX509Certificate_GetSubject_1 = 1;
const int CefX509Certificate_GetIssuer_2 = 2;
const int CefX509Certificate_GetSerialNumber_3 = 3;
const int CefX509Certificate_GetValidStart_4 = 4;
const int CefX509Certificate_GetValidExpiry_5 = 5;
const int CefX509Certificate_GetDEREncoded_6 = 6;
const int CefX509Certificate_GetPEMEncoded_7 = 7;
const int CefX509Certificate_GetIssuerChainSize_8 = 8;
const int CefX509Certificate_GetDEREncodedIssuerChain_9 = 9;
const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = 10;

void MyCefMet_CefX509Certificate(cef_x509certificate_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefX509CertificateCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefX509Certificate_GetSubject_1: {


		// gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
		auto ret_result = me->GetSubject();
		MyCefSetVoidPtr(ret, CefX509CertPrincipalCToCpp::Unwrap(ret_result));
	} break;
	case CefX509Certificate_GetIssuer_2: {


		// gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
		auto ret_result = me->GetIssuer();
		MyCefSetVoidPtr(ret, CefX509CertPrincipalCToCpp::Unwrap(ret_result));
	} break;
	case CefX509Certificate_GetSerialNumber_3: {


		// gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
		auto ret_result = me->GetSerialNumber();
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefX509Certificate_GetValidStart_4: {


		// gen! CefTime GetValidStart()
		auto ret_result = me->GetValidStart();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefX509Certificate_GetValidExpiry_5: {


		// gen! CefTime GetValidExpiry()
		auto ret_result = me->GetValidExpiry();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefX509Certificate_GetDEREncoded_6: {


		// gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
		auto ret_result = me->GetDEREncoded();
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefX509Certificate_GetPEMEncoded_7: {


		// gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
		auto ret_result = me->GetPEMEncoded();
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
	} break;
	case CefX509Certificate_GetIssuerChainSize_8: {


		// gen! size_t GetIssuerChainSize()
		auto ret_result = me->GetIssuerChainSize();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefX509Certificate_GetDEREncodedIssuerChain_9: {


		// gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
		me->GetDEREncodedIssuerChain(*((CefX509Certificate::IssuerChainBinaryList*)v1->ptr));

	} break;
	case CefX509Certificate_GetPEMEncodedIssuerChain_10: {


		// gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
		me->GetPEMEncodedIssuerChain(*((CefX509Certificate::IssuerChainBinaryList*)v1->ptr));

	} break;
	}
	CefX509CertificateCToCpp::Unwrap(me);
}


// [virtual] class CefXmlReader
const int CefXmlReader_MoveToNextNode_1 = 1;
const int CefXmlReader_Close_2 = 2;
const int CefXmlReader_HasError_3 = 3;
const int CefXmlReader_GetError_4 = 4;
const int CefXmlReader_GetType_5 = 5;
const int CefXmlReader_GetDepth_6 = 6;
const int CefXmlReader_GetLocalName_7 = 7;
const int CefXmlReader_GetPrefix_8 = 8;
const int CefXmlReader_GetQualifiedName_9 = 9;
const int CefXmlReader_GetNamespaceURI_10 = 10;
const int CefXmlReader_GetBaseURI_11 = 11;
const int CefXmlReader_GetXmlLang_12 = 12;
const int CefXmlReader_IsEmptyElement_13 = 13;
const int CefXmlReader_HasValue_14 = 14;
const int CefXmlReader_GetValue_15 = 15;
const int CefXmlReader_HasAttributes_16 = 16;
const int CefXmlReader_GetAttributeCount_17 = 17;
const int CefXmlReader_GetAttribute_18 = 18;
const int CefXmlReader_GetAttribute_19 = 19;
const int CefXmlReader_GetAttribute_20 = 20;
const int CefXmlReader_GetInnerXml_21 = 21;
const int CefXmlReader_GetOuterXml_22 = 22;
const int CefXmlReader_GetLineNumber_23 = 23;
const int CefXmlReader_MoveToAttribute_24 = 24;
const int CefXmlReader_MoveToAttribute_25 = 25;
const int CefXmlReader_MoveToAttribute_26 = 26;
const int CefXmlReader_MoveToFirstAttribute_27 = 27;
const int CefXmlReader_MoveToNextAttribute_28 = 28;
const int CefXmlReader_MoveToCarryingElement_29 = 29;

void MyCefMet_CefXmlReader(cef_xml_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefXmlReaderCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefXmlReader_MoveToNextNode_1: {


		// gen! bool MoveToNextNode()
		auto ret_result = me->MoveToNextNode();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_Close_2: {


		// gen! bool Close()
		auto ret_result = me->Close();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_HasError_3: {


		// gen! bool HasError()
		auto ret_result = me->HasError();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_GetError_4: {


		// gen! CefString GetError()
		auto ret_result = me->GetError();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetType_5: {


		// gen! NodeType GetType()
		auto ret_result = me->GetType();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefXmlReader_GetDepth_6: {


		// gen! int GetDepth()
		auto ret_result = me->GetDepth();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefXmlReader_GetLocalName_7: {


		// gen! CefString GetLocalName()
		auto ret_result = me->GetLocalName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetPrefix_8: {


		// gen! CefString GetPrefix()
		auto ret_result = me->GetPrefix();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetQualifiedName_9: {


		// gen! CefString GetQualifiedName()
		auto ret_result = me->GetQualifiedName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetNamespaceURI_10: {


		// gen! CefString GetNamespaceURI()
		auto ret_result = me->GetNamespaceURI();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetBaseURI_11: {


		// gen! CefString GetBaseURI()
		auto ret_result = me->GetBaseURI();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetXmlLang_12: {


		// gen! CefString GetXmlLang()
		auto ret_result = me->GetXmlLang();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_IsEmptyElement_13: {


		// gen! bool IsEmptyElement()
		auto ret_result = me->IsEmptyElement();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_HasValue_14: {


		// gen! bool HasValue()
		auto ret_result = me->HasValue();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_GetValue_15: {


		// gen! CefString GetValue()
		auto ret_result = me->GetValue();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_HasAttributes_16: {


		// gen! bool HasAttributes()
		auto ret_result = me->HasAttributes();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_GetAttributeCount_17: {


		// gen! size_t GetAttributeCount()
		auto ret_result = me->GetAttributeCount();
		MyCefSetInt32(ret, (int32_t)ret_result);
	} break;
	case CefXmlReader_GetAttribute_18: {


		// gen! CefString GetAttribute(int index)
		auto ret_result = me->GetAttribute(v1->i32);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetAttribute_19: {


		// gen! CefString GetAttribute(const CefString& qualifiedName)
		auto ret_result = me->GetAttribute(GetStringHolder(v1)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetAttribute_20: {


		// gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)
		auto ret_result = me->GetAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetInnerXml_21: {


		// gen! CefString GetInnerXml()
		auto ret_result = me->GetInnerXml();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetOuterXml_22: {


		// gen! CefString GetOuterXml()
		auto ret_result = me->GetOuterXml();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefXmlReader_GetLineNumber_23: {


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefXmlReader_MoveToAttribute_24: {


		// gen! bool MoveToAttribute(int index)
		auto ret_result = me->MoveToAttribute(v1->i32);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_MoveToAttribute_25: {


		// gen! bool MoveToAttribute(const CefString& qualifiedName)
		auto ret_result = me->MoveToAttribute(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_MoveToAttribute_26: {


		// gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)
		auto ret_result = me->MoveToAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_MoveToFirstAttribute_27: {


		// gen! bool MoveToFirstAttribute()
		auto ret_result = me->MoveToFirstAttribute();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_MoveToNextAttribute_28: {


		// gen! bool MoveToNextAttribute()
		auto ret_result = me->MoveToNextAttribute();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefXmlReader_MoveToCarryingElement_29: {


		// gen! bool MoveToCarryingElement()
		auto ret_result = me->MoveToCarryingElement();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefXmlReaderCToCpp::Unwrap(me);
}


// [virtual] class CefZipReader
const int CefZipReader_MoveToFirstFile_1 = 1;
const int CefZipReader_MoveToNextFile_2 = 2;
const int CefZipReader_MoveToFile_3 = 3;
const int CefZipReader_Close_4 = 4;
const int CefZipReader_GetFileName_5 = 5;
const int CefZipReader_GetFileSize_6 = 6;
const int CefZipReader_GetFileLastModified_7 = 7;
const int CefZipReader_OpenFile_8 = 8;
const int CefZipReader_CloseFile_9 = 9;
const int CefZipReader_ReadFile_10 = 10;
const int CefZipReader_Tell_11 = 11;
const int CefZipReader_Eof_12 = 12;

void MyCefMet_CefZipReader(cef_zip_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefZipReaderCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefZipReader_MoveToFirstFile_1: {


		// gen! bool MoveToFirstFile()
		auto ret_result = me->MoveToFirstFile();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefZipReader_MoveToNextFile_2: {


		// gen! bool MoveToNextFile()
		auto ret_result = me->MoveToNextFile();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefZipReader_MoveToFile_3: {


		// gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
		auto ret_result = me->MoveToFile(GetStringHolder(v1)->value,
			v2->i32 != 0);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefZipReader_Close_4: {


		// gen! bool Close()
		auto ret_result = me->Close();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefZipReader_GetFileName_5: {


		// gen! CefString GetFileName()
		auto ret_result = me->GetFileName();
		SetCefStringToJsValue(ret, ret_result);
	} break;
	case CefZipReader_GetFileSize_6: {


		// gen! int64 GetFileSize()
		auto ret_result = me->GetFileSize();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefZipReader_GetFileLastModified_7: {


		// gen! CefTime GetFileLastModified()
		auto ret_result = me->GetFileLastModified();
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

	} break;
	case CefZipReader_OpenFile_8: {


		// gen! bool OpenFile(const CefString& password)
		auto ret_result = me->OpenFile(GetStringHolder(v1)->value);
		MyCefSetBool(ret, ret_result);
	} break;
	case CefZipReader_CloseFile_9: {


		// gen! bool CloseFile()
		auto ret_result = me->CloseFile();
		MyCefSetBool(ret, ret_result);
	} break;
	case CefZipReader_ReadFile_10: {


		// gen! int ReadFile(void* buffer,size_t bufferSize)
		auto ret_result = me->ReadFile((void*)v1->ptr,
			v2->i64);
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefZipReader_Tell_11: {


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		MyCefSetInt64(ret, ret_result);
	} break;
	case CefZipReader_Eof_12: {


		// gen! bool Eof()
		auto ret_result = me->Eof();
		MyCefSetBool(ret, ret_result);
	} break;
	}
	CefZipReaderCToCpp::Unwrap(me);
}

const int CefAuthCallback_Continue_1 = 1;
const int CefAuthCallback_Cancel_2 = 2;

void MyCefMet_CefAuthCallback(cef_auth_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefAuthCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefAuthCallback_Continue_1: {


		// gen! void Continue(const CefString& username,const CefString& password)
		me->Continue(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);

	} break;
	case CefAuthCallback_Cancel_2: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefAuthCallbackCToCpp::Unwrap(me);
}
const int MyCefRunFileDialogCallback_OnFileDialogDismissed_1 = 1;
class MyCefRunFileDialogCallback :public CefRunFileDialogCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefRunFileDialogCallback() {
		mcallback = NULL;
	}
	//gen! void OnFileDialogDismissed(int selected_accept_filter,const std::vector<CefString>& file_paths)
	virtual void OnFileDialogDismissed(int selected_accept_filter, const std::vector<CefString>& file_paths) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetInt64(&args.v1, selected_accept_filter);
			MyCefSetVoidPtr2(&args.v2, &file_paths);
			this->mcallback(MyCefRunFileDialogCallback_OnFileDialogDismissed_1, &args);
		}
	}
};
const int CefRunFileDialogCallback_OnFileDialogDismissed_1 = 1;

void MyCefMet_CefRunFileDialogCallback(cef_run_file_dialog_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefRunFileDialogCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefRunFileDialogCallbackCppToC::Wrap(me);
}
const int MyCefPdfPrintCallback_OnPdfPrintFinished_1 = 1;
class MyCefPdfPrintCallback :public CefPdfPrintCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefPdfPrintCallback() {
		mcallback = NULL;
	}
	//gen! void OnPdfPrintFinished(const CefString& path,bool ok)
	virtual void OnPdfPrintFinished(const CefString& path, bool ok) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, path);
			MyCefSetBool(&args.v2, ok);
			this->mcallback(MyCefPdfPrintCallback_OnPdfPrintFinished_1, &args);
		}
	}
};
const int CefPdfPrintCallback_OnPdfPrintFinished_1 = 1;

void MyCefMet_CefPdfPrintCallback(cef_pdf_print_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefPdfPrintCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefPdfPrintCallbackCppToC::Wrap(me);
}
const int MyCefDownloadImageCallback_OnDownloadImageFinished_1 = 1;
class MyCefDownloadImageCallback :public CefDownloadImageCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefDownloadImageCallback() {
		mcallback = NULL;
	}
	//gen! void OnDownloadImageFinished(const CefString& image_url,int http_status_code,CefRefPtr<CefImage> image)
	virtual void OnDownloadImageFinished(const CefString& image_url, int http_status_code, CefRefPtr<CefImage> image) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, image_url);
			MyCefSetInt64(&args.v2, http_status_code);
			MyCefSetVoidPtr(&args.v3, CefImageCToCpp::Unwrap(image));
			this->mcallback(MyCefDownloadImageCallback_OnDownloadImageFinished_1, &args);
		}
	}
};
const int CefDownloadImageCallback_OnDownloadImageFinished_1 = 1;

void MyCefMet_CefDownloadImageCallback(cef_download_image_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDownloadImageCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefDownloadImageCallbackCppToC::Wrap(me);
}
const int CefCallback_Continue_1 = 1;
const int CefCallback_Cancel_2 = 2;

void MyCefMet_CefCallback(cef_callback_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefCallback_Continue_1: {


		// gen! void Continue()
		me->Continue();

	} break;
	case CefCallback_Cancel_2: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefCallbackCToCpp::Unwrap(me);
}
const int MyCefCompletionCallback_OnComplete_1 = 1;
class MyCefCompletionCallback :public CefCompletionCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefCompletionCallback() {
		mcallback = NULL;
	}
	//gen! void OnComplete()
	virtual void OnComplete() {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			this->mcallback(MyCefCompletionCallback_OnComplete_1, &args);
		}
	}
};
const int CefCompletionCallback_OnComplete_1 = 1;

void MyCefMet_CefCompletionCallback(cef_completion_callback_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefCompletionCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefCompletionCallbackCppToC::Wrap(me);
}
const int CefRunContextMenuCallback_Continue_1 = 1;
const int CefRunContextMenuCallback_Cancel_2 = 2;

void MyCefMet_CefRunContextMenuCallback(cef_run_context_menu_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefRunContextMenuCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefRunContextMenuCallback_Continue_1: {


		// gen! void Continue(int command_id,EventFlags event_flags)
		me->Continue(v1->i32,
			(cef_event_flags_t)v2->i32);

	} break;
	case CefRunContextMenuCallback_Cancel_2: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefRunContextMenuCallbackCToCpp::Unwrap(me);
}
const int MyCefSetCookieCallback_OnComplete_1 = 1;
class MyCefSetCookieCallback :public CefSetCookieCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefSetCookieCallback() {
		mcallback = NULL;
	}
	//gen! void OnComplete(bool success)
	virtual void OnComplete(bool success) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetBool(&args.v1, success);
			this->mcallback(MyCefSetCookieCallback_OnComplete_1, &args);
		}
	}
};
const int CefSetCookieCallback_OnComplete_1 = 1;

void MyCefMet_CefSetCookieCallback(cef_set_cookie_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefSetCookieCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefSetCookieCallbackCppToC::Wrap(me);
}
const int MyCefDeleteCookiesCallback_OnComplete_1 = 1;
class MyCefDeleteCookiesCallback :public CefDeleteCookiesCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefDeleteCookiesCallback() {
		mcallback = NULL;
	}
	//gen! void OnComplete(int num_deleted)
	virtual void OnComplete(int num_deleted) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetInt64(&args.v1, num_deleted);
			this->mcallback(MyCefDeleteCookiesCallback_OnComplete_1, &args);
		}
	}
};
const int CefDeleteCookiesCallback_OnComplete_1 = 1;

void MyCefMet_CefDeleteCookiesCallback(cef_delete_cookies_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDeleteCookiesCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefDeleteCookiesCallbackCppToC::Wrap(me);
}
const int CefFileDialogCallback_Continue_1 = 1;
const int CefFileDialogCallback_Cancel_2 = 2;

void MyCefMet_CefFileDialogCallback(cef_file_dialog_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefFileDialogCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefFileDialogCallback_Continue_1: {


		// gen! void Continue(int selected_accept_filter,const std::vector<CefString>& file_paths)
		me->Continue(v1->i32,
			*((std::vector<CefString>*)v2->ptr));

	} break;
	case CefFileDialogCallback_Cancel_2: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefFileDialogCallbackCToCpp::Unwrap(me);
}
const int CefBeforeDownloadCallback_Continue_1 = 1;

void MyCefMet_CefBeforeDownloadCallback(cef_before_download_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefBeforeDownloadCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefBeforeDownloadCallback_Continue_1: {


		// gen! void Continue(const CefString& download_path,bool show_dialog)
		me->Continue(GetStringHolder(v1)->value,
			v2->i32 != 0);

	} break;
	}
	CefBeforeDownloadCallbackCToCpp::Unwrap(me);
}
const int CefDownloadItemCallback_Cancel_1 = 1;
const int CefDownloadItemCallback_Pause_2 = 2;
const int CefDownloadItemCallback_Resume_3 = 3;

void MyCefMet_CefDownloadItemCallback(cef_download_item_callback_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefDownloadItemCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefDownloadItemCallback_Cancel_1: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	case CefDownloadItemCallback_Pause_2: {


		// gen! void Pause()
		me->Pause();

	} break;
	case CefDownloadItemCallback_Resume_3: {


		// gen! void Resume()
		me->Resume();

	} break;
	}
	CefDownloadItemCallbackCToCpp::Unwrap(me);
}
const int MyCefGetGeolocationCallback_OnLocationUpdate_1 = 1;
class MyCefGetGeolocationCallback :public CefGetGeolocationCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefGetGeolocationCallback() {
		mcallback = NULL;
	}
	//gen! void OnLocationUpdate(const CefGeoposition& position)
	virtual void OnLocationUpdate(const CefGeoposition& position) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetVoidPtr2(&args.v1, &position);
			this->mcallback(MyCefGetGeolocationCallback_OnLocationUpdate_1, &args);
		}
	}
};
const int CefGetGeolocationCallback_OnLocationUpdate_1 = 1;

void MyCefMet_CefGetGeolocationCallback(cef_get_geolocation_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefGetGeolocationCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefGetGeolocationCallbackCppToC::Wrap(me);
}
const int CefGeolocationCallback_Continue_1 = 1;

void MyCefMet_CefGeolocationCallback(cef_geolocation_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefGeolocationCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefGeolocationCallback_Continue_1: {


		// gen! void Continue(bool allow)
		me->Continue(v1->i32 != 0);

	} break;
	}
	CefGeolocationCallbackCToCpp::Unwrap(me);
}
const int CefJSDialogCallback_Continue_1 = 1;

void MyCefMet_CefJSDialogCallback(cef_jsdialog_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefJSDialogCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefJSDialogCallback_Continue_1: {


		// gen! void Continue(bool success,const CefString& user_input)
		me->Continue(v1->i32 != 0,
			GetStringHolder(v2)->value);

	} break;
	}
	CefJSDialogCallbackCToCpp::Unwrap(me);
}
const int CefPrintDialogCallback_Continue_1 = 1;
const int CefPrintDialogCallback_Cancel_2 = 2;

void MyCefMet_CefPrintDialogCallback(cef_print_dialog_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefPrintDialogCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefPrintDialogCallback_Continue_1: {


		// gen! void Continue(CefRefPtr<CefPrintSettings> settings)
		me->Continue(CefPrintSettingsCToCpp::Wrap((cef_print_settings_t*)v1->ptr));

	} break;
	case CefPrintDialogCallback_Cancel_2: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefPrintDialogCallbackCToCpp::Unwrap(me);
}
const int CefPrintJobCallback_Continue_1 = 1;

void MyCefMet_CefPrintJobCallback(cef_print_job_callback_t* me1, int metName, jsvalue* ret) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefPrintJobCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefPrintJobCallback_Continue_1: {


		// gen! void Continue()
		me->Continue();

	} break;
	}
	CefPrintJobCallbackCToCpp::Unwrap(me);
}
const int MyCefResolveCallback_OnResolveCompleted_1 = 1;
class MyCefResolveCallback :public CefResolveCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefResolveCallback() {
		mcallback = NULL;
	}
	//gen! void OnResolveCompleted(cef_errorcode_t result,const std::vector<CefString>& resolved_ips)
	virtual void OnResolveCompleted(cef_errorcode_t result, const std::vector<CefString>& resolved_ips) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetInt32(&args.v1, (int32_t)result);
			MyCefSetVoidPtr2(&args.v2, &resolved_ips);
			this->mcallback(MyCefResolveCallback_OnResolveCompleted_1, &args);
		}
	}
};
const int CefResolveCallback_OnResolveCompleted_1 = 1;

void MyCefMet_CefResolveCallback(cef_resolve_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefResolveCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefResolveCallbackCppToC::Wrap(me);
}
const int CefRequestCallback_Continue_1 = 1;
const int CefRequestCallback_Cancel_2 = 2;

void MyCefMet_CefRequestCallback(cef_request_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefRequestCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefRequestCallback_Continue_1: {


		// gen! void Continue(bool allow)
		me->Continue(v1->i32 != 0);

	} break;
	case CefRequestCallback_Cancel_2: {


		// gen! void Cancel()
		me->Cancel();

	} break;
	}
	CefRequestCallbackCToCpp::Unwrap(me);
}
const int CefSelectClientCertificateCallback_Select_1 = 1;

void MyCefMet_CefSelectClientCertificateCallback(cef_select_client_certificate_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefSelectClientCertificateCallbackCToCpp::Wrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefSelectClientCertificateCallback_Select_1: {


		// gen! void Select(CefRefPtr<CefX509Certificate> cert)
		me->Select(CefX509CertificateCToCpp::Wrap((cef_x509certificate_t*)v1->ptr));

	} break;
	}
	CefSelectClientCertificateCallbackCToCpp::Unwrap(me);
}
const int MyCefEndTracingCallback_OnEndTracingComplete_1 = 1;
class MyCefEndTracingCallback :public CefEndTracingCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefEndTracingCallback() {
		mcallback = NULL;
	}
	//gen! void OnEndTracingComplete(const CefString& tracing_file)
	virtual void OnEndTracingComplete(const CefString& tracing_file) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			SetCefStringToJsValue(&args.v1, tracing_file);
			this->mcallback(MyCefEndTracingCallback_OnEndTracingComplete_1, &args);
		}
	}
};
const int CefEndTracingCallback_OnEndTracingComplete_1 = 1;

void MyCefMet_CefEndTracingCallback(cef_end_tracing_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefEndTracingCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefEndTracingCallbackCppToC::Wrap(me);
}
const int CefWebPluginUnstableCallback_IsUnstable_1 = 1;

void MyCefMet_CefWebPluginUnstableCallback(cef_web_plugin_unstable_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefWebPluginUnstableCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	case CefWebPluginUnstableCallback_IsUnstable_1: {


		// gen! void IsUnstable(const CefString& path,bool unstable)
		me->IsUnstable(GetStringHolder(v1)->value,
			v2->i32 != 0);

	} break;
	}
	CefWebPluginUnstableCallbackCppToC::Wrap(me);
}
const int MyCefRegisterCdmCallback_OnCdmRegistrationComplete_1 = 1;
class MyCefRegisterCdmCallback :public CefRegisterCdmCallbackCppToC {
public:
	managed_callback mcallback;
	explicit MyCefRegisterCdmCallback() {
		mcallback = NULL;
	}
	//gen! void OnCdmRegistrationComplete(cef_cdm_registration_error_t result,const CefString& error_message)
	virtual void OnCdmRegistrationComplete(cef_cdm_registration_error_t result, const CefString& error_message) {
		if (this->mcallback) {
			MyMetArgs2 args;
			memset(&args, 0, sizeof(MyMetArgs2));
			MyCefSetInt32(&args.v1, (int32_t)result);
			SetCefStringToJsValue(&args.v2, error_message);
			this->mcallback(MyCefRegisterCdmCallback_OnCdmRegistrationComplete_1, &args);
		}
	}
};
const int CefRegisterCdmCallback_OnCdmRegistrationComplete_1 = 1;

void MyCefMet_CefRegisterCdmCallback(cef_register_cdm_callback_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	ret->type = JSVALUE_TYPE_EMPTY;
	auto me = CefRegisterCdmCallbackCppToC::Unwrap(me1);
	switch (metName) {
	case MET_Release:return; //yes, just return
	}
	CefRegisterCdmCallbackCppToC::Wrap(me);
}
void MyCefMet_CallN(void* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7) {
	int cefTypeName = (metName >> 16);
	switch (cefTypeName)
	{
	default: break;
	case CefTypeName_CefApp:
	{
		MyCefMet_CefApp((cef_app_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefBrowser:
	{
		MyCefMet_CefBrowser((cef_browser_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefNavigationEntryVisitor:
	{
		MyCefMet_CefNavigationEntryVisitor((cef_navigation_entry_visitor_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefBrowserHost:
	{
		MyCefMet_CefBrowserHost((cef_browser_host_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5, v6);
		break;
	}
	case CefTypeName_CefClient:
	{
		MyCefMet_CefClient((cef_client_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefCommandLine:
	{
		MyCefMet_CefCommandLine((cef_command_line_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefContextMenuParams:
	{
		MyCefMet_CefContextMenuParams((cef_context_menu_params_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefCookieManager:
	{
		MyCefMet_CefCookieManager((cef_cookie_manager_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefCookieVisitor:
	{
		MyCefMet_CefCookieVisitor((cef_cookie_visitor_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefDOMVisitor:
	{
		MyCefMet_CefDOMVisitor((cef_domvisitor_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefDOMDocument:
	{
		MyCefMet_CefDOMDocument((cef_domdocument_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefDOMNode:
	{
		MyCefMet_CefDOMNode((cef_domnode_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefDownloadItem:
	{
		MyCefMet_CefDownloadItem((cef_download_item_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefDragData:
	{
		MyCefMet_CefDragData((cef_drag_data_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefFrame:
	{
		MyCefMet_CefFrame((cef_frame_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefImage:
	{
		MyCefMet_CefImage((cef_image_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5, v6, v7);
		break;
	}
	case CefTypeName_CefMenuModel:
	{
		MyCefMet_CefMenuModel((cef_menu_model_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5);
		break;
	}
	case CefTypeName_CefMenuModelDelegate:
	{
		MyCefMet_CefMenuModelDelegate((cef_menu_model_delegate_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefNavigationEntry:
	{
		MyCefMet_CefNavigationEntry((cef_navigation_entry_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefPrintSettings:
	{
		MyCefMet_CefPrintSettings((cef_print_settings_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefProcessMessage:
	{
		MyCefMet_CefProcessMessage((cef_process_message_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefRequest:
	{
		MyCefMet_CefRequest((cef_request_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefPostData:
	{
		MyCefMet_CefPostData((cef_post_data_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefPostDataElement:
	{
		MyCefMet_CefPostDataElement((cef_post_data_element_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefRequestContext:
	{
		MyCefMet_CefRequestContext((cef_request_context_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefResourceBundle:
	{
		MyCefMet_CefResourceBundle((cef_resource_bundle_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefResponse:
	{
		MyCefMet_CefResponse((cef_response_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefResponseFilter:
	{
		MyCefMet_CefResponseFilter((cef_response_filter_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5, v6);
		break;
	}
	case CefTypeName_CefSchemeHandlerFactory:
	{
		MyCefMet_CefSchemeHandlerFactory((cef_scheme_handler_factory_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefSSLInfo:
	{
		MyCefMet_CefSSLInfo((cef_sslinfo_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefSSLStatus:
	{
		MyCefMet_CefSSLStatus((cef_sslstatus_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefStreamReader:
	{
		MyCefMet_CefStreamReader((cef_stream_reader_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefStreamWriter:
	{
		MyCefMet_CefStreamWriter((cef_stream_writer_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefStringVisitor:
	{
		MyCefMet_CefStringVisitor((cef_string_visitor_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefTask:
	{
		MyCefMet_CefTask((cef_task_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefTaskRunner:
	{
		MyCefMet_CefTaskRunner((cef_task_runner_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefURLRequest:
	{
		MyCefMet_CefURLRequest((cef_urlrequest_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefURLRequestClient:
	{
		MyCefMet_CefURLRequestClient((cef_urlrequest_client_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5, v6);
		break;
	}
	case CefTypeName_CefV8Context:
	{
		MyCefMet_CefV8Context((cef_v8context_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5);
		break;
	}
	case CefTypeName_CefV8Accessor:
	{
		MyCefMet_CefV8Accessor((cef_v8accessor_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefV8Interceptor:
	{
		MyCefMet_CefV8Interceptor((cef_v8interceptor_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4);
		break;
	}
	case CefTypeName_CefV8Exception:
	{
		MyCefMet_CefV8Exception((cef_v8exception_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefV8Value:
	{
		MyCefMet_CefV8Value((cef_v8value_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefV8StackTrace:
	{
		MyCefMet_CefV8StackTrace((cef_v8stack_trace_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefV8StackFrame:
	{
		MyCefMet_CefV8StackFrame((cef_v8stack_frame_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefValue:
	{
		MyCefMet_CefValue((cef_value_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefBinaryValue:
	{
		MyCefMet_CefBinaryValue((cef_binary_value_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefDictionaryValue:
	{
		MyCefMet_CefDictionaryValue((cef_dictionary_value_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefListValue:
	{
		MyCefMet_CefListValue((cef_list_value_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefWebPluginInfo:
	{
		MyCefMet_CefWebPluginInfo((cef_web_plugin_info_t*)me1, metName & 0xffff, ret
		);
		break;
	}
	case CefTypeName_CefWebPluginInfoVisitor:
	{
		MyCefMet_CefWebPluginInfoVisitor((cef_web_plugin_info_visitor_t*)me1, metName & 0xffff, ret
			, v1, v2, v3);
		break;
	}
	case CefTypeName_CefX509CertPrincipal:
	{
		MyCefMet_CefX509CertPrincipal((cef_x509cert_principal_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefX509Certificate:
	{
		MyCefMet_CefX509Certificate((cef_x509certificate_t*)me1, metName & 0xffff, ret
			, v1);
		break;
	}
	case CefTypeName_CefXmlReader:
	{
		MyCefMet_CefXmlReader((cef_xml_reader_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	case CefTypeName_CefZipReader:
	{
		MyCefMet_CefZipReader((cef_zip_reader_t*)me1, metName & 0xffff, ret
			, v1, v2);
		break;
	}
	}
}
void* NewInstance(int typeName, managed_callback mcallback, jsvalue* jsvalue) {
	switch (typeName) {
	case  CefTypeName_CefApp: {
		auto inst = new MyCefApp();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefNavigationEntryVisitor: {
		auto inst = new MyCefNavigationEntryVisitor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefClient: {
		auto inst = new MyCefClient();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefCookieVisitor: {
		auto inst = new MyCefCookieVisitor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefDOMVisitor: {
		auto inst = new MyCefDOMVisitor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefMenuModelDelegate: {
		auto inst = new MyCefMenuModelDelegate();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefResponseFilter: {
		auto inst = new MyCefResponseFilter();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefSchemeHandlerFactory: {
		auto inst = new MyCefSchemeHandlerFactory();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefStringVisitor: {
		auto inst = new MyCefStringVisitor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefTask: {
		auto inst = new MyCefTask();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefURLRequestClient: {
		auto inst = new MyCefURLRequestClient();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefV8Accessor: {
		auto inst = new MyCefV8Accessor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefV8Interceptor: {
		auto inst = new MyCefV8Interceptor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefWebPluginInfoVisitor: {
		auto inst = new MyCefWebPluginInfoVisitor();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefRunFileDialogCallback: {
		auto inst = new MyCefRunFileDialogCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefPdfPrintCallback: {
		auto inst = new MyCefPdfPrintCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefDownloadImageCallback: {
		auto inst = new MyCefDownloadImageCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefCompletionCallback: {
		auto inst = new MyCefCompletionCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefSetCookieCallback: {
		auto inst = new MyCefSetCookieCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefDeleteCookiesCallback: {
		auto inst = new MyCefDeleteCookiesCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefGetGeolocationCallback: {
		auto inst = new MyCefGetGeolocationCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefResolveCallback: {
		auto inst = new MyCefResolveCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefEndTracingCallback: {
		auto inst = new MyCefEndTracingCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	case  CefTypeName_CefRegisterCdmCallback: {
		auto inst = new MyCefRegisterCdmCallback();
		inst->mcallback = mcallback;
		return inst;
	}
	}
	return nullptr;
}
/////////////////////////////////////////////////
