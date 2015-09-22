namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LetterChanges
    {
        public static readonly string[] Letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public string Execute(string initString)
        {
            var letters = initString.ToArray().Select(c => c + string.Empty);
            var returnString = string.Empty;
            foreach (var letter in letters)
            {
                returnString += GetNextLetter(letter);
            }

            return returnString;
        }

        private static string GetNextLetter(string letter)
        {
            if (letter == "z")
            {
                return "a";
            }

            return Letters[GetIndex(letter) + 1];
        }

        private static int GetIndex(string letter)
        {
            for (var index = 0; index < Letters.Length; index++)
            {
                if (letter == Letters[index])
                {
                    return index;
                }
            }

            throw new InvalidOperationException("Letter not found : " + letter);
        }
    }
}
