using Application.Response.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Response
{
    public static class Factory
    {
        public static Response<T> CreateSuccessResponse<T>(T instance) // where T : IConvertible TODO: implement IConvertible in Domain Objects
        {
            return new Response<T>()
            {
                Data = instance
            };
        }

        public static ErrorResponse CreateErrorResponse(Errors errors)
        {
            return new ErrorResponse()
            {
                Errors = errors
            };
        }

        public static ErrorResponse InternalServerErrorResponse()
        {
            return new ErrorResponse()
            {
                Errors = new Errors()
                {
                    ErrorList = new List<Error>()
                    {
                        new Error()
                        {
                            Status = HttpStatusCodes.InternalServerError.ToString(),
                            Detail = "Unhandled error. Contact IntelliAuction for support.",
                            Id = Guid.NewGuid().ToString(),
                            Title = "Internal server error"
                        }
                    }
                }
            };
        }
    }
}
