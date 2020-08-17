using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Option")]
    public class Option {
        public Option() { }

        public Option(string name, string value) {
            this.name = name;
            Value     = value;
        }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}