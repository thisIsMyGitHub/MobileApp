using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class Prefs
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "Desc")]
        public string Desc { get; set; }

        [JsonProperty(PropertyName = "client")]
        public string client { get; set; }

    }
}
