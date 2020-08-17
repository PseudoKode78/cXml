using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("PaymentTerm")]
    public class PaymentTerm {
        [XmlAttribute("payInNumberOfDays")]
        public int payInNumberOfDays { get; set; }
    }
#pragma warning restore IDE1006
}