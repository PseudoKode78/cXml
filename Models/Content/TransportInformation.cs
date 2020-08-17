using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("TransportInformation")]
    public class TransportInformation {
        [XmlElement("Route")]
        public Route Route { get; set; }

        [XmlElement("ShippingContractNumber")]
        public string ShippingContractNumber { get; set; }

        [XmlElement("ShippingInstructions")]
        public ShippingInstructions ShippingInstructions { get; set; }
    }
#pragma warning restore IDE1006
}