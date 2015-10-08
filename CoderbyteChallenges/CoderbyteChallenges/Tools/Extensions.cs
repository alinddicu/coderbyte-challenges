namespace CoderbyteChallenges.Tools
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static int Multiply(this IEnumerable<int> intsEnum)
        {
            var intsList = intsEnum.ToArray();

            return !intsList.Any() ? 0 : intsList.Aggregate(1, (current, t) => current * t);
        }
    }
}
