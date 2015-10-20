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
            if (!IsLeftEqualsRight(brackets))
            {
                return MultipleBracketsResult.False;
            }

            if (!IsOpeningSameAsClosing(brackets.ToArray()))
            {
                return MultipleBracketsResult.False;
            }

            throw new NotImplementedException();
        }

        private static bool IsLeftEqualsRight(IEnumerable<string> brackets)
        {
            var leftBrackets = brackets.Where(c => LeftBrackets.Contains(c));
            var rightBrackets = brackets.Where(c => RightBrackets.Contains(c));

            return leftBrackets.Count() == rightBrackets.Count();
        }

        private bool IsOpeningSameAsClosing(string[] brackets)
        {
            return !brackets
                .Select((b, index) => new { First = b, Second = GetSecond(brackets, index) })
                .Any(o => LeftBrackets.Contains(o.First) && !RightBrackets.Contains(o.Second));
        }

        private string GetSecond(string[] brackets, int index)
        {
            if (index > brackets.Length - 2)
            {
                return string.Empty;
            }

            return brackets[index + 1];
        }
    }

    public struct MultipleBracketsResult
    {
        public static MultipleBracketsResult False = new MultipleBracketsResult(false);

        private readonly bool _bracketsMatch;
        private readonly int _bracketsPairs;

        public MultipleBracketsResult(bool bracketsMatch, int bracketsPairs = 0)
        {
            _bracketsMatch = bracketsMatch;
            _bracketsPairs = bracketsPairs;
        }
    }
}
