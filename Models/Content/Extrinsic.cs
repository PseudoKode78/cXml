using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Extrinsic")]
    public class Extrinsic {
        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlElement("IdReference")]
        public IdReference IdReference { get; set; }

        [XmlText]
        public string Value { get; set; }

        public bool ShouldSerializeIdReference() {
            return IdReference != null;
        }

        public bool ShouldSerializeValue() {
            return !string.IsNullOrEmpty(Value);
        }
    }
#pragma warning restore IDE1006
}