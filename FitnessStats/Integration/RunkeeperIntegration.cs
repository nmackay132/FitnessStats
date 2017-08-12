using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FitnessStats.Models;
using FitnessStats.Repositories;
using FitnessStats.Services;

namespace FitnessStats.Integration
{
    public class RunkeeperIntegration : IRunkeeperIntegration
    {
        private readonly IRunRepository _runRepository;
        private readonly IRunkeeperService _runkeeperService;

        public RunkeeperIntegration(IRunRepository runRepository, IRunkeeperService runkeeperService)
        {
            _runRepository = runRepository;
            _runkeeperService = runkeeperService;
        }

        public void UpdateRuns()
        {
            var runs = _runkeeperService.GetAllRunsIfChanges();

            if (!HasNewRuns(runs)) return;

            _runRepository.UpdateManyRuns(runs);
        }

        private static bool HasNewRuns(IList<Run> runs)
        {
            return runs?.Any() == true;
        }
    }
}