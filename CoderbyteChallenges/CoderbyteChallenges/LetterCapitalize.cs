namespace CoderbyteChallenges
{
    using System;
    using System.Linq;

    public class LetterCapitalize
    {
        private static readonly string Delimiter = " ";

        public string Execute(string input)
        {
            var words = SplitIntoWords(input);
            return string.Join(Delimiter, words.Select(w => CapitalizeWord(w)));
        }

        private static string[] SplitIntoWords(string input)
        {
            return input.Split(new[] { Delimiter }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static string CapitalizeWord(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Remove(0, 1);
        }
    }
}
