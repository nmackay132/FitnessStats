using FitnessStats.Models.Security;

namespace FitnessStats.Clients
{
    public interface IStravaAuthorizationClient
    {
        TokenReadModel GetToken(string authCode);
    }
}