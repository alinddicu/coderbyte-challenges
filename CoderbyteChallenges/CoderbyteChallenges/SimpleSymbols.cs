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
        private static readonly string[] Others = { "=", "+" };

        private static readonly string[] AllowedCaracters =
            LettersLowerCase
            .Concat(LettersCapitalCase)
            .Concat(Others)
            .ToArray();

        public string Execute(string str)
        {
            if (HasDisAllowedCaracters(str))
            {
                throw new InvalidDataException();
            }

            throw new NotImplementedException();
        }

        private static bool HasDisAllowedCaracters(string str)
        {
            return !str.ToArrayOfStrings().Any(s => AllowedCaracters.Contains(s));
        }
    }
}
