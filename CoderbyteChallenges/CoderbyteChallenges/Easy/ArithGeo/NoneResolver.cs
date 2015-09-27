namespace CoderbyteChallenges.Easy.ArithGeo
{
    public class NoneResolver : IArithGeoResolver
    {
        public bool CanResolve(params int[] numbers)
        {
            return true;
        }

        public ArithGeoType Resolve()
        {
            return ArithGeoType.None;
        }
    }
}
