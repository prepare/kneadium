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
        public readonly NativeRendererApp clientRenderApp;
        public readonly NativeBrowser browser;
        public readonly NativeFrame nativeFrame;
        public readonly NativeJsContext context;
        public MyCefContextArgs(NativeCallArgs args)
        {
            clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(1));
            browser = new NativeBrowser(args.GetArgAsNativePtr(2));
            nativeFrame = new NativeFrame(args.GetArgAsNativePtr(3));
            context = new NativeJsContext(args.GetArgAsNativePtr(4));
        }
    }
}