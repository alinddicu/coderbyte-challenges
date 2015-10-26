using System.Globalization;
namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    public struct Node
    {
        public Node(int position)
            : this()
        {
            Position = position;
        }

        public int Position { get; private set; }

        public override string ToString()
        {
            return Position.ToString(CultureInfo.InvariantCulture);
        }
    }
}
