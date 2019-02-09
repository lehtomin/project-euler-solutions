using System;
using System.Collections.Generic;
using Problem0003;

namespace Problem0014
{
    public class CalculateCollatzSequence
    {
        private static void Main()
        {
            const long maxStartingValue = 999999;
            var collatzSequence = GetLongestCollatzSequence(maxStartingValue);
            Console.WriteLine("Longest Collatz Sequence, starting under 1 000 000, has " + collatzSequence.Sequence.Count + " terms.");
            Console.WriteLine("It starts from number: " + collatzSequence.StartingValue);
            Console.ReadKey();
        }

        public static CollatzSequence GetLongestCollatzSequence(long maxStartingValue)
        {
            if (maxStartingValue <= 0)
                throw new ArgumentException("Value must be bigger than 0.");

            var sequence = new List<long>();
            var startingValue = 1;

            for (var i = 1; i <= maxStartingValue; i++)
            {
                var currentSequence = GetCollatzSequence(i);
                if (currentSequence.Count < sequence.Count)
                    continue;

                startingValue = i;
                sequence.Clear();
                sequence.AddRange(currentSequence);
            }

            return new CollatzSequence
            {
                StartingValue = startingValue,
                Sequence = sequence
            };
        }

        public static List<long> GetCollatzSequence(long startingValue)
        {
            if (startingValue <= 0)
                throw new ArgumentException("Value must be bigger than 0.");

            var currentValue = startingValue;
            var result = new List<long> { startingValue };
            while (currentValue != 1)
            {
                currentValue = PrimeFactorization.IsEven(currentValue) ? ApplyRuleForEvenNumber(currentValue) : ApplyRuleForOddNumber(currentValue);
                result.Add(currentValue);
            }
            return result;
        }

        private static long ApplyRuleForEvenNumber(long value)
        {
            if (value < 0 )
                throw new ArgumentException("Only positive values are allowed.");
            
            return value/2;
        }

        private static long ApplyRuleForOddNumber(long value)
        {
            if (value < 0)
                throw new ArgumentException("Only positive values are allowed.");

            return value*3 + 1;
        }
    }

    public class CollatzSequence
    {
        public long StartingValue { get; set; }
        public List<long> Sequence { get; set; }
    }
}
