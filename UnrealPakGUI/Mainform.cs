using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UnrealPakGUI
{
    public partial class MainForm : Form
    {
        private delegate void PassStringDelegate(string Line);
        FormLogs Logs;
        const string UnrealPakRelativePath = @"Engine\Binaries\Win64\UnrealPak.exe";
        string UnrealPakPath;
        string CryptoFilePath;
        string ProjectFilePath;
        string BatchOutputPath;
        bool bContentOnly = false;
        bool bCompression = false;
        bool bEncryption = false;
        bool bAsPatch = false;
        bool bBatchMode = false;
        int BatchCount = 0;
        int BatchTotal = 0;

        public MainForm()
        {
            InitializeComponent();
            Logs = new FormLogs();
        }

        private void BTN_BrowseEngineDir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FBD_BrowseDir.ShowDialog())
            {
                TB_EngineDir.Text = FBD_BrowseDir.SelectedPath;
            }
        }

        private void BTN_BrowseCryptoFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == OFD_BrowseCryptoFile.ShowDialog())
            {
                TB_CryptoFile.Text = OFD_BrowseCryptoFile.FileName;
            }
        }

        private void BTN_BrowseProjectFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == OFD_BrowseProjectFile.ShowDialog())
            {
                TB_ProjectFile.Text = OFD_BrowseProjectFile.FileName;
            }
        }

        private void BTN_RemoveItems_Click(object sender, EventArgs e)
        {
            LB_FilesToPak.BeginUpdate();
            IEnumerable<string> FilesToRemove = LB_FilesToPak.SelectedItems.Cast<string>();
            foreach (string FileName in FilesToRemove)
            {
                LB_FilesToPak.Items.Remove(FileName);
            }
            LB_FilesToPak.EndUpdate();
        }

        private void BTN_RemoveAll_Click(object sender, EventArgs e)
        {
            LB_FilesToPak.Items.Clear();
        }

        private void BTN_CreatePak_Click(object sender, EventArgs e)
        {
            bBatchMode = false;
            ApplyConfigs();

            if (!ValidateConfigs())
            {
                return;
            }
            
            if (LB_FilesToPak.Items.Count == 0)
            {
                MessageBox.Show("Nothing to Pak!", "Nothing to Pak");
                return;
            }

            if (DialogResult.OK != OFD_BrowseOutputFile.ShowDialog())
            {
                return;
            }

            ShowLog("///////////////////////// START PACKING /////////////////////////");

            string[] FilesToPak = LB_FilesToPak.Items.Cast<string>().ToArray();
            PakBatch Batch = new PakBatch(FilesToPak);
            Batch.OutputPath = OFD_BrowseOutputFile.FileName;
            CreateSinglePak(Batch);
        }

        private void BTN_BrowseBatchOutputDir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FBD_BrowseDir.ShowDialog())
            {
                TB_BatchOutputDir.Text = FBD_BrowseDir.SelectedPath;
            }
        }

        private void BTN_BatchRemove_Click(object sender, EventArgs e)
        {
            TreeNode NodeToRemove = TV_BatchFiles.SelectedNode;
            while (NodeToRemove.Parent != null)
            {
                NodeToRemove = NodeToRemove.Parent;
            }
            TV_BatchFiles.Nodes.Remove(NodeToRemove);
        }

        private void BTN_BatchRemoveAll_Click(object sender, EventArgs e)
        {
            TV_BatchFiles.Nodes.Clear();
        }

        private void BTN_BatchCreatePaks_Click(object sender, EventArgs e)
        {
            bBatchMode = true;
            ApplyConfigs();
            if (!ValidateConfigs())
            {
                return;
            }
            
            if (TV_BatchFiles.Nodes.Count == 0)
            {
                MessageBox.Show("Nothing to Pak!", "Nothing to Pak");
                return;
            }

            if (!Directory.Exists(BatchOutputPath))
            {
                MessageBox.Show("Output directory does not exist!");
                return;
            }

            ShowLog("////////////////////// START BATCH PACKING //////////////////////");

            BatchCount = BatchTotal = TV_BatchFiles.GetNodeCount(false);

            foreach (TreeNode Node in TV_BatchFiles.Nodes)
            {
                PakBatch Batch = Node.Tag as PakBatch;
                Batch.OutputPath = BatchOutputPath;
                if (Batch == null)
                {
                    continue;
                }
                CreateSinglePak(Batch);
            }
        }

        private void LB_FilesToPak_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LB_FilesToPak_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LB_FilesToPak_DragDrop(object sender, DragEventArgs e)
        {
            LB_FilesToPak.BeginUpdate();
            string[] FileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            foreach (string FileName in FileNames.Where(FileName => !LB_FilesToPak.Items.Contains(FileName)))
            {
                if (IsDirectory(FileName))
                {
                    foreach (string SubDirFileName in Directory.EnumerateFiles(FileName, "*.*", SearchOption.AllDirectories)
                    .Where(SubDirFileName => !LB_FilesToPak.Items.Contains(SubDirFileName)))
                    {
                        LB_FilesToPak.Items.Add(SubDirFileName);
                    }
                }
                else
                {
                    LB_FilesToPak.Items.Add(FileName);
                }
            }
            LB_FilesToPak.EndUpdate();
        }

        private void TV_BatchFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TV_BatchFiles_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TV_BatchFiles_DragDrop(object sender, DragEventArgs e)
        {
            TV_BatchFiles.BeginUpdate();
            string[] FileNames = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            if (CKB_FolderPak.Checked)
            {
                List<string> SingleFiles = new List<string>();
                foreach (string FileName in FileNames)
                {
                    if (IsDirectory(FileName))
                    {
                        PakBatch Batch = new PakBatch(new string[] { FileName });
                        TreeNode Node = new TreeNode(Batch.BatchNodeText);
                        Node.Tag = Batch;
                        foreach (string SubDirFileName in Batch.Files)
                        {
                            Node.Nodes.Add(new TreeNode(SubDirFileName.Substring(Batch.CommonPath.Length)));
                        }
                        TV_BatchFiles.Nodes.Add(Node);
                    }
                    else
                    {
                        SingleFiles.Add(FileName);
                    }
                }

                if (SingleFiles.Count > 0)
                {
                    PakBatch Batch = new PakBatch(SingleFiles.ToArray());
                    TreeNode Node = new TreeNode(Batch.BatchNodeText);
                    Node.Tag = Batch;
                    TV_BatchFiles.Nodes.Add(Node);
                }
            }
            else
            {
                PakBatch Batch = new PakBatch(FileNames);
                TreeNode Node = new TreeNode(Batch.BatchNodeText);
                Node.Tag = Batch;
                foreach (string FileName in Batch.Files)
                {
                    Node.Nodes.Add(new TreeNode(FileName.Substring(Batch.CommonPath.Length)));
                }
                TV_BatchFiles.Nodes.Add(Node);
                TV_BatchFiles.CollapseAll();
                Node.Expand();
            }
            TV_BatchFiles.EndUpdate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["EngineDir"] = TB_EngineDir.Text;
            Properties.Settings.Default["CryptoFile"] = TB_CryptoFile.Text;
            Properties.Settings.Default["ProjectFile"] = TB_ProjectFile.Text;
            Properties.Settings.Default["BatchOutputDir"] = TB_BatchOutputDir.Text;
            Properties.Settings.Default["bContentOnly"] = CKB_ContentOnly.Checked;
            Properties.Settings.Default["bUseCompression"] = CKB_Compression.Checked;
            Properties.Settings.Default["bUseEncryption"] = CKB_Encryption.Checked;
            Properties.Settings.Default["bAsPatch"] = CKB_AsPatch.Checked;
            Properties.Settings.Default["bFolderPak"] = CKB_FolderPak.Checked;
            Properties.Settings.Default.Save();
        }

        private bool ValidateConfigs()
        {
            if (!File.Exists(UnrealPakPath))
            {
                MessageBox.Show($"Could not find UnrealPak.exe at {UnrealPakPath}!", "UnrealPak.exe Not Found");
                return false;
            }

            if (bEncryption && !File.Exists(CryptoFilePath))
            {
                MessageBox.Show("Crypto File does not exist!", "Missing Crypto File");
                return false;
            }

            if (!File.Exists(ProjectFilePath))
            {
                MessageBox.Show("Project File does not exist!", "Missing Project File");
                return false;
            }

            return true;
        }

        private void ApplyConfigs()
        {
            UnrealPakPath = Path.Combine(TB_EngineDir.Text, UnrealPakRelativePath);
            CryptoFilePath = TB_CryptoFile.Text;
            ProjectFilePath = TB_ProjectFile.Text;
            BatchOutputPath = TB_BatchOutputDir.Text;
            bContentOnly = CKB_ContentOnly.Checked;
            bCompression = CKB_Compression.Checked;
            bEncryption = CKB_Encryption.Checked;
            bAsPatch = CKB_AsPatch.Checked;
        }

        private void CreateSinglePak(PakBatch Batch)
        {
            string ResponseFilePath = string.Empty;
            List<string> Args = new List<string>();

            ResponseFilePath = CreateResponseFile(Batch);

            if (!File.Exists(ResponseFilePath))
            {
                return;
            }

            if (string.IsNullOrEmpty(Batch.OutputPath))
            {
                return;
            }

            string FileOutputPath = Batch.OutputPath;
            if (bAsPatch)
            {
                FileOutputPath = FileOutputPath.Insert(FileOutputPath.LastIndexOf(".pak"), "_p");
            }

            Args.Add(FileOutputPath);
            Args.Add($"-create={ResponseFilePath}");

            if (bEncryption)
            {
                Args.Add($"-cryptokeys={CryptoFilePath}");
                Args.Add("-encryptindex");
            }

            Args.Add("-patchpaddingalign=2048");
            Args.Add($"-compressionformats={ProjectFilePath}");
            Args.Add("-multiprocess");
            
            RunUnrealPak(Args.ToArray());
        }

        private bool IsDirectory(string FileName)
        {
            return Directory.Exists(FileName);
        }

        private string CreateResponseFile(PakBatch Batch)
        {
            string[] FilesToPak = Batch.Files;
            string ProjectName = Path.GetFileNameWithoutExtension(ProjectFilePath);
            string ResponseFileDir = @".\ResponseFiles";
            string ResponseFilePath = Path.Combine(ResponseFileDir, $"{ProjectName}-{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}");
            string MountPoint = bContentOnly ? $"../../../{ProjectName}/" : Batch.CommonPath.Replace(@"\", "/");

            List<string> Lines = new List<string>();

            for (int i = 0; i < FilesToPak.Length; i++)
            {
                string FileName = FilesToPak[i];
                string FileExtension = Path.GetExtension(FileName);

                int RelativeIndex = bContentOnly ? FileName.LastIndexOf(@"Content\") : Batch.CommonPath.Length;
                if (RelativeIndex < 0)
                {
                    continue;
                }

                string RelativeFilePath = MountPoint + FileName.Substring(RelativeIndex).Replace(@"\", "/");
                string Line = "\"" + FileName + "\" \"" + RelativeFilePath + "\"";
                if (bEncryption && FileExtension == ".uasset" || FileExtension == ".ini")
                {
                    Line += " -encrypt";
                }

                Lines.Add(Line);
            }

            if (Lines.Count == 0)
            {
                string ErrMsg = $"ERROR: No eligible file{ (bBatchMode ? $" for batch {Batch.BatchNodeText}!" : "!") }";
                ShowLog(ErrMsg);
                return string.Empty;
            }

            if (!Directory.Exists(ResponseFileDir))
            {
                Directory.CreateDirectory(ResponseFileDir);
            }

            if (File.Exists(ResponseFilePath + ".txt"))
            {
                int DuplicateCount = 1;
                while (File.Exists(ResponseFilePath + $"_{DuplicateCount}.txt"))
                {
                    DuplicateCount++;
                }
                ResponseFilePath += $"_{DuplicateCount}.txt";
            }
            else
            {
                ResponseFilePath += ".txt";
            }

            File.WriteAllLines(ResponseFilePath, Lines);

            return Path.GetFullPath(ResponseFilePath);
        }

        private void RunUnrealPak(string[] Args)
        {
            Thread Worker = new Thread(() => RunUnrealPakWorker(Args));
            Worker.IsBackground = true;
            Worker.Start();
        }

        private void RunUnrealPakWorker(string[] Args)
        {
            string CombinedArgs = string.Empty;
            foreach (string Arg in Args)
            {
                CombinedArgs += Arg + " ";
            }
            CombinedArgs.Trim();

            ProcessStartInfo StartInfo = new ProcessStartInfo(UnrealPakPath, CombinedArgs);
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardOutput = !bBatchMode;
            StartInfo.RedirectStandardError = !bBatchMode;
            StartInfo.UseShellExecute = false;
            Process CmdProc = Process.Start(StartInfo);

            if (!bBatchMode)
            {
                ShowLog($"Running command: {UnrealPakPath} {CombinedArgs}");
                CmdProc.OutputDataReceived += new DataReceivedEventHandler(OnOutputDataReceived);
                CmdProc.BeginOutputReadLine();
            }

            CmdProc.WaitForExit();
            CmdProc.Close();

            if (bBatchMode)
            {
                ReportPakCreated(Args[0]);
            }
            else
            {
                ShowLog("///////////////////////// DONE PACKING //////////////////////////");
            }
        }

        private void ReportPakCreated(string PakName)
        {
            if (this.InvokeRequired)
            {
                PassStringDelegate Delegate = ReportPakCreated;
                object[] Args = { PakName };
                this.Invoke(Delegate, Args);
            }
            else
            {
                BatchCount--;
                ShowLog($"{BatchTotal - BatchCount} of {BatchTotal} - Pak file created: {PakName}");
                if (BatchCount == 0)
                {
                    ShowLog("////////////////////// DONE BATCH PACKING ///////////////////////");
                }
            }
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                ShowLog(e.Data);
            }
        }

        private void ShowLog(string Line)
        {
            if (this.InvokeRequired)
            {
                PassStringDelegate Delegate = ShowLog;
                object[] Args = { Line };
                this.Invoke(Delegate, Args);
            }
            else
            {
                if (!Logs.Visible)
                {
                    Logs.Show();
                }
                Logs.ShowLog(Line);
            }
        }
    }
}
