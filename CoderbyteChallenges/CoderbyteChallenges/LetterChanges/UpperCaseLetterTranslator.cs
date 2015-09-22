﻿namespace CoderbyteChallenges.LetterChanges
{
    public class UpperCaseLetterTranslator : LetterTranslatorBase
    {
        public UpperCaseLetterTranslator(string[] letters)
            : base(letters)
        {
        }

        public override bool CanTranslate(string symbol)
        {
            return char.IsUpper(symbol[0]) && ContainsLetter(symbol);
        }
    }
}
