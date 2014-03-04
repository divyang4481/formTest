using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZompioParser.Contracts
{

    //[DataContract(IsReference = true)]
    [JsonObject(IsReference = true)]
    public class BaseField
    {
        [JsonProperty(Order = 1, PropertyName = "title")]
        public string Title { get; set; }

        //[JsonProperty(Order = 2, PropertyName = "type",Required = Required.Always)]
        public string Type { get; set; }
        public string Description { get; set; }

        public bool Required { get; set; }

        [JsonProperty( PropertyName = "enum",DefaultValueHandling = DefaultValueHandling.Ignore )]
        public List<string> EnumList { get; set; }
    }

    
}
