namespace CoderbyteChallenges
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Tools;

    public class SimpleSymbols
    {
        private static readonly string[] Digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static readonly string[] LettersLowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string[] LettersCapitalCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static readonly string[] Letters = LettersLowerCase.Concat(LettersCapitalCase).ToArray();

        private static readonly string[] LettersAndDigits = Digits.Concat(Letters).ToArray();
        private static readonly string[] Others = { "=", "+" };

        private static readonly string[] AllowedCaracters = LettersAndDigits.Concat(Others).ToArray();

        public string Execute(string str)
        {
            if (HasDisallowedCaracters(str))
            {
                throw new InvalidDataException("Input string has disallowed caracters");
            }
            
            foreach (var index in GetLetterIndexes(str))
            {
                if (CheckLetterAtIndex(str, index) == ReturnFalse())
                {
                    return ReturnFalse();
                }
            }

            return ReturnTrue();
        }

        private IEnumerable<int> GetLetterIndexes(string str)
        {
            var lastIndex = 0;
            foreach (var letter in str.ToArrayOfStrings())
            {
                if (Others.Contains(letter) || Digits.Contains(letter))
                {
                    continue;
                }

                lastIndex = str.IndexOf(letter, lastIndex);
                yield return lastIndex;
            }
        }

        private string CheckLetterAtIndex(string str, int index)
        {
            if (!HasPlusAtLeft(str, index) || !HasPlusAtRight(str, index))
            {
                return ReturnFalse();
            }

            return ReturnTrue();
        }

        private bool HasPlusAtLeft(string letter, int index)
        {
            if (index == 0)
            {
                return false;
            }

            if (letter[index - 1] == '+')
            {
                return true;
            }

            return false;
        }

        private bool HasPlusAtRight(string letter, int index)
        {
            if (index == letter.Length - 1)
            {
                return false;
            }

            if (letter[index + 1] == '+')
            {
                return true;
            }

            return false;
        }

        private string ReturnTrue()
        {
            return "true";
        }

        private string ReturnFalse()
        {
            return "false";
        }

        private static bool HasDisallowedCaracters(string str)
        {
            return !str.ToArrayOfStrings().Any(s => AllowedCaracters.Contains(s));
        }
    }
}
