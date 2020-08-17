using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("PunchOutSetupRequest")]
    public class PunchOutSetupRequestBody {
        [XmlAttribute("operation")]
        public PunchOutSetupRequestOperationEnum operation { get; set; }

        [XmlElement("BuyerCookie")]
        public string BuyerCookie { get; set; }

        [XmlArray("Extrinsic")]
        public Extrinsic[] Extrinsic { get; set; }

        [XmlElement("BrowserFormPost")]
        public BrowserFormPost BrowserFormPost { get; set; }

        [XmlElement("SupplierSetup")]
        public SupplierSetup SupplierSetup { get; set; }

        [XmlElement("ShipTo")]
        public ShipTo ShipTo { get; set; }

        public bool ShouldSerializeBuyerCookie() {
            return !string.IsNullOrEmpty(BuyerCookie);
        }

        public bool ShouldSerializeExtrinsic() {
            return (Extrinsic?.Length ?? 0) > 0;
        }
    }
#pragma warning restore IDE1006
}