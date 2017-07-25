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
            this.cmdMakePatchFiles = new System.Windows.Forms.Button();
            this.cmdLoadPatchAndDoPatch = new System.Windows.Forms.Button();
            this.cmdMacApplyPatches = new System.Windows.Forms.Button();
            this.cmdMacBuildPatchesFromSrc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMakePatchFiles
            // 
            this.cmdMakePatchFiles.Location = new System.Drawing.Point(442, 39);
            this.cmdMakePatchFiles.Name = "cmdMakePatchFiles";
            this.cmdMakePatchFiles.Size = new System.Drawing.Size(282, 40);
            this.cmdMakePatchFiles.TabIndex = 1;
            this.cmdMakePatchFiles.Text = "Create New Patches from Source";
            this.cmdMakePatchFiles.UseVisualStyleBackColor = true;
            this.cmdMakePatchFiles.Click += new System.EventHandler(this.cmdCreatePatchFiles_Click);
            // 
            // cmdLoadPatchAndDoPatch
            // 
            this.cmdLoadPatchAndDoPatch.Location = new System.Drawing.Point(36, 39);
            this.cmdLoadPatchAndDoPatch.Name = "cmdLoadPatchAndDoPatch";
            this.cmdLoadPatchAndDoPatch.Size = new System.Drawing.Size(294, 40);
            this.cmdLoadPatchAndDoPatch.TabIndex = 2;
            this.cmdLoadPatchAndDoPatch.Text = "LoadPatch and Apply Patch";
            this.cmdLoadPatchAndDoPatch.UseVisualStyleBackColor = true;
            this.cmdLoadPatchAndDoPatch.Click += new System.EventHandler(this.cmdLoadPatchAndApplyPatch_Click);
            // 
            // cmdMacApplyPatches
            // 
            this.cmdMacApplyPatches.Location = new System.Drawing.Point(36, 187);
            this.cmdMacApplyPatches.Name = "cmdMacApplyPatches";
            this.cmdMacApplyPatches.Size = new System.Drawing.Size(294, 40);
            this.cmdMacApplyPatches.TabIndex = 4;
            this.cmdMacApplyPatches.Text = "[TEST mac] LoadPatch and Apply Patch";
            this.cmdMacApplyPatches.UseVisualStyleBackColor = true;
            this.cmdMacApplyPatches.Click += new System.EventHandler(this.cmdMacApplyPatches_Click);
            // 
            // cmdMacBuildPatchesFromSrc
            // 
            this.cmdMacBuildPatchesFromSrc.Location = new System.Drawing.Point(442, 187);
            this.cmdMacBuildPatchesFromSrc.Name = "cmdMacBuildPatchesFromSrc";
            this.cmdMacBuildPatchesFromSrc.Size = new System.Drawing.Size(282, 40);
            this.cmdMacBuildPatchesFromSrc.TabIndex = 3;
            this.cmdMacBuildPatchesFromSrc.Text = "[TEST mac] Create New Patches from Source";
            this.cmdMacBuildPatchesFromSrc.UseVisualStyleBackColor = true;
            this.cmdMacBuildPatchesFromSrc.Click += new System.EventHandler(this.cmdMacBuildPatchesFromSrc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "TestApiBuilder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "TestWrapperApiBuilder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdMacApplyPatches);
            this.Controls.Add(this.cmdMacBuildPatchesFromSrc);
            this.Controls.Add(this.cmdLoadPatchAndDoPatch);
            this.Controls.Add(this.cmdMakePatchFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdMakePatchFiles;
        private System.Windows.Forms.Button cmdLoadPatchAndDoPatch;
        private System.Windows.Forms.Button cmdMacApplyPatches;
        private System.Windows.Forms.Button cmdMacBuildPatchesFromSrc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

