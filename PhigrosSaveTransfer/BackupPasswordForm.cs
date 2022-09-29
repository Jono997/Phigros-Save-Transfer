using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PhigrosSaveTransfer
{
    public partial class BackupPasswordForm : Form
    {
        internal BackupData data;

        public BackupPasswordForm(string backup_name, AppVersion app_version)
        {
            data = new BackupData()
            {
                Name = backup_name,
                appVersion = app_version
            };
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void passwordRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = passwordRadioButton.Checked;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (noPasswordRadioButton.Checked)
            {
                data.HasPassword = false;
                Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" unpack backup.ab backup.tar", Global.Paths.Working);
                if (!File.Exists(Path.Combine(Global.Paths.Working, "backup.tar")))
                {
                    MessageBox.Show("Backup extraction failed. This is usually caused by an incorrect password. If the backup does have a password, please input it. Otherwise, try again.", "Backup extract failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                data.HasPassword = true;
                data.Password = passwordTextBox.Text;
                Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" unpack backup.ab backup.tar ""{data.Password}""", Global.Paths.Working);
                if (!File.Exists(Path.Combine(Global.Paths.Working, "backup.tar")))
                {
                    MessageBox.Show("Backup extraction failed. This is usually caused by an incorrect password. Please try again.", "Backup extract failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BackupPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel && MessageBox.Show("The backup information is not finalised. If you close this window, the backup will be deleted.\nClose this window anyway?", "Cancel backup?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
