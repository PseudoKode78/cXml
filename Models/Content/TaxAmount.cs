using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("TaxAmount")]
    public class TaxAmount {
        [XmlElement("Money")]
        public Money Money { get; set; }
    }
#pragma warning restore IDE1006
}