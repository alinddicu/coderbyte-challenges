namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Linq;
    using Tools;

    public class BinaryConverter
    {
        public int Execute(int binaryNumber)
        {
            return binaryNumber
                .ToArrayOfInts()
                .Reverse()
                .Select((i, index) => new { Int = i, Index = index })
                .Select(o => o.Int * (int)Math.Pow(2, o.Index))
                .Sum(i => i);
        }
    }
}
