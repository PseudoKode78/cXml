using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("BrowserFormPost")]
    public class BrowserFormPost {
        public BrowserFormPost() {
            URL = new URL();
        }

        public BrowserFormPost(string name, string value) {
            URL = new URL(name, value);
        }

        [XmlElement("URL")]
        public URL URL { get; set; }
    }
#pragma warning restore IDE1006
}