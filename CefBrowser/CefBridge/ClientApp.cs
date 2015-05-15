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
<<<<<<< HEAD
        internal static bool readyToClose;
=======
>>>>>>> origin/mod1

        bool isHandleCreated;
        bool isInitWithProcessHandle;
        AgentManagedCallback mxCallback;
<<<<<<< HEAD
        object sync_ = new object();
=======
>>>>>>> origin/mod1

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
<<<<<<< HEAD
                    this.clientAppPtr = this.GetHandle();
                    int initResult = Cef3Binder.MyCefInit(processHandle, clientAppPtr);
=======
                    contextImplPtr = Cef3Binder.MyCefInit(processHandle, this.GetHandle());
>>>>>>> origin/mod1
                    contextImplInit = true;
                }
            }
        }
<<<<<<< HEAD



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

=======
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
>>>>>>> origin/mod1
        }




    }

}