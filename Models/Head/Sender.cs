using System.Xml.Serialization;

namespace CXML.Models.Head {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Sender")]
    public class Sender {
        [XmlElement("Credential")]
        public Credential[] Credential { get; set; }

        [XmlElement("UserAgent", IsNullable = true)]
        public string UserAgent { get; set; }

        public bool ShouldSerializeUserAgent() {
            return UserAgent != null;
        }
    }
#pragma warning restore IDE1006
}