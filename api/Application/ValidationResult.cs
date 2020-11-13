using Application.Response.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class ValidationResult
    {
        public bool Success { get; set; }
        public Errors Errors { get; set; }
    }
}
