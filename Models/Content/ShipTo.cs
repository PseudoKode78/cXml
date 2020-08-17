using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ShipTo")]
    public class ShipTo {
        public ShipTo() {
            Address = new Address();
        }

        public ShipTo(string addressID,  string name, string deliverTo, string street, string city, string state,
                      string postalCode, string country) {
            Address = new Address(addressID, name, deliverTo, street, city, state, postalCode, country);
        }

        [XmlElement("Address")]
        public Address Address { get; set; }

        [XmlElement("CarrierIdentifier", IsNullable = true)]
        public CarrierIdentifier CarrierIdentifier { get; set; }
    }
#pragma warning restore IDE1006
}