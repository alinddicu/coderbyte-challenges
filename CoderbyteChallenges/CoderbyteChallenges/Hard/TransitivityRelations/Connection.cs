namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    public struct Connection
    {
        public Connection(Node start, Node end)
            : this()
        {
            Start = start;
            End = end;
        }

        public Node Start { get; private set; }

        public Node End { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", Start, End);
        }
    }
}
