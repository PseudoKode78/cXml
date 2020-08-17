using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Tax")]
    public class Tax {
        public Tax() {
            Money       = new Money();
            Description = new Description();
        }

        public Tax(string currency, decimal value, string description, string lang = null) {
            Money       = new Money(currency, value);
            Description = new Description(description, lang);
        }

        [XmlElement("Money")]
        public Money Money { get; set; }

        [XmlElement("Description")]
        public Description Description { get; set; }

        [XmlElement("TaxDetail")]
        public TaxDetail TaxDetail { get; set; }

        public bool ShouldSerializeTaxDetail() {
            return TaxDetail != null;
        }
    }
#pragma warning restore IDE1006
}