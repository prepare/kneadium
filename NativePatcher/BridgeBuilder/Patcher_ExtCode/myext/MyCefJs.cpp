#include "mycef_msg_const.h"
#include "mycef.h"
#include "MyCefJs.h"

//void MyCefMetArgs_GetArgs(MethodArgs* args, int argIndex, jsvalue* output)
//{
//	*output = args->internalArgs.vargs[argIndex];
//	//switch (argIndex)
//	//{
//	//case 0:
//	//{
//	//	*output = args->arg0;
//	//	break;
//	//}
//	//case 1:
//	//{
//	//	*output = args->arg1;
//	//	break;
//	//}
//	//case 2: {
//	//	*output = args->arg2;
//	//	break;
//	//}
//	//case 3: {
//	//	*output = args->arg3;
//	//	break;
//	//}
//	//case 4: {
//	//	*output = args->arg4;
//	//	break;
//	//}
//	//default:
//	//	output->type = JSVALUE_TYPE_EMPTY;
//	//	break;
//	//}
//}


//void MyCefMetArgs_SetResultAsJsValue(MethodArgs* args, int retIndex, jsvalue* value)
//{
//	switch (retIndex) {
//	case 0:
//		args->result0 = *(value);
//		break;
//	case 1:
//		args->result1 = *(value);
//		break;
//	case 2:
//		args->result2 = *(value);
//		break;
//	case 3:
//		args->result3 = *(value);
//		break;
//	case 4:
//		args->result4 = *(value);
//		break;
//	}
//}
//
//void MyCefMetArgs_SetResultAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len) {
//
//	//switch (argIndex)
//	//{
//	//case 0: {
//
//	//	args->result0.type = JSVALUE_TYPE_STRING;
//	//	args->result0.i32 = (int32_t)len;
//	//	args->result0.ptr = buffer;
//	//}break;
//	//case 1: {
//
//	//	args->result1.type = JSVALUE_TYPE_STRING;
//	//	args->result1.i32 = (int32_t)len;
//	//	args->result1.ptr = buffer;
//	//}break;
//	//case 2: {
//
//	//	args->result2.type = JSVALUE_TYPE_STRING;
//	//	args->result2.i32 = (int32_t)len;
//	//	args->result2.ptr = buffer;
//	//}break;
//	//case 3: {
//
//	//	args->result3.type = JSVALUE_TYPE_STRING;
//	//	args->result3.i32 = (int32_t)len;
//	//	args->result3.ptr = buffer;
//	//}break;
//	//case 4: {
//
//	//	args->result4.type = JSVALUE_TYPE_STRING;
//	//	args->result4.i32 = (int32_t)len;
//	//	args->result4.ptr = buffer;
//	//}break;
//	//}
//}
//void MyCefMetArgs_SetInputAsString(MethodArgs* args, int argIndex, const wchar_t* buffer, int len) {
//
//	////input
//	//switch (argIndex)
//	//{
//	//case 0: {
//
//	//	args->arg0.type = JSVALUE_TYPE_STRING;
//	//	args->arg0.i32 = (int32_t)len;
//	//	args->arg0.ptr = buffer;
//	//}break;
//	//case 1: {
//
//	//	args->arg1.type = JSVALUE_TYPE_STRING;
//	//	args->arg1.i32 = (int32_t)len;
//	//	args->arg1.ptr = buffer;
//	//}break;
//	//case 2: {
//
//	//	args->arg2.type = JSVALUE_TYPE_STRING;
//	//	args->arg2.i32 = (int32_t)len;
//	//	args->arg2.ptr = buffer;
//	//}break;
//	//case 3: {
//
//	//	args->arg3.type = JSVALUE_TYPE_STRING;
//	//	args->arg3.i32 = (int32_t)len;
//	//	args->arg3.ptr = buffer;
//	//}break;
//	//case 4: {
//
//	//	args->arg4.type = JSVALUE_TYPE_STRING;
//	//	args->arg4.i32 = (int32_t)len;
//	//	args->arg4.ptr = buffer;
//	//}break;
//	//}
//}
//void MyCefMetArgs_SetInputAsInt32(MethodArgs* args, int argIndex, int32_t value) {
//
//	////input
//	//switch (argIndex)
//	//{
//	//case 0: {
//
//	//	args->arg0.type = JSVALUE_TYPE_INTEGER;
//	//	args->arg0.i32 = value;
//	//}break;
//	//case 1: {
//
//	//	args->arg1.type = JSVALUE_TYPE_INTEGER;
//	//	args->arg1.i32 = value;
//	//}break;
//	//case 2: {
//
//	//	args->arg2.type = JSVALUE_TYPE_INTEGER;
//	//	args->arg2.i32 = value;
//	//}break;
//	//case 3: {
//
//	//	args->arg3.type = JSVALUE_TYPE_INTEGER;
//	//	args->arg3.i32 = value;
//	//}break;
//	//case 4: {
//
//	//	args->arg4.type = JSVALUE_TYPE_INTEGER;
//	//	args->arg4.i32 = value;
//	//}break;
//	//}
//}
//
//void MyCefMetArgs_SetResultAsInt32(MethodArgs* args, int argIndex, int value)
//{
//	/*switch (argIndex)
//	{
//	case 0: {
//
//		args->result0.type = JSVALUE_TYPE_INTEGER;
//		args->result0.i32 = (int32_t)value;
//	}break;
//	case 1: {
//
//		args->result1.type = JSVALUE_TYPE_INTEGER;
//		args->result1.i32 = (int32_t)value;
//	}break;
//	case 2: {
//
//		args->result2.type = JSVALUE_TYPE_INTEGER;
//		args->result2.i32 = (int32_t)value;
//	}break;
//	case 3: {
//
//		args->result3.type = JSVALUE_TYPE_INTEGER;
//		args->result3.i32 = (int32_t)value;
//	}break;
//	case 4: {
//
//		args->result4.type = JSVALUE_TYPE_INTEGER;
//		args->result4.i32 = (int32_t)value;
//	}break;
//	}*/
//
//}
//void MyCefMetArgs_SetResultAsByteBuffer(MethodArgs* args, int argIndex, const char* byteBuffer, int len) {
//
//	/*switch (argIndex)
//	{
//	case 0: {
//
//		args->result0.type = JSVALUE_TYPE_BUFFER;
//		args->result0.i32 = (int32_t)len;
//		args->result0.ptr = byteBuffer;
//	}break;
//	case 1: {
//
//		args->result1.type = JSVALUE_TYPE_BUFFER;
//		args->result1.i32 = (int32_t)len;
//		args->result1.ptr = byteBuffer;
//	}break;
//	case 2: {
//
//		args->result2.type = JSVALUE_TYPE_BUFFER;
//		args->result2.i32 = (int32_t)len;
//		args->result2.ptr = byteBuffer;
//	}break;
//	case 3: {
//
//		args->result3.type = JSVALUE_TYPE_BUFFER;
//		args->result3.i32 = (int32_t)len;
//		args->result3.ptr = byteBuffer;
//	}break;
//	case 4: {
//
//		args->result4.type = JSVALUE_TYPE_BUFFER;
//		args->result4.i32 = (int32_t)len;
//		args->result4.ptr = byteBuffer;
//	}break;
//	}*/
//}
//---------------------------------------------------------------------------



