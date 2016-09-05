//2016, MIT, WinterDev

using System;
using System.Text;
using System.Windows.Forms;
using LayoutFarm.CefBridge;
using System.Collections.Generic;
namespace LayoutFarm.CefBridge
{
    static class WinFormCefMsgLoopPump
    {

        static Timer loopTimer = new Timer();
        static Form tinyForm;
        static IntPtr tinyFormHandle;
        public static void Start()
        {
            if (tinyForm == null)
            {
                tinyForm = new System.Windows.Forms.Form();
                tinyForm.Size = new System.Drawing.Size(10, 10);
                tinyForm.Visible = false;
            }
            //force it create handle****  
            tinyFormHandle = tinyForm.Handle;

            //Cef3's message pump ***
            //---------------------------
            //this is CefMsgLoopPump implementation
            //it should not too fast or too slow to call  
            bool appIsIdel = true;
            loopTimer.Interval = 30;//30fps
            loopTimer.Tick += (s, e) =>
            {
                if (appIsIdel)
                {
                    for (int i = 10; i >= 0; --i)
                    {
                        MyCef3InitEssential.CefDoMessageLoopWork();
                    }
                    appIsIdel = false;
                }
            };

            Application.Idle += (s, e) =>
            {
                appIsIdel = true;
            };

            loopTimer.Enabled = true;
        }
        public static void SafeUIInvoke(SimpleDel simpleDel)
        {
            tinyForm.Invoke(simpleDel);
        }
    }
}