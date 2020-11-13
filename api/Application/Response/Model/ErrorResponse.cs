using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Response.Model
{
    public class ErrorResponse : BaseResponse
    {
        [JsonProperty("errors")]
        public Errors Errors { get; set; }
    }
}
