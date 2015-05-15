<<<<<<< HEAD

#include "cefclient/cefclient.h"
#include <windows.h>
#include <commdlg.h>
#include <shellapi.h>
#include <direct.h>
#include <sstream>
#include <string>
#include "include/cef_app.h"
#include "include/cef_browser.h"
#include "include/cef_frame.h"
#include "include/cef_runnable.h"
#include "cefclient/cefclient_osr_widget_win.h"
#include "cefclient/client_handler.h"
#include "cefclient/client_switches.h"
#include "cefclient/resource.h"
#include "cefclient/scheme_test.h"
#include "CommonModule.h"

#define MY_DLL_EXPORT __declspec(dllexport)  

extern "C"{ 

	MY_DLL_EXPORT int RegisterManagedCallBack(void* callback,int callBackKind);    
	//---------------------------------------------------------------------
	MY_DLL_EXPORT int MyCefGetVersion();
	//---------------------------------------------------------------------

	MY_DLL_EXPORT
    ClientApp* MyCefCreateClientApp();

	MY_DLL_EXPORT
	void MyCefClientAppSetManagedCallback(ClientApp* clientApp,managed_callback myMxCallback);
	
	//---------------------------------------------------------------------
	MY_DLL_EXPORT int MyCefInit(HINSTANCE hInstance,ClientApp* app);
	MY_DLL_EXPORT int MyCefShutDown();

	//create new client handler for window
	MY_DLL_EXPORT ClientHandler* MyCefCreateClientHandler();
	MY_DLL_EXPORT void MyCefSetupWindowsBegin(ClientHandler* cefClientHandler, HWND parentWindow);
	MY_DLL_EXPORT void MyCefSetupWindowsEnd(ClientHandler* cefClientHandler,HWND hWndParent,int x,int y,int width,int height);
	MY_DLL_EXPORT void MyCefCloseHandler(ClientHandler* cefClientHandler);
	
	MY_DLL_EXPORT bool MyCefUseMultiMessageLoop();
	//---------------------------------------------------------------------
	MY_DLL_EXPORT void MyCefRunMessageLoop();
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 
	MY_DLL_EXPORT void MyCefQuitMessageLoop();  
	//---------------------------------------------------------------------
	



	//---------------------------------------------------------------------
	//for client handler 
	MY_DLL_EXPORT 
	void NavigateTo(ClientHandler* g_ClientHandler, const wchar_t* url);
	
	MY_DLL_EXPORT 
	void ExecJavascript(ClientHandler* g_ClientHandler, 
		const wchar_t* jssource,
		const wchar_t* scripturl);

	MY_DLL_EXPORT 
	void PostData(ClientHandler* g_ClientHandler, 
		const wchar_t* jssource,
		void* rawDataToPost,
		size_t rawDataLength);

	MY_DLL_EXPORT 
	void DomGetTextWalk(ClientHandler* g_ClientHandler,delTextWalk strCallBack);
	
	MY_DLL_EXPORT 
	void DomGetSourceWalk(ClientHandler* g_ClientHandler,delTextWalk strCallBack);

	MY_DLL_EXPORT 
	void AgentRegisterManagedCallback(ClientHandler* g_ClientHandler,managed_callback callback);
	//--------------------------------------------------------------------- 

	
	MY_DLL_EXPORT 
    jsvalue MyCefCbArgs_GetArg(MethodArgs* args,int argIndex);
	MY_DLL_EXPORT 
    int MyCefCbArgs_ArgCount(MethodArgs* args);

	MY_DLL_EXPORT 
	void MyCefCbArgs_SetResultAsBuffer(MethodArgs* args,int resultIndex, const void* outputBuffer,int len);
 
	 
	//--------------------------------------------------------------------- 
	//scheme and request
	MY_DLL_EXPORT 
	void MyCef_CefRegisterSchemeHandlerFactory(
			const wchar_t* schemeName,
			const wchar_t* startURL,
			CefSchemeHandlerFactory* clientSchemeHandlerFactoryObject);

	MY_DLL_EXPORT 
    CefSchemeHandlerFactory* MyCef_CreateSchemeHandlerFactory();
 
}


void ManagedNotify(int id,const wchar_t* info);   
bool HasManagedNotify(); 

//---------------------------------------------------------------------
#define MYCEF_BROWSER_URL_CHANGED  1000
#define MYCEF_BROWSER_TITLE_CHANGED  1001
#define MYCEF_BROWSER_SEND_NOTIFICATION  1002
#define MYCEF_FILTER_URL_FOR_RESOURCE  1003
//---------------------------------------------------------------------
//
=======
#include "dll_init.h"
#include "common/client_app.h" 
#include "browser/client_handler.h"
#include "browser/client_handler_std.h"

#define MY_DLL_EXPORT __declspec(dllexport)  
 

extern "C"{  	 
	 

	//1.
	MY_DLL_EXPORT int MyCefGetVersion(); 
	//2.
	MY_DLL_EXPORT int RegisterManagedCallBack(void* callback,int callBackKind); 
	//3. 
	MY_DLL_EXPORT client::ClientApp* MyCefCreateClientApp();	
	//4.
	MY_DLL_EXPORT int MyCefInit(HINSTANCE hInstance,client::ClientApp* app);
	//5.
	MY_DLL_EXPORT void MyCefClientAppSetManagedCallback(client::ClientApp* clientApp,managed_callback myMxCallback);
	
	
	//6.
	MY_DLL_EXPORT client::ClientHandler* MyCefCreateClientHandler();
	//7.
	MY_DLL_EXPORT int MyCefSetupBrowserHwnd(client::ClientHandler* clientHandler,HWND surfaceHwnd,int x,int y,int w,int h);

	//8.
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 
	 
	//9.
	MY_DLL_EXPORT void MyCefShutDown();  
 
}
>>>>>>> origin/mod1
