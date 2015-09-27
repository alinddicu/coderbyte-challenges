namespace CoderbyteChallenges.ArithGeo
{
    using System.Linq;

    public class ArithGeo
    {
        private readonly IArithGeoResolver[] resolvers = new IArithGeoResolver[]
        {
            new ArithmetricResolver(), 
            new GeometricResolver(), 
            new NoneResolver(), 
        };

        public ArithGeoType Execute(params int[] numbers)
        {
            return resolvers.First(r => r.CanResolve(numbers)).Resolve();
        }
    }
}
