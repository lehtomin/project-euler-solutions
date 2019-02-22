using System;
using System.Collections.Generic;
using ProjectEulerSolutions.Common;

namespace Problem0012
{
    public class TriangularNumber
    {
        private readonly DivisorClassificationOfNumber _divisorClassificationOfNumber;
        public TriangularNumber()
        {
            _divisorClassificationOfNumber = new DivisorClassificationOfNumber();
        }

        public TriangularNumberWithDivisors GetTriangularNumberWithCertainAmountOfDivisors(long amountOfDivisors)
        {
            var divisors = new List<long>();
            long startIndex = 0;
            var endIndex = amountOfDivisors;
            while (divisors.Count < amountOfDivisors)
            {
                var triangularNumbers = GetTriangularNumbers(startIndex, endIndex);
                foreach (var number in triangularNumbers)
                {
                    divisors.AddRange(_divisorClassificationOfNumber.GetDivisorsForANumber(number));
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

        public List<long> GetTriangularNumbers(long startIndex, long endIndex)
        {
            var result = new List<long>();
            for (var i = startIndex; i <= endIndex; i++)
            {
                result.Add(i*(i+1)/2);
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
