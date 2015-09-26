namespace CoderbyteChallenges
{
    using System.Linq;
    using Tools;

    public class AlphabetSoup
    {
        public string Execute(string input)
        {
            return input
                .ToArrayOfStrings()
                .OrderBy(s => s)
                .Join();
        }
    }
}
