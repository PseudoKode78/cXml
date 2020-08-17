using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ItemDetail")]
    public class ItemDetail {
        [XmlElement("UnitPrice")]
        public UnitPrice UnitPrice { get; set; }

        [XmlElement("Description")]
        public Description Description { get; set; }

        [XmlElement("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }

        [XmlElement("Classification")]
        public Classification Classification { get; set; }

        [XmlElement("ManufacturerName")]
        public string ManufacturerName { get; set; }

        [XmlElement("LeadTime")]
        public int LeadTime { get; set; }

        public bool ShouldSerializeManufacturerName() {
            return !string.IsNullOrEmpty(ManufacturerName);
        }
    }
#pragma warning restore IDE1006
}