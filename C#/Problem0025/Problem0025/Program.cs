using Problem0002;
using System;
using System.Linq;
using System.Numerics;

namespace Problem0025
{
    public class Program
    {
        public static void Main()
        {
            var fibonacciNumbers = new FibonacciNumbers();
            var numberWith10000Digits = "1" + new string('0', 10000);
            var series = fibonacciNumbers.GenerateFibonacciSeries(BigInteger.Parse(numberWith10000Digits));
            var firstTermWithThousandDigits = series.First(n => n.ToString().Length == 1000);
            var index = series.IndexOf(firstTermWithThousandDigits);

            // In the problem index starts from 1
            Console.WriteLine($"Index of first term with 1000 digits is {index+1}");
            Console.ReadKey();
        }
    }
}
