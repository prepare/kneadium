//MIT, 2015-2017, EngineKit, WinterDev 
#include "mycef_msg_const.h"
#include "mycef.h" 


namespace mycefmx {
	managed_callback m_callback;
	managed_callback GetManagedCallback() {
		return m_callback;
	}
	void SetManagedCallback(managed_callback callback) {
		m_callback = callback;
	}
}


