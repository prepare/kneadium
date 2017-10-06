//###_ORIGINAL D:\projects\cef_binary_3.3071.1647.win64\tests\cefclient\browser//binding_test.cc
// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "tests/cefclient/browser/binding_test.h"

#include <algorithm>
#include <string>

namespace client {
namespace binding_test {

//###_BEGIN
#include "tests/cefclient/myext/mycef_buildconfig.h"
#if BUILD_TEST
//###_END

namespace {

const char kTestUrl[] = "http://tests/binding";
const char kTestMessageName[] = "BindingTest";

// Handle messages in the browser process.
class Handler : public CefMessageRouterBrowserSide::Handler {
 public:
  Handler() {}

  // Called due to cefQuery execution in binding.html.
  virtual bool OnQuery(CefRefPtr<CefBrowser> browser,
                       CefRefPtr<CefFrame> frame,
                       int64 query_id,
                       const CefString& request,
                       bool persistent,
                       CefRefPtr<Callback> callback) OVERRIDE {
    // Only handle messages from the test URL.
    const std::string& url = frame->GetURL();
    if (url.find(kTestUrl) != 0)
      return false;

    const std::string& message_name = request;
    if (message_name.find(kTestMessageName) == 0) {
      // Reverse the string and return.
      std::string result = message_name.substr(sizeof(kTestMessageName));
      std::reverse(result.begin(), result.end());
      callback->Success(result);
      return true;
    }

    return false;
  }
};

}  // namespace

void CreateMessageHandlers(test_runner::MessageHandlerSet& handlers) {
  handlers.insert(new Handler());
}

//###_BEGIN
#else
void CreateMessageHandlers(test_runner::MessageHandlerSet& handlers) {
//blank
}
#endif //BUILD_TEST
//###_END

}  // namespace binding_test
}  // namespace client
