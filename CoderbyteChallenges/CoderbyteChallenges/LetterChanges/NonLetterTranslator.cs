namespace CoderbyteChallenges.LetterChanges
{
    public class NonLetterTranslator : ISymbolTranslator
    {
        public bool CanTranslate(string symbol)
        {
            return !char.IsLetter(symbol[0]);
        }

        public string Translate(string symbol)
        {
            return symbol;
        }
    }
}
