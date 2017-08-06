using System.Collections.Generic;
using System.Linq;
using FitnessStats.Models;
using MongoDB.Driver;

namespace FitnessStats.Repositories
{
    public class RunRepository : MongoRepository, IRunRepository
    {
        private IMongoCollection<Run> runCollection;
         
        public RunRepository()
        {
            runCollection = _database.GetCollection<Run>("RunLog");
        }

        public List<Run> GetRuns()
        {
            return runCollection.AsQueryable().ToList();
        }

        public void UpdateManyRuns(IEnumerable<Run> runs)
        {
            var models = new List<WriteModel<Run>>();
            foreach (var run in runs)
            {
                var filter = Builders<Run>.Filter.Eq(r => r.StartTime, run.StartTime);
                var model = new ReplaceOneModel<Run>(filter, run) { IsUpsert = true };
                models.Add(model);
            }
            if (models.Any())
            {
                runCollection.BulkWrite(models);
            }
        }
    }
}