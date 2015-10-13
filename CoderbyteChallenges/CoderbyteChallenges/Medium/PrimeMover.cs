namespace CoderbyteChallenges.Medium
{
    using System.Linq;
    using Tools;

    public class PrimeMover
    {
        public int Execute(int nthPrimeNumber)
        {
            var primeNumbers = new PrimeNumbers().Execute(10000).ToArray();

            return primeNumbers[nthPrimeNumber - 1];
        }
    }
}
