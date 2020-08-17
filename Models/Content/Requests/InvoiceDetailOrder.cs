using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailOrder")]
    public class InvoiceDetailOrder {
        [XmlElement("InvoiceDetailOrderInfo")]
        public InvoiceDetailOrderInfo InvoiceDetailOrderInfo { get; set; }

        [XmlElement("InvoiceDetailItem")]
        public InvoiceDetailItem[] InvoiceDetailItem { get; set; }

        public bool ShouldSerializeInvoiceDetailOrderInfo() {
            return InvoiceDetailOrderInfo != null &&
                   (InvoiceDetailOrderInfo.MasterAgreementReference != null ||
                    InvoiceDetailOrderInfo.OrderReference           != null ||
                    InvoiceDetailOrderInfo.SupplierOrderInfo        != null);
        }
    }
#pragma warning restore IDE1006
}