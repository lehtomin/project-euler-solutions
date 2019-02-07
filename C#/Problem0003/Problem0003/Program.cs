using System;
using System.Linq;

namespace Problem0003
{
    public class Program
    {
        public static void Main()
        {
            var primeFactorization = PrimeFactorization.FindPrimeFactorization(600851475143);
            Console.WriteLine("Largest prime factor: " + primeFactorization.Max());
            Console.ReadKey();
        }
    }
}
