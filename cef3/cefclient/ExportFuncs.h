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
	MY_DLL_EXPORT int RegisterManagedCallBack(managed_callback callback,int callBackKind); 
	//3. 
	MY_DLL_EXPORT client::ClientApp* MyCefCreateClientApp(HINSTANCE hInstance);	
	 
	
	//4.
	MY_DLL_EXPORT MyBrowser* MyCefCreateMyWebBrowser();
	//5.
	MY_DLL_EXPORT int MyCefSetupBrowserHwnd(MyBrowser* myBw,HWND surfaceHwnd,int x,int y,int w,int h,const wchar_t* url);

	//6.
	MY_DLL_EXPORT void MyCefDoMessageLoopWork(); 
	 
	//7.
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
	MY_DLL_EXPORT void MyCefBwNavigateTo(MyBrowser* myBw, const wchar_t* url);
	//2. 
	MY_DLL_EXPORT void MyCefBwExecJavascript(MyBrowser* myBw, const wchar_t* jscode,const wchar_t* script_url);
	//3.
	MY_DLL_EXPORT void MyCefBwPostData(MyBrowser* myBw, const wchar_t* url,const wchar_t* rawDataToPost,size_t rawDataLength);
	//4. 
	MY_DLL_EXPORT void MyCefShowDevTools(MyBrowser* myBw,MyBrowser* myBwDev,HWND parentHwnd);
	//----------------------------
	MY_DLL_EXPORT void MyCefBwGoBack(MyBrowser* myBw);	 
	MY_DLL_EXPORT void MyCefBwGoForward(MyBrowser* myBw);	 
    MY_DLL_EXPORT void MyCefBwStop(MyBrowser* myBw);
	MY_DLL_EXPORT void MyCefBwReload(MyBrowser* myBw); 


}