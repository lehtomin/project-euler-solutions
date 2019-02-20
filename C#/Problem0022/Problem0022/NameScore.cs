using System.Collections.Generic;
using System.Linq;

namespace Problem0022
{
    public class NameScore
    {
        private readonly Dictionary<char, int> _valuesOfAlphabet = new Dictionary<char, int>
        {
            {'A', 1}, {'B', 2},
            {'C', 3}, {'D', 4},
            {'E', 5}, {'F', 6},
            {'G', 7}, {'H', 8},
            {'I', 9}, {'J', 10},
            {'K', 11}, {'L', 12},
            {'M', 13}, {'N', 14},
            {'O', 15}, {'P', 16},
            {'Q', 17}, {'R', 18},
            {'S', 19}, {'T', 20},
            {'U', 21}, {'V', 22},
            {'W', 23}, {'X', 24},
            {'Y', 25}, {'Z', 26}
        };

        public long CalculateNameScore(List<string> names)
        {
            var nameScores = new List<long>();
            foreach (var name in names)
            {
                var alphabeticalValue = CalculateAlphabeticalValue(name);
                long alphabeticalPosition = names.IndexOf(name) + 1;
                nameScores.Add(alphabeticalPosition*alphabeticalValue);
            }

            var result = 0L;
            foreach (var nameScore in nameScores)
            {
                result += nameScore;
            }

            return result;
        }

        public long CalculateAlphabeticalValue(string name)
        {
            var characters = name.ToUpper().ToCharArray();
            var alphabeticalValue = 0L;
            foreach (var character in characters)
            {
                alphabeticalValue += _valuesOfAlphabet.Single(v => v.Key == character).Value;
            }
            return alphabeticalValue;
        }

        public int CalculateAlphabeticalValueUsingAscii(string name)
        {
            var characters = name.ToUpper().ToCharArray();
            var alphabeticalValue = 0;
            foreach (var character in characters)
            {
                alphabeticalValue += character - 64;
            }
            return alphabeticalValue;
        }
    }
}
