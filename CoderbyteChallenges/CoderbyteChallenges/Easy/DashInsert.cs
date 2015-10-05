namespace CoderbyteChallenges.Easy
{
    using System;
    using System.Linq;
    using Tools;

    public class DashInsert
    {
        public string Execute(string str)
        {
            return str
                .ToArrayOfStrings()
                .Select((s, index) => new { S = s, IsOdd = IsOdd(s), Index = index })
                .Select(
                    o =>
                        new
                        {
                            o.S,
                            o.IsOdd,
                            IsPreviousOdd = o.Index > 0 && IsOdd(str[o.Index]),
                        })
                .Select(o => new { S = o.S, Dash = o.IsOdd && o.IsPreviousOdd ? "-" : string.Empty })
                .Select(o => o.Dash + o.S)
                .Join();
        }

        private static bool IsOdd(string s)
        {
            return int.Parse(s) % 2 == 1;
        }

        private static bool IsOdd(char s)
        {
            return int.Parse(s + "") % 2 == 1;
        }
    }
}
