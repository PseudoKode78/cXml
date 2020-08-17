using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailSummary")]
    public class InvoiceDetailSummary {
        [XmlElement("SubtotalAmount")]
        public SubtotalAmount SubtotalAmount { get; set; }

        [XmlElement("Tax")]
        public Tax Tax { get; set; }

        [XmlElement("GrossAmount", IsNullable = true)]
        public GrossAmount GrossAmount { get; set; }

        [XmlElement("NetAmount")]
        public NetAmount NetAmount { get; set; }

        [XmlElement("DueAmount", IsNullable = true)]
        public DueAmount DueAmount { get; set; }

        public bool ShouldSerializeGrossAmount() {
            return GrossAmount != null;
        }

        public bool ShouldSerializeDueAmount() {
            return DueAmount != null;
        }
    }
#pragma warning restore IDE1006
}