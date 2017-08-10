#pragma once
#include "ExportFuncAuto.h"   




//----------------
const int MET_Release = 0;
//----------------


//
inline void SetCefStringToJsValue(jsvalue* value, const CefString& cefstr) {

	MyCefStringHolder* str = new MyCefStringHolder();
	str->value = cefstr;
	//
	value->type = JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;
	value->ptr = str;
	value->i32 = str->value.length();
}
inline void MyCefSetVoidPtr(jsvalue* value, void* data) {
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = data;
}
inline void MyCefSetInt32(jsvalue* value, int32_t data) {
	value->type = JSVALUE_TYPE_INTEGER;
	value->i32 = data;
}
inline void MyCefSetUInt32(jsvalue* value, uint32_t data) {
	value->type = JSVALUE_TYPE_INTEGER;
	value->i32 = (int32_t)data;
}
inline void MyCefSetInt64(jsvalue* value, int64_t data) {
	value->type = JSVALUE_TYPE_INTEGER64;
	value->i64 = data;
}
inline void MyCefSetUInt64(jsvalue* value, uint64_t data) {
	value->type = JSVALUE_TYPE_INTEGER64;
	value->i64 = data;
}
inline void MyCefSetBool(jsvalue* value, bool data) {
	value->type = JSVALUE_TYPE_BOOLEAN;
	value->i32 = data ? 1 : 0;
}
inline void MyCefSetDouble(jsvalue* value, double data) {
	value->type = JSVALUE_TYPE_NUMBER;
	value->num = data;
}
inline void MyCefSetFloat(jsvalue* value, float data) {
	value->type = JSVALUE_TYPE_NUMBER;
	value->num = data;
}
inline MyCefStringHolder* GetStringHolder(jsvalue* value) {
	return (MyCefStringHolder*)value->ptr;
}
inline void MyCefSetCefPoint(jsvalue* value, CefPoint& data) {

	CefPoint* cefPoint = new CefPoint();
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = cefPoint;
}


////////////////////////////////////////// 
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
/*779*/

void MyCefMet_CefApp(cef_app_t* me1, int metName, jsvalue* ret) {
	/*780*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*781*/
	auto me = CefAppCppToC::Unwrap(me1);
	/*782*/
	switch (metName) {
		/*783*/
	case MET_Release:return; //yes, just return
							 /*784*/
	}
	/*785*/
	CefAppCppToC::Wrap(me);
	/*786*/
}


// [virtual] class CefBrowser
/*815*/
/*794*/
const int CefBrowser_GetHost_1 = 1;
/*795*/
const int CefBrowser_CanGoBack_2 = 2;
/*796*/
const int CefBrowser_GoBack_3 = 3;
/*797*/
const int CefBrowser_CanGoForward_4 = 4;
/*798*/
const int CefBrowser_GoForward_5 = 5;
/*799*/
const int CefBrowser_IsLoading_6 = 6;
/*800*/
const int CefBrowser_Reload_7 = 7;
/*801*/
const int CefBrowser_ReloadIgnoreCache_8 = 8;
/*802*/
const int CefBrowser_StopLoad_9 = 9;
/*803*/
const int CefBrowser_GetIdentifier_10 = 10;
/*804*/
const int CefBrowser_IsSame_11 = 11;
/*805*/
const int CefBrowser_IsPopup_12 = 12;
/*806*/
const int CefBrowser_HasDocument_13 = 13;
/*807*/
const int CefBrowser_GetMainFrame_14 = 14;
/*808*/
const int CefBrowser_GetFocusedFrame_15 = 15;
/*809*/
const int CefBrowser_GetFrame_16 = 16;
/*810*/
const int CefBrowser_GetFrame_17 = 17;
/*811*/
const int CefBrowser_GetFrameCount_18 = 18;
/*812*/
const int CefBrowser_GetFrameIdentifiers_19 = 19;
/*813*/
const int CefBrowser_GetFrameNames_20 = 20;
/*814*/
const int CefBrowser_SendProcessMessage_21 = 21;

void MyCefMet_CefBrowser(cef_browser_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*816*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*817*/
	auto me = CefBrowserCToCpp::Wrap(me1);
	/*818*/
	switch (metName) {
		/*819*/
	case MET_Release:return; //yes, just return
							 /*820*/
	case CefBrowser_GetHost_1: {
		/*821*/


		// gen! CefRefPtr<CefBrowserHost> GetHost()
		auto ret_result = me->GetHost();
		/*822*/
		MyCefSetVoidPtr(ret, CefBrowserHostCToCpp::Unwrap(ret_result));
		/*823*/
	} break;
		/*824*/
	case CefBrowser_CanGoBack_2: {
		/*825*/


		// gen! bool CanGoBack()
		auto ret_result = me->CanGoBack();
		/*826*/
		MyCefSetBool(ret, ret_result);
		/*827*/
	} break;
		/*828*/
	case CefBrowser_GoBack_3: {
		/*829*/


		// gen! void GoBack()
		me->GoBack();
		/*830*/

		/*831*/
	} break;
		/*832*/
	case CefBrowser_CanGoForward_4: {
		/*833*/


		// gen! bool CanGoForward()
		auto ret_result = me->CanGoForward();
		/*834*/
		MyCefSetBool(ret, ret_result);
		/*835*/
	} break;
		/*836*/
	case CefBrowser_GoForward_5: {
		/*837*/


		// gen! void GoForward()
		me->GoForward();
		/*838*/

		/*839*/
	} break;
		/*840*/
	case CefBrowser_IsLoading_6: {
		/*841*/


		// gen! bool IsLoading()
		auto ret_result = me->IsLoading();
		/*842*/
		MyCefSetBool(ret, ret_result);
		/*843*/
	} break;
		/*844*/
	case CefBrowser_Reload_7: {
		/*845*/


		// gen! void Reload()
		me->Reload();
		/*846*/

		/*847*/
	} break;
		/*848*/
	case CefBrowser_ReloadIgnoreCache_8: {
		/*849*/


		// gen! void ReloadIgnoreCache()
		me->ReloadIgnoreCache();
		/*850*/

		/*851*/
	} break;
		/*852*/
	case CefBrowser_StopLoad_9: {
		/*853*/


		// gen! void StopLoad()
		me->StopLoad();
		/*854*/

		/*855*/
	} break;
		/*856*/
	case CefBrowser_GetIdentifier_10: {
		/*857*/


		// gen! int GetIdentifier()
		auto ret_result = me->GetIdentifier();
		/*858*/
		MyCefSetInt64(ret, ret_result);
		/*859*/
	} break;
		/*860*/
	case CefBrowser_IsSame_11: {
		/*861*/


		// gen! bool IsSame(CefRefPtr<CefBrowser> that)
		auto ret_result = me->IsSame(CefBrowserCToCpp::Wrap((cef_browser_t*)v1->ptr));
		/*862*/
		MyCefSetBool(ret, ret_result);
		/*863*/
	} break;
		/*864*/
	case CefBrowser_IsPopup_12: {
		/*865*/


		// gen! bool IsPopup()
		auto ret_result = me->IsPopup();
		/*866*/
		MyCefSetBool(ret, ret_result);
		/*867*/
	} break;
		/*868*/
	case CefBrowser_HasDocument_13: {
		/*869*/


		// gen! bool HasDocument()
		auto ret_result = me->HasDocument();
		/*870*/
		MyCefSetBool(ret, ret_result);
		/*871*/
	} break;
		/*872*/
	case CefBrowser_GetMainFrame_14: {
		/*873*/


		// gen! CefRefPtr<CefFrame> GetMainFrame()
		auto ret_result = me->GetMainFrame();
		/*874*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*875*/
	} break;
		/*876*/
	case CefBrowser_GetFocusedFrame_15: {
		/*877*/


		// gen! CefRefPtr<CefFrame> GetFocusedFrame()
		auto ret_result = me->GetFocusedFrame();
		/*878*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*879*/
	} break;
		/*880*/
	case CefBrowser_GetFrame_16: {
		/*881*/


		// gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
		auto ret_result = me->GetFrame(v1->i64);
		/*882*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*883*/
	} break;
		/*884*/
	case CefBrowser_GetFrame_17: {
		/*885*/


		// gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
		auto ret_result = me->GetFrame(GetStringHolder(v1)->value);
		/*886*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*887*/
	} break;
		/*888*/
	case CefBrowser_GetFrameCount_18: {
		/*889*/


		// gen! size_t GetFrameCount()
		auto ret_result = me->GetFrameCount();
		/*890*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*891*/
	} break;
		/*892*/
	case CefBrowser_GetFrameIdentifiers_19: {
		/*893*/


		// gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
		me->GetFrameIdentifiers(*((std::vector<int64>*)v1->ptr));
		/*894*/

		/*895*/
	} break;
		/*896*/
	case CefBrowser_GetFrameNames_20: {
		/*897*/


		// gen! void GetFrameNames(std::vector<CefString>& names)
	/*	auto v_1 = (std::vector<CefString>*)v1->ptr;
		me->GetFrameNames(*v_1);*/
		//auto v_1 = (std::vector<CefString>*)v1->ptr;
		me->GetFrameNames(*((std::vector<CefString>*)v1->ptr));
		/*898*/

		/*899*/
	} break;
		/*900*/
	case CefBrowser_SendProcessMessage_21: {
		/*901*/


		// gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
		auto ret_result = me->SendProcessMessage((CefProcessId)v1->i32,
			CefProcessMessageCToCpp::Wrap((cef_process_message_t*)v2->ptr));
		/*902*/
		MyCefSetBool(ret, ret_result);
		/*903*/
	} break;
		/*904*/
	}
	/*905*/
	CefBrowserCToCpp::Unwrap(me);
	/*906*/
}


// [virtual] class CefNavigationEntryVisitor
/*1084*/

void MyCefMet_CefNavigationEntryVisitor(cef_navigation_entry_visitor_t* me1, int metName, jsvalue* ret) {
	/*1085*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1086*/
	auto me = CefNavigationEntryVisitorCppToC::Unwrap(me1);
	/*1087*/
	switch (metName) {
		/*1088*/
	case MET_Release:return; //yes, just return
							 /*1089*/
	}
	/*1090*/
	CefNavigationEntryVisitorCppToC::Wrap(me);
	/*1091*/
}


// [virtual] class CefBrowserHost
/*1151*/
/*1099*/
const int CefBrowserHost_GetBrowser_1 = 1;
/*1100*/
const int CefBrowserHost_CloseBrowser_2 = 2;
/*1101*/
const int CefBrowserHost_TryCloseBrowser_3 = 3;
/*1102*/
const int CefBrowserHost_SetFocus_4 = 4;
/*1103*/
const int CefBrowserHost_GetWindowHandle_5 = 5;
/*1104*/
const int CefBrowserHost_GetOpenerWindowHandle_6 = 6;
/*1105*/
const int CefBrowserHost_HasView_7 = 7;
/*1106*/
const int CefBrowserHost_GetClient_8 = 8;
/*1107*/
const int CefBrowserHost_GetRequestContext_9 = 9;
/*1108*/
const int CefBrowserHost_GetZoomLevel_10 = 10;
/*1109*/
const int CefBrowserHost_SetZoomLevel_11 = 11;
/*1110*/
const int CefBrowserHost_RunFileDialog_12 = 12;
/*1111*/
const int CefBrowserHost_StartDownload_13 = 13;
/*1112*/
const int CefBrowserHost_DownloadImage_14 = 14;
/*1113*/
const int CefBrowserHost_Print_15 = 15;
/*1114*/
const int CefBrowserHost_PrintToPDF_16 = 16;
/*1115*/
const int CefBrowserHost_Find_17 = 17;
/*1116*/
const int CefBrowserHost_StopFinding_18 = 18;
/*1117*/
const int CefBrowserHost_ShowDevTools_19 = 19;
/*1118*/
const int CefBrowserHost_CloseDevTools_20 = 20;
/*1119*/
const int CefBrowserHost_HasDevTools_21 = 21;
/*1120*/
const int CefBrowserHost_GetNavigationEntries_22 = 22;
/*1121*/
const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = 23;
/*1122*/
const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = 24;
/*1123*/
const int CefBrowserHost_ReplaceMisspelling_25 = 25;
/*1124*/
const int CefBrowserHost_AddWordToDictionary_26 = 26;
/*1125*/
const int CefBrowserHost_IsWindowRenderingDisabled_27 = 27;
/*1126*/
const int CefBrowserHost_WasResized_28 = 28;
/*1127*/
const int CefBrowserHost_WasHidden_29 = 29;
/*1128*/
const int CefBrowserHost_NotifyScreenInfoChanged_30 = 30;
/*1129*/
const int CefBrowserHost_Invalidate_31 = 31;
/*1130*/
const int CefBrowserHost_SendKeyEvent_32 = 32;
/*1131*/
const int CefBrowserHost_SendMouseClickEvent_33 = 33;
/*1132*/
const int CefBrowserHost_SendMouseMoveEvent_34 = 34;
/*1133*/
const int CefBrowserHost_SendMouseWheelEvent_35 = 35;
/*1134*/
const int CefBrowserHost_SendFocusEvent_36 = 36;
/*1135*/
const int CefBrowserHost_SendCaptureLostEvent_37 = 37;
/*1136*/
const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = 38;
/*1137*/
const int CefBrowserHost_GetWindowlessFrameRate_39 = 39;
/*1138*/
const int CefBrowserHost_SetWindowlessFrameRate_40 = 40;
/*1139*/
const int CefBrowserHost_ImeSetComposition_41 = 41;
/*1140*/
const int CefBrowserHost_ImeCommitText_42 = 42;
/*1141*/
const int CefBrowserHost_ImeFinishComposingText_43 = 43;
/*1142*/
const int CefBrowserHost_ImeCancelComposition_44 = 44;
/*1143*/
const int CefBrowserHost_DragTargetDragEnter_45 = 45;
/*1144*/
const int CefBrowserHost_DragTargetDragOver_46 = 46;
/*1145*/
const int CefBrowserHost_DragTargetDragLeave_47 = 47;
/*1146*/
const int CefBrowserHost_DragTargetDrop_48 = 48;
/*1147*/
const int CefBrowserHost_DragSourceEndedAt_49 = 49;
/*1148*/
const int CefBrowserHost_DragSourceSystemDragEnded_50 = 50;
/*1149*/
const int CefBrowserHost_GetVisibleNavigationEntry_51 = 51;
/*1150*/
const int CefBrowserHost_SetAccessibilityState_52 = 52;

void MyCefMet_CefBrowserHost(cef_browser_host_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1152*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1153*/
	auto me = CefBrowserHostCToCpp::Wrap(me1);
	/*1154*/
	switch (metName) {
		/*1155*/
	case MET_Release:return; //yes, just return
							 /*1156*/
	case CefBrowserHost_GetBrowser_1: {
		/*1157*/


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		/*1158*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*1159*/
	} break;
		/*1160*/
	case CefBrowserHost_CloseBrowser_2: {
		/*1161*/


		// gen! void CloseBrowser(bool force_close)
		me->CloseBrowser(v1->i32 != 0);
		/*1162*/

		/*1163*/
	} break;
		/*1164*/
	case CefBrowserHost_TryCloseBrowser_3: {
		/*1165*/


		// gen! bool TryCloseBrowser()
		auto ret_result = me->TryCloseBrowser();
		/*1166*/
		MyCefSetBool(ret, ret_result);
		/*1167*/
	} break;
		/*1168*/
	case CefBrowserHost_SetFocus_4: {
		/*1169*/


		// gen! void SetFocus(bool focus)
		me->SetFocus(v1->i32 != 0);
		/*1170*/

		/*1171*/
	} break;
		/*1172*/
	case CefBrowserHost_GetWindowHandle_5: {
		/*1173*/


		// gen! CefWindowHandle GetWindowHandle()
		auto ret_result = me->GetWindowHandle();
		/*1174*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1175*/
	} break;
		/*1176*/
	case CefBrowserHost_GetOpenerWindowHandle_6: {
		/*1177*/


		// gen! CefWindowHandle GetOpenerWindowHandle()
		auto ret_result = me->GetOpenerWindowHandle();
		/*1178*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1179*/
	} break;
		/*1180*/
	case CefBrowserHost_HasView_7: {
		/*1181*/


		// gen! bool HasView()
		auto ret_result = me->HasView();
		/*1182*/
		MyCefSetBool(ret, ret_result);
		/*1183*/
	} break;
		/*1184*/
	case CefBrowserHost_GetClient_8: {
		/*1185*/


		// gen! CefRefPtr<CefClient> GetClient()
		auto ret_result = me->GetClient();
		/*1186*/
		MyCefSetVoidPtr(ret, CefClientCppToC::Wrap(ret_result));
		/*1187*/
	} break;
		/*1188*/
	case CefBrowserHost_GetRequestContext_9: {
		/*1189*/


		// gen! CefRefPtr<CefRequestContext> GetRequestContext()
		auto ret_result = me->GetRequestContext();
		/*1190*/
		MyCefSetVoidPtr(ret, CefRequestContextCToCpp::Unwrap(ret_result));
		/*1191*/
	} break;
		/*1192*/
	case CefBrowserHost_GetZoomLevel_10: {
		/*1193*/


		// gen! double GetZoomLevel()
		auto ret_result = me->GetZoomLevel();
		/*1194*/
		MyCefSetDouble(ret, ret_result);
		/*1195*/
	} break;
		/*1196*/
	case CefBrowserHost_SetZoomLevel_11: {
		/*1197*/


		// gen! void SetZoomLevel(double zoomLevel)
		me->SetZoomLevel(v1->num);
		/*1198*/

		/*1199*/
	} break;
		/*1200*/
	case CefBrowserHost_RunFileDialog_12: {
		/*1201*/


		// gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
		me->RunFileDialog((CefBrowserHost::FileDialogMode)v1->i32,
			GetStringHolder(v2)->value,
			GetStringHolder(v3)->value,
			*((std::vector<CefString>*)v4->ptr),
			v5->i32,
			CefRunFileDialogCallbackCppToC::Unwrap((cef_run_file_dialog_callback_t*)v6->ptr));
		/*1202*/

		/*1203*/
	} break;
		/*1204*/
	case CefBrowserHost_StartDownload_13: {
		/*1205*/


		// gen! void StartDownload(const CefString& url)
		me->StartDownload(GetStringHolder(v1)->value);
		/*1206*/

		/*1207*/
	} break;
		/*1208*/
	case CefBrowserHost_DownloadImage_14: {
		/*1209*/


		// gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
		me->DownloadImage(GetStringHolder(v1)->value,
			v2->i32 != 0,
			v3->i32,
			v4->i32 != 0,
			CefDownloadImageCallbackCppToC::Unwrap((cef_download_image_callback_t*)v5->ptr));
		/*1210*/

		/*1211*/
	} break;
		/*1212*/
	case CefBrowserHost_Print_15: {
		/*1213*/


		// gen! void Print()
		me->Print();
		/*1214*/

		/*1215*/
	} break;
		/*1216*/
	case CefBrowserHost_PrintToPDF_16: {
		/*1217*/


		// gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
		me->PrintToPDF(GetStringHolder(v1)->value,
			*((CefPdfPrintSettings*)v2->ptr),
			CefPdfPrintCallbackCppToC::Unwrap((cef_pdf_print_callback_t*)v3->ptr));
		/*1218*/

		/*1219*/
	} break;
		/*1220*/
	case CefBrowserHost_Find_17: {
		/*1221*/


		// gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
		me->Find(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*1222*/

		/*1223*/
	} break;
		/*1224*/
	case CefBrowserHost_StopFinding_18: {
		/*1225*/


		// gen! void StopFinding(bool clearSelection)
		me->StopFinding(v1->i32 != 0);
		/*1226*/

		/*1227*/
	} break;
		/*1228*/
	case CefBrowserHost_ShowDevTools_19: {
		/*1229*/


		// gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
		me->ShowDevTools(*((CefWindowInfo*)v1->ptr),
			CefClientCppToC::Unwrap((cef_client_t*)v2->ptr),
			*((CefBrowserSettings*)v3->ptr),
			*((CefPoint*)v4->ptr));
		/*1230*/

		/*1231*/
	} break;
		/*1232*/
	case CefBrowserHost_CloseDevTools_20: {
		/*1233*/


		// gen! void CloseDevTools()
		me->CloseDevTools();
		/*1234*/

		/*1235*/
	} break;
		/*1236*/
	case CefBrowserHost_HasDevTools_21: {
		/*1237*/


		// gen! bool HasDevTools()
		auto ret_result = me->HasDevTools();
		/*1238*/
		MyCefSetBool(ret, ret_result);
		/*1239*/
	} break;
		/*1240*/
	case CefBrowserHost_GetNavigationEntries_22: {
		/*1241*/


		// gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
		me->GetNavigationEntries(CefNavigationEntryVisitorCppToC::Unwrap((cef_navigation_entry_visitor_t*)v1->ptr),
			v2->i32 != 0);
		/*1242*/

		/*1243*/
	} break;
		/*1244*/
	case CefBrowserHost_SetMouseCursorChangeDisabled_23: {
		/*1245*/


		// gen! void SetMouseCursorChangeDisabled(bool disabled)
		me->SetMouseCursorChangeDisabled(v1->i32 != 0);
		/*1246*/

		/*1247*/
	} break;
		/*1248*/
	case CefBrowserHost_IsMouseCursorChangeDisabled_24: {
		/*1249*/


		// gen! bool IsMouseCursorChangeDisabled()
		auto ret_result = me->IsMouseCursorChangeDisabled();
		/*1250*/
		MyCefSetBool(ret, ret_result);
		/*1251*/
	} break;
		/*1252*/
	case CefBrowserHost_ReplaceMisspelling_25: {
		/*1253*/


		// gen! void ReplaceMisspelling(const CefString& word)
		me->ReplaceMisspelling(GetStringHolder(v1)->value);
		/*1254*/

		/*1255*/
	} break;
		/*1256*/
	case CefBrowserHost_AddWordToDictionary_26: {
		/*1257*/


		// gen! void AddWordToDictionary(const CefString& word)
		me->AddWordToDictionary(GetStringHolder(v1)->value);
		/*1258*/

		/*1259*/
	} break;
		/*1260*/
	case CefBrowserHost_IsWindowRenderingDisabled_27: {
		/*1261*/


		// gen! bool IsWindowRenderingDisabled()
		auto ret_result = me->IsWindowRenderingDisabled();
		/*1262*/
		MyCefSetBool(ret, ret_result);
		/*1263*/
	} break;
		/*1264*/
	case CefBrowserHost_WasResized_28: {
		/*1265*/


		// gen! void WasResized()
		me->WasResized();
		/*1266*/

		/*1267*/
	} break;
		/*1268*/
	case CefBrowserHost_WasHidden_29: {
		/*1269*/


		// gen! void WasHidden(bool hidden)
		me->WasHidden(v1->i32 != 0);
		/*1270*/

		/*1271*/
	} break;
		/*1272*/
	case CefBrowserHost_NotifyScreenInfoChanged_30: {
		/*1273*/


		// gen! void NotifyScreenInfoChanged()
		me->NotifyScreenInfoChanged();
		/*1274*/

		/*1275*/
	} break;
		/*1276*/
	case CefBrowserHost_Invalidate_31: {
		/*1277*/


		// gen! void Invalidate(PaintElementType type)
		me->Invalidate((CefBrowserHost::PaintElementType)v1->i32);
		/*1278*/

		/*1279*/
	} break;
		/*1280*/
	case CefBrowserHost_SendKeyEvent_32: {
		/*1281*/


		// gen! void SendKeyEvent(const CefKeyEvent& event)
		me->SendKeyEvent(*((CefKeyEvent*)v1->ptr));
		/*1282*/

		/*1283*/
	} break;
		/*1284*/
	case CefBrowserHost_SendMouseClickEvent_33: {
		/*1285*/


		// gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
		me->SendMouseClickEvent(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::MouseButtonType)v2->i32,
			v3->i32 != 0,
			v4->i32);
		/*1286*/

		/*1287*/
	} break;
		/*1288*/
	case CefBrowserHost_SendMouseMoveEvent_34: {
		/*1289*/


		// gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
		me->SendMouseMoveEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32 != 0);
		/*1290*/

		/*1291*/
	} break;
		/*1292*/
	case CefBrowserHost_SendMouseWheelEvent_35: {
		/*1293*/


		// gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
		me->SendMouseWheelEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32,
			v3->i32);
		/*1294*/

		/*1295*/
	} break;
		/*1296*/
	case CefBrowserHost_SendFocusEvent_36: {
		/*1297*/


		// gen! void SendFocusEvent(bool setFocus)
		me->SendFocusEvent(v1->i32 != 0);
		/*1298*/

		/*1299*/
	} break;
		/*1300*/
	case CefBrowserHost_SendCaptureLostEvent_37: {
		/*1301*/


		// gen! void SendCaptureLostEvent()
		me->SendCaptureLostEvent();
		/*1302*/

		/*1303*/
	} break;
		/*1304*/
	case CefBrowserHost_NotifyMoveOrResizeStarted_38: {
		/*1305*/


		// gen! void NotifyMoveOrResizeStarted()
		me->NotifyMoveOrResizeStarted();
		/*1306*/

		/*1307*/
	} break;
		/*1308*/
	case CefBrowserHost_GetWindowlessFrameRate_39: {
		/*1309*/


		// gen! int GetWindowlessFrameRate()
		auto ret_result = me->GetWindowlessFrameRate();
		/*1310*/
		MyCefSetInt64(ret, ret_result);
		/*1311*/
	} break;
		/*1312*/
	case CefBrowserHost_SetWindowlessFrameRate_40: {
		/*1313*/


		// gen! void SetWindowlessFrameRate(int frame_rate)
		me->SetWindowlessFrameRate(v1->i32);
		/*1314*/

		/*1315*/
	} break;
		/*1316*/
	case CefBrowserHost_ImeSetComposition_41: {
		/*1317*/


		// gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
		me->ImeSetComposition(GetStringHolder(v1)->value,
			*((std::vector<CefCompositionUnderline>*)v2->ptr),
			*((CefRange*)v3->ptr),
			*((CefRange*)v4->ptr));
		/*1318*/

		/*1319*/
	} break;
		/*1320*/
	case CefBrowserHost_ImeCommitText_42: {
		/*1321*/


		// gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
		me->ImeCommitText(GetStringHolder(v1)->value,
			*((CefRange*)v2->ptr),
			v3->i32);
		/*1322*/

		/*1323*/
	} break;
		/*1324*/
	case CefBrowserHost_ImeFinishComposingText_43: {
		/*1325*/


		// gen! void ImeFinishComposingText(bool keep_selection)
		me->ImeFinishComposingText(v1->i32 != 0);
		/*1326*/

		/*1327*/
	} break;
		/*1328*/
	case CefBrowserHost_ImeCancelComposition_44: {
		/*1329*/


		// gen! void ImeCancelComposition()
		me->ImeCancelComposition();
		/*1330*/

		/*1331*/
	} break;
		/*1332*/
	case CefBrowserHost_DragTargetDragEnter_45: {
		/*1333*/


		// gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
		me->DragTargetDragEnter(CefDragDataCToCpp::Wrap((cef_drag_data_t*)v1->ptr),
			*((CefMouseEvent*)v2->ptr),
			(CefBrowserHost::DragOperationsMask)v3->i32);
		/*1334*/

		/*1335*/
	} break;
		/*1336*/
	case CefBrowserHost_DragTargetDragOver_46: {
		/*1337*/


		// gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
		me->DragTargetDragOver(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::DragOperationsMask)v2->i32);
		/*1338*/

		/*1339*/
	} break;
		/*1340*/
	case CefBrowserHost_DragTargetDragLeave_47: {
		/*1341*/


		// gen! void DragTargetDragLeave()
		me->DragTargetDragLeave();
		/*1342*/

		/*1343*/
	} break;
		/*1344*/
	case CefBrowserHost_DragTargetDrop_48: {
		/*1345*/


		// gen! void DragTargetDrop(const CefMouseEvent& event)
		me->DragTargetDrop(*((CefMouseEvent*)v1->ptr));
		/*1346*/

		/*1347*/
	} break;
		/*1348*/
	case CefBrowserHost_DragSourceEndedAt_49: {
		/*1349*/


		// gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
		me->DragSourceEndedAt(v1->i32,
			v2->i32,
			(CefBrowserHost::DragOperationsMask)v3->i32);
		/*1350*/

		/*1351*/
	} break;
		/*1352*/
	case CefBrowserHost_DragSourceSystemDragEnded_50: {
		/*1353*/


		// gen! void DragSourceSystemDragEnded()
		me->DragSourceSystemDragEnded();
		/*1354*/

		/*1355*/
	} break;
		/*1356*/
	case CefBrowserHost_GetVisibleNavigationEntry_51: {
		/*1357*/


		// gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
		auto ret_result = me->GetVisibleNavigationEntry();
		/*1358*/
		MyCefSetVoidPtr(ret, CefNavigationEntryCToCpp::Unwrap(ret_result));
		/*1359*/
	} break;
		/*1360*/
	case CefBrowserHost_SetAccessibilityState_52: {
		/*1361*/


		// gen! void SetAccessibilityState(cef_state_t accessibility_state)
		me->SetAccessibilityState((cef_state_t)v1->i32);
		/*1362*/

		/*1363*/
	} break;
		/*1364*/
	}
	/*1365*/
	CefBrowserHostCToCpp::Unwrap(me);
	/*1366*/
}


// [virtual] class CefClient
/*1836*/

void MyCefMet_CefClient(cef_client_t* me1, int metName, jsvalue* ret) {
	/*1837*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1838*/
	auto me = CefClientCppToC::Unwrap(me1);
	/*1839*/
	switch (metName) {
		/*1840*/
	case MET_Release:return; //yes, just return
							 /*1841*/
	}
	/*1842*/
	CefClientCppToC::Wrap(me);
	/*1843*/
}


// [virtual] class CefCommandLine
/*1871*/
/*1851*/
const int CefCommandLine_IsValid_1 = 1;
/*1852*/
const int CefCommandLine_IsReadOnly_2 = 2;
/*1853*/
const int CefCommandLine_Copy_3 = 3;
/*1854*/
const int CefCommandLine_InitFromArgv_4 = 4;
/*1855*/
const int CefCommandLine_InitFromString_5 = 5;
/*1856*/
const int CefCommandLine_Reset_6 = 6;
/*1857*/
const int CefCommandLine_GetArgv_7 = 7;
/*1858*/
const int CefCommandLine_GetCommandLineString_8 = 8;
/*1859*/
const int CefCommandLine_GetProgram_9 = 9;
/*1860*/
const int CefCommandLine_SetProgram_10 = 10;
/*1861*/
const int CefCommandLine_HasSwitches_11 = 11;
/*1862*/
const int CefCommandLine_HasSwitch_12 = 12;
/*1863*/
const int CefCommandLine_GetSwitchValue_13 = 13;
/*1864*/
const int CefCommandLine_GetSwitches_14 = 14;
/*1865*/
const int CefCommandLine_AppendSwitch_15 = 15;
/*1866*/
const int CefCommandLine_AppendSwitchWithValue_16 = 16;
/*1867*/
const int CefCommandLine_HasArguments_17 = 17;
/*1868*/
const int CefCommandLine_GetArguments_18 = 18;
/*1869*/
const int CefCommandLine_AppendArgument_19 = 19;
/*1870*/
const int CefCommandLine_PrependWrapper_20 = 20;

