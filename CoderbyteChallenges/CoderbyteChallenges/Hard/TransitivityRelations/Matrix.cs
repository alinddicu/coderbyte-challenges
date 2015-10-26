namespace CoderbyteChallenges.Hard.TransitivityRelations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Tools;

    public class Matrix
    {
        private static readonly string[] RemovableChars = { "(", ")", "," };

        private readonly int[][] _members;
        private readonly int _size;
        private readonly Node[] _nodes;
        private readonly Connection[] _connections;
        private readonly Transition[] _transitions;

        public Matrix(params string[] stringMatrixes)
        {
            _members = Parse(stringMatrixes);
            _size = _members.First().Length;
            _nodes = Enumerable.Range(0, _size).Select(i => new Node(i)).ToArray();
            _connections = SetConnections().ToArray();
            _transitions = SetTransitions().ToArray();
        }

        private IEnumerable<Transition> SetTransitions()
        {
            foreach (var connection in _connections.Where(c => !c.Start.Equals(c.End)))
            {
                var end =
                    _connections.FirstOrDefault(
                        c => c.Start.Equals(connection.End)
                            && !c.End.Equals(connection.Start)
                            && !connection.End.Equals(c.End));
                if (!end.Equals(default(Connection)))
                {
                    yield return new Transition(connection.Start, connection.End, end.End);
                }
            }
        }

        private IEnumerable<Connection> SetConnections()
        {
            foreach (var node in _nodes)
            {
                for (var j = 0; j < _size; j++)
                {
                    if (_members[node.Position][j] == 1)
                    {
                        yield return new Connection(node, new Node(j));
                    }
                }
            }
        }

        private static int[][] Parse(params string[] stringMatrixes)
        {
            return stringMatrixes
                .Select(
                    line => line
                        .ToArrayOfStrings()
                        .Where(s => !RemovableChars.Contains(s))
                        .Select(int.Parse)
                        .ToArray())
                 .ToArray();
        }

        public TransitivityRelationsResult IsTransitive()
        {
            var missingConnections = _transitions
                .Where(t => !_connections.Contains(t.GetConnection()))
                .Select(t => t.GetConnection())
                .ToArray();

            return new TransitivityRelationsResult(!missingConnections.Any(), missingConnections.Select(c => c.ToString()));
        }
    }
}
