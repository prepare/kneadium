//MIT, 2015-2017, WinterDev
#define WRAPPING_CEF_SHARED 1
#include "mycef.h" //mycef's jsvalue   
#include "libcef_dll/ctocpp/frame_ctocpp.h"
#include "libcef_dll/cpptoc/string_visitor_cpptoc.h"

class MyBrowserWindowWrapper; //forward decl

extern "C" {

	//these funcs for C# calling to Native
	//1. check version
	MY_DLL_EXPORT int MyCefGetVersion();
	//2. register global  managed_callback (.net-side event listener/ event handler)
	MY_DLL_EXPORT int RegisterManagedCallBack(managed_callback callback, int callBackKind);
	//3.1 create process-based client app. 1 process => 1 client app
	MY_DLL_EXPORT void* MyCefCreateClientApp(HINSTANCE hInstance);
	//3.2
	MY_DLL_EXPORT void MyCefSetInitSettings(CefSettings* cefSetting, int keyName, const wchar_t* value);
	 
	MY_DLL_EXPORT void MyCefShutDown();

	//
	//for debug
	MY_DLL_EXPORT void MyCefJsNotifyRenderer(managed_callback callback, MyMetArgsN* args);


	//3. create/manipulate browser
	MY_DLL_EXPORT MyBrowserWindowWrapper* MyCefCreateMyWebBrowser(managed_callback callback);
	MY_DLL_EXPORT MyBrowserWindowWrapper* MyCefCreateMyWebBrowserOSR(managed_callback callback);
	MY_DLL_EXPORT int MyCefSetupBrowserHwnd(MyBrowserWindowWrapper* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext);
	MY_DLL_EXPORT int MyCefSetupBrowserHwndOSR(MyBrowserWindowWrapper* myBw, HWND surfaceHwnd, int x, int y, int w, int h, const wchar_t* url, CefRequestContext* cefRefContext);
	MY_DLL_EXPORT void MyCefDoMessageLoopWork();
	 

	MY_DLL_EXPORT void MyCefShowDevTools(MyBrowserWindowWrapper* myBw, MyBrowserWindowWrapper* myBwDev, HWND parentHwnd);
	//----------------------------


	MY_DLL_EXPORT void MyCefDeletePtr(void* ptr);
	MY_DLL_EXPORT void MyCefDeletePtrArray(jsvalue* ptr);



	MY_DLL_EXPORT CefPdfPrintSettings* MyCefCreatePdfPrintSetting(wchar_t* pdfjsonConfig);
	//----------------------------
	MY_DLL_EXPORT void MyCefPrintToPdf(MyBrowserWindowWrapper* myBw, CefPdfPrintSettings* setting, wchar_t* filename, managed_callback callback);
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
	 

	//
	MY_DLL_EXPORT void MyCefBwCall2(MyBrowserWindowWrapper* myBw, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2);
	
	 
	MY_DLL_EXPORT void* CreateStdList(int elemType);

	MY_DLL_EXPORT void GetListCount(int elemType, void* list, int32_t* size);

	MY_DLL_EXPORT void GetListElement(int elemType, void* list, int index, jsvalue* jsvalue);

}

