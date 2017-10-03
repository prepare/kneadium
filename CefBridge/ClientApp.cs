//MIT, 2015-2017, WinterDev

using System;
namespace LayoutFarm.CefBridge
{

    public abstract class CefClientApp
    {
        /// <summary>
        /// native side client app 
        /// </summary>
        IntPtr clientAppPtr;
        static bool isInitWithProcessHandle;
        static readonly object sync_ = new object();
        MyCefCallback mxCallback;

        public CefClientApp(IntPtr processHandle)
        {

#if DEBUG
            //dev note: multiprocess debuging: renderer process debugger 
            //if you want to break in the renderer process
            //1. set break point after, MessageBox.Show();
            //2. call pop up message box
            //3. then, use Visual studio to find what process that own the pop up
            // ( Debug-> Attach To Process -> select process the own the pop up
            //4. select process id that is renderer process
            //5. push ok button on the pop msgbox , then debugger will break on the 
            //  break point after popup
            //if (Cef3Binder.s_dbugIsRendererProcess)
            //{
            //    System.Windows.Forms.MessageBox.Show("Renderer", "Renderer"); 
            //}
#endif

            lock (sync_)
            {
                //init once
                if (!isInitWithProcessHandle)
                {
                    isInitWithProcessHandle = true;
                    //1) register mx callback,
                    //call-back must be created first (before client app).
                    //
                    Cef3Binder.RegisterManagedCallBack(this.mxCallback = GetManagedCallbackImpl(), 3);
                    //2) create client app
                    //1 process have 1 client app instance.                                        
                    this.clientAppPtr = Cef3Binder.MyCefCreateClientApp(processHandle);
                    //the registered callback from previous step(1) was attached to the new client app.
                }
            }
        }
        protected abstract MyCefCallback GetManagedCallbackImpl();

    }



}