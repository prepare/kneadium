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

        static void MxCallBack(int id, IntPtr argsPtr)
        {
            switch (id)
            {
                case 100:
                    {
                        //test only

                    } break;
                case 101:
                    {
                    } break;
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

                    } break;
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

                    } break;
                case 106:
                    {
                        //console.log ...

                        NativeCallArgs args = new NativeCallArgs(argsPtr);
                        string msg = args.GetArgAsString(0);
                        string src = args.GetArgAsString(1);
                        string location = args.GetArgAsString(2);
                        Console.WriteLine(msg);

                    } break;
                case 107:
                    {
                        //show dev tools
                        UISafeInvoke(new SimpleDel(
                            () =>
                            {
                                CefBridgeTest.Form1 newPopupForm = new CefBridgeTest.Form1();
                                newPopupForm.Show();
                            }));
                    } break;
            }
        }





    }

}