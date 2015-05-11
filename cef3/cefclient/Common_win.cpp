//#include "Common_win.h"
//void ModifyZoom(CefRefPtr<CefBrowser> browser, double delta)
//{
//  if (CefCurrentlyOn(TID_UI)) {
//    browser->GetHost()->SetZoomLevel(
//        browser->GetHost()->GetZoomLevel() + delta);
//  } else {
//    CefPostTask(TID_UI, NewCefRunnableFunction(ModifyZoom, browser, delta));
//  }
//}
//
////=================================================================================