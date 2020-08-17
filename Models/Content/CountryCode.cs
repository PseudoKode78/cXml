using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("CountryCode")]
    public class CountryCode {
        public CountryCode() { }

        public CountryCode(string isoCountryCode) {
            this.isoCountryCode = isoCountryCode;
        }

        [XmlAttribute("isoCountryCode")]
        public string isoCountryCode { get; set; }
    }
#pragma warning restore IDE1006
}