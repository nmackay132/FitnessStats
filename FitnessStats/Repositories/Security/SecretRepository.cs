using FitnessStats.Models.Security;
using MongoDB.Driver;

namespace FitnessStats.Repositories.Security
{
    public class SecretRepository : Repository, ISecretRepository
    {
        private readonly IMongoCollection<Secret> _collection;

        public SecretRepository()
        {
            _collection = Database.GetCollection<Secret>("Secret");
        }

        public Secret GetStravaSecret()
        {
            var filter = Builders<Secret>.Filter.Eq(s => s.ApplicationName, "Strava");
            return _collection.Find(filter).FirstOrDefault();
        }
    }
}
