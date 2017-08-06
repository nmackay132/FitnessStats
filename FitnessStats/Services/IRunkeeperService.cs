using System.Collections.Generic;
using FitnessStats.Models;

namespace FitnessStats.Services
{
    public interface IRunkeeperService
    {
        List<Run> GetAllRunsIfChanges();
    }
}
