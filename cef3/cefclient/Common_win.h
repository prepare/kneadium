// Change the zoom factor on the UI thread.
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

#include "include/base/cef_bind.h"
#include "include/cef_app.h"
#include "include/cef_browser.h"
#include "include/cef_frame.h"
#include "include/cef_sandbox_win.h"
#include "include/wrapper/cef_closure_task.h"
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
void ModifyZoom(CefRefPtr<CefBrowser> browser, double delta); 
void ShowWarning(CefRefPtr<CefBrowser> browser, int id);
void SetFocusToBrowser(CefRefPtr<CefBrowser> browser);