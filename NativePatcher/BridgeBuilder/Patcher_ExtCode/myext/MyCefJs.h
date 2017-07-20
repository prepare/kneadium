#pragma once
//MIT, 2015-2017, WinterDev
extern "C" {

	 	 
	MY_DLL_EXPORT void MyCefMetArgs_GetArgs(MethodArgs* args, int argIndex, jsvalue* output);
	 
	MY_DLL_EXPORT void MyCefMetArgs_SetResultAsJsValue(MethodArgs* args, int retIndex, jsvalue* value);
	 
	MY_DLL_EXPORT void MyCefMetArgs_SetResultAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len);

	MY_DLL_EXPORT void MyCefMetArgs_SetResultAsInt32(MethodArgs* args, int argIndex, int value);

	MY_DLL_EXPORT void MyCefMetArgs_SetInputAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len);
	MY_DLL_EXPORT void MyCefMetArgs_SetInputAsInt32(MethodArgs* args, int argIndex, int32_t value);

	MY_DLL_EXPORT void MyCefMetArgs_SetResultAsByteBuffer(MethodArgs* args, int argIndex, const char* byteBuffer, int len);
	 
}