using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("SupplierOrderInfo")]
    public class SupplierOrderInfo {
        [XmlAttribute("orderID")]
        public string orderID { get; set; }
    }
#pragma warning restore IDE1006
}