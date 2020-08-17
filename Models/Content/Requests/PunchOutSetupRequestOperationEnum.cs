using System.Xml.Serialization;

namespace CXML.Models.Content.Requests {
    public enum PunchOutSetupRequestOperationEnum {
        [XmlEnum(Name = "create")]  Create  = 0,
        [XmlEnum(Name = "edit")]    Edit    = 1,
        [XmlEnum(Name = "inspect")] Inspect = 2,
        [XmlEnum(Name = "source")]  Source  = 3
    }
}