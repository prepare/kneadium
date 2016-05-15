//###_ORIGINAL D:\projects\cef_binary_3.2623.1399\cefclient\browser//client_handler.cc
// Copyright (c) 2013 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "cefclient/browser/client_handler.h"

#include <stdio.h>
#include <algorithm>
#include <iomanip>
#include <sstream>
#include <string>

#include "include/base/cef_bind.h"
#include "include/cef_browser.h"
#include "include/cef_frame.h"
#include "include/cef_parser.h"
#include "include/wrapper/cef_closure_task.h"
#include "cefclient/browser/main_context.h"
#include "cefclient/browser/resource_util.h"
#include "cefclient/browser/root_window_manager.h"
#include "cefclient/browser/test_runner.h"
#include "cefclient/common/client_switches.h"

namespace client {

#if defined(OS_WIN)
#define NEWLINE "\r\n"
#else
#define NEWLINE "\n"
#endif

namespace {

// Custom menu command Ids.
enum client_menu_ids {
  CLIENT_ID_SHOW_DEVTOOLS   = MENU_ID_USER_FIRST,
  CLIENT_ID_CLOSE_DEVTOOLS,
  CLIENT_ID_INSPECT_ELEMENT,
  CLIENT_ID_TESTMENU_SUBMENU,
  CLIENT_ID_TESTMENU_CHECKITEM,
  CLIENT_ID_TESTMENU_RADIOITEM1,
  CLIENT_ID_TESTMENU_RADIOITEM2,
  CLIENT_ID_TESTMENU_RADIOITEM3,
};

// Musr match the value in client_renderer.cc.
const char kFocusedNodeChangedMessage[] = "ClientRenderer.FocusedNodeChanged";

std::string GetTimeString(const CefTime& value) {
  if (value.GetTimeT() == 0)
    return "Unspecified";

  static const char* kMonths[] = {
    "January", "February", "March", "April", "May", "June", "July", "August",
    "September", "October", "November", "December"
  };
  std::string month;
  if (value.month >= 1 && value.month <= 12)
    month = kMonths[value.month - 1];
  else
    month = "Invalid";

  std::stringstream ss;
  ss << month << " " << value.day_of_month << ", " << value.year << " " <<
      std::setfill('0') << std::setw(2) << value.hour << ":" <<
      std::setfill('0') << std::setw(2) << value.minute << ":" <<
      std::setfill('0') << std::setw(2) << value.second;
  return ss.str();
}

std::string GetBinaryString(CefRefPtr<CefBinaryValue> value) {
  if (!value.get())
    return "&nbsp;";

  // Retrieve the value.
  const size_t size = value->GetSize();
  std::string src;
  src.resize(size);
  value->GetData(const_cast<char*>(src.data()), size, 0);

  // Encode the value.
  return CefBase64Encode(src.data(), src.size());
}

std::string GetCertStatusString(cef_cert_status_t status) {
  #define FLAG(flag) if (status & flag) result += std::string(#flag) + "<br/>"
  std::string result;

  FLAG(CERT_STATUS_COMMON_NAME_INVALID);
  FLAG(CERT_STATUS_DATE_INVALID);
  FLAG(CERT_STATUS_AUTHORITY_INVALID);
  FLAG(CERT_STATUS_NO_REVOCATION_MECHANISM);
  FLAG(CERT_STATUS_UNABLE_TO_CHECK_REVOCATION);
  FLAG(CERT_STATUS_REVOKED);
  FLAG(CERT_STATUS_INVALID);
  FLAG(CERT_STATUS_WEAK_SIGNATURE_ALGORITHM);
  FLAG(CERT_STATUS_NON_UNIQUE_NAME);
  FLAG(CERT_STATUS_WEAK_KEY);
  FLAG(CERT_STATUS_PINNED_KEY_MISSING);
  FLAG(CERT_STATUS_NAME_CONSTRAINT_VIOLATION);
  FLAG(CERT_STATUS_VALIDITY_TOO_LONG);
  FLAG(CERT_STATUS_IS_EV);
  FLAG(CERT_STATUS_REV_CHECKING_ENABLED);
  FLAG(CERT_STATUS_SHA1_SIGNATURE_PRESENT);
  FLAG(CERT_STATUS_CT_COMPLIANCE_FAILED);

  if (result.empty())
    return "&nbsp;";
  return result;
}

// Load a data: URI containing the error message.
void LoadErrorPage(CefRefPtr<CefFrame> frame,
                   const std::string& failed_url,
                   cef_errorcode_t error_code,
                   const std::string& other_info) {
  std::stringstream ss;
  ss << "<html><head><title>Page failed to load</title></head>"
        "<body bgcolor=\"white\">"
        "<h3>Page failed to load.</h3>"
        "URL: <a href=\"" << failed_url << "\">"<< failed_url << "</a>"
        "<br/>Error: " << test_runner::GetErrorString(error_code) <<
        " (" << error_code << ")";

  if (!other_info.empty())
    ss << "<br/>" << other_info;

  ss << "</body></html>";
  frame->LoadURL(test_runner::GetDataURI(ss.str(), "text/html"));
}

}  // namespace

//###_START 0
ClientHandler::ClientHandler(Delegate* delegate,
                             bool is_osr,
                             const std::string& startup_url)
  : is_osr_(is_osr),
    startup_url_(startup_url),
    delegate_(delegate),
    browser_count_(0),
    console_log_file_(MainContext::Get()->GetConsoleLogPath()),
    first_console_message_(true),
    focus_on_editable_field_(false) {
//###_FIND_NEXT_LANDMARK 0
  DCHECK(!console_log_file_.empty());
//###_APPEND_START 0
this->mcallback_ = NULL;
this->enableKeyIntercept = 0;//init
//###_APPEND_STOP

#if defined(OS_LINUX)
  // Provide the GTK-based dialog implementation on Linux.
  dialog_handler_ = new ClientDialogHandlerGtk();
#endif

  resource_manager_ = new CefResourceManager();
  test_runner::SetupResourceManager(resource_manager_);

  // Read command line settings.
  CefRefPtr<CefCommandLine> command_line =
      CefCommandLine::GetGlobalCommandLine();
  mouse_cursor_change_disabled_ =
      command_line->HasSwitch(switches::kMouseCursorChangeDisabled);
}

void ClientHandler::DetachDelegate() {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(base::Bind(&ClientHandler::DetachDelegate, this));
    return;
  }

