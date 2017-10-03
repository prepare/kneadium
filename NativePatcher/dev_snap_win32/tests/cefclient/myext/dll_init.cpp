////MIT, 2015-2017, WinterDev
//
//// Copyright (c) 2015 The Chromium Embedded Framework Authors. All rights
//// reserved. Use of this source code is governed by a BSD-style license that
//// can be found in the LICENSE file.
//
//
//#include "dll_init.h" 
//#include "include/cef_command_line.h"  
//#include "mycef.h"
//
//
//// When generating projects with CMake the CEF_USE_SANDBOX value will be defined
//// automatically if using the required compiler version. Pass -DUSE_SANDBOX=OFF
//// to the CMake command-line to disable use of the sandbox.
//// Uncomment this line to manually enable sandbox support.
//// #define CEF_USE_SANDBOX 1
//
//
//
//namespace client {
//
//	namespace init_main { 
//		client::MainContextImpl* InitDllApp(CefMainArgs& main_args, CefRefPtr<CefApp> app) { 
//
//			void* sandbox_info = NULL; 
//#if defined(CEF_USE_SANDBOX)
//			// Manage the life span of the sandbox information object. This is necessary
//			// for sandbox support on Windows. See cef_sandbox_win.h for complete details.
//			CefScopedSandboxInfo scoped_sandbox;
//			sandbox_info = scoped_sandbox.sandbox_info();
//#endif      
//			// Execute the secondary process, if any.
//			int exit_code = CefExecuteProcess(main_args, app, sandbox_info);
//			if (exit_code >= 0)
//			{
//				return NULL;
//			} 
//			// Parse command-line arguments.
//			CefRefPtr<CefCommandLine> command_line = CefCommandLine::CreateCommandLine();
//			command_line->InitFromString(::GetCommandLineW()); 
//			//-------------------------------------------------------------------------------------
//			// Create the main context object.			 
//			auto mainContext = new MainContextImpl(command_line, true);
//			mainContext->myMxCallback_ = mycefmx::GetManagedCallback();
//			//setting 
//			CefSettings settings;
//			settings.log_severity = (cef_log_severity_t)99;//disable log
//			//-------------------------------------------------------------------------------------
//#if !defined(CEF_USE_SANDBOX)
//			settings.no_sandbox = true;
//#endif		
//			mainContext->PopulateSettings(&settings); 
//			mainContext->Initialize(main_args, settings, app, sandbox_info); 
//			return mainContext;
//		} 
//	}  // namespace init_main 
//}  // namespace client 
//
//client::MainContextImpl* DllInitMain(CefMainArgs& main_args, CefRefPtr<CefApp> app)
//{
//	return client::init_main::InitDllApp(main_args, app);
//}