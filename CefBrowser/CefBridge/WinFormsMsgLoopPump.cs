//MIT, 2016-2017, WinterDev, brezza92, EngineKit

using System;
using System.Windows.Forms;
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
                tinyForm = new Form();
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
            bool looping1 = false;
            loopTimer.Interval = 30;//30fps
            loopTimer.Tick += (s, e) =>
            {
                if (appIsIdel)
                {
                    looping1 = true;
                    appIsIdel = false;
                    for (int i = 10; i >= 0; --i)
                    {
                        MyCef3InitEssential.CefDoMessageLoopWork();

                    }

                    looping1 = false;
                }
            };

            Application.Idle += (s, e) =>
            {
                if (!looping1)
                {
                    appIsIdel = true;
                }
            };

            loopTimer.Enabled = true;
        }
        public static void SafeUIInvoke(SimpleDel simpleDel)
        {
            tinyForm.Invoke(simpleDel);
        }
    }
}