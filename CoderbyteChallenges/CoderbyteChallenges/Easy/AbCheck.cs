namespace CoderbyteChallenges.Easy
{
    using System.Linq;
    using Tools;

    public class AbCheck
    {
        public bool Execute(string str)
        {
            return str.IndexesOf('a')
                .Select(index => str.IndexOf('b', index))
                .Any(index => index % 4 == 0);
        }
    }
}
