#include "mycef_buildconfig.h" //enable wrapper side func
#include "mycef_msg_const.h"
#include "mycef.h"
#include "MyCefJs.h"
#include "libcef_dll/ctocpp/v8value_ctocpp.h"
#include "libcef_dll/cpptoc/v8handler_cpptoc.h"
#include "libcef_dll/myext/ExportFuncAuto.h"

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

MyCefStringHolder* MyCefCreateStringHolder(const wchar_t* str) {
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
	char* buffer = new char[len + 1];
	memset(buffer, 0, len + 1);
	memcpy_s(buffer, len + 1, initData, len);
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
 
void* MyCefJs_New_V8Handler2(managed_callback callback) {

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
			if (this->callback) {
				CefV8HandlerExt::Execute(this->callback,
					name, object, arguments, retval, exception
				); 
			}
			//if (callback) {

			//	INIT_MY_MET_ARGS(metArgs, 3)
			//		MyCefSetVoidPtr(&vargs[1], object);
			//	MyCefSetVoidPtr2(&vargs[2], &arguments);
			//	MyCefSetInt32(&vargs[3], (int32_t)arguments.size());
			//	//-------------------------------------------
			//	callback(CEF_MSG_MyV8ManagedHandler_Execute, &metArgs);
			//	//check result
			//	retval = CefV8Value::CreateString(GetStringHolder(&vargs[0])->value);
			//	//retval = CefV8Value::CreateString("Hello, world!");
			//}
			return true;
		}
	private:
		IMPLEMENT_REFCOUNTING(MyV8ManagedHandler);
	};
	//----------------------------------------------- 
	CefRefPtr<CefV8Handler> myV8Handler = new MyV8ManagedHandler(callback); 
	return CefV8HandlerCppToC::Wrap(myV8Handler); 
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
	//copy utf16 char buff, copy in byte unit
	memcpy_s(outputBuffer, outputBufferLen * 2, cef_str, str_len * 2);
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