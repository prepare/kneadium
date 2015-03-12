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

	typedef void (*del02)(int oIndex,const wchar_t* methodName);
	typedef const wchar_t* (*del03)(int oIndex,const wchar_t* methodName);
	  
	MY_DLL_EXPORT int RegisterManagedCallBack(void* callback,int callBackKind);    
	//---------------------------------------------------------------------
	MY_DLL_EXPORT int MyCefGetVersion();
	MY_DLL_EXPORT int MyCefInit(HINSTANCE hInstance);
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
	//easy ...
	MY_DLL_EXPORT 
	void NavigateTo(ClientHandler* g_ClientHandler, const wchar_t* url);
	
	MY_DLL_EXPORT 
	void ExecJavascript(ClientHandler* g_ClientHandler, 
		const wchar_t* jssource,
		const wchar_t* scripturl);

	MY_DLL_EXPORT 
	void PostData(ClientHandler* g_ClientHandler, 
		const wchar_t* jssource,
		void* rawDataToPost,size_t rawDataLength);
	//--------------------------------------------------------------------- 
}


void ManagedCallBack(int id,const wchar_t* info); 
const wchar_t* ManagedCallBack3(int id,const wchar_t* info);
bool HasManagedCallBack(); 
//---------------------------------------------------------------------
#define MYCEF_BROWSER_URL_CHANGED  1000
#define MYCEF_BROWSER_TITLE_CHANGED  1001
#define MYCEF_BROWSER_SEND_NOTIFICATION  1002
#define MYCEF_FILTER_URL_FOR_RESOURCE  1003
//---------------------------------------------------------------------