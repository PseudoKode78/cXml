using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Name")]
    public class Name {
        public Name() {
            lang  = "en";
            Value = "";
        }

        public Name(string value) {
            lang  = "en";
            Value = value;
        }

        public Name(string value, string lang) {
            this.lang = lang;
            Value     = value;
        }

        [XmlAttribute("xml:lang")]
        public string lang { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}