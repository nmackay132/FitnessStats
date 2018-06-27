using FitnessStats.Models.Security;

namespace FitnessStats.Repositories.Security
{
    public interface ISecretRepository
    {
        Secret GetStravaSecret();
    }
}