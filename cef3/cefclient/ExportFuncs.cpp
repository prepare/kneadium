<<<<<<< HEAD
#include "CommonModule.h"
#include "ExportFuncs.h"  
//--------------------------------
using namespace std;  
//--------------------------------
//static
delTraceBack notifyListener= NULL;

int MyCefGetVersion()
{	
	 return 1001;
}
//-----------------------------------------------------------
=======
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
>>>>>>> origin/3.2357.1267
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
<<<<<<< HEAD
//-----------------------------------------------------------
void ManagedNotify(int id,const wchar_t* info)
{
	 if(notifyListener)
	 {
		notifyListener(id,info);
	 } 
}
 
bool HasManagedNotify()
{
	if(notifyListener)
	{
		return true;
	}
	else
	{
		return false;
	}
} 
ClientApp* MyCefCreateClientApp()
{
	return new ClientApp();
}
void MyCefClientAppSetManagedCallback(ClientApp* clientApp,managed_callback myMxCallback)
{
	clientApp->myMxCallback = myMxCallback;
}
ClientHandler* MyCefCreateClientHandler()
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
 
int MyCefInit(HINSTANCE hInstance,ClientApp* app)//,CefSettings* settings)
{	  
	CefRefPtr<ClientApp> myApp = app;
	return MyAppInit01(hInstance,myApp);  
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
 void MyCefQuitMessageLoop()
{
	CefQuitMessageLoop();

}

//-----
//easy ...
void NavigateTo(ClientHandler* g_ClientHandler, const wchar_t* url)
{    
	auto browser = g_ClientHandler->GetBrowser(); 
	browser->GetMainFrame()->LoadURL(CefString(url)); 
}
void ExecJavascript(ClientHandler* g_ClientHandler, 
	const wchar_t* jssource,
	const wchar_t* scripturl)
{
	auto browser = g_ClientHandler->GetBrowser(); 
	browser->GetMainFrame()->ExecuteJavaScript(CefString(jssource),
		CefString(scripturl),0);
} 
void PostData(ClientHandler* g_ClientHandler, 
	const wchar_t* url,
	void* rawDataToPost,
	size_t rawDataLength)
{

	 // Create a new request
  CefRefPtr<CefRequest> request(CefRequest::Create());
  
  //Set the request URL
  //eg. request->SetURL("http://tests/request");
  request->SetURL(url);

  // Add post data to the request.  The correct method and content-
  // type headers will be set by CEF.
  
  CefRefPtr<CefPostDataElement> postDataElement(CefPostDataElement::Create());   
  
  //eg.  
  /*std::string data = "arg1=val1&arg2=val2";
  postDataElement->SetToBytes(data.length(), data.c_str());*/

  postDataElement->SetToBytes(rawDataLength,rawDataToPost);
  CefRefPtr<CefPostData> postData(CefPostData::Create());
  postData->AddElement(postDataElement);
  request->SetPostData(postData);

  // Add a custom header
  CefRequest::HeaderMap headerMap;
  headerMap.insert(
      std::make_pair("X-My-Header", "My Header Value"));
  request->SetHeaderMap(headerMap);

  // Load the request
  auto browser = g_ClientHandler->GetBrowser(); 
  browser->GetMainFrame()->LoadRequest(request); 
}
 


class MyCefStringVisitor : public CefStringVisitor {
   public:
    explicit MyCefStringVisitor(CefRefPtr<CefBrowser> browser, delTextWalk strCallBack) : 
			browser_(browser),
			strCallBack_(strCallBack)
			{}
    virtual void Visit(const CefString& string) OVERRIDE {		  
		strCallBack_(0,string.c_str()); 
    }
   private:
    CefRefPtr<CefBrowser> browser_;
	delTextWalk strCallBack_;
    IMPLEMENT_REFCOUNTING(MyCefStringVisitor);
}; 

void DomGetTextWalk(ClientHandler* g_ClientHandler,delTextWalk strCallBack)
{ 
  auto browser1 = g_ClientHandler->GetBrowser();   
  //TODO: check mem leak here
  auto visitor= new MyCefStringVisitor(browser1,strCallBack); 
  browser1->GetMainFrame()->GetText(visitor);

}
void DomGetSourceWalk(ClientHandler* g_ClientHandler,delTextWalk strCallBack)
{ 
  auto browser1 = g_ClientHandler->GetBrowser();   
  //TODO: check mem leak here
  auto visitor= new MyCefStringVisitor(browser1,strCallBack); 
  browser1->GetMainFrame()->GetSource(visitor);
} 
void AgentRegisterManagedCallback(ClientHandler* g_ClientHandler,managed_callback callback)
{
	g_ClientHandler->SetManagedCallBack(callback);
}
void MyCefCbArgs_SetResultAsBuffer(MethodArgs* args,
	int resultIndex,
	const void* outputBuffer,
	int len)
{
	args->SetOutputString(resultIndex,outputBuffer,len);  
} 
 
jsvalue MyCefCbArgs_GetArg(MethodArgs* args,int argIndex)
{  
	switch(argIndex)
	{
		case 0:
			return args->arg0;
		case 1:
			return args->arg1;
		case 2:
			return args->arg2;
		case 3:
			return args->arg3;
		case 4:
			return args->arg4;
	}
	//empty
	jsvalue v;
	v.type =  JSVALUE_TYPE_EMPTY;
	v.length =0;
	return v;
	 
}  
int MyCefCbArgs_ArgCount(MethodArgs* args)
{
	return args->argCount;
}


void JsValueDispose(jsvalue value)
{	
	delete value.value.str;
}
  

 
class ClientSchemeHandler2 : public CefResourceHandler {
 public: 
  ClientSchemeHandler2() : offset_(0) {}

  virtual bool ProcessRequest(CefRefPtr<CefRequest> request,
                              CefRefPtr<CefCallback> callback)
                              OVERRIDE {
    CEF_REQUIRE_IO_THREAD();

    bool handled = false; 
    AutoLock lock_scope(this);
	 
	////send to 
 //   std::string url = request->GetURL();
 //   if (strstr(url.c_str(), "handler.html") != NULL) {
 //     // Build the response html
 //     data_ = "<html><head><title>Client Scheme Handler</title></head><body>"
 //             "This contents of this page page are served by the "
 //             "ClientSchemeHandler class handling the client:// protocol."
 //             "<br/>You should see an image:"
 //             "<br/><img src=\"client://tests/client.png\"><pre>";

 //     // Output a string representation of the request
 //     std::string dump;
 //     DumpRequestContents(request, dump);
 //     data_.append(dump);

 //     data_.append("</pre><br/>Try the test form:"
 //                  "<form method=\"POST\" action=\"handler.html\">"
 //                  "<input type=\"text\" name=\"field1\">"
 //                  "<input type=\"text\" name=\"field2\">"
 //                  "<input type=\"submit\">"
 //                  "</form></body></html>");

 //     handled = true;

 //     // Set the resulting mime type
 //     mime_type_ = "text/html";
 //   } else if (strstr(url.c_str(), "client.png") != NULL) {
 //     // Load the response image
 //     if (LoadBinaryResource("logo.png", data_)) {
 //       handled = true;
 //       // Set the resulting mime type
 //       mime_type_ = "image/png";
 //     }
 //   }

 //   if (handled) {
 //     // Indicate the headers are available.
 //     callback->Continue();
 //     return true;
 //   }

    return false;
  }

  virtual void GetResponseHeaders(CefRefPtr<CefResponse> response,
                                  int64& response_length,
                                  CefString& redirectUrl) OVERRIDE {
    CEF_REQUIRE_IO_THREAD();

    //ASSERT(!data_.empty());

    response->SetMimeType(mime_type_);
    response->SetStatus(200);

    // Set the resulting response length
    response_length = dataLen;
  }

  virtual void Cancel() OVERRIDE {
    CEF_REQUIRE_IO_THREAD();
  }

  virtual bool ReadResponse(void* data_out,
                            int bytes_to_read,
                            int& bytes_read,
                            CefRefPtr<CefCallback> callback)
                            OVERRIDE {
    CEF_REQUIRE_IO_THREAD();
	
    bool has_data = false;
    bytes_read = 0;

    AutoLock lock_scope(this);

    if (offset_ < dataLen) {
      // Copy the next block of data into the buffer.
      int transfer_size =
          std::min(bytes_to_read, static_cast<int>(dataLen - offset_));
      memcpy(data_out, (char*)data_ + offset_, transfer_size);
      offset_ += transfer_size;

      bytes_read = transfer_size;
      has_data = true;
    }

    return has_data;
  }

 private:
  
  void* data_; //content is binary blob
  size_t dataLen;

  std::string mime_type_;
  size_t offset_;

  IMPLEMENT_REFCOUNTING(ClientSchemeHandler2);
  IMPLEMENT_LOCKING(ClientSchemeHandler2);
};
class ClientSchemeHandlerFactory2 : public CefSchemeHandlerFactory {
 public:
	 //call to manaed side to create 
  managed_callback  callback2_newSchemeHandler;
  // Return a new scheme handler instance to handle the request.
  virtual CefRefPtr<CefResourceHandler> Create(CefRefPtr<CefBrowser> browser,
                                               CefRefPtr<CefFrame> frame,
                                               const CefString& scheme_name,
                                               CefRefPtr<CefRequest> request)
                                               OVERRIDE {
    CEF_REQUIRE_IO_THREAD();

	
	ClientSchemeHandler2* newHandler= new ClientSchemeHandler2();
	//ask .net side for a new scheme handler***	
	MethodArgs callbackArgs;

    return newHandler;
  }
  IMPLEMENT_REFCOUNTING(ClientSchemeHandlerFactory2);
};



//scheme
CefSchemeHandlerFactory* MyCef_CreateSchemeHandlerFactory(managed_callback callback2_newSchemeHandler)
{	 
	//call from .net side		
	
	ClientSchemeHandlerFactory2* schemeFactory2= new ClientSchemeHandlerFactory2();
	schemeFactory2->callback2_newSchemeHandler=callback2_newSchemeHandler;
	return schemeFactory2;
}
//-----------------------------------------------------------
void MyCef_CefRegisterSchemeHandlerFactory(  
	const wchar_t* schemeName,
	const wchar_t* startURL,
    CefSchemeHandlerFactory* clientSchemeHandlerFactoryObject)
{ 
	CefRegisterSchemeHandlerFactory(
		schemeName,
		startURL,
		clientSchemeHandlerFactoryObject);
}
=======
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
//4.
client::MainContextImpl* MyCefInit(HINSTANCE hInstance,client::ClientApp* app)
{
	CefRefPtr<client::ClientApp> myApp = app;   
	return DllInitMain(hInstance,myApp);
} 
//5. 
void MyCefClientAppSetManagedCallback(client::ClientApp* clientApp,managed_callback myMxCallback)
{
	clientApp->myMxCallback = myMxCallback;
}
//6.
void MyCefDoMessageLoopWork()
{		
	CefDoMessageLoopWork();
}
//7.
client::ClientHandler* MyCefCreateClientHandler(client::MainContextImpl* mainContext,
	HWND parentWindowHandler,
    int x, int y, int w, int h)
{ 
	const CefRect rect(x,y,w,h);	 
	mainContext->GetRootWindowManager()->RegisterManagedSurfaceWindow(
		parentWindowHandler,
		rect, std::string()); 
	return NULL;
}
	
>>>>>>> origin/3.2357.1267
