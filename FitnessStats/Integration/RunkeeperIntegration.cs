﻿using System.Linq;
using FitnessStats.Repositories;
using FitnessStats.Services;

namespace FitnessStats.Integration
{
    public class RunkeeperIntegration
    {
        private readonly RunRepository _runRepository;
        private readonly RunkeeperService _runkeeperService;

        public RunkeeperIntegration(RunRepository runRepository, RunkeeperService runkeeperService)
        {
            _runRepository = runRepository;
            _runkeeperService = runkeeperService;
        }

        public void UpdateRuns()
        {
            var runs = _runkeeperService.GetAllRunsIfChanges();
            if (runs != null && !runs.Any()) return;

            _runRepository.UpdateManyRuns(runs);
        }
    }
}