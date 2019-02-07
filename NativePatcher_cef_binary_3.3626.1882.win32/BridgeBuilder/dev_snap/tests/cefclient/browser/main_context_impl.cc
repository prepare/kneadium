//###_ORIGINAL D:\projects\cef_binary_3.3626.1882.win32\tests\cefclient\browser//main_context_impl.cc
// Copyright (c) 2015 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "tests/cefclient/browser/main_context_impl.h"

#include "include/cef_parser.h"
#include "include/cef_web_plugin.h"
#include "tests/shared/common/client_switches.h"

//###_BEGIN
#include "tests/cefclient/myext/ExportFuncs.h"
#include "tests/cefclient/myext/mycef_msg_const.h"
//###_END

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
      background_color_(0),
      browser_background_color_(0),
      windowless_frame_rate_(0),
      use_views_(false) {
  DCHECK(command_line_.get());

  // Set the main URL.
  if (command_line_->HasSwitch(switches::kUrl))
    main_url_ = command_line_->GetSwitchValue(switches::kUrl);
//###_START 3
  if (main_url_.empty())
//###_APPEND_START 3
{
main_url_ = kDefaultUrl;
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 3
  use_windowless_rendering_ =
      command_line_->HasSwitch(switches::kOffScreenRenderingEnabled);

  if (use_windowless_rendering_ &&
      command_line_->HasSwitch(switches::kOffScreenFrameRate)) {
    windowless_frame_rate_ =
        atoi(command_line_->GetSwitchValue(switches::kOffScreenFrameRate)
                 .ToString()
                 .c_str());
  }

  // Whether transparent painting is used with windowless rendering.
  const bool use_transparent_painting =
      use_windowless_rendering_ &&
      command_line_->HasSwitch(switches::kTransparentPaintingEnabled);

#if defined(OS_WIN)
  // Shared texture is only supported on Windows.
  shared_texture_enabled_ =
      use_windowless_rendering_ &&
      command_line_->HasSwitch(switches::kSharedTextureEnabled);
#endif

  external_begin_frame_enabled_ =
      use_windowless_rendering_ &&
      command_line_->HasSwitch(switches::kExternalBeginFrameEnabled);

  if (windowless_frame_rate_ <= 0) {
// Choose a reasonable default rate based on the OSR mode.
#if defined(OS_WIN)
    windowless_frame_rate_ = shared_texture_enabled_ ? 60 : 30;
#else
    windowless_frame_rate_ = 30;
#endif
  }

#if defined(OS_WIN) || defined(OS_LINUX)
  // Whether the Views framework will be used.
  use_views_ = command_line_->HasSwitch(switches::kUseViews);

  if (use_windowless_rendering_ && use_views_) {
    LOG(ERROR)
        << "Windowless rendering is not supported by the Views framework.";
    use_views_ = false;
  }

  if (use_views_ && command_line->HasSwitch(switches::kHideFrame) &&
      !command_line_->HasSwitch(switches::kUrl)) {
    // Use the draggable regions test as the default URL for frameless windows.
    main_url_ = "http://tests/draggable";
  }
#endif  // defined(OS_WIN) || defined(OS_LINUX)

//###_START 4
  if (command_line_->HasSwitch(switches::kBackgroundColor)) {
//###_APPEND_START 4
//background_color_ =
//ParseColor(command_line_->GetSwitchValue(switches::kBackgroundColor));
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 4
  }

  if (background_color_ == 0 && !use_views_) {
    // Set an explicit background color.
    background_color_ = CefColorSetARGB(255, 255, 255, 255);
  }

  // |browser_background_color_| should remain 0 to enable transparent painting.
  if (!use_transparent_painting) {
    browser_background_color_ = background_color_;
  }

  const std::string& cdm_path =
      command_line_->GetSwitchValue(switches::kWidevineCdmPath);
  if (!cdm_path.empty()) {
    // Register the Widevine CDM at the specified path. See comments in
    // cef_web_plugin.h for details. It's safe to call this method before
    // CefInitialize(), and calling it before CefInitialize() is required on
    // Linux.
    CefRegisterWidevineCdm(cdm_path, NULL);
  }
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

INIT_MY_MET_ARGS(metArgs, 0)
this->myMxCallback_(CEF_MSG_MainContext_GetConsoleLogPath, &metArgs);

auto bufferHolder = GetBufferHolder(&vargs[0]);
std::string str = std::string(bufferHolder->buffer);
//delete bufferHolder;
return str;
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
#if defined(OS_WIN) || defined(OS_LINUX)
  settings->multi_threaded_message_loop =
      command_line_->HasSwitch(switches::kMultiThreadedMessageLoop);
#endif

  if (!settings->multi_threaded_message_loop) {
    settings->external_message_pump =
        command_line_->HasSwitch(switches::kExternalMessagePump);
  }

  CefString(&settings->cache_path) =
      command_line_->GetSwitchValue(switches::kCachePath);

  if (use_windowless_rendering_)
    settings->windowless_rendering_enabled = true;

  if (browser_background_color_ != 0)
    settings->background_color = browser_background_color_;
}

void MainContextImpl::PopulateBrowserSettings(CefBrowserSettings* settings) {
  settings->windowless_frame_rate = windowless_frame_rate_;

  if (browser_background_color_ != 0)
    settings->background_color = browser_background_color_;
}

void MainContextImpl::PopulateOsrSettings(OsrRendererSettings* settings) {
  settings->show_update_rect =
      command_line_->HasSwitch(switches::kShowUpdateRect);

#if defined(OS_WIN)
  settings->shared_texture_enabled = shared_texture_enabled_;
#endif
  settings->external_begin_frame_enabled = external_begin_frame_enabled_;
  settings->begin_frame_rate = windowless_frame_rate_;

  if (browser_background_color_ != 0)
    settings->background_color = browser_background_color_;
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
