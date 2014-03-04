using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZompioParser.Contracts
{
    public class ZompioForm
    {
        public ZompioForm()
        {
            this.FormData = new FormData();
            this.FormResource = new FormResource();
            
        }

        [JsonProperty(Order = 1, PropertyName = "id")]
        public string id { get; set; }



        [JsonProperty(Order = 2, PropertyName = "FormSchema")]
        public FormSchema FormSchema { get; set; }

        [JsonProperty(Order = 3, PropertyName = "FormView")]
        public FormView FormView { get; set; }

        [JsonProperty(Order = 4, PropertyName = "FormResource")]
        public FormResource FormResource { get; set; }

        [JsonProperty(Order = 5, PropertyName = "FormData",DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("{}")]
        public FormData FormData { get; set; }


    }
}
