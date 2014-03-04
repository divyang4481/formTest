using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ZompioParser.Contracts
{
    public class FormSchema
    {
        public FormSchema()
        {
            this.Properties = new Dictionary<string, BaseField>();
        }

        [JsonProperty(Order = 1, PropertyName = "id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty(Order = 1, PropertyName = "type", NullValueHandling = NullValueHandling.Include, Required = Required.Default)]
        [DefaultValue("object")]
        public string Type { get; set; }

        public string Title { get; set; }

        [JsonProperty(PropertyName = "properties", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, BaseField> Properties { get; set; }


    }
}