void MyCefMet_CefCommandLine(cef_command_line_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*1872*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1873*/
	auto me = CefCommandLineCToCpp::Wrap(me1);
	/*1874*/
	switch (metName) {
		/*1875*/
	case MET_Release:return; //yes, just return
							 /*1876*/
	case CefCommandLine_IsValid_1: {
		/*1877*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*1878*/
		MyCefSetBool(ret, ret_result);
		/*1879*/
	} break;
		/*1880*/
	case CefCommandLine_IsReadOnly_2: {
		/*1881*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*1882*/
		MyCefSetBool(ret, ret_result);
		/*1883*/
	} break;
		/*1884*/
	case CefCommandLine_Copy_3: {
		/*1885*/


		// gen! CefRefPtr<CefCommandLine> Copy()
		auto ret_result = me->Copy();
		/*1886*/
		MyCefSetVoidPtr(ret, CefCommandLineCToCpp::Unwrap(ret_result));
		/*1887*/
	} break;
		/*1888*/
	case CefCommandLine_InitFromArgv_4: {
		/*1889*/


		// gen! void InitFromArgv(int argc,const char* const* argv)
		/*me->InitFromArgv(v1->i32,
			v2->ptr);*/
			/*1890*/

			/*1891*/
	} break;
		/*1892*/
	case CefCommandLine_InitFromString_5: {
		/*1893*/


		// gen! void InitFromString(const CefString& command_line)
		me->InitFromString(GetStringHolder(v1)->value);
		/*1894*/

		/*1895*/
	} break;
		/*1896*/
	case CefCommandLine_Reset_6: {
		/*1897*/


		// gen! void Reset()
		me->Reset();
		/*1898*/

		/*1899*/
	} break;
		/*1900*/
	case CefCommandLine_GetArgv_7: {
		/*1901*/


		// gen! void GetArgv(std::vector<CefString>& argv)
		me->GetArgv(*((std::vector<CefString>*)v1->ptr));
		/*1902*/

		/*1903*/
	} break;
		/*1904*/
	case CefCommandLine_GetCommandLineString_8: {
		/*1905*/


		// gen! CefString GetCommandLineString()
		auto ret_result = me->GetCommandLineString();
		/*1906*/
		SetCefStringToJsValue(ret, ret_result);
		/*1907*/
	} break;
		/*1908*/
	case CefCommandLine_GetProgram_9: {
		/*1909*/


		// gen! CefString GetProgram()
		auto ret_result = me->GetProgram();
		/*1910*/
		SetCefStringToJsValue(ret, ret_result);
		/*1911*/
	} break;
		/*1912*/
	case CefCommandLine_SetProgram_10: {
		/*1913*/


		// gen! void SetProgram(const CefString& program)
		me->SetProgram(GetStringHolder(v1)->value);
		/*1914*/

		/*1915*/
	} break;
		/*1916*/
	case CefCommandLine_HasSwitches_11: {
		/*1917*/


		// gen! bool HasSwitches()
		auto ret_result = me->HasSwitches();
		/*1918*/
		MyCefSetBool(ret, ret_result);
		/*1919*/
	} break;
		/*1920*/
	case CefCommandLine_HasSwitch_12: {
		/*1921*/


		// gen! bool HasSwitch(const CefString& name)
		auto ret_result = me->HasSwitch(GetStringHolder(v1)->value);
		/*1922*/
		MyCefSetBool(ret, ret_result);
		/*1923*/
	} break;
		/*1924*/
	case CefCommandLine_GetSwitchValue_13: {
		/*1925*/


		// gen! CefString GetSwitchValue(const CefString& name)
		auto ret_result = me->GetSwitchValue(GetStringHolder(v1)->value);
		/*1926*/
		SetCefStringToJsValue(ret, ret_result);
		/*1927*/
	} break;
		/*1928*/
	case CefCommandLine_GetSwitches_14: {
		/*1929*/


		// gen! void GetSwitches(SwitchMap& switches)
		me->GetSwitches(*((CefCommandLine::SwitchMap*)v1->ptr));
		/*1930*/

		/*1931*/
	} break;
		/*1932*/
	case CefCommandLine_AppendSwitch_15: {
		/*1933*/


		// gen! void AppendSwitch(const CefString& name)
		me->AppendSwitch(GetStringHolder(v1)->value);
		/*1934*/

		/*1935*/
	} break;
		/*1936*/
	case CefCommandLine_AppendSwitchWithValue_16: {
		/*1937*/


		// gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
		me->AppendSwitchWithValue(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*1938*/

		/*1939*/
	} break;
		/*1940*/
	case CefCommandLine_HasArguments_17: {
		/*1941*/


		// gen! bool HasArguments()
		auto ret_result = me->HasArguments();
		/*1942*/
		MyCefSetBool(ret, ret_result);
		/*1943*/
	} break;
		/*1944*/
	case CefCommandLine_GetArguments_18: {
		/*1945*/


		// gen! void GetArguments(ArgumentList& arguments)
		me->GetArguments(*((CefCommandLine::ArgumentList*)v1->ptr));
		/*1946*/

		/*1947*/
	} break;
		/*1948*/
	case CefCommandLine_AppendArgument_19: {
		/*1949*/


		// gen! void AppendArgument(const CefString& argument)
		me->AppendArgument(GetStringHolder(v1)->value);
		/*1950*/

		/*1951*/
	} break;
		/*1952*/
	case CefCommandLine_PrependWrapper_20: {
		/*1953*/


		// gen! void PrependWrapper(const CefString& wrapper)
		me->PrependWrapper(GetStringHolder(v1)->value);
		/*1954*/

		/*1955*/
	} break;
		/*1956*/
	}
	/*1957*/
	CefCommandLineCToCpp::Unwrap(me);
	/*1958*/
}


// [virtual] class CefContextMenuParams
/*2168*/
/*2147*/
const int CefContextMenuParams_GetXCoord_1 = 1;
/*2148*/
const int CefContextMenuParams_GetYCoord_2 = 2;
/*2149*/
const int CefContextMenuParams_GetTypeFlags_3 = 3;
/*2150*/
const int CefContextMenuParams_GetLinkUrl_4 = 4;
/*2151*/
const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = 5;
/*2152*/
const int CefContextMenuParams_GetSourceUrl_6 = 6;
/*2153*/
const int CefContextMenuParams_HasImageContents_7 = 7;
/*2154*/
const int CefContextMenuParams_GetTitleText_8 = 8;
/*2155*/
const int CefContextMenuParams_GetPageUrl_9 = 9;
/*2156*/
const int CefContextMenuParams_GetFrameUrl_10 = 10;
/*2157*/
const int CefContextMenuParams_GetFrameCharset_11 = 11;
/*2158*/
const int CefContextMenuParams_GetMediaType_12 = 12;
/*2159*/
const int CefContextMenuParams_GetMediaStateFlags_13 = 13;
/*2160*/
const int CefContextMenuParams_GetSelectionText_14 = 14;
/*2161*/
const int CefContextMenuParams_GetMisspelledWord_15 = 15;
/*2162*/
const int CefContextMenuParams_GetDictionarySuggestions_16 = 16;
/*2163*/
const int CefContextMenuParams_IsEditable_17 = 17;
/*2164*/
const int CefContextMenuParams_IsSpellCheckEnabled_18 = 18;
/*2165*/
const int CefContextMenuParams_GetEditStateFlags_19 = 19;
/*2166*/
const int CefContextMenuParams_IsCustomMenu_20 = 20;
/*2167*/
const int CefContextMenuParams_IsPepperMenu_21 = 21;

void MyCefMet_CefContextMenuParams(cef_context_menu_params_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*2169*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2170*/
	auto me = CefContextMenuParamsCToCpp::Wrap(me1);
	/*2171*/
	switch (metName) {
		/*2172*/
	case MET_Release:return; //yes, just return
							 /*2173*/
	case CefContextMenuParams_GetXCoord_1: {
		/*2174*/


		// gen! int GetXCoord()
		auto ret_result = me->GetXCoord();
		/*2175*/
		MyCefSetInt64(ret, ret_result);
		/*2176*/
	} break;
		/*2177*/
	case CefContextMenuParams_GetYCoord_2: {
		/*2178*/


		// gen! int GetYCoord()
		auto ret_result = me->GetYCoord();
		/*2179*/
		MyCefSetInt64(ret, ret_result);
		/*2180*/
	} break;
		/*2181*/
	case CefContextMenuParams_GetTypeFlags_3: {
		/*2182*/


		// gen! TypeFlags GetTypeFlags()
		auto ret_result = me->GetTypeFlags();
		/*2183*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2184*/
	} break;
		/*2185*/
	case CefContextMenuParams_GetLinkUrl_4: {
		/*2186*/


		// gen! CefString GetLinkUrl()
		auto ret_result = me->GetLinkUrl();
		/*2187*/
		SetCefStringToJsValue(ret, ret_result);
		/*2188*/
	} break;
		/*2189*/
	case CefContextMenuParams_GetUnfilteredLinkUrl_5: {
		/*2190*/


		// gen! CefString GetUnfilteredLinkUrl()
		auto ret_result = me->GetUnfilteredLinkUrl();
		/*2191*/
		SetCefStringToJsValue(ret, ret_result);
		/*2192*/
	} break;
		/*2193*/
	case CefContextMenuParams_GetSourceUrl_6: {
		/*2194*/


		// gen! CefString GetSourceUrl()
		auto ret_result = me->GetSourceUrl();
		/*2195*/
		SetCefStringToJsValue(ret, ret_result);
		/*2196*/
	} break;
		/*2197*/
	case CefContextMenuParams_HasImageContents_7: {
		/*2198*/


		// gen! bool HasImageContents()
		auto ret_result = me->HasImageContents();
		/*2199*/
		MyCefSetBool(ret, ret_result);
		/*2200*/
	} break;
		/*2201*/
	case CefContextMenuParams_GetTitleText_8: {
		/*2202*/


		// gen! CefString GetTitleText()
		auto ret_result = me->GetTitleText();
		/*2203*/
		SetCefStringToJsValue(ret, ret_result);
		/*2204*/
	} break;
		/*2205*/
	case CefContextMenuParams_GetPageUrl_9: {
		/*2206*/


		// gen! CefString GetPageUrl()
		auto ret_result = me->GetPageUrl();
		/*2207*/
		SetCefStringToJsValue(ret, ret_result);
		/*2208*/
	} break;
		/*2209*/
	case CefContextMenuParams_GetFrameUrl_10: {
		/*2210*/


		// gen! CefString GetFrameUrl()
		auto ret_result = me->GetFrameUrl();
		/*2211*/
		SetCefStringToJsValue(ret, ret_result);
		/*2212*/
	} break;
		/*2213*/
	case CefContextMenuParams_GetFrameCharset_11: {
		/*2214*/


		// gen! CefString GetFrameCharset()
		auto ret_result = me->GetFrameCharset();
		/*2215*/
		SetCefStringToJsValue(ret, ret_result);
		/*2216*/
	} break;
		/*2217*/
	case CefContextMenuParams_GetMediaType_12: {
		/*2218*/


		// gen! MediaType GetMediaType()
		auto ret_result = me->GetMediaType();
		/*2219*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2220*/
	} break;
		/*2221*/
	case CefContextMenuParams_GetMediaStateFlags_13: {
		/*2222*/


		// gen! MediaStateFlags GetMediaStateFlags()
		auto ret_result = me->GetMediaStateFlags();
		/*2223*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2224*/
	} break;
		/*2225*/
	case CefContextMenuParams_GetSelectionText_14: {
		/*2226*/


		// gen! CefString GetSelectionText()
		auto ret_result = me->GetSelectionText();
		/*2227*/
		SetCefStringToJsValue(ret, ret_result);
		/*2228*/
	} break;
		/*2229*/
	case CefContextMenuParams_GetMisspelledWord_15: {
		/*2230*/


		// gen! CefString GetMisspelledWord()
		auto ret_result = me->GetMisspelledWord();
		/*2231*/
		SetCefStringToJsValue(ret, ret_result);
		/*2232*/
	} break;
		/*2233*/
	case CefContextMenuParams_GetDictionarySuggestions_16: {
		/*2234*/


		// gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
		auto ret_result = me->GetDictionarySuggestions(*((std::vector<CefString>*)v1->ptr));
		/*2235*/
		MyCefSetBool(ret, ret_result);
		/*2236*/
	} break;
		/*2237*/
	case CefContextMenuParams_IsEditable_17: {
		/*2238*/


		// gen! bool IsEditable()
		auto ret_result = me->IsEditable();
		/*2239*/
		MyCefSetBool(ret, ret_result);
		/*2240*/
	} break;
		/*2241*/
	case CefContextMenuParams_IsSpellCheckEnabled_18: {
		/*2242*/


		// gen! bool IsSpellCheckEnabled()
		auto ret_result = me->IsSpellCheckEnabled();
		/*2243*/
		MyCefSetBool(ret, ret_result);
		/*2244*/
	} break;
		/*2245*/
	case CefContextMenuParams_GetEditStateFlags_19: {
		/*2246*/


		// gen! EditStateFlags GetEditStateFlags()
		auto ret_result = me->GetEditStateFlags();
		/*2247*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2248*/
	} break;
		/*2249*/
	case CefContextMenuParams_IsCustomMenu_20: {
		/*2250*/


		// gen! bool IsCustomMenu()
		auto ret_result = me->IsCustomMenu();
		/*2251*/
		MyCefSetBool(ret, ret_result);
		/*2252*/
	} break;
		/*2253*/
	case CefContextMenuParams_IsPepperMenu_21: {
		/*2254*/


		// gen! bool IsPepperMenu()
		auto ret_result = me->IsPepperMenu();
		/*2255*/
		MyCefSetBool(ret, ret_result);
		/*2256*/
	} break;
		/*2257*/
	}
	/*2258*/
	CefContextMenuParamsCToCpp::Unwrap(me);
	/*2259*/
}


// [virtual] class CefCookieManager
/*2443*/
/*2436*/
const int CefCookieManager_SetSupportedSchemes_1 = 1;
/*2437*/
const int CefCookieManager_VisitAllCookies_2 = 2;
/*2438*/
const int CefCookieManager_VisitUrlCookies_3 = 3;
/*2439*/
const int CefCookieManager_SetCookie_4 = 4;
/*2440*/
const int CefCookieManager_DeleteCookies_5 = 5;
/*2441*/
const int CefCookieManager_SetStoragePath_6 = 6;
/*2442*/
const int CefCookieManager_FlushStore_7 = 7;

void MyCefMet_CefCookieManager(cef_cookie_manager_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*2444*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2445*/
	auto me = CefCookieManagerCToCpp::Wrap(me1);
	/*2446*/
	switch (metName) {
		/*2447*/
	case MET_Release:return; //yes, just return
							 /*2448*/
	case CefCookieManager_SetSupportedSchemes_1: {
		/*2449*/


		// gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
		me->SetSupportedSchemes(*((std::vector<CefString>*)v1->ptr),
			CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v2->ptr));
		/*2450*/

		/*2451*/
	} break;
		/*2452*/
	case CefCookieManager_VisitAllCookies_2: {
		/*2453*/


		// gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
		auto ret_result = me->VisitAllCookies(CefCookieVisitorCppToC::Unwrap((cef_cookie_visitor_t*)v1->ptr));
		/*2454*/
		MyCefSetBool(ret, ret_result);
		/*2455*/
	} break;
		/*2456*/
	case CefCookieManager_VisitUrlCookies_3: {
		/*2457*/


		// gen! bool VisitUrlCookies(const CefString& url,bool includeHttpOnly,CefRefPtr<CefCookieVisitor> visitor)
		auto ret_result = me->VisitUrlCookies(GetStringHolder(v1)->value,
			v2->i32 != 0,
			CefCookieVisitorCppToC::Unwrap((cef_cookie_visitor_t*)v3->ptr));
		/*2458*/
		MyCefSetBool(ret, ret_result);
		/*2459*/
	} break;
		/*2460*/
	case CefCookieManager_SetCookie_4: {
		/*2461*/


		// gen! bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
		auto ret_result = me->SetCookie(GetStringHolder(v1)->value,
			*((CefCookie*)v2->ptr),
			CefSetCookieCallbackCppToC::Unwrap((cef_set_cookie_callback_t*)v3->ptr));
		/*2462*/
		MyCefSetBool(ret, ret_result);
		/*2463*/
	} break;
		/*2464*/
	case CefCookieManager_DeleteCookies_5: {
		/*2465*/


		// gen! bool DeleteCookies(const CefString& url,const CefString& cookie_name,CefRefPtr<CefDeleteCookiesCallback> callback)
		auto ret_result = me->DeleteCookies(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefDeleteCookiesCallbackCppToC::Unwrap((cef_delete_cookies_callback_t*)v3->ptr));
		/*2466*/
		MyCefSetBool(ret, ret_result);
		/*2467*/
	} break;
		/*2468*/
	case CefCookieManager_SetStoragePath_6: {
		/*2469*/


		// gen! bool SetStoragePath(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->SetStoragePath(GetStringHolder(v1)->value,
			v2->i32 != 0,
			CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v3->ptr));
		/*2470*/
		MyCefSetBool(ret, ret_result);
		/*2471*/
	} break;
		/*2472*/
	case CefCookieManager_FlushStore_7: {
		/*2473*/


		// gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->FlushStore(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*2474*/
		MyCefSetBool(ret, ret_result);
		/*2475*/
	} break;
		/*2476*/
	}
	/*2477*/
	CefCookieManagerCToCpp::Unwrap(me);
	/*2478*/
}


// [virtual] class CefCookieVisitor
/*2567*/

void MyCefMet_CefCookieVisitor(cef_cookie_visitor_t* me1, int metName, jsvalue* ret) {
	/*2568*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2569*/
	auto me = CefCookieVisitorCppToC::Unwrap(me1);
	/*2570*/
	switch (metName) {
		/*2571*/
	case MET_Release:return; //yes, just return
							 /*2572*/
	}
	/*2573*/
	CefCookieVisitorCppToC::Wrap(me);
	/*2574*/
}


// [virtual] class CefDOMVisitor
/*2582*/

void MyCefMet_CefDOMVisitor(cef_domvisitor_t* me1, int metName, jsvalue* ret) {
	/*2583*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2584*/
	auto me = CefDOMVisitorCppToC::Unwrap(me1);
	/*2585*/
	switch (metName) {
		/*2586*/
	case MET_Release:return; //yes, just return
							 /*2587*/
	}
	/*2588*/
	CefDOMVisitorCppToC::Wrap(me);
	/*2589*/
}


// [virtual] class CefDOMDocument
/*2611*/
/*2597*/
const int CefDOMDocument_GetType_1 = 1;
/*2598*/
const int CefDOMDocument_GetDocument_2 = 2;
/*2599*/
const int CefDOMDocument_GetBody_3 = 3;
/*2600*/
const int CefDOMDocument_GetHead_4 = 4;
/*2601*/
const int CefDOMDocument_GetTitle_5 = 5;
/*2602*/
const int CefDOMDocument_GetElementById_6 = 6;
/*2603*/
const int CefDOMDocument_GetFocusedNode_7 = 7;
/*2604*/
const int CefDOMDocument_HasSelection_8 = 8;
/*2605*/
const int CefDOMDocument_GetSelectionStartOffset_9 = 9;
/*2606*/
const int CefDOMDocument_GetSelectionEndOffset_10 = 10;
/*2607*/
const int CefDOMDocument_GetSelectionAsMarkup_11 = 11;
/*2608*/
const int CefDOMDocument_GetSelectionAsText_12 = 12;
/*2609*/
const int CefDOMDocument_GetBaseURL_13 = 13;
/*2610*/
const int CefDOMDocument_GetCompleteURL_14 = 14;

void MyCefMet_CefDOMDocument(cef_domdocument_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*2612*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2613*/
	auto me = CefDOMDocumentCToCpp::Wrap(me1);
	/*2614*/
	switch (metName) {
		/*2615*/
	case MET_Release:return; //yes, just return
							 /*2616*/
	case CefDOMDocument_GetType_1: {
		/*2617*/


		// gen! Type GetType()
		auto ret_result = me->GetType();
		/*2618*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2619*/
	} break;
		/*2620*/
	case CefDOMDocument_GetDocument_2: {
		/*2621*/


		// gen! CefRefPtr<CefDOMNode> GetDocument()
		auto ret_result = me->GetDocument();
		/*2622*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2623*/
	} break;
		/*2624*/
	case CefDOMDocument_GetBody_3: {
		/*2625*/


		// gen! CefRefPtr<CefDOMNode> GetBody()
		auto ret_result = me->GetBody();
		/*2626*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2627*/
	} break;
		/*2628*/
	case CefDOMDocument_GetHead_4: {
		/*2629*/


		// gen! CefRefPtr<CefDOMNode> GetHead()
		auto ret_result = me->GetHead();
		/*2630*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2631*/
	} break;
		/*2632*/
	case CefDOMDocument_GetTitle_5: {
		/*2633*/


		// gen! CefString GetTitle()
		auto ret_result = me->GetTitle();
		/*2634*/
		SetCefStringToJsValue(ret, ret_result);
		/*2635*/
	} break;
		/*2636*/
	case CefDOMDocument_GetElementById_6: {
		/*2637*/


		// gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
		auto ret_result = me->GetElementById(GetStringHolder(v1)->value);
		/*2638*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2639*/
	} break;
		/*2640*/
	case CefDOMDocument_GetFocusedNode_7: {
		/*2641*/


		// gen! CefRefPtr<CefDOMNode> GetFocusedNode()
		auto ret_result = me->GetFocusedNode();
		/*2642*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2643*/
	} break;
		/*2644*/
	case CefDOMDocument_HasSelection_8: {
		/*2645*/


		// gen! bool HasSelection()
		auto ret_result = me->HasSelection();
		/*2646*/
		MyCefSetBool(ret, ret_result);
		/*2647*/
	} break;
		/*2648*/
	case CefDOMDocument_GetSelectionStartOffset_9: {
		/*2649*/


		// gen! int GetSelectionStartOffset()
		auto ret_result = me->GetSelectionStartOffset();
		/*2650*/
		MyCefSetInt64(ret, ret_result);
		/*2651*/
	} break;
		/*2652*/
	case CefDOMDocument_GetSelectionEndOffset_10: {
		/*2653*/


		// gen! int GetSelectionEndOffset()
		auto ret_result = me->GetSelectionEndOffset();
		/*2654*/
		MyCefSetInt64(ret, ret_result);
		/*2655*/
	} break;
		/*2656*/
	case CefDOMDocument_GetSelectionAsMarkup_11: {
		/*2657*/


		// gen! CefString GetSelectionAsMarkup()
		auto ret_result = me->GetSelectionAsMarkup();
		/*2658*/
		SetCefStringToJsValue(ret, ret_result);
		/*2659*/
	} break;
		/*2660*/
	case CefDOMDocument_GetSelectionAsText_12: {
		/*2661*/


		// gen! CefString GetSelectionAsText()
		auto ret_result = me->GetSelectionAsText();
		/*2662*/
		SetCefStringToJsValue(ret, ret_result);
		/*2663*/
	} break;
		/*2664*/
	case CefDOMDocument_GetBaseURL_13: {
		/*2665*/


		// gen! CefString GetBaseURL()
		auto ret_result = me->GetBaseURL();
		/*2666*/
		SetCefStringToJsValue(ret, ret_result);
		/*2667*/
	} break;
		/*2668*/
	case CefDOMDocument_GetCompleteURL_14: {
		/*2669*/


		// gen! CefString GetCompleteURL(const CefString& partialURL)
		auto ret_result = me->GetCompleteURL(GetStringHolder(v1)->value);
		/*2670*/
		SetCefStringToJsValue(ret, ret_result);
		/*2671*/
	} break;
		/*2672*/
	}
	/*2673*/
	CefDOMDocumentCToCpp::Unwrap(me);
	/*2674*/
}


// [virtual] class CefDOMNode
/*2826*/
/*2800*/
const int CefDOMNode_GetType_1 = 1;
/*2801*/
const int CefDOMNode_IsText_2 = 2;
/*2802*/
const int CefDOMNode_IsElement_3 = 3;
/*2803*/
const int CefDOMNode_IsEditable_4 = 4;
/*2804*/
const int CefDOMNode_IsFormControlElement_5 = 5;
/*2805*/
const int CefDOMNode_GetFormControlElementType_6 = 6;
/*2806*/
const int CefDOMNode_IsSame_7 = 7;
/*2807*/
const int CefDOMNode_GetName_8 = 8;
/*2808*/
const int CefDOMNode_GetValue_9 = 9;
/*2809*/
const int CefDOMNode_SetValue_10 = 10;
/*2810*/
const int CefDOMNode_GetAsMarkup_11 = 11;
/*2811*/
const int CefDOMNode_GetDocument_12 = 12;
/*2812*/
const int CefDOMNode_GetParent_13 = 13;
/*2813*/
const int CefDOMNode_GetPreviousSibling_14 = 14;
/*2814*/
const int CefDOMNode_GetNextSibling_15 = 15;
/*2815*/
const int CefDOMNode_HasChildren_16 = 16;
/*2816*/
const int CefDOMNode_GetFirstChild_17 = 17;
/*2817*/
const int CefDOMNode_GetLastChild_18 = 18;
/*2818*/
const int CefDOMNode_GetElementTagName_19 = 19;
/*2819*/
const int CefDOMNode_HasElementAttributes_20 = 20;
/*2820*/
const int CefDOMNode_HasElementAttribute_21 = 21;
/*2821*/
const int CefDOMNode_GetElementAttribute_22 = 22;
/*2822*/
const int CefDOMNode_GetElementAttributes_23 = 23;
/*2823*/
const int CefDOMNode_SetElementAttribute_24 = 24;
/*2824*/
const int CefDOMNode_GetElementInnerText_25 = 25;
/*2825*/
const int CefDOMNode_GetElementBounds_26 = 26;

