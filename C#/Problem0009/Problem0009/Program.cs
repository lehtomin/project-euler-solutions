using System;
using System.Collections.Generic;

namespace Problem0009
{
    public class Program
    {
        static void Main()
        {
            var factors = FindSpecialPythagoreanTriplet();
            var product = factors[0] * factors[1] * factors[02];
            
            Console.WriteLine(product);
            Console.WriteLine("Factors are: " + factors[0] +", "+ factors[1] +", "+ factors[02]);
            Console.ReadKey();

        }

        /// <summary>
        /// Rules to follow:
        /// a^2 + b^2 = c^2
        /// a+b+c=1000
        /// a < b < c
        /// </summary>
        /// <returns></returns>
        public static List<int> FindSpecialPythagoreanTriplet()
        {
            var result = new List<int>();
            for (var b = 1; b < 1000; b++)
            {
                for (var c = 1000; c > b; c--)
                {
                    if (Math.Pow(1000, 2) - 2000 * b - 2000 * c + 2 * Math.Pow(b, 2) + 2 * b * c != 0)                    
                        continue;

                    var a = 1000 - b - c;
                    result.Add(a);
                    result.Add(b);
                    result.Add(c);
                    return result;
                }
            }
            return new List<int>();
        }
    }
}
