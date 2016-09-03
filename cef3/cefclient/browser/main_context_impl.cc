//###_ORIGINAL D:\projects\cef_binary_3.2785.1466\cefclient\browser//main_context_impl.cc
// Copyright (c) 2015 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "cefclient/browser/main_context_impl.h"

#include "include/cef_parser.h"
//###_START 0
#include "cefclient/common/client_switches.h"
//###_APPEND_START 0
#include "cefclient/myext/ExportFuncs.h"
#include "cefclient/myext/mycef_msg_const.h"
//###_APPEND_STOP

namespace client {

namespace {

//###_START 1
// The default URL to load in a browser window.
//###_APPEND_START 1
const char kDefaultUrl[] = "about:blank";
//const char kDefaultUrl[] = "http://www.google.com";
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 1
}  // namespace

MainContextImpl::MainContextImpl(CefRefPtr<CefCommandLine> command_line,
                                 bool terminate_when_all_windows_closed)
    : command_line_(command_line),
      terminate_when_all_windows_closed_(terminate_when_all_windows_closed),
      initialized_(false),
      shutdown_(false),
      background_color_(CefColorSetARGB(255, 255, 255, 255)),
      use_views_(false) {
  DCHECK(command_line_.get());

  // Set the main URL.
  if (command_line_->HasSwitch(switches::kUrl))
    main_url_ = command_line_->GetSwitchValue(switches::kUrl);
//###_START 3
  if (main_url_.empty()){
//###_APPEND_START 3
main_url_ = kDefaultUrl;
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 3
  }

  // Whether windowless (off-screen) rendering will be used.
  use_windowless_rendering_ =
      command_line_->HasSwitch(switches::kOffScreenRenderingEnabled);

#if defined(OS_WIN) || defined(OS_LINUX)
  // Whether the Views framework will be used.
  use_views_ = command_line_->HasSwitch(switches::kUseViews);

  if (use_windowless_rendering_ && use_views_) {
    LOG(ERROR) <<
        "Windowless rendering is not supported by the Views framework.";
    use_views_ = false;
  }

  if (use_views_ && command_line->HasSwitch(switches::kHideFrame) &&
      !command_line_->HasSwitch(switches::kUrl)) {
    // Use the draggable regions test as the default URL for frameless windows.
    main_url_ = "http://tests/draggable";
  }
#endif  // defined(OS_WIN) || defined(OS_LINUX)
}

MainContextImpl::~MainContextImpl() {
  // The context must either not have been initialized, or it must have also
  // been shut down.
  DCHECK(!initialized_ || shutdown_);
}

//###_START 2
std::string MainContextImpl::GetConsoleLogPath() {
//###_APPEND_START 2
if (this->myMxCallback_) {

MethodArgs args; 
memset(&args, 0, sizeof(MethodArgs));
this->myMxCallback_(CEF_MSG_MainContext_GetConsoleLogPath, &args);
CefString cefStr(args.ReadOutputAsString(0));
return cefStr;
}
else {
return GetAppWorkingDirectory() + "console.log";
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 2
}

std::string MainContextImpl::GetMainURL() {
  return main_url_;
}

cef_color_t MainContextImpl::GetBackgroundColor() {
  return background_color_;
}

bool MainContextImpl::UseViews() {
  return use_views_;
}

bool MainContextImpl::UseWindowlessRendering() {
  return use_windowless_rendering_;
}

void MainContextImpl::PopulateSettings(CefSettings* settings) {
#if defined(OS_WIN)
  settings->multi_threaded_message_loop =
      command_line_->HasSwitch(switches::kMultiThreadedMessageLoop);
#endif

  if (!settings->multi_threaded_message_loop) {
     settings->external_message_pump =
        command_line_->HasSwitch(switches::kExternalMessagePump); 
	 // settings->external_message_pump = 1;
  }

  CefString(&settings->cache_path) =
      command_line_->GetSwitchValue(switches::kCachePath);

  if (use_windowless_rendering_)
    settings->windowless_rendering_enabled = true;

//###_START 1
  settings->background_color = background_color_;
//###_APPEND_START 1
if (this->myMxCallback_) {
this->myMxCallback_(CEF_MSG_CefSettings_Init,settings);
}
//###_APPEND_STOP
}

void MainContextImpl::PopulateBrowserSettings(CefBrowserSettings* settings) {
  if (command_line_->HasSwitch(switches::kOffScreenFrameRate)) {
    settings->windowless_frame_rate = atoi(command_line_->
        GetSwitchValue(switches::kOffScreenFrameRate).ToString().c_str());
  }
}

void MainContextImpl::PopulateOsrSettings(OsrRenderer::Settings* settings) {
  settings->transparent =
      command_line_->HasSwitch(switches::kTransparentPaintingEnabled);
  settings->show_update_rect =
      command_line_->HasSwitch(switches::kShowUpdateRect);
  settings->background_color = background_color_;
}

RootWindowManager* MainContextImpl::GetRootWindowManager() {
  DCHECK(InValidState());
  return root_window_manager_.get();
}

bool MainContextImpl::Initialize(const CefMainArgs& args,
                                 const CefSettings& settings,
                                 CefRefPtr<CefApp> application,
                                 void* windows_sandbox_info) {
  DCHECK(thread_checker_.CalledOnValidThread());
  DCHECK(!initialized_);
  DCHECK(!shutdown_);

  if (!CefInitialize(args, settings, application, windows_sandbox_info))
    return false;

  // Need to create the RootWindowManager after calling CefInitialize because
  // TempWindowX11 uses cef_get_xdisplay().
  root_window_manager_.reset(
      new RootWindowManager(terminate_when_all_windows_closed_));

  initialized_ = true;

  return true;
}

void MainContextImpl::Shutdown() {
  DCHECK(thread_checker_.CalledOnValidThread());
  DCHECK(initialized_);
  DCHECK(!shutdown_);

  root_window_manager_.reset();

  CefShutdown();

  shutdown_ = true;
}

}  // namespace client
