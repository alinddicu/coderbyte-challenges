namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Linq;
    using Tools;

    public class RunLength
    {
        public string Execute(string toCompress)
        {
            //return toCompress
            //    .ToArrayOfStrings()
            //    .Select((s, i) => new { S = s, Index = i })
            //    .Select(o => new { o.S, IsSameNext = IsSameNext(toCompress, o.S, o.Index) })
            //    .GroupBy(o => new {} )
            //    .Join();

            throw new NotImplementedException();
        }

        private static bool IsSameNext(string toCompress, string c, int index)
        {
            if (index > toCompress.Length - 2)
            {
                return false;
            }

            return c == toCompress.ToArrayOfStrings().ToArray()[index];
        }
    }
}
