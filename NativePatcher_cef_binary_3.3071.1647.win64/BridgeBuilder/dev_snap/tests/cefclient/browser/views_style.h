//###_ORIGINAL D:\projects\cef_binary_3.3071.1647.win64\tests\cefclient\browser//views_style.h
// Copyright (c) 2017 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#ifndef CEF_TESTS_CEFCLIENT_BROWSER_VIEWS_STYLE_H_
#define CEF_TESTS_CEFCLIENT_BROWSER_VIEWS_STYLE_H_
#pragma once

#include "include/cef_menu_model.h"
#include "include/views/cef_label_button.h"
#include "include/views/cef_panel.h"
#include "include/views/cef_textfield.h"

namespace client {

namespace views_style {

//###_BEGIN
#include "tests/cefclient/myext/mycef_buildconfig.h"
#if BUILD_TEST_ROOT_WINDOW
//###_END

// Returns true if a style is set.
bool IsSet();

// Apply style to views objects.
void ApplyTo(CefRefPtr<CefPanel> panel);
void ApplyTo(CefRefPtr<CefLabelButton> label_button);
void ApplyTo(CefRefPtr<CefTextfield> textfield);
void ApplyTo(CefRefPtr<CefMenuModel> menu_model);

//###_BEGIN
#endif 
//###_END

}  // namespace views_style

}  // namespace client

#endif  // CEF_TESTS_CEFCLIENT_BROWSER_VIEWS_STYLE_H_
