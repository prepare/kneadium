namespace CefBridgeTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button7 = new System.Windows.Forms.Button();
            this.cefWebBrowser1 = new LayoutFarm.CefBridge.CefWebBrowser();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Navigate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cefWebBrowser1
            // 
            this.cefWebBrowser1.Location = new System.Drawing.Point(162, 12);
            this.cefWebBrowser1.Name = "cefWebBrowser1";
            this.cefWebBrowser1.Size = new System.Drawing.Size(802, 531);
            this.cefWebBrowser1.TabIndex = 6;
            this.cefWebBrowser1.Text = "cefWebBrowser1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 555);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cefWebBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LayoutFarm.CefBridge.CefWebBrowser cefWebBrowser1;
        private System.Windows.Forms.Button button7;
    }
}

