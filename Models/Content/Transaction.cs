using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Transaction")]
    public class Transaction {
        public Transaction() { }

        public Transaction(string name, URL url, params Option[] options) {
            this.name = name;
            URL       = url;
            Option    = options;
        }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlElement("URL")]
        public URL URL { get; set; }

        [XmlElement("Option", IsNullable = true)]
        public Option[] Option { get; set; }

        public bool ShouldSerializeName() {
            return !string.IsNullOrEmpty(name);
        }
    }
#pragma warning restore IDE1006
}