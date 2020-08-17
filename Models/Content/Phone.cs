using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Phone")]
    public class Phone {
        [XmlElement("TelephoneNumber")]
        public TelephoneNumber TelephoneNumber { get; set; }
    }
#pragma warning restore IDE1006
}