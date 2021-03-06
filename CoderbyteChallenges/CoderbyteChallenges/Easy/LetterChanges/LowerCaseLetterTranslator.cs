﻿namespace CoderbyteChallenges.Easy.LetterChanges
{
    public class LowerCaseLetterTranslator : LetterTranslatorBase
    {
        public LowerCaseLetterTranslator(string[] letters)
            : base(letters)
        {
        }

        public override bool CanTranslate(string symbol)
        {
            return char.IsLower(symbol[0]) && Contains(symbol);
        }
    }
}
