#include "cefsimple/simple_app.h" 
#include "cefsimple/simple_handler.h"
#include "include/cef_sandbox_win.h"

#define MY_DLL_EXPORT __declspec(dllexport)   

extern "C"{  	 
	//1.
	MY_DLL_EXPORT int MyCefGetVersion(); 
	//2.
	MY_DLL_EXPORT int RegisterManagedCallBack(void* callback,int callBackKind);  
	//3.
    MY_DLL_EXPORT SimpleApp* MyCefCreateClientApp();
	//4.
    MY_DLL_EXPORT int MyCefInit(HINSTANCE hInstance,SimpleApp* app1);
	//5.
	MY_DLL_EXPORT void MyCefClientAppSetManagedCallback(SimpleApp* clientApp,managed_callback myMxCallback);
	//6.
	MY_DLL_EXPORT SimpleHandler* MyCefCreateClientHandler();
	//7.
	MY_DLL_EXPORT int MyCefSetupWindowsBegin(SimpleHandler* clientHandler,HWND surfaceHwnd);
	//8.
	MY_DLL_EXPORT int MyCefSetupWindowsEnd(SimpleHandler* clientHandler,HWND surfaceHwnd,int x,int y,int w,int h);
	//9.
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 
	 
	//10.
	MY_DLL_EXPORT void MyCefShutDown();
	  
 
}