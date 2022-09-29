using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PhigrosSaveTransfer
{
    public class AppVersion
    {
        [XmlElement(ElementName = "name")]
        public string Name;
        [XmlElement(ElementName = "appid")]
        public string AppID;
        [XmlElement(ElementName = "signature")]
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