  DCHECK(delegate_);
  delegate_ = NULL;
}

bool ClientHandler::OnProcessMessageReceived(
    CefRefPtr<CefBrowser> browser,
    CefProcessId source_process,
    CefRefPtr<CefProcessMessage> message) {
  CEF_REQUIRE_UI_THREAD();

  if (message_router_->OnProcessMessageReceived(browser, source_process,
                                                message)) {
    return true;
  }

  // Check for messages from the client renderer.
  std::string message_name = message->GetName();
  if (message_name == kFocusedNodeChangedMessage) {
    // A message is sent from ClientRenderDelegate to tell us whether the
    // currently focused DOM node is editable. Use of |focus_on_editable_field_|
    // is redundant with CefKeyEvent.focus_on_editable_field in OnPreKeyEvent
    // but is useful for demonstration purposes.
    focus_on_editable_field_ = message->GetArgumentList()->GetBool(0);
    return true;
  }

  return false;
}

void ClientHandler::OnBeforeContextMenu(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefFrame> frame,
    CefRefPtr<CefContextMenuParams> params,
    CefRefPtr<CefMenuModel> model) {
  CEF_REQUIRE_UI_THREAD();

//###_START 0
  if ((params->GetTypeFlags() & (CM_TYPEFLAG_PAGE | CM_TYPEFLAG_FRAME)) != 0) {
//###_APPEND_START 0
if (this->mcallback_)
{
//send menu model to managed side
this->mcallback_(CEF_MSG_ClientHandler_OnBeforeContextMenu, NULL);
}
else if ((params->GetTypeFlags() & (CM_TYPEFLAG_PAGE | CM_TYPEFLAG_FRAME)) != 0) {
// Add a separator if the menu already has items.
if (model->GetCount() > 0)
model->AddSeparator();

// Add DevTools items to all context menus.
model->AddItem(CLIENT_ID_SHOW_DEVTOOLS, "&Show DevTools");
model->AddItem(CLIENT_ID_CLOSE_DEVTOOLS, "Close DevTools");
model->AddSeparator();
model->AddItem(CLIENT_ID_INSPECT_ELEMENT, "Inspect Element");

// Test context menu features.
BuildTestMenu(model);
}
//###_APPEND_STOP
    // Add a separator if the menu already has items.
    if (model->GetCount() > 0)
      model->AddSeparator();

    // Add DevTools items to all context menus.
    model->AddItem(CLIENT_ID_SHOW_DEVTOOLS, "&Show DevTools");
    model->AddItem(CLIENT_ID_CLOSE_DEVTOOLS, "Close DevTools");
    model->AddSeparator();
    model->AddItem(CLIENT_ID_INSPECT_ELEMENT, "Inspect Element");

    // Test context menu features.
    BuildTestMenu(model);
  }
}

