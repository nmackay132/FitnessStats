using Newtonsoft.Json;

namespace WebUI.RestApi
{
    public class AuthorizationCallbackReadModel
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}