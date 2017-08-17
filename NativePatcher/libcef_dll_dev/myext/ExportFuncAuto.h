//MIT, 2015-2017, WinterDev
#pragma once

//for auto gen content

#include "myext.h"

#include "include/internal/cef_types.h"
#include "include/wrapper/cef_helpers.h"

//
#include "include/capi/cef_resource_bundle_handler_capi.h"
#include "include/capi/cef_resource_bundle_capi.h"
#include "include/capi/cef_xml_reader_capi.h"
#include "include/capi/cef_zip_reader_capi.h"
#include "include/capi/cef_print_handler_capi.h"
#include "include/capi/cef_print_settings_capi.h"
#include "include/capi/cef_command_line_capi.h"
#include "include/capi/cef_urlrequest_capi.h"
#include "include/capi/cef_app_capi.h"

//for auto gen content  
//
#include "libcef_dll/ctocpp/frame_ctocpp.h"
#include "libcef_dll/ctocpp/browser_ctocpp.h"
#include "libcef_dll/ctocpp/v8context_ctocpp.h"
#include "libcef_dll/ctocpp/browser_host_ctocpp.h"
#include "libcef_dll/ctocpp/process_message_ctocpp.h"
#include "libcef_dll/ctocpp/drag_data_ctocpp.h"
#include "libcef_dll/ctocpp/navigation_entry_ctocpp.h"
#include "libcef_dll/ctocpp/request_context_ctocpp.h"
#include "libcef_dll/ctocpp/domdocument_ctocpp.h"
#include "libcef_dll/ctocpp/domnode_ctocpp.h"
#include "libcef_dll/ctocpp/download_item_callback_ctocpp.h"
#include "libcef_dll/ctocpp/download_item_ctocpp.h"
#include "libcef_dll/ctocpp/stream_writer_ctocpp.h"
#include "libcef_dll/ctocpp/stream_reader_ctocpp.h"
#include "libcef_dll/ctocpp/image_ctocpp.h"
#include "libcef_dll/ctocpp/request_ctocpp.h"
#include "libcef_dll/ctocpp/request_context_ctocpp.h"
#include "libcef_dll/ctocpp/request_callback_ctocpp.h"
#include "libcef_dll/ctocpp/binary_value_ctocpp.h"
#include "libcef_dll/ctocpp/post_data_ctocpp.h"
#include "libcef_dll/ctocpp/post_data_element_ctocpp.h"
#include "libcef_dll/ctocpp/resource_bundle_ctocpp.h"
#include "libcef_dll/ctocpp/sslinfo_ctocpp.h"
#include "libcef_dll/ctocpp/sslstatus_ctocpp.h"
#include "libcef_dll/ctocpp/x509cert_principal_ctocpp.h"
#include "libcef_dll/ctocpp/x509certificate_ctocpp.h"
#include "libcef_dll/ctocpp/task_runner_ctocpp.h"
#include "libcef_dll/ctocpp/web_plugin_info_ctocpp.h"
#include "libcef_dll/ctocpp/xml_reader_ctocpp.h"
#include "libcef_dll/ctocpp/zip_reader_ctocpp.h"
#include "libcef_dll/ctocpp/command_line_ctocpp.h"
//
#include "libcef_dll/ctocpp/v8context_ctocpp.h"
#include "libcef_dll/ctocpp/v8exception_ctocpp.h"
#include "libcef_dll/ctocpp/v8stack_frame_ctocpp.h"
#include "libcef_dll/ctocpp/v8stack_trace_ctocpp.h"
#include "libcef_dll/ctocpp/v8value_ctocpp.h"
#include "libcef_dll/ctocpp/context_menu_params_ctocpp.h"
#include "libcef_dll/ctocpp/cookie_manager_ctocpp.h"
#include "libcef_dll/ctocpp/run_context_menu_callback_ctocpp.h"
#include "libcef_dll/ctocpp/menu_model_ctocpp.h"
#include "libcef_dll/ctocpp/print_settings_ctocpp.h"
#include "libcef_dll/ctocpp/response_ctocpp.h"
#include "libcef_dll/ctocpp/urlrequest_ctocpp.h"
//
#include "libcef_dll/ctocpp/callback_ctocpp.h"
#include "libcef_dll/ctocpp/value_ctocpp.h"
#include "libcef_dll/ctocpp/dictionary_value_ctocpp.h"
#include "libcef_dll/ctocpp/list_value_ctocpp.h"
#include "libcef_dll/ctocpp/select_client_certificate_callback_ctocpp.h"
#include "libcef_dll/ctocpp/auth_callback_ctocpp.h"
#include "libcef_dll/ctocpp/jsdialog_callback_ctocpp.h"
#include "libcef_dll/ctocpp/geolocation_callback_ctocpp.h"
#include "libcef_dll/ctocpp/file_dialog_callback_ctocpp.h"
#include "libcef_dll/ctocpp/before_download_callback_ctocpp.h"
#include "libcef_dll/ctocpp/print_dialog_callback_ctocpp.h"
#include "libcef_dll/ctocpp/print_job_callback_ctocpp.h"
#include "libcef_dll/myext/MyCefStringHolder.h"

