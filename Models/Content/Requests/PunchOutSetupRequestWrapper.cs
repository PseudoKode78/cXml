using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Request")]
    public class PunchOutSetupRequestWrapper : Request {
        [XmlElement("PunchOutSetupRequest")]
        public PunchOutSetupRequestBody PunchOutSetupRequest { get; set; }
    }
#pragma warning restore IDE1006
}