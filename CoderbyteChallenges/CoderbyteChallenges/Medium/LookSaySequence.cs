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
            var strings = num
                .ToString(CultureInfo.InvariantCulture)
                .ToArrayOfStrings();

            var groups = new List<DigitGroup>();
            var lastString = string.Empty;
            for (var i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (lastString == s)
                {
                    groups.Last().Count++;
                }
                else
                {
                    groups.Add(new DigitGroup(s));
                }

                lastString = s;
            }

            return int.Parse(groups
                .Select(o => o.Count.ToString(CultureInfo.InvariantCulture) + o.Letter)
                .Join());
        }

        private class DigitGroup
        {
            public DigitGroup(string letter) 
            {
                Letter = letter;
                Count = 1;
            }

            public string Letter { get; private set; }

            public int Count { get; set; }
        }
    }
}
