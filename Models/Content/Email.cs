using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Email")]
    public class Email {
        public Email() { }

        public Email(string name, string value) {
            this.name = name;
            Value     = value;
        }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlText]
        public string Value { get; set; }

        public bool ShouldSerializename() {
            return !string.IsNullOrEmpty(name);
        }
    }
#pragma warning restore IDE1006
}