using System;

namespace FitnessStats.Helpers
{
    public class TimeFormatter
    {
        private const int secInHr = 60 * 60;
        private const int secInDay = 24 * secInHr;

        public static string Format(double totalSeconds)
        {
            var hours = Math.Floor(totalSeconds / secInHr);
            var minutes = Math.Floor((totalSeconds - (secInHr * hours)) / 60);
            var seconds = Math.Round((totalSeconds - (secInHr * hours + 60 * minutes)));
            var hStr = "";

            if (hours > 0) hStr = hours + "h:";

            return hStr + minutes + "m:" + seconds + "s";
        }

        public static string FormatToDays(double totalSeconds)
        {
            var days = Math.Floor(totalSeconds / secInDay);
            var hours = Math.Floor((totalSeconds - days * secInDay) / secInHr);
            var minutes = Math.Floor((totalSeconds - ((days * 24 + hours) * secInHr)) / 60);
            var dStr = string.Empty;
            var hStr = string.Empty;

            if (days > 0) dStr = days + "d:";
;           if (hours > 0) hStr = hours + "h:";

            return dStr + hStr + minutes + "m";
        }
    }
}
