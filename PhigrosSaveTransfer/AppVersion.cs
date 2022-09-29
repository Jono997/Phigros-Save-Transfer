using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhigrosSaveTransfer
{
    public class AppVersion
    {
        public string Name;
        public string AppID;
        public string Signature;

        public AppVersion()
        {
            Name = AppID = Signature = "";
        }

        public override string ToString()
        {
            return $"{Name} ({AppID})";
        }

        public static bool operator ==(AppVersion a, AppVersion b)
        {
            return a.AppID == b.AppID && a.Signature == b.Signature;
        }

        public static bool operator !=(AppVersion a, AppVersion b)
        {
            return a.AppID != b.AppID || a.Signature == b.Signature;
        }
    }
}
