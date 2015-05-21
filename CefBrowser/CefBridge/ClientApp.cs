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

        internal static bool readyToClose;
        static bool isInitWithProcessHandle;
        static object sync_ = new object();

        MyCefCallback mxCallback;
        System.Windows.Forms.Form tinyForm;

        delegate void SimpleDel();

        public CefClientApp(IntPtr processHandle)
        {
            lock (sync_)
            {
                //init once
                if (!isInitWithProcessHandle)
                {
                    isInitWithProcessHandle = true;

                    this.clientAppPtr = Cef3Binder.MyCefCreateClientApp();
                    int initResult = Cef3Binder.MyCefInit(processHandle, clientAppPtr);
                    //register managed callback ***
                    this.mxCallback = new MyCefCallback(MxCallBack);
                    Cef3Binder.RegisterManagedCallBack(this.mxCallback, 3);
                }
            }
        }
       
        public IntPtr CefReady()
        {
            //make it a hidden form
            tinyForm = new System.Windows.Forms.Form();
            tinyForm.Size = new System.Drawing.Size(10, 10);
            tinyForm.Visible = false;
            return tinyForm.Handle;//force it create handle
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
                        tinyForm.Invoke(new SimpleDel(
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
                        tinyForm.Invoke(new SimpleDel(
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