void MyCefMet_CefDOMNode(cef_domnode_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*2827*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2828*/
	auto me = CefDOMNodeCToCpp::Wrap(me1);
	/*2829*/
	switch (metName) {
		/*2830*/
	case MET_Release:return; //yes, just return
							 /*2831*/
	case CefDOMNode_GetType_1: {
		/*2832*/


		// gen! Type GetType()
		auto ret_result = me->GetType();
		/*2833*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2834*/
	} break;
		/*2835*/
	case CefDOMNode_IsText_2: {
		/*2836*/


		// gen! bool IsText()
		auto ret_result = me->IsText();
		/*2837*/
		MyCefSetBool(ret, ret_result);
		/*2838*/
	} break;
		/*2839*/
	case CefDOMNode_IsElement_3: {
		/*2840*/


		// gen! bool IsElement()
		auto ret_result = me->IsElement();
		/*2841*/
		MyCefSetBool(ret, ret_result);
		/*2842*/
	} break;
		/*2843*/
	case CefDOMNode_IsEditable_4: {
		/*2844*/


		// gen! bool IsEditable()
		auto ret_result = me->IsEditable();
		/*2845*/
		MyCefSetBool(ret, ret_result);
		/*2846*/
	} break;
		/*2847*/
	case CefDOMNode_IsFormControlElement_5: {
		/*2848*/


		// gen! bool IsFormControlElement()
		auto ret_result = me->IsFormControlElement();
		/*2849*/
		MyCefSetBool(ret, ret_result);
		/*2850*/
	} break;
		/*2851*/
	case CefDOMNode_GetFormControlElementType_6: {
		/*2852*/


		// gen! CefString GetFormControlElementType()
		auto ret_result = me->GetFormControlElementType();
		/*2853*/
		SetCefStringToJsValue(ret, ret_result);
		/*2854*/
	} break;
		/*2855*/
	case CefDOMNode_IsSame_7: {
		/*2856*/


		// gen! bool IsSame(CefRefPtr<CefDOMNode> that)
		auto ret_result = me->IsSame(CefDOMNodeCToCpp::Wrap((cef_domnode_t*)v1->ptr));
		/*2857*/
		MyCefSetBool(ret, ret_result);
		/*2858*/
	} break;
		/*2859*/
	case CefDOMNode_GetName_8: {
		/*2860*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*2861*/
		SetCefStringToJsValue(ret, ret_result);
		/*2862*/
	} break;
		/*2863*/
	case CefDOMNode_GetValue_9: {
		/*2864*/


		// gen! CefString GetValue()
		auto ret_result = me->GetValue();
		/*2865*/
		SetCefStringToJsValue(ret, ret_result);
		/*2866*/
	} break;
		/*2867*/
	case CefDOMNode_SetValue_10: {
		/*2868*/


		// gen! bool SetValue(const CefString& value)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value);
		/*2869*/
		MyCefSetBool(ret, ret_result);
		/*2870*/
	} break;
		/*2871*/
	case CefDOMNode_GetAsMarkup_11: {
		/*2872*/


		// gen! CefString GetAsMarkup()
		auto ret_result = me->GetAsMarkup();
		/*2873*/
		SetCefStringToJsValue(ret, ret_result);
		/*2874*/
	} break;
		/*2875*/
	case CefDOMNode_GetDocument_12: {
		/*2876*/


		// gen! CefRefPtr<CefDOMDocument> GetDocument()
		auto ret_result = me->GetDocument();
		/*2877*/
		MyCefSetVoidPtr(ret, CefDOMDocumentCToCpp::Unwrap(ret_result));
		/*2878*/
	} break;
		/*2879*/
	case CefDOMNode_GetParent_13: {
		/*2880*/


		// gen! CefRefPtr<CefDOMNode> GetParent()
		auto ret_result = me->GetParent();
		/*2881*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2882*/
	} break;
		/*2883*/
	case CefDOMNode_GetPreviousSibling_14: {
		/*2884*/


		// gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
		auto ret_result = me->GetPreviousSibling();
		/*2885*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2886*/
	} break;
		/*2887*/
	case CefDOMNode_GetNextSibling_15: {
		/*2888*/


		// gen! CefRefPtr<CefDOMNode> GetNextSibling()
		auto ret_result = me->GetNextSibling();
		/*2889*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2890*/
	} break;
		/*2891*/
	case CefDOMNode_HasChildren_16: {
		/*2892*/


		// gen! bool HasChildren()
		auto ret_result = me->HasChildren();
		/*2893*/
		MyCefSetBool(ret, ret_result);
		/*2894*/
	} break;
		/*2895*/
	case CefDOMNode_GetFirstChild_17: {
		/*2896*/


		// gen! CefRefPtr<CefDOMNode> GetFirstChild()
		auto ret_result = me->GetFirstChild();
		/*2897*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2898*/
	} break;
		/*2899*/
	case CefDOMNode_GetLastChild_18: {
		/*2900*/


		// gen! CefRefPtr<CefDOMNode> GetLastChild()
		auto ret_result = me->GetLastChild();
		/*2901*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*2902*/
	} break;
		/*2903*/
	case CefDOMNode_GetElementTagName_19: {
		/*2904*/


		// gen! CefString GetElementTagName()
		auto ret_result = me->GetElementTagName();
		/*2905*/
		SetCefStringToJsValue(ret, ret_result);
		/*2906*/
	} break;
		/*2907*/
	case CefDOMNode_HasElementAttributes_20: {
		/*2908*/


		// gen! bool HasElementAttributes()
		auto ret_result = me->HasElementAttributes();
		/*2909*/
		MyCefSetBool(ret, ret_result);
		/*2910*/
	} break;
		/*2911*/
	case CefDOMNode_HasElementAttribute_21: {
		/*2912*/


		// gen! bool HasElementAttribute(const CefString& attrName)
		auto ret_result = me->HasElementAttribute(GetStringHolder(v1)->value);
		/*2913*/
		MyCefSetBool(ret, ret_result);
		/*2914*/
	} break;
		/*2915*/
	case CefDOMNode_GetElementAttribute_22: {
		/*2916*/


		// gen! CefString GetElementAttribute(const CefString& attrName)
		auto ret_result = me->GetElementAttribute(GetStringHolder(v1)->value);
		/*2917*/
		SetCefStringToJsValue(ret, ret_result);
		/*2918*/
	} break;
		/*2919*/
	case CefDOMNode_GetElementAttributes_23: {
		/*2920*/


		// gen! void GetElementAttributes(AttributeMap& attrMap)
		me->GetElementAttributes(*((CefDOMNode::AttributeMap*)v1->ptr));
		/*2921*/

		/*2922*/
	} break;
		/*2923*/
	case CefDOMNode_SetElementAttribute_24: {
		/*2924*/


		// gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
		auto ret_result = me->SetElementAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*2925*/
		MyCefSetBool(ret, ret_result);
		/*2926*/
	} break;
		/*2927*/
	case CefDOMNode_GetElementInnerText_25: {
		/*2928*/


		// gen! CefString GetElementInnerText()
		auto ret_result = me->GetElementInnerText();
		/*2929*/
		SetCefStringToJsValue(ret, ret_result);
		/*2930*/
	} break;
		/*2931*/
	case CefDOMNode_GetElementBounds_26: {
		/*2932*/


		// gen! CefRect GetElementBounds()
		auto ret_result = me->GetElementBounds();
		/*2933*/
		CefRect* tmp_d1 = new CefRect(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*2934*/
	} break;
		/*2935*/
	}
	/*2936*/
	CefDOMNodeCToCpp::Unwrap(me);
	/*2937*/
}


// [virtual] class CefDownloadItem
/*3186*/
/*3169*/
const int CefDownloadItem_IsValid_1 = 1;
/*3170*/
const int CefDownloadItem_IsInProgress_2 = 2;
/*3171*/
const int CefDownloadItem_IsComplete_3 = 3;
/*3172*/
const int CefDownloadItem_IsCanceled_4 = 4;
/*3173*/
const int CefDownloadItem_GetCurrentSpeed_5 = 5;
/*3174*/
const int CefDownloadItem_GetPercentComplete_6 = 6;
/*3175*/
const int CefDownloadItem_GetTotalBytes_7 = 7;
/*3176*/
const int CefDownloadItem_GetReceivedBytes_8 = 8;
/*3177*/
const int CefDownloadItem_GetStartTime_9 = 9;
/*3178*/
const int CefDownloadItem_GetEndTime_10 = 10;
/*3179*/
const int CefDownloadItem_GetFullPath_11 = 11;
/*3180*/
const int CefDownloadItem_GetId_12 = 12;
/*3181*/
const int CefDownloadItem_GetURL_13 = 13;
/*3182*/
const int CefDownloadItem_GetOriginalUrl_14 = 14;
/*3183*/
const int CefDownloadItem_GetSuggestedFileName_15 = 15;
/*3184*/
const int CefDownloadItem_GetContentDisposition_16 = 16;
/*3185*/
const int CefDownloadItem_GetMimeType_17 = 17;

void MyCefMet_CefDownloadItem(cef_download_item_t* me1, int metName, jsvalue* ret) {
	/*3187*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3188*/
	auto me = CefDownloadItemCToCpp::Wrap(me1);
	/*3189*/
	switch (metName) {
		/*3190*/
	case MET_Release:return; //yes, just return
							 /*3191*/
	case CefDownloadItem_IsValid_1: {
		/*3192*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*3193*/
		MyCefSetBool(ret, ret_result);
		/*3194*/
	} break;
		/*3195*/
	case CefDownloadItem_IsInProgress_2: {
		/*3196*/


		// gen! bool IsInProgress()
		auto ret_result = me->IsInProgress();
		/*3197*/
		MyCefSetBool(ret, ret_result);
		/*3198*/
	} break;
		/*3199*/
	case CefDownloadItem_IsComplete_3: {
		/*3200*/


		// gen! bool IsComplete()
		auto ret_result = me->IsComplete();
		/*3201*/
		MyCefSetBool(ret, ret_result);
		/*3202*/
	} break;
		/*3203*/
	case CefDownloadItem_IsCanceled_4: {
		/*3204*/


		// gen! bool IsCanceled()
		auto ret_result = me->IsCanceled();
		/*3205*/
		MyCefSetBool(ret, ret_result);
		/*3206*/
	} break;
		/*3207*/
	case CefDownloadItem_GetCurrentSpeed_5: {
		/*3208*/


		// gen! int64 GetCurrentSpeed()
		auto ret_result = me->GetCurrentSpeed();
		/*3209*/
		MyCefSetInt64(ret, ret_result);
		/*3210*/
	} break;
		/*3211*/
	case CefDownloadItem_GetPercentComplete_6: {
		/*3212*/


		// gen! int GetPercentComplete()
		auto ret_result = me->GetPercentComplete();
		/*3213*/
		MyCefSetInt64(ret, ret_result);
		/*3214*/
	} break;
		/*3215*/
	case CefDownloadItem_GetTotalBytes_7: {
		/*3216*/


		// gen! int64 GetTotalBytes()
		auto ret_result = me->GetTotalBytes();
		/*3217*/
		MyCefSetInt64(ret, ret_result);
		/*3218*/
	} break;
		/*3219*/
	case CefDownloadItem_GetReceivedBytes_8: {
		/*3220*/


		// gen! int64 GetReceivedBytes()
		auto ret_result = me->GetReceivedBytes();
		/*3221*/
		MyCefSetInt64(ret, ret_result);
		/*3222*/
	} break;
		/*3223*/
	case CefDownloadItem_GetStartTime_9: {
		/*3224*/


		// gen! CefTime GetStartTime()
		auto ret_result = me->GetStartTime();
		/*3225*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*3226*/
	} break;
		/*3227*/
	case CefDownloadItem_GetEndTime_10: {
		/*3228*/


		// gen! CefTime GetEndTime()
		auto ret_result = me->GetEndTime();
		/*3229*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*3230*/
	} break;
		/*3231*/
	case CefDownloadItem_GetFullPath_11: {
		/*3232*/


		// gen! CefString GetFullPath()
		auto ret_result = me->GetFullPath();
		/*3233*/
		SetCefStringToJsValue(ret, ret_result);
		/*3234*/
	} break;
		/*3235*/
	case CefDownloadItem_GetId_12: {
		/*3236*/


		// gen! uint32 GetId()
		auto ret_result = me->GetId();
		/*3237*/
		MyCefSetUInt32(ret, ret_result);
		/*3238*/
	} break;
		/*3239*/
	case CefDownloadItem_GetURL_13: {
		/*3240*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*3241*/
		SetCefStringToJsValue(ret, ret_result);
		/*3242*/
	} break;
		/*3243*/
	case CefDownloadItem_GetOriginalUrl_14: {
		/*3244*/


		// gen! CefString GetOriginalUrl()
		auto ret_result = me->GetOriginalUrl();
		/*3245*/
		SetCefStringToJsValue(ret, ret_result);
		/*3246*/
	} break;
		/*3247*/
	case CefDownloadItem_GetSuggestedFileName_15: {
		/*3248*/


		// gen! CefString GetSuggestedFileName()
		auto ret_result = me->GetSuggestedFileName();
		/*3249*/
		SetCefStringToJsValue(ret, ret_result);
		/*3250*/
	} break;
		/*3251*/
	case CefDownloadItem_GetContentDisposition_16: {
		/*3252*/


		// gen! CefString GetContentDisposition()
		auto ret_result = me->GetContentDisposition();
		/*3253*/
		SetCefStringToJsValue(ret, ret_result);
		/*3254*/
	} break;
		/*3255*/
	case CefDownloadItem_GetMimeType_17: {
		/*3256*/


		// gen! CefString GetMimeType()
		auto ret_result = me->GetMimeType();
		/*3257*/
		SetCefStringToJsValue(ret, ret_result);
		/*3258*/
	} break;
		/*3259*/
	}
	/*3260*/
	CefDownloadItemCToCpp::Unwrap(me);
	/*3261*/
}


// [virtual] class CefDragData
/*3430*/
/*3405*/
const int CefDragData_Clone_1 = 1;
/*3406*/
const int CefDragData_IsReadOnly_2 = 2;
/*3407*/
const int CefDragData_IsLink_3 = 3;
/*3408*/
const int CefDragData_IsFragment_4 = 4;
/*3409*/
const int CefDragData_IsFile_5 = 5;
/*3410*/
const int CefDragData_GetLinkURL_6 = 6;
/*3411*/
const int CefDragData_GetLinkTitle_7 = 7;
/*3412*/
const int CefDragData_GetLinkMetadata_8 = 8;
/*3413*/
const int CefDragData_GetFragmentText_9 = 9;
/*3414*/
const int CefDragData_GetFragmentHtml_10 = 10;
/*3415*/
const int CefDragData_GetFragmentBaseURL_11 = 11;
/*3416*/
const int CefDragData_GetFileName_12 = 12;
/*3417*/
const int CefDragData_GetFileContents_13 = 13;
/*3418*/
const int CefDragData_GetFileNames_14 = 14;
/*3419*/
const int CefDragData_SetLinkURL_15 = 15;
/*3420*/
const int CefDragData_SetLinkTitle_16 = 16;
/*3421*/
const int CefDragData_SetLinkMetadata_17 = 17;
/*3422*/
const int CefDragData_SetFragmentText_18 = 18;
/*3423*/
const int CefDragData_SetFragmentHtml_19 = 19;
/*3424*/
const int CefDragData_SetFragmentBaseURL_20 = 20;
/*3425*/
const int CefDragData_ResetFileContents_21 = 21;
/*3426*/
const int CefDragData_AddFile_22 = 22;
/*3427*/
const int CefDragData_GetImage_23 = 23;
/*3428*/
const int CefDragData_GetImageHotspot_24 = 24;
/*3429*/
const int CefDragData_HasImage_25 = 25;

void MyCefMet_CefDragData(cef_drag_data_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*3431*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3432*/
	auto me = CefDragDataCToCpp::Wrap(me1);
	/*3433*/
	switch (metName) {
		/*3434*/
	case MET_Release:return; //yes, just return
							 /*3435*/
	case CefDragData_Clone_1: {
		/*3436*/


		// gen! CefRefPtr<CefDragData> Clone()
		auto ret_result = me->Clone();
		/*3437*/
		MyCefSetVoidPtr(ret, CefDragDataCToCpp::Unwrap(ret_result));
		/*3438*/
	} break;
		/*3439*/
	case CefDragData_IsReadOnly_2: {
		/*3440*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*3441*/
		MyCefSetBool(ret, ret_result);
		/*3442*/
	} break;
		/*3443*/
	case CefDragData_IsLink_3: {
		/*3444*/


		// gen! bool IsLink()
		auto ret_result = me->IsLink();
		/*3445*/
		MyCefSetBool(ret, ret_result);
		/*3446*/
	} break;
		/*3447*/
	case CefDragData_IsFragment_4: {
		/*3448*/


		// gen! bool IsFragment()
		auto ret_result = me->IsFragment();
		/*3449*/
		MyCefSetBool(ret, ret_result);
		/*3450*/
	} break;
		/*3451*/
	case CefDragData_IsFile_5: {
		/*3452*/


		// gen! bool IsFile()
		auto ret_result = me->IsFile();
		/*3453*/
		MyCefSetBool(ret, ret_result);
		/*3454*/
	} break;
		/*3455*/
	case CefDragData_GetLinkURL_6: {
		/*3456*/


		// gen! CefString GetLinkURL()
		auto ret_result = me->GetLinkURL();
		/*3457*/
		SetCefStringToJsValue(ret, ret_result);
		/*3458*/
	} break;
		/*3459*/
	case CefDragData_GetLinkTitle_7: {
		/*3460*/


		// gen! CefString GetLinkTitle()
		auto ret_result = me->GetLinkTitle();
		/*3461*/
		SetCefStringToJsValue(ret, ret_result);
		/*3462*/
	} break;
		/*3463*/
	case CefDragData_GetLinkMetadata_8: {
		/*3464*/


		// gen! CefString GetLinkMetadata()
		auto ret_result = me->GetLinkMetadata();
		/*3465*/
		SetCefStringToJsValue(ret, ret_result);
		/*3466*/
	} break;
		/*3467*/
	case CefDragData_GetFragmentText_9: {
		/*3468*/


		// gen! CefString GetFragmentText()
		auto ret_result = me->GetFragmentText();
		/*3469*/
		SetCefStringToJsValue(ret, ret_result);
		/*3470*/
	} break;
		/*3471*/
	case CefDragData_GetFragmentHtml_10: {
		/*3472*/


		// gen! CefString GetFragmentHtml()
		auto ret_result = me->GetFragmentHtml();
		/*3473*/
		SetCefStringToJsValue(ret, ret_result);
		/*3474*/
	} break;
		/*3475*/
	case CefDragData_GetFragmentBaseURL_11: {
		/*3476*/


		// gen! CefString GetFragmentBaseURL()
		auto ret_result = me->GetFragmentBaseURL();
		/*3477*/
		SetCefStringToJsValue(ret, ret_result);
		/*3478*/
	} break;
		/*3479*/
	case CefDragData_GetFileName_12: {
		/*3480*/


		// gen! CefString GetFileName()
		auto ret_result = me->GetFileName();
		/*3481*/
		SetCefStringToJsValue(ret, ret_result);
		/*3482*/
	} break;
		/*3483*/
	case CefDragData_GetFileContents_13: {
		/*3484*/


		// gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
		auto ret_result = me->GetFileContents(CefStreamWriterCToCpp::Wrap((cef_stream_writer_t*)v1->ptr));
		/*3485*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3486*/
	} break;
		/*3487*/
	case CefDragData_GetFileNames_14: {
		/*3488*/


		// gen! bool GetFileNames(std::vector<CefString>& names)
		auto ret_result = me->GetFileNames(*((std::vector<CefString>*)v1->ptr));
		/*3489*/
		MyCefSetBool(ret, ret_result);
		/*3490*/
	} break;
		/*3491*/
	case CefDragData_SetLinkURL_15: {
		/*3492*/


		// gen! void SetLinkURL(const CefString& url)
		me->SetLinkURL(GetStringHolder(v1)->value);
		/*3493*/

		/*3494*/
	} break;
		/*3495*/
	case CefDragData_SetLinkTitle_16: {
		/*3496*/


		// gen! void SetLinkTitle(const CefString& title)
		me->SetLinkTitle(GetStringHolder(v1)->value);
		/*3497*/

		/*3498*/
	} break;
		/*3499*/
	case CefDragData_SetLinkMetadata_17: {
		/*3500*/


		// gen! void SetLinkMetadata(const CefString& data)
		me->SetLinkMetadata(GetStringHolder(v1)->value);
		/*3501*/

		/*3502*/
	} break;
		/*3503*/
	case CefDragData_SetFragmentText_18: {
		/*3504*/


		// gen! void SetFragmentText(const CefString& text)
		me->SetFragmentText(GetStringHolder(v1)->value);
		/*3505*/

		/*3506*/
	} break;
		/*3507*/
	case CefDragData_SetFragmentHtml_19: {
		/*3508*/


		// gen! void SetFragmentHtml(const CefString& html)
		me->SetFragmentHtml(GetStringHolder(v1)->value);
		/*3509*/

		/*3510*/
	} break;
		/*3511*/
	case CefDragData_SetFragmentBaseURL_20: {
		/*3512*/


		// gen! void SetFragmentBaseURL(const CefString& base_url)
		me->SetFragmentBaseURL(GetStringHolder(v1)->value);
		/*3513*/

		/*3514*/
	} break;
		/*3515*/
	case CefDragData_ResetFileContents_21: {
		/*3516*/


		// gen! void ResetFileContents()
		me->ResetFileContents();
		/*3517*/

		/*3518*/
	} break;
		/*3519*/
	case CefDragData_AddFile_22: {
		/*3520*/


		// gen! void AddFile(const CefString& path,const CefString& display_name)
		me->AddFile(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*3521*/

		/*3522*/
	} break;
		/*3523*/
	case CefDragData_GetImage_23: {
		/*3524*/


		// gen! CefRefPtr<CefImage> GetImage()
		auto ret_result = me->GetImage();
		/*3525*/
		MyCefSetVoidPtr(ret, CefImageCToCpp::Unwrap(ret_result));
		/*3526*/
	} break;
		/*3527*/
	case CefDragData_GetImageHotspot_24: {
		/*3528*/


		// gen! CefPoint GetImageHotspot()
		auto ret_result = me->GetImageHotspot();
		/*3529*/
		CefPoint* tmp_d1 = new CefPoint(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*3530*/
	} break;
		/*3531*/
	case CefDragData_HasImage_25: {
		/*3532*/


		// gen! bool HasImage()
		auto ret_result = me->HasImage();
		/*3533*/
		MyCefSetBool(ret, ret_result);
		/*3534*/
	} break;
		/*3535*/
	}
	/*3536*/
	CefDragDataCToCpp::Unwrap(me);
	/*3537*/
}


// [virtual] class CefFrame
/*3787*/
/*3763*/
const int CefFrame_IsValid_1 = 1;
/*3764*/
const int CefFrame_Undo_2 = 2;
/*3765*/
const int CefFrame_Redo_3 = 3;
/*3766*/
const int CefFrame_Cut_4 = 4;
/*3767*/
const int CefFrame_Copy_5 = 5;
/*3768*/
const int CefFrame_Paste_6 = 6;
/*3769*/
const int CefFrame_Delete_7 = 7;
/*3770*/
const int CefFrame_SelectAll_8 = 8;
/*3771*/
const int CefFrame_ViewSource_9 = 9;
/*3772*/
const int CefFrame_GetSource_10 = 10;
/*3773*/
const int CefFrame_GetText_11 = 11;
/*3774*/
const int CefFrame_LoadRequest_12 = 12;
/*3775*/
const int CefFrame_LoadURL_13 = 13;
/*3776*/
const int CefFrame_LoadString_14 = 14;
/*3777*/
const int CefFrame_ExecuteJavaScript_15 = 15;
/*3778*/
const int CefFrame_IsMain_16 = 16;
/*3779*/
const int CefFrame_IsFocused_17 = 17;
/*3780*/
const int CefFrame_GetName_18 = 18;
/*3781*/
const int CefFrame_GetIdentifier_19 = 19;
/*3782*/
const int CefFrame_GetParent_20 = 20;
/*3783*/
const int CefFrame_GetURL_21 = 21;
/*3784*/
const int CefFrame_GetBrowser_22 = 22;
/*3785*/
const int CefFrame_GetV8Context_23 = 23;
/*3786*/
const int CefFrame_VisitDOM_24 = 24;

void MyCefMet_CefFrame(cef_frame_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*3788*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3789*/
	auto me = CefFrameCToCpp::Wrap(me1);
	/*3790*/
	switch (metName) {
		/*3791*/
	case MET_Release:return; //yes, just return
							 /*3792*/
	case CefFrame_IsValid_1: {
		/*3793*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*3794*/
		MyCefSetBool(ret, ret_result);
		/*3795*/
	} break;
		/*3796*/
	case CefFrame_Undo_2: {
		/*3797*/


		// gen! void Undo()
		me->Undo();
		/*3798*/

		/*3799*/
	} break;
		/*3800*/
	case CefFrame_Redo_3: {
		/*3801*/


		// gen! void Redo()
		me->Redo();
		/*3802*/

		/*3803*/
	} break;
		/*3804*/
	case CefFrame_Cut_4: {
		/*3805*/


		// gen! void Cut()
		me->Cut();
		/*3806*/

		/*3807*/
	} break;
		/*3808*/
	case CefFrame_Copy_5: {
		/*3809*/


		// gen! void Copy()
		me->Copy();
		/*3810*/

		/*3811*/
	} break;
		/*3812*/
	case CefFrame_Paste_6: {
		/*3813*/


		// gen! void Paste()
		me->Paste();
		/*3814*/

		/*3815*/
	} break;
		/*3816*/
	case CefFrame_Delete_7: {
		/*3817*/


		// gen! void Delete()
		me->Delete();
		/*3818*/

		/*3819*/
	} break;
		/*3820*/
	case CefFrame_SelectAll_8: {
		/*3821*/


		// gen! void SelectAll()
		me->SelectAll();
		/*3822*/

		/*3823*/
	} break;
		/*3824*/
	case CefFrame_ViewSource_9: {
		/*3825*/


		// gen! void ViewSource()
		me->ViewSource();
		/*3826*/

		/*3827*/
	} break;
		/*3828*/
	case CefFrame_GetSource_10: {
		/*3829*/


		// gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
		me->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		/*3830*/

		/*3831*/
	} break;
		/*3832*/
	case CefFrame_GetText_11: {
		/*3833*/


		// gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
		me->GetText(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		/*3834*/

		/*3835*/
	} break;
		/*3836*/
	case CefFrame_LoadRequest_12: {
		/*3837*/


		// gen! void LoadRequest(CefRefPtr<CefRequest> request)
		me->LoadRequest(CefRequestCToCpp::Wrap((cef_request_t*)v1->ptr));
		/*3838*/

		/*3839*/
	} break;
		/*3840*/
	case CefFrame_LoadURL_13: {
		/*3841*/


		// gen! void LoadURL(const CefString& url)
		me->LoadURL(GetStringHolder(v1)->value);
		/*3842*/

		/*3843*/
	} break;
		/*3844*/
	case CefFrame_LoadString_14: {
		/*3845*/


		// gen! void LoadString(const CefString& string_val,const CefString& url)
		me->LoadString(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*3846*/

		/*3847*/
	} break;
		/*3848*/
	case CefFrame_ExecuteJavaScript_15: {
		/*3849*/


		// gen! void ExecuteJavaScript(const CefString& code,const CefString& script_url,int start_line)
		me->ExecuteJavaScript(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			v3->i32);
		/*3850*/

		/*3851*/
	} break;
		/*3852*/
	case CefFrame_IsMain_16: {
		/*3853*/


		// gen! bool IsMain()
		auto ret_result = me->IsMain();
		/*3854*/
		MyCefSetBool(ret, ret_result);
		/*3855*/
	} break;
		/*3856*/
	case CefFrame_IsFocused_17: {
		/*3857*/


		// gen! bool IsFocused()
		auto ret_result = me->IsFocused();
		/*3858*/
		MyCefSetBool(ret, ret_result);
		/*3859*/
	} break;
		/*3860*/
	case CefFrame_GetName_18: {
		/*3861*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*3862*/
		SetCefStringToJsValue(ret, ret_result);
		/*3863*/
	} break;
		/*3864*/
	case CefFrame_GetIdentifier_19: {
		/*3865*/


		// gen! int64 GetIdentifier()
		auto ret_result = me->GetIdentifier();
		/*3866*/
		MyCefSetInt64(ret, ret_result);
		/*3867*/
	} break;
		/*3868*/
	case CefFrame_GetParent_20: {
		/*3869*/


		// gen! CefRefPtr<CefFrame> GetParent()
		auto ret_result = me->GetParent();
		/*3870*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*3871*/
	} break;
		/*3872*/
	case CefFrame_GetURL_21: {
		/*3873*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*3874*/
		SetCefStringToJsValue(ret, ret_result);
		/*3875*/
	} break;
		/*3876*/
	case CefFrame_GetBrowser_22: {
		/*3877*/


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		/*3878*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*3879*/
	} break;
		/*3880*/
	case CefFrame_GetV8Context_23: {
		/*3881*/


		// gen! CefRefPtr<CefV8Context> GetV8Context()
		auto ret_result = me->GetV8Context();
		/*3882*/
		MyCefSetVoidPtr(ret, CefV8ContextCToCpp::Unwrap(ret_result));
		/*3883*/
	} break;
		/*3884*/
	case CefFrame_VisitDOM_24: {
		/*3885*/


		// gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
		me->VisitDOM(CefDOMVisitorCppToC::Unwrap((cef_domvisitor_t*)v1->ptr));
		/*3886*/

		/*3887*/
	} break;
		/*3888*/
	}
	/*3889*/
	CefFrameCToCpp::Unwrap(me);
	/*3890*/
}


// [virtual] class CefImage
/*4108*/
/*4095*/
const int CefImage_IsEmpty_1 = 1;
/*4096*/
const int CefImage_IsSame_2 = 2;
/*4097*/
const int CefImage_AddBitmap_3 = 3;
/*4098*/
const int CefImage_AddPNG_4 = 4;
/*4099*/
const int CefImage_AddJPEG_5 = 5;
/*4100*/
const int CefImage_GetWidth_6 = 6;
/*4101*/
const int CefImage_GetHeight_7 = 7;
/*4102*/
const int CefImage_HasRepresentation_8 = 8;
/*4103*/
const int CefImage_RemoveRepresentation_9 = 9;
/*4104*/
const int CefImage_GetRepresentationInfo_10 = 10;
/*4105*/
const int CefImage_GetAsBitmap_11 = 11;
/*4106*/
const int CefImage_GetAsPNG_12 = 12;
/*4107*/
const int CefImage_GetAsJPEG_13 = 13;

void MyCefMet_CefImage(cef_image_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7) {
	/*4109*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*4110*/
	auto me = CefImageCToCpp::Wrap(me1);
	/*4111*/
	switch (metName) {
		/*4112*/
	case MET_Release:return; //yes, just return
							 /*4113*/
	case CefImage_IsEmpty_1: {
		/*4114*/


		// gen! bool IsEmpty()
		auto ret_result = me->IsEmpty();
		/*4115*/
		MyCefSetBool(ret, ret_result);
		/*4116*/
	} break;
		/*4117*/
	case CefImage_IsSame_2: {
		/*4118*/


		// gen! bool IsSame(CefRefPtr<CefImage> that)
		auto ret_result = me->IsSame(CefImageCToCpp::Wrap((cef_image_t*)v1->ptr));
		/*4119*/
		MyCefSetBool(ret, ret_result);
		/*4120*/
	} break;
		/*4121*/
	case CefImage_AddBitmap_3: {
		/*4122*/


		// gen! bool AddBitmap(float scale_factor,int pixel_width,int pixel_height,cef_color_type_t color_type,cef_alpha_type_t alpha_type,const void* pixel_data,size_t pixel_data_size)
		auto ret_result = me->AddBitmap(v1->num,
			v2->i32,
			v3->i32,
			(cef_color_type_t)v4->i32,
			(cef_alpha_type_t)v5->i32,
			(void*)v6->ptr,
			v7->i64);
		/*4123*/
		MyCefSetBool(ret, ret_result);
		/*4124*/
	} break;
		/*4125*/
	case CefImage_AddPNG_4: {
		/*4126*/


		// gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
		auto ret_result = me->AddPNG(v1->num,
			(void*)v2->ptr,
			v3->i64);
		/*4127*/
		MyCefSetBool(ret, ret_result);
		/*4128*/
	} break;
		/*4129*/
	case CefImage_AddJPEG_5: {
		/*4130*/


		// gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
		auto ret_result = me->AddJPEG(v1->num,
			(void*)v2->ptr,
			v3->i64);
		/*4131*/
		MyCefSetBool(ret, ret_result);
		/*4132*/
	} break;
		/*4133*/
	case CefImage_GetWidth_6: {
		/*4134*/


		// gen! size_t GetWidth()
		auto ret_result = me->GetWidth();
		/*4135*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*4136*/
	} break;
		/*4137*/
	case CefImage_GetHeight_7: {
		/*4138*/


		// gen! size_t GetHeight()
		auto ret_result = me->GetHeight();
		/*4139*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*4140*/
	} break;
		/*4141*/
	case CefImage_HasRepresentation_8: {
		/*4142*/


		// gen! bool HasRepresentation(float scale_factor)
		auto ret_result = me->HasRepresentation(v1->num);
		/*4143*/
		MyCefSetBool(ret, ret_result);
		/*4144*/
	} break;
		/*4145*/
	case CefImage_RemoveRepresentation_9: {
		/*4146*/


		// gen! bool RemoveRepresentation(float scale_factor)
		auto ret_result = me->RemoveRepresentation(v1->num);
		/*4147*/
		MyCefSetBool(ret, ret_result);
		/*4148*/
	} break;
		/*4149*/
	case CefImage_GetRepresentationInfo_10: {
		/*4150*/


		// gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetRepresentationInfo(v1->num,
			*((float*)v2->ptr),
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		/*4151*/
		MyCefSetBool(ret, ret_result);
		/*4152*/
	} break;
		/*4153*/
	case CefImage_GetAsBitmap_11: {
		/*4154*/


		// gen! CefRefPtr<CefBinaryValue> GetAsBitmap(float scale_factor,cef_color_type_t color_type,cef_alpha_type_t alpha_type,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsBitmap(v1->num,
			(cef_color_type_t)v2->i32,
			(cef_alpha_type_t)v3->i32,
			*((int*)v4->ptr),
			*((int*)v5->ptr));
		/*4155*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*4156*/
	} break;
		/*4157*/
	case CefImage_GetAsPNG_12: {
		/*4158*/


		// gen! CefRefPtr<CefBinaryValue> GetAsPNG(float scale_factor,bool with_transparency,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsPNG(v1->num,
			v2->i32 != 0,
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		/*4159*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*4160*/
	} break;
		/*4161*/
	case CefImage_GetAsJPEG_13: {
		/*4162*/


		// gen! CefRefPtr<CefBinaryValue> GetAsJPEG(float scale_factor,int quality,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsJPEG(v1->num,
			v2->i32,
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		/*4163*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*4164*/
	} break;
		/*4165*/
	}
	/*4166*/
	CefImageCToCpp::Unwrap(me);
	/*4167*/
}


// [virtual] class CefMenuModel
/*4377*/
/*4321*/
const int CefMenuModel_IsSubMenu_1 = 1;
/*4322*/
const int CefMenuModel_Clear_2 = 2;
/*4323*/
const int CefMenuModel_GetCount_3 = 3;
/*4324*/
const int CefMenuModel_AddSeparator_4 = 4;
/*4325*/
const int CefMenuModel_AddItem_5 = 5;
/*4326*/
const int CefMenuModel_AddCheckItem_6 = 6;
/*4327*/
const int CefMenuModel_AddRadioItem_7 = 7;
/*4328*/
const int CefMenuModel_AddSubMenu_8 = 8;
/*4329*/
const int CefMenuModel_InsertSeparatorAt_9 = 9;
/*4330*/
const int CefMenuModel_InsertItemAt_10 = 10;
/*4331*/
const int CefMenuModel_InsertCheckItemAt_11 = 11;
/*4332*/
const int CefMenuModel_InsertRadioItemAt_12 = 12;
/*4333*/
const int CefMenuModel_InsertSubMenuAt_13 = 13;
/*4334*/
const int CefMenuModel_Remove_14 = 14;
/*4335*/
const int CefMenuModel_RemoveAt_15 = 15;
/*4336*/
const int CefMenuModel_GetIndexOf_16 = 16;
/*4337*/
const int CefMenuModel_GetCommandIdAt_17 = 17;
/*4338*/
const int CefMenuModel_SetCommandIdAt_18 = 18;
/*4339*/
const int CefMenuModel_GetLabel_19 = 19;
/*4340*/
const int CefMenuModel_GetLabelAt_20 = 20;
/*4341*/
const int CefMenuModel_SetLabel_21 = 21;
/*4342*/
const int CefMenuModel_SetLabelAt_22 = 22;
/*4343*/
const int CefMenuModel_GetType_23 = 23;
/*4344*/
const int CefMenuModel_GetTypeAt_24 = 24;
/*4345*/
const int CefMenuModel_GetGroupId_25 = 25;
/*4346*/
const int CefMenuModel_GetGroupIdAt_26 = 26;
/*4347*/
const int CefMenuModel_SetGroupId_27 = 27;
/*4348*/
const int CefMenuModel_SetGroupIdAt_28 = 28;
/*4349*/
const int CefMenuModel_GetSubMenu_29 = 29;
/*4350*/
const int CefMenuModel_GetSubMenuAt_30 = 30;
/*4351*/
const int CefMenuModel_IsVisible_31 = 31;
/*4352*/
const int CefMenuModel_IsVisibleAt_32 = 32;
/*4353*/
const int CefMenuModel_SetVisible_33 = 33;
/*4354*/
const int CefMenuModel_SetVisibleAt_34 = 34;
/*4355*/
const int CefMenuModel_IsEnabled_35 = 35;
/*4356*/
const int CefMenuModel_IsEnabledAt_36 = 36;
/*4357*/
const int CefMenuModel_SetEnabled_37 = 37;
/*4358*/
const int CefMenuModel_SetEnabledAt_38 = 38;
/*4359*/
const int CefMenuModel_IsChecked_39 = 39;
/*4360*/
const int CefMenuModel_IsCheckedAt_40 = 40;
/*4361*/
const int CefMenuModel_SetChecked_41 = 41;
/*4362*/
const int CefMenuModel_SetCheckedAt_42 = 42;
/*4363*/
const int CefMenuModel_HasAccelerator_43 = 43;
/*4364*/
const int CefMenuModel_HasAcceleratorAt_44 = 44;
/*4365*/
const int CefMenuModel_SetAccelerator_45 = 45;
/*4366*/
const int CefMenuModel_SetAcceleratorAt_46 = 46;
/*4367*/
const int CefMenuModel_RemoveAccelerator_47 = 47;
/*4368*/
const int CefMenuModel_RemoveAcceleratorAt_48 = 48;
/*4369*/
const int CefMenuModel_GetAccelerator_49 = 49;
/*4370*/
const int CefMenuModel_GetAcceleratorAt_50 = 50;
/*4371*/
const int CefMenuModel_SetColor_51 = 51;
/*4372*/
const int CefMenuModel_SetColorAt_52 = 52;
/*4373*/
const int CefMenuModel_GetColor_53 = 53;
/*4374*/
const int CefMenuModel_GetColorAt_54 = 54;
/*4375*/
const int CefMenuModel_SetFontList_55 = 55;
/*4376*/
const int CefMenuModel_SetFontListAt_56 = 56;

void MyCefMet_CefMenuModel(cef_menu_model_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5) {
	/*4378*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*4379*/
	auto me = CefMenuModelCToCpp::Wrap(me1);
	/*4380*/
	switch (metName) {
		/*4381*/
	case MET_Release:return; //yes, just return
							 /*4382*/
	case CefMenuModel_IsSubMenu_1: {
		/*4383*/


		// gen! bool IsSubMenu()
		auto ret_result = me->IsSubMenu();
		/*4384*/
		MyCefSetBool(ret, ret_result);
		/*4385*/
	} break;
		/*4386*/
	case CefMenuModel_Clear_2: {
		/*4387*/


		// gen! bool Clear()
		auto ret_result = me->Clear();
		/*4388*/
		MyCefSetBool(ret, ret_result);
		/*4389*/
	} break;
		/*4390*/
	case CefMenuModel_GetCount_3: {
		/*4391*/


		// gen! int GetCount()
		auto ret_result = me->GetCount();
		/*4392*/
		MyCefSetInt64(ret, ret_result);
		/*4393*/
	} break;
		/*4394*/
	case CefMenuModel_AddSeparator_4: {
		/*4395*/


		// gen! bool AddSeparator()
		auto ret_result = me->AddSeparator();
		/*4396*/
		MyCefSetBool(ret, ret_result);
		/*4397*/
	} break;
		/*4398*/
	case CefMenuModel_AddItem_5: {
		/*4399*/


		// gen! bool AddItem(int command_id,const CefString& label)
		auto ret_result = me->AddItem(v1->i32,
			GetStringHolder(v2)->value);
		/*4400*/
		MyCefSetBool(ret, ret_result);
		/*4401*/
	} break;
		/*4402*/
	case CefMenuModel_AddCheckItem_6: {
		/*4403*/


		// gen! bool AddCheckItem(int command_id,const CefString& label)
		auto ret_result = me->AddCheckItem(v1->i32,
			GetStringHolder(v2)->value);
		/*4404*/
		MyCefSetBool(ret, ret_result);
		/*4405*/
	} break;
		/*4406*/
	case CefMenuModel_AddRadioItem_7: {
		/*4407*/


		// gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
		auto ret_result = me->AddRadioItem(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32);
		/*4408*/
		MyCefSetBool(ret, ret_result);
		/*4409*/
	} break;
		/*4410*/
	case CefMenuModel_AddSubMenu_8: {
		/*4411*/


		// gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
		auto ret_result = me->AddSubMenu(v1->i32,
			GetStringHolder(v2)->value);
		/*4412*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*4413*/
	} break;
		/*4414*/
	case CefMenuModel_InsertSeparatorAt_9: {
		/*4415*/


		// gen! bool InsertSeparatorAt(int index)
		auto ret_result = me->InsertSeparatorAt(v1->i32);
		/*4416*/
		MyCefSetBool(ret, ret_result);
		/*4417*/
	} break;
		/*4418*/
	case CefMenuModel_InsertItemAt_10: {
		/*4419*/


		// gen! bool InsertItemAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		/*4420*/
		MyCefSetBool(ret, ret_result);
		/*4421*/
	} break;
		/*4422*/
	case CefMenuModel_InsertCheckItemAt_11: {
		/*4423*/


		// gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertCheckItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		/*4424*/
		MyCefSetBool(ret, ret_result);
		/*4425*/
	} break;
		/*4426*/
	case CefMenuModel_InsertRadioItemAt_12: {
		/*4427*/


		// gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
		auto ret_result = me->InsertRadioItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value,
			v4->i32);
		/*4428*/
		MyCefSetBool(ret, ret_result);
		/*4429*/
	} break;
		/*4430*/
	case CefMenuModel_InsertSubMenuAt_13: {
		/*4431*/


		// gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertSubMenuAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		/*4432*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*4433*/
	} break;
		/*4434*/
	case CefMenuModel_Remove_14: {
		/*4435*/


		// gen! bool Remove(int command_id)
		auto ret_result = me->Remove(v1->i32);
		/*4436*/
		MyCefSetBool(ret, ret_result);
		/*4437*/
	} break;
		/*4438*/
	case CefMenuModel_RemoveAt_15: {
		/*4439*/


		// gen! bool RemoveAt(int index)
		auto ret_result = me->RemoveAt(v1->i32);
		/*4440*/
		MyCefSetBool(ret, ret_result);
		/*4441*/
	} break;
		/*4442*/
	case CefMenuModel_GetIndexOf_16: {
		/*4443*/


		// gen! int GetIndexOf(int command_id)
		auto ret_result = me->GetIndexOf(v1->i32);
		/*4444*/
		MyCefSetInt64(ret, ret_result);
		/*4445*/
	} break;
		/*4446*/
	case CefMenuModel_GetCommandIdAt_17: {
		/*4447*/


		// gen! int GetCommandIdAt(int index)
		auto ret_result = me->GetCommandIdAt(v1->i32);
		/*4448*/
		MyCefSetInt64(ret, ret_result);
		/*4449*/
	} break;
		/*4450*/
	case CefMenuModel_SetCommandIdAt_18: {
		/*4451*/


		// gen! bool SetCommandIdAt(int index,int command_id)
		auto ret_result = me->SetCommandIdAt(v1->i32,
			v2->i32);
		/*4452*/
		MyCefSetBool(ret, ret_result);
		/*4453*/
	} break;
		/*4454*/
	case CefMenuModel_GetLabel_19: {
		/*4455*/


		// gen! CefString GetLabel(int command_id)
		auto ret_result = me->GetLabel(v1->i32);
		/*4456*/
		SetCefStringToJsValue(ret, ret_result);
		/*4457*/
	} break;
		/*4458*/
	case CefMenuModel_GetLabelAt_20: {
		/*4459*/


		// gen! CefString GetLabelAt(int index)
		auto ret_result = me->GetLabelAt(v1->i32);
		/*4460*/
		SetCefStringToJsValue(ret, ret_result);
		/*4461*/
	} break;
		/*4462*/
	case CefMenuModel_SetLabel_21: {
		/*4463*/


		// gen! bool SetLabel(int command_id,const CefString& label)
		auto ret_result = me->SetLabel(v1->i32,
			GetStringHolder(v2)->value);
		/*4464*/
		MyCefSetBool(ret, ret_result);
		/*4465*/
	} break;
		/*4466*/
	case CefMenuModel_SetLabelAt_22: {
		/*4467*/


		// gen! bool SetLabelAt(int index,const CefString& label)
		auto ret_result = me->SetLabelAt(v1->i32,
			GetStringHolder(v2)->value);
		/*4468*/
		MyCefSetBool(ret, ret_result);
		/*4469*/
	} break;
		/*4470*/
	case CefMenuModel_GetType_23: {
		/*4471*/


		// gen! MenuItemType GetType(int command_id)
		auto ret_result = me->GetType(v1->i32);
		/*4472*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*4473*/
	} break;
		/*4474*/
	case CefMenuModel_GetTypeAt_24: {
		/*4475*/


		// gen! MenuItemType GetTypeAt(int index)
		auto ret_result = me->GetTypeAt(v1->i32);
		/*4476*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*4477*/
	} break;
		/*4478*/
	case CefMenuModel_GetGroupId_25: {
		/*4479*/


		// gen! int GetGroupId(int command_id)
		auto ret_result = me->GetGroupId(v1->i32);
		/*4480*/
		MyCefSetInt64(ret, ret_result);
		/*4481*/
	} break;
		/*4482*/
	case CefMenuModel_GetGroupIdAt_26: {
		/*4483*/


		// gen! int GetGroupIdAt(int index)
		auto ret_result = me->GetGroupIdAt(v1->i32);
		/*4484*/
		MyCefSetInt64(ret, ret_result);
		/*4485*/
	} break;
		/*4486*/
	case CefMenuModel_SetGroupId_27: {
		/*4487*/


		// gen! bool SetGroupId(int command_id,int group_id)
		auto ret_result = me->SetGroupId(v1->i32,
			v2->i32);
		/*4488*/
		MyCefSetBool(ret, ret_result);
		/*4489*/
	} break;
		/*4490*/
	case CefMenuModel_SetGroupIdAt_28: {
		/*4491*/


		// gen! bool SetGroupIdAt(int index,int group_id)
		auto ret_result = me->SetGroupIdAt(v1->i32,
			v2->i32);
		/*4492*/
		MyCefSetBool(ret, ret_result);
		/*4493*/
	} break;
		/*4494*/
	case CefMenuModel_GetSubMenu_29: {
		/*4495*/


		// gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
		auto ret_result = me->GetSubMenu(v1->i32);
		/*4496*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*4497*/
	} break;
		/*4498*/
	case CefMenuModel_GetSubMenuAt_30: {
		/*4499*/


		// gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
		auto ret_result = me->GetSubMenuAt(v1->i32);
		/*4500*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*4501*/
	} break;
		/*4502*/
	case CefMenuModel_IsVisible_31: {
		/*4503*/


		// gen! bool IsVisible(int command_id)
		auto ret_result = me->IsVisible(v1->i32);
		/*4504*/
		MyCefSetBool(ret, ret_result);
		/*4505*/
	} break;
		/*4506*/
	case CefMenuModel_IsVisibleAt_32: {
		/*4507*/


		// gen! bool IsVisibleAt(int index)
		auto ret_result = me->IsVisibleAt(v1->i32);
		/*4508*/
		MyCefSetBool(ret, ret_result);
		/*4509*/
	} break;
		/*4510*/
	case CefMenuModel_SetVisible_33: {
		/*4511*/


		// gen! bool SetVisible(int command_id,bool visible)
		auto ret_result = me->SetVisible(v1->i32,
			v2->i32 != 0);
		/*4512*/
		MyCefSetBool(ret, ret_result);
		/*4513*/
	} break;
		/*4514*/
	case CefMenuModel_SetVisibleAt_34: {
		/*4515*/


		// gen! bool SetVisibleAt(int index,bool visible)
		auto ret_result = me->SetVisibleAt(v1->i32,
			v2->i32 != 0);
		/*4516*/
		MyCefSetBool(ret, ret_result);
		/*4517*/
	} break;
		/*4518*/
	case CefMenuModel_IsEnabled_35: {
		/*4519*/


		// gen! bool IsEnabled(int command_id)
		auto ret_result = me->IsEnabled(v1->i32);
		/*4520*/
		MyCefSetBool(ret, ret_result);
		/*4521*/
	} break;
		/*4522*/
	case CefMenuModel_IsEnabledAt_36: {
		/*4523*/


		// gen! bool IsEnabledAt(int index)
		auto ret_result = me->IsEnabledAt(v1->i32);
		/*4524*/
		MyCefSetBool(ret, ret_result);
		/*4525*/
	} break;
		/*4526*/
	case CefMenuModel_SetEnabled_37: {
		/*4527*/


		// gen! bool SetEnabled(int command_id,bool enabled)
		auto ret_result = me->SetEnabled(v1->i32,
			v2->i32 != 0);
		/*4528*/
		MyCefSetBool(ret, ret_result);
		/*4529*/
	} break;
		/*4530*/
	case CefMenuModel_SetEnabledAt_38: {
		/*4531*/


		// gen! bool SetEnabledAt(int index,bool enabled)
		auto ret_result = me->SetEnabledAt(v1->i32,
			v2->i32 != 0);
		/*4532*/
		MyCefSetBool(ret, ret_result);
		/*4533*/
	} break;
		/*4534*/
	case CefMenuModel_IsChecked_39: {
		/*4535*/


		// gen! bool IsChecked(int command_id)
		auto ret_result = me->IsChecked(v1->i32);
		/*4536*/
		MyCefSetBool(ret, ret_result);
		/*4537*/
	} break;
		/*4538*/
	case CefMenuModel_IsCheckedAt_40: {
		/*4539*/


		// gen! bool IsCheckedAt(int index)
		auto ret_result = me->IsCheckedAt(v1->i32);
		/*4540*/
		MyCefSetBool(ret, ret_result);
		/*4541*/
	} break;
		/*4542*/
	case CefMenuModel_SetChecked_41: {
		/*4543*/


		// gen! bool SetChecked(int command_id,bool checked)
		auto ret_result = me->SetChecked(v1->i32,
			v2->i32 != 0);
		/*4544*/
		MyCefSetBool(ret, ret_result);
		/*4545*/
	} break;
		/*4546*/
	case CefMenuModel_SetCheckedAt_42: {
		/*4547*/


		// gen! bool SetCheckedAt(int index,bool checked)
		auto ret_result = me->SetCheckedAt(v1->i32,
			v2->i32 != 0);
		/*4548*/
		MyCefSetBool(ret, ret_result);
		/*4549*/
	} break;
		/*4550*/
	case CefMenuModel_HasAccelerator_43: {
		/*4551*/


		// gen! bool HasAccelerator(int command_id)
		auto ret_result = me->HasAccelerator(v1->i32);
		/*4552*/
		MyCefSetBool(ret, ret_result);
		/*4553*/
	} break;
		/*4554*/
	case CefMenuModel_HasAcceleratorAt_44: {
		/*4555*/


		// gen! bool HasAcceleratorAt(int index)
		auto ret_result = me->HasAcceleratorAt(v1->i32);
		/*4556*/
		MyCefSetBool(ret, ret_result);
		/*4557*/
	} break;
		/*4558*/
	case CefMenuModel_SetAccelerator_45: {
		/*4559*/


		// gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
		auto ret_result = me->SetAccelerator(v1->i32,
			v2->i32,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*4560*/
		MyCefSetBool(ret, ret_result);
		/*4561*/
	} break;
		/*4562*/
	case CefMenuModel_SetAcceleratorAt_46: {
		/*4563*/


		// gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
		auto ret_result = me->SetAcceleratorAt(v1->i32,
			v2->i32,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*4564*/
		MyCefSetBool(ret, ret_result);
		/*4565*/
	} break;
		/*4566*/
	case CefMenuModel_RemoveAccelerator_47: {
		/*4567*/


		// gen! bool RemoveAccelerator(int command_id)
		auto ret_result = me->RemoveAccelerator(v1->i32);
		/*4568*/
		MyCefSetBool(ret, ret_result);
		/*4569*/
	} break;
		/*4570*/
	case CefMenuModel_RemoveAcceleratorAt_48: {
		/*4571*/


		// gen! bool RemoveAcceleratorAt(int index)
		auto ret_result = me->RemoveAcceleratorAt(v1->i32);
		/*4572*/
		MyCefSetBool(ret, ret_result);
		/*4573*/
	} break;
		/*4574*/
	case CefMenuModel_GetAccelerator_49: {
		/*4575*/


		// gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
		auto ret_result = me->GetAccelerator(v1->i32,
			*((int*)v2->ptr),
			*((bool*)v3->ptr),
			*((bool*)v4->ptr),
			*((bool*)v5->ptr));
		/*4576*/
		MyCefSetBool(ret, ret_result);
		/*4577*/
	} break;
		/*4578*/
	case CefMenuModel_GetAcceleratorAt_50: {
		/*4579*/


		// gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
		auto ret_result = me->GetAcceleratorAt(v1->i32,
			*((int*)v2->ptr),
			*((bool*)v3->ptr),
			*((bool*)v4->ptr),
			*((bool*)v5->ptr));
		/*4580*/
		MyCefSetBool(ret, ret_result);
		/*4581*/
	} break;
		/*4582*/
	case CefMenuModel_SetColor_51: {
		/*4583*/


		// gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
		auto ret_result = me->SetColor(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			(cef_color_t)v3->i32);
		/*4584*/
		MyCefSetBool(ret, ret_result);
		/*4585*/
	} break;
		/*4586*/
	case CefMenuModel_SetColorAt_52: {
		/*4587*/


		// gen! bool SetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t color)
		auto ret_result = me->SetColorAt(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			(cef_color_t)v3->i32);
		/*4588*/
		MyCefSetBool(ret, ret_result);
		/*4589*/
	} break;
		/*4590*/
	case CefMenuModel_GetColor_53: {
		/*4591*/


		// gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
		auto ret_result = me->GetColor(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			*((cef_color_t*)v3->ptr));
		/*4592*/
		MyCefSetBool(ret, ret_result);
		/*4593*/
	} break;
		/*4594*/
	case CefMenuModel_GetColorAt_54: {
		/*4595*/


		// gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
		auto ret_result = me->GetColorAt(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			*((cef_color_t*)v3->ptr));
		/*4596*/
		MyCefSetBool(ret, ret_result);
		/*4597*/
	} break;
		/*4598*/
	case CefMenuModel_SetFontList_55: {
		/*4599*/


		// gen! bool SetFontList(int command_id,const CefString& font_list)
		auto ret_result = me->SetFontList(v1->i32,
			GetStringHolder(v2)->value);
		/*4600*/
		MyCefSetBool(ret, ret_result);
		/*4601*/
	} break;
		/*4602*/
	case CefMenuModel_SetFontListAt_56: {
		/*4603*/


		// gen! bool SetFontListAt(int index,const CefString& font_list)
		auto ret_result = me->SetFontListAt(v1->i32,
			GetStringHolder(v2)->value);
		/*4604*/
		MyCefSetBool(ret, ret_result);
		/*4605*/
	} break;
		/*4606*/
	}
	/*4607*/
	CefMenuModelCToCpp::Unwrap(me);
	/*4608*/
}


// [virtual] class CefMenuModelDelegate
/*5199*/

void MyCefMet_CefMenuModelDelegate(cef_menu_model_delegate_t* me1, int metName, jsvalue* ret) {
	/*5200*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*5201*/
	auto me = CefMenuModelDelegateCppToC::Unwrap(me1);
	/*5202*/
	switch (metName) {
		/*5203*/
	case MET_Release:return; //yes, just return
							 /*5204*/
	}
	/*5205*/
	CefMenuModelDelegateCppToC::Wrap(me);
	/*5206*/
}


// [virtual] class CefNavigationEntry
/*5224*/
/*5214*/
const int CefNavigationEntry_IsValid_1 = 1;
/*5215*/
const int CefNavigationEntry_GetURL_2 = 2;
/*5216*/
const int CefNavigationEntry_GetDisplayURL_3 = 3;
/*5217*/
const int CefNavigationEntry_GetOriginalURL_4 = 4;
/*5218*/
const int CefNavigationEntry_GetTitle_5 = 5;
/*5219*/
const int CefNavigationEntry_GetTransitionType_6 = 6;
/*5220*/
const int CefNavigationEntry_HasPostData_7 = 7;
/*5221*/
const int CefNavigationEntry_GetCompletionTime_8 = 8;
/*5222*/
const int CefNavigationEntry_GetHttpStatusCode_9 = 9;
/*5223*/
const int CefNavigationEntry_GetSSLStatus_10 = 10;

void MyCefMet_CefNavigationEntry(cef_navigation_entry_t* me1, int metName, jsvalue* ret) {
	/*5225*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*5226*/
	auto me = CefNavigationEntryCToCpp::Wrap(me1);
	/*5227*/
	switch (metName) {
		/*5228*/
	case MET_Release:return; //yes, just return
							 /*5229*/
	case CefNavigationEntry_IsValid_1: {
		/*5230*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*5231*/
		MyCefSetBool(ret, ret_result);
		/*5232*/
	} break;
		/*5233*/
	case CefNavigationEntry_GetURL_2: {
		/*5234*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*5235*/
		SetCefStringToJsValue(ret, ret_result);
		/*5236*/
	} break;
		/*5237*/
	case CefNavigationEntry_GetDisplayURL_3: {
		/*5238*/


		// gen! CefString GetDisplayURL()
		auto ret_result = me->GetDisplayURL();
		/*5239*/
		SetCefStringToJsValue(ret, ret_result);
		/*5240*/
	} break;
		/*5241*/
	case CefNavigationEntry_GetOriginalURL_4: {
		/*5242*/


		// gen! CefString GetOriginalURL()
		auto ret_result = me->GetOriginalURL();
		/*5243*/
		SetCefStringToJsValue(ret, ret_result);
		/*5244*/
	} break;
		/*5245*/
	case CefNavigationEntry_GetTitle_5: {
		/*5246*/


		// gen! CefString GetTitle()
		auto ret_result = me->GetTitle();
		/*5247*/
		SetCefStringToJsValue(ret, ret_result);
		/*5248*/
	} break;
		/*5249*/
	case CefNavigationEntry_GetTransitionType_6: {
		/*5250*/


		// gen! TransitionType GetTransitionType()
		auto ret_result = me->GetTransitionType();
		/*5251*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5252*/
	} break;
		/*5253*/
	case CefNavigationEntry_HasPostData_7: {
		/*5254*/


		// gen! bool HasPostData()
		auto ret_result = me->HasPostData();
		/*5255*/
		MyCefSetBool(ret, ret_result);
		/*5256*/
	} break;
		/*5257*/
	case CefNavigationEntry_GetCompletionTime_8: {
		/*5258*/


		// gen! CefTime GetCompletionTime()
		auto ret_result = me->GetCompletionTime();
		/*5259*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*5260*/
	} break;
		/*5261*/
	case CefNavigationEntry_GetHttpStatusCode_9: {
		/*5262*/


		// gen! int GetHttpStatusCode()
		auto ret_result = me->GetHttpStatusCode();
		/*5263*/
		MyCefSetInt64(ret, ret_result);
		/*5264*/
	} break;
		/*5265*/
	case CefNavigationEntry_GetSSLStatus_10: {
		/*5266*/


		// gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
		auto ret_result = me->GetSSLStatus();
		/*5267*/
		MyCefSetVoidPtr(ret, CefSSLStatusCToCpp::Unwrap(ret_result));
		/*5268*/
	} break;
		/*5269*/
	}
	/*5270*/
	CefNavigationEntryCToCpp::Unwrap(me);
	/*5271*/
}


// [virtual] class CefPrintSettings
/*5382*/
/*5359*/
const int CefPrintSettings_IsValid_1 = 1;
/*5360*/
const int CefPrintSettings_IsReadOnly_2 = 2;
/*5361*/
const int CefPrintSettings_Copy_3 = 3;
/*5362*/
const int CefPrintSettings_SetOrientation_4 = 4;
/*5363*/
const int CefPrintSettings_IsLandscape_5 = 5;
/*5364*/
const int CefPrintSettings_SetPrinterPrintableArea_6 = 6;
/*5365*/
const int CefPrintSettings_SetDeviceName_7 = 7;
/*5366*/
const int CefPrintSettings_GetDeviceName_8 = 8;
/*5367*/
const int CefPrintSettings_SetDPI_9 = 9;
/*5368*/
const int CefPrintSettings_GetDPI_10 = 10;
/*5369*/
const int CefPrintSettings_SetPageRanges_11 = 11;
/*5370*/
const int CefPrintSettings_GetPageRangesCount_12 = 12;
/*5371*/
const int CefPrintSettings_GetPageRanges_13 = 13;
/*5372*/
const int CefPrintSettings_SetSelectionOnly_14 = 14;
/*5373*/
const int CefPrintSettings_IsSelectionOnly_15 = 15;
/*5374*/
const int CefPrintSettings_SetCollate_16 = 16;
/*5375*/
const int CefPrintSettings_WillCollate_17 = 17;
/*5376*/
const int CefPrintSettings_SetColorModel_18 = 18;
/*5377*/
const int CefPrintSettings_GetColorModel_19 = 19;
/*5378*/
const int CefPrintSettings_SetCopies_20 = 20;
/*5379*/
const int CefPrintSettings_GetCopies_21 = 21;
/*5380*/
const int CefPrintSettings_SetDuplexMode_22 = 22;
/*5381*/
const int CefPrintSettings_GetDuplexMode_23 = 23;

void MyCefMet_CefPrintSettings(cef_print_settings_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*5383*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*5384*/
	auto me = CefPrintSettingsCToCpp::Wrap(me1);
	/*5385*/
	switch (metName) {
		/*5386*/
	case MET_Release:return; //yes, just return
							 /*5387*/
	case CefPrintSettings_IsValid_1: {
		/*5388*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*5389*/
		MyCefSetBool(ret, ret_result);
		/*5390*/
	} break;
		/*5391*/
	case CefPrintSettings_IsReadOnly_2: {
		/*5392*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*5393*/
		MyCefSetBool(ret, ret_result);
		/*5394*/
	} break;
		/*5395*/
	case CefPrintSettings_Copy_3: {
		/*5396*/


		// gen! CefRefPtr<CefPrintSettings> Copy()
		auto ret_result = me->Copy();
		/*5397*/
		MyCefSetVoidPtr(ret, CefPrintSettingsCToCpp::Unwrap(ret_result));
		/*5398*/
	} break;
		/*5399*/
	case CefPrintSettings_SetOrientation_4: {
		/*5400*/


		// gen! void SetOrientation(bool landscape)
		me->SetOrientation(v1->i32 != 0);
		/*5401*/

		/*5402*/
	} break;
		/*5403*/
	case CefPrintSettings_IsLandscape_5: {
		/*5404*/


		// gen! bool IsLandscape()
		auto ret_result = me->IsLandscape();
		/*5405*/
		MyCefSetBool(ret, ret_result);
		/*5406*/
	} break;
		/*5407*/
	case CefPrintSettings_SetPrinterPrintableArea_6: {
		/*5408*/


		// gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
		me->SetPrinterPrintableArea(*((CefSize*)v1->ptr),
			*((CefRect*)v2->ptr),
			v3->i32 != 0);
		/*5409*/

		/*5410*/
	} break;
		/*5411*/
	case CefPrintSettings_SetDeviceName_7: {
		/*5412*/


		// gen! void SetDeviceName(const CefString& name)
		me->SetDeviceName(GetStringHolder(v1)->value);
		/*5413*/

		/*5414*/
	} break;
		/*5415*/
	case CefPrintSettings_GetDeviceName_8: {
		/*5416*/


		// gen! CefString GetDeviceName()
		auto ret_result = me->GetDeviceName();
		/*5417*/
		SetCefStringToJsValue(ret, ret_result);
		/*5418*/
	} break;
		/*5419*/
	case CefPrintSettings_SetDPI_9: {
		/*5420*/


		// gen! void SetDPI(int dpi)
		me->SetDPI(v1->i32);
		/*5421*/

		/*5422*/
	} break;
		/*5423*/
	case CefPrintSettings_GetDPI_10: {
		/*5424*/


		// gen! int GetDPI()
		auto ret_result = me->GetDPI();
		/*5425*/
		MyCefSetInt64(ret, ret_result);
		/*5426*/
	} break;
		/*5427*/
	case CefPrintSettings_SetPageRanges_11: {
		/*5428*/


		// gen! void SetPageRanges(const PageRangeList& ranges)
		me->SetPageRanges(*((CefPrintSettings::PageRangeList*)v1->ptr));
		/*5429*/

		/*5430*/
	} break;
		/*5431*/
	case CefPrintSettings_GetPageRangesCount_12: {
		/*5432*/


		// gen! size_t GetPageRangesCount()
		auto ret_result = me->GetPageRangesCount();
		/*5433*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5434*/
	} break;
		/*5435*/
	case CefPrintSettings_GetPageRanges_13: {
		/*5436*/


		// gen! void GetPageRanges(PageRangeList& ranges)
		me->GetPageRanges(*((CefPrintSettings::PageRangeList*)v1->ptr));
		/*5437*/

		/*5438*/
	} break;
		/*5439*/
	case CefPrintSettings_SetSelectionOnly_14: {
		/*5440*/


		// gen! void SetSelectionOnly(bool selection_only)
		me->SetSelectionOnly(v1->i32 != 0);
		/*5441*/

		/*5442*/
	} break;
		/*5443*/
	case CefPrintSettings_IsSelectionOnly_15: {
		/*5444*/


		// gen! bool IsSelectionOnly()
		auto ret_result = me->IsSelectionOnly();
		/*5445*/
		MyCefSetBool(ret, ret_result);
		/*5446*/
	} break;
		/*5447*/
	case CefPrintSettings_SetCollate_16: {
		/*5448*/


		// gen! void SetCollate(bool collate)
		me->SetCollate(v1->i32 != 0);
		/*5449*/

		/*5450*/
	} break;
		/*5451*/
	case CefPrintSettings_WillCollate_17: {
		/*5452*/


		// gen! bool WillCollate()
		auto ret_result = me->WillCollate();
		/*5453*/
		MyCefSetBool(ret, ret_result);
		/*5454*/
	} break;
		/*5455*/
	case CefPrintSettings_SetColorModel_18: {
		/*5456*/


		// gen! void SetColorModel(ColorModel model)
		me->SetColorModel((CefPrintSettings::ColorModel)v1->i32);
		/*5457*/

		/*5458*/
	} break;
		/*5459*/
	case CefPrintSettings_GetColorModel_19: {
		/*5460*/


		// gen! ColorModel GetColorModel()
		auto ret_result = me->GetColorModel();
		/*5461*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5462*/
	} break;
		/*5463*/
	case CefPrintSettings_SetCopies_20: {
		/*5464*/


		// gen! void SetCopies(int copies)
		me->SetCopies(v1->i32);
		/*5465*/

		/*5466*/
	} break;
		/*5467*/
	case CefPrintSettings_GetCopies_21: {
		/*5468*/


		// gen! int GetCopies()
		auto ret_result = me->GetCopies();
		/*5469*/
		MyCefSetInt64(ret, ret_result);
		/*5470*/
	} break;
		/*5471*/
	case CefPrintSettings_SetDuplexMode_22: {
		/*5472*/


		// gen! void SetDuplexMode(DuplexMode mode)
		me->SetDuplexMode((CefPrintSettings::DuplexMode)v1->i32);
		/*5473*/

		/*5474*/
	} break;
		/*5475*/
	case CefPrintSettings_GetDuplexMode_23: {
		/*5476*/


		// gen! DuplexMode GetDuplexMode()
		auto ret_result = me->GetDuplexMode();
		/*5477*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5478*/
	} break;
		/*5479*/
	}
	/*5480*/
	CefPrintSettingsCToCpp::Unwrap(me);
	/*5481*/
}


// [virtual] class CefProcessMessage
/*5682*/
/*5677*/
const int CefProcessMessage_IsValid_1 = 1;
/*5678*/
const int CefProcessMessage_IsReadOnly_2 = 2;
/*5679*/
const int CefProcessMessage_Copy_3 = 3;
/*5680*/
const int CefProcessMessage_GetName_4 = 4;
/*5681*/
const int CefProcessMessage_GetArgumentList_5 = 5;

void MyCefMet_CefProcessMessage(cef_process_message_t* me1, int metName, jsvalue* ret) {
	/*5683*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*5684*/
	auto me = CefProcessMessageCToCpp::Wrap(me1);
	/*5685*/
	switch (metName) {
		/*5686*/
	case MET_Release:return; //yes, just return
							 /*5687*/
	case CefProcessMessage_IsValid_1: {
		/*5688*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*5689*/
		MyCefSetBool(ret, ret_result);
		/*5690*/
	} break;
		/*5691*/
	case CefProcessMessage_IsReadOnly_2: {
		/*5692*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*5693*/
		MyCefSetBool(ret, ret_result);
		/*5694*/
	} break;
		/*5695*/
	case CefProcessMessage_Copy_3: {
		/*5696*/


		// gen! CefRefPtr<CefProcessMessage> Copy()
		auto ret_result = me->Copy();
		/*5697*/
		MyCefSetVoidPtr(ret, CefProcessMessageCToCpp::Unwrap(ret_result));
		/*5698*/
	} break;
		/*5699*/
	case CefProcessMessage_GetName_4: {
		/*5700*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*5701*/
		SetCefStringToJsValue(ret, ret_result);
		/*5702*/
	} break;
		/*5703*/
	case CefProcessMessage_GetArgumentList_5: {
		/*5704*/


		// gen! CefRefPtr<CefListValue> GetArgumentList()
		auto ret_result = me->GetArgumentList();
		/*5705*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*5706*/
	} break;
		/*5707*/
	}
	/*5708*/
	CefProcessMessageCToCpp::Unwrap(me);
	/*5709*/
}


// [virtual] class CefRequest
/*5777*/
/*5757*/
const int CefRequest_IsReadOnly_1 = 1;
/*5758*/
const int CefRequest_GetURL_2 = 2;
/*5759*/
const int CefRequest_SetURL_3 = 3;
/*5760*/
const int CefRequest_GetMethod_4 = 4;
/*5761*/
const int CefRequest_SetMethod_5 = 5;
/*5762*/
const int CefRequest_SetReferrer_6 = 6;
/*5763*/
const int CefRequest_GetReferrerURL_7 = 7;
/*5764*/
const int CefRequest_GetReferrerPolicy_8 = 8;
/*5765*/
const int CefRequest_GetPostData_9 = 9;
/*5766*/
const int CefRequest_SetPostData_10 = 10;
/*5767*/
const int CefRequest_GetHeaderMap_11 = 11;
/*5768*/
const int CefRequest_SetHeaderMap_12 = 12;
/*5769*/
const int CefRequest_Set_13 = 13;
/*5770*/
const int CefRequest_GetFlags_14 = 14;
/*5771*/
const int CefRequest_SetFlags_15 = 15;
/*5772*/
const int CefRequest_GetFirstPartyForCookies_16 = 16;
/*5773*/
const int CefRequest_SetFirstPartyForCookies_17 = 17;
/*5774*/
const int CefRequest_GetResourceType_18 = 18;
/*5775*/
const int CefRequest_GetTransitionType_19 = 19;
/*5776*/
const int CefRequest_GetIdentifier_20 = 20;

void MyCefMet_CefRequest(cef_request_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	/*5778*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*5779*/
	auto me = CefRequestCToCpp::Wrap(me1);
	/*5780*/
	switch (metName) {
		/*5781*/
	case MET_Release:return; //yes, just return
							 /*5782*/
	case CefRequest_IsReadOnly_1: {
		/*5783*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*5784*/
		MyCefSetBool(ret, ret_result);
		/*5785*/
	} break;
		/*5786*/
	case CefRequest_GetURL_2: {
		/*5787*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*5788*/
		SetCefStringToJsValue(ret, ret_result);
		/*5789*/
	} break;
		/*5790*/
	case CefRequest_SetURL_3: {
		/*5791*/


		// gen! void SetURL(const CefString& url)
		me->SetURL(GetStringHolder(v1)->value);
		/*5792*/

		/*5793*/
	} break;
		/*5794*/
	case CefRequest_GetMethod_4: {
		/*5795*/


		// gen! CefString GetMethod()
		auto ret_result = me->GetMethod();
		/*5796*/
		SetCefStringToJsValue(ret, ret_result);
		/*5797*/
	} break;
		/*5798*/
	case CefRequest_SetMethod_5: {
		/*5799*/


		// gen! void SetMethod(const CefString& method)
		me->SetMethod(GetStringHolder(v1)->value);
		/*5800*/

		/*5801*/
	} break;
		/*5802*/
	case CefRequest_SetReferrer_6: {
		/*5803*/


		// gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
		me->SetReferrer(GetStringHolder(v1)->value,
			(CefRequest::ReferrerPolicy)v2->i32);
		/*5804*/

		/*5805*/
	} break;
		/*5806*/
	case CefRequest_GetReferrerURL_7: {
		/*5807*/


		// gen! CefString GetReferrerURL()
		auto ret_result = me->GetReferrerURL();
		/*5808*/
		SetCefStringToJsValue(ret, ret_result);
		/*5809*/
	} break;
		/*5810*/
	case CefRequest_GetReferrerPolicy_8: {
		/*5811*/


		// gen! ReferrerPolicy GetReferrerPolicy()
		auto ret_result = me->GetReferrerPolicy();
		/*5812*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5813*/
	} break;
		/*5814*/
	case CefRequest_GetPostData_9: {
		/*5815*/


		// gen! CefRefPtr<CefPostData> GetPostData()
		auto ret_result = me->GetPostData();
		/*5816*/
		MyCefSetVoidPtr(ret, CefPostDataCToCpp::Unwrap(ret_result));
		/*5817*/
	} break;
		/*5818*/
	case CefRequest_SetPostData_10: {
		/*5819*/


		// gen! void SetPostData(CefRefPtr<CefPostData> postData)
		me->SetPostData(CefPostDataCToCpp::Wrap((cef_post_data_t*)v1->ptr));
		/*5820*/

		/*5821*/
	} break;
		/*5822*/
	case CefRequest_GetHeaderMap_11: {
		/*5823*/


		// gen! void GetHeaderMap(HeaderMap& headerMap)
		me->GetHeaderMap(*((CefRequest::HeaderMap*)v1->ptr));
		/*5824*/

		/*5825*/
	} break;
		/*5826*/
	case CefRequest_SetHeaderMap_12: {
		/*5827*/


		// gen! void SetHeaderMap(const HeaderMap& headerMap)
		me->SetHeaderMap(*((CefRequest::HeaderMap*)v1->ptr));
		/*5828*/

		/*5829*/
	} break;
		/*5830*/
	case CefRequest_Set_13: {
		/*5831*/


		// gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
		me->Set(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefPostDataCToCpp::Wrap((cef_post_data_t*)v3->ptr),
			*((CefRequest::HeaderMap*)v4->ptr));
		/*5832*/

		/*5833*/
	} break;
		/*5834*/
	case CefRequest_GetFlags_14: {
		/*5835*/


		// gen! int GetFlags()
		auto ret_result = me->GetFlags();
		/*5836*/
		MyCefSetInt64(ret, ret_result);
		/*5837*/
	} break;
		/*5838*/
	case CefRequest_SetFlags_15: {
		/*5839*/


		// gen! void SetFlags(int flags)
		me->SetFlags(v1->i32);
		/*5840*/

		/*5841*/
	} break;
		/*5842*/
	case CefRequest_GetFirstPartyForCookies_16: {
		/*5843*/


		// gen! CefString GetFirstPartyForCookies()
		auto ret_result = me->GetFirstPartyForCookies();
		/*5844*/
		SetCefStringToJsValue(ret, ret_result);
		/*5845*/
	} break;
		/*5846*/
	case CefRequest_SetFirstPartyForCookies_17: {
		/*5847*/


		// gen! void SetFirstPartyForCookies(const CefString& url)
		me->SetFirstPartyForCookies(GetStringHolder(v1)->value);
		/*5848*/

		/*5849*/
	} break;
		/*5850*/
	case CefRequest_GetResourceType_18: {
		/*5851*/


		// gen! ResourceType GetResourceType()
		auto ret_result = me->GetResourceType();
		/*5852*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5853*/
	} break;
		/*5854*/
	case CefRequest_GetTransitionType_19: {
		/*5855*/


		// gen! TransitionType GetTransitionType()
		auto ret_result = me->GetTransitionType();
		/*5856*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*5857*/
	} break;
		/*5858*/
	case CefRequest_GetIdentifier_20: {
		/*5859*/


		// gen! uint64 GetIdentifier()
		auto ret_result = me->GetIdentifier();
		/*5860*/
		MyCefSetUInt64(ret, ret_result);
		/*5861*/
	} break;
		/*5862*/
	}
	/*5863*/
	CefRequestCToCpp::Unwrap(me);
	/*5864*/
}


// [virtual] class CefPostData
/*6055*/
/*6048*/
const int CefPostData_IsReadOnly_1 = 1;
/*6049*/
const int CefPostData_HasExcludedElements_2 = 2;
/*6050*/
const int CefPostData_GetElementCount_3 = 3;
/*6051*/
const int CefPostData_GetElements_4 = 4;
/*6052*/
const int CefPostData_RemoveElement_5 = 5;
/*6053*/
const int CefPostData_AddElement_6 = 6;
/*6054*/
const int CefPostData_RemoveElements_7 = 7;

void MyCefMet_CefPostData(cef_post_data_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*6056*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6057*/
	auto me = CefPostDataCToCpp::Wrap(me1);
	/*6058*/
	switch (metName) {
		/*6059*/
	case MET_Release:return; //yes, just return
							 /*6060*/
	case CefPostData_IsReadOnly_1: {
		/*6061*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*6062*/
		MyCefSetBool(ret, ret_result);
		/*6063*/
	} break;
		/*6064*/
	case CefPostData_HasExcludedElements_2: {
		/*6065*/


		// gen! bool HasExcludedElements()
		auto ret_result = me->HasExcludedElements();
		/*6066*/
		MyCefSetBool(ret, ret_result);
		/*6067*/
	} break;
		/*6068*/
	case CefPostData_GetElementCount_3: {
		/*6069*/


		// gen! size_t GetElementCount()
		auto ret_result = me->GetElementCount();
		/*6070*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6071*/
	} break;
		/*6072*/
	case CefPostData_GetElements_4: {
		/*6073*/


		// gen! void GetElements(ElementVector& elements)
		me->GetElements(*((CefPostData::ElementVector*)v1->ptr));
		/*6074*/

		/*6075*/
	} break;
		/*6076*/
	case CefPostData_RemoveElement_5: {
		/*6077*/


		// gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
		auto ret_result = me->RemoveElement(CefPostDataElementCToCpp::Wrap((cef_post_data_element_t*)v1->ptr));
		/*6078*/
		MyCefSetBool(ret, ret_result);
		/*6079*/
	} break;
		/*6080*/
	case CefPostData_AddElement_6: {
		/*6081*/


		// gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
		auto ret_result = me->AddElement(CefPostDataElementCToCpp::Wrap((cef_post_data_element_t*)v1->ptr));
		/*6082*/
		MyCefSetBool(ret, ret_result);
		/*6083*/
	} break;
		/*6084*/
	case CefPostData_RemoveElements_7: {
		/*6085*/


		// gen! void RemoveElements()
		me->RemoveElements();
		/*6086*/

		/*6087*/
	} break;
		/*6088*/
	}
	/*6089*/
	CefPostDataCToCpp::Unwrap(me);
	/*6090*/
}


// [virtual] class CefPostDataElement
/*6163*/
/*6155*/
const int CefPostDataElement_IsReadOnly_1 = 1;
/*6156*/
const int CefPostDataElement_SetToEmpty_2 = 2;
/*6157*/
const int CefPostDataElement_SetToFile_3 = 3;
/*6158*/
const int CefPostDataElement_SetToBytes_4 = 4;
/*6159*/
const int CefPostDataElement_GetType_5 = 5;
/*6160*/
const int CefPostDataElement_GetFile_6 = 6;
/*6161*/
const int CefPostDataElement_GetBytesCount_7 = 7;
/*6162*/
const int CefPostDataElement_GetBytes_8 = 8;

void MyCefMet_CefPostDataElement(cef_post_data_element_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*6164*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6165*/
	auto me = CefPostDataElementCToCpp::Wrap(me1);
	/*6166*/
	switch (metName) {
		/*6167*/
	case MET_Release:return; //yes, just return
							 /*6168*/
	case CefPostDataElement_IsReadOnly_1: {
		/*6169*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*6170*/
		MyCefSetBool(ret, ret_result);
		/*6171*/
	} break;
		/*6172*/
	case CefPostDataElement_SetToEmpty_2: {
		/*6173*/


		// gen! void SetToEmpty()
		me->SetToEmpty();
		/*6174*/

		/*6175*/
	} break;
		/*6176*/
	case CefPostDataElement_SetToFile_3: {
		/*6177*/


		// gen! void SetToFile(const CefString& fileName)
		me->SetToFile(GetStringHolder(v1)->value);
		/*6178*/

		/*6179*/
	} break;
		/*6180*/
	case CefPostDataElement_SetToBytes_4: {
		/*6181*/


		// gen! void SetToBytes(size_t size,const void* bytes)
		me->SetToBytes(v1->i64,
			(void*)v2->ptr);
		/*6182*/

		/*6183*/
	} break;
		/*6184*/
	case CefPostDataElement_GetType_5: {
		/*6185*/


		// gen! Type GetType()
		auto ret_result = me->GetType();
		/*6186*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6187*/
	} break;
		/*6188*/
	case CefPostDataElement_GetFile_6: {
		/*6189*/


		// gen! CefString GetFile()
		auto ret_result = me->GetFile();
		/*6190*/
		SetCefStringToJsValue(ret, ret_result);
		/*6191*/
	} break;
		/*6192*/
	case CefPostDataElement_GetBytesCount_7: {
		/*6193*/


		// gen! size_t GetBytesCount()
		auto ret_result = me->GetBytesCount();
		/*6194*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6195*/
	} break;
		/*6196*/
	case CefPostDataElement_GetBytes_8: {
		/*6197*/


		// gen! size_t GetBytes(size_t size,void* bytes)
		auto ret_result = me->GetBytes(v1->i64,
			(void*)v2->ptr);
		/*6198*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6199*/
	} break;
		/*6200*/
	}
	/*6201*/
	CefPostDataElementCToCpp::Unwrap(me);
	/*6202*/
}


// [virtual] class CefRequestContext
/*6296*/
/*6278*/
const int CefRequestContext_IsSame_1 = 1;
/*6279*/
const int CefRequestContext_IsSharingWith_2 = 2;
/*6280*/
const int CefRequestContext_IsGlobal_3 = 3;
/*6281*/
const int CefRequestContext_GetHandler_4 = 4;
/*6282*/
const int CefRequestContext_GetCachePath_5 = 5;
/*6283*/
const int CefRequestContext_GetDefaultCookieManager_6 = 6;
/*6284*/
const int CefRequestContext_RegisterSchemeHandlerFactory_7 = 7;
/*6285*/
const int CefRequestContext_ClearSchemeHandlerFactories_8 = 8;
/*6286*/
const int CefRequestContext_PurgePluginListCache_9 = 9;
/*6287*/
const int CefRequestContext_HasPreference_10 = 10;
/*6288*/
const int CefRequestContext_GetPreference_11 = 11;
/*6289*/
const int CefRequestContext_GetAllPreferences_12 = 12;
/*6290*/
const int CefRequestContext_CanSetPreference_13 = 13;
/*6291*/
const int CefRequestContext_SetPreference_14 = 14;
/*6292*/
const int CefRequestContext_ClearCertificateExceptions_15 = 15;
/*6293*/
const int CefRequestContext_CloseAllConnections_16 = 16;
/*6294*/
const int CefRequestContext_ResolveHost_17 = 17;
/*6295*/
const int CefRequestContext_ResolveHostCached_18 = 18;

void MyCefMet_CefRequestContext(cef_request_context_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*6297*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6298*/
	auto me = CefRequestContextCToCpp::Wrap(me1);
	/*6299*/
	switch (metName) {
		/*6300*/
	case MET_Release:return; //yes, just return
							 /*6301*/
	case CefRequestContext_IsSame_1: {
		/*6302*/


		// gen! bool IsSame(CefRefPtr<CefRequestContext> other)
		auto ret_result = me->IsSame(CefRequestContextCToCpp::Wrap((cef_request_context_t*)v1->ptr));
		/*6303*/
		MyCefSetBool(ret, ret_result);
		/*6304*/
	} break;
		/*6305*/
	case CefRequestContext_IsSharingWith_2: {
		/*6306*/


		// gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
		auto ret_result = me->IsSharingWith(CefRequestContextCToCpp::Wrap((cef_request_context_t*)v1->ptr));
		/*6307*/
		MyCefSetBool(ret, ret_result);
		/*6308*/
	} break;
		/*6309*/
	case CefRequestContext_IsGlobal_3: {
		/*6310*/


		// gen! bool IsGlobal()
		auto ret_result = me->IsGlobal();
		/*6311*/
		MyCefSetBool(ret, ret_result);
		/*6312*/
	} break;
		/*6313*/
	case CefRequestContext_GetHandler_4: {
		/*6314*/


		// gen! CefRefPtr<CefRequestContextHandler> GetHandler()
		auto ret_result = me->GetHandler();
		/*6315*/
		MyCefSetVoidPtr(ret, CefRequestContextHandlerCppToC::Wrap(ret_result));
		/*6316*/
	} break;
		/*6317*/
	case CefRequestContext_GetCachePath_5: {
		/*6318*/


		// gen! CefString GetCachePath()
		auto ret_result = me->GetCachePath();
		/*6319*/
		SetCefStringToJsValue(ret, ret_result);
		/*6320*/
	} break;
		/*6321*/
	case CefRequestContext_GetDefaultCookieManager_6: {
		/*6322*/


		// gen! CefRefPtr<CefCookieManager> GetDefaultCookieManager(CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->GetDefaultCookieManager(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*6323*/
		MyCefSetVoidPtr(ret, CefCookieManagerCToCpp::Unwrap(ret_result));
		/*6324*/
	} break;
		/*6325*/
	case CefRequestContext_RegisterSchemeHandlerFactory_7: {
		/*6326*/


		// gen! bool RegisterSchemeHandlerFactory(const CefString& scheme_name,const CefString& domain_name,CefRefPtr<CefSchemeHandlerFactory> factory)
		auto ret_result = me->RegisterSchemeHandlerFactory(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefSchemeHandlerFactoryCppToC::Unwrap((cef_scheme_handler_factory_t*)v3->ptr));
		/*6327*/
		MyCefSetBool(ret, ret_result);
		/*6328*/
	} break;
		/*6329*/
	case CefRequestContext_ClearSchemeHandlerFactories_8: {
		/*6330*/


		// gen! bool ClearSchemeHandlerFactories()
		auto ret_result = me->ClearSchemeHandlerFactories();
		/*6331*/
		MyCefSetBool(ret, ret_result);
		/*6332*/
	} break;
		/*6333*/
	case CefRequestContext_PurgePluginListCache_9: {
		/*6334*/


		// gen! void PurgePluginListCache(bool reload_pages)
		me->PurgePluginListCache(v1->i32 != 0);
		/*6335*/

		/*6336*/
	} break;
		/*6337*/
	case CefRequestContext_HasPreference_10: {
		/*6338*/


		// gen! bool HasPreference(const CefString& name)
		auto ret_result = me->HasPreference(GetStringHolder(v1)->value);
		/*6339*/
		MyCefSetBool(ret, ret_result);
		/*6340*/
	} break;
		/*6341*/
	case CefRequestContext_GetPreference_11: {
		/*6342*/


		// gen! CefRefPtr<CefValue> GetPreference(const CefString& name)
		auto ret_result = me->GetPreference(GetStringHolder(v1)->value);
		/*6343*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*6344*/
	} break;
		/*6345*/
	case CefRequestContext_GetAllPreferences_12: {
		/*6346*/


		// gen! CefRefPtr<CefDictionaryValue> GetAllPreferences(bool include_defaults)
		auto ret_result = me->GetAllPreferences(v1->i32 != 0);
		/*6347*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*6348*/
	} break;
		/*6349*/
	case CefRequestContext_CanSetPreference_13: {
		/*6350*/


		// gen! bool CanSetPreference(const CefString& name)
		auto ret_result = me->CanSetPreference(GetStringHolder(v1)->value);
		/*6351*/
		MyCefSetBool(ret, ret_result);
		/*6352*/
	} break;
		/*6353*/
	case CefRequestContext_SetPreference_14: {
		/*6354*/


		// gen! bool SetPreference(const CefString& name,CefRefPtr<CefValue> value,CefString& error)
		auto ret_result = me->SetPreference(GetStringHolder(v1)->value,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr),
			GetStringHolder(v3)->value);
		/*6355*/
		MyCefSetBool(ret, ret_result);
		/*6356*/
	} break;
		/*6357*/
	case CefRequestContext_ClearCertificateExceptions_15: {
		/*6358*/


		// gen! void ClearCertificateExceptions(CefRefPtr<CefCompletionCallback> callback)
		me->ClearCertificateExceptions(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*6359*/

		/*6360*/
	} break;
		/*6361*/
	case CefRequestContext_CloseAllConnections_16: {
		/*6362*/


		// gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
		me->CloseAllConnections(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*6363*/

		/*6364*/
	} break;
		/*6365*/
	case CefRequestContext_ResolveHost_17: {
		/*6366*/


		// gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
		me->ResolveHost(GetStringHolder(v1)->value,
			CefResolveCallbackCppToC::Unwrap((cef_resolve_callback_t*)v2->ptr));
		/*6367*/

		/*6368*/
	} break;
		/*6369*/
	case CefRequestContext_ResolveHostCached_18: {
		/*6370*/


		// gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
		auto ret_result = me->ResolveHostCached(GetStringHolder(v1)->value,
			*((std::vector<CefString>*)v2->ptr));
		/*6371*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6372*/
	} break;
		/*6373*/
	}
	/*6374*/
	CefRequestContextCToCpp::Unwrap(me);
	/*6375*/
}


// [virtual] class CefResourceBundle
/*6564*/
/*6561*/
const int CefResourceBundle_GetLocalizedString_1 = 1;
/*6562*/
const int CefResourceBundle_GetDataResource_2 = 2;
/*6563*/
const int CefResourceBundle_GetDataResourceForScale_3 = 3;

void MyCefMet_CefResourceBundle(cef_resource_bundle_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4) {
	/*6565*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6566*/
	auto me = CefResourceBundleCToCpp::Wrap(me1);
	/*6567*/
	switch (metName) {
		/*6568*/
	case MET_Release:return; //yes, just return
							 /*6569*/
	case CefResourceBundle_GetLocalizedString_1: {
		/*6570*/


		// gen! CefString GetLocalizedString(int string_id)
		auto ret_result = me->GetLocalizedString(v1->i32);
		/*6571*/
		SetCefStringToJsValue(ret, ret_result);
		/*6572*/
	} break;
		/*6573*/
	case CefResourceBundle_GetDataResource_2: {
		/*6574*/


		// gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
		auto ret_result = me->GetDataResource(v1->i32,
			*((void**)v2->ptr),
			*((size_t*)v3->ptr));
		/*6575*/
		MyCefSetBool(ret, ret_result);
		/*6576*/
	} break;
		/*6577*/
	case CefResourceBundle_GetDataResourceForScale_3: {
		/*6578*/


		// gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
		auto ret_result = me->GetDataResourceForScale(v1->i32,
			(CefResourceBundle::ScaleFactor)v2->i32,
			*((void**)v3->ptr),
			*((size_t*)v4->ptr));
		/*6579*/
		MyCefSetBool(ret, ret_result);
		/*6580*/
	} break;
		/*6581*/
	}
	/*6582*/
	CefResourceBundleCToCpp::Unwrap(me);
	/*6583*/
}


// [virtual] class CefResponse
/*6639*/
/*6627*/
const int CefResponse_IsReadOnly_1 = 1;
/*6628*/
const int CefResponse_GetError_2 = 2;
/*6629*/
const int CefResponse_SetError_3 = 3;
/*6630*/
const int CefResponse_GetStatus_4 = 4;
/*6631*/
const int CefResponse_SetStatus_5 = 5;
/*6632*/
const int CefResponse_GetStatusText_6 = 6;
/*6633*/
const int CefResponse_SetStatusText_7 = 7;
/*6634*/
const int CefResponse_GetMimeType_8 = 8;
/*6635*/
const int CefResponse_SetMimeType_9 = 9;
/*6636*/
const int CefResponse_GetHeader_10 = 10;
/*6637*/
const int CefResponse_GetHeaderMap_11 = 11;
/*6638*/
const int CefResponse_SetHeaderMap_12 = 12;

void MyCefMet_CefResponse(cef_response_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*6640*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6641*/
	auto me = CefResponseCToCpp::Wrap(me1);
	/*6642*/
	switch (metName) {
		/*6643*/
	case MET_Release:return; //yes, just return
							 /*6644*/
	case CefResponse_IsReadOnly_1: {
		/*6645*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*6646*/
		MyCefSetBool(ret, ret_result);
		/*6647*/
	} break;
		/*6648*/
	case CefResponse_GetError_2: {
		/*6649*/


		// gen! cef_errorcode_t GetError()
		auto ret_result = me->GetError();
		/*6650*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6651*/
	} break;
		/*6652*/
	case CefResponse_SetError_3: {
		/*6653*/


		// gen! void SetError(cef_errorcode_t error)
		me->SetError((cef_errorcode_t)v1->i32);
		/*6654*/

		/*6655*/
	} break;
		/*6656*/
	case CefResponse_GetStatus_4: {
		/*6657*/


		// gen! int GetStatus()
		auto ret_result = me->GetStatus();
		/*6658*/
		MyCefSetInt64(ret, ret_result);
		/*6659*/
	} break;
		/*6660*/
	case CefResponse_SetStatus_5: {
		/*6661*/


		// gen! void SetStatus(int status)
		me->SetStatus(v1->i32);
		/*6662*/

		/*6663*/
	} break;
		/*6664*/
	case CefResponse_GetStatusText_6: {
		/*6665*/


		// gen! CefString GetStatusText()
		auto ret_result = me->GetStatusText();
		/*6666*/
		SetCefStringToJsValue(ret, ret_result);
		/*6667*/
	} break;
		/*6668*/
	case CefResponse_SetStatusText_7: {
		/*6669*/


		// gen! void SetStatusText(const CefString& statusText)
		me->SetStatusText(GetStringHolder(v1)->value);
		/*6670*/

		/*6671*/
	} break;
		/*6672*/
	case CefResponse_GetMimeType_8: {
		/*6673*/


		// gen! CefString GetMimeType()
		auto ret_result = me->GetMimeType();
		/*6674*/
		SetCefStringToJsValue(ret, ret_result);
		/*6675*/
	} break;
		/*6676*/
	case CefResponse_SetMimeType_9: {
		/*6677*/


		// gen! void SetMimeType(const CefString& mimeType)
		me->SetMimeType(GetStringHolder(v1)->value);
		/*6678*/

		/*6679*/
	} break;
		/*6680*/
	case CefResponse_GetHeader_10: {
		/*6681*/


		// gen! CefString GetHeader(const CefString& name)
		auto ret_result = me->GetHeader(GetStringHolder(v1)->value);
		/*6682*/
		SetCefStringToJsValue(ret, ret_result);
		/*6683*/
	} break;
		/*6684*/
	case CefResponse_GetHeaderMap_11: {
		/*6685*/


		// gen! void GetHeaderMap(HeaderMap& headerMap)
		me->GetHeaderMap(*((CefResponse::HeaderMap*)v1->ptr));
		/*6686*/

		/*6687*/
	} break;
		/*6688*/
	case CefResponse_SetHeaderMap_12: {
		/*6689*/


		// gen! void SetHeaderMap(const HeaderMap& headerMap)
		me->SetHeaderMap(*((CefResponse::HeaderMap*)v1->ptr));
		/*6690*/

		/*6691*/
	} break;
		/*6692*/
	}
	/*6693*/
	CefResponseCToCpp::Unwrap(me);
	/*6694*/
}


// [virtual] class CefResponseFilter
/*6805*/

void MyCefMet_CefResponseFilter(cef_response_filter_t* me1, int metName, jsvalue* ret) {
	/*6806*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6807*/
	auto me = CefResponseFilterCppToC::Unwrap(me1);
	/*6808*/
	switch (metName) {
		/*6809*/
	case MET_Release:return; //yes, just return
							 /*6810*/
	}
	/*6811*/
	CefResponseFilterCppToC::Wrap(me);
	/*6812*/
}


// [virtual] class CefSchemeHandlerFactory
/*6820*/

void MyCefMet_CefSchemeHandlerFactory(cef_scheme_handler_factory_t* me1, int metName, jsvalue* ret) {
	/*6821*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6822*/
	auto me = CefSchemeHandlerFactoryCppToC::Unwrap(me1);
	/*6823*/
	switch (metName) {
		/*6824*/
	case MET_Release:return; //yes, just return
							 /*6825*/
	}
	/*6826*/
	CefSchemeHandlerFactoryCppToC::Wrap(me);
	/*6827*/
}


// [virtual] class CefSSLInfo
/*6837*/
/*6835*/
const int CefSSLInfo_GetCertStatus_1 = 1;
/*6836*/
const int CefSSLInfo_GetX509Certificate_2 = 2;

void MyCefMet_CefSSLInfo(cef_sslinfo_t* me1, int metName, jsvalue* ret) {
	/*6838*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6839*/
	auto me = CefSSLInfoCToCpp::Wrap(me1);
	/*6840*/
	switch (metName) {
		/*6841*/
	case MET_Release:return; //yes, just return
							 /*6842*/
	case CefSSLInfo_GetCertStatus_1: {
		/*6843*/


		// gen! cef_cert_status_t GetCertStatus()
		auto ret_result = me->GetCertStatus();
		/*6844*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6845*/
	} break;
		/*6846*/
	case CefSSLInfo_GetX509Certificate_2: {
		/*6847*/


		// gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
		auto ret_result = me->GetX509Certificate();
		/*6848*/
		MyCefSetVoidPtr(ret, CefX509CertificateCToCpp::Unwrap(ret_result));
		/*6849*/
	} break;
		/*6850*/
	}
	/*6851*/
	CefSSLInfoCToCpp::Unwrap(me);
	/*6852*/
}


// [virtual] class CefSSLStatus
/*6881*/
/*6876*/
const int CefSSLStatus_IsSecureConnection_1 = 1;
/*6877*/
const int CefSSLStatus_GetCertStatus_2 = 2;
/*6878*/
const int CefSSLStatus_GetSSLVersion_3 = 3;
/*6879*/
const int CefSSLStatus_GetContentStatus_4 = 4;
/*6880*/
const int CefSSLStatus_GetX509Certificate_5 = 5;

void MyCefMet_CefSSLStatus(cef_sslstatus_t* me1, int metName, jsvalue* ret) {
	/*6882*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6883*/
	auto me = CefSSLStatusCToCpp::Wrap(me1);
	/*6884*/
	switch (metName) {
		/*6885*/
	case MET_Release:return; //yes, just return
							 /*6886*/
	case CefSSLStatus_IsSecureConnection_1: {
		/*6887*/


		// gen! bool IsSecureConnection()
		auto ret_result = me->IsSecureConnection();
		/*6888*/
		MyCefSetBool(ret, ret_result);
		/*6889*/
	} break;
		/*6890*/
	case CefSSLStatus_GetCertStatus_2: {
		/*6891*/


		// gen! cef_cert_status_t GetCertStatus()
		auto ret_result = me->GetCertStatus();
		/*6892*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6893*/
	} break;
		/*6894*/
	case CefSSLStatus_GetSSLVersion_3: {
		/*6895*/


		// gen! cef_ssl_version_t GetSSLVersion()
		auto ret_result = me->GetSSLVersion();
		/*6896*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6897*/
	} break;
		/*6898*/
	case CefSSLStatus_GetContentStatus_4: {
		/*6899*/


		// gen! cef_ssl_content_status_t GetContentStatus()
		auto ret_result = me->GetContentStatus();
		/*6900*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6901*/
	} break;
		/*6902*/
	case CefSSLStatus_GetX509Certificate_5: {
		/*6903*/


		// gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
		auto ret_result = me->GetX509Certificate();
		/*6904*/
		MyCefSetVoidPtr(ret, CefX509CertificateCToCpp::Unwrap(ret_result));
		/*6905*/
	} break;
		/*6906*/
	}
	/*6907*/
	CefSSLStatusCToCpp::Unwrap(me);
	/*6908*/
}


// [virtual] class CefStreamReader
/*6961*/
/*6956*/
const int CefStreamReader_Read_1 = 1;
/*6957*/
const int CefStreamReader_Seek_2 = 2;
/*6958*/
const int CefStreamReader_Tell_3 = 3;
/*6959*/
const int CefStreamReader_Eof_4 = 4;
/*6960*/
const int CefStreamReader_MayBlock_5 = 5;

void MyCefMet_CefStreamReader(cef_stream_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*6962*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*6963*/
	auto me = CefStreamReaderCToCpp::Wrap(me1);
	/*6964*/
	switch (metName) {
		/*6965*/
	case MET_Release:return; //yes, just return
							 /*6966*/
	case CefStreamReader_Read_1: {
		/*6967*/


		// gen! size_t Read(void* ptr,size_t size,size_t n)
		auto ret_result = me->Read((void*)v1->ptr,
			v2->i64,
			v3->i64);
		/*6968*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*6969*/
	} break;
		/*6970*/
	case CefStreamReader_Seek_2: {
		/*6971*/


		// gen! int Seek(int64 offset,int whence)
		auto ret_result = me->Seek(v1->i64,
			v2->i32);
		/*6972*/
		MyCefSetInt64(ret, ret_result);
		/*6973*/
	} break;
		/*6974*/
	case CefStreamReader_Tell_3: {
		/*6975*/


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		/*6976*/
		MyCefSetInt64(ret, ret_result);
		/*6977*/
	} break;
		/*6978*/
	case CefStreamReader_Eof_4: {
		/*6979*/


		// gen! int Eof()
		auto ret_result = me->Eof();
		/*6980*/
		MyCefSetInt64(ret, ret_result);
		/*6981*/
	} break;
		/*6982*/
	case CefStreamReader_MayBlock_5: {
		/*6983*/


		// gen! bool MayBlock()
		auto ret_result = me->MayBlock();
		/*6984*/
		MyCefSetBool(ret, ret_result);
		/*6985*/
	} break;
		/*6986*/
	}
	/*6987*/
	CefStreamReaderCToCpp::Unwrap(me);
	/*6988*/
}


// [virtual] class CefStreamWriter
/*7046*/
/*7041*/
const int CefStreamWriter_Write_1 = 1;
/*7042*/
const int CefStreamWriter_Seek_2 = 2;
/*7043*/
const int CefStreamWriter_Tell_3 = 3;
/*7044*/
const int CefStreamWriter_Flush_4 = 4;
/*7045*/
const int CefStreamWriter_MayBlock_5 = 5;

void MyCefMet_CefStreamWriter(cef_stream_writer_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*7047*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7048*/
	auto me = CefStreamWriterCToCpp::Wrap(me1);
	/*7049*/
	switch (metName) {
		/*7050*/
	case MET_Release:return; //yes, just return
							 /*7051*/
	case CefStreamWriter_Write_1: {
		/*7052*/


		// gen! size_t Write(const void* ptr,size_t size,size_t n)
		auto ret_result = me->Write((void*)v1->ptr,
			v2->i64,
			v3->i64);
		/*7053*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*7054*/
	} break;
		/*7055*/
	case CefStreamWriter_Seek_2: {
		/*7056*/


		// gen! int Seek(int64 offset,int whence)
		auto ret_result = me->Seek(v1->i64,
			v2->i32);
		/*7057*/
		MyCefSetInt64(ret, ret_result);
		/*7058*/
	} break;
		/*7059*/
	case CefStreamWriter_Tell_3: {
		/*7060*/


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		/*7061*/
		MyCefSetInt64(ret, ret_result);
		/*7062*/
	} break;
		/*7063*/
	case CefStreamWriter_Flush_4: {
		/*7064*/


		// gen! int Flush()
		auto ret_result = me->Flush();
		/*7065*/
		MyCefSetInt64(ret, ret_result);
		/*7066*/
	} break;
		/*7067*/
	case CefStreamWriter_MayBlock_5: {
		/*7068*/


		// gen! bool MayBlock()
		auto ret_result = me->MayBlock();
		/*7069*/
		MyCefSetBool(ret, ret_result);
		/*7070*/
	} break;
		/*7071*/
	}
	/*7072*/
	CefStreamWriterCToCpp::Unwrap(me);
	/*7073*/
}


// [virtual] class CefStringVisitor
/*7126*/

void MyCefMet_CefStringVisitor(cef_string_visitor_t* me1, int metName, jsvalue* ret) {
	/*7127*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7128*/
	auto me = CefStringVisitorCppToC::Unwrap(me1);
	/*7129*/
	switch (metName) {
		/*7130*/
	case MET_Release:return; //yes, just return
							 /*7131*/
	}
	/*7132*/
	CefStringVisitorCppToC::Wrap(me);
	/*7133*/
}


// [virtual] class CefTask
/*7141*/

void MyCefMet_CefTask(cef_task_t* me1, int metName, jsvalue* ret) {
	/*7142*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7143*/
	auto me = CefTaskCppToC::Unwrap(me1);
	/*7144*/
	switch (metName) {
		/*7145*/
	case MET_Release:return; //yes, just return
							 /*7146*/
	}
	/*7147*/
	CefTaskCppToC::Wrap(me);
	/*7148*/
}


// [virtual] class CefTaskRunner
/*7161*/
/*7156*/
const int CefTaskRunner_IsSame_1 = 1;
/*7157*/
const int CefTaskRunner_BelongsToCurrentThread_2 = 2;
/*7158*/
const int CefTaskRunner_BelongsToThread_3 = 3;
/*7159*/
const int CefTaskRunner_PostTask_4 = 4;
/*7160*/
const int CefTaskRunner_PostDelayedTask_5 = 5;

void MyCefMet_CefTaskRunner(cef_task_runner_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*7162*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7163*/
	auto me = CefTaskRunnerCToCpp::Wrap(me1);
	/*7164*/
	switch (metName) {
		/*7165*/
	case MET_Release:return; //yes, just return
							 /*7166*/
	case CefTaskRunner_IsSame_1: {
		/*7167*/


		// gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
		auto ret_result = me->IsSame(CefTaskRunnerCToCpp::Wrap((cef_task_runner_t*)v1->ptr));
		/*7168*/
		MyCefSetBool(ret, ret_result);
		/*7169*/
	} break;
		/*7170*/
	case CefTaskRunner_BelongsToCurrentThread_2: {
		/*7171*/


		// gen! bool BelongsToCurrentThread()
		auto ret_result = me->BelongsToCurrentThread();
		/*7172*/
		MyCefSetBool(ret, ret_result);
		/*7173*/
	} break;
		/*7174*/
	case CefTaskRunner_BelongsToThread_3: {
		/*7175*/


		// gen! bool BelongsToThread(CefThreadId threadId)
		auto ret_result = me->BelongsToThread((CefThreadId)v1->i32);
		/*7176*/
		MyCefSetBool(ret, ret_result);
		/*7177*/
	} break;
		/*7178*/
	case CefTaskRunner_PostTask_4: {
		/*7179*/


		// gen! bool PostTask(CefRefPtr<CefTask> task)
		auto ret_result = me->PostTask(CefTaskCppToC::Unwrap((cef_task_t*)v1->ptr));
		/*7180*/
		MyCefSetBool(ret, ret_result);
		/*7181*/
	} break;
		/*7182*/
	case CefTaskRunner_PostDelayedTask_5: {
		/*7183*/


		// gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
		auto ret_result = me->PostDelayedTask(CefTaskCppToC::Unwrap((cef_task_t*)v1->ptr),
			v2->i64);
		/*7184*/
		MyCefSetBool(ret, ret_result);
		/*7185*/
	} break;
		/*7186*/
	}
	/*7187*/
	CefTaskRunnerCToCpp::Unwrap(me);
	/*7188*/
}


// [virtual] class CefURLRequest
/*7247*/
/*7241*/
const int CefURLRequest_GetRequest_1 = 1;
/*7242*/
const int CefURLRequest_GetClient_2 = 2;
/*7243*/
const int CefURLRequest_GetRequestStatus_3 = 3;
/*7244*/
const int CefURLRequest_GetRequestError_4 = 4;
/*7245*/
const int CefURLRequest_GetResponse_5 = 5;
/*7246*/
const int CefURLRequest_Cancel_6 = 6;

void MyCefMet_CefURLRequest(cef_urlrequest_t* me1, int metName, jsvalue* ret) {
	/*7248*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7249*/
	auto me = CefURLRequestCToCpp::Wrap(me1);
	/*7250*/
	switch (metName) {
		/*7251*/
	case MET_Release:return; //yes, just return
							 /*7252*/
	case CefURLRequest_GetRequest_1: {
		/*7253*/


		// gen! CefRefPtr<CefRequest> GetRequest()
		auto ret_result = me->GetRequest();
		/*7254*/
		MyCefSetVoidPtr(ret, CefRequestCToCpp::Unwrap(ret_result));
		/*7255*/
	} break;
		/*7256*/
	case CefURLRequest_GetClient_2: {
		/*7257*/


		// gen! CefRefPtr<CefURLRequestClient> GetClient()
		auto ret_result = me->GetClient();
		/*7258*/
		MyCefSetVoidPtr(ret, CefURLRequestClientCppToC::Wrap(ret_result));
		/*7259*/
	} break;
		/*7260*/
	case CefURLRequest_GetRequestStatus_3: {
		/*7261*/


		// gen! Status GetRequestStatus()
		auto ret_result = me->GetRequestStatus();
		/*7262*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*7263*/
	} break;
		/*7264*/
	case CefURLRequest_GetRequestError_4: {
		/*7265*/


		// gen! ErrorCode GetRequestError()
		auto ret_result = me->GetRequestError();
		/*7266*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*7267*/
	} break;
		/*7268*/
	case CefURLRequest_GetResponse_5: {
		/*7269*/


		// gen! CefRefPtr<CefResponse> GetResponse()
		auto ret_result = me->GetResponse();
		/*7270*/
		MyCefSetVoidPtr(ret, CefResponseCToCpp::Unwrap(ret_result));
		/*7271*/
	} break;
		/*7272*/
	case CefURLRequest_Cancel_6: {
		/*7273*/


		// gen! void Cancel()
		me->Cancel();
		/*7274*/

		/*7275*/
	} break;
		/*7276*/
	}
	/*7277*/
	CefURLRequestCToCpp::Unwrap(me);
	/*7278*/
}


// [virtual] class CefURLRequestClient
/*7333*/

void MyCefMet_CefURLRequestClient(cef_urlrequest_client_t* me1, int metName, jsvalue* ret) {
	/*7334*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7335*/
	auto me = CefURLRequestClientCppToC::Unwrap(me1);
	/*7336*/
	switch (metName) {
		/*7337*/
	case MET_Release:return; //yes, just return
							 /*7338*/
	}
	/*7339*/
	CefURLRequestClientCppToC::Wrap(me);
	/*7340*/
}


// [virtual] class CefV8Context
/*7357*/
/*7348*/
const int CefV8Context_GetTaskRunner_1 = 1;
/*7349*/
const int CefV8Context_IsValid_2 = 2;
/*7350*/
const int CefV8Context_GetBrowser_3 = 3;
/*7351*/
const int CefV8Context_GetFrame_4 = 4;
/*7352*/
const int CefV8Context_GetGlobal_5 = 5;
/*7353*/
const int CefV8Context_Enter_6 = 6;
/*7354*/
const int CefV8Context_Exit_7 = 7;
/*7355*/
const int CefV8Context_IsSame_8 = 8;
/*7356*/
const int CefV8Context_Eval_9 = 9;

void MyCefMet_CefV8Context(cef_v8context_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5) {
	/*7358*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7359*/
	auto me = CefV8ContextCToCpp::Wrap(me1);
	/*7360*/
	switch (metName) {
		/*7361*/
	case MET_Release:return; //yes, just return
							 /*7362*/
	case CefV8Context_GetTaskRunner_1: {
		/*7363*/


		// gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
		auto ret_result = me->GetTaskRunner();
		/*7364*/
		MyCefSetVoidPtr(ret, CefTaskRunnerCToCpp::Unwrap(ret_result));
		/*7365*/
	} break;
		/*7366*/
	case CefV8Context_IsValid_2: {
		/*7367*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*7368*/
		MyCefSetBool(ret, ret_result);
		/*7369*/
	} break;
		/*7370*/
	case CefV8Context_GetBrowser_3: {
		/*7371*/


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		/*7372*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*7373*/
	} break;
		/*7374*/
	case CefV8Context_GetFrame_4: {
		/*7375*/


		// gen! CefRefPtr<CefFrame> GetFrame()
		auto ret_result = me->GetFrame();
		/*7376*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*7377*/
	} break;
		/*7378*/
	case CefV8Context_GetGlobal_5: {
		/*7379*/


		// gen! CefRefPtr<CefV8Value> GetGlobal()
		auto ret_result = me->GetGlobal();
		/*7380*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*7381*/
	} break;
		/*7382*/
	case CefV8Context_Enter_6: {
		/*7383*/


		// gen! bool Enter()
		auto ret_result = me->Enter();
		/*7384*/
		MyCefSetBool(ret, ret_result);
		/*7385*/
	} break;
		/*7386*/
	case CefV8Context_Exit_7: {
		/*7387*/


		// gen! bool Exit()
		auto ret_result = me->Exit();
		/*7388*/
		MyCefSetBool(ret, ret_result);
		/*7389*/
	} break;
		/*7390*/
	case CefV8Context_IsSame_8: {
		/*7391*/


		// gen! bool IsSame(CefRefPtr<CefV8Context> that)
		auto ret_result = me->IsSame(CefV8ContextCToCpp::Wrap((cef_v8context_t*)v1->ptr));
		/*7392*/
		MyCefSetBool(ret, ret_result);
		/*7393*/
	} break;
		/*7394*/
	case CefV8Context_Eval_9: {
		/*7395*/


		// gen! bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
		auto ret_result = me->Eval(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			v3->i32,
			*((CefRefPtr<CefV8Value>*)v4->ptr),
			*((CefRefPtr<CefV8Exception>*)v5->ptr));
		/*7396*/
		MyCefSetBool(ret, ret_result);
		/*7397*/
	} break;
		/*7398*/
	}
	/*7399*/
	CefV8ContextCToCpp::Unwrap(me);
	/*7400*/
}


// [virtual] class CefV8Accessor
/*7492*/

void MyCefMet_CefV8Accessor(cef_v8accessor_t* me1, int metName, jsvalue* ret) {
	/*7493*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7494*/
	auto me = CefV8AccessorCppToC::Unwrap(me1);
	/*7495*/
	switch (metName) {
		/*7496*/
	case MET_Release:return; //yes, just return
							 /*7497*/
	}
	/*7498*/
	CefV8AccessorCppToC::Wrap(me);
	/*7499*/
}


// [virtual] class CefV8Interceptor
/*7507*/

void MyCefMet_CefV8Interceptor(cef_v8interceptor_t* me1, int metName, jsvalue* ret) {
	/*7508*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7509*/
	auto me = CefV8InterceptorCppToC::Unwrap(me1);
	/*7510*/
	switch (metName) {
		/*7511*/
	case MET_Release:return; //yes, just return
							 /*7512*/
	}
	/*7513*/
	CefV8InterceptorCppToC::Wrap(me);
	/*7514*/
}


// [virtual] class CefV8Exception
/*7530*/
/*7522*/
const int CefV8Exception_GetMessage_1 = 1;
/*7523*/
const int CefV8Exception_GetSourceLine_2 = 2;
/*7524*/
const int CefV8Exception_GetScriptResourceName_3 = 3;
/*7525*/
const int CefV8Exception_GetLineNumber_4 = 4;
/*7526*/
const int CefV8Exception_GetStartPosition_5 = 5;
/*7527*/
const int CefV8Exception_GetEndPosition_6 = 6;
/*7528*/
const int CefV8Exception_GetStartColumn_7 = 7;
/*7529*/
const int CefV8Exception_GetEndColumn_8 = 8;

void MyCefMet_CefV8Exception(cef_v8exception_t* me1, int metName, jsvalue* ret) {
	/*7531*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7532*/
	auto me = CefV8ExceptionCToCpp::Wrap(me1);
	/*7533*/
	switch (metName) {
		/*7534*/
	case MET_Release:return; //yes, just return
							 /*7535*/
	case CefV8Exception_GetMessage_1: {
		/*7536*/


		// gen! CefString GetMessage()
		auto ret_result = me->GetMessage();
		/*7537*/
		SetCefStringToJsValue(ret, ret_result);
		/*7538*/
	} break;
		/*7539*/
	case CefV8Exception_GetSourceLine_2: {
		/*7540*/


		// gen! CefString GetSourceLine()
		auto ret_result = me->GetSourceLine();
		/*7541*/
		SetCefStringToJsValue(ret, ret_result);
		/*7542*/
	} break;
		/*7543*/
	case CefV8Exception_GetScriptResourceName_3: {
		/*7544*/


		// gen! CefString GetScriptResourceName()
		auto ret_result = me->GetScriptResourceName();
		/*7545*/
		SetCefStringToJsValue(ret, ret_result);
		/*7546*/
	} break;
		/*7547*/
	case CefV8Exception_GetLineNumber_4: {
		/*7548*/


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		/*7549*/
		MyCefSetInt64(ret, ret_result);
		/*7550*/
	} break;
		/*7551*/
	case CefV8Exception_GetStartPosition_5: {
		/*7552*/


		// gen! int GetStartPosition()
		auto ret_result = me->GetStartPosition();
		/*7553*/
		MyCefSetInt64(ret, ret_result);
		/*7554*/
	} break;
		/*7555*/
	case CefV8Exception_GetEndPosition_6: {
		/*7556*/


		// gen! int GetEndPosition()
		auto ret_result = me->GetEndPosition();
		/*7557*/
		MyCefSetInt64(ret, ret_result);
		/*7558*/
	} break;
		/*7559*/
	case CefV8Exception_GetStartColumn_7: {
		/*7560*/


		// gen! int GetStartColumn()
		auto ret_result = me->GetStartColumn();
		/*7561*/
		MyCefSetInt64(ret, ret_result);
		/*7562*/
	} break;
		/*7563*/
	case CefV8Exception_GetEndColumn_8: {
		/*7564*/


		// gen! int GetEndColumn()
		auto ret_result = me->GetEndColumn();
		/*7565*/
		MyCefSetInt64(ret, ret_result);
		/*7566*/
	} break;
		/*7567*/
	}
	/*7568*/
	CefV8ExceptionCToCpp::Unwrap(me);
	/*7569*/
}


// [virtual] class CefV8Value
/*7685*/
/*7641*/
const int CefV8Value_IsValid_1 = 1;
/*7642*/
const int CefV8Value_IsUndefined_2 = 2;
/*7643*/
const int CefV8Value_IsNull_3 = 3;
/*7644*/
const int CefV8Value_IsBool_4 = 4;
/*7645*/
const int CefV8Value_IsInt_5 = 5;
/*7646*/
const int CefV8Value_IsUInt_6 = 6;
/*7647*/
const int CefV8Value_IsDouble_7 = 7;
/*7648*/
const int CefV8Value_IsDate_8 = 8;
/*7649*/
const int CefV8Value_IsString_9 = 9;
/*7650*/
const int CefV8Value_IsObject_10 = 10;
/*7651*/
const int CefV8Value_IsArray_11 = 11;
/*7652*/
const int CefV8Value_IsFunction_12 = 12;
/*7653*/
const int CefV8Value_IsSame_13 = 13;
/*7654*/
const int CefV8Value_GetBoolValue_14 = 14;
/*7655*/
const int CefV8Value_GetIntValue_15 = 15;
/*7656*/
const int CefV8Value_GetUIntValue_16 = 16;
/*7657*/
const int CefV8Value_GetDoubleValue_17 = 17;
/*7658*/
const int CefV8Value_GetDateValue_18 = 18;
/*7659*/
const int CefV8Value_GetStringValue_19 = 19;
/*7660*/
const int CefV8Value_IsUserCreated_20 = 20;
/*7661*/
const int CefV8Value_HasException_21 = 21;
/*7662*/
const int CefV8Value_GetException_22 = 22;
/*7663*/
const int CefV8Value_ClearException_23 = 23;
/*7664*/
const int CefV8Value_WillRethrowExceptions_24 = 24;
/*7665*/
const int CefV8Value_SetRethrowExceptions_25 = 25;
/*7666*/
const int CefV8Value_HasValue_26 = 26;
/*7667*/
const int CefV8Value_HasValue_27 = 27;
/*7668*/
const int CefV8Value_DeleteValue_28 = 28;
/*7669*/
const int CefV8Value_DeleteValue_29 = 29;
/*7670*/
const int CefV8Value_GetValue_30 = 30;
/*7671*/
const int CefV8Value_GetValue_31 = 31;
/*7672*/
const int CefV8Value_SetValue_32 = 32;
/*7673*/
const int CefV8Value_SetValue_33 = 33;
/*7674*/
const int CefV8Value_SetValue_34 = 34;
/*7675*/
const int CefV8Value_GetKeys_35 = 35;
/*7676*/
const int CefV8Value_SetUserData_36 = 36;
/*7677*/
const int CefV8Value_GetUserData_37 = 37;
/*7678*/
const int CefV8Value_GetExternallyAllocatedMemory_38 = 38;
/*7679*/
const int CefV8Value_AdjustExternallyAllocatedMemory_39 = 39;
/*7680*/
const int CefV8Value_GetArrayLength_40 = 40;
/*7681*/
const int CefV8Value_GetFunctionName_41 = 41;
/*7682*/
const int CefV8Value_GetFunctionHandler_42 = 42;
/*7683*/
const int CefV8Value_ExecuteFunction_43 = 43;
/*7684*/
const int CefV8Value_ExecuteFunctionWithContext_44 = 44;

void MyCefMet_CefV8Value(cef_v8value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*7686*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*7687*/
	auto me = CefV8ValueCToCpp::Wrap(me1);
	/*7688*/
	switch (metName) {
		/*7689*/
	case MET_Release:return; //yes, just return
							 /*7690*/
	case CefV8Value_IsValid_1: {
		/*7691*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*7692*/
		MyCefSetBool(ret, ret_result);
		/*7693*/
	} break;
		/*7694*/
	case CefV8Value_IsUndefined_2: {
		/*7695*/


		// gen! bool IsUndefined()
		auto ret_result = me->IsUndefined();
		/*7696*/
		MyCefSetBool(ret, ret_result);
		/*7697*/
	} break;
		/*7698*/
	case CefV8Value_IsNull_3: {
		/*7699*/


		// gen! bool IsNull()
		auto ret_result = me->IsNull();
		/*7700*/
		MyCefSetBool(ret, ret_result);
		/*7701*/
	} break;
		/*7702*/
	case CefV8Value_IsBool_4: {
		/*7703*/


		// gen! bool IsBool()
		auto ret_result = me->IsBool();
		/*7704*/
		MyCefSetBool(ret, ret_result);
		/*7705*/
	} break;
		/*7706*/
	case CefV8Value_IsInt_5: {
		/*7707*/


		// gen! bool IsInt()
		auto ret_result = me->IsInt();
		/*7708*/
		MyCefSetBool(ret, ret_result);
		/*7709*/
	} break;
		/*7710*/
	case CefV8Value_IsUInt_6: {
		/*7711*/


		// gen! bool IsUInt()
		auto ret_result = me->IsUInt();
		/*7712*/
		MyCefSetBool(ret, ret_result);
		/*7713*/
	} break;
		/*7714*/
	case CefV8Value_IsDouble_7: {
		/*7715*/


		// gen! bool IsDouble()
		auto ret_result = me->IsDouble();
		/*7716*/
		MyCefSetBool(ret, ret_result);
		/*7717*/
	} break;
		/*7718*/
	case CefV8Value_IsDate_8: {
		/*7719*/


		// gen! bool IsDate()
		auto ret_result = me->IsDate();
		/*7720*/
		MyCefSetBool(ret, ret_result);
		/*7721*/
	} break;
		/*7722*/
	case CefV8Value_IsString_9: {
		/*7723*/


		// gen! bool IsString()
		auto ret_result = me->IsString();
		/*7724*/
		MyCefSetBool(ret, ret_result);
		/*7725*/
	} break;
		/*7726*/
	case CefV8Value_IsObject_10: {
		/*7727*/


		// gen! bool IsObject()
		auto ret_result = me->IsObject();
		/*7728*/
		MyCefSetBool(ret, ret_result);
		/*7729*/
	} break;
		/*7730*/
	case CefV8Value_IsArray_11: {
		/*7731*/


		// gen! bool IsArray()
		auto ret_result = me->IsArray();
		/*7732*/
		MyCefSetBool(ret, ret_result);
		/*7733*/
	} break;
		/*7734*/
	case CefV8Value_IsFunction_12: {
		/*7735*/


		// gen! bool IsFunction()
		auto ret_result = me->IsFunction();
		/*7736*/
		MyCefSetBool(ret, ret_result);
		/*7737*/
	} break;
		/*7738*/
	case CefV8Value_IsSame_13: {
		/*7739*/


		// gen! bool IsSame(CefRefPtr<CefV8Value> that)
		auto ret_result = me->IsSame(CefV8ValueCToCpp::Wrap((cef_v8value_t*)v1->ptr));
		/*7740*/
		MyCefSetBool(ret, ret_result);
		/*7741*/
	} break;
		/*7742*/
	case CefV8Value_GetBoolValue_14: {
		/*7743*/


		// gen! bool GetBoolValue()
		auto ret_result = me->GetBoolValue();
		/*7744*/
		MyCefSetBool(ret, ret_result);
		/*7745*/
	} break;
		/*7746*/
	case CefV8Value_GetIntValue_15: {
		/*7747*/


		// gen! int32 GetIntValue()
		auto ret_result = me->GetIntValue();
		/*7748*/
		MyCefSetInt32(ret, ret_result);
		/*7749*/
	} break;
		/*7750*/
	case CefV8Value_GetUIntValue_16: {
		/*7751*/


		// gen! uint32 GetUIntValue()
		auto ret_result = me->GetUIntValue();
		/*7752*/
		MyCefSetUInt32(ret, ret_result);
		/*7753*/
	} break;
		/*7754*/
	case CefV8Value_GetDoubleValue_17: {
		/*7755*/


		// gen! double GetDoubleValue()
		auto ret_result = me->GetDoubleValue();
		/*7756*/
		MyCefSetDouble(ret, ret_result);
		/*7757*/
	} break;
		/*7758*/
	case CefV8Value_GetDateValue_18: {
		/*7759*/


		// gen! CefTime GetDateValue()
		auto ret_result = me->GetDateValue();
		/*7760*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*7761*/
	} break;
		/*7762*/
	case CefV8Value_GetStringValue_19: {
		/*7763*/


		// gen! CefString GetStringValue()
		auto ret_result = me->GetStringValue();
		/*7764*/
		SetCefStringToJsValue(ret, ret_result);
		/*7765*/
	} break;
		/*7766*/
	case CefV8Value_IsUserCreated_20: {
		/*7767*/


		// gen! bool IsUserCreated()
		auto ret_result = me->IsUserCreated();
		/*7768*/
		MyCefSetBool(ret, ret_result);
		/*7769*/
	} break;
		/*7770*/
	case CefV8Value_HasException_21: {
		/*7771*/


		// gen! bool HasException()
		auto ret_result = me->HasException();
		/*7772*/
		MyCefSetBool(ret, ret_result);
		/*7773*/
	} break;
		/*7774*/
	case CefV8Value_GetException_22: {
		/*7775*/


		// gen! CefRefPtr<CefV8Exception> GetException()
		auto ret_result = me->GetException();
		/*7776*/
		MyCefSetVoidPtr(ret, CefV8ExceptionCToCpp::Unwrap(ret_result));
		/*7777*/
	} break;
		/*7778*/
	case CefV8Value_ClearException_23: {
		/*7779*/


		// gen! bool ClearException()
		auto ret_result = me->ClearException();
		/*7780*/
		MyCefSetBool(ret, ret_result);
		/*7781*/
	} break;
		/*7782*/
	case CefV8Value_WillRethrowExceptions_24: {
		/*7783*/


		// gen! bool WillRethrowExceptions()
		auto ret_result = me->WillRethrowExceptions();
		/*7784*/
		MyCefSetBool(ret, ret_result);
		/*7785*/
	} break;
		/*7786*/
	case CefV8Value_SetRethrowExceptions_25: {
		/*7787*/


		// gen! bool SetRethrowExceptions(bool rethrow)
		auto ret_result = me->SetRethrowExceptions(v1->i32 != 0);
		/*7788*/
		MyCefSetBool(ret, ret_result);
		/*7789*/
	} break;
		/*7790*/
	case CefV8Value_HasValue_26: {
		/*7791*/


		// gen! bool HasValue(const CefString& key)
		auto ret_result = me->HasValue(GetStringHolder(v1)->value);
		/*7792*/
		MyCefSetBool(ret, ret_result);
		/*7793*/
	} break;
		/*7794*/
	case CefV8Value_HasValue_27: {
		/*7795*/


		// gen! bool HasValue(int index)
		auto ret_result = me->HasValue(v1->i32);
		/*7796*/
		MyCefSetBool(ret, ret_result);
		/*7797*/
	} break;
		/*7798*/
	case CefV8Value_DeleteValue_28: {
		/*7799*/


		// gen! bool DeleteValue(const CefString& key)
		auto ret_result = me->DeleteValue(GetStringHolder(v1)->value);
		/*7800*/
		MyCefSetBool(ret, ret_result);
		/*7801*/
	} break;
		/*7802*/
	case CefV8Value_DeleteValue_29: {
		/*7803*/


		// gen! bool DeleteValue(int index)
		auto ret_result = me->DeleteValue(v1->i32);
		/*7804*/
		MyCefSetBool(ret, ret_result);
		/*7805*/
	} break;
		/*7806*/
	case CefV8Value_GetValue_30: {
		/*7807*/


		// gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)
		auto ret_result = me->GetValue(GetStringHolder(v1)->value);
		/*7808*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*7809*/
	} break;
		/*7810*/
	case CefV8Value_GetValue_31: {
		/*7811*/


		// gen! CefRefPtr<CefV8Value> GetValue(int index)
		auto ret_result = me->GetValue(v1->i32);
		/*7812*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*7813*/
	} break;
		/*7814*/
	case CefV8Value_SetValue_32: {
		/*7815*/


		// gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			(CefV8Value::PropertyAttribute)v3->i32);
		/*7816*/
		MyCefSetBool(ret, ret_result);
		/*7817*/
	} break;
		/*7818*/
	case CefV8Value_SetValue_33: {
		/*7819*/


		// gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)
		auto ret_result = me->SetValue(v1->i32,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr));
		/*7820*/
		MyCefSetBool(ret, ret_result);
		/*7821*/
	} break;
		/*7822*/
	case CefV8Value_SetValue_34: {
		/*7823*/


		// gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			(CefV8Value::AccessControl)v2->i32,
			(CefV8Value::PropertyAttribute)v3->i32);
		/*7824*/
		MyCefSetBool(ret, ret_result);
		/*7825*/
	} break;
		/*7826*/
	case CefV8Value_GetKeys_35: {
		/*7827*/


		// gen! bool GetKeys(std::vector<CefString>& keys)
		auto ret_result = me->GetKeys(*((std::vector<CefString>*)v1->ptr));
		/*7828*/
		MyCefSetBool(ret, ret_result);
		/*7829*/
	} break;
		/*7830*/
	case CefV8Value_SetUserData_36: {
		/*7831*/


		// gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
		//auto ret_result = me->SetUserData(v1->ptr);
		///*7832*/
		//MyCefSetBool(ret, ret_result);
		/*7833*/
	} break;
		/*7834*/
	case CefV8Value_GetUserData_37: {
		/*7835*/


		// gen! CefRefPtr<CefBaseRefCounted> GetUserData()
		auto ret_result = me->GetUserData();
		/*7836*/

		/*7837*/
	} break;
		/*7838*/
	case CefV8Value_GetExternallyAllocatedMemory_38: {
		/*7839*/


		// gen! int GetExternallyAllocatedMemory()
		auto ret_result = me->GetExternallyAllocatedMemory();
		/*7840*/
		MyCefSetInt64(ret, ret_result);
		/*7841*/
	} break;
		/*7842*/
	case CefV8Value_AdjustExternallyAllocatedMemory_39: {
		/*7843*/


		// gen! int AdjustExternallyAllocatedMemory(int change_in_bytes)
		auto ret_result = me->AdjustExternallyAllocatedMemory(v1->i32);
		/*7844*/
		MyCefSetInt64(ret, ret_result);
		/*7845*/
	} break;
		/*7846*/
	case CefV8Value_GetArrayLength_40: {
		/*7847*/


		// gen! int GetArrayLength()
		auto ret_result = me->GetArrayLength();
		/*7848*/
		MyCefSetInt64(ret, ret_result);
		/*7849*/
	} break;
		/*7850*/
	case CefV8Value_GetFunctionName_41: {
		/*7851*/


		// gen! CefString GetFunctionName()
		auto ret_result = me->GetFunctionName();
		/*7852*/
		SetCefStringToJsValue(ret, ret_result);
		/*7853*/
	} break;
		/*7854*/
	case CefV8Value_GetFunctionHandler_42: {
		/*7855*/


		// gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
		auto ret_result = me->GetFunctionHandler();
		/*7856*/
		MyCefSetVoidPtr(ret, CefV8HandlerCppToC::Wrap(ret_result));
		/*7857*/
	} break;
		/*7858*/
	case CefV8Value_ExecuteFunction_43: {
		/*7859*/


		// gen! CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
		auto ret_result = me->ExecuteFunction(CefV8ValueCToCpp::Wrap((cef_v8value_t*)v1->ptr),
			*((CefV8ValueList*)v2->ptr));
		/*7860*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*7861*/
	} break;
		/*7862*/
	case CefV8Value_ExecuteFunctionWithContext_44: {
		/*7863*/


		// gen! CefRefPtr<CefV8Value> ExecuteFunctionWithContext(CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
		auto ret_result = me->ExecuteFunctionWithContext(CefV8ContextCToCpp::Wrap((cef_v8context_t*)v1->ptr),
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			*((CefV8ValueList*)v3->ptr));
		/*7864*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*7865*/
	} break;
		/*7866*/
	}
	/*7867*/
	CefV8ValueCToCpp::Unwrap(me);
	/*7868*/
}


// [virtual] class CefV8StackTrace
/*8265*/
/*8262*/
const int CefV8StackTrace_IsValid_1 = 1;
/*8263*/
const int CefV8StackTrace_GetFrameCount_2 = 2;
/*8264*/
const int CefV8StackTrace_GetFrame_3 = 3;

void MyCefMet_CefV8StackTrace(cef_v8stack_trace_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*8266*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*8267*/
	auto me = CefV8StackTraceCToCpp::Wrap(me1);
	/*8268*/
	switch (metName) {
		/*8269*/
	case MET_Release:return; //yes, just return
							 /*8270*/
	case CefV8StackTrace_IsValid_1: {
		/*8271*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*8272*/
		MyCefSetBool(ret, ret_result);
		/*8273*/
	} break;
		/*8274*/
	case CefV8StackTrace_GetFrameCount_2: {
		/*8275*/


		// gen! int GetFrameCount()
		auto ret_result = me->GetFrameCount();
		/*8276*/
		MyCefSetInt64(ret, ret_result);
		/*8277*/
	} break;
		/*8278*/
	case CefV8StackTrace_GetFrame_3: {
		/*8279*/


		// gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
		auto ret_result = me->GetFrame(v1->i32);
		/*8280*/
		MyCefSetVoidPtr(ret, CefV8StackFrameCToCpp::Unwrap(ret_result));
		/*8281*/
	} break;
		/*8282*/
	}
	/*8283*/
	CefV8StackTraceCToCpp::Unwrap(me);
	/*8284*/
}


// [virtual] class CefV8StackFrame
/*8325*/
/*8317*/
const int CefV8StackFrame_IsValid_1 = 1;
/*8318*/
const int CefV8StackFrame_GetScriptName_2 = 2;
/*8319*/
const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = 3;
/*8320*/
const int CefV8StackFrame_GetFunctionName_4 = 4;
/*8321*/
const int CefV8StackFrame_GetLineNumber_5 = 5;
/*8322*/
const int CefV8StackFrame_GetColumn_6 = 6;
/*8323*/
const int CefV8StackFrame_IsEval_7 = 7;
/*8324*/
const int CefV8StackFrame_IsConstructor_8 = 8;

void MyCefMet_CefV8StackFrame(cef_v8stack_frame_t* me1, int metName, jsvalue* ret) {
	/*8326*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*8327*/
	auto me = CefV8StackFrameCToCpp::Wrap(me1);
	/*8328*/
	switch (metName) {
		/*8329*/
	case MET_Release:return; //yes, just return
							 /*8330*/
	case CefV8StackFrame_IsValid_1: {
		/*8331*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*8332*/
		MyCefSetBool(ret, ret_result);
		/*8333*/
	} break;
		/*8334*/
	case CefV8StackFrame_GetScriptName_2: {
		/*8335*/


		// gen! CefString GetScriptName()
		auto ret_result = me->GetScriptName();
		/*8336*/
		SetCefStringToJsValue(ret, ret_result);
		/*8337*/
	} break;
		/*8338*/
	case CefV8StackFrame_GetScriptNameOrSourceURL_3: {
		/*8339*/


		// gen! CefString GetScriptNameOrSourceURL()
		auto ret_result = me->GetScriptNameOrSourceURL();
		/*8340*/
		SetCefStringToJsValue(ret, ret_result);
		/*8341*/
	} break;
		/*8342*/
	case CefV8StackFrame_GetFunctionName_4: {
		/*8343*/


		// gen! CefString GetFunctionName()
		auto ret_result = me->GetFunctionName();
		/*8344*/
		SetCefStringToJsValue(ret, ret_result);
		/*8345*/
	} break;
		/*8346*/
	case CefV8StackFrame_GetLineNumber_5: {
		/*8347*/


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		/*8348*/
		MyCefSetInt64(ret, ret_result);
		/*8349*/
	} break;
		/*8350*/
	case CefV8StackFrame_GetColumn_6: {
		/*8351*/


		// gen! int GetColumn()
		auto ret_result = me->GetColumn();
		/*8352*/
		MyCefSetInt64(ret, ret_result);
		/*8353*/
	} break;
		/*8354*/
	case CefV8StackFrame_IsEval_7: {
		/*8355*/


		// gen! bool IsEval()
		auto ret_result = me->IsEval();
		/*8356*/
		MyCefSetBool(ret, ret_result);
		/*8357*/
	} break;
		/*8358*/
	case CefV8StackFrame_IsConstructor_8: {
		/*8359*/


		// gen! bool IsConstructor()
		auto ret_result = me->IsConstructor();
		/*8360*/
		MyCefSetBool(ret, ret_result);
		/*8361*/
	} break;
		/*8362*/
	}
	/*8363*/
	CefV8StackFrameCToCpp::Unwrap(me);
	/*8364*/
}


// [virtual] class CefValue
/*8458*/
/*8436*/
const int CefValue_IsValid_1 = 1;
/*8437*/
const int CefValue_IsOwned_2 = 2;
/*8438*/
const int CefValue_IsReadOnly_3 = 3;
/*8439*/
const int CefValue_IsSame_4 = 4;
/*8440*/
const int CefValue_IsEqual_5 = 5;
/*8441*/
const int CefValue_Copy_6 = 6;
/*8442*/
const int CefValue_GetType_7 = 7;
/*8443*/
const int CefValue_GetBool_8 = 8;
/*8444*/
const int CefValue_GetInt_9 = 9;
/*8445*/
const int CefValue_GetDouble_10 = 10;
/*8446*/
const int CefValue_GetString_11 = 11;
/*8447*/
const int CefValue_GetBinary_12 = 12;
/*8448*/
const int CefValue_GetDictionary_13 = 13;
/*8449*/
const int CefValue_GetList_14 = 14;
/*8450*/
const int CefValue_SetNull_15 = 15;
/*8451*/
const int CefValue_SetBool_16 = 16;
/*8452*/
const int CefValue_SetInt_17 = 17;
/*8453*/
const int CefValue_SetDouble_18 = 18;
/*8454*/
const int CefValue_SetString_19 = 19;
/*8455*/
const int CefValue_SetBinary_20 = 20;
/*8456*/
const int CefValue_SetDictionary_21 = 21;
/*8457*/
const int CefValue_SetList_22 = 22;

void MyCefMet_CefValue(cef_value_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*8459*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*8460*/
	auto me = CefValueCToCpp::Wrap(me1);
	/*8461*/
	switch (metName) {
		/*8462*/
	case MET_Release:return; //yes, just return
							 /*8463*/
	case CefValue_IsValid_1: {
		/*8464*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*8465*/
		MyCefSetBool(ret, ret_result);
		/*8466*/
	} break;
		/*8467*/
	case CefValue_IsOwned_2: {
		/*8468*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*8469*/
		MyCefSetBool(ret, ret_result);
		/*8470*/
	} break;
		/*8471*/
	case CefValue_IsReadOnly_3: {
		/*8472*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*8473*/
		MyCefSetBool(ret, ret_result);
		/*8474*/
	} break;
		/*8475*/
	case CefValue_IsSame_4: {
		/*8476*/


		// gen! bool IsSame(CefRefPtr<CefValue> that)
		auto ret_result = me->IsSame(CefValueCToCpp::Wrap((cef_value_t*)v1->ptr));
		/*8477*/
		MyCefSetBool(ret, ret_result);
		/*8478*/
	} break;
		/*8479*/
	case CefValue_IsEqual_5: {
		/*8480*/


		// gen! bool IsEqual(CefRefPtr<CefValue> that)
		auto ret_result = me->IsEqual(CefValueCToCpp::Wrap((cef_value_t*)v1->ptr));
		/*8481*/
		MyCefSetBool(ret, ret_result);
		/*8482*/
	} break;
		/*8483*/
	case CefValue_Copy_6: {
		/*8484*/


		// gen! CefRefPtr<CefValue> Copy()
		auto ret_result = me->Copy();
		/*8485*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*8486*/
	} break;
		/*8487*/
	case CefValue_GetType_7: {
		/*8488*/


		// gen! CefValueType GetType()
		auto ret_result = me->GetType();
		/*8489*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*8490*/
	} break;
		/*8491*/
	case CefValue_GetBool_8: {
		/*8492*/


		// gen! bool GetBool()
		auto ret_result = me->GetBool();
		/*8493*/
		MyCefSetBool(ret, ret_result);
		/*8494*/
	} break;
		/*8495*/
	case CefValue_GetInt_9: {
		/*8496*/


		// gen! int GetInt()
		auto ret_result = me->GetInt();
		/*8497*/
		MyCefSetInt64(ret, ret_result);
		/*8498*/
	} break;
		/*8499*/
	case CefValue_GetDouble_10: {
		/*8500*/


		// gen! double GetDouble()
		auto ret_result = me->GetDouble();
		/*8501*/
		MyCefSetDouble(ret, ret_result);
		/*8502*/
	} break;
		/*8503*/
	case CefValue_GetString_11: {
		/*8504*/


		// gen! CefString GetString()
		auto ret_result = me->GetString();
		/*8505*/
		SetCefStringToJsValue(ret, ret_result);
		/*8506*/
	} break;
		/*8507*/
	case CefValue_GetBinary_12: {
		/*8508*/


		// gen! CefRefPtr<CefBinaryValue> GetBinary()
		auto ret_result = me->GetBinary();
		/*8509*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*8510*/
	} break;
		/*8511*/
	case CefValue_GetDictionary_13: {
		/*8512*/


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary()
		auto ret_result = me->GetDictionary();
		/*8513*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*8514*/
	} break;
		/*8515*/
	case CefValue_GetList_14: {
		/*8516*/


		// gen! CefRefPtr<CefListValue> GetList()
		auto ret_result = me->GetList();
		/*8517*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*8518*/
	} break;
		/*8519*/
	case CefValue_SetNull_15: {
		/*8520*/


		// gen! bool SetNull()
		auto ret_result = me->SetNull();
		/*8521*/
		MyCefSetBool(ret, ret_result);
		/*8522*/
	} break;
		/*8523*/
	case CefValue_SetBool_16: {
		/*8524*/


		// gen! bool SetBool(bool value)
		auto ret_result = me->SetBool(v1->i32 != 0);
		/*8525*/
		MyCefSetBool(ret, ret_result);
		/*8526*/
	} break;
		/*8527*/
	case CefValue_SetInt_17: {
		/*8528*/


		// gen! bool SetInt(int value)
		auto ret_result = me->SetInt(v1->i32);
		/*8529*/
		MyCefSetBool(ret, ret_result);
		/*8530*/
	} break;
		/*8531*/
	case CefValue_SetDouble_18: {
		/*8532*/


		// gen! bool SetDouble(double value)
		auto ret_result = me->SetDouble(v1->num);
		/*8533*/
		MyCefSetBool(ret, ret_result);
		/*8534*/
	} break;
		/*8535*/
	case CefValue_SetString_19: {
		/*8536*/


		// gen! bool SetString(const CefString& value)
		auto ret_result = me->SetString(GetStringHolder(v1)->value);
		/*8537*/
		MyCefSetBool(ret, ret_result);
		/*8538*/
	} break;
		/*8539*/
	case CefValue_SetBinary_20: {
		/*8540*/


		// gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		/*8541*/
		MyCefSetBool(ret, ret_result);
		/*8542*/
	} break;
		/*8543*/
	case CefValue_SetDictionary_21: {
		/*8544*/


		// gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		/*8545*/
		MyCefSetBool(ret, ret_result);
		/*8546*/
	} break;
		/*8547*/
	case CefValue_SetList_22: {
		/*8548*/


		// gen! bool SetList(CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		/*8549*/
		MyCefSetBool(ret, ret_result);
		/*8550*/
	} break;
		/*8551*/
	}
	/*8552*/
	CefValueCToCpp::Unwrap(me);
	/*8553*/
}


// [virtual] class CefBinaryValue
/*8755*/
/*8748*/
const int CefBinaryValue_IsValid_1 = 1;
/*8749*/
const int CefBinaryValue_IsOwned_2 = 2;
/*8750*/
const int CefBinaryValue_IsSame_3 = 3;
/*8751*/
const int CefBinaryValue_IsEqual_4 = 4;
/*8752*/
const int CefBinaryValue_Copy_5 = 5;
/*8753*/
const int CefBinaryValue_GetSize_6 = 6;
/*8754*/
const int CefBinaryValue_GetData_7 = 7;

void MyCefMet_CefBinaryValue(cef_binary_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3) {
	/*8756*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*8757*/
	auto me = CefBinaryValueCToCpp::Wrap(me1);
	/*8758*/
	switch (metName) {
		/*8759*/
	case MET_Release:return; //yes, just return
							 /*8760*/
	case CefBinaryValue_IsValid_1: {
		/*8761*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*8762*/
		MyCefSetBool(ret, ret_result);
		/*8763*/
	} break;
		/*8764*/
	case CefBinaryValue_IsOwned_2: {
		/*8765*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*8766*/
		MyCefSetBool(ret, ret_result);
		/*8767*/
	} break;
		/*8768*/
	case CefBinaryValue_IsSame_3: {
		/*8769*/


		// gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
		auto ret_result = me->IsSame(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		/*8770*/
		MyCefSetBool(ret, ret_result);
		/*8771*/
	} break;
		/*8772*/
	case CefBinaryValue_IsEqual_4: {
		/*8773*/


		// gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
		auto ret_result = me->IsEqual(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		/*8774*/
		MyCefSetBool(ret, ret_result);
		/*8775*/
	} break;
		/*8776*/
	case CefBinaryValue_Copy_5: {
		/*8777*/


		// gen! CefRefPtr<CefBinaryValue> Copy()
		auto ret_result = me->Copy();
		/*8778*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*8779*/
	} break;
		/*8780*/
	case CefBinaryValue_GetSize_6: {
		/*8781*/


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		/*8782*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*8783*/
	} break;
		/*8784*/
	case CefBinaryValue_GetData_7: {
		/*8785*/


		// gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
		auto ret_result = me->GetData((void*)v1->ptr,
			v2->i64,
			v3->i64);
		/*8786*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*8787*/
	} break;
		/*8788*/
	}
	/*8789*/
	CefBinaryValueCToCpp::Unwrap(me);
	/*8790*/
}


// [virtual] class CefDictionaryValue
/*8888*/
/*8859*/
const int CefDictionaryValue_IsValid_1 = 1;
/*8860*/
const int CefDictionaryValue_IsOwned_2 = 2;
/*8861*/
const int CefDictionaryValue_IsReadOnly_3 = 3;
/*8862*/
const int CefDictionaryValue_IsSame_4 = 4;
/*8863*/
const int CefDictionaryValue_IsEqual_5 = 5;
/*8864*/
const int CefDictionaryValue_Copy_6 = 6;
/*8865*/
const int CefDictionaryValue_GetSize_7 = 7;
/*8866*/
const int CefDictionaryValue_Clear_8 = 8;
/*8867*/
const int CefDictionaryValue_HasKey_9 = 9;
/*8868*/
const int CefDictionaryValue_GetKeys_10 = 10;
/*8869*/
const int CefDictionaryValue_Remove_11 = 11;
/*8870*/
const int CefDictionaryValue_GetType_12 = 12;
/*8871*/
const int CefDictionaryValue_GetValue_13 = 13;
/*8872*/
const int CefDictionaryValue_GetBool_14 = 14;
/*8873*/
const int CefDictionaryValue_GetInt_15 = 15;
/*8874*/
const int CefDictionaryValue_GetDouble_16 = 16;
/*8875*/
const int CefDictionaryValue_GetString_17 = 17;
/*8876*/
const int CefDictionaryValue_GetBinary_18 = 18;
/*8877*/
const int CefDictionaryValue_GetDictionary_19 = 19;
/*8878*/
const int CefDictionaryValue_GetList_20 = 20;
/*8879*/
const int CefDictionaryValue_SetValue_21 = 21;
/*8880*/
const int CefDictionaryValue_SetNull_22 = 22;
/*8881*/
const int CefDictionaryValue_SetBool_23 = 23;
/*8882*/
const int CefDictionaryValue_SetInt_24 = 24;
/*8883*/
const int CefDictionaryValue_SetDouble_25 = 25;
/*8884*/
const int CefDictionaryValue_SetString_26 = 26;
/*8885*/
const int CefDictionaryValue_SetBinary_27 = 27;
/*8886*/
const int CefDictionaryValue_SetDictionary_28 = 28;
/*8887*/
const int CefDictionaryValue_SetList_29 = 29;

void MyCefMet_CefDictionaryValue(cef_dictionary_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*8889*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*8890*/
	auto me = CefDictionaryValueCToCpp::Wrap(me1);
	/*8891*/
	switch (metName) {
		/*8892*/
	case MET_Release:return; //yes, just return
							 /*8893*/
	case CefDictionaryValue_IsValid_1: {
		/*8894*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*8895*/
		MyCefSetBool(ret, ret_result);
		/*8896*/
	} break;
		/*8897*/
	case CefDictionaryValue_IsOwned_2: {
		/*8898*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*8899*/
		MyCefSetBool(ret, ret_result);
		/*8900*/
	} break;
		/*8901*/
	case CefDictionaryValue_IsReadOnly_3: {
		/*8902*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*8903*/
		MyCefSetBool(ret, ret_result);
		/*8904*/
	} break;
		/*8905*/
	case CefDictionaryValue_IsSame_4: {
		/*8906*/


		// gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
		auto ret_result = me->IsSame(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		/*8907*/
		MyCefSetBool(ret, ret_result);
		/*8908*/
	} break;
		/*8909*/
	case CefDictionaryValue_IsEqual_5: {
		/*8910*/


		// gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
		auto ret_result = me->IsEqual(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		/*8911*/
		MyCefSetBool(ret, ret_result);
		/*8912*/
	} break;
		/*8913*/
	case CefDictionaryValue_Copy_6: {
		/*8914*/


		// gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
		auto ret_result = me->Copy(v1->i32 != 0);
		/*8915*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*8916*/
	} break;
		/*8917*/
	case CefDictionaryValue_GetSize_7: {
		/*8918*/


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		/*8919*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*8920*/
	} break;
		/*8921*/
	case CefDictionaryValue_Clear_8: {
		/*8922*/


		// gen! bool Clear()
		auto ret_result = me->Clear();
		/*8923*/
		MyCefSetBool(ret, ret_result);
		/*8924*/
	} break;
		/*8925*/
	case CefDictionaryValue_HasKey_9: {
		/*8926*/


		// gen! bool HasKey(const CefString& key)
		auto ret_result = me->HasKey(GetStringHolder(v1)->value);
		/*8927*/
		MyCefSetBool(ret, ret_result);
		/*8928*/
	} break;
		/*8929*/
	case CefDictionaryValue_GetKeys_10: {
		/*8930*/


		// gen! bool GetKeys(KeyList& keys)
		auto ret_result = me->GetKeys(*((CefDictionaryValue::KeyList*)v1->ptr));
		/*8931*/
		MyCefSetBool(ret, ret_result);
		/*8932*/
	} break;
		/*8933*/
	case CefDictionaryValue_Remove_11: {
		/*8934*/


		// gen! bool Remove(const CefString& key)
		auto ret_result = me->Remove(GetStringHolder(v1)->value);
		/*8935*/
		MyCefSetBool(ret, ret_result);
		/*8936*/
	} break;
		/*8937*/
	case CefDictionaryValue_GetType_12: {
		/*8938*/


		// gen! CefValueType GetType(const CefString& key)
		auto ret_result = me->GetType(GetStringHolder(v1)->value);
		/*8939*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*8940*/
	} break;
		/*8941*/
	case CefDictionaryValue_GetValue_13: {
		/*8942*/


		// gen! CefRefPtr<CefValue> GetValue(const CefString& key)
		auto ret_result = me->GetValue(GetStringHolder(v1)->value);
		/*8943*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*8944*/
	} break;
		/*8945*/
	case CefDictionaryValue_GetBool_14: {
		/*8946*/


		// gen! bool GetBool(const CefString& key)
		auto ret_result = me->GetBool(GetStringHolder(v1)->value);
		/*8947*/
		MyCefSetBool(ret, ret_result);
		/*8948*/
	} break;
		/*8949*/
	case CefDictionaryValue_GetInt_15: {
		/*8950*/


		// gen! int GetInt(const CefString& key)
		auto ret_result = me->GetInt(GetStringHolder(v1)->value);
		/*8951*/
		MyCefSetInt64(ret, ret_result);
		/*8952*/
	} break;
		/*8953*/
	case CefDictionaryValue_GetDouble_16: {
		/*8954*/


		// gen! double GetDouble(const CefString& key)
		auto ret_result = me->GetDouble(GetStringHolder(v1)->value);
		/*8955*/
		MyCefSetDouble(ret, ret_result);
		/*8956*/
	} break;
		/*8957*/
	case CefDictionaryValue_GetString_17: {
		/*8958*/


		// gen! CefString GetString(const CefString& key)
		auto ret_result = me->GetString(GetStringHolder(v1)->value);
		/*8959*/
		SetCefStringToJsValue(ret, ret_result);
		/*8960*/
	} break;
		/*8961*/
	case CefDictionaryValue_GetBinary_18: {
		/*8962*/


		// gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
		auto ret_result = me->GetBinary(GetStringHolder(v1)->value);
		/*8963*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*8964*/
	} break;
		/*8965*/
	case CefDictionaryValue_GetDictionary_19: {
		/*8966*/


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
		auto ret_result = me->GetDictionary(GetStringHolder(v1)->value);
		/*8967*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*8968*/
	} break;
		/*8969*/
	case CefDictionaryValue_GetList_20: {
		/*8970*/


		// gen! CefRefPtr<CefListValue> GetList(const CefString& key)
		auto ret_result = me->GetList(GetStringHolder(v1)->value);
		/*8971*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*8972*/
	} break;
		/*8973*/
	case CefDictionaryValue_SetValue_21: {
		/*8974*/


		// gen! bool SetValue(const CefString& key,CefRefPtr<CefValue> value)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr));
		/*8975*/
		MyCefSetBool(ret, ret_result);
		/*8976*/
	} break;
		/*8977*/
	case CefDictionaryValue_SetNull_22: {
		/*8978*/


		// gen! bool SetNull(const CefString& key)
		auto ret_result = me->SetNull(GetStringHolder(v1)->value);
		/*8979*/
		MyCefSetBool(ret, ret_result);
		/*8980*/
	} break;
		/*8981*/
	case CefDictionaryValue_SetBool_23: {
		/*8982*/


		// gen! bool SetBool(const CefString& key,bool value)
		auto ret_result = me->SetBool(GetStringHolder(v1)->value,
			v2->i32 != 0);
		/*8983*/
		MyCefSetBool(ret, ret_result);
		/*8984*/
	} break;
		/*8985*/
	case CefDictionaryValue_SetInt_24: {
		/*8986*/


		// gen! bool SetInt(const CefString& key,int value)
		auto ret_result = me->SetInt(GetStringHolder(v1)->value,
			v2->i32);
		/*8987*/
		MyCefSetBool(ret, ret_result);
		/*8988*/
	} break;
		/*8989*/
	case CefDictionaryValue_SetDouble_25: {
		/*8990*/


		// gen! bool SetDouble(const CefString& key,double value)
		auto ret_result = me->SetDouble(GetStringHolder(v1)->value,
			v2->num);
		/*8991*/
		MyCefSetBool(ret, ret_result);
		/*8992*/
	} break;
		/*8993*/
	case CefDictionaryValue_SetString_26: {
		/*8994*/


		// gen! bool SetString(const CefString& key,const CefString& value)
		auto ret_result = me->SetString(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*8995*/
		MyCefSetBool(ret, ret_result);
		/*8996*/
	} break;
		/*8997*/
	case CefDictionaryValue_SetBinary_27: {
		/*8998*/


		// gen! bool SetBinary(const CefString& key,CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(GetStringHolder(v1)->value,
			CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v2->ptr));
		/*8999*/
		MyCefSetBool(ret, ret_result);
		/*9000*/
	} break;
		/*9001*/
	case CefDictionaryValue_SetDictionary_28: {
		/*9002*/


		// gen! bool SetDictionary(const CefString& key,CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(GetStringHolder(v1)->value,
			CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v2->ptr));
		/*9003*/
		MyCefSetBool(ret, ret_result);
		/*9004*/
	} break;
		/*9005*/
	case CefDictionaryValue_SetList_29: {
		/*9006*/


		// gen! bool SetList(const CefString& key,CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(GetStringHolder(v1)->value,
			CefListValueCToCpp::Wrap((cef_list_value_t*)v2->ptr));
		/*9007*/
		MyCefSetBool(ret, ret_result);
		/*9008*/
	} break;
		/*9009*/
	}
	/*9010*/
	CefDictionaryValueCToCpp::Unwrap(me);
	/*9011*/
}


// [virtual] class CefListValue
/*9353*/
/*9325*/
const int CefListValue_IsValid_1 = 1;
/*9326*/
const int CefListValue_IsOwned_2 = 2;
/*9327*/
const int CefListValue_IsReadOnly_3 = 3;
/*9328*/
const int CefListValue_IsSame_4 = 4;
/*9329*/
const int CefListValue_IsEqual_5 = 5;
/*9330*/
const int CefListValue_Copy_6 = 6;
/*9331*/
const int CefListValue_SetSize_7 = 7;
/*9332*/
const int CefListValue_GetSize_8 = 8;
/*9333*/
const int CefListValue_Clear_9 = 9;
/*9334*/
const int CefListValue_Remove_10 = 10;
/*9335*/
const int CefListValue_GetType_11 = 11;
/*9336*/
const int CefListValue_GetValue_12 = 12;
/*9337*/
const int CefListValue_GetBool_13 = 13;
/*9338*/
const int CefListValue_GetInt_14 = 14;
/*9339*/
const int CefListValue_GetDouble_15 = 15;
/*9340*/
const int CefListValue_GetString_16 = 16;
/*9341*/
const int CefListValue_GetBinary_17 = 17;
/*9342*/
const int CefListValue_GetDictionary_18 = 18;
/*9343*/
const int CefListValue_GetList_19 = 19;
/*9344*/
const int CefListValue_SetValue_20 = 20;
/*9345*/
const int CefListValue_SetNull_21 = 21;
/*9346*/
const int CefListValue_SetBool_22 = 22;
/*9347*/
const int CefListValue_SetInt_23 = 23;
/*9348*/
const int CefListValue_SetDouble_24 = 24;
/*9349*/
const int CefListValue_SetString_25 = 25;
/*9350*/
const int CefListValue_SetBinary_26 = 26;
/*9351*/
const int CefListValue_SetDictionary_27 = 27;
/*9352*/
const int CefListValue_SetList_28 = 28;

void MyCefMet_CefListValue(cef_list_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*9354*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*9355*/
	auto me = CefListValueCToCpp::Wrap(me1);
	/*9356*/
	switch (metName) {
		/*9357*/
	case MET_Release:return; //yes, just return
							 /*9358*/
	case CefListValue_IsValid_1: {
		/*9359*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*9360*/
		MyCefSetBool(ret, ret_result);
		/*9361*/
	} break;
		/*9362*/
	case CefListValue_IsOwned_2: {
		/*9363*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*9364*/
		MyCefSetBool(ret, ret_result);
		/*9365*/
	} break;
		/*9366*/
	case CefListValue_IsReadOnly_3: {
		/*9367*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*9368*/
		MyCefSetBool(ret, ret_result);
		/*9369*/
	} break;
		/*9370*/
	case CefListValue_IsSame_4: {
		/*9371*/


		// gen! bool IsSame(CefRefPtr<CefListValue> that)
		auto ret_result = me->IsSame(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		/*9372*/
		MyCefSetBool(ret, ret_result);
		/*9373*/
	} break;
		/*9374*/
	case CefListValue_IsEqual_5: {
		/*9375*/


		// gen! bool IsEqual(CefRefPtr<CefListValue> that)
		auto ret_result = me->IsEqual(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		/*9376*/
		MyCefSetBool(ret, ret_result);
		/*9377*/
	} break;
		/*9378*/
	case CefListValue_Copy_6: {
		/*9379*/


		// gen! CefRefPtr<CefListValue> Copy()
		auto ret_result = me->Copy();
		/*9380*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*9381*/
	} break;
		/*9382*/
	case CefListValue_SetSize_7: {
		/*9383*/


		// gen! bool SetSize(size_t size)
		auto ret_result = me->SetSize(v1->i64);
		/*9384*/
		MyCefSetBool(ret, ret_result);
		/*9385*/
	} break;
		/*9386*/
	case CefListValue_GetSize_8: {
		/*9387*/


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		/*9388*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*9389*/
	} break;
		/*9390*/
	case CefListValue_Clear_9: {
		/*9391*/


		// gen! bool Clear()
		auto ret_result = me->Clear();
		/*9392*/
		MyCefSetBool(ret, ret_result);
		/*9393*/
	} break;
		/*9394*/
	case CefListValue_Remove_10: {
		/*9395*/


		// gen! bool Remove(size_t index)
		auto ret_result = me->Remove(v1->i64);
		/*9396*/
		MyCefSetBool(ret, ret_result);
		/*9397*/
	} break;
		/*9398*/
	case CefListValue_GetType_11: {
		/*9399*/


		// gen! CefValueType GetType(size_t index)
		auto ret_result = me->GetType(v1->i64);
		/*9400*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*9401*/
	} break;
		/*9402*/
	case CefListValue_GetValue_12: {
		/*9403*/


		// gen! CefRefPtr<CefValue> GetValue(size_t index)
		auto ret_result = me->GetValue(v1->i64);
		/*9404*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*9405*/
	} break;
		/*9406*/
	case CefListValue_GetBool_13: {
		/*9407*/


		// gen! bool GetBool(size_t index)
		auto ret_result = me->GetBool(v1->i64);
		/*9408*/
		MyCefSetBool(ret, ret_result);
		/*9409*/
	} break;
		/*9410*/
	case CefListValue_GetInt_14: {
		/*9411*/


		// gen! int GetInt(size_t index)
		auto ret_result = me->GetInt(v1->i64);
		/*9412*/
		MyCefSetInt64(ret, ret_result);
		/*9413*/
	} break;
		/*9414*/
	case CefListValue_GetDouble_15: {
		/*9415*/


		// gen! double GetDouble(size_t index)
		auto ret_result = me->GetDouble(v1->i64);
		/*9416*/
		MyCefSetDouble(ret, ret_result);
		/*9417*/
	} break;
		/*9418*/
	case CefListValue_GetString_16: {
		/*9419*/


		// gen! CefString GetString(size_t index)
		auto ret_result = me->GetString(v1->i64);
		/*9420*/
		SetCefStringToJsValue(ret, ret_result);
		/*9421*/
	} break;
		/*9422*/
	case CefListValue_GetBinary_17: {
		/*9423*/


		// gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
		auto ret_result = me->GetBinary(v1->i64);
		/*9424*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*9425*/
	} break;
		/*9426*/
	case CefListValue_GetDictionary_18: {
		/*9427*/


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
		auto ret_result = me->GetDictionary(v1->i64);
		/*9428*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*9429*/
	} break;
		/*9430*/
	case CefListValue_GetList_19: {
		/*9431*/


		// gen! CefRefPtr<CefListValue> GetList(size_t index)
		auto ret_result = me->GetList(v1->i64);
		/*9432*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*9433*/
	} break;
		/*9434*/
	case CefListValue_SetValue_20: {
		/*9435*/


		// gen! bool SetValue(size_t index,CefRefPtr<CefValue> value)
		auto ret_result = me->SetValue(v1->i64,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr));
		/*9436*/
		MyCefSetBool(ret, ret_result);
		/*9437*/
	} break;
		/*9438*/
	case CefListValue_SetNull_21: {
		/*9439*/


		// gen! bool SetNull(size_t index)
		auto ret_result = me->SetNull(v1->i64);
		/*9440*/
		MyCefSetBool(ret, ret_result);
		/*9441*/
	} break;
		/*9442*/
	case CefListValue_SetBool_22: {
		/*9443*/


		// gen! bool SetBool(size_t index,bool value)
		auto ret_result = me->SetBool(v1->i64,
			v2->i32 != 0);
		/*9444*/
		MyCefSetBool(ret, ret_result);
		/*9445*/
	} break;
		/*9446*/
	case CefListValue_SetInt_23: {
		/*9447*/


		// gen! bool SetInt(size_t index,int value)
		auto ret_result = me->SetInt(v1->i64,
			v2->i32);
		/*9448*/
		MyCefSetBool(ret, ret_result);
		/*9449*/
	} break;
		/*9450*/
	case CefListValue_SetDouble_24: {
		/*9451*/


		// gen! bool SetDouble(size_t index,double value)
		auto ret_result = me->SetDouble(v1->i64,
			v2->num);
		/*9452*/
		MyCefSetBool(ret, ret_result);
		/*9453*/
	} break;
		/*9454*/
	case CefListValue_SetString_25: {
		/*9455*/


		// gen! bool SetString(size_t index,const CefString& value)
		auto ret_result = me->SetString(v1->i64,
			GetStringHolder(v2)->value);
		/*9456*/
		MyCefSetBool(ret, ret_result);
		/*9457*/
	} break;
		/*9458*/
	case CefListValue_SetBinary_26: {
		/*9459*/


		// gen! bool SetBinary(size_t index,CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(v1->i64,
			CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v2->ptr));
		/*9460*/
		MyCefSetBool(ret, ret_result);
		/*9461*/
	} break;
		/*9462*/
	case CefListValue_SetDictionary_27: {
		/*9463*/


		// gen! bool SetDictionary(size_t index,CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(v1->i64,
			CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v2->ptr));
		/*9464*/
		MyCefSetBool(ret, ret_result);
		/*9465*/
	} break;
		/*9466*/
	case CefListValue_SetList_28: {
		/*9467*/


		// gen! bool SetList(size_t index,CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(v1->i64,
			CefListValueCToCpp::Wrap((cef_list_value_t*)v2->ptr));
		/*9468*/
		MyCefSetBool(ret, ret_result);
		/*9469*/
	} break;
		/*9470*/
	}
	/*9471*/
	CefListValueCToCpp::Unwrap(me);
	/*9472*/
}


