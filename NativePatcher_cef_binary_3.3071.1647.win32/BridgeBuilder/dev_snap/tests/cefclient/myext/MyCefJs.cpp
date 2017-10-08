#include "mycef_buildconfig.h" //enable wrapper side func
#include "mycef_msg_const.h"
#include "mycef.h"
#include "MyCefJs.h"
#include "libcef_dll/ctocpp/v8value_ctocpp.h"
#include "libcef_dll/cpptoc/v8handler_cpptoc.h"
#include "libcef_dll/myext/ExportFuncAuto.h"

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
		return true;
	}
private:
	IMPLEMENT_REFCOUNTING(MyV8ManagedHandler);
};
//----------------------------------------------- 

void* MyCefJs_New_V8Handler(managed_callback callback) {
	CefRefPtr<CefV8Handler> myV8Handler = new MyV8ManagedHandler(callback);
	return CefV8HandlerCppToC::Wrap(myV8Handler);
}
bool MyCefJs_CefRegisterExtension(const wchar_t* extensionName, const wchar_t* extensionCode, void* handler) {

	CefString name = extensionName;
	CefString code = extensionCode; 
	return CefRegisterExtension(name, code, CefV8HandlerCppToC::Unwrap((cef_v8handler_t*)handler));
}
