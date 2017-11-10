using System;
using System.Runtime.Serialization;

namespace Chatbase
{
    [DataContract]
    public class Event
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get; set; }

        [DataMember(Name = "user_id")]
        public string UserId { get; set; }

        [DataMember(Name = "intent")]
        public string Intent { get; set; }

        [DataMember(Name = "timestamp_millis")]
        public double TimestampMillis { get; set; }

        [DataMember(Name = "platform")]
        public string Platform { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "properties")]
        public EventProperty[] Properties { get; set; }

        public static double CurrentUnixMilliseconds()
        {
            return Math.Truncate(DateTime.UtcNow.Subtract(
                new DateTime(1970, 1, 1)).TotalMilliseconds);
        }

        public bool RequiredFields()
        {
            return !(
                String.IsNullOrEmpty(ApiKey)
                || String.IsNullOrEmpty(UserId)
                || String.IsNullOrEmpty(Intent)
            );
        }

        public Event()
        {
            TimestampMillis = CurrentUnixMilliseconds();
            Intent = "unknown";
        }

        public Event(string apiKey)
        {
            ApiKey = apiKey;
            TimestampMillis = CurrentUnixMilliseconds();
            Intent = "unknown";
        }

    }
}
