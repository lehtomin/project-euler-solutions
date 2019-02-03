using System;
using System.Collections.Generic;

namespace Problem0002
{
    public class Program
    {
        public static void Main()
        {
            // If value is bigger than 2147483647 (MaxValue), it will overflow the int
            List<int> fibonacciSeries = GenerateFibonacciSeries(4000000);
            var result = CalculateSumOfEvenNumbers(fibonacciSeries);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static List<int> GenerateFibonacciSeries(int limitValueTo)
        {
            var fibonacciSeries = new List<int> { 1, 1 };
            for (var i = 1; fibonacciSeries[i] < limitValueTo; i++)
            {
                fibonacciSeries.Add(fibonacciSeries[i] + fibonacciSeries[i - 1]);
            }

            return fibonacciSeries;
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
