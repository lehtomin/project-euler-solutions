using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem0017
{
    public class Program
    {
        private static readonly HashSet<KeyValuePair<int, string>> Mapping = new HashSet<KeyValuePair<int, string>>
        {
            new KeyValuePair<int, string>(1, "one"),
            new KeyValuePair<int, string>(2, "two"),
            new KeyValuePair<int, string>(3, "three"),
            new KeyValuePair<int, string>(4, "four"),
            new KeyValuePair<int, string>(5, "five"),
            new KeyValuePair<int, string>(6, "six"),
            new KeyValuePair<int, string>(7, "seven"),
            new KeyValuePair<int, string>(8, "eight"),
            new KeyValuePair<int, string>(9, "nine"),
            new KeyValuePair<int, string>(10, "ten"),
            new KeyValuePair<int, string>(11, "eleven"),
            new KeyValuePair<int, string>(12, "twelve"),
            new KeyValuePair<int, string>(13, "thirteen"),
            new KeyValuePair<int, string>(14, "fourteen"),
            new KeyValuePair<int, string>(15, "fifteen"),
            new KeyValuePair<int, string>(16, "sixteen"),
            new KeyValuePair<int, string>(17, "seventeen"),
            new KeyValuePair<int, string>(18, "eighteen"),
            new KeyValuePair<int, string>(19, "nineteen"),
            new KeyValuePair<int, string>(20, "twenty"),
            new KeyValuePair<int, string>(30, "thirty"),
            new KeyValuePair<int, string>(40, "forty"),
            new KeyValuePair<int, string>(50, "fifty"),
            new KeyValuePair<int, string>(60, "sixty"),
            new KeyValuePair<int, string>(70, "seventy"),
            new KeyValuePair<int, string>(80, "eighty"),
            new KeyValuePair<int, string>(90, "ninety"),
            new KeyValuePair<int, string>(100, "hundred"),
            new KeyValuePair<int, string>(1000, "thousand")
        };

        static void Main()
        {
            var words = new List<string>();

            words.AddRange(GetNumbersFromOneToTwenty(Mapping));
            words.AddRange(GetNumbersFrom21To99(Mapping));
            words.AddRange(GetNumbersFrom100To1000(Mapping));

            var result = CalculateAmountOfLetters(words);
            Console.WriteLine($"Number of letters is {result}");
            Console.ReadKey();
        }

        private static List<string> GetNumbersFromOneToTwenty(HashSet<KeyValuePair<int, string>> mapping)
        {
            var words = new List<string>();
            for (var i = 1; i <= 20; i++)
            {
                words.Add(mapping.Single(m => m.Key == i).Value);
            }

            return words;
        }

        private static List<string> GetNumbersFrom21To99(HashSet<KeyValuePair<int, string>> mapping)
        {
            var words = new List<string>();
            for (var i = 21; i < 100; i++)
            {
                var tenths = int.Parse(i.ToString().Substring(0, 1) + 0);
                var ones = int.Parse(i.ToString().Substring(1, 1));
                string word;
                if (ones == 0)
                    word = mapping.Single(m => m.Key == tenths).Value;
                else
                    word = mapping.Single(m => m.Key == tenths).Value + mapping.Single(m => m.Key == ones).Value;
                words.Add(word);
            }

            return words;
        }

        private static List<string> GetNumbersFrom100To1000(HashSet<KeyValuePair<int, string>> mapping)
        {
            var words = new List<string>();
            for (var i = 100; i < 1000; i++)
            {
                var hundredths = int.Parse(i.ToString().Substring(0, 1));
                var tenths = int.Parse(i.ToString().Substring(1, 1) + 0);
                var ones = int.Parse(i.ToString().Substring(2, 1));
                string word;

                if (ones == 0 && tenths == 0)
                    word = mapping.Single(m => m.Key == hundredths).Value + mapping.Single(m => m.Key == 100).Value;
                else if (tenths <= 10)
                {
                    var lastTwoDigits = int.Parse(i.ToString().Substring(1, 2));
                    word = mapping.Single(m => m.Key == hundredths).Value + mapping.Single(m => m.Key == 100).Value + "and" + mapping.Single(m => m.Key == lastTwoDigits).Value;
                }
                else
                {
                    if (ones == 0)
                        word = mapping.Single(m => m.Key == hundredths).Value + mapping.Single(m => m.Key == 100).Value + "and" + mapping.Single(m => m.Key == tenths).Value;
                    else
                        word = mapping.Single(m => m.Key == hundredths).Value + mapping.Single(m => m.Key == 100).Value + "and" + mapping.Single(m => m.Key == tenths).Value + mapping.Single(m => m.Key == ones).Value;
                }
                words.Add(word);

            }
            words.Add(mapping.Single(m => m.Key == 1).Value + mapping.Single(m => m.Key == 1000).Value);
            return words;
        }

        private static long CalculateAmountOfLetters(List<string> words)
        {
            var result = 0;
            foreach (var word in words)
            {
                result = result + word.Length;
            }

            return result;
        }
    }
}
