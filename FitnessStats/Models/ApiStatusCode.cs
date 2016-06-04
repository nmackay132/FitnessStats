using System.Net;

namespace MyWebApplication.Models
{
    public enum ApiStatusCode
    {
        InternalServerError = HttpStatusCode.InternalServerError,
        NotFound = HttpStatusCode.NotFound,
        OK = HttpStatusCode.OK,
        UnsupportedMediaType = HttpStatusCode.UnsupportedMediaType,
        BadRequest = HttpStatusCode.BadRequest
    }
}