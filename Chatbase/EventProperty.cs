using System.Runtime.Serialization;

namespace Chatbase
{
    [DataContract]
    public class EventProperty
    {
        [DataMember(Name = "property_name")]
        public string PropertyName { get; set; }

        [DataMember(Name = "string_value")]
        public string StringValue { get; set; }

        [DataMember(Name = "integer_value")]
        public int IntegerValue { get; set; }

        [DataMember(Name = "float_value")]
        public float FloatValue { get; set; }

        [DataMember(Name = "bool_value")]
        public bool BoolValue { get; set; }

    }
}
