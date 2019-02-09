using System;
using System.Collections.Generic;
using Problem0003;

namespace Problem0010
{
    public class Program
    {
        static void Main()
        {
            var primes = PrimeFactorization.FindPrimeNumbers(1, 2000000);
            var result = CalculateSum(primes);
            Console.WriteLine("Sum of all the prime numbers below 2 000 000 is : " + result);
            Console.ReadKey();          
        }

        public static long CalculateSum(List<long> values)
        {
            long result = 0;
            foreach (var primeNumber in values)
            {
                result = result + primeNumber;
            }
            return result;
        }
    }
}
