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




inline void MyCefSetCefPoint(jsvalue* value, CefPoint&data) {

	CefPoint* cefPoint = new CefPoint();
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = cefPoint;
};


//AUTOGEN
namespace CefAccessibilityHandlerExt
{

	//gen! void OnAccessibilityTreeChange(CefRefPtr<CefValue> value)
	void OnAccessibilityTreeChange(managed_callback mcallback, CefRefPtr<CefValue> value);

	//gen! void OnAccessibilityLocationChange(CefRefPtr<CefValue> value)
	void OnAccessibilityLocationChange(managed_callback mcallback, CefRefPtr<CefValue> value);
}
namespace CefAccessibilityHandlerExt {
	class OnAccessibilityTreeChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_value_t* value;//1
		};
		argData arg;//
		OnAccessibilityTreeChangeArgs(cef_value_t* value)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.value = value;
		}
		OnAccessibilityTreeChangeArgs(CefRefPtr<CefValue> value)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.value = CefValueCToCpp::Unwrap(value);
		}
		~OnAccessibilityTreeChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefValueCToCpp::Wrap(arg.value);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAccessibilityTreeChangeArgs);
	};
	class OnAccessibilityLocationChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_value_t* value;//1
		};
		argData arg;//
		OnAccessibilityLocationChangeArgs(cef_value_t* value)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.value = value;
		}
		OnAccessibilityLocationChangeArgs(CefRefPtr<CefValue> value)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.value = CefValueCToCpp::Unwrap(value);
		}
		~OnAccessibilityLocationChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefValueCToCpp::Wrap(arg.value);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAccessibilityLocationChangeArgs);
	};
}
namespace CefBrowserProcessHandlerExt
{

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
namespace CefBrowserProcessHandlerExt {
	class OnContextInitializedArgs {
	public:
		struct argData {
			int32_t myext_flags;
		};
		argData arg;//
		OnContextInitializedArgs()
		{
			arg.myext_flags = ((1 << 18) | 0);
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextInitializedArgs);
	};
	class OnBeforeChildProcessLaunchArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_command_line_t* command_line;//1
		};
		argData arg;//
		OnBeforeChildProcessLaunchArgs(cef_command_line_t* command_line)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.command_line = command_line;
		}
		OnBeforeChildProcessLaunchArgs(CefRefPtr<CefCommandLine> command_line)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.command_line = CefCommandLineCToCpp::Unwrap(command_line);
		}
		~OnBeforeChildProcessLaunchArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefCommandLineCToCpp::Wrap(arg.command_line);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeChildProcessLaunchArgs);
	};
	class OnRenderProcessThreadCreatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_list_value_t* extra_info;//1
		};
		argData arg;//
		OnRenderProcessThreadCreatedArgs(cef_list_value_t* extra_info)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.extra_info = extra_info;
		}
		OnRenderProcessThreadCreatedArgs(CefRefPtr<CefListValue> extra_info)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.extra_info = CefListValueCToCpp::Unwrap(extra_info);
		}
		~OnRenderProcessThreadCreatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefListValueCToCpp::Wrap(arg.extra_info);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderProcessThreadCreatedArgs);
	};
	class GetPrintHandlerArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefRefPtr<CefPrintHandler> myext_ret_value; //0
		};
		argData arg;//
		GetPrintHandlerArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetPrintHandlerArgs);
	};
	class OnScheduleMessagePumpWorkArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int64 delay_ms;//1
		};
		argData arg;//
		OnScheduleMessagePumpWorkArgs(int64 delay_ms)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.delay_ms = delay_ms;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnScheduleMessagePumpWorkArgs);
	};
}
namespace CefContextMenuHandlerExt
{

	//gen! void OnBeforeContextMenu(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,CefRefPtr<CefMenuModel> model)
	void OnBeforeContextMenu(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> params, CefRefPtr<CefMenuModel> model);

	//gen! bool RunContextMenu(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,CefRefPtr<CefMenuModel> model,CefRefPtr<CefRunContextMenuCallback> callback)
	bool RunContextMenu(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> params, CefRefPtr<CefMenuModel> model, CefRefPtr<CefRunContextMenuCallback> callback);

	//gen! bool OnContextMenuCommand(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,CefRefPtr<CefContextMenuParams> params,int command_id,EventFlags event_flags)
	bool OnContextMenuCommand(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> params, int command_id, cef_event_flags_t event_flags);

	//gen! void OnContextMenuDismissed(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame)
	void OnContextMenuDismissed(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame);
}
namespace CefContextMenuHandlerExt {
	class OnBeforeContextMenuArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_context_menu_params_t* _params;//3
			cef_menu_model_t* model;//4
		};
		argData arg;//
		OnBeforeContextMenuArgs(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* _params, cef_menu_model_t* model)
		{
			arg.myext_flags = ((1 << 18) | 4);
			arg.browser = browser;
			arg.frame = frame;
			arg._params = _params;
			arg.model = model;
		}
		OnBeforeContextMenuArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, CefRefPtr<CefMenuModel> model)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 4);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg._params = CefContextMenuParamsCToCpp::Unwrap(_params);
			arg.model = CefMenuModelCToCpp::Unwrap(model);
		}
		~OnBeforeContextMenuArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefContextMenuParamsCToCpp::Wrap(arg._params);
				CefMenuModelCToCpp::Wrap(arg.model);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeContextMenuArgs);
	};
	class RunContextMenuArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_context_menu_params_t* _params;//3
			cef_menu_model_t* model;//4
			cef_run_context_menu_callback_t* callback;//5
		};
		argData arg;//
		RunContextMenuArgs(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* _params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg._params = _params;
			arg.model = model;
			arg.callback = callback;
		}
		RunContextMenuArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, CefRefPtr<CefMenuModel> model, CefRefPtr<CefRunContextMenuCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg._params = CefContextMenuParamsCToCpp::Unwrap(_params);
			arg.model = CefMenuModelCToCpp::Unwrap(model);
			arg.callback = CefRunContextMenuCallbackCToCpp::Unwrap(callback);
		}
		~RunContextMenuArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefContextMenuParamsCToCpp::Wrap(arg._params);
				CefMenuModelCToCpp::Wrap(arg.model);
				CefRunContextMenuCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(RunContextMenuArgs);
	};
	class OnContextMenuCommandArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_context_menu_params_t* _params;//3
			int command_id;//4
			cef_event_flags_t event_flags;//5
		};
		argData arg;//
		OnContextMenuCommandArgs(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* _params, int command_id, cef_event_flags_t event_flags)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg._params = _params;
			arg.command_id = command_id;
			arg.event_flags = event_flags;
		}
		OnContextMenuCommandArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, int command_id, cef_event_flags_t event_flags)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg._params = CefContextMenuParamsCToCpp::Unwrap(_params);
			arg.command_id = command_id;
			arg.event_flags = event_flags;
		}
		~OnContextMenuCommandArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefContextMenuParamsCToCpp::Wrap(arg._params);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextMenuCommandArgs);
	};
	class OnContextMenuDismissedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
		};
		argData arg;//
		OnContextMenuDismissedArgs(cef_browser_t* browser, cef_frame_t* frame)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.frame = frame;
		}
		OnContextMenuDismissedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
		}
		~OnContextMenuDismissedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextMenuDismissedArgs);
	};
}
namespace CefDialogHandlerExt
{

