///MIT, 2015-2017, WinterDev


using System;
namespace LayoutFarm.CefBridge
{
    public class MyCefDevWindow
    {

        readonly MyCefBw _myCefBw;
        readonly MyCefCallback managedCallback;
        public MyCefDevWindow()
        {
            //create cef browser view handler  
            this.managedCallback = new MyCefCallback(this.MxCallBack);
            _myCefBw = new MyCefBw(Cef3Binder.MyCefCreateMyWebBrowser(managedCallback));
        }
        public IntPtr GetMyCefBrowser()
        {
            return _myCefBw.ptr;
        }
        void MxCallBack(int id, IntPtr argsPtr)
        {

        }
    }
}