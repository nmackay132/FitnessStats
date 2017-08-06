using System.Collections.Generic;
using FitnessStats.Models;

namespace FitnessStats.Services
{
    public interface IDataService
    {
        List<Run> GetRuns();
    }
}
