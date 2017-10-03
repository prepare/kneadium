//---THIS-FILE-WAS-PATCHED , org=D:\projects\cef_binary_3.3071.1647.win32\cpptoc\render_process_handler_cpptoc.cc
// Copyright (c) 2017 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.
//
// ---------------------------------------------------------------------------
//
// This file was generated by the CEF translator tool. If making changes by
// hand only do so within the body of existing method and function
// implementations. See the translator.README.txt file in the tools directory
// for more information.
//
// $hash=983c18727fdd4116f5b98eb9d1921d58f1511c76$
//

#include "libcef_dll/cpptoc/render_process_handler_cpptoc.h"
#include "libcef_dll/cpptoc/load_handler_cpptoc.h"
#include "libcef_dll/ctocpp/browser_ctocpp.h"
#include "libcef_dll/ctocpp/domnode_ctocpp.h"
#include "libcef_dll/ctocpp/frame_ctocpp.h"
#include "libcef_dll/ctocpp/list_value_ctocpp.h"
#include "libcef_dll/ctocpp/process_message_ctocpp.h"
#include "libcef_dll/ctocpp/request_ctocpp.h"
#include "libcef_dll/ctocpp/v8context_ctocpp.h"
#include "libcef_dll/ctocpp/v8exception_ctocpp.h"
#include "libcef_dll/ctocpp/v8stack_trace_ctocpp.h"

//---kneadium-ext-begin
#include "../myext/ExportFuncAuto.h"
#include "../myext/InternalHeaderForExportFunc.h"
//---kneadium-ext-end

namespace {

// MEMBER FUNCTIONS - Body may be edited by hand.

void CEF_CALLBACK render_process_handler_on_render_thread_created(
    struct _cef_render_process_handler_t* self,
    struct _cef_list_value_t* extra_info) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: extra_info; type: refptr_diff
  DCHECK(extra_info);
  if (!extra_info)
    return;

//---kneadium-ext-begin115
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnRenderThreadCreated_1;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnRenderThreadCreatedArgs args1(extra_info);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnRenderThreadCreated(
      CefListValueCToCpp::Wrap(extra_info));
}

void CEF_CALLBACK render_process_handler_on_web_kit_initialized(
    struct _cef_render_process_handler_t* self) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;

//---kneadium-ext-begin114
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnWebKitInitialized_2;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnWebKitInitializedArgs args1;
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnWebKitInitialized();
}

void CEF_CALLBACK render_process_handler_on_browser_created(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return;

//---kneadium-ext-begin113
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnBrowserCreated_3;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnBrowserCreatedArgs args1(browser);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnBrowserCreated(
      CefBrowserCToCpp::Wrap(browser));
}

void CEF_CALLBACK render_process_handler_on_browser_destroyed(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return;

//---kneadium-ext-begin112
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnBrowserDestroyed_4;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnBrowserDestroyedArgs args1(browser);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnBrowserDestroyed(
      CefBrowserCToCpp::Wrap(browser));
}

cef_load_handler_t* CEF_CALLBACK render_process_handler_get_load_handler(
    struct _cef_render_process_handler_t* self) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return NULL;

//---kneadium-ext-begin111
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_GetLoadHandler_5;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::GetLoadHandlerArgs args1;
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
 return CefLoadHandlerCppToC::Wrap(args1.arg.myext_ret_value);
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRefPtr<CefLoadHandler> _retval =
      CefRenderProcessHandlerCppToC::Get(self)->GetLoadHandler();

  // Return type: refptr_same
  return CefLoadHandlerCppToC::Wrap(_retval);
}

int CEF_CALLBACK render_process_handler_on_before_navigation(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser,
    cef_frame_t* frame,
    struct _cef_request_t* request,
    cef_navigation_type_t navigation_type,
    int is_redirect) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return 0;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return 0;
  // Verify param: frame; type: refptr_diff
  DCHECK(frame);
  if (!frame)
    return 0;
  // Verify param: request; type: refptr_diff
  DCHECK(request);
  if (!request)
    return 0;

//---kneadium-ext-begin110
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnBeforeNavigation_6;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnBeforeNavigationArgs args1(browser,frame,request,navigation_type,is_redirect);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
 return args1.arg.myext_ret_value;
}
}
#endif
//---kneadium-ext-end

  // Execute
  bool _retval = CefRenderProcessHandlerCppToC::Get(self)->OnBeforeNavigation(
      CefBrowserCToCpp::Wrap(browser), CefFrameCToCpp::Wrap(frame),
      CefRequestCToCpp::Wrap(request), navigation_type,
      is_redirect ? true : false);

  // Return type: bool
  return _retval;
}

void CEF_CALLBACK render_process_handler_on_context_created(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser,
    cef_frame_t* frame,
    struct _cef_v8context_t* context) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return;
  // Verify param: frame; type: refptr_diff
  DCHECK(frame);
  if (!frame)
    return;
  // Verify param: context; type: refptr_diff
  DCHECK(context);
  if (!context)
    return;

//---kneadium-ext-begin109
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnContextCreated_7;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnContextCreatedArgs args1(browser,frame,context);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnContextCreated(
      CefBrowserCToCpp::Wrap(browser), CefFrameCToCpp::Wrap(frame),
      CefV8ContextCToCpp::Wrap(context));
}

void CEF_CALLBACK render_process_handler_on_context_released(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser,
    cef_frame_t* frame,
    struct _cef_v8context_t* context) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return;
  // Verify param: frame; type: refptr_diff
  DCHECK(frame);
  if (!frame)
    return;
  // Verify param: context; type: refptr_diff
  DCHECK(context);
  if (!context)
    return;

