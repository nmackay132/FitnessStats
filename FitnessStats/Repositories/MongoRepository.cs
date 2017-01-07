using MongoDB.Driver;

namespace FitnessStats.Repositories
{
    public class MongoRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        protected MongoRepository()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("FitnessStats");
        }
    }
}