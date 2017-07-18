//MIT, 2015-2017, WinterDev 
#include "include/base/cef_scoped_ptr.h" 
#include "tests/cefclient/browser/main_context_impl.h" 
namespace client {
	namespace init_main {
		void SetManagedCallback(managed_callback callback);
	}
}

client::MainContextImpl* DllInitMain(CefMainArgs& main_args, CefRefPtr<CefApp> app);