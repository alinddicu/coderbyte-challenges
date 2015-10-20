namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Tools;

    public class MultipleBrackets
    {
        private static readonly IEnumerable<string> LeftBrackets = new[] { "(", "[" };
        private static readonly IEnumerable<string> RightBrackets = new[] { ")", "]" };
        private static readonly IEnumerable<string> Brackets = LeftBrackets.Union(RightBrackets);

        public MultipleBracketsResult Execute(string phrase)
        {
            var brackets = phrase.ToArrayOfStrings().Where(c => Brackets.Contains(c));
            var leftBrackets = brackets.Where(c => LeftBrackets.Contains(c));
            var rightBrackets = brackets.Where(c => RightBrackets.Contains(c));

            return new MultipleBracketsResult(leftBrackets.Count() == rightBrackets.Count());

            throw new NotImplementedException();
        }
    }

    public struct MultipleBracketsResult
    {
        private bool _bracketsMatch;

        public MultipleBracketsResult(bool bracketsMatch)
        {
            _bracketsMatch = bracketsMatch;
        }
    }
}
