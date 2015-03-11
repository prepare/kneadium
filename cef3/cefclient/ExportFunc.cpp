#include "CommonModule.h"
#include "ExportFuncs.h"  
//--------------------------------
using namespace std;  
//--------------------------------
//static
del02 managedListner;
del03 managedListner3;

int MyCefGetVersion()
{	
	 return 31;
}
//-----------------------------------------------------------
int RegisterManagedCallBack(void* funcPtr,int callbackKind)
{	
	switch(callbackKind)
	{
		case 0:
			{
				managedListner= (del02)funcPtr;		    
				return 0;
			}break;
		case 1:
			{
			 
			}break;
		case 3:
			{
				managedListner3= (del03)funcPtr;		    
				return 0;
			}break;
	} 
	return 1;
}
//-----------------------------------------------------------
void ManagedCallBack(int id,const wchar_t* info)
{
	 if(managedListner)
	 {
		 managedListner(id,info);
	 } 
}

const wchar_t* ManagedCallBack3(int id,const wchar_t* info)
{
	 if(managedListner3)
	 {
		return managedListner3(id,info);
	 } 
	 return NULL;
}
bool HasManagedCallBack()
{
	if(managedListner)
	{
		return true;
	}
	else
	{
		return false;
	}
}
void* MyCefCreateClientHandler()
{
	return new ClientHandler();
}
	
void MyCefRunMessageLoop()
{
	 CefRunMessageLoop();
}
int MyCefShutDown()
{
	CefShutdown();
	return 0;
} 
bool MyCefUseMultiMessageLoop()
{
	return IsMultiMessageLoopApp();
}
void MyCefCloseHandle()
{
	 CefShutdown();
}
int MyCefInit(HINSTANCE hInstance)//,CefSettings* settings)
{	 
	return MyAppInit01(hInstance);  
}

 void MyCefDoMessageLoopWork()
 {		
	CefDoMessageLoopWork();
	//MSG msg;
	//int j = 10;
	// 
	//while(PeekMessage(&msg, NULL, 0, 0,PM_REMOVE)){
	//	   //if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg)) {
	//	TranslateMessage(&msg);
	//	DispatchMessage(&msg); 
	//	CefDoMessageLoopWork();
	//}
 }  

void NavigateTo(void* g_ClientHandler, const wchar_t* url)
{
	 // When the user hits the enter key load the URL
    
	/*wchar_t* newcopy = new wchar_t[wcslen( L"http://localhost/testme/index.php")];
	wcscpy(newcopy,url);

	std::wstring newcopy2 = std::wstring(newcopy);  */ 
	CefRefPtr<ClientHandler> g_handler_= (ClientHandler*)g_ClientHandler;
	CefRefPtr<CefBrowser> browser = g_handler_->GetBrowser(); 
	browser->GetMainFrame()->LoadURL(CefString(url));
	
   /*  CefRefPtr<CefBrowser> browser = g_handler->GetBrowser();
     wchar_t strPtr[MAX_URL_LENGTH+1] = {0};
      *((LPWORD)strPtr) = MAX_URL_LENGTH;
        LRESULT strLen = SendMessage(hWnd, EM_GETLINE, 0, (LPARAM)strPtr);
        if (strLen > 0) {
          strPtr[strLen] = 0;
          browser->GetMainFrame()->LoadURL(strPtr);
        }*/  
}
