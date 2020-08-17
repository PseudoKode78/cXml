using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("DocumentReference")]
    public class DocumentReference {
        [XmlAttribute("payloadID")]
        public string payloadID { get; set; }
    }
#pragma warning restore IDE1006
}