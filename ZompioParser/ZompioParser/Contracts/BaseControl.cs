using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZompioParser.Contracts
{
    [DataContract(IsReference = true)]
    [JsonObject(IsReference = true)]
    public class BaseControl
    {
        [JsonProperty(Order = 1, PropertyName = "controlId", Required = Required.Always)]
        public string ControlId { get; set; }

        [JsonProperty(Order = 2, PropertyName = "type", NullValueHandling = NullValueHandling.Include, Required = Required.Default)]
        [DefaultValue("object")]
        public string Type { get; set; }

        [JsonProperty(Order = 3, PropertyName = "isContainer", NullValueHandling = NullValueHandling.Include, Required = Required.Default)]
        public bool IsContainer { get; set; }

        //[JsonProperty(Order = 4, PropertyName = "$ref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //[DataContract(IsReference = true)]

        //[JsonProperty(Order = 4, PropertyName = "FieldRef", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public FieldRef FieldRef { get; set; }

        //[DataMember(Name = "$ref")]
        [JsonProperty(Order = 4, PropertyName = "$ref", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Ref { get; set; }

        [JsonProperty(Order = 5, PropertyName = "Children", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dictionary<string,BaseControl> Children { get; set; }


        [OnDeserializing]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            // ber3 = "This value was set during deserialization";
        }
    }


    [DataContract(IsReference = true)]
    [JsonObject(IsReference = false)]
    public class FieldRef
    {
        [DataMember(Name = "$ref")]
        public string Ref { get; set; }
    }
}
