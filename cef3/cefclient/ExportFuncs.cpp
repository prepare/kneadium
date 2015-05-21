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

 
 
client::MainContextImpl* mainContext;  
client::MainMessageLoop* message_loop;  //essential for mainloop checking 

managed_callback myMxCallback_;

//1.
int MyCefGetVersion()
{	
	 return 1004;
}
//2.
int RegisterManagedCallBack(managed_callback mxCallback,int callbackKind)
{	
	switch(callbackKind)
	{
		case 0:
			{ 
				return 0;
			}break;
		case 1:
			{
			 
			}break;
		case 3:
			{   
				//set global mxCallback ***
				myMxCallback_ = mxCallback;
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
void MyCefClientAppSetManagedCallback(managed_callback myMxCallback)
{
	
}
//5.
int MyCefInit(HINSTANCE hInstance,client::ClientApp* app)
{
	CefRefPtr<client::ClientApp> myApp = app;   
	mainContext= DllInitMain(hInstance,myApp); 
	//set global mx callback to mainContext 
	mainContext->myMxCallback_ = myMxCallback_;
	return -1;
}  
//6, 
MyBrowser* MyCefCreateClientHandler()
{	
	/*const CefRect r(0,0,400,400); 
	CefBrowserSettings settings;
	client::MainContext::Get()->PopulateBrowserSettings(&settings);
    */
	/*auto rr1= mainContext->GetRootWindowManager()->CreateRootWindow(false,false,r,"");*/	
	 
    //create root window handler?
	auto myBw= new MyBrowser();
	auto rootWindow= new client::RootWindowWin();  
	myBw->rootWin = rootWindow;
	
	//1. create browser window handler
	//TODO: review here again, don't store at this module!
	auto bwWindow= new client::BrowserWindowStdWin(rootWindow,"");   
	myBw->bwWindow = bwWindow;


	//2. browser event handler
	auto hh = bwWindow->GetClientHandler();//  new client::ClientHandlerStd(bwWindow,"");
	hh->MyCefSetManagedCallBack(myMxCallback_); 

	return myBw;
}

//7.
int MyCefSetupBrowserHwnd(MyBrowser* myBw,HWND surfaceHwnd,int x,int y,int w,int h,const wchar_t* url)
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
  
  auto clientHandler = myBw->bwWindow->GetClientHandler(); 
  CefRefPtr<client::ClientHandler> handler(clientHandler);

  // Specify CEF browser settings here.
  CefBrowserSettings browser_settings;

  //std::string url;

  // Check if a "--url=" value was provided via the command-line. If so, use
  // that instead of the default URL.
  /*CefRefPtr<CefCommandLine> command_line =
      CefCommandLine::GetGlobalCommandLine();
  url = command_line->GetSwitchValue("url");
  if (url.empty())
    url = "https://cefbuilds.com";*/

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

//part 2:
//1. 
 void NativeMetSetResult(MethodArgs* args, int retIndex, jsvalue* value)
 {	 
	 switch(retIndex){
		 case 0:
			args->result0 = *(value);
			break;
		 case 1:
			 args->result1 = *(value);
			 break;
		 case 2:
			 args->result2 = *(value);
			 break;
		 case 3:
			 args->result3 = *(value);
			 break;
		 case 4:
			 args->result4 = *(value);
			 break;  

	 }
 }
 //2.
 jsvalue MyCefNativeMetGetArgs(MethodArgs* args,int argIndex) 
 {
	 switch(argIndex)
	 {
		case 0: return args->arg0;
		case 1: return args->arg1;
		case 2: return args->arg2;
		case 3: return args->arg3;
		case 4: return args->arg4;
		default: 
			{
				jsvalue v;
				v.type = JSVALUE_TYPE_EMPTY;
				v.length =0;
				return v;
			} 
	 } 
 }
 //3.
 void MyCefDisposePtr(void* ptr){
	 delete ptr;
 }


//---------------------------------------------------------------------------
//part3:

//1. 
void NavigateTo(MyBrowser* myBw, const wchar_t* url){
		 
	 myBw->bwWindow->GetBrowser()->GetMainFrame()->LoadURL(url); 
}
//2.
void ExecJavascript(MyBrowser* myBw, const wchar_t* jscode,const wchar_t* script_url){
	
	 myBw->bwWindow->GetBrowser()->GetMainFrame()->ExecuteJavaScript(jscode,script_url,0);
}
//3. 
void PostData(MyBrowser* myBw, const wchar_t* url,const wchar_t* rawDataToPost,size_t rawDataLength){
	
	//create request
	CefRefPtr<CefRequest> request(CefRequest::Create());
	request->SetURL(url);
	
	//Add post data to request, the correct method and content-type header willbe set by CEF

	CefRefPtr<CefPostDataElement> postDataElement(CefPostDataElement::Create());
	postDataElement->SetToBytes(rawDataLength,rawDataToPost);
	CefRefPtr<CefPostData> postData(CefPostData::Create());
	postData->AddElement(postDataElement);
	request->SetPostData(postData);

	//add custom header
	CefRequest::HeaderMap headerMap;
	headerMap.insert(
		std::make_pair("X-My-Header","My Header Value"));
	request->SetHeaderMap(headerMap);

	//load request
	 myBw->bwWindow->GetBrowser()->GetMainFrame()->LoadRequest(request); 

}
//4. 
void MyCefShowDevTools(MyBrowser* myBw, MyBrowser* myBwDev, HWND parentWindow)
{ 
  
	  //TODO : fine tune here

	  CefWindowInfo windowInfo;  
	  windowInfo.parent_window = parentWindow;
	  windowInfo.width = 800;
	  windowInfo.height = 600;
	  windowInfo.x  =0;
	  windowInfo.y  =0;

	  RECT r;
	  r.left =0;
	  r.top =0;
	  r.right = 800;
	  r.bottom = 600;

	  windowInfo.SetAsChild(parentWindow,r);

	  CefRefPtr<CefClient> client(myBwDev->bwWindow->GetClientHandler());
	  CefBrowserSettings settings;
	  CefPoint inspect_element_at;
   
	  myBw->bwWindow->GetBrowser()->GetHost()->ShowDevTools(
		  windowInfo,
		  client,
		  settings,
		  inspect_element_at);  
}
MY_DLL_EXPORT void MyCefBwGoBack(MyBrowser* myBw){
	
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()){
        browser->GoBack();
	}
}
MY_DLL_EXPORT void MyCefBwGoForward(MyBrowser* myBw){
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()){
        browser->GoForward();
	}
}
MY_DLL_EXPORT void MyCefBwStop(MyBrowser* myBw){
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()){
       browser->StopLoad();
	}
}
MY_DLL_EXPORT void MyCefBwReload(MyBrowser* myBw){
	if (CefRefPtr<CefBrowser> browser = myBw->bwWindow->GetBrowser()){
        browser->Reload();
	}
}