	//gen! bool OnFileDialog(CefRefPtr<CefBrowser> browser,FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefFileDialogCallback> callback)
	bool OnFileDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_file_dialog_mode_t mode, const CefString& title, const CefString& default_file_path, const std::vector<CefString>& accept_filters, int selected_accept_filter, CefRefPtr<CefFileDialogCallback> callback);
}
namespace CefDialogHandlerExt {
	class OnFileDialogArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_file_dialog_mode_t mode;//2
			const CefString* title;//3
			const CefString* default_file_path;//4
			const std::vector<CefString>* accept_filters;//5
			int selected_accept_filter;//6
			cef_file_dialog_callback_t* callback;//7
		};
		argData arg;//
		OnFileDialogArgs(cef_browser_t* browser, cef_file_dialog_mode_t mode, const CefString* title, const CefString* default_file_path, const std::vector<CefString>* accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 7);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.mode = mode;
			arg.title = title;
			arg.default_file_path = default_file_path;
			arg.accept_filters = accept_filters;
			arg.selected_accept_filter = selected_accept_filter;
			arg.callback = callback;
		}
		OnFileDialogArgs(CefRefPtr<CefBrowser> browser, cef_file_dialog_mode_t mode, const CefString* title, const CefString* default_file_path, const std::vector<CefString>* accept_filters, int selected_accept_filter, CefRefPtr<CefFileDialogCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 7);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.mode = mode;
			arg.title = title;
			arg.default_file_path = default_file_path;
			arg.accept_filters = accept_filters;
			arg.selected_accept_filter = selected_accept_filter;
			arg.callback = CefFileDialogCallbackCToCpp::Unwrap(callback);
		}
		~OnFileDialogArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFileDialogCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFileDialogArgs);
	};
}
namespace CefDisplayHandlerExt
{

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
namespace CefDisplayHandlerExt {
	class OnAddressChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			const CefString* url;//3
		};
		argData arg;//
		OnAddressChangeArgs(cef_browser_t* browser, cef_frame_t* frame, const CefString* url)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.frame = frame;
			arg.url = url;
		}
		OnAddressChangeArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString* url)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.url = url;
		}
		~OnAddressChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAddressChangeArgs);
	};
	class OnTitleChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const CefString* title;//2
		};
		argData arg;//
		OnTitleChangeArgs(cef_browser_t* browser, const CefString* title)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.title = title;
		}
		OnTitleChangeArgs(CefRefPtr<CefBrowser> browser, const CefString* title)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.title = title;
		}
		~OnTitleChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTitleChangeArgs);
	};
	class OnFaviconURLChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const std::vector<CefString>* icon_urls;//2
		};
		argData arg;//
		OnFaviconURLChangeArgs(cef_browser_t* browser, const std::vector<CefString>* icon_urls)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.icon_urls = icon_urls;
		}
		OnFaviconURLChangeArgs(CefRefPtr<CefBrowser> browser, const std::vector<CefString>* icon_urls)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.icon_urls = icon_urls;
		}
		~OnFaviconURLChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFaviconURLChangeArgs);
	};
	class OnFullscreenModeChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			bool fullscreen;//2
		};
		argData arg;//
		OnFullscreenModeChangeArgs(cef_browser_t* browser, bool fullscreen)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.fullscreen = fullscreen;
		}
		OnFullscreenModeChangeArgs(CefRefPtr<CefBrowser> browser, bool fullscreen)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.fullscreen = fullscreen;
		}
		~OnFullscreenModeChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFullscreenModeChangeArgs);
	};
	class OnTooltipArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			CefString* text;//2
		};
		argData arg;//
		OnTooltipArgs(cef_browser_t* browser, CefString* text)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.text = text;
		}
		OnTooltipArgs(CefRefPtr<CefBrowser> browser, CefString* text)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 2);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.text = text;
		}
		~OnTooltipArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTooltipArgs);
	};
	class OnStatusMessageArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const CefString* value;//2
		};
		argData arg;//
		OnStatusMessageArgs(cef_browser_t* browser, const CefString* value)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.value = value;
		}
		OnStatusMessageArgs(CefRefPtr<CefBrowser> browser, const CefString* value)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.value = value;
		}
		~OnStatusMessageArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnStatusMessageArgs);
	};
	class OnConsoleMessageArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefString* message;//2
			const CefString* source;//3
			int line;//4
		};
		argData arg;//
		OnConsoleMessageArgs(cef_browser_t* browser, const CefString* message, const CefString* source, int line)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.message = message;
			arg.source = source;
			arg.line = line;
		}
		OnConsoleMessageArgs(CefRefPtr<CefBrowser> browser, const CefString* message, const CefString* source, int line)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.message = message;
			arg.source = source;
			arg.line = line;
		}
		~OnConsoleMessageArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnConsoleMessageArgs);
	};
}
namespace CefDownloadHandlerExt
{

	//gen! void OnBeforeDownload(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDownloadItem> download_item,const CefString& suggested_name,CefRefPtr<CefBeforeDownloadCallback> callback)
	void OnBeforeDownload(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, const CefString& suggested_name, CefRefPtr<CefBeforeDownloadCallback> callback);

	//gen! void OnDownloadUpdated(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDownloadItem> download_item,CefRefPtr<CefDownloadItemCallback> callback)
	void OnDownloadUpdated(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, CefRefPtr<CefDownloadItemCallback> callback);
}
namespace CefDownloadHandlerExt {
	class OnBeforeDownloadArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_download_item_t* download_item;//2
			const CefString* suggested_name;//3
			cef_before_download_callback_t* callback;//4
		};
		argData arg;//
		OnBeforeDownloadArgs(cef_browser_t* browser, cef_download_item_t* download_item, const CefString* suggested_name, cef_before_download_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | 4);
			arg.browser = browser;
			arg.download_item = download_item;
			arg.suggested_name = suggested_name;
			arg.callback = callback;
		}
		OnBeforeDownloadArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, const CefString* suggested_name, CefRefPtr<CefBeforeDownloadCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 4);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.download_item = CefDownloadItemCToCpp::Unwrap(download_item);
			arg.suggested_name = suggested_name;
			arg.callback = CefBeforeDownloadCallbackCToCpp::Unwrap(callback);
		}
		~OnBeforeDownloadArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefDownloadItemCToCpp::Wrap(arg.download_item);
				CefBeforeDownloadCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeDownloadArgs);
	};
	class OnDownloadUpdatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_download_item_t* download_item;//2
			cef_download_item_callback_t* callback;//3
		};
		argData arg;//
		OnDownloadUpdatedArgs(cef_browser_t* browser, cef_download_item_t* download_item, cef_download_item_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.download_item = download_item;
			arg.callback = callback;
		}
		OnDownloadUpdatedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, CefRefPtr<CefDownloadItemCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.download_item = CefDownloadItemCToCpp::Unwrap(download_item);
			arg.callback = CefDownloadItemCallbackCToCpp::Unwrap(callback);
		}
		~OnDownloadUpdatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefDownloadItemCToCpp::Wrap(arg.download_item);
				CefDownloadItemCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnDownloadUpdatedArgs);
	};
}
namespace CefDragHandlerExt
{

	//gen! bool OnDragEnter(CefRefPtr<CefBrowser> browser,CefRefPtr<CefDragData> dragData,DragOperationsMask mask)
	bool OnDragEnter(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> dragData, cef_drag_operations_mask_t mask);

	//gen! void OnDraggableRegionsChanged(CefRefPtr<CefBrowser> browser,const std::vector<CefDraggableRegion>& regions)
	void OnDraggableRegionsChanged(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const std::vector<CefDraggableRegion>& regions);
}
namespace CefDragHandlerExt {
	class OnDragEnterArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_drag_data_t* dragData;//2
			cef_drag_operations_mask_t mask;//3
		};
		argData arg;//
		OnDragEnterArgs(cef_browser_t* browser, cef_drag_data_t* dragData, cef_drag_operations_mask_t mask)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.dragData = dragData;
			arg.mask = mask;
		}
		OnDragEnterArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> dragData, cef_drag_operations_mask_t mask)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 3);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.dragData = CefDragDataCToCpp::Unwrap(dragData);
			arg.mask = mask;
		}
		~OnDragEnterArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefDragDataCToCpp::Wrap(arg.dragData);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnDragEnterArgs);
	};
	class OnDraggableRegionsChangedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const std::vector<CefDraggableRegion>* regions;//2
		};
		argData arg;//
		OnDraggableRegionsChangedArgs(cef_browser_t* browser, const std::vector<CefDraggableRegion>* regions)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.regions = regions;
		}
		OnDraggableRegionsChangedArgs(CefRefPtr<CefBrowser> browser, const std::vector<CefDraggableRegion>* regions)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.regions = regions;
		}
		~OnDraggableRegionsChangedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnDraggableRegionsChangedArgs);
	};
}
namespace CefFindHandlerExt
{

	//gen! void OnFindResult(CefRefPtr<CefBrowser> browser,int identifier,int count,const CefRect& selectionRect,int activeMatchOrdinal,bool finalUpdate)
	void OnFindResult(managed_callback mcallback, CefRefPtr<CefBrowser> browser, int identifier, int count, const CefRect& selectionRect, int activeMatchOrdinal, bool finalUpdate);
}
namespace CefFindHandlerExt {
	class OnFindResultArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			int identifier;//2
			int count;//3
			const CefRect* selectionRect;//4
			int activeMatchOrdinal;//5
			bool finalUpdate;//6
		};
		argData arg;//
		OnFindResultArgs(cef_browser_t* browser, int identifier, int count, const CefRect* selectionRect, int activeMatchOrdinal, bool finalUpdate)
		{
			arg.myext_flags = ((1 << 18) | 6);
			arg.browser = browser;
			arg.identifier = identifier;
			arg.count = count;
			arg.selectionRect = selectionRect;
			arg.activeMatchOrdinal = activeMatchOrdinal;
			arg.finalUpdate = finalUpdate;
		}
		OnFindResultArgs(CefRefPtr<CefBrowser> browser, int identifier, int count, const CefRect* selectionRect, int activeMatchOrdinal, bool finalUpdate)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 6);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.identifier = identifier;
			arg.count = count;
			arg.selectionRect = selectionRect;
			arg.activeMatchOrdinal = activeMatchOrdinal;
			arg.finalUpdate = finalUpdate;
		}
		~OnFindResultArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFindResultArgs);
	};
}
namespace CefFocusHandlerExt
{

	//gen! void OnTakeFocus(CefRefPtr<CefBrowser> browser,bool next)
	void OnTakeFocus(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool next);

