namespace CoderbyteChallenges.Easy
{
    using System.Linq;
    using Tools;

    public class ExOh
    {
        public bool Execute(string str)
        {
            var groups = str
                .ToArrayOfStrings()
                .GroupBy(s => s)
                .Select(g => new {Letter = g.Key, Count = g.ToList().Count() })
                .ToArray();

            return groups.Count() == 2 
                && groups.Single(g => g.Letter == "o").Count == groups.Single(g => g.Letter == "x").Count;
        }
    }
}
