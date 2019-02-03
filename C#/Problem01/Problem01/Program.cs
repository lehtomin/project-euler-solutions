using System;

namespace Problem01
{
    public class Program
    {
        public static void Main()
        {
            var result = SumOfMultiplesOfThreeAndFive(1000);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int SumOfMultiplesOfThreeAndFive(int upperLimit)
        {
            var result = 0;
            for (var i = 0; i < upperLimit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) result += i;
            }

            return result;
        }
    }
}
