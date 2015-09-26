namespace CoderbyteChallenges
{
    using System;
    using System.Linq;

    public class LongestWord
    {
        public string Execute(string phrase)
        {
            return phrase
                .Split(new[] { " " }, StringSplitOptions.None)
                .Select(w => new { Word = w, w.Length })
                .OrderBy(w => w.Length)
                .Last()
                .Word;
        }
    }
}
