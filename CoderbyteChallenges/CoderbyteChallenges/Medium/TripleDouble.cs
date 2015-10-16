namespace CoderbyteChallenges.Medium
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class TripleDouble
    {
        public bool Execute(int tripleInt, int doubleInt)
        {
            var tripleDigits = ToDigitGroup(tripleInt, 3);
            var doubleDigits = ToDigitGroup(doubleInt, 2);

            return tripleDigits.Any(t => doubleDigits.Select(d => d.Digit).Contains(t.Digit));
        }

        private static IEnumerable<DigitGroup> ToDigitGroup(int tripleInt, int groupCount)
        {
            return tripleInt
                .ToString(CultureInfo.InvariantCulture)
                .ToArrayOfStrings()
                .GroupBy(o => o)
                .Select(g => new DigitGroup(g.Key, g.Count()))                
                .Where(d => d.Count >= groupCount);
        }

        private struct DigitGroup
        {
            public DigitGroup(string digit, int count) : this()
            {
                Digit = digit;
                Count = count;
            }

            public string Digit { get; private set; }

            public int Count { get; private set; }
        }
    }
}
