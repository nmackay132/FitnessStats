using System;

namespace FitnessStats.Repositories
{
    public interface ISyncSettingsRepository
    {
        DateTime? GetLastUpdatedTime();
    }
}
