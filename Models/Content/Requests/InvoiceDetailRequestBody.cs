using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailRequest")]
    public class InvoiceDetailRequestBody {
        [XmlElement("InvoiceDetailRequestHeader")]
        public InvoiceDetailRequestHeader InvoiceDetailRequestHeader { get; set; }

        [XmlElement("InvoiceDetailOrder")]
        public InvoiceDetailOrder InvoiceDetailOrder { get; set; }

        [XmlElement("InvoiceDetailSummary")]
        public InvoiceDetailSummary InvoiceDetailSummary { get; set; }

        public bool ShouldSerializeInvoiceDetailOrder() {
            return InvoiceDetailOrder != null;
        }
    }
#pragma warning restore IDE1006
}