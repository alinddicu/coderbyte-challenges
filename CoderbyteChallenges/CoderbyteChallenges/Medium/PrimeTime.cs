namespace CoderbyteChallenges.Medium
{
    using System.Linq;

    public class PrimeTime
    {
        public bool Execute(int number)
        {
            if (number < 3)
            {
                return false;
            }

            return Enumerable
                .Range(2, number - 2)
                .All(n => number % n != 0);
        }
    }
}
