using System.Collections.Generic;
using FitnessStats.Integration;
using FitnessStats.Models;
using FitnessStats.Repositories;

namespace FitnessStats.Services
{
    public class DataService : IDataService
    {
        private readonly IRunRepository _runRepository;
        private readonly IRunkeeperIntegration _runkeeperIntegration;

        public DataService(IRunRepository runRepository, IRunkeeperIntegration runkeeperIntegration)
        {
            _runRepository = runRepository;
            _runkeeperIntegration = runkeeperIntegration;
        }

        public IList<Run> GetRuns()
        {
            _runkeeperIntegration.UpdateRuns();
            return _runRepository.GetRuns();
        }
    }
}