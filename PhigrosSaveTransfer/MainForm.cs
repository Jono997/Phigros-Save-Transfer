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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshBackupsListBox();
            UpdateEnabledControls();
        }

        private void RefreshBackupsListBox()
        {
            backupsListBox.Items.Clear();
            foreach (BackupData bd in Global.backups)
                backupsListBox.Items.Add(bd.Name);
        }

        private void UpdateEnabledControls()
        {
            createBackupButton.Enabled = Global.FunctionalSystems.All;
            deleteBackupButton.Enabled = backupsListBox.SelectedIndex >= 0;
            applyBackupButton.Enabled  = createBackupButton.Enabled && deleteBackupButton.Enabled;
        }

        private void backupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEnabledControls();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (new SettingsForm().ShowDialog() == DialogResult.OK)
            {
                Global.TestJava();
                Global.TestADB();
                Global.TestDevice();
                Global.TestTar();
                UpdateEnabledControls();
            }
        }

        private void createBackupButton_Click(object sender, EventArgs e)
        {
            Global.ADB("backup -f backup.ab com.PigeonGames.Phigros", Global.Paths.Working);
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
            BackupPasswordForm bpf = new BackupPasswordForm();
            if (bpf.ShowDialog() == DialogResult.OK)
            {
                File.Move(backup_path, Global.Paths.Backup(bpf.data.Name));
                Global.backups.Add(bpf.data);
                Global.WriteXML(Global.Paths.BackupData, Global.backups);
                Global.CleanWorkingDirectory();
                MessageBox.Show("Backup successful");
                RefreshBackupsListBox();
            }
            else
            {
                File.Delete(backup_path);
            }
        }

        private void deleteBackupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you delete this backup, it cannot be recovered. Are you sure you want to delete it?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BackupData bd = Global.backups[backupsListBox.SelectedIndex];
                Global.backups.RemoveAt(backupsListBox.SelectedIndex);
                Global.WriteXML(Global.Paths.BackupData, Global.backups);
                File.Delete(Global.Paths.Backup(bd.Name));
                RefreshBackupsListBox();
            }
        }

        private void applyBackupButton_Click(object sender, EventArgs e)
        {
            if (new ApplyBackupForm(Global.backups[backupsListBox.SelectedIndex]).ShowDialog() == DialogResult.OK)
                new ApplyBackupCompleteForm().ShowDialog();
        }
    }
}