	//gen! bool OnSetFocus(CefRefPtr<CefBrowser> browser,FocusSource source)
	bool OnSetFocus(managed_callback mcallback, CefRefPtr<CefBrowser> browser, cef_focus_source_t source);

	//gen! void OnGotFocus(CefRefPtr<CefBrowser> browser)
	void OnGotFocus(managed_callback mcallback, CefRefPtr<CefBrowser> browser);
}
namespace CefFocusHandlerExt {
	class OnTakeFocusArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			bool next;//2
		};
		argData arg;//
		OnTakeFocusArgs(cef_browser_t* browser, bool next)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.next = next;
		}
		OnTakeFocusArgs(CefRefPtr<CefBrowser> browser, bool next)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.next = next;
		}
		~OnTakeFocusArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTakeFocusArgs);
	};
	class OnSetFocusArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_focus_source_t source;//2
		};
		argData arg;//
		OnSetFocusArgs(cef_browser_t* browser, cef_focus_source_t source)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.source = source;
		}
		OnSetFocusArgs(CefRefPtr<CefBrowser> browser, cef_focus_source_t source)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 2);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.source = source;
		}
		~OnSetFocusArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnSetFocusArgs);
	};
	class OnGotFocusArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnGotFocusArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnGotFocusArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnGotFocusArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnGotFocusArgs);
	};
}
namespace CefGeolocationHandlerExt
{

	//gen! bool OnRequestGeolocationPermission(CefRefPtr<CefBrowser> browser,const CefString& requesting_url,int request_id,CefRefPtr<CefGeolocationCallback> callback)
	bool OnRequestGeolocationPermission(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& requesting_url, int request_id, CefRefPtr<CefGeolocationCallback> callback);

	//gen! void OnCancelGeolocationPermission(CefRefPtr<CefBrowser> browser,int request_id)
	void OnCancelGeolocationPermission(managed_callback mcallback, CefRefPtr<CefBrowser> browser, int request_id);
}
namespace CefGeolocationHandlerExt {
	class OnRequestGeolocationPermissionArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefString* requesting_url;//2
			int request_id;//3
			cef_geolocation_callback_t* callback;//4
		};
		argData arg;//
		OnRequestGeolocationPermissionArgs(cef_browser_t* browser, const CefString* requesting_url, int request_id, cef_geolocation_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.requesting_url = requesting_url;
			arg.request_id = request_id;
			arg.callback = callback;
		}
		OnRequestGeolocationPermissionArgs(CefRefPtr<CefBrowser> browser, const CefString* requesting_url, int request_id, CefRefPtr<CefGeolocationCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.requesting_url = requesting_url;
			arg.request_id = request_id;
			arg.callback = CefGeolocationCallbackCToCpp::Unwrap(callback);
		}
		~OnRequestGeolocationPermissionArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefGeolocationCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRequestGeolocationPermissionArgs);
	};
	class OnCancelGeolocationPermissionArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			int request_id;//2
		};
		argData arg;//
		OnCancelGeolocationPermissionArgs(cef_browser_t* browser, int request_id)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.request_id = request_id;
		}
		OnCancelGeolocationPermissionArgs(CefRefPtr<CefBrowser> browser, int request_id)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.request_id = request_id;
		}
		~OnCancelGeolocationPermissionArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCancelGeolocationPermissionArgs);
	};
}
namespace CefJSDialogHandlerExt
{

	//gen! bool OnJSDialog(CefRefPtr<CefBrowser> browser,const CefString& origin_url,JSDialogType dialog_type,const CefString& message_text,const CefString& default_prompt_text,CefRefPtr<CefJSDialogCallback> callback,bool& suppress_message)
	bool OnJSDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& origin_url, cef_jsdialog_type_t dialog_type, const CefString& message_text, const CefString& default_prompt_text, CefRefPtr<CefJSDialogCallback> callback, bool& suppress_message);

	//gen! bool OnBeforeUnloadDialog(CefRefPtr<CefBrowser> browser,const CefString& message_text,bool is_reload,CefRefPtr<CefJSDialogCallback> callback)
	bool OnBeforeUnloadDialog(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefString& message_text, bool is_reload, CefRefPtr<CefJSDialogCallback> callback);

	//gen! void OnResetDialogState(CefRefPtr<CefBrowser> browser)
	void OnResetDialogState(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnDialogClosed(CefRefPtr<CefBrowser> browser)
	void OnDialogClosed(managed_callback mcallback, CefRefPtr<CefBrowser> browser);
}
namespace CefJSDialogHandlerExt {
	class OnJSDialogArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefString* origin_url;//2
			cef_jsdialog_type_t dialog_type;//3
			const CefString* message_text;//4
			const CefString* default_prompt_text;//5
			cef_jsdialog_callback_t* callback;//6
			bool* suppress_message;//7
		};
		argData arg;//
		OnJSDialogArgs(cef_browser_t* browser, const CefString* origin_url, cef_jsdialog_type_t dialog_type, const CefString* message_text, const CefString* default_prompt_text, cef_jsdialog_callback_t* callback, bool* suppress_message)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 7);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.origin_url = origin_url;
			arg.dialog_type = dialog_type;
			arg.message_text = message_text;
			arg.default_prompt_text = default_prompt_text;
			arg.callback = callback;
			arg.suppress_message = suppress_message;
		}
		OnJSDialogArgs(CefRefPtr<CefBrowser> browser, const CefString* origin_url, cef_jsdialog_type_t dialog_type, const CefString* message_text, const CefString* default_prompt_text, CefRefPtr<CefJSDialogCallback> callback, bool* suppress_message)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 7);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.origin_url = origin_url;
			arg.dialog_type = dialog_type;
			arg.message_text = message_text;
			arg.default_prompt_text = default_prompt_text;
			arg.callback = CefJSDialogCallbackCToCpp::Unwrap(callback);
			arg.suppress_message = suppress_message;
		}
		~OnJSDialogArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefJSDialogCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnJSDialogArgs);
	};
	class OnBeforeUnloadDialogArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefString* message_text;//2
			bool is_reload;//3
			cef_jsdialog_callback_t* callback;//4
		};
		argData arg;//
		OnBeforeUnloadDialogArgs(cef_browser_t* browser, const CefString* message_text, bool is_reload, cef_jsdialog_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.message_text = message_text;
			arg.is_reload = is_reload;
			arg.callback = callback;
		}
		OnBeforeUnloadDialogArgs(CefRefPtr<CefBrowser> browser, const CefString* message_text, bool is_reload, CefRefPtr<CefJSDialogCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.message_text = message_text;
			arg.is_reload = is_reload;
			arg.callback = CefJSDialogCallbackCToCpp::Unwrap(callback);
		}
		~OnBeforeUnloadDialogArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefJSDialogCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeUnloadDialogArgs);
	};
	class OnResetDialogStateArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnResetDialogStateArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnResetDialogStateArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnResetDialogStateArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResetDialogStateArgs);
	};
	class OnDialogClosedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnDialogClosedArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnDialogClosedArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnDialogClosedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnDialogClosedArgs);
	};
}
namespace CefKeyboardHandlerExt
{

	//gen! bool OnPreKeyEvent(CefRefPtr<CefBrowser> browser,const CefKeyEvent& event,CefEventHandle os_event,bool* is_keyboard_shortcut)
	bool OnPreKeyEvent(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefKeyEvent& event, CefEventHandle os_event, bool* is_keyboard_shortcut);

	//gen! bool OnKeyEvent(CefRefPtr<CefBrowser> browser,const CefKeyEvent& event,CefEventHandle os_event)
	bool OnKeyEvent(managed_callback mcallback, CefRefPtr<CefBrowser> browser, const CefKeyEvent& event, CefEventHandle os_event);
}
namespace CefKeyboardHandlerExt {
	class OnPreKeyEventArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefKeyEvent* _event;//2
			CefEventHandle os_event;//3
			bool* is_keyboard_shortcut;//4
		};
		argData arg;//
		OnPreKeyEventArgs(cef_browser_t* browser, const CefKeyEvent* _event, CefEventHandle os_event, bool* is_keyboard_shortcut)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg._event = _event;
			arg.os_event = os_event;
			arg.is_keyboard_shortcut = is_keyboard_shortcut;
		}
		OnPreKeyEventArgs(CefRefPtr<CefBrowser> browser, const CefKeyEvent* _event, CefEventHandle os_event, bool* is_keyboard_shortcut)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg._event = _event;
			arg.os_event = os_event;
			arg.is_keyboard_shortcut = is_keyboard_shortcut;
		}
		~OnPreKeyEventArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPreKeyEventArgs);
	};
	class OnKeyEventArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefKeyEvent* _event;//2
			CefEventHandle os_event;//3
		};
		argData arg;//
		OnKeyEventArgs(cef_browser_t* browser, const CefKeyEvent* _event, CefEventHandle os_event)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg._event = _event;
			arg.os_event = os_event;
		}
		OnKeyEventArgs(CefRefPtr<CefBrowser> browser, const CefKeyEvent* _event, CefEventHandle os_event)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 3);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg._event = _event;
			arg.os_event = os_event;
		}
		~OnKeyEventArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnKeyEventArgs);
	};
}
namespace CefLifeSpanHandlerExt
{

