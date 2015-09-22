namespace CoderbyteChallenges.Tools
{
    using System.Linq;

    public static class StringExtensions
    {
        public static string[] ToArrayOfStrings(this string str)
        {
            return str.ToArray().Select(c => c + string.Empty).ToArray();
        }
    }
}
