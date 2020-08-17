using System.Xml.Serialization;

namespace CXML.Models.Content.Responses {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("cXML")]
    public class ProfileResponse : cXml {
        [XmlElement("Response")]
        public ProfileResponseWrapper Response { get; set; }
    }
#pragma warning restore IDE1006
}