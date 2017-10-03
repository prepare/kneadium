//MIT, 2016-2017, WinterDev

using System;
using System.IO;
using LayoutFarm.CefBridge.Auto;
namespace LayoutFarm.CefBridge
{

    class RenderProcessClientApp : CefClientApp
    {
        RenderProcessHandler renderProcessHandler;

        public RenderProcessClientApp(IntPtr processHandle)
            : base(processHandle)
        {
        }
        protected override MyCefCallback GetManagedCallbackImpl()
        {
            return HandleNativeReq;
        }
        void InitCefSettings(CefSettings cefSettings)
        {
            if (ReferencePaths.SUB_PROCESS_PATH != null)
            {
                cefSettings.SetSubProcessPath(ReferencePaths.SUB_PROCESS_PATH);
            }
            cefSettings.SetCachePath(ReferencePaths.CACHE_PATH);
        }

        /// <summary>
        /// handle native reqiest , this is called by native side.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="argsPtr"></param>

        void HandleNativeReq(int met_id, IntPtr argsPtr)
        {
            if (renderProcessHandler == null)
            {
                //check if the render process handler is create or not
                //this method is called from native side
                //must check here!
                renderProcessHandler = new RenderProcessHandler();
            }

            //main raw msg switch table              
            if ((met_id >> 16) > 0)
            {
                //built in object 
                CefNativeRequestHandlers.HandleNativeReq_I0(renderProcessHandler, met_id, argsPtr);
                return;
            }

            //this is custom msg 
            dbugRenderProcessLog.WriteLine("custom_msg");
            switch ((MyCefMsg)met_id)
            {
                default:

                    break;
                //case MyCefMsg.CEF_MSG_ClientHandler_ShowDevTools:
                //    {

                //    }
                //    break;
                case MyCefMsg.CEF_MSG_CefSettings_Init:
                    {
                        InitCefSettings(new CefSettings(argsPtr));
                    }
                    break;
                case MyCefMsg.CEF_MSG_MainContext_GetConsoleLogPath:
                    {

                        NativeCallArgs nat1 = new NativeCallArgs(argsPtr);
                        nat1.SetOutputAsAsciiString(0, ReferencePaths.LOG_PATH);
                    }
                    break;
                case MyCefMsg.CEF_MSG_OSR_Render:
                    {
                        //not visit here?

                    }
                    break;
            }
        }
    }

}