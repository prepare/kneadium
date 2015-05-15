#include "ExportFuncs.h"   
#include "mycef.h"
 
 

delTraceBack notifyListener= NULL;

//1.
int MyCefGetVersion()
{	
	 return 2357;
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
SimpleApp* MyCefCreateClientApp(){
	auto app = new SimpleApp();
	app->extmode = true;
	return app;	 
}
//4. 
int MyCefInit(HINSTANCE hInstance,SimpleApp* app1)
{

	void* sandbox_info = NULL;

#if defined(CEF_USE_SANDBOX)
  // Manage the life span of the sandbox information object. This is necessary
  // for sandbox support on Windows. See cef_sandbox_win.h for complete details.
  CefScopedSandboxInfo scoped_sandbox;
  sandbox_info = scoped_sandbox.sandbox_info();
#endif
     // Provide CEF with command-line arguments.
  CefMainArgs main_args(hInstance); 

  // CEF applications have multiple sub-processes (render, plugin, GPU, etc)
  // that share the same executable. This function checks the command-line and,
  // if this is a sub-process, executes the appropriate logic.

  CefRefPtr<SimpleApp> app(app1);

  int exit_code = CefExecuteProcess(main_args, app.get(), sandbox_info);
  if (exit_code >= 0) {
    // The sub-process has completed so return here.
    return exit_code;
  }

  // Specify CEF global settings here.
  CefSettings settings;

#if !defined(CEF_USE_SANDBOX)
  settings.no_sandbox = true;
#endif

  // Initialize CEF.
  CefInitialize(main_args, settings,  app.get(), sandbox_info); 
  return -1;
}
//5.
void MyCefClientAppSetManagedCallback(SimpleApp* clientApp,managed_callback myMxCallback)
{
	clientApp->myMxCallback = myMxCallback;
}
	
//6.
SimpleHandler* MyCefCreateClientHandler()
{
	return new SimpleHandler();
} 
//7.
int MyCefSetupBrowserHwnd(SimpleHandler* clientHandler,HWND surfaceHwnd,int x,int y,int w,int h)
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
  CefRefPtr<SimpleHandler> handler(clientHandler);

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
  bool result= CefBrowserHost::CreateBrowser(window_info, handler.get(), url,
                                browser_settings, NULL);
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
void MyCefShutDown()
{
	CefShutdown();
}
 