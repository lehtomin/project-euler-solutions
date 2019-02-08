using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem0008
{
    public class ProductInSeries
    {
        public static void Main()
        {
            const string series =
                "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            var numberSeries = ConvertStringToIntArray(series);
            var largestProductInSeries = GetLargestProductInASeries(numberSeries, 13);
            Console.WriteLine("Largest product in series : " + largestProductInSeries.Product);
            Console.WriteLine("It's the product of factors: ");
            foreach (var factor in largestProductInSeries.Factors)
            {
                Console.Write(factor + " ");
            }
            Console.ReadKey();
        }

        public static List<int> ConvertStringToIntArray(string input)
        {
            var result = new List<int>();
            for (var i = 0; i < input.Length; i++)
            {
                try
                {
                    result.Add(int.Parse(input.ElementAt(i).ToString()));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only numbers are allowed!");
                    throw;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return result;
        }

        public static ProductAndFactors GetLargestProductInASeries(List<int> series, int numberOfAdjacentDigits)
        {
            if (series.Count < numberOfAdjacentDigits)
                throw new ArgumentException("There has to be more numbers in the series than the amount of adjacent numbers we're searching.");

            long result = 0;
            var factors = new List<int>();
            for (var i = 0; i < series.Count - numberOfAdjacentDigits; i++)
            {
                //Lesson learned: using var here instead of long caused value to be typed as int. It would then overflow resulting in incorrect solution.
                long productOfAdjacentNumbers = series[i];
                var currentFactors = new List<int> { series[i] };

                for (var j = i + 1; j <= i + numberOfAdjacentDigits - 1; j++)
                {
                    productOfAdjacentNumbers = productOfAdjacentNumbers * series[j];
                    currentFactors.Add(series[j]);
                }

                if (productOfAdjacentNumbers <= result)
                    continue;

                result = productOfAdjacentNumbers;
                factors.Clear();
                factors.AddRange(currentFactors);
            }

            return new ProductAndFactors
            {
                Product = result,
                Factors = factors
            };
        }
    }

    public class ProductAndFactors
    {
        public long Product { get; set; }

        public List<int> Factors { get; set; }
    }
}