//###_START 1
bool ClientHandler::OnContextMenuCommand(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefFrame> frame,
    CefRefPtr<CefContextMenuParams> params,
    int command_id,
    EventFlags event_flags) {
//###_FIND_NEXT_LANDMARK 1
  CEF_REQUIRE_UI_THREAD();
//###_APPEND_START 1
if (this->mcallback_) {
return true;
}
else {
switch (command_id) {
case CLIENT_ID_SHOW_DEVTOOLS:
ShowDevTools(browser, CefPoint());
return true;
case CLIENT_ID_CLOSE_DEVTOOLS:
CloseDevTools(browser);
return true;
case CLIENT_ID_INSPECT_ELEMENT:
ShowDevTools(browser, CefPoint(params->GetXCoord(), params->GetYCoord()));
return true;
default:  // Allow default handling, if any.
return ExecuteTestMenu(command_id);
}
}
//###_APPEND_STOP
//###_SKIP_UNTIL_PASS 1 }
}

void ClientHandler::OnAddressChange(CefRefPtr<CefBrowser> browser,
                                    CefRefPtr<CefFrame> frame,
                                    const CefString& url) {
  CEF_REQUIRE_UI_THREAD();

  // Only update the address for the main (top-level) frame.
  if (frame->IsMain())
    NotifyAddress(url);
}

void ClientHandler::OnTitleChange(CefRefPtr<CefBrowser> browser,
                                  const CefString& title) {
  CEF_REQUIRE_UI_THREAD();

  NotifyTitle(title);
}

void ClientHandler::OnFullscreenModeChange(CefRefPtr<CefBrowser> browser,
                                           bool fullscreen) {
  CEF_REQUIRE_UI_THREAD();

  NotifyFullscreen(fullscreen);
}

