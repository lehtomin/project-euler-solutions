using System;
using System.Numerics;

namespace Problem0016
{
    class Program
    {
        static void Main()
        {
            var powerDigit = BigInteger.Pow(2, 1000).ToString();
            var numbersToSum = powerDigit.ToCharArray(0, powerDigit.Length);
            double result = 0;
            foreach (var number in numbersToSum)
            {
                result += char.GetNumericValue(number);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
