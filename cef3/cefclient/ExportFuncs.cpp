#include "ExportFuncs.h"   
#include "mycef.h"
//static 

#include "include/base/cef_scoped_ptr.h"
#include "include/cef_command_line.h"
#include "include/cef_sandbox_win.h"
#include "cefclient/browser/client_app_browser.h"
#include "cefclient/browser/main_context_impl.h"
#include "cefclient/browser/main_message_loop_multithreaded_win.h"
#include "cefclient/browser/main_message_loop_std.h"
#include "cefclient/browser/root_window_win.h"
#include "cefclient/browser/root_window_manager.h"
#include "cefclient/browser/test_runner.h"
#include "cefclient/common/client_app_other.h"
#include "cefclient/renderer/client_app_renderer.h" 
#include "cefclient/browser/browser_window.h"
#include "cefclient/browser/browser_window_std_win.h"
#include "cefclient/browser/main_context.h" 

 
delTraceBack notifyListener= NULL;
client::MainContextImpl* mainContext;  
client::MainMessageLoop* message_loop;
client::RootWindowWin* rootWindow;
client::BrowserWindowStdWin* bwWindow;

managed_callback myMxCallback_;

//1.
int MyCefGetVersion()
{	
	 return 1004;
}
//2.
int RegisterManagedCallBack(void* funcPtr,int callbackKind)
{	
	switch(callbackKind)
	{
		case 0:
			{
				notifyListener= (delTraceBack)funcPtr;		    
				return 0;
			}break;
		case 1:
			{
			 
			}break;
		case 3:
			{   
				return 0;
			}break;
	} 
	return 1;
}
//3.
client::ClientApp* MyCefCreateClientApp()
{	
	// Parse command-line arguments.
   CefRefPtr<CefCommandLine> command_line = CefCommandLine::CreateCommandLine();
   command_line->InitFromString(::GetCommandLineW());
	//create browser process first?
   client::ClientApp* app= NULL;
   client::ClientApp::ProcessType process_type = client::ClientApp::GetProcessType(command_line);
   if (process_type == client::ClientApp::BrowserProcess)
     app = new client::ClientAppBrowser();
   else if (process_type == client::ClientApp::RendererProcess)
     app = new client::ClientAppRenderer();
   else if (process_type == client::ClientApp::OtherProcess)
     app = new client::ClientAppOther();

    // Create the main message loop object.
  message_loop = new client::MainMessageLoopStd();
  //message_loop.reset(new client::MainMessageLoopStd); 
 /* if (settings.multi_threaded_message_loop)
    message_loop.reset(new MainMessageLoopMultithreadedWin);
  else
    message_loop.reset(new MainMessageLoopStd);*/
   return app;
}
//4. 
void MyCefClientAppSetManagedCallback(client::ClientApp* clientApp,managed_callback myMxCallback)
{
	myMxCallback_ = myMxCallback;
}
//5.
int MyCefInit(HINSTANCE hInstance,client::ClientApp* app)
{
	CefRefPtr<client::ClientApp> myApp = app;   
	mainContext= DllInitMain(hInstance,myApp); 
	return -1;
}  
//6, 
client::ClientHandler* MyCefCreateClientHandler()
{	
	/*const CefRect r(0,0,400,400); 
	CefBrowserSettings settings;
	client::MainContext::Get()->PopulateBrowserSettings(&settings);
    */
	/*auto rr1= mainContext->GetRootWindowManager()->CreateRootWindow(false,false,r,"");*/	
	if(!rootWindow){
		//create root window handler?
		rootWindow= new client::RootWindowWin(); 
	} 

	//1. create browser window handler
	//TODO: review here again, don't store at this module!
	bwWindow= new client::BrowserWindowStdWin(rootWindow,"");   
	
	//2. browser event handler
	auto hh = new client::ClientHandlerStd(bwWindow,"");
	hh->MyCefSetManagedCallBack(myMxCallback_); 

	return hh;  
}

//7.
int MyCefSetupBrowserHwnd(client::ClientHandler* clientHandler,HWND surfaceHwnd,int x,int y,int w,int h)
{   

  // Information used when creating the native window.
  CefWindowInfo window_info; 
//#if defined(OS_WIN)
//  // On Windows we need to specify certain flags that will be passed to
//  // CreateWindowEx().
//  window_info.SetAsPopup(NULL, "cefsimple");
//  
//#endif

  RECT r;
  r.left = x;
  r.top = y;
  r.right = x+w;
  r.bottom  = y +h;

  window_info.SetAsChild(surfaceHwnd,r);
  //window_info.SetAsWindowless(surfaceHwnd,true);

  // SimpleHandler implements browser-level callbacks.
  CefRefPtr<client::ClientHandler> handler(clientHandler);

  // Specify CEF browser settings here.
  CefBrowserSettings browser_settings;

  std::string url;

  // Check if a "--url=" value was provided via the command-line. If so, use
  // that instead of the default URL.
  CefRefPtr<CefCommandLine> command_line =
      CefCommandLine::GetGlobalCommandLine();
  url = command_line->GetSwitchValue("url");
  if (url.empty())
    url = "http://www.google.com";

  // Create the first browser window.
  //bool result= CefBrowserHost::CreateBrowser(window_info, handler.get(), url,                                browser_settings, NULL);
  bool result= CefBrowserHost::CreateBrowser(window_info, clientHandler, url,  browser_settings, NULL);
  if(result){
	  return 1;
  }
  else{
	  return 0;
  }  
}
//8.
void MyCefDoMessageLoopWork()
{		
	CefDoMessageLoopWork();
}
//9.
void MyCefShutDown(){
	CefShutdown();
}

//---------------------------------------------------------------------------
//part2:

void NavigateTo(client::ClientHandler* clientHandler, const wchar_t* url){

	CefString url2(url); 
	bwWindow->GetBrowser()->GetMainFrame()->LoadURL(url2);

}