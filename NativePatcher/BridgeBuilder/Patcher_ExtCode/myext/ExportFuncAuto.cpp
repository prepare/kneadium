#pragma once
#include "ExportFuncAuto.h"   




//----------------
const int MET_Release = 0;
//----------------
 
 
//
inline void SetCefStringToJsValue(jsvalue* value, const CefString& cefstr) {
	 
	MyCefStringHolder* str = new MyCefStringHolder();
	str->value = cefstr;
	//
	value->type = JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;
	value->ptr = str;
	value->i32 = str->value.length();
}
inline void MyCefSetVoidPtr(jsvalue* value, void* data) {
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = data;
}
inline void MyCefSetInt32(jsvalue* value, int32_t data) {
	value->type = JSVALUE_TYPE_INTEGER;
	value->i32 = data;
}
inline void MyCefSetUInt32(jsvalue* value, uint32_t data) {
	value->type = JSVALUE_TYPE_INTEGER;
	value->i32 = (int32_t)data;
}
inline void MyCefSetInt64(jsvalue* value, int64_t data) {
	value->type = JSVALUE_TYPE_INTEGER64;
	value->i64 = data;
}
inline void MyCefSetUInt64(jsvalue* value, uint64_t data) {
	value->type = JSVALUE_TYPE_INTEGER64;
	value->i64 = data;
}
inline void MyCefSetBool(jsvalue* value, bool data) {
	value->type = JSVALUE_TYPE_BOOLEAN;
	value->i32 = data ? 1 : 0;
}
inline void MyCefSetDouble(jsvalue* value, double data) {
	value->type = JSVALUE_TYPE_NUMBER;
	value->num = data;
}
inline void MyCefSetFloat(jsvalue* value, float data) {
	value->type = JSVALUE_TYPE_NUMBER;
	value->num = data;
}
inline MyCefStringHolder* GetStringHolder(jsvalue* value) {
	return (MyCefStringHolder*)value->ptr;
}
inline void MyCefSetCefPoint(jsvalue* value, CefPoint& data) {

	CefPoint* cefPoint = new CefPoint();
	value->type = JSVALUE_TYPE_WRAPPED;
	value->ptr = cefPoint;
}

class MyCefStringVisitor2 : public CefStringVisitor {
public:
	managed_callback mcallback;
	explicit MyCefStringVisitor2(CefRefPtr<CefBrowser> browser) : browser_(browser) {
		mcallback = NULL;
	}
	virtual void Visit(const CefString& string) OVERRIDE {

		if (mcallback) {
			MethodArgs metArgs;
			memset(&metArgs, 0, sizeof(MethodArgs));
			metArgs.SetArgAsNativeObject(0, &string);
			metArgs.SetArgType(0, JSVALUE_TYPE_NATIVE_CEFSTRING);
			this->mcallback(CEF_MSG_MyCefDomGetTextWalk_Visit, &metArgs);
		}
	}
private:
	CefRefPtr<CefBrowser> browser_;
	IMPLEMENT_REFCOUNTING(MyCefStringVisitor2);
};

const int CefFrame_Relase = 0;

const int CefFrame_IsValid = 1;
const int CefFrame_Undo = 2;
const int CefFrame_Redo = 3;
const int CefFrame_Cut = 4;
const int CefFrame_Copy = 5;
const int CefFrame_Paste = 6;
const int CefFrame_Delete = 7;
const int CefFrame_SelectAll = 8;
const int CefFrame_ViewSource = 9;

const int CefFrame_GetSource = 10;
const int CefFrame_GetSource_Ext = 30;

const int CefFrame_GetUrl = 11;
const int CefFrame_GetText = 12;
const int CefFrame_LoadRequest = 13;
const int CefFrame_LoadUrl = 14;
const int CefFrame_LoadString = 15;
const int CefFrame_ExecuteJavaScript = 16;
const int CefFrame_IsMain = 17;
const int CefFrame_IsFocused = 18;
const int CefFrame_GetName = 19;
const int CefFrame_GetIdentifer = 20;
const int CefFrame_GetParent = 21;
const int CefFrame_GetBrowser = 22;
const int CefFrame_GetV8Context = 23;
const int CefFrame_VisitDOM = 24;

MY_DLL_EXPORT void MyCefFrameCall2(cef_frame_t* cefFrame, int methodName, jsvalue* ret, jsvalue* v1, jsvalue* v2) {

	auto cefFrame1 = CefFrameCToCpp::Wrap(cefFrame);
	ret->type = JSVALUE_TYPE_EMPTY;
	switch (methodName) {
	case CefFrame_Relase: {
		//just wrap, no unwrap
	}break;
	case CefFrame_IsValid: {
		//return boolean value
		ret->i32 = cefFrame1->IsValid() ? 1 : 0;
		ret->type = JSVALUE_TYPE_BOOLEAN;
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetSource:
	{
		cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetSource_Ext:
	{
		//void GetSource(CefRefPtr<CefStringVisitor> visitor) OVERRIDE;
		auto bwVisitor = new MyCefStringVisitor2(cefFrame1->GetBrowser());
		bwVisitor->mcallback = MyCefJsValueGetManagedCallback(v1);
		cefFrame1->GetSource(bwVisitor);
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetUrl:
	{
		SetCefStringToJsValue(ret, cefFrame1->GetURL());
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetText: {
		cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back  
	}break;
	case CefFrame_LoadUrl: {

		/*MyCefStringHolder* holder = (MyCefStringHolder*)v1->ptr;
		cefFrame1->LoadURL(holder->value);*/

		cefFrame1->LoadURL(GetStringHolder(v1)->value);
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_LoadString: {

		/*	MyCefStringHolder* holder1 = (MyCefStringHolder*)v1->ptr;
		MyCefStringHolder* holder2 = (MyCefStringHolder*)v2->ptr;*/
		cefFrame1->LoadStringW(GetStringHolder(v1)->value, GetStringHolder(v2)->value);
		CefFrameCToCpp::Unwrap(cefFrame1); //unwrap before return back 
	}break;
	case CefFrame_GetParent: {
		auto ret_result = cefFrame1->GetParent();
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefFrameCToCpp::Unwrap(ret_result);
		CefFrameCToCpp::Unwrap(cefFrame1);
	}break;
	case CefFrame_GetBrowser: {
		auto ret_result = cefFrame1->GetBrowser();
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefBrowserCToCpp::Unwrap(ret_result);
		CefFrameCToCpp::Unwrap(cefFrame1);
	}break;
	case CefFrame_GetV8Context: {
		auto ret_result = cefFrame1->GetV8Context();
		ret->type = JSVALUE_TYPE_WRAPPED;
		ret->ptr = CefV8ContextCToCpp::Unwrap(ret_result);
		CefFrameCToCpp::Unwrap(cefFrame1);
	}break;
	}
}

const int TypeName_StringVisitor = 1;

void MyCefRelease(void* ptr, int typeName) {
	switch (typeName) {
	case TypeName_StringVisitor: {
		CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)ptr);
	}break;
	}
}