using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Status")]
    public class Status {
        public Status() {
            code = "500";
            text = "Internal Server Error";
        }

        public Status(string code, string text) {
            this.code = code;
            this.text = text;
        }

        [XmlAttribute("code")]
        public string code { get; set; }

        [XmlAttribute("text")]
        public string text { get; set; }
    }
#pragma warning restore IDE1006
}