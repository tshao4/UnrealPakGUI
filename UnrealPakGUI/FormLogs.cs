using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnrealPakGUI
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
        }

        public void ShowLog(string Line)
        {
            TB_Logs.AppendText(Line + "\r\n");
        }

        public void ClearLog()
        {
            TB_Logs.Clear();
        }

        private void FormLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
