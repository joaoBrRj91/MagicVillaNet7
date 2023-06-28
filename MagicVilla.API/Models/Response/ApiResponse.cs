using System;
using System.Net;
using MagicVilla.API.Models.Response.Interface;

namespace MagicVilla.API.Models.Response
{
	public class ApiResponse : IResponse
    {
        public ApiResponse(HttpStatusCode statusCode, string statusCodeMessage, List<string> errorMessages, object result)
        {
            StatusCode = statusCode;
            StatusCodeMessage = statusCodeMessage;
            ErrorMessages = errorMessages;
            Result = result;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string StatusCodeMessage { get; set; }

        public List<string> ErrorMessages { get; set; }

        public object Result { get; set; }
    }
}

