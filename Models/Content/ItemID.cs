using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ItemID")]
    public class ItemID {
        [XmlElement("SupplierPartID")]
        public string SupplierPartID { get; set; }

        [XmlElement("SupplierPartAuxiliaryID")]
        public string SupplierPartAuxiliaryID { get; set; }
    }
#pragma warning restore IDE1006
}