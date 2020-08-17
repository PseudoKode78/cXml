using System.Xml.Serialization;

namespace CXML.Models.Head {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Identity")]
    public class Identity {
        public Identity() { }

        public Identity(string value) {
            Value = value;
        }

        [XmlText]
        public string Value { get; set; }

        public override string ToString() {
            return Value;
        }
    }
#pragma warning restore IDE1006
}