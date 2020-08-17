using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Money")]
    public class Money {
        public Money() {
            currency = "GBP";
            Value    = 0.0m;
        }

        public Money(string currency, decimal value) {
            this.currency = currency;
            Value         = value;
        }

        [XmlAttribute("alternateAmount")]
        public decimal alternateAmount { get; set; }

        [XmlAttribute("alternateCurrency")]
        public string alternateCurrency { get; set; }

        [XmlAttribute("currency")]
        public string currency { get; set; }

        [XmlText]
        public decimal Value { get; set; }

        public bool ShouldSerializealternateAmount() {
            return !string.IsNullOrEmpty(alternateCurrency) && alternateAmount != 0.0m;
        }

        public bool ShouldSerializealternateCurrency() {
            return !string.IsNullOrEmpty(alternateCurrency) && alternateAmount != 0.0m;
        }
    }
#pragma warning restore IDE1006
}