CefV8Context* MyCefJsGetCurrentContext() {
	auto currentContext = CefV8Context::GetCurrentContext();
	currentContext->AddRef();
	return currentContext.get();
}
CefV8Context* MyCefJs_GetEnteredContext() {
	auto enteredContext = CefV8Context::GetEnteredContext();
	enteredContext->AddRef();
	return enteredContext.get();
}

MyCefStringHolder* MyCefCreateStringHolder(const char16*  str) {
	MyCefStringHolder* str_h = new MyCefStringHolder();
	str_h->value = CefString(str);
	return str_h;
}

MyCefBufferHolder* MyCefCreateBufferHolder(int32_t len) {
	char* buffer = new char[len];
	MyCefBufferHolder* holder = new MyCefBufferHolder();
	holder->len = len;
	holder->buffer = buffer;
	return holder;
}
MyCefBufferHolder* MyCefCreateBufferHolderWithInitData(int32_t len, char* initData) {
	char* buffer = new char[len];
	memcpy_s(buffer, len, initData, len);
	MyCefBufferHolder* holder = new MyCefBufferHolder();
	holder->len = len;
	holder->buffer = buffer;
	return holder;
}

CefV8Context* MyCefFrame_GetContext(CefFrame* wbFrame) {

	auto ctx = wbFrame->GetV8Context();
	ctx->AddRef();
	return ctx.get();

}
CefV8Value* MyCefJsGetGlobal(CefV8Context* cefV8Context) {

	auto globalObject = cefV8Context->GetGlobal();
	globalObject->AddRef();
	return globalObject.get();
}
CefV8Context* MyCefJs_EnterContext(CefV8Context* cefV8Context) {
	cefV8Context->Enter();
	auto context = cefV8Context->GetCurrentContext();
	context->AddRef();
	return context.get();
}
void MyCefJs_ExitContext(CefV8Context* cefV8Context) {
	cefV8Context->Exit();
}
bool MyCefJs_CefV8Value_IsFunc(CefV8Value* target)
{
	return target->IsFunction();
}
void MyCefJs_CefV8Value_SetValue_ByString(CefV8Value* target, const wchar_t* key, CefV8Value* value, int setAttribute)
{
	CefString cefstr(key);
	CefRefPtr<CefV8Value> nvalue = value;
	target->SetValue(cefstr, nvalue, (cef_v8_propertyattribute_t)setAttribute);
}
void MyCefJs_CefV8Value_SetValue_ByIndex(CefV8Value* target, int index, CefV8Value* value)
{
	target->SetValue(index, value);
}
void MyCefJs_CefV8Value_ReadAsString(CefV8Value* target, char16* outputBuffer, int outputBufferLen, int* actualLength)
{
	CefString str = target->GetStringValue();
	int str_len = (int)str.length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, str.c_str());
}
CefV8Value* MyCefJs_CreateFunction(const wchar_t* name, CefV8Handler* handler)
{
	auto cefFunc = CefV8Value::CreateFunction(name, handler);
	//since cefFunc is reference counting variable,
	//so before we send it out of this lib, we must add reference counting ***
	cefFunc->AddRef();
	return cefFunc.get();
}
CefV8Handler* MyCefJs_New_V8Handler(managed_callback callback) {

	//-----------------------------------------------
	class MyV8ManagedHandler : public CefV8Handler {
	public:		 
		managed_callback callback;
		MyV8ManagedHandler(managed_callback callback) {
			 
			this->callback = callback;
		}
		virtual bool Execute(const CefString& name,
			CefRefPtr<CefV8Value> object,
			const CefV8ValueList& arguments,
			CefRefPtr<CefV8Value>& retval,
			CefString& exception)
		{			
			if (callback) {

				INIT_MY_MET_ARGS(metArgs,3)  
				MyCefSetVoidPtr(&vargs[1], object);
				MyCefSetVoidPtr2(&vargs[2], &arguments);
				MyCefSetInt32(&vargs[3], (int32_t)arguments.size()); 
				//-------------------------------------------
				callback(CEF_MSG_MyV8ManagedHandler_Execute, &metArgs);
				//check result
				retval = CefV8Value::CreateString(GetStringHolder(&vargs[0])->value); 
				//retval = CefV8Value::CreateString("Hello, world!");
			}
			return true;
		}
	private:
		IMPLEMENT_REFCOUNTING(MyV8ManagedHandler);
	};
	//----------------------------------------------- 
	return new MyV8ManagedHandler(callback);
}
//---------------------------------------
CefV8Value* MyCefJs_ExecJsFunctionWithContext(CefV8Value* cefJsFunc, CefV8Context* context, const wchar_t* argAsJsonString)
{
	CefV8ValueList args;
	CefRefPtr<CefV8Value> retval;
	CefRefPtr<CefV8Exception> exception;

	args.push_back(CefV8Value::CreateString(argAsJsonString));

	auto result = cefJsFunc->ExecuteFunctionWithContext(context, NULL, args);
	if (!result) {
		return NULL;
	}
	else {
		result->AddRef();
		return result.get();
	}
}

