namespace CoderbyteChallenges.Medium
{
    using System.Linq;
    using Tools;

    public class CaesarCipher
    {
        private readonly CircularArray<string> _letterArray;

        public CaesarCipher()
        {
            _letterArray = new CircularArray<string>(Alphabet.LettersLowerCase);
        }

        public string Execute(string phrase, int shift)
        {
            return phrase
                .ToArrayOfStrings()
                .Select(s => _letterArray[ _letterArray.FirstIndexOf(s) + shift])
                .Join();
        }
    }
}
