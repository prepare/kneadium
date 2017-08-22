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
		CefRefPtr<CefValue> value;//1
								  //
		bool myext_created_from_Unwrap;
		//
		OnAccessibilityTreeChangeArgs(CefRefPtr<CefValue> value)
			:myext_argCount(1), myext_created_from_Unwrap(false), value(value) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAccessibilityTreeChangeArgs);
	};
	class OnAccessibilityLocationChangeArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefValue> value;//1
								  //
		bool myext_created_from_Unwrap;
		//
		OnAccessibilityLocationChangeArgs(CefRefPtr<CefValue> value)
			:myext_argCount(1), myext_created_from_Unwrap(false), value(value) {}
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
		CefRefPtr<CefCommandLine> command_line;//1
											   //
		bool myext_created_from_Unwrap;
		//
		OnBeforeChildProcessLaunchArgs(CefRefPtr<CefCommandLine> command_line)
			:myext_argCount(1), myext_created_from_Unwrap(false), command_line(command_line) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeChildProcessLaunchArgs);
	};
	class OnRenderProcessThreadCreatedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefListValue> extra_info;//1
										   //
		bool myext_created_from_Unwrap;
		//
		OnRenderProcessThreadCreatedArgs(CefRefPtr<CefListValue> extra_info)
			:myext_argCount(1), myext_created_from_Unwrap(false), extra_info(extra_info) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefContextMenuParams> _params;//3
		CefRefPtr<CefMenuModel> model;//4
									  //
		bool myext_created_from_Unwrap;
		//
		OnBeforeContextMenuArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, CefRefPtr<CefMenuModel> model)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), frame(frame), _params(_params), model(model) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeContextMenuArgs);
	};
	class RunContextMenuArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefContextMenuParams> _params;//3
		CefRefPtr<CefMenuModel> model;//4
		CefRefPtr<CefRunContextMenuCallback> callback;//5
													  //
		bool myext_created_from_Unwrap;
		//
		RunContextMenuArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, CefRefPtr<CefMenuModel> model, CefRefPtr<CefRunContextMenuCallback> callback)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), _params(_params), model(model), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(RunContextMenuArgs);
	};
	class OnContextMenuCommandArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefContextMenuParams> _params;//3
		int command_id;//4
		cef_event_flags_t event_flags;//5
									  //
		bool myext_created_from_Unwrap;
		//
		OnContextMenuCommandArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefContextMenuParams> _params, int command_id, cef_event_flags_t event_flags)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), _params(_params), command_id(command_id), event_flags(event_flags) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextMenuCommandArgs);
	};
	class OnContextMenuDismissedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
								  //
		bool myext_created_from_Unwrap;
		//
		OnContextMenuDismissedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), frame(frame) {}
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
		CefRefPtr<CefBrowser> browser;//1
		cef_file_dialog_mode_t mode;//2
		const CefString& title;//3
		const CefString& default_file_path;//4
		const std::vector<CefString>& accept_filters;//5
		int selected_accept_filter;//6
		CefRefPtr<CefFileDialogCallback> callback;//7
												  //
		bool myext_created_from_Unwrap;
		//
		OnFileDialogArgs(CefRefPtr<CefBrowser> browser, cef_file_dialog_mode_t mode, const CefString& title, const CefString& default_file_path, const std::vector<CefString>& accept_filters, int selected_accept_filter, CefRefPtr<CefFileDialogCallback> callback)
			:myext_argCount(7), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), mode(mode), title(title), default_file_path(default_file_path), accept_filters(accept_filters), selected_accept_filter(selected_accept_filter), callback(callback) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		const CefString& url;//3
							 //
		bool myext_created_from_Unwrap;
		//
		OnAddressChangeArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& url)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), url(url) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAddressChangeArgs);
	};
	class OnTitleChangeArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const CefString& title;//2
							   //
		bool myext_created_from_Unwrap;
		//
		OnTitleChangeArgs(CefRefPtr<CefBrowser> browser, const CefString& title)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), title(title) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTitleChangeArgs);
	};
	class OnFaviconURLChangeArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const std::vector<CefString>& icon_urls;//2
												//
		bool myext_created_from_Unwrap;
		//
		OnFaviconURLChangeArgs(CefRefPtr<CefBrowser> browser, const std::vector<CefString>& icon_urls)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), icon_urls(icon_urls) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFaviconURLChangeArgs);
	};
	class OnFullscreenModeChangeArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		bool fullscreen;//2
						//
		bool myext_created_from_Unwrap;
		//
		OnFullscreenModeChangeArgs(CefRefPtr<CefBrowser> browser, bool fullscreen)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), fullscreen(fullscreen) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFullscreenModeChangeArgs);
	};
	class OnTooltipArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefString& text;//2
						//
		bool myext_created_from_Unwrap;
		//
		OnTooltipArgs(CefRefPtr<CefBrowser> browser, CefString& text)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), text(text) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTooltipArgs);
	};
	class OnStatusMessageArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const CefString& value;//2
							   //
		bool myext_created_from_Unwrap;
		//
		OnStatusMessageArgs(CefRefPtr<CefBrowser> browser, const CefString& value)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), value(value) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnStatusMessageArgs);
	};
	class OnConsoleMessageArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		const CefString& message;//2
		const CefString& source;//3
		int line;//4
				 //
		bool myext_created_from_Unwrap;
		//
		OnConsoleMessageArgs(CefRefPtr<CefBrowser> browser, const CefString& message, const CefString& source, int line)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), message(message), source(source), line(line) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefDownloadItem> download_item;//2
		const CefString& suggested_name;//3
		CefRefPtr<CefBeforeDownloadCallback> callback;//4
													  //
		bool myext_created_from_Unwrap;
		//
		OnBeforeDownloadArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, const CefString& suggested_name, CefRefPtr<CefBeforeDownloadCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), download_item(download_item), suggested_name(suggested_name), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeDownloadArgs);
	};
	class OnDownloadUpdatedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefDownloadItem> download_item;//2
		CefRefPtr<CefDownloadItemCallback> callback;//3
													//
		bool myext_created_from_Unwrap;
		//
		OnDownloadUpdatedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDownloadItem> download_item, CefRefPtr<CefDownloadItemCallback> callback)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), download_item(download_item), callback(callback) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefDragData> dragData;//2
		cef_drag_operations_mask_t mask;//3
										//
		bool myext_created_from_Unwrap;
		//
		OnDragEnterArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> dragData, cef_drag_operations_mask_t mask)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), dragData(dragData), mask(mask) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnDragEnterArgs);
	};
	class OnDraggableRegionsChangedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const std::vector<CefDraggableRegion>& regions;//2
													   //
		bool myext_created_from_Unwrap;
		//
		OnDraggableRegionsChangedArgs(CefRefPtr<CefBrowser> browser, const std::vector<CefDraggableRegion>& regions)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), regions(regions) {}
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
		CefRefPtr<CefBrowser> browser;//1
		int identifier;//2
		int count;//3
		const CefRect& selectionRect;//4
		int activeMatchOrdinal;//5
		bool finalUpdate;//6
						 //
		bool myext_created_from_Unwrap;
		//
		OnFindResultArgs(CefRefPtr<CefBrowser> browser, int identifier, int count, const CefRect& selectionRect, int activeMatchOrdinal, bool finalUpdate)
			:myext_argCount(6), myext_created_from_Unwrap(false), browser(browser), identifier(identifier), count(count), selectionRect(selectionRect), activeMatchOrdinal(activeMatchOrdinal), finalUpdate(finalUpdate) {}
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
		CefRefPtr<CefBrowser> browser;//1
		bool next;//2
				  //
		bool myext_created_from_Unwrap;
		//
		OnTakeFocusArgs(CefRefPtr<CefBrowser> browser, bool next)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), next(next) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnTakeFocusArgs);
	};
	class OnSetFocusArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		cef_focus_source_t source;//2
								  //
		bool myext_created_from_Unwrap;
		//
		OnSetFocusArgs(CefRefPtr<CefBrowser> browser, cef_focus_source_t source)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), source(source) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnSetFocusArgs);
	};
	class OnGotFocusArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnGotFocusArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
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
		CefRefPtr<CefBrowser> browser;//1
		const CefString& requesting_url;//2
		int request_id;//3
		CefRefPtr<CefGeolocationCallback> callback;//4
												   //
		bool myext_created_from_Unwrap;
		//
		OnRequestGeolocationPermissionArgs(CefRefPtr<CefBrowser> browser, const CefString& requesting_url, int request_id, CefRefPtr<CefGeolocationCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), requesting_url(requesting_url), request_id(request_id), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRequestGeolocationPermissionArgs);
	};
	class OnCancelGeolocationPermissionArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		int request_id;//2
					   //
		bool myext_created_from_Unwrap;
		//
		OnCancelGeolocationPermissionArgs(CefRefPtr<CefBrowser> browser, int request_id)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), request_id(request_id) {}
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
		CefRefPtr<CefBrowser> browser;//1
		const CefString& origin_url;//2
		cef_jsdialog_type_t dialog_type;//3
		const CefString& message_text;//4
		const CefString& default_prompt_text;//5
		CefRefPtr<CefJSDialogCallback> callback;//6
		bool& suppress_message;//7
							   //
		bool myext_created_from_Unwrap;
		//
		OnJSDialogArgs(CefRefPtr<CefBrowser> browser, const CefString& origin_url, cef_jsdialog_type_t dialog_type, const CefString& message_text, const CefString& default_prompt_text, CefRefPtr<CefJSDialogCallback> callback, bool& suppress_message)
			:myext_argCount(7), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), origin_url(origin_url), dialog_type(dialog_type), message_text(message_text), default_prompt_text(default_prompt_text), callback(callback), suppress_message(suppress_message) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnJSDialogArgs);
	};
	class OnBeforeUnloadDialogArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		const CefString& message_text;//2
		bool is_reload;//3
		CefRefPtr<CefJSDialogCallback> callback;//4
												//
		bool myext_created_from_Unwrap;
		//
		OnBeforeUnloadDialogArgs(CefRefPtr<CefBrowser> browser, const CefString& message_text, bool is_reload, CefRefPtr<CefJSDialogCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), message_text(message_text), is_reload(is_reload), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeUnloadDialogArgs);
	};
	class OnResetDialogStateArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnResetDialogStateArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResetDialogStateArgs);
	};
	class OnDialogClosedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnDialogClosedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
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
		CefRefPtr<CefBrowser> browser;//1
		const CefKeyEvent& _event;//2
		CefEventHandle os_event;//3
		bool* is_keyboard_shortcut;//4
								   //
		bool myext_created_from_Unwrap;
		//
		OnPreKeyEventArgs(CefRefPtr<CefBrowser> browser, const CefKeyEvent& _event, CefEventHandle os_event, bool* is_keyboard_shortcut)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), _event(_event), os_event(os_event), is_keyboard_shortcut(is_keyboard_shortcut) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPreKeyEventArgs);
	};
	class OnKeyEventArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		const CefKeyEvent& _event;//2
		CefEventHandle os_event;//3
								//
		bool myext_created_from_Unwrap;
		//
		OnKeyEventArgs(CefRefPtr<CefBrowser> browser, const CefKeyEvent& _event, CefEventHandle os_event)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), _event(_event), os_event(os_event) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
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
		OnBeforePopupArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, const CefString& target_frame_name, cef_window_open_disposition_t target_disposition, bool user_gesture, const CefPopupFeatures& popupFeatures, CefWindowInfo& windowInfo, CefRefPtr<CefClient>& client, CefBrowserSettings& settings, bool* no_javascript_access)
			:myext_argCount(11), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), target_url(target_url), target_frame_name(target_frame_name), target_disposition(target_disposition), user_gesture(user_gesture), popupFeatures(popupFeatures), windowInfo(windowInfo), client(client), settings(settings), no_javascript_access(no_javascript_access) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforePopupArgs);
	};
	class OnAfterCreatedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnAfterCreatedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnAfterCreatedArgs);
	};
	class DoCloseArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		DoCloseArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(DoCloseArgs);
	};
	class OnBeforeCloseArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnBeforeCloseArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
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
		CefRefPtr<CefBrowser> browser;//1
		bool isLoading;//2
		bool canGoBack;//3
		bool canGoForward;//4
						  //
		bool myext_created_from_Unwrap;
		//
		OnLoadingStateChangeArgs(CefRefPtr<CefBrowser> browser, bool isLoading, bool canGoBack, bool canGoForward)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), isLoading(isLoading), canGoBack(canGoBack), canGoForward(canGoForward) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadingStateChangeArgs);
	};
	class OnLoadStartArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		cef_transition_type_t transition_type;//3
											  //
		bool myext_created_from_Unwrap;
		//
		OnLoadStartArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_transition_type_t transition_type)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), transition_type(transition_type) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadStartArgs);
	};
	class OnLoadEndArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		int httpStatusCode;//3
						   //
		bool myext_created_from_Unwrap;
		//
		OnLoadEndArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, int httpStatusCode)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), httpStatusCode(httpStatusCode) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnLoadEndArgs);
	};
	class OnLoadErrorArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		cef_errorcode_t errorCode;//3
		const CefString& errorText;//4
		const CefString& failedUrl;//5
								   //
		bool myext_created_from_Unwrap;
		//
		OnLoadErrorArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, cef_errorcode_t errorCode, const CefString& errorText, const CefString& failedUrl)
			:myext_argCount(5), myext_created_from_Unwrap(false), browser(browser), frame(frame), errorCode(errorCode), errorText(errorText), failedUrl(failedUrl) {}
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
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnPrintStartArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintStartArgs);
	};
	class OnPrintSettingsArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefPrintSettings> settings;//2
		bool get_defaults;//3
						  //
		bool myext_created_from_Unwrap;
		//
		OnPrintSettingsArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefPrintSettings> settings, bool get_defaults)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), settings(settings), get_defaults(get_defaults) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintSettingsArgs);
	};
	class OnPrintDialogArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		bool has_selection;//2
		CefRefPtr<CefPrintDialogCallback> callback;//3
												   //
		bool myext_created_from_Unwrap;
		//
		OnPrintDialogArgs(CefRefPtr<CefBrowser> browser, bool has_selection, CefRefPtr<CefPrintDialogCallback> callback)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), has_selection(has_selection), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintDialogArgs);
	};
	class OnPrintJobArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		const CefString& document_name;//2
		const CefString& pdf_file_path;//3
		CefRefPtr<CefPrintJobCallback> callback;//4
												//
		bool myext_created_from_Unwrap;
		//
		OnPrintJobArgs(CefRefPtr<CefBrowser> browser, const CefString& document_name, const CefString& pdf_file_path, CefRefPtr<CefPrintJobCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), document_name(document_name), pdf_file_path(pdf_file_path), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPrintJobArgs);
	};
	class OnPrintResetArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnPrintResetArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRect& rect;//2
					  //
		bool myext_created_from_Unwrap;
		//
		GetRootScreenRectArgs(CefRefPtr<CefBrowser> browser, CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), rect(rect) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetRootScreenRectArgs);
	};
	class GetViewRectArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRect& rect;//2
					  //
		bool myext_created_from_Unwrap;
		//
		GetViewRectArgs(CefRefPtr<CefBrowser> browser, CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), rect(rect) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetViewRectArgs);
	};
	class GetScreenPointArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		int viewX;//2
		int viewY;//3
		int& screenX;//4
		int& screenY;//5
					 //
		bool myext_created_from_Unwrap;
		//
		GetScreenPointArgs(CefRefPtr<CefBrowser> browser, int viewX, int viewY, int& screenX, int& screenY)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), viewX(viewX), viewY(viewY), screenX(screenX), screenY(screenY) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetScreenPointArgs);
	};
	class GetScreenInfoArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefScreenInfo& screen_info;//2
								   //
		bool myext_created_from_Unwrap;
		//
		GetScreenInfoArgs(CefRefPtr<CefBrowser> browser, CefScreenInfo& screen_info)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), screen_info(screen_info) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetScreenInfoArgs);
	};
	class OnPopupShowArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		bool show;//2
				  //
		bool myext_created_from_Unwrap;
		//
		OnPopupShowArgs(CefRefPtr<CefBrowser> browser, bool show)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), show(show) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPopupShowArgs);
	};
	class OnPopupSizeArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const CefRect& rect;//2
							//
		bool myext_created_from_Unwrap;
		//
		OnPopupSizeArgs(CefRefPtr<CefBrowser> browser, const CefRect& rect)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), rect(rect) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPopupSizeArgs);
	};
	class OnPaintArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		cef_paint_element_type_t type;//2
		const std::vector<CefRect>& dirtyRects;//3
		const void* buffer;//4
		int width;//5
		int height;//6
				   //
		bool myext_created_from_Unwrap;
		//
		OnPaintArgs(CefRefPtr<CefBrowser> browser, cef_paint_element_type_t type, const std::vector<CefRect>& dirtyRects, const void* buffer, int width, int height)
			:myext_argCount(6), myext_created_from_Unwrap(false), browser(browser), type(type), dirtyRects(dirtyRects), buffer(buffer), width(width), height(height) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPaintArgs);
	};
	class OnCursorChangeArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefCursorHandle cursor;//2
		cef_cursor_type_t type;//3
		const CefCursorInfo& custom_cursor_info;//4
												//
		bool myext_created_from_Unwrap;
		//
		OnCursorChangeArgs(CefRefPtr<CefBrowser> browser, CefCursorHandle cursor, cef_cursor_type_t type, const CefCursorInfo& custom_cursor_info)
			:myext_argCount(4), myext_created_from_Unwrap(false), browser(browser), cursor(cursor), type(type), custom_cursor_info(custom_cursor_info) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCursorChangeArgs);
	};
	class StartDraggingArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefDragData> drag_data;//2
		cef_drag_operations_mask_t allowed_ops;//3
		int x;//4
		int y;//5
			  //
		bool myext_created_from_Unwrap;
		//
		StartDraggingArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefDragData> drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), drag_data(drag_data), allowed_ops(allowed_ops), x(x), y(y) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(StartDraggingArgs);
	};
	class UpdateDragCursorArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		cef_drag_operations_mask_t operation;//2
											 //
		bool myext_created_from_Unwrap;
		//
		UpdateDragCursorArgs(CefRefPtr<CefBrowser> browser, cef_drag_operations_mask_t operation)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), operation(operation) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(UpdateDragCursorArgs);
	};
	class OnScrollOffsetChangedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		double x;//2
		double y;//3
				 //
		bool myext_created_from_Unwrap;
		//
		OnScrollOffsetChangedArgs(CefRefPtr<CefBrowser> browser, double x, double y)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), x(x), y(y) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnScrollOffsetChangedArgs);
	};
	class OnImeCompositionRangeChangedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const CefRange& selected_range;//2
		const std::vector<CefRect>& character_bounds;//3
													 //
		bool myext_created_from_Unwrap;
		//
		OnImeCompositionRangeChangedArgs(CefRefPtr<CefBrowser> browser, const CefRange& selected_range, const std::vector<CefRect>& character_bounds)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), selected_range(selected_range), character_bounds(character_bounds) {}
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
		CefRefPtr<CefListValue> extra_info;//1
										   //
		bool myext_created_from_Unwrap;
		//
		OnRenderThreadCreatedArgs(CefRefPtr<CefListValue> extra_info)
			:myext_argCount(1), myext_created_from_Unwrap(false), extra_info(extra_info) {}
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
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnBrowserCreatedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBrowserCreatedArgs);
	};
	class OnBrowserDestroyedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnBrowserDestroyedArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		cef_navigation_type_t navigation_type;//4
		bool is_redirect;//5
						 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeNavigationArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, cef_navigation_type_t navigation_type, bool is_redirect)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), navigation_type(navigation_type), is_redirect(is_redirect) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeNavigationArgs);
	};
	class OnContextCreatedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefV8Context> context;//3
										//
		bool myext_created_from_Unwrap;
		//
		OnContextCreatedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), context(context) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextCreatedArgs);
	};
	class OnContextReleasedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefV8Context> context;//3
										//
		bool myext_created_from_Unwrap;
		//
		OnContextReleasedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), context(context) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnContextReleasedArgs);
	};
	class OnUncaughtExceptionArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefV8Context> context;//3
		CefRefPtr<CefV8Exception> exception;//4
		CefRefPtr<CefV8StackTrace> stackTrace;//5
											  //
		bool myext_created_from_Unwrap;
		//
		OnUncaughtExceptionArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefV8Context> context, CefRefPtr<CefV8Exception> exception, CefRefPtr<CefV8StackTrace> stackTrace)
			:myext_argCount(5), myext_created_from_Unwrap(false), browser(browser), frame(frame), context(context), exception(exception), stackTrace(stackTrace) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnUncaughtExceptionArgs);
	};
	class OnFocusedNodeChangedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefDOMNode> node;//3
								   //
		bool myext_created_from_Unwrap;
		//
		OnFocusedNodeChangedArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefDOMNode> node)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), frame(frame), node(node) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnFocusedNodeChangedArgs);
	};
	class OnProcessMessageReceivedArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefProcessId source_process;//2
		CefRefPtr<CefProcessMessage> message;//3
											 //
		bool myext_created_from_Unwrap;
		//
		OnProcessMessageReceivedArgs(CefRefPtr<CefBrowser> browser, CefProcessId source_process, CefRefPtr<CefProcessMessage> message)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), source_process(source_process), message(message) {}
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
		CefRefPtr<CefWebPluginInfo> plugin_info;//5
		cef_plugin_policy_t* plugin_policy;//6
										   //
		bool myext_created_from_Unwrap;
		//
		OnBeforePluginLoadArgs(const CefString& mime_type, const CefString& plugin_url, bool is_main_frame, const CefString& top_origin_url, CefRefPtr<CefWebPluginInfo> plugin_info, cef_plugin_policy_t* plugin_policy)
			:myext_argCount(6), myext_created_from_Unwrap(false), myext_ret_value(0), mime_type(mime_type), plugin_url(plugin_url), is_main_frame(is_main_frame), top_origin_url(top_origin_url), plugin_info(plugin_info), plugin_policy(plugin_policy) {}
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
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		bool is_redirect;//4
						 //
		bool myext_created_from_Unwrap;
		//
		OnBeforeBrowseArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, bool is_redirect)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), is_redirect(is_redirect) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeBrowseArgs);
	};
	class OnOpenURLFromTabArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		const CefString& target_url;//3
		cef_window_open_disposition_t target_disposition;//4
		bool user_gesture;//5
						  //
		bool myext_created_from_Unwrap;
		//
		OnOpenURLFromTabArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, const CefString& target_url, cef_window_open_disposition_t target_disposition, bool user_gesture)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), target_url(target_url), target_disposition(target_disposition), user_gesture(user_gesture) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnOpenURLFromTabArgs);
	};
	class OnBeforeResourceLoadArgs {
	public:
		int32_t myext_argCount;
		cef_return_value_t myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		CefRefPtr<CefRequestCallback> callback;//4
											   //
		bool myext_created_from_Unwrap;
		//
		OnBeforeResourceLoadArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefRequestCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value((cef_return_value_t)0), browser(browser), frame(frame), request(request), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnBeforeResourceLoadArgs);
	};
	class GetResourceHandlerArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefResourceHandler> myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
									  //
		bool myext_created_from_Unwrap;
		//
		GetResourceHandlerArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request)
			:myext_argCount(3), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResourceHandlerArgs);
	};
	class OnResourceRedirectArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		CefRefPtr<CefResponse> response;//4
		CefString& new_url;//5
						   //
		bool myext_created_from_Unwrap;
		//
		OnResourceRedirectArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, CefString& new_url)
			:myext_argCount(5), myext_created_from_Unwrap(false), browser(browser), frame(frame), request(request), response(response), new_url(new_url) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceRedirectArgs);
	};
	class OnResourceResponseArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		CefRefPtr<CefResponse> response;//4
										//
		bool myext_created_from_Unwrap;
		//
		OnResourceResponseArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), response(response) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceResponseArgs);
	};
	class GetResourceResponseFilterArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefResponseFilter> myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		CefRefPtr<CefResponse> response;//4
										//
		bool myext_created_from_Unwrap;
		//
		GetResourceResponseFilterArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), request(request), response(response) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetResourceResponseFilterArgs);
	};
	class OnResourceLoadCompleteArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		CefRefPtr<CefRequest> request;//3
		CefRefPtr<CefResponse> response;//4
		cef_urlrequest_status_t status;//5
		int64 received_content_length;//6
									  //
		bool myext_created_from_Unwrap;
		//
		OnResourceLoadCompleteArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, CefRefPtr<CefRequest> request, CefRefPtr<CefResponse> response, cef_urlrequest_status_t status, int64 received_content_length)
			:myext_argCount(6), myext_created_from_Unwrap(false), browser(browser), frame(frame), request(request), response(response), status(status), received_content_length(received_content_length) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnResourceLoadCompleteArgs);
	};
	class GetAuthCredentialsArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		CefRefPtr<CefFrame> frame;//2
		bool isProxy;//3
		const CefString& host;//4
		int port;//5
		const CefString& realm;//6
		const CefString& scheme;//7
		CefRefPtr<CefAuthCallback> callback;//8
											//
		bool myext_created_from_Unwrap;
		//
		GetAuthCredentialsArgs(CefRefPtr<CefBrowser> browser, CefRefPtr<CefFrame> frame, bool isProxy, const CefString& host, int port, const CefString& realm, const CefString& scheme, CefRefPtr<CefAuthCallback> callback)
			:myext_argCount(8), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), frame(frame), isProxy(isProxy), host(host), port(port), realm(realm), scheme(scheme), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(GetAuthCredentialsArgs);
	};
	class OnQuotaRequestArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		const CefString& origin_url;//2
		int64 new_size;//3
		CefRefPtr<CefRequestCallback> callback;//4
											   //
		bool myext_created_from_Unwrap;
		//
		OnQuotaRequestArgs(CefRefPtr<CefBrowser> browser, const CefString& origin_url, int64 new_size, CefRefPtr<CefRequestCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), origin_url(origin_url), new_size(new_size), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnQuotaRequestArgs);
	};
	class OnProtocolExecutionArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const CefString& url;//2
		bool& allow_os_execution;//3
								 //
		bool myext_created_from_Unwrap;
		//
		OnProtocolExecutionArgs(CefRefPtr<CefBrowser> browser, const CefString& url, bool& allow_os_execution)
			:myext_argCount(3), myext_created_from_Unwrap(false), browser(browser), url(url), allow_os_execution(allow_os_execution) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnProtocolExecutionArgs);
	};
	class OnCertificateErrorArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		cef_errorcode_t cert_error;//2
		const CefString& request_url;//3
		CefRefPtr<CefSSLInfo> ssl_info;//4
		CefRefPtr<CefRequestCallback> callback;//5
											   //
		bool myext_created_from_Unwrap;
		//
		OnCertificateErrorArgs(CefRefPtr<CefBrowser> browser, cef_errorcode_t cert_error, const CefString& request_url, CefRefPtr<CefSSLInfo> ssl_info, CefRefPtr<CefRequestCallback> callback)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), cert_error(cert_error), request_url(request_url), ssl_info(ssl_info), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnCertificateErrorArgs);
	};
	class OnSelectClientCertificateArgs {
	public:
		int32_t myext_argCount;
		bool myext_ret_value; //0
		CefRefPtr<CefBrowser> browser;//1
		bool isProxy;//2
		const CefString& host;//3
		int port;//4
		const std::vector<CefRefPtr<CefX509Certificate>>& certificates;//5
		CefRefPtr<CefSelectClientCertificateCallback> callback;//6
															   //
		bool myext_created_from_Unwrap;
		//
		OnSelectClientCertificateArgs(CefRefPtr<CefBrowser> browser, bool isProxy, const CefString& host, int port, const std::vector<CefRefPtr<CefX509Certificate>>& certificates, CefRefPtr<CefSelectClientCertificateCallback> callback)
			:myext_argCount(6), myext_created_from_Unwrap(false), myext_ret_value(0), browser(browser), isProxy(isProxy), host(host), port(port), certificates(certificates), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnSelectClientCertificateArgs);
	};
	class OnPluginCrashedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		const CefString& plugin_path;//2
									 //
		bool myext_created_from_Unwrap;
		//
		OnPluginCrashedArgs(CefRefPtr<CefBrowser> browser, const CefString& plugin_path)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), plugin_path(plugin_path) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnPluginCrashedArgs);
	};
	class OnRenderViewReadyArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
									  //
		bool myext_created_from_Unwrap;
		//
		OnRenderViewReadyArgs(CefRefPtr<CefBrowser> browser)
			:myext_argCount(1), myext_created_from_Unwrap(false), browser(browser) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(OnRenderViewReadyArgs);
	};
	class OnRenderProcessTerminatedArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefBrowser> browser;//1
		cef_termination_status_t status;//2
										//
		bool myext_created_from_Unwrap;
		//
		OnRenderProcessTerminatedArgs(CefRefPtr<CefBrowser> browser, cef_termination_status_t status)
			:myext_argCount(2), myext_created_from_Unwrap(false), browser(browser), status(status) {}
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
		CefRefPtr<CefRequest> request;//1
		CefRefPtr<CefCallback> callback;//2
										//
		bool myext_created_from_Unwrap;
		//
		ProcessRequestArgs(CefRefPtr<CefRequest> request, CefRefPtr<CefCallback> callback)
			:myext_argCount(2), myext_created_from_Unwrap(false), myext_ret_value(0), request(request), callback(callback) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(ProcessRequestArgs);
	};
	class GetResponseHeadersArgs {
	public:
		int32_t myext_argCount;
		CefRefPtr<CefResponse> response;//1
		int64& response_length;//2
		CefString& redirectUrl;//3
							   //
		bool myext_created_from_Unwrap;
		//
		GetResponseHeadersArgs(CefRefPtr<CefResponse> response, int64& response_length, CefString& redirectUrl)
			:myext_argCount(3), myext_created_from_Unwrap(false), response(response), response_length(response_length), redirectUrl(redirectUrl) {}
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
		CefRefPtr<CefCallback> callback;//4
										//
		bool myext_created_from_Unwrap;
		//
		ReadResponseArgs(void* data_out, int bytes_to_read, int& bytes_read, CefRefPtr<CefCallback> callback)
			:myext_argCount(4), myext_created_from_Unwrap(false), myext_ret_value(0), data_out(data_out), bytes_to_read(bytes_to_read), bytes_read(bytes_read), callback(callback) {}
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
		CefRefPtr<CefV8Value> _object;//2
		const CefV8ValueList& arguments;//3
		CefRefPtr<CefV8Value>& retval;//4
		CefString& exception;//5
							 //
		bool myext_created_from_Unwrap;
		//
		ExecuteArgs(const CefString& name, CefRefPtr<CefV8Value> _object, const CefV8ValueList& arguments, CefRefPtr<CefV8Value>& retval, CefString& exception)
			:myext_argCount(5), myext_created_from_Unwrap(false), myext_ret_value(0), name(name), _object(_object), arguments(arguments), retval(retval), exception(exception) {}
	private:
		DISALLOW_COPY_AND_ASSIGN(ExecuteArgs);
	};
}
