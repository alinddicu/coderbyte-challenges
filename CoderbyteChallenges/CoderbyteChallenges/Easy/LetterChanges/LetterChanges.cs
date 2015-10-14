namespace CoderbyteChallenges.Easy.LetterChanges
{
    using System.IO;
    using System.Linq;
    using Tools;

    public class LetterChanges
    {
        private readonly ISymbolTranslator[] _letterTranslators;

        public LetterChanges()
        {
            _letterTranslators = new ISymbolTranslator[]
            {
                new OtherSymbolTranslator(), 
                new LowerCaseLetterTranslator(Alphabet.LettersLowerCase), 
                new UpperCaseLetterTranslator(Alphabet.LettersCapitalCase)
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
                .Select(l => new {Letter = l, IsVowel = Alphabet.Vowels.Contains(l)})
                .Select(o => o.IsVowel ? o.Letter.ToUpper() : o.Letter)
                .Join();
        }
    }
}
