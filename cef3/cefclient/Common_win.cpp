#include "Common_win.h" 
extern CefRefPtr<ClientHandler> g_handler;

// Change the zoom factor on the UI thread.
void ModifyZoom(CefRefPtr<CefBrowser> browser, double delta) {
  if (!CefCurrentlyOn(TID_UI)) {
    // Execute on the UI thread.
    CefPostTask(TID_UI, base::Bind(&ModifyZoom, browser, delta));
    return;
  }

  browser->GetHost()->SetZoomLevel(
      browser->GetHost()->GetZoomLevel() + delta);
}

// Show a warning message on the UI thread.
void ShowWarning(CefRefPtr<CefBrowser> browser, int id) {
  if (!CefCurrentlyOn(TID_UI)) {
    // Execute on the UI thread.
    CefPostTask(TID_UI, base::Bind(&ShowWarning, browser, id));
    return;
  }

  if (!g_handler)
    return;

  std::wstring caption;
  std::wstringstream message;

  switch (id) {
    case ID_WARN_CONSOLEMESSAGE:
      caption = L"Console Messages";
      message << L"Console messages will be written to " <<
              std::wstring(CefString(g_handler->GetLogFile()));
      break;
    case ID_WARN_DOWNLOADCOMPLETE:
    case ID_WARN_DOWNLOADERROR:
      caption = L"File Download";
      message << L"File \"" <<
              std::wstring(CefString(g_handler->GetLastDownloadFile())) <<
              L"\" ";

      if (id == ID_WARN_DOWNLOADCOMPLETE)
        message << L"downloaded successfully.";
      else
        message << L"failed to download.";
      break;
  }

  MessageBox(g_handler->GetMainWindowHandle(),
             message.str().c_str(),
             caption.c_str(),
             MB_OK | MB_ICONINFORMATION);
}

// Set focus to |browser| on the UI thread.
void SetFocusToBrowser(CefRefPtr<CefBrowser> browser) {
  if (!CefCurrentlyOn(TID_UI)) {
    // Execute on the UI thread.
    CefPostTask(TID_UI, base::Bind(&SetFocusToBrowser, browser));
    return;
  }

  if (!g_handler)
    return;

  if (AppIsOffScreenRenderingEnabled()) {
    // Give focus to the OSR window.
    CefRefPtr<OSRWindow> osr_window =
        static_cast<OSRWindow*>(g_handler->GetOSRHandler().get());
    if (osr_window)
      ::SetFocus(osr_window->hwnd());
  } else {
    // Give focus to the browser.
    browser->GetHost()->SetFocus(true);
  }
}
