using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Response
{
    public class Errors
    {
        [JsonProperty("message")]
        List<Error> ErrorList { get; set; }
    }
}
