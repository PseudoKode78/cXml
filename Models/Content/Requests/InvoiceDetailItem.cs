using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailItem")]
    public class InvoiceDetailItem {
        [XmlAttribute("quantity")]
        public int quantity { get; set; }

        [XmlAttribute("invoiceLineNumber")]
        public int invoiceLineNumber { get; set; }

        [XmlElement("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }

        [XmlElement("UnitPrice")]
        public UnitPrice UnitPrice { get; set; }

        [XmlElement("InvoiceDetailItemReference")]
        public InvoiceDetailItemReference InvoiceDetailItemReference { get; set; }

        [XmlElement("SubtotalAmount")]
        public SubtotalAmount SubtotalAmount { get; set; }

        [XmlElement("Tax")]
        public Tax Tax { get; set; }
    }
#pragma warning restore IDE1006
}