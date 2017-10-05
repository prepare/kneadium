//MIT, 2015-2017, WinterDev
#pragma once 
//----------------------------------------------------------------------
//my custom msgs

const int CEF_MSG_ClientHandler_NotifyBrowserClosing = 100;
const int CEF_MSG_ClientHandler_NotifyBrowserClosed = 101;
const int CEF_MSG_ClientHandler_NotifyBrowserCreated = 102;



const int CEF_MSG_ClientHandler_CloseDevTools = 108;

const int CEF_MSG_ClientHandler_SetResourceManager = 140;
const int CEF_MSG_RequestUrlFilter2 = 142;
const int CEF_MSG_BinaryResouceProvider_OnRequest = 145;

//
const int CEF_MSG_CefSettings_Init = 150;
const int CEF_MSG_MainContext_GetConsoleLogPath = 151;
const int CEF_MSG_OSR_Render = 155;

const int CEF_MSG_OnQuery = 205;


const int CEF_MSG_MyV8ManagedHandler_Execute = 301;
const int CEF_MSG_HereOnRenderer = 303;

const int CEF_MSG_ClientHandler_NotifyTitle = 502;
const int CEF_MSG_ClientHandler_NotifyAddress = 503;


//---------------------------------------------------------------------------------
//msg from cs to native
//cef setting const
const int CEF_SETTINGS_BrowserSubProcessPath = 9;
const int CEF_SETTINGS_CachePath = 10;
const int CEF_SETTINGS_ResourcesDirPath = 11;
const int CEF_SETTINGS_UserDirPath = 12;
const int CEF_SETTINGS_LocalDirPath = 14;
const int CEF_SETTINGS_IgnoreCertError = 15;
const int CEF_SETTINGS_RemoteDebuggingPort = 17;
const int CEF_SETTINGS_LogFile = 18;
const int CEF_SETTINGS_LogSeverity = 19;

//---------------------------------------------------------------------------------