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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BTN_BrowseEngineDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BrowseCryptoFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OFD_BrowseCryptoFile = new System.Windows.Forms.OpenFileDialog();
            this.FBD_BrowseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.OFD_BrowseOutputFile = new System.Windows.Forms.OpenFileDialog();
            this.LB_FilesToPak = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_BrowseProjectFile = new System.Windows.Forms.Button();
            this.OFD_BrowseProjectFile = new System.Windows.Forms.OpenFileDialog();
            this.BTN_RemoveItems = new System.Windows.Forms.Button();
            this.BTN_CreatePak = new System.Windows.Forms.Button();
            this.OFD_AddFiles = new System.Windows.Forms.OpenFileDialog();
            this.BTN_RemoveAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TV_BatchFiles = new System.Windows.Forms.TreeView();
            this.BTN_BatchRemove = new System.Windows.Forms.Button();
            this.BTN_BatchCreatePaks = new System.Windows.Forms.Button();
            this.BTN_BatchRemoveAll = new System.Windows.Forms.Button();
            this.BTN_BrowseBatchOutputDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BTN_BrowseExtractToDir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TV_ListPak = new System.Windows.Forms.TreeView();
            this.TT_ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CKB_ContentOnly = new System.Windows.Forms.CheckBox();
            this.CKB_Compression = new System.Windows.Forms.CheckBox();
            this.CKB_Encryption = new System.Windows.Forms.CheckBox();
            this.CKB_FolderPak = new System.Windows.Forms.CheckBox();
            this.CKB_AsPatch = new System.Windows.Forms.CheckBox();
            this.TB_BatchOutputDir = new System.Windows.Forms.TextBox();
            this.TB_ExtractToDir = new System.Windows.Forms.TextBox();
            this.TB_ProjectFile = new System.Windows.Forms.TextBox();
            this.TB_CryptoFile = new System.Windows.Forms.TextBox();
            this.TB_EngineDir = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_BrowseEngineDir
            // 
            this.BTN_BrowseEngineDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseEngineDir.Location = new System.Drawing.Point(734, 10);
            this.BTN_BrowseEngineDir.Name = "BTN_BrowseEngineDir";
            this.BTN_BrowseEngineDir.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseEngineDir.TabIndex = 1;
            this.BTN_BrowseEngineDir.Text = "...";
            this.TT_ToolTip.SetToolTip(this.BTN_BrowseEngineDir, "Browse Engine Directory");
            this.BTN_BrowseEngineDir.UseVisualStyleBackColor = true;
            this.BTN_BrowseEngineDir.Click += new System.EventHandler(this.BTN_BrowseEngineDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Engine Dir";
            // 
            // BTN_BrowseCryptoFile
            // 
            this.BTN_BrowseCryptoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseCryptoFile.Location = new System.Drawing.Point(734, 38);
            this.BTN_BrowseCryptoFile.Name = "BTN_BrowseCryptoFile";
            this.BTN_BrowseCryptoFile.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseCryptoFile.TabIndex = 3;
            this.BTN_BrowseCryptoFile.Text = "...";
            this.TT_ToolTip.SetToolTip(this.BTN_BrowseCryptoFile, "Browse Crypto file");
            this.BTN_BrowseCryptoFile.UseVisualStyleBackColor = true;
            this.BTN_BrowseCryptoFile.Click += new System.EventHandler(this.BTN_BrowseCryptoFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
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
            this.LB_FilesToPak.Size = new System.Drawing.Size(629, 436);
            this.LB_FilesToPak.TabIndex = 0;
            this.TT_ToolTip.SetToolTip(this.LB_FilesToPak, "Pack files into a single pak file. Drag files here.");
            this.LB_FilesToPak.DragDrop += new System.Windows.Forms.DragEventHandler(this.LB_FilesToPak_DragDrop);
            this.LB_FilesToPak.DragEnter += new System.Windows.Forms.DragEventHandler(this.LB_FilesToPak_DragEnter);
            this.LB_FilesToPak.DragOver += new System.Windows.Forms.DragEventHandler(this.LB_FilesToPak_DragOver);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "UProject File";
            // 
            // BTN_BrowseProjectFile
            // 
            this.BTN_BrowseProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseProjectFile.Location = new System.Drawing.Point(734, 66);
            this.BTN_BrowseProjectFile.Name = "BTN_BrowseProjectFile";
            this.BTN_BrowseProjectFile.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseProjectFile.TabIndex = 5;
            this.BTN_BrowseProjectFile.Text = "...";
            this.TT_ToolTip.SetToolTip(this.BTN_BrowseProjectFile, "Browse UProject file");
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
            this.BTN_RemoveItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemoveItems.Location = new System.Drawing.Point(644, 332);
            this.BTN_RemoveItems.Name = "BTN_RemoveItems";
            this.BTN_RemoveItems.Size = new System.Drawing.Size(90, 30);
            this.BTN_RemoveItems.TabIndex = 1;
            this.BTN_RemoveItems.Text = "Remove";
            this.TT_ToolTip.SetToolTip(this.BTN_RemoveItems, "Remove selected files.");
            this.BTN_RemoveItems.UseVisualStyleBackColor = true;
            this.BTN_RemoveItems.Click += new System.EventHandler(this.BTN_RemoveItems_Click);
            // 
            // BTN_CreatePak
            // 
            this.BTN_CreatePak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CreatePak.Location = new System.Drawing.Point(644, 412);
            this.BTN_CreatePak.Name = "BTN_CreatePak";
            this.BTN_CreatePak.Size = new System.Drawing.Size(90, 30);
            this.BTN_CreatePak.TabIndex = 3;
            this.BTN_CreatePak.Text = "Create Pak";
            this.TT_ToolTip.SetToolTip(this.BTN_CreatePak, "Start packing!");
            this.BTN_CreatePak.UseVisualStyleBackColor = true;
            this.BTN_CreatePak.Click += new System.EventHandler(this.BTN_CreatePak_Click);
            // 
            // OFD_AddFiles
            // 
            this.OFD_AddFiles.Multiselect = true;
            // 
            // BTN_RemoveAll
            // 
            this.BTN_RemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_RemoveAll.Location = new System.Drawing.Point(644, 372);
            this.BTN_RemoveAll.Name = "BTN_RemoveAll";
            this.BTN_RemoveAll.Size = new System.Drawing.Size(90, 30);
            this.BTN_RemoveAll.TabIndex = 2;
            this.BTN_RemoveAll.Text = "Remove All";
            this.TT_ToolTip.SetToolTip(this.BTN_RemoveAll, "Remove all files.");
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 476);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_FilesToPak);
            this.tabPage1.Controls.Add(this.BTN_RemoveItems);
            this.tabPage1.Controls.Add(this.BTN_CreatePak);
            this.tabPage1.Controls.Add(this.BTN_RemoveAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Pak";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TV_BatchFiles);
            this.tabPage2.Controls.Add(this.BTN_BatchRemove);
            this.tabPage2.Controls.Add(this.BTN_BatchCreatePaks);
            this.tabPage2.Controls.Add(this.BTN_BatchRemoveAll);
            this.tabPage2.Controls.Add(this.BTN_BrowseBatchOutputDir);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CKB_FolderPak);
            this.tabPage2.Controls.Add(this.CKB_AsPatch);
            this.tabPage2.Controls.Add(this.TB_BatchOutputDir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Batch Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TV_BatchFiles
            // 
            this.TV_BatchFiles.AllowDrop = true;
            this.TV_BatchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TV_BatchFiles.Location = new System.Drawing.Point(6, 33);
            this.TV_BatchFiles.Name = "TV_BatchFiles";
            this.TV_BatchFiles.Size = new System.Drawing.Size(629, 411);
            this.TV_BatchFiles.TabIndex = 14;
            this.TT_ToolTip.SetToolTip(this.TV_BatchFiles, "Pack each batch into individual pak files. Drag files here.");
            this.TV_BatchFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.TV_BatchFiles_DragDrop);
            this.TV_BatchFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.TV_BatchFiles_DragEnter);
            this.TV_BatchFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.TV_BatchFiles_DragOver);
            // 
            // BTN_BatchRemove
            // 
            this.BTN_BatchRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BatchRemove.Location = new System.Drawing.Point(644, 334);
            this.BTN_BatchRemove.Name = "BTN_BatchRemove";
            this.BTN_BatchRemove.Size = new System.Drawing.Size(90, 30);
            this.BTN_BatchRemove.TabIndex = 15;
            this.BTN_BatchRemove.Text = "Remove";
            this.TT_ToolTip.SetToolTip(this.BTN_BatchRemove, "Remove selected files.");
            this.BTN_BatchRemove.UseVisualStyleBackColor = true;
            this.BTN_BatchRemove.Click += new System.EventHandler(this.BTN_BatchRemove_Click);
            // 
            // BTN_BatchCreatePaks
            // 
            this.BTN_BatchCreatePaks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BatchCreatePaks.Location = new System.Drawing.Point(644, 414);
            this.BTN_BatchCreatePaks.Name = "BTN_BatchCreatePaks";
            this.BTN_BatchCreatePaks.Size = new System.Drawing.Size(90, 30);
            this.BTN_BatchCreatePaks.TabIndex = 17;
            this.BTN_BatchCreatePaks.Text = "Create Paks";
            this.TT_ToolTip.SetToolTip(this.BTN_BatchCreatePaks, "Start batch packing!");
            this.BTN_BatchCreatePaks.UseVisualStyleBackColor = true;
            this.BTN_BatchCreatePaks.Click += new System.EventHandler(this.BTN_BatchCreatePaks_Click);
            // 
            // BTN_BatchRemoveAll
            // 
            this.BTN_BatchRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BatchRemoveAll.Location = new System.Drawing.Point(644, 374);
            this.BTN_BatchRemoveAll.Name = "BTN_BatchRemoveAll";
            this.BTN_BatchRemoveAll.Size = new System.Drawing.Size(90, 30);
            this.BTN_BatchRemoveAll.TabIndex = 16;
            this.BTN_BatchRemoveAll.Text = "Remove All";
            this.TT_ToolTip.SetToolTip(this.BTN_BatchRemoveAll, "Remove all files.");
            this.BTN_BatchRemoveAll.UseVisualStyleBackColor = true;
            this.BTN_BatchRemoveAll.Click += new System.EventHandler(this.BTN_BatchRemoveAll_Click);
            // 
            // BTN_BrowseBatchOutputDir
            // 
            this.BTN_BrowseBatchOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseBatchOutputDir.Location = new System.Drawing.Point(708, 6);
            this.BTN_BrowseBatchOutputDir.Name = "BTN_BrowseBatchOutputDir";
            this.BTN_BrowseBatchOutputDir.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseBatchOutputDir.TabIndex = 13;
            this.BTN_BrowseBatchOutputDir.Text = "...";
            this.TT_ToolTip.SetToolTip(this.BTN_BrowseBatchOutputDir, "Browse output directory.");
            this.BTN_BrowseBatchOutputDir.UseVisualStyleBackColor = true;
            this.BTN_BrowseBatchOutputDir.Click += new System.EventHandler(this.BTN_BrowseBatchOutputDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output Dir";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BTN_BrowseExtractToDir);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.TB_ExtractToDir);
            this.tabPage3.Controls.Add(this.TV_ListPak);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(746, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List & Extract";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BTN_BrowseExtractToDir
            // 
            this.BTN_BrowseExtractToDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_BrowseExtractToDir.Location = new System.Drawing.Point(708, 6);
            this.BTN_BrowseExtractToDir.Name = "BTN_BrowseExtractToDir";
            this.BTN_BrowseExtractToDir.Size = new System.Drawing.Size(32, 23);
            this.BTN_BrowseExtractToDir.TabIndex = 16;
            this.BTN_BrowseExtractToDir.Text = "...";
            this.TT_ToolTip.SetToolTip(this.BTN_BrowseExtractToDir, "Browse extract directory.");
            this.BTN_BrowseExtractToDir.UseVisualStyleBackColor = true;
            this.BTN_BrowseExtractToDir.Click += new System.EventHandler(this.BTN_BrowseExtractToDir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Extract To";
            // 
            // TV_ListPak
            // 
            this.TV_ListPak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TV_ListPak.Location = new System.Drawing.Point(6, 33);
            this.TV_ListPak.Name = "TV_ListPak";
            this.TV_ListPak.Size = new System.Drawing.Size(629, 411);
            this.TV_ListPak.TabIndex = 0;
            this.TT_ToolTip.SetToolTip(this.TV_ListPak, "Drag a pak file here to list its content.");
            // 
            // TT_ToolTip
            // 
            this.TT_ToolTip.AutomaticDelay = 0;
            this.TT_ToolTip.AutoPopDelay = 30000;
            this.TT_ToolTip.InitialDelay = 100;
            this.TT_ToolTip.ReshowDelay = 0;
            this.TT_ToolTip.UseAnimation = false;
            this.TT_ToolTip.UseFading = false;
            // 
            // CKB_ContentOnly
            // 
            this.CKB_ContentOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_ContentOnly.AutoSize = true;
            this.CKB_ContentOnly.Checked = global::UnrealPakGUI.Properties.Settings.Default.bContentOnly;
            this.CKB_ContentOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_ContentOnly.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UnrealPakGUI.Properties.Settings.Default, "bContentOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CKB_ContentOnly.Location = new System.Drawing.Point(433, 96);
            this.CKB_ContentOnly.Name = "CKB_ContentOnly";
            this.CKB_ContentOnly.Size = new System.Drawing.Size(132, 16);
            this.CKB_ContentOnly.TabIndex = 6;
            this.CKB_ContentOnly.Text = "Content Files Only";
            this.TT_ToolTip.SetToolTip(this.CKB_ContentOnly, resources.GetString("CKB_ContentOnly.ToolTip"));
            this.CKB_ContentOnly.UseVisualStyleBackColor = true;
            this.CKB_ContentOnly.CheckedChanged += new System.EventHandler(this.CKB_ContentOnly_CheckedChanged);
            // 
            // CKB_Compression
            // 
            this.CKB_Compression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_Compression.AutoSize = true;
            this.CKB_Compression.Checked = global::UnrealPakGUI.Properties.Settings.Default.bUseCompression;
            this.CKB_Compression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_Compression.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UnrealPakGUI.Properties.Settings.Default, "bUseCompression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CKB_Compression.Location = new System.Drawing.Point(575, 96);
            this.CKB_Compression.Name = "CKB_Compression";
            this.CKB_Compression.Size = new System.Drawing.Size(90, 16);
            this.CKB_Compression.TabIndex = 7;
            this.CKB_Compression.Text = "Compression";
            this.CKB_Compression.UseVisualStyleBackColor = true;
            this.CKB_Compression.CheckedChanged += new System.EventHandler(this.CKB_Compression_CheckedChanged);
            // 
            // CKB_Encryption
            // 
            this.CKB_Encryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_Encryption.AutoSize = true;
            this.CKB_Encryption.Checked = global::UnrealPakGUI.Properties.Settings.Default.bUseEncryption;
            this.CKB_Encryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_Encryption.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UnrealPakGUI.Properties.Settings.Default, "bUseEncryption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CKB_Encryption.Location = new System.Drawing.Point(677, 96);
            this.CKB_Encryption.Name = "CKB_Encryption";
            this.CKB_Encryption.Size = new System.Drawing.Size(84, 16);
            this.CKB_Encryption.TabIndex = 7;
            this.CKB_Encryption.Text = "Encryption";
            this.TT_ToolTip.SetToolTip(this.CKB_Encryption, "Encrypt pak file. A valid Crypto file is nessessary.");
            this.CKB_Encryption.UseVisualStyleBackColor = true;
            this.CKB_Encryption.CheckedChanged += new System.EventHandler(this.CKB_Encryption_CheckedChanged);
            // 
            // CKB_FolderPak
            // 
            this.CKB_FolderPak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_FolderPak.AutoSize = true;
            this.CKB_FolderPak.Checked = global::UnrealPakGUI.Properties.Settings.Default.bFolderPak;
            this.CKB_FolderPak.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UnrealPakGUI.Properties.Settings.Default, "bFolderPak", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CKB_FolderPak.Location = new System.Drawing.Point(645, 70);
            this.CKB_FolderPak.Name = "CKB_FolderPak";
            this.CKB_FolderPak.Size = new System.Drawing.Size(84, 16);
            this.CKB_FolderPak.TabIndex = 19;
            this.CKB_FolderPak.Text = "Folder Pak";
            this.TT_ToolTip.SetToolTip(this.CKB_FolderPak, "When drag-n-drop, each folder gets packed into its own pak.");
            this.CKB_FolderPak.UseVisualStyleBackColor = true;
            this.CKB_FolderPak.CheckedChanged += new System.EventHandler(this.CKB_FolderPak_CheckedChanged);
            // 
            // CKB_AsPatch
            // 
            this.CKB_AsPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CKB_AsPatch.AutoSize = true;
            this.CKB_AsPatch.Checked = global::UnrealPakGUI.Properties.Settings.Default.bAsPatch;
            this.CKB_AsPatch.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UnrealPakGUI.Properties.Settings.Default, "bAsPatch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CKB_AsPatch.Location = new System.Drawing.Point(645, 46);
            this.CKB_AsPatch.Name = "CKB_AsPatch";
            this.CKB_AsPatch.Size = new System.Drawing.Size(72, 16);
            this.CKB_AsPatch.TabIndex = 18;
            this.CKB_AsPatch.Text = "As Patch";
            this.TT_ToolTip.SetToolTip(this.CKB_AsPatch, "Append \"_p\" to pak filename.");
            this.CKB_AsPatch.UseVisualStyleBackColor = true;
            this.CKB_AsPatch.CheckedChanged += new System.EventHandler(this.CKB_AsPatch_CheckedChanged);
            // 
            // TB_BatchOutputDir
            // 
            this.TB_BatchOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_BatchOutputDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "BatchOutputDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_BatchOutputDir.Location = new System.Drawing.Point(77, 7);
            this.TB_BatchOutputDir.Name = "TB_BatchOutputDir";
            this.TB_BatchOutputDir.ReadOnly = true;
            this.TB_BatchOutputDir.Size = new System.Drawing.Size(625, 21);
            this.TB_BatchOutputDir.TabIndex = 12;
            this.TB_BatchOutputDir.Text = global::UnrealPakGUI.Properties.Settings.Default.BatchOutputDir;
            this.TT_ToolTip.SetToolTip(this.TB_BatchOutputDir, "Directory to save pak files.");
            // 
            // TB_ExtractToDir
            // 
            this.TB_ExtractToDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ExtractToDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "ExtractToDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_ExtractToDir.Location = new System.Drawing.Point(77, 7);
            this.TB_ExtractToDir.Name = "TB_ExtractToDir";
            this.TB_ExtractToDir.ReadOnly = true;
            this.TB_ExtractToDir.Size = new System.Drawing.Size(625, 21);
            this.TB_ExtractToDir.TabIndex = 15;
            this.TB_ExtractToDir.Text = global::UnrealPakGUI.Properties.Settings.Default.ExtractToDir;
            this.TT_ToolTip.SetToolTip(this.TB_ExtractToDir, "Directory to extract pak contet to.");
            // 
            // TB_ProjectFile
            // 
            this.TB_ProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ProjectFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "ProjectFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_ProjectFile.Location = new System.Drawing.Point(107, 67);
            this.TB_ProjectFile.Name = "TB_ProjectFile";
            this.TB_ProjectFile.ReadOnly = true;
            this.TB_ProjectFile.Size = new System.Drawing.Size(621, 21);
            this.TB_ProjectFile.TabIndex = 4;
            this.TB_ProjectFile.Text = global::UnrealPakGUI.Properties.Settings.Default.ProjectFile;
            this.TT_ToolTip.SetToolTip(this.TB_ProjectFile, "Path to uproject file");
            // 
            // TB_CryptoFile
            // 
            this.TB_CryptoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_CryptoFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "CryptoFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_CryptoFile.Location = new System.Drawing.Point(107, 39);
            this.TB_CryptoFile.Name = "TB_CryptoFile";
            this.TB_CryptoFile.ReadOnly = true;
            this.TB_CryptoFile.Size = new System.Drawing.Size(621, 21);
            this.TB_CryptoFile.TabIndex = 2;
            this.TB_CryptoFile.Text = global::UnrealPakGUI.Properties.Settings.Default.CryptoFile;
            this.TT_ToolTip.SetToolTip(this.TB_CryptoFile, "Path to Crypto.json file");
            // 
            // TB_EngineDir
            // 
            this.TB_EngineDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_EngineDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnrealPakGUI.Properties.Settings.Default, "EngineDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TB_EngineDir.Location = new System.Drawing.Point(107, 11);
            this.TB_EngineDir.Name = "TB_EngineDir";
            this.TB_EngineDir.ReadOnly = true;
            this.TB_EngineDir.Size = new System.Drawing.Size(621, 21);
            this.TB_EngineDir.TabIndex = 0;
            this.TB_EngineDir.Text = global::UnrealPakGUI.Properties.Settings.Default.EngineDir;
            this.TT_ToolTip.SetToolTip(this.TB_EngineDir, "Unreal Engine root directory");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 584);
            this.Controls.Add(this.CKB_ContentOnly);
            this.Controls.Add(this.CKB_Compression);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.FolderBrowserDialog FBD_BrowseDir;
        private System.Windows.Forms.OpenFileDialog OFD_BrowseOutputFile;
        private System.Windows.Forms.ListBox LB_FilesToPak;
        private System.Windows.Forms.TextBox TB_ProjectFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_BrowseProjectFile;
        private System.Windows.Forms.OpenFileDialog OFD_BrowseProjectFile;
        private System.Windows.Forms.CheckBox CKB_Encryption;
        private System.Windows.Forms.Button BTN_RemoveItems;
        private System.Windows.Forms.Button BTN_CreatePak;
        private System.Windows.Forms.OpenFileDialog OFD_AddFiles;
        private System.Windows.Forms.Button BTN_RemoveAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView TV_BatchFiles;
        private System.Windows.Forms.Button BTN_BatchRemove;
        private System.Windows.Forms.Button BTN_BatchCreatePaks;
        private System.Windows.Forms.Button BTN_BatchRemoveAll;
        private System.Windows.Forms.TextBox TB_BatchOutputDir;
        private System.Windows.Forms.Button BTN_BrowseBatchOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CKB_ContentOnly;
        private System.Windows.Forms.ToolTip TT_ToolTip;
        private System.Windows.Forms.CheckBox CKB_AsPatch;
        private System.Windows.Forms.CheckBox CKB_FolderPak;
        private System.Windows.Forms.CheckBox CKB_Compression;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView TV_ListPak;
        private System.Windows.Forms.Button BTN_BrowseExtractToDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_ExtractToDir;
    }
}

