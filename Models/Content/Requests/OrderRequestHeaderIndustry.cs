using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("OrderRequestHeaderIndustry")]
    public class OrderRequestHeaderIndustry {
        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}