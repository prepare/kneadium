//MIT, 2016-2017, WinterDev

using System;
using System.Windows.Forms;

namespace LayoutFarm.CefBridge
{
    public class MyCef3WinForms : Cef3WinForms
    {
        public override void SetAsCurrentImpl()
        {
            Cef3WinForms.SetMeAsCurrentImpl(this);
        }
        public override void SaveUIInvoke(SimpleDel simpleDel)
        {
            WinFormCefMsgLoopPump.SafeUIInvoke(simpleDel);
        }
        public override IWindowForm CreateNewWindow(int width, int height)
        {
            Form form1 = new Form();
            form1.Width = width;
            form1.Height = height;
            return MyWindowForm.TryGetWindowFormOrRegisterIfNotExists(form1);
        }
        public override IWindowForm CreateNewBrowserWindow(int width, int height)
        {
            Form form1 = new Form();
            form1.Width = width;
            form1.Height = height;
            return MyWindowForm.TryGetWindowFormOrRegisterIfNotExists(form1);
        }
    }
}