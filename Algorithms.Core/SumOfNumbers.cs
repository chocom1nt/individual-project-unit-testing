using System;

namespace Algorithms.Core
{
    public static partial class Algorithms
    {
        public static int SumOfNumbers(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Переданное число меньше 0");
            }

            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            return sum;
        }
    }
}
