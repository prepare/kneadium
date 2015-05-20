#include "dll_init.h"
#include "common/client_app.h" 
#include "browser/client_handler.h"
#include "browser/client_handler_std.h"
#include "browser/root_window_win.h"

#define MY_DLL_EXPORT __declspec(dllexport)  
 

extern "C"{  	 
	 

	class MyBrowser
	{
	public:
		    client::RootWindowWin* rootWin;
		    client::BrowserWindow* bwWindow; 
	};


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
	MY_DLL_EXPORT MyBrowser* MyCefCreateClientHandler();
	//7.
	MY_DLL_EXPORT int MyCefSetupBrowserHwnd(MyBrowser* myBw,HWND surfaceHwnd,int x,int y,int w,int h,const wchar_t* url);

	//8.
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 
	 
	//9.
	MY_DLL_EXPORT void MyCefShutDown();  

	
	//--------------------
	//part 2
	//1.
	MY_DLL_EXPORT  void NativeMetSetResult(MethodArgs* args, int retIndex, jsvalue* value);
	//2.
	MY_DLL_EXPORT jsvalue MyCefNativeMetGetArgs(MethodArgs* args,int argIndex);
	//3.
	MY_DLL_EXPORT void MyCefDisposePtr(void* ptr);


	//part3:
	//--------------------
	//1.
	MY_DLL_EXPORT void NavigateTo(MyBrowser* myBw, const wchar_t* url);
	//2. 
	MY_DLL_EXPORT void ExecJavascript(MyBrowser* myBw, const wchar_t* jscode,const wchar_t* script_url);
	//3.
	MY_DLL_EXPORT void PostData(MyBrowser* myBw, const wchar_t* url,const wchar_t* rawDataToPost,size_t rawDataLength);

	//----------------------------
	

}