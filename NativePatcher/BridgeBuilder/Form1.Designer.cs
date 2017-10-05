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
            this.cmdCefBridgeCodeGen = new System.Windows.Forms.Button();
            this.cmdCopyDevSnap = new System.Windows.Forms.Button();
            this.cmbCefSrcFolder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdShowCefSourceFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMakePatchFiles
            // 
            this.cmdMakePatchFiles.Location = new System.Drawing.Point(52, 218);
            this.cmdMakePatchFiles.Name = "cmdMakePatchFiles";
            this.cmdMakePatchFiles.Size = new System.Drawing.Size(282, 40);
            this.cmdMakePatchFiles.TabIndex = 1;
            this.cmdMakePatchFiles.Text = "Create New Patches from Source";
            this.cmdMakePatchFiles.UseVisualStyleBackColor = true;
            this.cmdMakePatchFiles.Click += new System.EventHandler(this.cmdCreatePatchFiles_Click);
            // 
            // cmdLoadPatchAndDoPatch
            // 
            this.cmdLoadPatchAndDoPatch.Location = new System.Drawing.Point(52, 174);
            this.cmdLoadPatchAndDoPatch.Name = "cmdLoadPatchAndDoPatch";
            this.cmdLoadPatchAndDoPatch.Size = new System.Drawing.Size(282, 40);
            this.cmdLoadPatchAndDoPatch.TabIndex = 2;
            this.cmdLoadPatchAndDoPatch.Text = "LoadPatch and Apply Patch";
            this.cmdLoadPatchAndDoPatch.UseVisualStyleBackColor = true;
            this.cmdLoadPatchAndDoPatch.Click += new System.EventHandler(this.cmdLoadPatchAndApplyPatch_Click);
            // 
            // cmdMacApplyPatches
            // 
            this.cmdMacApplyPatches.Location = new System.Drawing.Point(352, 532);
            this.cmdMacApplyPatches.Name = "cmdMacApplyPatches";
            this.cmdMacApplyPatches.Size = new System.Drawing.Size(282, 40);
            this.cmdMacApplyPatches.TabIndex = 4;
            this.cmdMacApplyPatches.Text = "[TEST mac] LoadPatch and Apply Patch";
            this.cmdMacApplyPatches.UseVisualStyleBackColor = true;
            this.cmdMacApplyPatches.Click += new System.EventHandler(this.cmdMacApplyPatches_Click);
            // 
            // cmdMacBuildPatchesFromSrc
            // 
            this.cmdMacBuildPatchesFromSrc.Location = new System.Drawing.Point(352, 578);
            this.cmdMacBuildPatchesFromSrc.Name = "cmdMacBuildPatchesFromSrc";
            this.cmdMacBuildPatchesFromSrc.Size = new System.Drawing.Size(282, 40);
            this.cmdMacBuildPatchesFromSrc.TabIndex = 3;
            this.cmdMacBuildPatchesFromSrc.Text = "[TEST mac] Create New Patches from Source";
            this.cmdMacBuildPatchesFromSrc.UseVisualStyleBackColor = true;
            this.cmdMacBuildPatchesFromSrc.Click += new System.EventHandler(this.cmdMacBuildPatchesFromSrc_Click);
            // 
            // cmdCefBridgeCodeGen
            // 
            this.cmdCefBridgeCodeGen.Location = new System.Drawing.Point(52, 349);
            this.cmdCefBridgeCodeGen.Name = "cmdCefBridgeCodeGen";
            this.cmdCefBridgeCodeGen.Size = new System.Drawing.Size(282, 40);
            this.cmdCefBridgeCodeGen.TabIndex = 6;
            this.cmdCefBridgeCodeGen.Text = "TestWrapperApiBuilder";
            this.cmdCefBridgeCodeGen.UseVisualStyleBackColor = true;
            this.cmdCefBridgeCodeGen.Click += new System.EventHandler(this.cmdCefBridgeCodeGen_Click);
            // 
            // cmdCopyDevSnap
            // 
            this.cmdCopyDevSnap.Location = new System.Drawing.Point(52, 276);
            this.cmdCopyDevSnap.Name = "cmdCopyDevSnap";
            this.cmdCopyDevSnap.Size = new System.Drawing.Size(282, 40);
            this.cmdCopyDevSnap.TabIndex = 7;
            this.cmdCopyDevSnap.Text = "Copy dev snapshot";
            this.cmdCopyDevSnap.UseVisualStyleBackColor = true;
            this.cmdCopyDevSnap.Click += new System.EventHandler(this.cmdCopyDevSnap_Click);
            // 
            // cmbCefSrcFolder
            // 
            this.cmbCefSrcFolder.FormattingEnabled = true;
            this.cmbCefSrcFolder.Location = new System.Drawing.Point(138, 24);
            this.cmbCefSrcFolder.Name = "cmbCefSrcFolder";
            this.cmbCefSrcFolder.Size = new System.Drawing.Size(260, 21);
            this.cmbCefSrcFolder.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cef Original Source";
            // 
            // cmdShowCefSourceFolder
            // 
            this.cmdShowCefSourceFolder.Location = new System.Drawing.Point(404, 24);
            this.cmdShowCefSourceFolder.Name = "cmdShowCefSourceFolder";
            this.cmdShowCefSourceFolder.Size = new System.Drawing.Size(126, 35);
            this.cmdShowCefSourceFolder.TabIndex = 10;
            this.cmdShowCefSourceFolder.Text = "Show in Folder";
            this.cmdShowCefSourceFolder.UseVisualStyleBackColor = true;
            this.cmdShowCefSourceFolder.Click += new System.EventHandler(this.cmdShowCefSourceFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 682);
            this.Controls.Add(this.cmdShowCefSourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCefSrcFolder);
            this.Controls.Add(this.cmdCopyDevSnap);
            this.Controls.Add(this.cmdCefBridgeCodeGen);
            this.Controls.Add(this.cmdMacApplyPatches);
            this.Controls.Add(this.cmdMacBuildPatchesFromSrc);
            this.Controls.Add(this.cmdLoadPatchAndDoPatch);
            this.Controls.Add(this.cmdMakePatchFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdMakePatchFiles;
        private System.Windows.Forms.Button cmdLoadPatchAndDoPatch;
        private System.Windows.Forms.Button cmdMacApplyPatches;
        private System.Windows.Forms.Button cmdMacBuildPatchesFromSrc;
        private System.Windows.Forms.Button cmdCefBridgeCodeGen;
        private System.Windows.Forms.Button cmdCopyDevSnap;
        private System.Windows.Forms.ComboBox cmbCefSrcFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdShowCefSourceFolder;
    }
}

