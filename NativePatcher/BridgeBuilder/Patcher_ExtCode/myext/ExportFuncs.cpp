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
#include "include/internal/cef_types.h"
#include "libcef_dll/ctocpp/browser_ctocpp.h"
#include "libcef_dll/ctocpp/v8context_ctocpp.h"
#include "libcef_dll/ctocpp/browser_host_ctocpp.h"
#include "libcef_dll/ctocpp/process_message_ctocpp.h"
#include "libcef_dll/ctocpp/drag_data_ctocpp.h"
#include "libcef_dll/ctocpp/navigation_entry_ctocpp.h"
#include "libcef_dll/ctocpp/request_context_ctocpp.h"

//
#include "libcef_dll/cpptoc/drag_handler_cpptoc.h" 
#include "libcef_dll/cpptoc/navigation_entry_visitor_cpptoc.h"
#include "libcef_dll/cpptoc/pdf_print_callback_cpptoc.h"
#include "libcef_dll/cpptoc/client_cpptoc.h"
#include "libcef_dll/cpptoc/download_image_callback_cpptoc.h"
#include "libcef_dll/cpptoc/run_file_dialog_callback_cpptoc.h"
//

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
/*227*/
/*175*/
const int CefBrowserHost_GetBrowser_1 = 1;
/*176*/
const int CefBrowserHost_CloseBrowser_2 = 2;
/*177*/
const int CefBrowserHost_TryCloseBrowser_3 = 3;
/*178*/
const int CefBrowserHost_SetFocus_4 = 4;
/*179*/
const int CefBrowserHost_GetWindowHandle_5 = 5;
/*180*/
const int CefBrowserHost_GetOpenerWindowHandle_6 = 6;
/*181*/
const int CefBrowserHost_HasView_7 = 7;
/*182*/
const int CefBrowserHost_GetClient_8 = 8;
/*183*/
const int CefBrowserHost_GetRequestContext_9 = 9;
/*184*/
const int CefBrowserHost_GetZoomLevel_10 = 10;
/*185*/
const int CefBrowserHost_SetZoomLevel_11 = 11;
/*186*/
const int CefBrowserHost_RunFileDialog_12 = 12;
/*187*/
const int CefBrowserHost_StartDownload_13 = 13;
/*188*/
const int CefBrowserHost_DownloadImage_14 = 14;
/*189*/
const int CefBrowserHost_Print_15 = 15;
/*190*/
const int CefBrowserHost_PrintToPDF_16 = 16;
/*191*/
const int CefBrowserHost_Find_17 = 17;
/*192*/
const int CefBrowserHost_StopFinding_18 = 18;
/*193*/
const int CefBrowserHost_ShowDevTools_19 = 19;
/*194*/
const int CefBrowserHost_CloseDevTools_20 = 20;
/*195*/
const int CefBrowserHost_HasDevTools_21 = 21;
/*196*/
const int CefBrowserHost_GetNavigationEntries_22 = 22;
/*197*/
const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = 23;
/*198*/
const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = 24;
/*199*/
const int CefBrowserHost_ReplaceMisspelling_25 = 25;
/*200*/
const int CefBrowserHost_AddWordToDictionary_26 = 26;
/*201*/
const int CefBrowserHost_IsWindowRenderingDisabled_27 = 27;
/*202*/
const int CefBrowserHost_WasResized_28 = 28;
/*203*/
const int CefBrowserHost_WasHidden_29 = 29;
/*204*/
const int CefBrowserHost_NotifyScreenInfoChanged_30 = 30;
/*205*/
const int CefBrowserHost_Invalidate_31 = 31;
/*206*/
const int CefBrowserHost_SendKeyEvent_32 = 32;
/*207*/
const int CefBrowserHost_SendMouseClickEvent_33 = 33;
/*208*/
const int CefBrowserHost_SendMouseMoveEvent_34 = 34;
/*209*/
const int CefBrowserHost_SendMouseWheelEvent_35 = 35;
/*210*/
const int CefBrowserHost_SendFocusEvent_36 = 36;
/*211*/
const int CefBrowserHost_SendCaptureLostEvent_37 = 37;
/*212*/
const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = 38;
/*213*/
const int CefBrowserHost_GetWindowlessFrameRate_39 = 39;
/*214*/
const int CefBrowserHost_SetWindowlessFrameRate_40 = 40;
/*215*/
const int CefBrowserHost_ImeSetComposition_41 = 41;
/*216*/
const int CefBrowserHost_ImeCommitText_42 = 42;
/*217*/
const int CefBrowserHost_ImeFinishComposingText_43 = 43;
/*218*/
const int CefBrowserHost_ImeCancelComposition_44 = 44;
/*219*/
const int CefBrowserHost_DragTargetDragEnter_45 = 45;
/*220*/
const int CefBrowserHost_DragTargetDragOver_46 = 46;
/*221*/
const int CefBrowserHost_DragTargetDragLeave_47 = 47;
/*222*/
const int CefBrowserHost_DragTargetDrop_48 = 48;
/*223*/
const int CefBrowserHost_DragSourceEndedAt_49 = 49;
/*224*/
const int CefBrowserHost_DragSourceSystemDragEnded_50 = 50;
/*225*/
const int CefBrowserHost_GetVisibleNavigationEntry_51 = 51;
/*226*/
const int CefBrowserHost_SetAccessibilityState_52 = 52;

