using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FitnessStats.Clients;
using FitnessStats.Models;
using FitnessStats.Repositories;
using FitnessStats.Services;

namespace FitnessStats.Integration
{
    public class RunkeeperIntegration : IRunkeeperIntegration
    {
        private readonly IRunRepository _runRepository;
        private readonly IRunkeeperClient _runkeeperClient;

        public RunkeeperIntegration(IRunRepository runRepository, IRunkeeperClient runkeeperClient)
        {
            _runRepository = runRepository;
            _runkeeperClient = runkeeperClient;
        }

        public void UpdateRuns()
        {
            var runs = _runkeeperClient.GetAllRunsIfChanges();

            if (!HasNewRuns(runs)) return;

            _runRepository.UpdateManyRuns(runs);
        }

        private static bool HasNewRuns(IList<Run> runs)
        {
            return runs?.Any() == true;
        }
    }
}