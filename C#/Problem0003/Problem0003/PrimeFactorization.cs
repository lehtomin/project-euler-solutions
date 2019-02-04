using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem0003
{
    public class PrimeFactorization
    {
        public static void Main()
        {
            var primeFactorization = FindPrimeFactorization(600851475143);
            Console.WriteLine("Largest prime factor: " + primeFactorization.Max());
            Console.ReadKey();
        }

        public static List<long> FindPrimeFactorization(long value)
        {
            var result = new List<long>();
            var remaining = value;
            var primeNumbersList = FindPrimeNumbers(Math.Sqrt(value));
            foreach (var primeNumber in primeNumbersList)
            {

                while (remaining >= Math.Pow(primeNumber, 2))
                {
                    if (remaining % primeNumber == 0)
                    {
                        remaining = remaining / primeNumber;
                        result.Add(primeNumber);
                    }
                    else break;
                }
                if (remaining == primeNumber)
                {
                    result.Add(primeNumber);
                    return result;
                }
            }
            return result;
        }

        public static List<long> FindPrimeNumbers(double maxValue)
        {
            var result = new List<long>();
            for (var i = 2; i <= maxValue; i++)
            {
                if (IsPrimeNumber(i)) result.Add(i);
            }
            return result;
        }

        public static bool IsPrimeNumber(long value)
        {
            if (value == 2) return true;
            if (value > 2 && !IsEven(value))
            {
                for (var i = 2; i <= Math.Floor(Math.Sqrt(value)); i++)
                {
                    if (value % i == 0) return false;
                }
                return true;
            }
            return false;
        }

        public static bool IsEven(long value)
        {
            return (value >= 0 && value % 2 == 0);
        }
    }
}
