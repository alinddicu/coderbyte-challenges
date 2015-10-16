namespace CoderbyteChallenges.Medium
{
    using System.Linq;

    public class ThreeFiveMultiples
    {
        public int Execute(int num)
        {
            return Enumerable
                .Range(1, num - 1)
                .Where(n => n % 3 == 0 || n % 5 == 0)
                .Sum(n => n);
        }
    }
}
