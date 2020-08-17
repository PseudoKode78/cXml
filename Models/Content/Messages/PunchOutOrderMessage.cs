using System.Xml.Serialization;

namespace CXML.Models.Content.Messages {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("cXML")]
    public class PunchOutOrderMessage : cXml {
        [XmlElement("Message")]
        public PunchOutOrderMessageWrapper Message { get; set; }
    }
#pragma warning restore IDE1006
}