	//gen! bool OnBeforePopup(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,const CefString& target_url,const CefString& target_frame_name,WindowOpenDisposition target_disposition,bool user_gesture,const CefPopupFeatures& popupFeatures,CefWindowInfo& windowInfo,CefRefPtr<CefClient>& client,CefBrowserSettings& settings,bool* no_javascript_access)
	bool OnBeforePopup(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, const CefString& target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures& popupFeatures, CefWindowInfo& windowInfo, CefRefPtr<CefClient>& client, CefBrowserSettings& settings, bool* no_javascript_access);

	//gen! void OnAfterCreated(CefRefPtr<CefBrowser> browser)
	void OnAfterCreated(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! bool DoClose(CefRefPtr<CefBrowser> browser)
	bool DoClose(managed_callback mcallback, CefRefPtr<CefBrowser> browser);

	//gen! void OnBeforeClose(CefRefPtr<CefBrowser> browser)
	void OnBeforeClose(managed_callback mcallback, CefRefPtr<CefBrowser> browser);
}
namespace CefLifeSpanHandlerExt {
	class OnBeforePopupArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			const CefString* target_url;//3
			const CefString* target_frame_name;//4
			cef_window_open_disposition_t target_disposition;//5
			bool user_gesture;//6
			const CefPopupFeatures* popupFeatures;//7
			CefWindowInfo* windowInfo;//8
			CefRefPtr<CefClient>* client;//9
			CefBrowserSettings* settings;//10
			bool* no_javascript_access;//11
		};
		argData arg;//
		OnBeforePopupArgs(cef_browser_t* browser, cef_frame_t* frame, const CefString* target_url, const CefString* target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures* popupFeatures, CefWindowInfo* windowInfo, CefRefPtr<CefClient>* client, CefBrowserSettings* settings, bool* no_javascript_access)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 11);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.target_url = target_url;
			arg.target_frame_name = target_frame_name;
			arg.target_disposition = target_disposition;
			arg.user_gesture = user_gesture;
			arg.popupFeatures = popupFeatures;
			arg.windowInfo = windowInfo;
			arg.client = client;
			arg.settings = settings;
			arg.no_javascript_access = no_javascript_access;
		}
		OnBeforePopupArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString* target_url, const CefString* target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures* popupFeatures, CefWindowInfo* windowInfo, CefRefPtr<CefClient>* client, CefBrowserSettings* settings, bool* no_javascript_access)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 11);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.target_url = target_url;
			arg.target_frame_name = target_frame_name;
			arg.target_disposition = target_disposition;
			arg.user_gesture = user_gesture;
			arg.popupFeatures = popupFeatures;
			arg.windowInfo = windowInfo;
			arg.client = client;
			arg.settings = settings;
			arg.no_javascript_access = no_javascript_access;
		}
		~OnBeforePopupArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforePopupArgs);
	};
	class OnAfterCreatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnAfterCreatedArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnAfterCreatedArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnAfterCreatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAfterCreatedArgs);
	};
	class DoCloseArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
		};
		argData arg;//
		DoCloseArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 1);
			arg.myext_ret_value = 0;
			arg.browser = browser;
		}
		DoCloseArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 1);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~DoCloseArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(DoCloseArgs);
	};
	class OnBeforeCloseArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnBeforeCloseArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnBeforeCloseArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnBeforeCloseArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeCloseArgs);
	};
}
namespace CefLoadHandlerExt
{

	//gen! void OnLoadingStateChange(CefRefPtr<CefBrowser> browser,bool isLoading,bool canGoBack,bool canGoForward)
	void OnLoadingStateChange(managed_callback mcallback, CefRefPtr<CefBrowser> browser, bool isLoading, bool canGoBack, bool canGoForward);

	//gen! void OnLoadStart(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,TransitionType transition_type)
	void OnLoadStart(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_transition_type_t transition_type);

	//gen! void OnLoadEnd(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,int httpStatusCode)
	void OnLoadEnd(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, int httpStatusCode);

