using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailOrderInfo")]
    public class InvoiceDetailOrderInfo {
        [XmlElement("MasterAgreementReference")]
        public MasterAgreementReference MasterAgreementReference { get; set; }

        [XmlElement("OrderReference")]
        public OrderReference OrderReference { get; set; }

        [XmlElement("SupplierOrderInfo")]
        public SupplierOrderInfo SupplierOrderInfo { get; set; }

        public bool ShouldSerializeMasterAgreementReference() {
            return MasterAgreementReference != null;
        }

        public bool ShouldSerializeOrderReference() {
            return OrderReference != null;
        }

        public bool ShouldSerializeSupplierOrderInfo() {
            return SupplierOrderInfo != null;
        }
    }
#pragma warning restore IDE1006
}