namespace CoderbyteChallenges.Hard
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Tools;

    public class TransitivityRelations
    {
        private static readonly string[] RemovableChars = { "(", ")", "," };

        public TransitivityRelationsResult Execute(params string[] stringMatrixes)
        {
            var matrix = new Matrix(stringMatrixes);
            return matrix.IsTransitive();
        }

        private class Matrix
        {
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
                        line =>
                            line
                            .ToArrayOfStrings()
                            .Where(s => !RemovableChars.Contains(s))
                            .Select(int.Parse)
                            .ToArray()).ToArray();
            }

            public TransitivityRelationsResult IsTransitive()
            {
                var isTransitive =
                    _transitions.All(
                        t => _connections.Contains(t.GetConnection()));

                var missingConnections = _transitions.Where(
                    t => !_connections.Contains(t.GetConnection()))
                         .Select(t => t.GetConnection());

                return new TransitivityRelationsResult(isTransitive, missingConnections.Select(c => c.ToString()));
            }

            private struct Node
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

            private struct Connection
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
                    return string.Format("({0},{1})", Start, End);
                }
            }

            private struct Transition
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

                public Connection GetReverseConnection()
                {
                    return new Connection(_end, _start);
                }
            }
        }

        public class TransitivityRelationsResult
        {
            public TransitivityRelationsResult(bool isTransitive, IEnumerable<string> missingConnections)
            {
                IsTransitive = isTransitive;
                MissingConnections = missingConnections;
            }

            public bool IsTransitive { get; private set; }

            public IEnumerable<string> MissingConnections { get; private set; }
        }
    }
}
