namespace CoderbyteChallenges.Easy
{
    using System;
    using System.Linq;

    public class LetterCountI
    {
        public string Execute(string str)
        {
            var groups = str
                .Split(" ".ToArray(), StringSplitOptions.None)
                .Select(w => new {Word = w, Count = w.GroupBy(lettre => lettre).Max(g => g.Count())})
                .ToArray();

            var max = groups.Max(g => g.Count);
            if (max == 1)
            {
                return string.Empty;
            }

            return groups.First(g => g.Count == max).Word;
        }
    }
}
