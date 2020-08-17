using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("TelephoneNumber")]
    public class TelephoneNumber {
        [XmlElement("CountryCode")]
        public CountryCode CountryCode { get; set; }

        [XmlElement("AreaOrCityCode")]
        public string AreaOrCityCode { get; set; }

        [XmlElement("Number")]
        public string Number { get; set; }
    }
#pragma warning restore IDE1006
}