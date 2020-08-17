using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("SupplierSetup")]
    public class SupplierSetup {
        public SupplierSetup() { }

        public SupplierSetup(string name, string value) {
            URL = new URL(name, value);
        }

        [XmlElement("URL")]
        public URL URL { get; set; }
    }
#pragma warning restore IDE1006
}