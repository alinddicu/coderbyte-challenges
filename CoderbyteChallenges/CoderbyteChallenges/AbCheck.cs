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
            var chars = str.ToCharArray();
            for (var index = 0; index < chars.Length; index++)
            {
                if (chars[index] == 'a')
                {
                    yield return index;
                }
            }
        }
    }
}
