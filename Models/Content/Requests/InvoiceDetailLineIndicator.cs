using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailLineIndicator")]
    public class InvoiceDetailLineIndicator {
        [XmlAttribute("isAccountingInLine")]
        public string isAccountingInLine { get; set; }

        [XmlAttribute("isTaxInLine")]
        public string isTaxInLine { get; set; }
    }
#pragma warning restore IDE1006
}