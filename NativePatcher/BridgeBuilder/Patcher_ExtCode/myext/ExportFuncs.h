//MIT, 2015-2017, WinterDev
 
#include "mycef.h" //mycef's jsvalue   

class MyBrowser; //forward decl

extern "C" {


	//part 1 
	//1.
	MY_DLL_EXPORT int MyCefGetVersion();
	//2.
	MY_DLL_EXPORT int RegisterManagedCallBack(managed_callback callback, int callBackKind);
	//3.  
	MY_DLL_EXPORT void* MyCefCreateClientApp(HINSTANCE hInstance);
	//3.1 
	MY_DLL_EXPORT void MyCefEnableKeyIntercept(MyBrowser* myBw, int enable);

	//4.
	MY_DLL_EXPORT MyBrowser* MyCefCreateMyWebBrowser(managed_callback callback);
	//4. OSR
	MY_DLL_EXPORT MyBrowser* MyCefCreateMyWebBrowserOSR(managed_callback callback);

	//5.
	MY_DLL_EXPORT int MyCefSetupBrowserHwnd(MyBrowser* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext);
	//5. OSR
	MY_DLL_EXPORT int MyCefSetupBrowserHwndOSR(MyBrowser* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext);
	//6
	MY_DLL_EXPORT void MyCefCloseMyWebBrowser(MyBrowser* myBw);
	//7.
	MY_DLL_EXPORT void MyCefDoMessageLoopWork();
	//8.
	MY_DLL_EXPORT void MyCefSetBrowserSize(MyBrowser* myBw, int w, int h);

	MY_DLL_EXPORT void MyCefShutDown();
	MY_DLL_EXPORT void MyCefDomGetTextWalk(MyBrowser* myBw, managed_callback strCallBack);
	MY_DLL_EXPORT void MyCefDomGetSourceWalk(MyBrowser* myBw, managed_callback strCallBack);
	//--------------------
	MY_DLL_EXPORT void MyCefSetInitSettings(CefSettings* cefSetting, int keyName, const wchar_t* value);




	//part3:
	//--------------------
	//1.
	MY_DLL_EXPORT void MyCefBwNavigateTo(MyBrowser* myBw, const wchar_t* url);
	//2. 
	MY_DLL_EXPORT void MyCefBwExecJavascript(MyBrowser* myBw, const wchar_t* jscode, const wchar_t* script_url);

	MY_DLL_EXPORT void MyCefBwExecJavascript2(CefBrowser* nativeWb, const wchar_t* jscode, const wchar_t* script_url);
	//3.
	MY_DLL_EXPORT void MyCefBwPostData(MyBrowser* myBw, const wchar_t* url, const wchar_t* rawDataToPost, size_t rawDataLength);
	//4. 
	MY_DLL_EXPORT void MyCefShowDevTools(MyBrowser* myBw, MyBrowser* myBwDev, HWND parentHwnd);
	//----------------------------
	MY_DLL_EXPORT void MyCefBwGoBack(MyBrowser* myBw);
	MY_DLL_EXPORT void MyCefBwGoForward(MyBrowser* myBw);
	MY_DLL_EXPORT void MyCefBwStop(MyBrowser* myBw);
	MY_DLL_EXPORT void MyCefBwReload(MyBrowser* myBw);
	MY_DLL_EXPORT void MyCefBwReloadIgnoreCache(MyBrowser* myBw);


	//----------------------------
	//part4: javascript context
	MY_DLL_EXPORT CefV8Context* MyCefJsGetCurrentContext();
	MY_DLL_EXPORT CefV8Context* MyCefJs_GetEnteredContext();
	MY_DLL_EXPORT void MyCefJsNotifyRenderer(managed_callback callback, MethodArgs* args);

	MY_DLL_EXPORT CefV8Context* MyCefJsFrameContext(CefFrame* wbFrame);

	MY_DLL_EXPORT CefV8Value* MyCefJsGetGlobal(CefV8Context* cefV8Context);

	 
	MY_DLL_EXPORT CefV8Context* MyCefJs_EnterContext(CefV8Context* cefV8Context);
	MY_DLL_EXPORT void MyCefJs_ExitContext(CefV8Context* cefV8Context);

	MY_DLL_EXPORT CefV8Handler* MyCefJs_New_V8Handler(managed_callback callback);
	MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByString(CefV8Value* target, const wchar_t* key, CefV8Value* value, int setAttribute);
	MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByIndex(CefV8Value* target, int index, CefV8Value* value);
	MY_DLL_EXPORT bool MyCefJs_CefV8Value_IsFunc(CefV8Value* target);
	MY_DLL_EXPORT bool MyCefJs_CefRegisterExtension(const wchar_t* extensionName, const wchar_t* extensionCode);

	MY_DLL_EXPORT CefV8Value* MyCefJs_CreateFunction(const wchar_t* name, CefV8Handler* handler);
	MY_DLL_EXPORT CefV8Value* MyCefJs_ExecJsFunctionWithContext(CefV8Value* cefJsFunc, CefV8Context* context, const wchar_t* argAsJsonString);


	MY_DLL_EXPORT void MyCefFrame_GetUrl(CefFrame* frame, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefString_Read(CefString* cefStr, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefJs_CefV8Value_ReadAsString(CefV8Value* target, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefStringHolder_Read(MyCefStringHolder* mycefstr, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);



	MY_DLL_EXPORT void MyCefJs_MetReadArgAsString(const CefV8ValueList* jsArgs, int index, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT int MyCefJs_MetReadArgAsInt32(const CefV8ValueList* jsArgs, int index);
	MY_DLL_EXPORT CefV8Value* MyCefJs_MetReadArgAsCefV8Value(const CefV8ValueList* jsArgs, int index);
	MY_DLL_EXPORT CefV8Handler* MyCefJs_MetReadArgAsV8FuncHandle(const CefV8ValueList* jsArgs, int index);

	MY_DLL_EXPORT MyCefStringHolder* MyCefCreateCefString(const wchar_t*  str);
	//------------------------------
	//part 5 : UI Proc Ext
	//----------------------------


	//part 6
	MY_DLL_EXPORT bool MyCefAddCrossOriginWhitelistEntry(
		const wchar_t*  sourceOrigin,
		const wchar_t*  targetProtocol,
		const wchar_t*  targetDomain,
		bool allow_target_subdomains
	);
	MY_DLL_EXPORT bool MyCefRemoveCrossOriginWhitelistEntry(
		const wchar_t*  sourceOrigin,
		const wchar_t*  targetProtocol,
		const wchar_t*  targetDomain,
		bool allow_target_subdomains
	);

}