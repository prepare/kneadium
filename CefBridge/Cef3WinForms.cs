//MIT, 2015-2017, WinterDev


namespace LayoutFarm.CefBridge
{
    public abstract class Cef3WinForms
    {
        public abstract IWindowForm CreateNewWindow(int width, int height);
        public abstract IWindowForm CreateNewBrowserWindow(int width, int height);
        public abstract void SaveUIInvoke(SimpleDel simpleDel);

        protected static void SetMeAsCurrentImpl(Cef3WinForms impl)
        {
            s_currentImpl = impl;
        }
        internal static Cef3WinForms s_currentImpl;
        public abstract void SetAsCurrentImpl();        
    }
}