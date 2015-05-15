// Copyright (c) 2011 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "cefclient/client_handler.h" 
#include <string>
#include <windows.h>
#include <shlobj.h> 

#include "include/cef_browser.h"
#include "include/cef_frame.h"
#include "cefclient/resource.h"

<<<<<<< HEAD
//my extension
#include "ExportFuncs.h"

void ClientHandler::OnAddressChange(CefRefPtr<CefBrowser> browser,
                                    CefRefPtr<CefFrame> frame,
                                    const CefString& url)
{
  REQUIRE_UI_THREAD();  

  if(HasManagedNotify())
  {		
		
	  if (m_BrowserId == browser->GetIdentifier() && frame->IsMain())   {

		  ManagedNotify(
			  MYCEF_BROWSER_URL_CHANGED,
			  url.ToWString().c_str());
	  }
  }
  //if(m_EditHwnd)
  //{    
	 // if (m_BrowserId == browser->GetIdentifier() && frame->IsMain())   {
		//// Set the edit window text
		//SetWindowText(m_EditHwnd, std::wstring(url).c_str());
	 // }
=======


void ClientHandler::OnAddressChange(CefRefPtr<CefBrowser> browser,
                                    CefRefPtr<CefFrame> frame,
                                    const CefString& url) {
  CEF_REQUIRE_UI_THREAD();

  //if (GetBrowserId() == browser->GetIdentifier() && frame->IsMain()) {
  //  // Set the edit window text
  //  SetWindowText(edit_handle_, std::wstring(url).c_str());
>>>>>>> origin/retro1
  //}
}

void ClientHandler::OnTitleChange(CefRefPtr<CefBrowser> browser,
                                  const CefString& title) {
<<<<<<< HEAD
  REQUIRE_UI_THREAD();
  
  if(HasManagedNotify())
  {	
	  if (m_BrowserId == browser->GetIdentifier())   {
		   ManagedNotify(
			  MYCEF_BROWSER_TITLE_CHANGED,
			  title.ToWString().c_str()); 
	  }
  }
  //// Set the frame window title bar
  //CefWindowHandle hwnd = browser->GetHost()->GetWindowHandle();
  //if (m_BrowserId == browser->GetIdentifier())   {
=======
  CEF_REQUIRE_UI_THREAD();

  //// Set the frame window title bar
  //CefWindowHandle hwnd = browser->GetHost()->GetWindowHandle();
  //if (GetBrowserId() == browser->GetIdentifier()) {
>>>>>>> origin/retro1
  //  // The frame window will be the parent of the browser window
  //  hwnd = GetParent(hwnd);
  //}
  //SetWindowText(hwnd, std::wstring(title).c_str());
}

void ClientHandler::SendNotification(NotificationType type) {
  
<<<<<<< HEAD
  if(HasManagedNotify())
  {	  
	  switch (type) {
	  case NOTIFY_CONSOLE_MESSAGE:
		ManagedNotify(
			  MYCEF_BROWSER_SEND_NOTIFICATION,
			  L"console msg"); 
		break;
	  case NOTIFY_DOWNLOAD_COMPLETE:
		ManagedNotify(
			  MYCEF_BROWSER_SEND_NOTIFICATION,
			  L"download complete"); 
		break;
	  case NOTIFY_DOWNLOAD_ERROR:
		ManagedNotify(
			  MYCEF_BROWSER_SEND_NOTIFICATION,
			   L"download error"); 
		break;
	  default:
		return;
	  }
	  
  }
 /* UINT id;
=======
  UINT id;
>>>>>>> origin/retro1
  switch (type) {
  case NOTIFY_CONSOLE_MESSAGE:
    id = ID_WARN_CONSOLEMESSAGE;
    break;
  case NOTIFY_DOWNLOAD_COMPLETE:
    id = ID_WARN_DOWNLOADCOMPLETE;
    break;
  case NOTIFY_DOWNLOAD_ERROR:
    id = ID_WARN_DOWNLOADERROR;
    break;
  default:
    return;
  }
<<<<<<< HEAD
  PostMessage(m_MainHwnd, WM_COMMAND, id, 0);*/
}

void ClientHandler::SetLoading(bool isLoading) {

  // comment out 
 //ASSERT(m_EditHwnd != NULL && m_ReloadHwnd != NULL && m_StopHwnd != NULL);
  //EnableWindow(m_EditHwnd, TRUE);
  // comment out
  //EnableWindow(m_ReloadHwnd, !isLoading);
  //EnableWindow(m_StopHwnd, isLoading);
}

void ClientHandler::SetNavState(bool canGoBack, bool canGoForward) {
  // comment out
  //ASSERT(m_BackHwnd != NULL && m_ForwardHwnd != NULL);
  //EnableWindow(m_BackHwnd, canGoBack);
  //EnableWindow(m_ForwardHwnd, canGoForward);
=======
  PostMessage(main_handle_, WM_COMMAND, id, 0);


}

void ClientHandler::SetLoading(bool isLoading) {
  /*DCHECK(edit_handle_ != NULL && reload_handle_ != NULL &&
         stop_handle_ != NULL);*/
  DCHECK(edit_handle_ != NULL);

  EnableWindow(edit_handle_, TRUE);
  EnableWindow(reload_handle_, !isLoading);
  EnableWindow(stop_handle_, isLoading);
}

void ClientHandler::SetNavState(bool canGoBack, bool canGoForward) {
  /*DCHECK(back_handle_ != NULL && forward_handle_ != NULL);
  EnableWindow(back_handle_, canGoBack);
  EnableWindow(forward_handle_, canGoForward);*/
>>>>>>> origin/retro1
}

std::string ClientHandler::GetDownloadPath(const std::string& file_name) {

  TCHAR szFolderPath[MAX_PATH];
  std::string path;

  
  // Save the file in the user's "My Documents" folder.
  if (SUCCEEDED(SHGetFolderPath(NULL, CSIDL_PERSONAL | CSIDL_FLAG_CREATE,
                                NULL, 0, szFolderPath))) {
    path = CefString(szFolderPath);
    path += "\\" + file_name;
  } 
  return path;
}
