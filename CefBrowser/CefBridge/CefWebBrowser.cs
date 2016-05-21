//2015-2016, BSD, WinterDev
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

    public sealed class CefWebBrowserControl : Control
    {

        MyCefBrowser cefBrowser;
        IWindowControl thisWindowControl; 
        public CefWebBrowserControl()
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

            thisWindowControl = new MyWindowControl(this);
        }

        public void NavigateTo(string url)
        {
            this.cefBrowser.NavigateTo(url);
        }
        public MyCefBrowser Agent
        {
            get { return this.cefBrowser; }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (cefBrowser != null)
            {
                cefBrowser.SetSize(this.Width, this.Height);
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!DesignMode)
            {
                //create cef browser when handle is created
                
                this.cefBrowser = new MyCefBrowser(thisWindowControl, 0, 0, 800, 500, "about:blank"); 
            }
        }
        private void CefBrowser_BrowserCreated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cefBrowser.CurrentUrl))
            {
                cefBrowser.NavigateTo(cefBrowser.CurrentUrl);
            }
        }
        public void SetInitUrl(string initUrl)
        {

        }
        
        //internal void BrowserAfterCreated(CefBrowser browser)
        //{
        //    //_browser = browser;
        //    //_browserWindowHandle = _browser.GetHost().GetWindowHandle();
        //    //ResizeWindow(_browserWindowHandle, Width, Height);
        //}

        //internal void OnTitleChanged(string title)
        //{
        //    Title = title;

        //    var handler = TitleChanged;
        //    if (handler != null) handler(this, EventArgs.Empty);
        //}

        //public string Title { get; private set; }

        //public event EventHandler TitleChanged;

        //internal void OnAddressChanged(string address)
        //{
        //    Address = address;

        //    var handler = AddressChanged;
        //    if (handler != null) handler(this, EventArgs.Empty);
        //}

        //public string Address { get; private set; }

        //public event EventHandler AddressChanged;

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
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);

        //    //var form = TopLevelControl as Form;
        //    //if (form != null && form.WindowState != FormWindowState.Minimized)
        //    //{
        //    //    ResizeWindow(_browserWindowHandle, Width, Height);
        //    //}
        //}

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

        //private static void ResizeWindow(IntPtr handle, int width, int height)
        //{
        //    if (handle != IntPtr.Zero)
        //    {
        //        NativeMethods.SetWindowPos(handle, IntPtr.Zero,
        //            0, 0, width, height,
        //            SetWindowPosFlags.NoMove | SetWindowPosFlags.NoZOrder
        //            );
        //    }
        //}

    }
}