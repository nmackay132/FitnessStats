using System.Collections.Generic;
using System.Linq;
using FitnessStats.Models;
using MongoDB.Driver;

namespace FitnessStats.Repositories
{
    public class RunRepository : Repository, IRunRepository
    {
        private readonly IMongoCollection<Run> _runCollection;
         
        public RunRepository()
        {
            _runCollection = Database.GetCollection<Run>("RunLog");
        }

        public IList<Run> GetRuns()
        {
            return _runCollection.AsQueryable().ToList();
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
                _runCollection.BulkWrite(models);
            }
        }
    }
}