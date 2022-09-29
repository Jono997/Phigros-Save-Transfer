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
            if (new CreateBackupForm().ShowDialog() == DialogResult.OK)
                RefreshBackupsListBox();
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
