using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Comments")]
    public class Comments {
        [XmlElement("Attachment")]
        public Attachment[] Attachment { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}