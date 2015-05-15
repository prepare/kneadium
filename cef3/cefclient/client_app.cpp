// Copyright (c) 2013 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

// This file is shared by cefclient and cef_unittests so don't include using
// a qualified path.
#include "client_app.h"  // NOLINT(build/include)

#include <string>

#include "include/cef_cookie.h"
#include "include/cef_process_message.h"
#include "include/cef_task.h"
#include "include/cef_v8.h"
#include "include/wrapper/cef_helpers.h"

ClientApp::ClientApp() {
	myMxCallback= NULL;
}

void ClientApp::OnRegisterCustomSchemes(
    CefRefPtr<CefSchemeRegistrar> registrar) {

<<<<<<< HEAD
// Handles the native implementation for the client_app extension.
class ClientAppExtensionHandler : public CefV8Handler {
 public:
  explicit ClientAppExtensionHandler(CefRefPtr<ClientApp> client_app)
    : client_app_(client_app) {
  }

  virtual bool Execute(const CefString& name,
                       CefRefPtr<CefV8Value> object,
                       const CefV8ValueList& arguments,
                       CefRefPtr<CefV8Value>& retval,
                       CefString& exception) {
   
	bool handled = false;

    if (name == "sendMessage") {
      // Send a message to the browser process.
      if ((arguments.size() == 1 || arguments.size() == 2) &&
          arguments[0]->IsString()) {
        CefRefPtr<CefBrowser> browser =
            CefV8Context::GetCurrentContext()->GetBrowser();
        ASSERT(browser.get());

        CefString name = arguments[0]->GetStringValue();
        if (!name.empty()) {
          CefRefPtr<CefProcessMessage> message =
              CefProcessMessage::Create(name);

          // Translate the arguments, if any.
          if (arguments.size() == 2 && arguments[1]->IsArray())
            SetList(arguments[1], message->GetArgumentList());

          browser->SendProcessMessage(PID_BROWSER, message);
          handled = true;
        }
      }
    } else if (name == "setMessageCallback") {
      // Set a message callback.
      if (arguments.size() == 2 && arguments[0]->IsString() &&
          arguments[1]->IsFunction()) {
        std::string name = arguments[0]->GetStringValue();
        CefRefPtr<CefV8Context> context = CefV8Context::GetCurrentContext();
        int browser_id = context->GetBrowser()->GetIdentifier();
        client_app_->SetMessageCallback(name, browser_id, context,
                                        arguments[1]);
        handled = true;
      }
    }  else if (name == "removeMessageCallback") {
      // Remove a message callback.
      if (arguments.size() == 1 && arguments[0]->IsString()) {
        std::string name = arguments[0]->GetStringValue();
        CefRefPtr<CefV8Context> context = CefV8Context::GetCurrentContext();
        int browser_id = context->GetBrowser()->GetIdentifier();
        bool removed = client_app_->RemoveMessageCallback(name, browser_id);
        retval = CefV8Value::CreateBool(removed);
        handled = true;
      }
    }

    if (!handled)
      exception = "Invalid method arguments";

    return true;
  }

 private:
  CefRefPtr<ClientApp> client_app_;

  IMPLEMENT_REFCOUNTING(ClientAppExtensionHandler);
};

}  // namespace


ClientApp::ClientApp() {

  myMxCallback= NULL;
  CreateBrowserDelegates(browser_delegates_);
  CreateRenderDelegates(render_delegates_);
=======
>>>>>>> origin/retro1

  // Default schemes that support cookies.
  cookieable_schemes_.push_back("http");
  cookieable_schemes_.push_back("https"); 

  if(this->myMxCallback)
  {  
		//send to
		myMxCallback(0,NULL);
  }
  else
  {	 
	   RegisterCustomSchemes(registrar, cookieable_schemes_);
		////others...
		//scheme_test::RegisterCustomSchemes(registrar, cookiable_schemes);
  }

}

