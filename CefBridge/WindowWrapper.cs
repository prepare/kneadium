//2015-2016 MIT, WinterDev

using System;
namespace LayoutFarm.CefBridge
{
    public interface IWindowControl : System.IDisposable
    {
        IntPtr GetHandle();
        IWindowControl GetTopLevelControl();
        void Show();
        IWindowControl GetParent();
        void RemoveChild(IWindowControl child);
    }
    public interface IWindowForm : IWindowControl
    {
        void Close();
        string Text { get; set; }
    }
}