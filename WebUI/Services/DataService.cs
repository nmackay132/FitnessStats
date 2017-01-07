using System.Collections.Generic;
using MongoDB.Driver;
using WebUI.Integration;
using WebUI.Models;
using WebUI.Repositories;

namespace WebUI.Services
{
    public class DataService
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        private RunkeeperService runkeeperService;
        private RunRepository runRepository;
        private RunkeeperIntegration runkeeperIntegration;

        public DataService()
        {
            _client = new MongoClient();
            runkeeperService = new RunkeeperService();
            runRepository = new RunRepository();
            runkeeperIntegration = new RunkeeperIntegration(runRepository, runkeeperService);
        }

        public List<Run> GetRuns()
        {
            //runkeeperIntegration.UpdateRuns();
            //GetAllRunsIfChanges();
            return runRepository.GetRuns();
        }

        public void GetAllRunsIfChanges()
        {
            var runs = runkeeperService.GetAllRunsIfChanges();
        }
    }
}