//###_START 2
bool ClientHandler::OnConsoleMessage(CefRefPtr<CefBrowser> browser,
                                     const CefString& message,
                                     const CefString& source,
                                     int line) {
//###_FIND_NEXT_LANDMARK 2
  CEF_REQUIRE_UI_THREAD();
//###_APPEND_START 2
if (this->mcallback_) {

//get managed stream object
MethodArgs* args = new MethodArgs();
// memset(&args,0,sizeof(MethodArgs));	  
//send info to managed side

auto str16 = message.ToString16();
auto cstr = str16.c_str();
args->SetArgAsString(0, cstr);
auto str16_1 = message.ToString16();
auto cstr_1 = str16_1.c_str();
args->SetArgAsString(1, cstr_1);
auto str16_2 = std::to_wstring((long long)line);
auto cstr_2 = str16_2.c_str();
args->SetArgAsString(2, cstr_2);
this->mcallback_(CEF_MSG_ClientHandler_OnConsoleMessage, args);

delete args;
}
else {
FILE* file = fopen(console_log_file_.c_str(), "a");
if (file) {
std::stringstream ss;
ss << "Message: " << message.ToString() << NEWLINE <<
"Source: " << source.ToString() << NEWLINE <<
"Line: " << line << NEWLINE <<
"-----------------------" << NEWLINE;
fputs(ss.str().c_str(), file);
fclose(file);

if (first_console_message_) {
test_runner::Alert(
browser, "Console messages written to " + console_log_file_);
first_console_message_ = false;
}
}
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 2
  return false;
}

void ClientHandler::OnBeforeDownload(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefDownloadItem> download_item,
    const CefString& suggested_name,
    CefRefPtr<CefBeforeDownloadCallback> callback) {
  CEF_REQUIRE_UI_THREAD();

  // Continue the download and show the "Save As" dialog.
  callback->Continue(MainContext::Get()->GetDownloadPath(suggested_name), true);
}

void ClientHandler::OnDownloadUpdated(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefDownloadItem> download_item,
    CefRefPtr<CefDownloadItemCallback> callback) {
  CEF_REQUIRE_UI_THREAD();

  if (download_item->IsComplete()) {
    test_runner::Alert(
        browser,
        "File \"" + download_item->GetFullPath().ToString() +
        "\" downloaded successfully.");
  }
}

bool ClientHandler::OnDragEnter(CefRefPtr<CefBrowser> browser,
                                CefRefPtr<CefDragData> dragData,
                                CefDragHandler::DragOperationsMask mask) {
  CEF_REQUIRE_UI_THREAD();

  // Forbid dragging of link URLs.
  if (mask & DRAG_OPERATION_LINK)
    return true;

  return false;
}

void ClientHandler::OnDraggableRegionsChanged(
    CefRefPtr<CefBrowser> browser,
    const std::vector<CefDraggableRegion>& regions) {
  CEF_REQUIRE_UI_THREAD();

  NotifyDraggableRegions(regions);
}

bool ClientHandler::OnRequestGeolocationPermission(
      CefRefPtr<CefBrowser> browser,
      const CefString& requesting_url,
      int request_id,
      CefRefPtr<CefGeolocationCallback> callback) {
  CEF_REQUIRE_UI_THREAD();

//###_START 3
  // Allow geolocation access from all websites.
//###_APPEND_START 3
callback->Continue(false); //I cancel all :)
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 3
  return true;
}

//###_START 7
bool ClientHandler::OnPreKeyEvent(CefRefPtr<CefBrowser> browser,
                                  const CefKeyEvent& event,
                                  CefEventHandle os_event,
                                  bool* is_keyboard_shortcut) {
//###_FIND_NEXT_LANDMARK 7
  CEF_REQUIRE_UI_THREAD();
//###_APPEND_START 7
if (this->mcallback_ && this->enableKeyIntercept != 0) {
if (!event.focus_on_editable_field) {
//call across process, so create on heap 
//don't forget to release it
MethodArgs* metArgs = new MethodArgs();
metArgs->SetArgAsNativeObject(0, &event);
this->mcallback_(CEF_MSG_ClientHandler_OnPreKeyEvent, metArgs); //tmp
int result = metArgs->ReadOutputAsInt32(0);
delete metArgs;
return result != 0;
}
}
else {
if (!event.focus_on_editable_field && event.windows_key_code == 0x20) {
// Special handling for the space character when an input element does not
// have focus. Handling the event in OnPreKeyEvent() keeps the event from
// being processed in the renderer. If we instead handled the event in the
// OnKeyEvent() method the space key would cause the window to scroll in
// addition to showing the alert box.
if (event.type == KEYEVENT_RAWKEYDOWN)
test_runner::Alert(browser, "You pressed the space bar!");
return true;
}
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 7
  return false;
}

//###_START 4
bool ClientHandler::OnBeforePopup(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefFrame> frame,
    const CefString& target_url,
    const CefString& target_frame_name,
    CefLifeSpanHandler::WindowOpenDisposition target_disposition,
    bool user_gesture,
    const CefPopupFeatures& popupFeatures,
    CefWindowInfo& windowInfo,
    CefRefPtr<CefClient>& client,
    CefBrowserSettings& settings,
    bool* no_javascript_access) {
//###_FIND_NEXT_LANDMARK 4
  CEF_REQUIRE_IO_THREAD();
//###_APPEND_START 4
if (this->mcallback_) {
//create popup window
//with specific url
//*** on managed side  : please invoke on main process of app ***

//call across process, so create on heap 
//don't forget to release it
MethodArgs* metArgs = new MethodArgs();
auto str16 = target_url.ToString16();
auto cstr = str16.c_str();

metArgs->SetArgAsString(0, cstr);
this->mcallback_(CEF_MSG_ClientHandler_OnBeforePopup, metArgs);

delete metArgs;

return true;
}
else {

// Return true to cancel the popup window.
return !CreatePopupWindow(browser, false, popupFeatures, windowInfo, client,
settings);
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 4
}

//###_START 5
void ClientHandler::OnAfterCreated(CefRefPtr<CefBrowser> browser) {
  CEF_REQUIRE_UI_THREAD();

  browser_count_++;

  if (!message_router_) {
    // Create the browser-side router for query handling.
    CefMessageRouterConfig config;
//###_FIND_NEXT_LANDMARK 5
    message_router_ = CefMessageRouterBrowserSide::Create(config);
//###_APPEND_START 5
// Register handlers with the router.
if (this->mcallback_)
{
//1. msg handler
MyCefJsHandler* myCefJsHandler = new MyCefJsHandler();
message_handler_set_.insert(myCefJsHandler);
myCefJsHandler->mcallback_ = this->mcallback_;

MessageHandlerSet::const_iterator it = message_handler_set_.begin();
for (; it != message_handler_set_.end(); ++it)
message_router_->AddHandler(*(it), false);
}
else
{
test_runner::CreateMessageHandlers(message_handler_set_);
MessageHandlerSet::const_iterator it = message_handler_set_.begin();
for (; it != message_handler_set_.end(); ++it)
message_router_->AddHandler(*(it), false);

}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 5
  }

  // Disable mouse cursor change if requested via the command-line flag.
  if (mouse_cursor_change_disabled_)
    browser->GetHost()->SetMouseCursorChangeDisabled(true);

  NotifyBrowserCreated(browser);
}

bool ClientHandler::DoClose(CefRefPtr<CefBrowser> browser) {
  CEF_REQUIRE_UI_THREAD();

  NotifyBrowserClosing(browser);

  // Allow the close. For windowed browsers this will result in the OS close
  // event being sent.
  return false;
}

void ClientHandler::OnBeforeClose(CefRefPtr<CefBrowser> browser) {
  CEF_REQUIRE_UI_THREAD();

  if (--browser_count_ == 0) {
    // Remove and delete message router handlers.
    MessageHandlerSet::const_iterator it =
        message_handler_set_.begin();
    for (; it != message_handler_set_.end(); ++it) {
      message_router_->RemoveHandler(*(it));
      delete *(it);
    }
    message_handler_set_.clear();
    message_router_ = NULL;
  }

  NotifyBrowserClosed(browser);
}

void ClientHandler::OnLoadingStateChange(CefRefPtr<CefBrowser> browser,
                                         bool isLoading,
                                         bool canGoBack,
                                         bool canGoForward) {
  CEF_REQUIRE_UI_THREAD();

  NotifyLoadingState(isLoading, canGoBack, canGoForward);
}

//###_START 6
void ClientHandler::OnLoadError(CefRefPtr<CefBrowser> browser,
                                CefRefPtr<CefFrame> frame,
                                ErrorCode errorCode,
                                const CefString& errorText,
                                const CefString& failedUrl) {
  CEF_REQUIRE_UI_THREAD();

  // Don't display an error for downloaded files.
  if (errorCode == ERR_ABORTED)
    return;

  //###_FIND_NEXT_LANDMARK 6
  // Don't display an error for external protocols that we allow the OS to
  //###_FIND_NEXT_LANDMARK 6
  // handle. See OnProtocolExecution().
  //###_APPEND_START 6   

  if (this->mcallback_)
  {
	  //TODO: send cmd to managed side
	  //create dev window
	  //send cef client
	  MethodArgs  args;
	  memset(&args, 0, sizeof(MethodArgs));
	  //send info to managed side 
	  args.SetArgAsNativeObject(0, browser.get());
	  args.SetArgAsNativeObject(1, frame.get());
	  args.SetArgAsInt32(2, errorCode);
	  auto str16 = errorText.ToString16();
	  auto cstr = str16.c_str();
	  args.SetArgAsString(3, cstr);

	  auto str16_1 = failedUrl.ToString16();
	  auto cstr_1 = str16_1.c_str();
	  args.SetArgAsString(4, cstr_1);
	  //------------------------
	  this->mcallback_(CEF_MSG_ClientHandler_OnLoadError, &args);
	  //------------------------			 
	  //load page error

	  LoadErrorPage(frame, failedUrl, errorCode, errorText);
  }
  else
  {
	  if (errorCode == ERR_UNKNOWN_URL_SCHEME) {
		  std::string urlStr = frame->GetURL();
		  if (urlStr.find("spotify:") == 0)
			  return;
	  }
	  // Load the error page. 
	  LoadErrorPage(frame, failedUrl, errorCode, errorText);
  }

  //###_APPEND_STOP 
  //###_SKIP_UNTIL_PASS 6 }
  //if (errorCode == ERR_UNKNOWN_URL_SCHEME) {
  //	std::string urlStr = frame->GetURL();
  //	if (urlStr.find("spotify:") == 0)
  //		return;
  //}
  //// Load the error page. 
  //LoadErrorPage(frame, failedUrl, errorCode, errorText); 
}

bool ClientHandler::OnBeforeBrowse(CefRefPtr<CefBrowser> browser,
                                   CefRefPtr<CefFrame> frame,
                                   CefRefPtr<CefRequest> request,
                                   bool is_redirect) {
  CEF_REQUIRE_UI_THREAD();

  message_router_->OnBeforeBrowse(browser, frame);
  return false;
}

bool ClientHandler::OnOpenURLFromTab(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefFrame> frame,
    const CefString& target_url,
    CefRequestHandler::WindowOpenDisposition target_disposition,
    bool user_gesture) {
  if (target_disposition == WOD_NEW_BACKGROUND_TAB ||
      target_disposition == WOD_NEW_FOREGROUND_TAB) {
    // Handle middle-click and ctrl + left-click by opening the URL in a new
    // browser window.
    MainContext::Get()->GetRootWindowManager()->CreateRootWindow(
        true, is_osr(), CefRect(), target_url);
    return true;
  }

  // Open the URL in the current browser window.
  return false;
}

cef_return_value_t ClientHandler::OnBeforeResourceLoad(
      CefRefPtr<CefBrowser> browser,
      CefRefPtr<CefFrame> frame,
      CefRefPtr<CefRequest> request,
      CefRefPtr<CefRequestCallback> callback) {
  CEF_REQUIRE_IO_THREAD();

  return resource_manager_->OnBeforeResourceLoad(browser, frame, request,
                                                 callback);
}

CefRefPtr<CefResourceHandler> ClientHandler::GetResourceHandler(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefFrame> frame,
    CefRefPtr<CefRequest> request) {
  CEF_REQUIRE_IO_THREAD();

  return resource_manager_->GetResourceHandler(browser, frame, request);
}

CefRefPtr<CefResponseFilter> ClientHandler::GetResourceResponseFilter(
    CefRefPtr<CefBrowser> browser,
    CefRefPtr<CefFrame> frame,
    CefRefPtr<CefRequest> request,
    CefRefPtr<CefResponse> response) {
  CEF_REQUIRE_IO_THREAD();

  return test_runner::GetResourceResponseFilter(browser, frame, request,
                                                response);
}

bool ClientHandler::OnQuotaRequest(CefRefPtr<CefBrowser> browser,
                                   const CefString& origin_url,
                                   int64 new_size,
                                   CefRefPtr<CefRequestCallback> callback) {
  CEF_REQUIRE_IO_THREAD();

  static const int64 max_size = 1024 * 1024 * 20;  // 20mb.

  // Grant the quota request if the size is reasonable.
  callback->Continue(new_size <= max_size);
  return true;
}

void ClientHandler::OnProtocolExecution(CefRefPtr<CefBrowser> browser,
                                        const CefString& url,
                                        bool& allow_os_execution) {
  CEF_REQUIRE_UI_THREAD();

  std::string urlStr = url;

  // Allow OS execution of Spotify URIs.
  if (urlStr.find("spotify:") == 0)
    allow_os_execution = true;
}

bool ClientHandler::OnCertificateError(
    CefRefPtr<CefBrowser> browser,
    ErrorCode cert_error,
    const CefString& request_url,
    CefRefPtr<CefSSLInfo> ssl_info,
    CefRefPtr<CefRequestCallback> callback) {
  CEF_REQUIRE_UI_THREAD();

  CefRefPtr<CefSSLCertPrincipal> subject = ssl_info->GetSubject();
  CefRefPtr<CefSSLCertPrincipal> issuer = ssl_info->GetIssuer();

  // Build a table showing certificate information. Various types of invalid
  // certificates can be tested using https://badssl.com/.
  std::stringstream ss;
  ss << "X.509 Certificate Information:"
        "<table border=1><tr><th>Field</th><th>Value</th></tr>" <<
        "<tr><td>Subject</td><td>" <<
            (subject.get() ? subject->GetDisplayName().ToString() : "&nbsp;") <<
            "</td></tr>"
        "<tr><td>Issuer</td><td>" <<
            (issuer.get() ? issuer->GetDisplayName().ToString() : "&nbsp;") <<
            "</td></tr>"
        "<tr><td>Serial #*</td><td>" <<
            GetBinaryString(ssl_info->GetSerialNumber()) << "</td></tr>"
        "<tr><td>Status</td><td>" <<
            GetCertStatusString(ssl_info->GetCertStatus()) << "</td></tr>"
        "<tr><td>Valid Start</td><td>" <<
            GetTimeString(ssl_info->GetValidStart()) << "</td></tr>"
        "<tr><td>Valid Expiry</td><td>" <<
            GetTimeString(ssl_info->GetValidExpiry()) << "</td></tr>";

  CefSSLInfo::IssuerChainBinaryList der_chain_list;
  CefSSLInfo::IssuerChainBinaryList pem_chain_list;
  ssl_info->GetDEREncodedIssuerChain(der_chain_list);
  ssl_info->GetPEMEncodedIssuerChain(pem_chain_list);
  DCHECK_EQ(der_chain_list.size(), pem_chain_list.size());

  der_chain_list.insert(der_chain_list.begin(), ssl_info->GetDEREncoded());
  pem_chain_list.insert(pem_chain_list.begin(), ssl_info->GetPEMEncoded());

  for (size_t i = 0U; i < der_chain_list.size(); ++i) {
    ss << "<tr><td>DER Encoded*</td>"
          "<td style=\"max-width:800px;overflow:scroll;\">" <<
              GetBinaryString(der_chain_list[i]) << "</td></tr>"
          "<tr><td>PEM Encoded*</td>"
          "<td style=\"max-width:800px;overflow:scroll;\">" <<
              GetBinaryString(pem_chain_list[i]) << "</td></tr>";
  }

  ss << "</table> * Displayed value is base64 encoded.";

  // Load the error page.
  LoadErrorPage(browser->GetMainFrame(), request_url, cert_error, ss.str());

  return false;  // Cancel the request.
}

void ClientHandler::OnRenderProcessTerminated(CefRefPtr<CefBrowser> browser,
                                              TerminationStatus status) {
  CEF_REQUIRE_UI_THREAD();

  message_router_->OnRenderProcessTerminated(browser);

  // Don't reload if there's no start URL, or if the crash URL was specified.
  if (startup_url_.empty() || startup_url_ == "chrome://crash")
    return;

  CefRefPtr<CefFrame> frame = browser->GetMainFrame();
  std::string url = frame->GetURL();

  // Don't reload if the termination occurred before any URL had successfully
  // loaded.
  if (url.empty())
    return;

  std::string start_url = startup_url_;

  // Convert URLs to lowercase for easier comparison.
  std::transform(url.begin(), url.end(), url.begin(), tolower);
  std::transform(start_url.begin(), start_url.end(), start_url.begin(),
                 tolower);

  // Don't reload the URL that just resulted in termination.
  if (url.find(start_url) == 0)
    return;

  frame->LoadURL(startup_url_);
}

int ClientHandler::GetBrowserCount() const {
  CEF_REQUIRE_UI_THREAD();
  return browser_count_;
}

//###_START 6
void ClientHandler::ShowDevTools(CefRefPtr<CefBrowser> browser,
                                 const CefPoint& inspect_element_at) {
  CefWindowInfo windowInfo;
  CefRefPtr<CefClient> client;
//###_FIND_NEXT_LANDMARK 6
  CefBrowserSettings settings;
//###_APPEND_START 6
if (this->mcallback_)
{
//TODO: send cmd to managed side
//create dev window
//send cef client 
this->mcallback_(CEF_MSG_ClientHandler_ShowDevTools, NULL);
}
else {
if (CreatePopupWindow(browser, true, CefPopupFeatures(), windowInfo, client,
settings)) {
browser->GetHost()->ShowDevTools(windowInfo, client, settings,
inspect_element_at);
}
}
//###_APPEND_STOP
//###_SKIP_UNTIL_PASS 6 }
}

//###_START 7
void ClientHandler::CloseDevTools(CefRefPtr<CefBrowser> browser) {
//###_APPEND_START 7
if (this->mcallback_) {
//TODO: send command
this->mcallback_(CEF_MSG_ClientHandler_CloseDevTools, NULL);
}
else {
browser->GetHost()->CloseDevTools();
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 7
}


bool ClientHandler::CreatePopupWindow(
    CefRefPtr<CefBrowser> browser,
    bool is_devtools,
    const CefPopupFeatures& popupFeatures,
    CefWindowInfo& windowInfo,
    CefRefPtr<CefClient>& client,
    CefBrowserSettings& settings) {
  // Note: This method will be called on multiple threads.

  // The popup browser will be parented to a new native window.
  // Don't show URL bar and navigation buttons on DevTools windows.
  MainContext::Get()->GetRootWindowManager()->CreateRootWindowAsPopup(
      !is_devtools, is_osr(), popupFeatures, windowInfo, client, settings);

  return true;
}


//###_START 8
void ClientHandler::NotifyBrowserCreated(CefRefPtr<CefBrowser> browser) {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
//###_FIND_NEXT_LANDMARK 8
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyBrowserCreated, this, browser));
    return;
//###_FIND_NEXT_LANDMARK 8
  }
//###_APPEND_START 8
if (this->mcallback_) {
this->mcallback_(CEF_MSG_ClientHandler_NotifyBrowserCreated, NULL);
}
//###_APPEND_STOP

  if (delegate_)
    delegate_->OnBrowserCreated(browser);
}

void ClientHandler::NotifyBrowserClosing(CefRefPtr<CefBrowser> browser) {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyBrowserClosing, this, browser));
    return;
  }

  if (delegate_)
    delegate_->OnBrowserClosing(browser);
}

