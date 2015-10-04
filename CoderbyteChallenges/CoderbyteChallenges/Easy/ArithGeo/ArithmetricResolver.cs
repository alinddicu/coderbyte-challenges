namespace CoderbyteChallenges.Easy.ArithGeo
{
    public class ArithmetricResolver : ProgressionResolverBase
    {
        public ArithmetricResolver()
            : base(GetRatio, CheckProgression)
        {
        }

        private static bool CheckProgression(int[] orderedNumbers, int index, int ratio)
        {
            return orderedNumbers[index] + ratio != orderedNumbers[index + 1];
        }

        private static int GetRatio(int[] orderedNumbers)
        {
            return orderedNumbers[1] - orderedNumbers[0];
        }

        public override ArithGeoType Resolve()
        {
            return ArithGeoType.Arithmetic;
        }
    }
}
