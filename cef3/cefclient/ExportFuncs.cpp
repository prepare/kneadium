#include "ExportFuncs.h"   
#include "mycef.h"
//static 

delTraceBack notifyListener= NULL;

//1.
int MyCefGetVersion()
{	
	 return 1003;
}
//2.
int RegisterManagedCallBack(void* funcPtr,int callbackKind)
{	
	switch(callbackKind)
	{
		case 0:
			{
				notifyListener= (delTraceBack)funcPtr;		    
				return 0;
			}break;
		case 1:
			{
			 
			}break;
		case 3:
			{   
				return 0;
			}break;
	} 
	return 1;
}