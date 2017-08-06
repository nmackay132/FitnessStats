using System.Collections.Generic;
using FitnessStats.Integration;
using FitnessStats.Models;
using FitnessStats.Repositories;
using MongoDB.Driver;

namespace FitnessStats.Services
{
    public class DataService : IDataService
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        private IRunkeeperService _runkeeperService;
        private IRunRepository _runRepository;
        private RunkeeperIntegration runkeeperIntegration;

        public DataService(IRunkeeperService runkeeperService, IRunRepository runRepository)
        {
            _client = new MongoClient();
            _runkeeperService = runkeeperService;
            //runRepository = new RunRepository();
            _runRepository = runRepository;
            //runRepository = new RunRepository();
            runkeeperIntegration = new RunkeeperIntegration(runRepository, runkeeperService);
        }

        public List<Run> GetRuns()
        {
            //runkeeperIntegration.UpdateRuns();
            //GetAllRunsIfChanges();
            return _runRepository.GetRuns();
        }

        public void GetAllRunsIfChanges()
        {
            var runs = _runkeeperService.GetAllRunsIfChanges();
        }
    }
}