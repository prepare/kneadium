//MIT, 2015-2017, WinterDev

namespace LayoutFarm.CefBridge
{
    public class CefStartArgs
    {
        public bool IsValidCefArgs { get; private set; }
        public string ProcessType { get; private set; }

        private CefStartArgs() { }

        public static CefStartArgs Parse(string[] startupArgs)
        {
            var cefStartArgs = new CefStartArgs();
            int j = startupArgs.Length;
            for (int i = 0; i < j; ++i)
            {
                string arg = startupArgs[i];
                if (arg.StartsWith("--"))
                {
                    //find what type
                    string[] split1 = arg.Split('=');
                    if (split1.Length == 2)
                    {
                        switch (split1[0])
                        {
                            case "--type":
                                {
                                    cefStartArgs.IsValidCefArgs = true;
                                    cefStartArgs.ProcessType = split1[1];
                                    //in this version we stop here
                                    //ignore other ...
                                    //this not correct 
                                    i = j + 1;
                                }
                                break;
                        }
                    }
                }
            }
            return cefStartArgs;
        }
    }
}