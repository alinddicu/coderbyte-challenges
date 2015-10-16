namespace CoderbyteChallenges.Medium
{
    using System.Linq;
    using Tools;

    public class StringReduction
    {
        private static readonly string[] Letters = { "a", "b", "c" };

        public string Execute(string str)
        {
            if (str.Length == 2 && CountDistinctLetters(str) == 1)
            {
                return str;
            }

            var toReduce = GetToReduce(str);
            var start = GetStart(str, toReduce);
            var end = str.Substring(2);

            return Execute(start + Reduce(toReduce) + end);
        }

        private static int CountDistinctLetters(string str)
        {
            return str.ToArrayOfStrings().GroupBy(s => s).Count();
        }

        private string GetStart(string str, string toReduce)
        {
            return str.Substring(0, str.IndexOf(toReduce));
        }

        private static string GetToReduce(string str)
        {
            var letter = str
                .ToArrayOfStrings()
                .Select((s, i) => new LetterInfo(s, i))
                .FirstOrDefault(l => CanBeReduced(str, l));

            return letter.Letter + str[letter.Index + 1].ToString();
        }

        private static string Reduce(string toReduce)
        {
            return Letters.Except(toReduce.ToArrayOfStrings()).Join();
        }

        private static bool CanBeReduced(string str, LetterInfo l)
        {
            if (str.Length == 1)
            {
                return false;
            }

            if (l.Index + 2 > str.Length)
            {
                return false;
            }

            var letter = l.Letter;
            var nextLetter = str[l.Index + 1].ToString();

            return letter != nextLetter;
        }

        private struct LetterInfo
        {
            public LetterInfo(string letter, int index)
                : this()
            {
                Letter = letter;
                Index = index;
            }

            public string Letter { get; set; }

            public int Index { get; set; }
        }
    }
}
