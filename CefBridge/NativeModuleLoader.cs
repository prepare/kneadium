//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge
{

    enum OsPlatform
    {
        Unknown,
        Windows,
        Mac,
        Linux
    }
    static class PlatformNeutralMethods
    {
        static NativeModuleLoader nativeModuleLoader;
        static PlatformNeutralMethods()
        {
            //evaluate current platform
            switch (GetOsName())
            {
                //TODO: review here for linux
                default:
                    throw new NotSupportedException();
                case OsPlatform.Windows:
                    nativeModuleLoader = new Win32NativeModuleLoader();
                    break;
                case OsPlatform.Mac:
                    nativeModuleLoader = new MacOsNativeModuleLoader();
                    break;
            }
        }
        public static OsPlatform GetOsName()
        {
            //check platform
#if NETCOREAPP1_1
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.OSX))
            {
                return OsPlatform.Mac;
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.Linux)
                )
            {
                return OsPlatform.Linux;
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
              System.Runtime.InteropServices.OSPlatform.Windows))
            {
                return OsPlatform.Windows;
            }
            else
            {
                return OsPlatform.Unknown;
            }            
#else
            OperatingSystem os = Environment.OSVersion;
            switch (os.Platform)
            {
                default:
                    throw new NotSupportedException();
                case PlatformID.MacOSX:
                    return OsPlatform.Mac;
                case PlatformID.Win32NT:
                    return OsPlatform.Windows;
            }
#endif
        }


        public static IntPtr LoadLibrary(string libname)
        {
            return nativeModuleLoader.LoadLib(libname);
        }
        public static string GetError()
        {
            return nativeModuleLoader.GetError();
        }
    }


    abstract class NativeModuleLoader
    {

        public abstract IntPtr LoadLib(string libname);
        public abstract bool FreeLib(IntPtr hModule);
        public abstract IntPtr GetFunc(IntPtr hModule, string funcName);
        public abstract string GetError();

    }
    class Win32NativeModuleLoader : NativeModuleLoader
    {
        //TODO: review here, check for other platforms
        //-----------------------------------------------
        //this is Windows Specific class ***
        [DllImport("Kernel32.dll")]
        static extern IntPtr LoadLibrary(string libraryName);
        [DllImport("Kernel32.dll")]
        static extern bool FreeLibrary(IntPtr hModule);
        [DllImport("Kernel32.dll")]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("Kernel32.dll")]
        static extern uint SetErrorMode(int uMode);
        [DllImport("Kernel32.dll")]
        static extern uint GetLastError();

        public override IntPtr LoadLib(string libname)
        {
            return LoadLibrary(libname);
        }

        public override bool FreeLib(IntPtr hModule)
        {
            return FreeLibrary(hModule);
        }

        public override IntPtr GetFunc(IntPtr hModule, string funcName)
        {
            return GetProcAddress(hModule, funcName);
        }
        public override string GetError()
        {
            uint lastError = GetLastError();
            if (lastError == 0)
            {
                return null;
            }
            else
            {
                return lastError.ToString();
            }
        }
        //---------------------- 

    }
    class MacOsNativeModuleLoader : NativeModuleLoader
    {
        /*
#define RTLD_LAZY   1
#define RTLD_NOW    2
#define RTLD_GLOBAL 4
*/
        [DllImport("libdl.so")]
        static extern IntPtr dlopen(string filename, int flags);
        [DllImport("libdl.so")]
        static extern int dlclose(IntPtr handle);
        [DllImport("libdl.so")]
        static extern IntPtr dlsym(IntPtr handle, string symbol);
        [DllImport("libdl.so")]
        static extern string dlerror();

        public override bool FreeLib(IntPtr hModule)
        {
            return dlclose(hModule) != 0;
        }
        public override IntPtr GetFunc(IntPtr hModule, string funcName)
        {
            return dlsym(hModule, funcName);
        }
        public override IntPtr LoadLib(string libname)
        {
            return dlopen(libname, 2);
        }
        public override string GetError()
        {
            return dlerror();
        }
    }


}