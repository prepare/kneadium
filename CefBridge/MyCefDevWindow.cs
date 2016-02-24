//2015 MIT, WinterDev
using System; 
namespace LayoutFarm.CefBridge
{ 
    public class MyCefDevWindow
    {

        IntPtr myCefBrowser;
        MyCefCallback managedCallback;
        public MyCefDevWindow()
        {
            //create cef browser view handler  
            this.managedCallback = new MyCefCallback(this.MxCallBack);
            this.myCefBrowser = Cef3Binder.MyCefCreateMyWebBrowser(managedCallback); 
        }
        public IntPtr GetMyCefBrowser()
        {
            return this.myCefBrowser;
        }
        void MxCallBack(int id, IntPtr argsPtr)
        {
            switch (id)
            {
                case 100:
                    {
                    }
                    break;
            }

        }
    }

}