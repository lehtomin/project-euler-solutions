using System;

namespace Problem0021
{
    class Program
    {
        private static AmicableNumbers _amicableNumbers;
        static void Main()
        {
            _amicableNumbers = new AmicableNumbers();
            const int maxValue = 9999;
            var amicableNumbers = _amicableNumbers.GetAmicableNumbers(maxValue);
            var sum = 0L;
            foreach (var amicableNumber in amicableNumbers)
            {
                sum += amicableNumber;
            }
            Console.WriteLine($"Sum Of Amicable numbers under {maxValue + 1} is {sum}");
            Console.ReadKey();
        }
    }
}