/*228*/
void MyCefMet_CefBrowserHost(cef_browser_host_t* me1, int metName, jsvalue* ret, jsvalue* v1, jsvalue* v2, jsvalue* v3, jsvalue* v4, jsvalue* v5, jsvalue* v6) {
	/*229*/
	ret->type = JSVALUE_TYPE_EMPTY;
	/*230*/
	auto me = CefBrowserHostCToCpp::Wrap(me1);
	/*231*/
	switch (metName) {
		/*232*/
	case MET_Release:return; //yes, just return
							 /*233*/
	case CefBrowserHost_GetBrowser_1: {
		/*234*/

		/*235*/
		// gen! CefRefPtr<CefBrowser> GetBrowser()
		/*236*/

		auto ret_result = me->GetBrowser();
		/*237*/
		MyCefSetVoidPtr(ret, CefBrowserCToCpp::Unwrap(ret_result));
		/*238*/
	} break;
		/*239*/
	case CefBrowserHost_CloseBrowser_2: {
		/*240*/

		/*241*/
		// gen! void CloseBrowser(bool force_close)
		/*242*/

		me->CloseBrowser(v1->i32 != 0);
		/*243*/

		/*244*/
	} break;
		/*245*/
	case CefBrowserHost_TryCloseBrowser_3: {
		/*246*/

		/*247*/
		// gen! bool TryCloseBrowser()
		/*248*/

		auto ret_result = me->TryCloseBrowser();
		/*249*/
		MyCefSetBool(ret, ret_result);
		/*250*/
	} break;
		/*251*/
	case CefBrowserHost_SetFocus_4: {
		/*252*/

		/*253*/
		// gen! void SetFocus(bool focus)
		/*254*/

		me->SetFocus(v1->i32 != 0);
		/*255*/

		/*256*/
	} break;
		/*257*/
	case CefBrowserHost_GetWindowHandle_5: {
		/*258*/

		/*259*/
		// gen! CefWindowHandle GetWindowHandle()
		/*260*/

		auto ret_result = me->GetWindowHandle();
		/*261*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*262*/
	} break;
		/*263*/
	case CefBrowserHost_GetOpenerWindowHandle_6: {
		/*264*/

		/*265*/
		// gen! CefWindowHandle GetOpenerWindowHandle()
		/*266*/

		auto ret_result = me->GetOpenerWindowHandle();
		/*267*/
		MyCefSetInt32(ret, (int32_t)ret_result);
		/*268*/
	} break;
		/*269*/
	case CefBrowserHost_HasView_7: {
		/*270*/

		/*271*/
		// gen! bool HasView()
		/*272*/

		auto ret_result = me->HasView();
		/*273*/
		MyCefSetBool(ret, ret_result);
		/*274*/
	} break;
		/*275*/
	case CefBrowserHost_GetClient_8: {
		/*276*/

		/*277*/
		// gen! CefRefPtr<CefClient> GetClient()
		/*278*/

		auto ret_result = me->GetClient();
		/*279*/
		MyCefSetVoidPtr(ret, CefClientCppToC::Wrap(ret_result));
		/*280*/
	} break;
		/*281*/
	case CefBrowserHost_GetRequestContext_9: {
		/*282*/

		/*283*/
		// gen! CefRefPtr<CefRequestContext> GetRequestContext()
		/*284*/

		auto ret_result = me->GetRequestContext();
		/*285*/
		MyCefSetVoidPtr(ret, CefRequestContextCToCpp::Unwrap(ret_result));
		/*286*/
	} break;
		/*287*/
	case CefBrowserHost_GetZoomLevel_10: {
		/*288*/

		/*289*/
		// gen! double GetZoomLevel()
		/*290*/

		auto ret_result = me->GetZoomLevel();
		/*291*/
		MyCefSetDouble(ret, ret_result);
		/*292*/
	} break;
		/*293*/
	case CefBrowserHost_SetZoomLevel_11: {
		/*294*/

		/*295*/
		// gen! void SetZoomLevel(double zoomLevel)
		/*296*/

		me->SetZoomLevel(v1->num);
		/*297*/

		/*298*/
	} break;
		/*299*/
	case CefBrowserHost_RunFileDialog_12: {
		/*300*/

		/*301*/
		// gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
		/*302*/

		me->RunFileDialog((CefBrowserHost::FileDialogMode)v1->i32,
			GetStringHolder(v2)->value,
			GetStringHolder(v3)->value,
			*((std::vector<CefString>*)v4->ptr),
			v5->i32,
			CefRunFileDialogCallbackCppToC::Unwrap((cef_run_file_dialog_callback_t*)v6->ptr));
		/*303*/

		/*304*/
	} break;
		/*305*/
	case CefBrowserHost_StartDownload_13: {
		/*306*/

		/*307*/
		// gen! void StartDownload(const CefString& url)
		/*308*/

		me->StartDownload(GetStringHolder(v1)->value);
		/*309*/

		/*310*/
	} break;
		/*311*/
	case CefBrowserHost_DownloadImage_14: {
		/*312*/

		/*313*/
		// gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
		/*314*/

		me->DownloadImage(GetStringHolder(v1)->value,
			v2->i32 != 0,
			v3->i32,
			v4->i32 != 0,
			CefDownloadImageCallbackCppToC::Unwrap((cef_download_image_callback_t*)v5->ptr));
		/*315*/

		/*316*/
	} break;
		/*317*/
	case CefBrowserHost_Print_15: {
		/*318*/

		/*319*/
		// gen! void Print()
		/*320*/

		me->Print();
		/*321*/

		/*322*/
	} break;
		/*323*/
	case CefBrowserHost_PrintToPDF_16: {
		/*324*/

		/*325*/
		// gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
		/*326*/

		me->PrintToPDF(GetStringHolder(v1)->value,
			*((CefPdfPrintSettings*)v2->ptr),
			CefPdfPrintCallbackCppToC::Unwrap((cef_pdf_print_callback_t*)v3->ptr));
		/*327*/

		/*328*/
	} break;
		/*329*/
	case CefBrowserHost_Find_17: {
		/*330*/

		/*331*/
		// gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
		/*332*/

		me->Find(v1->i32,
			GetStringHolder(v2)->value,
			v3->i32 != 0,
			v4->i32 != 0,
			v5->i32 != 0);
		/*333*/

		/*334*/
	} break;
		/*335*/
	case CefBrowserHost_StopFinding_18: {
		/*336*/

		/*337*/
		// gen! void StopFinding(bool clearSelection)
		/*338*/

		me->StopFinding(v1->i32 != 0);
		/*339*/

		/*340*/
	} break;
		/*341*/
	case CefBrowserHost_ShowDevTools_19: {
		/*342*/

		/*343*/
		// gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
		/*344*/

		me->ShowDevTools(*((CefWindowInfo*)v1->ptr),
			CefClientCppToC::Unwrap((cef_client_t*)v2->ptr),
			*((CefBrowserSettings*)v3->ptr),
			*((CefPoint*)v4->ptr));
		/*345*/

		/*346*/
	} break;
		/*347*/
	case CefBrowserHost_CloseDevTools_20: {
		/*348*/

		/*349*/
		// gen! void CloseDevTools()
		/*350*/

		me->CloseDevTools();
		/*351*/

		/*352*/
	} break;
		/*353*/
	case CefBrowserHost_HasDevTools_21: {
		/*354*/

		/*355*/
		// gen! bool HasDevTools()
		/*356*/

		auto ret_result = me->HasDevTools();
		/*357*/
		MyCefSetBool(ret, ret_result);
		/*358*/
	} break;
		/*359*/
	case CefBrowserHost_GetNavigationEntries_22: {
		/*360*/

		/*361*/
		// gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
		/*362*/

		me->GetNavigationEntries(CefNavigationEntryVisitorCppToC::Unwrap((cef_navigation_entry_visitor_t*)v1->ptr),
			v2->i32 != 0);
		/*363*/

		/*364*/
	} break;
		/*365*/
	case CefBrowserHost_SetMouseCursorChangeDisabled_23: {
		/*366*/

		/*367*/
		// gen! void SetMouseCursorChangeDisabled(bool disabled)
		/*368*/

		me->SetMouseCursorChangeDisabled(v1->i32 != 0);
		/*369*/

		/*370*/
	} break;
		/*371*/
	case CefBrowserHost_IsMouseCursorChangeDisabled_24: {
		/*372*/

		/*373*/
		// gen! bool IsMouseCursorChangeDisabled()
		/*374*/

		auto ret_result = me->IsMouseCursorChangeDisabled();
		/*375*/
		MyCefSetBool(ret, ret_result);
		/*376*/
	} break;
		/*377*/
	case CefBrowserHost_ReplaceMisspelling_25: {
		/*378*/

		/*379*/
		// gen! void ReplaceMisspelling(const CefString& word)
		/*380*/

		me->ReplaceMisspelling(GetStringHolder(v1)->value);
		/*381*/

		/*382*/
	} break;
		/*383*/
	case CefBrowserHost_AddWordToDictionary_26: {
		/*384*/

		/*385*/
		// gen! void AddWordToDictionary(const CefString& word)
		/*386*/

		me->AddWordToDictionary(GetStringHolder(v1)->value);
		/*387*/

		/*388*/
	} break;
		/*389*/
	case CefBrowserHost_IsWindowRenderingDisabled_27: {
		/*390*/

		/*391*/
		// gen! bool IsWindowRenderingDisabled()
		/*392*/

		auto ret_result = me->IsWindowRenderingDisabled();
		/*393*/
		MyCefSetBool(ret, ret_result);
		/*394*/
	} break;
		/*395*/
	case CefBrowserHost_WasResized_28: {
		/*396*/

		/*397*/
		// gen! void WasResized()
		/*398*/

		me->WasResized();
		/*399*/

		/*400*/
	} break;
		/*401*/
	case CefBrowserHost_WasHidden_29: {
		/*402*/

		/*403*/
		// gen! void WasHidden(bool hidden)
		/*404*/

		me->WasHidden(v1->i32 != 0);
		/*405*/

		/*406*/
	} break;
		/*407*/
	case CefBrowserHost_NotifyScreenInfoChanged_30: {
		/*408*/

		/*409*/
		// gen! void NotifyScreenInfoChanged()
		/*410*/

		me->NotifyScreenInfoChanged();
		/*411*/

		/*412*/
	} break;
		/*413*/
	case CefBrowserHost_Invalidate_31: {
		/*414*/

		/*415*/
		// gen! void Invalidate(PaintElementType type)
		/*416*/

		me->Invalidate((CefBrowserHost::PaintElementType)v1->i32);
		/*417*/

		/*418*/
	} break;
		/*419*/
	case CefBrowserHost_SendKeyEvent_32: {
		/*420*/

		/*421*/
		// gen! void SendKeyEvent(const CefKeyEvent& event)
		/*422*/

		me->SendKeyEvent(*((CefKeyEvent*)v1->ptr));
		/*423*/

		/*424*/
	} break;
		/*425*/
	case CefBrowserHost_SendMouseClickEvent_33: {
		/*426*/

		/*427*/
		// gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
		/*428*/

		me->SendMouseClickEvent(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::MouseButtonType)v2->i32,
			v3->i32 != 0,
			v4->i32);
		/*429*/

		/*430*/
	} break;
		/*431*/
	case CefBrowserHost_SendMouseMoveEvent_34: {
		/*432*/

		/*433*/
		// gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
		/*434*/

		me->SendMouseMoveEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32 != 0);
		/*435*/

		/*436*/
	} break;
		/*437*/
	case CefBrowserHost_SendMouseWheelEvent_35: {
		/*438*/

		/*439*/
		// gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
		/*440*/

		me->SendMouseWheelEvent(*((CefMouseEvent*)v1->ptr),
			v2->i32,
			v3->i32);
		/*441*/

		/*442*/
	} break;
		/*443*/
	case CefBrowserHost_SendFocusEvent_36: {
		/*444*/

		/*445*/
		// gen! void SendFocusEvent(bool setFocus)
		/*446*/

		me->SendFocusEvent(v1->i32 != 0);
		/*447*/

		/*448*/
	} break;
		/*449*/
	case CefBrowserHost_SendCaptureLostEvent_37: {
		/*450*/

		/*451*/
		// gen! void SendCaptureLostEvent()
		/*452*/

		me->SendCaptureLostEvent();
		/*453*/

		/*454*/
	} break;
		/*455*/
	case CefBrowserHost_NotifyMoveOrResizeStarted_38: {
		/*456*/

		/*457*/
		// gen! void NotifyMoveOrResizeStarted()
		/*458*/

		me->NotifyMoveOrResizeStarted();
		/*459*/

		/*460*/
	} break;
		/*461*/
	case CefBrowserHost_GetWindowlessFrameRate_39: {
		/*462*/

		/*463*/
		// gen! int GetWindowlessFrameRate()
		/*464*/

		auto ret_result = me->GetWindowlessFrameRate();
		/*465*/
		MyCefSetInt64(ret, ret_result);
		/*466*/
	} break;
		/*467*/
	case CefBrowserHost_SetWindowlessFrameRate_40: {
		/*468*/

		/*469*/
		// gen! void SetWindowlessFrameRate(int frame_rate)
		/*470*/

		me->SetWindowlessFrameRate(v1->i32);
		/*471*/

		/*472*/
	} break;
		/*473*/
	case CefBrowserHost_ImeSetComposition_41: {
		/*474*/

		/*475*/
		// gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
		/*476*/

		me->ImeSetComposition(GetStringHolder(v1)->value,
			*((std::vector<CefCompositionUnderline>*)v2->ptr),
			*((CefRange*)v3->ptr),
			*((CefRange*)v4->ptr));
		/*477*/

		/*478*/
	} break;
		/*479*/
	case CefBrowserHost_ImeCommitText_42: {
		/*480*/

		/*481*/
		// gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
		/*482*/

		me->ImeCommitText(GetStringHolder(v1)->value,
			*((CefRange*)v2->ptr),
			v3->i32);
		/*483*/

		/*484*/
	} break;
		/*485*/
	case CefBrowserHost_ImeFinishComposingText_43: {
		/*486*/

		/*487*/
		// gen! void ImeFinishComposingText(bool keep_selection)
		/*488*/

		me->ImeFinishComposingText(v1->i32 != 0);
		/*489*/

		/*490*/
	} break;
		/*491*/
	case CefBrowserHost_ImeCancelComposition_44: {
		/*492*/

		/*493*/
		// gen! void ImeCancelComposition()
		/*494*/

		me->ImeCancelComposition();
		/*495*/

		/*496*/
	} break;
		/*497*/
	case CefBrowserHost_DragTargetDragEnter_45: {
		/*498*/

		/*499*/
		// gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
		/*500*/

		me->DragTargetDragEnter(CefDragDataCToCpp::Wrap((cef_drag_data_t*)v1->ptr),
			*((CefMouseEvent*)v2->ptr),
			(CefBrowserHost::DragOperationsMask)v3->i32);
		/*501*/

		/*502*/
	} break;
		/*503*/
	case CefBrowserHost_DragTargetDragOver_46: {
		/*504*/

		/*505*/
		// gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
		/*506*/

		me->DragTargetDragOver(*((CefMouseEvent*)v1->ptr),
			(CefBrowserHost::DragOperationsMask)v2->i32);
		/*507*/

		/*508*/
	} break;
		/*509*/
	case CefBrowserHost_DragTargetDragLeave_47: {
		/*510*/

		/*511*/
		// gen! void DragTargetDragLeave()
		/*512*/

		me->DragTargetDragLeave();
		/*513*/

		/*514*/
	} break;
		/*515*/
	case CefBrowserHost_DragTargetDrop_48: {
		/*516*/

		/*517*/
		// gen! void DragTargetDrop(const CefMouseEvent& event)
		/*518*/

		me->DragTargetDrop(*((CefMouseEvent*)v1->ptr));
		/*519*/

		/*520*/
	} break;
		/*521*/
	case CefBrowserHost_DragSourceEndedAt_49: {
		/*522*/

		/*523*/
		// gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
		/*524*/

		me->DragSourceEndedAt(v1->i32,
			v2->i32,
			(CefBrowserHost::DragOperationsMask)v3->i32);
		/*525*/

		/*526*/
	} break;
		/*527*/
	case CefBrowserHost_DragSourceSystemDragEnded_50: {
		/*528*/

		/*529*/
		// gen! void DragSourceSystemDragEnded()
		/*530*/

		me->DragSourceSystemDragEnded();
		/*531*/

		/*532*/
	} break;
		/*533*/
	case CefBrowserHost_GetVisibleNavigationEntry_51: {
		/*534*/

		/*535*/
		// gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
		/*536*/

		auto ret_result = me->GetVisibleNavigationEntry();
		/*537*/
		MyCefSetVoidPtr(ret, CefNavigationEntryCToCpp::Unwrap(ret_result));
		/*538*/
	} break;
		/*539*/
	case CefBrowserHost_SetAccessibilityState_52: {
		/*540*/

		/*541*/
		// gen! void SetAccessibilityState(cef_state_t accessibility_state)
		/*542*/

		me->SetAccessibilityState((cef_state_t)v1->i32);
		/*543*/

		/*544*/
	} break;
		/*545*/
	}
	/*546*/
	CefBrowserHostCToCpp::Unwrap(me);
	/*547*/
}
