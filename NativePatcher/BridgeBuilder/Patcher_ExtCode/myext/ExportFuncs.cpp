//MIT, 2015-2017, WinterDev
#include "ExportFuncs.h"   
#include "dll_init.h" 
#include "mycef.h"


//static 

#include "include/base/cef_scoped_ptr.h"
#include "include/cef_command_line.h"

#include "include/cef_origin_whitelist.h"
#include "tests/shared/browser/client_app_browser.h"
#include "tests/cefclient/browser/main_context_impl.h"

#include "tests/shared/browser/main_message_loop_std.h"

#include "tests/cefclient/browser/root_window_manager.h"
#include "tests/cefclient/browser/test_runner.h"
#include "tests/shared/common/client_app_other.h"
#include "tests/shared/renderer/client_app_renderer.h" 
#include "tests/cefclient/browser/browser_window.h" 
#include "tests/cefclient/browser/main_context.h" 


#include "include/cef_sandbox_win.h"
#include "tests/cefclient/browser/main_message_loop_multithreaded_win.h"
#include "tests/cefclient/browser/browser_window_std_win.h"
#include "tests/cefclient/browser/root_window_win.h" //***
#include "tests/cefclient/browser/osr_window_win.h" //*** 
#include "../browser/root_window_win.h" //**
#include "../browser/browser_window_osr_win.h" //**



client::MainContextImpl* mainContext;
client::MainMessageLoop* message_loop;  //essential for mainloop checking 

managed_callback myMxCallback_ = NULL;


class MyBrowser
{
public:
	client::RootWindowWin* rootWin;
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



//3.
client::ClientApp* MyCefCreateClientApp(HINSTANCE hInstance)
{
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
	//create main context here
	client::init_main::SetManagedCallback(myMxCallback_);

	CefMainArgs main_args(hInstance);
	mainContext = DllInitMain(main_args, app);
	return app;
}

//3.1 
MY_DLL_EXPORT void MyCefEnableKeyIntercept(MyBrowser* myBw, int enable) {
	auto clientHandle = myBw->bwWindow->GetClientHandler();
	clientHandle->MyCefEnableKeyIntercept(enable);
}

//4. 
MyBrowser* MyCefCreateMyWebBrowser(managed_callback callback)
{

	//create root window handler?
	auto myBw = new MyBrowser();
	auto rootWindow = new client::RootWindowWin();
	myBw->rootWin = rootWindow;

	//1. create browser window handler
	//TODO: review here again, don't store at this module!
	auto bwWindow = new client::BrowserWindowStdWin(rootWindow, "");
	myBw->bwWindow = bwWindow;

	//2. browser event handler
	auto hh = bwWindow->GetClientHandler();
	hh->MyCefSetManagedCallBack(callback);
	return myBw;
}

//4.OSR
MyBrowser* MyCefCreateMyWebBrowserOSR(managed_callback callback)
{

	//create root window handler?
	auto myBw = new MyBrowser();
	auto rootWindow = new client::RootWindowWin();
	myBw->rootWin = rootWindow;

	//1. create browser window handler
	//TODO: review here again, don't store at this module!
	client::OsrRenderer::Settings settings;
	client::MainContext::Get()->PopulateOsrSettings(&settings);
	auto bwWindow = new client::BrowserWindowOsrWin(rootWindow, "", settings);

	//SetUserDataPtr()
	myBw->bwWindow = bwWindow;

	//2. browser event handler
	auto hh = bwWindow->GetClientHandler();
	hh->MyCefSetManagedCallBack(callback);
	return myBw;
}

//5.
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

	if (result) {
		return 1;
	}
	else {
		return 0;
	}
}

//5. OSR
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
//6
void MyCefCloseMyWebBrowser(MyBrowser* myBw) {
	myBw->bwWindow->ClientClose();
}

