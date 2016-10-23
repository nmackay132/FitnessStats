using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessStats.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FitnessStats.Services
{
    public class DataService
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public DataService()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("FitnessStats");
        }

        public List<Run> GetRuns()
        {
            var collection = _database.GetCollection<Run>("RunLog");
            //var filter = new BsonDocument();
            //var sort = Builders<Run>.Sort.Descending("start_time");
            List<Run> runs = collection.AsQueryable().Select(run => run).ToList();
            //var result = await collection.Find(filter).Sort(sort).ToListAsync();
            return runs;
        }

        public void UpdateRuns()
        {
            
        }
    }
}