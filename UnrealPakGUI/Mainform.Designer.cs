namespace UnrealPakGUI
{
    partial class MainForm
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
            this.BTN_BrowseEngineDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BrowseCryptoFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OFD_BrowseCryptoFile = new System.Windows.Forms.OpenFileDialog();
            this.FBD_BrowseEngineDir = new System.Windows.Forms.FolderBrowserDialog();
            this.OFD_BrowseOutputFile = new System.Windows.Forms.OpenFileDialog();
            this.LB_FilesToPak = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_BrowseProjectFile = new System.Windows.Forms.Button();
            this.OFD_BrowseProjectFile = new System.Windows.Forms.OpenFileDialog();
            this.BTN_RemoveItems = new System.Windows.Forms.Button();
            this.BTN_AddFiles = new System.Windows.Forms.Button();
            this.BTN_AddDir = new System.Windows.Forms.Button();
            this.BTN_CreatePak = new System.Windows.Forms.Button();
            this.OFD_AddFiles = new System.Windows.Forms.OpenFileDialog();
            this.FBD_AddDir = new System.Windows.Forms.FolderBrowserDialog();
            this.CKB_Encryption = new System.Windows.Forms.CheckBox();
            this.TB_ProjectFile = new System.Windows.Forms.TextBox();
            this.TB_CryptoFile = new System.Windows.Forms.TextBox();
            this.TB_EngineDir = new System.Windows.Forms.TextBox();
            this.BTN_RemoveAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_BrowseEngineDir
            // 
            this.BTN_BrowseEngineDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseEngineDir.Location = new System.Drawing.Point(864, 11);
            this.BTN_BrowseEngineDir.Name = "BTN_BrowseEngineDir";
            this.BTN_BrowseEngineDir.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseEngineDir.TabIndex = 2;
            this.BTN_BrowseEngineDir.Text = "...";
            this.BTN_BrowseEngineDir.UseVisualStyleBackColor = true;
            this.BTN_BrowseEngineDir.Click += new System.EventHandler(this.BTN_BrowseEngineDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Engine Dir";
            // 
            // BTN_BrowseCryptoFile
            // 
            this.BTN_BrowseCryptoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseCryptoFile.Location = new System.Drawing.Point(864, 38);
            this.BTN_BrowseCryptoFile.Name = "BTN_BrowseCryptoFile";
            this.BTN_BrowseCryptoFile.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseCryptoFile.TabIndex = 2;
            this.BTN_BrowseCryptoFile.Text = "...";
            this.BTN_BrowseCryptoFile.UseVisualStyleBackColor = true;
            this.BTN_BrowseCryptoFile.Click += new System.EventHandler(this.BTN_BrowseCryptoFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crypto File";
            // 
            // OFD_BrowseCryptoFile
            // 
            this.OFD_BrowseCryptoFile.DefaultExt = "json";
            this.OFD_BrowseCryptoFile.Filter = "Crypto Files|*.json";
            // 
            // OFD_BrowseOutputFile
            // 
            this.OFD_BrowseOutputFile.CheckFileExists = false;
            this.OFD_BrowseOutputFile.DefaultExt = "pak";
            this.OFD_BrowseOutputFile.Filter = "Unreal Pak Files|*.pak";
            // 
            // LB_FilesToPak
            // 
            this.LB_FilesToPak.AllowDrop = true;
            this.LB_FilesToPak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_FilesToPak.FormattingEnabled = true;
            this.LB_FilesToPak.ItemHeight = 12;
            this.LB_FilesToPak.Location = new System.Drawing.Point(6, 6);
            this.LB_FilesToPak.Name = "LB_FilesToPak";
            this.LB_FilesToPak.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_FilesToPak.Size = new System.Drawing.Size(759, 484);
            this.LB_FilesToPak.TabIndex = 4;
            this.LB_FilesToPak.DragDrop += new System.Windows.Forms.DragEventHandler(this.LB_FilesToPak_DragDrop);
            this.LB_FilesToPak.DragEnter += new System.Windows.Forms.DragEventHandler(this.LB_FilesToPak_DragEnter);
            this.LB_FilesToPak.DragOver += new System.Windows.Forms.DragEventHandler(this.LB_FilesToPak_DragOver);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Project File";
            // 
            // BTN_BrowseProjectFile
            // 
            this.BTN_BrowseProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseProjectFile.Location = new System.Drawing.Point(864, 65);
            this.BTN_BrowseProjectFile.Name = "BTN_BrowseProjectFile";
            this.BTN_BrowseProjectFile.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseProjectFile.TabIndex = 2;
            this.BTN_BrowseProjectFile.Text = "...";
            this.BTN_BrowseProjectFile.UseVisualStyleBackColor = true;
            this.BTN_BrowseProjectFile.Click += new System.EventHandler(this.BTN_BrowseProjectFile_Click);
            // 
            // OFD_BrowseProjectFile
            // 
            this.OFD_BrowseProjectFile.DefaultExt = "uproject";
            this.OFD_BrowseProjectFile.Filter = "Unreal Project File|*.uproject";
            // 
            // BTN_RemoveItems
            // 
            this.BTN_RemoveItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemoveItems.Location = new System.Drawing.Point(776, 92);
            this.BTN_RemoveItems.Name = "BTN_RemoveItems";
            this.BTN_RemoveItems.Size = new System.Drawing.Size(90, 30);
            this.BTN_RemoveItems.TabIndex = 6;
            this.BTN_RemoveItems.Text = "Remove";
            this.BTN_RemoveItems.UseVisualStyleBackColor = true;
            this.BTN_RemoveItems.Click += new System.EventHandler(this.BTN_RemoveItems_Click);
            // 
            // BTN_AddFiles
            // 
            this.BTN_AddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AddFiles.Location = new System.Drawing.Point(775, 12);
            this.BTN_AddFiles.Name = "BTN_AddFiles";
            this.BTN_AddFiles.Size = new System.Drawing.Size(90, 30);
            this.BTN_AddFiles.TabIndex = 7;
            this.BTN_AddFiles.Text = "Add Files";
            this.BTN_AddFiles.UseVisualStyleBackColor = true;
            this.BTN_AddFiles.Click += new System.EventHandler(this.BTN_AddFiles_Click);
            // 
            // BTN_AddDir
            // 
            this.BTN_AddDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AddDir.Location = new System.Drawing.Point(776, 52);
            this.BTN_AddDir.Name = "BTN_AddDir";
            this.BTN_AddDir.Size = new System.Drawing.Size(90, 30);
            this.BTN_AddDir.TabIndex = 7;
            this.BTN_AddDir.Text = "Add Dir";
            this.BTN_AddDir.UseVisualStyleBackColor = true;
            this.BTN_AddDir.Click += new System.EventHandler(this.BTN_AddDir_Click);
            // 
            // BTN_CreatePak
            // 
            this.BTN_CreatePak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CreatePak.Location = new System.Drawing.Point(775, 172);
            this.BTN_CreatePak.Name = "BTN_CreatePak";
            this.BTN_CreatePak.Size = new System.Drawing.Size(90, 30);
            this.BTN_CreatePak.TabIndex = 6;
            this.BTN_CreatePak.Text = "Create Pak";
            this.BTN_CreatePak.UseVisualStyleBackColor = true;
            this.BTN_CreatePak.Click += new System.EventHandler(this.BTN_CreatePak_Click);
            // 
            // OFD_AddFiles
            // 
            this.OFD_AddFiles.Multiselect = true;
            // 
            // CKB_Encryption
            // 
            this.CKB_Encryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_Encryption.AutoSize = true;
            this.CKB_Encryption.Checked = true;
            this.CKB_Encryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_Encryption.Location = new System.Drawing.Point(806, 100);
            this.CKB_Encryption.Name = "CKB_Encryption";
            this.CKB_Encryption.Size = new System.Drawing.Size(84, 16);
            this.CKB_Encryption.TabIndex = 5;
            this.CKB_Encryption.Text = "Encryption";
            this.CKB_Encryption.UseVisualStyleBackColor = true;
            // 
            // TB_ProjectFile
            // 
            this.TB_ProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ProjectFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "ProjectFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_ProjectFile.Location = new System.Drawing.Point(107, 66);
            this.TB_ProjectFile.Name = "TB_ProjectFile";
            this.TB_ProjectFile.ReadOnly = true;
            this.TB_ProjectFile.Size = new System.Drawing.Size(751, 21);
            this.TB_ProjectFile.TabIndex = 0;
            this.TB_ProjectFile.Text = global::UnrealPakGUI.Properties.Settings.Default.ProjectFile;
            // 
            // TB_CryptoFile
            // 
            this.TB_CryptoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_CryptoFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "CryptoFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_CryptoFile.Location = new System.Drawing.Point(107, 39);
            this.TB_CryptoFile.Name = "TB_CryptoFile";
            this.TB_CryptoFile.ReadOnly = true;
            this.TB_CryptoFile.Size = new System.Drawing.Size(751, 21);
            this.TB_CryptoFile.TabIndex = 0;
            this.TB_CryptoFile.Text = global::UnrealPakGUI.Properties.Settings.Default.CryptoFile;
            // 
            // TB_EngineDir
            // 
            this.TB_EngineDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_EngineDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "EngineDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_EngineDir.Location = new System.Drawing.Point(107, 12);
            this.TB_EngineDir.Name = "TB_EngineDir";
            this.TB_EngineDir.ReadOnly = true;
            this.TB_EngineDir.Size = new System.Drawing.Size(751, 21);
            this.TB_EngineDir.TabIndex = 0;
            this.TB_EngineDir.Text = global::UnrealPakGUI.Properties.Settings.Default.EngineDir;
            // 
            // BTN_RemoveAll
            // 
            this.BTN_RemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemoveAll.Location = new System.Drawing.Point(776, 132);
            this.BTN_RemoveAll.Name = "BTN_RemoveAll";
            this.BTN_RemoveAll.Size = new System.Drawing.Size(90, 30);
            this.BTN_RemoveAll.TabIndex = 6;
            this.BTN_RemoveAll.Text = "Remove All";
            this.BTN_RemoveAll.UseVisualStyleBackColor = true;
            this.BTN_RemoveAll.Click += new System.EventHandler(this.BTN_RemoveAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 526);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_FilesToPak);
            this.tabPage1.Controls.Add(this.BTN_AddDir);
            this.tabPage1.Controls.Add(this.BTN_AddFiles);
            this.tabPage1.Controls.Add(this.BTN_RemoveItems);
            this.tabPage1.Controls.Add(this.BTN_CreatePak);
            this.tabPage1.Controls.Add(this.BTN_RemoveAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Pak";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Batch Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 642);
            this.Controls.Add(this.CKB_Encryption);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_BrowseProjectFile);
            this.Controls.Add(this.BTN_BrowseCryptoFile);
            this.Controls.Add(this.BTN_BrowseEngineDir);
            this.Controls.Add(this.TB_ProjectFile);
            this.Controls.Add(this.TB_CryptoFile);
            this.Controls.Add(this.TB_EngineDir);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "UnrealPakGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_EngineDir;
        private System.Windows.Forms.Button BTN_BrowseEngineDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_CryptoFile;
        private System.Windows.Forms.Button BTN_BrowseCryptoFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OFD_BrowseCryptoFile;
        private System.Windows.Forms.FolderBrowserDialog FBD_BrowseEngineDir;
        private System.Windows.Forms.OpenFileDialog OFD_BrowseOutputFile;
        private System.Windows.Forms.ListBox LB_FilesToPak;
        private System.Windows.Forms.TextBox TB_ProjectFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_BrowseProjectFile;
        private System.Windows.Forms.OpenFileDialog OFD_BrowseProjectFile;
        private System.Windows.Forms.CheckBox CKB_Encryption;
        private System.Windows.Forms.Button BTN_RemoveItems;
        private System.Windows.Forms.Button BTN_AddFiles;
        private System.Windows.Forms.Button BTN_AddDir;
        private System.Windows.Forms.Button BTN_CreatePak;
        private System.Windows.Forms.OpenFileDialog OFD_AddFiles;
        private System.Windows.Forms.FolderBrowserDialog FBD_AddDir;
        private System.Windows.Forms.Button BTN_RemoveAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

