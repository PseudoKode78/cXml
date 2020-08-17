using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoicePartner")]
    public class InvoicePartner {
        [XmlElement("Contact")]
        public Contact Contact { get; set; }

        [XmlElement("IdReference")]
        public IdReference[] IdReference { get; set; }
    }
#pragma warning restore IDE1006
}