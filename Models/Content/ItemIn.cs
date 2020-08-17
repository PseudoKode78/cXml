using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ItemIn")]
    public class ItemIn {
        [XmlAttribute("quantity")]
        public int quantity { get; set; }

        [XmlAttribute("openQuantity")]
        public int openQuantity { get; set; }

        [XmlAttribute("promisedQuantity")]
        public int promisedQuantity { get; set; }

        [XmlAttribute("lineNumber")]
        public int lineNumber { get; set; }

        [XmlAttribute("parentLineNumber")]
        public int parentLineNumber { get; set; }

        [XmlAttribute("itemType")]
        public string itemType { get; set; }

        [XmlAttribute("compositeItemType")]
        public string compositeItemType { get; set; }

        [XmlAttribute("itemClassification")]
        public string itemClassification { get; set; }

        [XmlAttribute("itemCategory")]
        public string itemCategory { get; set; }

        [XmlElement("ItemID")]
        public ItemID ItemID { get; set; }

        [XmlElement("ItemDetail")]
        public ItemDetail ItemDetail { get; set; }

        public bool ShouldSerializeopenQuantity() {
            return openQuantity > 0;
        }

        public bool ShouldSerializepromisedQuantity() {
            return promisedQuantity > 0;
        }

        public bool ShouldSerializelineNumber() {
            return lineNumber > 0;
        }

        public bool ShouldSerializeparentLineNumber() {
            return parentLineNumber > 0;
        }

        public bool ShouldSerializeitemType() {
            return !string.IsNullOrEmpty(itemType);
        }

        public bool ShouldSerializecompositeItemType() {
            return !string.IsNullOrEmpty(compositeItemType);
        }

        public bool ShouldSerializeitemClassification() {
            return !string.IsNullOrEmpty(itemClassification);
        }

        public bool ShouldSerializeitemCategory() {
            return !string.IsNullOrEmpty(itemCategory);
        }
    }
#pragma warning restore IDE1006
}