 
#include "include/base/cef_scoped_ptr.h"
#include "include/cef_command_line.h"
#include "include/cef_sandbox_win.h"
#include "tests/shared/browser/client_app_browser.h"
#include "tests/cefclient/browser/main_context_impl.h"
#include "tests/cefclient/browser/main_message_loop_multithreaded_win.h"
#include "tests/shared/browser/main_message_loop_std.h"
#include "tests/cefclient/browser/root_window_manager.h"
#include "tests/cefclient/browser/test_runner.h"
#include "tests/shared/common/client_app_other.h"
#include "tests/shared/renderer/client_app_renderer.h"
#include "mycef.h"

namespace client {
	namespace init_main {
		void SetManagedCallback(managed_callback callback);
	}
}

client::MainContextImpl* DllInitMain(CefMainArgs& main_args, CefRefPtr<CefApp> app);