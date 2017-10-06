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
// $hash=5e273b65a19f371ad2fa5073c38dd6ad7a2c40d5$
//

#include "libcef_dll/ctocpp/request_context_ctocpp.h"
#include "libcef_dll/cpptoc/completion_callback_cpptoc.h"
#include "libcef_dll/cpptoc/request_context_handler_cpptoc.h"
#include "libcef_dll/cpptoc/resolve_callback_cpptoc.h"
#include "libcef_dll/cpptoc/scheme_handler_factory_cpptoc.h"
#include "libcef_dll/ctocpp/cookie_manager_ctocpp.h"
#include "libcef_dll/ctocpp/dictionary_value_ctocpp.h"
#include "libcef_dll/ctocpp/value_ctocpp.h"
#include "libcef_dll/transfer_util.h"

// STATIC METHODS - Body may be edited by hand.

CefRefPtr<CefRequestContext> CefRequestContext::GetGlobalContext() {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  cef_request_context_t* _retval = cef_request_context_get_global_context();

  // Return type: refptr_same
  return CefRequestContextCToCpp::Wrap(_retval);
}

CefRefPtr<CefRequestContext> CefRequestContext::CreateContext(
    const CefRequestContextSettings& settings,
    CefRefPtr<CefRequestContextHandler> handler) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Unverified params: handler

  // Execute
  cef_request_context_t* _retval = cef_request_context_create_context(
      &settings, CefRequestContextHandlerCppToC::Wrap(handler));

  // Return type: refptr_same
  return CefRequestContextCToCpp::Wrap(_retval);
}

CefRefPtr<CefRequestContext> CefRequestContext::CreateContext(
    CefRefPtr<CefRequestContext> other,
    CefRefPtr<CefRequestContextHandler> handler) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: other; type: refptr_same
  DCHECK(other.get());
  if (!other.get())
    return NULL;
  // Unverified params: handler

  // Execute
  cef_request_context_t* _retval =
      cef_create_context_shared(CefRequestContextCToCpp::Unwrap(other),
                                CefRequestContextHandlerCppToC::Wrap(handler));

  // Return type: refptr_same
  return CefRequestContextCToCpp::Wrap(_retval);
}

// VIRTUAL METHODS - Body may be edited by hand.

bool CefRequestContextCToCpp::IsSame(CefRefPtr<CefRequestContext> other) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, is_same))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: other; type: refptr_same
  DCHECK(other.get());
  if (!other.get())
    return false;

  // Execute
  int _retval =
      _struct->is_same(_struct, CefRequestContextCToCpp::Unwrap(other));

  // Return type: bool
  return _retval ? true : false;
}

bool CefRequestContextCToCpp::IsSharingWith(
    CefRefPtr<CefRequestContext> other) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, is_sharing_with))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: other; type: refptr_same
  DCHECK(other.get());
  if (!other.get())
    return false;

  // Execute
  int _retval =
      _struct->is_sharing_with(_struct, CefRequestContextCToCpp::Unwrap(other));

  // Return type: bool
  return _retval ? true : false;
}

bool CefRequestContextCToCpp::IsGlobal() {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, is_global))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  int _retval = _struct->is_global(_struct);

  // Return type: bool
  return _retval ? true : false;
}

CefRefPtr<CefRequestContextHandler> CefRequestContextCToCpp::GetHandler() {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, get_handler))
    return NULL;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  cef_request_context_handler_t* _retval = _struct->get_handler(_struct);

  // Return type: refptr_diff
  return CefRequestContextHandlerCppToC::Unwrap(_retval);
}

CefString CefRequestContextCToCpp::GetCachePath() {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, get_cache_path))
    return CefString();

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  cef_string_userfree_t _retval = _struct->get_cache_path(_struct);

  // Return type: string
  CefString _retvalStr;
  _retvalStr.AttachToUserFree(_retval);
  return _retvalStr;
}

CefRefPtr<CefCookieManager> CefRequestContextCToCpp::GetDefaultCookieManager(
    CefRefPtr<CefCompletionCallback> callback) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, get_default_cookie_manager))
    return NULL;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Unverified params: callback

  // Execute
  cef_cookie_manager_t* _retval = _struct->get_default_cookie_manager(
      _struct, CefCompletionCallbackCppToC::Wrap(callback));

  // Return type: refptr_same
  return CefCookieManagerCToCpp::Wrap(_retval);
}

bool CefRequestContextCToCpp::RegisterSchemeHandlerFactory(
    const CefString& scheme_name,
    const CefString& domain_name,
    CefRefPtr<CefSchemeHandlerFactory> factory) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, register_scheme_handler_factory))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: scheme_name; type: string_byref_const
  DCHECK(!scheme_name.empty());
  if (scheme_name.empty())
    return false;
  // Unverified params: domain_name, factory

  // Execute
  int _retval = _struct->register_scheme_handler_factory(
      _struct, scheme_name.GetStruct(), domain_name.GetStruct(),
      CefSchemeHandlerFactoryCppToC::Wrap(factory));

  // Return type: bool
  return _retval ? true : false;
}

bool CefRequestContextCToCpp::ClearSchemeHandlerFactories() {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, clear_scheme_handler_factories))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  int _retval = _struct->clear_scheme_handler_factories(_struct);

  // Return type: bool
  return _retval ? true : false;
}

void CefRequestContextCToCpp::PurgePluginListCache(bool reload_pages) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, purge_plugin_list_cache))
    return;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  _struct->purge_plugin_list_cache(_struct, reload_pages);
}

