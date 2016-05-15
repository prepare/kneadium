//2015-2016 MIT, WinterDev

namespace LayoutFarm.CefBridge
{

    /// <summary>
    /// listener for browser process
    /// </summary>
    public abstract class CefUIProcessListener
    {
        public virtual void OnFilterUrl(NativeCallArgs args) { }
        public virtual void OnAddResourceMx(NativeResourceMx nativeResourceMx) { }
        public virtual void OnRequestForBinaryResource(NativeCallArgs args) { }
        public virtual void OnCefQuery(NativeCallArgs args, QueryRequestArgs reqArgs) { }
        public virtual void OnConsoleLog(NativeCallArgs args) { }
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

            clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(0));
            browser = new NativeBrowser(args.GetArgAsNativePtr(1));
            nativeFrame = new NativeFrame(args.GetArgAsNativePtr(2));
            context = new NativeJsContext(args.GetArgAsNativePtr(3));
        }
    }


}