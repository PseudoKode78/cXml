using System.Xml.Serialization;

namespace CXML.Models.Content.Responses {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("PunchOutSetupResponse")]
    public class PunchOutSetupResponseBody {
        [XmlElement("StartPage")]
        public StartPage StartPage { get; set; }
    }
#pragma warning restore IDE1006
}