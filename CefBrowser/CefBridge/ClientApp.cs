//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{
    public class CefClientApp
    {
        IntPtr clientAppPtr;
        internal static IntPtr contextImplPtr;
        static bool contextImplInit;

        bool isHandleCreated;
        bool isInitWithProcessHandle;
        AgentManagedCallback mxCallback;

        public CefClientApp()
        {
            //init native part 
        }
        public void InitWithProcessHandle(IntPtr processHandle)
        {
            if (!isInitWithProcessHandle)
            {
                isInitWithProcessHandle = true;
                if (!contextImplInit)
                {
                    contextImplPtr = Cef3Binder.MyCefInit(processHandle, this.GetHandle());
                    contextImplInit = true;
                }
            }
        }
        void MxCallBack(int id, IntPtr argsPtr)
        {

        }
        IntPtr GetHandle()
        {
            if (!this.isHandleCreated)
            {


                this.clientAppPtr = Cef3Binder.MyCefCreateClientApp(contextImplPtr);
                this.isHandleCreated = true;

                //register managed callback ***
                this.mxCallback = new AgentManagedCallback(MxCallBack);
                Cef3Binder.MyCefClientAppSetManagedCallback(this.clientAppPtr, this.mxCallback);

            }
            return this.clientAppPtr;
        }




    }

}