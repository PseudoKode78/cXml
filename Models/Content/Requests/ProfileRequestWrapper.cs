using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Request")]
    public class ProfileRequestWrapper : Request {
        [XmlElement("ProfileRequest")]
        public ProfileRequestBody ProfileRequest { get; set; }
    }
#pragma warning restore IDE1006
}