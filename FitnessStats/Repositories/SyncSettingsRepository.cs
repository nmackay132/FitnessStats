using System;
using System.Linq;
using FitnessStats.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace FitnessStats.Repositories
{
    public class SyncSettingsRepository : Repository, ISyncSettingsRepository
    {
        private readonly IMongoQueryable<SyncSettings> _collection;
        public SyncSettingsRepository()
        {
            _collection = Database.GetCollection<SyncSettings>("SyncSettings").AsQueryable();
        }

        public DateTime? GetLastUpdatedTime()
        {
            return _collection.SingleOrDefault()?.LastUpdated;
        }
    }
}