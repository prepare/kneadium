//2015-2016 MIT, WinterDev
using System;

namespace LayoutFarm.CefBridge
{


    public class CefClientApp
    {
        IntPtr clientAppPtr;

        static bool isInitWithProcessHandle;
        static readonly object sync_ = new object();

        MyCefCallback mxCallback;
        MyCefRenderProcessListener renderProcessListener;



        public CefClientApp(IntPtr processHandle, MyCefRenderProcessListener renderProcessListener)
        {

            this.renderProcessListener = renderProcessListener;

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

                    //1. register mx callback
                    this.mxCallback = new MyCefCallback(MxCallBack);
                    Cef3Binder.RegisterManagedCallBack(this.mxCallback, 3);

                    //2. create client app
                    this.clientAppPtr = Cef3Binder.MyCefCreateClientApp(processHandle);

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

                    }
                    break;
                case 101:
                    {
                    }
                    break;
                case 103:
                    {
                        //create pop up window and send window handle to cef


                        IWindowForm popupWin = Cef3Binder.CreateBlankForm(600, 450);
                        popupWin.Show();

                        IntPtr handle = popupWin.GetHandle();
                        if (argsPtr != IntPtr.Zero)
                        {
                            NativeCallArgs2 args = new NativeCallArgs2(argsPtr);
                            args.SetResult(handle);

                        }

                    }
                    break;
                case 104:
                    {
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            string url = args.GetArgAsString(0);
                            IWindowForm popupWin = Cef3Binder.CreateNewBrowserWindow(600, 450);
                            popupWin.Show();
                            args.Dispose();
                        });

                    }
                    break;
                case 106:
                    {
                        //console.log ...
                        if (renderProcessListener != null)
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            renderProcessListener.OnConsoleLog(args);
                        }
                    }
                    break;
                case 107:
                    {
                        //show dev tools
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            IWindowForm newPopupForm = Cef3Binder.CreateNewBrowserWindow(800, 600);
                            newPopupForm.Show();
                        });

                    }
                    break;
                case 202:
                    {
                        //client app callback
                        //eg. from RenderClientApp
                        //in render process ***
                        //we can register external methods  for window object here.
                        //NativeMethods.MessageBox(IntPtr.Zero, id.ToString(), "NN2", 0);

                        if (renderProcessListener != null)
                        {
                            NativeCallArgs args = new NativeCallArgs(argsPtr);
                            MyCefContextArgs cefContextArgs = new MyCefContextArgs(args);
                            //var clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(0));
                            //var browser = new NativeBrowser(args.GetArgAsNativePtr(1));
                            //var context = new NativeJsContext(args.GetArgAsNativePtr(2));

                            renderProcessListener.OnContextCreated(cefContextArgs);
                        }


                    }
                    break;
            }
        }
    }

}