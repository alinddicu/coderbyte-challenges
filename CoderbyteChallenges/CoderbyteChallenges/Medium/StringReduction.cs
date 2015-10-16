namespace CoderbyteChallenges.Medium
{
    using System.Linq;
    using Tools;

    public class StringReduction
    {
        private static readonly string[] Letters = { "a", "b", "c" };

        public string Execute(string str)
        {
            if (str.Length == 1)
            {
                return str;
            }

            if (str.Length == 2 && str.ToArrayOfStrings().GroupBy(s => s).Count() == 1)
            {
                return str;
            }

            if (str.Length == 2 && str.ToArrayOfStrings().GroupBy(s => s).Count() == 2)
            {
                return Reduce(str);
            }

            var toReduce = GetToReduce(str);
            var start = GetStart(str, toReduce);
            var end = str.Substring(2);

            return Execute(start + Reduce(toReduce) + end);
        }

        private string GetStart(string str, string toReduce)
        {
            return str.Substring(0, str.IndexOf(toReduce));
        }

        private string GetToReduce(string str)
        {
            var letter = str
                .ToArrayOfStrings()
                .Select((s, i) => new Letter(s, i))
                .FirstOrDefault(l => CanBeReduced(str, l));

            return letter.S + str.ToArrayOfStrings().ToArray()[letter.Index + 1];
        }

        private string Reduce(string toReduce)
        {
            return Letters.Except(toReduce.ToArrayOfStrings()).Join();
        }

        private bool CanBeReduced(string str, Letter l)
        {
            if (str.Length == 1)
            {
                return false;
            }

            if (l.Index + 2 > str.Length)
            {
                return false;
            }

            var letter = l.S;
            var nextLetter = str.ToArrayOfStrings().ToArray()[l.Index + 1];

            return letter != nextLetter;
        }

        private struct Letter
        {
            public Letter(string s, int index)
                : this()
            {
                S = s;
                Index = index;
            }

            public string S { get; set; }

            public int Index { get; set; }
        }
    }
}
