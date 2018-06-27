using System.Web.Http;
using FitnessStats.Clients;

namespace WebUI.RestApi
{
    public class AuthorizationController : ApiController
    {
        private readonly IStravaAuthorizationClient _stravaAuthorizationClient;

        public AuthorizationController(IStravaAuthorizationClient stravaAuthorizationClient)
        {
            _stravaAuthorizationClient = stravaAuthorizationClient;
        }

        [HttpGet]
        [Route("callback")]
        public IHttpActionResult Callback([FromUri] AuthorizationCallbackReadModel queryData)
        {
            _stravaAuthorizationClient.GetToken(queryData.Code);
            return Ok();
        }
    }
}