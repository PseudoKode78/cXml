using System.Xml.Serialization;

namespace CXML.Models.Content.Responses {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Response")]
    public class PunchOutSetupResponseWrapper : Response {
        [XmlElement("PunchOutSetupResponse")]
        public PunchOutSetupResponseBody PunchOutSetupResponse { get; set; }
    }
#pragma warning restore IDE1006
}