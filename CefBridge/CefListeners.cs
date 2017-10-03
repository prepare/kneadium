//MIT, 2015-2017, WinterDev

namespace LayoutFarm.CefBridge
{


    public abstract class CefOsrListener
    {
        public virtual void OnRender(NativeCallArgs args) { }

    }
   

    public class MyCefContextArgs
    {

        public readonly NativeJsContext context;
        public MyCefContextArgs(NativeCallArgs args)
        {
            context = new NativeJsContext(args.GetArgAsNativePtr(4));
        }
    }
}