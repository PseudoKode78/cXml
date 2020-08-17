using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CXML.Helpers {
    public static class SerializeHelper {
        public static string SerializeString<T>(ref T  obj, out bool success, string xmlHeader = "",
                                                string cXmlVersion = "") {
            success = false;
            var result                                         = "";
            if (string.IsNullOrEmpty(cXmlVersion)) cXmlVersion = "http://xml.cxml.org/schemas/cXML/1.2.044/cXML.dtd";

            try {
                var xmlSerializer = new XmlSerializer(typeof(T));

                var settings = new XmlWriterSettings {
                                                         OmitXmlDeclaration = false,
                                                         Encoding           = Encoding.UTF8,
                                                         ConformanceLevel   = ConformanceLevel.Document
                                                     };

                using (var sw = new StringWriter()) {
                    using (var xw = new XmlTextWriter(sw)) {
                        var xns = new XmlSerializerNamespaces();
                        xns.Add(string.Empty, string.Empty);
                        xw.Formatting = Formatting.Indented;
                        xw.WriteDocType("cXML", null, cXmlVersion, null);
                        xmlSerializer.Serialize(xw, obj, xns);
                        success = true;
                    }

                    result = sw.ToString();
                }
            } catch (Exception ex) {
                throw ex;
            }

            if (!string.IsNullOrEmpty(xmlHeader)) return xmlHeader + "\r\n" + result;

            return result;
        }

        public static string SerializeUrlEncodedString<T>(ref T obj, out bool success) {
            success = false;
            var result = "";
            try {
                var xmlSerializer = new XmlSerializer(typeof(T));

                var settings = new XmlWriterSettings {
                                                         OmitXmlDeclaration = false,
                                                         Encoding           = Encoding.UTF8,
                                                         ConformanceLevel   = ConformanceLevel.Document
                                                     };

                using (var sw = new StringWriter()) {
                    using (var xw = new XmlTextWriter(sw)) {
                        var xns = new XmlSerializerNamespaces();
                        xns.Add(string.Empty, string.Empty);
                        xw.Formatting = Formatting.Indented;
                        xw.WriteDocType("cXML", null, "http://xml.cxml.org/schemas/cXML/1.2.014/cXML.dtd", null);
                        xmlSerializer.Serialize(xw, obj, xns);
                        success = true;
                    }

                    result = sw.ToString();
                }
            } catch (Exception ex) {
                throw ex;
            }

            return result;
        }

        public static bool DeserializeString<T>(ref string text, out T obj) {
            obj = default;
            var success = false;
            try {
                using (TextReader sr = new StringReader(text)) {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    obj     = (T) xmlSerializer.Deserialize(sr);
                    success = true;
                }
            } catch (Exception ex) {
                throw ex;
            }

            return success;
        }
    }
}