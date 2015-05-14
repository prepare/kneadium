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
	MY_DLL_EXPORT int MyCefSetupWindowsBegin(client::ClientHandler* clientHandler,HWND surfaceHwnd);
	//8.
	MY_DLL_EXPORT int MyCefSetupWindowsEnd(client::ClientHandler* clientHandler,HWND surfaceHwnd,int x,int y,int w,int h);
	
	//9.
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 
	 
	//10.
	MY_DLL_EXPORT void MyCefShutDown(); 
	
 
}