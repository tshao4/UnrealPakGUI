namespace UnrealPakGUI
{
    partial class FormLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogs));
            this.TB_Logs = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.BTN_ClearLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Logs
            // 
            this.TB_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Logs.Location = new System.Drawing.Point(12, 12);
            this.TB_Logs.Multiline = true;
            this.TB_Logs.Name = "TB_Logs";
            this.TB_Logs.ReadOnly = true;
            this.TB_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Logs.Size = new System.Drawing.Size(733, 473);
            this.TB_Logs.TabIndex = 9;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BTN_ClearLogs
            // 
            this.BTN_ClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ClearLogs.Location = new System.Drawing.Point(670, 491);
            this.BTN_ClearLogs.Name = "BTN_ClearLogs";
            this.BTN_ClearLogs.Size = new System.Drawing.Size(75, 23);
            this.BTN_ClearLogs.TabIndex = 10;
            this.BTN_ClearLogs.Text = "Clear Logs";
            this.BTN_ClearLogs.UseVisualStyleBackColor = true;
            this.BTN_ClearLogs.Click += new System.EventHandler(this.BTN_ClearLogs_Click);
            // 
            // FormLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 526);
            this.Controls.Add(this.BTN_ClearLogs);
            this.Controls.Add(this.TB_Logs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogs";
            this.ShowInTaskbar = false;
            this.Text = "Logs";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogs_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Logs;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button BTN_ClearLogs;
    }
}