//---kneadium-ext-begin108
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnContextReleased_8;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnContextReleasedArgs args1(browser,frame,context);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnContextReleased(
      CefBrowserCToCpp::Wrap(browser), CefFrameCToCpp::Wrap(frame),
      CefV8ContextCToCpp::Wrap(context));
}

void CEF_CALLBACK render_process_handler_on_uncaught_exception(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser,
    cef_frame_t* frame,
    struct _cef_v8context_t* context,
    struct _cef_v8exception_t* exception,
    struct _cef_v8stack_trace_t* stackTrace) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return;
  // Verify param: frame; type: refptr_diff
  DCHECK(frame);
  if (!frame)
    return;
  // Verify param: context; type: refptr_diff
  DCHECK(context);
  if (!context)
    return;
  // Verify param: exception; type: refptr_diff
  DCHECK(exception);
  if (!exception)
    return;
  // Verify param: stackTrace; type: refptr_diff
  DCHECK(stackTrace);
  if (!stackTrace)
    return;

//---kneadium-ext-begin107
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnUncaughtException_9;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnUncaughtExceptionArgs args1(browser,frame,context,exception,stackTrace);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnUncaughtException(
      CefBrowserCToCpp::Wrap(browser), CefFrameCToCpp::Wrap(frame),
      CefV8ContextCToCpp::Wrap(context), CefV8ExceptionCToCpp::Wrap(exception),
      CefV8StackTraceCToCpp::Wrap(stackTrace));
}

void CEF_CALLBACK render_process_handler_on_focused_node_changed(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser,
    cef_frame_t* frame,
    cef_domnode_t* node) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return;
  // Unverified params: frame, node

//---kneadium-ext-begin106
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnFocusedNodeChanged_10;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnFocusedNodeChangedArgs args1(browser,frame,node);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefRenderProcessHandlerCppToC::Get(self)->OnFocusedNodeChanged(
      CefBrowserCToCpp::Wrap(browser), CefFrameCToCpp::Wrap(frame),
      CefDOMNodeCToCpp::Wrap(node));
}

int CEF_CALLBACK render_process_handler_on_process_message_received(
    struct _cef_render_process_handler_t* self,
    cef_browser_t* browser,
    cef_process_id_t source_process,
    cef_process_message_t* message) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return 0;
  // Verify param: browser; type: refptr_diff
  DCHECK(browser);
  if (!browser)
    return 0;
  // Verify param: message; type: refptr_diff
  DCHECK(message);
  if (!message)
    return 0;

//---kneadium-ext-begin105
#if ENABLE_KNEADIUM_EXT
auto me = CefRenderProcessHandlerCppToC::Get(self);
const int CALLER_CODE=(CefRenderProcessHandlerExt::_typeName << 16) | CefRenderProcessHandlerExt::CefRenderProcessHandlerExt_OnProcessMessageReceived_11;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefRenderProcessHandlerExt::OnProcessMessageReceivedArgs args1(browser,source_process,message);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
 return args1.arg.myext_ret_value;
}
}
#endif
//---kneadium-ext-end

  // Execute
  bool _retval =
      CefRenderProcessHandlerCppToC::Get(self)->OnProcessMessageReceived(
          CefBrowserCToCpp::Wrap(browser), source_process,
          CefProcessMessageCToCpp::Wrap(message));

  // Return type: bool
  return _retval;
}

}  // namespace

// CONSTRUCTOR - Do not edit by hand.

CefRenderProcessHandlerCppToC::CefRenderProcessHandlerCppToC() {
  GetStruct()->on_render_thread_created =
      render_process_handler_on_render_thread_created;
  GetStruct()->on_web_kit_initialized =
      render_process_handler_on_web_kit_initialized;
  GetStruct()->on_browser_created = render_process_handler_on_browser_created;
  GetStruct()->on_browser_destroyed =
      render_process_handler_on_browser_destroyed;
  GetStruct()->get_load_handler = render_process_handler_get_load_handler;
  GetStruct()->on_before_navigation =
      render_process_handler_on_before_navigation;
  GetStruct()->on_context_created = render_process_handler_on_context_created;
  GetStruct()->on_context_released = render_process_handler_on_context_released;
  GetStruct()->on_uncaught_exception =
      render_process_handler_on_uncaught_exception;
  GetStruct()->on_focused_node_changed =
      render_process_handler_on_focused_node_changed;
  GetStruct()->on_process_message_received =
      render_process_handler_on_process_message_received;
}

template <>
CefRefPtr<CefRenderProcessHandler> CefCppToCRefCounted<
    CefRenderProcessHandlerCppToC,
    CefRenderProcessHandler,
    cef_render_process_handler_t>::UnwrapDerived(CefWrapperType type,
                                                 cef_render_process_handler_t*
                                                     s) {
  NOTREACHED() << "Unexpected class type: " << type;
  return NULL;
}

#if DCHECK_IS_ON()
template <>
base::AtomicRefCount
    CefCppToCRefCounted<CefRenderProcessHandlerCppToC,
                        CefRenderProcessHandler,
                        cef_render_process_handler_t>::DebugObjCt = 0;
#endif

template <>
CefWrapperType CefCppToCRefCounted<CefRenderProcessHandlerCppToC,
                                   CefRenderProcessHandler,
                                   cef_render_process_handler_t>::kWrapperType =
    WT_RENDER_PROCESS_HANDLER;
