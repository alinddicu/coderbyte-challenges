namespace CoderbyteChallenges.Easy
{
    using System.Linq;
    using Tools;

    public class AdditivePersistence
    {
        public int Execute(int number)
        {
            var times = 0;
            while (number > 9)
            {
                number = number.ToArrayOfInts().Sum(n => n);
                times++;
            }

            return times;
        }
    }
}
