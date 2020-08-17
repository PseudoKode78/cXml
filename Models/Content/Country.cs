using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Country")]
    public class Country {
        public Country() {
            isoCountryCode = "GB";
            Value          = "GB";
        }

        public Country(string countryCode) {
            isoCountryCode = countryCode;
            Value          = countryCode;
        }

        public Country(string countryCode, string value) {
            isoCountryCode = countryCode;
            Value          = value;
        }

        [XmlAttribute("isoCountryCode")]
        public string isoCountryCode { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}