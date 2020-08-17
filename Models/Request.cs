using System.Xml.Serialization;

namespace CXML.Models {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Request")]
    public class Request : Body {
        [XmlAttribute("deploymentMode")]
        public string deploymentMode { get; set; }

        public bool ShouldSerializedeploymentMode() {
            return !string.IsNullOrEmpty(deploymentMode);
        }
    }
#pragma warning restore IDE1006
}