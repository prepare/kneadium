#include "mycef_msg_const.h"
#include "mycef.h"
#include "MyCefJs.h"

void MyCefMetArgs_GetArgs(MethodArgs* args, int argIndex, jsvalue* output)
{
	switch (argIndex)
	{
	case 0:
	{
		*output = args->arg0;
		break;
	}
	case 1:
	{
		*output = args->arg1;
		break;
	}
	case 2: {
		*output = args->arg2;
		break;
	}
	case 3: {
		*output = args->arg3;
		break;
	}
	case 4: {
		*output = args->arg4;
		break;
	}
	default:
		output->type = JSVALUE_TYPE_EMPTY;
		break;
	}
} 
 
 
void MyCefMetArgs_SetResultAsJsValue(MethodArgs* args, int retIndex, jsvalue* value)
{
	switch (retIndex) {
	case 0:
		args->result0 = *(value);
		break;
	case 1:
		args->result1 = *(value);
		break;
	case 2:
		args->result2 = *(value);
		break;
	case 3:
		args->result3 = *(value);
		break;
	case 4:
		args->result4 = *(value);
		break;
	}
}
 
void MyCefMetArgs_SetResultAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len) {

	switch (argIndex)
	{
	case 0: {

		args->result0.type = JSVALUE_TYPE_STRING;
		args->result0.i32 = (int32_t)len;
		args->result0.ptr = buffer;
	}break;
	case 1: {

		args->result1.type = JSVALUE_TYPE_STRING;
		args->result1.i32 = (int32_t)len;
		args->result1.ptr = buffer;
	}break;
	case 2: {

		args->result2.type = JSVALUE_TYPE_STRING;
		args->result2.i32 = (int32_t)len;
		args->result2.ptr = buffer;
	}break;
	case 3: {

		args->result3.type = JSVALUE_TYPE_STRING;
		args->result3.i32 = (int32_t)len;
		args->result3.ptr = buffer;
	}break;
	case 4: {

		args->result4.type = JSVALUE_TYPE_STRING;
		args->result4.i32 = (int32_t)len;
		args->result4.ptr = buffer;
	}break;
	}
}
void MyCefMetArgs_SetInputAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len) {

	//input
	switch (argIndex)
	{
	case 0: {

		args->arg0.type = JSVALUE_TYPE_STRING;
		args->arg0.i32 = (int32_t)len;
		args->arg0.ptr = buffer;
	}break;
	case 1: {

		args->arg1.type = JSVALUE_TYPE_STRING;
		args->arg1.i32 = (int32_t)len;
		args->arg1.ptr = buffer;
	}break;
	case 2: {

		args->arg2.type = JSVALUE_TYPE_STRING;
		args->arg2.i32 = (int32_t)len;
		args->arg2.ptr = buffer;
	}break;
	case 3: {

		args->arg3.type = JSVALUE_TYPE_STRING;
		args->arg3.i32 = (int32_t)len;
		args->arg3.ptr = buffer;
	}break;
	case 4: {

		args->arg4.type = JSVALUE_TYPE_STRING;
		args->arg4.i32 = (int32_t)len;
		args->arg4.ptr = buffer;
	}break;
	}
}
void MyCefMetArgs_SetInputAsInt32(MethodArgs* args, int argIndex, int32_t value) {

	//input
	switch (argIndex)
	{
	case 0: {

		args->arg0.type = JSVALUE_TYPE_INTEGER;
		args->arg0.i32 = value;
	}break;
	case 1: {

		args->arg1.type = JSVALUE_TYPE_INTEGER;
		args->arg1.i32 = value;
	}break;
	case 2: {

		args->arg2.type = JSVALUE_TYPE_INTEGER;
		args->arg2.i32 = value;
	}break;
	case 3: {

		args->arg3.type = JSVALUE_TYPE_INTEGER;
		args->arg3.i32 = value;
	}break;
	case 4: {

		args->arg4.type = JSVALUE_TYPE_INTEGER;
		args->arg4.i32 = value;
	}break;
	}
}
 
void MyCefMetArgs_SetResultAsInt32(MethodArgs* args, int argIndex, int value)
{
	switch (argIndex)
	{
	case 0: {

		args->result0.type = JSVALUE_TYPE_INTEGER;
		args->result0.i32 = (int32_t)value;
	}break;
	case 1: {

		args->result1.type = JSVALUE_TYPE_INTEGER;
		args->result1.i32 = (int32_t)value;
	}break;
	case 2: {

		args->result2.type = JSVALUE_TYPE_INTEGER;
		args->result2.i32 = (int32_t)value;
	}break;
	case 3: {

		args->result3.type = JSVALUE_TYPE_INTEGER;
		args->result3.i32 = (int32_t)value;
	}break;
	case 4: {

		args->result4.type = JSVALUE_TYPE_INTEGER;
		args->result4.i32 = (int32_t)value;
	}break;
	}

}
void MyCefMetArgs_SetResultAsByteBuffer(MethodArgs* args, int argIndex, const char* byteBuffer, int len) {

	switch (argIndex)
	{
	case 0: {

		args->result0.type = JSVALUE_TYPE_BUFFER;
		args->result0.i32 = (int32_t)len;
		args->result0.ptr = byteBuffer;
	}break;
	case 1: {

		args->result1.type = JSVALUE_TYPE_BUFFER;
		args->result1.i32 = (int32_t)len;
		args->result1.ptr = byteBuffer;
	}break;
	case 2: {

		args->result2.type = JSVALUE_TYPE_BUFFER;
		args->result2.i32 = (int32_t)len;
		args->result2.ptr = byteBuffer;
	}break;
	case 3: {

		args->result3.type = JSVALUE_TYPE_BUFFER;
		args->result3.i32 = (int32_t)len;
		args->result3.ptr = byteBuffer;
	}break;
	case 4: {

		args->result4.type = JSVALUE_TYPE_BUFFER;
		args->result4.i32 = (int32_t)len;
		args->result4.ptr = byteBuffer;
	}break;
	}
}
//---------------------------------------------------------------------------