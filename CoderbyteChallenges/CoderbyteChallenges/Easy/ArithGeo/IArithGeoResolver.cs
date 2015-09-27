namespace CoderbyteChallenges.Easy.ArithGeo
{
    public interface IArithGeoResolver
    {
        bool CanResolve(params int[] numbers);

        ArithGeoType Resolve();
    }
}
