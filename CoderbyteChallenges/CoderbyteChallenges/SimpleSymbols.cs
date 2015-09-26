namespace CoderbyteChallenges
{
    using System.IO;
    using System.Linq;
    using Tools;

    public class SimpleSymbols
    {
        private static readonly string[] Digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static readonly string[] LettersLowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "symbol", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string[] LettersCapitalCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static readonly string[] Letters = LettersLowerCase.Concat(LettersCapitalCase).ToArray();

        private static readonly string[] LettersAndDigits = Digits.Concat(Letters).ToArray();
        private static readonly string[] Others = { "=", "+" };

        private static readonly string[] AllowedCaracters = LettersAndDigits.Concat(Others).ToArray();

        public bool Execute(string str)
        {
            if (HasDisallowedCaracters(str))
            {
                throw new InvalidDataException("Input string has disallowed caracters");
            }

            return str
                .ToArrayOfStrings()
                .Select((s, i) => new {Symbol = s, Index = i})
                .Where(o => IsAllowedSymbol(o.Symbol))
                .All(o => HasPlusAtLeft(str, o.Index) && HasPlusAtRight(str, o.Index));
        }

        private static bool IsAllowedSymbol(string symbol)
        {
            return !(Others.Contains(symbol) || Digits.Contains(symbol));
        }

        private static bool HasPlusAtLeft(string str, int index)
        {
            if (index == 0)
            {
                return false;
            }

            if (str[index - 1] == '+')
            {
                return true;
            }

            return false;
        }

        private bool HasPlusAtRight(string str, int index)
        {
            if (index == str.Length - 1)
            {
                return false;
            }

            if (str[index + 1] == '+')
            {
                return true;
            }

            return false;
        }

        private static bool HasDisallowedCaracters(string str)
        {
            return !str.ToArrayOfStrings().Any(s => AllowedCaracters.Contains(s));
        }
    }
}
