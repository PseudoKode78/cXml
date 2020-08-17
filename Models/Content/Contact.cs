using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Contact")]
    public class Contact {
        [XmlAttribute("role")]
        public string role { get; set; }

        [XmlAttribute("addressID")]
        public string addressID { get; set; }

        [XmlElement("Name")]
        public Name Name { get; set; }

        [XmlElement("PostalAddress")]
        public PostalAddress PostalAddress { get; set; }

        [XmlElement("Phone", IsNullable = true)]
        public Phone Phone { get; set; }

        public bool ShouldSerializePhone() {
            return Phone?.TelephoneNumber?.Number != null;
        }
    }
#pragma warning restore IDE1006
}