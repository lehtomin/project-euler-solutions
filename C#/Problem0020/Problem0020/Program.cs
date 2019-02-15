using System;
using Problem0015;

namespace Problem0020
{
    public class Program
    {
        public static void Main()
        {
            var factorialString = Permutation.CalculateFactorial(100).ToString();
            var sum = 0;
            for (var i = 0; i < factorialString.Length; i++)
            {
                sum += int.Parse(factorialString[i].ToString());
            }

            Console.WriteLine($"Sum of digits for 100 factorial: {sum}");
            Console.ReadKey();
        }
    }
}