//###_START 9
void ClientHandler::NotifyBrowserClosed(CefRefPtr<CefBrowser> browser) {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyBrowserClosed, this, browser));
    return;
  }

  if (delegate_)
//###_FIND_NEXT_LANDMARK 9
    delegate_->OnBrowserClosed(browser);
//###_APPEND_START 9
if (this->mcallback_) {
this->mcallback_(CEF_MSG_ClientHandler_NotifyBrowserClosed, NULL);
}
//###_APPEND_STOP
}

//###_START 11
void ClientHandler::NotifyAddress(const CefString& url) {
//###_FIND_NEXT_LANDMARK 11
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyAddress, this, url));
    return;
//###_FIND_NEXT_LANDMARK 11
  }
//###_APPEND_START 11
if (this->mcallback_ != NULL) {
MethodArgs* metArgs = new MethodArgs();
auto str16 = url.ToString16();
auto cstr = str16.c_str();
metArgs->SetArgAsString(0, cstr);
this->mcallback_(CEF_MSG_ClientHandler_NotifyAddress, metArgs);
delete metArgs;
}
else {
if (delegate_)
delegate_->OnSetAddress(url);
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 11
}

//###_START 10
void ClientHandler::NotifyTitle(const CefString& title) {
//###_FIND_NEXT_LANDMARK 10
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyTitle, this, title));
    return;
