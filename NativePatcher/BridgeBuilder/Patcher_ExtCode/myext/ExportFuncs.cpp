//MIT, 2015-2017, WinterDev



#include "ExportFuncs.h"   
#include "dll_init.h" 
#include "mycef.h"

#include "include/cef_parser.h"
#include "include/cef_origin_whitelist.h" //add original whitelist
#include "tests/shared/browser/client_app_browser.h"  
#include "tests/shared/common/client_app_other.h"
#include "tests/shared/renderer/client_app_renderer.h"  
#include "include/cef_zip_reader.h"

//
#include "tests/shared/browser/main_message_loop_std.h" 
//
#include "../browser/root_window_win.h" //**
#include "../browser/browser_window_osr_win.h" //**
#include "tests/cefclient/browser/browser_window_std_win.h" 

//---------------------
//for auto gen content
#include "include/internal/cef_types.h"
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
//
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
#include "libcef_dll/ctocpp/value_ctocpp.h"
#include "libcef_dll/ctocpp/dictionary_value_ctocpp.h"
#include "libcef_dll/ctocpp/list_value_ctocpp.h"

//
#include "libcef_dll/cpptoc/drag_handler_cpptoc.h" 
#include "libcef_dll/cpptoc/navigation_entry_visitor_cpptoc.h"
#include "libcef_dll/cpptoc/pdf_print_callback_cpptoc.h"
#include "libcef_dll/cpptoc/client_cpptoc.h"
#include "libcef_dll/cpptoc/download_image_callback_cpptoc.h"
#include "libcef_dll/cpptoc/run_file_dialog_callback_cpptoc.h"
#include "libcef_dll/cpptoc/domvisitor_cpptoc.h"
#include "libcef_dll/cpptoc/completion_callback_cpptoc.h"
#include "libcef_dll/cpptoc/cookie_visitor_cpptoc.h"
#include "libcef_dll/cpptoc/delete_cookies_callback_cpptoc.h"
#include "libcef_dll/cpptoc/menu_model_delegate_cpptoc.h"
#include "libcef_dll/cpptoc/request_context_handler_cpptoc.h"
#include "libcef_dll/cpptoc/resolve_callback_cpptoc.h"
#include "libcef_dll/cpptoc/response_filter_cpptoc.h"
#include "libcef_dll/cpptoc/scheme_handler_factory_cpptoc.h"
#include "libcef_dll/cpptoc/task_cpptoc.h"
#include "libcef_dll/cpptoc/set_cookie_callback_cpptoc.h"
#include "libcef_dll/cpptoc/v8accessor_cpptoc.h"
#include "libcef_dll/cpptoc/v8handler_cpptoc.h"
#include "libcef_dll/cpptoc/v8interceptor_cpptoc.h"
#include "libcef_dll/cpptoc/web_plugin_info_visitor_cpptoc.h"
#include "libcef_dll/cpptoc/web_plugin_unstable_callback_cpptoc.h"
#include "libcef_dll/cpptoc/write_handler_cpptoc.h"
#include "libcef_dll/cpptoc/app_cpptoc.h"
#include "libcef_dll/cpptoc/urlrequest_client_cpptoc.h"
//---------------------
//for auto gen content

//




client::MainContextImpl* mainContext;
client::MainMessageLoop* message_loop;  //essential for mainloop checking 
managed_callback myMxCallback_ = NULL;



class MyCefRootWindow :public client::BrowserWindow::Delegate {

	//this class is used in this module only
	//
public:
	void OnBrowserCreated(CefRefPtr<CefBrowser> browser) OVERRIDE {

	}
	void OnBrowserWindowDestroyed() OVERRIDE {

	}
	void OnSetAddress(const std::string& url) OVERRIDE {

	}
	void OnSetTitle(const std::string& title) OVERRIDE
	{
	}
	void OnSetFullscreen(bool fullscreen) OVERRIDE {

	}
	void OnSetLoadingState(bool isLoading,
		bool canGoBack,
		bool canGoForward) OVERRIDE {

	}
	void OnSetDraggableRegions(
		const std::vector<CefDraggableRegion>& regions) OVERRIDE {
	}
};


class MyBrowser
{
public:
	MyCefRootWindow* rootWin;
	client::BrowserWindow* bwWindow;
};



//1.
int MyCefGetVersion()
{
	return 1011;
}
//2.
int RegisterManagedCallBack(managed_callback mxCallback, int callbackKind)
{

	switch (callbackKind)
	{
	case 3:
	{
		//set global mxCallback ***
		myMxCallback_ = mxCallback;
		return 0;
	}
	}
	return 1; //default
}
//------------------------------------------
void* MyCefCreateClientApp(HINSTANCE hInstance)
{
	//this similar to client::RunMain()
	//
	//this func returns client::ClientApp
	///
	//-----
	//user must call RegisterManagedCallBack() before use this method *** 
	//-----

	// Parse command-line arguments.
	CefRefPtr<CefCommandLine> command_line = CefCommandLine::CreateCommandLine();
	command_line->InitFromString(::GetCommandLineW());
	//create browser process first?
	client::ClientApp* app = NULL;
	client::ClientApp::ProcessType process_type = client::ClientApp::GetProcessType(command_line);

	if (process_type == client::ClientApp::BrowserProcess)
	{
		app = new client::ClientAppBrowser();
		app->myMxCallback_ = myMxCallback_;
	}
	else if (process_type == client::ClientApp::RendererProcess)
	{
		//MessageBox(0, L"RendererProcess msg", L"RendererProcess MSG", 0);
		app = new client::ClientAppRenderer();
		app->myMxCallback_ = myMxCallback_;
	}
	else if (process_type == client::ClientApp::OtherProcess)
	{
		app = new client::ClientAppOther();
		app->myMxCallback_ = myMxCallback_;
	}
	// Create the main message loop object.
	message_loop = new client::MainMessageLoopStd();
	//message_loop.reset(new client::MainMessageLoopStd); 
	/* if (settings.multi_threaded_message_loop)
	message_loop.reset(new MainMessageLoopMultithreadedWin);
	else
	message_loop.reset(new MainMessageLoopStd);*/

	//------------------------------------------------------------------
	//set managed callback*** 
	mycefmx::SetManagedCallback(myMxCallback_);
	CefMainArgs main_args(hInstance);
	mainContext = DllInitMain(main_args, app);
	return app;
}

void MyCefSetInitSettings(CefSettings* cefSetting, int keyName, const wchar_t* value) {
	switch (keyName)
	{
	case CEF_SETTINGS_BrowserSubProcessPath:
		CefString(&cefSetting->browser_subprocess_path) = value;
		break;
	case CEF_SETTINGS_CachePath:
		CefString(&cefSetting->cache_path) = value;
		break;
	case CEF_SETTINGS_ResourcesDirPath:
		CefString(&cefSetting->resources_dir_path) = value;
		break;
	case CEF_SETTINGS_UserDirPath:
		CefString(&cefSetting->user_data_path) = value;
		break;

	case CEF_SETTINGS_LocalDirPath:
		CefString(&cefSetting->locales_dir_path) = value;
		break;
	case CEF_SETTINGS_IgnoreCertError:
		cefSetting->ignore_certificate_errors = std::stoi(value);
		break;
	case CEF_SETTINGS_RemoteDebuggingPort:
		cefSetting->remote_debugging_port = std::stoi(value);
		break;
	case CEF_SETTINGS_LogFile:
		CefString(&cefSetting->log_file) = value;
		break;
	case CEF_SETTINGS_LogSeverity:
		cefSetting->log_severity = (cef_log_severity_t)std::stoi(value);
		break;
	default:
		break;
	}
}

void MyCefDoMessageLoopWork()
{
	CefDoMessageLoopWork();
}
void MyCefShutDown() {

	// Shut down CEF.
	mainContext->Shutdown();
	// Release objects in reverse order of creation. 
	/*CefShutdown();*/
}

//--------------------------------------
//browser instance...
//--------------------------------------
MyBrowser* MyCefCreateMyWebBrowser(managed_callback callback)
{
	auto myBw = new MyBrowser();

	auto rootWindow = new MyCefRootWindow();//new client::RootWindowWin();
	myBw->rootWin = rootWindow;

	//1. create browser window handler
	//TODO: review here again, don't store at this module!
	auto bwWindow = new client::BrowserWindowStdWin(rootWindow, "");
	myBw->bwWindow = bwWindow;

	//2. browser event handler	 
	auto clientHandler = bwWindow->GetClientHandler();
	clientHandler->MyCefSetManagedCallBack(callback);

	return myBw;
}


MyBrowser* MyCefCreateMyWebBrowserOSR(managed_callback callback)
{
	auto myBw = new MyBrowser();

	auto rootWindow = new MyCefRootWindow(); //new client::RootWindowWin();
	myBw->rootWin = rootWindow;


	client::OsrRenderer::Settings settings;
	client::MainContext::Get()->PopulateOsrSettings(&settings);

	//1. create browser window handler
	//TODO: review here again, don't store at this module!
	auto bwWindow = new client::BrowserWindowOsrWin(rootWindow, "", settings);
	myBw->bwWindow = bwWindow;

	//2. browser event handler
	auto clientHandler = bwWindow->GetClientHandler();
	clientHandler->MyCefSetManagedCallBack(callback);
	return myBw;
}


int MyCefSetupBrowserHwnd(MyBrowser* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext)
{
	RECT r;
	r.left = x;
	r.top = y;
	r.right = x + w;
	r.bottom = y + h;


	//// Information used when creating the native window.
	CefWindowInfo window_info;
	window_info.SetAsChild(surfaceHwnd, r);
	// SimpleHandler implements browser-level callbacks. 
	auto clientHandler = myBw->bwWindow->GetClientHandler();
	CefRefPtr<client::ClientHandler> handler(clientHandler);

	// Specify CEF browser settings here.
	CefBrowserSettings browser_settings;
	//populate browser setting here
	memset(&browser_settings, 0, sizeof(CefBrowserSettings));

	bool result = CefBrowserHost::CreateBrowser(window_info,
		clientHandler,
		url,
		browser_settings,
		CefRefPtr<CefRequestContext>(cefRefContext));

	return (result) ? 1 : 0;
}


int MyCefSetupBrowserHwndOSR(MyBrowser* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext)
{

	////--off-screen-rendering-enabled 
	CefRect cef_rect(x, y, w, h);
	CefBrowserSettings browser_settings;
	//populate browser setting here
	memset(&browser_settings, 0, sizeof(CefBrowserSettings));
	client::MainContext::Get()->PopulateBrowserSettings(&browser_settings);
	client::BrowserWindowOsrWin* windowosr = (client::BrowserWindowOsrWin*)myBw->bwWindow;
	windowosr->CreateBrowser(surfaceHwnd, cef_rect, browser_settings, cefRefContext);
	//----------------------------------
	return 1;
}


//---------------------
class MyCefStringVisitor : public CefStringVisitor {
public:
	managed_callback mcallback;
	explicit MyCefStringVisitor(CefRefPtr<CefBrowser> browser) : browser_(browser) {
		mcallback = NULL;
	}
	virtual void Visit(const CefString& string) OVERRIDE {

		if (mcallback) {
			MethodArgs metArgs;
			memset(&metArgs, 0, sizeof(MethodArgs));
			metArgs.SetArgAsNativeObject(0, &string);
			metArgs.SetArgType(0, JSVALUE_TYPE_NATIVE_CEFSTRING);
			this->mcallback(CEF_MSG_MyCefDomGetTextWalk_Visit, &metArgs);
		}
	}
private:
	CefRefPtr<CefBrowser> browser_;
	IMPLEMENT_REFCOUNTING(MyCefStringVisitor);
};

void MyCefDomGetTextWalk(MyBrowser* myBw, managed_callback strCallBack)
{
	auto bw = myBw->bwWindow->GetBrowser();
	auto bwVisitor = new MyCefStringVisitor(bw);
	bwVisitor->mcallback = strCallBack;
	bw->GetMainFrame()->GetText(bwVisitor);
	//this is not blocking method, so=> need to create visitor on heap

}
void MyCefDomGetSourceWalk(MyBrowser* myBw, managed_callback strCallBack)
{
	auto bw = myBw->bwWindow->GetBrowser();
	auto bwVisitor = new MyCefStringVisitor(bw);
	bwVisitor->mcallback = strCallBack;
	bw->GetMainFrame()->GetSource(bwVisitor);
	//this is not blocking method, so=> need to create visitor on heap
}



//4. 
void MyCefShowDevTools(MyBrowser* myBw, MyBrowser* myBwDev, HWND parentWindow)
{

	//TODO : fine tune here

	CefWindowInfo windowInfo;
	windowInfo.parent_window = parentWindow;
	windowInfo.width = 800;
	windowInfo.height = 600;
	windowInfo.x = 0;
	windowInfo.y = 0;

	RECT r;
	r.left = 0;
	r.top = 0;
	r.right = 800;
	r.bottom = 600;

	windowInfo.SetAsChild(parentWindow, r);

	CefRefPtr<CefClient> client(myBwDev->bwWindow->GetClientHandler());
	CefBrowserSettings settings;
	CefPoint inspect_element_at;

	myBw->bwWindow->GetBrowser()->GetHost()->ShowDevTools(
		windowInfo,
		client,
		settings,
		inspect_element_at);
}


void MyCefPrintToPdf(MyBrowser* myBw, CefPdfPrintSettings* setting, wchar_t* filename, managed_callback callback) {


	//
	class MyPdfCallback : public CefPdfPrintCallback {
	public:
		managed_callback m_callback;
		void OnPdfPrintFinished(const CefString& path, bool ok) OVERRIDE
		{
			if (m_callback) {
				//callback
				MethodArgs metArgs;
				metArgs.SetArgAsInt32(0, ok ? 1 : 0);
				metArgs.SetArgAsString(1, path.c_str());
				m_callback(0, &metArgs);
			}
		}
		IMPLEMENT_REFCOUNTING(MyPdfCallback);
	};

	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {

		CefPdfPrintSettings pdfSetting;
		if (setting) {
			pdfSetting = *setting;
		}
		else {
			//set default
			pdfSetting.header_footer_enabled = true;
		}
		// Print to the selected PDF file.
		auto myPdfCallback = new MyPdfCallback();
		myPdfCallback->m_callback = callback;
		browser->GetHost()->PrintToPDF(filename, pdfSetting, myPdfCallback);
	}
}
CefPdfPrintSettings* MyCefCreatePdfPrintSetting(wchar_t* pdfjsonConfig) {
	CefString cefStr = pdfjsonConfig;
	CefRefPtr<CefValue> value = CefParseJSON(cefStr, JSON_PARSER_RFC);
	//
	if (value.get() && value->GetType() == VTYPE_DICTIONARY) {
		CefRefPtr<CefDictionaryValue> dict = value->GetDictionary();
		//
		CefPdfPrintSettings* setting = new CefPdfPrintSettings();

		CefDictionaryValue* dict_value = dict.get();
		if (dict_value->HasKey("header_footer_enabled")) {
			setting->header_footer_enabled = dict_value->GetBool("header_footer_enabled");
		}
		if (dict_value->HasKey("header_footer_url")) {
			CefString(&setting->header_footer_url) = dict_value->GetString("header_footer_url");
		}
		if (dict_value->HasKey("header_footer_title")) {
			CefString(&setting->header_footer_title) = dict_value->GetString("header_footer_title");
		}
		if (dict_value->HasKey("page_width")) {
			setting->page_width = dict_value->GetInt("page_width");
		}
		if (dict_value->HasKey("page_height")) {
			setting->page_height = dict_value->GetInt("page_height");
		}
		if (dict_value->HasKey("scale_factor")) {
			setting->scale_factor = dict_value->GetInt("scale_factor");
		}
		if (dict_value->HasKey("margin_top")) {
			setting->margin_top = dict_value->GetDouble("margin_top");
		}
		if (dict_value->HasKey("margin_right")) {
			setting->margin_right = dict_value->GetDouble("margin_right");
		}
		if (dict_value->HasKey("margin_bottom")) {
			setting->margin_bottom = dict_value->GetDouble("margin_bottom");
		}
		if (dict_value->HasKey("margin_left")) {
			setting->margin_left = dict_value->GetDouble("margin_left");
		}
		if (dict_value->HasKey("margin_type")) {
			setting->margin_type = (cef_pdf_print_margin_type_t)dict_value->GetInt("margin_type");
		}
		if (dict_value->HasKey("header_footer_enabled")) {
			setting->header_footer_enabled = dict_value->GetInt("header_footer_enabled");
		}
		if (dict_value->HasKey("selection_only")) {
			setting->selection_only = dict_value->GetInt("selection_only");
		}
		if (dict_value->HasKey("landscape")) {
			setting->landscape = dict_value->GetInt("landscape");
		}
		if (dict_value->HasKey("backgrounds_enabled")) {
			setting->backgrounds_enabled = dict_value->GetInt("backgrounds_enabled");
		}

		return setting;
	}
	return NULL;
}


void HereOnRenderer(const managed_callback callback, MethodArgs* args)
{
	callback(CEF_MSG_HereOnRenderer, args);
}


void MyCefJsNotifyRenderer(const managed_callback callback, MethodArgs* args) {
	CefPostTask(TID_RENDERER, base::Bind(&HereOnRenderer, callback, args));
}



bool MyCefAddCrossOriginWhitelistEntry(
	const wchar_t*  sourceOrigin,
	const wchar_t*  targetProtocol,
	const wchar_t*  targetDomain,
	bool allow_target_subdomains
)
{
	return CefAddCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allow_target_subdomains);
}
bool MyCefRemoveCrossOriginWhitelistEntry(
	const wchar_t*  sourceOrigin,
	const wchar_t*  targetProtocol,
	const wchar_t*  targetDomain,
	bool allow_target_subdomains
)
{
	return CefAddCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allow_target_subdomains);
}

void MyCefDeletePtr(void* ptr) {
	delete ptr;
}
void MyCefDeletePtrArray(jsvalue* ptr) {
	delete[] ptr;
}