//
extern "C" {

	MY_DLL_EXPORT void MyCefMet_CallN(void* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7);
	MY_DLL_EXPORT void* NewInstance(int typeName, managed_callback mcallback, jsvalue* jsvalue);
}

inline void SetCefStringToJsValue(jsvalue* value, const CefString&cefstr) {

	MyCefStringHolder* str = new MyCefStringHolder();
	str->value = cefstr;
	//
	value->type = JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;
	value->ptr = str;
	value->i32 = str->value.length();
}
inline void SetCefStringToJsValue2(jsvalue* value, const CefString&cefstr) {

	//not need MyCefStringHolder
	value->type = JSVALUE_TYPE_NATIVE_CEFSTRING;
	value->ptr = &cefstr;
	value->i32 = cefstr.length();
}
inline void DeleteCefStringHolderFromJsValue(jsvalue* value) {
	value->i32 = 0;
	delete value->ptr;
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
inline void MyCefSetBool(jsvalue* value, int data)
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
namespace CefAccessibilityHandlerExt
{
	const int _typeName = CefTypeName_CefAccessibilityHandler;
	const int CefAccessibilityHandlerExt_OnAccessibilityTreeChange_1 = 1;
	const int CefAccessibilityHandlerExt_OnAccessibilityLocationChange_2 = 2;

	//gen! void OnAccessibilityTreeChange(CefRefPtr<CefValue> value)
	void OnAccessibilityTreeChange(managed_callback mcallback, CefRefPtr<CefValue> value);

	//gen! void OnAccessibilityLocationChange(CefRefPtr<CefValue> value)
	void OnAccessibilityLocationChange(managed_callback mcallback, CefRefPtr<CefValue> value);
}
namespace CefBrowserProcessHandlerExt
{
	const int _typeName = CefTypeName_CefBrowserProcessHandler;
	const int CefBrowserProcessHandlerExt_OnContextInitialized_1 = 1;
	const int CefBrowserProcessHandlerExt_OnBeforeChildProcessLaunch_2 = 2;
	const int CefBrowserProcessHandlerExt_OnRenderProcessThreadCreated_3 = 3;
	const int CefBrowserProcessHandlerExt_GetPrintHandler_4 = 4;
	const int CefBrowserProcessHandlerExt_OnScheduleMessagePumpWork_5 = 5;

	//gen! void OnContextInitialized()
	void OnContextInitialized(managed_callback mcallback);

	//gen! void OnBeforeChildProcessLaunch(CefRefPtr<CefCommandLine> command_line)
	void OnBeforeChildProcessLaunch(managed_callback mcallback, CefRefPtr<CefCommandLine> command_line);

	//gen! void OnRenderProcessThreadCreated(CefRefPtr<CefListValue> extra_info)
	void OnRenderProcessThreadCreated(managed_callback mcallback, CefRefPtr<CefListValue> extra_info);

	//gen! CefRefPtr<CefPrintHandler> GetPrintHandler()
	CefRefPtr<CefPrintHandler> GetPrintHandler(managed_callback mcallback);

	//gen! void OnScheduleMessagePumpWork(int64 delay_ms)
	void OnScheduleMessagePumpWork(managed_callback mcallback, int64 delay_ms);
}
namespace CefContextMenuHandlerExt
{
	const int _typeName = CefTypeName_CefContextMenuHandler;
	const int CefContextMenuHandlerExt_OnBeforeContextMenu_1 = 1;
	const int CefContextMenuHandlerExt_RunContextMenu_2 = 2;
	const int CefContextMenuHandlerExt_OnContextMenuCommand_3 = 3;
	const int CefContextMenuHandlerExt_OnContextMenuDismissed_4 = 4;

	//gen! void OnBeforeContextMenu(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,CefRefPtr<CefMenuModel> model)
	void OnBeforeContextMenu(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> params, CefRefPtr<CefMenuModel> model);

	//gen! bool RunContextMenu(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,CefRefPtr<CefMenuModel> model,CefRefPtr<CefRunContextMenuCallback> callback)
	bool RunContextMenu(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> params, CefRefPtr<CefMenuModel> model, CefRefPtr<CefRunContextMenuCallback> callback);

	//gen! bool OnContextMenuCommand(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,int command_id,EventFlags event_flags)
	bool OnContextMenuCommand(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> params, int command_id, cef_event_flags_t event_flags);

	//gen! void OnContextMenuDismissed(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame)
	void OnContextMenuDismissed(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame);
}
namespace CefDialogHandlerExt
{
	const int _typeName = CefTypeName_CefDialogHandler;
	const int CefDialogHandlerExt_OnFileDialog_1 = 1;

	//gen! bool OnFileDialog(CefRefPtr<CefBrowser> browser,FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefFileDialogCallback> callback)
	bool OnFileDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_file_dialog_mode_t mode, const CefString& title, const CefString& default_file_path, const std::vector<CefString>& accept_filters, int selected_accept_filter, CefRefPtr<CefFileDialogCallback> callback);
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

	//gen! void OnAddressChange(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& url)
	void OnAddressChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& url);

	//gen! void OnTitleChange(CefRefPtr<CefBrowser> browser,const CefString& title)
	void OnTitleChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& title);

	//gen! void OnFaviconURLChange(CefRefPtr<CefBrowser> browser,const std::vector<CefString>& icon_urls)
	void OnFaviconURLChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const std::vector<CefString>& icon_urls);

	//gen! void OnFullscreenModeChange(CefRefPtr<CefBrowser> browser,bool fullscreen)
	void OnFullscreenModeChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool fullscreen);

	//gen! bool OnTooltip(CefRefPtr<CefBrowser> browser,CefString& text)
	bool OnTooltip(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefString& text);

	//gen! void OnStatusMessage(CefRefPtr<CefBrowser> browser,const CefString& value)
	void OnStatusMessage(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& value);

	//gen! bool OnConsoleMessage(CefRefPtr<CefBrowser> browser,const CefString& message,const CefString& source,int line)
	bool OnConsoleMessage(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& message, const CefString& source, int line);
}
namespace CefDownloadHandlerExt
{
	const int _typeName = CefTypeName_CefDownloadHandler;
	const int CefDownloadHandlerExt_OnBeforeDownload_1 = 1;
	const int CefDownloadHandlerExt_OnDownloadUpdated_2 = 2;