//###_FIND_NEXT_LANDMARK 10
  }
//###_APPEND_START 10
if (this->mcallback_ != NULL) {

//alloc on heap , don't forget to delete
MethodArgs* metArgs = new MethodArgs();
auto str16 = title.ToString16();
auto cstr = str16.c_str();
metArgs->SetArgAsString(0, cstr);
this->mcallback_(CEF_MSG_ClientHandler_NotifyTitle, metArgs);
delete metArgs;
}
else {
if (delegate_)
delegate_->OnSetTitle(title);
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 10
}

void ClientHandler::NotifyFullscreen(bool fullscreen) {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyFullscreen, this, fullscreen));
    return;
  }

  if (delegate_)
    delegate_->OnSetFullscreen(fullscreen);
}

void ClientHandler::NotifyLoadingState(bool isLoading,
                                       bool canGoBack,
                                       bool canGoForward) {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyLoadingState, this,
                   isLoading, canGoBack, canGoForward));
    return;
  }

  if (delegate_)
    delegate_->OnSetLoadingState(isLoading, canGoBack, canGoForward);
}

void ClientHandler::NotifyDraggableRegions(
    const std::vector<CefDraggableRegion>& regions) {
  if (!CURRENTLY_ON_MAIN_THREAD()) {
    // Execute this method on the main thread.
    MAIN_POST_CLOSURE(
        base::Bind(&ClientHandler::NotifyDraggableRegions, this, regions));
    return;
  }

  if (delegate_)
    delegate_->OnSetDraggableRegions(regions);
}

