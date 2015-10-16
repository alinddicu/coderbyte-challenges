namespace CoderbyteChallenges.Easy
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class MultiplicativePersistence
    {
        public int Execute(int number)
        {
            var times = 0;
            while (number > 9)
            {
                number = number.ToArrayOfInts().Multiply();
                times++;
            }

            return times;
        }
    }
}
