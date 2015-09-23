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
            words = Capitalize(words);
            return JoinCapitalized(words);
        }

        private static string[] SplitIntoWords(string input)
        {
            return input.Split(new[] { Delimiter }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static string[] Capitalize(string[] words)
        {
            return words.Select(w => Capitalize(w)).ToArray();
        }

        private static string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Remove(0, 1);
        }

        private static string JoinCapitalized(string[] words)
        {
            return string.Join(Delimiter, words);
        }
    }
}
