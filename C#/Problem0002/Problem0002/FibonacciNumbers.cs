using System.Collections.Generic;
using System.Numerics;

namespace Problem0002
{
    public class FibonacciNumbers
    {
        public List<BigInteger> GenerateFibonacciSeries(BigInteger limitValueTo)
        {
            var fibonacciSeries = new List<BigInteger> { 1, 1 };
            for (var i = 1; fibonacciSeries[i] < limitValueTo; i++)
            {
                fibonacciSeries.Add(fibonacciSeries[i] + fibonacciSeries[i - 1]);
            }

            return fibonacciSeries;
        }
    }
}
