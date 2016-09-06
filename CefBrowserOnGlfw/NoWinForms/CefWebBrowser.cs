//2015-2016, BSD, WinterDev
// Copyright © 2010-2014 The CefSharp Authors. All rights reserved. 
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using PixelFarm.Forms; 
namespace LayoutFarm.CefBridge
{
    public sealed class CefWebBrowserControl : Control
    {
        MyCefBrowser cefBrowser;
        IWindowControl thisWindowControl;
        public event EventHandler BrowserReady;
        public CefWebBrowserControl()
        {
            //SetStyle(
            //    ControlStyles.ContainerControl
            //    | ControlStyles.ResizeRedraw
            //    | ControlStyles.FixedWidth
            //    | ControlStyles.FixedHeight
            //    | ControlStyles.StandardClick
            //    | ControlStyles.UserMouse
            //    | ControlStyles.SupportsTransparentBackColor
            //    | ControlStyles.StandardDoubleClick
            //    | ControlStyles.OptimizedDoubleBuffer
            //    | ControlStyles.CacheText
            //    | ControlStyles.EnableNotifyMessage
            //    | ControlStyles.DoubleBuffer
            //    | ControlStyles.OptimizedDoubleBuffer
            //    | ControlStyles.UseTextForAccessibility
            //    | ControlStyles.Opaque,
            //    false);
            //SetStyle(
            //    ControlStyles.UserPaint
            //    | ControlStyles.AllPaintingInWmPaint
            //    | ControlStyles.Selectable,
            //    true);
            thisWindowControl = MyWindowControl.TryGetWindowControlOrRegisterIfNotExists(this);
        }
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            //switch (e.KeyCode)
            //{
            //    case Keys.Up:
            //    case Keys.Down:
            //    case Keys.Left:
            //    case Keys.Right:
            //        e.IsInputKey = true;
            //        break;
            //}
        }
        public void NavigateTo(string url)
        {
            if (cefBrowser != null)
            {
                this.cefBrowser.NavigateTo(url);
            }
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
                InitWebBrowserControl();
            }
        }
        void InitWebBrowserControl()
        {
            //---------
            //create timer for notify when browser is ready
            var bwReadyTimer = new Timer();
            bwReadyTimer.Interval = 50;//ms
            bwReadyTimer.Tick += (s, e1) =>
            {
                if (this.IsHandleCreated && this.Agent.IsBrowserCreated)
                {
                    bwReadyTimer.Enabled = false;//stop timer
                    if (cefBrowser != null)
                    {
                        cefBrowser.SetSize(this.Width, this.Height);
                    }

                    if (BrowserReady != null)
                    {
                        BrowserReady(this, EventArgs.Empty);
                    }
                    bwReadyTimer.Dispose();
                    bwReadyTimer = null;
                }
            };
            bwReadyTimer.Enabled = true;
            //---------
            //create cef browser when handle is created 
            this.cefBrowser = new MyCefBrowser(thisWindowControl, 0, 0, 800, 500, "about:blank");
        }
    }
}