using System;
using Pencil.Gaming;
using LayoutFarm.CefBridge;
using PixelFarm.Forms;

namespace TestGlfw
{


    class MyFormWrapper : IWindowForm
    {

        IntPtr nativeWindowHwnd;
        string text;
        public MyFormWrapper(IntPtr nativeWindowHwnd)
        {
            this.nativeWindowHwnd = nativeWindowHwnd;
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
            }
        }

        public event EventHandler FormClosed;

        public void Close()
        {
            //TODO implement this
            if (FormClosed != null)
            {
                FormClosed(null, EventArgs.Empty);
            }
        }

        public void Dispose()
        {

        }

        public IntPtr GetHandle()
        {
            return nativeWindowHwnd;
        }

        public IWindowControl GetParent()
        {
            return null;
        }

        public IWindowControl GetTopLevelControl()
        {
            return this;
        }

        public void MarkAsDisposed()
        {

        }

        public void RemoveChild(IWindowControl child)
        {

        }

        public void Show()
        {

        }
    }
}