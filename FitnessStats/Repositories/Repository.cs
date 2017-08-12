using MongoDB.Driver;

namespace FitnessStats.Repositories
{
    public class Repository
    {
        protected static IMongoClient Client;
        protected static IMongoDatabase Database;

        protected Repository()
        {
            Client = new MongoClient();
            Database = Client.GetDatabase("FitnessStats");
        }
    }
}