//MIT, 2015-2017, WinterDev

namespace LayoutFarm.CefBridge
{


    public abstract class CefOsrListener
    {
        public virtual void OnRender(NativeCallArgs args) { }

    }
    /// <summary>
    /// listener for render process
    /// </summary>
    public abstract class CefRenderProcessListener
    {
        public virtual void OnWebKitInitialized(NativeCallArgs nativeCallArgs) { }
        public virtual void OnContextCreated(MyCefContextArgs args) { }
        public virtual void OnContextReleased(MyCefContextArgs args) { }
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