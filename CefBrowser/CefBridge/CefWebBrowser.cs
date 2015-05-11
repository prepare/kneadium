//2015 BSD, WinterDev

// Copyright © 2010-2014 The CefSharp Authors. All rights reserved. 
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace LayoutFarm.CefBridge
{

    public sealed class CefWebBrowser : Control
    {
        bool _handleCreated;
        CefBrowserAgent cefBrowserView;
        bool nativeHandleCreated = false;

        public CefWebBrowser()
        {
            SetStyle(
                ControlStyles.ContainerControl
                | ControlStyles.ResizeRedraw
                | ControlStyles.FixedWidth
                | ControlStyles.FixedHeight
                | ControlStyles.StandardClick
                | ControlStyles.UserMouse
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.StandardDoubleClick
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.CacheText
                | ControlStyles.EnableNotifyMessage
                | ControlStyles.DoubleBuffer
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UseTextForAccessibility
                | ControlStyles.Opaque,
                false);

            SetStyle(
                ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.Selectable,
                true);
        }
        public void NavigateTo(string url)
        {
            this.cefBrowserView.NavigateTo(url);
        }
        public CefBrowserAgent Agent
        {
            get { return this.cefBrowserView; }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (DesignMode)
            {
                //if (!_handleCreated) Paint += PaintInDesignMode;
            }
            else
            {
                if (!LayoutFarm.CefBridge.Cef3Binder.IsLoadCef3Success())
                {
                    MessageBox.Show("cef 3 not found");
                } 
                this.cefBrowserView = new CefBrowserAgent(this.Handle, 0, 0, 800, 500);
                nativeHandleCreated = true;
            }
            _handleCreated = true; 
        } 
        public void PrepareNativeClose()
        {
            if (nativeHandleCreated)
            {
                this.cefBrowserView.CloseView();
                nativeHandleCreated = false;
            }
        }
        protected override void Dispose(bool disposing)
        {


            //if (_browser != null)
            //{
            //    //var host = _browser.GetHost();
            //    //host.CloseBrowser();
            //    //host.ParentWindowWillClose();
            //    //host.Dispose();
            //    //_browser.Dispose();
            //    //_browser = null;
            //    //_browserWindowHandle = IntPtr.Zero;
            //}

            base.Dispose(disposing);
        }

        //internal void BrowserAfterCreated(CefBrowser browser)
        //{
        //    //_browser = browser;
        //    //_browserWindowHandle = _browser.GetHost().GetWindowHandle();
        //    //ResizeWindow(_browserWindowHandle, Width, Height);
        //}

        internal void OnTitleChanged(string title)
        {
            Title = title;

            var handler = TitleChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public string Title { get; private set; }

        public event EventHandler TitleChanged;

        //internal void OnAddressChanged(string address)
        //{
        //    Address = address;

        //    var handler = AddressChanged;
        //    if (handler != null) handler(this, EventArgs.Empty);
        //}

        public string Address { get; private set; }

        public event EventHandler AddressChanged;

        //internal void OnStatusMessage(string value)
        //{
        //    var handler = StatusMessage;
        //    if (handler != null) handler(this, new StatusMessageEventArgs(value));
        //}

        //public event EventHandler<StatusMessageEventArgs> StatusMessage;

        //protected override void OnPaint(PaintEventArgs e)
        //{

        //    base.OnPaint(e);
        //    e.Graphics.DrawRectangle(Pens.Red, new Rectangle(0, 0, 20, 20));
        //}
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //var form = TopLevelControl as Form;
            //if (form != null && form.WindowState != FormWindowState.Minimized)
            //{
            //    ResizeWindow(_browserWindowHandle, Width, Height);
            //}
        }

        //private void PaintInDesignMode(object sender, PaintEventArgs e)
        //{
        //    var width = this.Width;
        //    var height = this.Height;
        //    if (width > 1 && height > 1)
        //    {
        //        var brush = new SolidBrush(this.ForeColor);
        //        var pen = new Pen(this.ForeColor);
        //        pen.DashStyle = DashStyle.Dash;

        //        e.Graphics.DrawRectangle(pen, 0, 0, width - 1, height - 1);

        //        var fontHeight = (int)(this.Font.GetHeight(e.Graphics) * 1.25);

        //        var x = 3;
        //        var y = 3;

        //        e.Graphics.DrawString("CefWebBrowser", Font, brush, x, y + (0 * fontHeight));
        //        e.Graphics.DrawString(string.Format("StartUrl: {0}", StartUrl), Font, brush, x, y + (1 * fontHeight));

        //        brush.Dispose();
        //        pen.Dispose();
        //    }
        //}

        private static void ResizeWindow(IntPtr handle, int width, int height)
        {
            if (handle != IntPtr.Zero)
            {
                NativeMethods.SetWindowPos(handle, IntPtr.Zero,
                    0, 0, width, height,
                    SetWindowPosFlags.NoMove | SetWindowPosFlags.NoZOrder
                    );
            }
        }

        //public CefBrowser Browser { get { return _browser; } }
    }
}