//2015 MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace LayoutFarm.CefBridge
{
    public delegate void SimpleDel();

    public class CefClientApp
    {
        IntPtr clientAppPtr;
        static bool isInitWithProcessHandle;
        static object sync_ = new object();
        static object sync_remove = new object();

        MyCefCallback mxCallback;
        static System.Windows.Forms.Form tinyForm;

        static Dictionary<System.Windows.Forms.Form, List<MyCefBrowser>> registeredWbControls =
            new Dictionary<System.Windows.Forms.Form, List<MyCefBrowser>>();

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
            if (Cef3Binder.s_IsRendererProcess)
            {
                System.Windows.Forms.MessageBox.Show("Renderer", "Renderer");

            }
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

        public IntPtr CefReady()
        {
            //make it a hidden form
            if (tinyForm == null)
            {
                tinyForm = new System.Windows.Forms.Form();
                tinyForm.Size = new System.Drawing.Size(10, 10);
                tinyForm.Visible = false;
            }
            return tinyForm.Handle;//force it create handle
        }
        internal static void RegisterCefWbControl(MyCefBrowser cefWb)
        {
            //register this control with parent form
            var ownerForm = (System.Windows.Forms.Form)cefWb.ParentControl.TopLevelControl;
            List<MyCefBrowser> foundList;
            if (!registeredWbControls.TryGetValue(ownerForm, out foundList))
            {
                foundList = new List<MyCefBrowser>();
                registeredWbControls.Add(ownerForm, foundList);
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
            if (registeredWbControls.TryGetValue(wb.ParentForm, out wblist))
            {
                lock (sync_remove)
                {
                    wblist.Remove(wb);
                    if (wblist.Count == 0)
                    {
                        registeredWbControls.Remove(wb.ParentForm);
                    }
                }
            }
        }
        internal static void DisposeCefWbControl(System.Windows.Forms.Form ownerForm)
        {
            //register this control with parent form 
            List<MyCefBrowser> foundList;
            if (registeredWbControls.TryGetValue(ownerForm, out foundList))
            {
                //remove wb controls             
                for (int i = foundList.Count - 1; i >= 0; --i)
                {
                    var wb = foundList[i].ParentControl;
                    var parent = wb.Parent;
                    parent.Controls.Remove(wb);
                    wb.Dispose();
                }

                registeredWbControls.Remove(ownerForm);

            }

        }
        internal static bool IsReadyToClose(System.Windows.Forms.Form ownerForm)
        {
            //register this control with parent form  
            lock (sync_remove)
            {
                return !registeredWbControls.ContainsKey(ownerForm);
            }
        }
        public static void UISafeInvoke(SimpleDel del)
        {
            tinyForm.Invoke(del);
        }
        void RenderProcessOnContextCreated(NativeCallArgs args)
        {

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

                        System.Windows.Forms.Form popupWin = new System.Windows.Forms.Form();
                        popupWin.Width = 600;
                        popupWin.Height = 450;
                        popupWin.Show();

                        IntPtr handle = popupWin.Handle;
                        if (argsPtr != IntPtr.Zero)
                        {
                            NativeCallArgs2 args = new NativeCallArgs2(argsPtr);
                            args.SetResult(handle);

                        }

                    }
                    break;
                case 104:
                    {
                        UISafeInvoke(new SimpleDel(
                            () =>
                            {
                                CefBridgeTest.Form1 newPopupForm = new CefBridgeTest.Form1();

                                NativeCallArgs args = new NativeCallArgs(argsPtr);
                                string url = args.GetArgAsString(0);
                                newPopupForm.InitUrl = url;


                                newPopupForm.Show();
                                args.Dispose();
                            }));

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
                        UISafeInvoke(new SimpleDel(
                            () =>
                            {
                                CefBridgeTest.Form1 newPopupForm = new CefBridgeTest.Form1();
                                newPopupForm.Show();
                            }));
                    }
                    break;
                case 202:
                    {
                        //client app callback
                        //eg. from RenderClientApp
                        //in render process ***
                        //we can register external methods  for window object here.
                        //NativeMethods.MessageBox(IntPtr.Zero, id.ToString(), "NN2", 0);
                        NativeCallArgs args = new NativeCallArgs(argsPtr);
                        RenderProcessOnContextCreated(args);
                    }
                    break;
            }
        }
    }

}