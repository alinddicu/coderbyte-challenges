namespace CoderbyteChallenges.Medium
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class RunLength
    {
        private readonly List<Group> _groups = new List<Group>();

        public string Execute(string toCompress)
        {
            var letters = toCompress.ToArrayOfStrings();
            var previousLetter = string.Empty;
            foreach (var letter in letters)
            {
                if (letter == previousLetter)
                {
                    _groups.Last().Count++;
                }
                else
                {
                    _groups.Add(new Group(letter));
                }

                previousLetter = letter;
            }

            return _groups.Select(g => g.ToString()).Join();
        }

        private class Group
        {
            private readonly string _letter;

            public Group(string letter)
            {
                _letter = letter;
                Count = 1;
            }

            public int Count { get; set; }

            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "{0}{1}", Count, _letter);
            }
        }
    }
}
