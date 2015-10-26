namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public struct Transition
    {
        private readonly Node _start;
        private readonly Node _middle;
        private readonly Node _end;

        public Transition(Node start, Node middle, Node end)
            : this()
        {
            _start = start;
            _middle = middle;
            _end = end;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} : {2}", _start, _middle, _end);
        }

        public Connection GetConnection()
        {
            return new Connection(_start, _end);
        }
    }
}
