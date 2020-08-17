using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Description")]
    public class Description {
        public Description() { }

        public Description(string description, string lang = null) {
            Value     = description;
            this.lang = lang;
        }

        [XmlAttribute("xml:lang")]
        public string lang { get; set; }

        [XmlText]
        public string Value { get; set; }

        public bool ShouldSerializelang() {
            return !string.IsNullOrEmpty(lang);
        }
    }
#pragma warning restore IDE1006
}