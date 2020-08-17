using System.Xml.Serialization;

namespace CXML.Models.Head {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("To")]
    public class To {
        [XmlElement("Credential")]
        public Credential[] Credential { get; set; }
    }
#pragma warning restore IDE1006
}