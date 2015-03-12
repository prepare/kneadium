#include "CommonModule.h"

#define MAX_LOADSTRING 100
char szWorkingDir[MAX_PATH];  // The current working directory
TCHAR szOSRWindowClass[MAX_LOADSTRING]; 
bool _isMultiMessageLoopApp;
HINSTANCE hInst;   // current instance
std::string MyAppGetWorkingDirectory() 
{
  return szWorkingDir;
}
std::string AppGetWorkingDirectory() {
    return MyAppGetWorkingDirectory();   
}

void MyCefInitWorkingDir()
{
	if (_getcwd(szWorkingDir, MAX_PATH) == NULL){
		szWorkingDir[0] = 0;
	}
}
int MyAppInit01(HINSTANCE hInstance)
{	
	
	//---------------------
   CefMainArgs main_args(hInstance);
   CefRefPtr<ClientApp> app(new ClientApp);

   //Execute the secondary process, if any.
   int exit_code = CefExecuteProcess(main_args, app.get());
   if (exit_code >= 0){
	 return exit_code;
   }

   //---------------------
   MyCefInitWorkingDir();
	//Parse command line arguments. The passed in values are ignored on Windows.
   AppInitCommandLine(0, NULL);

   CefSettings settings; 
	//Populate the settings based on command line arguments.
   AppGetSettings(settings);

	// Initialize CEF.
   CefInitialize(main_args, settings, app.get());

   _isMultiMessageLoopApp= settings.multi_threaded_message_loop;

   hInst = hInstance;  // Store instance handle in our global variable	 

   return -1;
}
bool IsMultiMessageLoopApp()
{
	return _isMultiMessageLoopApp;
} 
