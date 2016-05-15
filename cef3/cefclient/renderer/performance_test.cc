//###_ORIGINAL D:\projects\cef_binary_3.2623.1399\cefclient\renderer//performance_test.cc
// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "cefclient/renderer/performance_test.h"

#include <algorithm>
#include <string>

#include "include/wrapper/cef_stream_resource_handler.h"
#include "cefclient/renderer/performance_test_setup.h"

namespace client {
namespace performance_test {

// Use more interations for a Release build.
#ifdef NDEBUG
const int kDefaultIterations = 100000;
#else
const int kDefaultIterations = 10000;
#endif

namespace {

const char kGetPerfTests[] = "GetPerfTests";
const char kRunPerfTest[] = "RunPerfTest";
const char kPerfTestReturnValue[] = "PerfTestReturnValue";

class V8Handler : public CefV8Handler {
 public:
  V8Handler() {
  }

  virtual bool Execute(const CefString& name,
                       CefRefPtr<CefV8Value> object,
                       const CefV8ValueList& arguments,
                       CefRefPtr<CefV8Value>& retval,
                       CefString& exception) OVERRIDE {
    if (name == kRunPerfTest) {
      if (arguments.size() == 1 && arguments[0]->IsString()) {
        // Run the specified perf test.
        bool found = false;

        std::string test = arguments[0]->GetStringValue();
        for (int i = 0; i < kPerfTestsCount; ++i) {
          if (test == kPerfTests[i].name) {
            // Execute the test.
            int64 delta = kPerfTests[i].test(kPerfTests[i].iterations);

            retval = CefV8Value::CreateInt(delta);
            found = true;
            break;
          }
        }

        if (!found) {
          std::string msg = "Unknown test: ";
          msg.append(test);
          exception = msg;
        }
      } else {
        exception = "Invalid function parameters";
      }
    } else if (name == kGetPerfTests) {
      // Retrieve the list of perf tests.
      retval = CefV8Value::CreateArray(kPerfTestsCount);
      for (int i = 0; i < kPerfTestsCount; ++i) {
        CefRefPtr<CefV8Value> val = CefV8Value::CreateArray(2);
        val->SetValue(0, CefV8Value::CreateString(kPerfTests[i].name));
        val->SetValue(1, CefV8Value::CreateUInt(kPerfTests[i].iterations));
        retval->SetValue(i, val);
      }
    } else if (name == kPerfTestReturnValue) {
      if (arguments.size() == 0) {
        retval = CefV8Value::CreateInt(1);
      } else if (arguments.size() == 1 && arguments[0]->IsInt()) {
        int32 type = arguments[0]->GetIntValue();
        CefTime date;
        switch (type) {
          case 0:
            retval = CefV8Value::CreateUndefined();
            break;
          case 1:
            retval = CefV8Value::CreateNull();
            break;
          case 2:
            retval = CefV8Value::CreateBool(true);
            break;
          case 3:
            retval = CefV8Value::CreateInt(1);
            break;
          case 4:
            retval = CefV8Value::CreateUInt(1);
            break;
          case 5:
            retval = CefV8Value::CreateDouble(1.234);
            break;
          case 6:
            date.Now();
            retval = CefV8Value::CreateDate(date);
            break;
          case 7:
            retval = CefV8Value::CreateString("Hello, world!");
            break;
          case 8:
            retval = CefV8Value::CreateObject(NULL);
            break;
          case 9:
            retval = CefV8Value::CreateArray(8);
            break;
          case 10:
            // retval = CefV8Value::CreateFunction(...);
            exception = "Not implemented";
            break;
          default:
            exception = "Not supported";
        }
      }
    }

    return true;
  }

 private:
  IMPLEMENT_REFCOUNTING(V8Handler);
};

// Handle bindings in the render process.
//###_START 7
class RenderDelegate : public ClientAppRenderer::Delegate {
 public:
//###_FIND_NEXT_LANDMARK 7
  RenderDelegate() {
//###_FIND_NEXT_LANDMARK 7
  }
//###_APPEND_START 7
virtual void OnWebKitInitialized(CefRefPtr<ClientAppRenderer> app) { 
if (app->myMxCallback_) {
MethodArgs* metArgs = new MethodArgs();
metArgs->SetArgAsNativeObject(0, app.get());
app->myMxCallback_(CEF_MSG_RenderDelegate_OnWebKitInitialized, metArgs);
delete metArgs;
} 
}
virtual void OnContextReleased(CefRefPtr<ClientAppRenderer> app,
CefRefPtr<CefBrowser> browser,
CefRefPtr<CefFrame> frame,
CefRefPtr<CefV8Context> context) {
if (app->myMxCallback_)
{
//expose all to managed side
//browser,frame and context ?  
MethodArgs* metArgs = new MethodArgs();
metArgs->SetArgAsNativeObject(0, app.get());
metArgs->SetArgAsNativeObject(1, browser.get());
metArgs->SetArgAsNativeObject(2, frame.get());


metArgs->SetArgAsNativeObject(3, context.get());

app->myMxCallback_(CEF_MSG_RenderDelegate_OnContextReleased, metArgs);
delete metArgs;
}
}
//###_APPEND_STOP

//###_START 0
  virtual void OnContextCreated(CefRefPtr<ClientAppRenderer> app,
                                CefRefPtr<CefBrowser> browser,
                                CefRefPtr<CefFrame> frame,
//###_FIND_NEXT_LANDMARK 0
                                CefRefPtr<CefV8Context> context) OVERRIDE {
//###_APPEND_START 0
if (app->myMxCallback_)
{
//expose all to managed side
//browser,frame and context ?  
MethodArgs* metArgs = new MethodArgs();
metArgs->SetArgAsNativeObject(0, app.get());
metArgs->SetArgAsNativeObject(1, browser.get());
metArgs->SetArgAsNativeObject(2, frame.get());
context->AddRef();
metArgs->SetArgAsNativeObject(3, context.get());

app->myMxCallback_(CEF_MSG_RenderDelegate_OnContextCreated, metArgs);
delete metArgs;
}
else {

//MessageBox(0, L"context-created:mx callback is not set", L"context-created:mx callback is not set", 0);
//single handler for 3 external methods

CefRefPtr<CefV8Value> object = context->GetGlobal();
CefRefPtr<CefV8Handler> handler = new V8Handler();

// Bind test functions.
object->SetValue(kGetPerfTests,
CefV8Value::CreateFunction(kGetPerfTests, handler),
V8_PROPERTY_ATTRIBUTE_READONLY);
object->SetValue(kRunPerfTest,
CefV8Value::CreateFunction(kRunPerfTest, handler),
V8_PROPERTY_ATTRIBUTE_READONLY);
object->SetValue(kPerfTestReturnValue,
CefV8Value::CreateFunction(kPerfTestReturnValue, handler),
V8_PROPERTY_ATTRIBUTE_READONLY);
}
//###_APPEND_STOP
//###_SKIP_UNTIL_AND_ACCEPT 0
  }

 private:
  IMPLEMENT_REFCOUNTING(RenderDelegate);
};

}  // namespace

void CreateDelegates(ClientAppRenderer::DelegateSet& delegates) {
  delegates.insert(new RenderDelegate);
}

}  // namespace performance_test
}  // namespace client
