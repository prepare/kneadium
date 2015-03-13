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
	 return 1001;
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
    explicit MyCefStringVisitor(CefRefPtr<CefBrowser> browser, del04 strCallBack) : 
			browser_(browser),
			strCallBack_(strCallBack)
			{}
    virtual void Visit(const CefString& string) OVERRIDE {		  
		strCallBack_(0,string.c_str()); 
    }
   private:
    CefRefPtr<CefBrowser> browser_;
	del04  strCallBack_;
    IMPLEMENT_REFCOUNTING(Visitor);
}; 

void DomGetTextWalk(ClientHandler* g_ClientHandler,del04 strCallBack)
{ 
  auto browser1 = g_ClientHandler->GetBrowser();   
  //TODO: check mem leak here
  auto visitor= new MyCefStringVisitor(browser1,strCallBack); 
  browser1->GetMainFrame()->GetText(visitor);

}
void DomGetSourceWalk(ClientHandler* g_ClientHandler,del04 strCallBack)
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

	  
void MyCefCbArgs_SetResultAsBuffer(CefCallbackArgs* args,
	int resultIndex,
	const void* outputBuffer,
	int len)
{
	args->SetOutputString(resultIndex,outputBuffer,len);  
} 
 
jsvalue MyCefCbArgs_GetArg(CefCallbackArgs* args,int argIndex)
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
int MyCefCbArgs_ArgCount(CefCallbackArgs* args)
{
	return args->argCount;
}


void JsValueDispose(jsvalue value)
{	
	delete value.value.str;
}
void CefRequest_GetURL(CefRequest* req,wchar_t* resultBuffer,int* len)
{		 
	auto url= req->GetURL().c_str(); 
	*len = wcslen(url);
	wcscpy(resultBuffer, url);
}

//-----------------------------------------------------------
class ProcessRequestArgs
{
public:
	//call .net args...
	CefRequest* req;  
	//----------------
	void* outputResult;
};


typedef void (*ClientSchemeHandler2_ProcessRequestCb)(int id, CefRequest* cefRequest);

class ClientSchemeHandler2 : public CefResourceHandler {
 public:
  
  ClientSchemeHandler2_ProcessRequestCb processReqCb;

  ClientSchemeHandler2() : offset_(0) {}

  virtual bool ProcessRequest(CefRefPtr<CefRequest> request,
                              CefRefPtr<CefCallback> callback)
                              OVERRIDE {
    REQUIRE_IO_THREAD();

    bool handled = false; 
    AutoLock lock_scope(this);
	if(processReqCb)
	{	

		processReqCb(0,request);

	}
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
    REQUIRE_IO_THREAD();

    //ASSERT(!data_.empty());

    response->SetMimeType(mime_type_);
    response->SetStatus(200);

    // Set the resulting response length
    response_length = dataLen;
  }

  virtual void Cancel() OVERRIDE {
    REQUIRE_IO_THREAD();
  }

  virtual bool ReadResponse(void* data_out,
                            int bytes_to_read,
                            int& bytes_read,
                            CefRefPtr<CefCallback> callback)
                            OVERRIDE {
    REQUIRE_IO_THREAD();

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
  managed_callback2  callback2_newSchemeHandler;
  // Return a new scheme handler instance to handle the request.
  virtual CefRefPtr<CefResourceHandler> Create(CefRefPtr<CefBrowser> browser,
                                               CefRefPtr<CefFrame> frame,
                                               const CefString& scheme_name,
                                               CefRefPtr<CefRequest> request)
                                               OVERRIDE {
    REQUIRE_IO_THREAD();

	
	ClientSchemeHandler2* newHandler= new ClientSchemeHandler2();
	//ask .net side for new scheme handler***
	
	//callback2_newSchemeHandler(0,

    return newHandler;
  }
  IMPLEMENT_REFCOUNTING(ClientSchemeHandlerFactory2);
};



//scheme
CefSchemeHandlerFactory* MyCef_CreateSchemeHandlerFactory(managed_callback2 callback2_newSchemeHandler)
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