//7.
void MyCefDoMessageLoopWork()
{
	CefDoMessageLoopWork();
}
//8.
void MyCefShutDown() {

	// Shut down CEF.
	mainContext->Shutdown();
	// Release objects in reverse order of creation. 
	/*CefShutdown();*/
}

//9.
void MyCefSetBrowserSize(MyBrowser* myBw, int w, int h) {
	//auto windowHandle = myBw->bwWindow->GetWindowHandle();
	myBw->bwWindow->SetBounds(0, 0, w, h);
}


void MyCefDomGetTextWalk(MyBrowser* myBw, managed_callback strCallBack)
{
	//---------------------
	class Visitor : public CefStringVisitor {
	public:
		managed_callback mcallback;
		explicit Visitor(CefRefPtr<CefBrowser> browser) : browser_(browser) {
			mcallback = NULL;
		}
		virtual void Visit(const CefString& string) OVERRIDE {

			MethodArgs metArgs;
			memset(&metArgs, 0, sizeof(MethodArgs));
			metArgs.SetArgAsNativeObject(0, &string);
			metArgs.SetArgType(0, JSVALUE_TYPE_NATIVE_CEFSTRING);
			this->mcallback(302, &metArgs);
		}
	private:
		CefRefPtr<CefBrowser> browser_;
		IMPLEMENT_REFCOUNTING(Visitor);
	};

	//---------------------
	//delegate/lambda pattern
	auto bw = myBw->bwWindow->GetBrowser();
	auto bwVisitor = new Visitor(bw);
	bwVisitor->mcallback = strCallBack;
	bw->GetMainFrame()->GetText(bwVisitor);
	delete bwVisitor;
}
void MyCefDomGetSourceWalk(MyBrowser* myBw, managed_callback strCallBack)
{
	//---------------------
	class Visitor : public CefStringVisitor {
	public:
		managed_callback mcallback;
		explicit Visitor(CefRefPtr<CefBrowser> browser) : browser_(browser) {
			mcallback = NULL;
		}
		virtual void Visit(const CefString& string) OVERRIDE {

			MethodArgs metArgs;
			memset(&metArgs, 0, sizeof(MethodArgs));
			metArgs.SetArgAsNativeObject(0, &string);
			metArgs.SetArgType(0, JSVALUE_TYPE_NATIVE_CEFSTRING);
			this->mcallback(302, &metArgs);
		}
	private:
		CefRefPtr<CefBrowser> browser_;
		IMPLEMENT_REFCOUNTING(Visitor);
	};

	//---------------------
	//delegate/lambda pattern
	auto bw = myBw->bwWindow->GetBrowser();
	auto bwVisitor = new Visitor(bw);
	bwVisitor->mcallback = strCallBack;
	bw->GetMainFrame()->GetSource(bwVisitor);
	delete bwVisitor;
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
//--------------------------------------------------------------------------------------------------
//part 2:
//1. 


void MyCefNativeMetGetArgs(MethodArgs* args, int argIndex, jsvalue* output)
{
	switch (argIndex)
	{
	case 0:
	{
		*output = args->arg0; 
		break;
	}
	case 1:
	{
		*output = args->arg1; 
		break;
	}
	case 2: {
		*output = args->arg2; 
		break;
	}
	case 3: {
		*output = args->arg3; 
		break;
	}
	case 4: {
		*output = args->arg4; 
		break;
	}
	default:
		output->type = JSVALUE_TYPE_EMPTY;
		break;
	}
}

//3.
void MyCefMetArgs_SetResultAsJsValue(MethodArgs* args, int retIndex, jsvalue* value)
{
	switch (retIndex) {
	case 0:
		args->result0 = *(value);
		break;
	case 1:
		args->result1 = *(value);
		break;
	case 2:
		args->result2 = *(value);
		break;
	case 3:
		args->result3 = *(value);
		break;
	case 4:
		args->result4 = *(value);
		break; 
	}
}
//4.
void MyCefMetArgs_SetResultAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len) {

	switch (argIndex)
	{
	case 0: {

		args->result0.type = JSVALUE_TYPE_STRING;
		args->result0.i32 = (int32_t)len;
		args->result0.ptr = buffer;
	}break;
	case 1: {

		args->result1.type = JSVALUE_TYPE_STRING;
		args->result1.i32 = (int32_t)len;
		args->result1.ptr = buffer;
	}break;
	case 2: {

		args->result2.type = JSVALUE_TYPE_STRING;
		args->result2.i32 = (int32_t)len;
		args->result2.ptr = buffer;
	}break;
	case 3: {

		args->result3.type = JSVALUE_TYPE_STRING;
		args->result3.i32 = (int32_t)len;
		args->result3.ptr = buffer;
	}break;
	case 4: {

		args->result4.type = JSVALUE_TYPE_STRING;
		args->result4.i32 = (int32_t)len;
		args->result4.ptr = buffer;
	}break;
	}
}
void MyCefMetArgs_SetInputAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len) {

	//input
	switch (argIndex)
	{
	case 0: {

		args->arg0.type = JSVALUE_TYPE_STRING;
		args->arg0.i32 = (int32_t)len;
		args->arg0.ptr = buffer;
	}break;
	case 1: {

		args->arg1.type = JSVALUE_TYPE_STRING;
		args->arg1.i32 = (int32_t)len;
		args->arg1.ptr = buffer;
	}break;
	case 2: {

		args->arg2.type = JSVALUE_TYPE_STRING;
		args->arg2.i32 = (int32_t)len;
		args->arg2.ptr = buffer;
	}break;
	case 3: {

		args->arg3.type = JSVALUE_TYPE_STRING;
		args->arg3.i32 = (int32_t)len;
		args->arg3.ptr = buffer;
	}break;
	case 4: {

		args->arg4.type = JSVALUE_TYPE_STRING;
		args->arg4.i32 = (int32_t)len;
		args->arg4.ptr = buffer;
	}break;
	}
}
void MyCefMetArgs_SetInputAsInt32(MethodArgs* args, int argIndex, int32_t value) {

	//input
	switch (argIndex)
	{
	case 0: {

		args->arg0.type = JSVALUE_TYPE_INTEGER;
		args->arg0.i32 = value;
	}break;
	case 1: {

		args->arg1.type = JSVALUE_TYPE_INTEGER;
		args->arg1.i32 = value;
	}break;
	case 2: {

		args->arg2.type = JSVALUE_TYPE_INTEGER;
		args->arg2.i32 = value;
	}break;
	case 3: {

		args->arg3.type = JSVALUE_TYPE_INTEGER;
		args->arg3.i32 = value;
	}break;
	case 4: {

		args->arg4.type = JSVALUE_TYPE_INTEGER;
		args->arg4.i32 = value;
	}break;
	}
}
//4.
void MyCefMetArgs_SetResultAsByteBuffer(MethodArgs* args, int argIndex, const char* byteBuffer, int len) {

	switch (argIndex)
	{
	case 0: {

		args->result0.type = JSVALUE_TYPE_BUFFER;
		args->result0.i32 = (int32_t)len;
		args->result0.ptr = byteBuffer;
	}break;
	case 1: {

		args->result1.type = JSVALUE_TYPE_BUFFER;
		args->result1.i32 = (int32_t)len;
		args->result1.ptr = byteBuffer;
	}break;
	case 2: {

		args->result2.type = JSVALUE_TYPE_BUFFER;
		args->result2.i32 = (int32_t)len;
		args->result2.ptr = byteBuffer;
	}break;
	case 3: {

		args->result3.type = JSVALUE_TYPE_BUFFER;
		args->result3.i32 = (int32_t)len;
		args->result3.ptr = byteBuffer;
	}break;
	case 4: {

		args->result4.type = JSVALUE_TYPE_BUFFER;
		args->result4.i32 = (int32_t)len;
		args->result4.ptr = byteBuffer;
	}break;
	}
}
void MyCefMetArgs_SetResultAsInt32(MethodArgs* args, int argIndex, int value)
{
	switch (argIndex)
	{
	case 0: {

		args->result0.type = JSVALUE_TYPE_INTEGER;
		args->result0.i32 = (int32_t)value;
	}break;
	case 1: {

		args->result1.type = JSVALUE_TYPE_INTEGER;
		args->result1.i32 = (int32_t)value;
	}break;
	case 2: {

		args->result2.type = JSVALUE_TYPE_INTEGER;
		args->result2.i32 = (int32_t)value;
	}break;
	case 3: {

		args->result3.type = JSVALUE_TYPE_INTEGER;
		args->result3.i32 = (int32_t)value;
	}break;
	case 4: {

		args->result4.type = JSVALUE_TYPE_INTEGER;
		args->result4.i32 = (int32_t)value;
	}break;
	}

}

