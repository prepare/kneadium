//2016, MIT, WinterDev

using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace LayoutFarm.CefBridge
{

    class MyWindowControl : IWindowControl
    {
        Control control;
        MyWindowControl topLevelWindowControl;
        MyWindowControl parentControl;
        bool markedAsDisposed;
        protected MyWindowControl() { }
        private MyWindowControl(Control control)
        {
            SetInnerControl(control);
        }
        protected void SetInnerControl(Control control)
        {
            this.control = control;
        }
        IntPtr IWindowControl.GetHandle()
        {
            //sometime control was disposed 
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
            if (control != null)
            {
                control.Dispose();
                control = null;
            }
        }
        IWindowControl IWindowControl.GetTopLevelControl()
        {
            //TODO: review here again
            Control realTopLevelWindowControl = control.TopLevelControl;
            if (topLevelWindowControl == null ||
                topLevelWindowControl.control != realTopLevelWindowControl)
            {
                return topLevelWindowControl = (realTopLevelWindowControl is Form) ?
                        (MyWindowControl)MyWindowForm.TryGetWindowControlOrRegisterIfNotExists((Form)realTopLevelWindowControl) :
                         MyWindowControl.TryGetWindowControlOrRegisterIfNotExists(realTopLevelWindowControl);
            }

            return topLevelWindowControl;
        }
        IWindowControl IWindowControl.GetParent()
        {
            //TODO: review here again
            Control realParentControl = control.Parent;
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


        static Dictionary<Control, MyWindowControl> registerControls = new Dictionary<Control, MyWindowControl>();
        public static MyWindowControl TryGetWindowControlOrRegisterIfNotExists(Control control)
        {
            if (control is Form)
            {
                return MyWindowForm.TryGetWindowControlOrRegisterIfNotExists(control);
            }
            MyWindowControl myWinControl;
            if (!registerControls.TryGetValue(control, out myWinControl))
            {
                //register new one
                myWinControl = new CefBridge.MyWindowControl(control);
                registerControls.Add(control, myWinControl);
            }
            return myWinControl;
        }
    }

    class MyWindowForm : MyWindowControl, IWindowForm
    {
        Form form;
        Timer tmClosingCheck;
        bool startClosing;
        private MyWindowForm(Form form)
        {
            this.form = form;
            SetInnerControl(form);
            //not enable when start

            tmClosingCheck = new Timer();
            tmClosingCheck.Interval = 200;
            tmClosingCheck.Tick += TmClosingCheck_Tick;

            form.FormClosing += Form_FormClosing;
            form.FormClosed += Form_FormClosed;
        }
        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form has closed
            ((IWindowForm)this).MarkAsDisposed();
        }
        void TmClosingCheck_Tick(object sender, EventArgs e)
        {
            if (MyCefBrowser.IsReadyToClose(this))
            {
                tmClosingCheck.Enabled = false;
                form.Close();
                //we not dispose here
            }
        }

        IntPtr formHandle;
        object closingLock = new object();
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {

            bool closing = false;
            lock (closingLock)
            {
                closing = startClosing;
                startClosing = true;
            }
            if (!closing)
            {
                //this is 1st time we start close
                startClosing = closing = true;
                e.Cancel = true;
                formHandle = form.Handle;
                MyCefBrowser.DisposeAllChildWebBrowserControls(this);
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
        static Dictionary<Form, MyWindowForm> registerControls = new Dictionary<Form, MyWindowForm>();
        public static IWindowForm TryGetWindowControlOrRegisterIfNotExists(Form form)
        {
            MyWindowForm myWinForm;
            if (!registerControls.TryGetValue(form, out myWinForm))
            {
                //register new one
                myWinForm = new MyWindowForm(form);
                registerControls.Add(form, myWinForm);
            }
            return myWinForm;
        }
    }



}