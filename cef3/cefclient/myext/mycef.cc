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
void MethodArgs::SetArgAsNativeObject(int argIndex, const void* nativeObject)
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
void MethodArgs::SetArgType(int argIndex, int type)
{
	switch (argIndex) {
	case 0:
		this->arg0.type = type;
		break;
	case 1:
		this->arg1.type = type;
		break;
	case 2:
		this->arg2.type = type;
		break;
	case 3:
		this->arg3.type = type;
		break;
	case 4:
		this->arg4.type = type;
		break;
	}
}


std::wstring MethodArgs::ReadOutputAsString(int resultIndex)
{
	switch (resultIndex) {
	case 0:
	{
		switch (this->result0.type)
		{
		case JSVALUE_TYPE_STRING:
			//unicode string
			return std::wstring(this->result0.value.str2);
		case JSVALUE_TYPE_BUFFER:
		{
			std::string str1 = "";
			str1.append((const char*) this->result0.value.byteBuffer, (size_t)result0.length);
			CefString cefStr(str1);
			return cefStr.c_str();
		}
		}
	}break;
	case 1:
	{
		switch (this->result1.type)
		{
		case JSVALUE_TYPE_STRING:
			//unicode string
			return std::wstring(this->result1.value.str2);
		case JSVALUE_TYPE_BUFFER:
		{
			std::string str1 = "";
			str1.append((const char*) this->result1.value.byteBuffer, (size_t)result1.length);
			CefString cefStr(str1);
			return cefStr.c_str();
		}
		}
	}break;
	case 2:
	{
		switch (this->result2.type)
		{
		case JSVALUE_TYPE_STRING:
			//unicode string
			return std::wstring(this->result2.value.str2);
		case JSVALUE_TYPE_BUFFER:
		{
			std::string str1 = "";
			str1.append((const char*) this->result2.value.byteBuffer, (size_t)result2.length);
			CefString cefStr(str1);
			return cefStr.c_str();
		}
		}
	}break;



	}
	//default
	return L"";
}

QueryRequestArgs::QueryRequestArgs() {


	this->browser = nullptr;
	this->frame = nullptr;
	this->query_id = 0;
	this->request = nullptr;
	this->persistent = false;
	this->callback = nullptr;
}