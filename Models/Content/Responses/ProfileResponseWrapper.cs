using System.Xml.Serialization;

namespace CXML.Models.Content.Responses {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Response")]
    public class ProfileResponseWrapper : Response {
        [XmlElement("ProfileResponse")]
        public ProfileResponseBody ProfileResponse { get; set; }
    }
#pragma warning restore IDE1006
}