	//gen! void OnLoadError(CefRefPtr<CefBrowser> browser,CefRefPtr<CefFrame> frame,ErrorCode errorCode,const CefString& errorText,const CefString& failedUrl)
	void OnLoadError(managed_callback mcallback, CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_errorcode_t errorCode, const CefString& errorText, const CefString& failedUrl);
}
namespace CefLoadHandlerExt {
	class OnLoadingStateChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			bool isLoading;//2
			bool canGoBack;//3
			bool canGoForward;//4
		};
		argData arg;//
		OnLoadingStateChangeArgs(cef_browser_t* browser, bool isLoading, bool canGoBack, bool canGoForward)
		{
			arg.myext_flags = ((1 << 18) | 4);
			arg.browser = browser;
			arg.isLoading = isLoading;
			arg.canGoBack = canGoBack;
			arg.canGoForward = canGoForward;
		}
		OnLoadingStateChangeArgs(CefRefPtr<CefBrowser> browser, bool isLoading, bool canGoBack, bool canGoForward)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 4);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.isLoading = isLoading;
			arg.canGoBack = canGoBack;
			arg.canGoForward = canGoForward;
		}
		~OnLoadingStateChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadingStateChangeArgs);
	};
	class OnLoadStartArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_transition_type_t transition_type;//3
		};
		argData arg;//
		OnLoadStartArgs(cef_browser_t* browser, cef_frame_t* frame, cef_transition_type_t transition_type)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.frame = frame;
			arg.transition_type = transition_type;
		}
		OnLoadStartArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_transition_type_t transition_type)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.transition_type = transition_type;
		}
		~OnLoadStartArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadStartArgs);
	};
	class OnLoadEndArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			int httpStatusCode;//3
		};
		argData arg;//
		OnLoadEndArgs(cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.frame = frame;
			arg.httpStatusCode = httpStatusCode;
		}
		OnLoadEndArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, int httpStatusCode)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.httpStatusCode = httpStatusCode;
		}
		~OnLoadEndArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadEndArgs);
	};
	class OnLoadErrorArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_errorcode_t errorCode;//3
			const CefString* errorText;//4
			const CefString* failedUrl;//5
		};
		argData arg;//
		OnLoadErrorArgs(cef_browser_t* browser, cef_frame_t* frame, cef_errorcode_t errorCode, const CefString* errorText, const CefString* failedUrl)
		{
			arg.myext_flags = ((1 << 18) | 5);
			arg.browser = browser;
			arg.frame = frame;
			arg.errorCode = errorCode;
			arg.errorText = errorText;
			arg.failedUrl = failedUrl;
		}
		OnLoadErrorArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_errorcode_t errorCode, const CefString* errorText, const CefString* failedUrl)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 5);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.errorCode = errorCode;
			arg.errorText = errorText;
			arg.failedUrl = failedUrl;
		}
		~OnLoadErrorArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadErrorArgs);
	};
}
namespace CefPrintHandlerExt
{

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
namespace CefPrintHandlerExt {
	class OnPrintStartArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnPrintStartArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnPrintStartArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnPrintStartArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintStartArgs);
	};
	class OnPrintSettingsArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_print_settings_t* settings;//2
			bool get_defaults;//3
		};
		argData arg;//
		OnPrintSettingsArgs(cef_browser_t* browser, cef_print_settings_t* settings, bool get_defaults)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.settings = settings;
			arg.get_defaults = get_defaults;
		}
		OnPrintSettingsArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefPrintSettings> settings, bool get_defaults)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.settings = CefPrintSettingsCToCpp::Unwrap(settings);
			arg.get_defaults = get_defaults;
		}
		~OnPrintSettingsArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefPrintSettingsCToCpp::Wrap(arg.settings);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintSettingsArgs);
	};
	class OnPrintDialogArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			bool has_selection;//2
			cef_print_dialog_callback_t* callback;//3
		};
		argData arg;//
		OnPrintDialogArgs(cef_browser_t* browser, bool has_selection, cef_print_dialog_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.has_selection = has_selection;
			arg.callback = callback;
		}
		OnPrintDialogArgs(CefRefPtr<CefBrowser> browser, bool has_selection, CefRefPtr<CefPrintDialogCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 3);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.has_selection = has_selection;
			arg.callback = CefPrintDialogCallbackCToCpp::Unwrap(callback);
		}
		~OnPrintDialogArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefPrintDialogCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintDialogArgs);
	};
	class OnPrintJobArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefString* document_name;//2
			const CefString* pdf_file_path;//3
			cef_print_job_callback_t* callback;//4
		};
		argData arg;//
		OnPrintJobArgs(cef_browser_t* browser, const CefString* document_name, const CefString* pdf_file_path, cef_print_job_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.document_name = document_name;
			arg.pdf_file_path = pdf_file_path;
			arg.callback = callback;
		}
		OnPrintJobArgs(CefRefPtr<CefBrowser> browser, const CefString* document_name, const CefString* pdf_file_path, CefRefPtr<CefPrintJobCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.document_name = document_name;
			arg.pdf_file_path = pdf_file_path;
			arg.callback = CefPrintJobCallbackCToCpp::Unwrap(callback);
		}
		~OnPrintJobArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefPrintJobCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintJobArgs);
	};
	class OnPrintResetArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnPrintResetArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnPrintResetArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnPrintResetArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintResetArgs);
	};
	class GetPdfPaperSizeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefSize myext_ret_value; //0
			int device_units_per_inch;//1
		};
		argData arg;//
		GetPdfPaperSizeArgs(int device_units_per_inch)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 1);
			arg.myext_ret_value = CefSize();
			arg.device_units_per_inch = device_units_per_inch;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetPdfPaperSizeArgs);
	};
}
namespace CefRenderHandlerExt
{

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
namespace CefRenderHandlerExt {
	class GetAccessibilityHandlerArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefRefPtr<CefAccessibilityHandler> myext_ret_value; //0
		};
		argData arg;//
		GetAccessibilityHandlerArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetAccessibilityHandlerArgs);
	};
	class GetRootScreenRectArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			CefRect* rect;//2
		};
		argData arg;//
		GetRootScreenRectArgs(cef_browser_t* browser, CefRect* rect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.rect = rect;
		}
		GetRootScreenRectArgs(CefRefPtr<CefBrowser> browser, CefRect* rect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 2);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.rect = rect;
		}
		~GetRootScreenRectArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetRootScreenRectArgs);
	};
	class GetViewRectArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			CefRect* rect;//2
		};
		argData arg;//
		GetViewRectArgs(cef_browser_t* browser, CefRect* rect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.rect = rect;
		}
		GetViewRectArgs(CefRefPtr<CefBrowser> browser, CefRect* rect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 2);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.rect = rect;
		}
		~GetViewRectArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetViewRectArgs);
	};
	class GetScreenPointArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			int viewX;//2
			int viewY;//3
			int* screenX;//4
			int* screenY;//5
		};
		argData arg;//
		GetScreenPointArgs(cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.viewX = viewX;
			arg.viewY = viewY;
			arg.screenX = screenX;
			arg.screenY = screenY;
		}
		GetScreenPointArgs(CefRefPtr<CefBrowser> browser, int viewX, int viewY, int* screenX, int* screenY)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.viewX = viewX;
			arg.viewY = viewY;
			arg.screenX = screenX;
			arg.screenY = screenY;
		}
		~GetScreenPointArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetScreenPointArgs);
	};
	class GetScreenInfoArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			CefScreenInfo* screen_info;//2
		};
		argData arg;//
		GetScreenInfoArgs(cef_browser_t* browser, CefScreenInfo* screen_info)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.screen_info = screen_info;
		}
		GetScreenInfoArgs(CefRefPtr<CefBrowser> browser, CefScreenInfo* screen_info)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 2);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.screen_info = screen_info;
		}
		~GetScreenInfoArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetScreenInfoArgs);
	};
	class OnPopupShowArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			bool show;//2
		};
		argData arg;//
		OnPopupShowArgs(cef_browser_t* browser, bool show)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.show = show;
		}
		OnPopupShowArgs(CefRefPtr<CefBrowser> browser, bool show)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.show = show;
		}
		~OnPopupShowArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPopupShowArgs);
	};
	class OnPopupSizeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const CefRect* rect;//2
		};
		argData arg;//
		OnPopupSizeArgs(cef_browser_t* browser, const CefRect* rect)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.rect = rect;
		}
		OnPopupSizeArgs(CefRefPtr<CefBrowser> browser, const CefRect* rect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.rect = rect;
		}
		~OnPopupSizeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPopupSizeArgs);
	};
	class OnPaintArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_paint_element_type_t type;//2
			const std::vector<CefRect>* dirtyRects;//3
			const void* buffer;//4
			int width;//5
			int height;//6
		};
		argData arg;//
		OnPaintArgs(cef_browser_t* browser, cef_paint_element_type_t type, const std::vector<CefRect>* dirtyRects, const void* buffer, int width, int height)
		{
			arg.myext_flags = ((1 << 18) | 6);
			arg.browser = browser;
			arg.type = type;
			arg.dirtyRects = dirtyRects;
			arg.buffer = buffer;
			arg.width = width;
			arg.height = height;
		}
		OnPaintArgs(CefRefPtr<CefBrowser> browser, cef_paint_element_type_t type, const std::vector<CefRect>* dirtyRects, const void* buffer, int width, int height)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 6);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.type = type;
			arg.dirtyRects = dirtyRects;
			arg.buffer = buffer;
			arg.width = width;
			arg.height = height;
		}
		~OnPaintArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPaintArgs);
	};
	class OnCursorChangeArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			CefCursorHandle cursor;//2
			cef_cursor_type_t type;//3
			const CefCursorInfo* custom_cursor_info;//4
		};
		argData arg;//
		OnCursorChangeArgs(cef_browser_t* browser, CefCursorHandle cursor, cef_cursor_type_t type, const CefCursorInfo* custom_cursor_info)
		{
			arg.myext_flags = ((1 << 18) | 4);
			arg.browser = browser;
			arg.cursor = cursor;
			arg.type = type;
			arg.custom_cursor_info = custom_cursor_info;
		}
		OnCursorChangeArgs(CefRefPtr<CefBrowser> browser, CefCursorHandle cursor, cef_cursor_type_t type, const CefCursorInfo* custom_cursor_info)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 4);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.cursor = cursor;
			arg.type = type;
			arg.custom_cursor_info = custom_cursor_info;
		}
		~OnCursorChangeArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCursorChangeArgs);
	};
	class StartDraggingArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_drag_data_t* drag_data;//2
			cef_drag_operations_mask_t allowed_ops;//3
			int x;//4
			int y;//5
		};
		argData arg;//
		StartDraggingArgs(cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.drag_data = drag_data;
			arg.allowed_ops = allowed_ops;
			arg.x = x;
			arg.y = y;
		}
		StartDraggingArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.drag_data = CefDragDataCToCpp::Unwrap(drag_data);
			arg.allowed_ops = allowed_ops;
			arg.x = x;
			arg.y = y;
		}
		~StartDraggingArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefDragDataCToCpp::Wrap(arg.drag_data);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(StartDraggingArgs);
	};
	class UpdateDragCursorArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_drag_operations_mask_t operation;//2
		};
		argData arg;//
		UpdateDragCursorArgs(cef_browser_t* browser, cef_drag_operations_mask_t operation)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.operation = operation;
		}
		UpdateDragCursorArgs(CefRefPtr<CefBrowser> browser, cef_drag_operations_mask_t operation)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.operation = operation;
		}
		~UpdateDragCursorArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(UpdateDragCursorArgs);
	};
	class OnScrollOffsetChangedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			double x;//2
			double y;//3
		};
		argData arg;//
		OnScrollOffsetChangedArgs(cef_browser_t* browser, double x, double y)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.x = x;
			arg.y = y;
		}
		OnScrollOffsetChangedArgs(CefRefPtr<CefBrowser> browser, double x, double y)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.x = x;
			arg.y = y;
		}
		~OnScrollOffsetChangedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnScrollOffsetChangedArgs);
	};
	class OnImeCompositionRangeChangedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const CefRange* selected_range;//2
			const std::vector<CefRect>* character_bounds;//3
		};
		argData arg;//
		OnImeCompositionRangeChangedArgs(cef_browser_t* browser, const CefRange* selected_range, const std::vector<CefRect>* character_bounds)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.selected_range = selected_range;
			arg.character_bounds = character_bounds;
		}
		OnImeCompositionRangeChangedArgs(CefRefPtr<CefBrowser> browser, const CefRange* selected_range, const std::vector<CefRect>* character_bounds)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.selected_range = selected_range;
			arg.character_bounds = character_bounds;
		}
		~OnImeCompositionRangeChangedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnImeCompositionRangeChangedArgs);
	};
}
namespace CefRenderProcessHandlerExt
{

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
namespace CefRenderProcessHandlerExt {
	class OnRenderThreadCreatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_list_value_t* extra_info;//1
		};
		argData arg;//
		OnRenderThreadCreatedArgs(cef_list_value_t* extra_info)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.extra_info = extra_info;
		}
		OnRenderThreadCreatedArgs(CefRefPtr<CefListValue> extra_info)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.extra_info = CefListValueCToCpp::Unwrap(extra_info);
		}
		~OnRenderThreadCreatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefListValueCToCpp::Wrap(arg.extra_info);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderThreadCreatedArgs);
	};
	class OnWebKitInitializedArgs {
	public:
		struct argData {
			int32_t myext_flags;
		};
		argData arg;//
		OnWebKitInitializedArgs()
		{
			arg.myext_flags = ((1 << 18) | 0);
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnWebKitInitializedArgs);
	};
	class OnBrowserCreatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnBrowserCreatedArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnBrowserCreatedArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnBrowserCreatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBrowserCreatedArgs);
	};
	class OnBrowserDestroyedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnBrowserDestroyedArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnBrowserDestroyedArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnBrowserDestroyedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBrowserDestroyedArgs);
	};
	class GetLoadHandlerArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefRefPtr<CefLoadHandler> myext_ret_value; //0
		};
		argData arg;//
		GetLoadHandlerArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetLoadHandlerArgs);
	};
	class OnBeforeNavigationArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			cef_navigation_type_t navigation_type;//4
			bool is_redirect;//5
		};
		argData arg;//
		OnBeforeNavigationArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, bool is_redirect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.navigation_type = navigation_type;
			arg.is_redirect = is_redirect;
		}
		OnBeforeNavigationArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, cef_navigation_type_t navigation_type, bool is_redirect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.navigation_type = navigation_type;
			arg.is_redirect = is_redirect;
		}
		~OnBeforeNavigationArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeNavigationArgs);
	};
	class OnContextCreatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_v8context_t* context;//3
		};
		argData arg;//
		OnContextCreatedArgs(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.frame = frame;
			arg.context = context;
		}
		OnContextCreatedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.context = CefV8ContextCToCpp::Unwrap(context);
		}
		~OnContextCreatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefV8ContextCToCpp::Wrap(arg.context);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextCreatedArgs);
	};
	class OnContextReleasedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_v8context_t* context;//3
		};
		argData arg;//
		OnContextReleasedArgs(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.frame = frame;
			arg.context = context;
		}
		OnContextReleasedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.context = CefV8ContextCToCpp::Unwrap(context);
		}
		~OnContextReleasedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefV8ContextCToCpp::Wrap(arg.context);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextReleasedArgs);
	};
	class OnUncaughtExceptionArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_v8context_t* context;//3
			cef_v8exception_t* exception;//4
			cef_v8stack_trace_t* stackTrace;//5
		};
		argData arg;//
		OnUncaughtExceptionArgs(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace)
		{
			arg.myext_flags = ((1 << 18) | 5);
			arg.browser = browser;
			arg.frame = frame;
			arg.context = context;
			arg.exception = exception;
			arg.stackTrace = stackTrace;
		}
		OnUncaughtExceptionArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context, CefRefPtr<CefV8Exception> exception, CefRefPtr<CefV8StackTrace> stackTrace)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 5);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.context = CefV8ContextCToCpp::Unwrap(context);
			arg.exception = CefV8ExceptionCToCpp::Unwrap(exception);
			arg.stackTrace = CefV8StackTraceCToCpp::Unwrap(stackTrace);
		}
		~OnUncaughtExceptionArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefV8ContextCToCpp::Wrap(arg.context);
				CefV8ExceptionCToCpp::Wrap(arg.exception);
				CefV8StackTraceCToCpp::Wrap(arg.stackTrace);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnUncaughtExceptionArgs);
	};
	class OnFocusedNodeChangedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_domnode_t* node;//3
		};
		argData arg;//
		OnFocusedNodeChangedArgs(cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.frame = frame;
			arg.node = node;
		}
		OnFocusedNodeChangedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefDOMNode> node)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.node = CefDOMNodeCToCpp::Unwrap(node);
		}
		~OnFocusedNodeChangedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefDOMNodeCToCpp::Wrap(arg.node);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFocusedNodeChangedArgs);
	};
	class OnProcessMessageReceivedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			CefProcessId source_process;//2
			cef_process_message_t* message;//3
		};
		argData arg;//
		OnProcessMessageReceivedArgs(cef_browser_t* browser, CefProcessId source_process, cef_process_message_t* message)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.source_process = source_process;
			arg.message = message;
		}
		OnProcessMessageReceivedArgs(CefRefPtr<CefBrowser> browser, CefProcessId source_process, CefRefPtr<CefProcessMessage> message)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 3);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.source_process = source_process;
			arg.message = CefProcessMessageCToCpp::Unwrap(message);
		}
		~OnProcessMessageReceivedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefProcessMessageCToCpp::Wrap(arg.message);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnProcessMessageReceivedArgs);
	};
}
namespace CefRequestContextHandlerExt
{