bool MyCefJs_CefRegisterExtension(const wchar_t* extensionName, const wchar_t* extensionCode) {

	//-----------------------------------------------
	class MyV8ManagedHandler : public CefV8Handler {
	public:

		MyV8ManagedHandler() {
		}
		virtual bool Execute(const CefString& name,
			CefRefPtr<CefV8Value> object,
			const CefV8ValueList& arguments,
			CefRefPtr<CefV8Value>& retval,
			CefString& exception)
		{
			return true;
		}
	private:
		IMPLEMENT_REFCOUNTING(MyV8ManagedHandler);
	};
	//----------------------------------------------- 
	CefString name = extensionName;
	CefString code = extensionCode;
	CefRefPtr<CefV8Handler> handler = new MyV8ManagedHandler();
	return CefRegisterExtension(name, code, handler);
}
//-----------
void MyCefString_Read(CefString* cefStr, char16* outputBuffer, int outputBufferLen, int* actualLength)
{
	int str_len = (int)cefStr->length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, cefStr->c_str());
}
void MyCefStringHolder_Read(MyCefStringHolder* mycefStr, char16* outputBuffer, int outputBufferLen, int* actualLength)
{
	CefString* cefStr = &mycefStr->value;
	int str_len = (int)cefStr->length();
	*actualLength = str_len;
	auto cef_str = cefStr->c_str();
	memcpy_s(outputBuffer, str_len, cef_str, str_len);
}
void MyCefStringGetRawPtr(void* cefstring, char16** outputBuffer, int* actualLength) {
	CefString* cefStr = (CefString*)cefstring;
	*actualLength = (int)cefStr->length();
	*outputBuffer = (char16*)cefStr->c_str();;
}
//-----------
MY_DLL_EXPORT void MyCefJs_MetReadArgAsString(const CefV8ValueList* jsArgs, int index, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	auto value = jsArgs->at(index);
	CefString cefStr = value->GetStringValue();
	*actualLength = (int32_t)cefStr.length();
	wcscpy_s(outputBuffer, outputBufferLen, cefStr.c_str());
}
MY_DLL_EXPORT int MyCefJs_MetReadArgAsInt32(const CefV8ValueList* jsArgs, int index) {
	auto value = jsArgs->at(index);
	return value->GetIntValue();
}
MY_DLL_EXPORT CefV8Value* MyCefJs_MetReadArgAsCefV8Value(const CefV8ValueList* jsArgs, int index) {
	auto value = jsArgs->at(index);
	value->AddRef();
	return value;
}
MY_DLL_EXPORT CefV8Handler* MyCefJs_MetReadArgAsV8FuncHandle(const CefV8ValueList* jsArgs, int index) {
	auto value = jsArgs->at(index);
	value->AddRef();
	return value->GetFunctionHandler();
}