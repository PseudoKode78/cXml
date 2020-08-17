using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ShippingInstructions")]
    public class ShippingInstructions {
        [XmlElement("Description")]
        public string Description { get; set; }
    }
#pragma warning restore IDE1006
}