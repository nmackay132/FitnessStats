using System.Linq;
using FitnessStats.Repositories;
using FitnessStats.Services;

namespace FitnessStats.Integration
{
    public class RunkeeperIntegration
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
            if (runs != null && !runs.Any()) return;

            _runRepository.UpdateManyRuns(runs);
        }
    }
}