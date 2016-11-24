using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class News
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "Desc")]
        public string Desc { get; set; }

        [JsonProperty(PropertyName = "Special")]
        public string Special { get; set; }

        [JsonProperty(PropertyName = "item")]
        public string item { get; set; }
    }
}
