using System;
using System.Diagnostics;

namespace Problem0005
{
    public class SmallestMultiple
    {
        public static void Main()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            var nestedIfsResult = UglyNestedIfs();
            timer.Stop();
            Console.WriteLine(nestedIfsResult);
            Console.WriteLine("NestedIfs time elapsed: " + timer.ElapsedMilliseconds + " ms");
            timer.Restart();
            var parameterizedResult = GetSmallestMultipleFromOneTo(20);
            timer.Stop();
            Console.WriteLine(parameterizedResult);
            Console.WriteLine("Parameterized time elapsed: " + timer.ElapsedMilliseconds + " ms");

            Console.ReadKey();
        }

        private static long UglyNestedIfs()
        {
            long currentNumber = 20;
            while (true)
            {

                if (currentNumber % 19 == 0)
                {
                    if (currentNumber % 18 == 0)
                    {
                        if (currentNumber % 17 == 0)
                        {
                            if (currentNumber % 16 == 0)
                            {
                                if (currentNumber % 15 == 0)
                                {
                                    if (currentNumber % 14 == 0)
                                    {
                                        if (currentNumber % 13 == 0)
                                        {
                                            if (currentNumber % 12 == 0)
                                            {
                                                if (currentNumber % 11 == 0)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                currentNumber += 20;
            }
            return currentNumber;
        }

        private static long GetSmallestMultipleFromOneTo(int maxDivider)
        {
            long smallestNumber = maxDivider;
            while (true)
            {
                for (var i = maxDivider - 1; i >= maxDivider / 2; i--)
                {
                    if (smallestNumber % i == 0)
                    {
                        if ((int)Math.Ceiling((double)maxDivider / 2) == i)
                            return smallestNumber;
                    }
                    else break;
                }
                smallestNumber += maxDivider;
            }
        }
    }
}
