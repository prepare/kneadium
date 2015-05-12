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
#include "cefclient/browser/root_window_manager.h"
#include "cefclient/browser/test_runner.h"
#include "cefclient/common/client_app_other.h"
#include "cefclient/renderer/client_app_renderer.h"

delTraceBack notifyListener= NULL;

//1.
int MyCefGetVersion()
{	
	 return 1003;
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
   return app;
}

int MyCefInit(HINSTANCE hInstance,client::ClientApp* app)
{
	CefRefPtr<client::ClientApp> myApp = app;   
	return DllInitMain(hInstance,myApp);
} 