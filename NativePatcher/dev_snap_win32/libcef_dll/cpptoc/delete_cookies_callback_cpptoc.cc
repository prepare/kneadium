//---THIS-FILE-WAS-PATCHED , org=D:\projects\cef_binary_3.3071.1647.win32\cpptoc\delete_cookies_callback_cpptoc.cc
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
// $hash=f17a9939eba29ab59060b3198e6041ff582a42a8$
//

#include "libcef_dll/cpptoc/delete_cookies_callback_cpptoc.h"

//---kneadium-ext-begin
#include "../myext/ExportFuncAuto.h"
#include "../myext/InternalHeaderForExportFunc.h"
//---kneadium-ext-end

namespace {

// MEMBER FUNCTIONS - Body may be edited by hand.

void CEF_CALLBACK
delete_cookies_callback_on_complete(struct _cef_delete_cookies_callback_t* self,
                                    int num_deleted) {
  // AUTO-GENERATED CONTENT - DELETE THIS COMMENT BEFORE MODIFYING

  DCHECK(self);
  if (!self)
    return;

//---kneadium-ext-begin34
#if ENABLE_KNEADIUM_EXT
auto me = CefDeleteCookiesCallbackCppToC::Get(self);
const int CALLER_CODE=(CefDeleteCookiesCallbackExt::_typeName << 16) | CefDeleteCookiesCallbackExt::CefDeleteCookiesCallbackExt_OnComplete_1;
auto m_callback= me->GetManagedCallBack(CALLER_CODE);
if(m_callback){
CefDeleteCookiesCallbackExt::OnCompleteArgs args1(num_deleted);
m_callback(CALLER_CODE, &args1.arg);
 if (((args1.arg.myext_flags >> 21) & 1) == 1){
return;
}
}
#endif
//---kneadium-ext-end

  // Execute
  CefDeleteCookiesCallbackCppToC::Get(self)->OnComplete(num_deleted);
}

}  // namespace

// CONSTRUCTOR - Do not edit by hand.

CefDeleteCookiesCallbackCppToC::CefDeleteCookiesCallbackCppToC() {
  GetStruct()->on_complete = delete_cookies_callback_on_complete;
}

template <>
CefRefPtr<CefDeleteCookiesCallback> CefCppToCRefCounted<
    CefDeleteCookiesCallbackCppToC,
    CefDeleteCookiesCallback,
    cef_delete_cookies_callback_t>::UnwrapDerived(CefWrapperType type,
                                                  cef_delete_cookies_callback_t*
                                                      s) {
  NOTREACHED() << "Unexpected class type: " << type;
  return NULL;
}

#if DCHECK_IS_ON()
template <>
base::AtomicRefCount
    CefCppToCRefCounted<CefDeleteCookiesCallbackCppToC,
                        CefDeleteCookiesCallback,
                        cef_delete_cookies_callback_t>::DebugObjCt = 0;
#endif

template <>
CefWrapperType
    CefCppToCRefCounted<CefDeleteCookiesCallbackCppToC,
                        CefDeleteCookiesCallback,
                        cef_delete_cookies_callback_t>::kWrapperType =
        WT_DELETE_COOKIES_CALLBACK;
