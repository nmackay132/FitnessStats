using System;
using System.Configuration;
using FitnessStats.Models.Security;
using FitnessStats.Repositories.Security;
using RestSharp;

namespace FitnessStats.Clients
{
    public class StravaAuthorizationClient : IStravaAuthorizationClient
    {
        private readonly IRestClient _restClient;
        private readonly ISecretRepository _secretRepository;

        public StravaAuthorizationClient(IRestClient restClient, ISecretRepository secretRepository)
        {
            _restClient = restClient;
            _secretRepository = secretRepository;
        }

        public TokenReadModel GetToken(string authCode)
        {
            var tokenUrl = ConfigurationManager.AppSettings["StravaTokenUrl"];
            var secret = _secretRepository.GetStravaSecret();
            _restClient.BaseUrl = new Uri(tokenUrl);

            var request = new RestRequest(tokenUrl, Method.POST);
            request.AddParameter("application/x-www-form-urlencoded", $"code={authCode}&client_id={secret.ClientId}&client_secret={secret.ClientSecret}", ParameterType.RequestBody);

            var response = _restClient.Execute<TokenReadModel>(request);

            if (!response.IsSuccessful)
            {
                throw new Exception("Failed to retrieve Identity Token.");
            }

            return response.Data;
        }
    }
}