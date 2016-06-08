//2015-2016 MIT, WinterDev

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
namespace LayoutFarm.CefBridge
{

    public class Cef3BinderForNativeWindow
    {

        const string CEF_CLIENT_DLL = "cefclient.dll";
#if DEBUG
        public static bool s_dbugIsRendererProcess;
#endif 

        static CefClientApp clientApp;
        static CustomSchemeAgent customScheme;
        public static IWindowForm CreateBlankForm(int width, int height)
        {
            return null;
        }

        [DllImport(CEF_CLIENT_DLL)]
        public static extern IntPtr MyCefCreateNativeWindow(int width, int height);
    }



}