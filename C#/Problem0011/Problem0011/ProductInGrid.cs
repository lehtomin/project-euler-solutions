using System;
using System.Collections.Generic;
using System.Linq;
using Problem0008;

namespace Problem0011
{
    public class ProductInGrid
    {
        private static void Main()
        {
            const int countOfAdjacentNumbers = 4;
            var numberGrid = ParseInput("08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08\r\n49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00\r\n81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65\r\n52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91\r\n22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80\r\n24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50\r\n32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70\r\n67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21\r\n24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72\r\n21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95\r\n78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92\r\n16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57\r\n86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58\r\n19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40\r\n04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66\r\n88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69\r\n04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36\r\n20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16\r\n20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54\r\n01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48");

            var largestProduct = FindLargestProductInAGrid(numberGrid, countOfAdjacentNumbers);
            Console.WriteLine($"Largest product with {countOfAdjacentNumbers} adjacent numbers: {largestProduct.Product}");
            Console.WriteLine($"Direction: {largestProduct.Direction}");
            Console.Write("Factors: ");
            foreach (var factor in largestProduct.Factors)
            {
                Console.Write($"{factor} ");
            }
            Console.ReadKey();
        }

        public static List<List<int>> ParseInput(string input)
        {
            var result = new List<List<int>>();
            input = input.Replace("\r", "");
            var rowString = input.Split('\n');

            foreach (var row in rowString)
            {
                var resultRow = new List<int>();
                var values = row.Split(' ');
                foreach (var value in values)
                {
                    var parsedValue = int.Parse(value);
                    resultRow.Add(parsedValue);
                }
                result.Add(resultRow);
            }
            return result;
        }

        public static ProductAndFactorsAndDirection FindLargestProductInAGrid(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var resultList = new List<ProductAndFactorsAndDirection>();
            var horizontalResult = GetLargestProductHorizontally(numberGrid, countOfAdjacentNumbers);
            var verticalResult = GetLargestProductVertically(numberGrid, countOfAdjacentNumbers);
            var diagonalResult = GetLargestProductDiagonally(numberGrid, countOfAdjacentNumbers);
                
            resultList.Add(new ProductAndFactorsAndDirection
            {
                Product = horizontalResult.Product,
                Factors = horizontalResult.Factors,
                Direction = Direction.Horizontal
            });
            resultList.Add(new ProductAndFactorsAndDirection
            {
                Product = verticalResult.Product,
                Factors = verticalResult.Factors,
                Direction = Direction.Vertical
            });
            resultList.Add(new ProductAndFactorsAndDirection
            {
                Product = diagonalResult.Product,
                Factors = diagonalResult.Factors,
                Direction = Direction.Diagonal
            });

            var maxProduct = resultList.Max(p => p.Product);
            return resultList.First(p => p.Product == maxProduct);
        }

        private static ProductAndFactors GetLargestProductHorizontally(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var result = new ProductAndFactors();
            foreach (var row in numberGrid)
            {
                var currentRow = ProductInSeries.GetLargestProductInASeries(row, countOfAdjacentNumbers);
                if (currentRow.Product <= result.Product)
                    continue;

                result.Product = currentRow.Product;
                result.Factors.Clear();
                result.Factors = currentRow.Factors;
            }
            return result;
        }

        private static ProductAndFactors GetLargestProductVertically(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var result = new ProductAndFactors();

            for (var i = 0; i < numberGrid.Count; i++)
            {
                var series = new List<int>();
                foreach (var row in numberGrid)
                {
                    series.Add(row[i]);
                }
                var currentColumn = ProductInSeries.GetLargestProductInASeries(series, countOfAdjacentNumbers);
                if (currentColumn.Product <= result.Product)
                    continue;

                result.Product = currentColumn.Product;
                result.Factors.Clear();
                result.Factors = currentColumn.Factors;

            }
            return result;
        }

