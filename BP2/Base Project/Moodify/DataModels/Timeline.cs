using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class Timeline
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "anger")]
        public double Anger { get; set; }

        [JsonProperty(PropertyName = "contempt")]
        public double Contempt { get; set; }

        [JsonProperty(PropertyName = "disgust")]
        public double Disgust { get; set; }

        [JsonProperty(PropertyName = "fear")]
        public double Fear { get; set; }

        [JsonProperty(PropertyName = "happiness")]
        public double Happiness { get; set; }

    }
}
