namespace CoderbyteChallenges.LetterChanges
{
    public class NonLetterTranslator : ILetterTranslator
    {
        public bool CanTranslate(string symbol)
        {
            return !char.IsLetter(symbol[0]);
        }

        public string Translate(string letter)
        {
            return letter;
        }
    }
}
