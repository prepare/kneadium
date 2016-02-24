//2015 MIT, WinterDev
using System;
using System.Collections.Generic;

namespace LayoutFarm.CefBridge
{


    public class CefClientAppX : CefClientApp
    {
        IntPtr clientAppPtr;
        static bool isInitWithProcessHandle;
        static object sync_ = new object();
        static object sync_remove = new object();

        MyCefCallback mxCallback;

        static Dictionary<IntPtr, List<MyCefBrowser>> registeredWbControls =
            new Dictionary<IntPtr, List<MyCefBrowser>>();

        public CefClientAppX(IntPtr processHandle)
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

                    //1. register mx callback
                    this.mxCallback = new MyCefCallback(MxCallBack);
                    Cef3Binder.RegisterManagedCallBack(this.mxCallback, 3);

                    //2. create client app
                    this.clientAppPtr = Cef3Binder.MyCefCreateClientApp(processHandle);
                    //register managed callback ***     
                }
            }
        }


        public static void RegisterCefWbControl(MyCefBrowser cefWb)
        {
            //register this control with parent form
            var ownerForm = (IWindowForm)cefWb.ParentControl.GetTopLevelControl();
            List<MyCefBrowser> foundList;
            IntPtr winHandle = ownerForm.GetHandle();
            if (!registeredWbControls.TryGetValue(winHandle, out foundList))
            {
                foundList = new List<MyCefBrowser>();
                registeredWbControls.Add(winHandle, foundList);
            }
            if (!foundList.Contains(cefWb))
            {
                foundList.Add(cefWb);
                cefWb.BrowserDisposed += new EventHandler(cefWb_BrowserDisposed);
            }
        }
        static void cefWb_BrowserDisposed(object sender, EventArgs e)
        {
            //when browser is disposed..
            MyCefBrowser wb = (MyCefBrowser)sender;
            //remove wb from registerd list
            List<MyCefBrowser> wblist;
            IntPtr winHandle = wb.ParentForm.GetHandle();
            if (registeredWbControls.TryGetValue(winHandle, out wblist))
            {
                lock (sync_remove)
                {
                    wblist.Remove(wb);
                    if (wblist.Count == 0)
                    {
                        registeredWbControls.Remove(winHandle);
                    }
                }
            }
        }
        public static void DisposeCefWbControl(IWindowForm ownerForm)
        {
            //register this control with parent form 
            List<MyCefBrowser> foundList;
            IntPtr winHandle = ownerForm.GetHandle();
            if (registeredWbControls.TryGetValue(winHandle, out foundList))
            {
                //remove wb controls             
                for (int i = foundList.Count - 1; i >= 0; --i)
                {
                    var wb = foundList[i].ParentControl;
                    var parent = wb.GetParent();
                    parent.RemoveChild(wb);
                    wb.Dispose();
                }

                registeredWbControls.Remove(winHandle);

            }

        }
        public static bool IsReadyToClose(IWindowForm ownerForm)
        {
            //register this control with parent form  
            lock (sync_remove)
            {
                return !registeredWbControls.ContainsKey(ownerForm.GetHandle());
            }
        }

        void RenderProcessOnContextCreated(NativeCallArgs args)
        {

            //test function on render process

            var clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(0));
            var browser = new NativeBrowser(args.GetArgAsNativePtr(1));
            var context = new NativeJsContext(args.GetArgAsNativePtr(2));


            CefV8Value cefV8Global = context.GetGlobal();
            Cef3FuncHandler funcHandler = Cef3FuncHandler.CreateFuncHandler(Test001);
            Cef3Func func = Cef3Func.CreateFunc("test001", funcHandler);
            cefV8Global.Set("test001", func);
        }
        void Test001(int id, IntPtr argsPtr)
        {

#if DEBUG
            if (Cef3Binder.s_dbugIsRendererProcess)
            {
                System.Diagnostics.Debugger.Break();
            }
#endif
            var nativeCallArgs = new NativeCallArgs(argsPtr);
            nativeCallArgs.SetOutput(0, "hello from managed side !");

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
                            IWindowForm popupWin = Cef3Binder.CreateNewBrowserWindow(600, 450, url);
                            popupWin.Show();
                            args.Dispose();
                        });

                    }
                    break;
                case 106:
                    {
                        //console.log ...

                        NativeCallArgs args = new NativeCallArgs(argsPtr);
                        string msg = args.GetArgAsString(0);
                        string src = args.GetArgAsString(1);
                        string location = args.GetArgAsString(2);
                        Console.WriteLine(msg);

                    }
                    break;
                case 107:
                    {
                        //show dev tools
                        Cef3Binder.SafeUIInvoke(() =>
                        {
                            IWindowForm newPopupForm = Cef3Binder.CreateNewBrowserWindow(800, 600, "");
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

#if DEBUG
                        //if you want to stop on RenderProcess
                        if (Cef3Binder.s_dbugIsRendererProcess)
                        {
                            System.Diagnostics.Debugger.Break();
                        }
#endif

                        NativeCallArgs args = new NativeCallArgs(argsPtr);
                        RenderProcessOnContextCreated(args);
                    }
                    break;
            }
        }
    }

}