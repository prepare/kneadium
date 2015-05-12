#include "dll_init.h"
#include "common/client_app.h" 
#include "browser/client_handler.h"
#include "browser/client_handler_std.h"

#define MY_DLL_EXPORT __declspec(dllexport)  
 

extern "C"{  	 

	MY_DLL_EXPORT int MyCefGetVersion(); 
	MY_DLL_EXPORT int RegisterManagedCallBack(void* callback,int callBackKind); 
	MY_DLL_EXPORT client::ClientApp* MyCefCreateClientApp();
	MY_DLL_EXPORT client::MainContextImpl* MyCefInit(HINSTANCE hInstance,client::ClientApp* app);
	MY_DLL_EXPORT void MyCefClientAppSetManagedCallback(client::ClientApp* clientApp,managed_callback myMxCallback);
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 

	MY_DLL_EXPORT client::ClientHandler* MyCefCreateClientHandler(client::MainContextImpl* mainContext,
			HWND parentWindowHandler,
            int x, int y, int w, int h);
 
}