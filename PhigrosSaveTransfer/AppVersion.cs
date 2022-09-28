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
    }
}
