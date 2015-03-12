// Copyright (c) 2013 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "cefclient/cefclient.h"
#include <windows.h>
#include <commdlg.h>
#include <shellapi.h>
#include <direct.h>
#include <sstream>
#include <string>
#include "include/cef_app.h"
#include "include/cef_browser.h"
#include "include/cef_frame.h"
#include "include/cef_runnable.h"
#include "cefclient/cefclient_osr_widget_win.h"
#include "cefclient/client_handler.h"
#include "cefclient/client_switches.h"
#include "cefclient/resource.h"
#include "cefclient/scheme_test.h"
#include "cefclient/string_util.h"

//--------------------------------------
// 
#include "CommonModule.h"
#include "ExportFuncs.h"
#include "Common_win.h"
//--------------------------------------
//
#define MAX_LOADSTRING 100
//#define MAX_URL_LENGTH  255
//#define BUTTON_WIDTH 72
//#define URLBAR_HEIGHT  24  

extern HINSTANCE hInst; 
extern TCHAR szOSRWindowClass[MAX_LOADSTRING];

class MainBrowserProvider : public OSRBrowserProvider {
  
public: 
  CefRefPtr<ClientHandler> my_g_handler; 
  virtual CefRefPtr<CefBrowser> GetBrowser() {
     if (my_g_handler.get())
      return my_g_handler->GetBrowser(); 
    return NULL;
  }
} g_main_browser_provider;

// Global functions 
void AppQuitMessageLoop() {
  CefRefPtr<CefCommandLine> command_line = AppGetCommandLine();
  if (command_line->HasSwitch(cefclient::kMultiThreadedMessageLoop)) {
    // Running in multi-threaded message loop mode. Need to execute
    // PostQuitMessage on the main application thread.
    ///ASSERT(hMessageWnd);
    //PostMessage(hMessageWnd, WM_COMMAND, ID_QUIT, 0);
  } else {
    CefQuitMessageLoop();
  }
} 
//=================================================================================
//my extension
void MyCefSetupWindowsBegin(ClientHandler* cefClientHandler, HWND hWndParent)
{ 
	ClientHandler* g_handler2 = (ClientHandler*)cefClientHandler;
	g_handler2->SetMainHwnd(hWndParent);
}
 
//my extension
void MyCefSetupWindowsEnd(ClientHandler* cefClientHandler,HWND hWndParent,int x,int y,int width,int height)
{	   
      
      RECT rect;	  
      rect.left = x;
      rect.top = y;
      rect.right  =  x+ width;
      rect.bottom = y+ height; 

      CefRefPtr<ClientHandler> g_handler2 = (ClientHandler*)cefClientHandler;

      // Create the single static handler class instance 
      CefWindowInfo windowInfo;
      CefBrowserSettings settings;
      if (AppIsOffScreenRenderingEnabled()) {

        CefRefPtr<CefCommandLine> cmd_line = AppGetCommandLine();
        bool transparent =
            cmd_line->HasSwitch(cefclient::kTransparentPaintingEnabled);
		g_main_browser_provider.my_g_handler = g_handler2;
        CefRefPtr<OSRWindow> osr_window =
            OSRWindow::Create(&g_main_browser_provider, transparent);


        osr_window->CreateWidget(hWndParent, rect, hInst, szOSRWindowClass);
        windowInfo.SetAsOffScreen(osr_window->hwnd());
        windowInfo.SetTransparentPainting(transparent ? TRUE : FALSE);
        g_handler2->SetOSRHandler(osr_window.get());

      } else {
         // Initialize window info to the defaults for a child window.
         windowInfo.SetAsChild(hWndParent, rect);
      }

      // Creat the new child browser window
      bool result= CefBrowserHost::CreateBrowser(windowInfo, g_handler2.get(),
          g_handler2->GetStartupURL(), settings);
      //------------------------ 

      if(result)
      {
          CefString ccstr= CefString(g_handler2->GetStartupURL());	  
          ManagedCallBack(0, ccstr.ToWString().c_str() ); 
      }
      else
      {
          ManagedCallBack(1,L"OKOK-F");
      }
      //------------------------
}
void MyCefCloseHandler(ClientHandler* cefClientHandler)
{	


}