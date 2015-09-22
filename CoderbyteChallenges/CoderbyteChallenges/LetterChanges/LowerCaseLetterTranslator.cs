namespace CoderbyteChallenges.LetterChanges
{
    public class LowerCaseLetterTranslator : LetterTranslatorBase
    {
        public LowerCaseLetterTranslator(string[] letters)
            : base(letters)
        {
        }

        public override bool CanTranslate(string symbol)
        {
            return char.IsLetter(symbol[0]) && char.IsLower(symbol[0]);
        }
    }
}
