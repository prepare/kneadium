//MIT, 2015-2017, EngineKit, WinterDev


#include "mycef_msg_const.h"
#include "mycef.h"





 
MY_DLL_EXPORT void MyCefString_Read(CefString* cefStr, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	int str_len = (int)cefStr->length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, cefStr->c_str());
}
MY_DLL_EXPORT void MyCefStringHolder_Read(MyCefStringHolder* mycefStr, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	CefString* cefStr = &mycefStr->value;
	int str_len = (int)cefStr->length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, cefStr->c_str());
}


MY_DLL_EXPORT void MyCefJs_CefV8Value_ReadAsString(CefV8Value* target, wchar_t* outputBuffer, int outputBufferLen, int* actualLength)
{
	CefString str = target->GetStringValue();
	int str_len = (int)str.length();
	*actualLength = str_len;
	wcscpy_s(outputBuffer, outputBufferLen, str.c_str());
}

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




//part4: javascript context
MY_DLL_EXPORT CefV8Context* MyCefJsGetCurrentContext() {
	auto currentContext = CefV8Context::GetCurrentContext();
	currentContext->AddRef();
	return currentContext.get();
}
MY_DLL_EXPORT  CefV8Context* MyCefJs_GetEnteredContext() {
	auto enteredContext = CefV8Context::GetEnteredContext();
	enteredContext->AddRef();
	return enteredContext.get();
}
MY_DLL_EXPORT  CefV8Context* MyCefJs_ContextEnter() {
	auto enteredContext = CefV8Context::GetEnteredContext();
	enteredContext->AddRef();
	return enteredContext.get();
}
MY_DLL_EXPORT MyCefStringHolder* MyCefCreateCefString(const wchar_t*  str) {
	MyCefStringHolder* str_h = new MyCefStringHolder();
	auto cefStr = CefV8Value::CreateString(str);
	str_h->any = cefStr;

	return str_h;
}

MY_DLL_EXPORT CefV8Context* MyCefJsFrameContext(CefFrame* wbFrame) {

	auto ctx = wbFrame->GetV8Context();
	ctx->AddRef();
	return ctx.get();

}
MY_DLL_EXPORT CefV8Value* MyCefJsGetGlobal(CefV8Context* cefV8Context) {

	auto globalObject = cefV8Context->GetGlobal();
	globalObject->AddRef();
	return globalObject.get();
}
MY_DLL_EXPORT CefV8Context* MyCefJs_EnterContext(CefV8Context* cefV8Context) {
	cefV8Context->Enter();
	auto context = cefV8Context->GetCurrentContext();
	context->AddRef();
	return context.get();
}
MY_DLL_EXPORT void MyCefJs_ExitContext(CefV8Context* cefV8Context) {
	cefV8Context->Exit();
}
MY_DLL_EXPORT bool MyCefJs_CefV8Value_IsFunc(CefV8Value* target)
{
	return target->IsFunction();
}
MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByString(CefV8Value* target, const wchar_t* key, CefV8Value* value, int setAttribute)
{
	CefString cefstr(key);
	CefRefPtr<CefV8Value> nvalue = value;
	target->SetValue(cefstr, nvalue, (cef_v8_propertyattribute_t)setAttribute);
}
MY_DLL_EXPORT void MyCefJs_CefV8Value_SetValue_ByIndex(CefV8Value* target, int index, CefV8Value* value)
{
	target->SetValue(index, value);
}
MY_DLL_EXPORT CefV8Value* MyCefJs_CreateFunction(const wchar_t* name, CefV8Handler* handler)
{
	auto cefFunc = CefV8Value::CreateFunction(name, handler);
	//since cefFunc is reference counting variable,
	//so before we send it out of this lib, we must add reference counting ***
	cefFunc->AddRef();
	return cefFunc.get();
}
MY_DLL_EXPORT CefV8Handler* MyCefJs_New_V8Handler(managed_callback callback) {

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

				MethodArgs metArgs;
				memset(&metArgs, 0, sizeof(MethodArgs));
				metArgs.SetArgAsNativeObject(0, object);
				metArgs.SetArgAsNativeObject(1, &arguments);
				metArgs.SetArgAsInt32(2, (int32_t)arguments.size());
				//-------------------------------------------
				callback(CEF_MSG_MyV8ManagedHandler_Execute, &metArgs);
				//check result
				retval = CefV8Value::CreateString(metArgs.ReadOutputAsString(0));
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
MY_DLL_EXPORT CefV8Value* MyCefJs_ExecJsFunctionWithContext(CefV8Value* cefJsFunc, CefV8Context* context, const wchar_t* argAsJsonString)
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


