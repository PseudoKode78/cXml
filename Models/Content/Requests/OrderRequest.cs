using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("cXML")]
    public class OrderRequest : cXml {
        [XmlElement("Request")]
        public OrderRequestWrapper Request { get; set; }
    }
#pragma warning restore IDE1006
}