#include "cefclient/cefclient.h"
#include <windows.h>
#include <commdlg.h>
#include <shellapi.h>
#include <direct.h>
#include <sstream>
#include <string>
#include "include/cef_app.h"
#include "include/cef_browser.h"
#include "include/cef_frame.h"
#include "include/cef_runnable.h"
#include "cefclient/cefclient_osr_widget_win.h"
#include "cefclient/client_handler.h"
#include "cefclient/client_switches.h"
#include "cefclient/resource.h"
#include "cefclient/scheme_test.h"
#include "cefclient/string_util.h"

std::string MyAppGetWorkingDirectory();
void MyCefInitWorkingDir();
int MyAppInit01(HINSTANCE hInstance);
bool IsMultiMessageLoopApp(); 
//---------------------------------------------------------------------------
void MySetupWindowsEnd(HWND hWndParent,int x,int y,int width,int height);
std::string AppGetWorkingDirectory();
