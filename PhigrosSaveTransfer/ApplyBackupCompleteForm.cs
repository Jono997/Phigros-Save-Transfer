using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhigrosSaveTransfer
{
    public partial class ApplyBackupCompleteForm : Form
    {
        public ApplyBackupCompleteForm()
        {
            InitializeComponent();
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Global.ADB("restore backup.ab", Global.Paths.Working);
        }

        private void ApplyBackupCompleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.CleanWorkingDirectory();
        }
    }
}
