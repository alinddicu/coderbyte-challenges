namespace CoderbyteChallenges
{
    public class LongestWord
    {
        public string Execute(string phrase)
        {
            var words = phrase.Split(' ');

            var longestWord = string.Empty;
            foreach(var word in words)
            {
                if (IsNotLongestWord(longestWord, word))
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        private static bool IsNotLongestWord(string longestWord, string word)
        {
            return word.Length > longestWord.Length;
        }
    }
}
