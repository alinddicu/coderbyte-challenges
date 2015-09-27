namespace CoderbyteChallenges.Easy
{
    using System.Linq;

    public class VowelCount
    {
        private static readonly char[] Letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
        private static readonly char[] Consons = Letters.Except(Vowels).ToArray();

        public int Execute(string str)
        {
            return str.ToCharArray().Except(Consons).Count();
        }
    }
}
