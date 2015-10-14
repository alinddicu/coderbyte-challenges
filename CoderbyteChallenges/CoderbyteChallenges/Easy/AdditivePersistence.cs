﻿namespace CoderbyteChallenges.Easy
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class AdditivePersistence
    {
        public int Execute(int number)
        {
            var times = 0;
            while (number > 9)
            {
                number = ToArrayOfInts(number).Sum(n => n);
                times++;
            }

            return times;
        }

        private static IEnumerable<int> ToArrayOfInts(int number)
        {
            return number
                .ToString(CultureInfo.InvariantCulture)
                .ToArrayOfStrings()
                .Select(int.Parse);
        }
    }
}