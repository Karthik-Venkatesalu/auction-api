using Newtonsoft.Json;
using System.Collections.Generic;

namespace Application.Response.Model
{
    public class Errors
    {
        [JsonProperty("message")]
        public IEnumerable<Error> ErrorList { get; set; }
    }
}