//---------------------------------------------------------------------------
//part3:

//1. 
void MyCefBwNavigateTo(MyBrowser* myBw, const wchar_t* url) {

	myBw->bwWindow->GetBrowser()->GetMainFrame()->LoadURL(url);
}
//2.
void MyCefBwExecJavascript(MyBrowser* myBw, const wchar_t* jscode, const wchar_t* script_url) {

	myBw->bwWindow->GetBrowser()->GetMainFrame()->ExecuteJavaScript(jscode, script_url, 0);
}
void MyCefBwExecJavascript2(CefBrowser* nativeWb, const wchar_t* jscode, const wchar_t* script_url) {
	nativeWb->GetMainFrame()->ExecuteJavaScript(jscode, script_url, 0);
}
//3. 
void MyCefBwPostData(MyBrowser* myBw, const wchar_t* url, const wchar_t* rawDataToPost, size_t rawDataLength) {

	//create request
	CefRefPtr<CefRequest> request(CefRequest::Create());
	request->SetURL(url);

	//Add post data to request, the correct method and content-type header willbe set by CEF

	CefRefPtr<CefPostDataElement> postDataElement(CefPostDataElement::Create());
	postDataElement->SetToBytes(rawDataLength, rawDataToPost);
	CefRefPtr<CefPostData> postData(CefPostData::Create());
	postData->AddElement(postDataElement);
	request->SetPostData(postData);

	//add custom header
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
MY_DLL_EXPORT void MyCefBwGoBack(MyBrowser* myBw) {

	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->GoBack();
	}
}
MY_DLL_EXPORT void MyCefBwGoForward(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->GoForward();
	}
}
MY_DLL_EXPORT void MyCefBwStop(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->StopLoad();
	}
}
MY_DLL_EXPORT void MyCefBwReload(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->Reload();
	}
}
MY_DLL_EXPORT void MyCefBwReloadIgnoreCache(MyBrowser* myBw) {
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()) {
		browser->ReloadIgnoreCache();
	}
}


