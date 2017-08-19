//###_ORIGINAL D:\projects\cef_binary_3.3071.1647.win32\tests\cefclient\browser//root_window_manager.h
// Copyright (c) 2015 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#ifndef CEF_TESTS_CEFCLIENT_BROWSER_ROOT_WINDOW_MANAGER_H_
#define CEF_TESTS_CEFCLIENT_BROWSER_ROOT_WINDOW_MANAGER_H_
#pragma once

#include <set>

#include "include/base/cef_scoped_ptr.h"
#include "include/cef_command_line.h"
#include "tests/cefclient/browser/root_window.h"
//###_START 0
#include "tests/cefclient/browser/temp_window.h"
//###_APPEND_START 0
#include "tests/cefclient/myext/mycef.h"
//###_APPEND_STOP

namespace client {

// Used to create/manage RootWindow instances. The methods of this class can be
// called from any browser process thread unless otherwise indicated.
class RootWindowManager : public RootWindow::Delegate {
 public:
  // If |terminate_when_all_windows_closed| is true quit the main message loop
  // after all windows have closed.
  explicit RootWindowManager(bool terminate_when_all_windows_closed);

  // Create a new top-level native window that loads |url|.
  // If |with_controls| is true the window will show controls.
  // If |with_osr| is true the window will use off-screen rendering.
  // If |bounds| is empty the default window size and location will be used.
  // This method can be called from anywhere to create a new top-level window.
  scoped_refptr<RootWindow> CreateRootWindow(bool with_controls,
                                             bool with_osr,
                                             const CefRect& bounds,
                                             const std::string& url);

  // Create a new native popup window.
  // If |with_controls| is true the window will show controls.
  // If |with_osr| is true the window will use off-screen rendering.
  // This method is called from ClientHandler::CreatePopupWindow() to
  // create a new popup or DevTools window.
  scoped_refptr<RootWindow> CreateRootWindowAsPopup(
      bool with_controls,
      bool with_osr,
      const CefPopupFeatures& popupFeatures,
      CefWindowInfo& windowInfo,
      CefRefPtr<CefClient>& client,
      CefBrowserSettings& settings);

  // Returns the RootWindow associated with the specified browser ID. Must be
  // called on the main thread.
  scoped_refptr<RootWindow> GetWindowForBrowser(int browser_id);

//###_START 1
  // Close all existing windows. If |force| is true onunload handlers will not
  // be executed.
//###_FIND_NEXT_LANDMARK 1
  void CloseAllWindows(bool force);
//###_APPEND_START 1
//my extension --for callback to managed side
managed_callback myMxCallback_;
//###_APPEND_STOP

 private:
  // Allow deletion via scoped_ptr only.
  friend struct base::DefaultDeleter<RootWindowManager>;

  ~RootWindowManager();

  void OnRootWindowCreated(scoped_refptr<RootWindow> root_window);

  // RootWindow::Delegate methods.
  CefRefPtr<CefRequestContext> GetRequestContext(
      RootWindow* root_window) OVERRIDE;
  CefRefPtr<CefImage> GetDefaultWindowIcon() OVERRIDE;
  void OnTest(RootWindow* root_window, int test_id) OVERRIDE;
  void OnExit(RootWindow* root_window) OVERRIDE;
  void OnRootWindowDestroyed(RootWindow* root_window) OVERRIDE;

  const bool terminate_when_all_windows_closed_;
  bool request_context_per_browser_;
  bool request_context_shared_cache_;

  // Existing root windows. Only accessed on the main thread.
  typedef std::set<scoped_refptr<RootWindow>> RootWindowSet;
  RootWindowSet root_windows_;

  // Singleton window used as the temporary parent for popup browsers.
  TempWindow temp_window_;

  CefRefPtr<CefRequestContext> shared_request_context_;
  CefRefPtr<CefImage> default_window_icon_;

  DISALLOW_COPY_AND_ASSIGN(RootWindowManager);
};

}  // namespace client

#endif  // CEF_TESTS_CEFCLIENT_BROWSER_ROOT_WINDOW_MANAGER_H_
