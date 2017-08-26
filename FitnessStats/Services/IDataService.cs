using System.Collections.Generic;
using FitnessStats.Models;

namespace FitnessStats.Services
{
    public interface IDataService
    {
        IList<Run> GetRuns();
    }
}