// [virtual] class CefWebPluginInfo
/*9740*/
/*9736*/
const int CefWebPluginInfo_GetName_1 = 1;
/*9737*/
const int CefWebPluginInfo_GetPath_2 = 2;
/*9738*/
const int CefWebPluginInfo_GetVersion_3 = 3;
/*9739*/
const int CefWebPluginInfo_GetDescription_4 = 4;

void MyCefMet_CefWebPluginInfo(cef_web_plugin_info_t* me1, int metName, jsvalue* ret) {
	/*9741*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*9742*/
	auto me = CefWebPluginInfoCToCpp::Wrap(me1);
	/*9743*/
	switch (metName) {
		/*9744*/
	case MET_Release:return; //yes, just return
							 /*9745*/
	case CefWebPluginInfo_GetName_1: {
		/*9746*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*9747*/
		SetCefStringToJsValue(ret, ret_result);
		/*9748*/
	} break;
		/*9749*/
	case CefWebPluginInfo_GetPath_2: {
		/*9750*/


		// gen! CefString GetPath()
		auto ret_result = me->GetPath();
		/*9751*/
		SetCefStringToJsValue(ret, ret_result);
		/*9752*/
	} break;
		/*9753*/
	case CefWebPluginInfo_GetVersion_3: {
		/*9754*/


		// gen! CefString GetVersion()
		auto ret_result = me->GetVersion();
		/*9755*/
		SetCefStringToJsValue(ret, ret_result);
		/*9756*/
	} break;
		/*9757*/
	case CefWebPluginInfo_GetDescription_4: {
		/*9758*/


		// gen! CefString GetDescription()
		auto ret_result = me->GetDescription();
		/*9759*/
		SetCefStringToJsValue(ret, ret_result);
		/*9760*/
	} break;
		/*9761*/
	}
	/*9762*/
	CefWebPluginInfoCToCpp::Unwrap(me);
	/*9763*/
}


