using System.Collections.Generic;
using System.Linq;
using Problem0012;

namespace Problem0021
{
    public class AmicableNumbers
    {
        public IEnumerable<long> GetAmicableNumbers(int maxValue)
        {
            var numbersAndTheirSums = GetNumbersAndSumOfTheirProperDivisors(maxValue);
            var amicableNumbers = FindAmicableNumbers(numbersAndTheirSums);

            return amicableNumbers;
        }

        public Dictionary<long, long> GetNumbersAndSumOfTheirProperDivisors(int maxValue)
        {
            var numbersAndTheirSums = new Dictionary<long, long>();
            for (var i = 2; i <= maxValue; i++)
            {
                var sumOfProperDivisors = 0L;
                var divisors = GetProperDivisorsForANumber(i);
                foreach (var divisor in divisors)
                {
                    sumOfProperDivisors += divisor;
                }

                numbersAndTheirSums.Add(i, sumOfProperDivisors);
            }

            return numbersAndTheirSums;
        }

        public List<long> GetProperDivisorsForANumber(long number)
        {
            var divisors = TriangularNumber.GetDivisorsForANumber(number);
            divisors.Remove(number);
            return divisors;
        }

        private IEnumerable<long> FindAmicableNumbers(Dictionary<long, long> numbersAndTheirSums)
        {
            var amicableNumbers = new List<long>();
            foreach (var numberAndSum in numbersAndTheirSums)
            {
                if (numberAndSum.Key == numberAndSum.Value)
                    continue;
                if (!numbersAndTheirSums.ContainsKey(numberAndSum.Value))
                    continue;

                var correspondingNumberAndSum = numbersAndTheirSums.Single(n => n.Key == numberAndSum.Value);
                if (numberAndSum.Key == correspondingNumberAndSum.Value)
                {
                    amicableNumbers.Add(numberAndSum.Key);
                }
            
            }
            return amicableNumbers;
        }
    }
}
