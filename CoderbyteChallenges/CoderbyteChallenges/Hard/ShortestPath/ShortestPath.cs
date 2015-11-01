namespace CoderbyteChallenges.Hard.ShortestPath
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShortestPath
    {
        // https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm

        private int _nodesCount;
        private Node[] _nodes;
        private Node _departure;
        private Node _arrival;
        private Link[] _links;

        public IEnumerable<string> Execute(params string[] parameters)
        {
            _nodesCount = int.Parse(parameters[0]);
            _nodes = ParseNodes(parameters).ToArray();
            _departure = _nodes.First();
            _arrival = _nodes.Last();
            _links = ParseLinks(parameters).ToArray();

            return Execute();
        }

        private IEnumerable<string> Execute()
        {
            var currentNode = _departure;
            currentNode.TentativeDistance = 0;
            MarkNodesUnvisitedExcept(currentNode);
            var visitedNodes = new List<Node>();

            do
            {
                var neighbours = GetNeighours(currentNode);
                foreach (var neighbour in neighbours)
                {
                    neighbour.TentativeDistance = new[] { neighbour.TentativeDistance, 1 }.Min(d => d);
                }

                visitedNodes.Add(currentNode);
                currentNode.Visited = true;

                currentNode = _nodes.Except(visitedNodes).OrderBy(n => n.TentativeDistance).FirstOrDefault();
                if (currentNode == null)
                {
                    break;
                }
            } 
            while (!_arrival.Visited);

            return visitedNodes
                .Where(n => n.TentativeDistance != int.MaxValue)
                .OrderBy(n => n.TentativeDistance)
                .Select(n => n.ToString());
        }

        private void MarkNodesUnvisitedExcept(Node node)
        {
            _nodes.Except(new[] { node }).ToList().ForEach(n => n.Visited = false);
        }

        private IEnumerable<Node> GetNeighours(Node node)
        {
            var lns = _links
                .Where(l => l.Start == node || l.End == node)
                .Select(l => l.Start == node ? l.End : l.Start);

            return _nodes.Where(lns.Contains);
        }

        private IEnumerable<Link> ParseLinks(IList<string> parameters)
        {
            for (var i = _nodesCount + 1; i < parameters.Count; i++)
            {
                yield return new Link(parameters[i]);
            }
        }

        private IEnumerable<Node> ParseNodes(IList<string> parameters)
        {
            for (var i = 1; i < _nodesCount + 1; i++)
            {
                yield return new Node(parameters[i]);
            }
        }

        private class Link
        {
            public Link(string linkStr)
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

        private class Node
        {
            public Node(string name)
            {
                Name = name;
                Visited = false;
                TentativeDistance = int.MaxValue;
            }

            public string Name { get; private set; }

            public bool Visited { get; set; }

            public int TentativeDistance { get; set; }

            public override string ToString()
            {
                return Name;
            }

            protected bool Equals(Node other)
            {
                return string.Equals(Name, other.Name);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                return obj.GetType() == GetType() && Equals((Node)obj);
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }

            public static bool operator ==(Node left, Node right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(Node left, Node right)
            {
                return !Equals(left, right);
            }
        }
    }
}
