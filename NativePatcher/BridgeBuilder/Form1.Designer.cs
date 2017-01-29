namespace BridgeBuilder
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
            this.cmdBuild1 = new System.Windows.Forms.Button();
            this.cmdMakePatchFiles = new System.Windows.Forms.Button();
            this.cmdLoadPatchAndDoPatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBuild1
            // 
            this.cmdBuild1.Location = new System.Drawing.Point(503, 39);
            this.cmdBuild1.Name = "cmdBuild1";
            this.cmdBuild1.Size = new System.Drawing.Size(162, 40);
            this.cmdBuild1.TabIndex = 0;
            this.cmdBuild1.Text = "ManualPatchFiles";
            this.cmdBuild1.UseVisualStyleBackColor = true;
            this.cmdBuild1.Visible = false;
            this.cmdBuild1.Click += new System.EventHandler(this.cmdBuild1_Click);
            // 
            // cmdMakePatchFiles
            // 
            this.cmdMakePatchFiles.Location = new System.Drawing.Point(232, 39);
            this.cmdMakePatchFiles.Name = "cmdMakePatchFiles";
            this.cmdMakePatchFiles.Size = new System.Drawing.Size(201, 40);
            this.cmdMakePatchFiles.TabIndex = 1;
            this.cmdMakePatchFiles.Text = "Create New Patches from Source";
            this.cmdMakePatchFiles.UseVisualStyleBackColor = true;
            this.cmdMakePatchFiles.Click += new System.EventHandler(this.cmdCreatePatchFiles_Click);
            // 
            // cmdLoadPatchAndDoPatch
            // 
            this.cmdLoadPatchAndDoPatch.Location = new System.Drawing.Point(36, 39);
            this.cmdLoadPatchAndDoPatch.Name = "cmdLoadPatchAndDoPatch";
            this.cmdLoadPatchAndDoPatch.Size = new System.Drawing.Size(162, 40);
            this.cmdLoadPatchAndDoPatch.TabIndex = 2;
            this.cmdLoadPatchAndDoPatch.Text = "LoadPatch and Apply Patch";
            this.cmdLoadPatchAndDoPatch.UseVisualStyleBackColor = true;
            this.cmdLoadPatchAndDoPatch.Click += new System.EventHandler(this.cmdLoadPatchAndApplyPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 326);
            this.Controls.Add(this.cmdLoadPatchAndDoPatch);
            this.Controls.Add(this.cmdMakePatchFiles);
            this.Controls.Add(this.cmdBuild1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBuild1;
        private System.Windows.Forms.Button cmdMakePatchFiles;
        private System.Windows.Forms.Button cmdLoadPatchAndDoPatch;
    }
}

