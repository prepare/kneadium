//2016, MIT, WinterDev

using System;
using System.Windows.Forms;
namespace LayoutFarm.CefBridge
{
    class MyWindowControl : IWindowControl
    {
        Control control;
        MyWindowControl topLevelWindowControl;
        MyWindowControl parentControl;
        bool markedAsDisposed;
        public MyWindowControl(Control control)
        {
            this.control = control;
        }

        IntPtr IWindowControl.GetHandle()
        {
            //sometime control was disposed
            if (markedAsDisposed)
            {
                return IntPtr.Zero;
            }
            return control.Handle;
        }
        void IWindowControl.MarkAsDisposed()
        {
            markedAsDisposed = true;
        }

        void IWindowControl.Show()
        {
            control.Show();
        }
        void IDisposable.Dispose()
        {
            //if (control != null)
            //{
            //    control.Dispose();
            //    control = null;
            //}
        }
        IWindowControl IWindowControl.GetTopLevelControl()
        {
            //TODO: review here again
            System.Windows.Forms.Control realTopLevelWindowControl = control.TopLevelControl;
            if (topLevelWindowControl == null ||
                topLevelWindowControl.control != realTopLevelWindowControl)
            {
                if (realTopLevelWindowControl is System.Windows.Forms.Form)
                {
                    topLevelWindowControl = new MyWindowForm((System.Windows.Forms.Form)realTopLevelWindowControl);
                }
                else
                {
                    //create new
                    topLevelWindowControl = new MyWindowControl(realTopLevelWindowControl);
                }
            }

            return topLevelWindowControl;
        }
        IWindowControl IWindowControl.GetParent()
        {
            //TODO: review here again
            System.Windows.Forms.Control realParentControl = control.Parent;
            if (parentControl == null ||
                parentControl.control != realParentControl)
            {
                //create new
                parentControl = new MyWindowControl(realParentControl);
            }
            return parentControl;
        }
        void IWindowControl.RemoveChild(IWindowControl child)
        {
            var child1 = (MyWindowControl)child;
            this.control.Controls.Remove(child1.control);
        }


    }

    class MyWindowForm : MyWindowControl, IWindowForm
    {
        Form form;
        Timer tmClosingCheck;
        bool startClosing;
        public MyWindowForm(Form form)
            : base(form)
        {
            this.form = form;
            //not enable when start
            //tmClosingCheck will start when form is closing
            tmClosingCheck = new Timer();
            tmClosingCheck.Interval = 200;
            tmClosingCheck.Tick += TmClosingCheck_Tick;
            form.FormClosing += Form_FormClosing;
            form.FormClosed += Form_FormClosed;
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form has closed
            ((IWindowForm)this).MarkAsDisposed();
        }
        private void TmClosingCheck_Tick(object sender, EventArgs e)
        {
            if (MyCefBrowser.IsReadyToClose(formHandle))
            {
                tmClosingCheck.Enabled = false;
                form.Close();
            }
        }

        IntPtr formHandle;
        object closingLock = new object();
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //essential
            //monitor form closing 
            bool closing = false;
            lock (closingLock)
            {
                closing = startClosing;
            }
            if (!closing)
            {
                startClosing = closing = true;
                e.Cancel = true;
                formHandle = form.Handle;
                MyCefBrowser.DisposeCefWbControl(this);
                tmClosingCheck.Enabled = true;
            }

        }

        void IWindowForm.Close()
        {
            this.form.Close();
        }
        string IWindowForm.Text
        {
            get { return form.Text; }
            set
            {
                form.Text = value;
            }
        }
    }
}