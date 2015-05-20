#include "mycef.h"
void MethodArgs::SetArgAsString(int argIndex,const wchar_t* str)
{
	switch(argIndex){
			case 0:{
				this->arg0.type = JSVALUE_TYPE_STRING;
				this->arg0.length = wcslen(str);
				this->arg0.value.str = (uint16_t*)str;
		   }break;
	}
}