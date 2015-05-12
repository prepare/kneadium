#include "dll_init.h"
#include "common/client_app.h"
#define MY_DLL_EXPORT __declspec(dllexport)  
 

extern "C"{  	 

	MY_DLL_EXPORT int MyCefGetVersion(); 
	MY_DLL_EXPORT int RegisterManagedCallBack(void* callback,int callBackKind); 
	MY_DLL_EXPORT client::ClientApp* MyCefCreateClientApp();
	MY_DLL_EXPORT client::MainContextImpl* MyCefInit(HINSTANCE hInstance,client::ClientApp* app);
	MY_DLL_EXPORT void MyCefClientAppSetManagedCallback(client::ClientApp* clientApp,managed_callback myMxCallback);
	MY_DLL_EXPORT void MyCefDoMessageLoopWork();
}