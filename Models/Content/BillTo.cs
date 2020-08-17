using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("BillTo")]
    public class BillTo {
        public BillTo() {
            Address = new Address();
        }

        public BillTo(string addressID,  string name, string deliverTo, string street, string city, string state,
                      string postalCode, string country) {
            Address = new Address(addressID, name, deliverTo, street, city, state, postalCode, country);
        }

        [XmlElement("Address")]
        public Address Address { get; set; }
    }
#pragma warning restore IDE1006
}