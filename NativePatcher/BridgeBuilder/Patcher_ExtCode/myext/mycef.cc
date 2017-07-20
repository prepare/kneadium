//MIT, 2015-2017, EngineKit, WinterDev


#include "mycef_msg_const.h"
#include "mycef.h"

//-----------------------
void MethodArgs::SetArgAsString(int argIndex, const wchar_t* str)
{
	switch (argIndex) {
	case 0:
	{
		this->arg0.type = JSVALUE_TYPE_STRING;
		this->arg0.i32 = (int32_t)wcslen(str);
		this->arg0.ptr = str;
	}break;
	case 1:
	{
		this->arg1.type = JSVALUE_TYPE_STRING;
		this->arg1.i32 = (int32_t)wcslen(str);
		this->arg1.ptr = str;
	}break;
	case 2:
	{
		this->arg2.type = JSVALUE_TYPE_STRING;
		this->arg2.i32 = (int32_t)wcslen(str);
		this->arg2.ptr = str;
	}break;
	case 3:
	{
		this->arg3.type = JSVALUE_TYPE_STRING;
		this->arg3.i32 = (int32_t)wcslen(str);
		this->arg3.ptr = str;
	}break;
	case 4:
	{
		this->arg4.type = JSVALUE_TYPE_STRING;
		this->arg4.i32 = (int32_t)wcslen(str);
		this->arg4.ptr = str;
	}break;
	}
}
void MethodArgs::SetArgAsInt32(int argIndex, const int32_t value)
{
	switch (argIndex) {
	case 0:
	{
		this->arg0.type = JSVALUE_TYPE_INTEGER;
		this->arg0.i32 = value;
	}break;
	case 1:
	{
		this->arg1.type = JSVALUE_TYPE_INTEGER;
		this->arg1.i32 = value;
	}break;
	case 2:
	{
		this->arg2.type = JSVALUE_TYPE_INTEGER;
		this->arg2.i32 = value;
	}break;
	case 3:
	{
		this->arg3.type = JSVALUE_TYPE_INTEGER;
		this->arg3.i32 = value;
	}break;
	case 4:
	{
		this->arg4.type = JSVALUE_TYPE_INTEGER;
		this->arg4.i32 = value;
	}break;
	}
}
void MethodArgs::SetArgAsNativeObject(int argIndex, const void* nativeObject)
{
	switch (argIndex) {
	case 0:
	{
		this->arg0.type = JSVALUE_TYPE_WRAPPED;
		this->arg0.ptr = nativeObject;
	}break;
	case 1:
	{
		this->arg1.type = JSVALUE_TYPE_WRAPPED;
		this->arg1.ptr = nativeObject;
	}break;
	case 2:
	{
		this->arg2.type = JSVALUE_TYPE_WRAPPED;
		this->arg2.ptr = nativeObject;
	}break;
	case 3:
	{
		this->arg3.type = JSVALUE_TYPE_WRAPPED;
		this->arg3.ptr = nativeObject;
	}break;
	case 4:
	{
		this->arg4.type = JSVALUE_TYPE_WRAPPED;
		this->arg4.ptr = nativeObject;
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
int MethodArgs::ReadOutputAsInt32(int resultIndex) {
	switch (resultIndex) {
	case 0:
	{
		switch (this->result0.type)
		{
		case JSVALUE_TYPE_INTEGER:
			return this->result0.i32;
		}
	}break;
	case 1:
	{
		switch (this->result0.type)
		{
		case JSVALUE_TYPE_INTEGER:

			return this->result1.i32;
		}
	}break;
	case 2:
	{
		switch (this->result0.type)
		{
		case JSVALUE_TYPE_INTEGER:
			return this->result2.i32;
		}
	}break;

	}
	return 0;//else
}

const char16* MethodArgs::ReadOutputAsString(int resultIndex)
{
	switch (resultIndex) {
	case 0:
	{
		switch (this->result0.type)
		{
		case JSVALUE_TYPE_STRING:
			//TODO: review again
			//unicode string
			return (char16*)this->result0.ptr;

		case JSVALUE_TYPE_BUFFER:
		{
			//TODO: review again
			std::string str1 = "";
			str1.append((const char*) this->result0.ptr, (size_t)result0.i32);
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
			//TODO: review again
			//unicode string
			return (char16*)this->result0.ptr;
		case JSVALUE_TYPE_BUFFER:
		{
			std::string str1 = "";
			str1.append((const char*) this->result1.ptr, (size_t)result1.i32);
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
			////unicode string
			return (char16*)this->result0.ptr;
		case JSVALUE_TYPE_BUFFER:
		{
			std::string str1 = "";
			str1.append((const char*) this->result2.ptr, (size_t)result2.i32);
			CefString cefStr(str1);
			return cefStr.c_str();
		}
		}
	}break;
	}
	return nullptr;
}

QueryRequestArgs::QueryRequestArgs() {


	this->browser = nullptr;
	this->frame = nullptr;
	this->query_id = 0;
	this->request = nullptr;
	this->persistent = false;
	this->callback = nullptr;
}







