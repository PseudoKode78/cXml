using System;
using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("OrderRequestHeader")]
    public class OrderRequestHeader {
        [XmlAttribute("orderID")]
        public string orderID { get; set; }

        [XmlIgnore]
        public DateTime orderDate { get; set; }

        [XmlAttribute("orderDate")]
        public string orderDateString {
            get => orderDate.ToString("o");
            set {
                var tempDate             = new DateTime();
                var tryResult            = DateTime.TryParse(value, out tempDate);
                if (tryResult) orderDate = tempDate;
            }
        }

        [XmlAttribute("orderType")]
        public string orderType { get; set; }

        [XmlAttribute("releaseRequired")]
        public string releaseRequired { get; set; }

        [XmlAttribute("type")]
        public string type { get; set; }

        [XmlAttribute("orderVersion")]
        public string orderVersion { get; set; }

        [XmlAttribute("isInternalVersion")]
        public string isInternalVersion { get; set; }

        [XmlAttribute("agreementID")]
        public string agreementID { get; set; }

        [XmlAttribute("agreementPayloadID")]
        public string agreementPayloadID { get; set; }

        [XmlAttribute("parentAgreementID")]
        public string parentAgreementID { get; set; }

        [XmlAttribute("parentAgreementPayloadID")]
        public string parentAgreementPayloadID { get; set; }

        [XmlIgnore]
        public DateTime? effectiveDate { get; set; }

        [XmlAttribute("effectiveDate")]
        public string effectiveDateString {
            get => effectiveDate?.ToString("o") ?? "";
            set => effectiveDate = DateTime.Parse(value);
        }

        [XmlIgnore]
        public DateTime? expirationDate { get; set; }

        [XmlAttribute("expirationDate")]
        public string expirationDateString {
            get => expirationDate?.ToString("o") ?? "";
            set => expirationDate = DateTime.Parse(value);
        }

        [XmlAttribute("requisitionID")]
        public string requisitionID { get; set; }

        [XmlAttribute("shipComplete")]
        public string shipComplete { get; set; }

        [XmlIgnore]
        public DateTime? pickUpDate { get; set; }

        [XmlAttribute("pickUpDate")]
        public string pickUpDateString {
            get => pickUpDate?.ToString("o") ?? "";
            set => pickUpDate = DateTime.Parse(value);
        }

        [XmlIgnore]
        public DateTime? requestedDeliveryDate { get; set; }

        [XmlAttribute("requestedDeliveryDate")]
        public string requestedDeliveryDateString {
            get => requestedDeliveryDate?.ToString("o") ?? "";
            set => requestedDeliveryDate = DateTime.Parse(value);
        }

        [XmlElement("Total")]
        public Total Total { get; set; }

        [XmlElement("ShipTo")]
        public ShipTo ShipTo { get; set; }

        [XmlElement("BillTo")]
        public BillTo BillTo { get; set; }

        [XmlElement("LegalEntity", IsNullable = true)]
        public LegalEntity LegalEntity { get; set; }

        [XmlElement("OrganizationUnit", IsNullable = true)]
        public OrganizationUnit OrganizationUnit { get; set; }

        [XmlElement("Shipping", IsNullable = true)]
        public Shipping Shipping { get; set; }

        [XmlElement("Tax", IsNullable = true)]
        public Tax Tax { get; set; }

        [XmlElement("Payment", IsNullable = true)]
        public Payment Payment { get; set; }

        [XmlElement("PaymentTerm", IsNullable = true)]
        public Payment PaymentTerm { get; set; }

        [XmlElement("Contact", IsNullable = true)]
        public Contact[] Contact { get; set; }

        [XmlElement("Comments", IsNullable = true)]
        public Comments Comments { get; set; }

        [XmlElement("Followup", IsNullable = true)]
        public Followup Followup { get; set; }

        [XmlElement("ControlKeys", IsNullable = true)]
        public ControlKeys ControlKeys { get; set; }

        [XmlElement("DocumentReference", IsNullable = true)]
        public DocumentReference DocumentReference { get; set; }

        [XmlElement("SupplierOrderInfo", IsNullable = true)]
        public SupplierOrderInfo SupplierOrderInfo { get; set; }

        [XmlElement("TermsOfDelivery", IsNullable = true)]
        public TermsOfDelivery TermsOfDelivery { get; set; }

        [XmlElement("DeliveryPeriod", IsNullable = true)]
        public DeliveryPeriod Period { get; set; }

        [XmlElement("IdReference", IsNullable = true)]
        public IdReference IdReference { get; set; }

        [XmlElement("OrderRequestHeaderIndustry", IsNullable = true)]
        public OrderRequestHeaderIndustry OrderRequestHeaderIndustry { get; set; }

        [XmlElement("Extrinsic", IsNullable = true)]
        public Extrinsic[] Extrinsic { get; set; }
    }
#pragma warning restore IDE1006
}