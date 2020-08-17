using System.Xml.Serialization;
using CXML.Models.Head;

namespace CXML.Models {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Header")]
    public class Header {
        public Header() {
            From   = new From();
            To     = new To();
            Sender = new Sender();
        }

        [XmlElement("From")]
        public From From { get; set; }

        [XmlElement("To")]
        public To To { get; set; }

        [XmlElement("Sender")]
        public Sender Sender { get; set; }
    }
#pragma warning restore IDE1006
}