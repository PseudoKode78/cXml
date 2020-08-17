using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("PostalAddress")]
    public class PostalAddress {
        public PostalAddress() { }

        public PostalAddress(string deliverTo, string street, string city, string state, string postalCode,
                             string country) {
            if (!string.IsNullOrEmpty(deliverTo)) DeliverTo = deliverTo.Split(',');
            if (!string.IsNullOrEmpty(street)) Street       = street.Split(',');
            City       = city;
            State      = state;
            PostalCode = postalCode;
            Country    = new Country(country);
        }

        [XmlAttribute("name")]
        public string name { get; set; }

        [XmlElement("DeliverTo", IsNullable = true)]
        public string[] DeliverTo { get; set; }

        [XmlElement("Street")]
        public string[] Street { get; set; }

        [XmlElement("City")]
        public string City { get; set; }

        [XmlElement("State", IsNullable = true)]
        public string State { get; set; }

        [XmlElement("PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement("Country")]
        public Country Country { get; set; }

        public bool ShouldSerializeDeliverTo() {
            return DeliverTo != null;
        }

        public bool ShouldSerializeState() {
            return !string.IsNullOrEmpty(State);
        }
    }
#pragma warning restore IDE1006
}