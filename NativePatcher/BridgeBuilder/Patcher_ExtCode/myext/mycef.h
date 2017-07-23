//MIT, 2015-2017, WinterDev

// This file is part of the VroomJs library.
//
// Author:
//     Federico Di Gregorio <fog@initd.org>
//
// Copyright (c) 2013 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#include <string>
#include <uchar.h>

#include "include/wrapper/cef_message_router.h" 
#include "tests/cefclient/browser/client_types.h"

#pragma once
#if defined(_WIN32) && !defined(__MINGW32__)

typedef signed char int8_t;
typedef unsigned char uint8_t;
typedef short int16_t;  // NOLINT
typedef unsigned short uint16_t;  // NOLINT
typedef int int32_t;
typedef unsigned int uint32_t;
typedef __int64 int64_t;
typedef unsigned __int64 uint64_t;
// intptr_t and friends are defined in crtdefs.h through stdio.h.

#else

#include <stdint.h>

#endif 

#ifdef _WIN32 
#define MY_DLL_EXPORT __declspec(dllexport)
#else 
#define MY_DLL_EXPORT
#endif

// jsvalue (JsValue on the CLR side) is a struct that can be easily marshaled
// by simply blitting its value (being only 16 bytes should be quite fast too).

#define JSVALUE_TYPE_UNKNOWN_ERROR  -1
#define JSVALUE_TYPE_EMPTY			 0
#define JSVALUE_TYPE_NULL            1
#define JSVALUE_TYPE_BOOLEAN         2
#define JSVALUE_TYPE_INTEGER         3
#define JSVALUE_TYPE_NUMBER          4
#define JSVALUE_TYPE_STRING          5 //unicode string
#define JSVALUE_TYPE_DATE            6
#define JSVALUE_TYPE_INDEX           7
#define JSVALUE_TYPE_ARRAY          10
#define JSVALUE_TYPE_STRING_ERROR   11
#define JSVALUE_TYPE_MANAGED        12
#define JSVALUE_TYPE_MANAGED_ERROR  13
#define JSVALUE_TYPE_WRAPPED        14
#define JSVALUE_TYPE_DICT           15
#define JSVALUE_TYPE_ERROR          16
#define JSVALUE_TYPE_FUNCTION       17

#define JSVALUE_TYPE_JSTYPEDEF      18 //my extension
#define JSVALUE_TYPE_INTEGER64      19 //my extension
#define JSVALUE_TYPE_BUFFER         20 //my extension

#define JSVALUE_TYPE_NATIVE_CEFSTRING 30  //my extension
#define JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING 31//my extension
#define JSVALUE_TYPE_MEM_ERROR      50 //my extension


extern "C" {
	 
	struct jsvalue
	{
	    int32_t type; //type and flags
	                  //this for 32 bits values, also be used as string len, array len  and index to managed slot index
	    int32_t i32;
	    // native ptr (may point to native object, native array, native string)
	    const void* ptr; //uint16_t* or jsvalue**   arr or 
	               //store float or double
	    double num;
	    //store 64 bits value
	    int64_t i64;
	};
	//struct jsvalue_ret
	//{
	//	int32_t type; //type and flags
	//				  //this for 32 bits values, also be used as string len, array len  and index to managed slot index
	//	int32_t i32;
	//	// native ptr (may point to native object, native array, native string)
	//	void* ptr; //uint16_t* or jsvalue**   arr or 
	//					 //store float or double
	//	double num;
	//	//store 64 bits value
	//	int64_t i64;
	//};
}




class MethodArgs
{
public:

	int method_id;

	struct jsvalue arg0;//this arg for instant method
	struct jsvalue arg1;
	struct jsvalue arg2;
	struct jsvalue arg3;
	struct jsvalue arg4;

	struct jsvalue result0;//this arg for instant method
	struct jsvalue result1;
	struct jsvalue result2;
	struct jsvalue result3;
	struct jsvalue result4;

	//void* outputBuffer;	 
	//int outputLen;
	int resultKind;

	int argCount;
	int resultCount;

	void SetArgAsString(int argIndex, const wchar_t* str);
	void SetArgAsNativeObject(int argIndex, const void* nativeObject);
	void SetArgAsInt32(int argIndex, const int32_t value);
	void SetArgType(int argIndex, int type);

	//----------------------------------------------------------------------
	void SetOutputAsNativeObject(int retIndex, const void* nativeObject);
	void SetOutputAsInt32(int retIndex, const int32_t value);
	void SetOutputAsString(int retIndex, const wchar_t* str);
	//----------------------------------------------------------------------

	const char16* ReadOutputAsString(int resultIndex);
	int ReadOutputAsInt32(int resultIndex);

};

class MyCefStringHolder
{
public:
	CefString value;
	void* any;
};

class QueryRequestArgs
{

public:

	CefBrowser* browser;
	CefFrame* frame;
	MyCefStringHolder* request;
	int64 query_id;
	bool persistent;
	CefMessageRouterBrowserSide::Callback* callback;
	QueryRequestArgs();

};



typedef void(__cdecl *managed_callback)(int id, void* args);

 
namespace mycefmx {
	managed_callback GetManagedCallback();
	void SetManagedCallback(managed_callback callback);

}