	//gen! void OnBeforeDownload(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDownloadItem> download_item,const CefString& suggested_name,CefRefPtr<CefBeforeDownloadCallback> callback)
	void OnBeforeDownload(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, const CefString& suggested_name, CefRefPtr<CefBeforeDownloadCallback> callback);

	//gen! void OnDownloadUpdated(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDownloadItem> download_item,CefRefPtr<CefDownloadItemCallback> callback)
	void OnDownloadUpdated(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, CefRefPtr<CefDownloadItemCallback> callback);
}
namespace CefDragHandlerExt
{
	const int _typeName = CefTypeName_CefDragHandler;
	const int CefDragHandlerExt_OnDragEnter_1 = 1;
	const int CefDragHandlerExt_OnDraggableRegionsChanged_2 = 2;

	//gen! bool OnDragEnter(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDragData> dragData,DragOperationsMask mask)
	bool OnDragEnter(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> dragData, cef_drag_operations_mask_t mask);

	//gen! void OnDraggableRegionsChanged(CefRefPtr<CefBrowser> browser,const std::vector<CefDraggableRegion>& regions)
	void OnDraggableRegionsChanged(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const std::vector<CefDraggableRegion>& regions);
}
namespace CefFindHandlerExt
{
	const int _typeName = CefTypeName_CefFindHandler;
	const int CefFindHandlerExt_OnFindResult_1 = 1;