	//gen! CefRefPtr<CefCookieManager> GetCookieManager()
	CefRefPtr<CefCookieManager> GetCookieManager(managed_callback mcallback);

	//gen! bool OnBeforePluginLoad(const CefString& mime_type,const CefString& plugin_url,bool is_main_frame,const CefString& top_origin_url,CefRefPtr<CefWebPluginInfo> plugin_info,PluginPolicy* plugin_policy)
	bool OnBeforePluginLoad(managed_callback mcallback, const CefString& mime_type, const CefString& plugin_url, bool is_main_frame, const CefString& top_origin_url, CefRefPtr<CefWebPluginInfo> plugin_info, cef_plugin_policy_t* plugin_policy);
}
namespace CefRequestContextHandlerExt {
	class GetCookieManagerArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefRefPtr<CefCookieManager> myext_ret_value; //0
		};
		argData arg;//
		GetCookieManagerArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetCookieManagerArgs);
	};
	class OnBeforePluginLoadArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			const CefString* mime_type;//1
			const CefString* plugin_url;//2
			bool is_main_frame;//3
			const CefString* top_origin_url;//4
			cef_web_plugin_info_t* plugin_info;//5
			cef_plugin_policy_t* plugin_policy;//6
		};
		argData arg;//
		OnBeforePluginLoadArgs(const CefString* mime_type, const CefString* plugin_url, bool is_main_frame, const CefString* top_origin_url, cef_web_plugin_info_t* plugin_info, cef_plugin_policy_t* plugin_policy)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 6);
			arg.myext_ret_value = 0;
			arg.mime_type = mime_type;
			arg.plugin_url = plugin_url;
			arg.is_main_frame = is_main_frame;
			arg.top_origin_url = top_origin_url;
			arg.plugin_info = plugin_info;
			arg.plugin_policy = plugin_policy;
		}
		OnBeforePluginLoadArgs(const CefString* mime_type, const CefString* plugin_url, bool is_main_frame, const CefString* top_origin_url, CefRefPtr<CefWebPluginInfo> plugin_info, cef_plugin_policy_t* plugin_policy)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 6);
			arg.myext_ret_value = 0;
			arg.mime_type = mime_type;
			arg.plugin_url = plugin_url;
			arg.is_main_frame = is_main_frame;
			arg.top_origin_url = top_origin_url;
			arg.plugin_info = CefWebPluginInfoCToCpp::Unwrap(plugin_info);
			arg.plugin_policy = plugin_policy;
		}
		~OnBeforePluginLoadArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefWebPluginInfoCToCpp::Wrap(arg.plugin_info);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforePluginLoadArgs);
	};
}
namespace CefRequestHandlerExt
{

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
namespace CefRequestHandlerExt {
	class OnBeforeBrowseArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			bool is_redirect;//4
		};
		argData arg;//
		OnBeforeBrowseArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, bool is_redirect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.is_redirect = is_redirect;
		}
		OnBeforeBrowseArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, bool is_redirect)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.is_redirect = is_redirect;
		}
		~OnBeforeBrowseArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeBrowseArgs);
	};
	class OnOpenURLFromTabArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			const CefString* target_url;//3
			cef_window_open_disposition_t target_disposition;//4
			bool user_gesture;//5
		};
		argData arg;//
		OnOpenURLFromTabArgs(cef_browser_t* browser, cef_frame_t* frame, const CefString* target_url, cef_window_open_disposition_t target_disposition, bool user_gesture)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.target_url = target_url;
			arg.target_disposition = target_disposition;
			arg.user_gesture = user_gesture;
		}
		OnOpenURLFromTabArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString* target_url, cef_window_open_disposition_t target_disposition, bool user_gesture)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.target_url = target_url;
			arg.target_disposition = target_disposition;
			arg.user_gesture = user_gesture;
		}
		~OnOpenURLFromTabArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnOpenURLFromTabArgs);
	};
	class OnBeforeResourceLoadArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_return_value_t myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			cef_request_callback_t* callback;//4
		};
		argData arg;//
		OnBeforeResourceLoadArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value =(cef_return_value_t) 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.callback = callback;
		}
		OnBeforeResourceLoadArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefRequestCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = (cef_return_value_t)0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.callback = CefRequestCallbackCToCpp::Unwrap(callback);
		}
		~OnBeforeResourceLoadArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
				CefRequestCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeResourceLoadArgs);
	};
	class GetResourceHandlerArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefRefPtr<CefResourceHandler> myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
		};
		argData arg;//
		GetResourceHandlerArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
		}
		GetResourceHandlerArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 3);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
		}
		~GetResourceHandlerArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResourceHandlerArgs);
	};
	class OnResourceRedirectArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			cef_response_t* response;//4
			CefString* new_url;//5
		};
		argData arg;//
		OnResourceRedirectArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, CefString* new_url)
		{
			arg.myext_flags = ((1 << 18) | 5);
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.response = response;
			arg.new_url = new_url;
		}
		OnResourceRedirectArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, CefString* new_url)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 5);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.response = CefResponseCToCpp::Unwrap(response);
			arg.new_url = new_url;
		}
		~OnResourceRedirectArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
				CefResponseCToCpp::Wrap(arg.response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceRedirectArgs);
	};
	class OnResourceResponseArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			cef_response_t* response;//4
		};
		argData arg;//
		OnResourceResponseArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.response = response;
		}
		OnResourceResponseArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.response = CefResponseCToCpp::Unwrap(response);
		}
		~OnResourceResponseArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
				CefResponseCToCpp::Wrap(arg.response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceResponseArgs);
	};
	class GetResourceResponseFilterArgs {
	public:
		struct argData {
			int32_t myext_flags;
			CefRefPtr<CefResponseFilter> myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			cef_response_t* response;//4
		};
		argData arg;//
		GetResourceResponseFilterArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.response = response;
		}
		GetResourceResponseFilterArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.response = CefResponseCToCpp::Unwrap(response);
		}
		~GetResourceResponseFilterArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
				CefResponseCToCpp::Wrap(arg.response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResourceResponseFilterArgs);
	};
	class OnResourceLoadCompleteArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			cef_request_t* request;//3
			cef_response_t* response;//4
			cef_urlrequest_status_t status;//5
			int64 received_content_length;//6
		};
		argData arg;//
		OnResourceLoadCompleteArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_urlrequest_status_t status, int64 received_content_length)
		{
			arg.myext_flags = ((1 << 18) | 6);
			arg.browser = browser;
			arg.frame = frame;
			arg.request = request;
			arg.response = response;
			arg.status = status;
			arg.received_content_length = received_content_length;
		}
		OnResourceLoadCompleteArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, cef_urlrequest_status_t status, int64 received_content_length)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 6);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.response = CefResponseCToCpp::Unwrap(response);
			arg.status = status;
			arg.received_content_length = received_content_length;
		}
		~OnResourceLoadCompleteArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefRequestCToCpp::Wrap(arg.request);
				CefResponseCToCpp::Wrap(arg.response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceLoadCompleteArgs);
	};
	class GetAuthCredentialsArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_frame_t* frame;//2
			bool isProxy;//3
			const CefString* host;//4
			int port;//5
			const CefString* realm;//6
			const CefString* scheme;//7
			cef_auth_callback_t* callback;//8
		};
		argData arg;//
		GetAuthCredentialsArgs(cef_browser_t* browser, cef_frame_t* frame, bool isProxy, const CefString* host, int port, const CefString* realm, const CefString* scheme, cef_auth_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 8);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.frame = frame;
			arg.isProxy = isProxy;
			arg.host = host;
			arg.port = port;
			arg.realm = realm;
			arg.scheme = scheme;
			arg.callback = callback;
		}
		GetAuthCredentialsArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, bool isProxy, const CefString* host, int port, const CefString* realm, const CefString* scheme, CefRefPtr<CefAuthCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 8);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.frame = CefFrameCToCpp::Unwrap(frame);
			arg.isProxy = isProxy;
			arg.host = host;
			arg.port = port;
			arg.realm = realm;
			arg.scheme = scheme;
			arg.callback = CefAuthCallbackCToCpp::Unwrap(callback);
		}
		~GetAuthCredentialsArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefFrameCToCpp::Wrap(arg.frame);
				CefAuthCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetAuthCredentialsArgs);
	};
	class OnQuotaRequestArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			const CefString* origin_url;//2
			int64 new_size;//3
			cef_request_callback_t* callback;//4
		};
		argData arg;//
		OnQuotaRequestArgs(cef_browser_t* browser, const CefString* origin_url, int64 new_size, cef_request_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.origin_url = origin_url;
			arg.new_size = new_size;
			arg.callback = callback;
		}
		OnQuotaRequestArgs(CefRefPtr<CefBrowser> browser, const CefString* origin_url, int64 new_size, CefRefPtr<CefRequestCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.origin_url = origin_url;
			arg.new_size = new_size;
			arg.callback = CefRequestCallbackCToCpp::Unwrap(callback);
		}
		~OnQuotaRequestArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefRequestCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnQuotaRequestArgs);
	};
	class OnProtocolExecutionArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const CefString* url;//2
			bool* allow_os_execution;//3
		};
		argData arg;//
		OnProtocolExecutionArgs(cef_browser_t* browser, const CefString* url, bool* allow_os_execution)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.browser = browser;
			arg.url = url;
			arg.allow_os_execution = allow_os_execution;
		}
		OnProtocolExecutionArgs(CefRefPtr<CefBrowser> browser, const CefString* url, bool* allow_os_execution)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.url = url;
			arg.allow_os_execution = allow_os_execution;
		}
		~OnProtocolExecutionArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnProtocolExecutionArgs);
	};
	class OnCertificateErrorArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			cef_errorcode_t cert_error;//2
			const CefString* request_url;//3
			cef_sslinfo_t* ssl_info;//4
			cef_request_callback_t* callback;//5
		};
		argData arg;//
		OnCertificateErrorArgs(cef_browser_t* browser, cef_errorcode_t cert_error, const CefString* request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.cert_error = cert_error;
			arg.request_url = request_url;
			arg.ssl_info = ssl_info;
			arg.callback = callback;
		}
		OnCertificateErrorArgs(CefRefPtr<CefBrowser> browser, cef_errorcode_t cert_error, const CefString* request_url, CefRefPtr<CefSSLInfo> ssl_info, CefRefPtr<CefRequestCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.cert_error = cert_error;
			arg.request_url = request_url;
			arg.ssl_info = CefSSLInfoCToCpp::Unwrap(ssl_info);
			arg.callback = CefRequestCallbackCToCpp::Unwrap(callback);
		}
		~OnCertificateErrorArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefSSLInfoCToCpp::Wrap(arg.ssl_info);
				CefRequestCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCertificateErrorArgs);
	};
	class OnSelectClientCertificateArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_browser_t* browser;//1
			bool isProxy;//2
			const CefString* host;//3
			int port;//4
			const std::vector<CefRefPtr<CefX509Certificate>>* certificates;//5
			cef_select_client_certificate_callback_t* callback;//6
		};
		argData arg;//
		OnSelectClientCertificateArgs(cef_browser_t* browser, bool isProxy, const CefString* host, int port, const std::vector<CefRefPtr<CefX509Certificate>>* certificates, cef_select_client_certificate_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 6);
			arg.myext_ret_value = 0;
			arg.browser = browser;
			arg.isProxy = isProxy;
			arg.host = host;
			arg.port = port;
			arg.certificates = certificates;
			arg.callback = callback;
		}
		OnSelectClientCertificateArgs(CefRefPtr<CefBrowser> browser, bool isProxy, const CefString* host, int port, const std::vector<CefRefPtr<CefX509Certificate>>* certificates, CefRefPtr<CefSelectClientCertificateCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 6);
			arg.myext_ret_value = 0;
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.isProxy = isProxy;
			arg.host = host;
			arg.port = port;
			arg.certificates = certificates;
			arg.callback = CefSelectClientCertificateCallbackCToCpp::Unwrap(callback);
		}
		~OnSelectClientCertificateArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
				CefSelectClientCertificateCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnSelectClientCertificateArgs);
	};
	class OnPluginCrashedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			const CefString* plugin_path;//2
		};
		argData arg;//
		OnPluginCrashedArgs(cef_browser_t* browser, const CefString* plugin_path)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.plugin_path = plugin_path;
		}
		OnPluginCrashedArgs(CefRefPtr<CefBrowser> browser, const CefString* plugin_path)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.plugin_path = plugin_path;
		}
		~OnPluginCrashedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPluginCrashedArgs);
	};
	class OnRenderViewReadyArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
		};
		argData arg;//
		OnRenderViewReadyArgs(cef_browser_t* browser)
		{
			arg.myext_flags = ((1 << 18) | 1);
			arg.browser = browser;
		}
		OnRenderViewReadyArgs(CefRefPtr<CefBrowser> browser)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 1);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
		}
		~OnRenderViewReadyArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderViewReadyArgs);
	};
	class OnRenderProcessTerminatedArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_browser_t* browser;//1
			cef_termination_status_t status;//2
		};
		argData arg;//
		OnRenderProcessTerminatedArgs(cef_browser_t* browser, cef_termination_status_t status)
		{
			arg.myext_flags = ((1 << 18) | 2);
			arg.browser = browser;
			arg.status = status;
		}
		OnRenderProcessTerminatedArgs(CefRefPtr<CefBrowser> browser, cef_termination_status_t status)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 2);
			arg.browser = CefBrowserCToCpp::Unwrap(browser);
			arg.status = status;
		}
		~OnRenderProcessTerminatedArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefBrowserCToCpp::Wrap(arg.browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderProcessTerminatedArgs);
	};
}
namespace CefResourceBundleHandlerExt
{

