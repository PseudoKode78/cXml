using System.Xml.Serialization;

namespace CXML.Models.Content.Responses {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("cXML")]
    public class PunchOutSetupResponse : cXml {
        [XmlElement("Response")]
        public PunchOutSetupResponseWrapper Response { get; set; }
    }
#pragma warning restore IDE1006
}