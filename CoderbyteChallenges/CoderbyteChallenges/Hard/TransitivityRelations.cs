namespace CoderbyteChallenges.Hard
{
    using System.Collections.Generic;
    using System.Linq;
    using Tools;

    public class TransitivityRelations
    {
        private static readonly string[] RemovableChars = { "(", ")", "," };

        public TransitivityRelationsResult Execute(params string[] stringMatrixes)
        {
            var matrix = new Matrix(stringMatrixes);

            throw new System.NotImplementedException();
        }

        private class Matrix
        {
            private readonly int[][] _members;

            public Matrix(params string[] stringMatrixes)
            {
                _members = Parse(stringMatrixes);
            }

            private static int[][] Parse(params string[] stringMatrixes)
            {
                var returnLines = new List<int[]>();
                foreach (var line in stringMatrixes)
                {
                    returnLines.Add(
                        line.ToArrayOfStrings()
                            .Where(s => !RemovableChars.Contains(s))
                            .Select(int.Parse).ToArray());
                }

                return returnLines.ToArray();
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
