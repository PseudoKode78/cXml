using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Address")]
    public class Address {
        public Address() {
            addressID     = "";
            Name          = new Name();
            PostalAddress = new PostalAddress();
        }

        public Address(string addressID,  string name, string deliverTo, string street, string city, string state,
                       string postalCode, string country) {
            this.addressID = addressID;
            Name           = new Name(name);
            PostalAddress  = new PostalAddress(deliverTo, street, city, state, postalCode, country);
        }

        [XmlAttribute("isoCountryCode")]
        public string isoCountryCode { get; set; }

        [XmlAttribute("addressID")]
        public string addressID { get; set; }

        [XmlAttribute("addressIDDomain")]
        public string addressIDDomain { get; set; }

        [XmlElement("Name")]
        public Name Name { get; set; }

        [XmlElement("PostalAddress")]
        public PostalAddress PostalAddress { get; set; }

        [XmlElement("Email", IsNullable = true)]
        public Email Email { get; set; }

        public bool ShouldSerializeisoCountryCode() {
            return !string.IsNullOrEmpty(isoCountryCode);
        }

        public bool ShouldSerializeaddressIDDomain() {
            return !string.IsNullOrEmpty(addressIDDomain);
        }
    }
#pragma warning restore IDE1006
}