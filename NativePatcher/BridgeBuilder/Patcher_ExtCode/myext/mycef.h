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
#pragma once
#include <string>
#include <uchar.h>
 
#include "include/base/cef_ref_counted.h"
#include "include/cef_base.h" 
#include "include/cef_v8.h" 
#include "libcef_dll/myext/myext.h"
#include "libcef_dll/myext/MyCefStringHolder.h"

class MethodArgs
{
public: 
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
		 
	int16_t resultKind;
	int16_t argCount;
	int16_t resultCount;



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
 
 
namespace mycefmx {
	managed_callback GetManagedCallback();
	void SetManagedCallback(managed_callback callback); 
}


extern "C" {
	 
	MY_DLL_EXPORT managed_callback MyCefJsValueGetManagedCallback(jsvalue* v);
	MY_DLL_EXPORT void MyCefJsValueSetManagedCallback(jsvalue* v, managed_callback cb);
}