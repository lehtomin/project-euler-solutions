using System;

namespace Problem0012
{
    public class Program
    {
        private static TriangularNumber _triangularNumber;

        static void Main()
        {
            _triangularNumber = new TriangularNumber();
            const long amountOfDivisors = 501;
            var result = _triangularNumber.GetTriangularNumberWithCertainAmountOfDivisors(amountOfDivisors);
            Console.WriteLine($"Triangular number with {result.Divisors.Count} divisors is {result.TriangularNumber}");
            Console.ReadKey();
        }
    }
}
