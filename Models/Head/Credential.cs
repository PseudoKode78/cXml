using System.Xml.Serialization;

namespace CXML.Models.Head {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("Credential")]
    public class Credential {
        public Credential() {
            CredentialMac = null;
        }

        public Credential(string domain, string identity, string sharedSecret = "", string userAgent = "",
                          string type = "") {
            this.domain  = domain;
            Identity     = new Identity(identity);
            SharedSecret = sharedSecret;
            UserAgent    = userAgent;
            this.type    = type;
        }

        [XmlAttribute("domain")]
        public string domain { get; set; }

        [XmlAttribute("type")]
        public string type { get; set; }

        [XmlElement("Identity", IsNullable = true)]
        public Identity Identity { get; set; }

        [XmlElement("SharedSecret", IsNullable = true)]
        public string SharedSecret { get; set; }

        [XmlElement("CredentialMac", IsNullable = true)]
        public CredentialMac CredentialMac { get; set; }

        [XmlElement("UserAgent", IsNullable = true)]
        public string UserAgent { get; set; }

        public bool ShouldSerializetype() {
            return !string.IsNullOrEmpty(type);
        }

        public bool ShouldSerializeIdentity() {
            return Identity != null;
        }

        public bool ShouldSerializeSharedSecret() {
            return !string.IsNullOrEmpty(SharedSecret);
        }

        public bool ShouldSerializeCredentialMac() {
            return !string.IsNullOrEmpty(CredentialMac?.Value);
        }

        public bool ShouldSerializeUserAgent() {
            return !string.IsNullOrEmpty(UserAgent);
        }

        public override string ToString() {
            return
                $"[Credential] Domain:{domain} Identity:{Identity} SharedSecret:{SharedSecret} CredentialMac:{CredentialMac} UserAgent:{UserAgent}";
        }
    }
#pragma warning restore IDE1006
}