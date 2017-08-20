//MIT, 2015-2017, WinterDev

#pragma once
#include "libcef_dll/myext/myext.h"

extern "C" {
	MY_DLL_EXPORT CefV8Context* MyCefFrame_GetContext(CefFrame* wbFrame);
	MY_DLL_EXPORT CefV8Handler* MyCefJs_New_V8Handler(managed_callback callback);
	//
	MY_DLL_EXPORT CefV8Context* MyCefJsGetCurrentContext();
	MY_DLL_EXPORT CefV8Context* MyCefJs_GetEnteredContext();
	MY_DLL_EXPORT CefV8Value* MyCefJsGetGlobal(CefV8Context* cefV8Context);
	MY_DLL_EXPORT CefV8Context* MyCefJs_EnterContext(CefV8Context* cefV8Context);
	MY_DLL_EXPORT void MyCefJs_ExitContext(CefV8Context* cefV8Context);

	MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByString(CefV8Value* target, const wchar_t* key, CefV8Value* value, int setAttribute);
	MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByIndex(CefV8Value* target, int index, CefV8Value* value);
	MY_DLL_EXPORT bool MyCefJs_CefV8Value_IsFunc(CefV8Value* target);
	MY_DLL_EXPORT bool MyCefJs_CefRegisterExtension(const wchar_t* extensionName, const wchar_t* extensionCode);
	MY_DLL_EXPORT CefV8Value* MyCefJs_CreateFunction(const wchar_t* name, CefV8Handler* handler);
	MY_DLL_EXPORT CefV8Value* MyCefJs_ExecJsFunctionWithContext(CefV8Value* cefJsFunc, CefV8Context* context, const wchar_t* argAsJsonString);
	MY_DLL_EXPORT void MyCefString_Read(CefString* cefStr, char16* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefJs_CefV8Value_ReadAsString(CefV8Value* target, char16* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefStringHolder_Read(MyCefStringHolder* mycefstr, char16* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT void MyCefStringGetRawPtr(void* cefstring, char16** outputBuffer, int* actualLength);

	MY_DLL_EXPORT void MyCefJs_MetReadArgAsString(const CefV8ValueList* jsArgs, int index, wchar_t* outputBuffer, int outputBufferLen, int* actualLength);
	MY_DLL_EXPORT int MyCefJs_MetReadArgAsInt32(const CefV8ValueList* jsArgs, int index);
	MY_DLL_EXPORT CefV8Value* MyCefJs_MetReadArgAsCefV8Value(const CefV8ValueList* jsArgs, int index);
	MY_DLL_EXPORT CefV8Handler* MyCefJs_MetReadArgAsV8FuncHandle(const CefV8ValueList* jsArgs, int index);
	MY_DLL_EXPORT MyCefStringHolder* MyCefCreateStringHolder(const wchar_t*  str);
	//
	MY_DLL_EXPORT MyCefBufferHolder* MyCefCreateBufferHolder(int32_t len);
	MY_DLL_EXPORT MyCefBufferHolder* MyCefCreateBufferHolderWithInitData(int32_t len, char* initData);
}