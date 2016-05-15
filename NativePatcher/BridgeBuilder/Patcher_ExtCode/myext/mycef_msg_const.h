#pragma once 
//----------------------------------------------------------------------
//cef msg constant
//----------------------------------------------------------------------
 
const int CEF_MSG_ClientHandler_NotifyBrowserClosed = 100;
const int CEF_MSG_ClientHandler_NotifyBrowserCreated = 101;
const int CEF_MSG_ClientHandler_OnBeforePopup = 104;
const int CEF_MSG_ClientHandler_OnConsoleMessage = 106;
const int CEF_MSG_ClientHandler_ShowDevTools = 107;
const int CEF_MSG_ClientHandler_CloseDevTools = 108;
const int CEF_MSG_ClientHandler_OnBeforeContextMenu = 109;

const int CEF_MSG_ClientHandler_OnLoadError = 119;
const int CEF_MSG_ClientHandler_SetResourceManager = 140;
const int CEF_MSG_RequestUrlFilter2 = 142;
const int CEF_MSG_BinaryResouceProvider_OnRequest = 145;

const int CEF_MSG_RenderDelegate_OnWebKitInitialized = 201;
const int CEF_MSG_RenderDelegate_OnContextCreated = 202;
const int CEF_MSG_RenderDelegate_OnContextReleased = 203;
const int CEF_MSG_OnQuery = 205;

const int CEF_MSG_MyV8ManagedHandler_Execute = 301;
const int CEF_MSG_HereOnRenderer = 303;

const int CEF_MSG_ClientHandler_OnPreKeyEvent = 501;
const int CEF_MSG_ClientHandler_NotifyTitle = 502;
const int CEF_MSG_ClientHandler_NotifyAddress = 503;
