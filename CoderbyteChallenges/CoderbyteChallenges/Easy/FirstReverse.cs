namespace CoderbyteChallenges.Easy
{
    using System.Linq;
    using Tools;

    public class FirstReverse
    {
        public string Execute(string str)
        {
            return str
                .ToArrayOfStrings()
                .Reverse()
                .Join();
        }
    }
}
