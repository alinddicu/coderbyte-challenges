namespace CoderbyteChallenges.LetterChanges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LetterChanges
    {
        private static readonly string[] LettersLowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string[] LettersCapitalCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static readonly string[] Vowels = { "a", "e", "i", "o", "u" };

        public string Execute(string str)
        {
            str = Translate(str);
            str = CapitalizeVowels(str);

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

            return char.IsUpper(symbol[0]) 
                ? LettersCapitalCase[GetIndex(LettersCapitalCase, symbol) + 1] 
                : LettersLowerCase[GetIndex(LettersLowerCase, symbol) + 1];
        }

        private static int GetIndex(IList<string> letters, string letter)
        {
            for (var index = 0; index < letters.Count; index++)
            {
                if (letter == letters[index])
                {
                    return index;
                }
            }

            throw new InvalidOperationException("Unknown letter : " + letter);
        }

        private static string CapitalizeVowels(string initString)
        {
            var letters = initString.ToArray().Select(c => c + string.Empty);
            var returnString = string.Empty;
            foreach (var letter in letters)
            {
                if (Vowels.Contains(letter.ToLower()))
                {
                    returnString += letter.ToUpper();
                }
                else
                {
                    returnString += letter;
                }
            }

            return returnString;
        }
    }
}
