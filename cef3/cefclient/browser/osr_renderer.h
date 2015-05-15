// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license
// that can be found in the LICENSE file.

#ifndef CEF_TESTS_CEFCLIENT_BROWSER_OSR_RENDERER_H_
#define CEF_TESTS_CEFCLIENT_BROWSER_OSR_RENDERER_H_
#pragma once

#include "include/cef_browser.h"
#include "include/cef_render_handler.h"

namespace client {

class OsrRenderer {
 public:
<<<<<<< HEAD:cef3/cefclient/browser/osr_renderer.h
<<<<<<< HEAD:cef3/cefclient/osrenderer.h
  ClientOSRenderer(bool transparent,
                   bool show_update_rect);
  virtual ~ClientOSRenderer();
=======
=======
>>>>>>> origin/s01_t1:cef3/cefclient/browser/osr_renderer.h
  struct Settings {
    Settings();

    // If true use transparent rendering.
    bool transparent;

    // If true draw a border around update rectangles.
    bool show_update_rect;

    // Background color.
    cef_color_t background_color;
  };

  explicit OsrRenderer(const Settings& settings);
  ~OsrRenderer();
<<<<<<< HEAD:cef3/cefclient/browser/osr_renderer.h
>>>>>>> origin/3.2357.1267:cef3/cefclient/browser/osr_renderer.h
=======
>>>>>>> origin/s01_t1:cef3/cefclient/browser/osr_renderer.h

  // Initialize the OpenGL environment.
  void Initialize();

  // Clean up the OpenGL environment.
  void Cleanup();

  // Render to the screen.
  void Render();

  // Forwarded from CefRenderHandler callbacks.
  void OnPopupShow(CefRefPtr<CefBrowser> browser,
                   bool show);
  // |rect| must be in pixel coordinates.
  void OnPopupSize(CefRefPtr<CefBrowser> browser,
                   const CefRect& rect);
  void OnPaint(CefRefPtr<CefBrowser> browser,
               CefRenderHandler::PaintElementType type,
               const CefRenderHandler::RectList& dirtyRects,
               const void* buffer, int width, int height);

  // Apply spin.
  void SetSpin(float spinX, float spinY);
  void IncrementSpin(float spinDX, float spinDY);

  bool IsTransparent() const { return settings_.transparent; }
  cef_color_t GetBackgroundColor() const { return settings_.background_color; }

  int GetViewWidth() const { return view_width_; }
  int GetViewHeight() const { return view_height_; }

  const CefRect& popup_rect() const { return popup_rect_; }
  const CefRect& original_popup_rect() const { return original_popup_rect_; }

  CefRect GetPopupRectInWebView(const CefRect& original_rect);
  void ClearPopupRects();

 private:
<<<<<<< HEAD:cef3/cefclient/browser/osr_renderer.h
<<<<<<< HEAD:cef3/cefclient/osrenderer.h
  const bool transparent_;
  const bool show_update_rect_;
=======
  const Settings settings_;
>>>>>>> origin/3.2357.1267:cef3/cefclient/browser/osr_renderer.h
=======
  const Settings settings_;
>>>>>>> origin/s01_t1:cef3/cefclient/browser/osr_renderer.h
  bool initialized_;
  unsigned int texture_id_;
  int view_width_;
  int view_height_;
  CefRect popup_rect_;
  CefRect original_popup_rect_;
  float spin_x_;
  float spin_y_;
  CefRect update_rect_;
<<<<<<< HEAD:cef3/cefclient/browser/osr_renderer.h
<<<<<<< HEAD:cef3/cefclient/osrenderer.h
=======

  DISALLOW_COPY_AND_ASSIGN(OsrRenderer);
>>>>>>> origin/3.2357.1267:cef3/cefclient/browser/osr_renderer.h
=======

  DISALLOW_COPY_AND_ASSIGN(OsrRenderer);
>>>>>>> origin/s01_t1:cef3/cefclient/browser/osr_renderer.h
};

}  // namespace client

#endif  // CEF_TESTS_CEFCLIENT_BROWSER_OSR_RENDERER_H_

