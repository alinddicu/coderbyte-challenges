namespace CoderbyteChallenges.Easy
{
    using System.Linq;
    using Tools;

    public class DashInsert
    {
        public string Execute(string str)
        {
            return str
                .ToArrayOfStrings()
                .Select((s, index) => new { S = s, IsOdd = IsOdd(s), IsNextOdd = IsNextOdd(str, index), Index = index })
                .Select(o => new { o.S, Dash = o.IsOdd && o.IsNextOdd ? "-" : string.Empty, o.Index })
                .Select(o => new { S = str[o.Index], o.Dash })
                .Select(o => o.S + o.Dash)
                .Join();
        }

        private static bool IsNextOdd(string str, int index)
        {
            return index < str.Length - 1 && IsOdd(str[index + 1]);
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
