#include "mycef.h"
jsvalue ConvToJsValue(std::wstring str)
{
	 
	jsvalue v; 
	// Initialize to a generic error.
	v.type = JSVALUE_TYPE_STRING;

	int len = str.length();
	wchar_t* buff= new wchar_t[len+1]; 
	wcscpy_s(buff,len+1,str.c_str());

	v.length = len;
	v.value.str = (uint16_t*)buff;

	return v;
}