//---------------------------------------------------------------------------
//part4: javascript context
MY_DLL_EXPORT CefV8Context* MyCefJsGetCurrentContext() {
	auto currentContext = CefV8Context::GetCurrentContext();
	currentContext->AddRef();
	return currentContext.get();
}
MY_DLL_EXPORT  CefV8Context* MyCefJs_GetEnteredContext() {
	auto enteredContext = CefV8Context::GetEnteredContext();
	enteredContext->AddRef();
	return enteredContext.get();
}
MY_DLL_EXPORT  CefV8Context* MyCefJs_ContextEnter() {
	auto enteredContext = CefV8Context::GetEnteredContext();
	enteredContext->AddRef();
	return enteredContext.get();
}
MY_DLL_EXPORT MyCefStringHolder* MyCefCreateCefString(const wchar_t*  str) {
	MyCefStringHolder* str_h = new MyCefStringHolder();
	auto cefStr = CefV8Value::CreateString(str);
	str_h->any = cefStr;

	return str_h;
}


MY_DLL_EXPORT  CefV8Context* MyCefJsFrameContext(CefFrame* wbFrame) {

	auto ctx = wbFrame->GetV8Context();
	ctx->AddRef();
	return ctx.get();

}
MY_DLL_EXPORT CefV8Value* MyCefJsGetGlobal(CefV8Context* cefV8Context) {

	auto globalObject = cefV8Context->GetGlobal();
	globalObject->AddRef();
	return globalObject.get();
}
MY_DLL_EXPORT CefV8Context* MyCefJs_EnterContext(CefV8Context* cefV8Context) {
	cefV8Context->Enter();
	auto context = cefV8Context->GetCurrentContext();
	context->AddRef();
	return context.get();
}
MY_DLL_EXPORT void MyCefJs_ExitContext(CefV8Context* cefV8Context) {
	cefV8Context->Exit();
}

