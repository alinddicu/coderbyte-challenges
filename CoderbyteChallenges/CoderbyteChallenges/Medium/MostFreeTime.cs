namespace CoderbyteChallenges.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class MostFreeTime
    {
        public string Execute(IEnumerable<string> evts)
        {
            var events = evts.Select(evt => new Event(evt)).OrderBy(e => e.Start).ToArray();

            var freeTime = events
                .Select((evt, index) => new EventCouple(evt, events.GetNext(index)))
                .Select(o => o.ComputeFreeTime())
                .Aggregate((prev, cur) => prev.Add(cur));

            return FormatFreeTime(freeTime);
        }

        private static string FormatFreeTime(TimeSpan freeTime)
        {
            return string.Format("{0:00}:{1:00}", Math.Truncate(freeTime.TotalHours), freeTime.Minutes);
        }

        private class EventCouple
        {
            private readonly Event _current;
            private readonly Event _next;

            public EventCouple(Event current, Event next)
            {
                _current = current;
                _next = next;
            }

            public TimeSpan ComputeFreeTime()
            {
                return _next == null ? TimeSpan.Zero : _next.Start.Subtract(_current.End);
            }
        }

        private class Event
        {
            public Event(string evt)
            {
                var splits = evt.Split('-');
                var start = PreformatTime(splits[0]);
                var end = PreformatTime(splits[1]);

                Start = ParseExactTime(start);
                End = ParseExactTime(end);
            }

            public DateTime Start { get; private set; }

            public DateTime End { get; private set; }

            private static string PreformatTime(string time)
            {
                return time.Insert(5, " ");
            }

            private static DateTime ParseExactTime(string start)
            {
                return DateTime.ParseExact(start, "h:mm tt", CultureInfo.InvariantCulture);
            }
        }
    }
}
