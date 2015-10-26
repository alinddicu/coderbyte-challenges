namespace CoderbyteChallenges.Hard.ShortestPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortestPath
    {
        // https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm

        private int _nodesCount;
        private Node[] _nodes;
        private Link[] _links;

        public IEnumerable<string> Execute(params string[] parameters)
        {
            _nodesCount = int.Parse(parameters[0]);
            _nodes = ParseNodes(parameters).ToArray();
            _links = ParseLinks(parameters).ToArray();

            throw new NotImplementedException();
        }

        private IEnumerable<Link> ParseLinks(string[] parameters)
        {
            for (var i = _nodesCount + 1; i < parameters.Length; i++)
            {
                yield return new Link(parameters[i]);
            }
        }

        private IEnumerable<Node> ParseNodes(string[] parameters)
        {
            for (var i = 1; i < _nodesCount + 1; i++)
            {
                yield return new Node(parameters[i]);
            }
        }

        private struct Link
        {
            public Link(string linkStr)
                : this()
            {
                var nodes = linkStr.Split('-');
                Start = new Node(nodes[0]);
                End = new Node(nodes[1]);
            }

            public Node End { get; private set; }

            public Node Start { get; private set; }

            public override string ToString()
            {
                return string.Format("{0} <-> {1}", Start, End);
            }
        }

        private struct Node
        {
            private string _name;

            public Node(string name)
            {
                _name = name;
            }

            public override string ToString()
            {
                return _name;
            }
        }
    }
}
