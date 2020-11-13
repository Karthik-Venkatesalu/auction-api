using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Response
{
    public class Document<T>
    {
        [JsonProperty("meta")]
        public Dictionary<string, object> Meta { get; set; }

        [JsonProperty("errors")]
        public Errors Errors { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("links")]
        public Link Link { get; set; }
    }
}
