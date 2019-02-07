using System.Collections.Generic;
using System.Linq;
using Problem0003;

namespace Program0007
{
    public class PrimeNumbers
    {
        public static IEnumerable<long> GeneratePrimeNumbers(int amountToGenerate)
        {
            var primeNumbers = new List<long>();
            long minValue = 0;
            long patchSize = 100;
            var maxValue = patchSize;

            while (primeNumbers.Count <= amountToGenerate)
            {
                var foundPrimes = PrimeFactorization.FindPrimeNumbers(minValue, maxValue);
                primeNumbers.AddRange(foundPrimes);
                var lastIndex = primeNumbers.Count - 1;
                minValue = primeNumbers[lastIndex] + 1;
                maxValue = primeNumbers[lastIndex] + patchSize;
            }
            return primeNumbers.Take(amountToGenerate);
        }
    }
}
