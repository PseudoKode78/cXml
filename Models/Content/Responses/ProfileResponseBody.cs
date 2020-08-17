using System;
using System.Xml.Serialization;

namespace CXML.Models.Content.Responses {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("ProfileResponse")]
    public class ProfileResponseBody {
        public ProfileResponseBody() { }

        public ProfileResponseBody(DateTime effectiveDate) {
            this.effectiveDate = effectiveDate;
            lastRefresh        = DateTime.Now;
        }

        [XmlIgnore]
        public DateTime effectiveDate { get; set; }

        [XmlAttribute("effectiveDate")]
        public string effectiveDateString {
            get => effectiveDate.ToString("o");
            set => effectiveDate = DateTime.Parse(value);
        }

        [XmlIgnore]
        public DateTime lastRefresh { get; set; }

        [XmlAttribute("lastRefresh")]
        public string lastRefreshString {
            get => lastRefresh.ToString("o");
            set => lastRefresh = DateTime.Parse(value);
        }

        [XmlElement("Option", IsNullable = true)]
        public Option[] Option { get; set; }

        [XmlElement("Transaction", IsNullable = true)]
        public Transaction[] Transaction { get; set; }

        public bool ShouldSerializelastRefreshString() {
            return lastRefresh != null;
        }

        public bool ShouldSerializeOption() {
            return ((Option?.Length ?? 0) > 0);
        }

        public bool ShouldSerializeTransaction() {
            return ((Transaction?.Length ?? 0) > 0);
        }
    }
#pragma warning restore IDE1006
}