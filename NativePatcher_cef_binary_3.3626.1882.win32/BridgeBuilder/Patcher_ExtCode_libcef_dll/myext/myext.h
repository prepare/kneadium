//MIT, 2015-2017, WinterDev
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
 
typedef void(__cdecl *managed_callback)(int id, void* args);


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
#define JSVALUE_TYPE_MANAGED_CB 32
#define JSVALUE_TYPE_MEM_ERROR      50 //my extension

 
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



 inline void MyCefSetVoidPtr(jsvalue* value, void* data)
 {
	 value->type = JSVALUE_TYPE_WRAPPED;
	 value->ptr = data;
 };
 inline void MyCefSetVoidPtr2(jsvalue* value, const void* data) {
	 value->type = JSVALUE_TYPE_WRAPPED;
	 value->ptr = data;
 };
 inline void MyCefSetInt32(jsvalue* value, int32_t data)
 {
	 value->type = JSVALUE_TYPE_INTEGER;
	 value->i32 = data;
 };
 inline void MyCefSetUInt32(jsvalue* value, uint32_t data)
 {
	 value->type = JSVALUE_TYPE_INTEGER;
	 value->i32 = (int32_t)data;
 };
 inline void MyCefSetInt64(jsvalue* value, int64_t data)
 {
	 value->type = JSVALUE_TYPE_INTEGER64;
	 value->i64 = data;
 };
 inline void MyCefSetUInt64(jsvalue* value, uint64_t data)
 {
	 value->type = JSVALUE_TYPE_INTEGER64;
	 value->i64 = data;
 };
 inline void MyCefSetBool(jsvalue* value, bool data)
 {
	 value->type = JSVALUE_TYPE_BOOLEAN;
	 value->i32 = data ? 1 : 0;
 };
 inline void MyCefSetBool(jsvalue* value, int data)
 {
	 value->type = JSVALUE_TYPE_BOOLEAN;
	 value->i32 = data ? 1 : 0;
 };
 inline void MyCefSetDouble(jsvalue* value, double data)
 {
	 value->type = JSVALUE_TYPE_NUMBER;
	 value->num = data;
 }
 inline void MyCefSetFloat(jsvalue* value, float data)
 {
	 value->type = JSVALUE_TYPE_NUMBER;
	 value->num = data;
 };


#include "include/internal/cef_string.h"

 class MyCefStringHolder
 {
 public:
	 CefString value;
 };
 struct MyCefBufferHolder {
	 int32_t len;
	 char* buffer;
 };


 inline MyCefStringHolder* GetStringHolder(jsvalue* value) {
	 return (MyCefStringHolder*)value->ptr;
 };
 inline MyCefBufferHolder* GetBufferHolder(jsvalue* value) {
	 return (MyCefBufferHolder*)value->ptr;
 };
 inline void SetCefStringToJsValue(jsvalue* value, const CefString&cefstr) {

	 MyCefStringHolder* str = new MyCefStringHolder();
	 str->value = cefstr;
	 //
	 value->type = JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;
	 value->ptr = str;
	 value->i32 = str->value.length();
 };
 inline void SetCefStringToJsValue2(jsvalue* value, const CefString&cefstr) {

	 //not need MyCefStringHolder
	 value->type = JSVALUE_TYPE_NATIVE_CEFSTRING;
	 value->ptr = &cefstr;
	 value->i32 = cefstr.length();
 };
 inline void DeleteCefStringHolderFromJsValue(jsvalue* value) {
	 value->i32 = 0;
	 delete value->ptr;
 };
  