bool MyCefJs_CefRegisterExtension(const wchar_t* extensionName, const wchar_t* extensionCode) {


	//-----------------------------------------------
	class MyV8ManagedHandler : public CefV8Handler {
	public:

		MyV8ManagedHandler() {
		}
		virtual bool Execute(const CefString& name,
			CefRefPtr<CefV8Value> object,
			const CefV8ValueList& arguments,
			CefRefPtr<CefV8Value>& retval,
			CefString& exception)
		{

			return true;
		}
	private:
		IMPLEMENT_REFCOUNTING(MyV8ManagedHandler);
	};
	//----------------------------------------------- 
	CefString name = extensionName;
	CefString code = extensionCode;
	CefRefPtr<CefV8Handler> handler = new MyV8ManagedHandler();
	return CefRegisterExtension(name, code, handler);
}
MY_DLL_EXPORT CefV8Handler* MyCefJs_New_V8Handler(managed_callback callback) {

	//-----------------------------------------------
	class MyV8ManagedHandler : public CefV8Handler {
	public:
		managed_callback callback;
		MyV8ManagedHandler(managed_callback callback) {
			this->callback = callback;
		}
		virtual bool Execute(const CefString& name,
			CefRefPtr<CefV8Value> object,
			const CefV8ValueList& arguments,
			CefRefPtr<CefV8Value>& retval,
			CefString& exception)
		{
			if (callback) {

				MethodArgs metArgs;
				memset(&metArgs, 0, sizeof(MethodArgs));
				metArgs.SetArgAsNativeObject(0, object);
				metArgs.SetArgAsNativeObject(1, &arguments);
				metArgs.SetArgAsInt32(2, (int32_t)arguments.size());
				//-------------------------------------------
				callback(CEF_MSG_MyV8ManagedHandler_Execute, &metArgs);
				//check result
				retval = CefV8Value::CreateString(metArgs.ReadOutputAsString(0));
				//retval = CefV8Value::CreateString("Hello, world!");

			}
			return true;
		}
	private:
		IMPLEMENT_REFCOUNTING(MyV8ManagedHandler);
	};
	//----------------------------------------------- 
	return new MyV8ManagedHandler(callback);
}

void HereOnRenderer(const managed_callback callback, MethodArgs* args)
{
	callback(CEF_MSG_HereOnRenderer, args);
}

MY_DLL_EXPORT void DisposeMethodArgs(MethodArgs* args) {
	delete args;
}
MY_DLL_EXPORT void MyCefJsNotifyRenderer(const managed_callback callback, MethodArgs* args) {
	CefPostTask(TID_RENDERER, base::Bind(&HereOnRenderer, callback, args));
}
MY_DLL_EXPORT bool MyCefJs_CefV8Value_IsFunc(CefV8Value* target)
{
	return target->IsFunction();
}
MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByString(CefV8Value* target, const wchar_t* key, CefV8Value* value, int setAttribute)
{
	CefString cefstr(key);
	CefRefPtr<CefV8Value> nvalue = value;
	target->SetValue(cefstr, nvalue, (cef_v8_propertyattribute_t)setAttribute);
}
MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByIndex(CefV8Value* target, int index, CefV8Value* value)
{
	target->SetValue(index, value);
}
MY_DLL_EXPORT CefV8Value* MyCefJs_CreateFunction(const wchar_t* name, CefV8Handler* handler)
{
	auto cefFunc = CefV8Value::CreateFunction(name, handler);
	//since cefFunc is reference counting variable,
	//so before we send it out of this lib, we must add reference counting ***
	cefFunc->AddRef();
	return cefFunc.get();
}

