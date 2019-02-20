using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem0022
{
    class Program
    {
        private static NameScore _nameScore;
        static void Main()
        {
            _nameScore = new NameScore();
            var file = System.IO.File.ReadAllText("../../DataFiles/p022_names.txt");
            var names = GetAlphabeticallyOrderedListFromFile(file);
            var nameScore = _nameScore.CalculateNameScore(names);

            Console.WriteLine($"Name score for the file is {nameScore}");
            Console.ReadKey();
       }

        private static List<string> GetAlphabeticallyOrderedListFromFile(string file)
        {
            var quotesReplaced = file.Replace('"', ' ').Replace(" ", string.Empty);
            var names = quotesReplaced.Split(',');
            return names.OrderBy(n => n).ToList();
        }
    }
}
