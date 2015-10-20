namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MostFreeTime
    {
        public string Execute(IEnumerable<string> evts)
        {
            var events = evts.Select(evt => new Event(evt)).OrderBy(e => e.Start).ToArray();

            var freeTime = TimeSpan.Zero;
            var enumerator = events.GetEnumerator();
            Event previous = null;
            while (enumerator.MoveNext())
            {
                var current = (Event)enumerator.Current;
                if (previous != null)
                {
                    freeTime = freeTime.Add(current.Start.Subtract(previous.End));
                }

                previous = current;
            }

            return string.Format("{0:00}:{1:00}", Math.Truncate(freeTime.TotalHours), freeTime.Minutes);
        }

        private DateTime GetNextEvent(Event evt, int index, Event[] events)
        {
            throw new NotImplementedException();
        }

        private class Event
        {
            public Event(DateTime start, DateTime end)
            {
                Start = start;
                End = end;
            }

            public Event(string evt)
            {
                var splits = evt.Split('-');
                var start = splits[0].Insert(5, ":00 ");
                var end = splits[1].Insert(5, ":00 ");

                Start = DateTime.ParseExact(start, "h:mm:ss tt", CultureInfo.InvariantCulture);
                End = DateTime.ParseExact(end, "h:mm:ss tt", CultureInfo.InvariantCulture);
            }

            public DateTime Start { get; private set; }

            public DateTime End { get; private set; }
        }
    }
}