void ClientHandler::BuildTestMenu(CefRefPtr<CefMenuModel> model) {
  if (model->GetCount() > 0)
    model->AddSeparator();

  // Build the sub menu.
  CefRefPtr<CefMenuModel> submenu =
      model->AddSubMenu(CLIENT_ID_TESTMENU_SUBMENU, "Context Menu Test");
  submenu->AddCheckItem(CLIENT_ID_TESTMENU_CHECKITEM, "Check Item");
  submenu->AddRadioItem(CLIENT_ID_TESTMENU_RADIOITEM1, "Radio Item 1", 0);
  submenu->AddRadioItem(CLIENT_ID_TESTMENU_RADIOITEM2, "Radio Item 2", 0);
  submenu->AddRadioItem(CLIENT_ID_TESTMENU_RADIOITEM3, "Radio Item 3", 0);

  // Check the check item.
  if (test_menu_state_.check_item)
    submenu->SetChecked(CLIENT_ID_TESTMENU_CHECKITEM, true);

  // Check the selected radio item.
  submenu->SetChecked(
      CLIENT_ID_TESTMENU_RADIOITEM1 + test_menu_state_.radio_item, true);
}

//###_START 10
bool ClientHandler::ExecuteTestMenu(int command_id) {
  if (command_id == CLIENT_ID_TESTMENU_CHECKITEM) {
    // Toggle the check item.
    test_menu_state_.check_item ^= 1;
    return true;
  } else if (command_id >= CLIENT_ID_TESTMENU_RADIOITEM1 &&
             command_id <= CLIENT_ID_TESTMENU_RADIOITEM3) {
    // Store the selected radio item.
    test_menu_state_.radio_item = (command_id - CLIENT_ID_TESTMENU_RADIOITEM1);
    return true;
  }

//###_FIND_NEXT_LANDMARK 10
  // Allow default handling to proceed.
//###_FIND_NEXT_LANDMARK 10
  return false;
//###_FIND_NEXT_LANDMARK 10
}
//###_APPEND_START 10
//my extension ***
void ClientHandler::MyCefSetManagedCallBack(managed_callback m) {

this->mcallback_ = m;
//add resource mx handler

MethodArgs args;
memset(&args, 0, sizeof(MethodArgs));

//get filter function ptr from managed side
args.SetArgAsNativeObject(0, resource_manager_);

m(CEF_MSG_ClientHandler_SetResourceManager, &args);

//1. add url filter
//2. add resource provider
client::test_runner::SetupResourceManager2(resource_manager_, m);
}
void ClientHandler::MyCefEnableKeyIntercept(int enable) {
this->enableKeyIntercept = enable;
}
//###_APPEND_STOP

}  // namespace client
