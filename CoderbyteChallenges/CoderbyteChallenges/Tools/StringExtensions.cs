namespace CoderbyteChallenges.Tools
{
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
    }
}
