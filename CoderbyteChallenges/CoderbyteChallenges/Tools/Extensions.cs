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

        public static IEnumerable<T> Permute<T>(this T[] objects, int position1, int position2)
        {
            var object1 = objects[position1];
            var object2 = objects[position2];

            objects[position1] = object2;
            objects[position2] = object1;

            return objects;
        }
    }
}
