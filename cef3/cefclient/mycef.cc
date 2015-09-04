//MIT 2015,EngineKit

#include "include/cef_browser.h"
#include "include/cef_request.h"
#include "include/wrapper/cef_message_router.h"
#include "include/wrapper/cef_resource_manager.h"
#include "mycef.h"

void MethodArgs::SetArgAsString(int argIndex, const wchar_t* str)
{
	switch (argIndex) {
	case 0:
	{
		this->arg0.type = JSVALUE_TYPE_STRING;
		this->arg0.length = wcslen(str);
		this->arg0.value.str = (uint16_t*)str;
	}break;
	case 1:
	{
		this->arg1.type = JSVALUE_TYPE_STRING;
		this->arg1.length = wcslen(str);
		this->arg1.value.str = (uint16_t*)str;
	}break;
	case 2:
	{
		this->arg2.type = JSVALUE_TYPE_STRING;
		this->arg2.length = wcslen(str);
		this->arg2.value.str = (uint16_t*)str;
	}break;
	case 3:
	{
		this->arg3.type = JSVALUE_TYPE_STRING;
		this->arg3.length = wcslen(str);
		this->arg3.value.str = (uint16_t*)str;
	}break;
	case 4:
	{
		this->arg4.type = JSVALUE_TYPE_STRING;
		this->arg4.length = wcslen(str);
		this->arg4.value.str = (uint16_t*)str;
	}break;
	}
}
void MethodArgs::SetArgAsNativeObject(int argIndex, void* nativeObject)
{
	switch (argIndex) {
	case 0:
	{
		this->arg0.type = JSVALUE_TYPE_WRAPPED;
		this->arg0.length = 0;
		this->arg0.value.ptr = nativeObject;
	}break;
	case 1:
	{
		this->arg1.type = JSVALUE_TYPE_WRAPPED;
		this->arg1.length = 0;
		this->arg1.value.ptr = nativeObject;
	}break;
	case 2:
	{
		this->arg2.type = JSVALUE_TYPE_WRAPPED;
		this->arg2.length = 0;
		this->arg2.value.ptr = nativeObject;
	}break;
	case 3:
	{
		this->arg3.type = JSVALUE_TYPE_WRAPPED;
		this->arg3.length = 0;
		this->arg3.value.ptr = nativeObject;
	}break;
	case 4:
	{
		this->arg4.type = JSVALUE_TYPE_WRAPPED;
		this->arg4.length = 0;
		this->arg4.value.ptr = nativeObject;
	}break;
	}
}

