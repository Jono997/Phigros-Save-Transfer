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
    public partial class CreateBackupForm : Form
    {
        public CreateBackupForm()
        {
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
            backupNameTextBox.Text = DateTime.Now.ToString("G");
            originComboBox.Items.AddRange(Global.AppVersions);
        }

        private void originComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            createBackupButton.Enabled = originComboBox.SelectedIndex >= 0;
        }

        private void createBackupButton_Click(object sender, EventArgs e)
        {
            AppVersion app_version = (AppVersion)originComboBox.SelectedItem;
            Global.ADB($"backup -f backup.ab {app_version.AppID}", Global.Paths.Working);
            string backup_path = Path.Combine(Global.Paths.Working, "backup.ab");
            if (!File.Exists(backup_path))
            {
                MessageBox.Show("Backup failed. Backup file not found.", "backup.ab not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FileInfo backup_info = new FileInfo(backup_path);
            if (backup_info.Length < Global.settings.GoodBackupSize)
            {
                if (MessageBox.Show($"This backup is a low filesize ({backup_info.Length / 1000} KB). Usually, backups below 7,500 KB are incomplete or corrupted.\nStore this backup anyway?", "Low backup size", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    File.Delete(backup_path);
                    return;
                }
            }
            BackupPasswordForm bpf = new BackupPasswordForm(backupNameTextBox.Text, app_version);
            if (bpf.ShowDialog() == DialogResult.OK)
            {
                File.Move(backup_path, Global.Paths.Backup(bpf.data.Name));
                Global.backups.Add(bpf.data);
                Global.WriteXML(Global.Paths.BackupData, Global.backups);
                Global.CleanWorkingDirectory();
                MessageBox.Show("Backup successful");
                DialogResult = DialogResult.OK;
            }
            else
            {
                File.Delete(backup_path);
            }
            Close();
        }
    }
}
