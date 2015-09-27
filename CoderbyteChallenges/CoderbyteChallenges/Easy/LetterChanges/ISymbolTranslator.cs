namespace CoderbyteChallenges.Easy.LetterChanges
{
    public interface ISymbolTranslator
    {
        bool CanTranslate(string symbol);

        string Translate(string symbol);
    }
}
