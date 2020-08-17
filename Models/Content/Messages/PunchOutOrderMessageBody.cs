using System.Xml.Serialization;

namespace CXML.Models.Content.Messages {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("PunchOutOrderMessage")]
    public class PunchOutOrderMessageBody {
        [XmlElement("BuyerCookie")]
        public string BuyerCookie { get; set; }

        [XmlElement("PunchOutOrderMessageHeader")]
        public PunchOutOrderMessageHeader PunchOutOrderMessageHeader { get; set; }

        [XmlElement("ItemIn")]
        public ItemIn[] ItemIn { get; set; }

        public bool ShouldSerializeBuyerCookie() {
            return !string.IsNullOrEmpty(BuyerCookie);
        }
    }
#pragma warning restore IDE1006
}