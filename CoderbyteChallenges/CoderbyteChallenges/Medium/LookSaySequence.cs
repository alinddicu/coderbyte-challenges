namespace CoderbyteChallenges.Medium
{
    using System;
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

            var groups = new List<List<string>>();
            var lastString = strings.First();
            var group = new List<string>();
            for (var i = 0; i < strings.Length; i++)
            {
                var s = strings[i];
                if (lastString == s)
                {
                    group.Add(s);
                    if (i == strings.Length - 1)
                    {
                        groups.Add(group);
                    }
                }
                else
                {
                    groups.Add(group);
                    group = new List<string> { s };
                }

                lastString = s;
            }

            return int.Parse(groups
                .Select(g => new { Digit = g.First(), Count = g.Count() })
                .Select(o => o.Count.ToString(CultureInfo.InvariantCulture) + o.Digit)
                .Join());

            throw new NotImplementedException();
        }
    }
}
