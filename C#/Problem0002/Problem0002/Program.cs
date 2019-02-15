using System;
using System.Collections.Generic;

namespace Problem0002
{
    public class Program
    {
        public static void Main()
        {
            var fibonacciNumbers = new FibonacciNumbers();
            // If value is bigger than 2147483647 (MaxValue), it will overflow the int
            List<int> fibonacciSeries = fibonacciNumbers.GenerateFibonacciSeries(4000000);
            var result = CalculateSumOfEvenNumbers(fibonacciSeries);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int CalculateSumOfEvenNumbers(List<int> values)
        {
            var result = 0;
            foreach (var value in values)
            {
                if (value % 2 == 0) result += value;
            }
            return result;
        }
    }
}
