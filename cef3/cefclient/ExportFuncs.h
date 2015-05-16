#include "dll_init.h"
#include "common/client_app.h" 
#include "browser/client_handler.h"
#include "browser/client_handler_std.h"

#define MY_DLL_EXPORT __declspec(dllexport)  
 

extern "C"{  	 
	 
	//part 1

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

	
	//--------------------
	//part 2
	
	//1.
	MY_DLL_EXPORT void NavigateTo(client::ClientHandler* clientHandler, const wchar_t* url);
	//2. 
	MY_DLL_EXPORT void ExecJavascript(client::ClientHandler* clientHandler, const wchar_t* jscode,const wchar_t* script_url);
	//3.
	MY_DLL_EXPORT void PostData(client::ClientHandler* clientHandler, const wchar_t* url,const wchar_t* rawDataToPost,size_t rawDataLength);



}