namespace CoderbyteChallenges.Easy
{
    using System;
    using System.Linq;

    public class LetterCountI
    {
        public string Execute(string str)
        {
            // Hello apple pie
            var groups = str
                .Split(" ".ToArray(), StringSplitOptions.None)
                .Select(w => new {Word = w, G = w.GroupBy(l => l)})
                .ToArray();

            var max = groups.Max(g => g.G.Count());

            return groups.FirstOrDefault(g => g.G.Count() == max).Word;
        }
    }
}
