using System.Xml.Serialization;

namespace CXML.Models.Content.Messages {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Message")]
    public class PunchOutOrderMessageWrapper : Message {
        [XmlElement("PunchOutOrderMessage")]
        public PunchOutOrderMessageBody PunchOutOrderMessage { get; set; }
    }
#pragma warning restore IDE1006
}