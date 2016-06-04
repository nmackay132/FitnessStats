using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApplication.Models
{
    public class ApiResponse<T>
    {
        public ApiStatusCode StatusCode { get; set; }
        public T Data { get; set; }
        public ApiResponse(ApiStatusCode statusCode, T data)
        {
            this.StatusCode = statusCode;
            this.Data = data;
        }
    }
}