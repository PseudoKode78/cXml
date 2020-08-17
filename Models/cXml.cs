using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CXML.Models {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("cXml", IsNullable = false)]
    public class cXml {
        public cXml() { }

        public cXml(string payloadID, DateTime timestamp, string lang = "", string version = "",
                    string signatureversion = "") {
            this.payloadID   = payloadID;
            this.timestamp   = timestamp;
            this.lang        = lang;
            this.version     = version;
            signatureVersion = signatureVersion;
        }

        [XmlIgnore]
        [XmlAttribute("version")]
        [DefaultValue("1.2.044")]
        public string version { get; set; }

        [XmlAttribute("payloadID")]
        public string payloadID { get; set; }

        [XmlIgnore]
        public DateTime timestamp { get; set; }

        [XmlAttribute("timestamp")]
        public string timestampString {
            get => timestamp.ToString("o");
            set => timestamp = DateTime.Parse(value);
        }

        [XmlAttribute("lang")]
        public string lang { get; set; }

        [XmlIgnore]
        [XmlAttribute("signatureVersion")]
        public string signatureVersion { get; set; }


        [XmlElement("Header", typeof(Header), IsNullable = true)]
        public Header Header { get; set; }

        public bool ShouldSerializeversion() {
            return !string.IsNullOrEmpty(version);
        }

        public bool ShouldSerializelang() {
            return !string.IsNullOrEmpty(lang);
        }

        public bool ShouldSerializesignatureVersion() {
            return !string.IsNullOrEmpty(signatureVersion);
        }

        public bool ShouldSerializeHeader() {
            return Header != null;
        }
    }
#pragma warning restore IDE1006
}