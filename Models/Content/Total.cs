using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Total")]
    public class Total {
        public Total() {
            Money = new Money();
        }

        public Total(string currency, decimal value) {
            Money = new Money(currency, value);
        }

        [XmlElement("Money")]
        public Money Money { get; set; }
    }
#pragma warning restore IDE1006
}