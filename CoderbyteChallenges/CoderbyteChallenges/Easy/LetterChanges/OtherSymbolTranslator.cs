namespace CoderbyteChallenges.Easy.LetterChanges
{
    using Tools;

    public class OtherSymbolTranslator : ISymbolTranslator
    {
        public bool CanTranslate(string symbol)
        {
            return !symbol.IsLetter();
        }

        public string Translate(string symbol)
        {
            return symbol;
        }
    }
}
