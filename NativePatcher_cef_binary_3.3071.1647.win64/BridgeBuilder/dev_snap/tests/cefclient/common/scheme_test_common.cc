//###_ORIGINAL D:\projects\cef_binary_3.3071.1647.win64\tests\cefclient\common//scheme_test_common.cc
// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "tests/cefclient/common/scheme_test_common.h"

#include "include/cef_scheme.h"

namespace client {
namespace scheme_test {

//###_BEGIN
#include "tests/cefclient/myext/mycef_buildconfig.h"
#if BUILD_TEST
//###_END

void RegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar,
                           std::vector<CefString>& cookiable_schemes) {
  registrar->AddCustomScheme("client", true, false, false, false, true, false);
}

//###_BEGIN
#else

void RegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar,
std::vector<CefString>& cookiable_schemes) {

}

#endif //BUILD_TEST
//###_END

}  // namespace scheme_test
}  // namespace client
