using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailShipping")]
    public class InvoiceDetailShipping {
        [XmlElement("Contact")]
        public Contact[] Contact { get; set; }
    }
#pragma warning restore IDE1006
}