        private static ProductAndFactors GetLargestProductDiagonally(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            foreach (var row in numberGrid)
            {
                if (row.Count != numberGrid.Count)
                    throw new ArgumentException("Dimensions of the input has to be same (n rows and n columns).");
            }

            var list = new List<ProductAndFactors>
            {
                GetLargestProductFromUpperRightHalfOfMatrix(numberGrid, countOfAdjacentNumbers),
                GetLargestProductFromLowerLeftHalfOfMatrix(numberGrid, countOfAdjacentNumbers),
                GetLargestProductFromLowerRightHalfOfMatrix(numberGrid, countOfAdjacentNumbers),
                GetLargestProductFromUpperLeftHalfOfMatrix(numberGrid, countOfAdjacentNumbers)
            };

            var maxProduct = list.Max(p => p.Product);
            return list.First(p => p.Product == maxProduct);
        }

        private static ProductAndFactors GetLargestProductFromUpperRightHalfOfMatrix(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var result = new ProductAndFactors();
            for (var i = 0; i <= numberGrid.Count - countOfAdjacentNumbers; i++)
            {
                var startingPointRow = 0;
                var startingPointColumn = i;
                var series = new List<int>();
                for (var j = 0; j < numberGrid.Count - i; j++)
                {
                    series.Add(numberGrid[startingPointRow + j][startingPointColumn + j]);
                }

                var currentColumn = ProductInSeries.GetLargestProductInASeries(series, countOfAdjacentNumbers);
                if (currentColumn.Product <= result.Product)
                    continue;

                result.Product = currentColumn.Product;
                result.Factors.Clear();
                result.Factors = currentColumn.Factors;
            }
            return result;
        }

        private static ProductAndFactors GetLargestProductFromLowerLeftHalfOfMatrix(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var result = new ProductAndFactors();
            for (var i = 0; i <= numberGrid.Count - countOfAdjacentNumbers; i++)
            {
                var startingPointRow = i;
                var startingPointColumn = 0;
                var series = new List<int>();
                for (var j = 0; j < numberGrid.Count - i; j++)
                {
                    series.Add(numberGrid[startingPointRow + j][startingPointColumn + j]);
                }

                var currentColumn = ProductInSeries.GetLargestProductInASeries(series, countOfAdjacentNumbers);
                if (currentColumn.Product <= result.Product)
                    continue;

                result.Product = currentColumn.Product;
                result.Factors.Clear();
                result.Factors = currentColumn.Factors;
            }

            return result;
        }

        private static ProductAndFactors GetLargestProductFromLowerRightHalfOfMatrix(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var result = new ProductAndFactors();
            for (var i = numberGrid.Count - countOfAdjacentNumbers; i >= 0; i--)
            {
                var startingPointRow = numberGrid.Count - 1;
                var startingPointColumn = i;
                var series = new List<int>();
                for (var j = 0; j < numberGrid.Count - i; j++)
                {
                    series.Add(numberGrid[startingPointRow - j][startingPointColumn + j]);
                }

                var currentColumn = ProductInSeries.GetLargestProductInASeries(series, countOfAdjacentNumbers);
                if (currentColumn.Product <= result.Product)
                    continue;

                result.Product = currentColumn.Product;
                result.Factors.Clear();
                result.Factors = currentColumn.Factors;
            }
            return result;
        }

        private static ProductAndFactors GetLargestProductFromUpperLeftHalfOfMatrix(List<List<int>> numberGrid, int countOfAdjacentNumbers)
        {
            var result = new ProductAndFactors();
            for (var i = numberGrid.Count - 1; i >= countOfAdjacentNumbers - 1; i--)
            {
                var startingPointRow = i;
                var startingPointColumn = 0;
                var series = new List<int>();
                for (var j = 0; j <= i; j++)
                {
                    series.Add(numberGrid[startingPointRow - j][startingPointColumn + j]);
                }

                var currentColumn = ProductInSeries.GetLargestProductInASeries(series, countOfAdjacentNumbers);
                if (currentColumn.Product <= result.Product)
                    continue;

                result.Product = currentColumn.Product;
                result.Factors.Clear();
                result.Factors = currentColumn.Factors;
            }
            return result;
        }
    }

    public class ProductAndFactorsAndDirection : ProductAndFactors
    {
        public Direction Direction { get; set; }
    }

    public enum Direction
    {
        Horizontal,
        Vertical,
        Diagonal
    }
}
