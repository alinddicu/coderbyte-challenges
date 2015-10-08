namespace CoderbyteChallenges.Tools
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static int Multiply(this IEnumerable<int> intsEnum)
        {
            var intsList = intsEnum.ToArray();
            if (!intsList.Any())
            {
                return 0;
            }

            var product = 1;
            for (var index = 0; index < intsList.Length; index++)
            {
                product *= intsList[index];
            }

            return product;
        }
    }
}
