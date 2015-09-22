﻿namespace CoderbyteChallenges.LetterChanges
{
    using Tools;

    public class UpperCaseLetterTranslator : ILetterTranslator
    {
        private readonly CircularArray<string> _array;

        public UpperCaseLetterTranslator(string[] letters)
        {
            _array = new CircularArray<string>(letters);
        }

        public bool CanTranslate(string letter)
        {
            return char.IsLetter(letter[0]) && char.IsUpper(letter[0]);
        }

        public string Translate(string letter)
        {
            var index = _array.FirstIndexOf(letter);
            return _array[index+1];
        }
    }
}
