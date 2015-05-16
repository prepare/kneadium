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
        internal static bool readyToClose;

        bool isHandleCreated;
        bool isInitWithProcessHandle;
        AgentManagedCallback mxCallback;
        object sync_ = new object();

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
                    this.clientAppPtr = this.GetHandle();
                    int initResult = Cef3Binder.MyCefInit(processHandle, clientAppPtr);
                    contextImplInit = true;
                }
            }
        }



        void MxCallBack(int id, IntPtr argsPtr)
        {
            switch (id)
            {
                case 100:
                    {
                        //test only
                        readyToClose = true;

                    } break;
            }
        }


        IntPtr GetHandle()
        {
            lock (sync_)
            {
                if (!this.isHandleCreated)
                {
                    this.isHandleCreated = true;

                    this.clientAppPtr = Cef3Binder.MyCefCreateClientApp();
                    //register managed callback ***
                    this.mxCallback = new AgentManagedCallback(MxCallBack);
                    Cef3Binder.MyCefClientAppSetManagedCallback(this.clientAppPtr, this.mxCallback);
                }
                return this.clientAppPtr;
            }

        }




    }

}