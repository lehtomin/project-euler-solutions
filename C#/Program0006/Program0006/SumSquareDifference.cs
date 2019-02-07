using System;

namespace Program0006
{
    public class SumSquareDifference
    {
        static void Main()
        {
            var difference = CalculateSumSquareDifference(1, 100);
            Console.WriteLine(difference);
            Console.ReadKey();
        }

        public static long CalculateSumSquareDifference(long lowerLimit, long upperLimit)
        {
            var sumOfSquares = CalculateSumOfSquares(lowerLimit, upperLimit);
            var squareOfSums = CalculateSquareOfSum(lowerLimit, upperLimit);
            return squareOfSums - sumOfSquares;
        }

        public static long CalculateSumOfSquares(long lowerLimit, long upperLimit)
        {
            if (lowerLimit > upperLimit)
                throw new ArgumentException("Lower limit can't be bigger than the upper limit!");

            long sum = 0;
            for (var i = lowerLimit; i <= upperLimit; i++)
            {
                sum += (long)Math.Pow(i, 2);
            }
            return sum;
        }

        public static long CalculateSquareOfSum(long lowerLimit, long upperLimit)
        {
            if (lowerLimit > upperLimit)
                throw new ArgumentException("Lower limit can't be bigger than the upper limit!");

            var sum = CalculateSum(lowerLimit, upperLimit);
            sum = (long)Math.Pow(sum, 2);
            return sum;
        }

        public static long CalculateSum(long lowerLimit, long upperLimit)
        {
            if(lowerLimit > upperLimit)
                throw new ArgumentException("Lower limit can't be bigger than the upper limit!");

            long sum = 0;
            for (var i = lowerLimit; i <= upperLimit; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
