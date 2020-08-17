using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("OrderRequest")]
    public class OrderRequestBody {
        [XmlElement("OrderRequestHeader")]
        public OrderRequestHeader OrderRequestHeader { get; set; }

        [XmlElement("ItemOut")]
        public ItemOut[] ItemOut { get; set; }
    }
#pragma warning restore IDE1006
}