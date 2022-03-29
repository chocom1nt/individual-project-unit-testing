using System;

namespace Algorithms.Core
{
    public static partial class Algorithms
    {
        public static string HumanReadableTime(int inputSeconds)
        {
            int maxTime = 359999;

            if (inputSeconds < 0)
            {
                throw new ArgumentException("Переданное значение времени недопустимо");
            }

            if (inputSeconds > maxTime)
            {
                throw new ArgumentException($"Переданное значение времени больше допустимого. Максимум: {maxTime}");
            }

            int secondsInMinute = 60;
            int secondsInHour = 60 * secondsInMinute;

            int hours = inputSeconds / secondsInHour;
            int minutes = inputSeconds % secondsInHour / secondsInMinute;
            int seconds = inputSeconds % secondsInHour % secondsInMinute;

            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }

        private static string LeadingZero(int number)
        {
            return number > 9 ? $"{number}" : $"0{number}";
        }
    }
}