bool CefRequestContextCToCpp::HasPreference(const CefString& name) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, has_preference))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: name; type: string_byref_const
  DCHECK(!name.empty());
  if (name.empty())
    return false;

  // Execute
  int _retval = _struct->has_preference(_struct, name.GetStruct());

  // Return type: bool
  return _retval ? true : false;
}

CefRefPtr<CefValue> CefRequestContextCToCpp::GetPreference(
    const CefString& name) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, get_preference))
    return NULL;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: name; type: string_byref_const
  DCHECK(!name.empty());
  if (name.empty())
    return NULL;

  // Execute
  cef_value_t* _retval = _struct->get_preference(_struct, name.GetStruct());

  // Return type: refptr_same
  return CefValueCToCpp::Wrap(_retval);
}

CefRefPtr<CefDictionaryValue> CefRequestContextCToCpp::GetAllPreferences(
    bool include_defaults) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, get_all_preferences))
    return NULL;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Execute
  cef_dictionary_value_t* _retval =
      _struct->get_all_preferences(_struct, include_defaults);

  // Return type: refptr_same
  return CefDictionaryValueCToCpp::Wrap(_retval);
}

bool CefRequestContextCToCpp::CanSetPreference(const CefString& name) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, can_set_preference))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: name; type: string_byref_const
  DCHECK(!name.empty());
  if (name.empty())
    return false;

  // Execute
  int _retval = _struct->can_set_preference(_struct, name.GetStruct());

  // Return type: bool
  return _retval ? true : false;
}

bool CefRequestContextCToCpp::SetPreference(const CefString& name,
                                            CefRefPtr<CefValue> value,
                                            CefString& error) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, set_preference))
    return false;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: name; type: string_byref_const
  DCHECK(!name.empty());
  if (name.empty())
    return false;
  // Unverified params: value

  // Execute
  int _retval = _struct->set_preference(_struct, name.GetStruct(),
                                        CefValueCToCpp::Unwrap(value),
                                        error.GetWritableStruct());

  // Return type: bool
  return _retval ? true : false;
}

void CefRequestContextCToCpp::ClearCertificateExceptions(
    CefRefPtr<CefCompletionCallback> callback) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, clear_certificate_exceptions))
    return;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Unverified params: callback

  // Execute
  _struct->clear_certificate_exceptions(
      _struct, CefCompletionCallbackCppToC::Wrap(callback));
}

void CefRequestContextCToCpp::CloseAllConnections(
    CefRefPtr<CefCompletionCallback> callback) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, close_all_connections))
    return;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Unverified params: callback

  // Execute
  _struct->close_all_connections(_struct,
                                 CefCompletionCallbackCppToC::Wrap(callback));
}

void CefRequestContextCToCpp::ResolveHost(
    const CefString& origin,
    CefRefPtr<CefResolveCallback> callback) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, resolve_host))
    return;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: origin; type: string_byref_const
  DCHECK(!origin.empty());
  if (origin.empty())
    return;
  // Verify param: callback; type: refptr_diff
  DCHECK(callback.get());
  if (!callback.get())
    return;

  // Execute
  _struct->resolve_host(_struct, origin.GetStruct(),
                        CefResolveCallbackCppToC::Wrap(callback));
}

cef_errorcode_t CefRequestContextCToCpp::ResolveHostCached(
    const CefString& origin,
    std::vector<CefString>& resolved_ips) {
  cef_request_context_t* _struct = GetStruct();
  if (CEF_MEMBER_MISSING(_struct, resolve_host_cached))
    return ERR_FAILED;

  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  // Verify param: origin; type: string_byref_const
  DCHECK(!origin.empty());
  if (origin.empty())
    return ERR_FAILED;

  // Translate param: resolved_ips; type: string_vec_byref
  cef_string_list_t resolved_ipsList = cef_string_list_alloc();
  DCHECK(resolved_ipsList);
  if (resolved_ipsList)
    transfer_string_list_contents(resolved_ips, resolved_ipsList);

  // Execute
  cef_errorcode_t _retval = _struct->resolve_host_cached(
      _struct, origin.GetStruct(), resolved_ipsList);

  // Restore param:resolved_ips; type: string_vec_byref
  if (resolved_ipsList) {
    resolved_ips.clear();
    transfer_string_list_contents(resolved_ipsList, resolved_ips);
    cef_string_list_free(resolved_ipsList);
  }

  // Return type: simple
  return _retval;
}

// CONSTRUCTOR - Do not edit by hand.

CefRequestContextCToCpp::CefRequestContextCToCpp() {}

template <>
cef_request_context_t* CefCToCppRefCounted<
    CefRequestContextCToCpp,
    CefRequestContext,
    cef_request_context_t>::UnwrapDerived(CefWrapperType type,
                                          CefRequestContext* c) {
  NOTREACHED() << "Unexpected class type: " << type;
  return NULL;
}

#if DCHECK_IS_ON()
template <>
base::AtomicRefCount CefCToCppRefCounted<CefRequestContextCToCpp,
                                         CefRequestContext,
                                         cef_request_context_t>::DebugObjCt = 0;
#endif

template <>
CefWrapperType CefCToCppRefCounted<CefRequestContextCToCpp,
                                   CefRequestContext,
                                   cef_request_context_t>::kWrapperType =
    WT_REQUEST_CONTEXT;
