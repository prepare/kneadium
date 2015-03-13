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


//------------------------------------------------------------------

CefCallbackArgs::CefCallbackArgs() 
{  	  
} 
 
void CefCallbackArgs::SetOutputString(int resultIndex, const void* dataBuffer,int len)
{	

	 
	this->resultKind =JSVALUE_TYPE_STRING;  

	char* data= new char[len];
	memcpy_s(data,len,dataBuffer,len);	 


	jsvalue v;
	v.type = JSVALUE_TYPE_STRING;
	v.length = len;//buffer len
	v.value.ptr = data;

	switch(resultIndex)
	{
		case 0:
		{
			this->result0 =v;

		}break;
		case 1:
		{
			this->result1 =v;
		}break;
		case 2:
		{ 
			this->result2 =v;

		}break;
		case 3:
		{
			this->result3 =v;

		}break;
	}
	/*this->outputLen = len;
	this->outputBuffer = new char[len];
	memcpy(this->outputBuffer,dataBuffer,len);	 
	this->resultKind =JSVALUE_TYPE_STRING;*/
}
 