using System;
using System.Collections.Generic;

namespace Problem0012
{
    public class TriangularNumber
    {
        static void Main()
        {
            const long amountOfDivisors = 501;
            var result = GetTriangularNumberWithCertainAmountOfDivisors(amountOfDivisors);
            Console.WriteLine($"Triangular number with {result.Divisors.Count} divisors is {result.TriangularNumber}");
            Console.ReadKey();
        }

        public static TriangularNumberWithDivisors GetTriangularNumberWithCertainAmountOfDivisors(long amountOfDivisors)
        {
            var divisors = new List<long>();
            long startIndex = 0;
            var endIndex = amountOfDivisors;
            while (divisors.Count < amountOfDivisors)
            {
                var triangularNumbers = GetTriangularNumbers(startIndex, endIndex);
                foreach (var number in triangularNumbers)
                {
                    divisors.AddRange(GetDivisorsForANumber(number));
                    if (divisors.Count < amountOfDivisors)
                    {
                        divisors.Clear();
                        continue;
                    }

                    return new TriangularNumberWithDivisors
                    {
                        TriangularNumber = number,
                        Divisors = divisors
                    };
                }

                startIndex += amountOfDivisors;
                endIndex += amountOfDivisors;
            }
            return new TriangularNumberWithDivisors();
        }

        public static List<long> GetTriangularNumbers(long startIndex, long endIndex)
        {
            var result = new List<long>();
            for (var i = startIndex; i <= endIndex; i++)
            {
                result.Add(i*(i+1)/2);
            }

            return result;
        }

        public static List<long> GetDivisorsForANumber(long number)
        {
            var result = new List<long>();
            for (var i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if(number / i == i)
                        result.Add(i);
                    else
                    {
                        result.Add(i);
                        result.Add(number/i);
                    }
                }               
            }
            return result;
        }
    }

    public class TriangularNumberWithDivisors
    {
        public long TriangularNumber { get; set; }

        public List<long> Divisors { get; set; }
    }
}
