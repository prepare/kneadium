//###_ORIGINAL D:\projects\cef_binary_3.3071.1647.win32\tests\cefclient\renderer//client_app_delegates_renderer.cc
// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "tests/cefclient/renderer/client_renderer.h"
#include "tests/cefclient/renderer/performance_test.h"
#include "tests/shared/renderer/client_app_renderer.h"

//###_BEGIN
#include "tests/cefclient/myext/mycef_buildconfig.h"
//###_END

namespace client {

// static
void ClientAppRenderer::CreateDelegates(DelegateSet& delegates) {
  renderer::CreateDelegates(delegates);
//###_BEGIN
#if BUILD_TEST

//###_END

  performance_test::CreateDelegates(delegates);
//###_BEGIN
#endif //BUILD_TEST
//###_END

}

}  // namespace client