// [virtual] class CefWebPluginInfoVisitor
/*9803*/

void MyCefMet_CefWebPluginInfoVisitor(cef_web_plugin_info_visitor_t* me1, int metName, jsvalue* ret) {
	/*9804*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*9805*/
	auto me = CefWebPluginInfoVisitorCppToC::Unwrap(me1);
	/*9806*/
	switch (metName) {
		/*9807*/
	case MET_Release:return; //yes, just return
							 /*9808*/
	}
	/*9809*/
	CefWebPluginInfoVisitorCppToC::Wrap(me);
	/*9810*/
}


// [virtual] class CefX509CertPrincipal
/*9827*/
/*9818*/
const int CefX509CertPrincipal_GetDisplayName_1 = 1;
/*9819*/
const int CefX509CertPrincipal_GetCommonName_2 = 2;
/*9820*/
const int CefX509CertPrincipal_GetLocalityName_3 = 3;
/*9821*/
const int CefX509CertPrincipal_GetStateOrProvinceName_4 = 4;
/*9822*/
const int CefX509CertPrincipal_GetCountryName_5 = 5;
/*9823*/
const int CefX509CertPrincipal_GetStreetAddresses_6 = 6;
/*9824*/
const int CefX509CertPrincipal_GetOrganizationNames_7 = 7;
/*9825*/
const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = 8;
/*9826*/
const int CefX509CertPrincipal_GetDomainComponents_9 = 9;