	//gen! bool GetLocalizedString(int string_id,CefString& string)
	bool GetLocalizedString(managed_callback mcallback, int string_id, CefString& string);

	//gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
	bool GetDataResource(managed_callback mcallback, int resource_id, void*& data, size_t& data_size);

	//gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
	bool GetDataResourceForScale(managed_callback mcallback, int resource_id, cef_scale_factor_t scale_factor, void*& data, size_t& data_size);
}
namespace CefResourceBundleHandlerExt {
	class GetLocalizedStringArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			int string_id;//1
			CefString* _string;//2
		};
		argData arg;//
		GetLocalizedStringArgs(int string_id, CefString* _string)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.string_id = string_id;
			arg._string = _string;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetLocalizedStringArgs);
	};
	class GetDataResourceArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			int resource_id;//1
			void** data;//2
			size_t* data_size;//3
		};
		argData arg;//
		GetDataResourceArgs(int resource_id, void** data, size_t* data_size)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.resource_id = resource_id;
			arg.data = data;
			arg.data_size = data_size;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetDataResourceArgs);
	};
	class GetDataResourceForScaleArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			int resource_id;//1
			cef_scale_factor_t scale_factor;//2
			void** data;//3
			size_t* data_size;//4
		};
		argData arg;//
		GetDataResourceForScaleArgs(int resource_id, cef_scale_factor_t scale_factor, void** data, size_t* data_size)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.resource_id = resource_id;
			arg.scale_factor = scale_factor;
			arg.data = data;
			arg.data_size = data_size;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetDataResourceForScaleArgs);
	};
}
namespace CefResourceHandlerExt
{

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
namespace CefResourceHandlerExt {
	class ProcessRequestArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			cef_request_t* request;//1
			cef_callback_t* callback;//2
		};
		argData arg;//
		ProcessRequestArgs(cef_request_t* request, cef_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.request = request;
			arg.callback = callback;
		}
		ProcessRequestArgs(CefRefPtr<CefRequest> request, CefRefPtr<CefCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 2);
			arg.myext_ret_value = 0;
			arg.request = CefRequestCToCpp::Unwrap(request);
			arg.callback = CefCallbackCToCpp::Unwrap(callback);
		}
		~ProcessRequestArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefRequestCToCpp::Wrap(arg.request);
				CefCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ProcessRequestArgs);
	};
	class GetResponseHeadersArgs {
	public:
		struct argData {
			int32_t myext_flags;
			cef_response_t* response;//1
			int64* response_length;//2
			CefString* redirectUrl;//3
		};
		argData arg;//
		GetResponseHeadersArgs(cef_response_t* response, int64* response_length, CefString* redirectUrl)
		{
			arg.myext_flags = ((1 << 18) | 3);
			arg.response = response;
			arg.response_length = response_length;
			arg.redirectUrl = redirectUrl;
		}
		GetResponseHeadersArgs(CefRefPtr<CefResponse> response, int64* response_length, CefString* redirectUrl)
		{
			arg.myext_flags = ((1 << 18) | (1 << 20) | 3);
			arg.response = CefResponseCToCpp::Unwrap(response);
			arg.response_length = response_length;
			arg.redirectUrl = redirectUrl;
		}
		~GetResponseHeadersArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefResponseCToCpp::Wrap(arg.response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResponseHeadersArgs);
	};
	class ReadResponseArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			void* data_out;//1
			int bytes_to_read;//2
			int* bytes_read;//3
			cef_callback_t* callback;//4
		};
		argData arg;//
		ReadResponseArgs(void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 4);
			arg.myext_ret_value = 0;
			arg.data_out = data_out;
			arg.bytes_to_read = bytes_to_read;
			arg.bytes_read = bytes_read;
			arg.callback = callback;
		}
		ReadResponseArgs(void* data_out, int bytes_to_read, int* bytes_read, CefRefPtr<CefCallback> callback)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 4);
			arg.myext_ret_value = 0;
			arg.data_out = data_out;
			arg.bytes_to_read = bytes_to_read;
			arg.bytes_read = bytes_read;
			arg.callback = CefCallbackCToCpp::Unwrap(callback);
		}
		~ReadResponseArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefCallbackCToCpp::Wrap(arg.callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ReadResponseArgs);
	};
	class CanGetCookieArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			const CefCookie* cookie;//1
		};
		argData arg;//
		CanGetCookieArgs(const CefCookie* cookie)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 1);
			arg.myext_ret_value = 0;
			arg.cookie = cookie;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(CanGetCookieArgs);
	};
	class CanSetCookieArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			const CefCookie* cookie;//1
		};
		argData arg;//
		CanSetCookieArgs(const CefCookie* cookie)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 1);
			arg.myext_ret_value = 0;
			arg.cookie = cookie;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(CanSetCookieArgs);
	};
	class CancelArgs {
	public:
		struct argData {
			int32_t myext_flags;
		};
		argData arg;//
		CancelArgs()
		{
			arg.myext_flags = ((1 << 18) | 0);
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(CancelArgs);
	};
}
namespace CefReadHandlerExt
{

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
namespace CefReadHandlerExt {
	class ReadArgs {
	public:
		struct argData {
			int32_t myext_flags;
			size_t myext_ret_value; //0
			void* ptr;//1
			size_t size;//2
			size_t n;//3
		};
		argData arg;//
		ReadArgs(void* ptr, size_t size, size_t n)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.ptr = ptr;
			arg.size = size;
			arg.n = n;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ReadArgs);
	};
	class SeekArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int myext_ret_value; //0
			int64 offset;//1
			int whence;//2
		};
		argData arg;//
		SeekArgs(int64 offset, int whence)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.offset = offset;
			arg.whence = whence;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(SeekArgs);
	};
	class TellArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int64 myext_ret_value; //0
		};
		argData arg;//
		TellArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(TellArgs);
	};
	class EofArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int myext_ret_value; //0
		};
		argData arg;//
		EofArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(EofArgs);
	};
	class MayBlockArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
		};
		argData arg;//
		MayBlockArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(MayBlockArgs);
	};
}
namespace CefWriteHandlerExt
{

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
namespace CefWriteHandlerExt {
	class WriteArgs {
	public:
		struct argData {
			int32_t myext_flags;
			size_t myext_ret_value; //0
			const void* ptr;//1
			size_t size;//2
			size_t n;//3
		};
		argData arg;//
		WriteArgs(const void* ptr, size_t size, size_t n)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 3);
			arg.myext_ret_value = 0;
			arg.ptr = ptr;
			arg.size = size;
			arg.n = n;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(WriteArgs);
	};
	class SeekArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int myext_ret_value; //0
			int64 offset;//1
			int whence;//2
		};
		argData arg;//
		SeekArgs(int64 offset, int whence)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 2);
			arg.myext_ret_value = 0;
			arg.offset = offset;
			arg.whence = whence;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(SeekArgs);
	};
	class TellArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int64 myext_ret_value; //0
		};
		argData arg;//
		TellArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(TellArgs);
	};
	class FlushArgs {
	public:
		struct argData {
			int32_t myext_flags;
			int myext_ret_value; //0
		};
		argData arg;//
		FlushArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(FlushArgs);
	};
	class MayBlockArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
		};
		argData arg;//
		MayBlockArgs()
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 0);
			arg.myext_ret_value = 0;
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(MayBlockArgs);
	};
}
namespace CefV8HandlerExt
{

