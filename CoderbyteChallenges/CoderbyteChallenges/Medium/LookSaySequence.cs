namespace CoderbyteChallenges.Medium
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class LookSaySequence
    {
        public int Execute(int num)
        {
            var digits = num
                .ToString(CultureInfo.InvariantCulture)
                .ToArrayOfStrings();

            var digitGroups = new List<DigitGroup>();
            var lastDigit = string.Empty;
            foreach (var digit in digits)
            {
                if (lastDigit == digit)
                {
                    digitGroups.Last().Count++;
                }
                else
                {
                    digitGroups.Add(new DigitGroup(digit));
                }

                lastDigit = digit;
            }

            return int.Parse(digitGroups
                .Select(o => o.ToString())
                .Join());
        }

        private class DigitGroup
        {
            private readonly string _letter;

            public DigitGroup(string letter) 
            {
                _letter = letter;
                Count = 1;
            }

            public int Count { get; set; }

            public override string ToString()
            {
                return Count.ToString(CultureInfo.InvariantCulture) + _letter;
            }
        }
    }
}
