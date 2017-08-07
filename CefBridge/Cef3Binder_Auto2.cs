//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{

    // [virtual] class CefApp
    /*168*/
    /*166*/
    static class MetName_CefApp
    {
        /*167*/
    }



    // [virtual] class CefBrowser
    /*305*/
    /*282*/
    static class MetName_CefBrowser
    {
        /*283*/
        public const int CefBrowser_GetHost_1 = 1;
        /*284*/
        public const int CefBrowser_CanGoBack_2 = 2;
        /*285*/
        public const int CefBrowser_GoBack_3 = 3;
        /*286*/
        public const int CefBrowser_CanGoForward_4 = 4;
        /*287*/
        public const int CefBrowser_GoForward_5 = 5;
        /*288*/
        public const int CefBrowser_IsLoading_6 = 6;
        /*289*/
        public const int CefBrowser_Reload_7 = 7;
        /*290*/
        public const int CefBrowser_ReloadIgnoreCache_8 = 8;
        /*291*/
        public const int CefBrowser_StopLoad_9 = 9;
        /*292*/
        public const int CefBrowser_GetIdentifier_10 = 10;
        /*293*/
        public const int CefBrowser_IsSame_11 = 11;
        /*294*/
        public const int CefBrowser_IsPopup_12 = 12;
        /*295*/
        public const int CefBrowser_HasDocument_13 = 13;
        /*296*/
        public const int CefBrowser_GetMainFrame_14 = 14;
        /*297*/
        public const int CefBrowser_GetFocusedFrame_15 = 15;
        /*298*/
        public const int CefBrowser_GetFrame_16 = 16;
        /*299*/
        public const int CefBrowser_GetFrame_17 = 17;
        /*300*/
        public const int CefBrowser_GetFrameCount_18 = 18;
        /*301*/
        public const int CefBrowser_GetFrameIdentifiers_19 = 19;
        /*302*/
        public const int CefBrowser_GetFrameNames_20 = 20;
        /*303*/
        public const int CefBrowser_SendProcessMessage_21 = 21;
        /*304*/
    }



    // [virtual] class CefNavigationEntryVisitor
    /*316*/
    /*314*/
    static class MetName_CefNavigationEntryVisitor
    {
        /*315*/
    }



    // [virtual] class CefBrowserHost
    /*639*/
    /*585*/
    static class MetName_CefBrowserHost
    {
        /*586*/
        public const int CefBrowserHost_GetBrowser_1 = 1;
        /*587*/
        public const int CefBrowserHost_CloseBrowser_2 = 2;
        /*588*/
        public const int CefBrowserHost_TryCloseBrowser_3 = 3;
        /*589*/
        public const int CefBrowserHost_SetFocus_4 = 4;
        /*590*/
        public const int CefBrowserHost_GetWindowHandle_5 = 5;
        /*591*/
        public const int CefBrowserHost_GetOpenerWindowHandle_6 = 6;
        /*592*/
        public const int CefBrowserHost_HasView_7 = 7;
        /*593*/
        public const int CefBrowserHost_GetClient_8 = 8;
        /*594*/
        public const int CefBrowserHost_GetRequestContext_9 = 9;
        /*595*/
        public const int CefBrowserHost_GetZoomLevel_10 = 10;
        /*596*/
        public const int CefBrowserHost_SetZoomLevel_11 = 11;
        /*597*/
        public const int CefBrowserHost_RunFileDialog_12 = 12;
        /*598*/
        public const int CefBrowserHost_StartDownload_13 = 13;
        /*599*/
        public const int CefBrowserHost_DownloadImage_14 = 14;
        /*600*/
        public const int CefBrowserHost_Print_15 = 15;
        /*601*/
        public const int CefBrowserHost_PrintToPDF_16 = 16;
        /*602*/
        public const int CefBrowserHost_Find_17 = 17;
        /*603*/
        public const int CefBrowserHost_StopFinding_18 = 18;
        /*604*/
        public const int CefBrowserHost_ShowDevTools_19 = 19;
        /*605*/
        public const int CefBrowserHost_CloseDevTools_20 = 20;
        /*606*/
        public const int CefBrowserHost_HasDevTools_21 = 21;
        /*607*/
        public const int CefBrowserHost_GetNavigationEntries_22 = 22;
        /*608*/
        public const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = 23;
        /*609*/
        public const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = 24;
        /*610*/
        public const int CefBrowserHost_ReplaceMisspelling_25 = 25;
        /*611*/
        public const int CefBrowserHost_AddWordToDictionary_26 = 26;
        /*612*/
        public const int CefBrowserHost_IsWindowRenderingDisabled_27 = 27;
        /*613*/
        public const int CefBrowserHost_WasResized_28 = 28;
        /*614*/
        public const int CefBrowserHost_WasHidden_29 = 29;
        /*615*/
        public const int CefBrowserHost_NotifyScreenInfoChanged_30 = 30;
        /*616*/
        public const int CefBrowserHost_Invalidate_31 = 31;
        /*617*/
        public const int CefBrowserHost_SendKeyEvent_32 = 32;
        /*618*/
        public const int CefBrowserHost_SendMouseClickEvent_33 = 33;
        /*619*/
        public const int CefBrowserHost_SendMouseMoveEvent_34 = 34;
        /*620*/
        public const int CefBrowserHost_SendMouseWheelEvent_35 = 35;
        /*621*/
        public const int CefBrowserHost_SendFocusEvent_36 = 36;
        /*622*/
        public const int CefBrowserHost_SendCaptureLostEvent_37 = 37;
        /*623*/
        public const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = 38;
        /*624*/
        public const int CefBrowserHost_GetWindowlessFrameRate_39 = 39;
        /*625*/
        public const int CefBrowserHost_SetWindowlessFrameRate_40 = 40;
        /*626*/
        public const int CefBrowserHost_ImeSetComposition_41 = 41;
        /*627*/
        public const int CefBrowserHost_ImeCommitText_42 = 42;
        /*628*/
        public const int CefBrowserHost_ImeFinishComposingText_43 = 43;
        /*629*/
        public const int CefBrowserHost_ImeCancelComposition_44 = 44;
        /*630*/
        public const int CefBrowserHost_DragTargetDragEnter_45 = 45;
        /*631*/
        public const int CefBrowserHost_DragTargetDragOver_46 = 46;
        /*632*/
        public const int CefBrowserHost_DragTargetDragLeave_47 = 47;
        /*633*/
        public const int CefBrowserHost_DragTargetDrop_48 = 48;
        /*634*/
        public const int CefBrowserHost_DragSourceEndedAt_49 = 49;
        /*635*/
        public const int CefBrowserHost_DragSourceSystemDragEnded_50 = 50;
        /*636*/
        public const int CefBrowserHost_GetVisibleNavigationEntry_51 = 51;
        /*637*/
        public const int CefBrowserHost_SetAccessibilityState_52 = 52;
        /*638*/
    }



    // [virtual] class CefClient
    /*650*/
    /*648*/
    static class MetName_CefClient
    {
        /*649*/
    }



    // [virtual] class CefCommandLine
    /*781*/
    /*759*/
    static class MetName_CefCommandLine
    {
        /*760*/
        public const int CefCommandLine_IsValid_1 = 1;
        /*761*/
        public const int CefCommandLine_IsReadOnly_2 = 2;
        /*762*/
        public const int CefCommandLine_Copy_3 = 3;
        /*763*/
        public const int CefCommandLine_InitFromArgv_4 = 4;
        /*764*/
        public const int CefCommandLine_InitFromString_5 = 5;
        /*765*/
        public const int CefCommandLine_Reset_6 = 6;
        /*766*/
        public const int CefCommandLine_GetArgv_7 = 7;
        /*767*/
        public const int CefCommandLine_GetCommandLineString_8 = 8;
        /*768*/
        public const int CefCommandLine_GetProgram_9 = 9;
        /*769*/
        public const int CefCommandLine_SetProgram_10 = 10;
        /*770*/
        public const int CefCommandLine_HasSwitches_11 = 11;
        /*771*/
        public const int CefCommandLine_HasSwitch_12 = 12;
        /*772*/
        public const int CefCommandLine_GetSwitchValue_13 = 13;
        /*773*/
        public const int CefCommandLine_GetSwitches_14 = 14;
        /*774*/
        public const int CefCommandLine_AppendSwitch_15 = 15;
        /*775*/
        public const int CefCommandLine_AppendSwitchWithValue_16 = 16;
        /*776*/
        public const int CefCommandLine_HasArguments_17 = 17;
        /*777*/
        public const int CefCommandLine_GetArguments_18 = 18;
        /*778*/
        public const int CefCommandLine_AppendArgument_19 = 19;
        /*779*/
        public const int CefCommandLine_PrependWrapper_20 = 20;
        /*780*/
    }



    // [virtual] class CefContextMenuParams
    /*918*/
    /*895*/
    static class MetName_CefContextMenuParams
    {
        /*896*/
        public const int CefContextMenuParams_GetXCoord_1 = 1;
        /*897*/
        public const int CefContextMenuParams_GetYCoord_2 = 2;
        /*898*/
        public const int CefContextMenuParams_GetTypeFlags_3 = 3;
        /*899*/
        public const int CefContextMenuParams_GetLinkUrl_4 = 4;
        /*900*/
        public const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = 5;
        /*901*/
        public const int CefContextMenuParams_GetSourceUrl_6 = 6;
        /*902*/
        public const int CefContextMenuParams_HasImageContents_7 = 7;
        /*903*/
        public const int CefContextMenuParams_GetTitleText_8 = 8;
        /*904*/
        public const int CefContextMenuParams_GetPageUrl_9 = 9;
        /*905*/
        public const int CefContextMenuParams_GetFrameUrl_10 = 10;
        /*906*/
        public const int CefContextMenuParams_GetFrameCharset_11 = 11;
        /*907*/
        public const int CefContextMenuParams_GetMediaType_12 = 12;
        /*908*/
        public const int CefContextMenuParams_GetMediaStateFlags_13 = 13;
        /*909*/
        public const int CefContextMenuParams_GetSelectionText_14 = 14;
        /*910*/
        public const int CefContextMenuParams_GetMisspelledWord_15 = 15;
        /*911*/
        public const int CefContextMenuParams_GetDictionarySuggestions_16 = 16;
        /*912*/
        public const int CefContextMenuParams_IsEditable_17 = 17;
        /*913*/
        public const int CefContextMenuParams_IsSpellCheckEnabled_18 = 18;
        /*914*/
        public const int CefContextMenuParams_GetEditStateFlags_19 = 19;
        /*915*/
        public const int CefContextMenuParams_IsCustomMenu_20 = 20;
        /*916*/
        public const int CefContextMenuParams_IsPepperMenu_21 = 21;
        /*917*/
    }



    // [virtual] class CefCookieManager
    /*971*/
    /*962*/
    static class MetName_CefCookieManager
    {
        /*963*/
        public const int CefCookieManager_SetSupportedSchemes_1 = 1;
        /*964*/
        public const int CefCookieManager_VisitAllCookies_2 = 2;
        /*965*/
        public const int CefCookieManager_VisitUrlCookies_3 = 3;
        /*966*/
        public const int CefCookieManager_SetCookie_4 = 4;
        /*967*/
        public const int CefCookieManager_DeleteCookies_5 = 5;
        /*968*/
        public const int CefCookieManager_SetStoragePath_6 = 6;
        /*969*/
        public const int CefCookieManager_FlushStore_7 = 7;
        /*970*/
    }



    // [virtual] class CefCookieVisitor
    /*982*/
    /*980*/
    static class MetName_CefCookieVisitor
    {
        /*981*/
    }



    // [virtual] class CefDOMVisitor
    /*993*/
    /*991*/
    static class MetName_CefDOMVisitor
    {
        /*992*/
    }



    // [virtual] class CefDOMDocument
    /*1088*/
    /*1072*/
    static class MetName_CefDOMDocument
    {
        /*1073*/
        public const int CefDOMDocument_GetType_1 = 1;
        /*1074*/
        public const int CefDOMDocument_GetDocument_2 = 2;
        /*1075*/
        public const int CefDOMDocument_GetBody_3 = 3;
        /*1076*/
        public const int CefDOMDocument_GetHead_4 = 4;
        /*1077*/
        public const int CefDOMDocument_GetTitle_5 = 5;
        /*1078*/
        public const int CefDOMDocument_GetElementById_6 = 6;
        /*1079*/
        public const int CefDOMDocument_GetFocusedNode_7 = 7;
        /*1080*/
        public const int CefDOMDocument_HasSelection_8 = 8;
        /*1081*/
        public const int CefDOMDocument_GetSelectionStartOffset_9 = 9;
        /*1082*/
        public const int CefDOMDocument_GetSelectionEndOffset_10 = 10;
        /*1083*/
        public const int CefDOMDocument_GetSelectionAsMarkup_11 = 11;
        /*1084*/
        public const int CefDOMDocument_GetSelectionAsText_12 = 12;
        /*1085*/
        public const int CefDOMDocument_GetBaseURL_13 = 13;
        /*1086*/
        public const int CefDOMDocument_GetCompleteURL_14 = 14;
        /*1087*/
    }



    // [virtual] class CefDOMNode
    /*1255*/
    /*1227*/
    static class MetName_CefDOMNode
    {
        /*1228*/
        public const int CefDOMNode_GetType_1 = 1;
        /*1229*/
        public const int CefDOMNode_IsText_2 = 2;
        /*1230*/
        public const int CefDOMNode_IsElement_3 = 3;
        /*1231*/
        public const int CefDOMNode_IsEditable_4 = 4;
        /*1232*/
        public const int CefDOMNode_IsFormControlElement_5 = 5;
        /*1233*/
        public const int CefDOMNode_GetFormControlElementType_6 = 6;
        /*1234*/
        public const int CefDOMNode_IsSame_7 = 7;
        /*1235*/
        public const int CefDOMNode_GetName_8 = 8;
        /*1236*/
        public const int CefDOMNode_GetValue_9 = 9;
        /*1237*/
        public const int CefDOMNode_SetValue_10 = 10;
        /*1238*/
        public const int CefDOMNode_GetAsMarkup_11 = 11;
        /*1239*/
        public const int CefDOMNode_GetDocument_12 = 12;
        /*1240*/
        public const int CefDOMNode_GetParent_13 = 13;
        /*1241*/
        public const int CefDOMNode_GetPreviousSibling_14 = 14;
        /*1242*/
        public const int CefDOMNode_GetNextSibling_15 = 15;
        /*1243*/
        public const int CefDOMNode_HasChildren_16 = 16;
        /*1244*/
        public const int CefDOMNode_GetFirstChild_17 = 17;
        /*1245*/
        public const int CefDOMNode_GetLastChild_18 = 18;
        /*1246*/
        public const int CefDOMNode_GetElementTagName_19 = 19;
        /*1247*/
        public const int CefDOMNode_HasElementAttributes_20 = 20;
        /*1248*/
        public const int CefDOMNode_HasElementAttribute_21 = 21;
        /*1249*/
        public const int CefDOMNode_GetElementAttribute_22 = 22;
        /*1250*/
        public const int CefDOMNode_GetElementAttributes_23 = 23;
        /*1251*/
        public const int CefDOMNode_SetElementAttribute_24 = 24;
        /*1252*/
        public const int CefDOMNode_GetElementInnerText_25 = 25;
        /*1253*/
        public const int CefDOMNode_GetElementBounds_26 = 26;
        /*1254*/
    }



    // [virtual] class CefDownloadItem
    /*1368*/
    /*1349*/
    static class MetName_CefDownloadItem
    {
        /*1350*/
        public const int CefDownloadItem_IsValid_1 = 1;
        /*1351*/
        public const int CefDownloadItem_IsInProgress_2 = 2;
        /*1352*/
        public const int CefDownloadItem_IsComplete_3 = 3;
        /*1353*/
        public const int CefDownloadItem_IsCanceled_4 = 4;
        /*1354*/
        public const int CefDownloadItem_GetCurrentSpeed_5 = 5;
        /*1355*/
        public const int CefDownloadItem_GetPercentComplete_6 = 6;
        /*1356*/
        public const int CefDownloadItem_GetTotalBytes_7 = 7;
        /*1357*/
        public const int CefDownloadItem_GetReceivedBytes_8 = 8;
        /*1358*/
        public const int CefDownloadItem_GetStartTime_9 = 9;
        /*1359*/
        public const int CefDownloadItem_GetEndTime_10 = 10;
        /*1360*/
        public const int CefDownloadItem_GetFullPath_11 = 11;
        /*1361*/
        public const int CefDownloadItem_GetId_12 = 12;
        /*1362*/
        public const int CefDownloadItem_GetURL_13 = 13;
        /*1363*/
        public const int CefDownloadItem_GetOriginalUrl_14 = 14;
        /*1364*/
        public const int CefDownloadItem_GetSuggestedFileName_15 = 15;
        /*1365*/
        public const int CefDownloadItem_GetContentDisposition_16 = 16;
        /*1366*/
        public const int CefDownloadItem_GetMimeType_17 = 17;
        /*1367*/
    }



    // [virtual] class CefDragData
    /*1529*/
    /*1502*/
    static class MetName_CefDragData
    {
        /*1503*/
        public const int CefDragData_Clone_1 = 1;
        /*1504*/
        public const int CefDragData_IsReadOnly_2 = 2;
        /*1505*/
        public const int CefDragData_IsLink_3 = 3;
        /*1506*/
        public const int CefDragData_IsFragment_4 = 4;
        /*1507*/
        public const int CefDragData_IsFile_5 = 5;
        /*1508*/
        public const int CefDragData_GetLinkURL_6 = 6;
        /*1509*/
        public const int CefDragData_GetLinkTitle_7 = 7;
        /*1510*/
        public const int CefDragData_GetLinkMetadata_8 = 8;
        /*1511*/
        public const int CefDragData_GetFragmentText_9 = 9;
        /*1512*/
        public const int CefDragData_GetFragmentHtml_10 = 10;
        /*1513*/
        public const int CefDragData_GetFragmentBaseURL_11 = 11;
        /*1514*/
        public const int CefDragData_GetFileName_12 = 12;
        /*1515*/
        public const int CefDragData_GetFileContents_13 = 13;
        /*1516*/
        public const int CefDragData_GetFileNames_14 = 14;
        /*1517*/
        public const int CefDragData_SetLinkURL_15 = 15;
        /*1518*/
        public const int CefDragData_SetLinkTitle_16 = 16;
        /*1519*/
        public const int CefDragData_SetLinkMetadata_17 = 17;
        /*1520*/
        public const int CefDragData_SetFragmentText_18 = 18;
        /*1521*/
        public const int CefDragData_SetFragmentHtml_19 = 19;
        /*1522*/
        public const int CefDragData_SetFragmentBaseURL_20 = 20;
        /*1523*/
        public const int CefDragData_ResetFileContents_21 = 21;
        /*1524*/
        public const int CefDragData_AddFile_22 = 22;
        /*1525*/
        public const int CefDragData_GetImage_23 = 23;
        /*1526*/
        public const int CefDragData_GetImageHotspot_24 = 24;
        /*1527*/
        public const int CefDragData_HasImage_25 = 25;
        /*1528*/
    }



    // [virtual] class CefFrame
    /*1684*/
    /*1658*/
    static class MetName_CefFrame
    {
        /*1659*/
        public const int CefFrame_IsValid_1 = 1;
        /*1660*/
        public const int CefFrame_Undo_2 = 2;
        /*1661*/
        public const int CefFrame_Redo_3 = 3;
        /*1662*/
        public const int CefFrame_Cut_4 = 4;
        /*1663*/
        public const int CefFrame_Copy_5 = 5;
        /*1664*/
        public const int CefFrame_Paste_6 = 6;
        /*1665*/
        public const int CefFrame_Delete_7 = 7;
        /*1666*/
        public const int CefFrame_SelectAll_8 = 8;
        /*1667*/
        public const int CefFrame_ViewSource_9 = 9;
        /*1668*/
        public const int CefFrame_GetSource_10 = 10;
        /*1669*/
        public const int CefFrame_GetText_11 = 11;
        /*1670*/
        public const int CefFrame_LoadRequest_12 = 12;
        /*1671*/
        public const int CefFrame_LoadURL_13 = 13;
        /*1672*/
        public const int CefFrame_LoadString_14 = 14;
        /*1673*/
        public const int CefFrame_ExecuteJavaScript_15 = 15;
        /*1674*/
        public const int CefFrame_IsMain_16 = 16;
        /*1675*/
        public const int CefFrame_IsFocused_17 = 17;
        /*1676*/
        public const int CefFrame_GetName_18 = 18;
        /*1677*/
        public const int CefFrame_GetIdentifier_19 = 19;
        /*1678*/
        public const int CefFrame_GetParent_20 = 20;
        /*1679*/
        public const int CefFrame_GetURL_21 = 21;
        /*1680*/
        public const int CefFrame_GetBrowser_22 = 22;
        /*1681*/
        public const int CefFrame_GetV8Context_23 = 23;
        /*1682*/
        public const int CefFrame_VisitDOM_24 = 24;
        /*1683*/
    }



    // [virtual] class CefImage
    /*1773*/
    /*1758*/
    static class MetName_CefImage
    {
        /*1759*/
        public const int CefImage_IsEmpty_1 = 1;
        /*1760*/
        public const int CefImage_IsSame_2 = 2;
        /*1761*/
        public const int CefImage_AddBitmap_3 = 3;
        /*1762*/
        public const int CefImage_AddPNG_4 = 4;
        /*1763*/
        public const int CefImage_AddJPEG_5 = 5;
        /*1764*/
        public const int CefImage_GetWidth_6 = 6;
        /*1765*/
        public const int CefImage_GetHeight_7 = 7;
        /*1766*/
        public const int CefImage_HasRepresentation_8 = 8;
        /*1767*/
        public const int CefImage_RemoveRepresentation_9 = 9;
        /*1768*/
        public const int CefImage_GetRepresentationInfo_10 = 10;
        /*1769*/
        public const int CefImage_GetAsBitmap_11 = 11;
        /*1770*/
        public const int CefImage_GetAsPNG_12 = 12;
        /*1771*/
        public const int CefImage_GetAsJPEG_13 = 13;
        /*1772*/
    }



    // [virtual] class CefMenuModel
    /*2120*/
    /*2062*/
    static class MetName_CefMenuModel
    {
        /*2063*/
        public const int CefMenuModel_IsSubMenu_1 = 1;
        /*2064*/
        public const int CefMenuModel_Clear_2 = 2;
        /*2065*/
        public const int CefMenuModel_GetCount_3 = 3;
        /*2066*/
        public const int CefMenuModel_AddSeparator_4 = 4;
        /*2067*/
        public const int CefMenuModel_AddItem_5 = 5;
        /*2068*/
        public const int CefMenuModel_AddCheckItem_6 = 6;
        /*2069*/
        public const int CefMenuModel_AddRadioItem_7 = 7;
        /*2070*/
        public const int CefMenuModel_AddSubMenu_8 = 8;
        /*2071*/
        public const int CefMenuModel_InsertSeparatorAt_9 = 9;
        /*2072*/
        public const int CefMenuModel_InsertItemAt_10 = 10;
        /*2073*/
        public const int CefMenuModel_InsertCheckItemAt_11 = 11;
        /*2074*/
        public const int CefMenuModel_InsertRadioItemAt_12 = 12;
        /*2075*/
        public const int CefMenuModel_InsertSubMenuAt_13 = 13;
        /*2076*/
        public const int CefMenuModel_Remove_14 = 14;
        /*2077*/
        public const int CefMenuModel_RemoveAt_15 = 15;
        /*2078*/
        public const int CefMenuModel_GetIndexOf_16 = 16;
        /*2079*/
        public const int CefMenuModel_GetCommandIdAt_17 = 17;
        /*2080*/
        public const int CefMenuModel_SetCommandIdAt_18 = 18;
        /*2081*/
        public const int CefMenuModel_GetLabel_19 = 19;
        /*2082*/
        public const int CefMenuModel_GetLabelAt_20 = 20;
        /*2083*/
        public const int CefMenuModel_SetLabel_21 = 21;
        /*2084*/
        public const int CefMenuModel_SetLabelAt_22 = 22;
        /*2085*/
        public const int CefMenuModel_GetType_23 = 23;
        /*2086*/
        public const int CefMenuModel_GetTypeAt_24 = 24;
        /*2087*/
        public const int CefMenuModel_GetGroupId_25 = 25;
        /*2088*/
        public const int CefMenuModel_GetGroupIdAt_26 = 26;
        /*2089*/
        public const int CefMenuModel_SetGroupId_27 = 27;
        /*2090*/
        public const int CefMenuModel_SetGroupIdAt_28 = 28;
        /*2091*/
        public const int CefMenuModel_GetSubMenu_29 = 29;
        /*2092*/
        public const int CefMenuModel_GetSubMenuAt_30 = 30;
        /*2093*/
        public const int CefMenuModel_IsVisible_31 = 31;
        /*2094*/
        public const int CefMenuModel_IsVisibleAt_32 = 32;
        /*2095*/
        public const int CefMenuModel_SetVisible_33 = 33;
        /*2096*/
        public const int CefMenuModel_SetVisibleAt_34 = 34;
        /*2097*/
        public const int CefMenuModel_IsEnabled_35 = 35;
        /*2098*/
        public const int CefMenuModel_IsEnabledAt_36 = 36;
        /*2099*/
        public const int CefMenuModel_SetEnabled_37 = 37;
        /*2100*/
        public const int CefMenuModel_SetEnabledAt_38 = 38;
        /*2101*/
        public const int CefMenuModel_IsChecked_39 = 39;
        /*2102*/
        public const int CefMenuModel_IsCheckedAt_40 = 40;
        /*2103*/
        public const int CefMenuModel_SetChecked_41 = 41;
        /*2104*/
        public const int CefMenuModel_SetCheckedAt_42 = 42;
        /*2105*/
        public const int CefMenuModel_HasAccelerator_43 = 43;
        /*2106*/
        public const int CefMenuModel_HasAcceleratorAt_44 = 44;
        /*2107*/
        public const int CefMenuModel_SetAccelerator_45 = 45;
        /*2108*/
        public const int CefMenuModel_SetAcceleratorAt_46 = 46;
        /*2109*/
        public const int CefMenuModel_RemoveAccelerator_47 = 47;
        /*2110*/
        public const int CefMenuModel_RemoveAcceleratorAt_48 = 48;
        /*2111*/
        public const int CefMenuModel_GetAccelerator_49 = 49;
        /*2112*/
        public const int CefMenuModel_GetAcceleratorAt_50 = 50;
        /*2113*/
        public const int CefMenuModel_SetColor_51 = 51;
        /*2114*/
        public const int CefMenuModel_SetColorAt_52 = 52;
        /*2115*/
        public const int CefMenuModel_GetColor_53 = 53;
        /*2116*/
        public const int CefMenuModel_GetColorAt_54 = 54;
        /*2117*/
        public const int CefMenuModel_SetFontList_55 = 55;
        /*2118*/
        public const int CefMenuModel_SetFontListAt_56 = 56;
        /*2119*/
    }



    // [virtual] class CefMenuModelDelegate
    /*2131*/
    /*2129*/
    static class MetName_CefMenuModelDelegate
    {
        /*2130*/
    }



    // [virtual] class CefNavigationEntry
    /*2202*/
    /*2190*/
    static class MetName_CefNavigationEntry
    {
        /*2191*/
        public const int CefNavigationEntry_IsValid_1 = 1;
        /*2192*/
        public const int CefNavigationEntry_GetURL_2 = 2;
        /*2193*/
        public const int CefNavigationEntry_GetDisplayURL_3 = 3;
        /*2194*/
        public const int CefNavigationEntry_GetOriginalURL_4 = 4;
        /*2195*/
        public const int CefNavigationEntry_GetTitle_5 = 5;
        /*2196*/
        public const int CefNavigationEntry_GetTransitionType_6 = 6;
        /*2197*/
        public const int CefNavigationEntry_HasPostData_7 = 7;
        /*2198*/
        public const int CefNavigationEntry_GetCompletionTime_8 = 8;
        /*2199*/
        public const int CefNavigationEntry_GetHttpStatusCode_9 = 9;
        /*2200*/
        public const int CefNavigationEntry_GetSSLStatus_10 = 10;
        /*2201*/
    }



    // [virtual] class CefPrintSettings
    /*2351*/
    /*2326*/
    static class MetName_CefPrintSettings
    {
        /*2327*/
        public const int CefPrintSettings_IsValid_1 = 1;
        /*2328*/
        public const int CefPrintSettings_IsReadOnly_2 = 2;
        /*2329*/
        public const int CefPrintSettings_Copy_3 = 3;
        /*2330*/
        public const int CefPrintSettings_SetOrientation_4 = 4;
        /*2331*/
        public const int CefPrintSettings_IsLandscape_5 = 5;
        /*2332*/
        public const int CefPrintSettings_SetPrinterPrintableArea_6 = 6;
        /*2333*/
        public const int CefPrintSettings_SetDeviceName_7 = 7;
        /*2334*/
        public const int CefPrintSettings_GetDeviceName_8 = 8;
        /*2335*/
        public const int CefPrintSettings_SetDPI_9 = 9;
        /*2336*/
        public const int CefPrintSettings_GetDPI_10 = 10;
        /*2337*/
        public const int CefPrintSettings_SetPageRanges_11 = 11;
        /*2338*/
        public const int CefPrintSettings_GetPageRangesCount_12 = 12;
        /*2339*/
        public const int CefPrintSettings_GetPageRanges_13 = 13;
        /*2340*/
        public const int CefPrintSettings_SetSelectionOnly_14 = 14;
        /*2341*/
        public const int CefPrintSettings_IsSelectionOnly_15 = 15;
        /*2342*/
        public const int CefPrintSettings_SetCollate_16 = 16;
        /*2343*/
        public const int CefPrintSettings_WillCollate_17 = 17;
        /*2344*/
        public const int CefPrintSettings_SetColorModel_18 = 18;
        /*2345*/
        public const int CefPrintSettings_GetColorModel_19 = 19;
        /*2346*/
        public const int CefPrintSettings_SetCopies_20 = 20;
        /*2347*/
        public const int CefPrintSettings_GetCopies_21 = 21;
        /*2348*/
        public const int CefPrintSettings_SetDuplexMode_22 = 22;
        /*2349*/
        public const int CefPrintSettings_GetDuplexMode_23 = 23;
        /*2350*/
    }



    // [virtual] class CefProcessMessage
    /*2392*/
    /*2385*/
    static class MetName_CefProcessMessage
    {
        /*2386*/
        public const int CefProcessMessage_IsValid_1 = 1;
        /*2387*/
        public const int CefProcessMessage_IsReadOnly_2 = 2;
        /*2388*/
        public const int CefProcessMessage_Copy_3 = 3;
        /*2389*/
        public const int CefProcessMessage_GetName_4 = 4;
        /*2390*/
        public const int CefProcessMessage_GetArgumentList_5 = 5;
        /*2391*/
    }



    // [virtual] class CefRequest
    /*2523*/
    /*2501*/
    static class MetName_CefRequest
    {
        /*2502*/
        public const int CefRequest_IsReadOnly_1 = 1;
        /*2503*/
        public const int CefRequest_GetURL_2 = 2;
        /*2504*/
        public const int CefRequest_SetURL_3 = 3;
        /*2505*/
        public const int CefRequest_GetMethod_4 = 4;
        /*2506*/
        public const int CefRequest_SetMethod_5 = 5;
        /*2507*/
        public const int CefRequest_SetReferrer_6 = 6;
        /*2508*/
        public const int CefRequest_GetReferrerURL_7 = 7;
        /*2509*/
        public const int CefRequest_GetReferrerPolicy_8 = 8;
        /*2510*/
        public const int CefRequest_GetPostData_9 = 9;
        /*2511*/
        public const int CefRequest_SetPostData_10 = 10;
        /*2512*/
        public const int CefRequest_GetHeaderMap_11 = 11;
        /*2513*/
        public const int CefRequest_SetHeaderMap_12 = 12;
        /*2514*/
        public const int CefRequest_Set_13 = 13;
        /*2515*/
        public const int CefRequest_GetFlags_14 = 14;
        /*2516*/
        public const int CefRequest_SetFlags_15 = 15;
        /*2517*/
        public const int CefRequest_GetFirstPartyForCookies_16 = 16;
        /*2518*/
        public const int CefRequest_SetFirstPartyForCookies_17 = 17;
        /*2519*/
        public const int CefRequest_GetResourceType_18 = 18;
        /*2520*/
        public const int CefRequest_GetTransitionType_19 = 19;
        /*2521*/
        public const int CefRequest_GetIdentifier_20 = 20;
        /*2522*/
    }



    // [virtual] class CefPostData
    /*2576*/
    /*2567*/
    static class MetName_CefPostData
    {
        /*2568*/
        public const int CefPostData_IsReadOnly_1 = 1;
        /*2569*/
        public const int CefPostData_HasExcludedElements_2 = 2;
        /*2570*/
        public const int CefPostData_GetElementCount_3 = 3;
        /*2571*/
        public const int CefPostData_GetElements_4 = 4;
        /*2572*/
        public const int CefPostData_RemoveElement_5 = 5;
        /*2573*/
        public const int CefPostData_AddElement_6 = 6;
        /*2574*/
        public const int CefPostData_RemoveElements_7 = 7;
        /*2575*/
    }



    // [virtual] class CefPostDataElement
    /*2635*/
    /*2625*/
    static class MetName_CefPostDataElement
    {
        /*2626*/
        public const int CefPostDataElement_IsReadOnly_1 = 1;
        /*2627*/
        public const int CefPostDataElement_SetToEmpty_2 = 2;
        /*2628*/
        public const int CefPostDataElement_SetToFile_3 = 3;
        /*2629*/
        public const int CefPostDataElement_SetToBytes_4 = 4;
        /*2630*/
        public const int CefPostDataElement_GetType_5 = 5;
        /*2631*/
        public const int CefPostDataElement_GetFile_6 = 6;
        /*2632*/
        public const int CefPostDataElement_GetBytesCount_7 = 7;
        /*2633*/
        public const int CefPostDataElement_GetBytes_8 = 8;
        /*2634*/
    }



    // [virtual] class CefRequestContext
    /*2754*/
    /*2734*/
    static class MetName_CefRequestContext
    {
        /*2735*/
        public const int CefRequestContext_IsSame_1 = 1;
        /*2736*/
        public const int CefRequestContext_IsSharingWith_2 = 2;
        /*2737*/
        public const int CefRequestContext_IsGlobal_3 = 3;
        /*2738*/
        public const int CefRequestContext_GetHandler_4 = 4;
        /*2739*/
        public const int CefRequestContext_GetCachePath_5 = 5;
        /*2740*/
        public const int CefRequestContext_GetDefaultCookieManager_6 = 6;
        /*2741*/
        public const int CefRequestContext_RegisterSchemeHandlerFactory_7 = 7;
        /*2742*/
        public const int CefRequestContext_ClearSchemeHandlerFactories_8 = 8;
        /*2743*/
        public const int CefRequestContext_PurgePluginListCache_9 = 9;
        /*2744*/
        public const int CefRequestContext_HasPreference_10 = 10;
        /*2745*/
        public const int CefRequestContext_GetPreference_11 = 11;
        /*2746*/
        public const int CefRequestContext_GetAllPreferences_12 = 12;
        /*2747*/
        public const int CefRequestContext_CanSetPreference_13 = 13;
        /*2748*/
        public const int CefRequestContext_SetPreference_14 = 14;
        /*2749*/
        public const int CefRequestContext_ClearCertificateExceptions_15 = 15;
        /*2750*/
        public const int CefRequestContext_CloseAllConnections_16 = 16;
        /*2751*/
        public const int CefRequestContext_ResolveHost_17 = 17;
        /*2752*/
        public const int CefRequestContext_ResolveHostCached_18 = 18;
        /*2753*/
    }



    // [virtual] class CefResourceBundle
    /*2783*/
    /*2778*/
    static class MetName_CefResourceBundle
    {
        /*2779*/
        public const int CefResourceBundle_GetLocalizedString_1 = 1;
        /*2780*/
        public const int CefResourceBundle_GetDataResource_2 = 2;
        /*2781*/
        public const int CefResourceBundle_GetDataResourceForScale_3 = 3;
        /*2782*/
    }



    // [virtual] class CefResponse
    /*2866*/
    /*2852*/
    static class MetName_CefResponse
    {
        /*2853*/
        public const int CefResponse_IsReadOnly_1 = 1;
        /*2854*/
        public const int CefResponse_GetError_2 = 2;
        /*2855*/
        public const int CefResponse_SetError_3 = 3;
        /*2856*/
        public const int CefResponse_GetStatus_4 = 4;
        /*2857*/
        public const int CefResponse_SetStatus_5 = 5;
        /*2858*/
        public const int CefResponse_GetStatusText_6 = 6;
        /*2859*/
        public const int CefResponse_SetStatusText_7 = 7;
        /*2860*/
        public const int CefResponse_GetMimeType_8 = 8;
        /*2861*/
        public const int CefResponse_SetMimeType_9 = 9;
        /*2862*/
        public const int CefResponse_GetHeader_10 = 10;
        /*2863*/
        public const int CefResponse_GetHeaderMap_11 = 11;
        /*2864*/
        public const int CefResponse_SetHeaderMap_12 = 12;
        /*2865*/
    }



    // [virtual] class CefResponseFilter
    /*2877*/
    /*2875*/
    static class MetName_CefResponseFilter
    {
        /*2876*/
    }



    // [virtual] class CefSchemeHandlerFactory
    /*2888*/
    /*2886*/
    static class MetName_CefSchemeHandlerFactory
    {
        /*2887*/
    }



    // [virtual] class CefSSLInfo
    /*2911*/
    /*2907*/
    static class MetName_CefSSLInfo
    {
        /*2908*/
        public const int CefSSLInfo_GetCertStatus_1 = 1;
        /*2909*/
        public const int CefSSLInfo_GetX509Certificate_2 = 2;
        /*2910*/
    }



    // [virtual] class CefSSLStatus
    /*2952*/
    /*2945*/
    static class MetName_CefSSLStatus
    {
        /*2946*/
        public const int CefSSLStatus_IsSecureConnection_1 = 1;
        /*2947*/
        public const int CefSSLStatus_GetCertStatus_2 = 2;
        /*2948*/
        public const int CefSSLStatus_GetSSLVersion_3 = 3;
        /*2949*/
        public const int CefSSLStatus_GetContentStatus_4 = 4;
        /*2950*/
        public const int CefSSLStatus_GetX509Certificate_5 = 5;
        /*2951*/
    }



    // [virtual] class CefStreamReader
    /*2993*/
    /*2986*/
    static class MetName_CefStreamReader
    {
        /*2987*/
        public const int CefStreamReader_Read_1 = 1;
        /*2988*/
        public const int CefStreamReader_Seek_2 = 2;
        /*2989*/
        public const int CefStreamReader_Tell_3 = 3;
        /*2990*/
        public const int CefStreamReader_Eof_4 = 4;
        /*2991*/
        public const int CefStreamReader_MayBlock_5 = 5;
        /*2992*/
    }



    // [virtual] class CefStreamWriter
    /*3034*/
    /*3027*/
    static class MetName_CefStreamWriter
    {
        /*3028*/
        public const int CefStreamWriter_Write_1 = 1;
        /*3029*/
        public const int CefStreamWriter_Seek_2 = 2;
        /*3030*/
        public const int CefStreamWriter_Tell_3 = 3;
        /*3031*/
        public const int CefStreamWriter_Flush_4 = 4;
        /*3032*/
        public const int CefStreamWriter_MayBlock_5 = 5;
        /*3033*/
    }



    // [virtual] class CefStringVisitor
    /*3045*/
    /*3043*/
    static class MetName_CefStringVisitor
    {
        /*3044*/
    }



    // [virtual] class CefTask
    /*3056*/
    /*3054*/
    static class MetName_CefTask
    {
        /*3055*/
    }



    // [virtual] class CefTaskRunner
    /*3097*/
    /*3090*/
    static class MetName_CefTaskRunner
    {
        /*3091*/
        public const int CefTaskRunner_IsSame_1 = 1;
        /*3092*/
        public const int CefTaskRunner_BelongsToCurrentThread_2 = 2;
        /*3093*/
        public const int CefTaskRunner_BelongsToThread_3 = 3;
        /*3094*/
        public const int CefTaskRunner_PostTask_4 = 4;
        /*3095*/
        public const int CefTaskRunner_PostDelayedTask_5 = 5;
        /*3096*/
    }



    // [virtual] class CefURLRequest
    /*3144*/
    /*3136*/
    static class MetName_CefURLRequest
    {
        /*3137*/
        public const int CefURLRequest_GetRequest_1 = 1;
        /*3138*/
        public const int CefURLRequest_GetClient_2 = 2;
        /*3139*/
        public const int CefURLRequest_GetRequestStatus_3 = 3;
        /*3140*/
        public const int CefURLRequest_GetRequestError_4 = 4;
        /*3141*/
        public const int CefURLRequest_GetResponse_5 = 5;
        /*3142*/
        public const int CefURLRequest_Cancel_6 = 6;
        /*3143*/
    }



    // [virtual] class CefURLRequestClient
    /*3155*/
    /*3153*/
    static class MetName_CefURLRequestClient
    {
        /*3154*/
    }



    // [virtual] class CefV8Context
    /*3220*/
    /*3209*/
    static class MetName_CefV8Context
    {
        /*3210*/
        public const int CefV8Context_GetTaskRunner_1 = 1;
        /*3211*/
        public const int CefV8Context_IsValid_2 = 2;
        /*3212*/
        public const int CefV8Context_GetBrowser_3 = 3;
        /*3213*/
        public const int CefV8Context_GetFrame_4 = 4;
        /*3214*/
        public const int CefV8Context_GetGlobal_5 = 5;
        /*3215*/
        public const int CefV8Context_Enter_6 = 6;
        /*3216*/
        public const int CefV8Context_Exit_7 = 7;
        /*3217*/
        public const int CefV8Context_IsSame_8 = 8;
        /*3218*/
        public const int CefV8Context_Eval_9 = 9;
        /*3219*/
    }



    // [virtual] class CefV8Accessor
    /*3231*/
    /*3229*/
    static class MetName_CefV8Accessor
    {
        /*3230*/
    }



    // [virtual] class CefV8Interceptor
    /*3242*/
    /*3240*/
    static class MetName_CefV8Interceptor
    {
        /*3241*/
    }



    // [virtual] class CefV8Exception
    /*3301*/
    /*3291*/
    static class MetName_CefV8Exception
    {
        /*3292*/
        public const int CefV8Exception_GetMessage_1 = 1;
        /*3293*/
        public const int CefV8Exception_GetSourceLine_2 = 2;
        /*3294*/
        public const int CefV8Exception_GetScriptResourceName_3 = 3;
        /*3295*/
        public const int CefV8Exception_GetLineNumber_4 = 4;
        /*3296*/
        public const int CefV8Exception_GetStartPosition_5 = 5;
        /*3297*/
        public const int CefV8Exception_GetEndPosition_6 = 6;
        /*3298*/
        public const int CefV8Exception_GetStartColumn_7 = 7;
        /*3299*/
        public const int CefV8Exception_GetEndColumn_8 = 8;
        /*3300*/
    }



    // [virtual] class CefV8Value
    /*3576*/
    /*3530*/
    static class MetName_CefV8Value
    {
        /*3531*/
        public const int CefV8Value_IsValid_1 = 1;
        /*3532*/
        public const int CefV8Value_IsUndefined_2 = 2;
        /*3533*/
        public const int CefV8Value_IsNull_3 = 3;
        /*3534*/
        public const int CefV8Value_IsBool_4 = 4;
        /*3535*/
        public const int CefV8Value_IsInt_5 = 5;
        /*3536*/
        public const int CefV8Value_IsUInt_6 = 6;
        /*3537*/
        public const int CefV8Value_IsDouble_7 = 7;
        /*3538*/
        public const int CefV8Value_IsDate_8 = 8;
        /*3539*/
        public const int CefV8Value_IsString_9 = 9;
        /*3540*/
        public const int CefV8Value_IsObject_10 = 10;
        /*3541*/
        public const int CefV8Value_IsArray_11 = 11;
        /*3542*/
        public const int CefV8Value_IsFunction_12 = 12;
        /*3543*/
        public const int CefV8Value_IsSame_13 = 13;
        /*3544*/
        public const int CefV8Value_GetBoolValue_14 = 14;
        /*3545*/
        public const int CefV8Value_GetIntValue_15 = 15;
        /*3546*/
        public const int CefV8Value_GetUIntValue_16 = 16;
        /*3547*/
        public const int CefV8Value_GetDoubleValue_17 = 17;
        /*3548*/
        public const int CefV8Value_GetDateValue_18 = 18;
        /*3549*/
        public const int CefV8Value_GetStringValue_19 = 19;
        /*3550*/
        public const int CefV8Value_IsUserCreated_20 = 20;
        /*3551*/
        public const int CefV8Value_HasException_21 = 21;
        /*3552*/
        public const int CefV8Value_GetException_22 = 22;
        /*3553*/
        public const int CefV8Value_ClearException_23 = 23;
        /*3554*/
        public const int CefV8Value_WillRethrowExceptions_24 = 24;
        /*3555*/
        public const int CefV8Value_SetRethrowExceptions_25 = 25;
        /*3556*/
        public const int CefV8Value_HasValue_26 = 26;
        /*3557*/
        public const int CefV8Value_HasValue_27 = 27;
        /*3558*/
        public const int CefV8Value_DeleteValue_28 = 28;
        /*3559*/
        public const int CefV8Value_DeleteValue_29 = 29;
        /*3560*/
        public const int CefV8Value_GetValue_30 = 30;
        /*3561*/
        public const int CefV8Value_GetValue_31 = 31;
        /*3562*/
        public const int CefV8Value_SetValue_32 = 32;
        /*3563*/
        public const int CefV8Value_SetValue_33 = 33;
        /*3564*/
        public const int CefV8Value_SetValue_34 = 34;
        /*3565*/
        public const int CefV8Value_GetKeys_35 = 35;
        /*3566*/
        public const int CefV8Value_SetUserData_36 = 36;
        /*3567*/
        public const int CefV8Value_GetUserData_37 = 37;
        /*3568*/
        public const int CefV8Value_GetExternallyAllocatedMemory_38 = 38;
        /*3569*/
        public const int CefV8Value_AdjustExternallyAllocatedMemory_39 = 39;
        /*3570*/
        public const int CefV8Value_GetArrayLength_40 = 40;
        /*3571*/
        public const int CefV8Value_GetFunctionName_41 = 41;
        /*3572*/
        public const int CefV8Value_GetFunctionHandler_42 = 42;
        /*3573*/
        public const int CefV8Value_ExecuteFunction_43 = 43;
        /*3574*/
        public const int CefV8Value_ExecuteFunctionWithContext_44 = 44;
        /*3575*/
    }



    // [virtual] class CefV8StackTrace
    /*3605*/
    /*3600*/
    static class MetName_CefV8StackTrace
    {
        /*3601*/
        public const int CefV8StackTrace_IsValid_1 = 1;
        /*3602*/
        public const int CefV8StackTrace_GetFrameCount_2 = 2;
        /*3603*/
        public const int CefV8StackTrace_GetFrame_3 = 3;
        /*3604*/
    }



    // [virtual] class CefV8StackFrame
    /*3664*/
    /*3654*/
    static class MetName_CefV8StackFrame
    {
        /*3655*/
        public const int CefV8StackFrame_IsValid_1 = 1;
        /*3656*/
        public const int CefV8StackFrame_GetScriptName_2 = 2;
        /*3657*/
        public const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = 3;
        /*3658*/
        public const int CefV8StackFrame_GetFunctionName_4 = 4;
        /*3659*/
        public const int CefV8StackFrame_GetLineNumber_5 = 5;
        /*3660*/
        public const int CefV8StackFrame_GetColumn_6 = 6;
        /*3661*/
        public const int CefV8StackFrame_IsEval_7 = 7;
        /*3662*/
        public const int CefV8StackFrame_IsConstructor_8 = 8;
        /*3663*/
    }



    // [virtual] class CefValue
    /*3807*/
    /*3783*/
    static class MetName_CefValue
    {
        /*3784*/
        public const int CefValue_IsValid_1 = 1;
        /*3785*/
        public const int CefValue_IsOwned_2 = 2;
        /*3786*/
        public const int CefValue_IsReadOnly_3 = 3;
        /*3787*/
        public const int CefValue_IsSame_4 = 4;
        /*3788*/
        public const int CefValue_IsEqual_5 = 5;
        /*3789*/
        public const int CefValue_Copy_6 = 6;
        /*3790*/
        public const int CefValue_GetType_7 = 7;
        /*3791*/
        public const int CefValue_GetBool_8 = 8;
        /*3792*/
        public const int CefValue_GetInt_9 = 9;
        /*3793*/
        public const int CefValue_GetDouble_10 = 10;
        /*3794*/
        public const int CefValue_GetString_11 = 11;
        /*3795*/
        public const int CefValue_GetBinary_12 = 12;
        /*3796*/
        public const int CefValue_GetDictionary_13 = 13;
        /*3797*/
        public const int CefValue_GetList_14 = 14;
        /*3798*/
        public const int CefValue_SetNull_15 = 15;
        /*3799*/
        public const int CefValue_SetBool_16 = 16;
        /*3800*/
        public const int CefValue_SetInt_17 = 17;
        /*3801*/
        public const int CefValue_SetDouble_18 = 18;
        /*3802*/
        public const int CefValue_SetString_19 = 19;
        /*3803*/
        public const int CefValue_SetBinary_20 = 20;
        /*3804*/
        public const int CefValue_SetDictionary_21 = 21;
        /*3805*/
        public const int CefValue_SetList_22 = 22;
        /*3806*/
    }



    // [virtual] class CefBinaryValue
    /*3860*/
    /*3851*/
    static class MetName_CefBinaryValue
    {
        /*3852*/
        public const int CefBinaryValue_IsValid_1 = 1;
        /*3853*/
        public const int CefBinaryValue_IsOwned_2 = 2;
        /*3854*/
        public const int CefBinaryValue_IsSame_3 = 3;
        /*3855*/
        public const int CefBinaryValue_IsEqual_4 = 4;
        /*3856*/
        public const int CefBinaryValue_Copy_5 = 5;
        /*3857*/
        public const int CefBinaryValue_GetSize_6 = 6;
        /*3858*/
        public const int CefBinaryValue_GetData_7 = 7;
        /*3859*/
    }



    // [virtual] class CefDictionaryValue
    /*4045*/
    /*4014*/
    static class MetName_CefDictionaryValue
    {
        /*4015*/
        public const int CefDictionaryValue_IsValid_1 = 1;
        /*4016*/
        public const int CefDictionaryValue_IsOwned_2 = 2;
        /*4017*/
        public const int CefDictionaryValue_IsReadOnly_3 = 3;
        /*4018*/
        public const int CefDictionaryValue_IsSame_4 = 4;
        /*4019*/
        public const int CefDictionaryValue_IsEqual_5 = 5;
        /*4020*/
        public const int CefDictionaryValue_Copy_6 = 6;
        /*4021*/
        public const int CefDictionaryValue_GetSize_7 = 7;
        /*4022*/
        public const int CefDictionaryValue_Clear_8 = 8;
        /*4023*/
        public const int CefDictionaryValue_HasKey_9 = 9;
        /*4024*/
        public const int CefDictionaryValue_GetKeys_10 = 10;
        /*4025*/
        public const int CefDictionaryValue_Remove_11 = 11;
        /*4026*/
        public const int CefDictionaryValue_GetType_12 = 12;
        /*4027*/
        public const int CefDictionaryValue_GetValue_13 = 13;
        /*4028*/
        public const int CefDictionaryValue_GetBool_14 = 14;
        /*4029*/
        public const int CefDictionaryValue_GetInt_15 = 15;
        /*4030*/
        public const int CefDictionaryValue_GetDouble_16 = 16;
        /*4031*/
        public const int CefDictionaryValue_GetString_17 = 17;
        /*4032*/
        public const int CefDictionaryValue_GetBinary_18 = 18;
        /*4033*/
        public const int CefDictionaryValue_GetDictionary_19 = 19;
        /*4034*/
        public const int CefDictionaryValue_GetList_20 = 20;
        /*4035*/
        public const int CefDictionaryValue_SetValue_21 = 21;
        /*4036*/
        public const int CefDictionaryValue_SetNull_22 = 22;
        /*4037*/
        public const int CefDictionaryValue_SetBool_23 = 23;
        /*4038*/
        public const int CefDictionaryValue_SetInt_24 = 24;
        /*4039*/
        public const int CefDictionaryValue_SetDouble_25 = 25;
        /*4040*/
        public const int CefDictionaryValue_SetString_26 = 26;
        /*4041*/
        public const int CefDictionaryValue_SetBinary_27 = 27;
        /*4042*/
        public const int CefDictionaryValue_SetDictionary_28 = 28;
        /*4043*/
        public const int CefDictionaryValue_SetList_29 = 29;
        /*4044*/
    }



    // [virtual] class CefListValue
    /*4224*/
    /*4194*/
    static class MetName_CefListValue
    {
        /*4195*/
        public const int CefListValue_IsValid_1 = 1;
        /*4196*/
        public const int CefListValue_IsOwned_2 = 2;
        /*4197*/
        public const int CefListValue_IsReadOnly_3 = 3;
        /*4198*/
        public const int CefListValue_IsSame_4 = 4;
        /*4199*/
        public const int CefListValue_IsEqual_5 = 5;
        /*4200*/
        public const int CefListValue_Copy_6 = 6;
        /*4201*/
        public const int CefListValue_SetSize_7 = 7;
        /*4202*/
        public const int CefListValue_GetSize_8 = 8;
        /*4203*/
        public const int CefListValue_Clear_9 = 9;
        /*4204*/
        public const int CefListValue_Remove_10 = 10;
        /*4205*/
        public const int CefListValue_GetType_11 = 11;
        /*4206*/
        public const int CefListValue_GetValue_12 = 12;
        /*4207*/
        public const int CefListValue_GetBool_13 = 13;
        /*4208*/
        public const int CefListValue_GetInt_14 = 14;
        /*4209*/
        public const int CefListValue_GetDouble_15 = 15;
        /*4210*/
        public const int CefListValue_GetString_16 = 16;
        /*4211*/
        public const int CefListValue_GetBinary_17 = 17;
        /*4212*/
        public const int CefListValue_GetDictionary_18 = 18;
        /*4213*/
        public const int CefListValue_GetList_19 = 19;
        /*4214*/
        public const int CefListValue_SetValue_20 = 20;
        /*4215*/
        public const int CefListValue_SetNull_21 = 21;
        /*4216*/
        public const int CefListValue_SetBool_22 = 22;
        /*4217*/
        public const int CefListValue_SetInt_23 = 23;
        /*4218*/
        public const int CefListValue_SetDouble_24 = 24;
        /*4219*/
        public const int CefListValue_SetString_25 = 25;
        /*4220*/
        public const int CefListValue_SetBinary_26 = 26;
        /*4221*/
        public const int CefListValue_SetDictionary_27 = 27;
        /*4222*/
        public const int CefListValue_SetList_28 = 28;
        /*4223*/
    }



    // [virtual] class CefWebPluginInfo
    /*4259*/
    /*4253*/
    static class MetName_CefWebPluginInfo
    {
        /*4254*/
        public const int CefWebPluginInfo_GetName_1 = 1;
        /*4255*/
        public const int CefWebPluginInfo_GetPath_2 = 2;
        /*4256*/
        public const int CefWebPluginInfo_GetVersion_3 = 3;
        /*4257*/
        public const int CefWebPluginInfo_GetDescription_4 = 4;
        /*4258*/
    }



    // [virtual] class CefWebPluginInfoVisitor
    /*4270*/
    /*4268*/
    static class MetName_CefWebPluginInfoVisitor
    {
        /*4269*/
    }



    // [virtual] class CefX509CertPrincipal
    /*4335*/
    /*4324*/
    static class MetName_CefX509CertPrincipal
    {
        /*4325*/
        public const int CefX509CertPrincipal_GetDisplayName_1 = 1;
        /*4326*/
        public const int CefX509CertPrincipal_GetCommonName_2 = 2;
        /*4327*/
        public const int CefX509CertPrincipal_GetLocalityName_3 = 3;
        /*4328*/
        public const int CefX509CertPrincipal_GetStateOrProvinceName_4 = 4;
        /*4329*/
        public const int CefX509CertPrincipal_GetCountryName_5 = 5;
        /*4330*/
        public const int CefX509CertPrincipal_GetStreetAddresses_6 = 6;
        /*4331*/
        public const int CefX509CertPrincipal_GetOrganizationNames_7 = 7;
        /*4332*/
        public const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = 8;
        /*4333*/
        public const int CefX509CertPrincipal_GetDomainComponents_9 = 9;
        /*4334*/
    }



    // [virtual] class CefX509Certificate
    /*4406*/
    /*4394*/
    static class MetName_CefX509Certificate
    {
        /*4395*/
        public const int CefX509Certificate_GetSubject_1 = 1;
        /*4396*/
        public const int CefX509Certificate_GetIssuer_2 = 2;
        /*4397*/
        public const int CefX509Certificate_GetSerialNumber_3 = 3;
        /*4398*/
        public const int CefX509Certificate_GetValidStart_4 = 4;
        /*4399*/
        public const int CefX509Certificate_GetValidExpiry_5 = 5;
        /*4400*/
        public const int CefX509Certificate_GetDEREncoded_6 = 6;
        /*4401*/
        public const int CefX509Certificate_GetPEMEncoded_7 = 7;
        /*4402*/
        public const int CefX509Certificate_GetIssuerChainSize_8 = 8;
        /*4403*/
        public const int CefX509Certificate_GetDEREncodedIssuerChain_9 = 9;
        /*4404*/
        public const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = 10;
        /*4405*/
    }



    // [virtual] class CefXmlReader
    /*4591*/
    /*4560*/
    static class MetName_CefXmlReader
    {
        /*4561*/
        public const int CefXmlReader_MoveToNextNode_1 = 1;
        /*4562*/
        public const int CefXmlReader_Close_2 = 2;
        /*4563*/
        public const int CefXmlReader_HasError_3 = 3;
        /*4564*/
        public const int CefXmlReader_GetError_4 = 4;
        /*4565*/
        public const int CefXmlReader_GetType_5 = 5;
        /*4566*/
        public const int CefXmlReader_GetDepth_6 = 6;
        /*4567*/
        public const int CefXmlReader_GetLocalName_7 = 7;
        /*4568*/
        public const int CefXmlReader_GetPrefix_8 = 8;
        /*4569*/
        public const int CefXmlReader_GetQualifiedName_9 = 9;
        /*4570*/
        public const int CefXmlReader_GetNamespaceURI_10 = 10;
        /*4571*/
        public const int CefXmlReader_GetBaseURI_11 = 11;
        /*4572*/
        public const int CefXmlReader_GetXmlLang_12 = 12;
        /*4573*/
        public const int CefXmlReader_IsEmptyElement_13 = 13;
        /*4574*/
        public const int CefXmlReader_HasValue_14 = 14;
        /*4575*/
        public const int CefXmlReader_GetValue_15 = 15;
        /*4576*/
        public const int CefXmlReader_HasAttributes_16 = 16;
        /*4577*/
        public const int CefXmlReader_GetAttributeCount_17 = 17;
        /*4578*/
        public const int CefXmlReader_GetAttribute_18 = 18;
        /*4579*/
        public const int CefXmlReader_GetAttribute_19 = 19;
        /*4580*/
        public const int CefXmlReader_GetAttribute_20 = 20;
        /*4581*/
        public const int CefXmlReader_GetInnerXml_21 = 21;
        /*4582*/
        public const int CefXmlReader_GetOuterXml_22 = 22;
        /*4583*/
        public const int CefXmlReader_GetLineNumber_23 = 23;
        /*4584*/
        public const int CefXmlReader_MoveToAttribute_24 = 24;
        /*4585*/
        public const int CefXmlReader_MoveToAttribute_25 = 25;
        /*4586*/
        public const int CefXmlReader_MoveToAttribute_26 = 26;
        /*4587*/
        public const int CefXmlReader_MoveToFirstAttribute_27 = 27;
        /*4588*/
        public const int CefXmlReader_MoveToNextAttribute_28 = 28;
        /*4589*/
        public const int CefXmlReader_MoveToCarryingElement_29 = 29;
        /*4590*/
    }



    // [virtual] class CefZipReader
    /*4674*/
    /*4660*/
    static class MetName_CefZipReader
    {
        /*4661*/
        public const int CefZipReader_MoveToFirstFile_1 = 1;
        /*4662*/
        public const int CefZipReader_MoveToNextFile_2 = 2;
        /*4663*/
        public const int CefZipReader_MoveToFile_3 = 3;
        /*4664*/
        public const int CefZipReader_Close_4 = 4;
        /*4665*/
        public const int CefZipReader_GetFileName_5 = 5;
        /*4666*/
        public const int CefZipReader_GetFileSize_6 = 6;
        /*4667*/
        public const int CefZipReader_GetFileLastModified_7 = 7;
        /*4668*/
        public const int CefZipReader_OpenFile_8 = 8;
        /*4669*/
        public const int CefZipReader_CloseFile_9 = 9;
        /*4670*/
        public const int CefZipReader_ReadFile_10 = 10;
        /*4671*/
        public const int CefZipReader_Tell_11 = 11;
        /*4672*/
        public const int CefZipReader_Eof_12 = 12;
        /*4673*/
    }




}