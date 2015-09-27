namespace CoderbyteChallenges.Easy.ArithGeo
{
    using System.Linq;

    public class GeometricResolver : IArithGeoResolver
    {
        public bool CanResolve(params int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return false;
            }

            var orderedNumbers = numbers.OrderBy(n => n).ToArray();
            var ratio = orderedNumbers[1] / orderedNumbers[0];

            for (var index = 0; index < orderedNumbers.Length - 1; index++)
            {
                if (orderedNumbers[index] * ratio != orderedNumbers[index + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public ArithGeoType Resolve()
        {
            return ArithGeoType.Geometric;
        }
    }
}
