using System;
using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailRequestHeader")]
    public class InvoiceDetailRequestHeader {
        [XmlIgnore]
        public DateTime invoiceDate { get; set; }

        [XmlAttribute("invoiceDate")]
        public string invoiceDateString {
            get => invoiceDate.ToString("o");
            set => invoiceDate = DateTime.Parse(value);
        }

        [XmlAttribute("operation")]
        public string operation { get; set; }

        [XmlAttribute("purpose")]
        public string purpose { get; set; }

        [XmlAttribute("invoiceOrigin")]
        public string invoiceOrigin { get; set; }

        [XmlAttribute("invoiceID")]
        public string invoiceID { get; set; }

        [XmlElement("InvoiceDetailHeaderIndicator", IsNullable = false)]
        public InvoiceDetailHeaderIndicator InvoiceDetailHeaderIndicator { get; set; }

        [XmlElement("InvoiceDetailLineIndicator", IsNullable = false)]
        public InvoiceDetailLineIndicator InvoiceDetailLineIndicator { get; set; }

        [XmlElement("InvoicePartner")]
        public InvoicePartner[] InvoicePartner { get; set; }

        [XmlElement("InvoiceDetailShipping", IsNullable = true)]
        public InvoiceDetailShipping InvoiceDetailShipping { get; set; }

        [XmlElement("PaymentTerm")]
        public PaymentTerm PaymentTerm { get; set; }

        [XmlElement("Comments")]
        public Comments[] Comments { get; set; }


        [XmlElement("Extrinsic", IsNullable = true)]
        public Extrinsic[] Extrinsic { get; set; }

        public bool ShouldSerializeInvoiceDetailShipping() {
            return InvoiceDetailShipping != null;
        }

        public bool ShouldSerializeExtrinsic() {
            return Extrinsic != null;
        }
    }
#pragma warning restore IDE1006
}