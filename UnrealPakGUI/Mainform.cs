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
        public MainForm()
        {
            InitializeComponent();
            Logs = new FormLogs();
        }

        const string UnrealPakRelativePath = @"Engine\Binaries\Win64\UnrealPak.exe";
        string CmdStr = string.Empty;
        FormLogs Logs;

        private void BTN_BrowseEngineDir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FBD_BrowseEngineDir.ShowDialog())
            {
                TB_EngineDir.Text = FBD_BrowseEngineDir.SelectedPath;
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

        private void BTN_AddFiles_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == OFD_AddFiles.ShowDialog())
            {
                LB_FilesToPak.BeginUpdate();
                foreach (string FileName in OFD_AddFiles.FileNames.Where(FileName => !LB_FilesToPak.Items.Contains(FileName)))
                {
                    LB_FilesToPak.Items.Add(FileName);
                }
                LB_FilesToPak.EndUpdate();
            }
        }

        private void BTN_AddDir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == FBD_AddDir.ShowDialog())
            {
                LB_FilesToPak.BeginUpdate();
                foreach (string FileName in Directory.EnumerateFiles(FBD_AddDir.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(FileName => !LB_FilesToPak.Items.Contains(FileName)))
                {
                    LB_FilesToPak.Items.Add(FileName);
                }
                LB_FilesToPak.EndUpdate();
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
            LB_FilesToPak.BeginUpdate();
            LB_FilesToPak.Items.Clear();
            LB_FilesToPak.EndUpdate();
        }

        private void BTN_CreatePak_Click(object sender, EventArgs e)
        {
            string UnrealPakPath = Path.Combine(TB_EngineDir.Text, UnrealPakRelativePath);
            string CryptoFilePath = TB_CryptoFile.Text;
            string ProjectFilePath = TB_ProjectFile.Text;
            bool bEncryption = CKB_Encryption.Checked;
            string[] FilesToPak = LB_FilesToPak.Items.Cast<string>().ToArray() ;
            string ResponseFilePath = string.Empty;
            string OutputFilePath = string.Empty;
            string Args = string.Empty;

            if (!File.Exists(UnrealPakPath))
            {
                MessageBox.Show($"Could not find UnrealPak.exe at {UnrealPakPath}!", "UnrealPak.exe Not Found");
                return;
            }

            if (bEncryption && !File.Exists(CryptoFilePath))
            {                
                MessageBox.Show("Crypto File does not exist!", "Missing Crypto File");
                return;
            }

            if (!File.Exists(ProjectFilePath))
            {
                MessageBox.Show("Project File does not exist!", "Missing Project File");
                return;
            }

            if (FilesToPak.Count() == 0)
            {
                MessageBox.Show("Nothing to Pak!", "Nothing to Pak");
                return;
            }

            ResponseFilePath = CreateResponseFile(FilesToPak, ProjectFilePath, bEncryption);

            if (!File.Exists(ResponseFilePath))
            {
                MessageBox.Show($"Unable to create response file: {ResponseFilePath}", "Response File");
                return;
            }

            if (DialogResult.OK != OFD_BrowseOutputFile.ShowDialog())
            {
                return;
            }

            OutputFilePath = OFD_BrowseOutputFile.FileName;

            Args = OutputFilePath
                + $" -create={ResponseFilePath}";

            if (bEncryption)
            {
                Args += $" -cryptokeys={CryptoFilePath}" + " -encryptindex";
            }

            Args += " -patchpaddingalign=2048"
                + $" -compressionformats={ProjectFilePath}"
                + " -multiprocess";

            RunUnrealPak(UnrealPakPath, Args);
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["EngineDir"] = TB_EngineDir.Text;
            Properties.Settings.Default["CryptoFile"] = TB_CryptoFile.Text;
            Properties.Settings.Default["ProjectFile"] = TB_ProjectFile.Text;
            Properties.Settings.Default["bUseEncryption"] = CKB_Encryption.Checked;
            Properties.Settings.Default.Save();
        }

        private bool IsDirectory(string FileName)
        {
            return Directory.Exists(FileName);
        }

        private string CreateResponseFile(string[] FilesToPak, string ProjectFilePath, bool bEncrytion)
        {
            string ProjectName = Path.GetFileNameWithoutExtension(ProjectFilePath);
            string ResponseFileDir = @".\ResponseFiles";
            string ResponseFilePath = Path.Combine(ResponseFileDir, $"{ProjectName}-{DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss")}.txt");
            string MountPoint = $"../../../{ProjectName}";

            List<string> Lines = new List<string>();

            for (int i = 0; i < FilesToPak.Length; i++)
            {
                string FileName = FilesToPak[i];
                string FileExtension = Path.GetExtension(FileName);

                int RelativeIndex = FileName.LastIndexOf(@"\Content\");
                if (RelativeIndex < 0)
                {
                    continue;
                }

                string RelativeFilePath = MountPoint + FileName.Substring(RelativeIndex).Replace(@"\", "/");
                string Line = "\"" + FileName + "\" \"" + RelativeFilePath + "\"";
                if (bEncrytion && FileExtension == ".uasset" || FileExtension == ".ini")
                {
                    Line += " -encrypt";
                }

                Lines.Add(Line);
            }

            if (Lines.Count == 0)
            {
                return "No eligible file!";
            }

            if (!Directory.Exists(ResponseFileDir))
            {
                Directory.CreateDirectory(ResponseFileDir);
            }            

            File.WriteAllLines(ResponseFilePath, Lines);

            return Path.GetFullPath(ResponseFilePath);
        }

        private void RunUnrealPak(string UnrealPakPath, string Args)
        {
            CmdStr = UnrealPakPath + " " + Args;
            Thread Worker = new Thread(RunUnrealPakWorker);
            Worker.IsBackground = true;
            Worker.Start();
        }

        private void RunUnrealPakWorker()
        {
            ProcessStartInfo StartInfo = new ProcessStartInfo("cmd.exe");
            StartInfo.CreateNoWindow = true;
            StartInfo.RedirectStandardInput = true;
            StartInfo.RedirectStandardOutput = true;
            StartInfo.RedirectStandardError = true;
            StartInfo.UseShellExecute = false;
            Process CmdProc = Process.Start(StartInfo);
            StreamWriter Writer = CmdProc.StandardInput;
            Writer.WriteLine(CmdStr);
            Writer.WriteLine("exit");
            Writer.Close();

            CmdProc.OutputDataReceived += new DataReceivedEventHandler(OnOutputDataReceived);
            CmdProc.BeginOutputReadLine();
            CmdProc.WaitForExit();
            CmdProc.Close();
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                ShowLog(e.Data);
            }
        }

        private delegate void ShowLogDelegate(string Line);
        private void ShowLog(string Line)
        {
            if (this.InvokeRequired)
            {
                ShowLogDelegate Delegate = ShowLog;
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
