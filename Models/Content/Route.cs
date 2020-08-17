using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Route")]
    public class Route {
        [XmlAttribute("method")]
        public string method { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}