using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("TaxDetail")]
    public class TaxDetail {
        [XmlAttribute("purpose")]
        public string purpose { get; set; }

        [XmlAttribute("category")]
        public string category { get; set; }

        [XmlAttribute("percentageRate")]
        public string percentageRate { get; set; }

        [XmlElement("TaxableAmount")]
        public TaxableAmount TaxableAmount { get; set; }

        [XmlElement("TaxAmount")]
        public TaxAmount TaxAmount { get; set; }
    }
#pragma warning restore IDE1006
}