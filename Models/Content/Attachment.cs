using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Attachment")]
    public class Attachment {
        [XmlAttribute("visibility")]
        public string visibility { get; set; }

        [XmlElement("Url")]
        public URL URL { get; set; }
    }
#pragma warning restore IDE1006
}