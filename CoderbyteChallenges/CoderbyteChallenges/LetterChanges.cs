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

        private static string GetNextLetter(string letter)
        {
            if (letter == "z")
            {
                return "a";
            }

            if (letter == "Z")
            {
                return "A";
            }

            try
            {
                return LettersLowerCase[GetIndex(LettersLowerCase, letter) + 1];
            }
            catch (InvalidOperationException)
            {
                return LettersCapitalCase[GetIndex(LettersCapitalCase, letter) + 1];
            }
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

            throw new InvalidOperationException("Letter not found : " + letter);
        }

        private string CapitalizeVowels(string str)
        {
            throw new NotImplementedException();
        }
    }
}
