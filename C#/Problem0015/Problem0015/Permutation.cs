using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem0015
{
    public class Permutation
    {
        static void Main()
        {
            const int gridWidth = 20;
            const int gridHeight = 20;
            var result = CalculateAmountOfPermutations(new List<int> { gridWidth, gridHeight });
            Console.WriteLine($"Amount of permutations in {gridWidth}x{gridHeight} grid: {result}");
            Console.ReadKey();
        }

        public static BigInteger CalculateAmountOfPermutations(List<int> amountsOfDifferentSymbols)
        {
            int totalAmountOfSymbols = 0;
            foreach (var number in amountsOfDifferentSymbols)
            {
                totalAmountOfSymbols += number;
            }

            var totalFactorial = CalculateFactorial(totalAmountOfSymbols);
            BigInteger productOfFactorialsOfEachSymbol = 1;
            foreach (var symbol in amountsOfDifferentSymbols)
            {
                productOfFactorialsOfEachSymbol *= CalculateFactorial(symbol);
            }
            var amountOfUniquePermutations = totalFactorial / productOfFactorialsOfEachSymbol;
            return amountOfUniquePermutations;
        }

        public static BigInteger CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Factorial can't be calculated from negative numbers.");
            BigInteger result = 1;
            for (var i = number; i > 0; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
