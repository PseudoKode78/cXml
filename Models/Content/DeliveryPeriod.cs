﻿using System.Xml.Serialization;

namespace CXML.Models.Content {
#pragma warning disable IDE1006 // Ignore Naming Rule Violations for cXml
    [XmlRoot("DeliveryPeriod")]
    public class DeliveryPeriod {
        // TODO: Complete DeliveryPeriod Element
        [XmlText]
        public string Value { get; set; }
    }
#pragma warning restore IDE1006
}