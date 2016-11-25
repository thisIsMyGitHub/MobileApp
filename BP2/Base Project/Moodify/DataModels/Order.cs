using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class Order
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "pizza")]
        public string pizza { get; set; }
        [JsonProperty(PropertyName = "pasta")]
        public string pasta { get; set; }
        [JsonProperty(PropertyName = "burger")]
        public string burger { get; set; }
        [JsonProperty(PropertyName = "cola")]
        public string cola { get; set; }
    }
}
