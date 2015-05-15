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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cefWebBrowser1 = new LayoutFarm.CefBridge.CefWebBrowser();
<<<<<<< HEAD
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
=======
>>>>>>> origin/mod1
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "ExecJs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "PostData";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "GetText";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "GetSource";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 37);
            this.button5.TabIndex = 13;
            this.button5.Text = "SchemeTest";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cefWebBrowser1
            // 
            this.cefWebBrowser1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cefWebBrowser1.Location = new System.Drawing.Point(162, 12);
            this.cefWebBrowser1.Name = "cefWebBrowser1";
            this.cefWebBrowser1.Size = new System.Drawing.Size(802, 459);
            this.cefWebBrowser1.TabIndex = 6;
            this.cefWebBrowser1.Text = "cefWebBrowser1";
            // 
<<<<<<< HEAD
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 37);
            this.button6.TabIndex = 14;
            this.button6.Text = "SchemeTest";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 488);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 37);
            this.button8.TabIndex = 15;
            this.button8.Text = "SchemeTest";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
=======
>>>>>>> origin/mod1
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 621);
<<<<<<< HEAD
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
=======
>>>>>>> origin/mod1
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cefWebBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.Form1_Load);
=======
>>>>>>> origin/mod1
            this.ResumeLayout(false);

        }

        #endregion

        private LayoutFarm.CefBridge.CefWebBrowser cefWebBrowser1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
<<<<<<< HEAD
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
=======
>>>>>>> origin/mod1
    }
}

