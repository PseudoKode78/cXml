using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Followup")]
    public class Followup {
        // TODO: Complete Followup Element, should probably be ignored
        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}