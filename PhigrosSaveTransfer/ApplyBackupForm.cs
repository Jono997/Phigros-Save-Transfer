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
            versionsListBox.Items.AddRange(Global.AppVersions);
        }

        private void versionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = versionsListBox.SelectedIndex >= 0;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            AppVersion target = (AppVersion)versionsListBox.SelectedItem;
            File.Copy(Global.Paths.Backup(data.Name), Path.Combine(Global.Paths.Working, "backup.ab"));

            if (target != data.appVersion)
            {
                if (data.HasPassword)
                    Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" unpack backup.ab backup.tar ""{data.Password}""", Global.Paths.Working);
                else
                    Global.CMD($@"""{Global.Paths.Java}"" -jar ""{Global.Paths.ABE}"" unpack backup.ab backup.tar", Global.Paths.Working);
                string filelist = Global.CMD($@"""{Global.Paths.Tar}"" -tf backup.tar", Global.Paths.Working);
                filelist = filelist.Replace(data.appVersion.AppID, target.AppID);
                File.WriteAllText("package.list", filelist);
                Global.CMD($@"""{Global.Paths.Tar}"" -xf backup.tar", Global.Paths.Working);

                Directory.Move(Path.Combine(Global.Paths.Working, "apps", data.appVersion.AppID), Path.Combine(Global.Paths.Working, "apps", target.AppID));
                string manifest_path = Path.Combine(Global.Paths.Working, "apps", target.AppID, "_manifest");
                string[] manifest = File.ReadAllText(manifest_path).Split('\n');
                manifest[1] = target.AppID;
                manifest[7] = target.Signature;
                string manifest_output = "";
                foreach (string line in manifest)
                    manifest_output += $"{line}\n";
                File.WriteAllText(manifest_path, manifest_output);

                string playerprefs_base_path = Path.Combine(Global.Paths.Working, "apps", target.AppID, "sp");
                File.Move(Path.Combine(playerprefs_base_path, data.appVersion.AppID + ".v2.playerprefs.xml"), Path.Combine(playerprefs_base_path, target.AppID + ".v2.playerprefs.xml"));

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
