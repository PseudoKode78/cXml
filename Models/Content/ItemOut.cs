using System;
using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ItemOut")]
    public class ItemOut {
        [XmlAttribute("quantity")]
        public int quantity { get; set; }

        [XmlIgnore]
        public int lineNumber { get; set; }

        [XmlAttribute("lineNumber")]
        public string lineNumberString {
            get => lineNumber.ToString();
            set {
                if (!string.IsNullOrEmpty(value)) lineNumber = int.Parse(value);
            }
        }

        [XmlAttribute("requisitionID")]
        public string requisitionID { get; set; }

        [XmlAttribute("agreementItemNumber")]
        public string agreementItemNumber { get; set; }

        [XmlIgnore]
        public DateTime requestedDeliveryDate { get; set; }

        [XmlAttribute("requestedDeliveryDate")]
        public string requestedDeliveryDateString {
            get => requestedDeliveryDate.ToString("o");
            set => requestedDeliveryDate = DateTime.Parse(value);
        }

        [XmlAttribute("isAdHoc")]
        public string isAdHoc { get; set; }

        [XmlAttribute("parentLineNumber")]
        public int parentLineNumber { get; set; }

        [XmlAttribute("itemType")]
        public string itemType { get; set; }

        [XmlAttribute("requiresServiceEntry")]
        public string requiresServiceEntry { get; set; }

        [XmlIgnore]
        public DateTime confirmationDueDate { get; set; }

        [XmlAttribute("confirmationDueDate")]
        public string confirmationDueDateString {
            get => confirmationDueDate.ToString("o");
            set => confirmationDueDate = DateTime.Parse(value);
        }

        [XmlAttribute("compositeItemType")]
        public string compositeItemType { get; set; }


        [XmlAttribute("itemClassification")]
        public string itemClassification { get; set; }

        [XmlAttribute("itemCategory")]
        public string itemCategory { get; set; }

        [XmlAttribute("subcontractingType")]
        public string subcontractingType { get; set; }

        [XmlIgnore]
        public DateTime requestedShipmentDate { get; set; }

        [XmlAttribute("requestedShipmentDate")]
        public string requestedShipmentDateString {
            get => requestedShipmentDate.ToString("o");
            set => requestedShipmentDate = DateTime.Parse(value);
        }

        [XmlAttribute("isReturn")]
        public string isReturn { get; set; }

        [XmlAttribute("returnAuthorizationNumber")]
        public string returnAuthorizationNumber { get; set; }

        [XmlAttribute("isDeliveryCompleted")]
        public string isDeliveryCompleted { get; set; }

        [XmlElement("ItemID")]
        public ItemID ItemID { get; set; }

        [XmlElement("ItemDetail")]
        public ItemDetail ItemDetail { get; set; }

        public bool ShouldSerializelineNumber() {
            return lineNumber > 0;
        }

        public bool ShouldSerializeparentLineNumber() {
            return parentLineNumber > 0;
        }
    }
#pragma warning restore IDE1006
}