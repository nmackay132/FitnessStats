using System.Collections.Generic;
using FitnessStats.Models;

namespace FitnessStats.Repositories
{
    public interface IRunRepository
    {
        IList<Run> GetRuns();
        void UpdateManyRuns(IEnumerable<Run> runs);
    }
}
