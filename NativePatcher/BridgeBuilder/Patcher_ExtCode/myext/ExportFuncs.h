//MIT, 2015-2017, WinterDev

#include "mycef.h" //mycef's jsvalue   

class MyBrowser; //forward decl

extern "C" {


	//1. init
	MY_DLL_EXPORT int MyCefGetVersion();
	MY_DLL_EXPORT int RegisterManagedCallBack(managed_callback callback, int callBackKind);
	MY_DLL_EXPORT void* MyCefCreateClientApp(HINSTANCE hInstance);
	MY_DLL_EXPORT void MyCefSetInitSettings(CefSettings* cefSetting, int keyName, const wchar_t* value);
	MY_DLL_EXPORT void MyCefDoMessageLoopWork();
	MY_DLL_EXPORT void MyCefShutDown();
	//
	//2. debug
	MY_DLL_EXPORT void MyCefJsNotifyRenderer(managed_callback callback, MethodArgs* args);
	 

	//3. create/manipulate browser
	MY_DLL_EXPORT MyBrowser* MyCefCreateMyWebBrowser(managed_callback callback);
	MY_DLL_EXPORT MyBrowser* MyCefCreateMyWebBrowserOSR(managed_callback callback);
	MY_DLL_EXPORT int MyCefSetupBrowserHwnd(MyBrowser* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext);
	MY_DLL_EXPORT int MyCefSetupBrowserHwndOSR(MyBrowser* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext);
	  
	//--------------------
	MY_DLL_EXPORT void MyCefDomGetTextWalk(MyBrowser* myBw, managed_callback strCallBack);
	MY_DLL_EXPORT void MyCefDomGetSourceWalk(MyBrowser* myBw, managed_callback strCallBack);
	 
	 
	MY_DLL_EXPORT void MyCefShowDevTools(MyBrowser* myBw, MyBrowser* myBwDev, HWND parentHwnd);
	//----------------------------
 
	//----------------------------
	MY_DLL_EXPORT void MyCefDeletePtr(void* ptr);
	MY_DLL_EXPORT void MyCefDeletePtrArray(jsvalue* ptr);
	 

	//----------------------------
	MY_DLL_EXPORT CefFrame* MyCefBwGetMainFrame(MyBrowser* myBw);
	MY_DLL_EXPORT void MyCefFrame_GetUrl(CefFrame* frame, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefFrameGetSource(CefFrame* cefFrame, managed_callback strCallBack);
	
	//----------------------------
	MY_DLL_EXPORT CefPdfPrintSettings* MyCefCreatePdfPrintSetting(wchar_t* pdfjsonConfig);
	//----------------------------
	MY_DLL_EXPORT void MyCefPrintToPdf(MyBrowser* myBw, CefPdfPrintSettings* setting,wchar_t* filename,managed_callback callback);
	//----------------------------
	
	
	
	//----------------------------
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

	 
	MY_DLL_EXPORT void MyCefBwCall2(MyBrowser* myBw, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2);

}