void MyCefMet_CefX509CertPrincipal(cef_x509cert_principal_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*9828*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*9829*/
	auto me = CefX509CertPrincipalCToCpp::Wrap(me1);
	/*9830*/
	switch (metName) {
		/*9831*/
	case MET_Release:return; //yes, just return
							 /*9832*/
	case CefX509CertPrincipal_GetDisplayName_1: {
		/*9833*/


		// gen! CefString GetDisplayName()
		auto ret_result = me->GetDisplayName();
		/*9834*/
		SetCefStringToJsValue(ret, ret_result);
		/*9835*/
	} break;
		/*9836*/
	case CefX509CertPrincipal_GetCommonName_2: {
		/*9837*/


		// gen! CefString GetCommonName()
		auto ret_result = me->GetCommonName();
		/*9838*/
		SetCefStringToJsValue(ret, ret_result);
		/*9839*/
	} break;
		/*9840*/
	case CefX509CertPrincipal_GetLocalityName_3: {
		/*9841*/


		// gen! CefString GetLocalityName()
		auto ret_result = me->GetLocalityName();
		/*9842*/
		SetCefStringToJsValue(ret, ret_result);
		/*9843*/
	} break;
		/*9844*/
	case CefX509CertPrincipal_GetStateOrProvinceName_4: {
		/*9845*/


		// gen! CefString GetStateOrProvinceName()
		auto ret_result = me->GetStateOrProvinceName();
		/*9846*/
		SetCefStringToJsValue(ret, ret_result);
		/*9847*/
	} break;
		/*9848*/
	case CefX509CertPrincipal_GetCountryName_5: {
		/*9849*/


		// gen! CefString GetCountryName()
		auto ret_result = me->GetCountryName();
		/*9850*/
		SetCefStringToJsValue(ret, ret_result);
		/*9851*/
	} break;
		/*9852*/
	case CefX509CertPrincipal_GetStreetAddresses_6: {
		/*9853*/


		// gen! void GetStreetAddresses(std::vector<CefString>& addresses)
		me->GetStreetAddresses(*((std::vector<CefString>*)v1->ptr));
		/*9854*/

		/*9855*/
	} break;
		/*9856*/
	case CefX509CertPrincipal_GetOrganizationNames_7: {
		/*9857*/


		// gen! void GetOrganizationNames(std::vector<CefString>& names)
		me->GetOrganizationNames(*((std::vector<CefString>*)v1->ptr));
		/*9858*/

		/*9859*/
	} break;
		/*9860*/
	case CefX509CertPrincipal_GetOrganizationUnitNames_8: {
		/*9861*/


		// gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
		me->GetOrganizationUnitNames(*((std::vector<CefString>*)v1->ptr));
		/*9862*/

		/*9863*/
	} break;
		/*9864*/
	case CefX509CertPrincipal_GetDomainComponents_9: {
		/*9865*/


		// gen! void GetDomainComponents(std::vector<CefString>& components)
		me->GetDomainComponents(*((std::vector<CefString>*)v1->ptr));
		/*9866*/

		/*9867*/
	} break;
		/*9868*/
	}
	/*9869*/
	CefX509CertPrincipalCToCpp::Unwrap(me);
	/*9870*/
}


