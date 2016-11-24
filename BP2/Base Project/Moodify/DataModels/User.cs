using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class User
    {

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "pref")]
        public string pref { get; set; }
        [JsonProperty(PropertyName = "client")]
        public string client { get; set; }
        [JsonProperty(PropertyName = "password")]
        public string password { get; set; }
    }
}
