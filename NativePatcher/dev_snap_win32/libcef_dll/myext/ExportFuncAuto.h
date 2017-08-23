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
		int32_t myext_argCount;
		cef_value_t* value;//1
						   //
		bool myext_created_from_Unwrap;
		//
		OnAccessibilityTreeChangeArgs(cef_value_t* value)
			:myext_argCount(1), myext_created_from_Unwrap(false), value(value) {}
		OnAccessibilityTreeChangeArgs(CefRefPtr<CefValue> value)
			:myext_argCount(1), myext_created_from_Unwrap(true), value(CefValueCToCpp::Unwrap(value)) {}
		~OnAccessibilityTreeChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefValueCToCpp::Wrap(value);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAccessibilityTreeChangeArgs);
	};
	class OnAccessibilityLocationChangeArgs {
	public:
		int32_t myext_argCount;
		cef_value_t* value;//1
						   //
		bool myext_created_from_Unwrap;
		//
		OnAccessibilityLocationChangeArgs(cef_value_t* value)
			:myext_argCount(1), myext_created_from_Unwrap(false), value(value) {}
		OnAccessibilityLocationChangeArgs(CefRefPtr<CefValue> value)
			:myext_argCount(1), myext_created_from_Unwrap(true), value(CefValueCToCpp::Unwrap(value)) {}
		~OnAccessibilityLocationChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefValueCToCpp::Wrap(value);
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
		int32_t myext_argCount;
		//
		bool myext_created_from_Unwrap;
		//
		OnContextInitializedArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextInitializedArgs);
	};
	class OnBeforeChildProcessLaunchArgs {
	public:
		int32_t myext_argCount;
		cef_command_line_t* command_line;//1
										 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeChildProcessLaunchArgs(cef_command_line_t* command_line)
			:myext_argCount(1), myext_created_from_Unwrap(false), command_line(command_line) {}
		OnBeforeChildProcessLaunchArgs(CefRefPtr<CefCommandLine> command_line)
			:myext_argCount(1), myext_created_from_Unwrap(true), command_line(CefCommandLineCToCpp::Unwrap(command_line)) {}
		~OnBeforeChildProcessLaunchArgs() {
			if (myext_created_from_Unwrap) {
				CefCommandLineCToCpp::Wrap(command_line);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeChildProcessLaunchArgs);
	};
	class OnRenderProcessThreadCreatedArgs {
	public:
		int32_t myext_argCount;
		cef_list_value_t* extra_info;//1
									 //
		bool myext_created_from_Unwrap;
		//
		OnRenderProcessThreadCreatedArgs(cef_list_value_t* extra_info)
			:myext_argCount(1), myext_created_from_Unwrap(false), extra_info(extra_info) {}
		OnRenderProcessThreadCreatedArgs(CefRefPtr<CefListValue> extra_info)
			:myext_argCount(1), myext_created_from_Unwrap(true), extra_info(CefListValueCToCpp::Unwrap(extra_info)) {}
		~OnRenderProcessThreadCreatedArgs() {
			if (myext_created_from_Unwrap) {
				CefListValueCToCpp::Wrap(extra_info);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderProcessThreadCreatedArgs);
	};
	class GetPrintHandlerArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefPrintHandler> myext_ret_value; //0
													//
		bool myext_created_from_Unwrap;
		//
		GetPrintHandlerArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetPrintHandlerArgs);
	};
	class OnScheduleMessagePumpWorkArgs {
	public:
		int32_t myext_argCount;
		int64 delay_ms;//1
					   //
		bool myext_created_from_Unwrap;
		//
		OnScheduleMessagePumpWorkArgs(int64 delay_ms)
			:myext_argCount(1), myext_created_from_Unwrap(false), delay_ms(delay_ms) {}
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_context_menu_params_t* _params;//3
		cef_menu_model_t* model;//4
								//
		bool myext_created_from_Unwrap;
		//
		OnBeforeContextMenuArgs(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* _params, cef_menu_model_t* model)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), frame(frame), _params(_params), model(model) {}
		OnBeforeContextMenuArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, CefRefPtr<CefMenuModel> model)
			:myext_argCount(4), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), _params(CefContextMenuParamsCToCpp::Unwrap(_params)), model(CefMenuModelCToCpp::Unwrap(model)) {}
		~OnBeforeContextMenuArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefContextMenuParamsCToCpp::Wrap(_params);
				CefMenuModelCToCpp::Wrap(model);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeContextMenuArgs);
	};
	class RunContextMenuArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_context_menu_params_t* _params;//3
		cef_menu_model_t* model;//4
		cef_run_context_menu_callback_t* callback;//5
												  //
		bool myext_created_from_Unwrap;
		//
		RunContextMenuArgs(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* _params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), _params(_params), model(model), callback(callback) {}
		RunContextMenuArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, CefRefPtr<CefMenuModel> model, CefRefPtr<CefRunContextMenuCallback> callback)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), _params(CefContextMenuParamsCToCpp::Unwrap(_params)), model(CefMenuModelCToCpp::Unwrap(model)), callback(CefRunContextMenuCallbackCToCpp::Unwrap(callback)) {}
		~RunContextMenuArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefContextMenuParamsCToCpp::Wrap(_params);
				CefMenuModelCToCpp::Wrap(model);
				CefRunContextMenuCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(RunContextMenuArgs);
	};
	class OnContextMenuCommandArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_context_menu_params_t* _params;//3
		int command_id;//4
		cef_event_flags_t event_flags;//5
									  //
		bool myext_created_from_Unwrap;
		//
		OnContextMenuCommandArgs(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* _params, int command_id, cef_event_flags_t event_flags)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), _params(_params), command_id(command_id), event_flags(event_flags) {}
		OnContextMenuCommandArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, int command_id, cef_event_flags_t event_flags)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), _params(CefContextMenuParamsCToCpp::Unwrap(_params)), command_id(command_id), event_flags(event_flags) {}
		~OnContextMenuCommandArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefContextMenuParamsCToCpp::Wrap(_params);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextMenuCommandArgs);
	};
	class OnContextMenuDismissedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
						   //
		bool myext_created_from_Unwrap;
		//
		OnContextMenuDismissedArgs(cef_browser_t* browser, cef_frame_t* frame)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), frame(frame) {}
		OnContextMenuDismissedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)) {}
		~OnContextMenuDismissedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_file_dialog_mode_t mode;//2
		const CefString& title;//3
		const CefString& default_file_path;//4
		const std::vector<CefString>& accept_filters;//5
		int selected_accept_filter;//6
		cef_file_dialog_callback_t* callback;//7
											 //
		bool myext_created_from_Unwrap;
		//
		OnFileDialogArgs(cef_browser_t* browser, cef_file_dialog_mode_t mode, const CefString& title, const CefString& default_file_path, const std::vector<CefString>& accept_filters, int selected_accept_filter, cef_file_dialog_callback_t* callback)
			:myext_argCount(7), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), mode(mode), title(title), default_file_path(default_file_path), accept_filters(accept_filters), selected_accept_filter(selected_accept_filter), callback(callback) {}
		OnFileDialogArgs(CefRefPtr<CefBrowser> browser, cef_file_dialog_mode_t mode, const CefString& title, const CefString& default_file_path, const std::vector<CefString>& accept_filters, int selected_accept_filter, CefRefPtr<CefFileDialogCallback> callback)
			:myext_argCount(7), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), mode(mode), title(title), default_file_path(default_file_path), accept_filters(accept_filters), selected_accept_filter(selected_accept_filter), callback(CefFileDialogCallbackCToCpp::Unwrap(callback)) {}
		~OnFileDialogArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFileDialogCallbackCToCpp::Wrap(callback);
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		const CefString& url;//3
							 //
		bool myext_created_from_Unwrap;
		//
		OnAddressChangeArgs(cef_browser_t* browser, cef_frame_t* frame, const CefString& url)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), url(url) {}
		OnAddressChangeArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& url)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), url(url) {}
		~OnAddressChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAddressChangeArgs);
	};
	class OnTitleChangeArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const CefString& title;//2
							   //
		bool myext_created_from_Unwrap;
		//
		OnTitleChangeArgs(cef_browser_t* browser, const CefString& title)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), title(title) {}
		OnTitleChangeArgs(CefRefPtr<CefBrowser> browser, const CefString& title)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), title(title) {}
		~OnTitleChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTitleChangeArgs);
	};
	class OnFaviconURLChangeArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const std::vector<CefString>& icon_urls;//2
												//
		bool myext_created_from_Unwrap;
		//
		OnFaviconURLChangeArgs(cef_browser_t* browser, const std::vector<CefString>& icon_urls)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), icon_urls(icon_urls) {}
		OnFaviconURLChangeArgs(CefRefPtr<CefBrowser> browser, const std::vector<CefString>& icon_urls)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), icon_urls(icon_urls) {}
		~OnFaviconURLChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFaviconURLChangeArgs);
	};
	class OnFullscreenModeChangeArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		bool fullscreen;//2
						//
		bool myext_created_from_Unwrap;
		//
		OnFullscreenModeChangeArgs(cef_browser_t* browser, bool fullscreen)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), fullscreen(fullscreen) {}
		OnFullscreenModeChangeArgs(CefRefPtr<CefBrowser> browser, bool fullscreen)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), fullscreen(fullscreen) {}
		~OnFullscreenModeChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFullscreenModeChangeArgs);
	};
	class OnTooltipArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		CefString& text;//2
						//
		bool myext_created_from_Unwrap;
		//
		OnTooltipArgs(cef_browser_t* browser, CefString& text)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), text(text) {}
		OnTooltipArgs(CefRefPtr<CefBrowser> browser, CefString& text)
			:myext_argCount(2), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), text(text) {}
		~OnTooltipArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTooltipArgs);
	};
	class OnStatusMessageArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const CefString& value;//2
							   //
		bool myext_created_from_Unwrap;
		//
		OnStatusMessageArgs(cef_browser_t* browser, const CefString& value)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), value(value) {}
		OnStatusMessageArgs(CefRefPtr<CefBrowser> browser, const CefString& value)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), value(value) {}
		~OnStatusMessageArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnStatusMessageArgs);
	};
	class OnConsoleMessageArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefString& message;//2
		const CefString& source;//3
		int line;//4
				 //
		bool myext_created_from_Unwrap;
		//
		OnConsoleMessageArgs(cef_browser_t* browser, const CefString& message, const CefString& source, int line)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), message(message), source(source), line(line) {}
		OnConsoleMessageArgs(CefRefPtr<CefBrowser> browser, const CefString& message, const CefString& source, int line)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), message(message), source(source), line(line) {}
		~OnConsoleMessageArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_download_item_t* download_item;//2
		const CefString& suggested_name;//3
		cef_before_download_callback_t* callback;//4
												 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeDownloadArgs(cef_browser_t* browser, cef_download_item_t* download_item, const CefString& suggested_name, cef_before_download_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), download_item(download_item), suggested_name(suggested_name), callback(callback) {}
		OnBeforeDownloadArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, const CefString& suggested_name, CefRefPtr<CefBeforeDownloadCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), download_item(CefDownloadItemCToCpp::Unwrap(download_item)), suggested_name(suggested_name), callback(CefBeforeDownloadCallbackCToCpp::Unwrap(callback)) {}
		~OnBeforeDownloadArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefDownloadItemCToCpp::Wrap(download_item);
				CefBeforeDownloadCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeDownloadArgs);
	};
	class OnDownloadUpdatedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_download_item_t* download_item;//2
		cef_download_item_callback_t* callback;//3
											   //
		bool myext_created_from_Unwrap;
		//
		OnDownloadUpdatedArgs(cef_browser_t* browser, cef_download_item_t* download_item, cef_download_item_callback_t* callback)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), download_item(download_item), callback(callback) {}
		OnDownloadUpdatedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, CefRefPtr<CefDownloadItemCallback> callback)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), download_item(CefDownloadItemCToCpp::Unwrap(download_item)), callback(CefDownloadItemCallbackCToCpp::Unwrap(callback)) {}
		~OnDownloadUpdatedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefDownloadItemCToCpp::Wrap(download_item);
				CefDownloadItemCallbackCToCpp::Wrap(callback);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_drag_data_t* dragData;//2
		cef_drag_operations_mask_t mask;//3
										//
		bool myext_created_from_Unwrap;
		//
		OnDragEnterArgs(cef_browser_t* browser, cef_drag_data_t* dragData, cef_drag_operations_mask_t mask)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), dragData(dragData), mask(mask) {}
		OnDragEnterArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> dragData, cef_drag_operations_mask_t mask)
			:myext_argCount(3), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), dragData(CefDragDataCToCpp::Unwrap(dragData)), mask(mask) {}
		~OnDragEnterArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefDragDataCToCpp::Wrap(dragData);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnDragEnterArgs);
	};
	class OnDraggableRegionsChangedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const std::vector<CefDraggableRegion>& regions;//2
													   //
		bool myext_created_from_Unwrap;
		//
		OnDraggableRegionsChangedArgs(cef_browser_t* browser, const std::vector<CefDraggableRegion>& regions)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), regions(regions) {}
		OnDraggableRegionsChangedArgs(CefRefPtr<CefBrowser> browser, const std::vector<CefDraggableRegion>& regions)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), regions(regions) {}
		~OnDraggableRegionsChangedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		int identifier;//2
		int count;//3
		const CefRect& selectionRect;//4
		int activeMatchOrdinal;//5
		bool finalUpdate;//6
						 //
		bool myext_created_from_Unwrap;
		//
		OnFindResultArgs(cef_browser_t* browser, int identifier, int count, const CefRect& selectionRect, int activeMatchOrdinal, bool finalUpdate)
			:myext_argCount(6), myext_created_from_Unwrap(false), browser(browser), identifier(identifier), count(count), selectionRect(selectionRect), activeMatchOrdinal(activeMatchOrdinal), finalUpdate(finalUpdate) {}
		OnFindResultArgs(CefRefPtr<CefBrowser> browser, int identifier, int count, const CefRect& selectionRect, int activeMatchOrdinal, bool finalUpdate)
			:myext_argCount(6), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), identifier(identifier), count(count), selectionRect(selectionRect), activeMatchOrdinal(activeMatchOrdinal), finalUpdate(finalUpdate) {}
		~OnFindResultArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		bool next;//2
				  //
		bool myext_created_from_Unwrap;
		//
		OnTakeFocusArgs(cef_browser_t* browser, bool next)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), next(next) {}
		OnTakeFocusArgs(CefRefPtr<CefBrowser> browser, bool next)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), next(next) {}
		~OnTakeFocusArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTakeFocusArgs);
	};
	class OnSetFocusArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_focus_source_t source;//2
								  //
		bool myext_created_from_Unwrap;
		//
		OnSetFocusArgs(cef_browser_t* browser, cef_focus_source_t source)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), source(source) {}
		OnSetFocusArgs(CefRefPtr<CefBrowser> browser, cef_focus_source_t source)
			:myext_argCount(2), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), source(source) {}
		~OnSetFocusArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnSetFocusArgs);
	};
	class OnGotFocusArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnGotFocusArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnGotFocusArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnGotFocusArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefString& requesting_url;//2
		int request_id;//3
		cef_geolocation_callback_t* callback;//4
											 //
		bool myext_created_from_Unwrap;
		//
		OnRequestGeolocationPermissionArgs(cef_browser_t* browser, const CefString& requesting_url, int request_id, cef_geolocation_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), requesting_url(requesting_url), request_id(request_id), callback(callback) {}
		OnRequestGeolocationPermissionArgs(CefRefPtr<CefBrowser> browser, const CefString& requesting_url, int request_id, CefRefPtr<CefGeolocationCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), requesting_url(requesting_url), request_id(request_id), callback(CefGeolocationCallbackCToCpp::Unwrap(callback)) {}
		~OnRequestGeolocationPermissionArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefGeolocationCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRequestGeolocationPermissionArgs);
	};
	class OnCancelGeolocationPermissionArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		int request_id;//2
					   //
		bool myext_created_from_Unwrap;
		//
		OnCancelGeolocationPermissionArgs(cef_browser_t* browser, int request_id)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), request_id(request_id) {}
		OnCancelGeolocationPermissionArgs(CefRefPtr<CefBrowser> browser, int request_id)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), request_id(request_id) {}
		~OnCancelGeolocationPermissionArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefString& origin_url;//2
		cef_jsdialog_type_t dialog_type;//3
		const CefString& message_text;//4
		const CefString& default_prompt_text;//5
		cef_jsdialog_callback_t* callback;//6
		bool& suppress_message;//7
							   //
		bool myext_created_from_Unwrap;
		//
		OnJSDialogArgs(cef_browser_t* browser, const CefString& origin_url, cef_jsdialog_type_t dialog_type, const CefString& message_text, const CefString& default_prompt_text, cef_jsdialog_callback_t* callback, bool& suppress_message)
			:myext_argCount(7), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), origin_url(origin_url), dialog_type(dialog_type), message_text(message_text), default_prompt_text(default_prompt_text), callback(callback), suppress_message(suppress_message) {}
		OnJSDialogArgs(CefRefPtr<CefBrowser> browser, const CefString& origin_url, cef_jsdialog_type_t dialog_type, const CefString& message_text, const CefString& default_prompt_text, CefRefPtr<CefJSDialogCallback> callback, bool& suppress_message)
			:myext_argCount(7), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), origin_url(origin_url), dialog_type(dialog_type), message_text(message_text), default_prompt_text(default_prompt_text), callback(CefJSDialogCallbackCToCpp::Unwrap(callback)), suppress_message(suppress_message) {}
		~OnJSDialogArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefJSDialogCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnJSDialogArgs);
	};
	class OnBeforeUnloadDialogArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefString& message_text;//2
		bool is_reload;//3
		cef_jsdialog_callback_t* callback;//4
										  //
		bool myext_created_from_Unwrap;
		//
		OnBeforeUnloadDialogArgs(cef_browser_t* browser, const CefString& message_text, bool is_reload, cef_jsdialog_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), message_text(message_text), is_reload(is_reload), callback(callback) {}
		OnBeforeUnloadDialogArgs(CefRefPtr<CefBrowser> browser, const CefString& message_text, bool is_reload, CefRefPtr<CefJSDialogCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), message_text(message_text), is_reload(is_reload), callback(CefJSDialogCallbackCToCpp::Unwrap(callback)) {}
		~OnBeforeUnloadDialogArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefJSDialogCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeUnloadDialogArgs);
	};
	class OnResetDialogStateArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnResetDialogStateArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnResetDialogStateArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnResetDialogStateArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResetDialogStateArgs);
	};
	class OnDialogClosedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnDialogClosedArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnDialogClosedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnDialogClosedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefKeyEvent& _event;//2
		CefEventHandle os_event;//3
		bool* is_keyboard_shortcut;//4
								   //
		bool myext_created_from_Unwrap;
		//
		OnPreKeyEventArgs(cef_browser_t* browser, const CefKeyEvent& _event, CefEventHandle os_event, bool* is_keyboard_shortcut)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), _event(_event), os_event(os_event), is_keyboard_shortcut(is_keyboard_shortcut) {}
		OnPreKeyEventArgs(CefRefPtr<CefBrowser> browser, const CefKeyEvent& _event, CefEventHandle os_event, bool* is_keyboard_shortcut)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), _event(_event), os_event(os_event), is_keyboard_shortcut(is_keyboard_shortcut) {}
		~OnPreKeyEventArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPreKeyEventArgs);
	};
	class OnKeyEventArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefKeyEvent& _event;//2
		CefEventHandle os_event;//3
								//
		bool myext_created_from_Unwrap;
		//
		OnKeyEventArgs(cef_browser_t* browser, const CefKeyEvent& _event, CefEventHandle os_event)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), _event(_event), os_event(os_event) {}
		OnKeyEventArgs(CefRefPtr<CefBrowser> browser, const CefKeyEvent& _event, CefEventHandle os_event)
			:myext_argCount(3), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), _event(_event), os_event(os_event) {}
		~OnKeyEventArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		const CefString& target_url;//3
		const CefString& target_frame_name;//4
		cef_window_open_disposition_t target_disposition;//5
		bool user_gesture;//6
		const CefPopupFeatures& popupFeatures;//7
		CefWindowInfo& windowInfo;//8
		CefRefPtr<CefClient>& client;//9
		CefBrowserSettings& settings;//10
		bool* no_javascript_access;//11
								   //
		bool myext_created_from_Unwrap;
		//
		OnBeforePopupArgs(cef_browser_t* browser, cef_frame_t* frame, const CefString& target_url, const CefString& target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures& popupFeatures, CefWindowInfo& windowInfo, CefRefPtr<CefClient>& client, CefBrowserSettings& settings, bool* no_javascript_access)
			:myext_argCount(11), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), target_url(target_url), target_frame_name(target_frame_name), target_disposition(target_disposition), user_gesture(user_gesture), popupFeatures(popupFeatures), windowInfo(windowInfo), client(client), settings(settings), no_javascript_access(no_javascript_access) {}
		OnBeforePopupArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, const CefString& target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures& popupFeatures, CefWindowInfo& windowInfo, CefRefPtr<CefClient>& client, CefBrowserSettings& settings, bool* no_javascript_access)
			:myext_argCount(11), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), target_url(target_url), target_frame_name(target_frame_name), target_disposition(target_disposition), user_gesture(user_gesture), popupFeatures(popupFeatures), windowInfo(windowInfo), client(client), settings(settings), no_javascript_access(no_javascript_access) {}
		~OnBeforePopupArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforePopupArgs);
	};
	class OnAfterCreatedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnAfterCreatedArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnAfterCreatedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnAfterCreatedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAfterCreatedArgs);
	};
	class DoCloseArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		DoCloseArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser) {}
		DoCloseArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~DoCloseArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(DoCloseArgs);
	};
	class OnBeforeCloseArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnBeforeCloseArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnBeforeCloseArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnBeforeCloseArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		bool isLoading;//2
		bool canGoBack;//3
		bool canGoForward;//4
						  //
		bool myext_created_from_Unwrap;
		//
		OnLoadingStateChangeArgs(cef_browser_t* browser, bool isLoading, bool canGoBack, bool canGoForward)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), isLoading(isLoading), canGoBack(canGoBack), canGoForward(canGoForward) {}
		OnLoadingStateChangeArgs(CefRefPtr<CefBrowser> browser, bool isLoading, bool canGoBack, bool canGoForward)
			:myext_argCount(4), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), isLoading(isLoading), canGoBack(canGoBack), canGoForward(canGoForward) {}
		~OnLoadingStateChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadingStateChangeArgs);
	};
	class OnLoadStartArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_transition_type_t transition_type;//3
											  //
		bool myext_created_from_Unwrap;
		//
		OnLoadStartArgs(cef_browser_t* browser, cef_frame_t* frame, cef_transition_type_t transition_type)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), transition_type(transition_type) {}
		OnLoadStartArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_transition_type_t transition_type)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), transition_type(transition_type) {}
		~OnLoadStartArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadStartArgs);
	};
	class OnLoadEndArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		int httpStatusCode;//3
						   //
		bool myext_created_from_Unwrap;
		//
		OnLoadEndArgs(cef_browser_t* browser, cef_frame_t* frame, int httpStatusCode)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), httpStatusCode(httpStatusCode) {}
		OnLoadEndArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, int httpStatusCode)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), httpStatusCode(httpStatusCode) {}
		~OnLoadEndArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadEndArgs);
	};
	class OnLoadErrorArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_errorcode_t errorCode;//3
		const CefString& errorText;//4
		const CefString& failedUrl;//5
								   //
		bool myext_created_from_Unwrap;
		//
		OnLoadErrorArgs(cef_browser_t* browser, cef_frame_t* frame, cef_errorcode_t errorCode, const CefString& errorText, const CefString& failedUrl)
			:myext_argCount(5), myext_created_from_Unwrap(false), browser(browser), frame(frame), errorCode(errorCode), errorText(errorText), failedUrl(failedUrl) {}
		OnLoadErrorArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_errorcode_t errorCode, const CefString& errorText, const CefString& failedUrl)
			:myext_argCount(5), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), errorCode(errorCode), errorText(errorText), failedUrl(failedUrl) {}
		~OnLoadErrorArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
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
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnPrintStartArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnPrintStartArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnPrintStartArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintStartArgs);
	};
	class OnPrintSettingsArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_print_settings_t* settings;//2
		bool get_defaults;//3
						  //
		bool myext_created_from_Unwrap;
		//
		OnPrintSettingsArgs(cef_browser_t* browser, cef_print_settings_t* settings, bool get_defaults)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), settings(settings), get_defaults(get_defaults) {}
		OnPrintSettingsArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefPrintSettings> settings, bool get_defaults)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), settings(CefPrintSettingsCToCpp::Unwrap(settings)), get_defaults(get_defaults) {}
		~OnPrintSettingsArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefPrintSettingsCToCpp::Wrap(settings);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintSettingsArgs);
	};
	class OnPrintDialogArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		bool has_selection;//2
		cef_print_dialog_callback_t* callback;//3
											  //
		bool myext_created_from_Unwrap;
		//
		OnPrintDialogArgs(cef_browser_t* browser, bool has_selection, cef_print_dialog_callback_t* callback)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), has_selection(has_selection), callback(callback) {}
		OnPrintDialogArgs(CefRefPtr<CefBrowser> browser, bool has_selection, CefRefPtr<CefPrintDialogCallback> callback)
			:myext_argCount(3), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), has_selection(has_selection), callback(CefPrintDialogCallbackCToCpp::Unwrap(callback)) {}
		~OnPrintDialogArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefPrintDialogCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintDialogArgs);
	};
	class OnPrintJobArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefString& document_name;//2
		const CefString& pdf_file_path;//3
		cef_print_job_callback_t* callback;//4
										   //
		bool myext_created_from_Unwrap;
		//
		OnPrintJobArgs(cef_browser_t* browser, const CefString& document_name, const CefString& pdf_file_path, cef_print_job_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), document_name(document_name), pdf_file_path(pdf_file_path), callback(callback) {}
		OnPrintJobArgs(CefRefPtr<CefBrowser> browser, const CefString& document_name, const CefString& pdf_file_path, CefRefPtr<CefPrintJobCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), document_name(document_name), pdf_file_path(pdf_file_path), callback(CefPrintJobCallbackCToCpp::Unwrap(callback)) {}
		~OnPrintJobArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefPrintJobCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintJobArgs);
	};
	class OnPrintResetArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnPrintResetArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnPrintResetArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnPrintResetArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintResetArgs);
	};
	class GetPdfPaperSizeArgs {
	public:
		int32_t myext_argCount;
		CefSize myext_ret_value; //0
		int device_units_per_inch;//1
								  //
		bool myext_created_from_Unwrap;
		//
		GetPdfPaperSizeArgs(int device_units_per_inch)
			:myext_argCount(1), myext_created_from_Unwrap(false), myext_ret_value(CefSize()), device_units_per_inch(device_units_per_inch) {}
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
		int32_t myext_argCount;
		CefRefPtr<CefAccessibilityHandler> myext_ret_value; //0
															//
		bool myext_created_from_Unwrap;
		//
		GetAccessibilityHandlerArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetAccessibilityHandlerArgs);
	};
	class GetRootScreenRectArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		CefRect& rect;//2
					  //
		bool myext_created_from_Unwrap;
		//
		GetRootScreenRectArgs(cef_browser_t* browser, CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), rect(rect) {}
		GetRootScreenRectArgs(CefRefPtr<CefBrowser> browser, CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), rect(rect) {}
		~GetRootScreenRectArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetRootScreenRectArgs);
	};
	class GetViewRectArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		CefRect& rect;//2
					  //
		bool myext_created_from_Unwrap;
		//
		GetViewRectArgs(cef_browser_t* browser, CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), rect(rect) {}
		GetViewRectArgs(CefRefPtr<CefBrowser> browser, CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), rect(rect) {}
		~GetViewRectArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetViewRectArgs);
	};
	class GetScreenPointArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		int viewX;//2
		int viewY;//3
		int& screenX;//4
		int& screenY;//5
					 //
		bool myext_created_from_Unwrap;
		//
		GetScreenPointArgs(cef_browser_t* browser, int viewX, int viewY, int& screenX, int& screenY)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), viewX(viewX), viewY(viewY), screenX(screenX), screenY(screenY) {}
		GetScreenPointArgs(CefRefPtr<CefBrowser> browser, int viewX, int viewY, int& screenX, int& screenY)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), viewX(viewX), viewY(viewY), screenX(screenX), screenY(screenY) {}
		~GetScreenPointArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetScreenPointArgs);
	};
	class GetScreenInfoArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		CefScreenInfo& screen_info;//2
								   //
		bool myext_created_from_Unwrap;
		//
		GetScreenInfoArgs(cef_browser_t* browser, CefScreenInfo& screen_info)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), screen_info(screen_info) {}
		GetScreenInfoArgs(CefRefPtr<CefBrowser> browser, CefScreenInfo& screen_info)
			:myext_argCount(2), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), screen_info(screen_info) {}
		~GetScreenInfoArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetScreenInfoArgs);
	};
	class OnPopupShowArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		bool show;//2
				  //
		bool myext_created_from_Unwrap;
		//
		OnPopupShowArgs(cef_browser_t* browser, bool show)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), show(show) {}
		OnPopupShowArgs(CefRefPtr<CefBrowser> browser, bool show)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), show(show) {}
		~OnPopupShowArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPopupShowArgs);
	};
	class OnPopupSizeArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const CefRect& rect;//2
							//
		bool myext_created_from_Unwrap;
		//
		OnPopupSizeArgs(cef_browser_t* browser, const CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), rect(rect) {}
		OnPopupSizeArgs(CefRefPtr<CefBrowser> browser, const CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), rect(rect) {}
		~OnPopupSizeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPopupSizeArgs);
	};
	class OnPaintArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_paint_element_type_t type;//2
		const std::vector<CefRect>& dirtyRects;//3
		const void* buffer;//4
		int width;//5
		int height;//6
				   //
		bool myext_created_from_Unwrap;
		//
		OnPaintArgs(cef_browser_t* browser, cef_paint_element_type_t type, const std::vector<CefRect>& dirtyRects, const void* buffer, int width, int height)
			:myext_argCount(6), myext_created_from_Unwrap(false), browser(browser), type(type), dirtyRects(dirtyRects), buffer(buffer), width(width), height(height) {}
		OnPaintArgs(CefRefPtr<CefBrowser> browser, cef_paint_element_type_t type, const std::vector<CefRect>& dirtyRects, const void* buffer, int width, int height)
			:myext_argCount(6), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), type(type), dirtyRects(dirtyRects), buffer(buffer), width(width), height(height) {}
		~OnPaintArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPaintArgs);
	};
	class OnCursorChangeArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		CefCursorHandle cursor;//2
		cef_cursor_type_t type;//3
		const CefCursorInfo& custom_cursor_info;//4
												//
		bool myext_created_from_Unwrap;
		//
		OnCursorChangeArgs(cef_browser_t* browser, CefCursorHandle cursor, cef_cursor_type_t type, const CefCursorInfo& custom_cursor_info)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), cursor(cursor), type(type), custom_cursor_info(custom_cursor_info) {}
		OnCursorChangeArgs(CefRefPtr<CefBrowser> browser, CefCursorHandle cursor, cef_cursor_type_t type, const CefCursorInfo& custom_cursor_info)
			:myext_argCount(4), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), cursor(cursor), type(type), custom_cursor_info(custom_cursor_info) {}
		~OnCursorChangeArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCursorChangeArgs);
	};
	class StartDraggingArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_drag_data_t* drag_data;//2
		cef_drag_operations_mask_t allowed_ops;//3
		int x;//4
		int y;//5
			  //
		bool myext_created_from_Unwrap;
		//
		StartDraggingArgs(cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), drag_data(drag_data), allowed_ops(allowed_ops), x(x), y(y) {}
		StartDraggingArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), drag_data(CefDragDataCToCpp::Unwrap(drag_data)), allowed_ops(allowed_ops), x(x), y(y) {}
		~StartDraggingArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefDragDataCToCpp::Wrap(drag_data);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(StartDraggingArgs);
	};
	class UpdateDragCursorArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_drag_operations_mask_t operation;//2
											 //
		bool myext_created_from_Unwrap;
		//
		UpdateDragCursorArgs(cef_browser_t* browser, cef_drag_operations_mask_t operation)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), operation(operation) {}
		UpdateDragCursorArgs(CefRefPtr<CefBrowser> browser, cef_drag_operations_mask_t operation)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), operation(operation) {}
		~UpdateDragCursorArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(UpdateDragCursorArgs);
	};
	class OnScrollOffsetChangedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		double x;//2
		double y;//3
				 //
		bool myext_created_from_Unwrap;
		//
		OnScrollOffsetChangedArgs(cef_browser_t* browser, double x, double y)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), x(x), y(y) {}
		OnScrollOffsetChangedArgs(CefRefPtr<CefBrowser> browser, double x, double y)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), x(x), y(y) {}
		~OnScrollOffsetChangedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnScrollOffsetChangedArgs);
	};
	class OnImeCompositionRangeChangedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const CefRange& selected_range;//2
		const std::vector<CefRect>& character_bounds;//3
													 //
		bool myext_created_from_Unwrap;
		//
		OnImeCompositionRangeChangedArgs(cef_browser_t* browser, const CefRange& selected_range, const std::vector<CefRect>& character_bounds)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), selected_range(selected_range), character_bounds(character_bounds) {}
		OnImeCompositionRangeChangedArgs(CefRefPtr<CefBrowser> browser, const CefRange& selected_range, const std::vector<CefRect>& character_bounds)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), selected_range(selected_range), character_bounds(character_bounds) {}
		~OnImeCompositionRangeChangedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		cef_list_value_t* extra_info;//1
									 //
		bool myext_created_from_Unwrap;
		//
		OnRenderThreadCreatedArgs(cef_list_value_t* extra_info)
			:myext_argCount(1), myext_created_from_Unwrap(false), extra_info(extra_info) {}
		OnRenderThreadCreatedArgs(CefRefPtr<CefListValue> extra_info)
			:myext_argCount(1), myext_created_from_Unwrap(true), extra_info(CefListValueCToCpp::Unwrap(extra_info)) {}
		~OnRenderThreadCreatedArgs() {
			if (myext_created_from_Unwrap) {
				CefListValueCToCpp::Wrap(extra_info);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderThreadCreatedArgs);
	};
	class OnWebKitInitializedArgs {
	public:
		int32_t myext_argCount;
		//
		bool myext_created_from_Unwrap;
		//
		OnWebKitInitializedArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnWebKitInitializedArgs);
	};
	class OnBrowserCreatedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnBrowserCreatedArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnBrowserCreatedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnBrowserCreatedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBrowserCreatedArgs);
	};
	class OnBrowserDestroyedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnBrowserDestroyedArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnBrowserDestroyedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnBrowserDestroyedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBrowserDestroyedArgs);
	};
	class GetLoadHandlerArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefLoadHandler> myext_ret_value; //0
												   //
		bool myext_created_from_Unwrap;
		//
		GetLoadHandlerArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetLoadHandlerArgs);
	};
	class OnBeforeNavigationArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		cef_navigation_type_t navigation_type;//4
		bool is_redirect;//5
						 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeNavigationArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_navigation_type_t navigation_type, bool is_redirect)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), navigation_type(navigation_type), is_redirect(is_redirect) {}
		OnBeforeNavigationArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, cef_navigation_type_t navigation_type, bool is_redirect)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), navigation_type(navigation_type), is_redirect(is_redirect) {}
		~OnBeforeNavigationArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeNavigationArgs);
	};
	class OnContextCreatedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_v8context_t* context;//3
								 //
		bool myext_created_from_Unwrap;
		//
		OnContextCreatedArgs(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), context(context) {}
		OnContextCreatedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), context(CefV8ContextCToCpp::Unwrap(context)) {}
		~OnContextCreatedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefV8ContextCToCpp::Wrap(context);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextCreatedArgs);
	};
	class OnContextReleasedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_v8context_t* context;//3
								 //
		bool myext_created_from_Unwrap;
		//
		OnContextReleasedArgs(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), context(context) {}
		OnContextReleasedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), context(CefV8ContextCToCpp::Unwrap(context)) {}
		~OnContextReleasedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefV8ContextCToCpp::Wrap(context);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextReleasedArgs);
	};
	class OnUncaughtExceptionArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_v8context_t* context;//3
		cef_v8exception_t* exception;//4
		cef_v8stack_trace_t* stackTrace;//5
										//
		bool myext_created_from_Unwrap;
		//
		OnUncaughtExceptionArgs(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace)
			:myext_argCount(5), myext_created_from_Unwrap(false), browser(browser), frame(frame), context(context), exception(exception), stackTrace(stackTrace) {}
		OnUncaughtExceptionArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context, CefRefPtr<CefV8Exception> exception, CefRefPtr<CefV8StackTrace> stackTrace)
			:myext_argCount(5), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), context(CefV8ContextCToCpp::Unwrap(context)), exception(CefV8ExceptionCToCpp::Unwrap(exception)), stackTrace(CefV8StackTraceCToCpp::Unwrap(stackTrace)) {}
		~OnUncaughtExceptionArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefV8ContextCToCpp::Wrap(context);
				CefV8ExceptionCToCpp::Wrap(exception);
				CefV8StackTraceCToCpp::Wrap(stackTrace);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnUncaughtExceptionArgs);
	};
	class OnFocusedNodeChangedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_domnode_t* node;//3
							//
		bool myext_created_from_Unwrap;
		//
		OnFocusedNodeChangedArgs(cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), node(node) {}
		OnFocusedNodeChangedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefDOMNode> node)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), node(CefDOMNodeCToCpp::Unwrap(node)) {}
		~OnFocusedNodeChangedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefDOMNodeCToCpp::Wrap(node);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFocusedNodeChangedArgs);
	};
	class OnProcessMessageReceivedArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		CefProcessId source_process;//2
		cef_process_message_t* message;//3
									   //
		bool myext_created_from_Unwrap;
		//
		OnProcessMessageReceivedArgs(cef_browser_t* browser, CefProcessId source_process, cef_process_message_t* message)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), source_process(source_process), message(message) {}
		OnProcessMessageReceivedArgs(CefRefPtr<CefBrowser> browser, CefProcessId source_process, CefRefPtr<CefProcessMessage> message)
			:myext_argCount(3), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), source_process(source_process), message(CefProcessMessageCToCpp::Unwrap(message)) {}
		~OnProcessMessageReceivedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefProcessMessageCToCpp::Wrap(message);
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
		int32_t myext_argCount;
		CefRefPtr<CefCookieManager> myext_ret_value; //0
													 //
		bool myext_created_from_Unwrap;
		//
		GetCookieManagerArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetCookieManagerArgs);
	};
	class OnBeforePluginLoadArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		const CefString& mime_type;//1
		const CefString& plugin_url;//2
		bool is_main_frame;//3
		const CefString& top_origin_url;//4
		cef_web_plugin_info_t* plugin_info;//5
		cef_plugin_policy_t* plugin_policy;//6
										   //
		bool myext_created_from_Unwrap;
		//
		OnBeforePluginLoadArgs(const CefString& mime_type, const CefString& plugin_url, bool is_main_frame, const CefString& top_origin_url, cef_web_plugin_info_t* plugin_info, cef_plugin_policy_t* plugin_policy)
			:myext_argCount(6), myext_created_from_Unwrap(false), myext_ret_value(0), mime_type(mime_type), plugin_url(plugin_url), is_main_frame(is_main_frame), top_origin_url(top_origin_url), plugin_info(plugin_info), plugin_policy(plugin_policy) {}
		OnBeforePluginLoadArgs(const CefString& mime_type, const CefString& plugin_url, bool is_main_frame, const CefString& top_origin_url, CefRefPtr<CefWebPluginInfo> plugin_info, cef_plugin_policy_t* plugin_policy)
			:myext_argCount(6), myext_created_from_Unwrap(true), myext_ret_value(0), mime_type(mime_type), plugin_url(plugin_url), is_main_frame(is_main_frame), top_origin_url(top_origin_url), plugin_info(CefWebPluginInfoCToCpp::Unwrap(plugin_info)), plugin_policy(plugin_policy) {}
		~OnBeforePluginLoadArgs() {
			if (myext_created_from_Unwrap) {
				CefWebPluginInfoCToCpp::Wrap(plugin_info);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		bool is_redirect;//4
						 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeBrowseArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, bool is_redirect)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), is_redirect(is_redirect) {}
		OnBeforeBrowseArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, bool is_redirect)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), is_redirect(is_redirect) {}
		~OnBeforeBrowseArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeBrowseArgs);
	};
	class OnOpenURLFromTabArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		const CefString& target_url;//3
		cef_window_open_disposition_t target_disposition;//4
		bool user_gesture;//5
						  //
		bool myext_created_from_Unwrap;
		//
		OnOpenURLFromTabArgs(cef_browser_t* browser, cef_frame_t* frame, const CefString& target_url, cef_window_open_disposition_t target_disposition, bool user_gesture)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), target_url(target_url), target_disposition(target_disposition), user_gesture(user_gesture) {}
		OnOpenURLFromTabArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, cef_window_open_disposition_t target_disposition, bool user_gesture)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), target_url(target_url), target_disposition(target_disposition), user_gesture(user_gesture) {}
		~OnOpenURLFromTabArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnOpenURLFromTabArgs);
	};
	class OnBeforeResourceLoadArgs {
	public:
		int32_t myext_argCount;
		cef_return_value_t myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		cef_request_callback_t* callback;//4
										 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeResourceLoadArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_request_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value((cef_return_value_t)0), browser(browser), frame(frame), request(request), callback(callback) {}
		OnBeforeResourceLoadArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefRequestCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value((cef_return_value_t)0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), callback(CefRequestCallbackCToCpp::Unwrap(callback)) {}
		~OnBeforeResourceLoadArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
				CefRequestCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeResourceLoadArgs);
	};
	class GetResourceHandlerArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefResourceHandler> myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
							   //
		bool myext_created_from_Unwrap;
		//
		GetResourceHandlerArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request) {}
		GetResourceHandlerArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request)
			:myext_argCount(3), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)) {}
		~GetResourceHandlerArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResourceHandlerArgs);
	};
	class OnResourceRedirectArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		cef_response_t* response;//4
		CefString& new_url;//5
						   //
		bool myext_created_from_Unwrap;
		//
		OnResourceRedirectArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, CefString& new_url)
			:myext_argCount(5), myext_created_from_Unwrap(false), browser(browser), frame(frame), request(request), response(response), new_url(new_url) {}
		OnResourceRedirectArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, CefString& new_url)
			:myext_argCount(5), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), response(CefResponseCToCpp::Unwrap(response)), new_url(new_url) {}
		~OnResourceRedirectArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
				CefResponseCToCpp::Wrap(response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceRedirectArgs);
	};
	class OnResourceResponseArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		cef_response_t* response;//4
								 //
		bool myext_created_from_Unwrap;
		//
		OnResourceResponseArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), response(response) {}
		OnResourceResponseArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), response(CefResponseCToCpp::Unwrap(response)) {}
		~OnResourceResponseArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
				CefResponseCToCpp::Wrap(response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceResponseArgs);
	};
	class GetResourceResponseFilterArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefResponseFilter> myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		cef_response_t* response;//4
								 //
		bool myext_created_from_Unwrap;
		//
		GetResourceResponseFilterArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), response(response) {}
		GetResourceResponseFilterArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), response(CefResponseCToCpp::Unwrap(response)) {}
		~GetResourceResponseFilterArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
				CefResponseCToCpp::Wrap(response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResourceResponseFilterArgs);
	};
	class OnResourceLoadCompleteArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		cef_request_t* request;//3
		cef_response_t* response;//4
		cef_urlrequest_status_t status;//5
		int64 received_content_length;//6
									  //
		bool myext_created_from_Unwrap;
		//
		OnResourceLoadCompleteArgs(cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, cef_response_t* response, cef_urlrequest_status_t status, int64 received_content_length)
			:myext_argCount(6), myext_created_from_Unwrap(false), browser(browser), frame(frame), request(request), response(response), status(status), received_content_length(received_content_length) {}
		OnResourceLoadCompleteArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, cef_urlrequest_status_t status, int64 received_content_length)
			:myext_argCount(6), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), request(CefRequestCToCpp::Unwrap(request)), response(CefResponseCToCpp::Unwrap(response)), status(status), received_content_length(received_content_length) {}
		~OnResourceLoadCompleteArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefRequestCToCpp::Wrap(request);
				CefResponseCToCpp::Wrap(response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceLoadCompleteArgs);
	};
	class GetAuthCredentialsArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_frame_t* frame;//2
		bool isProxy;//3
		const CefString& host;//4
		int port;//5
		const CefString& realm;//6
		const CefString& scheme;//7
		cef_auth_callback_t* callback;//8
									  //
		bool myext_created_from_Unwrap;
		//
		GetAuthCredentialsArgs(cef_browser_t* browser, cef_frame_t* frame, bool isProxy, const CefString& host, int port, const CefString& realm, const CefString& scheme, cef_auth_callback_t* callback)
			:myext_argCount(8), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), isProxy(isProxy), host(host), port(port), realm(realm), scheme(scheme), callback(callback) {}
		GetAuthCredentialsArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, bool isProxy, const CefString& host, int port, const CefString& realm, const CefString& scheme, CefRefPtr<CefAuthCallback> callback)
			:myext_argCount(8), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), frame(CefFrameCToCpp::Unwrap(frame)), isProxy(isProxy), host(host), port(port), realm(realm), scheme(scheme), callback(CefAuthCallbackCToCpp::Unwrap(callback)) {}
		~GetAuthCredentialsArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefFrameCToCpp::Wrap(frame);
				CefAuthCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetAuthCredentialsArgs);
	};
	class OnQuotaRequestArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		const CefString& origin_url;//2
		int64 new_size;//3
		cef_request_callback_t* callback;//4
										 //
		bool myext_created_from_Unwrap;
		//
		OnQuotaRequestArgs(cef_browser_t* browser, const CefString& origin_url, int64 new_size, cef_request_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), origin_url(origin_url), new_size(new_size), callback(callback) {}
		OnQuotaRequestArgs(CefRefPtr<CefBrowser> browser, const CefString& origin_url, int64 new_size, CefRefPtr<CefRequestCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), origin_url(origin_url), new_size(new_size), callback(CefRequestCallbackCToCpp::Unwrap(callback)) {}
		~OnQuotaRequestArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefRequestCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnQuotaRequestArgs);
	};
	class OnProtocolExecutionArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const CefString& url;//2
		bool& allow_os_execution;//3
								 //
		bool myext_created_from_Unwrap;
		//
		OnProtocolExecutionArgs(cef_browser_t* browser, const CefString& url, bool& allow_os_execution)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), url(url), allow_os_execution(allow_os_execution) {}
		OnProtocolExecutionArgs(CefRefPtr<CefBrowser> browser, const CefString& url, bool& allow_os_execution)
			:myext_argCount(3), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), url(url), allow_os_execution(allow_os_execution) {}
		~OnProtocolExecutionArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnProtocolExecutionArgs);
	};
	class OnCertificateErrorArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		cef_errorcode_t cert_error;//2
		const CefString& request_url;//3
		cef_sslinfo_t* ssl_info;//4
		cef_request_callback_t* callback;//5
										 //
		bool myext_created_from_Unwrap;
		//
		OnCertificateErrorArgs(cef_browser_t* browser, cef_errorcode_t cert_error, const CefString& request_url, cef_sslinfo_t* ssl_info, cef_request_callback_t* callback)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), cert_error(cert_error), request_url(request_url), ssl_info(ssl_info), callback(callback) {}
		OnCertificateErrorArgs(CefRefPtr<CefBrowser> browser, cef_errorcode_t cert_error, const CefString& request_url, CefRefPtr<CefSSLInfo> ssl_info, CefRefPtr<CefRequestCallback> callback)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), cert_error(cert_error), request_url(request_url), ssl_info(CefSSLInfoCToCpp::Unwrap(ssl_info)), callback(CefRequestCallbackCToCpp::Unwrap(callback)) {}
		~OnCertificateErrorArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefSSLInfoCToCpp::Wrap(ssl_info);
				CefRequestCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCertificateErrorArgs);
	};
	class OnSelectClientCertificateArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_browser_t* browser;//1
		bool isProxy;//2
		const CefString& host;//3
		int port;//4
		const std::vector<CefRefPtr<CefX509Certificate>>& certificates;//5
		cef_select_client_certificate_callback_t* callback;//6
														   //
		bool myext_created_from_Unwrap;
		//
		OnSelectClientCertificateArgs(cef_browser_t* browser, bool isProxy, const CefString& host, int port, const std::vector<CefRefPtr<CefX509Certificate>>& certificates, cef_select_client_certificate_callback_t* callback)
			:myext_argCount(6), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), isProxy(isProxy), host(host), port(port), certificates(certificates), callback(callback) {}
		OnSelectClientCertificateArgs(CefRefPtr<CefBrowser> browser, bool isProxy, const CefString& host, int port, const std::vector<CefRefPtr<CefX509Certificate>>& certificates, CefRefPtr<CefSelectClientCertificateCallback> callback)
			:myext_argCount(6), myext_created_from_Unwrap(true), myext_ret_value(0), browser(CefBrowserCToCpp::Unwrap(browser)), isProxy(isProxy), host(host), port(port), certificates(certificates), callback(CefSelectClientCertificateCallbackCToCpp::Unwrap(callback)) {}
		~OnSelectClientCertificateArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
				CefSelectClientCertificateCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnSelectClientCertificateArgs);
	};
	class OnPluginCrashedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		const CefString& plugin_path;//2
									 //
		bool myext_created_from_Unwrap;
		//
		OnPluginCrashedArgs(cef_browser_t* browser, const CefString& plugin_path)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), plugin_path(plugin_path) {}
		OnPluginCrashedArgs(CefRefPtr<CefBrowser> browser, const CefString& plugin_path)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), plugin_path(plugin_path) {}
		~OnPluginCrashedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPluginCrashedArgs);
	};
	class OnRenderViewReadyArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
							   //
		bool myext_created_from_Unwrap;
		//
		OnRenderViewReadyArgs(cef_browser_t* browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
		OnRenderViewReadyArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)) {}
		~OnRenderViewReadyArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderViewReadyArgs);
	};
	class OnRenderProcessTerminatedArgs {
	public:
		int32_t myext_argCount;
		cef_browser_t* browser;//1
		cef_termination_status_t status;//2
										//
		bool myext_created_from_Unwrap;
		//
		OnRenderProcessTerminatedArgs(cef_browser_t* browser, cef_termination_status_t status)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), status(status) {}
		OnRenderProcessTerminatedArgs(CefRefPtr<CefBrowser> browser, cef_termination_status_t status)
			:myext_argCount(2), myext_created_from_Unwrap(true), browser(CefBrowserCToCpp::Unwrap(browser)), status(status) {}
		~OnRenderProcessTerminatedArgs() {
			if (myext_created_from_Unwrap) {
				CefBrowserCToCpp::Wrap(browser);
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		int string_id;//1
		CefString& _string;//2
						   //
		bool myext_created_from_Unwrap;
		//
		GetLocalizedStringArgs(int string_id, CefString& _string)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), string_id(string_id), _string(_string) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetLocalizedStringArgs);
	};
	class GetDataResourceArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		int resource_id;//1
		void*& data;//2
		size_t& data_size;//3
						  //
		bool myext_created_from_Unwrap;
		//
		GetDataResourceArgs(int resource_id, void*& data, size_t& data_size)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), resource_id(resource_id), data(data), data_size(data_size) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetDataResourceArgs);
	};
	class GetDataResourceForScaleArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		int resource_id;//1
		cef_scale_factor_t scale_factor;//2
		void*& data;//3
		size_t& data_size;//4
						  //
		bool myext_created_from_Unwrap;
		//
		GetDataResourceForScaleArgs(int resource_id, cef_scale_factor_t scale_factor, void*& data, size_t& data_size)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), resource_id(resource_id), scale_factor(scale_factor), data(data), data_size(data_size) {}
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		cef_request_t* request;//1
		cef_callback_t* callback;//2
								 //
		bool myext_created_from_Unwrap;
		//
		ProcessRequestArgs(cef_request_t* request, cef_callback_t* callback)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), request(request), callback(callback) {}
		ProcessRequestArgs(CefRefPtr<CefRequest> request, CefRefPtr<CefCallback> callback)
			:myext_argCount(2), myext_created_from_Unwrap(true), myext_ret_value(0), request(CefRequestCToCpp::Unwrap(request)), callback(CefCallbackCToCpp::Unwrap(callback)) {}
		~ProcessRequestArgs() {
			if (myext_created_from_Unwrap) {
				CefRequestCToCpp::Wrap(request);
				CefCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ProcessRequestArgs);
	};
	class GetResponseHeadersArgs {
	public:
		int32_t myext_argCount;
		cef_response_t* response;//1
		int64& response_length;//2
		CefString& redirectUrl;//3
							   //
		bool myext_created_from_Unwrap;
		//
		GetResponseHeadersArgs(cef_response_t* response, int64& response_length, CefString& redirectUrl)
			:myext_argCount(3), myext_created_from_Unwrap(false), response(response), response_length(response_length), redirectUrl(redirectUrl) {}
		GetResponseHeadersArgs(CefRefPtr<CefResponse> response, int64& response_length, CefString& redirectUrl)
			:myext_argCount(3), myext_created_from_Unwrap(true), response(CefResponseCToCpp::Unwrap(response)), response_length(response_length), redirectUrl(redirectUrl) {}
		~GetResponseHeadersArgs() {
			if (myext_created_from_Unwrap) {
				CefResponseCToCpp::Wrap(response);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResponseHeadersArgs);
	};
	class ReadResponseArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		void* data_out;//1
		int bytes_to_read;//2
		int& bytes_read;//3
		cef_callback_t* callback;//4
								 //
		bool myext_created_from_Unwrap;
		//
		ReadResponseArgs(void* data_out, int bytes_to_read, int& bytes_read, cef_callback_t* callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), data_out(data_out), bytes_to_read(bytes_to_read), bytes_read(bytes_read), callback(callback) {}
		ReadResponseArgs(void* data_out, int bytes_to_read, int& bytes_read, CefRefPtr<CefCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(true), myext_ret_value(0), data_out(data_out), bytes_to_read(bytes_to_read), bytes_read(bytes_read), callback(CefCallbackCToCpp::Unwrap(callback)) {}
		~ReadResponseArgs() {
			if (myext_created_from_Unwrap) {
				CefCallbackCToCpp::Wrap(callback);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ReadResponseArgs);
	};
	class CanGetCookieArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		const CefCookie& cookie;//1
								//
		bool myext_created_from_Unwrap;
		//
		CanGetCookieArgs(const CefCookie& cookie)
			:myext_argCount(1), myext_created_from_Unwrap(false), myext_ret_value(0), cookie(cookie) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(CanGetCookieArgs);
	};
	class CanSetCookieArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		const CefCookie& cookie;//1
								//
		bool myext_created_from_Unwrap;
		//
		CanSetCookieArgs(const CefCookie& cookie)
			:myext_argCount(1), myext_created_from_Unwrap(false), myext_ret_value(0), cookie(cookie) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(CanSetCookieArgs);
	};
	class CancelArgs {
	public:
		int32_t myext_argCount;
		//
		bool myext_created_from_Unwrap;
		//
		CancelArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false) {}
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
		int32_t myext_argCount;
		size_t myext_ret_value; //0
		void* ptr;//1
		size_t size;//2
		size_t n;//3
				 //
		bool myext_created_from_Unwrap;
		//
		ReadArgs(void* ptr, size_t size, size_t n)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), ptr(ptr), size(size), n(n) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(ReadArgs);
	};
	class SeekArgs {
	public:
		int32_t myext_argCount;
		int myext_ret_value; //0
		int64 offset;//1
		int whence;//2
				   //
		bool myext_created_from_Unwrap;
		//
		SeekArgs(int64 offset, int whence)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), offset(offset), whence(whence) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(SeekArgs);
	};
	class TellArgs {
	public:
		int32_t myext_argCount;
		int64 myext_ret_value; //0
							   //
		bool myext_created_from_Unwrap;
		//
		TellArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(TellArgs);
	};
	class EofArgs {
	public:
		int32_t myext_argCount;
		int myext_ret_value; //0
							 //
		bool myext_created_from_Unwrap;
		//
		EofArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(EofArgs);
	};
	class MayBlockArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
							  //
		bool myext_created_from_Unwrap;
		//
		MayBlockArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
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
		int32_t myext_argCount;
		size_t myext_ret_value; //0
		const void* ptr;//1
		size_t size;//2
		size_t n;//3
				 //
		bool myext_created_from_Unwrap;
		//
		WriteArgs(const void* ptr, size_t size, size_t n)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), ptr(ptr), size(size), n(n) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(WriteArgs);
	};
	class SeekArgs {
	public:
		int32_t myext_argCount;
		int myext_ret_value; //0
		int64 offset;//1
		int whence;//2
				   //
		bool myext_created_from_Unwrap;
		//
		SeekArgs(int64 offset, int whence)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), offset(offset), whence(whence) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(SeekArgs);
	};
	class TellArgs {
	public:
		int32_t myext_argCount;
		int64 myext_ret_value; //0
							   //
		bool myext_created_from_Unwrap;
		//
		TellArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(TellArgs);
	};
	class FlushArgs {
	public:
		int32_t myext_argCount;
		int myext_ret_value; //0
							 //
		bool myext_created_from_Unwrap;
		//
		FlushArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(FlushArgs);
	};
	class MayBlockArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
							  //
		bool myext_created_from_Unwrap;
		//
		MayBlockArgs()
			:myext_argCount(0), myext_created_from_Unwrap(false), myext_ret_value(0) {}
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
		int32_t myext_argCount;
		bool myext_ret_value; //0
		const CefString& name;//1
		cef_v8value_t* _object;//2
		const CefV8ValueList& arguments;//3
		CefRefPtr<CefV8Value>& retval;//4
		CefString& exception;//5
							 //
		bool myext_created_from_Unwrap;
		//
		ExecuteArgs(const CefString& name, cef_v8value_t* _object, const CefV8ValueList& arguments, CefRefPtr<CefV8Value>& retval, CefString& exception)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), name(name), _object(_object), arguments(arguments), retval(retval), exception(exception) {}
		ExecuteArgs(const CefString& name, CefRefPtr<CefV8Value> _object, const CefV8ValueList& arguments, CefRefPtr<CefV8Value>& retval, CefString& exception)
			:myext_argCount(5), myext_created_from_Unwrap(true), myext_ret_value(0), name(name), _object(CefV8ValueCToCpp::Unwrap(_object)), arguments(arguments), retval(retval), exception(exception) {}
		~ExecuteArgs() {
			if (myext_created_from_Unwrap) {
				CefV8ValueCToCpp::Wrap(_object);
			}
		}
	private:
		DISALLOW_COPY_AND_ASSIGN(ExecuteArgs);
	};
}
																																																															 