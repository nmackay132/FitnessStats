using System.Net;

namespace FitnessStats.Models
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