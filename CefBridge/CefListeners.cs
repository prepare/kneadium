//MIT, 2015-2017, WinterDev

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
        public virtual void OnDownloadCompleted(NativeCallArgs args) { }
        public virtual void OnExecProtocol(NativeCallArgs args) { }
    }

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
            //MyCefSetVoidPtr2(&vargs[1], app.get());
            //MyCefSetVoidPtr2(&vargs[2], browser.get());
            //MyCefSetVoidPtr2(&vargs[3], frame.get());
            //MyCefSetVoidPtr2(&vargs[4], context.get());

            clientRenderApp = new NativeRendererApp(args.GetArgAsNativePtr(1));
            browser = new NativeBrowser(args.GetArgAsNativePtr(2));
            nativeFrame = new NativeFrame(args.GetArgAsNativePtr(3));
            context = new NativeJsContext(args.GetArgAsNativePtr(4));
        }
    }
}