using System.Collections.Generic;
using FitnessStats.Models;

namespace FitnessStats.Clients
{
    public interface IRunkeeperClient
    {
        List<Run> GetAllRunsIfChanges();
    }
}
