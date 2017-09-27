//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    //CsNativeHandlerSwitchTableCodeGen::GenerateCefNativeRequestHandlers
    //------ common cef handler swicth table---------
    public static class CefNativeRequestHandlers
    {
        //CsNativeHandlerSwitchTableCodeGen::GenerateHandleNativeReq
        public static void HandleNativeReq(object inst, int met_id, IntPtr args)
        {
            switch ((met_id >> 16))
            {
                case CefAccessibilityHandler._typeNAME:
                    CefAccessibilityHandler.HandleNativeReq(inst as CefAccessibilityHandler.I0, inst as CefAccessibilityHandler.I1, met_id, args);
                    break;
                case CefBrowserProcessHandler._typeNAME:
                    CefBrowserProcessHandler.HandleNativeReq(inst as CefBrowserProcessHandler.I0, inst as CefBrowserProcessHandler.I1, met_id, args);
                    break;
                case CefContextMenuHandler._typeNAME:
                    CefContextMenuHandler.HandleNativeReq(inst as CefContextMenuHandler.I0, inst as CefContextMenuHandler.I1, met_id, args);
                    break;
                case CefDialogHandler._typeNAME:
                    CefDialogHandler.HandleNativeReq(inst as CefDialogHandler.I0, inst as CefDialogHandler.I1, met_id, args);
                    break;
                case CefDisplayHandler._typeNAME:
                    CefDisplayHandler.HandleNativeReq(inst as CefDisplayHandler.I0, inst as CefDisplayHandler.I1, met_id, args);
                    break;
                case CefDownloadHandler._typeNAME:
                    CefDownloadHandler.HandleNativeReq(inst as CefDownloadHandler.I0, inst as CefDownloadHandler.I1, met_id, args);
                    break;
                case CefDragHandler._typeNAME:
                    CefDragHandler.HandleNativeReq(inst as CefDragHandler.I0, inst as CefDragHandler.I1, met_id, args);
                    break;
                case CefFindHandler._typeNAME:
                    CefFindHandler.HandleNativeReq(inst as CefFindHandler.I0, inst as CefFindHandler.I1, met_id, args);
                    break;
                case CefFocusHandler._typeNAME:
                    CefFocusHandler.HandleNativeReq(inst as CefFocusHandler.I0, inst as CefFocusHandler.I1, met_id, args);
                    break;
                case CefGeolocationHandler._typeNAME:
                    CefGeolocationHandler.HandleNativeReq(inst as CefGeolocationHandler.I0, inst as CefGeolocationHandler.I1, met_id, args);
                    break;
                case CefJSDialogHandler._typeNAME:
                    CefJSDialogHandler.HandleNativeReq(inst as CefJSDialogHandler.I0, inst as CefJSDialogHandler.I1, met_id, args);
                    break;
                case CefKeyboardHandler._typeNAME:
                    CefKeyboardHandler.HandleNativeReq(inst as CefKeyboardHandler.I0, inst as CefKeyboardHandler.I1, met_id, args);
                    break;
                case CefLifeSpanHandler._typeNAME:
                    CefLifeSpanHandler.HandleNativeReq(inst as CefLifeSpanHandler.I0, inst as CefLifeSpanHandler.I1, met_id, args);
                    break;
                case CefLoadHandler._typeNAME:
                    CefLoadHandler.HandleNativeReq(inst as CefLoadHandler.I0, inst as CefLoadHandler.I1, met_id, args);
                    break;
                case CefPrintHandler._typeNAME:
                    CefPrintHandler.HandleNativeReq(inst as CefPrintHandler.I0, inst as CefPrintHandler.I1, met_id, args);
                    break;
                case CefRenderHandler._typeNAME:
                    CefRenderHandler.HandleNativeReq(inst as CefRenderHandler.I0, inst as CefRenderHandler.I1, met_id, args);
                    break;
                case CefRenderProcessHandler._typeNAME:
                    CefRenderProcessHandler.HandleNativeReq(inst as CefRenderProcessHandler.I0, inst as CefRenderProcessHandler.I1, met_id, args);
                    break;
                case CefRequestContextHandler._typeNAME:
                    CefRequestContextHandler.HandleNativeReq(inst as CefRequestContextHandler.I0, inst as CefRequestContextHandler.I1, met_id, args);
                    break;
                case CefRequestHandler._typeNAME:
                    CefRequestHandler.HandleNativeReq(inst as CefRequestHandler.I0, inst as CefRequestHandler.I1, met_id, args);
                    break;
                case CefResourceBundleHandler._typeNAME:
                    CefResourceBundleHandler.HandleNativeReq(inst as CefResourceBundleHandler.I0, inst as CefResourceBundleHandler.I1, met_id, args);
                    break;
                case CefResourceHandler._typeNAME:
                    CefResourceHandler.HandleNativeReq(inst as CefResourceHandler.I0, inst as CefResourceHandler.I1, met_id, args);
                    break;
                case CefReadHandler._typeNAME:
                    CefReadHandler.HandleNativeReq(inst as CefReadHandler.I0, inst as CefReadHandler.I1, met_id, args);
                    break;
                case CefWriteHandler._typeNAME:
                    CefWriteHandler.HandleNativeReq(inst as CefWriteHandler.I0, inst as CefWriteHandler.I1, met_id, args);
                    break;
                case CefV8Handler._typeNAME:
                    CefV8Handler.HandleNativeReq(inst as CefV8Handler.I0, inst as CefV8Handler.I1, met_id, args);
                    break;
            }
        }
        //CsNativeHandlerSwitchTableCodeGen::GenerateHandleNativeReq_I0
        public static void HandleNativeReq_I0(object inst, int met_id, IntPtr args)
        {
            switch ((met_id >> 16))
            {
                case CefAccessibilityHandler._typeNAME:
                    CefAccessibilityHandler.HandleNativeReq_I0(inst as CefAccessibilityHandler.I0, met_id, args);
                    break;
                case CefBrowserProcessHandler._typeNAME:
                    CefBrowserProcessHandler.HandleNativeReq_I0(inst as CefBrowserProcessHandler.I0, met_id, args);
                    break;
                case CefContextMenuHandler._typeNAME:
                    CefContextMenuHandler.HandleNativeReq_I0(inst as CefContextMenuHandler.I0, met_id, args);
                    break;
                case CefDialogHandler._typeNAME:
                    CefDialogHandler.HandleNativeReq_I0(inst as CefDialogHandler.I0, met_id, args);
                    break;
                case CefDisplayHandler._typeNAME:
                    CefDisplayHandler.HandleNativeReq_I0(inst as CefDisplayHandler.I0, met_id, args);
                    break;
                case CefDownloadHandler._typeNAME:
                    CefDownloadHandler.HandleNativeReq_I0(inst as CefDownloadHandler.I0, met_id, args);
                    break;
                case CefDragHandler._typeNAME:
                    CefDragHandler.HandleNativeReq_I0(inst as CefDragHandler.I0, met_id, args);
                    break;
                case CefFindHandler._typeNAME:
                    CefFindHandler.HandleNativeReq_I0(inst as CefFindHandler.I0, met_id, args);
                    break;
                case CefFocusHandler._typeNAME:
                    CefFocusHandler.HandleNativeReq_I0(inst as CefFocusHandler.I0, met_id, args);
                    break;
                case CefGeolocationHandler._typeNAME:
                    CefGeolocationHandler.HandleNativeReq_I0(inst as CefGeolocationHandler.I0, met_id, args);
                    break;
                case CefJSDialogHandler._typeNAME:
                    CefJSDialogHandler.HandleNativeReq_I0(inst as CefJSDialogHandler.I0, met_id, args);
                    break;
                case CefKeyboardHandler._typeNAME:
                    CefKeyboardHandler.HandleNativeReq_I0(inst as CefKeyboardHandler.I0, met_id, args);
                    break;
                case CefLifeSpanHandler._typeNAME:
                    CefLifeSpanHandler.HandleNativeReq_I0(inst as CefLifeSpanHandler.I0, met_id, args);
                    break;
                case CefLoadHandler._typeNAME:
                    CefLoadHandler.HandleNativeReq_I0(inst as CefLoadHandler.I0, met_id, args);
                    break;
                case CefPrintHandler._typeNAME:
                    CefPrintHandler.HandleNativeReq_I0(inst as CefPrintHandler.I0, met_id, args);
                    break;
                case CefRenderHandler._typeNAME:
                    CefRenderHandler.HandleNativeReq_I0(inst as CefRenderHandler.I0, met_id, args);
                    break;
                case CefRenderProcessHandler._typeNAME:
                    CefRenderProcessHandler.HandleNativeReq_I0(inst as CefRenderProcessHandler.I0, met_id, args);
                    break;
                case CefRequestContextHandler._typeNAME:
                    CefRequestContextHandler.HandleNativeReq_I0(inst as CefRequestContextHandler.I0, met_id, args);
                    break;
                case CefRequestHandler._typeNAME:
                    CefRequestHandler.HandleNativeReq_I0(inst as CefRequestHandler.I0, met_id, args);
                    break;
                case CefResourceBundleHandler._typeNAME:
                    CefResourceBundleHandler.HandleNativeReq_I0(inst as CefResourceBundleHandler.I0, met_id, args);
                    break;
                case CefResourceHandler._typeNAME:
                    CefResourceHandler.HandleNativeReq_I0(inst as CefResourceHandler.I0, met_id, args);
                    break;
                case CefReadHandler._typeNAME:
                    CefReadHandler.HandleNativeReq_I0(inst as CefReadHandler.I0, met_id, args);
                    break;
                case CefWriteHandler._typeNAME:
                    CefWriteHandler.HandleNativeReq_I0(inst as CefWriteHandler.I0, met_id, args);
                    break;
                case CefV8Handler._typeNAME:
                    CefV8Handler.HandleNativeReq_I0(inst as CefV8Handler.I0, met_id, args);
                    break;
            }
        }
    }
}
