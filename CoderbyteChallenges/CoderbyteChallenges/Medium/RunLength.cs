namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Tools;

    public class RunLength
    {
        private readonly List<Group> _groups = new List<Group>();

        public string Execute(string toCompress)
        {
            var letters = toCompress.ToArrayOfStrings();

            var previousLetter = string.Empty;
            foreach (var g in letters.Select((l, i) => new {Letter = l, Index = i }))
            {
                var letter = g.Letter;
                if (!_groups.Any())
                {
                    _groups.Add(new Group(letter, g.Index));
                    previousLetter = letter;

                    continue;
                }

                var group = _groups.Last();
                if (letter == previousLetter)
                {
                    group.Count++;
                }
                else
                {
                    _groups.Add(new Group(letter, g.Index));
                }

                previousLetter = letter;
            }

            return _groups.Select(g => g.ToString()).Join();

            //return toCompress
            //    .ToArrayOfStrings()
            //    .Select((s, i) => new { S = s, Index = i })
            //    .Select(o => new { o.S, IsSameNext = IsSameNext(toCompress, o.S, o.Index) })
            //    .GroupBy(o => new {} )
            //    .Join();

            throw new NotImplementedException();
        }

        private static bool IsSameNext(string toCompress, string c, int index)
        {
            if (index > toCompress.Length - 2)
            {
                return false;
            }

            return c == toCompress.ToArrayOfStrings().ToArray()[index];
        }

        private class Group
        {
            public Group(string letter, int firstLetterGlobalPosition)
            {
                Letter = letter;
                FirstLetterGlobalPosition = firstLetterGlobalPosition;
                Count = 1;
            }

            public string Letter { get; private set; }

            public int Count { get; set; }

            public int FirstLetterGlobalPosition { get; private set; }

            public override string ToString()
            {
                return string.Format("{0}{1}", Count, Letter);
            }
        }
    }
}
