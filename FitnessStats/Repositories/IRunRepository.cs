using System.Collections.Generic;
using FitnessStats.Models;

namespace FitnessStats.Repositories
{
    public interface IRunRepository
    {
        List<Run> GetRuns();
        void UpdateManyRuns(IEnumerable<Run> runs);
    }
}
