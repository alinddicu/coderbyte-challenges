namespace CoderbyteChallenges.LetterChanges
{
    public interface ISymbolTranslator
    {
        bool CanTranslate(string symbol);

        string Translate(string symbol);
    }
}
