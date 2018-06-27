using System.Collections.Generic;
using FitnessStats.Helpers;
using FitnessStats.Integration;
using FitnessStats.Models;
using FitnessStats.Repositories;

namespace FitnessStats.Services
{
    public class RunkeeperService : IRunkeeperService
    {
        private readonly IRunRepository _runRepository;
        private readonly IRunkeeperIntegration _runkeeperIntegration;

        public RunkeeperService(IRunRepository runRepository, IRunkeeperIntegration runkeeperIntegration)
        {
            _runRepository = runRepository;
            _runkeeperIntegration = runkeeperIntegration;
        }

        public IList<Run> GetRuns()
        {
            _runkeeperIntegration.UpdateRuns();
            return _runRepository.GetRuns();
        }

        public StatsSummaryReadModel GetStatsSummary()
        {
            var runs = GetRuns();
            var stats = new StatsSummaryReadModel();
            double totalMeters = 0;
            foreach (var run in runs)
            {
                stats.TotalCalories += run.TotalCalories;
                stats.TotalDuration += run.Duration;
                totalMeters += run.TotalDistance;
            }

            stats.TotalCaloriesFormatted = $"{stats.TotalCalories:n0}";
            stats.TotalKilometers = DistanceConverter.MetersToKilometers(totalMeters);
            stats.TotalKilometersFormatted = $"{stats.TotalKilometers:n0} km";
            stats.TotalMiles = DistanceConverter.MetersToMiles(totalMeters); 
            stats.TotalMilesFormatted = $"{stats.TotalMiles:n0} mi";
            stats.TotalDurationFormatted = TimeFormatter.FormatToDhm(stats.TotalDuration);

            return stats;
        }
    }
}