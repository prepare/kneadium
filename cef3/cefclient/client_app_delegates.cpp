// Copyright (c) 2012 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.

#include "cefclient/client_app.h"
#include "cefclient/client_renderer.h"
#include "cefclient/performance_test.h"
#include "cefclient/scheme_test.h"

#if defined(OS_LINUX)
#include "cefclient/print_handler_gtk.h"
#endif

// static
void ClientApp::CreateBrowserDelegates(BrowserDelegateSet& delegates)
{
}

// static
void ClientApp::CreateRenderDelegates(RenderDelegateSet& delegates) 
{	
  client_renderer::CreateRenderDelegates(delegates);
  performance_test::CreateRenderDelegates(delegates);
  //register custom render delegate 

}

// static
void ClientApp::RegisterCustomSchemes(
    CefRefPtr<CefSchemeRegistrar> registrar,
<<<<<<< HEAD
    std::vector<CefString>& cookiable_schemes)
{
	if(this->myMxCallback)
	{  
		//send to
		myMxCallback(0,NULL);
	}
	else
	{
		//others...
		scheme_test::RegisterCustomSchemes(registrar, cookiable_schemes);
	}
=======
    std::vector<CefString>& cookiable_schemes) {
	
	 
  scheme_test::RegisterCustomSchemes(registrar, cookiable_schemes);
>>>>>>> origin/retro1
}

// static
CefRefPtr<CefPrintHandler> ClientApp::CreatePrintHandler() {
#if defined(OS_LINUX)
  return new ClientPrintHandlerGtk();
#else
  return NULL;
#endif
}

