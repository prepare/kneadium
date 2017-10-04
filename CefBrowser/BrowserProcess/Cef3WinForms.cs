//MIT, 2015-2017, WinterDev


namespace LayoutFarm.CefBridge
{
    static partial class Cef3Binder
    {
        public static IWindowForm CreateBlankForm(int width, int height)
        {
            return Cef3WinForms.s_currentImpl.CreateNewWindow(width, height);
        }
        public static IWindowForm CreateNewBrowserWindow(int width, int height)
        {
            return Cef3WinForms.s_currentImpl.CreateNewBrowserWindow(width, height);
        }

        public static void SafeUIInvoke(SimpleDel del)
        {
            Cef3WinForms.s_currentImpl.SaveUIInvoke(del);
        }
    }

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