	//gen! void OnFindResult(CefRefPtr<CefBrowser> browser,int identifier,int count,const CefRect& selectionRect,int activeMatchOrdinal,bool finalUpdate)
	void OnFindResult(managed_callback mcallback, CefRefPtr<CefBrowser> browser, int identifier, int count, const CefRect& selectionRect, int activeMatchOrdinal, bool finalUpdate);
}
namespace CefFocusHandlerExt
{
	const int _typeName = CefTypeName_CefFocusHandler;
	const int CefFocusHandlerExt_OnTakeFocus_1 = 1;
	const int CefFocusHandlerExt_OnSetFocus_2 = 2;
	const int CefFocusHandlerExt_OnGotFocus_3 = 3;

	//gen! void OnTakeFocus(CefRefPtr<CefBrowser> browser,bool next)
	void OnTakeFocus(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool next);

	//gen! bool OnSetFocus(CefRefPtr<CefBrowser> browser,FocusSource source)
	bool OnSetFocus(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_focus_source_t source);

	//gen! void OnGotFocus(CefRefPtr<CefBrowser> browser)
	void OnGotFocus(managed_callback mcallback, CefRefPtr<CefBrowser> browser);
}
namespace CefGeolocationHandlerExt
{
	const int _typeName = CefTypeName_CefGeolocationHandler;
	const int CefGeolocationHandlerExt_OnRequestGeolocationPermission_1 = 1;
	const int CefGeolocationHandlerExt_OnCancelGeolocationPermission_2 = 2;

	//gen! bool OnRequestGeolocationPermission(CefRefPtr<CefBrowser> browser,const CefString& requesting_url,int request_id,CefRefPtr<CefGeolocationCallback> callback)
	bool OnRequestGeolocationPermission(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& requesting_url, int request_id, CefRefPtr<CefGeolocationCallback> callback);

	//gen! void OnCancelGeolocationPermission(CefRefPtr<CefBrowser> browser,int request_id)
	void OnCancelGeolocationPermission(managed_callback mcallback, CefRefPtr<CefBrowser> browser, int request_id);
}
namespace CefJSDialogHandlerExt
{
	const int _typeName = CefTypeName_CefJSDialogHandler;
	const int CefJSDialogHandlerExt_OnJSDialog_1 = 1;
	const int CefJSDialogHandlerExt_OnBeforeUnloadDialog_2 = 2;
	const int CefJSDialogHandlerExt_OnResetDialogState_3 = 3;
	const int CefJSDialogHandlerExt_OnDialogClosed_4 = 4;

	//gen! bool OnJSDialog(CefRefPtr<CefBrowser> browser,const CefString& origin_url,JSDialogType dialog_type,const CefString& message_text,const CefString& default_prompt_text,CefRefPtr<CefJSDialogCallback> callback,bool& suppress_message)
	bool OnJSDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& origin_url, cef_jsdialog_type_t dialog_type, const CefString& message_text, const CefString& default_prompt_text, CefRefPtr<CefJSDialogCallback> callback, bool& suppress_message);

	//gen! bool OnBeforeUnloadDialog(CefRefPtr<CefBrowser> browser,const CefString& message_text,bool is_reload,CefRefPtr<CefJSDialogCallback> callback)
	bool OnBeforeUnloadDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& message_text, bool is_reload, CefRefPtr<CefJSDialogCallback> callback);

	//gen! void OnResetDialogState(CefRefPtr<CefBrowser> browser)
	void OnResetDialogState(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnDialogClosed(CefRefPtr<CefBrowser> browser)
	void OnDialogClosed(managed_callback mcallback, CefRefPtr<CefBrowser> browser);
}
namespace CefKeyboardHandlerExt
{
	const int _typeName = CefTypeName_CefKeyboardHandler;
	const int CefKeyboardHandlerExt_OnPreKeyEvent_1 = 1;
	const int CefKeyboardHandlerExt_OnKeyEvent_2 = 2;

	//gen! bool OnPreKeyEvent(CefRefPtr<CefBrowser> browser,const CefKeyEvent& event,CefEventHandle os_event,bool* is_keyboard_shortcut)
	bool OnPreKeyEvent(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefKeyEvent& event, CefEventHandle os_event, bool* is_keyboard_shortcut);

