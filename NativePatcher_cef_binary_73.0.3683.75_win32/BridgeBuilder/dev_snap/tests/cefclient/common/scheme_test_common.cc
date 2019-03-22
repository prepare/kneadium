// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "tests/cefclient/common/scheme_test_common.h"

#include "include/cef_scheme.h"

//###_BEGIN
#include "tests/cefclient/myext/mycef_buildconfig.h"

//###_END
namespace client {
namespace scheme_test {


#if BUILD_TEST
void RegisterCustomSchemes(CefRawPtr<CefSchemeRegistrar> registrar,
                           std::vector<CefString>& cookiable_schemes) {
  registrar->AddCustomScheme(
      "client", CEF_SCHEME_OPTION_STANDARD | CEF_SCHEME_OPTION_CORS_ENABLED);
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


 