MY_DLL_EXPORT CefV8Value* MyCefJs_ExecJsFunctionWithContext(CefV8Value* cefJsFunc, CefV8Context* context, const wchar_t* argAsJsonString)
{
	CefV8ValueList args;
	CefRefPtr<CefV8Value> retval;
	CefRefPtr<CefV8Exception> exception;

	args.push_back(CefV8Value::CreateString(argAsJsonString));

	auto result = cefJsFunc->ExecuteFunctionWithContext(context, NULL, args);
	if (!result) {
		return NULL;
	}
	else {
		result->AddRef();
		return result.get();
	}
}

MY_DLL_EXPORT void MyCefFrame_GetUrl(CefFrame* frame, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{

	CefString str = frame->GetURL();
	int str_len = (int)str.length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, str.c_str());
}

MY_DLL_EXPORT void MyCefString_Read(CefString* cefStr, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	int str_len = (int)cefStr->length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, cefStr->c_str());
}

MY_DLL_EXPORT void MyCefStringHolder_Read(MyCefStringHolder* mycefStr, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	CefString* cefStr = &mycefStr->value;
	int str_len = (int)cefStr->length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, cefStr->c_str());
}
MY_DLL_EXPORT void MyCefJs_CefV8Value_ReadAsString(CefV8Value* target, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	CefString str = target->GetStringValue();
	int str_len = (int)str.length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, str.c_str());
}

MY_DLL_EXPORT void MyCefJs_MetReadArgAsString(const CefV8ValueList* jsArgs, int index, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	auto value = jsArgs->at(index);
	CefString cefStr = value->GetStringValue();
	*actualLength = (int32_t)cefStr.length();
	wcscpy_s(outputBuffer, outputBufferLen, cefStr.c_str());
}
MY_DLL_EXPORT int MyCefJs_MetReadArgAsInt32(const CefV8ValueList* jsArgs, int index) {
	auto value = jsArgs->at(index);
	return value->GetIntValue();
}
MY_DLL_EXPORT CefV8Value* MyCefJs_MetReadArgAsCefV8Value(const CefV8ValueList* jsArgs, int index) {
	auto value = jsArgs->at(index);
	value->AddRef();
	return value;
}
MY_DLL_EXPORT CefV8Handler* MyCefJs_MetReadArgAsV8FuncHandle(const CefV8ValueList* jsArgs, int index) {
	auto value = jsArgs->at(index);
	value->AddRef();
	return value->GetFunctionHandler();
}

//---------------------------------------
//part 6
//---------------------------------------
MY_DLL_EXPORT bool MyCefAddCrossOriginWhitelistEntry(
	const wchar_t*  sourceOrigin,
	const wchar_t*  targetProtocol,
	const wchar_t*  targetDomain,
	bool allow_target_subdomains
)
{
	return CefAddCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allow_target_subdomains);
}
MY_DLL_EXPORT bool MyCefRemoveCrossOriginWhitelistEntry(
	const wchar_t*  sourceOrigin,
	const wchar_t*  targetProtocol,
	const wchar_t*  targetDomain,
	bool allow_target_subdomains
)
{
	return CefAddCrossOriginWhitelistEntry(sourceOrigin, targetProtocol, targetDomain, allow_target_subdomains);
}
//---------------------------------------
