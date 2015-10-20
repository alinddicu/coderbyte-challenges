namespace CoderbyteChallenges.Tools
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using NFluent;

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

        public static IEnumerable<int> ToArrayOfInts(this int number)
        {
            return number
                .ToString(CultureInfo.InvariantCulture)
                .ToArrayOfStrings()
                .Select(int.Parse);
        }

        public static T GetNext<T>(this IList<T> objects, int index)
        {
            if (index > objects.Count() - 2)
            {
                return default(T);
            }

            return objects[index + 1];
        }
    }
}
