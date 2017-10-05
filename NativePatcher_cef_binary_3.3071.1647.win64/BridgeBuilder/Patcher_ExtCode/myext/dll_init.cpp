//MIT, 2015-2017, WinterDev

// Copyright (c) 2015 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.


#include "dll_init.h" 
#include "include/cef_command_line.h"  



// When generating projects with CMake the CEF_USE_SANDBOX value will be defined
// automatically if using the required compiler version. Pass -DUSE_SANDBOX=OFF
// to the CMake command-line to disable use of the sandbox.
// Uncomment this line to manually enable sandbox support.
// #define CEF_USE_SANDBOX 1

#if defined(CEF_USE_SANDBOX)
// The cef_sandbox.lib static library is currently built with VS2013. It may not
// link successfully with other VS versions.
#include "include/cef_sandbox_win.h"

#pragma comment(lib, "cef_sandbox.lib")
#endif

namespace client {

	namespace init_main {

		//static
		managed_callback m_callback;


		void SetManagedCallback(managed_callback callback) {
			m_callback = callback;
		}

		client::MainContextImpl* InitDllApp(CefMainArgs& main_args, CefRefPtr<CefApp> app) {


			void* sandbox_info = NULL;

#if defined(CEF_USE_SANDBOX)
			// Manage the life span of the sandbox information object. This is necessary
			// for sandbox support on Windows. See cef_sandbox_win.h for complete details.
			CefScopedSandboxInfo scoped_sandbox;
			sandbox_info = scoped_sandbox.sandbox_info();
#endif  
			//// Create a ClientApp of the correct type.
			//CefRefPtr<CefApp> app;
			/*ClientApp::ProcessType process_type = ClientApp::GetProcessType(command_line);
			if (process_type == ClientApp::BrowserProcess)
			{
			}
			else if (process_type == ClientApp::RendererProcess)
			{
				MessageBox(0, L"RendererProcess INIT", L"RendererProcess INI", 0);
			}
			else if (process_type == ClientApp::OtherProcess)
			{
			}*/
			// Execute the secondary process, if any.
			int exit_code = CefExecuteProcess(main_args, app, sandbox_info);
			if (exit_code >= 0)
			{
				return NULL;
			}

			// Parse command-line arguments.
			CefRefPtr<CefCommandLine> command_line = CefCommandLine::CreateCommandLine();
			command_line->InitFromString(::GetCommandLineW());

			//-------------------------------------------------------------------------------------
			// Create the main context object.
			//scoped_ptr<MainContextImpl> context(new MainContextImpl(command_line, true));
			auto mainContext = new MainContextImpl(command_line, true);
			mainContext->myMxCallback_ = m_callback;
			//setting 
			CefSettings settings;
			settings.log_severity = (cef_log_severity_t)99;//disable log
			//-------------------------------------------------------------------------------------
#if !defined(CEF_USE_SANDBOX)
			settings.no_sandbox = true;
#endif
			// Populate the settings based on command line arguments.		    


			mainContext->PopulateSettings(&settings); 
			//-------------------------------------------------------------------------------------
			// Create the main message loop object.
			/*scoped_ptr<MainMessageLoop> message_loop;
			if (settings.multi_threaded_message_loop)
			  message_loop.reset(new MainMessageLoopMultithreadedWin);
			else
			  message_loop.reset(new MainMessageLoopStd);
			*/
			//Initialize CEF.
			mainContext->Initialize(main_args, settings, app, sandbox_info);

			
			 
			// Register scheme handlers.
			//test_runner::RegisterSchemeHandlers(); //if you don't want to register the scheme handler

			// Create the first window.
			//context->GetRootWindowManager()->CreateRootWindow(
			//    true,             // Show controls.
			//    settings.windowless_rendering_enabled ? true : false,
			//    CefRect(),        // Use default system size.
			//    std::string());   // Use default URL.

			//// Run the message loop. This will block until Quit() is called by the
			//// RootWindowManager after all windows have been destroyed.
			//int result = message_loop->Run();

			//// Shut down CEF.
			//context->Shutdown();

			//// Release objects in reverse order of creation.
			//message_loop.reset();
			//context.reset();

			//return result;
			return mainContext;
		}

	}  // namespace init_main 
}  // namespace client

client::MainContextImpl* DllInitMain(CefMainArgs& main_args, CefRefPtr<CefApp> app)
{
	return client::init_main::InitDllApp(main_args, app);
}