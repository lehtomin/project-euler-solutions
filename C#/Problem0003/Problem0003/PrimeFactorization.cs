using System;
using System.Collections.Generic;

namespace Problem0003
{
    public class PrimeFactorization
    {
        public static List<long> FindPrimeFactorization(long value)
        {
            var result = new List<long>();
            var remaining = value;
            var primeNumbersList = FindPrimeNumbers(1, (long)Math.Ceiling(Math.Sqrt(value)));
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

        public static List<long> FindPrimeNumbers(long minValue, long maxValue)
        {
            var currentValue = minValue;
            var result = new List<long>();
            if (minValue <= 2)
            {
                result.Add(2);
                currentValue = 3;
            }

            while (currentValue <= maxValue)
            {
                if (IsPrimeNumber(currentValue))
                    result.Add(currentValue);
                if (IsEven(currentValue))
                    currentValue++;
                else currentValue += 2;
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
