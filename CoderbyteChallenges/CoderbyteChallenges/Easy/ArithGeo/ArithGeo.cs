namespace CoderbyteChallenges.Easy.ArithGeo
{
    using System.Linq;

    public class ArithGeo
    {
        private readonly IArithGeoResolver[] _resolvers = new IArithGeoResolver[]
        {
            new ArithmetricResolver(), 
            new GeometricResolver(), 
            new NoneResolver(), 
        };

        public ArithGeoType Execute(params int[] numbers)
        {
            return _resolvers.First(r => r.CanResolve(numbers)).Resolve();
        }
    }
}
