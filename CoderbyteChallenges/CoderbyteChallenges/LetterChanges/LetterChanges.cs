namespace CoderbyteChallenges.LetterChanges
{
    using System.Linq;

    public class LetterChanges
    {
        private static readonly string[] LettersLowerCase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static readonly string[] LettersCapitalCase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private static readonly string[] Vowels = { "a", "e", "i", "o", "u" };

        private readonly ISymbolTranslator[] _letterTranslators;

        public LetterChanges()
        {
            _letterTranslators = new ISymbolTranslator[]
            {
                new NonLetterTranslator(), 
                new LowerCaseLetterTranslator(LettersLowerCase), 
                new UpperCaseLetterTranslator(LettersCapitalCase)
            };
        }

        public string Execute(string str)
        {
            str = Translate(str);
            str = CapitalizeVowels(str);

            return str;
        }

        private string Translate(string initString)
        {
            var letters = initString.ToArray().Select(c => c + string.Empty);
            var returnString = string.Empty;
            foreach (var letter in letters)
            {
                returnString += GetNextLetter(letter);
            }

            return returnString;
        }

        private string GetNextLetter(string symbol)
        {
            return _letterTranslators.Single(o => o.CanTranslate(symbol)).Translate(symbol);
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
