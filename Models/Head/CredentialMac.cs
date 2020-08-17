using System;
using System.Xml.Serialization;

namespace CXML.Models.Head {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("CredentalMac")]
    public class CredentialMac {
        [XmlAttribute("type")]
        public string type { get; set; }


        [XmlAttribute("algorithm")]
        public string alogrithm { get; set; }

        [XmlIgnore]
        public DateTime creationDate { get; set; }

        [XmlAttribute("creationDate")]
        public string creationDateString {
            get => creationDate.ToString("o");
            set => creationDate = DateTime.Parse(value);
        }

        [XmlIgnore]
        public DateTime expirationDate { get; set; }

        [XmlAttribute("expirationDate")]
        public string expirationDateString {
            get => expirationDate.ToString("o");
            set => expirationDate = DateTime.Parse(value);
        }

        [XmlText]
        public string Value { get; set; }

        public bool ShouldSerializetype() {
            return type != "";
        }
    }
#pragma warning restore IDE1006
}