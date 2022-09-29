using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PhigrosSaveTransfer
{
    public class BackupData
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name;

        [XmlAttribute(AttributeName = "haspassword", DataType = "boolean")]
        public bool HasPassword;

        [XmlElement(ElementName = "password")]
        public string Password;

        [XmlElement(ElementName = "appversion")]
        public AppVersion appVersion;

        public BackupData()
        {
            Name = DateTime.Now.ToString("G");
            Password = "";
            HasPassword = false;
            appVersion = Global.AppVersions[0];
        }
    }
}
