namespace CoderbyteChallenges.Hard
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Configuration;
    using Tools;

    public class TransitivityRelations
    {
        private static readonly string[] RemovableChars = { "(", ")", "," };

        public TransitivityRelationsResult Execute(params string[] stringMatrixes)
        {
            var matrix = new Matrix(stringMatrixes);
            var isTransitive = matrix.IsTransitive();
            if (isTransitive)
            {
                return new TransitivityRelationsResult(true);
            }

            throw new System.NotImplementedException();
        }

        private class Matrix
        {
            private readonly int[][] _members;
            private readonly int _size;
            private readonly Node[] _nodes;
            private Connection[] _connections;

            public Matrix(params string[] stringMatrixes)
            {
                _members = Parse(stringMatrixes);
                _size = _members.First().Length;
                _nodes = Enumerable.Range(0, _size).Select(i => new Node(i)).ToArray();
                _connections = CreateConnections().ToArray();
            }

            private IEnumerable<Connection> CreateConnections()
            {
                foreach (var node in _nodes)
                {
                    var connection = new Connection(node);
                    for (var j = 0; j < _size; j++)
                    {
                        if (_members[node.Position][j] == 1)
                        {
                            connection.Add(new Node(j));
                        }
                    }

                    yield return connection;
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

            public bool IsTransitive()
            {


                return false;
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
                    return Position.ToString();
                }
            }

            private struct Connection
            {
                private Node _node;
                private readonly List<Node> _neighbours;

                public Connection(Node node)
                    : this()
                {
                    _node = node;
                    _neighbours = new List<Node>();
                }

                public void Add(Node node)
                {
                    _neighbours.Add(node);
                }

                public override string ToString()
                {
                    return string.Format("{0} : [{1}]", _node, _neighbours.Select(n => n.ToString()).Join(", "));
                }
            }
        }

        public class TransitivityRelationsResult
        {
            public TransitivityRelationsResult(bool isTransitive)
            {
                IsTransitive = isTransitive;
            }

            public bool IsTransitive { get; private set; }
        }
    }
}
