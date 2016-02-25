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

        public MyWindowControl(System.Windows.Forms.Control control)
        {
            this.control = control;

        }
        IntPtr IWindowControl.GetHandle()
        {
            return this.control.Handle;
        }

        void IWindowControl.Show()
        {
            control.Show();
        }
        public void Dispose()
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
        public MyWindowForm(Form form)
            : base(form)
        {
            this.form = form;
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