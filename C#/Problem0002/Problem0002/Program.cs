using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem0002
{
    public class Program
    {
        public static void Main()
        {
            var fibonacciNumbers = new FibonacciNumbers();
            List<BigInteger> fibonacciSeries = fibonacciNumbers.GenerateFibonacciSeries(4000000);
            var result = CalculateSumOfEvenNumbers(fibonacciSeries);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static BigInteger CalculateSumOfEvenNumbers(List<BigInteger> values)
        {
            BigInteger result = 0;
            foreach (var value in values)
            {
                if (value % 2 == 0) result += value;
            }
            return result;
        }
    }
}
