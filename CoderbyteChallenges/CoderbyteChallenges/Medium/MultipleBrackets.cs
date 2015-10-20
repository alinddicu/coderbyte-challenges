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

        private static readonly InvalidPair[] InvalidPairs = new[]
        {
            new InvalidPair("(", "]"),
            new InvalidPair("[", ")")
        };

        public MultipleBracketsResult Execute(string phrase)
        {
            var brackets = phrase.ToArrayOfStrings().Where(c => Brackets.Contains(c)).ToArray();
            if (!IsLeftEqualsRight(brackets))
            {
                return MultipleBracketsResult.False;
            }

            if (!IsOpeningSameAsClosing(brackets))
            {
                return MultipleBracketsResult.False;
            }

            return new MultipleBracketsResult(true, brackets.Count(c => LeftBrackets.Contains(c)));
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
                .Select((b, index) => new InvalidPair(b, GetSecond(brackets, index)))
                .Where(o => LeftBrackets.Contains(o.First))
                .Any(o => InvalidPairs.Contains(o));
        }

        private string GetSecond(string[] brackets, int index)
        {
            if (index > brackets.Length - 2)
            {
                return string.Empty;
            }

            return brackets[index + 1];
        }

        private struct InvalidPair
        {
            public InvalidPair(string first, string second)
                : this()
            {
                First = first;
                Second = second;
            }

            public string First { get; private set; }

            public string Second { get; private set; }
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
