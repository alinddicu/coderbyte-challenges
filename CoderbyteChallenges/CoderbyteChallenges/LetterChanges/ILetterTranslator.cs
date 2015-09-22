namespace CoderbyteChallenges.LetterChanges
{
    public interface ILetterTranslator
    {
        bool CanTranslate(string letter);

        string Translate(string letter);
    }
}
