namespace CoderbyteChallenges
{
    using System.Collections.Generic;
    using System.Linq;

    public class AbCheck
    {
        public bool Execute(string str)
        {
            return GetIndexesOfA(str)
                .Select(index => str.IndexOf('b', index))
                .Any(index => index % 4 == 0);
        }

        private static IEnumerable<int> GetIndexesOfA(string str)
        {
            return str
                .ToCharArray()
                .Select((x, i) => new { Char = x, Index = i })
                .Where(g => g.Char == 'a')
                .Select(o => o.Index);
        }
    }
}
