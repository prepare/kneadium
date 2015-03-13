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