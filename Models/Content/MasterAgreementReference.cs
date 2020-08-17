using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("MasterAgreementReference")]
    public class MasterAgreementReference {
        [XmlElement("DocumentReference")]
        public DocumentReference DocumentReference { get; set; }
    }
#pragma warning restore IDE1006
}