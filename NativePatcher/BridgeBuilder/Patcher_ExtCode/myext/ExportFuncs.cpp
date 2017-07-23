//MIT, 2015-2017, WinterDev
#include "ExportFuncs.h"   
#include "dll_init.h" 
#include "mycef.h"

#include "include/cef_parser.h"
#include "include/cef_origin_whitelist.h" //add original whitelist
#include "tests/shared/browser/client_app_browser.h"  
#include "tests/shared/common/client_app_other.h"
#include "tests/shared/renderer/client_app_renderer.h"  

//
#include "tests/shared/browser/main_message_loop_std.h" 
//
#include "../browser/root_window_win.h" //**
#include "../browser/browser_window_osr_win.h" //**
#include "tests/cefclient/browser/browser_window_std_win.h" 




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


void MyCefCloseMyWebBrowser(MyBrowser* myBw) {
	myBw->bwWindow->ClientClose();
}



void MyCefEnableKeyIntercept(MyBrowser* myBw, int enable) {
	auto clientHandle = myBw->bwWindow->GetClientHandler();
	clientHandle->MyCefEnableKeyIntercept(enable);
}


void MyCefSetBrowserSize(MyBrowser* myBw, int w, int h) {

	myBw->bwWindow->SetBounds(0, 0, w, h);
}

//---------------------
class MyCefStringVisitor : public CefStringVisitor {
public:
	managed_callback mcallback;
	explicit MyCefStringVisitor(CefRefPtr<CefBrowser> browser) : browser_(browser) {
		mcallback = NULL;
	}
	virtual void Visit(const CefString& string) OVERRIDE {

		MethodArgs metArgs;
		memset(&metArgs, 0, sizeof(MethodArgs));
		metArgs.SetArgAsNativeObject(0, &string);
		metArgs.SetArgType(0, JSVALUE_TYPE_NATIVE_CEFSTRING);
		this->mcallback(CEF_MSG_MyCefDomGetTextWalk_Visit, &metArgs);
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
CefFrame* MyCefBwGetMainFrame(MyBrowser *myBw) {

	auto cefFrame = myBw->bwWindow->GetBrowser()->GetMainFrame();
	cefFrame->AddRef();//*** before send to external framework
	return cefFrame;
}
void MyCefFrameGetSource(CefFrame* cefFrame, managed_callback strCallBack) {

	auto bwVisitor = new MyCefStringVisitor(cefFrame->GetBrowser());
	bwVisitor->mcallback = strCallBack;
	cefFrame->GetSource(bwVisitor);
}



//part3: 
//1. 
void MyCefBwNavigateTo(MyBrowser* myBw, const wchar_t* url) {

	myBw->bwWindow->GetBrowser()->GetMainFrame()->LoadURL(url);
}
//2.
void MyCefBwExecJavascript(MyBrowser* myBw, const wchar_t* jscode, const wchar_t* script_url) {

	myBw->bwWindow->GetBrowser()->GetMainFrame()->ExecuteJavaScript(jscode, script_url, 0);
}

//3. 
void MyCefBwPostData(MyBrowser* myBw, const wchar_t* url, const wchar_t* rawDataToPost, size_t rawDataLength) {

	//create request
	CefRefPtr<CefRequest> request(CefRequest::Create());
	request->SetURL(url);

	//Add post data to request, the correct method and content-type header will be set by CEF

	CefRefPtr<CefPostDataElement> postDataElement(CefPostDataElement::Create());
	postDataElement->SetToBytes(rawDataLength, rawDataToPost);
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
void MyCefBwGoBack(MyBrowser* myBw) {

	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {

		browser->GoBack();
	}
}
void MyCefBwGoForward(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {


		browser->GoForward();
	}
}
void MyCefBwStop(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->StopLoad();
	}
}
void MyCefBwReload(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->Reload();
	}
}
void MyCefBwReloadIgnoreCache(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->ReloadIgnoreCache();
	}
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
void MyCefFrame_GetUrl(CefFrame* frame, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{

	CefString str = frame->GetURL();
	int str_len = (int)str.length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, str.c_str());
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
void MyCefDeleteContent(jsvalue* ptr) {
	switch (ptr->type)
	{
	case JSVALUE_TYPE_BUFFER:
	case JSVALUE_TYPE_ARRAY:
		delete[] ptr->ptr;
		break;
	case JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING:
		delete ptr->ptr;
		break;
	default:
		break;
	}
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

void MyCefBwCall0(MyBrowser* myBw, int methodName, jsvalue* ret) {
	MyCefBwCall2(myBw, methodName, ret, nullptr, nullptr);
}
void MyCefBwCall1(MyBrowser* myBw, int methodName, jsvalue* ret, jsvalue* v1) {
	MyCefBwCall2(myBw, methodName, ret, v1, nullptr);
}
void MyCefBwCall2(MyBrowser* myBw, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {

	auto bw = myBw->bwWindow->GetBrowser();
	//
	switch (methodName) {
	case 1: {
		bw->GoBack();
		ret->type = JSVALUE_TYPE_EMPTY;
	}	break;
	case 2: {
		bw->Reload();
		ret->type = JSVALUE_TYPE_EMPTY;
	}	break;
	case 3: {
		bw->ReloadIgnoreCache();
		ret->type = JSVALUE_TYPE_EMPTY;
	}	break;
	case 4: {
		auto frameCount = bw->GetFrameCount();
		ret->type = JSVALUE_TYPE_INTEGER;
		ret->i32 = (int32_t)frameCount;
	} break;
	case 5: {
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = bw;
	}break;
	case 6: {
		ret->i32 = bw->IsSame((CefBrowser*)v1->ptr) ? 1 : 0;
		ret->type = JSVALUE_TYPE_BOOLEAN;
	} break;
	case 7: {
		std::vector<CefString> cefStringList;
		bw->GetFrameNames(cefStringList);
		CopyStringListToResult(v1, cefStringList);

		ret->type = JSVALUE_TYPE_EMPTY;
	}break;
		//case 8: {
		//	//export 
		//	std::vector<CefString>* cefStringList = new std::vector<CefString>();
		//	ret->type = JSVALUE_TYPE_WRAPPED;
		//	ret->ptr = cefStringList;
		//}break;
	case 9: {
		//get string list
		std::vector<CefString>* cefStringList = (std::vector<CefString>*)v1->ptr;
		ret->type = JSVALUE_TYPE_INTEGER;
		ret->i32 = cefStringList->size();

	}break;
	case 10: {
		//get int list
		std::vector<int64> int64list;
		bw->GetFrameIdentifiers(int64list);
		CopyInt64ListToResult(v1, int64list);
		ret->type = JSVALUE_TYPE_EMPTY;
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
	case 21: {
		//get string
		CefString cefStr = bw->GetMainFrame()->GetURL();
		ret->type = JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;

		MyCefStringHolder* myCefStringHolder = new MyCefStringHolder();
		myCefStringHolder->value = cefStr;
		ret->ptr = myCefStringHolder;
		ret->i32 = cefStr.length();

	}break;
		//
	}
}


