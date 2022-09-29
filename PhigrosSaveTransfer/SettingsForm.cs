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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
            #region Populate text boxes
            javaPathTextBox.Text = Global.settings.JavaPath;
            ADBPathTextBox.Text  = Global.settings.ADBPath;
            ABEPathTextBox.Text  = Global.settings.ABEPath;
            tarPathTextBox.Text  = Global.settings.TarPath;
            backupSizeNumericUpDown.Value = Global.settings.GoodBackupSize;
            #endregion
            UpdateErrorColours();
        }

        private void UpdateErrorColours()
        {
            javaPathTextBox.ForeColor = Global.FunctionalSystems.Java ? Color.Black : Color.Red;
            ADBPathTextBox.ForeColor  = Global.FunctionalSystems.ADB ? Color.Black : Color.Red;
            ABEPathTextBox.ForeColor = System.IO.File.Exists(ABEPathTextBox.Text) ? Color.Black : Color.Red;
            tarPathTextBox.ForeColor  = Global.FunctionalSystems.Tar ? Color.Black : Color.Red;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string[] current_paths = new string[] { Global.settings.JavaPath, Global.settings.ADBPath, Global.settings.ABEPath, Global.settings.TarPath };
            bool[] current_passes = new bool[] { Global.FunctionalSystems.Java, Global.FunctionalSystems.ADB, Global.FunctionalSystems.Device, Global.FunctionalSystems.Tar };
            Global.settings.JavaPath = javaPathTextBox.Text;
            Global.settings.ADBPath = ADBPathTextBox.Text;
            Global.settings.ABEPath = ABEPathTextBox.Text;
            Global.settings.TarPath = tarPathTextBox.Text;
            
            Global.TestAll();
            UpdateErrorColours();

            Global.settings.JavaPath = current_paths[0];
            Global.settings.ADBPath = current_paths[1];
            Global.settings.ABEPath = current_paths[2];
            Global.settings.TarPath = current_paths[3];
            Global.FunctionalSystems.Java = current_passes[0];
            Global.FunctionalSystems.ADB = current_passes[1];
            Global.FunctionalSystems.Device = current_passes[2];
            Global.FunctionalSystems.Tar = current_passes[3];
        }

        private void javaPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = javaPathTextBox.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                javaPathTextBox.Text = openFileDialog.FileName;
        }

        private void ADBPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = ADBPathTextBox.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                ADBPathTextBox.Text = openFileDialog.FileName;
        }

        private void ABEPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = ABEPathTextBox.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                ABEPathTextBox.Text = openFileDialog.FileName;
        }

        private void tarPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = tarPathTextBox.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tarPathTextBox.Text = openFileDialog.FileName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Global.settings.JavaPath = javaPathTextBox.Text;
            Global.settings.ADBPath = ADBPathTextBox.Text;
            Global.settings.ABEPath = ABEPathTextBox.Text;
            Global.settings.TarPath = tarPathTextBox.Text;
            Global.settings.GoodBackupSize = Convert.ToInt64(backupSizeNumericUpDown.Value);
            Global.WriteXML(Global.Paths.Settings, Global.settings);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
