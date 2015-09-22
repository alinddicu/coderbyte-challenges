namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LetterChanges
    {
        public static readonly string[] LettersLowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public static readonly string[] LettersCapitalCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public string Execute(string str)
        {
            str = Translate(str);
            //str = CapitalizeVowels(str);

            return str;
        }

        private static string Translate(string initString)
        {
            var letters = initString.ToArray().Select(c => c + string.Empty);
            var returnString = string.Empty;
            foreach (var letter in letters)
            {
                returnString += GetNextLetter(letter);
            }

            return returnString;
        }

        private static string GetNextLetter(string symbol)
        {
            if (!char.IsLetter(symbol[0]))
            {
                return symbol;
            }

            if (symbol == "z")
            {
                return "a";
            }

            if (symbol == "Z")
            {
                return "A";
            }

            if (char.IsUpper(symbol[0]))
            {
                return LettersCapitalCase[GetIndex(LettersCapitalCase, symbol) + 1];
            }

            return LettersLowerCase[GetIndex(LettersLowerCase, symbol) + 1];
        }

        private static int GetIndex(string[] letters, string letter)
        {
            for (var index = 0; index < letters.Length; index++)
            {
                if (letter == letters[index])
                {
                    return index;
                }
            }

            throw new InvalidOperationException("Unknown letter : " + letter);
        }

        private static string CapitalizeVowels(string str)
        {
            throw new NotImplementedException();
        }
    }
}
