namespace CoderbyteChallenges.Medium
{
    using System.Collections.Generic;
    using System.Linq;
    using Tools;

    public class StringScramble
    {
        public bool Execute(string random, string word)
        {
            var wordLetterInfos = WordToLetterInfos(word);
            var randomLetterInfos = WordToLetterInfos(random);

            return wordLetterInfos.All(w => randomLetterInfos.SingleOrDefault(r => w.Letter == r.Letter).Count >= w.Count);
        }

        private static IEnumerable<LetterInfo> WordToLetterInfos(string word)
        {
            return word
                    .ToArrayOfStrings()
                    .GroupBy(l => l)
                    .Select(g => new LetterInfo(g.Key, g.Count()));
        }

        private struct LetterInfo
        {
            public LetterInfo(string letter, int count)
                : this()
            {
                Letter = letter;
                Count = count;
            }

            public string Letter { get; private set; }

            public int Count { get; private set; }

            public override string ToString()
            {
                return string.Format("Letter : {0}, Count : {1}", Letter, Count);
            }
        }
    }
}
