//MIT 2015, WinterDev

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




// jsvalue (JsValue on the CLR side) is a struct that can be easily marshaled
// by simply blitting its value (being only 16 bytes should be quite fast too).

#define JSVALUE_TYPE_UNKNOWN_ERROR  -1
#define JSVALUE_TYPE_EMPTY			 0
#define JSVALUE_TYPE_NULL            1
#define JSVALUE_TYPE_BOOLEAN         2
#define JSVALUE_TYPE_INTEGER         3
#define JSVALUE_TYPE_NUMBER          4
#define JSVALUE_TYPE_STRING          5
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
 


extern "C"{


struct jsvalue
{	
	   //-------------
	   //from vroomjs
	   //-------------

       // 8 bytes is the maximum CLR alignment; by putting the union first and a
       // int64_t inside it we make (almost) sure the offset of 'type' will always
       // be 8 and the total size 16. We add a check to JsContext_new anyway. 
       union 
       {
            int32_t     i32;
            int64_t     i64;
            double      num;
            void       *ptr;
            uint16_t   *str; 
            jsvalue    *arr;
       } value;
        
       int32_t         type;
       int32_t         length; // Also used as slot index on the CLR side.
};
 
}

jsvalue ConvToJsValue(std::wstring str);

class MethodArgs
{
public:
	MethodArgs();
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

	void SetOutputString(int resultIndex, const void* dataBuffer,int len);  
};

typedef void (*delTraceBack)(int oIndex,const wchar_t* methodName);  
//for visitor
typedef void (*delTextWalk)(int oIndex,const wchar_t* textContent);
typedef void (__stdcall *managed_callback)(int id, void* args);   