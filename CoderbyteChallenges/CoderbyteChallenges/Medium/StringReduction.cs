namespace CoderbyteChallenges.Medium
{
    using System.Linq;
    using Tools;

    public class StringReduction
    {
        private static readonly string[] Letters = { "a", "b", "c" };

        private string _previousStr;

        public string Execute(string str)
        {
            while (true)
            {
                if (str == _previousStr)
                {
                    return str;
                }

                if (str.Length == 2 && CountDistinctLetters(str) == 1)
                {
                    return str;
                }

                var toReduce = GetToReduce(str);
                var start = GetStart(str, toReduce);
                var end = str.Substring(2);

                _previousStr = str;
                str = start + Reduce(toReduce) + end;
            }
        }

        private static int CountDistinctLetters(string str)
        {
            return str.ToArrayOfStrings().GroupBy(s => s).Count();
        }

        private static string GetStart(string str, string toReduce)
        {
            return str.Substring(0, str.IndexOf(toReduce, System.StringComparison.Ordinal));
        }

        private static string GetToReduce(string str)
        {
            var letterInfo = str
                .ToArrayOfStrings()
                .Select((s, i) => new LetterInfo(s, i))
                .FirstOrDefault(l => CanBeReduced(str, l));

            if (letterInfo == null)
            {
                return str.Substring(0, 2);
            }

            return letterInfo.Letter + str[letterInfo.Index + 1].ToString();
        }

        private static string Reduce(string toReduce)
        {
            if (CountDistinctLetters(toReduce) != 2)
            {
                return toReduce;
            }

            return Letters.Except(toReduce.ToArrayOfStrings()).Join();
        }

        private static bool CanBeReduced(string str, LetterInfo l)
        {
            if (l.Index + 2 > str.Length)
            {
                return false;
            }

            var letter = l.Letter;
            var nextLetter = str[l.Index + 1].ToString();

            return letter != nextLetter;
        }

        private class LetterInfo
        {
            public LetterInfo(string letter, int index)
            {
                Letter = letter;
                Index = index;
            }

            public string Letter { get; private set; }

            public int Index { get; private set; }
        }
    }
}
