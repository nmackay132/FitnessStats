using System;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using WebUI.Models;

namespace WebUI.Repositories
{
    public class SyncSettingsRepository : MongoRepository
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