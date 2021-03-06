﻿namespace FileExplorer
{
    partial class frmSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.ckResumeDownloadAndUploadOnStartup = new System.Windows.Forms.CheckBox();
            this.tabDownloadOptions = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.numMinDownloadSliceSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ckRetryWhenDownloadFail = new System.Windows.Forms.CheckBox();
            this.ckAutomaticDownloadMaxThreadCount = new System.Windows.Forms.CheckBox();
            this.numDownloadMaxThreadCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUploadOptions = new System.Windows.Forms.TabPage();
            this.ckOverwriteIfExists = new System.Windows.Forms.CheckBox();
            this.ckRetryWhenUploadFail = new System.Windows.Forms.CheckBox();
            this.ckAutomaticUploadMaxThreadCount = new System.Windows.Forms.CheckBox();
            this.numUploadMaxThreadCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numDiskCache = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabDownloadOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDownloadSliceSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownloadMaxThreadCount)).BeginInit();
            this.tabUploadOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUploadMaxThreadCount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiskCache)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabDownloadOptions);
            this.tabControl1.Controls.Add(this.tabUploadOptions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.ckResumeDownloadAndUploadOnStartup);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(359, 267);
            this.tabGeneral.TabIndex = 2;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // ckResumeDownloadAndUploadOnStartup
            // 
            this.ckResumeDownloadAndUploadOnStartup.AutoSize = true;
            this.ckResumeDownloadAndUploadOnStartup.Location = new System.Drawing.Point(20, 16);
            this.ckResumeDownloadAndUploadOnStartup.Name = "ckResumeDownloadAndUploadOnStartup";
            this.ckResumeDownloadAndUploadOnStartup.Size = new System.Drawing.Size(223, 17);
            this.ckResumeDownloadAndUploadOnStartup.TabIndex = 3;
            this.ckResumeDownloadAndUploadOnStartup.Text = "Resume download and upload on startup.";
            this.ckResumeDownloadAndUploadOnStartup.UseVisualStyleBackColor = true;
            // 
            // tabDownloadOptions
            // 
            this.tabDownloadOptions.Controls.Add(this.label5);
            this.tabDownloadOptions.Controls.Add(this.numDiskCache);
            this.tabDownloadOptions.Controls.Add(this.label6);
            this.tabDownloadOptions.Controls.Add(this.label4);
            this.tabDownloadOptions.Controls.Add(this.numMinDownloadSliceSize);
            this.tabDownloadOptions.Controls.Add(this.label3);
            this.tabDownloadOptions.Controls.Add(this.ckRetryWhenDownloadFail);
            this.tabDownloadOptions.Controls.Add(this.ckAutomaticDownloadMaxThreadCount);
            this.tabDownloadOptions.Controls.Add(this.numDownloadMaxThreadCount);
            this.tabDownloadOptions.Controls.Add(this.label1);
            this.tabDownloadOptions.Location = new System.Drawing.Point(4, 22);
            this.tabDownloadOptions.Name = "tabDownloadOptions";
            this.tabDownloadOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownloadOptions.Size = new System.Drawing.Size(359, 267);
            this.tabDownloadOptions.TabIndex = 0;
            this.tabDownloadOptions.Text = "Download Options";
            this.tabDownloadOptions.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "KB";
            // 
            // numMinDownloadSliceSize
            // 
            this.numMinDownloadSliceSize.Location = new System.Drawing.Point(139, 109);
            this.numMinDownloadSliceSize.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.numMinDownloadSliceSize.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numMinDownloadSliceSize.Name = "numMinDownloadSliceSize";
            this.numMinDownloadSliceSize.Size = new System.Drawing.Size(120, 20);
            this.numMinDownloadSliceSize.TabIndex = 4;
            this.numMinDownloadSliceSize.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min slice size: ";
            // 
            // ckRetryWhenDownloadFail
            // 
            this.ckRetryWhenDownloadFail.AutoSize = true;
            this.ckRetryWhenDownloadFail.Location = new System.Drawing.Point(49, 73);
            this.ckRetryWhenDownloadFail.Name = "ckRetryWhenDownloadFail";
            this.ckRetryWhenDownloadFail.Size = new System.Drawing.Size(157, 17);
            this.ckRetryWhenDownloadFail.TabIndex = 3;
            this.ckRetryWhenDownloadFail.Text = "Retry when download failed";
            this.ckRetryWhenDownloadFail.UseVisualStyleBackColor = true;
            // 
            // ckAutomaticDownloadMaxThreadCount
            // 
            this.ckAutomaticDownloadMaxThreadCount.AutoSize = true;
            this.ckAutomaticDownloadMaxThreadCount.Location = new System.Drawing.Point(49, 50);
            this.ckAutomaticDownloadMaxThreadCount.Name = "ckAutomaticDownloadMaxThreadCount";
            this.ckAutomaticDownloadMaxThreadCount.Size = new System.Drawing.Size(115, 17);
            this.ckAutomaticDownloadMaxThreadCount.TabIndex = 2;
            this.ckAutomaticDownloadMaxThreadCount.Text = "Automatic decision";
            this.ckAutomaticDownloadMaxThreadCount.UseVisualStyleBackColor = true;
            // 
            // numDownloadMaxThreadCount
            // 
            this.numDownloadMaxThreadCount.Location = new System.Drawing.Point(139, 14);
            this.numDownloadMaxThreadCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDownloadMaxThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDownloadMaxThreadCount.Name = "numDownloadMaxThreadCount";
            this.numDownloadMaxThreadCount.Size = new System.Drawing.Size(120, 20);
            this.numDownloadMaxThreadCount.TabIndex = 1;
            this.numDownloadMaxThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max thread count: ";
            // 
            // tabUploadOptions
            // 
            this.tabUploadOptions.Controls.Add(this.ckOverwriteIfExists);
            this.tabUploadOptions.Controls.Add(this.ckRetryWhenUploadFail);
            this.tabUploadOptions.Controls.Add(this.ckAutomaticUploadMaxThreadCount);
            this.tabUploadOptions.Controls.Add(this.numUploadMaxThreadCount);
            this.tabUploadOptions.Controls.Add(this.label2);
            this.tabUploadOptions.Location = new System.Drawing.Point(4, 22);
            this.tabUploadOptions.Name = "tabUploadOptions";
            this.tabUploadOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabUploadOptions.Size = new System.Drawing.Size(359, 267);
            this.tabUploadOptions.TabIndex = 1;
            this.tabUploadOptions.Text = "Upload Options";
            this.tabUploadOptions.UseVisualStyleBackColor = true;
            // 
            // ckOverwriteIfExists
            // 
            this.ckOverwriteIfExists.AutoSize = true;
            this.ckOverwriteIfExists.Location = new System.Drawing.Point(49, 96);
            this.ckOverwriteIfExists.Name = "ckOverwriteIfExists";
            this.ckOverwriteIfExists.Size = new System.Drawing.Size(108, 17);
            this.ckOverwriteIfExists.TabIndex = 5;
            this.ckOverwriteIfExists.Text = "Overwrite if exists";
            this.ckOverwriteIfExists.UseVisualStyleBackColor = true;
            // 
            // ckRetryWhenUploadFail
            // 
            this.ckRetryWhenUploadFail.AutoSize = true;
            this.ckRetryWhenUploadFail.Location = new System.Drawing.Point(49, 73);
            this.ckRetryWhenUploadFail.Name = "ckRetryWhenUploadFail";
            this.ckRetryWhenUploadFail.Size = new System.Drawing.Size(143, 17);
            this.ckRetryWhenUploadFail.TabIndex = 4;
            this.ckRetryWhenUploadFail.Text = "Retry when upload failed";
            this.ckRetryWhenUploadFail.UseVisualStyleBackColor = true;
            // 
            // ckAutomaticUploadMaxThreadCount
            // 
            this.ckAutomaticUploadMaxThreadCount.AutoSize = true;
            this.ckAutomaticUploadMaxThreadCount.Location = new System.Drawing.Point(49, 50);
            this.ckAutomaticUploadMaxThreadCount.Name = "ckAutomaticUploadMaxThreadCount";
            this.ckAutomaticUploadMaxThreadCount.Size = new System.Drawing.Size(115, 17);
            this.ckAutomaticUploadMaxThreadCount.TabIndex = 3;
            this.ckAutomaticUploadMaxThreadCount.Text = "Automatic decision";
            this.ckAutomaticUploadMaxThreadCount.UseVisualStyleBackColor = true;
            // 
            // numUploadMaxThreadCount
            // 
            this.numUploadMaxThreadCount.Location = new System.Drawing.Point(139, 14);
            this.numUploadMaxThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUploadMaxThreadCount.Name = "numUploadMaxThreadCount";
            this.numUploadMaxThreadCount.Size = new System.Drawing.Size(120, 20);
            this.numUploadMaxThreadCount.TabIndex = 2;
            this.numUploadMaxThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max thread count: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 41);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(195, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 99;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "KB";
            // 
            // numDiskCache
            // 
            this.numDiskCache.Location = new System.Drawing.Point(139, 135);
            this.numDiskCache.Maximum = new decimal(new int[] {
            1073741824,
            0,
            0,
            0});
            this.numDiskCache.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numDiskCache.Name = "numDiskCache";
            this.numDiskCache.Size = new System.Drawing.Size(120, 20);
            this.numDiskCache.TabIndex = 6;
            this.numDiskCache.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Disk cache: ";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 334);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabDownloadOptions.ResumeLayout(false);
            this.tabDownloadOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDownloadSliceSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownloadMaxThreadCount)).EndInit();
            this.tabUploadOptions.ResumeLayout(false);
            this.tabUploadOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUploadMaxThreadCount)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDiskCache)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDownloadOptions;
        private System.Windows.Forms.TabPage tabUploadOptions;
        private System.Windows.Forms.NumericUpDown numDownloadMaxThreadCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numUploadMaxThreadCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckAutomaticDownloadMaxThreadCount;
        private System.Windows.Forms.CheckBox ckAutomaticUploadMaxThreadCount;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.CheckBox ckResumeDownloadAndUploadOnStartup;
        private System.Windows.Forms.CheckBox ckRetryWhenDownloadFail;
        private System.Windows.Forms.CheckBox ckRetryWhenUploadFail;
        private System.Windows.Forms.NumericUpDown numMinDownloadSliceSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckOverwriteIfExists;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDiskCache;
        private System.Windows.Forms.Label label6;
    }
}