<<<<<<< HEAD
void ClientApp::OnContextInitialized() 
{
=======
void ClientApp::OnContextInitialized() {
  CreateBrowserDelegates(browser_delegates_);

>>>>>>> origin/retro1
  // Register cookieable schemes with the global cookie manager.
  CefRefPtr<CefCookieManager> manager = CefCookieManager::GetGlobalManager();
  DCHECK(manager.get());
  manager->SetSupportedSchemes(cookieable_schemes_);

  print_handler_ = CreatePrintHandler();

  BrowserDelegateSet::iterator it = browser_delegates_.begin();
  for (; it != browser_delegates_.end(); ++it)
    (*it)->OnContextInitialized(this);
}

void ClientApp::OnBeforeChildProcessLaunch(
      CefRefPtr<CefCommandLine> command_line) 
{
  BrowserDelegateSet::iterator it = browser_delegates_.begin();
  for (; it != browser_delegates_.end(); ++it)
    (*it)->OnBeforeChildProcessLaunch(this, command_line);
}

void ClientApp::OnRenderProcessThreadCreated(
    CefRefPtr<CefListValue> extra_info)
{
  BrowserDelegateSet::iterator it = browser_delegates_.begin();
  for (; it != browser_delegates_.end(); ++it)
    (*it)->OnRenderProcessThreadCreated(this, extra_info);
}

void ClientApp::OnRenderThreadCreated(CefRefPtr<CefListValue> extra_info) {
  CreateRenderDelegates(render_delegates_);

  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnRenderThreadCreated(this, extra_info);
}

<<<<<<< HEAD
void ClientApp::OnWebKitInitialized()
{   
	if(this->myMxCallback)
	{ 

	}
  

  // Register the client_app extension.
  std::string app_code =
    "var app;"
    "if (!app)"
    "  app = {};"
    "(function() {"
    "  app.sendMessage = function(name, arguments) {"
    "    native function sendMessage();"
    "    return sendMessage(name, arguments);"
    "  };"
    "  app.setMessageCallback = function(name, callback) {"
    "    native function setMessageCallback();"
    "    return setMessageCallback(name, callback);"
    "  };"
    "  app.removeMessageCallback = function(name) {"
    "    native function removeMessageCallback();"
    "    return removeMessageCallback(name);"
    "  };"
    "})();";
  CefRegisterExtension("v8/app", app_code,
      new ClientAppExtensionHandler(this));

=======
void ClientApp::OnWebKitInitialized() {
>>>>>>> origin/retro1
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnWebKitInitialized(this);
}

void ClientApp::OnBrowserCreated(CefRefPtr<CefBrowser> browser)
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnBrowserCreated(this, browser);
}

void ClientApp::OnBrowserDestroyed(CefRefPtr<CefBrowser> browser)
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnBrowserDestroyed(this, browser);
}

CefRefPtr<CefLoadHandler> ClientApp::GetLoadHandler() {
  CefRefPtr<CefLoadHandler> load_handler;
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end() && !load_handler.get(); ++it)
    load_handler = (*it)->GetLoadHandler(this);

  return load_handler;
}

bool ClientApp::OnBeforeNavigation(CefRefPtr<CefBrowser> browser,
                                   CefRefPtr<CefFrame> frame,
                                   CefRefPtr<CefRequest> request,
                                   NavigationType navigation_type,
                                   bool is_redirect)
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it) {
    if ((*it)->OnBeforeNavigation(this, browser, frame, request,
                                  navigation_type, is_redirect)) {
      return true;
    }
  }

  return false;
}

void ClientApp::OnContextCreated(CefRefPtr<CefBrowser> browser,
                                 CefRefPtr<CefFrame> frame,
                                 CefRefPtr<CefV8Context> context) 
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnContextCreated(this, browser, frame, context);
}

void ClientApp::OnContextReleased(CefRefPtr<CefBrowser> browser,
                                  CefRefPtr<CefFrame> frame,
                                  CefRefPtr<CefV8Context> context)
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnContextReleased(this, browser, frame, context);
}

void ClientApp::OnUncaughtException(CefRefPtr<CefBrowser> browser,
                                    CefRefPtr<CefFrame> frame,
                                    CefRefPtr<CefV8Context> context,
                                    CefRefPtr<CefV8Exception> exception,
                                    CefRefPtr<CefV8StackTrace> stackTrace)
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it) {
    (*it)->OnUncaughtException(this, browser, frame, context, exception,
                               stackTrace);
  }
}

void ClientApp::OnFocusedNodeChanged(CefRefPtr<CefBrowser> browser,
                                     CefRefPtr<CefFrame> frame,
                                     CefRefPtr<CefDOMNode> node)
{
  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end(); ++it)
    (*it)->OnFocusedNodeChanged(this, browser, frame, node);
}

bool ClientApp::OnProcessMessageReceived(
    CefRefPtr<CefBrowser> browser,
    CefProcessId source_process,
<<<<<<< HEAD
    CefRefPtr<CefProcessMessage> message) 
{
  ASSERT(source_process == PID_BROWSER);
=======
    CefRefPtr<CefProcessMessage> message) {
  DCHECK_EQ(source_process, PID_BROWSER);

>>>>>>> origin/retro1
  bool handled = false;

  RenderDelegateSet::iterator it = render_delegates_.begin();
  for (; it != render_delegates_.end() && !handled; ++it) {
    handled = (*it)->OnProcessMessageReceived(this, browser, source_process,
                                              message);
  }

  return handled;
}
