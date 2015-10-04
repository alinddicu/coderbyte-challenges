namespace CoderbyteChallenges.Easy.ArithGeo
{
    using System;
    using System.Linq;

    public abstract class ProgressionResolverBase : IArithGeoResolver
    {
        private readonly Func<int[], int> _getRatio;
        private readonly Func<int[], int, int, bool> _checkProgression;

        protected ProgressionResolverBase(
            Func<int[], int> getRatio,
            Func<int[], int, int, bool> checkProgression)
        {
            _getRatio = getRatio;
            _checkProgression = checkProgression;
        }

        public bool CanResolve(params int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return false;
            }

            var orderedNumbers = numbers.OrderBy(n => n).ToArray();
            var ratio = _getRatio(orderedNumbers);

            for (var index = 0; index < orderedNumbers.Length - 1; index++)
            {
                if (_checkProgression(orderedNumbers, index, ratio))
                {
                    return false;
                }
            }

            return true;
        }

        public abstract ArithGeoType Resolve();
    }
}
