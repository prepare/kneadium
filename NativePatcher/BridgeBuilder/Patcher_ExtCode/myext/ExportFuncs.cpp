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
//
#include "libcef_dll/ctocpp/v8context_ctocpp.h"
#include "libcef_dll/ctocpp/v8exception_ctocpp.h"
#include "libcef_dll/ctocpp/v8stack_frame_ctocpp.h"
#include "libcef_dll/ctocpp/v8stack_trace_ctocpp.h"
#include "libcef_dll/ctocpp/v8value_ctocpp.h"

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
 

 