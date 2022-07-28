using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhigrosSaveTransfer
{
    public class BackupData
    {
        public string Name;
        public bool HasPassword;
        public string Password;
        public BackupOrigin Origin;
        public enum BackupOrigin
        {
            TapTap,
            GooglePlay
        }

        public BackupData()
        {
            Name = DateTime.Now.ToString("G");
            Password = "";
            HasPassword = false;
            Origin = BackupOrigin.TapTap;
        }
    }
}