// [virtual] class CefX509Certificate
/*9960*/
/*9950*/
const int CefX509Certificate_GetSubject_1 = 1;
/*9951*/
const int CefX509Certificate_GetIssuer_2 = 2;
/*9952*/
const int CefX509Certificate_GetSerialNumber_3 = 3;
/*9953*/
const int CefX509Certificate_GetValidStart_4 = 4;
/*9954*/
const int CefX509Certificate_GetValidExpiry_5 = 5;
/*9955*/
const int CefX509Certificate_GetDEREncoded_6 = 6;
/*9956*/
const int CefX509Certificate_GetPEMEncoded_7 = 7;
/*9957*/
const int CefX509Certificate_GetIssuerChainSize_8 = 8;
/*9958*/
const int CefX509Certificate_GetDEREncodedIssuerChain_9 = 9;
/*9959*/
const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = 10;

void MyCefMet_CefX509Certificate(cef_x509certificate_t* me1, int metName, jsvalue* ret, jsvalue* v1) {
	/*9961*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*9962*/
	auto me = CefX509CertificateCToCpp::Wrap(me1);
	/*9963*/
	switch (metName) {
		/*9964*/
	case MET_Release:return; //yes, just return
							 /*9965*/
	case CefX509Certificate_GetSubject_1: {
		/*9966*/


		// gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
		auto ret_result = me->GetSubject();
		/*9967*/
		MyCefSetVoidPtr(ret, CefX509CertPrincipalCToCpp::Unwrap(ret_result));
		/*9968*/
	} break;
		/*9969*/
	case CefX509Certificate_GetIssuer_2: {
		/*9970*/


		// gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
		auto ret_result = me->GetIssuer();
		/*9971*/
		MyCefSetVoidPtr(ret, CefX509CertPrincipalCToCpp::Unwrap(ret_result));
		/*9972*/
	} break;
		/*9973*/
	case CefX509Certificate_GetSerialNumber_3: {
		/*9974*/


		// gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
		auto ret_result = me->GetSerialNumber();
		/*9975*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*9976*/
	} break;
		/*9977*/
	case CefX509Certificate_GetValidStart_4: {
		/*9978*/


		// gen! CefTime GetValidStart()
		auto ret_result = me->GetValidStart();
		/*9979*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*9980*/
	} break;
		/*9981*/
	case CefX509Certificate_GetValidExpiry_5: {
		/*9982*/


		// gen! CefTime GetValidExpiry()
		auto ret_result = me->GetValidExpiry();
		/*9983*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*9984*/
	} break;
		/*9985*/
	case CefX509Certificate_GetDEREncoded_6: {
		/*9986*/


		// gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
		auto ret_result = me->GetDEREncoded();
		/*9987*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*9988*/
	} break;
		/*9989*/
	case CefX509Certificate_GetPEMEncoded_7: {
		/*9990*/


		// gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
		auto ret_result = me->GetPEMEncoded();
		/*9991*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*9992*/
	} break;
		/*9993*/
	case CefX509Certificate_GetIssuerChainSize_8: {
		/*9994*/


		// gen! size_t GetIssuerChainSize()
		auto ret_result = me->GetIssuerChainSize();
		/*9995*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*9996*/
	} break;
		/*9997*/
	case CefX509Certificate_GetDEREncodedIssuerChain_9: {
		/*9998*/


		// gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
		me->GetDEREncodedIssuerChain(*((CefX509Certificate::IssuerChainBinaryList*)v1->ptr));
		/*9999*/

		/*10000*/
	} break;
		/*10001*/
	case CefX509Certificate_GetPEMEncodedIssuerChain_10: {
		/*10002*/


		// gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
		me->GetPEMEncodedIssuerChain(*((CefX509Certificate::IssuerChainBinaryList*)v1->ptr));
		/*10003*/

		/*10004*/
	} break;
		/*10005*/
	}
	/*10006*/
	CefX509CertificateCToCpp::Unwrap(me);
	/*10007*/
}


