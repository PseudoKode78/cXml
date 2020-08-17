using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Classification")]
    public class Classification {
        public Classification() { }

        public Classification(string value, string domain) {
            Value       = value;
            this.domain = domain;
        }

        [XmlAttribute("domain")]
        public string domain { get; set; }

        [XmlText]
        public string Value { get; set; }

        public bool ShouldSerializedomain() {
            return !string.IsNullOrEmpty(domain);
        }
    }
#pragma warning restore IDE1006
}