using System;
using System.Linq;

namespace Program0007
{
    public class Program
    {
        private static void Main()
        {
            var primes = PrimeNumbers.GeneratePrimeNumbers(10001).ToList();
            Console.WriteLine(primes[10000]);
            Console.ReadKey();
        }
    }
}
