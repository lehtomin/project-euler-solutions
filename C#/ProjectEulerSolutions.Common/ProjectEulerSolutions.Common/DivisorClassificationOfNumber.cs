using System;
using System.Collections.Generic;

namespace ProjectEulerSolutions.Common
{
    public class DivisorClassificationOfNumber
    {
        public bool IsPerfect(long number)
        {
            return GetSumOfProperDivisors(number) == number;
        }

        public bool IsAbundant(long number)
        {
            return GetSumOfProperDivisors(number) > number;
        }

        public bool IsDeficient(long number)
        {
            return GetSumOfProperDivisors(number) < number;
        }

        public long GetSumOfProperDivisors(long number)
        {
            var divisors = GetProperDivisorsForANumber(number);
            return CalculateSum(divisors);
        }

        public List<long> GetProperDivisorsForANumber(long number)
        {
            var divisors = GetDivisorsForANumber(number);
            divisors.Remove(number);
            return divisors;
        }

        public List<long> GetDivisorsForANumber(long number)
        {
            var result = new List<long>();
            for (var i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (number / i == i)
                        result.Add(i);
                    else
                    {
                        result.Add(i);
                        result.Add(number / i);
                    }
                }
            }
            return result;
        }

        public long CalculateSum(List<long> numbersToSum)
        {
            var result = 0L;
            foreach (var number in numbersToSum)
            {
                result += number;
            }

            return result;
        }
    }
}
