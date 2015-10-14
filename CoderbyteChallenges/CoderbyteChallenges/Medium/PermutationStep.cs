namespace CoderbyteChallenges.Medium
{
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class PermutationStep
    {
        public int Execute(int num)
        {
            var strings = num.ToString(CultureInfo.InvariantCulture).ToArrayOfStrings().Reverse().ToArray();

            var indexToPermute = strings
                .Select((s, i) => new DigitPosition(s, i))
                .LastOrDefault(o => IsLesser(o, strings));

            if (indexToPermute == null)
            {
                return -1;
            }

            return int.Parse(strings.Permute(indexToPermute.Index, indexToPermute.Index + 1).Reverse().Join());
        }

        private static bool IsLesser(DigitPosition o, string[] strings)
        {
            var nextIndex = o.Index + 1;
            if (nextIndex >= strings.Length)
            {
                return false;
            }

            return int.Parse(o.S) < int.Parse(strings[nextIndex]);
        }

        private class DigitPosition
        {
            public DigitPosition(string s, int index)
            {
                S = s;
                Index = index;
            }

            public string S { get; private set; }

            public int Index { get; private set; }
        }
    }
}
