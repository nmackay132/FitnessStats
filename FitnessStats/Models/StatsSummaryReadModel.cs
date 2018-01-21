namespace FitnessStats.Models
{
    public class StatsSummaryReadModel
    {
        public double TotalKilometers { get; set; }
        public string TotalKilometersFormatted { get; set; }

        public double TotalMiles { get; set; }
        public string TotalMilesFormatted { get; set; }

        public double TotalCalories { get; set; }
        public string TotalCaloriesFormatted { get; set; }

        public double TotalDuration { get; set; }
        public string TotalDurationFormatted { get; set; }
    }
}
