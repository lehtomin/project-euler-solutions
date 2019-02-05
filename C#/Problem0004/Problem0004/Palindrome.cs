using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem0004
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            var palindromeProduct = FindPalindromeProductOfTwoFactors(999);
            Console.WriteLine("Largest palindrome made from two 3-digit numbers is " + palindromeProduct.Product +
                              ". And it's factors are " + palindromeProduct.Factors.ElementAt(0) +
                              " and " + palindromeProduct.Factors.ElementAt(1));
            Console.ReadKey();

        }

        public static PalindromeProduct FindPalindromeProductOfTwoFactors(long maxFactor) /*The make-up of make-up artists*/
        {
            long product = 0;
            var factors = new List<long>();
            for (long i = maxFactor; i > 0; i--)
            {
                for (var j = i; j > 0; j--)
                {
                    if (IsPalindrome(i * j))
                    {
                        if (i * j > product)
                        {
                            product = i * j;
                            factors.RemoveAll(factor => factor > 0);
                            factors.Add(i);
                            factors.Add(j);
                        }
                    }
                }
            }
            return new PalindromeProduct
            {
                Product = product,
                Factors = factors
            };
        }

        public static bool IsPalindrome(long value)
        {
            var valueString = value.ToString();
            var length = value.ToString().Length;

            if (length == 1 || value < 0)
                return false;
            var i = 0;
            while ( i <= length/2 )
            {
                if (valueString[i] != valueString[length - 1 - i])
                    return false;
                i++;
            }
            return true;
        }
    }

    public class PalindromeProduct
    {
        public IEnumerable<long> Factors { get; set; }

        public long Product { get; set; }
    }
}
