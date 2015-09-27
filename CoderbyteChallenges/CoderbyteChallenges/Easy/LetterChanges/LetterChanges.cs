namespace CoderbyteChallenges.Easy.LetterChanges
{
    using System.IO;
    using System.Linq;
    using Tools;

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
                new OtherSymbolTranslator(), 
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
            return initString
                .ToArrayOfStrings()
                .Select(GetNextLetter)
                .Join();
        }

        private string GetNextLetter(string symbol)
        {
            var translator = _letterTranslators.SingleOrDefault(o => o.CanTranslate(symbol));
            if (translator == null)
            {
                throw new InvalidDataException("Letter not found : " + symbol);
            }

            return translator.Translate(symbol);
        }

        private static string CapitalizeVowels(string str)
        {
            return str
                .ToArrayOfStrings()
                .Select(l => new {Letter = l, IsVowel = Vowels.Contains(l)})
                .Select(o => o.IsVowel ? o.Letter.ToUpper() : o.Letter)
                .Join();
        }
    }
}
