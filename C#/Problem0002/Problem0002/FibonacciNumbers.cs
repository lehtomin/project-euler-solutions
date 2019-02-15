using System.Collections.Generic;

namespace Problem0002
{
    public class FibonacciNumbers
    {
        public List<int> GenerateFibonacciSeries(int limitValueTo)
        {
            var fibonacciSeries = new List<int> { 1, 1 };
            for (var i = 1; fibonacciSeries[i] < limitValueTo; i++)
            {
                fibonacciSeries.Add(fibonacciSeries[i] + fibonacciSeries[i - 1]);
            }

            return fibonacciSeries;
        }
    }
}
