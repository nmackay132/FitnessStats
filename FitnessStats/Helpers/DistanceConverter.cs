namespace FitnessStats.Helpers
{
    public class DistanceConverter
    {
        private const double KmToMiles = 0.621371;

        public static double MetersToKilometers(double meters)
        {
            return meters / 1000;
        }

        public static double MetersToMiles(double meters)
        {
            return MetersToKilometers(meters) * KmToMiles;
        }
    }
}
