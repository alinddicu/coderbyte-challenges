namespace CoderbyteChallenges.Tools
{
    using System.Collections.Generic;
    using System.Linq;

    public static class StringExtensions
    {
        public static string[] ToArrayOfStrings(this string str)
        {
            return str.ToArray().Select(c => c + string.Empty).ToArray();
        }

        public static bool IsLetter(this string str)
        {
            return str.Length == 1 && char.IsLetter(str[0]);
        }

        public static IEnumerable<int> IndexesOf(this string str, char carac)
        {
            return str
                .ToCharArray()
                .Select((x, i) => new { Char = x, Index = i })
                .Where(g => g.Char == carac)
                .Select(o => o.Index);
        }
    }
}
