namespace CoderbyteChallenges
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Tools;

    public class SimpleSymbols
    {
        private static readonly string[] LettersLowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string[] LettersCapitalCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        private static readonly string[] Letters = LettersLowerCase.Concat(LettersCapitalCase).ToArray();
        private static readonly string[] Others = { "=", "+" };

        private static readonly string[] AllowedCaracters = Letters.Concat(Others).ToArray();

        public string Execute(string str)
        {
            if (HasDisallowedCaracters(str))
            {
                throw new InvalidDataException("Input string has disallowed caracters");
            }

            var index = GetIndex(str);
            if (!HasPlusAtLeft(str, index))
            {
                return ReturnFalse();
            }

            if (!HasPlusAtRight(str, index))
            {
                return ReturnFalse();
            }

            return ReturnTrue();
        }

        private int GetIndex(string str)
        {
            foreach (var letter in str.ToArrayOfStrings())
            {
                if (Others.Contains(letter))
                {
                    continue;
                }

                return str.IndexOf(letter);
            }

            return -1;
        }

        private bool HasPlusAtLeft(string str, int index)
        {
            if (str[index - 1] == '+')
            {
                return true;
            }

            return false;
        }

        private bool HasPlusAtRight(string str, int index)
        {
            if (str[index + 1] == '+')
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
