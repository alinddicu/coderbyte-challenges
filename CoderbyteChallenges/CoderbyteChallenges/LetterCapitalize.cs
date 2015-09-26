namespace CoderbyteChallenges
{
    using System;
    using System.Linq;
    using Tools;

    public class LetterCapitalize
    {
        private const string Delimiter = " ";

        public string Execute(string input)
        {
            return input
                .Split(new[] { Delimiter }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => new { FirstLetter = GetFirstLetterOfWord(w), RestOfWord = GetRestOfWord(w) })
                .Select(o => (o.FirstLetter.ToUpper() + o.RestOfWord))
                .Join(Delimiter);
        }

        private static string GetRestOfWord(string w)
        {
            return w.Substring(1, w.Length - 1);
        }

        private static string GetFirstLetterOfWord(string w)
        {
            return w.Substring(0, 1);
        }
    }
}
