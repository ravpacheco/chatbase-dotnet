using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Chatbase
{
    [CollectionDataContract]
    public class EventCollection : Collection<Event> { }

    [DataContract]
    public class EventSet
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get; set; }

        [DataMember(Name = "events")]
        private EventCollection Events;

        public EventSet(string apiKey)
        {
            ApiKey = apiKey;
            Events = new EventCollection();
        }

        public void Add(Event msg)
        {
            Events.Add(msg);
        }

        public EventCollection GetEvents()
        {
            return Events;
        }

        public Event NewEvent()
        {
            return new Event(ApiKey);
        }
    }
}