	//gen! bool OnKeyEvent(CefRefPtr<CefBrowser> browser,const CefKeyEvent& event,CefEventHandle os_event)
	bool OnKeyEvent(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefKeyEvent& event, CefEventHandle os_event);
}
namespace CefLifeSpanHandlerExt
{
	const int _typeName = CefTypeName_CefLifeSpanHandler;
	const int CefLifeSpanHandlerExt_OnBeforePopup_1 = 1;
	const int CefLifeSpanHandlerExt_OnAfterCreated_2 = 2;
	const int CefLifeSpanHandlerExt_DoClose_3 = 3;
	const int CefLifeSpanHandlerExt_OnBeforeClose_4 = 4;

	//gen! bool OnBeforePopup(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& target_url,const CefString& target_frame_name,WindowOpenDisposition target_disposition,bool user_gesture,const CefPopupFeatures& popupFeatures,CefWindowInfo& windowInfo,CefRefPtr<CefClient>& client,CefBrowserSettings& settings,bool* no_javascript_access)
	bool OnBeforePopup(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, const CefString& target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures& popupFeatures, CefWindowInfo& windowInfo, CefRefPtr<CefClient>& client, CefBrowserSettings& settings, bool* no_javascript_access);

	//gen! void OnAfterCreated(CefRefPtr<CefBrowser> browser)
	void OnAfterCreated(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! bool DoClose(CefRefPtr<CefBrowser> browser)
	bool DoClose(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnBeforeClose(CefRefPtr<CefBrowser> browser)
	void OnBeforeClose(managed_callback mcallback, CefRefPtr<CefBrowser> browser);
}
namespace CefLoadHandlerExt
{
	const int _typeName = CefTypeName_CefLoadHandler;
	const int CefLoadHandlerExt_OnLoadingStateChange_1 = 1;
	const int CefLoadHandlerExt_OnLoadStart_2 = 2;
	const int CefLoadHandlerExt_OnLoadEnd_3 = 3;
	const int CefLoadHandlerExt_OnLoadError_4 = 4;

	//gen! void OnLoadingStateChange(CefRefPtr<CefBrowser> browser,bool isLoading,bool canGoBack,bool canGoForward)
	void OnLoadingStateChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool isLoading, bool canGoBack, bool canGoForward);

	//gen! void OnLoadStart(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,TransitionType transition_type)
	void OnLoadStart(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_transition_type_t transition_type);

	//gen! void OnLoadEnd(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,int httpStatusCode)
	void OnLoadEnd(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, int httpStatusCode);

	//gen! void OnLoadError(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,ErrorCode errorCode,const CefString& errorText,const CefString& failedUrl)
	void OnLoadError(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_errorcode_t errorCode, const CefString& errorText, const CefString& failedUrl);
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

	//gen! void OnPrintStart(CefRefPtr<CefBrowser> browser)
	void OnPrintStart(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnPrintSettings(CefRefPtr<CefBrowser> browser,CefRefPtr<CefPrintSettings> settings,bool get_defaults)
	void OnPrintSettings(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefPrintSettings> settings, bool get_defaults);

	//gen! bool OnPrintDialog(CefRefPtr<CefBrowser> browser,bool has_selection,CefRefPtr<CefPrintDialogCallback> callback)
	bool OnPrintDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool has_selection, CefRefPtr<CefPrintDialogCallback> callback);

	//gen! bool OnPrintJob(CefRefPtr<CefBrowser> browser,const CefString& document_name,const CefString& pdf_file_path,CefRefPtr<CefPrintJobCallback> callback)
	bool OnPrintJob(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& document_name, const CefString& pdf_file_path, CefRefPtr<CefPrintJobCallback> callback);

	//gen! void OnPrintReset(CefRefPtr<CefBrowser> browser)
	void OnPrintReset(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! CefSize GetPdfPaperSize(int device_units_per_inch)
	CefSize GetPdfPaperSize(managed_callback mcallback, int device_units_per_inch);
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

	//gen! CefRefPtr<CefAccessibilityHandler> GetAccessibilityHandler()
	CefRefPtr<CefAccessibilityHandler> GetAccessibilityHandler(managed_callback mcallback);

	//gen! bool GetRootScreenRect(CefRefPtr<CefBrowser> browser,CefRect& rect)
	bool GetRootScreenRect(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRect& rect);

	//gen! bool GetViewRect(CefRefPtr<CefBrowser> browser,CefRect& rect)
	bool GetViewRect(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRect& rect);

	//gen! bool GetScreenPoint(CefRefPtr<CefBrowser> browser,int viewX,int viewY,int& screenX,int& screenY)
	bool GetScreenPoint(managed_callback mcallback, CefRefPtr<CefBrowser> browser, int viewX, int viewY, int& screenX, int& screenY);

	//gen! bool GetScreenInfo(CefRefPtr<CefBrowser> browser,CefScreenInfo& screen_info)
	bool GetScreenInfo(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefScreenInfo& screen_info);

	//gen! void OnPopupShow(CefRefPtr<CefBrowser> browser,bool show)
	void OnPopupShow(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool show);

	//gen! void OnPopupSize(CefRefPtr<CefBrowser> browser,const CefRect& rect)
	void OnPopupSize(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefRect& rect);

	//gen! void OnPaint(CefRefPtr<CefBrowser> browser,PaintElementType type,const RectList& dirtyRects,const void* buffer,int width,int height)
	void OnPaint(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_paint_element_type_t type, const std::vector<CefRect>& dirtyRects, const void* buffer, int width, int height);

	//gen! void OnCursorChange(CefRefPtr<CefBrowser> browser,CefCursorHandle cursor,CursorType type,const CefCursorInfo& custom_cursor_info)
	void OnCursorChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefCursorHandle cursor, cef_cursor_type_t type, const CefCursorInfo& custom_cursor_info);

	//gen! bool StartDragging(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDragData> drag_data,DragOperationsMask allowed_ops,int x,int y)
	bool StartDragging(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y);

	//gen! void UpdateDragCursor(CefRefPtr<CefBrowser> browser,DragOperation operation)
	void UpdateDragCursor(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_drag_operations_mask_t operation);

	//gen! void OnScrollOffsetChanged(CefRefPtr<CefBrowser> browser,double x,double y)
	void OnScrollOffsetChanged(managed_callback mcallback, CefRefPtr<CefBrowser> browser, double x, double y);

	//gen! void OnImeCompositionRangeChanged(CefRefPtr<CefBrowser> browser,const CefRange& selected_range,const RectList& character_bounds)
	void OnImeCompositionRangeChanged(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefRange& selected_range, const std::vector<CefRect>& character_bounds);
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

	//gen! void OnRenderThreadCreated(CefRefPtr<CefListValue> extra_info)
	void OnRenderThreadCreated(managed_callback mcallback, CefRefPtr<CefListValue> extra_info);

	//gen! void OnWebKitInitialized()
	void OnWebKitInitialized(managed_callback mcallback);

	//gen! void OnBrowserCreated(CefRefPtr<CefBrowser> browser)
	void OnBrowserCreated(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnBrowserDestroyed(CefRefPtr<CefBrowser> browser)
	void OnBrowserDestroyed(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! CefRefPtr<CefLoadHandler> GetLoadHandler()
	CefRefPtr<CefLoadHandler> GetLoadHandler(managed_callback mcallback);

	//gen! bool OnBeforeNavigation(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,NavigationType navigation_type,bool is_redirect)
	bool OnBeforeNavigation(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, cef_navigation_type_t navigation_type, bool is_redirect);

	//gen! void OnContextCreated(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefV8Context> context)
	void OnContextCreated(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context);

	//gen! void OnContextReleased(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefV8Context> context)
	void OnContextReleased(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context);

	//gen! void OnUncaughtException(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Exception> exception,CefRefPtr<CefV8StackTrace> stackTrace)
	void OnUncaughtException(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context, CefRefPtr<CefV8Exception> exception, CefRefPtr<CefV8StackTrace> stackTrace);

	//gen! void OnFocusedNodeChanged(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefDOMNode> node)
	void OnFocusedNodeChanged(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefDOMNode> node);

	//gen! bool OnProcessMessageReceived(CefRefPtr<CefBrowser> browser,CefProcessId source_process,CefRefPtr<CefProcessMessage> message)
	bool OnProcessMessageReceived(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefProcessId source_process, CefRefPtr<CefProcessMessage> message);
}
namespace CefRequestContextHandlerExt
{
	const int _typeName = CefTypeName_CefRequestContextHandler;
	const int CefRequestContextHandlerExt_GetCookieManager_1 = 1;
	const int CefRequestContextHandlerExt_OnBeforePluginLoad_2 = 2;

	//gen! CefRefPtr<CefCookieManager> GetCookieManager()
	CefRefPtr<CefCookieManager> GetCookieManager(managed_callback mcallback);

	//gen! bool OnBeforePluginLoad(const CefString& mime_type,const CefString& plugin_url,bool is_main_frame,const CefString& top_origin_url,CefRefPtr<CefWebPluginInfo> plugin_info,PluginPolicy* plugin_policy)
	bool OnBeforePluginLoad(managed_callback mcallback, const CefString& mime_type, const CefString& plugin_url, bool is_main_frame, const CefString& top_origin_url, CefRefPtr<CefWebPluginInfo> plugin_info, cef_plugin_policy_t* plugin_policy);
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

	//gen! bool OnBeforeBrowse(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,bool is_redirect)
	bool OnBeforeBrowse(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, bool is_redirect);

	//gen! bool OnOpenURLFromTab(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& target_url,WindowOpenDisposition target_disposition,bool user_gesture)
	bool OnOpenURLFromTab(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, cef_window_open_disposition_t target_disposition, bool user_gesture);

	//gen! ReturnValue OnBeforeResourceLoad(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefRequestCallback> callback)
	CefRequestHandler::ReturnValue OnBeforeResourceLoad(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefRequestCallback> callback);

	//gen! CefRefPtr<CefResourceHandler> GetResourceHandler(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request)
	CefRefPtr<CefResourceHandler> GetResourceHandler(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request);

	//gen! void OnResourceRedirect(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response,CefString& new_url)
	void OnResourceRedirect(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, CefString& new_url);

	//gen! bool OnResourceResponse(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response)
	bool OnResourceResponse(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response);

	//gen! CefRefPtr<CefResponseFilter> GetResourceResponseFilter(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response)
	CefRefPtr<CefResponseFilter> GetResourceResponseFilter(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response);

	//gen! void OnResourceLoadComplete(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefRequest> request,CefRefPtr<CefResponse> response,URLRequestStatus status,int64 received_content_length)
	void OnResourceLoadComplete(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, cef_urlrequest_status_t status, int64 received_content_length);

	//gen! bool GetAuthCredentials(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,bool isProxy,const CefString& host,int port,const CefString& realm,const CefString& scheme,CefRefPtr<CefAuthCallback> callback)
	bool GetAuthCredentials(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, bool isProxy, const CefString& host, int port, const CefString& realm, const CefString& scheme, CefRefPtr<CefAuthCallback> callback);

	//gen! bool OnQuotaRequest(CefRefPtr<CefBrowser> browser,const CefString& origin_url,int64 new_size,CefRefPtr<CefRequestCallback> callback)
	bool OnQuotaRequest(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& origin_url, int64 new_size, CefRefPtr<CefRequestCallback> callback);

	//gen! void OnProtocolExecution(CefRefPtr<CefBrowser> browser,const CefString& url,bool& allow_os_execution)
	void OnProtocolExecution(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& url, bool& allow_os_execution);

	//gen! bool OnCertificateError(CefRefPtr<CefBrowser> browser,cef_errorcode_t cert_error,const CefString& request_url,CefRefPtr<CefSSLInfo> ssl_info,CefRefPtr<CefRequestCallback> callback)
	bool OnCertificateError(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_errorcode_t cert_error, const CefString& request_url, CefRefPtr<CefSSLInfo> ssl_info, CefRefPtr<CefRequestCallback> callback);

	//gen! bool OnSelectClientCertificate(CefRefPtr<CefBrowser> browser,bool isProxy,const CefString& host,int port,const X509CertificateList& certificates,CefRefPtr<CefSelectClientCertificateCallback> callback)
	bool OnSelectClientCertificate(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool isProxy, const CefString& host, int port, const std::vector<CefRefPtr<CefX509Certificate>>& certificates, CefRefPtr<CefSelectClientCertificateCallback> callback);

	//gen! void OnPluginCrashed(CefRefPtr<CefBrowser> browser,const CefString& plugin_path)
	void OnPluginCrashed(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& plugin_path);

	//gen! void OnRenderViewReady(CefRefPtr<CefBrowser> browser)
	void OnRenderViewReady(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnRenderProcessTerminated(CefRefPtr<CefBrowser> browser,TerminationStatus status)
	void OnRenderProcessTerminated(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_termination_status_t status);
}
namespace CefResourceBundleHandlerExt
{
	const int _typeName = CefTypeName_CefResourceBundleHandler;
	const int CefResourceBundleHandlerExt_GetLocalizedString_1 = 1;
	const int CefResourceBundleHandlerExt_GetDataResource_2 = 2;
	const int CefResourceBundleHandlerExt_GetDataResourceForScale_3 = 3;

	//gen! bool GetLocalizedString(int string_id,CefString& string)
	bool GetLocalizedString(managed_callback mcallback, int string_id, CefString& string);

	//gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
	bool GetDataResource(managed_callback mcallback, int resource_id, void*& data, size_t& data_size);

	//gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
	bool GetDataResourceForScale(managed_callback mcallback, int resource_id, cef_scale_factor_t scale_factor, void*& data, size_t& data_size);
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

	//gen! bool ProcessRequest(CefRefPtr<CefRequest> request,CefRefPtr<CefCallback> callback)
	bool ProcessRequest(managed_callback mcallback, CefRefPtr<CefRequest> request, CefRefPtr<CefCallback> callback);

	//gen! void GetResponseHeaders(CefRefPtr<CefResponse> response,int64& response_length,CefString& redirectUrl)
	void GetResponseHeaders(managed_callback mcallback, CefRefPtr<CefResponse> response, int64& response_length, CefString& redirectUrl);

	//gen! bool ReadResponse(void* data_out,int bytes_to_read,int& bytes_read,CefRefPtr<CefCallback> callback)
	bool ReadResponse(managed_callback mcallback, void* data_out, int bytes_to_read, int& bytes_read, CefRefPtr<CefCallback> callback);

	//gen! bool CanGetCookie(const CefCookie& cookie)
	bool CanGetCookie(managed_callback mcallback, const CefCookie& cookie);

	//gen! bool CanSetCookie(const CefCookie& cookie)
	bool CanSetCookie(managed_callback mcallback, const CefCookie& cookie);

	//gen! void Cancel()
	void Cancel(managed_callback mcallback);
}
namespace CefReadHandlerExt
{
	const int _typeName = CefTypeName_CefReadHandler;
	const int CefReadHandlerExt_Read_1 = 1;
	const int CefReadHandlerExt_Seek_2 = 2;
	const int CefReadHandlerExt_Tell_3 = 3;
	const int CefReadHandlerExt_Eof_4 = 4;
	const int CefReadHandlerExt_MayBlock_5 = 5;

	//gen! size_t Read(void* ptr,size_t size,size_t n)
	size_t Read(managed_callback mcallback, void* ptr, size_t size, size_t n);

	//gen! int Seek(int64 offset,int whence)
	int Seek(managed_callback mcallback, int64 offset, int whence);

	//gen! int64 Tell()
	int64 Tell(managed_callback mcallback);

	//gen! int Eof()
	int Eof(managed_callback mcallback);

	//gen! bool MayBlock()
	bool MayBlock(managed_callback mcallback);
}
namespace CefWriteHandlerExt
{
	const int _typeName = CefTypeName_CefWriteHandler;
	const int CefWriteHandlerExt_Write_1 = 1;
	const int CefWriteHandlerExt_Seek_2 = 2;
	const int CefWriteHandlerExt_Tell_3 = 3;
	const int CefWriteHandlerExt_Flush_4 = 4;
	const int CefWriteHandlerExt_MayBlock_5 = 5;

	//gen! size_t Write(const void* ptr,size_t size,size_t n)
	size_t Write(managed_callback mcallback, const void* ptr, size_t size, size_t n);

	//gen! int Seek(int64 offset,int whence)
	int Seek(managed_callback mcallback, int64 offset, int whence);

	//gen! int64 Tell()
	int64 Tell(managed_callback mcallback);

	//gen! int Flush()
	int Flush(managed_callback mcallback);

	//gen! bool MayBlock()
	bool MayBlock(managed_callback mcallback);
}
namespace CefV8HandlerExt
{
	const int _typeName = CefTypeName_CefV8Handler;
	const int CefV8HandlerExt_Execute_1 = 1;

	//gen! bool Execute(const CefString& name,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments,CefRefPtr<CefV8Value>& retval,CefString& exception)
	bool Execute(managed_callback mcallback, const CefString& name, CefRefPtr<CefV8Value> object, const CefV8ValueList& arguments, CefRefPtr<CefV8Value>& retval, CefString& exception);
}
