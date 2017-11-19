//MIT, 2015-2017, WinterDev

#pragma once
#include "libcef_dll/myext/myext.h"

extern "C" {
	 
	MY_DLL_EXPORT void* MyCefJs_New_V8Handler(managed_callback callback); 
	MY_DLL_EXPORT bool MyCefJs_CefRegisterExtension(const wchar_t* extensionName, const wchar_t* extensionCode, void* handler);

 	 
	MY_DLL_EXPORT void MyCefStringHolder_Read(MyCefStringHolder* mycefstr, char16* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefStringGetRawPtr(void* cefstring, char16** outputBuffer, int* actualLength); 
	MY_DLL_EXPORT MyCefStringHolder* MyCefCreateStringHolder(const wchar_t*  str); 
	MY_DLL_EXPORT MyCefBufferHolder* MyCefCreateBufferHolder(int32_t len);
	MY_DLL_EXPORT MyCefBufferHolder* MyCefCreateBufferHolderWithInitData(int32_t len, char* initData);
}