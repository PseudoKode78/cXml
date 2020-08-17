using System;
using System.Diagnostics;

namespace CXML.Helpers {
    public static class CxmlHelper {
        public static string GeneratePayloadID(DateTime timeStamp, string hostName) {
            var dateTime  = timeStamp;
            var ticks     = dateTime.Ticks.ToString("0000000");
            var processID = Process.GetCurrentProcess().Id.ToString("0000");
            var random    = new Random(dateTime.Millisecond).Next(1, 9999).ToString("0000");
            var hostname  = hostName;

            return $"{ticks}.{processID}.{random}@{hostname}";
        }
    }
}