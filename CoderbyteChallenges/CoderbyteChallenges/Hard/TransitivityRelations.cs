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
                return stringMatrixes
                    .Select(
                        line => 
                            line
                            .ToArrayOfStrings()
                            .Where(s => !RemovableChars.Contains(s))
                            .Select(int.Parse)
                            .ToArray()).ToArray();
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
