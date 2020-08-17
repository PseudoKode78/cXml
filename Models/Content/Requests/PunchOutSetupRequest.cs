using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("cXML")]
    public class PunchOutSetupRequest : cXml {
        [XmlElement("Request")]
        public PunchOutSetupRequestWrapper Request { get; set; }
    }
#pragma warning restore IDE1006
}