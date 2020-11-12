using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Response
{
    public class Link
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }
    }
}
