using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("IdReference")]
    public class IdReference {
        public IdReference() { }

        public IdReference(string domain, string identifier) {
            this.domain     = domain;
            this.identifier = identifier;
        }

        [XmlAttribute("domain")]
        public string domain { get; set; }

        [XmlAttribute("identifier")]
        public string identifier { get; set; }

        [XmlElement("Description", IsNullable = true)]
        public Description Description { get; set; }

        public bool ShouldSerializeDescription() {
            return Description != null;
        }
    }
#pragma warning restore IDE1006
}