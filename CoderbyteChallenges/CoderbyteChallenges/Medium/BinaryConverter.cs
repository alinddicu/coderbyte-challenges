namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class BinaryConverter
    {
        public int Execute(int binaryNumber)
        {
            return binaryNumber
                .ToString(CultureInfo.InvariantCulture)
                .ToArrayOfStrings()
                .Reverse()
                .Select((s, i) => new { S = s, Index = i })
                .Select(o => int.Parse(o.S) * (int)Math.Pow(2, o.Index))
                .Sum(i => i);
        }
    }
}
