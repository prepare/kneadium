//###_ORIGINAL D:\projects\cef_binary_3.3626.1882.win32\tests\cefclient\renderer//client_app_delegates_renderer.cc
// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "tests/cefclient/renderer/client_renderer.h"
#include "tests/cefclient/renderer/performance_test.h"
#include "tests/shared/renderer/client_app_renderer.h"

//###_BEGIN
#include "tests/shared/renderer/client_app_renderer.h" 
#include "tests/cefclient/myext/mycef_buildconfig.h"
#include "libcef_dll/myext/ExportFuncAuto.h"
//###_END

namespace client {

// static
void ClientAppRenderer::CreateDelegates(DelegateSet& delegates) {
  renderer::CreateDelegates(delegates);
//###_BEGIN
class MyCefRenderDelegate : public ClientAppRenderer::Delegate {
public:
MyCefRenderDelegate() {}

virtual void OnContextCreated(CefRefPtr<ClientAppRenderer> app,
CefRefPtr<CefBrowser> browser,
CefRefPtr<CefFrame> frame,
CefRefPtr<CefV8Context> context) OVERRIDE{

if (app->myMxCallback_) {
CefRenderProcessHandlerExt::OnContextCreated(app->myMxCallback_, browser, frame, context);
}
}
virtual void OnWebKitInitialized(CefRefPtr<ClientAppRenderer> app) {
if (app->myMxCallback_) {
CefRenderProcessHandlerExt::OnWebKitInitialized(app->myMxCallback_);
}
}
virtual void OnContextReleased(CefRefPtr<ClientAppRenderer> app,
CefRefPtr<CefBrowser> browser,
CefRefPtr<CefFrame> frame,
CefRefPtr<CefV8Context> context) {
if (app->myMxCallback_){
CefRenderProcessHandlerExt::OnContextReleased(app->myMxCallback_, browser, frame, context); 
}
}
private:
IMPLEMENT_REFCOUNTING(MyCefRenderDelegate);
};

delegates.insert(new MyCefRenderDelegate);

#if BUILD_TEST
//###_END

  performance_test::CreateDelegates(delegates);
//###_BEGIN
#endif //BUILD_TEST
//###_END

}

}  // namespace client