//----------------
const int MET_Release = 0;
//----------------
void CopyStringListToResult(jsvalue* ret, std::vector<CefString>& lst) {

	//convert data to user list
	auto sizeCount = lst.size();
	//transfer databack 
	jsvalue* arr = new jsvalue[sizeCount];
	for (size_t i = 0; i < sizeCount; ++i) {

		CefString cefStr = lst[i];
		arr[i].ptr = cefStr.c_str();
		arr[i].type = JSVALUE_TYPE_STRING;
	}
	ret->i32 = sizeCount;
	ret->ptr = arr;
	ret->type = JSVALUE_TYPE_ARRAY;
}
void CopyInt64ListToResult(jsvalue* ret, std::vector<int64>& int64list) {

	auto sizeCount = int64list.size();
	//transfer databack 
	jsvalue* arr = new jsvalue[sizeCount];
	for (size_t i = 0; i < sizeCount; ++i) {
		arr[i].i64 = int64list[i];
		arr[i].type = JSVALUE_TYPE_INTEGER64;
	}
	ret->i32 = sizeCount;
	ret->ptr = arr;
	ret->type = JSVALUE_TYPE_ARRAY;
}
//
inline void SetCefStringToJsValue(jsvalue* value, const CefString& cefstr) {


	//
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
//----------------

managed_callback MyCefJsValueGetManagedCallback(jsvalue* v) {
	if (v->type == JSVALUE_TYPE_MANAGED_CB) {
		return (managed_callback)v->ptr;
	}
	else {
		return nullptr;
	}
}
void MyCefJsValueSetManagedCallback(jsvalue* v, managed_callback cb) {
	v->type = JSVALUE_TYPE_MANAGED_CB;
	v->ptr = cb;
}


const int CefBw_GoBack = 1;
const int CefBw_Reload = 2;
const int CefBw_ReloadIgnoreCache = 3;
const int CefBw_GetFrameCount = 4;

const int CefBw_IsSame = 6;
const int CefBw_GetFrameNames = 7;

const int CefBw_GetFrameIdentifiers = 10;
const int CefBw_MyCef_EnableKeyIntercept = 11;

const int CefBw_GetMainFrame_GetURL = 21;
const int CefBw_StopLoad = 22;
const int CefBw_GoForward = 23;
const int CefBw_GetMainFrame_LoadURL = 24;
const int CefBw_SetSize = 25;
const int CefBw_ExecJs = 26;
const int CefBw_PostData = 27;
const int CefBw_CloseBw = 28;
const int CefBw_GetMainFrame = 29;
const int CefBw_NewStringVisitor = 30;
//----------------

void MyCefBwCall2(MyBrowser* myBw, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {

	auto bw = myBw->bwWindow->GetBrowser();
	ret->type = JSVALUE_TYPE_EMPTY;

	switch (methodName) {
	case CefBw_GoBack: {
		bw->GoBack();
	}	break;
	case CefBw_Reload: {
		bw->Reload();
	}	break;
	case CefBw_StopLoad: {
		bw->StopLoad();
	}	break;
	case CefBw_ReloadIgnoreCache: {
		bw->ReloadIgnoreCache();
	}	break;
	case CefBw_GetFrameCount: {
		//set return value (int32)
		MyCefSetInt32(ret, bw->GetFrameCount());
	} break;
	case CefBw_MyCef_EnableKeyIntercept: {

		auto clientHandle = myBw->bwWindow->GetClientHandler();
		clientHandle->MyCefEnableKeyIntercept(v1->i32);

	}break;
	case 5: {
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = bw;
	}break;
	case CefBw_IsSame: {
		ret->i32 = bw->IsSame((CefBrowser*)v1->ptr) ? 1 : 0;
		ret->type = JSVALUE_TYPE_BOOLEAN;
	} break;
	case CefBw_GetFrameNames: {
		std::vector<CefString> cefStringList;
		bw->GetFrameNames(cefStringList);
		CopyStringListToResult(v1, cefStringList);
	}break;
	case 9: {
		//get string list
		std::vector<CefString>* cefStringList = (std::vector<CefString>*)v1->ptr;
		ret->type = JSVALUE_TYPE_INTEGER;
		ret->i32 = cefStringList->size();
	}break;
	case CefBw_GetFrameIdentifiers: {
		//get int list
		std::vector<int64> int64list;
		bw->GetFrameIdentifiers(int64list);
		CopyInt64ListToResult(v1, int64list);
		//auto sizeCount = int64list.size();
		////transfer databack 
		//jsvalue* arr = new jsvalue[sizeCount];
		//for (size_t i = 0; i < sizeCount; ++i) {
		//	arr[i].i64 = int64list[i];
		//	arr[i].type = JSVALUE_TYPE_INTEGER64;
		//}
		//ret->i32 = sizeCount;
		//ret->ptr = arr;
		//ret->type = JSVALUE_TYPE_ARRAY;
	}break;
	case CefBw_CloseBw: {
		myBw->bwWindow->ClientClose();
	}break;
	case CefBw_GetMainFrame: {
		//***
		cef_frame_t* cef_frame = CefFrameCToCpp::Unwrap(myBw->bwWindow->GetBrowser()->GetMainFrame());
		ret->ptr = cef_frame;
		ret->type = JSVALUE_TYPE_WRAPPED;
		//***
	}break;
	case CefBw_GetMainFrame_LoadURL: {
		bw->GetMainFrame()->LoadURL(GetStringHolder(v1)->value);

	}break;
	case CefBw_GetMainFrame_GetURL: {
		SetCefStringToJsValue(ret, bw->GetMainFrame()->GetURL());
	}break;
	case CefBw_SetSize: {
		myBw->bwWindow->SetBounds(0, 0, v1->i32, v2->i32);
	}break;
	case CefBw_ExecJs: {
		/*MyCefStringHolder* jscode = (MyCefStringHolder*)v1->ptr;
		MyCefStringHolder* script_url = (MyCefStringHolder*)v2->ptr;*/

		myBw->bwWindow->GetBrowser()->GetMainFrame()->ExecuteJavaScript(
			GetStringHolder(v1)->value, //jscode
			GetStringHolder(v2)->value, //script_url
			0);  //line num
	}break;
	case CefBw_PostData: {
		//create request
		CefRefPtr<CefRequest> request(CefRequest::Create());

		request->SetURL(GetStringHolder(v1)->value);
		//Add post data to request, the correct method and content-type header will be set by CEF 
		CefRefPtr<CefPostDataElement> postDataElement(CefPostDataElement::Create());


		char* buffer1 = new char[v2->i32];
		memcpy(buffer1, v2->ptr, v2->i32);
		postDataElement->SetToBytes(v2->i32, buffer1);
		//------

		CefRefPtr<CefPostData> postData(CefPostData::Create());
		postData->AddElement(postDataElement);
		request->SetPostData(postData);

		//add custom header (for test)
		CefRequest::HeaderMap headerMap;
		headerMap.insert(
			std::make_pair("X-My-Header", "My Header Value"));
		request->SetHeaderMap(headerMap);

		//load request
		myBw->bwWindow->GetBrowser()->GetMainFrame()->LoadRequest(request);

		delete buffer1;
	}break;
	case CefBw_NewStringVisitor: {

		auto stringVisitor = new MyCefStringVisitor(myBw->bwWindow->GetBrowser());
		stringVisitor->mcallback = MyCefJsValueGetManagedCallback(v1);
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefStringVisitorCppToC::Wrap(stringVisitor);

	}break;
	}
}
void MyCefBrowserCall2(cef_browser_t* bw, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {


	auto me = CefBrowserCToCpp::Wrap(bw);
	//...

	auto ret_result = me->GetHost();

	MyCefSetVoidPtr(ret, CefBrowserHostCToCpp::Unwrap(ret_result));


	CefBrowserCToCpp::Unwrap(me);

}
const int CefFrame_Relase = 0;

const int CefFrame_IsValid = 1;
const int CefFrame_Undo = 2;
const int CefFrame_Redo = 3;
const int CefFrame_Cut = 4;
const int CefFrame_Copy = 5;
const int CefFrame_Paste = 6;
const int CefFrame_Delete = 7;
const int CefFrame_SelectAll = 8;
const int CefFrame_ViewSource = 9;

const int CefFrame_GetSource = 10;
const int CefFrame_GetSource_Ext = 30;

const int CefFrame_GetUrl = 11;
const int CefFrame_GetText = 12;
const int CefFrame_LoadRequest = 13;
const int CefFrame_LoadUrl = 14;
const int CefFrame_LoadString = 15;
const int CefFrame_ExecuteJavaScript = 16;
const int CefFrame_IsMain = 17;
const int CefFrame_IsFocused = 18;
const int CefFrame_GetName = 19;
const int CefFrame_GetIdentifer = 20;
const int CefFrame_GetParent = 21;
const int CefFrame_GetBrowser = 22;
const int CefFrame_GetV8Context = 23;
const int CefFrame_VisitDOM = 24;

void MyCefFrameCall2(cef_frame_t* cefFrame, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {

	auto cefFrame1 = CefFrameCToCpp::Wrap(cefFrame);
	ret->type = JSVALUE_TYPE_EMPTY;
	switch (methodName) {
	case CefFrame_Relase: {
		//just wrap, no unwrap
	}break;
	case CefFrame_IsValid: {
		//return boolean value
		ret->i32 = cefFrame1->IsValid() ? 1 : 0;
		ret->type = JSVALUE_TYPE_BOOLEAN;
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetSource:
	{
		cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetSource_Ext:
	{
		//void GetSource(CefRefPtr<CefStringVisitor> visitor) OVERRIDE;
		auto bwVisitor = new MyCefStringVisitor(cefFrame1->GetBrowser());
		bwVisitor->mcallback = MyCefJsValueGetManagedCallback(v1);
		cefFrame1->GetSource(bwVisitor);
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetUrl:
	{
		SetCefStringToJsValue(ret, cefFrame1->GetURL());
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetText: {
		cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back  
	}break;
	case CefFrame_LoadUrl: {

		/*MyCefStringHolder* holder = (MyCefStringHolder*)v1->ptr;
		cefFrame1->LoadURL(holder->value);*/

		cefFrame1->LoadURL(GetStringHolder(v1)->value);
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_LoadString: {

		/*	MyCefStringHolder* holder1 = (MyCefStringHolder*)v1->ptr;
			MyCefStringHolder* holder2 = (MyCefStringHolder*)v2->ptr;*/
		cefFrame1->LoadStringW(GetStringHolder(v1)->value, GetStringHolder(v2)->value);
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetParent: {
		auto ret_result = cefFrame1->GetParent();
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefFrameCToCpp::Unwrap(ret_result);
		CefFrameCToCpp::Unwrap(cefFrame1);
	}break;
	case CefFrame_GetBrowser: {
		auto ret_result = cefFrame1->GetBrowser();
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefBrowserCToCpp::Unwrap(ret_result);
		CefFrameCToCpp::Unwrap(cefFrame1);
	}break;
	case CefFrame_GetV8Context: {
		auto ret_result = cefFrame1->GetV8Context();
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefV8ContextCToCpp::Unwrap(ret_result);
		CefFrameCToCpp::Unwrap(cefFrame1);
	}break;
	}
}

const int TypeName_StringVisitor = 1;

void MyCefRelease(void* ptr, int typeName) {
	switch (typeName) {
	case TypeName_StringVisitor: {
		CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)ptr);
	}break;
	}
}
 

 
//////////////////////////////////////////

// [virtual] class CefApp
/*1*/

/*2*/
void MyCefMet_CefApp(cef_app_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*4*/
	auto me = CefAppCppToC::Unwrap(me1);
	/*5*/
	switch (metName) {
		/*6*/
	case MET_Release:return; //yes, just return
							 /*7*/
	}
	/*8*/
	CefAppCppToC::Wrap(me);
	/*9*/
}


// [virtual] class CefBrowser
/*31*/
/*10*/
const int CefBrowser_GetHost_1 = 1;
/*11*/
const int CefBrowser_CanGoBack_2 = 2;
/*12*/
const int CefBrowser_GoBack_3 = 3;
/*13*/
const int CefBrowser_CanGoForward_4 = 4;
/*14*/
const int CefBrowser_GoForward_5 = 5;
/*15*/
const int CefBrowser_IsLoading_6 = 6;
/*16*/
const int CefBrowser_Reload_7 = 7;
/*17*/
const int CefBrowser_ReloadIgnoreCache_8 = 8;
/*18*/
const int CefBrowser_StopLoad_9 = 9;
/*19*/
const int CefBrowser_GetIdentifier_10 = 10;
/*20*/
const int CefBrowser_IsSame_11 = 11;
/*21*/
const int CefBrowser_IsPopup_12 = 12;
/*22*/
const int CefBrowser_HasDocument_13 = 13;
/*23*/
const int CefBrowser_GetMainFrame_14 = 14;
/*24*/
const int CefBrowser_GetFocusedFrame_15 = 15;
/*25*/
const int CefBrowser_GetFrame_16 = 16;
/*26*/
const int CefBrowser_GetFrame_17 = 17;
/*27*/
const int CefBrowser_GetFrameCount_18 = 18;
/*28*/
const int CefBrowser_GetFrameIdentifiers_19 = 19;
/*29*/
const int CefBrowser_GetFrameNames_20 = 20;
/*30*/
const int CefBrowser_SendProcessMessage_21 = 21;

/*32*/
void MyCefMet_CefBrowser(cef_browser_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*33*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*34*/
	auto me = CefBrowserCToCpp::Wrap(me1);
	/*35*/
	switch (metName) {
		/*36*/
	case MET_Release:return; //yes, just return
							 /*37*/
	case CefBrowser_GetHost_1: {
		/*38*/


		// gen! CefRefPtr<CefBrowserHost> GetHost()
		auto ret_result = me->GetHost();
		/*39*/
		MyCefSetVoidPtr(ret, CefBrowserHostCToCpp::Unwrap(ret_result));
		/*40*/
	} break;
		/*41*/
	case CefBrowser_CanGoBack_2: {
		/*42*/


		// gen! bool CanGoBack()
		auto ret_result = me->CanGoBack();
		/*43*/
		MyCefSetBool(ret, ret_result);
		/*44*/
	} break;
		/*45*/
	case CefBrowser_GoBack_3: {
		/*46*/


		// gen! void GoBack()
		me->GoBack();
		/*47*/

		/*48*/
	} break;
		/*49*/
	case CefBrowser_CanGoForward_4: {
		/*50*/


		// gen! bool CanGoForward()
		auto ret_result = me->CanGoForward();
		/*51*/
		MyCefSetBool(ret, ret_result);
		/*52*/
	} break;
		/*53*/
	case CefBrowser_GoForward_5: {
		/*54*/


		// gen! void GoForward()
		me->GoForward();
		/*55*/

		/*56*/
	} break;
		/*57*/
	case CefBrowser_IsLoading_6: {
		/*58*/


		// gen! bool IsLoading()
		auto ret_result = me->IsLoading();
		/*59*/
		MyCefSetBool(ret, ret_result);
		/*60*/
	} break;
		/*61*/
	case CefBrowser_Reload_7: {
		/*62*/


		// gen! void Reload()
		me->Reload();
		/*63*/

		/*64*/
	} break;
		/*65*/
	case CefBrowser_ReloadIgnoreCache_8: {
		/*66*/


		// gen! void ReloadIgnoreCache()
		me->ReloadIgnoreCache();
		/*67*/

		/*68*/
	} break;
		/*69*/
	case CefBrowser_StopLoad_9: {
		/*70*/


		// gen! void StopLoad()
		me->StopLoad();
		/*71*/

		/*72*/
	} break;
		/*73*/
	case CefBrowser_GetIdentifier_10: {
		/*74*/


		// gen! int GetIdentifier()
		auto ret_result = me->GetIdentifier();
		/*75*/
		MyCefSetInt64(ret, ret_result);
		/*76*/
	} break;
		/*77*/
	case CefBrowser_IsSame_11: {
		/*78*/


		// gen! bool IsSame(CefRefPtr<CefBrowser> that)
		auto ret_result = me->IsSame(CefBrowserCToCpp::Wrap((cef_browser_t*)v1->ptr));
		/*79*/
		MyCefSetBool(ret, ret_result);
		/*80*/
	} break;
		/*81*/
	case CefBrowser_IsPopup_12: {
		/*82*/


		// gen! bool IsPopup()
		auto ret_result = me->IsPopup();
		/*83*/
		MyCefSetBool(ret, ret_result);
		/*84*/
	} break;
		/*85*/
	case CefBrowser_HasDocument_13: {
		/*86*/


		// gen! bool HasDocument()
		auto ret_result = me->HasDocument();
		/*87*/
		MyCefSetBool(ret, ret_result);
		/*88*/
	} break;
		/*89*/
	case CefBrowser_GetMainFrame_14: {
		/*90*/


		// gen! CefRefPtr<CefFrame> GetMainFrame()
		auto ret_result = me->GetMainFrame();
		/*91*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*92*/
	} break;
		/*93*/
	case CefBrowser_GetFocusedFrame_15: {
		/*94*/


		// gen! CefRefPtr<CefFrame> GetFocusedFrame()
		auto ret_result = me->GetFocusedFrame();
		/*95*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*96*/
	} break;
		/*97*/
	case CefBrowser_GetFrame_16: {
		/*98*/


		// gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
		auto ret_result = me->GetFrame(v1->i64);
		/*99*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*100*/
	} break;
		/*101*/
	case CefBrowser_GetFrame_17: {
		/*102*/


		// gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
		auto ret_result = me->GetFrame(GetStringHolder(v1)->value);
		/*103*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*104*/
	} break;
		/*105*/
	case CefBrowser_GetFrameCount_18: {
		/*106*/


		// gen! size_t GetFrameCount()
		auto ret_result = me->GetFrameCount();
		/*107*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*108*/
	} break;
		/*109*/
	case CefBrowser_GetFrameIdentifiers_19: {
		/*110*/


		// gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
		me->GetFrameIdentifiers(*((std::vector<int64>*)v1->ptr));
		/*111*/

		/*112*/
	} break;
		/*113*/
	case CefBrowser_GetFrameNames_20: {
		/*114*/


		// gen! void GetFrameNames(std::vector<CefString>& names)
		me->GetFrameNames(*((std::vector<CefString>*)v1->ptr));
		/*115*/

		/*116*/
	} break;
		/*117*/
	case CefBrowser_SendProcessMessage_21: {
		/*118*/


		// gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
		auto ret_result = me->SendProcessMessage((CefProcessId)v1->i32,
			CefProcessMessageCToCpp::Wrap((cef_process_message_t*)v2->ptr));
		/*119*/
		MyCefSetBool(ret, ret_result);
		/*120*/
	} break;
		/*121*/
	}
	/*122*/
	CefBrowserCToCpp::Unwrap(me);
	/*123*/
}


// [virtual] class CefNavigationEntryVisitor
/*124*/

/*125*/
void MyCefMet_CefNavigationEntryVisitor(cef_navigation_entry_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*126*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*127*/
	auto me = CefNavigationEntryVisitorCppToC::Unwrap(me1);
	/*128*/
	switch (metName) {
		/*129*/
	case MET_Release:return; //yes, just return
							 /*130*/
	}
	/*131*/
	CefNavigationEntryVisitorCppToC::Wrap(me);
	/*132*/
}


// [virtual] class CefBrowserHost
/*185*/
/*133*/
const int CefBrowserHost_GetBrowser_1 = 1;
/*134*/
const int CefBrowserHost_CloseBrowser_2 = 2;
/*135*/
const int CefBrowserHost_TryCloseBrowser_3 = 3;
/*136*/
const int CefBrowserHost_SetFocus_4 = 4;
/*137*/
const int CefBrowserHost_GetWindowHandle_5 = 5;
/*138*/
const int CefBrowserHost_GetOpenerWindowHandle_6 = 6;
/*139*/
const int CefBrowserHost_HasView_7 = 7;
/*140*/
const int CefBrowserHost_GetClient_8 = 8;
/*141*/
const int CefBrowserHost_GetRequestContext_9 = 9;
/*142*/
const int CefBrowserHost_GetZoomLevel_10 = 10;
/*143*/
const int CefBrowserHost_SetZoomLevel_11 = 11;
/*144*/
const int CefBrowserHost_RunFileDialog_12 = 12;
/*145*/
const int CefBrowserHost_StartDownload_13 = 13;
/*146*/
const int CefBrowserHost_DownloadImage_14 = 14;
/*147*/
const int CefBrowserHost_Print_15 = 15;
/*148*/
const int CefBrowserHost_PrintToPDF_16 = 16;
/*149*/
const int CefBrowserHost_Find_17 = 17;
/*150*/
const int CefBrowserHost_StopFinding_18 = 18;
/*151*/
const int CefBrowserHost_ShowDevTools_19 = 19;
/*152*/
const int CefBrowserHost_CloseDevTools_20 = 20;
/*153*/
const int CefBrowserHost_HasDevTools_21 = 21;
/*154*/
const int CefBrowserHost_GetNavigationEntries_22 = 22;
/*155*/
const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = 23;
/*156*/
const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = 24;
/*157*/
const int CefBrowserHost_ReplaceMisspelling_25 = 25;
/*158*/
const int CefBrowserHost_AddWordToDictionary_26 = 26;
/*159*/
const int CefBrowserHost_IsWindowRenderingDisabled_27 = 27;
/*160*/
const int CefBrowserHost_WasResized_28 = 28;
/*161*/
const int CefBrowserHost_WasHidden_29 = 29;
/*162*/
const int CefBrowserHost_NotifyScreenInfoChanged_30 = 30;
/*163*/
const int CefBrowserHost_Invalidate_31 = 31;
/*164*/
const int CefBrowserHost_SendKeyEvent_32 = 32;
/*165*/
const int CefBrowserHost_SendMouseClickEvent_33 = 33;
/*166*/
const int CefBrowserHost_SendMouseMoveEvent_34 = 34;
/*167*/
const int CefBrowserHost_SendMouseWheelEvent_35 = 35;
/*168*/
const int CefBrowserHost_SendFocusEvent_36 = 36;
/*169*/
const int CefBrowserHost_SendCaptureLostEvent_37 = 37;
/*170*/
const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = 38;
/*171*/
const int CefBrowserHost_GetWindowlessFrameRate_39 = 39;
/*172*/
const int CefBrowserHost_SetWindowlessFrameRate_40 = 40;
/*173*/
const int CefBrowserHost_ImeSetComposition_41 = 41;
/*174*/
const int CefBrowserHost_ImeCommitText_42 = 42;
/*175*/
const int CefBrowserHost_ImeFinishComposingText_43 = 43;
/*176*/
const int CefBrowserHost_ImeCancelComposition_44 = 44;
/*177*/
const int CefBrowserHost_DragTargetDragEnter_45 = 45;
/*178*/
const int CefBrowserHost_DragTargetDragOver_46 = 46;
/*179*/
const int CefBrowserHost_DragTargetDragLeave_47 = 47;
/*180*/
const int CefBrowserHost_DragTargetDrop_48 = 48;
/*181*/
const int CefBrowserHost_DragSourceEndedAt_49 = 49;
/*182*/
const int CefBrowserHost_DragSourceSystemDragEnded_50 = 50;
/*183*/
const int CefBrowserHost_GetVisibleNavigationEntry_51 = 51;
/*184*/
const int CefBrowserHost_SetAccessibilityState_52 = 52;

/*186*/
void MyCefMet_CefBrowserHost(cef_browser_host_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*187*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*188*/
	auto me = CefBrowserHostCToCpp::Wrap(me1);
	/*189*/
	switch (metName) {
		/*190*/
	case MET_Release:return; //yes, just return
							 /*191*/
	case CefBrowserHost_GetBrowser_1: {
		/*192*/


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		/*193*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*194*/
	} break;
		/*195*/
	case CefBrowserHost_CloseBrowser_2: {
		/*196*/


		// gen! void CloseBrowser(bool force_close)
		me->CloseBrowser(v1->i32 != 0);
		/*197*/

		/*198*/
	} break;
		/*199*/
	case CefBrowserHost_TryCloseBrowser_3: {
		/*200*/


		// gen! bool TryCloseBrowser()
		auto ret_result = me->TryCloseBrowser();
		/*201*/
		MyCefSetBool(ret, ret_result);
		/*202*/
	} break;
		/*203*/
	case CefBrowserHost_SetFocus_4: {
		/*204*/


		// gen! void SetFocus(bool focus)
		me->SetFocus(v1->i32 != 0);
		/*205*/

		/*206*/
	} break;
		/*207*/
	case CefBrowserHost_GetWindowHandle_5: {
		/*208*/


		// gen! CefWindowHandle GetWindowHandle()
		auto ret_result = me->GetWindowHandle();
		/*209*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*210*/
	} break;
		/*211*/
	case CefBrowserHost_GetOpenerWindowHandle_6: {
		/*212*/


		// gen! CefWindowHandle GetOpenerWindowHandle()
		auto ret_result = me->GetOpenerWindowHandle();
		/*213*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*214*/
	} break;
		/*215*/
	case CefBrowserHost_HasView_7: {
		/*216*/


		// gen! bool HasView()
		auto ret_result = me->HasView();
		/*217*/
		MyCefSetBool(ret, ret_result);
		/*218*/
	} break;
		/*219*/
	case CefBrowserHost_GetClient_8: {
		/*220*/


		// gen! CefRefPtr<CefClient> GetClient()
		auto ret_result = me->GetClient();
		/*221*/
		MyCefSetVoidPtr(ret, CefClientCppToC::Wrap(ret_result));
		/*222*/
	} break;
		/*223*/
	case CefBrowserHost_GetRequestContext_9: {
		/*224*/


		// gen! CefRefPtr<CefRequestContext> GetRequestContext()
		auto ret_result = me->GetRequestContext();
		/*225*/
		MyCefSetVoidPtr(ret, CefRequestContextCToCpp::Unwrap(ret_result));
		/*226*/
	} break;
		/*227*/
	case CefBrowserHost_GetZoomLevel_10: {
		/*228*/


		// gen! double GetZoomLevel()
		auto ret_result = me->GetZoomLevel();
		/*229*/
		MyCefSetDouble(ret, ret_result);
		/*230*/
	} break;
		/*231*/
	case CefBrowserHost_SetZoomLevel_11: {
		/*232*/


		// gen! void SetZoomLevel(double zoomLevel)
		me->SetZoomLevel(v1->num);
		/*233*/

		/*234*/
	} break;
		/*235*/
	case CefBrowserHost_RunFileDialog_12: {
		/*236*/


		// gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
		me->RunFileDialog((CefBrowserHost::FileDialogMode)v1->i32,
			GetStringHolder(v2)->value,
			GetStringHolder(v3)->value,
			*((std::vector<CefString>*)v4->ptr),
			v5->i32,
			CefRunFileDialogCallbackCppToC::Unwrap((cef_run_file_dialog_callback_t*)v6->ptr));
		/*237*/

		/*238*/
	} break;
		/*239*/
	case CefBrowserHost_StartDownload_13: {
		/*240*/


		// gen! void StartDownload(const CefString& url)
		me->StartDownload(GetStringHolder(v1)->value);
		/*241*/

		/*242*/
	} break;
		/*243*/
	case CefBrowserHost_DownloadImage_14: {
		/*244*/


		// gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
		me->DownloadImage(GetStringHolder(v1)->value,
			v2->i32 != 0,
			v3->i32,
			v4->i32 != 0,
			CefDownloadImageCallbackCppToC::Unwrap((cef_download_image_callback_t*)v5->ptr));
		/*245*/

		/*246*/
	} break;
		/*247*/
	case CefBrowserHost_Print_15: {
		/*248*/


		// gen! void Print()
		me->Print();
		/*249*/

		/*250*/
	} break;
		/*251*/
	case CefBrowserHost_PrintToPDF_16: {
		/*252*/


		// gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
		me->PrintToPDF(GetStringHolder(v1)->value,
			*((CefPdfPrintSettings*)v2->ptr),
			CefPdfPrintCallbackCppToC::Unwrap((cef_pdf_print_callback_t*)v3->ptr));
		/*253*/

		/*254*/
	} break;
		/*255*/
	case CefBrowserHost_Find_17: {
		/*256*/


		// gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
		me->Find(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*257*/

		/*258*/
	} break;
		/*259*/
	case CefBrowserHost_StopFinding_18: {
		/*260*/


		// gen! void StopFinding(bool clearSelection)
		me->StopFinding(v1->i32 != 0);
		/*261*/

		/*262*/
	} break;
		/*263*/
	case CefBrowserHost_ShowDevTools_19: {
		/*264*/


		// gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
		me->ShowDevTools(*((CefWindowInfo*)v1->ptr),
			CefClientCppToC::Unwrap((cef_client_t*)v2->ptr),
			*((CefBrowserSettings*)v3->ptr),
			*((CefPoint*)v4->ptr));
		/*265*/

		/*266*/
	} break;
		/*267*/
	case CefBrowserHost_CloseDevTools_20: {
		/*268*/


		// gen! void CloseDevTools()
		me->CloseDevTools();
		/*269*/

		/*270*/
	} break;
		/*271*/
	case CefBrowserHost_HasDevTools_21: {
		/*272*/


		// gen! bool HasDevTools()
		auto ret_result = me->HasDevTools();
		/*273*/
		MyCefSetBool(ret, ret_result);
		/*274*/
	} break;
		/*275*/
	case CefBrowserHost_GetNavigationEntries_22: {
		/*276*/


		// gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
		me->GetNavigationEntries(CefNavigationEntryVisitorCppToC::Unwrap((cef_navigation_entry_visitor_t*)v1->ptr),
			v2->i32 != 0);
		/*277*/

		/*278*/
	} break;
		/*279*/
	case CefBrowserHost_SetMouseCursorChangeDisabled_23: {
		/*280*/


		// gen! void SetMouseCursorChangeDisabled(bool disabled)
		me->SetMouseCursorChangeDisabled(v1->i32 != 0);
		/*281*/

		/*282*/
	} break;
		/*283*/
	case CefBrowserHost_IsMouseCursorChangeDisabled_24: {
		/*284*/


		// gen! bool IsMouseCursorChangeDisabled()
		auto ret_result = me->IsMouseCursorChangeDisabled();
		/*285*/
		MyCefSetBool(ret, ret_result);
		/*286*/
	} break;
		/*287*/
	case CefBrowserHost_ReplaceMisspelling_25: {
		/*288*/


		// gen! void ReplaceMisspelling(const CefString& word)
		me->ReplaceMisspelling(GetStringHolder(v1)->value);
		/*289*/

		/*290*/
	} break;
		/*291*/
	case CefBrowserHost_AddWordToDictionary_26: {
		/*292*/


		// gen! void AddWordToDictionary(const CefString& word)
		me->AddWordToDictionary(GetStringHolder(v1)->value);
		/*293*/

		/*294*/
	} break;
		/*295*/
	case CefBrowserHost_IsWindowRenderingDisabled_27: {
		/*296*/


		// gen! bool IsWindowRenderingDisabled()
		auto ret_result = me->IsWindowRenderingDisabled();
		/*297*/
		MyCefSetBool(ret, ret_result);
		/*298*/
	} break;
		/*299*/
	case CefBrowserHost_WasResized_28: {
		/*300*/


		// gen! void WasResized()
		me->WasResized();
		/*301*/

		/*302*/
	} break;
		/*303*/
	case CefBrowserHost_WasHidden_29: {
		/*304*/


		// gen! void WasHidden(bool hidden)
		me->WasHidden(v1->i32 != 0);
		/*305*/

		/*306*/
	} break;
		/*307*/
	case CefBrowserHost_NotifyScreenInfoChanged_30: {
		/*308*/


		// gen! void NotifyScreenInfoChanged()
		me->NotifyScreenInfoChanged();
		/*309*/

		/*310*/
	} break;
		/*311*/
	case CefBrowserHost_Invalidate_31: {
		/*312*/


		// gen! void Invalidate(PaintElementType type)
		me->Invalidate((CefBrowserHost::PaintElementType)v1->i32);
		/*313*/

		/*314*/
	} break;
		/*315*/
	case CefBrowserHost_SendKeyEvent_32: {
		/*316*/


		// gen! void SendKeyEvent(const CefKeyEvent& event)
		me->SendKeyEvent(*((CefKeyEvent*)v1->ptr));
		/*317*/

		/*318*/
	} break;
		/*319*/
	case CefBrowserHost_SendMouseClickEvent_33: {
		/*320*/


		// gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
		me->SendMouseClickEvent(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::MouseButtonType)v2->i32,
			v3->i32 != 0,
			v4->i32);
		/*321*/

		/*322*/
	} break;
		/*323*/
	case CefBrowserHost_SendMouseMoveEvent_34: {
		/*324*/


		// gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
		me->SendMouseMoveEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32 != 0);
		/*325*/

		/*326*/
	} break;
		/*327*/
	case CefBrowserHost_SendMouseWheelEvent_35: {
		/*328*/


		// gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
		me->SendMouseWheelEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32,
			v3->i32);
		/*329*/

		/*330*/
	} break;
		/*331*/
	case CefBrowserHost_SendFocusEvent_36: {
		/*332*/


		// gen! void SendFocusEvent(bool setFocus)
		me->SendFocusEvent(v1->i32 != 0);
		/*333*/

		/*334*/
	} break;
		/*335*/
	case CefBrowserHost_SendCaptureLostEvent_37: {
		/*336*/


		// gen! void SendCaptureLostEvent()
		me->SendCaptureLostEvent();
		/*337*/

		/*338*/
	} break;
		/*339*/
	case CefBrowserHost_NotifyMoveOrResizeStarted_38: {
		/*340*/


		// gen! void NotifyMoveOrResizeStarted()
		me->NotifyMoveOrResizeStarted();
		/*341*/

		/*342*/
	} break;
		/*343*/
	case CefBrowserHost_GetWindowlessFrameRate_39: {
		/*344*/


		// gen! int GetWindowlessFrameRate()
		auto ret_result = me->GetWindowlessFrameRate();
		/*345*/
		MyCefSetInt64(ret, ret_result);
		/*346*/
	} break;
		/*347*/
	case CefBrowserHost_SetWindowlessFrameRate_40: {
		/*348*/


		// gen! void SetWindowlessFrameRate(int frame_rate)
		me->SetWindowlessFrameRate(v1->i32);
		/*349*/

		/*350*/
	} break;
		/*351*/
	case CefBrowserHost_ImeSetComposition_41: {
		/*352*/


		// gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
		me->ImeSetComposition(GetStringHolder(v1)->value,
			*((std::vector<CefCompositionUnderline>*)v2->ptr),
			*((CefRange*)v3->ptr),
			*((CefRange*)v4->ptr));
		/*353*/

		/*354*/
	} break;
		/*355*/
	case CefBrowserHost_ImeCommitText_42: {
		/*356*/


		// gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
		me->ImeCommitText(GetStringHolder(v1)->value,
			*((CefRange*)v2->ptr),
			v3->i32);
		/*357*/

		/*358*/
	} break;
		/*359*/
	case CefBrowserHost_ImeFinishComposingText_43: {
		/*360*/


		// gen! void ImeFinishComposingText(bool keep_selection)
		me->ImeFinishComposingText(v1->i32 != 0);
		/*361*/

		/*362*/
	} break;
		/*363*/
	case CefBrowserHost_ImeCancelComposition_44: {
		/*364*/


		// gen! void ImeCancelComposition()
		me->ImeCancelComposition();
		/*365*/

		/*366*/
	} break;
		/*367*/
	case CefBrowserHost_DragTargetDragEnter_45: {
		/*368*/


		// gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
		me->DragTargetDragEnter(CefDragDataCToCpp::Wrap((cef_drag_data_t*)v1->ptr),
			*((CefMouseEvent*)v2->ptr),
			(CefBrowserHost::DragOperationsMask)v3->i32);
		/*369*/

		/*370*/
	} break;
		/*371*/
	case CefBrowserHost_DragTargetDragOver_46: {
		/*372*/


		// gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
		me->DragTargetDragOver(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::DragOperationsMask)v2->i32);
		/*373*/

		/*374*/
	} break;
		/*375*/
	case CefBrowserHost_DragTargetDragLeave_47: {
		/*376*/


		// gen! void DragTargetDragLeave()
		me->DragTargetDragLeave();
		/*377*/

		/*378*/
	} break;
		/*379*/
	case CefBrowserHost_DragTargetDrop_48: {
		/*380*/


		// gen! void DragTargetDrop(const CefMouseEvent& event)
		me->DragTargetDrop(*((CefMouseEvent*)v1->ptr));
		/*381*/

		/*382*/
	} break;
		/*383*/
	case CefBrowserHost_DragSourceEndedAt_49: {
		/*384*/


		// gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
		me->DragSourceEndedAt(v1->i32,
			v2->i32,
			(CefBrowserHost::DragOperationsMask)v3->i32);
		/*385*/

		/*386*/
	} break;
		/*387*/
	case CefBrowserHost_DragSourceSystemDragEnded_50: {
		/*388*/


		// gen! void DragSourceSystemDragEnded()
		me->DragSourceSystemDragEnded();
		/*389*/

		/*390*/
	} break;
		/*391*/
	case CefBrowserHost_GetVisibleNavigationEntry_51: {
		/*392*/


		// gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
		auto ret_result = me->GetVisibleNavigationEntry();
		/*393*/
		MyCefSetVoidPtr(ret, CefNavigationEntryCToCpp::Unwrap(ret_result));
		/*394*/
	} break;
		/*395*/
	case CefBrowserHost_SetAccessibilityState_52: {
		/*396*/


		// gen! void SetAccessibilityState(cef_state_t accessibility_state)
		me->SetAccessibilityState((cef_state_t)v1->i32);
		/*397*/

		/*398*/
	} break;
		/*399*/
	}
	/*400*/
	CefBrowserHostCToCpp::Unwrap(me);
	/*401*/
}


// [virtual] class CefClient
/*402*/

/*403*/
void MyCefMet_CefClient(cef_client_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*404*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*405*/
	auto me = CefClientCppToC::Unwrap(me1);
	/*406*/
	switch (metName) {
		/*407*/
	case MET_Release:return; //yes, just return
							 /*408*/
	}
	/*409*/
	CefClientCppToC::Wrap(me);
	/*410*/
}


// [virtual] class CefCommandLine
/*431*/
/*411*/
const int CefCommandLine_IsValid_1 = 1;
/*412*/
const int CefCommandLine_IsReadOnly_2 = 2;
/*413*/
const int CefCommandLine_Copy_3 = 3;
/*414*/
const int CefCommandLine_InitFromArgv_4 = 4;
/*415*/
const int CefCommandLine_InitFromString_5 = 5;
/*416*/
const int CefCommandLine_Reset_6 = 6;
/*417*/
const int CefCommandLine_GetArgv_7 = 7;
/*418*/
const int CefCommandLine_GetCommandLineString_8 = 8;
/*419*/
const int CefCommandLine_GetProgram_9 = 9;
/*420*/
const int CefCommandLine_SetProgram_10 = 10;
/*421*/
const int CefCommandLine_HasSwitches_11 = 11;
/*422*/
const int CefCommandLine_HasSwitch_12 = 12;
/*423*/
const int CefCommandLine_GetSwitchValue_13 = 13;
/*424*/
const int CefCommandLine_GetSwitches_14 = 14;
/*425*/
const int CefCommandLine_AppendSwitch_15 = 15;
/*426*/
const int CefCommandLine_AppendSwitchWithValue_16 = 16;
/*427*/
const int CefCommandLine_HasArguments_17 = 17;
/*428*/
const int CefCommandLine_GetArguments_18 = 18;
/*429*/
const int CefCommandLine_AppendArgument_19 = 19;
/*430*/
const int CefCommandLine_PrependWrapper_20 = 20;

/*432*/
void MyCefMet_CefCommandLine(cef_command_line_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*433*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*434*/
	auto me = CefCommandLineCToCpp::Wrap(me1);
	/*435*/
	switch (metName) {
		/*436*/
	case MET_Release:return; //yes, just return
							 /*437*/
	case CefCommandLine_IsValid_1: {
		/*438*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*439*/
		MyCefSetBool(ret, ret_result);
		/*440*/
	} break;
		/*441*/
	case CefCommandLine_IsReadOnly_2: {
		/*442*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*443*/
		MyCefSetBool(ret, ret_result);
		/*444*/
	} break;
		/*445*/
	case CefCommandLine_Copy_3: {
		/*446*/


		// gen! CefRefPtr<CefCommandLine> Copy()
		auto ret_result = me->Copy();
		/*447*/
		MyCefSetVoidPtr(ret, CefCommandLineCToCpp::Unwrap(ret_result));
		/*448*/
	} break;
		/*449*/
	case CefCommandLine_InitFromArgv_4: {
		/*450*/


		// gen! void InitFromArgv(int argc,const char* const* argv)
		/*me->InitFromArgv(v1->i32,
			(const char*) v2->ptr);*/
		/*451*/

		/*452*/
	} break;
		/*453*/
	case CefCommandLine_InitFromString_5: {
		/*454*/


		// gen! void InitFromString(const CefString& command_line)
		me->InitFromString(GetStringHolder(v1)->value);
		/*455*/

		/*456*/
	} break;
		/*457*/
	case CefCommandLine_Reset_6: {
		/*458*/


		// gen! void Reset()
		me->Reset();
		/*459*/

		/*460*/
	} break;
		/*461*/
	case CefCommandLine_GetArgv_7: {
		/*462*/


		// gen! void GetArgv(std::vector<CefString>& argv)
		me->GetArgv(*((std::vector<CefString>*)v1->ptr));
		/*463*/

		/*464*/
	} break;
		/*465*/
	case CefCommandLine_GetCommandLineString_8: {
		/*466*/


		// gen! CefString GetCommandLineString()
		auto ret_result = me->GetCommandLineString();
		/*467*/
		SetCefStringToJsValue(ret, ret_result);
		/*468*/
	} break;
		/*469*/
	case CefCommandLine_GetProgram_9: {
		/*470*/


		// gen! CefString GetProgram()
		auto ret_result = me->GetProgram();
		/*471*/
		SetCefStringToJsValue(ret, ret_result);
		/*472*/
	} break;
		/*473*/
	case CefCommandLine_SetProgram_10: {
		/*474*/


		// gen! void SetProgram(const CefString& program)
		me->SetProgram(GetStringHolder(v1)->value);
		/*475*/

		/*476*/
	} break;
		/*477*/
	case CefCommandLine_HasSwitches_11: {
		/*478*/


		// gen! bool HasSwitches()
		auto ret_result = me->HasSwitches();
		/*479*/
		MyCefSetBool(ret, ret_result);
		/*480*/
	} break;
		/*481*/
	case CefCommandLine_HasSwitch_12: {
		/*482*/


		// gen! bool HasSwitch(const CefString& name)
		auto ret_result = me->HasSwitch(GetStringHolder(v1)->value);
		/*483*/
		MyCefSetBool(ret, ret_result);
		/*484*/
	} break;
		/*485*/
	case CefCommandLine_GetSwitchValue_13: {
		/*486*/


		// gen! CefString GetSwitchValue(const CefString& name)
		auto ret_result = me->GetSwitchValue(GetStringHolder(v1)->value);
		/*487*/
		SetCefStringToJsValue(ret, ret_result);
		/*488*/
	} break;
		/*489*/
	case CefCommandLine_GetSwitches_14: {
		/*490*/


		// gen! void GetSwitches(SwitchMap& switches)
		me->GetSwitches(*((CefCommandLine::SwitchMap*)v1->ptr));
		/*491*/

		/*492*/
	} break;
		/*493*/
	case CefCommandLine_AppendSwitch_15: {
		/*494*/


		// gen! void AppendSwitch(const CefString& name)
		me->AppendSwitch(GetStringHolder(v1)->value);
		/*495*/

		/*496*/
	} break;
		/*497*/
	case CefCommandLine_AppendSwitchWithValue_16: {
		/*498*/


		// gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
		me->AppendSwitchWithValue(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*499*/

		/*500*/
	} break;
		/*501*/
	case CefCommandLine_HasArguments_17: {
		/*502*/


		// gen! bool HasArguments()
		auto ret_result = me->HasArguments();
		/*503*/
		MyCefSetBool(ret, ret_result);
		/*504*/
	} break;
		/*505*/
	case CefCommandLine_GetArguments_18: {
		/*506*/


		// gen! void GetArguments(ArgumentList& arguments)
		me->GetArguments(*((CefCommandLine::ArgumentList*)v1->ptr));
		/*507*/

		/*508*/
	} break;
		/*509*/
	case CefCommandLine_AppendArgument_19: {
		/*510*/


		// gen! void AppendArgument(const CefString& argument)
		me->AppendArgument(GetStringHolder(v1)->value);
		/*511*/

		/*512*/
	} break;
		/*513*/
	case CefCommandLine_PrependWrapper_20: {
		/*514*/


		// gen! void PrependWrapper(const CefString& wrapper)
		me->PrependWrapper(GetStringHolder(v1)->value);
		/*515*/

		/*516*/
	} break;
		/*517*/
	}
	/*518*/
	CefCommandLineCToCpp::Unwrap(me);
	/*519*/
}


// [virtual] class CefContextMenuParams
/*541*/
/*520*/
const int CefContextMenuParams_GetXCoord_1 = 1;
/*521*/
const int CefContextMenuParams_GetYCoord_2 = 2;
/*522*/
const int CefContextMenuParams_GetTypeFlags_3 = 3;
/*523*/
const int CefContextMenuParams_GetLinkUrl_4 = 4;
/*524*/
const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = 5;
/*525*/
const int CefContextMenuParams_GetSourceUrl_6 = 6;
/*526*/
const int CefContextMenuParams_HasImageContents_7 = 7;
/*527*/
const int CefContextMenuParams_GetTitleText_8 = 8;
/*528*/
const int CefContextMenuParams_GetPageUrl_9 = 9;
/*529*/
const int CefContextMenuParams_GetFrameUrl_10 = 10;
/*530*/
const int CefContextMenuParams_GetFrameCharset_11 = 11;
/*531*/
const int CefContextMenuParams_GetMediaType_12 = 12;
/*532*/
const int CefContextMenuParams_GetMediaStateFlags_13 = 13;
/*533*/
const int CefContextMenuParams_GetSelectionText_14 = 14;
/*534*/
const int CefContextMenuParams_GetMisspelledWord_15 = 15;
/*535*/
const int CefContextMenuParams_GetDictionarySuggestions_16 = 16;
/*536*/
const int CefContextMenuParams_IsEditable_17 = 17;
/*537*/
const int CefContextMenuParams_IsSpellCheckEnabled_18 = 18;
/*538*/
const int CefContextMenuParams_GetEditStateFlags_19 = 19;
/*539*/
const int CefContextMenuParams_IsCustomMenu_20 = 20;
/*540*/
const int CefContextMenuParams_IsPepperMenu_21 = 21;

/*542*/
void MyCefMet_CefContextMenuParams(cef_context_menu_params_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*543*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*544*/
	auto me = CefContextMenuParamsCToCpp::Wrap(me1);
	/*545*/
	switch (metName) {
		/*546*/
	case MET_Release:return; //yes, just return
							 /*547*/
	case CefContextMenuParams_GetXCoord_1: {
		/*548*/


		// gen! int GetXCoord()
		auto ret_result = me->GetXCoord();
		/*549*/
		MyCefSetInt64(ret, ret_result);
		/*550*/
	} break;
		/*551*/
	case CefContextMenuParams_GetYCoord_2: {
		/*552*/


		// gen! int GetYCoord()
		auto ret_result = me->GetYCoord();
		/*553*/
		MyCefSetInt64(ret, ret_result);
		/*554*/
	} break;
		/*555*/
	case CefContextMenuParams_GetTypeFlags_3: {
		/*556*/


		// gen! TypeFlags GetTypeFlags()
		auto ret_result = me->GetTypeFlags();
		/*557*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*558*/
	} break;
		/*559*/
	case CefContextMenuParams_GetLinkUrl_4: {
		/*560*/


		// gen! CefString GetLinkUrl()
		auto ret_result = me->GetLinkUrl();
		/*561*/
		SetCefStringToJsValue(ret, ret_result);
		/*562*/
	} break;
		/*563*/
	case CefContextMenuParams_GetUnfilteredLinkUrl_5: {
		/*564*/


		// gen! CefString GetUnfilteredLinkUrl()
		auto ret_result = me->GetUnfilteredLinkUrl();
		/*565*/
		SetCefStringToJsValue(ret, ret_result);
		/*566*/
	} break;
		/*567*/
	case CefContextMenuParams_GetSourceUrl_6: {
		/*568*/


		// gen! CefString GetSourceUrl()
		auto ret_result = me->GetSourceUrl();
		/*569*/
		SetCefStringToJsValue(ret, ret_result);
		/*570*/
	} break;
		/*571*/
	case CefContextMenuParams_HasImageContents_7: {
		/*572*/


		// gen! bool HasImageContents()
		auto ret_result = me->HasImageContents();
		/*573*/
		MyCefSetBool(ret, ret_result);
		/*574*/
	} break;
		/*575*/
	case CefContextMenuParams_GetTitleText_8: {
		/*576*/


		// gen! CefString GetTitleText()
		auto ret_result = me->GetTitleText();
		/*577*/
		SetCefStringToJsValue(ret, ret_result);
		/*578*/
	} break;
		/*579*/
	case CefContextMenuParams_GetPageUrl_9: {
		/*580*/


		// gen! CefString GetPageUrl()
		auto ret_result = me->GetPageUrl();
		/*581*/
		SetCefStringToJsValue(ret, ret_result);
		/*582*/
	} break;
		/*583*/
	case CefContextMenuParams_GetFrameUrl_10: {
		/*584*/


		// gen! CefString GetFrameUrl()
		auto ret_result = me->GetFrameUrl();
		/*585*/
		SetCefStringToJsValue(ret, ret_result);
		/*586*/
	} break;
		/*587*/
	case CefContextMenuParams_GetFrameCharset_11: {
		/*588*/


		// gen! CefString GetFrameCharset()
		auto ret_result = me->GetFrameCharset();
		/*589*/
		SetCefStringToJsValue(ret, ret_result);
		/*590*/
	} break;
		/*591*/
	case CefContextMenuParams_GetMediaType_12: {
		/*592*/


		// gen! MediaType GetMediaType()
		auto ret_result = me->GetMediaType();
		/*593*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*594*/
	} break;
		/*595*/
	case CefContextMenuParams_GetMediaStateFlags_13: {
		/*596*/


		// gen! MediaStateFlags GetMediaStateFlags()
		auto ret_result = me->GetMediaStateFlags();
		/*597*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*598*/
	} break;
		/*599*/
	case CefContextMenuParams_GetSelectionText_14: {
		/*600*/


		// gen! CefString GetSelectionText()
		auto ret_result = me->GetSelectionText();
		/*601*/
		SetCefStringToJsValue(ret, ret_result);
		/*602*/
	} break;
		/*603*/
	case CefContextMenuParams_GetMisspelledWord_15: {
		/*604*/


		// gen! CefString GetMisspelledWord()
		auto ret_result = me->GetMisspelledWord();
		/*605*/
		SetCefStringToJsValue(ret, ret_result);
		/*606*/
	} break;
		/*607*/
	case CefContextMenuParams_GetDictionarySuggestions_16: {
		/*608*/


		// gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
		auto ret_result = me->GetDictionarySuggestions(*((std::vector<CefString>*)v1->ptr));
		/*609*/
		MyCefSetBool(ret, ret_result);
		/*610*/
	} break;
		/*611*/
	case CefContextMenuParams_IsEditable_17: {
		/*612*/


		// gen! bool IsEditable()
		auto ret_result = me->IsEditable();
		/*613*/
		MyCefSetBool(ret, ret_result);
		/*614*/
	} break;
		/*615*/
	case CefContextMenuParams_IsSpellCheckEnabled_18: {
		/*616*/


		// gen! bool IsSpellCheckEnabled()
		auto ret_result = me->IsSpellCheckEnabled();
		/*617*/
		MyCefSetBool(ret, ret_result);
		/*618*/
	} break;
		/*619*/
	case CefContextMenuParams_GetEditStateFlags_19: {
		/*620*/


		// gen! EditStateFlags GetEditStateFlags()
		auto ret_result = me->GetEditStateFlags();
		/*621*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*622*/
	} break;
		/*623*/
	case CefContextMenuParams_IsCustomMenu_20: {
		/*624*/


		// gen! bool IsCustomMenu()
		auto ret_result = me->IsCustomMenu();
		/*625*/
		MyCefSetBool(ret, ret_result);
		/*626*/
	} break;
		/*627*/
	case CefContextMenuParams_IsPepperMenu_21: {
		/*628*/


		// gen! bool IsPepperMenu()
		auto ret_result = me->IsPepperMenu();
		/*629*/
		MyCefSetBool(ret, ret_result);
		/*630*/
	} break;
		/*631*/
	}
	/*632*/
	CefContextMenuParamsCToCpp::Unwrap(me);
	/*633*/
}


// [virtual] class CefCookieManager
/*641*/
/*634*/
const int CefCookieManager_SetSupportedSchemes_1 = 1;
/*635*/
const int CefCookieManager_VisitAllCookies_2 = 2;
/*636*/
const int CefCookieManager_VisitUrlCookies_3 = 3;
/*637*/
const int CefCookieManager_SetCookie_4 = 4;
/*638*/
const int CefCookieManager_DeleteCookies_5 = 5;
/*639*/
const int CefCookieManager_SetStoragePath_6 = 6;
/*640*/
const int CefCookieManager_FlushStore_7 = 7;

/*642*/
void MyCefMet_CefCookieManager(cef_cookie_manager_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*643*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*644*/
	auto me = CefCookieManagerCToCpp::Wrap(me1);
	/*645*/
	switch (metName) {
		/*646*/
	case MET_Release:return; //yes, just return
							 /*647*/
	case CefCookieManager_SetSupportedSchemes_1: {
		/*648*/


		// gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
		me->SetSupportedSchemes(*((std::vector<CefString>*)v1->ptr),
			CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v2->ptr));
		/*649*/

		/*650*/
	} break;
		/*651*/
	case CefCookieManager_VisitAllCookies_2: {
		/*652*/


		// gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
		auto ret_result = me->VisitAllCookies(CefCookieVisitorCppToC::Unwrap((cef_cookie_visitor_t*)v1->ptr));
		/*653*/
		MyCefSetBool(ret, ret_result);
		/*654*/
	} break;
		/*655*/
	case CefCookieManager_VisitUrlCookies_3: {
		/*656*/


		// gen! bool VisitUrlCookies(const CefString& url,bool includeHttpOnly,CefRefPtr<CefCookieVisitor> visitor)
		auto ret_result = me->VisitUrlCookies(GetStringHolder(v1)->value,
			v2->i32 != 0,
			CefCookieVisitorCppToC::Unwrap((cef_cookie_visitor_t*)v3->ptr));
		/*657*/
		MyCefSetBool(ret, ret_result);
		/*658*/
	} break;
		/*659*/
	case CefCookieManager_SetCookie_4: {
		/*660*/


		// gen! bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
		auto ret_result = me->SetCookie(GetStringHolder(v1)->value,
			*((CefCookie*)v2->ptr),
			CefSetCookieCallbackCppToC::Unwrap((cef_set_cookie_callback_t*)v3->ptr));
		/*661*/
		MyCefSetBool(ret, ret_result);
		/*662*/
	} break;
		/*663*/
	case CefCookieManager_DeleteCookies_5: {
		/*664*/


		// gen! bool DeleteCookies(const CefString& url,const CefString& cookie_name,CefRefPtr<CefDeleteCookiesCallback> callback)
		auto ret_result = me->DeleteCookies(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefDeleteCookiesCallbackCppToC::Unwrap((cef_delete_cookies_callback_t*)v3->ptr));
		/*665*/
		MyCefSetBool(ret, ret_result);
		/*666*/
	} break;
		/*667*/
	case CefCookieManager_SetStoragePath_6: {
		/*668*/


		// gen! bool SetStoragePath(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->SetStoragePath(GetStringHolder(v1)->value,
			v2->i32 != 0,
			CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v3->ptr));
		/*669*/
		MyCefSetBool(ret, ret_result);
		/*670*/
	} break;
		/*671*/
	case CefCookieManager_FlushStore_7: {
		/*672*/


		// gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->FlushStore(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*673*/
		MyCefSetBool(ret, ret_result);
		/*674*/
	} break;
		/*675*/
	}
	/*676*/
	CefCookieManagerCToCpp::Unwrap(me);
	/*677*/
}


// [virtual] class CefCookieVisitor
/*678*/

/*679*/
void MyCefMet_CefCookieVisitor(cef_cookie_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*680*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*681*/
	auto me = CefCookieVisitorCppToC::Unwrap(me1);
	/*682*/
	switch (metName) {
		/*683*/
	case MET_Release:return; //yes, just return
							 /*684*/
	}
	/*685*/
	CefCookieVisitorCppToC::Wrap(me);
	/*686*/
}


// [virtual] class CefDOMVisitor
/*687*/

/*688*/
void MyCefMet_CefDOMVisitor(cef_domvisitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*689*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*690*/
	auto me = CefDOMVisitorCppToC::Unwrap(me1);
	/*691*/
	switch (metName) {
		/*692*/
	case MET_Release:return; //yes, just return
							 /*693*/
	}
	/*694*/
	CefDOMVisitorCppToC::Wrap(me);
	/*695*/
}


// [virtual] class CefDOMDocument
/*710*/
/*696*/
const int CefDOMDocument_GetType_1 = 1;
/*697*/
const int CefDOMDocument_GetDocument_2 = 2;
/*698*/
const int CefDOMDocument_GetBody_3 = 3;
/*699*/
const int CefDOMDocument_GetHead_4 = 4;
/*700*/
const int CefDOMDocument_GetTitle_5 = 5;
/*701*/
const int CefDOMDocument_GetElementById_6 = 6;
/*702*/
const int CefDOMDocument_GetFocusedNode_7 = 7;
/*703*/
const int CefDOMDocument_HasSelection_8 = 8;
/*704*/
const int CefDOMDocument_GetSelectionStartOffset_9 = 9;
/*705*/
const int CefDOMDocument_GetSelectionEndOffset_10 = 10;
/*706*/
const int CefDOMDocument_GetSelectionAsMarkup_11 = 11;
/*707*/
const int CefDOMDocument_GetSelectionAsText_12 = 12;
/*708*/
const int CefDOMDocument_GetBaseURL_13 = 13;
/*709*/
const int CefDOMDocument_GetCompleteURL_14 = 14;

/*711*/
void MyCefMet_CefDOMDocument(cef_domdocument_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*712*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*713*/
	auto me = CefDOMDocumentCToCpp::Wrap(me1);
	/*714*/
	switch (metName) {
		/*715*/
	case MET_Release:return; //yes, just return
							 /*716*/
	case CefDOMDocument_GetType_1: {
		/*717*/


		// gen! Type GetType()
		auto ret_result = me->GetType();
		/*718*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*719*/
	} break;
		/*720*/
	case CefDOMDocument_GetDocument_2: {
		/*721*/


		// gen! CefRefPtr<CefDOMNode> GetDocument()
		auto ret_result = me->GetDocument();
		/*722*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*723*/
	} break;
		/*724*/
	case CefDOMDocument_GetBody_3: {
		/*725*/


		// gen! CefRefPtr<CefDOMNode> GetBody()
		auto ret_result = me->GetBody();
		/*726*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*727*/
	} break;
		/*728*/
	case CefDOMDocument_GetHead_4: {
		/*729*/


		// gen! CefRefPtr<CefDOMNode> GetHead()
		auto ret_result = me->GetHead();
		/*730*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*731*/
	} break;
		/*732*/
	case CefDOMDocument_GetTitle_5: {
		/*733*/


		// gen! CefString GetTitle()
		auto ret_result = me->GetTitle();
		/*734*/
		SetCefStringToJsValue(ret, ret_result);
		/*735*/
	} break;
		/*736*/
	case CefDOMDocument_GetElementById_6: {
		/*737*/


		// gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
		auto ret_result = me->GetElementById(GetStringHolder(v1)->value);
		/*738*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*739*/
	} break;
		/*740*/
	case CefDOMDocument_GetFocusedNode_7: {
		/*741*/


		// gen! CefRefPtr<CefDOMNode> GetFocusedNode()
		auto ret_result = me->GetFocusedNode();
		/*742*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*743*/
	} break;
		/*744*/
	case CefDOMDocument_HasSelection_8: {
		/*745*/


		// gen! bool HasSelection()
		auto ret_result = me->HasSelection();
		/*746*/
		MyCefSetBool(ret, ret_result);
		/*747*/
	} break;
		/*748*/
	case CefDOMDocument_GetSelectionStartOffset_9: {
		/*749*/


		// gen! int GetSelectionStartOffset()
		auto ret_result = me->GetSelectionStartOffset();
		/*750*/
		MyCefSetInt64(ret, ret_result);
		/*751*/
	} break;
		/*752*/
	case CefDOMDocument_GetSelectionEndOffset_10: {
		/*753*/


		// gen! int GetSelectionEndOffset()
		auto ret_result = me->GetSelectionEndOffset();
		/*754*/
		MyCefSetInt64(ret, ret_result);
		/*755*/
	} break;
		/*756*/
	case CefDOMDocument_GetSelectionAsMarkup_11: {
		/*757*/


		// gen! CefString GetSelectionAsMarkup()
		auto ret_result = me->GetSelectionAsMarkup();
		/*758*/
		SetCefStringToJsValue(ret, ret_result);
		/*759*/
	} break;
		/*760*/
	case CefDOMDocument_GetSelectionAsText_12: {
		/*761*/


		// gen! CefString GetSelectionAsText()
		auto ret_result = me->GetSelectionAsText();
		/*762*/
		SetCefStringToJsValue(ret, ret_result);
		/*763*/
	} break;
		/*764*/
	case CefDOMDocument_GetBaseURL_13: {
		/*765*/


		// gen! CefString GetBaseURL()
		auto ret_result = me->GetBaseURL();
		/*766*/
		SetCefStringToJsValue(ret, ret_result);
		/*767*/
	} break;
		/*768*/
	case CefDOMDocument_GetCompleteURL_14: {
		/*769*/


		// gen! CefString GetCompleteURL(const CefString& partialURL)
		auto ret_result = me->GetCompleteURL(GetStringHolder(v1)->value);
		/*770*/
		SetCefStringToJsValue(ret, ret_result);
		/*771*/
	} break;
		/*772*/
	}
	/*773*/
	CefDOMDocumentCToCpp::Unwrap(me);
	/*774*/
}


// [virtual] class CefDOMNode
/*801*/
/*775*/
const int CefDOMNode_GetType_1 = 1;
/*776*/
const int CefDOMNode_IsText_2 = 2;
/*777*/
const int CefDOMNode_IsElement_3 = 3;
/*778*/
const int CefDOMNode_IsEditable_4 = 4;
/*779*/
const int CefDOMNode_IsFormControlElement_5 = 5;
/*780*/
const int CefDOMNode_GetFormControlElementType_6 = 6;
/*781*/
const int CefDOMNode_IsSame_7 = 7;
/*782*/
const int CefDOMNode_GetName_8 = 8;
/*783*/
const int CefDOMNode_GetValue_9 = 9;
/*784*/
const int CefDOMNode_SetValue_10 = 10;
/*785*/
const int CefDOMNode_GetAsMarkup_11 = 11;
/*786*/
const int CefDOMNode_GetDocument_12 = 12;
/*787*/
const int CefDOMNode_GetParent_13 = 13;
/*788*/
const int CefDOMNode_GetPreviousSibling_14 = 14;
/*789*/
const int CefDOMNode_GetNextSibling_15 = 15;
/*790*/
const int CefDOMNode_HasChildren_16 = 16;
/*791*/
const int CefDOMNode_GetFirstChild_17 = 17;
/*792*/
const int CefDOMNode_GetLastChild_18 = 18;
/*793*/
const int CefDOMNode_GetElementTagName_19 = 19;
/*794*/
const int CefDOMNode_HasElementAttributes_20 = 20;
/*795*/
const int CefDOMNode_HasElementAttribute_21 = 21;
/*796*/
const int CefDOMNode_GetElementAttribute_22 = 22;
/*797*/
const int CefDOMNode_GetElementAttributes_23 = 23;
/*798*/
const int CefDOMNode_SetElementAttribute_24 = 24;
/*799*/
const int CefDOMNode_GetElementInnerText_25 = 25;
/*800*/
const int CefDOMNode_GetElementBounds_26 = 26;

/*802*/
void MyCefMet_CefDOMNode(cef_domnode_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*803*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*804*/
	auto me = CefDOMNodeCToCpp::Wrap(me1);
	/*805*/
	switch (metName) {
		/*806*/
	case MET_Release:return; //yes, just return
							 /*807*/
	case CefDOMNode_GetType_1: {
		/*808*/


		// gen! Type GetType()
		auto ret_result = me->GetType();
		/*809*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*810*/
	} break;
		/*811*/
	case CefDOMNode_IsText_2: {
		/*812*/


		// gen! bool IsText()
		auto ret_result = me->IsText();
		/*813*/
		MyCefSetBool(ret, ret_result);
		/*814*/
	} break;
		/*815*/
	case CefDOMNode_IsElement_3: {
		/*816*/


		// gen! bool IsElement()
		auto ret_result = me->IsElement();
		/*817*/
		MyCefSetBool(ret, ret_result);
		/*818*/
	} break;
		/*819*/
	case CefDOMNode_IsEditable_4: {
		/*820*/


		// gen! bool IsEditable()
		auto ret_result = me->IsEditable();
		/*821*/
		MyCefSetBool(ret, ret_result);
		/*822*/
	} break;
		/*823*/
	case CefDOMNode_IsFormControlElement_5: {
		/*824*/


		// gen! bool IsFormControlElement()
		auto ret_result = me->IsFormControlElement();
		/*825*/
		MyCefSetBool(ret, ret_result);
		/*826*/
	} break;
		/*827*/
	case CefDOMNode_GetFormControlElementType_6: {
		/*828*/


		// gen! CefString GetFormControlElementType()
		auto ret_result = me->GetFormControlElementType();
		/*829*/
		SetCefStringToJsValue(ret, ret_result);
		/*830*/
	} break;
		/*831*/
	case CefDOMNode_IsSame_7: {
		/*832*/


		// gen! bool IsSame(CefRefPtr<CefDOMNode> that)
		auto ret_result = me->IsSame(CefDOMNodeCToCpp::Wrap((cef_domnode_t*)v1->ptr));
		/*833*/
		MyCefSetBool(ret, ret_result);
		/*834*/
	} break;
		/*835*/
	case CefDOMNode_GetName_8: {
		/*836*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*837*/
		SetCefStringToJsValue(ret, ret_result);
		/*838*/
	} break;
		/*839*/
	case CefDOMNode_GetValue_9: {
		/*840*/


		// gen! CefString GetValue()
		auto ret_result = me->GetValue();
		/*841*/
		SetCefStringToJsValue(ret, ret_result);
		/*842*/
	} break;
		/*843*/
	case CefDOMNode_SetValue_10: {
		/*844*/


		// gen! bool SetValue(const CefString& value)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value);
		/*845*/
		MyCefSetBool(ret, ret_result);
		/*846*/
	} break;
		/*847*/
	case CefDOMNode_GetAsMarkup_11: {
		/*848*/


		// gen! CefString GetAsMarkup()
		auto ret_result = me->GetAsMarkup();
		/*849*/
		SetCefStringToJsValue(ret, ret_result);
		/*850*/
	} break;
		/*851*/
	case CefDOMNode_GetDocument_12: {
		/*852*/


		// gen! CefRefPtr<CefDOMDocument> GetDocument()
		auto ret_result = me->GetDocument();
		/*853*/
		MyCefSetVoidPtr(ret, CefDOMDocumentCToCpp::Unwrap(ret_result));
		/*854*/
	} break;
		/*855*/
	case CefDOMNode_GetParent_13: {
		/*856*/


		// gen! CefRefPtr<CefDOMNode> GetParent()
		auto ret_result = me->GetParent();
		/*857*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*858*/
	} break;
		/*859*/
	case CefDOMNode_GetPreviousSibling_14: {
		/*860*/


		// gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
		auto ret_result = me->GetPreviousSibling();
		/*861*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*862*/
	} break;
		/*863*/
	case CefDOMNode_GetNextSibling_15: {
		/*864*/


		// gen! CefRefPtr<CefDOMNode> GetNextSibling()
		auto ret_result = me->GetNextSibling();
		/*865*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*866*/
	} break;
		/*867*/
	case CefDOMNode_HasChildren_16: {
		/*868*/


		// gen! bool HasChildren()
		auto ret_result = me->HasChildren();
		/*869*/
		MyCefSetBool(ret, ret_result);
		/*870*/
	} break;
		/*871*/
	case CefDOMNode_GetFirstChild_17: {
		/*872*/


		// gen! CefRefPtr<CefDOMNode> GetFirstChild()
		auto ret_result = me->GetFirstChild();
		/*873*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*874*/
	} break;
		/*875*/
	case CefDOMNode_GetLastChild_18: {
		/*876*/


		// gen! CefRefPtr<CefDOMNode> GetLastChild()
		auto ret_result = me->GetLastChild();
		/*877*/
		MyCefSetVoidPtr(ret, CefDOMNodeCToCpp::Unwrap(ret_result));
		/*878*/
	} break;
		/*879*/
	case CefDOMNode_GetElementTagName_19: {
		/*880*/


		// gen! CefString GetElementTagName()
		auto ret_result = me->GetElementTagName();
		/*881*/
		SetCefStringToJsValue(ret, ret_result);
		/*882*/
	} break;
		/*883*/
	case CefDOMNode_HasElementAttributes_20: {
		/*884*/


		// gen! bool HasElementAttributes()
		auto ret_result = me->HasElementAttributes();
		/*885*/
		MyCefSetBool(ret, ret_result);
		/*886*/
	} break;
		/*887*/
	case CefDOMNode_HasElementAttribute_21: {
		/*888*/


		// gen! bool HasElementAttribute(const CefString& attrName)
		auto ret_result = me->HasElementAttribute(GetStringHolder(v1)->value);
		/*889*/
		MyCefSetBool(ret, ret_result);
		/*890*/
	} break;
		/*891*/
	case CefDOMNode_GetElementAttribute_22: {
		/*892*/


		// gen! CefString GetElementAttribute(const CefString& attrName)
		auto ret_result = me->GetElementAttribute(GetStringHolder(v1)->value);
		/*893*/
		SetCefStringToJsValue(ret, ret_result);
		/*894*/
	} break;
		/*895*/
	case CefDOMNode_GetElementAttributes_23: {
		/*896*/


		// gen! void GetElementAttributes(AttributeMap& attrMap)
		me->GetElementAttributes(*((CefDOMNode::AttributeMap*)v1->ptr));
		/*897*/

		/*898*/
	} break;
		/*899*/
	case CefDOMNode_SetElementAttribute_24: {
		/*900*/


		// gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
		auto ret_result = me->SetElementAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*901*/
		MyCefSetBool(ret, ret_result);
		/*902*/
	} break;
		/*903*/
	case CefDOMNode_GetElementInnerText_25: {
		/*904*/


		// gen! CefString GetElementInnerText()
		auto ret_result = me->GetElementInnerText();
		/*905*/
		SetCefStringToJsValue(ret, ret_result);
		/*906*/
	} break;
		/*907*/
	case CefDOMNode_GetElementBounds_26: {
		/*908*/


		// gen! CefRect GetElementBounds()
		auto ret_result = me->GetElementBounds();
		/*909*/
		CefRect* tmp_d1 = new CefRect(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*910*/
	} break;
		/*911*/
	}
	/*912*/
	CefDOMNodeCToCpp::Unwrap(me);
	/*913*/
}


// [virtual] class CefDownloadItem
/*931*/
/*914*/
const int CefDownloadItem_IsValid_1 = 1;
/*915*/
const int CefDownloadItem_IsInProgress_2 = 2;
/*916*/
const int CefDownloadItem_IsComplete_3 = 3;
/*917*/
const int CefDownloadItem_IsCanceled_4 = 4;
/*918*/
const int CefDownloadItem_GetCurrentSpeed_5 = 5;
/*919*/
const int CefDownloadItem_GetPercentComplete_6 = 6;
/*920*/
const int CefDownloadItem_GetTotalBytes_7 = 7;
/*921*/
const int CefDownloadItem_GetReceivedBytes_8 = 8;
/*922*/
const int CefDownloadItem_GetStartTime_9 = 9;
/*923*/
const int CefDownloadItem_GetEndTime_10 = 10;
/*924*/
const int CefDownloadItem_GetFullPath_11 = 11;
/*925*/
const int CefDownloadItem_GetId_12 = 12;
/*926*/
const int CefDownloadItem_GetURL_13 = 13;
/*927*/
const int CefDownloadItem_GetOriginalUrl_14 = 14;
/*928*/
const int CefDownloadItem_GetSuggestedFileName_15 = 15;
/*929*/
const int CefDownloadItem_GetContentDisposition_16 = 16;
/*930*/
const int CefDownloadItem_GetMimeType_17 = 17;

/*932*/
void MyCefMet_CefDownloadItem(cef_download_item_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*933*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*934*/
	auto me = CefDownloadItemCToCpp::Wrap(me1);
	/*935*/
	switch (metName) {
		/*936*/
	case MET_Release:return; //yes, just return
							 /*937*/
	case CefDownloadItem_IsValid_1: {
		/*938*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*939*/
		MyCefSetBool(ret, ret_result);
		/*940*/
	} break;
		/*941*/
	case CefDownloadItem_IsInProgress_2: {
		/*942*/


		// gen! bool IsInProgress()
		auto ret_result = me->IsInProgress();
		/*943*/
		MyCefSetBool(ret, ret_result);
		/*944*/
	} break;
		/*945*/
	case CefDownloadItem_IsComplete_3: {
		/*946*/


		// gen! bool IsComplete()
		auto ret_result = me->IsComplete();
		/*947*/
		MyCefSetBool(ret, ret_result);
		/*948*/
	} break;
		/*949*/
	case CefDownloadItem_IsCanceled_4: {
		/*950*/


		// gen! bool IsCanceled()
		auto ret_result = me->IsCanceled();
		/*951*/
		MyCefSetBool(ret, ret_result);
		/*952*/
	} break;
		/*953*/
	case CefDownloadItem_GetCurrentSpeed_5: {
		/*954*/


		// gen! int64 GetCurrentSpeed()
		auto ret_result = me->GetCurrentSpeed();
		/*955*/
		MyCefSetInt64(ret, ret_result);
		/*956*/
	} break;
		/*957*/
	case CefDownloadItem_GetPercentComplete_6: {
		/*958*/


		// gen! int GetPercentComplete()
		auto ret_result = me->GetPercentComplete();
		/*959*/
		MyCefSetInt64(ret, ret_result);
		/*960*/
	} break;
		/*961*/
	case CefDownloadItem_GetTotalBytes_7: {
		/*962*/


		// gen! int64 GetTotalBytes()
		auto ret_result = me->GetTotalBytes();
		/*963*/
		MyCefSetInt64(ret, ret_result);
		/*964*/
	} break;
		/*965*/
	case CefDownloadItem_GetReceivedBytes_8: {
		/*966*/


		// gen! int64 GetReceivedBytes()
		auto ret_result = me->GetReceivedBytes();
		/*967*/
		MyCefSetInt64(ret, ret_result);
		/*968*/
	} break;
		/*969*/
	case CefDownloadItem_GetStartTime_9: {
		/*970*/


		// gen! CefTime GetStartTime()
		auto ret_result = me->GetStartTime();
		/*971*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*972*/
	} break;
		/*973*/
	case CefDownloadItem_GetEndTime_10: {
		/*974*/


		// gen! CefTime GetEndTime()
		auto ret_result = me->GetEndTime();
		/*975*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*976*/
	} break;
		/*977*/
	case CefDownloadItem_GetFullPath_11: {
		/*978*/


		// gen! CefString GetFullPath()
		auto ret_result = me->GetFullPath();
		/*979*/
		SetCefStringToJsValue(ret, ret_result);
		/*980*/
	} break;
		/*981*/
	case CefDownloadItem_GetId_12: {
		/*982*/


		// gen! uint32 GetId()
		auto ret_result = me->GetId();
		/*983*/
		MyCefSetUInt32(ret, ret_result);
		/*984*/
	} break;
		/*985*/
	case CefDownloadItem_GetURL_13: {
		/*986*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*987*/
		SetCefStringToJsValue(ret, ret_result);
		/*988*/
	} break;
		/*989*/
	case CefDownloadItem_GetOriginalUrl_14: {
		/*990*/


		// gen! CefString GetOriginalUrl()
		auto ret_result = me->GetOriginalUrl();
		/*991*/
		SetCefStringToJsValue(ret, ret_result);
		/*992*/
	} break;
		/*993*/
	case CefDownloadItem_GetSuggestedFileName_15: {
		/*994*/


		// gen! CefString GetSuggestedFileName()
		auto ret_result = me->GetSuggestedFileName();
		/*995*/
		SetCefStringToJsValue(ret, ret_result);
		/*996*/
	} break;
		/*997*/
	case CefDownloadItem_GetContentDisposition_16: {
		/*998*/


		// gen! CefString GetContentDisposition()
		auto ret_result = me->GetContentDisposition();
		/*999*/
		SetCefStringToJsValue(ret, ret_result);
		/*1000*/
	} break;
		/*1001*/
	case CefDownloadItem_GetMimeType_17: {
		/*1002*/


		// gen! CefString GetMimeType()
		auto ret_result = me->GetMimeType();
		/*1003*/
		SetCefStringToJsValue(ret, ret_result);
		/*1004*/
	} break;
		/*1005*/
	}
	/*1006*/
	CefDownloadItemCToCpp::Unwrap(me);
	/*1007*/
}


// [virtual] class CefDragData
/*1033*/
/*1008*/
const int CefDragData_Clone_1 = 1;
/*1009*/
const int CefDragData_IsReadOnly_2 = 2;
/*1010*/
const int CefDragData_IsLink_3 = 3;
/*1011*/
const int CefDragData_IsFragment_4 = 4;
/*1012*/
const int CefDragData_IsFile_5 = 5;
/*1013*/
const int CefDragData_GetLinkURL_6 = 6;
/*1014*/
const int CefDragData_GetLinkTitle_7 = 7;
/*1015*/
const int CefDragData_GetLinkMetadata_8 = 8;
/*1016*/
const int CefDragData_GetFragmentText_9 = 9;
/*1017*/
const int CefDragData_GetFragmentHtml_10 = 10;
/*1018*/
const int CefDragData_GetFragmentBaseURL_11 = 11;
/*1019*/
const int CefDragData_GetFileName_12 = 12;
/*1020*/
const int CefDragData_GetFileContents_13 = 13;
/*1021*/
const int CefDragData_GetFileNames_14 = 14;
/*1022*/
const int CefDragData_SetLinkURL_15 = 15;
/*1023*/
const int CefDragData_SetLinkTitle_16 = 16;
/*1024*/
const int CefDragData_SetLinkMetadata_17 = 17;
/*1025*/
const int CefDragData_SetFragmentText_18 = 18;
/*1026*/
const int CefDragData_SetFragmentHtml_19 = 19;
/*1027*/
const int CefDragData_SetFragmentBaseURL_20 = 20;
/*1028*/
const int CefDragData_ResetFileContents_21 = 21;
/*1029*/
const int CefDragData_AddFile_22 = 22;
/*1030*/
const int CefDragData_GetImage_23 = 23;
/*1031*/
const int CefDragData_GetImageHotspot_24 = 24;
/*1032*/
const int CefDragData_HasImage_25 = 25;

/*1034*/
void MyCefMet_CefDragData(cef_drag_data_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1035*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1036*/
	auto me = CefDragDataCToCpp::Wrap(me1);
	/*1037*/
	switch (metName) {
		/*1038*/
	case MET_Release:return; //yes, just return
							 /*1039*/
	case CefDragData_Clone_1: {
		/*1040*/


		// gen! CefRefPtr<CefDragData> Clone()
		auto ret_result = me->Clone();
		/*1041*/
		MyCefSetVoidPtr(ret, CefDragDataCToCpp::Unwrap(ret_result));
		/*1042*/
	} break;
		/*1043*/
	case CefDragData_IsReadOnly_2: {
		/*1044*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*1045*/
		MyCefSetBool(ret, ret_result);
		/*1046*/
	} break;
		/*1047*/
	case CefDragData_IsLink_3: {
		/*1048*/


		// gen! bool IsLink()
		auto ret_result = me->IsLink();
		/*1049*/
		MyCefSetBool(ret, ret_result);
		/*1050*/
	} break;
		/*1051*/
	case CefDragData_IsFragment_4: {
		/*1052*/


		// gen! bool IsFragment()
		auto ret_result = me->IsFragment();
		/*1053*/
		MyCefSetBool(ret, ret_result);
		/*1054*/
	} break;
		/*1055*/
	case CefDragData_IsFile_5: {
		/*1056*/


		// gen! bool IsFile()
		auto ret_result = me->IsFile();
		/*1057*/
		MyCefSetBool(ret, ret_result);
		/*1058*/
	} break;
		/*1059*/
	case CefDragData_GetLinkURL_6: {
		/*1060*/


		// gen! CefString GetLinkURL()
		auto ret_result = me->GetLinkURL();
		/*1061*/
		SetCefStringToJsValue(ret, ret_result);
		/*1062*/
	} break;
		/*1063*/
	case CefDragData_GetLinkTitle_7: {
		/*1064*/


		// gen! CefString GetLinkTitle()
		auto ret_result = me->GetLinkTitle();
		/*1065*/
		SetCefStringToJsValue(ret, ret_result);
		/*1066*/
	} break;
		/*1067*/
	case CefDragData_GetLinkMetadata_8: {
		/*1068*/


		// gen! CefString GetLinkMetadata()
		auto ret_result = me->GetLinkMetadata();
		/*1069*/
		SetCefStringToJsValue(ret, ret_result);
		/*1070*/
	} break;
		/*1071*/
	case CefDragData_GetFragmentText_9: {
		/*1072*/


		// gen! CefString GetFragmentText()
		auto ret_result = me->GetFragmentText();
		/*1073*/
		SetCefStringToJsValue(ret, ret_result);
		/*1074*/
	} break;
		/*1075*/
	case CefDragData_GetFragmentHtml_10: {
		/*1076*/


		// gen! CefString GetFragmentHtml()
		auto ret_result = me->GetFragmentHtml();
		/*1077*/
		SetCefStringToJsValue(ret, ret_result);
		/*1078*/
	} break;
		/*1079*/
	case CefDragData_GetFragmentBaseURL_11: {
		/*1080*/


		// gen! CefString GetFragmentBaseURL()
		auto ret_result = me->GetFragmentBaseURL();
		/*1081*/
		SetCefStringToJsValue(ret, ret_result);
		/*1082*/
	} break;
		/*1083*/
	case CefDragData_GetFileName_12: {
		/*1084*/


		// gen! CefString GetFileName()
		auto ret_result = me->GetFileName();
		/*1085*/
		SetCefStringToJsValue(ret, ret_result);
		/*1086*/
	} break;
		/*1087*/
	case CefDragData_GetFileContents_13: {
		/*1088*/


		// gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
		auto ret_result = me->GetFileContents(CefStreamWriterCToCpp::Wrap((cef_stream_writer_t*)v1->ptr));
		/*1089*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1090*/
	} break;
		/*1091*/
	case CefDragData_GetFileNames_14: {
		/*1092*/


		// gen! bool GetFileNames(std::vector<CefString>& names)
		auto ret_result = me->GetFileNames(*((std::vector<CefString>*)v1->ptr));
		/*1093*/
		MyCefSetBool(ret, ret_result);
		/*1094*/
	} break;
		/*1095*/
	case CefDragData_SetLinkURL_15: {
		/*1096*/


		// gen! void SetLinkURL(const CefString& url)
		me->SetLinkURL(GetStringHolder(v1)->value);
		/*1097*/

		/*1098*/
	} break;
		/*1099*/
	case CefDragData_SetLinkTitle_16: {
		/*1100*/


		// gen! void SetLinkTitle(const CefString& title)
		me->SetLinkTitle(GetStringHolder(v1)->value);
		/*1101*/

		/*1102*/
	} break;
		/*1103*/
	case CefDragData_SetLinkMetadata_17: {
		/*1104*/


		// gen! void SetLinkMetadata(const CefString& data)
		me->SetLinkMetadata(GetStringHolder(v1)->value);
		/*1105*/

		/*1106*/
	} break;
		/*1107*/
	case CefDragData_SetFragmentText_18: {
		/*1108*/


		// gen! void SetFragmentText(const CefString& text)
		me->SetFragmentText(GetStringHolder(v1)->value);
		/*1109*/

		/*1110*/
	} break;
		/*1111*/
	case CefDragData_SetFragmentHtml_19: {
		/*1112*/


		// gen! void SetFragmentHtml(const CefString& html)
		me->SetFragmentHtml(GetStringHolder(v1)->value);
		/*1113*/

		/*1114*/
	} break;
		/*1115*/
	case CefDragData_SetFragmentBaseURL_20: {
		/*1116*/


		// gen! void SetFragmentBaseURL(const CefString& base_url)
		me->SetFragmentBaseURL(GetStringHolder(v1)->value);
		/*1117*/

		/*1118*/
	} break;
		/*1119*/
	case CefDragData_ResetFileContents_21: {
		/*1120*/


		// gen! void ResetFileContents()
		me->ResetFileContents();
		/*1121*/

		/*1122*/
	} break;
		/*1123*/
	case CefDragData_AddFile_22: {
		/*1124*/


		// gen! void AddFile(const CefString& path,const CefString& display_name)
		me->AddFile(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*1125*/

		/*1126*/
	} break;
		/*1127*/
	case CefDragData_GetImage_23: {
		/*1128*/


		// gen! CefRefPtr<CefImage> GetImage()
		auto ret_result = me->GetImage();
		/*1129*/
		MyCefSetVoidPtr(ret, CefImageCToCpp::Unwrap(ret_result));
		/*1130*/
	} break;
		/*1131*/
	case CefDragData_GetImageHotspot_24: {
		/*1132*/


		// gen! CefPoint GetImageHotspot()
		auto ret_result = me->GetImageHotspot();
		/*1133*/
		CefPoint* tmp_d1 = new CefPoint(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*1134*/
	} break;
		/*1135*/
	case CefDragData_HasImage_25: {
		/*1136*/


		// gen! bool HasImage()
		auto ret_result = me->HasImage();
		/*1137*/
		MyCefSetBool(ret, ret_result);
		/*1138*/
	} break;
		/*1139*/
	}
	/*1140*/
	CefDragDataCToCpp::Unwrap(me);
	/*1141*/
}


// [virtual] class CefFrame
/*1166*/
/*1142*/
const int CefFrame_IsValid_1 = 1;
/*1143*/
const int CefFrame_Undo_2 = 2;
/*1144*/
const int CefFrame_Redo_3 = 3;
/*1145*/
const int CefFrame_Cut_4 = 4;
/*1146*/
const int CefFrame_Copy_5 = 5;
/*1147*/
const int CefFrame_Paste_6 = 6;
/*1148*/
const int CefFrame_Delete_7 = 7;
/*1149*/
const int CefFrame_SelectAll_8 = 8;
/*1150*/
const int CefFrame_ViewSource_9 = 9;
/*1151*/
const int CefFrame_GetSource_10 = 10;
/*1152*/
const int CefFrame_GetText_11 = 11;
/*1153*/
const int CefFrame_LoadRequest_12 = 12;
/*1154*/
const int CefFrame_LoadURL_13 = 13;
/*1155*/
const int CefFrame_LoadString_14 = 14;
/*1156*/
const int CefFrame_ExecuteJavaScript_15 = 15;
/*1157*/
const int CefFrame_IsMain_16 = 16;
/*1158*/
const int CefFrame_IsFocused_17 = 17;
/*1159*/
const int CefFrame_GetName_18 = 18;
/*1160*/
const int CefFrame_GetIdentifier_19 = 19;
/*1161*/
const int CefFrame_GetParent_20 = 20;
/*1162*/
const int CefFrame_GetURL_21 = 21;
/*1163*/
const int CefFrame_GetBrowser_22 = 22;
/*1164*/
const int CefFrame_GetV8Context_23 = 23;
/*1165*/
const int CefFrame_VisitDOM_24 = 24;

/*1167*/
void MyCefMet_CefFrame(cef_frame_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1168*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1169*/
	auto me = CefFrameCToCpp::Wrap(me1);
	/*1170*/
	switch (metName) {
		/*1171*/
	case MET_Release:return; //yes, just return
							 /*1172*/
	case CefFrame_IsValid_1: {
		/*1173*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*1174*/
		MyCefSetBool(ret, ret_result);
		/*1175*/
	} break;
		/*1176*/
	case CefFrame_Undo_2: {
		/*1177*/


		// gen! void Undo()
		me->Undo();
		/*1178*/

		/*1179*/
	} break;
		/*1180*/
	case CefFrame_Redo_3: {
		/*1181*/


		// gen! void Redo()
		me->Redo();
		/*1182*/

		/*1183*/
	} break;
		/*1184*/
	case CefFrame_Cut_4: {
		/*1185*/


		// gen! void Cut()
		me->Cut();
		/*1186*/

		/*1187*/
	} break;
		/*1188*/
	case CefFrame_Copy_5: {
		/*1189*/


		// gen! void Copy()
		me->Copy();
		/*1190*/

		/*1191*/
	} break;
		/*1192*/
	case CefFrame_Paste_6: {
		/*1193*/


		// gen! void Paste()
		me->Paste();
		/*1194*/

		/*1195*/
	} break;
		/*1196*/
	case CefFrame_Delete_7: {
		/*1197*/


		// gen! void Delete()
		me->Delete();
		/*1198*/

		/*1199*/
	} break;
		/*1200*/
	case CefFrame_SelectAll_8: {
		/*1201*/


		// gen! void SelectAll()
		me->SelectAll();
		/*1202*/

		/*1203*/
	} break;
		/*1204*/
	case CefFrame_ViewSource_9: {
		/*1205*/


		// gen! void ViewSource()
		me->ViewSource();
		/*1206*/

		/*1207*/
	} break;
		/*1208*/
	case CefFrame_GetSource_10: {
		/*1209*/


		// gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
		me->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		/*1210*/

		/*1211*/
	} break;
		/*1212*/
	case CefFrame_GetText_11: {
		/*1213*/


		// gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
		me->GetText(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		/*1214*/

		/*1215*/
	} break;
		/*1216*/
	case CefFrame_LoadRequest_12: {
		/*1217*/


		// gen! void LoadRequest(CefRefPtr<CefRequest> request)
		me->LoadRequest(CefRequestCToCpp::Wrap((cef_request_t*)v1->ptr));
		/*1218*/

		/*1219*/
	} break;
		/*1220*/
	case CefFrame_LoadURL_13: {
		/*1221*/


		// gen! void LoadURL(const CefString& url)
		me->LoadURL(GetStringHolder(v1)->value);
		/*1222*/

		/*1223*/
	} break;
		/*1224*/
	case CefFrame_LoadString_14: {
		/*1225*/


		// gen! void LoadString(const CefString& string_val,const CefString& url)
		me->LoadString(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*1226*/

		/*1227*/
	} break;
		/*1228*/
	case CefFrame_ExecuteJavaScript_15: {
		/*1229*/


		// gen! void ExecuteJavaScript(const CefString& code,const CefString& script_url,int start_line)
		me->ExecuteJavaScript(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			v3->i32);
		/*1230*/

		/*1231*/
	} break;
		/*1232*/
	case CefFrame_IsMain_16: {
		/*1233*/


		// gen! bool IsMain()
		auto ret_result = me->IsMain();
		/*1234*/
		MyCefSetBool(ret, ret_result);
		/*1235*/
	} break;
		/*1236*/
	case CefFrame_IsFocused_17: {
		/*1237*/


		// gen! bool IsFocused()
		auto ret_result = me->IsFocused();
		/*1238*/
		MyCefSetBool(ret, ret_result);
		/*1239*/
	} break;
		/*1240*/
	case CefFrame_GetName_18: {
		/*1241*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*1242*/
		SetCefStringToJsValue(ret, ret_result);
		/*1243*/
	} break;
		/*1244*/
	case CefFrame_GetIdentifier_19: {
		/*1245*/


		// gen! int64 GetIdentifier()
		auto ret_result = me->GetIdentifier();
		/*1246*/
		MyCefSetInt64(ret, ret_result);
		/*1247*/
	} break;
		/*1248*/
	case CefFrame_GetParent_20: {
		/*1249*/


		// gen! CefRefPtr<CefFrame> GetParent()
		auto ret_result = me->GetParent();
		/*1250*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*1251*/
	} break;
		/*1252*/
	case CefFrame_GetURL_21: {
		/*1253*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*1254*/
		SetCefStringToJsValue(ret, ret_result);
		/*1255*/
	} break;
		/*1256*/
	case CefFrame_GetBrowser_22: {
		/*1257*/


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		/*1258*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*1259*/
	} break;
		/*1260*/
	case CefFrame_GetV8Context_23: {
		/*1261*/


		// gen! CefRefPtr<CefV8Context> GetV8Context()
		auto ret_result = me->GetV8Context();
		/*1262*/
		MyCefSetVoidPtr(ret, CefV8ContextCToCpp::Unwrap(ret_result));
		/*1263*/
	} break;
		/*1264*/
	case CefFrame_VisitDOM_24: {
		/*1265*/


		// gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
		me->VisitDOM(CefDOMVisitorCppToC::Unwrap((cef_domvisitor_t*)v1->ptr));
		/*1266*/

		/*1267*/
	} break;
		/*1268*/
	}
	/*1269*/
	CefFrameCToCpp::Unwrap(me);
	/*1270*/
}


// [virtual] class CefImage
/*1284*/
/*1271*/
const int CefImage_IsEmpty_1 = 1;
/*1272*/
const int CefImage_IsSame_2 = 2;
/*1273*/
const int CefImage_AddBitmap_3 = 3;
/*1274*/
const int CefImage_AddPNG_4 = 4;
/*1275*/
const int CefImage_AddJPEG_5 = 5;
/*1276*/
const int CefImage_GetWidth_6 = 6;
/*1277*/
const int CefImage_GetHeight_7 = 7;
/*1278*/
const int CefImage_HasRepresentation_8 = 8;
/*1279*/
const int CefImage_RemoveRepresentation_9 = 9;
/*1280*/
const int CefImage_GetRepresentationInfo_10 = 10;
/*1281*/
const int CefImage_GetAsBitmap_11 = 11;
/*1282*/
const int CefImage_GetAsPNG_12 = 12;
/*1283*/
const int CefImage_GetAsJPEG_13 = 13;

/*1285*/
void MyCefMet_CefImage(cef_image_t* me1, int metName, jsvalue* ret,
	jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6, jsvalue* v7 ) {
	/*1286*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1287*/
	auto me = CefImageCToCpp::Wrap(me1);
	/*1288*/
	switch (metName) {
		/*1289*/
	case MET_Release:return; //yes, just return
							 /*1290*/
	case CefImage_IsEmpty_1: {
		/*1291*/


		// gen! bool IsEmpty()
		auto ret_result = me->IsEmpty();
		/*1292*/
		MyCefSetBool(ret, ret_result);
		/*1293*/
	} break;
		/*1294*/
	case CefImage_IsSame_2: {
		/*1295*/


		// gen! bool IsSame(CefRefPtr<CefImage> that)
		auto ret_result = me->IsSame(CefImageCToCpp::Wrap((cef_image_t*)v1->ptr));
		/*1296*/
		MyCefSetBool(ret, ret_result);
		/*1297*/
	} break;
		/*1298*/
	case CefImage_AddBitmap_3: {
		/*1299*/


		// gen! bool AddBitmap(float scale_factor,int pixel_width,int pixel_height,cef_color_type_t color_type,cef_alpha_type_t alpha_type,const void* pixel_data,size_t pixel_data_size)
		auto ret_result = me->AddBitmap(v1->num,
			v2->i32,
			v3->i32,
			(cef_color_type_t)v4->i32,
			(cef_alpha_type_t)v5->i32,
			(void*)v6->ptr,
			v7->i64);
		/*1300*/
		MyCefSetBool(ret, ret_result);
		/*1301*/
	} break;
		/*1302*/
	case CefImage_AddPNG_4: {
		/*1303*/


		// gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
		auto ret_result = me->AddPNG(v1->num,
			(void*)v2->ptr,
			v3->i64);
		/*1304*/
		MyCefSetBool(ret, ret_result);
		/*1305*/
	} break;
		/*1306*/
	case CefImage_AddJPEG_5: {
		/*1307*/


		// gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
		auto ret_result = me->AddJPEG(v1->num,
			(void*)v2->ptr,
			v3->i64);
		/*1308*/
		MyCefSetBool(ret, ret_result);
		/*1309*/
	} break;
		/*1310*/
	case CefImage_GetWidth_6: {
		/*1311*/


		// gen! size_t GetWidth()
		auto ret_result = me->GetWidth();
		/*1312*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1313*/
	} break;
		/*1314*/
	case CefImage_GetHeight_7: {
		/*1315*/


		// gen! size_t GetHeight()
		auto ret_result = me->GetHeight();
		/*1316*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1317*/
	} break;
		/*1318*/
	case CefImage_HasRepresentation_8: {
		/*1319*/


		// gen! bool HasRepresentation(float scale_factor)
		auto ret_result = me->HasRepresentation(v1->num);
		/*1320*/
		MyCefSetBool(ret, ret_result);
		/*1321*/
	} break;
		/*1322*/
	case CefImage_RemoveRepresentation_9: {
		/*1323*/


		// gen! bool RemoveRepresentation(float scale_factor)
		auto ret_result = me->RemoveRepresentation(v1->num);
		/*1324*/
		MyCefSetBool(ret, ret_result);
		/*1325*/
	} break;
		/*1326*/
	case CefImage_GetRepresentationInfo_10: {
		/*1327*/


		// gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetRepresentationInfo(v1->num,
			*((float*)v2->ptr),
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		/*1328*/
		MyCefSetBool(ret, ret_result);
		/*1329*/
	} break;
		/*1330*/
	case CefImage_GetAsBitmap_11: {
		/*1331*/


		// gen! CefRefPtr<CefBinaryValue> GetAsBitmap(float scale_factor,cef_color_type_t color_type,cef_alpha_type_t alpha_type,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsBitmap(v1->num,
			(cef_color_type_t)v2->i32,
			(cef_alpha_type_t)v3->i32,
			*((int*)v4->ptr),
			*((int*)v5->ptr));
		/*1332*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*1333*/
	} break;
		/*1334*/
	case CefImage_GetAsPNG_12: {
		/*1335*/


		// gen! CefRefPtr<CefBinaryValue> GetAsPNG(float scale_factor,bool with_transparency,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsPNG(v1->num,
			v2->i32 != 0,
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		/*1336*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*1337*/
	} break;
		/*1338*/
	case CefImage_GetAsJPEG_13: {
		/*1339*/


		// gen! CefRefPtr<CefBinaryValue> GetAsJPEG(float scale_factor,int quality,int& pixel_width,int& pixel_height)
		auto ret_result = me->GetAsJPEG(v1->num,
			v2->i32,
			*((int*)v3->ptr),
			*((int*)v4->ptr));
		/*1340*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*1341*/
	} break;
		/*1342*/
	}
	/*1343*/
	CefImageCToCpp::Unwrap(me);
	/*1344*/
}


// [virtual] class CefMenuModel
/*1401*/
/*1345*/
const int CefMenuModel_IsSubMenu_1 = 1;
/*1346*/
const int CefMenuModel_Clear_2 = 2;
/*1347*/
const int CefMenuModel_GetCount_3 = 3;
/*1348*/
const int CefMenuModel_AddSeparator_4 = 4;
/*1349*/
const int CefMenuModel_AddItem_5 = 5;
/*1350*/
const int CefMenuModel_AddCheckItem_6 = 6;
/*1351*/
const int CefMenuModel_AddRadioItem_7 = 7;
/*1352*/
const int CefMenuModel_AddSubMenu_8 = 8;
/*1353*/
const int CefMenuModel_InsertSeparatorAt_9 = 9;
/*1354*/
const int CefMenuModel_InsertItemAt_10 = 10;
/*1355*/
const int CefMenuModel_InsertCheckItemAt_11 = 11;
/*1356*/
const int CefMenuModel_InsertRadioItemAt_12 = 12;
/*1357*/
const int CefMenuModel_InsertSubMenuAt_13 = 13;
/*1358*/
const int CefMenuModel_Remove_14 = 14;
/*1359*/
const int CefMenuModel_RemoveAt_15 = 15;
/*1360*/
const int CefMenuModel_GetIndexOf_16 = 16;
/*1361*/
const int CefMenuModel_GetCommandIdAt_17 = 17;
/*1362*/
const int CefMenuModel_SetCommandIdAt_18 = 18;
/*1363*/
const int CefMenuModel_GetLabel_19 = 19;
/*1364*/
const int CefMenuModel_GetLabelAt_20 = 20;
/*1365*/
const int CefMenuModel_SetLabel_21 = 21;
/*1366*/
const int CefMenuModel_SetLabelAt_22 = 22;
/*1367*/
const int CefMenuModel_GetType_23 = 23;
/*1368*/
const int CefMenuModel_GetTypeAt_24 = 24;
/*1369*/
const int CefMenuModel_GetGroupId_25 = 25;
/*1370*/
const int CefMenuModel_GetGroupIdAt_26 = 26;
/*1371*/
const int CefMenuModel_SetGroupId_27 = 27;
/*1372*/
const int CefMenuModel_SetGroupIdAt_28 = 28;
/*1373*/
const int CefMenuModel_GetSubMenu_29 = 29;
/*1374*/
const int CefMenuModel_GetSubMenuAt_30 = 30;
/*1375*/
const int CefMenuModel_IsVisible_31 = 31;
/*1376*/
const int CefMenuModel_IsVisibleAt_32 = 32;
/*1377*/
const int CefMenuModel_SetVisible_33 = 33;
/*1378*/
const int CefMenuModel_SetVisibleAt_34 = 34;
/*1379*/
const int CefMenuModel_IsEnabled_35 = 35;
/*1380*/
const int CefMenuModel_IsEnabledAt_36 = 36;
/*1381*/
const int CefMenuModel_SetEnabled_37 = 37;
/*1382*/
const int CefMenuModel_SetEnabledAt_38 = 38;
/*1383*/
const int CefMenuModel_IsChecked_39 = 39;
/*1384*/
const int CefMenuModel_IsCheckedAt_40 = 40;
/*1385*/
const int CefMenuModel_SetChecked_41 = 41;
/*1386*/
const int CefMenuModel_SetCheckedAt_42 = 42;
/*1387*/
const int CefMenuModel_HasAccelerator_43 = 43;
/*1388*/
const int CefMenuModel_HasAcceleratorAt_44 = 44;
/*1389*/
const int CefMenuModel_SetAccelerator_45 = 45;
/*1390*/
const int CefMenuModel_SetAcceleratorAt_46 = 46;
/*1391*/
const int CefMenuModel_RemoveAccelerator_47 = 47;
/*1392*/
const int CefMenuModel_RemoveAcceleratorAt_48 = 48;
/*1393*/
const int CefMenuModel_GetAccelerator_49 = 49;
/*1394*/
const int CefMenuModel_GetAcceleratorAt_50 = 50;
/*1395*/
const int CefMenuModel_SetColor_51 = 51;
/*1396*/
const int CefMenuModel_SetColorAt_52 = 52;
/*1397*/
const int CefMenuModel_GetColor_53 = 53;
/*1398*/
const int CefMenuModel_GetColorAt_54 = 54;
/*1399*/
const int CefMenuModel_SetFontList_55 = 55;
/*1400*/
const int CefMenuModel_SetFontListAt_56 = 56;

/*1402*/
void MyCefMet_CefMenuModel(cef_menu_model_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1403*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1404*/
	auto me = CefMenuModelCToCpp::Wrap(me1);
	/*1405*/
	switch (metName) {
		/*1406*/
	case MET_Release:return; //yes, just return
							 /*1407*/
	case CefMenuModel_IsSubMenu_1: {
		/*1408*/


		// gen! bool IsSubMenu()
		auto ret_result = me->IsSubMenu();
		/*1409*/
		MyCefSetBool(ret, ret_result);
		/*1410*/
	} break;
		/*1411*/
	case CefMenuModel_Clear_2: {
		/*1412*/


		// gen! bool Clear()
		auto ret_result = me->Clear();
		/*1413*/
		MyCefSetBool(ret, ret_result);
		/*1414*/
	} break;
		/*1415*/
	case CefMenuModel_GetCount_3: {
		/*1416*/


		// gen! int GetCount()
		auto ret_result = me->GetCount();
		/*1417*/
		MyCefSetInt64(ret, ret_result);
		/*1418*/
	} break;
		/*1419*/
	case CefMenuModel_AddSeparator_4: {
		/*1420*/


		// gen! bool AddSeparator()
		auto ret_result = me->AddSeparator();
		/*1421*/
		MyCefSetBool(ret, ret_result);
		/*1422*/
	} break;
		/*1423*/
	case CefMenuModel_AddItem_5: {
		/*1424*/


		// gen! bool AddItem(int command_id,const CefString& label)
		auto ret_result = me->AddItem(v1->i32,
			GetStringHolder(v2)->value);
		/*1425*/
		MyCefSetBool(ret, ret_result);
		/*1426*/
	} break;
		/*1427*/
	case CefMenuModel_AddCheckItem_6: {
		/*1428*/


		// gen! bool AddCheckItem(int command_id,const CefString& label)
		auto ret_result = me->AddCheckItem(v1->i32,
			GetStringHolder(v2)->value);
		/*1429*/
		MyCefSetBool(ret, ret_result);
		/*1430*/
	} break;
		/*1431*/
	case CefMenuModel_AddRadioItem_7: {
		/*1432*/


		// gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
		auto ret_result = me->AddRadioItem(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32);
		/*1433*/
		MyCefSetBool(ret, ret_result);
		/*1434*/
	} break;
		/*1435*/
	case CefMenuModel_AddSubMenu_8: {
		/*1436*/


		// gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
		auto ret_result = me->AddSubMenu(v1->i32,
			GetStringHolder(v2)->value);
		/*1437*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*1438*/
	} break;
		/*1439*/
	case CefMenuModel_InsertSeparatorAt_9: {
		/*1440*/


		// gen! bool InsertSeparatorAt(int index)
		auto ret_result = me->InsertSeparatorAt(v1->i32);
		/*1441*/
		MyCefSetBool(ret, ret_result);
		/*1442*/
	} break;
		/*1443*/
	case CefMenuModel_InsertItemAt_10: {
		/*1444*/


		// gen! bool InsertItemAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		/*1445*/
		MyCefSetBool(ret, ret_result);
		/*1446*/
	} break;
		/*1447*/
	case CefMenuModel_InsertCheckItemAt_11: {
		/*1448*/


		// gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertCheckItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		/*1449*/
		MyCefSetBool(ret, ret_result);
		/*1450*/
	} break;
		/*1451*/
	case CefMenuModel_InsertRadioItemAt_12: {
		/*1452*/


		// gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
		auto ret_result = me->InsertRadioItemAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value,
			v4->i32);
		/*1453*/
		MyCefSetBool(ret, ret_result);
		/*1454*/
	} break;
		/*1455*/
	case CefMenuModel_InsertSubMenuAt_13: {
		/*1456*/


		// gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
		auto ret_result = me->InsertSubMenuAt(v1->i32,
			v2->i32,
			GetStringHolder(v3)->value);
		/*1457*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*1458*/
	} break;
		/*1459*/
	case CefMenuModel_Remove_14: {
		/*1460*/


		// gen! bool Remove(int command_id)
		auto ret_result = me->Remove(v1->i32);
		/*1461*/
		MyCefSetBool(ret, ret_result);
		/*1462*/
	} break;
		/*1463*/
	case CefMenuModel_RemoveAt_15: {
		/*1464*/


		// gen! bool RemoveAt(int index)
		auto ret_result = me->RemoveAt(v1->i32);
		/*1465*/
		MyCefSetBool(ret, ret_result);
		/*1466*/
	} break;
		/*1467*/
	case CefMenuModel_GetIndexOf_16: {
		/*1468*/


		// gen! int GetIndexOf(int command_id)
		auto ret_result = me->GetIndexOf(v1->i32);
		/*1469*/
		MyCefSetInt64(ret, ret_result);
		/*1470*/
	} break;
		/*1471*/
	case CefMenuModel_GetCommandIdAt_17: {
		/*1472*/


		// gen! int GetCommandIdAt(int index)
		auto ret_result = me->GetCommandIdAt(v1->i32);
		/*1473*/
		MyCefSetInt64(ret, ret_result);
		/*1474*/
	} break;
		/*1475*/
	case CefMenuModel_SetCommandIdAt_18: {
		/*1476*/


		// gen! bool SetCommandIdAt(int index,int command_id)
		auto ret_result = me->SetCommandIdAt(v1->i32,
			v2->i32);
		/*1477*/
		MyCefSetBool(ret, ret_result);
		/*1478*/
	} break;
		/*1479*/
	case CefMenuModel_GetLabel_19: {
		/*1480*/


		// gen! CefString GetLabel(int command_id)
		auto ret_result = me->GetLabel(v1->i32);
		/*1481*/
		SetCefStringToJsValue(ret, ret_result);
		/*1482*/
	} break;
		/*1483*/
	case CefMenuModel_GetLabelAt_20: {
		/*1484*/


		// gen! CefString GetLabelAt(int index)
		auto ret_result = me->GetLabelAt(v1->i32);
		/*1485*/
		SetCefStringToJsValue(ret, ret_result);
		/*1486*/
	} break;
		/*1487*/
	case CefMenuModel_SetLabel_21: {
		/*1488*/


		// gen! bool SetLabel(int command_id,const CefString& label)
		auto ret_result = me->SetLabel(v1->i32,
			GetStringHolder(v2)->value);
		/*1489*/
		MyCefSetBool(ret, ret_result);
		/*1490*/
	} break;
		/*1491*/
	case CefMenuModel_SetLabelAt_22: {
		/*1492*/


		// gen! bool SetLabelAt(int index,const CefString& label)
		auto ret_result = me->SetLabelAt(v1->i32,
			GetStringHolder(v2)->value);
		/*1493*/
		MyCefSetBool(ret, ret_result);
		/*1494*/
	} break;
		/*1495*/
	case CefMenuModel_GetType_23: {
		/*1496*/


		// gen! MenuItemType GetType(int command_id)
		auto ret_result = me->GetType(v1->i32);
		/*1497*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1498*/
	} break;
		/*1499*/
	case CefMenuModel_GetTypeAt_24: {
		/*1500*/


		// gen! MenuItemType GetTypeAt(int index)
		auto ret_result = me->GetTypeAt(v1->i32);
		/*1501*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1502*/
	} break;
		/*1503*/
	case CefMenuModel_GetGroupId_25: {
		/*1504*/


		// gen! int GetGroupId(int command_id)
		auto ret_result = me->GetGroupId(v1->i32);
		/*1505*/
		MyCefSetInt64(ret, ret_result);
		/*1506*/
	} break;
		/*1507*/
	case CefMenuModel_GetGroupIdAt_26: {
		/*1508*/


		// gen! int GetGroupIdAt(int index)
		auto ret_result = me->GetGroupIdAt(v1->i32);
		/*1509*/
		MyCefSetInt64(ret, ret_result);
		/*1510*/
	} break;
		/*1511*/
	case CefMenuModel_SetGroupId_27: {
		/*1512*/


		// gen! bool SetGroupId(int command_id,int group_id)
		auto ret_result = me->SetGroupId(v1->i32,
			v2->i32);
		/*1513*/
		MyCefSetBool(ret, ret_result);
		/*1514*/
	} break;
		/*1515*/
	case CefMenuModel_SetGroupIdAt_28: {
		/*1516*/


		// gen! bool SetGroupIdAt(int index,int group_id)
		auto ret_result = me->SetGroupIdAt(v1->i32,
			v2->i32);
		/*1517*/
		MyCefSetBool(ret, ret_result);
		/*1518*/
	} break;
		/*1519*/
	case CefMenuModel_GetSubMenu_29: {
		/*1520*/


		// gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
		auto ret_result = me->GetSubMenu(v1->i32);
		/*1521*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*1522*/
	} break;
		/*1523*/
	case CefMenuModel_GetSubMenuAt_30: {
		/*1524*/


		// gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
		auto ret_result = me->GetSubMenuAt(v1->i32);
		/*1525*/
		MyCefSetVoidPtr(ret, CefMenuModelCToCpp::Unwrap(ret_result));
		/*1526*/
	} break;
		/*1527*/
	case CefMenuModel_IsVisible_31: {
		/*1528*/


		// gen! bool IsVisible(int command_id)
		auto ret_result = me->IsVisible(v1->i32);
		/*1529*/
		MyCefSetBool(ret, ret_result);
		/*1530*/
	} break;
		/*1531*/
	case CefMenuModel_IsVisibleAt_32: {
		/*1532*/


		// gen! bool IsVisibleAt(int index)
		auto ret_result = me->IsVisibleAt(v1->i32);
		/*1533*/
		MyCefSetBool(ret, ret_result);
		/*1534*/
	} break;
		/*1535*/
	case CefMenuModel_SetVisible_33: {
		/*1536*/


		// gen! bool SetVisible(int command_id,bool visible)
		auto ret_result = me->SetVisible(v1->i32,
			v2->i32 != 0);
		/*1537*/
		MyCefSetBool(ret, ret_result);
		/*1538*/
	} break;
		/*1539*/
	case CefMenuModel_SetVisibleAt_34: {
		/*1540*/


		// gen! bool SetVisibleAt(int index,bool visible)
		auto ret_result = me->SetVisibleAt(v1->i32,
			v2->i32 != 0);
		/*1541*/
		MyCefSetBool(ret, ret_result);
		/*1542*/
	} break;
		/*1543*/
	case CefMenuModel_IsEnabled_35: {
		/*1544*/


		// gen! bool IsEnabled(int command_id)
		auto ret_result = me->IsEnabled(v1->i32);
		/*1545*/
		MyCefSetBool(ret, ret_result);
		/*1546*/
	} break;
		/*1547*/
	case CefMenuModel_IsEnabledAt_36: {
		/*1548*/


		// gen! bool IsEnabledAt(int index)
		auto ret_result = me->IsEnabledAt(v1->i32);
		/*1549*/
		MyCefSetBool(ret, ret_result);
		/*1550*/
	} break;
		/*1551*/
	case CefMenuModel_SetEnabled_37: {
		/*1552*/


		// gen! bool SetEnabled(int command_id,bool enabled)
		auto ret_result = me->SetEnabled(v1->i32,
			v2->i32 != 0);
		/*1553*/
		MyCefSetBool(ret, ret_result);
		/*1554*/
	} break;
		/*1555*/
	case CefMenuModel_SetEnabledAt_38: {
		/*1556*/


		// gen! bool SetEnabledAt(int index,bool enabled)
		auto ret_result = me->SetEnabledAt(v1->i32,
			v2->i32 != 0);
		/*1557*/
		MyCefSetBool(ret, ret_result);
		/*1558*/
	} break;
		/*1559*/
	case CefMenuModel_IsChecked_39: {
		/*1560*/


		// gen! bool IsChecked(int command_id)
		auto ret_result = me->IsChecked(v1->i32);
		/*1561*/
		MyCefSetBool(ret, ret_result);
		/*1562*/
	} break;
		/*1563*/
	case CefMenuModel_IsCheckedAt_40: {
		/*1564*/


		// gen! bool IsCheckedAt(int index)
		auto ret_result = me->IsCheckedAt(v1->i32);
		/*1565*/
		MyCefSetBool(ret, ret_result);
		/*1566*/
	} break;
		/*1567*/
	case CefMenuModel_SetChecked_41: {
		/*1568*/


		// gen! bool SetChecked(int command_id,bool checked)
		auto ret_result = me->SetChecked(v1->i32,
			v2->i32 != 0);
		/*1569*/
		MyCefSetBool(ret, ret_result);
		/*1570*/
	} break;
		/*1571*/
	case CefMenuModel_SetCheckedAt_42: {
		/*1572*/


		// gen! bool SetCheckedAt(int index,bool checked)
		auto ret_result = me->SetCheckedAt(v1->i32,
			v2->i32 != 0);
		/*1573*/
		MyCefSetBool(ret, ret_result);
		/*1574*/
	} break;
		/*1575*/
	case CefMenuModel_HasAccelerator_43: {
		/*1576*/


		// gen! bool HasAccelerator(int command_id)
		auto ret_result = me->HasAccelerator(v1->i32);
		/*1577*/
		MyCefSetBool(ret, ret_result);
		/*1578*/
	} break;
		/*1579*/
	case CefMenuModel_HasAcceleratorAt_44: {
		/*1580*/


		// gen! bool HasAcceleratorAt(int index)
		auto ret_result = me->HasAcceleratorAt(v1->i32);
		/*1581*/
		MyCefSetBool(ret, ret_result);
		/*1582*/
	} break;
		/*1583*/
	case CefMenuModel_SetAccelerator_45: {
		/*1584*/


		// gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
		auto ret_result = me->SetAccelerator(v1->i32,
			v2->i32,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*1585*/
		MyCefSetBool(ret, ret_result);
		/*1586*/
	} break;
		/*1587*/
	case CefMenuModel_SetAcceleratorAt_46: {
		/*1588*/


		// gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
		auto ret_result = me->SetAcceleratorAt(v1->i32,
			v2->i32,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*1589*/
		MyCefSetBool(ret, ret_result);
		/*1590*/
	} break;
		/*1591*/
	case CefMenuModel_RemoveAccelerator_47: {
		/*1592*/


		// gen! bool RemoveAccelerator(int command_id)
		auto ret_result = me->RemoveAccelerator(v1->i32);
		/*1593*/
		MyCefSetBool(ret, ret_result);
		/*1594*/
	} break;
		/*1595*/
	case CefMenuModel_RemoveAcceleratorAt_48: {
		/*1596*/


		// gen! bool RemoveAcceleratorAt(int index)
		auto ret_result = me->RemoveAcceleratorAt(v1->i32);
		/*1597*/
		MyCefSetBool(ret, ret_result);
		/*1598*/
	} break;
		/*1599*/
	case CefMenuModel_GetAccelerator_49: {
		/*1600*/


		// gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
		auto ret_result = me->GetAccelerator(v1->i32,
			*((int*)v2->ptr),
			*((bool*)v3->ptr),
			*((bool*)v4->ptr),
			*((bool*)v5->ptr));
		/*1601*/
		MyCefSetBool(ret, ret_result);
		/*1602*/
	} break;
		/*1603*/
	case CefMenuModel_GetAcceleratorAt_50: {
		/*1604*/


		// gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
		auto ret_result = me->GetAcceleratorAt(v1->i32,
			*((int*)v2->ptr),
			*((bool*)v3->ptr),
			*((bool*)v4->ptr),
			*((bool*)v5->ptr));
		/*1605*/
		MyCefSetBool(ret, ret_result);
		/*1606*/
	} break;
		/*1607*/
	case CefMenuModel_SetColor_51: {
		/*1608*/


		// gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
		auto ret_result = me->SetColor(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			(cef_color_t)v3->i32);
		/*1609*/
		MyCefSetBool(ret, ret_result);
		/*1610*/
	} break;
		/*1611*/
	case CefMenuModel_SetColorAt_52: {
		/*1612*/


		// gen! bool SetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t color)
		auto ret_result = me->SetColorAt(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			(cef_color_t)v3->i32);
		/*1613*/
		MyCefSetBool(ret, ret_result);
		/*1614*/
	} break;
		/*1615*/
	case CefMenuModel_GetColor_53: {
		/*1616*/


		// gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
		auto ret_result = me->GetColor(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			*((cef_color_t*)v3->ptr));
		/*1617*/
		MyCefSetBool(ret, ret_result);
		/*1618*/
	} break;
		/*1619*/
	case CefMenuModel_GetColorAt_54: {
		/*1620*/


		// gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
		auto ret_result = me->GetColorAt(v1->i32,
			(cef_menu_color_type_t)v2->i32,
			*((cef_color_t*)v3->ptr));
		/*1621*/
		MyCefSetBool(ret, ret_result);
		/*1622*/
	} break;
		/*1623*/
	case CefMenuModel_SetFontList_55: {
		/*1624*/


		// gen! bool SetFontList(int command_id,const CefString& font_list)
		auto ret_result = me->SetFontList(v1->i32,
			GetStringHolder(v2)->value);
		/*1625*/
		MyCefSetBool(ret, ret_result);
		/*1626*/
	} break;
		/*1627*/
	case CefMenuModel_SetFontListAt_56: {
		/*1628*/


		// gen! bool SetFontListAt(int index,const CefString& font_list)
		auto ret_result = me->SetFontListAt(v1->i32,
			GetStringHolder(v2)->value);
		/*1629*/
		MyCefSetBool(ret, ret_result);
		/*1630*/
	} break;
		/*1631*/
	}
	/*1632*/
	CefMenuModelCToCpp::Unwrap(me);
	/*1633*/
}


// [virtual] class CefMenuModelDelegate
/*1634*/

/*1635*/
void MyCefMet_CefMenuModelDelegate(cef_menu_model_delegate_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1636*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1637*/
	auto me = CefMenuModelDelegateCppToC::Unwrap(me1);
	/*1638*/
	switch (metName) {
		/*1639*/
	case MET_Release:return; //yes, just return
							 /*1640*/
	}
	/*1641*/
	CefMenuModelDelegateCppToC::Wrap(me);
	/*1642*/
}


// [virtual] class CefNavigationEntry
/*1653*/
/*1643*/
const int CefNavigationEntry_IsValid_1 = 1;
/*1644*/
const int CefNavigationEntry_GetURL_2 = 2;
/*1645*/
const int CefNavigationEntry_GetDisplayURL_3 = 3;
/*1646*/
const int CefNavigationEntry_GetOriginalURL_4 = 4;
/*1647*/
const int CefNavigationEntry_GetTitle_5 = 5;
/*1648*/
const int CefNavigationEntry_GetTransitionType_6 = 6;
/*1649*/
const int CefNavigationEntry_HasPostData_7 = 7;
/*1650*/
const int CefNavigationEntry_GetCompletionTime_8 = 8;
/*1651*/
const int CefNavigationEntry_GetHttpStatusCode_9 = 9;
/*1652*/
const int CefNavigationEntry_GetSSLStatus_10 = 10;

/*1654*/
void MyCefMet_CefNavigationEntry(cef_navigation_entry_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1655*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1656*/
	auto me = CefNavigationEntryCToCpp::Wrap(me1);
	/*1657*/
	switch (metName) {
		/*1658*/
	case MET_Release:return; //yes, just return
							 /*1659*/
	case CefNavigationEntry_IsValid_1: {
		/*1660*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*1661*/
		MyCefSetBool(ret, ret_result);
		/*1662*/
	} break;
		/*1663*/
	case CefNavigationEntry_GetURL_2: {
		/*1664*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*1665*/
		SetCefStringToJsValue(ret, ret_result);
		/*1666*/
	} break;
		/*1667*/
	case CefNavigationEntry_GetDisplayURL_3: {
		/*1668*/


		// gen! CefString GetDisplayURL()
		auto ret_result = me->GetDisplayURL();
		/*1669*/
		SetCefStringToJsValue(ret, ret_result);
		/*1670*/
	} break;
		/*1671*/
	case CefNavigationEntry_GetOriginalURL_4: {
		/*1672*/


		// gen! CefString GetOriginalURL()
		auto ret_result = me->GetOriginalURL();
		/*1673*/
		SetCefStringToJsValue(ret, ret_result);
		/*1674*/
	} break;
		/*1675*/
	case CefNavigationEntry_GetTitle_5: {
		/*1676*/


		// gen! CefString GetTitle()
		auto ret_result = me->GetTitle();
		/*1677*/
		SetCefStringToJsValue(ret, ret_result);
		/*1678*/
	} break;
		/*1679*/
	case CefNavigationEntry_GetTransitionType_6: {
		/*1680*/


		// gen! TransitionType GetTransitionType()
		auto ret_result = me->GetTransitionType();
		/*1681*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1682*/
	} break;
		/*1683*/
	case CefNavigationEntry_HasPostData_7: {
		/*1684*/


		// gen! bool HasPostData()
		auto ret_result = me->HasPostData();
		/*1685*/
		MyCefSetBool(ret, ret_result);
		/*1686*/
	} break;
		/*1687*/
	case CefNavigationEntry_GetCompletionTime_8: {
		/*1688*/


		// gen! CefTime GetCompletionTime()
		auto ret_result = me->GetCompletionTime();
		/*1689*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*1690*/
	} break;
		/*1691*/
	case CefNavigationEntry_GetHttpStatusCode_9: {
		/*1692*/


		// gen! int GetHttpStatusCode()
		auto ret_result = me->GetHttpStatusCode();
		/*1693*/
		MyCefSetInt64(ret, ret_result);
		/*1694*/
	} break;
		/*1695*/
	case CefNavigationEntry_GetSSLStatus_10: {
		/*1696*/


		// gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
		auto ret_result = me->GetSSLStatus();
		/*1697*/
		MyCefSetVoidPtr(ret, CefSSLStatusCToCpp::Unwrap(ret_result));
		/*1698*/
	} break;
		/*1699*/
	}
	/*1700*/
	CefNavigationEntryCToCpp::Unwrap(me);
	/*1701*/
}


// [virtual] class CefPrintSettings
/*1725*/
/*1702*/
const int CefPrintSettings_IsValid_1 = 1;
/*1703*/
const int CefPrintSettings_IsReadOnly_2 = 2;
/*1704*/
const int CefPrintSettings_Copy_3 = 3;
/*1705*/
const int CefPrintSettings_SetOrientation_4 = 4;
/*1706*/
const int CefPrintSettings_IsLandscape_5 = 5;
/*1707*/
const int CefPrintSettings_SetPrinterPrintableArea_6 = 6;
/*1708*/
const int CefPrintSettings_SetDeviceName_7 = 7;
/*1709*/
const int CefPrintSettings_GetDeviceName_8 = 8;
/*1710*/
const int CefPrintSettings_SetDPI_9 = 9;
/*1711*/
const int CefPrintSettings_GetDPI_10 = 10;
/*1712*/
const int CefPrintSettings_SetPageRanges_11 = 11;
/*1713*/
const int CefPrintSettings_GetPageRangesCount_12 = 12;
/*1714*/
const int CefPrintSettings_GetPageRanges_13 = 13;
/*1715*/
const int CefPrintSettings_SetSelectionOnly_14 = 14;
/*1716*/
const int CefPrintSettings_IsSelectionOnly_15 = 15;
/*1717*/
const int CefPrintSettings_SetCollate_16 = 16;
/*1718*/
const int CefPrintSettings_WillCollate_17 = 17;
/*1719*/
const int CefPrintSettings_SetColorModel_18 = 18;
/*1720*/
const int CefPrintSettings_GetColorModel_19 = 19;
/*1721*/
const int CefPrintSettings_SetCopies_20 = 20;
/*1722*/
const int CefPrintSettings_GetCopies_21 = 21;
/*1723*/
const int CefPrintSettings_SetDuplexMode_22 = 22;
/*1724*/
const int CefPrintSettings_GetDuplexMode_23 = 23;

/*1726*/
void MyCefMet_CefPrintSettings(cef_print_settings_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1727*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1728*/
	auto me = CefPrintSettingsCToCpp::Wrap(me1);
	/*1729*/
	switch (metName) {
		/*1730*/
	case MET_Release:return; //yes, just return
							 /*1731*/
	case CefPrintSettings_IsValid_1: {
		/*1732*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*1733*/
		MyCefSetBool(ret, ret_result);
		/*1734*/
	} break;
		/*1735*/
	case CefPrintSettings_IsReadOnly_2: {
		/*1736*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*1737*/
		MyCefSetBool(ret, ret_result);
		/*1738*/
	} break;
		/*1739*/
	case CefPrintSettings_Copy_3: {
		/*1740*/


		// gen! CefRefPtr<CefPrintSettings> Copy()
		auto ret_result = me->Copy();
		/*1741*/
		MyCefSetVoidPtr(ret, CefPrintSettingsCToCpp::Unwrap(ret_result));
		/*1742*/
	} break;
		/*1743*/
	case CefPrintSettings_SetOrientation_4: {
		/*1744*/


		// gen! void SetOrientation(bool landscape)
		me->SetOrientation(v1->i32 != 0);
		/*1745*/

		/*1746*/
	} break;
		/*1747*/
	case CefPrintSettings_IsLandscape_5: {
		/*1748*/


		// gen! bool IsLandscape()
		auto ret_result = me->IsLandscape();
		/*1749*/
		MyCefSetBool(ret, ret_result);
		/*1750*/
	} break;
		/*1751*/
	case CefPrintSettings_SetPrinterPrintableArea_6: {
		/*1752*/


		// gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
		me->SetPrinterPrintableArea(*((CefSize*)v1->ptr),
			*((CefRect*)v2->ptr),
			v3->i32 != 0);
		/*1753*/

		/*1754*/
	} break;
		/*1755*/
	case CefPrintSettings_SetDeviceName_7: {
		/*1756*/


		// gen! void SetDeviceName(const CefString& name)
		me->SetDeviceName(GetStringHolder(v1)->value);
		/*1757*/

		/*1758*/
	} break;
		/*1759*/
	case CefPrintSettings_GetDeviceName_8: {
		/*1760*/


		// gen! CefString GetDeviceName()
		auto ret_result = me->GetDeviceName();
		/*1761*/
		SetCefStringToJsValue(ret, ret_result);
		/*1762*/
	} break;
		/*1763*/
	case CefPrintSettings_SetDPI_9: {
		/*1764*/


		// gen! void SetDPI(int dpi)
		me->SetDPI(v1->i32);
		/*1765*/

		/*1766*/
	} break;
		/*1767*/
	case CefPrintSettings_GetDPI_10: {
		/*1768*/


		// gen! int GetDPI()
		auto ret_result = me->GetDPI();
		/*1769*/
		MyCefSetInt64(ret, ret_result);
		/*1770*/
	} break;
		/*1771*/
	case CefPrintSettings_SetPageRanges_11: {
		/*1772*/


		// gen! void SetPageRanges(const PageRangeList& ranges)
		me->SetPageRanges(*((CefPrintSettings::PageRangeList*)v1->ptr));
		/*1773*/

		/*1774*/
	} break;
		/*1775*/
	case CefPrintSettings_GetPageRangesCount_12: {
		/*1776*/


		// gen! size_t GetPageRangesCount()
		auto ret_result = me->GetPageRangesCount();
		/*1777*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1778*/
	} break;
		/*1779*/
	case CefPrintSettings_GetPageRanges_13: {
		/*1780*/


		// gen! void GetPageRanges(PageRangeList& ranges)
		me->GetPageRanges(*((CefPrintSettings::PageRangeList*)v1->ptr));
		/*1781*/

		/*1782*/
	} break;
		/*1783*/
	case CefPrintSettings_SetSelectionOnly_14: {
		/*1784*/


		// gen! void SetSelectionOnly(bool selection_only)
		me->SetSelectionOnly(v1->i32 != 0);
		/*1785*/

		/*1786*/
	} break;
		/*1787*/
	case CefPrintSettings_IsSelectionOnly_15: {
		/*1788*/


		// gen! bool IsSelectionOnly()
		auto ret_result = me->IsSelectionOnly();
		/*1789*/
		MyCefSetBool(ret, ret_result);
		/*1790*/
	} break;
		/*1791*/
	case CefPrintSettings_SetCollate_16: {
		/*1792*/


		// gen! void SetCollate(bool collate)
		me->SetCollate(v1->i32 != 0);
		/*1793*/

		/*1794*/
	} break;
		/*1795*/
	case CefPrintSettings_WillCollate_17: {
		/*1796*/


		// gen! bool WillCollate()
		auto ret_result = me->WillCollate();
		/*1797*/
		MyCefSetBool(ret, ret_result);
		/*1798*/
	} break;
		/*1799*/
	case CefPrintSettings_SetColorModel_18: {
		/*1800*/


		// gen! void SetColorModel(ColorModel model)
		me->SetColorModel((CefPrintSettings::ColorModel)v1->i32);
		/*1801*/

		/*1802*/
	} break;
		/*1803*/
	case CefPrintSettings_GetColorModel_19: {
		/*1804*/


		// gen! ColorModel GetColorModel()
		auto ret_result = me->GetColorModel();
		/*1805*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1806*/
	} break;
		/*1807*/
	case CefPrintSettings_SetCopies_20: {
		/*1808*/


		// gen! void SetCopies(int copies)
		me->SetCopies(v1->i32);
		/*1809*/

		/*1810*/
	} break;
		/*1811*/
	case CefPrintSettings_GetCopies_21: {
		/*1812*/


		// gen! int GetCopies()
		auto ret_result = me->GetCopies();
		/*1813*/
		MyCefSetInt64(ret, ret_result);
		/*1814*/
	} break;
		/*1815*/
	case CefPrintSettings_SetDuplexMode_22: {
		/*1816*/


		// gen! void SetDuplexMode(DuplexMode mode)
		me->SetDuplexMode((CefPrintSettings::DuplexMode)v1->i32);
		/*1817*/

		/*1818*/
	} break;
		/*1819*/
	case CefPrintSettings_GetDuplexMode_23: {
		/*1820*/


		// gen! DuplexMode GetDuplexMode()
		auto ret_result = me->GetDuplexMode();
		/*1821*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1822*/
	} break;
		/*1823*/
	}
	/*1824*/
	CefPrintSettingsCToCpp::Unwrap(me);
	/*1825*/
}


// [virtual] class CefProcessMessage
/*1831*/
/*1826*/
const int CefProcessMessage_IsValid_1 = 1;
/*1827*/
const int CefProcessMessage_IsReadOnly_2 = 2;
/*1828*/
const int CefProcessMessage_Copy_3 = 3;
/*1829*/
const int CefProcessMessage_GetName_4 = 4;
/*1830*/
const int CefProcessMessage_GetArgumentList_5 = 5;

/*1832*/
void MyCefMet_CefProcessMessage(cef_process_message_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1833*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1834*/
	auto me = CefProcessMessageCToCpp::Wrap(me1);
	/*1835*/
	switch (metName) {
		/*1836*/
	case MET_Release:return; //yes, just return
							 /*1837*/
	case CefProcessMessage_IsValid_1: {
		/*1838*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*1839*/
		MyCefSetBool(ret, ret_result);
		/*1840*/
	} break;
		/*1841*/
	case CefProcessMessage_IsReadOnly_2: {
		/*1842*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*1843*/
		MyCefSetBool(ret, ret_result);
		/*1844*/
	} break;
		/*1845*/
	case CefProcessMessage_Copy_3: {
		/*1846*/


		// gen! CefRefPtr<CefProcessMessage> Copy()
		auto ret_result = me->Copy();
		/*1847*/
		MyCefSetVoidPtr(ret, CefProcessMessageCToCpp::Unwrap(ret_result));
		/*1848*/
	} break;
		/*1849*/
	case CefProcessMessage_GetName_4: {
		/*1850*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*1851*/
		SetCefStringToJsValue(ret, ret_result);
		/*1852*/
	} break;
		/*1853*/
	case CefProcessMessage_GetArgumentList_5: {
		/*1854*/


		// gen! CefRefPtr<CefListValue> GetArgumentList()
		auto ret_result = me->GetArgumentList();
		/*1855*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*1856*/
	} break;
		/*1857*/
	}
	/*1858*/
	CefProcessMessageCToCpp::Unwrap(me);
	/*1859*/
}


// [virtual] class CefRequest
/*1880*/
/*1860*/
const int CefRequest_IsReadOnly_1 = 1;
/*1861*/
const int CefRequest_GetURL_2 = 2;
/*1862*/
const int CefRequest_SetURL_3 = 3;
/*1863*/
const int CefRequest_GetMethod_4 = 4;
/*1864*/
const int CefRequest_SetMethod_5 = 5;
/*1865*/
const int CefRequest_SetReferrer_6 = 6;
/*1866*/
const int CefRequest_GetReferrerURL_7 = 7;
/*1867*/
const int CefRequest_GetReferrerPolicy_8 = 8;
/*1868*/
const int CefRequest_GetPostData_9 = 9;
/*1869*/
const int CefRequest_SetPostData_10 = 10;
/*1870*/
const int CefRequest_GetHeaderMap_11 = 11;
/*1871*/
const int CefRequest_SetHeaderMap_12 = 12;
/*1872*/
const int CefRequest_Set_13 = 13;
/*1873*/
const int CefRequest_GetFlags_14 = 14;
/*1874*/
const int CefRequest_SetFlags_15 = 15;
/*1875*/
const int CefRequest_GetFirstPartyForCookies_16 = 16;
/*1876*/
const int CefRequest_SetFirstPartyForCookies_17 = 17;
/*1877*/
const int CefRequest_GetResourceType_18 = 18;
/*1878*/
const int CefRequest_GetTransitionType_19 = 19;
/*1879*/
const int CefRequest_GetIdentifier_20 = 20;

/*1881*/
void MyCefMet_CefRequest(cef_request_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1882*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1883*/
	auto me = CefRequestCToCpp::Wrap(me1);
	/*1884*/
	switch (metName) {
		/*1885*/
	case MET_Release:return; //yes, just return
							 /*1886*/
	case CefRequest_IsReadOnly_1: {
		/*1887*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*1888*/
		MyCefSetBool(ret, ret_result);
		/*1889*/
	} break;
		/*1890*/
	case CefRequest_GetURL_2: {
		/*1891*/


		// gen! CefString GetURL()
		auto ret_result = me->GetURL();
		/*1892*/
		SetCefStringToJsValue(ret, ret_result);
		/*1893*/
	} break;
		/*1894*/
	case CefRequest_SetURL_3: {
		/*1895*/


		// gen! void SetURL(const CefString& url)
		me->SetURL(GetStringHolder(v1)->value);
		/*1896*/

		/*1897*/
	} break;
		/*1898*/
	case CefRequest_GetMethod_4: {
		/*1899*/


		// gen! CefString GetMethod()
		auto ret_result = me->GetMethod();
		/*1900*/
		SetCefStringToJsValue(ret, ret_result);
		/*1901*/
	} break;
		/*1902*/
	case CefRequest_SetMethod_5: {
		/*1903*/


		// gen! void SetMethod(const CefString& method)
		me->SetMethod(GetStringHolder(v1)->value);
		/*1904*/

		/*1905*/
	} break;
		/*1906*/
	case CefRequest_SetReferrer_6: {
		/*1907*/


		// gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
		me->SetReferrer(GetStringHolder(v1)->value,
			(CefRequest::ReferrerPolicy)v2->i32);
		/*1908*/

		/*1909*/
	} break;
		/*1910*/
	case CefRequest_GetReferrerURL_7: {
		/*1911*/


		// gen! CefString GetReferrerURL()
		auto ret_result = me->GetReferrerURL();
		/*1912*/
		SetCefStringToJsValue(ret, ret_result);
		/*1913*/
	} break;
		/*1914*/
	case CefRequest_GetReferrerPolicy_8: {
		/*1915*/


		// gen! ReferrerPolicy GetReferrerPolicy()
		auto ret_result = me->GetReferrerPolicy();
		/*1916*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1917*/
	} break;
		/*1918*/
	case CefRequest_GetPostData_9: {
		/*1919*/


		// gen! CefRefPtr<CefPostData> GetPostData()
		auto ret_result = me->GetPostData();
		/*1920*/
		MyCefSetVoidPtr(ret, CefPostDataCToCpp::Unwrap(ret_result));
		/*1921*/
	} break;
		/*1922*/
	case CefRequest_SetPostData_10: {
		/*1923*/


		// gen! void SetPostData(CefRefPtr<CefPostData> postData)
		me->SetPostData(CefPostDataCToCpp::Wrap((cef_post_data_t*)v1->ptr));
		/*1924*/

		/*1925*/
	} break;
		/*1926*/
	case CefRequest_GetHeaderMap_11: {
		/*1927*/


		// gen! void GetHeaderMap(HeaderMap& headerMap)
		me->GetHeaderMap(*((CefRequest::HeaderMap*)v1->ptr));
		/*1928*/

		/*1929*/
	} break;
		/*1930*/
	case CefRequest_SetHeaderMap_12: {
		/*1931*/


		// gen! void SetHeaderMap(const HeaderMap& headerMap)
		me->SetHeaderMap(*((CefRequest::HeaderMap*)v1->ptr));
		/*1932*/

		/*1933*/
	} break;
		/*1934*/
	case CefRequest_Set_13: {
		/*1935*/


		// gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
		me->Set(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefPostDataCToCpp::Wrap((cef_post_data_t*)v3->ptr),
			*((CefRequest::HeaderMap*)v4->ptr));
		/*1936*/

		/*1937*/
	} break;
		/*1938*/
	case CefRequest_GetFlags_14: {
		/*1939*/


		// gen! int GetFlags()
		auto ret_result = me->GetFlags();
		/*1940*/
		MyCefSetInt64(ret, ret_result);
		/*1941*/
	} break;
		/*1942*/
	case CefRequest_SetFlags_15: {
		/*1943*/


		// gen! void SetFlags(int flags)
		me->SetFlags(v1->i32);
		/*1944*/

		/*1945*/
	} break;
		/*1946*/
	case CefRequest_GetFirstPartyForCookies_16: {
		/*1947*/


		// gen! CefString GetFirstPartyForCookies()
		auto ret_result = me->GetFirstPartyForCookies();
		/*1948*/
		SetCefStringToJsValue(ret, ret_result);
		/*1949*/
	} break;
		/*1950*/
	case CefRequest_SetFirstPartyForCookies_17: {
		/*1951*/


		// gen! void SetFirstPartyForCookies(const CefString& url)
		me->SetFirstPartyForCookies(GetStringHolder(v1)->value);
		/*1952*/

		/*1953*/
	} break;
		/*1954*/
	case CefRequest_GetResourceType_18: {
		/*1955*/


		// gen! ResourceType GetResourceType()
		auto ret_result = me->GetResourceType();
		/*1956*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1957*/
	} break;
		/*1958*/
	case CefRequest_GetTransitionType_19: {
		/*1959*/


		// gen! TransitionType GetTransitionType()
		auto ret_result = me->GetTransitionType();
		/*1960*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1961*/
	} break;
		/*1962*/
	case CefRequest_GetIdentifier_20: {
		/*1963*/


		// gen! uint64 GetIdentifier()
		auto ret_result = me->GetIdentifier();
		/*1964*/
		MyCefSetUInt64(ret, ret_result);
		/*1965*/
	} break;
		/*1966*/
	}
	/*1967*/
	CefRequestCToCpp::Unwrap(me);
	/*1968*/
}


// [virtual] class CefPostData
/*1976*/
/*1969*/
const int CefPostData_IsReadOnly_1 = 1;
/*1970*/
const int CefPostData_HasExcludedElements_2 = 2;
/*1971*/
const int CefPostData_GetElementCount_3 = 3;
/*1972*/
const int CefPostData_GetElements_4 = 4;
/*1973*/
const int CefPostData_RemoveElement_5 = 5;
/*1974*/
const int CefPostData_AddElement_6 = 6;
/*1975*/
const int CefPostData_RemoveElements_7 = 7;

/*1977*/
void MyCefMet_CefPostData(cef_post_data_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*1978*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*1979*/
	auto me = CefPostDataCToCpp::Wrap(me1);
	/*1980*/
	switch (metName) {
		/*1981*/
	case MET_Release:return; //yes, just return
							 /*1982*/
	case CefPostData_IsReadOnly_1: {
		/*1983*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*1984*/
		MyCefSetBool(ret, ret_result);
		/*1985*/
	} break;
		/*1986*/
	case CefPostData_HasExcludedElements_2: {
		/*1987*/


		// gen! bool HasExcludedElements()
		auto ret_result = me->HasExcludedElements();
		/*1988*/
		MyCefSetBool(ret, ret_result);
		/*1989*/
	} break;
		/*1990*/
	case CefPostData_GetElementCount_3: {
		/*1991*/


		// gen! size_t GetElementCount()
		auto ret_result = me->GetElementCount();
		/*1992*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*1993*/
	} break;
		/*1994*/
	case CefPostData_GetElements_4: {
		/*1995*/


		// gen! void GetElements(ElementVector& elements)
		me->GetElements(*((CefPostData::ElementVector*)v1->ptr));
		/*1996*/

		/*1997*/
	} break;
		/*1998*/
	case CefPostData_RemoveElement_5: {
		/*1999*/


		// gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
		auto ret_result = me->RemoveElement(CefPostDataElementCToCpp::Wrap((cef_post_data_element_t*)v1->ptr));
		/*2000*/
		MyCefSetBool(ret, ret_result);
		/*2001*/
	} break;
		/*2002*/
	case CefPostData_AddElement_6: {
		/*2003*/


		// gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
		auto ret_result = me->AddElement(CefPostDataElementCToCpp::Wrap((cef_post_data_element_t*)v1->ptr));
		/*2004*/
		MyCefSetBool(ret, ret_result);
		/*2005*/
	} break;
		/*2006*/
	case CefPostData_RemoveElements_7: {
		/*2007*/


		// gen! void RemoveElements()
		me->RemoveElements();
		/*2008*/

		/*2009*/
	} break;
		/*2010*/
	}
	/*2011*/
	CefPostDataCToCpp::Unwrap(me);
	/*2012*/
}


// [virtual] class CefPostDataElement
/*2021*/
/*2013*/
const int CefPostDataElement_IsReadOnly_1 = 1;
/*2014*/
const int CefPostDataElement_SetToEmpty_2 = 2;
/*2015*/
const int CefPostDataElement_SetToFile_3 = 3;
/*2016*/
const int CefPostDataElement_SetToBytes_4 = 4;
/*2017*/
const int CefPostDataElement_GetType_5 = 5;
/*2018*/
const int CefPostDataElement_GetFile_6 = 6;
/*2019*/
const int CefPostDataElement_GetBytesCount_7 = 7;
/*2020*/
const int CefPostDataElement_GetBytes_8 = 8;

/*2022*/
void MyCefMet_CefPostDataElement(cef_post_data_element_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2023*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2024*/
	auto me = CefPostDataElementCToCpp::Wrap(me1);
	/*2025*/
	switch (metName) {
		/*2026*/
	case MET_Release:return; //yes, just return
							 /*2027*/
	case CefPostDataElement_IsReadOnly_1: {
		/*2028*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*2029*/
		MyCefSetBool(ret, ret_result);
		/*2030*/
	} break;
		/*2031*/
	case CefPostDataElement_SetToEmpty_2: {
		/*2032*/


		// gen! void SetToEmpty()
		me->SetToEmpty();
		/*2033*/

		/*2034*/
	} break;
		/*2035*/
	case CefPostDataElement_SetToFile_3: {
		/*2036*/


		// gen! void SetToFile(const CefString& fileName)
		me->SetToFile(GetStringHolder(v1)->value);
		/*2037*/

		/*2038*/
	} break;
		/*2039*/
	case CefPostDataElement_SetToBytes_4: {
		/*2040*/


		// gen! void SetToBytes(size_t size,const void* bytes)
		me->SetToBytes(v1->i64,
			(void*)v2->ptr);
		/*2041*/

		/*2042*/
	} break;
		/*2043*/
	case CefPostDataElement_GetType_5: {
		/*2044*/


		// gen! Type GetType()
		auto ret_result = me->GetType();
		/*2045*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2046*/
	} break;
		/*2047*/
	case CefPostDataElement_GetFile_6: {
		/*2048*/


		// gen! CefString GetFile()
		auto ret_result = me->GetFile();
		/*2049*/
		SetCefStringToJsValue(ret, ret_result);
		/*2050*/
	} break;
		/*2051*/
	case CefPostDataElement_GetBytesCount_7: {
		/*2052*/


		// gen! size_t GetBytesCount()
		auto ret_result = me->GetBytesCount();
		/*2053*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2054*/
	} break;
		/*2055*/
	case CefPostDataElement_GetBytes_8: {
		/*2056*/


		// gen! size_t GetBytes(size_t size,void* bytes)
		auto ret_result = me->GetBytes(v1->i64,
			(void*)v2->ptr);
		/*2057*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2058*/
	} break;
		/*2059*/
	}
	/*2060*/
	CefPostDataElementCToCpp::Unwrap(me);
	/*2061*/
}


// [virtual] class CefRequestContext
/*2080*/
/*2062*/
const int CefRequestContext_IsSame_1 = 1;
/*2063*/
const int CefRequestContext_IsSharingWith_2 = 2;
/*2064*/
const int CefRequestContext_IsGlobal_3 = 3;
/*2065*/
const int CefRequestContext_GetHandler_4 = 4;
/*2066*/
const int CefRequestContext_GetCachePath_5 = 5;
/*2067*/
const int CefRequestContext_GetDefaultCookieManager_6 = 6;
/*2068*/
const int CefRequestContext_RegisterSchemeHandlerFactory_7 = 7;
/*2069*/
const int CefRequestContext_ClearSchemeHandlerFactories_8 = 8;
/*2070*/
const int CefRequestContext_PurgePluginListCache_9 = 9;
/*2071*/
const int CefRequestContext_HasPreference_10 = 10;
/*2072*/
const int CefRequestContext_GetPreference_11 = 11;
/*2073*/
const int CefRequestContext_GetAllPreferences_12 = 12;
/*2074*/
const int CefRequestContext_CanSetPreference_13 = 13;
/*2075*/
const int CefRequestContext_SetPreference_14 = 14;
/*2076*/
const int CefRequestContext_ClearCertificateExceptions_15 = 15;
/*2077*/
const int CefRequestContext_CloseAllConnections_16 = 16;
/*2078*/
const int CefRequestContext_ResolveHost_17 = 17;
/*2079*/
const int CefRequestContext_ResolveHostCached_18 = 18;

/*2081*/
void MyCefMet_CefRequestContext(cef_request_context_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2082*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2083*/
	auto me = CefRequestContextCToCpp::Wrap(me1);
	/*2084*/
	switch (metName) {
		/*2085*/
	case MET_Release:return; //yes, just return
							 /*2086*/
	case CefRequestContext_IsSame_1: {
		/*2087*/


		// gen! bool IsSame(CefRefPtr<CefRequestContext> other)
		auto ret_result = me->IsSame(CefRequestContextCToCpp::Wrap((cef_request_context_t*)v1->ptr));
		/*2088*/
		MyCefSetBool(ret, ret_result);
		/*2089*/
	} break;
		/*2090*/
	case CefRequestContext_IsSharingWith_2: {
		/*2091*/


		// gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
		auto ret_result = me->IsSharingWith(CefRequestContextCToCpp::Wrap((cef_request_context_t*)v1->ptr));
		/*2092*/
		MyCefSetBool(ret, ret_result);
		/*2093*/
	} break;
		/*2094*/
	case CefRequestContext_IsGlobal_3: {
		/*2095*/


		// gen! bool IsGlobal()
		auto ret_result = me->IsGlobal();
		/*2096*/
		MyCefSetBool(ret, ret_result);
		/*2097*/
	} break;
		/*2098*/
	case CefRequestContext_GetHandler_4: {
		/*2099*/


		// gen! CefRefPtr<CefRequestContextHandler> GetHandler()
		auto ret_result = me->GetHandler();
		/*2100*/
		MyCefSetVoidPtr(ret, CefRequestContextHandlerCppToC::Wrap(ret_result));
		/*2101*/
	} break;
		/*2102*/
	case CefRequestContext_GetCachePath_5: {
		/*2103*/


		// gen! CefString GetCachePath()
		auto ret_result = me->GetCachePath();
		/*2104*/
		SetCefStringToJsValue(ret, ret_result);
		/*2105*/
	} break;
		/*2106*/
	case CefRequestContext_GetDefaultCookieManager_6: {
		/*2107*/


		// gen! CefRefPtr<CefCookieManager> GetDefaultCookieManager(CefRefPtr<CefCompletionCallback> callback)
		auto ret_result = me->GetDefaultCookieManager(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*2108*/
		MyCefSetVoidPtr(ret, CefCookieManagerCToCpp::Unwrap(ret_result));
		/*2109*/
	} break;
		/*2110*/
	case CefRequestContext_RegisterSchemeHandlerFactory_7: {
		/*2111*/


		// gen! bool RegisterSchemeHandlerFactory(const CefString& scheme_name,const CefString& domain_name,CefRefPtr<CefSchemeHandlerFactory> factory)
		auto ret_result = me->RegisterSchemeHandlerFactory(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			CefSchemeHandlerFactoryCppToC::Unwrap((cef_scheme_handler_factory_t*)v3->ptr));
		/*2112*/
		MyCefSetBool(ret, ret_result);
		/*2113*/
	} break;
		/*2114*/
	case CefRequestContext_ClearSchemeHandlerFactories_8: {
		/*2115*/


		// gen! bool ClearSchemeHandlerFactories()
		auto ret_result = me->ClearSchemeHandlerFactories();
		/*2116*/
		MyCefSetBool(ret, ret_result);
		/*2117*/
	} break;
		/*2118*/
	case CefRequestContext_PurgePluginListCache_9: {
		/*2119*/


		// gen! void PurgePluginListCache(bool reload_pages)
		me->PurgePluginListCache(v1->i32 != 0);
		/*2120*/

		/*2121*/
	} break;
		/*2122*/
	case CefRequestContext_HasPreference_10: {
		/*2123*/


		// gen! bool HasPreference(const CefString& name)
		auto ret_result = me->HasPreference(GetStringHolder(v1)->value);
		/*2124*/
		MyCefSetBool(ret, ret_result);
		/*2125*/
	} break;
		/*2126*/
	case CefRequestContext_GetPreference_11: {
		/*2127*/


		// gen! CefRefPtr<CefValue> GetPreference(const CefString& name)
		auto ret_result = me->GetPreference(GetStringHolder(v1)->value);
		/*2128*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*2129*/
	} break;
		/*2130*/
	case CefRequestContext_GetAllPreferences_12: {
		/*2131*/


		// gen! CefRefPtr<CefDictionaryValue> GetAllPreferences(bool include_defaults)
		auto ret_result = me->GetAllPreferences(v1->i32 != 0);
		/*2132*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*2133*/
	} break;
		/*2134*/
	case CefRequestContext_CanSetPreference_13: {
		/*2135*/


		// gen! bool CanSetPreference(const CefString& name)
		auto ret_result = me->CanSetPreference(GetStringHolder(v1)->value);
		/*2136*/
		MyCefSetBool(ret, ret_result);
		/*2137*/
	} break;
		/*2138*/
	case CefRequestContext_SetPreference_14: {
		/*2139*/


		// gen! bool SetPreference(const CefString& name,CefRefPtr<CefValue> value,CefString& error)
		auto ret_result = me->SetPreference(GetStringHolder(v1)->value,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr),
			GetStringHolder(v3)->value);
		/*2140*/
		MyCefSetBool(ret, ret_result);
		/*2141*/
	} break;
		/*2142*/
	case CefRequestContext_ClearCertificateExceptions_15: {
		/*2143*/


		// gen! void ClearCertificateExceptions(CefRefPtr<CefCompletionCallback> callback)
		me->ClearCertificateExceptions(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*2144*/

		/*2145*/
	} break;
		/*2146*/
	case CefRequestContext_CloseAllConnections_16: {
		/*2147*/


		// gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
		me->CloseAllConnections(CefCompletionCallbackCppToC::Unwrap((cef_completion_callback_t*)v1->ptr));
		/*2148*/

		/*2149*/
	} break;
		/*2150*/
	case CefRequestContext_ResolveHost_17: {
		/*2151*/


		// gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
		me->ResolveHost(GetStringHolder(v1)->value,
			CefResolveCallbackCppToC::Unwrap((cef_resolve_callback_t*)v2->ptr));
		/*2152*/

		/*2153*/
	} break;
		/*2154*/
	case CefRequestContext_ResolveHostCached_18: {
		/*2155*/


		// gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
		auto ret_result = me->ResolveHostCached(GetStringHolder(v1)->value,
			*((std::vector<CefString>*)v2->ptr));
		/*2156*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2157*/
	} break;
		/*2158*/
	}
	/*2159*/
	CefRequestContextCToCpp::Unwrap(me);
	/*2160*/
}


// [virtual] class CefResourceBundle
/*2164*/
/*2161*/
const int CefResourceBundle_GetLocalizedString_1 = 1;
/*2162*/
const int CefResourceBundle_GetDataResource_2 = 2;
/*2163*/
const int CefResourceBundle_GetDataResourceForScale_3 = 3;

/*2165*/
void MyCefMet_CefResourceBundle(cef_resource_bundle_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2166*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2167*/
	auto me = CefResourceBundleCToCpp::Wrap(me1);
	/*2168*/
	switch (metName) {
		/*2169*/
	case MET_Release:return; //yes, just return
							 /*2170*/
	case CefResourceBundle_GetLocalizedString_1: {
		/*2171*/


		// gen! CefString GetLocalizedString(int string_id)
		auto ret_result = me->GetLocalizedString(v1->i32);
		/*2172*/
		SetCefStringToJsValue(ret, ret_result);
		/*2173*/
	} break;
		/*2174*/
	case CefResourceBundle_GetDataResource_2: {
		/*2175*/


		// gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
		auto ret_result = me->GetDataResource(v1->i32,
			*((void**)v2->ptr),
			*((size_t*)v3->ptr));
		/*2176*/
		MyCefSetBool(ret, ret_result);
		/*2177*/
	} break;
		/*2178*/
	case CefResourceBundle_GetDataResourceForScale_3: {
		/*2179*/


		// gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
		auto ret_result = me->GetDataResourceForScale(v1->i32,
			(CefResourceBundle::ScaleFactor)v2->i32,
			*((void**)v3->ptr),
			*((size_t*)v4->ptr));
		/*2180*/
		MyCefSetBool(ret, ret_result);
		/*2181*/
	} break;
		/*2182*/
	}
	/*2183*/
	CefResourceBundleCToCpp::Unwrap(me);
	/*2184*/
}


// [virtual] class CefResponse
/*2197*/
/*2185*/
const int CefResponse_IsReadOnly_1 = 1;
/*2186*/
const int CefResponse_GetError_2 = 2;
/*2187*/
const int CefResponse_SetError_3 = 3;
/*2188*/
const int CefResponse_GetStatus_4 = 4;
/*2189*/
const int CefResponse_SetStatus_5 = 5;
/*2190*/
const int CefResponse_GetStatusText_6 = 6;
/*2191*/
const int CefResponse_SetStatusText_7 = 7;
/*2192*/
const int CefResponse_GetMimeType_8 = 8;
/*2193*/
const int CefResponse_SetMimeType_9 = 9;
/*2194*/
const int CefResponse_GetHeader_10 = 10;
/*2195*/
const int CefResponse_GetHeaderMap_11 = 11;
/*2196*/
const int CefResponse_SetHeaderMap_12 = 12;

/*2198*/
void MyCefMet_CefResponse(cef_response_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2199*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2200*/
	auto me = CefResponseCToCpp::Wrap(me1);
	/*2201*/
	switch (metName) {
		/*2202*/
	case MET_Release:return; //yes, just return
							 /*2203*/
	case CefResponse_IsReadOnly_1: {
		/*2204*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*2205*/
		MyCefSetBool(ret, ret_result);
		/*2206*/
	} break;
		/*2207*/
	case CefResponse_GetError_2: {
		/*2208*/


		// gen! cef_errorcode_t GetError()
		auto ret_result = me->GetError();
		/*2209*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2210*/
	} break;
		/*2211*/
	case CefResponse_SetError_3: {
		/*2212*/


		// gen! void SetError(cef_errorcode_t error)
		me->SetError((cef_errorcode_t)v1->i32);
		/*2213*/

		/*2214*/
	} break;
		/*2215*/
	case CefResponse_GetStatus_4: {
		/*2216*/


		// gen! int GetStatus()
		auto ret_result = me->GetStatus();
		/*2217*/
		MyCefSetInt64(ret, ret_result);
		/*2218*/
	} break;
		/*2219*/
	case CefResponse_SetStatus_5: {
		/*2220*/


		// gen! void SetStatus(int status)
		me->SetStatus(v1->i32);
		/*2221*/

		/*2222*/
	} break;
		/*2223*/
	case CefResponse_GetStatusText_6: {
		/*2224*/


		// gen! CefString GetStatusText()
		auto ret_result = me->GetStatusText();
		/*2225*/
		SetCefStringToJsValue(ret, ret_result);
		/*2226*/
	} break;
		/*2227*/
	case CefResponse_SetStatusText_7: {
		/*2228*/


		// gen! void SetStatusText(const CefString& statusText)
		me->SetStatusText(GetStringHolder(v1)->value);
		/*2229*/

		/*2230*/
	} break;
		/*2231*/
	case CefResponse_GetMimeType_8: {
		/*2232*/


		// gen! CefString GetMimeType()
		auto ret_result = me->GetMimeType();
		/*2233*/
		SetCefStringToJsValue(ret, ret_result);
		/*2234*/
	} break;
		/*2235*/
	case CefResponse_SetMimeType_9: {
		/*2236*/


		// gen! void SetMimeType(const CefString& mimeType)
		me->SetMimeType(GetStringHolder(v1)->value);
		/*2237*/

		/*2238*/
	} break;
		/*2239*/
	case CefResponse_GetHeader_10: {
		/*2240*/


		// gen! CefString GetHeader(const CefString& name)
		auto ret_result = me->GetHeader(GetStringHolder(v1)->value);
		/*2241*/
		SetCefStringToJsValue(ret, ret_result);
		/*2242*/
	} break;
		/*2243*/
	case CefResponse_GetHeaderMap_11: {
		/*2244*/


		// gen! void GetHeaderMap(HeaderMap& headerMap)
		me->GetHeaderMap(*((CefResponse::HeaderMap*)v1->ptr));
		/*2245*/

		/*2246*/
	} break;
		/*2247*/
	case CefResponse_SetHeaderMap_12: {
		/*2248*/


		// gen! void SetHeaderMap(const HeaderMap& headerMap)
		me->SetHeaderMap(*((CefResponse::HeaderMap*)v1->ptr));
		/*2249*/

		/*2250*/
	} break;
		/*2251*/
	}
	/*2252*/
	CefResponseCToCpp::Unwrap(me);
	/*2253*/
}


// [virtual] class CefResponseFilter
/*2254*/

/*2255*/
void MyCefMet_CefResponseFilter(cef_response_filter_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2256*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2257*/
	auto me = CefResponseFilterCppToC::Unwrap(me1);
	/*2258*/
	switch (metName) {
		/*2259*/
	case MET_Release:return; //yes, just return
							 /*2260*/
	}
	/*2261*/
	CefResponseFilterCppToC::Wrap(me);
	/*2262*/
}


// [virtual] class CefSchemeHandlerFactory
/*2263*/

/*2264*/
void MyCefMet_CefSchemeHandlerFactory(cef_scheme_handler_factory_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2265*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2266*/
	auto me = CefSchemeHandlerFactoryCppToC::Unwrap(me1);
	/*2267*/
	switch (metName) {
		/*2268*/
	case MET_Release:return; //yes, just return
							 /*2269*/
	}
	/*2270*/
	CefSchemeHandlerFactoryCppToC::Wrap(me);
	/*2271*/
}


// [virtual] class CefSSLInfo
/*2274*/
/*2272*/
const int CefSSLInfo_GetCertStatus_1 = 1;
/*2273*/
const int CefSSLInfo_GetX509Certificate_2 = 2;

/*2275*/
void MyCefMet_CefSSLInfo(cef_sslinfo_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2276*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2277*/
	auto me = CefSSLInfoCToCpp::Wrap(me1);
	/*2278*/
	switch (metName) {
		/*2279*/
	case MET_Release:return; //yes, just return
							 /*2280*/
	case CefSSLInfo_GetCertStatus_1: {
		/*2281*/


		// gen! cef_cert_status_t GetCertStatus()
		auto ret_result = me->GetCertStatus();
		/*2282*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2283*/
	} break;
		/*2284*/
	case CefSSLInfo_GetX509Certificate_2: {
		/*2285*/


		// gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
		auto ret_result = me->GetX509Certificate();
		/*2286*/
		MyCefSetVoidPtr(ret, CefX509CertificateCToCpp::Unwrap(ret_result));
		/*2287*/
	} break;
		/*2288*/
	}
	/*2289*/
	CefSSLInfoCToCpp::Unwrap(me);
	/*2290*/
}


// [virtual] class CefSSLStatus
/*2296*/
/*2291*/
const int CefSSLStatus_IsSecureConnection_1 = 1;
/*2292*/
const int CefSSLStatus_GetCertStatus_2 = 2;
/*2293*/
const int CefSSLStatus_GetSSLVersion_3 = 3;
/*2294*/
const int CefSSLStatus_GetContentStatus_4 = 4;
/*2295*/
const int CefSSLStatus_GetX509Certificate_5 = 5;

/*2297*/
void MyCefMet_CefSSLStatus(cef_sslstatus_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2298*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2299*/
	auto me = CefSSLStatusCToCpp::Wrap(me1);
	/*2300*/
	switch (metName) {
		/*2301*/
	case MET_Release:return; //yes, just return
							 /*2302*/
	case CefSSLStatus_IsSecureConnection_1: {
		/*2303*/


		// gen! bool IsSecureConnection()
		auto ret_result = me->IsSecureConnection();
		/*2304*/
		MyCefSetBool(ret, ret_result);
		/*2305*/
	} break;
		/*2306*/
	case CefSSLStatus_GetCertStatus_2: {
		/*2307*/


		// gen! cef_cert_status_t GetCertStatus()
		auto ret_result = me->GetCertStatus();
		/*2308*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2309*/
	} break;
		/*2310*/
	case CefSSLStatus_GetSSLVersion_3: {
		/*2311*/


		// gen! cef_ssl_version_t GetSSLVersion()
		auto ret_result = me->GetSSLVersion();
		/*2312*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2313*/
	} break;
		/*2314*/
	case CefSSLStatus_GetContentStatus_4: {
		/*2315*/


		// gen! cef_ssl_content_status_t GetContentStatus()
		auto ret_result = me->GetContentStatus();
		/*2316*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2317*/
	} break;
		/*2318*/
	case CefSSLStatus_GetX509Certificate_5: {
		/*2319*/


		// gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
		auto ret_result = me->GetX509Certificate();
		/*2320*/
		MyCefSetVoidPtr(ret, CefX509CertificateCToCpp::Unwrap(ret_result));
		/*2321*/
	} break;
		/*2322*/
	}
	/*2323*/
	CefSSLStatusCToCpp::Unwrap(me);
	/*2324*/
}


// [virtual] class CefStreamReader
/*2330*/
/*2325*/
const int CefStreamReader_Read_1 = 1;
/*2326*/
const int CefStreamReader_Seek_2 = 2;
/*2327*/
const int CefStreamReader_Tell_3 = 3;
/*2328*/
const int CefStreamReader_Eof_4 = 4;
/*2329*/
const int CefStreamReader_MayBlock_5 = 5;

/*2331*/
void MyCefMet_CefStreamReader(cef_stream_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2332*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2333*/
	auto me = CefStreamReaderCToCpp::Wrap(me1);
	/*2334*/
	switch (metName) {
		/*2335*/
	case MET_Release:return; //yes, just return
							 /*2336*/
	case CefStreamReader_Read_1: {
		/*2337*/


		// gen! size_t Read(void* ptr,size_t size,size_t n)
		auto ret_result = me->Read((void*)v1->ptr,
			v2->i64,
			v3->i64);
		/*2338*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2339*/
	} break;
		/*2340*/
	case CefStreamReader_Seek_2: {
		/*2341*/


		// gen! int Seek(int64 offset,int whence)
		auto ret_result = me->Seek(v1->i64,
			v2->i32);
		/*2342*/
		MyCefSetInt64(ret, ret_result);
		/*2343*/
	} break;
		/*2344*/
	case CefStreamReader_Tell_3: {
		/*2345*/


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		/*2346*/
		MyCefSetInt64(ret, ret_result);
		/*2347*/
	} break;
		/*2348*/
	case CefStreamReader_Eof_4: {
		/*2349*/


		// gen! int Eof()
		auto ret_result = me->Eof();
		/*2350*/
		MyCefSetInt64(ret, ret_result);
		/*2351*/
	} break;
		/*2352*/
	case CefStreamReader_MayBlock_5: {
		/*2353*/


		// gen! bool MayBlock()
		auto ret_result = me->MayBlock();
		/*2354*/
		MyCefSetBool(ret, ret_result);
		/*2355*/
	} break;
		/*2356*/
	}
	/*2357*/
	CefStreamReaderCToCpp::Unwrap(me);
	/*2358*/
}


// [virtual] class CefStreamWriter
/*2364*/
/*2359*/
const int CefStreamWriter_Write_1 = 1;
/*2360*/
const int CefStreamWriter_Seek_2 = 2;
/*2361*/
const int CefStreamWriter_Tell_3 = 3;
/*2362*/
const int CefStreamWriter_Flush_4 = 4;
/*2363*/
const int CefStreamWriter_MayBlock_5 = 5;

/*2365*/
void MyCefMet_CefStreamWriter(cef_stream_writer_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2366*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2367*/
	auto me = CefStreamWriterCToCpp::Wrap(me1);
	/*2368*/
	switch (metName) {
		/*2369*/
	case MET_Release:return; //yes, just return
							 /*2370*/
	case CefStreamWriter_Write_1: {
		/*2371*/


		// gen! size_t Write(const void* ptr,size_t size,size_t n)
		auto ret_result = me->Write((void*)v1->ptr,
			v2->i64,
			v3->i64);
		/*2372*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2373*/
	} break;
		/*2374*/
	case CefStreamWriter_Seek_2: {
		/*2375*/


		// gen! int Seek(int64 offset,int whence)
		auto ret_result = me->Seek(v1->i64,
			v2->i32);
		/*2376*/
		MyCefSetInt64(ret, ret_result);
		/*2377*/
	} break;
		/*2378*/
	case CefStreamWriter_Tell_3: {
		/*2379*/


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		/*2380*/
		MyCefSetInt64(ret, ret_result);
		/*2381*/
	} break;
		/*2382*/
	case CefStreamWriter_Flush_4: {
		/*2383*/


		// gen! int Flush()
		auto ret_result = me->Flush();
		/*2384*/
		MyCefSetInt64(ret, ret_result);
		/*2385*/
	} break;
		/*2386*/
	case CefStreamWriter_MayBlock_5: {
		/*2387*/


		// gen! bool MayBlock()
		auto ret_result = me->MayBlock();
		/*2388*/
		MyCefSetBool(ret, ret_result);
		/*2389*/
	} break;
		/*2390*/
	}
	/*2391*/
	CefStreamWriterCToCpp::Unwrap(me);
	/*2392*/
}


// [virtual] class CefStringVisitor
/*2393*/

/*2394*/
void MyCefMet_CefStringVisitor(cef_string_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2395*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2396*/
	auto me = CefStringVisitorCppToC::Unwrap(me1);
	/*2397*/
	switch (metName) {
		/*2398*/
	case MET_Release:return; //yes, just return
							 /*2399*/
	}
	/*2400*/
	CefStringVisitorCppToC::Wrap(me);
	/*2401*/
}


// [virtual] class CefTask
/*2402*/

/*2403*/
void MyCefMet_CefTask(cef_task_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2404*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2405*/
	auto me = CefTaskCppToC::Unwrap(me1);
	/*2406*/
	switch (metName) {
		/*2407*/
	case MET_Release:return; //yes, just return
							 /*2408*/
	}
	/*2409*/
	CefTaskCppToC::Wrap(me);
	/*2410*/
}


// [virtual] class CefTaskRunner
/*2416*/
/*2411*/
const int CefTaskRunner_IsSame_1 = 1;
/*2412*/
const int CefTaskRunner_BelongsToCurrentThread_2 = 2;
/*2413*/
const int CefTaskRunner_BelongsToThread_3 = 3;
/*2414*/
const int CefTaskRunner_PostTask_4 = 4;
/*2415*/
const int CefTaskRunner_PostDelayedTask_5 = 5;

/*2417*/
void MyCefMet_CefTaskRunner(cef_task_runner_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2418*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2419*/
	auto me = CefTaskRunnerCToCpp::Wrap(me1);
	/*2420*/
	switch (metName) {
		/*2421*/
	case MET_Release:return; //yes, just return
							 /*2422*/
	case CefTaskRunner_IsSame_1: {
		/*2423*/


		// gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
		auto ret_result = me->IsSame(CefTaskRunnerCToCpp::Wrap((cef_task_runner_t*)v1->ptr));
		/*2424*/
		MyCefSetBool(ret, ret_result);
		/*2425*/
	} break;
		/*2426*/
	case CefTaskRunner_BelongsToCurrentThread_2: {
		/*2427*/


		// gen! bool BelongsToCurrentThread()
		auto ret_result = me->BelongsToCurrentThread();
		/*2428*/
		MyCefSetBool(ret, ret_result);
		/*2429*/
	} break;
		/*2430*/
	case CefTaskRunner_BelongsToThread_3: {
		/*2431*/


		// gen! bool BelongsToThread(CefThreadId threadId)
		auto ret_result = me->BelongsToThread((CefThreadId)v1->i32);
		/*2432*/
		MyCefSetBool(ret, ret_result);
		/*2433*/
	} break;
		/*2434*/
	case CefTaskRunner_PostTask_4: {
		/*2435*/


		// gen! bool PostTask(CefRefPtr<CefTask> task)
		auto ret_result = me->PostTask(CefTaskCppToC::Unwrap((cef_task_t*)v1->ptr));
		/*2436*/
		MyCefSetBool(ret, ret_result);
		/*2437*/
	} break;
		/*2438*/
	case CefTaskRunner_PostDelayedTask_5: {
		/*2439*/


		// gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
		auto ret_result = me->PostDelayedTask(CefTaskCppToC::Unwrap((cef_task_t*)v1->ptr),
			v2->i64);
		/*2440*/
		MyCefSetBool(ret, ret_result);
		/*2441*/
	} break;
		/*2442*/
	}
	/*2443*/
	CefTaskRunnerCToCpp::Unwrap(me);
	/*2444*/
}


// [virtual] class CefURLRequest
/*2451*/
/*2445*/
const int CefURLRequest_GetRequest_1 = 1;
/*2446*/
const int CefURLRequest_GetClient_2 = 2;
/*2447*/
const int CefURLRequest_GetRequestStatus_3 = 3;
/*2448*/
const int CefURLRequest_GetRequestError_4 = 4;
/*2449*/
const int CefURLRequest_GetResponse_5 = 5;
/*2450*/
const int CefURLRequest_Cancel_6 = 6;

/*2452*/
void MyCefMet_CefURLRequest(cef_urlrequest_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2453*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2454*/
	auto me = CefURLRequestCToCpp::Wrap(me1);
	/*2455*/
	switch (metName) {
		/*2456*/
	case MET_Release:return; //yes, just return
							 /*2457*/
	case CefURLRequest_GetRequest_1: {
		/*2458*/


		// gen! CefRefPtr<CefRequest> GetRequest()
		auto ret_result = me->GetRequest();
		/*2459*/
		MyCefSetVoidPtr(ret, CefRequestCToCpp::Unwrap(ret_result));
		/*2460*/
	} break;
		/*2461*/
	case CefURLRequest_GetClient_2: {
		/*2462*/


		// gen! CefRefPtr<CefURLRequestClient> GetClient()
		auto ret_result = me->GetClient();
		/*2463*/
		MyCefSetVoidPtr(ret, CefURLRequestClientCppToC::Wrap(ret_result));
		/*2464*/
	} break;
		/*2465*/
	case CefURLRequest_GetRequestStatus_3: {
		/*2466*/


		// gen! Status GetRequestStatus()
		auto ret_result = me->GetRequestStatus();
		/*2467*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2468*/
	} break;
		/*2469*/
	case CefURLRequest_GetRequestError_4: {
		/*2470*/


		// gen! ErrorCode GetRequestError()
		auto ret_result = me->GetRequestError();
		/*2471*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2472*/
	} break;
		/*2473*/
	case CefURLRequest_GetResponse_5: {
		/*2474*/


		// gen! CefRefPtr<CefResponse> GetResponse()
		auto ret_result = me->GetResponse();
		/*2475*/
		MyCefSetVoidPtr(ret, CefResponseCToCpp::Unwrap(ret_result));
		/*2476*/
	} break;
		/*2477*/
	case CefURLRequest_Cancel_6: {
		/*2478*/


		// gen! void Cancel()
		me->Cancel();
		/*2479*/

		/*2480*/
	} break;
		/*2481*/
	}
	/*2482*/
	CefURLRequestCToCpp::Unwrap(me);
	/*2483*/
}


// [virtual] class CefURLRequestClient
/*2484*/

/*2485*/
void MyCefMet_CefURLRequestClient(cef_urlrequest_client_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2486*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2487*/
	auto me = CefURLRequestClientCppToC::Unwrap(me1);
	/*2488*/
	switch (metName) {
		/*2489*/
	case MET_Release:return; //yes, just return
							 /*2490*/
	}
	/*2491*/
	CefURLRequestClientCppToC::Wrap(me);
	/*2492*/
}


// [virtual] class CefV8Context
/*2502*/
/*2493*/
const int CefV8Context_GetTaskRunner_1 = 1;
/*2494*/
const int CefV8Context_IsValid_2 = 2;
/*2495*/
const int CefV8Context_GetBrowser_3 = 3;
/*2496*/
const int CefV8Context_GetFrame_4 = 4;
/*2497*/
const int CefV8Context_GetGlobal_5 = 5;
/*2498*/
const int CefV8Context_Enter_6 = 6;
/*2499*/
const int CefV8Context_Exit_7 = 7;
/*2500*/
const int CefV8Context_IsSame_8 = 8;
/*2501*/
const int CefV8Context_Eval_9 = 9;

/*2503*/
void MyCefMet_CefV8Context(cef_v8context_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2504*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2505*/
	auto me = CefV8ContextCToCpp::Wrap(me1);
	/*2506*/
	switch (metName) {
		/*2507*/
	case MET_Release:return; //yes, just return
							 /*2508*/
	case CefV8Context_GetTaskRunner_1: {
		/*2509*/


		// gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
		auto ret_result = me->GetTaskRunner();
		/*2510*/
		MyCefSetVoidPtr(ret, CefTaskRunnerCToCpp::Unwrap(ret_result));
		/*2511*/
	} break;
		/*2512*/
	case CefV8Context_IsValid_2: {
		/*2513*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*2514*/
		MyCefSetBool(ret, ret_result);
		/*2515*/
	} break;
		/*2516*/
	case CefV8Context_GetBrowser_3: {
		/*2517*/


		// gen! CefRefPtr<CefBrowser> GetBrowser()
		auto ret_result = me->GetBrowser();
		/*2518*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*2519*/
	} break;
		/*2520*/
	case CefV8Context_GetFrame_4: {
		/*2521*/


		// gen! CefRefPtr<CefFrame> GetFrame()
		auto ret_result = me->GetFrame();
		/*2522*/
		MyCefSetVoidPtr(ret, CefFrameCToCpp::Unwrap(ret_result));
		/*2523*/
	} break;
		/*2524*/
	case CefV8Context_GetGlobal_5: {
		/*2525*/


		// gen! CefRefPtr<CefV8Value> GetGlobal()
		auto ret_result = me->GetGlobal();
		/*2526*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*2527*/
	} break;
		/*2528*/
	case CefV8Context_Enter_6: {
		/*2529*/


		// gen! bool Enter()
		auto ret_result = me->Enter();
		/*2530*/
		MyCefSetBool(ret, ret_result);
		/*2531*/
	} break;
		/*2532*/
	case CefV8Context_Exit_7: {
		/*2533*/


		// gen! bool Exit()
		auto ret_result = me->Exit();
		/*2534*/
		MyCefSetBool(ret, ret_result);
		/*2535*/
	} break;
		/*2536*/
	case CefV8Context_IsSame_8: {
		/*2537*/


		// gen! bool IsSame(CefRefPtr<CefV8Context> that)
		auto ret_result = me->IsSame(CefV8ContextCToCpp::Wrap((cef_v8context_t*)v1->ptr));
		/*2538*/
		MyCefSetBool(ret, ret_result);
		/*2539*/
	} break;
		/*2540*/
	case CefV8Context_Eval_9: {
		/*2541*/


		// gen! bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
		auto ret_result = me->Eval(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value,
			v3->i32,
			*((CefRefPtr<CefV8Value>*)v4->ptr),
			*((CefRefPtr<CefV8Exception>*)v5->ptr));
		/*2542*/
		MyCefSetBool(ret, ret_result);
		/*2543*/
	} break;
		/*2544*/
	}
	/*2545*/
	CefV8ContextCToCpp::Unwrap(me);
	/*2546*/
}


// [virtual] class CefV8Accessor
/*2547*/

/*2548*/
void MyCefMet_CefV8Accessor(cef_v8accessor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2549*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2550*/
	auto me = CefV8AccessorCppToC::Unwrap(me1);
	/*2551*/
	switch (metName) {
		/*2552*/
	case MET_Release:return; //yes, just return
							 /*2553*/
	}
	/*2554*/
	CefV8AccessorCppToC::Wrap(me);
	/*2555*/
}


// [virtual] class CefV8Interceptor
/*2556*/

/*2557*/
void MyCefMet_CefV8Interceptor(cef_v8interceptor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2558*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2559*/
	auto me = CefV8InterceptorCppToC::Unwrap(me1);
	/*2560*/
	switch (metName) {
		/*2561*/
	case MET_Release:return; //yes, just return
							 /*2562*/
	}
	/*2563*/
	CefV8InterceptorCppToC::Wrap(me);
	/*2564*/
}


// [virtual] class CefV8Exception
/*2573*/
/*2565*/
const int CefV8Exception_GetMessage_1 = 1;
/*2566*/
const int CefV8Exception_GetSourceLine_2 = 2;
/*2567*/
const int CefV8Exception_GetScriptResourceName_3 = 3;
/*2568*/
const int CefV8Exception_GetLineNumber_4 = 4;
/*2569*/
const int CefV8Exception_GetStartPosition_5 = 5;
/*2570*/
const int CefV8Exception_GetEndPosition_6 = 6;
/*2571*/
const int CefV8Exception_GetStartColumn_7 = 7;
/*2572*/
const int CefV8Exception_GetEndColumn_8 = 8;

/*2574*/
void MyCefMet_CefV8Exception(cef_v8exception_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2575*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2576*/
	auto me = CefV8ExceptionCToCpp::Wrap(me1);
	/*2577*/
	switch (metName) {
		/*2578*/
	case MET_Release:return; //yes, just return
							 /*2579*/
	case CefV8Exception_GetMessage_1: {
		/*2580*/


		// gen! CefString GetMessage()
		auto ret_result = me->GetMessage();
		/*2581*/
		SetCefStringToJsValue(ret, ret_result);
		/*2582*/
	} break;
		/*2583*/
	case CefV8Exception_GetSourceLine_2: {
		/*2584*/


		// gen! CefString GetSourceLine()
		auto ret_result = me->GetSourceLine();
		/*2585*/
		SetCefStringToJsValue(ret, ret_result);
		/*2586*/
	} break;
		/*2587*/
	case CefV8Exception_GetScriptResourceName_3: {
		/*2588*/


		// gen! CefString GetScriptResourceName()
		auto ret_result = me->GetScriptResourceName();
		/*2589*/
		SetCefStringToJsValue(ret, ret_result);
		/*2590*/
	} break;
		/*2591*/
	case CefV8Exception_GetLineNumber_4: {
		/*2592*/


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		/*2593*/
		MyCefSetInt64(ret, ret_result);
		/*2594*/
	} break;
		/*2595*/
	case CefV8Exception_GetStartPosition_5: {
		/*2596*/


		// gen! int GetStartPosition()
		auto ret_result = me->GetStartPosition();
		/*2597*/
		MyCefSetInt64(ret, ret_result);
		/*2598*/
	} break;
		/*2599*/
	case CefV8Exception_GetEndPosition_6: {
		/*2600*/


		// gen! int GetEndPosition()
		auto ret_result = me->GetEndPosition();
		/*2601*/
		MyCefSetInt64(ret, ret_result);
		/*2602*/
	} break;
		/*2603*/
	case CefV8Exception_GetStartColumn_7: {
		/*2604*/


		// gen! int GetStartColumn()
		auto ret_result = me->GetStartColumn();
		/*2605*/
		MyCefSetInt64(ret, ret_result);
		/*2606*/
	} break;
		/*2607*/
	case CefV8Exception_GetEndColumn_8: {
		/*2608*/


		// gen! int GetEndColumn()
		auto ret_result = me->GetEndColumn();
		/*2609*/
		MyCefSetInt64(ret, ret_result);
		/*2610*/
	} break;
		/*2611*/
	}
	/*2612*/
	CefV8ExceptionCToCpp::Unwrap(me);
	/*2613*/
}


// [virtual] class CefV8Value
/*2658*/
/*2614*/
const int CefV8Value_IsValid_1 = 1;
/*2615*/
const int CefV8Value_IsUndefined_2 = 2;
/*2616*/
const int CefV8Value_IsNull_3 = 3;
/*2617*/
const int CefV8Value_IsBool_4 = 4;
/*2618*/
const int CefV8Value_IsInt_5 = 5;
/*2619*/
const int CefV8Value_IsUInt_6 = 6;
/*2620*/
const int CefV8Value_IsDouble_7 = 7;
/*2621*/
const int CefV8Value_IsDate_8 = 8;
/*2622*/
const int CefV8Value_IsString_9 = 9;
/*2623*/
const int CefV8Value_IsObject_10 = 10;
/*2624*/
const int CefV8Value_IsArray_11 = 11;
/*2625*/
const int CefV8Value_IsFunction_12 = 12;
/*2626*/
const int CefV8Value_IsSame_13 = 13;
/*2627*/
const int CefV8Value_GetBoolValue_14 = 14;
/*2628*/
const int CefV8Value_GetIntValue_15 = 15;
/*2629*/
const int CefV8Value_GetUIntValue_16 = 16;
/*2630*/
const int CefV8Value_GetDoubleValue_17 = 17;
/*2631*/
const int CefV8Value_GetDateValue_18 = 18;
/*2632*/
const int CefV8Value_GetStringValue_19 = 19;
/*2633*/
const int CefV8Value_IsUserCreated_20 = 20;
/*2634*/
const int CefV8Value_HasException_21 = 21;
/*2635*/
const int CefV8Value_GetException_22 = 22;
/*2636*/
const int CefV8Value_ClearException_23 = 23;
/*2637*/
const int CefV8Value_WillRethrowExceptions_24 = 24;
/*2638*/
const int CefV8Value_SetRethrowExceptions_25 = 25;
/*2639*/
const int CefV8Value_HasValue_26 = 26;
/*2640*/
const int CefV8Value_HasValue_27 = 27;
/*2641*/
const int CefV8Value_DeleteValue_28 = 28;
/*2642*/
const int CefV8Value_DeleteValue_29 = 29;
/*2643*/
const int CefV8Value_GetValue_30 = 30;
/*2644*/
const int CefV8Value_GetValue_31 = 31;
/*2645*/
const int CefV8Value_SetValue_32 = 32;
/*2646*/
const int CefV8Value_SetValue_33 = 33;
/*2647*/
const int CefV8Value_SetValue_34 = 34;
/*2648*/
const int CefV8Value_GetKeys_35 = 35;
/*2649*/
const int CefV8Value_SetUserData_36 = 36;
/*2650*/
const int CefV8Value_GetUserData_37 = 37;
/*2651*/
const int CefV8Value_GetExternallyAllocatedMemory_38 = 38;
/*2652*/
const int CefV8Value_AdjustExternallyAllocatedMemory_39 = 39;
/*2653*/
const int CefV8Value_GetArrayLength_40 = 40;
/*2654*/
const int CefV8Value_GetFunctionName_41 = 41;
/*2655*/
const int CefV8Value_GetFunctionHandler_42 = 42;
/*2656*/
const int CefV8Value_ExecuteFunction_43 = 43;
/*2657*/
const int CefV8Value_ExecuteFunctionWithContext_44 = 44;

/*2659*/
void MyCefMet_CefV8Value(cef_v8value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2660*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2661*/
	auto me = CefV8ValueCToCpp::Wrap(me1);
	/*2662*/
	switch (metName) {
		/*2663*/
	case MET_Release:return; //yes, just return
							 /*2664*/
	case CefV8Value_IsValid_1: {
		/*2665*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*2666*/
		MyCefSetBool(ret, ret_result);
		/*2667*/
	} break;
		/*2668*/
	case CefV8Value_IsUndefined_2: {
		/*2669*/


		// gen! bool IsUndefined()
		auto ret_result = me->IsUndefined();
		/*2670*/
		MyCefSetBool(ret, ret_result);
		/*2671*/
	} break;
		/*2672*/
	case CefV8Value_IsNull_3: {
		/*2673*/


		// gen! bool IsNull()
		auto ret_result = me->IsNull();
		/*2674*/
		MyCefSetBool(ret, ret_result);
		/*2675*/
	} break;
		/*2676*/
	case CefV8Value_IsBool_4: {
		/*2677*/


		// gen! bool IsBool()
		auto ret_result = me->IsBool();
		/*2678*/
		MyCefSetBool(ret, ret_result);
		/*2679*/
	} break;
		/*2680*/
	case CefV8Value_IsInt_5: {
		/*2681*/


		// gen! bool IsInt()
		auto ret_result = me->IsInt();
		/*2682*/
		MyCefSetBool(ret, ret_result);
		/*2683*/
	} break;
		/*2684*/
	case CefV8Value_IsUInt_6: {
		/*2685*/


		// gen! bool IsUInt()
		auto ret_result = me->IsUInt();
		/*2686*/
		MyCefSetBool(ret, ret_result);
		/*2687*/
	} break;
		/*2688*/
	case CefV8Value_IsDouble_7: {
		/*2689*/


		// gen! bool IsDouble()
		auto ret_result = me->IsDouble();
		/*2690*/
		MyCefSetBool(ret, ret_result);
		/*2691*/
	} break;
		/*2692*/
	case CefV8Value_IsDate_8: {
		/*2693*/


		// gen! bool IsDate()
		auto ret_result = me->IsDate();
		/*2694*/
		MyCefSetBool(ret, ret_result);
		/*2695*/
	} break;
		/*2696*/
	case CefV8Value_IsString_9: {
		/*2697*/


		// gen! bool IsString()
		auto ret_result = me->IsString();
		/*2698*/
		MyCefSetBool(ret, ret_result);
		/*2699*/
	} break;
		/*2700*/
	case CefV8Value_IsObject_10: {
		/*2701*/


		// gen! bool IsObject()
		auto ret_result = me->IsObject();
		/*2702*/
		MyCefSetBool(ret, ret_result);
		/*2703*/
	} break;
		/*2704*/
	case CefV8Value_IsArray_11: {
		/*2705*/


		// gen! bool IsArray()
		auto ret_result = me->IsArray();
		/*2706*/
		MyCefSetBool(ret, ret_result);
		/*2707*/
	} break;
		/*2708*/
	case CefV8Value_IsFunction_12: {
		/*2709*/


		// gen! bool IsFunction()
		auto ret_result = me->IsFunction();
		/*2710*/
		MyCefSetBool(ret, ret_result);
		/*2711*/
	} break;
		/*2712*/
	case CefV8Value_IsSame_13: {
		/*2713*/


		// gen! bool IsSame(CefRefPtr<CefV8Value> that)
		auto ret_result = me->IsSame(CefV8ValueCToCpp::Wrap((cef_v8value_t*)v1->ptr));
		/*2714*/
		MyCefSetBool(ret, ret_result);
		/*2715*/
	} break;
		/*2716*/
	case CefV8Value_GetBoolValue_14: {
		/*2717*/


		// gen! bool GetBoolValue()
		auto ret_result = me->GetBoolValue();
		/*2718*/
		MyCefSetBool(ret, ret_result);
		/*2719*/
	} break;
		/*2720*/
	case CefV8Value_GetIntValue_15: {
		/*2721*/


		// gen! int32 GetIntValue()
		auto ret_result = me->GetIntValue();
		/*2722*/
		MyCefSetInt32(ret, ret_result);
		/*2723*/
	} break;
		/*2724*/
	case CefV8Value_GetUIntValue_16: {
		/*2725*/


		// gen! uint32 GetUIntValue()
		auto ret_result = me->GetUIntValue();
		/*2726*/
		MyCefSetUInt32(ret, ret_result);
		/*2727*/
	} break;
		/*2728*/
	case CefV8Value_GetDoubleValue_17: {
		/*2729*/


		// gen! double GetDoubleValue()
		auto ret_result = me->GetDoubleValue();
		/*2730*/
		MyCefSetDouble(ret, ret_result);
		/*2731*/
	} break;
		/*2732*/
	case CefV8Value_GetDateValue_18: {
		/*2733*/


		// gen! CefTime GetDateValue()
		auto ret_result = me->GetDateValue();
		/*2734*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*2735*/
	} break;
		/*2736*/
	case CefV8Value_GetStringValue_19: {
		/*2737*/


		// gen! CefString GetStringValue()
		auto ret_result = me->GetStringValue();
		/*2738*/
		SetCefStringToJsValue(ret, ret_result);
		/*2739*/
	} break;
		/*2740*/
	case CefV8Value_IsUserCreated_20: {
		/*2741*/


		// gen! bool IsUserCreated()
		auto ret_result = me->IsUserCreated();
		/*2742*/
		MyCefSetBool(ret, ret_result);
		/*2743*/
	} break;
		/*2744*/
	case CefV8Value_HasException_21: {
		/*2745*/


		// gen! bool HasException()
		auto ret_result = me->HasException();
		/*2746*/
		MyCefSetBool(ret, ret_result);
		/*2747*/
	} break;
		/*2748*/
	case CefV8Value_GetException_22: {
		/*2749*/


		// gen! CefRefPtr<CefV8Exception> GetException()
		auto ret_result = me->GetException();
		/*2750*/
		MyCefSetVoidPtr(ret, CefV8ExceptionCToCpp::Unwrap(ret_result));
		/*2751*/
	} break;
		/*2752*/
	case CefV8Value_ClearException_23: {
		/*2753*/


		// gen! bool ClearException()
		auto ret_result = me->ClearException();
		/*2754*/
		MyCefSetBool(ret, ret_result);
		/*2755*/
	} break;
		/*2756*/
	case CefV8Value_WillRethrowExceptions_24: {
		/*2757*/


		// gen! bool WillRethrowExceptions()
		auto ret_result = me->WillRethrowExceptions();
		/*2758*/
		MyCefSetBool(ret, ret_result);
		/*2759*/
	} break;
		/*2760*/
	case CefV8Value_SetRethrowExceptions_25: {
		/*2761*/


		// gen! bool SetRethrowExceptions(bool rethrow)
		auto ret_result = me->SetRethrowExceptions(v1->i32 != 0);
		/*2762*/
		MyCefSetBool(ret, ret_result);
		/*2763*/
	} break;
		/*2764*/
	case CefV8Value_HasValue_26: {
		/*2765*/


		// gen! bool HasValue(const CefString& key)
		auto ret_result = me->HasValue(GetStringHolder(v1)->value);
		/*2766*/
		MyCefSetBool(ret, ret_result);
		/*2767*/
	} break;
		/*2768*/
	case CefV8Value_HasValue_27: {
		/*2769*/


		// gen! bool HasValue(int index)
		auto ret_result = me->HasValue(v1->i32);
		/*2770*/
		MyCefSetBool(ret, ret_result);
		/*2771*/
	} break;
		/*2772*/
	case CefV8Value_DeleteValue_28: {
		/*2773*/


		// gen! bool DeleteValue(const CefString& key)
		auto ret_result = me->DeleteValue(GetStringHolder(v1)->value);
		/*2774*/
		MyCefSetBool(ret, ret_result);
		/*2775*/
	} break;
		/*2776*/
	case CefV8Value_DeleteValue_29: {
		/*2777*/


		// gen! bool DeleteValue(int index)
		auto ret_result = me->DeleteValue(v1->i32);
		/*2778*/
		MyCefSetBool(ret, ret_result);
		/*2779*/
	} break;
		/*2780*/
	case CefV8Value_GetValue_30: {
		/*2781*/


		// gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)
		auto ret_result = me->GetValue(GetStringHolder(v1)->value);
		/*2782*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*2783*/
	} break;
		/*2784*/
	case CefV8Value_GetValue_31: {
		/*2785*/


		// gen! CefRefPtr<CefV8Value> GetValue(int index)
		auto ret_result = me->GetValue(v1->i32);
		/*2786*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*2787*/
	} break;
		/*2788*/
	case CefV8Value_SetValue_32: {
		/*2789*/


		// gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			(CefV8Value::PropertyAttribute)v3->i32);
		/*2790*/
		MyCefSetBool(ret, ret_result);
		/*2791*/
	} break;
		/*2792*/
	case CefV8Value_SetValue_33: {
		/*2793*/


		// gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)
		auto ret_result = me->SetValue(v1->i32,
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr));
		/*2794*/
		MyCefSetBool(ret, ret_result);
		/*2795*/
	} break;
		/*2796*/
	case CefV8Value_SetValue_34: {
		/*2797*/


		// gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			(CefV8Value::AccessControl)v2->i32,
			(CefV8Value::PropertyAttribute)v3->i32);
		/*2798*/
		MyCefSetBool(ret, ret_result);
		/*2799*/
	} break;
		/*2800*/
	case CefV8Value_GetKeys_35: {
		/*2801*/


		// gen! bool GetKeys(std::vector<CefString>& keys)
		auto ret_result = me->GetKeys(*((std::vector<CefString>*)v1->ptr));
		/*2802*/
		MyCefSetBool(ret, ret_result);
		/*2803*/
	} break;
		/*2804*/
	case CefV8Value_SetUserData_36: {
		/*2805*/


		// gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
		//auto ret_result = me->SetUserData(v1->ptr);
		///*2806*/
		//MyCefSetBool(ret, ret_result);
		/*2807*/
	} break;
		/*2808*/
	case CefV8Value_GetUserData_37: {
		/*2809*/


		// gen! CefRefPtr<CefBaseRefCounted> GetUserData()
		auto ret_result = me->GetUserData();
		/*2810*/

		/*2811*/
	} break;
		/*2812*/
	case CefV8Value_GetExternallyAllocatedMemory_38: {
		/*2813*/


		// gen! int GetExternallyAllocatedMemory()
		auto ret_result = me->GetExternallyAllocatedMemory();
		/*2814*/
		MyCefSetInt64(ret, ret_result);
		/*2815*/
	} break;
		/*2816*/
	case CefV8Value_AdjustExternallyAllocatedMemory_39: {
		/*2817*/


		// gen! int AdjustExternallyAllocatedMemory(int change_in_bytes)
		auto ret_result = me->AdjustExternallyAllocatedMemory(v1->i32);
		/*2818*/
		MyCefSetInt64(ret, ret_result);
		/*2819*/
	} break;
		/*2820*/
	case CefV8Value_GetArrayLength_40: {
		/*2821*/


		// gen! int GetArrayLength()
		auto ret_result = me->GetArrayLength();
		/*2822*/
		MyCefSetInt64(ret, ret_result);
		/*2823*/
	} break;
		/*2824*/
	case CefV8Value_GetFunctionName_41: {
		/*2825*/


		// gen! CefString GetFunctionName()
		auto ret_result = me->GetFunctionName();
		/*2826*/
		SetCefStringToJsValue(ret, ret_result);
		/*2827*/
	} break;
		/*2828*/
	case CefV8Value_GetFunctionHandler_42: {
		/*2829*/


		// gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
		auto ret_result = me->GetFunctionHandler();
		/*2830*/
		MyCefSetVoidPtr(ret, CefV8HandlerCppToC::Wrap(ret_result));
		/*2831*/
	} break;
		/*2832*/
	case CefV8Value_ExecuteFunction_43: {
		/*2833*/


		// gen! CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
		auto ret_result = me->ExecuteFunction(CefV8ValueCToCpp::Wrap((cef_v8value_t*)v1->ptr),
			*((CefV8ValueList*)v2->ptr));
		/*2834*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*2835*/
	} break;
		/*2836*/
	case CefV8Value_ExecuteFunctionWithContext_44: {
		/*2837*/


		// gen! CefRefPtr<CefV8Value> ExecuteFunctionWithContext(CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
		auto ret_result = me->ExecuteFunctionWithContext(CefV8ContextCToCpp::Wrap((cef_v8context_t*)v1->ptr),
			CefV8ValueCToCpp::Wrap((cef_v8value_t*)v2->ptr),
			*((CefV8ValueList*)v3->ptr));
		/*2838*/
		MyCefSetVoidPtr(ret, CefV8ValueCToCpp::Unwrap(ret_result));
		/*2839*/
	} break;
		/*2840*/
	}
	/*2841*/
	CefV8ValueCToCpp::Unwrap(me);
	/*2842*/
}


// [virtual] class CefV8StackTrace
/*2846*/
/*2843*/
const int CefV8StackTrace_IsValid_1 = 1;
/*2844*/
const int CefV8StackTrace_GetFrameCount_2 = 2;
/*2845*/
const int CefV8StackTrace_GetFrame_3 = 3;

/*2847*/
void MyCefMet_CefV8StackTrace(cef_v8stack_trace_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2848*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2849*/
	auto me = CefV8StackTraceCToCpp::Wrap(me1);
	/*2850*/
	switch (metName) {
		/*2851*/
	case MET_Release:return; //yes, just return
							 /*2852*/
	case CefV8StackTrace_IsValid_1: {
		/*2853*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*2854*/
		MyCefSetBool(ret, ret_result);
		/*2855*/
	} break;
		/*2856*/
	case CefV8StackTrace_GetFrameCount_2: {
		/*2857*/


		// gen! int GetFrameCount()
		auto ret_result = me->GetFrameCount();
		/*2858*/
		MyCefSetInt64(ret, ret_result);
		/*2859*/
	} break;
		/*2860*/
	case CefV8StackTrace_GetFrame_3: {
		/*2861*/


		// gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
		auto ret_result = me->GetFrame(v1->i32);
		/*2862*/
		MyCefSetVoidPtr(ret, CefV8StackFrameCToCpp::Unwrap(ret_result));
		/*2863*/
	} break;
		/*2864*/
	}
	/*2865*/
	CefV8StackTraceCToCpp::Unwrap(me);
	/*2866*/
}


// [virtual] class CefV8StackFrame
/*2875*/
/*2867*/
const int CefV8StackFrame_IsValid_1 = 1;
/*2868*/
const int CefV8StackFrame_GetScriptName_2 = 2;
/*2869*/
const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = 3;
/*2870*/
const int CefV8StackFrame_GetFunctionName_4 = 4;
/*2871*/
const int CefV8StackFrame_GetLineNumber_5 = 5;
/*2872*/
const int CefV8StackFrame_GetColumn_6 = 6;
/*2873*/
const int CefV8StackFrame_IsEval_7 = 7;
/*2874*/
const int CefV8StackFrame_IsConstructor_8 = 8;

/*2876*/
void MyCefMet_CefV8StackFrame(cef_v8stack_frame_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2877*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2878*/
	auto me = CefV8StackFrameCToCpp::Wrap(me1);
	/*2879*/
	switch (metName) {
		/*2880*/
	case MET_Release:return; //yes, just return
							 /*2881*/
	case CefV8StackFrame_IsValid_1: {
		/*2882*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*2883*/
		MyCefSetBool(ret, ret_result);
		/*2884*/
	} break;
		/*2885*/
	case CefV8StackFrame_GetScriptName_2: {
		/*2886*/


		// gen! CefString GetScriptName()
		auto ret_result = me->GetScriptName();
		/*2887*/
		SetCefStringToJsValue(ret, ret_result);
		/*2888*/
	} break;
		/*2889*/
	case CefV8StackFrame_GetScriptNameOrSourceURL_3: {
		/*2890*/


		// gen! CefString GetScriptNameOrSourceURL()
		auto ret_result = me->GetScriptNameOrSourceURL();
		/*2891*/
		SetCefStringToJsValue(ret, ret_result);
		/*2892*/
	} break;
		/*2893*/
	case CefV8StackFrame_GetFunctionName_4: {
		/*2894*/


		// gen! CefString GetFunctionName()
		auto ret_result = me->GetFunctionName();
		/*2895*/
		SetCefStringToJsValue(ret, ret_result);
		/*2896*/
	} break;
		/*2897*/
	case CefV8StackFrame_GetLineNumber_5: {
		/*2898*/


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		/*2899*/
		MyCefSetInt64(ret, ret_result);
		/*2900*/
	} break;
		/*2901*/
	case CefV8StackFrame_GetColumn_6: {
		/*2902*/


		// gen! int GetColumn()
		auto ret_result = me->GetColumn();
		/*2903*/
		MyCefSetInt64(ret, ret_result);
		/*2904*/
	} break;
		/*2905*/
	case CefV8StackFrame_IsEval_7: {
		/*2906*/


		// gen! bool IsEval()
		auto ret_result = me->IsEval();
		/*2907*/
		MyCefSetBool(ret, ret_result);
		/*2908*/
	} break;
		/*2909*/
	case CefV8StackFrame_IsConstructor_8: {
		/*2910*/


		// gen! bool IsConstructor()
		auto ret_result = me->IsConstructor();
		/*2911*/
		MyCefSetBool(ret, ret_result);
		/*2912*/
	} break;
		/*2913*/
	}
	/*2914*/
	CefV8StackFrameCToCpp::Unwrap(me);
	/*2915*/
}


// [virtual] class CefValue
/*2938*/
/*2916*/
const int CefValue_IsValid_1 = 1;
/*2917*/
const int CefValue_IsOwned_2 = 2;
/*2918*/
const int CefValue_IsReadOnly_3 = 3;
/*2919*/
const int CefValue_IsSame_4 = 4;
/*2920*/
const int CefValue_IsEqual_5 = 5;
/*2921*/
const int CefValue_Copy_6 = 6;
/*2922*/
const int CefValue_GetType_7 = 7;
/*2923*/
const int CefValue_GetBool_8 = 8;
/*2924*/
const int CefValue_GetInt_9 = 9;
/*2925*/
const int CefValue_GetDouble_10 = 10;
/*2926*/
const int CefValue_GetString_11 = 11;
/*2927*/
const int CefValue_GetBinary_12 = 12;
/*2928*/
const int CefValue_GetDictionary_13 = 13;
/*2929*/
const int CefValue_GetList_14 = 14;
/*2930*/
const int CefValue_SetNull_15 = 15;
/*2931*/
const int CefValue_SetBool_16 = 16;
/*2932*/
const int CefValue_SetInt_17 = 17;
/*2933*/
const int CefValue_SetDouble_18 = 18;
/*2934*/
const int CefValue_SetString_19 = 19;
/*2935*/
const int CefValue_SetBinary_20 = 20;
/*2936*/
const int CefValue_SetDictionary_21 = 21;
/*2937*/
const int CefValue_SetList_22 = 22;

/*2939*/
void MyCefMet_CefValue(cef_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*2940*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*2941*/
	auto me = CefValueCToCpp::Wrap(me1);
	/*2942*/
	switch (metName) {
		/*2943*/
	case MET_Release:return; //yes, just return
							 /*2944*/
	case CefValue_IsValid_1: {
		/*2945*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*2946*/
		MyCefSetBool(ret, ret_result);
		/*2947*/
	} break;
		/*2948*/
	case CefValue_IsOwned_2: {
		/*2949*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*2950*/
		MyCefSetBool(ret, ret_result);
		/*2951*/
	} break;
		/*2952*/
	case CefValue_IsReadOnly_3: {
		/*2953*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*2954*/
		MyCefSetBool(ret, ret_result);
		/*2955*/
	} break;
		/*2956*/
	case CefValue_IsSame_4: {
		/*2957*/


		// gen! bool IsSame(CefRefPtr<CefValue> that)
		auto ret_result = me->IsSame(CefValueCToCpp::Wrap((cef_value_t*)v1->ptr));
		/*2958*/
		MyCefSetBool(ret, ret_result);
		/*2959*/
	} break;
		/*2960*/
	case CefValue_IsEqual_5: {
		/*2961*/


		// gen! bool IsEqual(CefRefPtr<CefValue> that)
		auto ret_result = me->IsEqual(CefValueCToCpp::Wrap((cef_value_t*)v1->ptr));
		/*2962*/
		MyCefSetBool(ret, ret_result);
		/*2963*/
	} break;
		/*2964*/
	case CefValue_Copy_6: {
		/*2965*/


		// gen! CefRefPtr<CefValue> Copy()
		auto ret_result = me->Copy();
		/*2966*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*2967*/
	} break;
		/*2968*/
	case CefValue_GetType_7: {
		/*2969*/


		// gen! CefValueType GetType()
		auto ret_result = me->GetType();
		/*2970*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*2971*/
	} break;
		/*2972*/
	case CefValue_GetBool_8: {
		/*2973*/


		// gen! bool GetBool()
		auto ret_result = me->GetBool();
		/*2974*/
		MyCefSetBool(ret, ret_result);
		/*2975*/
	} break;
		/*2976*/
	case CefValue_GetInt_9: {
		/*2977*/


		// gen! int GetInt()
		auto ret_result = me->GetInt();
		/*2978*/
		MyCefSetInt64(ret, ret_result);
		/*2979*/
	} break;
		/*2980*/
	case CefValue_GetDouble_10: {
		/*2981*/


		// gen! double GetDouble()
		auto ret_result = me->GetDouble();
		/*2982*/
		MyCefSetDouble(ret, ret_result);
		/*2983*/
	} break;
		/*2984*/
	case CefValue_GetString_11: {
		/*2985*/


		// gen! CefString GetString()
		auto ret_result = me->GetString();
		/*2986*/
		SetCefStringToJsValue(ret, ret_result);
		/*2987*/
	} break;
		/*2988*/
	case CefValue_GetBinary_12: {
		/*2989*/


		// gen! CefRefPtr<CefBinaryValue> GetBinary()
		auto ret_result = me->GetBinary();
		/*2990*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*2991*/
	} break;
		/*2992*/
	case CefValue_GetDictionary_13: {
		/*2993*/


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary()
		auto ret_result = me->GetDictionary();
		/*2994*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*2995*/
	} break;
		/*2996*/
	case CefValue_GetList_14: {
		/*2997*/


		// gen! CefRefPtr<CefListValue> GetList()
		auto ret_result = me->GetList();
		/*2998*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*2999*/
	} break;
		/*3000*/
	case CefValue_SetNull_15: {
		/*3001*/


		// gen! bool SetNull()
		auto ret_result = me->SetNull();
		/*3002*/
		MyCefSetBool(ret, ret_result);
		/*3003*/
	} break;
		/*3004*/
	case CefValue_SetBool_16: {
		/*3005*/


		// gen! bool SetBool(bool value)
		auto ret_result = me->SetBool(v1->i32 != 0);
		/*3006*/
		MyCefSetBool(ret, ret_result);
		/*3007*/
	} break;
		/*3008*/
	case CefValue_SetInt_17: {
		/*3009*/


		// gen! bool SetInt(int value)
		auto ret_result = me->SetInt(v1->i32);
		/*3010*/
		MyCefSetBool(ret, ret_result);
		/*3011*/
	} break;
		/*3012*/
	case CefValue_SetDouble_18: {
		/*3013*/


		// gen! bool SetDouble(double value)
		auto ret_result = me->SetDouble(v1->num);
		/*3014*/
		MyCefSetBool(ret, ret_result);
		/*3015*/
	} break;
		/*3016*/
	case CefValue_SetString_19: {
		/*3017*/


		// gen! bool SetString(const CefString& value)
		auto ret_result = me->SetString(GetStringHolder(v1)->value);
		/*3018*/
		MyCefSetBool(ret, ret_result);
		/*3019*/
	} break;
		/*3020*/
	case CefValue_SetBinary_20: {
		/*3021*/


		// gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		/*3022*/
		MyCefSetBool(ret, ret_result);
		/*3023*/
	} break;
		/*3024*/
	case CefValue_SetDictionary_21: {
		/*3025*/


		// gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		/*3026*/
		MyCefSetBool(ret, ret_result);
		/*3027*/
	} break;
		/*3028*/
	case CefValue_SetList_22: {
		/*3029*/


		// gen! bool SetList(CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		/*3030*/
		MyCefSetBool(ret, ret_result);
		/*3031*/
	} break;
		/*3032*/
	}
	/*3033*/
	CefValueCToCpp::Unwrap(me);
	/*3034*/
}


// [virtual] class CefBinaryValue
/*3042*/
/*3035*/
const int CefBinaryValue_IsValid_1 = 1;
/*3036*/
const int CefBinaryValue_IsOwned_2 = 2;
/*3037*/
const int CefBinaryValue_IsSame_3 = 3;
/*3038*/
const int CefBinaryValue_IsEqual_4 = 4;
/*3039*/
const int CefBinaryValue_Copy_5 = 5;
/*3040*/
const int CefBinaryValue_GetSize_6 = 6;
/*3041*/
const int CefBinaryValue_GetData_7 = 7;

/*3043*/
void MyCefMet_CefBinaryValue(cef_binary_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3044*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3045*/
	auto me = CefBinaryValueCToCpp::Wrap(me1);
	/*3046*/
	switch (metName) {
		/*3047*/
	case MET_Release:return; //yes, just return
							 /*3048*/
	case CefBinaryValue_IsValid_1: {
		/*3049*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*3050*/
		MyCefSetBool(ret, ret_result);
		/*3051*/
	} break;
		/*3052*/
	case CefBinaryValue_IsOwned_2: {
		/*3053*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*3054*/
		MyCefSetBool(ret, ret_result);
		/*3055*/
	} break;
		/*3056*/
	case CefBinaryValue_IsSame_3: {
		/*3057*/


		// gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
		auto ret_result = me->IsSame(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		/*3058*/
		MyCefSetBool(ret, ret_result);
		/*3059*/
	} break;
		/*3060*/
	case CefBinaryValue_IsEqual_4: {
		/*3061*/


		// gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
		auto ret_result = me->IsEqual(CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v1->ptr));
		/*3062*/
		MyCefSetBool(ret, ret_result);
		/*3063*/
	} break;
		/*3064*/
	case CefBinaryValue_Copy_5: {
		/*3065*/


		// gen! CefRefPtr<CefBinaryValue> Copy()
		auto ret_result = me->Copy();
		/*3066*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*3067*/
	} break;
		/*3068*/
	case CefBinaryValue_GetSize_6: {
		/*3069*/


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		/*3070*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3071*/
	} break;
		/*3072*/
	case CefBinaryValue_GetData_7: {
		/*3073*/


		// gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
		auto ret_result = me->GetData((void*)v1->ptr,
			v2->i64,
			v3->i64);
		/*3074*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3075*/
	} break;
		/*3076*/
	}
	/*3077*/
	CefBinaryValueCToCpp::Unwrap(me);
	/*3078*/
}


// [virtual] class CefDictionaryValue
/*3108*/
/*3079*/
const int CefDictionaryValue_IsValid_1 = 1;
/*3080*/
const int CefDictionaryValue_IsOwned_2 = 2;
/*3081*/
const int CefDictionaryValue_IsReadOnly_3 = 3;
/*3082*/
const int CefDictionaryValue_IsSame_4 = 4;
/*3083*/
const int CefDictionaryValue_IsEqual_5 = 5;
/*3084*/
const int CefDictionaryValue_Copy_6 = 6;
/*3085*/
const int CefDictionaryValue_GetSize_7 = 7;
/*3086*/
const int CefDictionaryValue_Clear_8 = 8;
/*3087*/
const int CefDictionaryValue_HasKey_9 = 9;
/*3088*/
const int CefDictionaryValue_GetKeys_10 = 10;
/*3089*/
const int CefDictionaryValue_Remove_11 = 11;
/*3090*/
const int CefDictionaryValue_GetType_12 = 12;
/*3091*/
const int CefDictionaryValue_GetValue_13 = 13;
/*3092*/
const int CefDictionaryValue_GetBool_14 = 14;
/*3093*/
const int CefDictionaryValue_GetInt_15 = 15;
/*3094*/
const int CefDictionaryValue_GetDouble_16 = 16;
/*3095*/
const int CefDictionaryValue_GetString_17 = 17;
/*3096*/
const int CefDictionaryValue_GetBinary_18 = 18;
/*3097*/
const int CefDictionaryValue_GetDictionary_19 = 19;
/*3098*/
const int CefDictionaryValue_GetList_20 = 20;
/*3099*/
const int CefDictionaryValue_SetValue_21 = 21;
/*3100*/
const int CefDictionaryValue_SetNull_22 = 22;
/*3101*/
const int CefDictionaryValue_SetBool_23 = 23;
/*3102*/
const int CefDictionaryValue_SetInt_24 = 24;
/*3103*/
const int CefDictionaryValue_SetDouble_25 = 25;
/*3104*/
const int CefDictionaryValue_SetString_26 = 26;
/*3105*/
const int CefDictionaryValue_SetBinary_27 = 27;
/*3106*/
const int CefDictionaryValue_SetDictionary_28 = 28;
/*3107*/
const int CefDictionaryValue_SetList_29 = 29;

/*3109*/
void MyCefMet_CefDictionaryValue(cef_dictionary_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3110*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3111*/
	auto me = CefDictionaryValueCToCpp::Wrap(me1);
	/*3112*/
	switch (metName) {
		/*3113*/
	case MET_Release:return; //yes, just return
							 /*3114*/
	case CefDictionaryValue_IsValid_1: {
		/*3115*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*3116*/
		MyCefSetBool(ret, ret_result);
		/*3117*/
	} break;
		/*3118*/
	case CefDictionaryValue_IsOwned_2: {
		/*3119*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*3120*/
		MyCefSetBool(ret, ret_result);
		/*3121*/
	} break;
		/*3122*/
	case CefDictionaryValue_IsReadOnly_3: {
		/*3123*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*3124*/
		MyCefSetBool(ret, ret_result);
		/*3125*/
	} break;
		/*3126*/
	case CefDictionaryValue_IsSame_4: {
		/*3127*/


		// gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
		auto ret_result = me->IsSame(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		/*3128*/
		MyCefSetBool(ret, ret_result);
		/*3129*/
	} break;
		/*3130*/
	case CefDictionaryValue_IsEqual_5: {
		/*3131*/


		// gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
		auto ret_result = me->IsEqual(CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v1->ptr));
		/*3132*/
		MyCefSetBool(ret, ret_result);
		/*3133*/
	} break;
		/*3134*/
	case CefDictionaryValue_Copy_6: {
		/*3135*/


		// gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
		auto ret_result = me->Copy(v1->i32 != 0);
		/*3136*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*3137*/
	} break;
		/*3138*/
	case CefDictionaryValue_GetSize_7: {
		/*3139*/


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		/*3140*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3141*/
	} break;
		/*3142*/
	case CefDictionaryValue_Clear_8: {
		/*3143*/


		// gen! bool Clear()
		auto ret_result = me->Clear();
		/*3144*/
		MyCefSetBool(ret, ret_result);
		/*3145*/
	} break;
		/*3146*/
	case CefDictionaryValue_HasKey_9: {
		/*3147*/


		// gen! bool HasKey(const CefString& key)
		auto ret_result = me->HasKey(GetStringHolder(v1)->value);
		/*3148*/
		MyCefSetBool(ret, ret_result);
		/*3149*/
	} break;
		/*3150*/
	case CefDictionaryValue_GetKeys_10: {
		/*3151*/


		// gen! bool GetKeys(KeyList& keys)
		auto ret_result = me->GetKeys(*((CefDictionaryValue::KeyList*)v1->ptr));
		/*3152*/
		MyCefSetBool(ret, ret_result);
		/*3153*/
	} break;
		/*3154*/
	case CefDictionaryValue_Remove_11: {
		/*3155*/


		// gen! bool Remove(const CefString& key)
		auto ret_result = me->Remove(GetStringHolder(v1)->value);
		/*3156*/
		MyCefSetBool(ret, ret_result);
		/*3157*/
	} break;
		/*3158*/
	case CefDictionaryValue_GetType_12: {
		/*3159*/


		// gen! CefValueType GetType(const CefString& key)
		auto ret_result = me->GetType(GetStringHolder(v1)->value);
		/*3160*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3161*/
	} break;
		/*3162*/
	case CefDictionaryValue_GetValue_13: {
		/*3163*/


		// gen! CefRefPtr<CefValue> GetValue(const CefString& key)
		auto ret_result = me->GetValue(GetStringHolder(v1)->value);
		/*3164*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*3165*/
	} break;
		/*3166*/
	case CefDictionaryValue_GetBool_14: {
		/*3167*/


		// gen! bool GetBool(const CefString& key)
		auto ret_result = me->GetBool(GetStringHolder(v1)->value);
		/*3168*/
		MyCefSetBool(ret, ret_result);
		/*3169*/
	} break;
		/*3170*/
	case CefDictionaryValue_GetInt_15: {
		/*3171*/


		// gen! int GetInt(const CefString& key)
		auto ret_result = me->GetInt(GetStringHolder(v1)->value);
		/*3172*/
		MyCefSetInt64(ret, ret_result);
		/*3173*/
	} break;
		/*3174*/
	case CefDictionaryValue_GetDouble_16: {
		/*3175*/


		// gen! double GetDouble(const CefString& key)
		auto ret_result = me->GetDouble(GetStringHolder(v1)->value);
		/*3176*/
		MyCefSetDouble(ret, ret_result);
		/*3177*/
	} break;
		/*3178*/
	case CefDictionaryValue_GetString_17: {
		/*3179*/


		// gen! CefString GetString(const CefString& key)
		auto ret_result = me->GetString(GetStringHolder(v1)->value);
		/*3180*/
		SetCefStringToJsValue(ret, ret_result);
		/*3181*/
	} break;
		/*3182*/
	case CefDictionaryValue_GetBinary_18: {
		/*3183*/


		// gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
		auto ret_result = me->GetBinary(GetStringHolder(v1)->value);
		/*3184*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*3185*/
	} break;
		/*3186*/
	case CefDictionaryValue_GetDictionary_19: {
		/*3187*/


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
		auto ret_result = me->GetDictionary(GetStringHolder(v1)->value);
		/*3188*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*3189*/
	} break;
		/*3190*/
	case CefDictionaryValue_GetList_20: {
		/*3191*/


		// gen! CefRefPtr<CefListValue> GetList(const CefString& key)
		auto ret_result = me->GetList(GetStringHolder(v1)->value);
		/*3192*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*3193*/
	} break;
		/*3194*/
	case CefDictionaryValue_SetValue_21: {
		/*3195*/


		// gen! bool SetValue(const CefString& key,CefRefPtr<CefValue> value)
		auto ret_result = me->SetValue(GetStringHolder(v1)->value,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr));
		/*3196*/
		MyCefSetBool(ret, ret_result);
		/*3197*/
	} break;
		/*3198*/
	case CefDictionaryValue_SetNull_22: {
		/*3199*/


		// gen! bool SetNull(const CefString& key)
		auto ret_result = me->SetNull(GetStringHolder(v1)->value);
		/*3200*/
		MyCefSetBool(ret, ret_result);
		/*3201*/
	} break;
		/*3202*/
	case CefDictionaryValue_SetBool_23: {
		/*3203*/


		// gen! bool SetBool(const CefString& key,bool value)
		auto ret_result = me->SetBool(GetStringHolder(v1)->value,
			v2->i32 != 0);
		/*3204*/
		MyCefSetBool(ret, ret_result);
		/*3205*/
	} break;
		/*3206*/
	case CefDictionaryValue_SetInt_24: {
		/*3207*/


		// gen! bool SetInt(const CefString& key,int value)
		auto ret_result = me->SetInt(GetStringHolder(v1)->value,
			v2->i32);
		/*3208*/
		MyCefSetBool(ret, ret_result);
		/*3209*/
	} break;
		/*3210*/
	case CefDictionaryValue_SetDouble_25: {
		/*3211*/


		// gen! bool SetDouble(const CefString& key,double value)
		auto ret_result = me->SetDouble(GetStringHolder(v1)->value,
			v2->num);
		/*3212*/
		MyCefSetBool(ret, ret_result);
		/*3213*/
	} break;
		/*3214*/
	case CefDictionaryValue_SetString_26: {
		/*3215*/


		// gen! bool SetString(const CefString& key,const CefString& value)
		auto ret_result = me->SetString(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*3216*/
		MyCefSetBool(ret, ret_result);
		/*3217*/
	} break;
		/*3218*/
	case CefDictionaryValue_SetBinary_27: {
		/*3219*/


		// gen! bool SetBinary(const CefString& key,CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(GetStringHolder(v1)->value,
			CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v2->ptr));
		/*3220*/
		MyCefSetBool(ret, ret_result);
		/*3221*/
	} break;
		/*3222*/
	case CefDictionaryValue_SetDictionary_28: {
		/*3223*/


		// gen! bool SetDictionary(const CefString& key,CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(GetStringHolder(v1)->value,
			CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v2->ptr));
		/*3224*/
		MyCefSetBool(ret, ret_result);
		/*3225*/
	} break;
		/*3226*/
	case CefDictionaryValue_SetList_29: {
		/*3227*/


		// gen! bool SetList(const CefString& key,CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(GetStringHolder(v1)->value,
			CefListValueCToCpp::Wrap((cef_list_value_t*)v2->ptr));
		/*3228*/
		MyCefSetBool(ret, ret_result);
		/*3229*/
	} break;
		/*3230*/
	}
	/*3231*/
	CefDictionaryValueCToCpp::Unwrap(me);
	/*3232*/
}


// [virtual] class CefListValue
/*3261*/
/*3233*/
const int CefListValue_IsValid_1 = 1;
/*3234*/
const int CefListValue_IsOwned_2 = 2;
/*3235*/
const int CefListValue_IsReadOnly_3 = 3;
/*3236*/
const int CefListValue_IsSame_4 = 4;
/*3237*/
const int CefListValue_IsEqual_5 = 5;
/*3238*/
const int CefListValue_Copy_6 = 6;
/*3239*/
const int CefListValue_SetSize_7 = 7;
/*3240*/
const int CefListValue_GetSize_8 = 8;
/*3241*/
const int CefListValue_Clear_9 = 9;
/*3242*/
const int CefListValue_Remove_10 = 10;
/*3243*/
const int CefListValue_GetType_11 = 11;
/*3244*/
const int CefListValue_GetValue_12 = 12;
/*3245*/
const int CefListValue_GetBool_13 = 13;
/*3246*/
const int CefListValue_GetInt_14 = 14;
/*3247*/
const int CefListValue_GetDouble_15 = 15;
/*3248*/
const int CefListValue_GetString_16 = 16;
/*3249*/
const int CefListValue_GetBinary_17 = 17;
/*3250*/
const int CefListValue_GetDictionary_18 = 18;
/*3251*/
const int CefListValue_GetList_19 = 19;
/*3252*/
const int CefListValue_SetValue_20 = 20;
/*3253*/
const int CefListValue_SetNull_21 = 21;
/*3254*/
const int CefListValue_SetBool_22 = 22;
/*3255*/
const int CefListValue_SetInt_23 = 23;
/*3256*/
const int CefListValue_SetDouble_24 = 24;
/*3257*/
const int CefListValue_SetString_25 = 25;
/*3258*/
const int CefListValue_SetBinary_26 = 26;
/*3259*/
const int CefListValue_SetDictionary_27 = 27;
/*3260*/
const int CefListValue_SetList_28 = 28;

/*3262*/
void MyCefMet_CefListValue(cef_list_value_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3263*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3264*/
	auto me = CefListValueCToCpp::Wrap(me1);
	/*3265*/
	switch (metName) {
		/*3266*/
	case MET_Release:return; //yes, just return
							 /*3267*/
	case CefListValue_IsValid_1: {
		/*3268*/


		// gen! bool IsValid()
		auto ret_result = me->IsValid();
		/*3269*/
		MyCefSetBool(ret, ret_result);
		/*3270*/
	} break;
		/*3271*/
	case CefListValue_IsOwned_2: {
		/*3272*/


		// gen! bool IsOwned()
		auto ret_result = me->IsOwned();
		/*3273*/
		MyCefSetBool(ret, ret_result);
		/*3274*/
	} break;
		/*3275*/
	case CefListValue_IsReadOnly_3: {
		/*3276*/


		// gen! bool IsReadOnly()
		auto ret_result = me->IsReadOnly();
		/*3277*/
		MyCefSetBool(ret, ret_result);
		/*3278*/
	} break;
		/*3279*/
	case CefListValue_IsSame_4: {
		/*3280*/


		// gen! bool IsSame(CefRefPtr<CefListValue> that)
		auto ret_result = me->IsSame(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		/*3281*/
		MyCefSetBool(ret, ret_result);
		/*3282*/
	} break;
		/*3283*/
	case CefListValue_IsEqual_5: {
		/*3284*/


		// gen! bool IsEqual(CefRefPtr<CefListValue> that)
		auto ret_result = me->IsEqual(CefListValueCToCpp::Wrap((cef_list_value_t*)v1->ptr));
		/*3285*/
		MyCefSetBool(ret, ret_result);
		/*3286*/
	} break;
		/*3287*/
	case CefListValue_Copy_6: {
		/*3288*/


		// gen! CefRefPtr<CefListValue> Copy()
		auto ret_result = me->Copy();
		/*3289*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*3290*/
	} break;
		/*3291*/
	case CefListValue_SetSize_7: {
		/*3292*/


		// gen! bool SetSize(size_t size)
		auto ret_result = me->SetSize(v1->i64);
		/*3293*/
		MyCefSetBool(ret, ret_result);
		/*3294*/
	} break;
		/*3295*/
	case CefListValue_GetSize_8: {
		/*3296*/


		// gen! size_t GetSize()
		auto ret_result = me->GetSize();
		/*3297*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3298*/
	} break;
		/*3299*/
	case CefListValue_Clear_9: {
		/*3300*/


		// gen! bool Clear()
		auto ret_result = me->Clear();
		/*3301*/
		MyCefSetBool(ret, ret_result);
		/*3302*/
	} break;
		/*3303*/
	case CefListValue_Remove_10: {
		/*3304*/


		// gen! bool Remove(size_t index)
		auto ret_result = me->Remove(v1->i64);
		/*3305*/
		MyCefSetBool(ret, ret_result);
		/*3306*/
	} break;
		/*3307*/
	case CefListValue_GetType_11: {
		/*3308*/


		// gen! CefValueType GetType(size_t index)
		auto ret_result = me->GetType(v1->i64);
		/*3309*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3310*/
	} break;
		/*3311*/
	case CefListValue_GetValue_12: {
		/*3312*/


		// gen! CefRefPtr<CefValue> GetValue(size_t index)
		auto ret_result = me->GetValue(v1->i64);
		/*3313*/
		MyCefSetVoidPtr(ret, CefValueCToCpp::Unwrap(ret_result));
		/*3314*/
	} break;
		/*3315*/
	case CefListValue_GetBool_13: {
		/*3316*/


		// gen! bool GetBool(size_t index)
		auto ret_result = me->GetBool(v1->i64);
		/*3317*/
		MyCefSetBool(ret, ret_result);
		/*3318*/
	} break;
		/*3319*/
	case CefListValue_GetInt_14: {
		/*3320*/


		// gen! int GetInt(size_t index)
		auto ret_result = me->GetInt(v1->i64);
		/*3321*/
		MyCefSetInt64(ret, ret_result);
		/*3322*/
	} break;
		/*3323*/
	case CefListValue_GetDouble_15: {
		/*3324*/


		// gen! double GetDouble(size_t index)
		auto ret_result = me->GetDouble(v1->i64);
		/*3325*/
		MyCefSetDouble(ret, ret_result);
		/*3326*/
	} break;
		/*3327*/
	case CefListValue_GetString_16: {
		/*3328*/


		// gen! CefString GetString(size_t index)
		auto ret_result = me->GetString(v1->i64);
		/*3329*/
		SetCefStringToJsValue(ret, ret_result);
		/*3330*/
	} break;
		/*3331*/
	case CefListValue_GetBinary_17: {
		/*3332*/


		// gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
		auto ret_result = me->GetBinary(v1->i64);
		/*3333*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*3334*/
	} break;
		/*3335*/
	case CefListValue_GetDictionary_18: {
		/*3336*/


		// gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
		auto ret_result = me->GetDictionary(v1->i64);
		/*3337*/
		MyCefSetVoidPtr(ret, CefDictionaryValueCToCpp::Unwrap(ret_result));
		/*3338*/
	} break;
		/*3339*/
	case CefListValue_GetList_19: {
		/*3340*/


		// gen! CefRefPtr<CefListValue> GetList(size_t index)
		auto ret_result = me->GetList(v1->i64);
		/*3341*/
		MyCefSetVoidPtr(ret, CefListValueCToCpp::Unwrap(ret_result));
		/*3342*/
	} break;
		/*3343*/
	case CefListValue_SetValue_20: {
		/*3344*/


		// gen! bool SetValue(size_t index,CefRefPtr<CefValue> value)
		auto ret_result = me->SetValue(v1->i64,
			CefValueCToCpp::Wrap((cef_value_t*)v2->ptr));
		/*3345*/
		MyCefSetBool(ret, ret_result);
		/*3346*/
	} break;
		/*3347*/
	case CefListValue_SetNull_21: {
		/*3348*/


		// gen! bool SetNull(size_t index)
		auto ret_result = me->SetNull(v1->i64);
		/*3349*/
		MyCefSetBool(ret, ret_result);
		/*3350*/
	} break;
		/*3351*/
	case CefListValue_SetBool_22: {
		/*3352*/


		// gen! bool SetBool(size_t index,bool value)
		auto ret_result = me->SetBool(v1->i64,
			v2->i32 != 0);
		/*3353*/
		MyCefSetBool(ret, ret_result);
		/*3354*/
	} break;
		/*3355*/
	case CefListValue_SetInt_23: {
		/*3356*/


		// gen! bool SetInt(size_t index,int value)
		auto ret_result = me->SetInt(v1->i64,
			v2->i32);
		/*3357*/
		MyCefSetBool(ret, ret_result);
		/*3358*/
	} break;
		/*3359*/
	case CefListValue_SetDouble_24: {
		/*3360*/


		// gen! bool SetDouble(size_t index,double value)
		auto ret_result = me->SetDouble(v1->i64,
			v2->num);
		/*3361*/
		MyCefSetBool(ret, ret_result);
		/*3362*/
	} break;
		/*3363*/
	case CefListValue_SetString_25: {
		/*3364*/


		// gen! bool SetString(size_t index,const CefString& value)
		auto ret_result = me->SetString(v1->i64,
			GetStringHolder(v2)->value);
		/*3365*/
		MyCefSetBool(ret, ret_result);
		/*3366*/
	} break;
		/*3367*/
	case CefListValue_SetBinary_26: {
		/*3368*/


		// gen! bool SetBinary(size_t index,CefRefPtr<CefBinaryValue> value)
		auto ret_result = me->SetBinary(v1->i64,
			CefBinaryValueCToCpp::Wrap((cef_binary_value_t*)v2->ptr));
		/*3369*/
		MyCefSetBool(ret, ret_result);
		/*3370*/
	} break;
		/*3371*/
	case CefListValue_SetDictionary_27: {
		/*3372*/


		// gen! bool SetDictionary(size_t index,CefRefPtr<CefDictionaryValue> value)
		auto ret_result = me->SetDictionary(v1->i64,
			CefDictionaryValueCToCpp::Wrap((cef_dictionary_value_t*)v2->ptr));
		/*3373*/
		MyCefSetBool(ret, ret_result);
		/*3374*/
	} break;
		/*3375*/
	case CefListValue_SetList_28: {
		/*3376*/


		// gen! bool SetList(size_t index,CefRefPtr<CefListValue> value)
		auto ret_result = me->SetList(v1->i64,
			CefListValueCToCpp::Wrap((cef_list_value_t*)v2->ptr));
		/*3377*/
		MyCefSetBool(ret, ret_result);
		/*3378*/
	} break;
		/*3379*/
	}
	/*3380*/
	CefListValueCToCpp::Unwrap(me);
	/*3381*/
}


// [virtual] class CefWebPluginInfo
/*3386*/
/*3382*/
const int CefWebPluginInfo_GetName_1 = 1;
/*3383*/
const int CefWebPluginInfo_GetPath_2 = 2;
/*3384*/
const int CefWebPluginInfo_GetVersion_3 = 3;
/*3385*/
const int CefWebPluginInfo_GetDescription_4 = 4;

/*3387*/
void MyCefMet_CefWebPluginInfo(cef_web_plugin_info_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3388*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3389*/
	auto me = CefWebPluginInfoCToCpp::Wrap(me1);
	/*3390*/
	switch (metName) {
		/*3391*/
	case MET_Release:return; //yes, just return
							 /*3392*/
	case CefWebPluginInfo_GetName_1: {
		/*3393*/


		// gen! CefString GetName()
		auto ret_result = me->GetName();
		/*3394*/
		SetCefStringToJsValue(ret, ret_result);
		/*3395*/
	} break;
		/*3396*/
	case CefWebPluginInfo_GetPath_2: {
		/*3397*/


		// gen! CefString GetPath()
		auto ret_result = me->GetPath();
		/*3398*/
		SetCefStringToJsValue(ret, ret_result);
		/*3399*/
	} break;
		/*3400*/
	case CefWebPluginInfo_GetVersion_3: {
		/*3401*/


		// gen! CefString GetVersion()
		auto ret_result = me->GetVersion();
		/*3402*/
		SetCefStringToJsValue(ret, ret_result);
		/*3403*/
	} break;
		/*3404*/
	case CefWebPluginInfo_GetDescription_4: {
		/*3405*/


		// gen! CefString GetDescription()
		auto ret_result = me->GetDescription();
		/*3406*/
		SetCefStringToJsValue(ret, ret_result);
		/*3407*/
	} break;
		/*3408*/
	}
	/*3409*/
	CefWebPluginInfoCToCpp::Unwrap(me);
	/*3410*/
}


// [virtual] class CefWebPluginInfoVisitor
/*3411*/

/*3412*/
void MyCefMet_CefWebPluginInfoVisitor(cef_web_plugin_info_visitor_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3413*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3414*/
	auto me = CefWebPluginInfoVisitorCppToC::Unwrap(me1);
	/*3415*/
	switch (metName) {
		/*3416*/
	case MET_Release:return; //yes, just return
							 /*3417*/
	}
	/*3418*/
	CefWebPluginInfoVisitorCppToC::Wrap(me);
	/*3419*/
}


// [virtual] class CefX509CertPrincipal
/*3429*/
/*3420*/
const int CefX509CertPrincipal_GetDisplayName_1 = 1;
/*3421*/
const int CefX509CertPrincipal_GetCommonName_2 = 2;
/*3422*/
const int CefX509CertPrincipal_GetLocalityName_3 = 3;
/*3423*/
const int CefX509CertPrincipal_GetStateOrProvinceName_4 = 4;
/*3424*/
const int CefX509CertPrincipal_GetCountryName_5 = 5;
/*3425*/
const int CefX509CertPrincipal_GetStreetAddresses_6 = 6;
/*3426*/
const int CefX509CertPrincipal_GetOrganizationNames_7 = 7;
/*3427*/
const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = 8;
/*3428*/
const int CefX509CertPrincipal_GetDomainComponents_9 = 9;

/*3430*/
void MyCefMet_CefX509CertPrincipal(cef_x509cert_principal_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3431*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3432*/
	auto me = CefX509CertPrincipalCToCpp::Wrap(me1);
	/*3433*/
	switch (metName) {
		/*3434*/
	case MET_Release:return; //yes, just return
							 /*3435*/
	case CefX509CertPrincipal_GetDisplayName_1: {
		/*3436*/


		// gen! CefString GetDisplayName()
		auto ret_result = me->GetDisplayName();
		/*3437*/
		SetCefStringToJsValue(ret, ret_result);
		/*3438*/
	} break;
		/*3439*/
	case CefX509CertPrincipal_GetCommonName_2: {
		/*3440*/


		// gen! CefString GetCommonName()
		auto ret_result = me->GetCommonName();
		/*3441*/
		SetCefStringToJsValue(ret, ret_result);
		/*3442*/
	} break;
		/*3443*/
	case CefX509CertPrincipal_GetLocalityName_3: {
		/*3444*/


		// gen! CefString GetLocalityName()
		auto ret_result = me->GetLocalityName();
		/*3445*/
		SetCefStringToJsValue(ret, ret_result);
		/*3446*/
	} break;
		/*3447*/
	case CefX509CertPrincipal_GetStateOrProvinceName_4: {
		/*3448*/


		// gen! CefString GetStateOrProvinceName()
		auto ret_result = me->GetStateOrProvinceName();
		/*3449*/
		SetCefStringToJsValue(ret, ret_result);
		/*3450*/
	} break;
		/*3451*/
	case CefX509CertPrincipal_GetCountryName_5: {
		/*3452*/


		// gen! CefString GetCountryName()
		auto ret_result = me->GetCountryName();
		/*3453*/
		SetCefStringToJsValue(ret, ret_result);
		/*3454*/
	} break;
		/*3455*/
	case CefX509CertPrincipal_GetStreetAddresses_6: {
		/*3456*/


		// gen! void GetStreetAddresses(std::vector<CefString>& addresses)
		me->GetStreetAddresses(*((std::vector<CefString>*)v1->ptr));
		/*3457*/

		/*3458*/
	} break;
		/*3459*/
	case CefX509CertPrincipal_GetOrganizationNames_7: {
		/*3460*/


		// gen! void GetOrganizationNames(std::vector<CefString>& names)
		me->GetOrganizationNames(*((std::vector<CefString>*)v1->ptr));
		/*3461*/

		/*3462*/
	} break;
		/*3463*/
	case CefX509CertPrincipal_GetOrganizationUnitNames_8: {
		/*3464*/


		// gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
		me->GetOrganizationUnitNames(*((std::vector<CefString>*)v1->ptr));
		/*3465*/

		/*3466*/
	} break;
		/*3467*/
	case CefX509CertPrincipal_GetDomainComponents_9: {
		/*3468*/


		// gen! void GetDomainComponents(std::vector<CefString>& components)
		me->GetDomainComponents(*((std::vector<CefString>*)v1->ptr));
		/*3469*/

		/*3470*/
	} break;
		/*3471*/
	}
	/*3472*/
	CefX509CertPrincipalCToCpp::Unwrap(me);
	/*3473*/
}


// [virtual] class CefX509Certificate
/*3484*/
/*3474*/
const int CefX509Certificate_GetSubject_1 = 1;
/*3475*/
const int CefX509Certificate_GetIssuer_2 = 2;
/*3476*/
const int CefX509Certificate_GetSerialNumber_3 = 3;
/*3477*/
const int CefX509Certificate_GetValidStart_4 = 4;
/*3478*/
const int CefX509Certificate_GetValidExpiry_5 = 5;
/*3479*/
const int CefX509Certificate_GetDEREncoded_6 = 6;
/*3480*/
const int CefX509Certificate_GetPEMEncoded_7 = 7;
/*3481*/
const int CefX509Certificate_GetIssuerChainSize_8 = 8;
/*3482*/
const int CefX509Certificate_GetDEREncodedIssuerChain_9 = 9;
/*3483*/
const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = 10;

/*3485*/
void MyCefMet_CefX509Certificate(cef_x509certificate_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3486*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3487*/
	auto me = CefX509CertificateCToCpp::Wrap(me1);
	/*3488*/
	switch (metName) {
		/*3489*/
	case MET_Release:return; //yes, just return
							 /*3490*/
	case CefX509Certificate_GetSubject_1: {
		/*3491*/


		// gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
		auto ret_result = me->GetSubject();
		/*3492*/
		MyCefSetVoidPtr(ret, CefX509CertPrincipalCToCpp::Unwrap(ret_result));
		/*3493*/
	} break;
		/*3494*/
	case CefX509Certificate_GetIssuer_2: {
		/*3495*/


		// gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
		auto ret_result = me->GetIssuer();
		/*3496*/
		MyCefSetVoidPtr(ret, CefX509CertPrincipalCToCpp::Unwrap(ret_result));
		/*3497*/
	} break;
		/*3498*/
	case CefX509Certificate_GetSerialNumber_3: {
		/*3499*/


		// gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
		auto ret_result = me->GetSerialNumber();
		/*3500*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*3501*/
	} break;
		/*3502*/
	case CefX509Certificate_GetValidStart_4: {
		/*3503*/


		// gen! CefTime GetValidStart()
		auto ret_result = me->GetValidStart();
		/*3504*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*3505*/
	} break;
		/*3506*/
	case CefX509Certificate_GetValidExpiry_5: {
		/*3507*/


		// gen! CefTime GetValidExpiry()
		auto ret_result = me->GetValidExpiry();
		/*3508*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*3509*/
	} break;
		/*3510*/
	case CefX509Certificate_GetDEREncoded_6: {
		/*3511*/


		// gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
		auto ret_result = me->GetDEREncoded();
		/*3512*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*3513*/
	} break;
		/*3514*/
	case CefX509Certificate_GetPEMEncoded_7: {
		/*3515*/


		// gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
		auto ret_result = me->GetPEMEncoded();
		/*3516*/
		MyCefSetVoidPtr(ret, CefBinaryValueCToCpp::Unwrap(ret_result));
		/*3517*/
	} break;
		/*3518*/
	case CefX509Certificate_GetIssuerChainSize_8: {
		/*3519*/


		// gen! size_t GetIssuerChainSize()
		auto ret_result = me->GetIssuerChainSize();
		/*3520*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3521*/
	} break;
		/*3522*/
	case CefX509Certificate_GetDEREncodedIssuerChain_9: {
		/*3523*/


		// gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
		me->GetDEREncodedIssuerChain(*((CefX509Certificate::IssuerChainBinaryList*)v1->ptr));
		/*3524*/

		/*3525*/
	} break;
		/*3526*/
	case CefX509Certificate_GetPEMEncodedIssuerChain_10: {
		/*3527*/


		// gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
		me->GetPEMEncodedIssuerChain(*((CefX509Certificate::IssuerChainBinaryList*)v1->ptr));
		/*3528*/

		/*3529*/
	} break;
		/*3530*/
	}
	/*3531*/
	CefX509CertificateCToCpp::Unwrap(me);
	/*3532*/
}


// [virtual] class CefXmlReader
/*3562*/
/*3533*/
const int CefXmlReader_MoveToNextNode_1 = 1;
/*3534*/
const int CefXmlReader_Close_2 = 2;
/*3535*/
const int CefXmlReader_HasError_3 = 3;
/*3536*/
const int CefXmlReader_GetError_4 = 4;
/*3537*/
const int CefXmlReader_GetType_5 = 5;
/*3538*/
const int CefXmlReader_GetDepth_6 = 6;
/*3539*/
const int CefXmlReader_GetLocalName_7 = 7;
/*3540*/
const int CefXmlReader_GetPrefix_8 = 8;
/*3541*/
const int CefXmlReader_GetQualifiedName_9 = 9;
/*3542*/
const int CefXmlReader_GetNamespaceURI_10 = 10;
/*3543*/
const int CefXmlReader_GetBaseURI_11 = 11;
/*3544*/
const int CefXmlReader_GetXmlLang_12 = 12;
/*3545*/
const int CefXmlReader_IsEmptyElement_13 = 13;
/*3546*/
const int CefXmlReader_HasValue_14 = 14;
/*3547*/
const int CefXmlReader_GetValue_15 = 15;
/*3548*/
const int CefXmlReader_HasAttributes_16 = 16;
/*3549*/
const int CefXmlReader_GetAttributeCount_17 = 17;
/*3550*/
const int CefXmlReader_GetAttribute_18 = 18;
/*3551*/
const int CefXmlReader_GetAttribute_19 = 19;
/*3552*/
const int CefXmlReader_GetAttribute_20 = 20;
/*3553*/
const int CefXmlReader_GetInnerXml_21 = 21;
/*3554*/
const int CefXmlReader_GetOuterXml_22 = 22;
/*3555*/
const int CefXmlReader_GetLineNumber_23 = 23;
/*3556*/
const int CefXmlReader_MoveToAttribute_24 = 24;
/*3557*/
const int CefXmlReader_MoveToAttribute_25 = 25;
/*3558*/
const int CefXmlReader_MoveToAttribute_26 = 26;
/*3559*/
const int CefXmlReader_MoveToFirstAttribute_27 = 27;
/*3560*/
const int CefXmlReader_MoveToNextAttribute_28 = 28;
/*3561*/
const int CefXmlReader_MoveToCarryingElement_29 = 29;

/*3563*/
void MyCefMet_CefXmlReader(cef_xml_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3564*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3565*/
	auto me = CefXmlReaderCToCpp::Wrap(me1);
	/*3566*/
	switch (metName) {
		/*3567*/
	case MET_Release:return; //yes, just return
							 /*3568*/
	case CefXmlReader_MoveToNextNode_1: {
		/*3569*/


		// gen! bool MoveToNextNode()
		auto ret_result = me->MoveToNextNode();
		/*3570*/
		MyCefSetBool(ret, ret_result);
		/*3571*/
	} break;
		/*3572*/
	case CefXmlReader_Close_2: {
		/*3573*/


		// gen! bool Close()
		auto ret_result = me->Close();
		/*3574*/
		MyCefSetBool(ret, ret_result);
		/*3575*/
	} break;
		/*3576*/
	case CefXmlReader_HasError_3: {
		/*3577*/


		// gen! bool HasError()
		auto ret_result = me->HasError();
		/*3578*/
		MyCefSetBool(ret, ret_result);
		/*3579*/
	} break;
		/*3580*/
	case CefXmlReader_GetError_4: {
		/*3581*/


		// gen! CefString GetError()
		auto ret_result = me->GetError();
		/*3582*/
		SetCefStringToJsValue(ret, ret_result);
		/*3583*/
	} break;
		/*3584*/
	case CefXmlReader_GetType_5: {
		/*3585*/


		// gen! NodeType GetType()
		auto ret_result = me->GetType();
		/*3586*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3587*/
	} break;
		/*3588*/
	case CefXmlReader_GetDepth_6: {
		/*3589*/


		// gen! int GetDepth()
		auto ret_result = me->GetDepth();
		/*3590*/
		MyCefSetInt64(ret, ret_result);
		/*3591*/
	} break;
		/*3592*/
	case CefXmlReader_GetLocalName_7: {
		/*3593*/


		// gen! CefString GetLocalName()
		auto ret_result = me->GetLocalName();
		/*3594*/
		SetCefStringToJsValue(ret, ret_result);
		/*3595*/
	} break;
		/*3596*/
	case CefXmlReader_GetPrefix_8: {
		/*3597*/


		// gen! CefString GetPrefix()
		auto ret_result = me->GetPrefix();
		/*3598*/
		SetCefStringToJsValue(ret, ret_result);
		/*3599*/
	} break;
		/*3600*/
	case CefXmlReader_GetQualifiedName_9: {
		/*3601*/


		// gen! CefString GetQualifiedName()
		auto ret_result = me->GetQualifiedName();
		/*3602*/
		SetCefStringToJsValue(ret, ret_result);
		/*3603*/
	} break;
		/*3604*/
	case CefXmlReader_GetNamespaceURI_10: {
		/*3605*/


		// gen! CefString GetNamespaceURI()
		auto ret_result = me->GetNamespaceURI();
		/*3606*/
		SetCefStringToJsValue(ret, ret_result);
		/*3607*/
	} break;
		/*3608*/
	case CefXmlReader_GetBaseURI_11: {
		/*3609*/


		// gen! CefString GetBaseURI()
		auto ret_result = me->GetBaseURI();
		/*3610*/
		SetCefStringToJsValue(ret, ret_result);
		/*3611*/
	} break;
		/*3612*/
	case CefXmlReader_GetXmlLang_12: {
		/*3613*/


		// gen! CefString GetXmlLang()
		auto ret_result = me->GetXmlLang();
		/*3614*/
		SetCefStringToJsValue(ret, ret_result);
		/*3615*/
	} break;
		/*3616*/
	case CefXmlReader_IsEmptyElement_13: {
		/*3617*/


		// gen! bool IsEmptyElement()
		auto ret_result = me->IsEmptyElement();
		/*3618*/
		MyCefSetBool(ret, ret_result);
		/*3619*/
	} break;
		/*3620*/
	case CefXmlReader_HasValue_14: {
		/*3621*/


		// gen! bool HasValue()
		auto ret_result = me->HasValue();
		/*3622*/
		MyCefSetBool(ret, ret_result);
		/*3623*/
	} break;
		/*3624*/
	case CefXmlReader_GetValue_15: {
		/*3625*/


		// gen! CefString GetValue()
		auto ret_result = me->GetValue();
		/*3626*/
		SetCefStringToJsValue(ret, ret_result);
		/*3627*/
	} break;
		/*3628*/
	case CefXmlReader_HasAttributes_16: {
		/*3629*/


		// gen! bool HasAttributes()
		auto ret_result = me->HasAttributes();
		/*3630*/
		MyCefSetBool(ret, ret_result);
		/*3631*/
	} break;
		/*3632*/
	case CefXmlReader_GetAttributeCount_17: {
		/*3633*/


		// gen! size_t GetAttributeCount()
		auto ret_result = me->GetAttributeCount();
		/*3634*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*3635*/
	} break;
		/*3636*/
	case CefXmlReader_GetAttribute_18: {
		/*3637*/


		// gen! CefString GetAttribute(int index)
		auto ret_result = me->GetAttribute(v1->i32);
		/*3638*/
		SetCefStringToJsValue(ret, ret_result);
		/*3639*/
	} break;
		/*3640*/
	case CefXmlReader_GetAttribute_19: {
		/*3641*/


		// gen! CefString GetAttribute(const CefString& qualifiedName)
		auto ret_result = me->GetAttribute(GetStringHolder(v1)->value);
		/*3642*/
		SetCefStringToJsValue(ret, ret_result);
		/*3643*/
	} break;
		/*3644*/
	case CefXmlReader_GetAttribute_20: {
		/*3645*/


		// gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)
		auto ret_result = me->GetAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*3646*/
		SetCefStringToJsValue(ret, ret_result);
		/*3647*/
	} break;
		/*3648*/
	case CefXmlReader_GetInnerXml_21: {
		/*3649*/


		// gen! CefString GetInnerXml()
		auto ret_result = me->GetInnerXml();
		/*3650*/
		SetCefStringToJsValue(ret, ret_result);
		/*3651*/
	} break;
		/*3652*/
	case CefXmlReader_GetOuterXml_22: {
		/*3653*/


		// gen! CefString GetOuterXml()
		auto ret_result = me->GetOuterXml();
		/*3654*/
		SetCefStringToJsValue(ret, ret_result);
		/*3655*/
	} break;
		/*3656*/
	case CefXmlReader_GetLineNumber_23: {
		/*3657*/


		// gen! int GetLineNumber()
		auto ret_result = me->GetLineNumber();
		/*3658*/
		MyCefSetInt64(ret, ret_result);
		/*3659*/
	} break;
		/*3660*/
	case CefXmlReader_MoveToAttribute_24: {
		/*3661*/


		// gen! bool MoveToAttribute(int index)
		auto ret_result = me->MoveToAttribute(v1->i32);
		/*3662*/
		MyCefSetBool(ret, ret_result);
		/*3663*/
	} break;
		/*3664*/
	case CefXmlReader_MoveToAttribute_25: {
		/*3665*/


		// gen! bool MoveToAttribute(const CefString& qualifiedName)
		auto ret_result = me->MoveToAttribute(GetStringHolder(v1)->value);
		/*3666*/
		MyCefSetBool(ret, ret_result);
		/*3667*/
	} break;
		/*3668*/
	case CefXmlReader_MoveToAttribute_26: {
		/*3669*/


		// gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)
		auto ret_result = me->MoveToAttribute(GetStringHolder(v1)->value,
			GetStringHolder(v2)->value);
		/*3670*/
		MyCefSetBool(ret, ret_result);
		/*3671*/
	} break;
		/*3672*/
	case CefXmlReader_MoveToFirstAttribute_27: {
		/*3673*/


		// gen! bool MoveToFirstAttribute()
		auto ret_result = me->MoveToFirstAttribute();
		/*3674*/
		MyCefSetBool(ret, ret_result);
		/*3675*/
	} break;
		/*3676*/
	case CefXmlReader_MoveToNextAttribute_28: {
		/*3677*/


		// gen! bool MoveToNextAttribute()
		auto ret_result = me->MoveToNextAttribute();
		/*3678*/
		MyCefSetBool(ret, ret_result);
		/*3679*/
	} break;
		/*3680*/
	case CefXmlReader_MoveToCarryingElement_29: {
		/*3681*/


		// gen! bool MoveToCarryingElement()
		auto ret_result = me->MoveToCarryingElement();
		/*3682*/
		MyCefSetBool(ret, ret_result);
		/*3683*/
	} break;
		/*3684*/
	}
	/*3685*/
	CefXmlReaderCToCpp::Unwrap(me);
	/*3686*/
}


// [virtual] class CefZipReader
/*3699*/
/*3687*/
const int CefZipReader_MoveToFirstFile_1 = 1;
/*3688*/
const int CefZipReader_MoveToNextFile_2 = 2;
/*3689*/
const int CefZipReader_MoveToFile_3 = 3;
/*3690*/
const int CefZipReader_Close_4 = 4;
/*3691*/
const int CefZipReader_GetFileName_5 = 5;
/*3692*/
const int CefZipReader_GetFileSize_6 = 6;
/*3693*/
const int CefZipReader_GetFileLastModified_7 = 7;
/*3694*/
const int CefZipReader_OpenFile_8 = 8;
/*3695*/
const int CefZipReader_CloseFile_9 = 9;
/*3696*/
const int CefZipReader_ReadFile_10 = 10;
/*3697*/
const int CefZipReader_Tell_11 = 11;
/*3698*/
const int CefZipReader_Eof_12 = 12;

/*3700*/
void MyCefMet_CefZipReader(cef_zip_reader_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*3701*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*3702*/
	auto me = CefZipReaderCToCpp::Wrap(me1);
	/*3703*/
	switch (metName) {
		/*3704*/
	case MET_Release:return; //yes, just return
							 /*3705*/
	case CefZipReader_MoveToFirstFile_1: {
		/*3706*/


		// gen! bool MoveToFirstFile()
		auto ret_result = me->MoveToFirstFile();
		/*3707*/
		MyCefSetBool(ret, ret_result);
		/*3708*/
	} break;
		/*3709*/
	case CefZipReader_MoveToNextFile_2: {
		/*3710*/


		// gen! bool MoveToNextFile()
		auto ret_result = me->MoveToNextFile();
		/*3711*/
		MyCefSetBool(ret, ret_result);
		/*3712*/
	} break;
		/*3713*/
	case CefZipReader_MoveToFile_3: {
		/*3714*/


		// gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
		auto ret_result = me->MoveToFile(GetStringHolder(v1)->value,
			v2->i32 != 0);
		/*3715*/
		MyCefSetBool(ret, ret_result);
		/*3716*/
	} break;
		/*3717*/
	case CefZipReader_Close_4: {
		/*3718*/


		// gen! bool Close()
		auto ret_result = me->Close();
		/*3719*/
		MyCefSetBool(ret, ret_result);
		/*3720*/
	} break;
		/*3721*/
	case CefZipReader_GetFileName_5: {
		/*3722*/


		// gen! CefString GetFileName()
		auto ret_result = me->GetFileName();
		/*3723*/
		SetCefStringToJsValue(ret, ret_result);
		/*3724*/
	} break;
		/*3725*/
	case CefZipReader_GetFileSize_6: {
		/*3726*/


		// gen! int64 GetFileSize()
		auto ret_result = me->GetFileSize();
		/*3727*/
		MyCefSetInt64(ret, ret_result);
		/*3728*/
	} break;
		/*3729*/
	case CefZipReader_GetFileLastModified_7: {
		/*3730*/


		// gen! CefTime GetFileLastModified()
		auto ret_result = me->GetFileLastModified();
		/*3731*/
		CefTime* tmp_d1 = new CefTime(ret_result);
		MyCefSetVoidPtr(ret, tmp_d1);

		/*3732*/
	} break;
		/*3733*/
	case CefZipReader_OpenFile_8: {
		/*3734*/


		// gen! bool OpenFile(const CefString& password)
		auto ret_result = me->OpenFile(GetStringHolder(v1)->value);
		/*3735*/
		MyCefSetBool(ret, ret_result);
		/*3736*/
	} break;
		/*3737*/
	case CefZipReader_CloseFile_9: {
		/*3738*/


		// gen! bool CloseFile()
		auto ret_result = me->CloseFile();
		/*3739*/
		MyCefSetBool(ret, ret_result);
		/*3740*/
	} break;
		/*3741*/
	case CefZipReader_ReadFile_10: {
		/*3742*/


		// gen! int ReadFile(void* buffer,size_t bufferSize)
		auto ret_result = me->ReadFile((void*)v1->ptr,
			v2->i64);
		/*3743*/
		MyCefSetInt64(ret, ret_result);
		/*3744*/
	} break;
		/*3745*/
	case CefZipReader_Tell_11: {
		/*3746*/


		// gen! int64 Tell()
		auto ret_result = me->Tell();
		/*3747*/
		MyCefSetInt64(ret, ret_result);
		/*3748*/
	} break;
		/*3749*/
	case CefZipReader_Eof_12: {
		/*3750*/


		// gen! bool Eof()
		auto ret_result = me->Eof();
		/*3751*/
		MyCefSetBool(ret, ret_result);
		/*3752*/
	} break;
		/*3753*/
	}
	/*3754*/
	CefZipReaderCToCpp::Unwrap(me);
	/*3755*/
}

