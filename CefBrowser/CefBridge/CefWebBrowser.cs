//BSD, 2015-2017, WinterDev
// Copyright © 2010-2014 The CefSharp Authors. All rights reserved. 
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace LayoutFarm.CefBridge
{
    public sealed class CefWebBrowserControl : Control
    {
        MyCefBrowser cefBrowser;
        IWindowControl thisWindowControl;
        public event EventHandler BrowserReady;
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
            thisWindowControl = MyWindowControl.TryGetWindowControlOrRegisterIfNotExists(this);
        }
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
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
                    //we use this timer once
                    //so...
                    //after notify we delete it
                    bwReadyTimer.Dispose();
                    bwReadyTimer = null;
                }
            };
            bwReadyTimer.Enabled = true;

            //---------
            //create cef browser when handle is created 
            MyCefOsrListener osrListener = new MyCefOsrListener();
            //this.cefBrowser = new MyCefBrowser(thisWindowControl, 0, 0, 800, 500, "about:blank", true) { OsrListener = osrListener };
            this.cefBrowser = new MyCefBrowser(thisWindowControl, 0, 0, 800, 500, "about:blank", false);

        }

        class MyCefOsrListener : CefOsrListener
        {
            //test output
            int n = 0;

            public override void OnRender(NativeCallArgs args)
            {
                //if not set to 0
                //images not render to native cef win                 

                return; //just return
                if (n > 100) return;
                //----------------------

                IntPtr rawBitBuffer = args.GetArgAsNativePtr(0);
                int width = args.GetArgAsInt32(1);
                int height = args.GetArgAsInt32(2);

                unsafe
                {
                    using (Bitmap bmp = new Bitmap(width, height))
                    {
                        var bmpdata = bmp.LockBits(
                            new Rectangle(0, 0, width, height),
                            System.Drawing.Imaging.ImageLockMode.ReadWrite,
                            System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                        CopyMemory(bmpdata.Scan0, rawBitBuffer, width * height * 4);
                        bmp.UnlockBits(bmpdata);
                        bmp.Save(ReferencePaths.SAVE_IMAGE_PATH + (n++) + ".jpg");
                    }
                }
            }

            [System.Runtime.InteropServices.DllImport("kernel32.dll")]
            static extern void CopyMemory(IntPtr dest, IntPtr src, int count);
        }
    }
}