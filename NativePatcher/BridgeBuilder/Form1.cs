using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BridgeBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBuild1_Click(object sender, EventArgs e)
        {

            string srcRootDir = @"D:\projects\cef_binary_3.2526.1366\cefclient";
            Builder builder = new Builder(srcRootDir);
            builder.DoChanged();

        }
    }
}