// [virtual] class CefXmlReader
/*10124*/
/*10095*/
const int CefXmlReader_MoveToNextNode_1 = 1;
/*10096*/
const int CefXmlReader_Close_2 = 2;
/*10097*/
const int CefXmlReader_HasError_3 = 3;
/*10098*/
const int CefXmlReader_GetError_4 = 4;
/*10099*/
const int CefXmlReader_GetType_5 = 5;
/*10100*/
const int CefXmlReader_GetDepth_6 = 6;
/*10101*/
const int CefXmlReader_GetLocalName_7 = 7;
/*10102*/
const int CefXmlReader_GetPrefix_8 = 8;
/*10103*/
const int CefXmlReader_GetQualifiedName_9 = 9;
/*10104*/
const int CefXmlReader_GetNamespaceURI_10 = 10;
/*10105*/
const int CefXmlReader_GetBaseURI_11 = 11;
/*10106*/
const int CefXmlReader_GetXmlLang_12 = 12;
/*10107*/
const int CefXmlReader_IsEmptyElement_13 = 13;
/*10108*/
const int CefXmlReader_HasValue_14 = 14;
/*10109*/
const int CefXmlReader_GetValue_15 = 15;
/*10110*/
const int CefXmlReader_HasAttributes_16 = 16;
/*10111*/
const int CefXmlReader_GetAttributeCount_17 = 17;
/*10112*/
const int CefXmlReader_GetAttribute_18 = 18;
/*10113*/
const int CefXmlReader_GetAttribute_19 = 19;
/*10114*/
const int CefXmlReader_GetAttribute_20 = 20;
/*10115*/
const int CefXmlReader_GetInnerXml_21 = 21;
/*10116*/
const int CefXmlReader_GetOuterXml_22 = 22;
/*10117*/
const int CefXmlReader_GetLineNumber_23 = 23;
/*10118*/
const int CefXmlReader_MoveToAttribute_24 = 24;
/*10119*/
const int CefXmlReader_MoveToAttribute_25 = 25;
/*10120*/
const int CefXmlReader_MoveToAttribute_26 = 26;
/*10121*/
const int CefXmlReader_MoveToFirstAttribute_27 = 27;
/*10122*/
const int CefXmlReader_MoveToNextAttribute_28 = 28;
/*10123*/
const int CefXmlReader_MoveToCarryingElement_29 = 29;

void MyCefMet_CefXmlReader(cef_xml_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*10125*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*10126*/
	auto me = CefXmlReaderCToCpp::Wrap(me1);
	/*10127*/
	switch (metName) {
		/*10128*/
	case MET_Release:return; //yes, just return
							 /*10129*/
	case CefXmlReader_MoveToNextNode_1: {
		/*10130*/


		// gen! bool MoveToNextNode()
		auto ret_result = me->MoveToNextNode();
		/*10131*/
		MyCefSetBool(ret, ret_result);
		/*10132*/
	} break;
		/*10133*/
	case CefXmlReader_Close_2: {
		/*10134*/


		// gen! bool Close()
		auto ret_result = me->Close();
		/*10135*/
		MyCefSetBool(ret, ret_result);
		/*10136*/
	} break;
		/*10137*/
	case CefXmlReader_HasError_3: {
		/*10138*/


		// gen! bool HasError()
		auto ret_result = me->HasError();
		/*10139*/
		MyCefSetBool(ret, ret_result);
		/*10140*/
	} break;
		/*10141*/
	case CefXmlReader_GetError_4: {
		/*10142*/


		// gen! CefString GetError()
		auto ret_result = me->GetError();
		/*10143*/
		SetCefStringToJsValue(ret, ret_result);
		/*10144*/
	} break;
		/*10145*/
	case CefXmlReader_GetType_5: {
		/*10146*/


		// gen! NodeType GetType()
		auto ret_result = me->GetType();
		/*10147*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*10148*/
	} break;
		/*10149*/
	case CefXmlReader_GetDepth_6: {
		/*10150*/


		// gen! int GetDepth()
		auto ret_result = me->GetDepth();
		/*10151*/
		MyCefSetInt64(ret, ret_result);
		/*10152*/
	} break;
		/*10153*/
	case CefXmlReader_GetLocalName_7: {
		/*10154*/


		// gen! CefString GetLocalName()
		auto ret_result = me->GetLocalName();
		/*10155*/
		SetCefStringToJsValue(ret, ret_result);
		/*10156*/
	} break;
		/*10157*/
	case CefXmlReader_GetPrefix_8: {
		/*10158*/


		// gen! CefString GetPrefix()
		auto ret_result = me->GetPrefix();
		/*10159*/
		SetCefStringToJsValue(ret, ret_result);
		/*10160*/
	} break;
		/*10161*/
	case CefXmlReader_GetQualifiedName_9: {
		/*10162*/


		// gen! CefString GetQualifiedName()
		auto ret_result = me->GetQualifiedName();
		/*10163*/
		SetCefStringToJsValue(ret, ret_result);
		/*10164*/
	} break;
		/*10165*/
	case CefXmlReader_GetNamespaceURI_10: {
		/*10166*/


		// gen! CefString GetNamespaceURI()
		auto ret_result = me->GetNamespaceURI();
		/*10167*/
		SetCefStringToJsValue(ret, ret_result);
		/*10168*/
	} break;
		/*10169*/
	case CefXmlReader_GetBaseURI_11: {
		/*10170*/


		// gen! CefString GetBaseURI()
		auto ret_result = me->GetBaseURI();
		/*10171*/
		SetCefStringToJsValue(ret, ret_result);
		/*10172*/
	} break;
		/*10173*/
	case CefXmlReader_GetXmlLang_12: {
		/*10174*/


		// gen! CefString GetXmlLang()
		auto ret_result = me->GetXmlLang();
		/*10175*/
		SetCefStringToJsValue(ret, ret_result);
		/*10176*/
	} break;
		/*10177*/
	case CefXmlReader_IsEmptyElement_13: {
		/*10178*/


		// gen! bool IsEmptyElement()
		auto ret_result = me->IsEmptyElement();
		/*10179*/
		MyCefSetBool(ret, ret_result);
		/*10180*/
	} break;
		/*10181*/
	case CefXmlReader_HasValue_14: {
		/*10182*/


		// gen! bool HasValue()
		auto ret_result = me->HasValue();
		/*10183*/
		MyCefSetBool(ret, ret_result);
		/*10184*/
	} break;
		/*10185*/
	case CefXmlReader_GetValue_15: {
		/*10186*/


		// gen! CefString GetValue()
		auto ret_result = me->GetValue();
		/*10187*/
		SetCefStringToJsValue(ret, ret_result);
		/*10188*/
	} break;
		/*10189*/
	case CefXmlReader_HasAttributes_16: {
		/*10190*/


		// gen! bool HasAttributes()
		auto ret_result = me->HasAttributes();
		/*10191*/
		MyCefSetBool(ret, ret_result);
		/*10192*/
	} break;
		/*10193*/
	case CefXmlReader_GetAttributeCount_17: {
		/*10194*/


		// gen! size_t GetAttributeCount()
		auto ret_result = me->GetAttributeCount();
		/*10195*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*10196*/
	} break;
		/*10197*/
	case CefXmlReader_GetAttribute_18: {
		/*10198*/


		// gen! CefString GetAttribute(int index)
		auto ret_result = me->GetAttribute(v1->i32);
		/*10199*/
		SetCefStringToJsValue(ret, ret_result);
		/*10200*/
	} break;
		/*10201*/
	case CefXmlReader_GetAttribute_19: {
		/*10202*/


		// gen! CefString GetAttribute(const CefString& qualifiedName)
		auto ret_result = me->GetAttribute(GetStringHolder(v1)->value);
		/*10203*/
		SetCefStringToJsValue(ret, ret_result);
		/*10204*/
	} break;
		/*10205*/
	case CefXmlReader_GetAttribute_20: {
		/*10206*/


		// gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)
		auto ret_result = me->GetAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*10207*/
		SetCefStringToJsValue(ret, ret_result);
		/*10208*/
	} break;
		/*10209*/
	case CefXmlReader_GetInnerXml_21: {
		/*10210*/


		// gen! CefString GetInnerXml()
		auto ret_result = me->GetInnerXml();
		/*10211*/
		SetCefStringToJsValue(ret, ret_result);
		/*10212*/
	} break;
		/*10213*/
	case CefXmlReader_GetOuterXml_22: {
		/*10214*/


		// gen! CefString GetOuterXml()
		auto ret_result = me->GetOuterXml();
		/*10215*/
		SetCefStringToJsValue(ret, ret_result);
		/*10216*/
	} break;
		/*10217*/
	case CefXmlReader_GetLineNumber_23: {
		/*10218*/


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		/*10219*/
		MyCefSetInt64(ret, ret_result);
		/*10220*/
	} break;
		/*10221*/
	case CefXmlReader_MoveToAttribute_24: {
		/*10222*/


		// gen! bool MoveToAttribute(int index)
		auto ret_result = me->MoveToAttribute(v1->i32);
		/*10223*/
		MyCefSetBool(ret, ret_result);
		/*10224*/
	} break;
		/*10225*/
	case CefXmlReader_MoveToAttribute_25: {
		/*10226*/


		// gen! bool MoveToAttribute(const CefString& qualifiedName)
		auto ret_result = me->MoveToAttribute(GetStringHolder(v1)->value);
		/*10227*/
		MyCefSetBool(ret, ret_result);
		/*10228*/
	} break;
		/*10229*/
	case CefXmlReader_MoveToAttribute_26: {
		/*10230*/


		// gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)
		auto ret_result = me->MoveToAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*10231*/
		MyCefSetBool(ret, ret_result);
		/*10232*/
	} break;
		/*10233*/
	case CefXmlReader_MoveToFirstAttribute_27: {
		/*10234*/


		// gen! bool MoveToFirstAttribute()
		auto ret_result = me->MoveToFirstAttribute();
		/*10235*/
		MyCefSetBool(ret, ret_result);
		/*10236*/
	} break;
		/*10237*/
	case CefXmlReader_MoveToNextAttribute_28: {
		/*10238*/


		// gen! bool MoveToNextAttribute()
		auto ret_result = me->MoveToNextAttribute();
		/*10239*/
		MyCefSetBool(ret, ret_result);
		/*10240*/
	} break;
		/*10241*/
	case CefXmlReader_MoveToCarryingElement_29: {
		/*10242*/


		// gen! bool MoveToCarryingElement()
		auto ret_result = me->MoveToCarryingElement();
		/*10243*/
		MyCefSetBool(ret, ret_result);
		/*10244*/
	} break;
		/*10245*/
	}
	/*10246*/
	CefXmlReaderCToCpp::Unwrap(me);
	/*10247*/
}


// [virtual] class CefZipReader
/*10519*/
/*10507*/
const int CefZipReader_MoveToFirstFile_1 = 1;
/*10508*/
const int CefZipReader_MoveToNextFile_2 = 2;
/*10509*/
const int CefZipReader_MoveToFile_3 = 3;
/*10510*/
const int CefZipReader_Close_4 = 4;
/*10511*/
const int CefZipReader_GetFileName_5 = 5;
/*10512*/
const int CefZipReader_GetFileSize_6 = 6;
/*10513*/
const int CefZipReader_GetFileLastModified_7 = 7;
/*10514*/
const int CefZipReader_OpenFile_8 = 8;
/*10515*/
const int CefZipReader_CloseFile_9 = 9;
/*10516*/
const int CefZipReader_ReadFile_10 = 10;
/*10517*/
const int CefZipReader_Tell_11 = 11;
/*10518*/
const int CefZipReader_Eof_12 = 12;

void MyCefMet_CefZipReader(cef_zip_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {
	/*10520*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*10521*/
	auto me = CefZipReaderCToCpp::Wrap(me1);
	/*10522*/
	switch (metName) {
		/*10523*/
	case MET_Release:return; //yes, just return
							 /*10524*/
	case CefZipReader_MoveToFirstFile_1: {
		/*10525*/


		// gen! bool MoveToFirstFile()
		auto ret_result = me->MoveToFirstFile();
		/*10526*/
		MyCefSetBool(ret, ret_result);
		/*10527*/
	} break;
		/*10528*/
	case CefZipReader_MoveToNextFile_2: {
		/*10529*/


		// gen! bool MoveToNextFile()
		auto ret_result = me->MoveToNextFile();
		/*10530*/
		MyCefSetBool(ret, ret_result);
		/*10531*/
	} break;
		/*10532*/
	case CefZipReader_MoveToFile_3: {
		/*10533*/


		// gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
		auto ret_result = me->MoveToFile(GetStringHolder(v1)->value,
			v2->i32 != 0);
		/*10534*/
		MyCefSetBool(ret, ret_result);
		/*10535*/
	} break;
		/*10536*/
	case CefZipReader_Close_4: {
		/*10537*/


		// gen! bool Close()
		auto ret_result = me->Close();
		/*10538*/
		MyCefSetBool(ret, ret_result);
		/*10539*/
	} break;
		/*10540*/
	case CefZipReader_GetFileName_5: {
		/*10541*/


		// gen! CefString GetFileName()
		auto ret_result = me->GetFileName();
		/*10542*/
		SetCefStringToJsValue(ret, ret_result);
		/*10543*/
	} break;
		/*10544*/
	case CefZipReader_GetFileSize_6: {
		/*10545*/


		// gen! int64 GetFileSize()
		auto ret_result = me->GetFileSize();
		/*10546*/
		MyCefSetInt64(ret, ret_result);
		/*10547*/
	} break;
		/*10548*/
	case CefZipReader_GetFileLastModified_7: {
		/*10549*/


		// gen! CefTime GetFileLastModified()
		auto ret_result = me->GetFileLastModified();
		/*10550*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*10551*/
	} break;
		/*10552*/
	case CefZipReader_OpenFile_8: {
		/*10553*/


		// gen! bool OpenFile(const CefString& password)
		auto ret_result = me->OpenFile(GetStringHolder(v1)->value);
		/*10554*/
		MyCefSetBool(ret, ret_result);
		/*10555*/
	} break;
		/*10556*/
	case CefZipReader_CloseFile_9: {
		/*10557*/


		// gen! bool CloseFile()
		auto ret_result = me->CloseFile();
		/*10558*/
		MyCefSetBool(ret, ret_result);
		/*10559*/
	} break;
		/*10560*/
	case CefZipReader_ReadFile_10: {
		/*10561*/


		// gen! int ReadFile(void* buffer,size_t bufferSize)
		auto ret_result = me->ReadFile((void*)v1->ptr,
			v2->i64);
		/*10562*/
		MyCefSetInt64(ret, ret_result);
		/*10563*/
	} break;
		/*10564*/
	case CefZipReader_Tell_11: {
		/*10565*/


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		/*10566*/
		MyCefSetInt64(ret, ret_result);
		/*10567*/
	} break;
		/*10568*/
	case CefZipReader_Eof_12: {
		/*10569*/


		// gen! bool Eof()
		auto ret_result = me->Eof();
		/*10570*/
		MyCefSetBool(ret, ret_result);
		/*10571*/
	} break;
		/*10572*/
	}
	/*10573*/
	CefZipReaderCToCpp::Unwrap(me);
	/*10574*/
}

/*10687*/
void MyCefMet_CallN(void* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7) {
	/*10688*/
	int cefTypeName = (metName >> 16);
	/*10689*/
	switch (cefTypeName)
		/*10690*/
	{
		/*10691*/
	default: break;
		/*10692*/
	case CefTypeName_CefApp:
		/*10693*/
	{
		/*10694*/
		MyCefMet_CefApp((cef_app_t*)me1, metName & 0xffff, ret
			/*10695*/
		);
		/*10696*/
		break;
		/*10697*/
	}
	/*10698*/
	case CefTypeName_CefBrowser:
		/*10699*/
	{
		/*10700*/
		MyCefMet_CefBrowser((cef_browser_t*)me1, metName & 0xffff, ret
			, v1, v2/*10701*/
		);
		/*10702*/
		break;
		/*10703*/
	}
	/*10704*/
	case CefTypeName_CefNavigationEntryVisitor:
		/*10705*/
	{
		/*10706*/
		MyCefMet_CefNavigationEntryVisitor((cef_navigation_entry_visitor_t*)me1, metName & 0xffff, ret
			/*10707*/
		);
		/*10708*/
		break;
		/*10709*/
	}
	/*10710*/
	case CefTypeName_CefBrowserHost:
		/*10711*/
	{
		/*10712*/
		MyCefMet_CefBrowserHost((cef_browser_host_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5, v6/*10713*/
		);
		/*10714*/
		break;
		/*10715*/
	}
	/*10716*/
	case CefTypeName_CefClient:
		/*10717*/
	{
		/*10718*/
		MyCefMet_CefClient((cef_client_t*)me1, metName & 0xffff, ret
			/*10719*/
		);
		/*10720*/
		break;
		/*10721*/
	}
	/*10722*/
	case CefTypeName_CefCommandLine:
		/*10723*/
	{
		/*10724*/
		MyCefMet_CefCommandLine((cef_command_line_t*)me1, metName & 0xffff, ret
			, v1, v2/*10725*/
		);
		/*10726*/
		break;
		/*10727*/
	}
	/*10728*/
	case CefTypeName_CefContextMenuParams:
		/*10729*/
	{
		/*10730*/
		MyCefMet_CefContextMenuParams((cef_context_menu_params_t*)me1, metName & 0xffff, ret
			, v1/*10731*/
		);
		/*10732*/
		break;
		/*10733*/
	}
	/*10734*/
	case CefTypeName_CefCookieManager:
		/*10735*/
	{
		/*10736*/
		MyCefMet_CefCookieManager((cef_cookie_manager_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10737*/
		);
		/*10738*/
		break;
		/*10739*/
	}
	/*10740*/
	case CefTypeName_CefCookieVisitor:
		/*10741*/
	{
		/*10742*/
		MyCefMet_CefCookieVisitor((cef_cookie_visitor_t*)me1, metName & 0xffff, ret
			/*10743*/
		);
		/*10744*/
		break;
		/*10745*/
	}
	/*10746*/
	case CefTypeName_CefDOMVisitor:
		/*10747*/
	{
		/*10748*/
		MyCefMet_CefDOMVisitor((cef_domvisitor_t*)me1, metName & 0xffff, ret
			/*10749*/
		);
		/*10750*/
		break;
		/*10751*/
	}
	/*10752*/
	case CefTypeName_CefDOMDocument:
		/*10753*/
	{
		/*10754*/
		MyCefMet_CefDOMDocument((cef_domdocument_t*)me1, metName & 0xffff, ret
			, v1/*10755*/
		);
		/*10756*/
		break;
		/*10757*/
	}
	/*10758*/
	case CefTypeName_CefDOMNode:
		/*10759*/
	{
		/*10760*/
		MyCefMet_CefDOMNode((cef_domnode_t*)me1, metName & 0xffff, ret
			, v1, v2/*10761*/
		);
		/*10762*/
		break;
		/*10763*/
	}
	/*10764*/
	case CefTypeName_CefDownloadItem:
		/*10765*/
	{
		/*10766*/
		MyCefMet_CefDownloadItem((cef_download_item_t*)me1, metName & 0xffff, ret
			/*10767*/
		);
		/*10768*/
		break;
		/*10769*/
	}
	/*10770*/
	case CefTypeName_CefDragData:
		/*10771*/
	{
		/*10772*/
		MyCefMet_CefDragData((cef_drag_data_t*)me1, metName & 0xffff, ret
			, v1, v2/*10773*/
		);
		/*10774*/
		break;
		/*10775*/
	}
	/*10776*/
	case CefTypeName_CefFrame:
		/*10777*/
	{
		/*10778*/
		MyCefMet_CefFrame((cef_frame_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10779*/
		);
		/*10780*/
		break;
		/*10781*/
	}
	/*10782*/
	case CefTypeName_CefImage:
		/*10783*/
	{
		/*10784*/
		//MyCefMet_CefImage((cef_image_t*)me1, metName & 0xffff, ret
		//	, v1, v2, v3, v4, v5, v6, v7/*10785*/
		//);
		/*10786*/
		break;
		/*10787*/
	}
	/*10788*/
	case CefTypeName_CefMenuModel:
		/*10789*/
	{
		/*10790*/
		MyCefMet_CefMenuModel((cef_menu_model_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5/*10791*/
		);
		/*10792*/
		break;
		/*10793*/
	}
	/*10794*/
	case CefTypeName_CefMenuModelDelegate:
		/*10795*/
	{
		/*10796*/
		MyCefMet_CefMenuModelDelegate((cef_menu_model_delegate_t*)me1, metName & 0xffff, ret
			/*10797*/
		);
		/*10798*/
		break;
		/*10799*/
	}
	/*10800*/
	case CefTypeName_CefNavigationEntry:
		/*10801*/
	{
		/*10802*/
		MyCefMet_CefNavigationEntry((cef_navigation_entry_t*)me1, metName & 0xffff, ret
			/*10803*/
		);
		/*10804*/
		break;
		/*10805*/
	}
	/*10806*/
	case CefTypeName_CefPrintSettings:
		/*10807*/
	{
		/*10808*/
		MyCefMet_CefPrintSettings((cef_print_settings_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10809*/
		);
		/*10810*/
		break;
		/*10811*/
	}
	/*10812*/
	case CefTypeName_CefProcessMessage:
		/*10813*/
	{
		/*10814*/
		MyCefMet_CefProcessMessage((cef_process_message_t*)me1, metName & 0xffff, ret
			/*10815*/
		);
		/*10816*/
		break;
		/*10817*/
	}
	/*10818*/
	case CefTypeName_CefRequest:
		/*10819*/
	{
		/*10820*/
		MyCefMet_CefRequest((cef_request_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4/*10821*/
		);
		/*10822*/
		break;
		/*10823*/
	}
	/*10824*/
	case CefTypeName_CefPostData:
		/*10825*/
	{
		/*10826*/
		MyCefMet_CefPostData((cef_post_data_t*)me1, metName & 0xffff, ret
			, v1/*10827*/
		);
		/*10828*/
		break;
		/*10829*/
	}
	/*10830*/
	case CefTypeName_CefPostDataElement:
		/*10831*/
	{
		/*10832*/
		MyCefMet_CefPostDataElement((cef_post_data_element_t*)me1, metName & 0xffff, ret
			, v1, v2/*10833*/
		);
		/*10834*/
		break;
		/*10835*/
	}
	/*10836*/
	case CefTypeName_CefRequestContext:
		/*10837*/
	{
		/*10838*/
		MyCefMet_CefRequestContext((cef_request_context_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10839*/
		);
		/*10840*/
		break;
		/*10841*/
	}
	/*10842*/
	case CefTypeName_CefResourceBundle:
		/*10843*/
	{
		/*10844*/
		MyCefMet_CefResourceBundle((cef_resource_bundle_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4/*10845*/
		);
		/*10846*/
		break;
		/*10847*/
	}
	/*10848*/
	case CefTypeName_CefResponse:
		/*10849*/
	{
		/*10850*/
		MyCefMet_CefResponse((cef_response_t*)me1, metName & 0xffff, ret
			, v1/*10851*/
		);
		/*10852*/
		break;
		/*10853*/
	}
	/*10854*/
	case CefTypeName_CefResponseFilter:
		/*10855*/
	{
		/*10856*/
		MyCefMet_CefResponseFilter((cef_response_filter_t*)me1, metName & 0xffff, ret
			/*10857*/
		);
		/*10858*/
		break;
		/*10859*/
	}
	/*10860*/
	case CefTypeName_CefSchemeHandlerFactory:
		/*10861*/
	{
		/*10862*/
		MyCefMet_CefSchemeHandlerFactory((cef_scheme_handler_factory_t*)me1, metName & 0xffff, ret
			/*10863*/
		);
		/*10864*/
		break;
		/*10865*/
	}
	/*10866*/
	case CefTypeName_CefSSLInfo:
		/*10867*/
	{
		/*10868*/
		MyCefMet_CefSSLInfo((cef_sslinfo_t*)me1, metName & 0xffff, ret
			/*10869*/
		);
		/*10870*/
		break;
		/*10871*/
	}
	/*10872*/
	case CefTypeName_CefSSLStatus:
		/*10873*/
	{
		/*10874*/
		MyCefMet_CefSSLStatus((cef_sslstatus_t*)me1, metName & 0xffff, ret
			/*10875*/
		);
		/*10876*/
		break;
		/*10877*/
	}
	/*10878*/
	case CefTypeName_CefStreamReader:
		/*10879*/
	{
		/*10880*/
		MyCefMet_CefStreamReader((cef_stream_reader_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10881*/
		);
		/*10882*/
		break;
		/*10883*/
	}
	/*10884*/
	case CefTypeName_CefStreamWriter:
		/*10885*/
	{
		/*10886*/
		MyCefMet_CefStreamWriter((cef_stream_writer_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10887*/
		);
		/*10888*/
		break;
		/*10889*/
	}
	/*10890*/
	case CefTypeName_CefStringVisitor:
		/*10891*/
	{
		/*10892*/
		MyCefMet_CefStringVisitor((cef_string_visitor_t*)me1, metName & 0xffff, ret
			/*10893*/
		);
		/*10894*/
		break;
		/*10895*/
	}
	/*10896*/
	case CefTypeName_CefTask:
		/*10897*/
	{
		/*10898*/
		MyCefMet_CefTask((cef_task_t*)me1, metName & 0xffff, ret
			/*10899*/
		);
		/*10900*/
		break;
		/*10901*/
	}
	/*10902*/
	case CefTypeName_CefTaskRunner:
		/*10903*/
	{
		/*10904*/
		MyCefMet_CefTaskRunner((cef_task_runner_t*)me1, metName & 0xffff, ret
			, v1, v2/*10905*/
		);
		/*10906*/
		break;
		/*10907*/
	}
	/*10908*/
	case CefTypeName_CefURLRequest:
		/*10909*/
	{
		/*10910*/
		MyCefMet_CefURLRequest((cef_urlrequest_t*)me1, metName & 0xffff, ret
			/*10911*/
		);
		/*10912*/
		break;
		/*10913*/
	}
	/*10914*/
	case CefTypeName_CefURLRequestClient:
		/*10915*/
	{
		/*10916*/
		MyCefMet_CefURLRequestClient((cef_urlrequest_client_t*)me1, metName & 0xffff, ret
			/*10917*/
		);
		/*10918*/
		break;
		/*10919*/
	}
	/*10920*/
	case CefTypeName_CefV8Context:
		/*10921*/
	{
		/*10922*/
		MyCefMet_CefV8Context((cef_v8context_t*)me1, metName & 0xffff, ret
			, v1, v2, v3, v4, v5/*10923*/
		);
		/*10924*/
		break;
		/*10925*/
	}
	/*10926*/
	case CefTypeName_CefV8Accessor:
		/*10927*/
	{
		/*10928*/
		MyCefMet_CefV8Accessor((cef_v8accessor_t*)me1, metName & 0xffff, ret
			/*10929*/
		);
		/*10930*/
		break;
		/*10931*/
	}
	/*10932*/
	case CefTypeName_CefV8Interceptor:
		/*10933*/
	{
		/*10934*/
		MyCefMet_CefV8Interceptor((cef_v8interceptor_t*)me1, metName & 0xffff, ret
			/*10935*/
		);
		/*10936*/
		break;
		/*10937*/
	}
	/*10938*/
	case CefTypeName_CefV8Exception:
		/*10939*/
	{
		/*10940*/
		MyCefMet_CefV8Exception((cef_v8exception_t*)me1, metName & 0xffff, ret
			/*10941*/
		);
		/*10942*/
		break;
		/*10943*/
	}
	/*10944*/
	case CefTypeName_CefV8Value:
		/*10945*/
	{
		/*10946*/
		MyCefMet_CefV8Value((cef_v8value_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10947*/
		);
		/*10948*/
		break;
		/*10949*/
	}
	/*10950*/
	case CefTypeName_CefV8StackTrace:
		/*10951*/
	{
		/*10952*/
		MyCefMet_CefV8StackTrace((cef_v8stack_trace_t*)me1, metName & 0xffff, ret
			, v1/*10953*/
		);
		/*10954*/
		break;
		/*10955*/
	}
	/*10956*/
	case CefTypeName_CefV8StackFrame:
		/*10957*/
	{
		/*10958*/
		MyCefMet_CefV8StackFrame((cef_v8stack_frame_t*)me1, metName & 0xffff, ret
			/*10959*/
		);
		/*10960*/
		break;
		/*10961*/
	}
	/*10962*/
	case CefTypeName_CefValue:
		/*10963*/
	{
		/*10964*/
		MyCefMet_CefValue((cef_value_t*)me1, metName & 0xffff, ret
			, v1/*10965*/
		);
		/*10966*/
		break;
		/*10967*/
	}
	/*10968*/
	case CefTypeName_CefBinaryValue:
		/*10969*/
	{
		/*10970*/
		MyCefMet_CefBinaryValue((cef_binary_value_t*)me1, metName & 0xffff, ret
			, v1, v2, v3/*10971*/
		);
		/*10972*/
		break;
		/*10973*/
	}
	/*10974*/
	case CefTypeName_CefDictionaryValue:
		/*10975*/
	{
		/*10976*/
		MyCefMet_CefDictionaryValue((cef_dictionary_value_t*)me1, metName & 0xffff, ret
			, v1, v2/*10977*/
		);
		/*10978*/
		break;
		/*10979*/
	}
	/*10980*/
	case CefTypeName_CefListValue:
		/*10981*/
	{
		/*10982*/
		MyCefMet_CefListValue((cef_list_value_t*)me1, metName & 0xffff, ret
			, v1, v2/*10983*/
		);
		/*10984*/
		break;
		/*10985*/
	}
	/*10986*/
	case CefTypeName_CefWebPluginInfo:
		/*10987*/
	{
		/*10988*/
		MyCefMet_CefWebPluginInfo((cef_web_plugin_info_t*)me1, metName & 0xffff, ret
			/*10989*/
		);
		/*10990*/
		break;
		/*10991*/
	}
	/*10992*/
	case CefTypeName_CefWebPluginInfoVisitor:
		/*10993*/
	{
		/*10994*/
		MyCefMet_CefWebPluginInfoVisitor((cef_web_plugin_info_visitor_t*)me1, metName & 0xffff, ret
			/*10995*/
		);
		/*10996*/
		break;
		/*10997*/
	}
	/*10998*/
	case CefTypeName_CefX509CertPrincipal:
		/*10999*/
	{
		/*11000*/
		MyCefMet_CefX509CertPrincipal((cef_x509cert_principal_t*)me1, metName & 0xffff, ret
			, v1/*11001*/
		);
		/*11002*/
		break;
		/*11003*/
	}
	/*11004*/
	case CefTypeName_CefX509Certificate:
		/*11005*/
	{
		/*11006*/
		MyCefMet_CefX509Certificate((cef_x509certificate_t*)me1, metName & 0xffff, ret
			, v1/*11007*/
		);
		/*11008*/
		break;
		/*11009*/
	}
	/*11010*/
	case CefTypeName_CefXmlReader:
		/*11011*/
	{
		/*11012*/
		MyCefMet_CefXmlReader((cef_xml_reader_t*)me1, metName & 0xffff, ret
			, v1, v2/*11013*/
		);
		/*11014*/
		break;
		/*11015*/
	}
	/*11016*/
	case CefTypeName_CefZipReader:
		/*11017*/
	{
		/*11018*/
		MyCefMet_CefZipReader((cef_zip_reader_t*)me1, metName & 0xffff, ret
			, v1, v2/*11019*/
		);
		/*11020*/
		break;
		/*11021*/
	}
	/*11022*/
	}
	/*11023*/
}

 