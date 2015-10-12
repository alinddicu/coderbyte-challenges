namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Linq;

    public class PrimeTime
    {
        public bool Execute(int number)
        {
            if (number < 3)
            {
                return false;
            }

            var numbers = new int[number - 3];
            for (var i = 2; i < number - 1; i++)
            {
                numbers[i - 2] = i;
            }

            return numbers.All(n => number % n != 0);
        }
    }
}
