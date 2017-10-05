//###_ORIGINAL D:\projects\cef_binary_3.3071.1647.win32\tests\cefclient//cefclient_win.cc
// Copyright (c) 2015 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include <windows.h>

//###_BEGIN
#include "tests/cefclient/myext/mycef_buildconfig.h"
#include "myext/mycef.h"
#if BUILD_TEST_ROOT_WINDOW
//###_END

#include "include/base/cef_scoped_ptr.h"
#include "include/cef_command_line.h"
#include "include/cef_sandbox_win.h"
#include "tests/cefclient/browser/main_context_impl.h"
#include "tests/cefclient/browser/main_message_loop_multithreaded_win.h"
#include "tests/cefclient/browser/root_window_manager.h"
#include "tests/cefclient/browser/test_runner.h"
#include "tests/shared/browser/client_app_browser.h"
#include "tests/shared/browser/main_message_loop_external_pump.h"
#include "tests/shared/browser/main_message_loop_std.h"
#include "tests/shared/common/client_app_other.h"
#include "tests/shared/common/client_switches.h"
#include "tests/shared/renderer/client_app_renderer.h"

// When generating projects with CMake the CEF_USE_SANDBOX value will be defined
// automatically if using the required compiler version. Pass -DUSE_SANDBOX=OFF
// to the CMake command-line to disable use of the sandbox.
// Uncomment this line to manually enable sandbox support.
// #define CEF_USE_SANDBOX 1

#if defined(CEF_USE_SANDBOX)
// The cef_sandbox.lib static library is currently built with VS2015. It may not
// link successfully with other VS versions.
#pragma comment(lib, "cef_sandbox.lib")
#endif

namespace client {
namespace {

int RunMain(HINSTANCE hInstance, int nCmdShow) {
  // Enable High-DPI support on Windows 7 or newer.
  CefEnableHighDPISupport();

  CefMainArgs main_args(hInstance);

  void* sandbox_info = NULL;

#if defined(CEF_USE_SANDBOX)
  // Manage the life span of the sandbox information object. This is necessary
  // for sandbox support on Windows. See cef_sandbox_win.h for complete details.
  CefScopedSandboxInfo scoped_sandbox;
  sandbox_info = scoped_sandbox.sandbox_info();
#endif

  // Parse command-line arguments.
  CefRefPtr<CefCommandLine> command_line = CefCommandLine::CreateCommandLine();
  command_line->InitFromString(::GetCommandLineW());

  // Create a ClientApp of the correct type.
  CefRefPtr<CefApp> app;
  ClientApp::ProcessType process_type = ClientApp::GetProcessType(command_line);
  if (process_type == ClientApp::BrowserProcess)
    app = new ClientAppBrowser();
  else if (process_type == ClientApp::RendererProcess)
    app = new ClientAppRenderer();
  else if (process_type == ClientApp::OtherProcess)
    app = new ClientAppOther();

  // Execute the secondary process, if any.
  int exit_code = CefExecuteProcess(main_args, app, sandbox_info);
  if (exit_code >= 0)
    return exit_code;

  // Create the main context object.
  scoped_ptr<MainContextImpl> context(new MainContextImpl(command_line, true));

  CefSettings settings;

#if !defined(CEF_USE_SANDBOX)
  settings.no_sandbox = true;
#endif

  // Populate the settings based on command line arguments.
  context->PopulateSettings(&settings);

  // Create the main message loop object.
  scoped_ptr<MainMessageLoop> message_loop;
  if (settings.multi_threaded_message_loop)
    message_loop.reset(new MainMessageLoopMultithreadedWin);
  else if (settings.external_message_pump)
    message_loop = MainMessageLoopExternalPump::Create();
  else
    message_loop.reset(new MainMessageLoopStd);

  // Initialize CEF.
  context->Initialize(main_args, settings, app, sandbox_info);

  // Register scheme handlers.
  test_runner::RegisterSchemeHandlers();

  // Create the first window.
  context->GetRootWindowManager()->CreateRootWindow(
      !command_line->HasSwitch(switches::kHideControls),  // Show controls.
      settings.windowless_rendering_enabled ? true : false,
      CefRect(),       // Use default system size.
      std::string());  // Use default URL.

  // Run the message loop. This will block until Quit() is called by the
  // RootWindowManager after all windows have been destroyed.
  int result = message_loop->Run();

  // Shut down CEF.
  context->Shutdown();

  // Release objects in reverse order of creation.
  message_loop.reset();
  context.reset();

  return result;
}

}  // namespace
}  // namespace client

//###_BEGIN
void MyCefStringGetRawPtr1(void* cefstring, char16** outputBuffer, int* actualLength) {
CefString* cefStr = (CefString*)cefstring;
*actualLength = (int)cefStr->length();
*outputBuffer = (char16*)cefStr->c_str();;
}
void TestSetArgs(MyMetArgsN* metArgs) {
jsvalue* a1 = &metArgs->vargs[1];
char16* tmpArr = NULL;
int actualLen = 0; 
MyCefStringGetRawPtr1((void*)a1->ptr, &tmpArr, &actualLen);
}
//###_END

// Program entry point function.
int APIENTRY wWinMain(HINSTANCE hInstance,
                      HINSTANCE hPrevInstance,
                      LPTSTR lpCmdLine,
                      int nCmdShow) {
  UNREFERENCED_PARAMETER(hPrevInstance);
  UNREFERENCED_PARAMETER(lpCmdLine);
//###_BEGIN
//simple test args
INIT_MY_MET_ARGS(args, 1);
std::string tt = "hello!";
CefString t2 = tt;
SetCefStringToJsValue2(&vargs[1], t2);
TestSetArgs(&args);
//###_END

  return client::RunMain(hInstance, nCmdShow);
}
//###_BEGIN
#endif //BUILD_TEST
//###_END

