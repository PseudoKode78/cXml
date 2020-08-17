using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("CarrierIdentifier")]
    public class CarrierIdentifier {
        [XmlAttribute("domain")]
        public string domain { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}