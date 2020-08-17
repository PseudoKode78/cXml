using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("DueAmount")]
    public class DueAmount {
        [XmlElement("Money")]
        public Money Money { get; set; }
    }
#pragma warning restore IDE1006
}