	//gen! bool Execute(const CefString& name,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments,CefRefPtr<CefV8Value>& retval,CefString& exception)
	bool Execute(managed_callback mcallback, const CefString& name, CefRefPtr<CefV8Value> object, const CefV8ValueList& arguments, CefRefPtr<CefV8Value>& retval, CefString& exception);
}
namespace CefV8HandlerExt {
	class ExecuteArgs {
	public:
		struct argData {
			int32_t myext_flags;
			bool myext_ret_value; //0
			const CefString* name;//1
			cef_v8value_t* _object;//2
			const CefV8ValueList* arguments;//3
			CefRefPtr<CefV8Value>* retval;//4
			CefString* exception;//5
		};
		argData arg;//
		ExecuteArgs(const CefString* name, cef_v8value_t* _object, const CefV8ValueList* arguments, CefRefPtr<CefV8Value>* retval, CefString* exception)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | 5);
			arg.myext_ret_value = 0;
			arg.name = name;
			arg._object = _object;
			arg.arguments = arguments;
			arg.retval = retval;
			arg.exception = exception;
		}
		ExecuteArgs(const CefString* name, CefRefPtr<CefV8Value> _object, const CefV8ValueList* arguments, CefRefPtr<CefV8Value>* retval, CefString* exception)
		{
			arg.myext_flags = ((1 << 18) | (1 << 19) | (1 << 20) | 5);
			arg.myext_ret_value = 0;
			arg.name = name;
			arg._object = CefV8ValueCToCpp::Unwrap(_object);
			arg.arguments = arguments;
			arg.retval = retval;
			arg.exception = exception;
		}
		~ExecuteArgs() {
			if (((arg.myext_flags >> 20) & 1) == 1) {
				CefV8ValueCToCpp::Wrap(arg._object);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ExecuteArgs);
	};
}
