namespace CoderbyteChallenges
{
    using System.Collections.Generic;
    using System.Linq;

    public class AbCheck
    {
        public bool Execute(string str)
        {
            foreach (var indexOfA in GetIndexesOfA(str).ToArray())
            {
                var expectedIndexOfB = indexOfA + 4;
                var indexOfB = str.IndexOf('b', indexOfA);
                if (indexOfB == expectedIndexOfB)
                {
                    return true;
                }
            }

            return false;
        }

        private static IEnumerable<int> GetIndexesOfA(string str)
        {
            return str
                .ToCharArray()
                .Select((x, i) => new { X = x, Index = i })
                .Where(g => g.X == 'a')
                .Select(o => o.Index);
        }
    }
}
