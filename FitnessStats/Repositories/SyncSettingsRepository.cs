using System;
using System.Linq;
using FitnessStats.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace FitnessStats.Repositories
{
    public class SyncSettingsRepository : MongoRepository, ISyncSettingsRepository
    {
        private readonly IMongoQueryable<SyncSettings> collection;
        public SyncSettingsRepository()
        {
            collection = _database.GetCollection<SyncSettings>("SyncSettings").AsQueryable();
        }

        public DateTime GetLastUpdatedTime()
        {
            return collection.Single().LastUpdated;
        }
    }
}