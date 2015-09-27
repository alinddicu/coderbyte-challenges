namespace CoderbyteChallenges.Easy.LetterChanges
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

        protected bool Contains(string letter)
        {
            return letter.IsLetter() && _array.FirstIndexOf(letter) > -1;
        }
    }
}
