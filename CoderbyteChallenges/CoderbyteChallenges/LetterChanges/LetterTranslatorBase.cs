namespace CoderbyteChallenges.LetterChanges
{
    using Tools;

    public abstract class LetterTranslatorBase : ISymbolTranslator
    {
        private readonly CircularArray<string> _array;

        protected LetterTranslatorBase(string[] letters)
        {
            _array = new CircularArray<string>(letters);
        }

        public abstract bool CanTranslate(string symbol);

        public string Translate(string symbol)
        {
            var index = _array.FirstIndexOf(symbol);
            return _array[index + 1];
        }

        protected bool ContainsLetter(string letter)
        {
            return char.IsLetter(letter[0]) && _array.FirstIndexOf(letter) > -1;
        }
    }
}
