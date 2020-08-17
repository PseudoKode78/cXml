using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("InvoiceDetailItemReference")]
    public class InvoiceDetailItemReference {
        [XmlAttribute("lineNumber")]
        public int lineNumber { get; set; }

        [XmlElement("ItemID")]
        public ItemID ItemID { get; set; }

        [XmlElement("Description")]
        public Description Description { get; set; }
    }
#pragma warning restore IDE1006
}