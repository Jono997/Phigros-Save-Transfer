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
    public partial class ApplyBackupForm : Form
    {
        private BackupData data;

        public ApplyBackupForm(BackupData data)
        {
            this.data = data;
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            BackupData.BackupOrigin target = TapTapRadioButton.Checked ? BackupData.BackupOrigin.TapTap : BackupData.BackupOrigin.GooglePlay;
            File.Copy(Global.Paths.Backup(data.Name), Path.Combine(Global.Paths.Working, "backup.ab"));

            if (target != data.Origin)
            {
                if (data.HasPassword)
                    Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" unpack backup.ab backup.tar ""{data.Password}""", Global.Paths.Working);
                else
                    Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" unpack backup.ab backup.tar", Global.Paths.Working);
                Global.CMD($@"""{Global.Paths.Tar}"" -tf backup.tar > package.list", Global.Paths.Working);
                Global.CMD($@"""{Global.Paths.Tar}"" -xf backup.tar", Global.Paths.Working);

                string[] manifest = File.ReadAllText(Global.Paths.Manifest).Split('\n');
                foreach (string key in Global.ManifestKeys.Keys)
                    if (Global.ManifestKeys[key] == target)
                        manifest[7] = key;
                string manifest_output = "";
                foreach (string line in manifest)
                    manifest_output += $"{line}\n";
                File.WriteAllText(Global.Paths.Manifest, manifest_output);

                File.Delete(Path.Combine(Global.Paths.Working, "backup.ab"));
                File.Delete(Path.Combine(Global.Paths.Working, "backup.tar"));
                Global.CMD($@"""{Global.Paths.Tar}"" -cf backup.tar -T package.list", Global.Paths.Working);
                Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" pack backup.tar backup.ab", Global.Paths.Working);
            }

            Global.ADB("restore backup.ab", Global.Paths.Working);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
