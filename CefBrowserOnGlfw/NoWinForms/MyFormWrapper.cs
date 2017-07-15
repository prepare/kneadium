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

        public void Close()
        {

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