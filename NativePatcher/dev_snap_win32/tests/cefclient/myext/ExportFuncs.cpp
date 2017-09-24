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
#include "libcef_dll/ctocpp/browser_ctocpp.h"
#include "libcef_dll/ctocpp/v8context_ctocpp.h"
//
#include "libcef_dll/ctocpp/download_item_callback_ctocpp.h"
#include "libcef_dll/cpptoc/download_image_callback_cpptoc.h"
#include "libcef_dll/cpptoc/run_file_dialog_callback_cpptoc.h"

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
	explicit MyCefStringVisitor() {
		mcallback = NULL;
	}
	virtual void Visit(const CefString& string) OVERRIDE {

		if (mcallback) {

			INIT_MY_MET_ARGS(metArgs, 1)
				SetCefStringToJsValue2(&vargs[1], string);
			mcallback(CEF_MSG_MyCefDomGetTextWalk_Visit, &metArgs);
		}
	}
private:
	IMPLEMENT_REFCOUNTING(MyCefStringVisitor);
};

void MyCefDomGetTextWalk(MyBrowser* myBw, managed_callback strCallBack)
{
	auto bw = myBw->bwWindow->GetBrowser();
	auto bwVisitor = new MyCefStringVisitor();
	bwVisitor->mcallback = strCallBack;
	bw->GetMainFrame()->GetText(bwVisitor);
	//this is not blocking method, so=> need to create visitor on heap

}
void MyCefDomGetSourceWalk(MyBrowser* myBw, managed_callback strCallBack)
{
	auto bw = myBw->bwWindow->GetBrowser();
	auto bwVisitor = new MyCefStringVisitor();
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
				INIT_MY_MET_ARGS(metArgs, 2)
					MyCefSetBool(&vargs[1], ok);
				SetCefStringToJsValue2(&vargs[2], path);
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


void HereOnRenderer(const managed_callback callback, MyMetArgsN* args)
{
	callback(CEF_MSG_HereOnRenderer, args);
}


void MyCefJsNotifyRenderer(const managed_callback callback, MyMetArgsN* args) {
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
//----------------

MY_DLL_EXPORT managed_callback MyCefJsValueGetManagedCallback(jsvalue* v) {
	if (v->type == JSVALUE_TYPE_MANAGED_CB) {
		return (managed_callback)v->ptr;
	}
	else {
		return nullptr;
	}
}
MY_DLL_EXPORT void MyCefJsValueSetManagedCallback(jsvalue* v, managed_callback cb) {
	v->type = JSVALUE_TYPE_MANAGED_CB;
	v->ptr = cb;
}

const int CefBw_MyCef_EnableKeyIntercept = 11;
const int CefBw_SetSize = 25;

const int CefBw_PostData = 27;
const int CefBw_CloseBw = 28;
const int CefBw_GetMainFrame = 29;
const int CefBw_GetCefBrowser = 31;
//----------------

void MyCefBwCall2(MyBrowser* myBw, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {

	auto bw = myBw->bwWindow->GetBrowser();
	ret->type = JSVALUE_TYPE_EMPTY;

	switch (methodName) {
	case CefBw_MyCef_EnableKeyIntercept: {
		auto clientHandle = myBw->bwWindow->GetClientHandler();
		clientHandle->MyCefEnableKeyIntercept(v1->i32);
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
	case CefBw_GetCefBrowser: {
		//***		
		cef_browser_t* cef_browser = CefBrowserCToCpp::Unwrap(myBw->bwWindow->GetBrowser());
		ret->ptr = cef_browser;
		ret->type = JSVALUE_TYPE_WRAPPED;
		//***
	}break;
	case CefBw_SetSize: {
		myBw->bwWindow->SetBounds(0, 0, v1->i32, v2->i32);
	}break;
	case CefBw_PostData: {

		//create request:
		// 
		CefRefPtr<CefRequest> request(CefRequest::Create());
		MyCefStringHolder* url = (MyCefStringHolder*)v1->ptr;
		request->SetURL(url->value);
		//Add post data to request, the correct method and content-type header will be set by CEF 
		CefRefPtr<CefPostDataElement> postDataElement(CefPostDataElement::Create());


		char* buffer1 = new char[v2->i32];
		memcpy_s(buffer1, v2->i32, v2->ptr, v2->i32);
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
	}
}

 

void* CreateStdList(int elemType) {
	switch (elemType) {
	case 1:
		return new std::vector<int64>();
	case 2:
		return new std::vector<CefString>();
	case 3:
		return new std::vector<CefCompositionUnderline>();
	default:
		return nullptr;
	}
}

void GetListCount(int elemType, void* list, int32_t* size) {
	switch (elemType) {
	case 1:
		*size = (int32_t)((std::vector<int64>*)list)->size();
		break;
	case 2:
	{
		*size = (int32_t)((std::vector<CefString>*)list)->size();
		break;
	}
	case 3:
		*size = (int32_t)((std::vector<CefCompositionUnderline>*)list)->size();
		break;
	default:
		*size = 0;
		break;
	}
}

void GetListElement(int elemType, void* list, int index, jsvalue* jsvalue) {
	switch (elemType) {
	case 1:
	{
		jsvalue->i64 = ((std::vector<int64>*)list)->at(index);
		break;
	}
	case 2:
	{
		//create string holder for this 
		MyCefStringHolder* myCefStringHolder = new MyCefStringHolder();
		CefString cefstr = ((std::vector<CefString>*)list)->at(index);
		myCefStringHolder->value = cefstr;
		jsvalue->ptr = myCefStringHolder;
		jsvalue->i32 = cefstr.length();
		break;
	}
	case 3:
		//nothing now
	default:
		break;
	}
}


