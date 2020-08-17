using System.Xml.Serialization;

namespace CXML.Models.Content.Messages {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("PunchOutOrderMessageHeader")]
    public class PunchOutOrderMessageHeader {
        [XmlAttribute("operationAllowed")]
        public string operationAllowed { get; set; }

        [XmlAttribute("quoteStatus")]
        public string quoteStatus { get; set; }

        [XmlElement("Total")]
        public Total Total { get; set; }

        [XmlElement("Shipping")]
        public Shipping Shipping { get; set; }

        [XmlElement("Tax")]
        public Tax Tax { get; set; }

        public bool ShouldSerializeShipping() {
            return Shipping?.Money?.Value > 0;
        }

        public bool ShouldSerializeTax() {
            return Tax?.Money?.Value > 0;
        }
    }
#pragma warning restore IDE1006
}